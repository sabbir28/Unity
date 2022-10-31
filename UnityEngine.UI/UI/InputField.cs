using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000058 RID: 88
	[AddComponentMenu("UI/Input Field", 31)]
	public class InputField : Selectable, IUpdateSelectedHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement, IEventSystemHandler
	{
		// Token: 0x060002AD RID: 685 RVA: 0x0000F8EC File Offset: 0x0000DCEC
		protected InputField()
		{
			this.EnforceTextHOverflow();
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0000FA48 File Offset: 0x0000DE48
		private BaseInput input
		{
			get
			{
				BaseInput result;
				if (EventSystem.current && EventSystem.current.currentInputModule)
				{
					result = EventSystem.current.currentInputModule.input;
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002AF RID: 687 RVA: 0x0000FA98 File Offset: 0x0000DE98
		private string compositionString
		{
			get
			{
				return (!(this.input != null)) ? Input.compositionString : this.input.compositionString;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0000FAD4 File Offset: 0x0000DED4
		protected Mesh mesh
		{
			get
			{
				if (this.m_Mesh == null)
				{
					this.m_Mesh = new Mesh();
				}
				return this.m_Mesh;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x0000FB0C File Offset: 0x0000DF0C
		protected TextGenerator cachedInputTextGenerator
		{
			get
			{
				if (this.m_InputTextCache == null)
				{
					this.m_InputTextCache = new TextGenerator();
				}
				return this.m_InputTextCache;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x0000FB50 File Offset: 0x0000DF50
		// (set) Token: 0x060002B2 RID: 690 RVA: 0x0000FB3D File Offset: 0x0000DF3D
		public bool shouldHideMobileInput
		{
			get
			{
				RuntimePlatform platform = Application.platform;
				switch (platform)
				{
				case RuntimePlatform.IPhonePlayer:
				case RuntimePlatform.Android:
					break;
				default:
					if (platform != RuntimePlatform.TizenPlayer && platform != RuntimePlatform.tvOS)
					{
						return true;
					}
					break;
				}
				return this.m_HideMobileInput;
			}
			set
			{
				SetPropertyUtility.SetStruct<bool>(ref this.m_HideMobileInput, value);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000FBA8 File Offset: 0x0000DFA8
		private bool shouldActivateOnSelect
		{
			get
			{
				return Application.platform != RuntimePlatform.tvOS;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x0000FBCC File Offset: 0x0000DFCC
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x0000FBE8 File Offset: 0x0000DFE8
		public string text
		{
			get
			{
				return this.m_Text;
			}
			set
			{
				if (!(this.text == value))
				{
					if (value == null)
					{
						value = "";
					}
					value = value.Replace("\0", string.Empty);
					if (this.m_LineType == InputField.LineType.SingleLine)
					{
						value = value.Replace("\n", "").Replace("\t", "");
					}
					if (this.onValidateInput != null || this.characterValidation != InputField.CharacterValidation.None)
					{
						this.m_Text = "";
						InputField.OnValidateInput onValidateInput = this.onValidateInput ?? new InputField.OnValidateInput(this.Validate);
						this.m_CaretPosition = (this.m_CaretSelectPosition = value.Length);
						int num = (this.characterLimit <= 0) ? value.Length : Math.Min(this.characterLimit, value.Length);
						for (int i = 0; i < num; i++)
						{
							char c = onValidateInput(this.m_Text, this.m_Text.Length, value[i]);
							if (c != '\0')
							{
								this.m_Text += c;
							}
						}
					}
					else
					{
						this.m_Text = ((this.characterLimit <= 0 || value.Length <= this.characterLimit) ? value : value.Substring(0, this.characterLimit));
					}
					if (this.m_Keyboard != null)
					{
						this.m_Keyboard.text = this.m_Text;
					}
					if (this.m_CaretPosition > this.m_Text.Length)
					{
						this.m_CaretPosition = (this.m_CaretSelectPosition = this.m_Text.Length);
					}
					else if (this.m_CaretSelectPosition > this.m_Text.Length)
					{
						this.m_CaretSelectPosition = this.m_Text.Length;
					}
					this.SendOnValueChangedAndUpdateLabel();
				}
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x0000FDE0 File Offset: 0x0000E1E0
		public bool isFocused
		{
			get
			{
				return this.m_AllowInput;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x0000FDFC File Offset: 0x0000E1FC
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x0000FE17 File Offset: 0x0000E217
		public float caretBlinkRate
		{
			get
			{
				return this.m_CaretBlinkRate;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<float>(ref this.m_CaretBlinkRate, value))
				{
					if (this.m_AllowInput)
					{
						this.SetCaretActive();
					}
				}
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0000FE40 File Offset: 0x0000E240
		// (set) Token: 0x060002BB RID: 699 RVA: 0x0000FE5B File Offset: 0x0000E25B
		public int caretWidth
		{
			get
			{
				return this.m_CaretWidth;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<int>(ref this.m_CaretWidth, value))
				{
					this.MarkGeometryAsDirty();
				}
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0000FE78 File Offset: 0x0000E278
		// (set) Token: 0x060002BD RID: 701 RVA: 0x0000FE93 File Offset: 0x0000E293
		public Text textComponent
		{
			get
			{
				return this.m_TextComponent;
			}
			set
			{
				if (SetPropertyUtility.SetClass<Text>(ref this.m_TextComponent, value))
				{
					this.EnforceTextHOverflow();
				}
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002BE RID: 702 RVA: 0x0000FEB0 File Offset: 0x0000E2B0
		// (set) Token: 0x060002BF RID: 703 RVA: 0x0000FECB File Offset: 0x0000E2CB
		public Graphic placeholder
		{
			get
			{
				return this.m_Placeholder;
			}
			set
			{
				SetPropertyUtility.SetClass<Graphic>(ref this.m_Placeholder, value);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000FEDC File Offset: 0x0000E2DC
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x0000FF12 File Offset: 0x0000E312
		public Color caretColor
		{
			get
			{
				return (!this.customCaretColor) ? this.textComponent.color : this.m_CaretColor;
			}
			set
			{
				if (SetPropertyUtility.SetColor(ref this.m_CaretColor, value))
				{
					this.MarkGeometryAsDirty();
				}
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000FF2C File Offset: 0x0000E32C
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x0000FF47 File Offset: 0x0000E347
		public bool customCaretColor
		{
			get
			{
				return this.m_CustomCaretColor;
			}
			set
			{
				if (this.m_CustomCaretColor != value)
				{
					this.m_CustomCaretColor = value;
					this.MarkGeometryAsDirty();
				}
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x0000FF68 File Offset: 0x0000E368
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x0000FF83 File Offset: 0x0000E383
		public Color selectionColor
		{
			get
			{
				return this.m_SelectionColor;
			}
			set
			{
				if (SetPropertyUtility.SetColor(ref this.m_SelectionColor, value))
				{
					this.MarkGeometryAsDirty();
				}
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x0000FFA0 File Offset: 0x0000E3A0
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x0000FFBB File Offset: 0x0000E3BB
		public InputField.SubmitEvent onEndEdit
		{
			get
			{
				return this.m_OnEndEdit;
			}
			set
			{
				SetPropertyUtility.SetClass<InputField.SubmitEvent>(ref this.m_OnEndEdit, value);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x0000FFCC File Offset: 0x0000E3CC
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x0000FFE7 File Offset: 0x0000E3E7
		[Obsolete("onValueChange has been renamed to onValueChanged")]
		public InputField.OnChangeEvent onValueChange
		{
			get
			{
				return this.onValueChanged;
			}
			set
			{
				this.onValueChanged = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0000FFF4 File Offset: 0x0000E3F4
		// (set) Token: 0x060002CB RID: 715 RVA: 0x0001000F File Offset: 0x0000E40F
		public InputField.OnChangeEvent onValueChanged
		{
			get
			{
				return this.m_OnValueChanged;
			}
			set
			{
				SetPropertyUtility.SetClass<InputField.OnChangeEvent>(ref this.m_OnValueChanged, value);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00010020 File Offset: 0x0000E420
		// (set) Token: 0x060002CD RID: 717 RVA: 0x0001003B File Offset: 0x0000E43B
		public InputField.OnValidateInput onValidateInput
		{
			get
			{
				return this.m_OnValidateInput;
			}
			set
			{
				SetPropertyUtility.SetClass<InputField.OnValidateInput>(ref this.m_OnValidateInput, value);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002CE RID: 718 RVA: 0x0001004C File Offset: 0x0000E44C
		// (set) Token: 0x060002CF RID: 719 RVA: 0x00010067 File Offset: 0x0000E467
		public int characterLimit
		{
			get
			{
				return this.m_CharacterLimit;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<int>(ref this.m_CharacterLimit, Math.Max(0, value)))
				{
					this.UpdateLabel();
				}
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x00010088 File Offset: 0x0000E488
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x000100A3 File Offset: 0x0000E4A3
		public InputField.ContentType contentType
		{
			get
			{
				return this.m_ContentType;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<InputField.ContentType>(ref this.m_ContentType, value))
				{
					this.EnforceContentType();
				}
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x000100C0 File Offset: 0x0000E4C0
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x000100DB File Offset: 0x0000E4DB
		public InputField.LineType lineType
		{
			get
			{
				return this.m_LineType;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<InputField.LineType>(ref this.m_LineType, value))
				{
					this.SetToCustomIfContentTypeIsNot(new InputField.ContentType[]
					{
						InputField.ContentType.Standard,
						InputField.ContentType.Autocorrected
					});
					this.EnforceTextHOverflow();
				}
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x00010108 File Offset: 0x0000E508
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x00010123 File Offset: 0x0000E523
		public InputField.InputType inputType
		{
			get
			{
				return this.m_InputType;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<InputField.InputType>(ref this.m_InputType, value))
				{
					this.SetToCustom();
				}
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x00010140 File Offset: 0x0000E540
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x0001015B File Offset: 0x0000E55B
		public TouchScreenKeyboardType keyboardType
		{
			get
			{
				return this.m_KeyboardType;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<TouchScreenKeyboardType>(ref this.m_KeyboardType, value))
				{
					this.SetToCustom();
				}
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00010178 File Offset: 0x0000E578
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x00010193 File Offset: 0x0000E593
		public InputField.CharacterValidation characterValidation
		{
			get
			{
				return this.m_CharacterValidation;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<InputField.CharacterValidation>(ref this.m_CharacterValidation, value))
				{
					this.SetToCustom();
				}
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002DA RID: 730 RVA: 0x000101B0 File Offset: 0x0000E5B0
		// (set) Token: 0x060002DB RID: 731 RVA: 0x000101CB File Offset: 0x0000E5CB
		public bool readOnly
		{
			get
			{
				return this.m_ReadOnly;
			}
			set
			{
				this.m_ReadOnly = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002DC RID: 732 RVA: 0x000101D8 File Offset: 0x0000E5D8
		public bool multiLine
		{
			get
			{
				return this.m_LineType == InputField.LineType.MultiLineNewline || this.lineType == InputField.LineType.MultiLineSubmit;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002DD RID: 733 RVA: 0x00010208 File Offset: 0x0000E608
		// (set) Token: 0x060002DE RID: 734 RVA: 0x00010223 File Offset: 0x0000E623
		public char asteriskChar
		{
			get
			{
				return this.m_AsteriskChar;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<char>(ref this.m_AsteriskChar, value))
				{
					this.UpdateLabel();
				}
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002DF RID: 735 RVA: 0x00010240 File Offset: 0x0000E640
		public bool wasCanceled
		{
			get
			{
				return this.m_WasCanceled;
			}
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0001025B File Offset: 0x0000E65B
		protected void ClampPos(ref int pos)
		{
			if (pos < 0)
			{
				pos = 0;
			}
			else if (pos > this.text.Length)
			{
				pos = this.text.Length;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x00010290 File Offset: 0x0000E690
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x000102B7 File Offset: 0x0000E6B7
		protected int caretPositionInternal
		{
			get
			{
				return this.m_CaretPosition + this.compositionString.Length;
			}
			set
			{
				this.m_CaretPosition = value;
				this.ClampPos(ref this.m_CaretPosition);
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x000102D0 File Offset: 0x0000E6D0
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x000102F7 File Offset: 0x0000E6F7
		protected int caretSelectPositionInternal
		{
			get
			{
				return this.m_CaretSelectPosition + this.compositionString.Length;
			}
			set
			{
				this.m_CaretSelectPosition = value;
				this.ClampPos(ref this.m_CaretSelectPosition);
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00010310 File Offset: 0x0000E710
		private bool hasSelection
		{
			get
			{
				return this.caretPositionInternal != this.caretSelectPositionInternal;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x00010338 File Offset: 0x0000E738
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x0001035F File Offset: 0x0000E75F
		public int caretPosition
		{
			get
			{
				return this.m_CaretSelectPosition + this.compositionString.Length;
			}
			set
			{
				this.selectionAnchorPosition = value;
				this.selectionFocusPosition = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x00010370 File Offset: 0x0000E770
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x00010397 File Offset: 0x0000E797
		public int selectionAnchorPosition
		{
			get
			{
				return this.m_CaretPosition + this.compositionString.Length;
			}
			set
			{
				if (this.compositionString.Length == 0)
				{
					this.m_CaretPosition = value;
					this.ClampPos(ref this.m_CaretPosition);
				}
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002EA RID: 746 RVA: 0x000103C4 File Offset: 0x0000E7C4
		// (set) Token: 0x060002EB RID: 747 RVA: 0x000103EB File Offset: 0x0000E7EB
		public int selectionFocusPosition
		{
			get
			{
				return this.m_CaretSelectPosition + this.compositionString.Length;
			}
			set
			{
				if (this.compositionString.Length == 0)
				{
					this.m_CaretSelectPosition = value;
					this.ClampPos(ref this.m_CaretSelectPosition);
				}
			}
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00010418 File Offset: 0x0000E818
		protected override void OnEnable()
		{
			base.OnEnable();
			if (this.m_Text == null)
			{
				this.m_Text = string.Empty;
			}
			this.m_DrawStart = 0;
			this.m_DrawEnd = this.m_Text.Length;
			if (this.m_CachedInputRenderer != null)
			{
				this.m_CachedInputRenderer.SetMaterial(this.m_TextComponent.GetModifiedMaterial(Graphic.defaultGraphicMaterial), Texture2D.whiteTexture);
			}
			if (this.m_TextComponent != null)
			{
				this.m_TextComponent.RegisterDirtyVerticesCallback(new UnityAction(this.MarkGeometryAsDirty));
				this.m_TextComponent.RegisterDirtyVerticesCallback(new UnityAction(this.UpdateLabel));
				this.m_TextComponent.RegisterDirtyMaterialCallback(new UnityAction(this.UpdateCaretMaterial));
				this.UpdateLabel();
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x000104EC File Offset: 0x0000E8EC
		protected override void OnDisable()
		{
			this.m_BlinkCoroutine = null;
			this.DeactivateInputField();
			if (this.m_TextComponent != null)
			{
				this.m_TextComponent.UnregisterDirtyVerticesCallback(new UnityAction(this.MarkGeometryAsDirty));
				this.m_TextComponent.UnregisterDirtyVerticesCallback(new UnityAction(this.UpdateLabel));
				this.m_TextComponent.UnregisterDirtyMaterialCallback(new UnityAction(this.UpdateCaretMaterial));
			}
			CanvasUpdateRegistry.UnRegisterCanvasElementForRebuild(this);
			if (this.m_CachedInputRenderer != null)
			{
				this.m_CachedInputRenderer.Clear();
			}
			if (this.m_Mesh != null)
			{
				Object.DestroyImmediate(this.m_Mesh);
			}
			this.m_Mesh = null;
			base.OnDisable();
		}

		// Token: 0x060002EE RID: 750 RVA: 0x000105AC File Offset: 0x0000E9AC
		private IEnumerator CaretBlink()
		{
			this.m_CaretVisible = true;
			yield return null;
			while (this.isFocused && this.m_CaretBlinkRate > 0f)
			{
				float blinkPeriod = 1f / this.m_CaretBlinkRate;
				bool blinkState = (Time.unscaledTime - this.m_BlinkStartTime) % blinkPeriod < blinkPeriod / 2f;
				if (this.m_CaretVisible != blinkState)
				{
					this.m_CaretVisible = blinkState;
					if (!this.hasSelection)
					{
						this.MarkGeometryAsDirty();
					}
				}
				yield return null;
			}
			this.m_BlinkCoroutine = null;
			yield break;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x000105CE File Offset: 0x0000E9CE
		private void SetCaretVisible()
		{
			if (this.m_AllowInput)
			{
				this.m_CaretVisible = true;
				this.m_BlinkStartTime = Time.unscaledTime;
				this.SetCaretActive();
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000105FC File Offset: 0x0000E9FC
		private void SetCaretActive()
		{
			if (this.m_AllowInput)
			{
				if (this.m_CaretBlinkRate > 0f)
				{
					if (this.m_BlinkCoroutine == null)
					{
						this.m_BlinkCoroutine = base.StartCoroutine(this.CaretBlink());
					}
				}
				else
				{
					this.m_CaretVisible = true;
				}
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00010658 File Offset: 0x0000EA58
		private void UpdateCaretMaterial()
		{
			if (this.m_TextComponent != null && this.m_CachedInputRenderer != null)
			{
				this.m_CachedInputRenderer.SetMaterial(this.m_TextComponent.GetModifiedMaterial(Graphic.defaultGraphicMaterial), Texture2D.whiteTexture);
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x000106A8 File Offset: 0x0000EAA8
		protected void OnFocus()
		{
			this.SelectAll();
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x000106B1 File Offset: 0x0000EAB1
		protected void SelectAll()
		{
			this.caretPositionInternal = this.text.Length;
			this.caretSelectPositionInternal = 0;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000106CC File Offset: 0x0000EACC
		public void MoveTextEnd(bool shift)
		{
			int length = this.text.Length;
			if (shift)
			{
				this.caretSelectPositionInternal = length;
			}
			else
			{
				this.caretPositionInternal = length;
				this.caretSelectPositionInternal = this.caretPositionInternal;
			}
			this.UpdateLabel();
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00010718 File Offset: 0x0000EB18
		public void MoveTextStart(bool shift)
		{
			int num = 0;
			if (shift)
			{
				this.caretSelectPositionInternal = num;
			}
			else
			{
				this.caretPositionInternal = num;
				this.caretSelectPositionInternal = this.caretPositionInternal;
			}
			this.UpdateLabel();
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00010758 File Offset: 0x0000EB58
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x00010772 File Offset: 0x0000EB72
		private static string clipboard
		{
			get
			{
				return GUIUtility.systemCopyBuffer;
			}
			set
			{
				GUIUtility.systemCopyBuffer = value;
			}
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0001077C File Offset: 0x0000EB7C
		private bool InPlaceEditing()
		{
			return !TouchScreenKeyboard.isSupported;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0001079C File Offset: 0x0000EB9C
		private void UpdateCaretFromKeyboard()
		{
			RangeInt selection = this.m_Keyboard.selection;
			int start = selection.start;
			int end = selection.end;
			bool flag = false;
			if (this.caretPositionInternal != start)
			{
				flag = true;
				this.caretPositionInternal = start;
			}
			if (this.caretSelectPositionInternal != end)
			{
				this.caretSelectPositionInternal = end;
				flag = true;
			}
			if (flag)
			{
				this.m_BlinkStartTime = Time.unscaledTime;
				this.UpdateLabel();
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00010810 File Offset: 0x0000EC10
		protected virtual void LateUpdate()
		{
			if (this.m_ShouldActivateNextUpdate)
			{
				if (!this.isFocused)
				{
					this.ActivateInputFieldInternal();
					this.m_ShouldActivateNextUpdate = false;
					return;
				}
				this.m_ShouldActivateNextUpdate = false;
			}
			if (!this.InPlaceEditing() && this.isFocused)
			{
				this.AssignPositioningIfNeeded();
				if (this.m_Keyboard == null || this.m_Keyboard.done)
				{
					if (this.m_Keyboard != null)
					{
						if (!this.m_ReadOnly)
						{
							this.text = this.m_Keyboard.text;
						}
						if (this.m_Keyboard.wasCanceled)
						{
							this.m_WasCanceled = true;
						}
					}
					this.OnDeselect(null);
				}
				else
				{
					string text = this.m_Keyboard.text;
					if (this.m_Text != text)
					{
						if (this.m_ReadOnly)
						{
							this.m_Keyboard.text = this.m_Text;
						}
						else
						{
							this.m_Text = "";
							foreach (char c in text)
							{
								if (c == '\r' || c == '\u0003')
								{
									c = '\n';
								}
								if (this.onValidateInput != null)
								{
									c = this.onValidateInput(this.m_Text, this.m_Text.Length, c);
								}
								else if (this.characterValidation != InputField.CharacterValidation.None)
								{
									c = this.Validate(this.m_Text, this.m_Text.Length, c);
								}
								if (this.lineType == InputField.LineType.MultiLineSubmit && c == '\n')
								{
									this.m_Keyboard.text = this.m_Text;
									this.OnDeselect(null);
									return;
								}
								if (c != '\0')
								{
									this.m_Text += c;
								}
							}
							if (this.characterLimit > 0 && this.m_Text.Length > this.characterLimit)
							{
								this.m_Text = this.m_Text.Substring(0, this.characterLimit);
							}
							if (this.m_Keyboard.canGetSelection)
							{
								this.UpdateCaretFromKeyboard();
							}
							else
							{
								int length = this.m_Text.Length;
								this.caretSelectPositionInternal = length;
								this.caretPositionInternal = length;
							}
							if (this.m_Text != text)
							{
								this.m_Keyboard.text = this.m_Text;
							}
							this.SendOnValueChangedAndUpdateLabel();
						}
					}
					else if (this.m_Keyboard.canGetSelection)
					{
						this.UpdateCaretFromKeyboard();
					}
					if (this.m_Keyboard.done)
					{
						if (this.m_Keyboard.wasCanceled)
						{
							this.m_WasCanceled = true;
						}
						this.OnDeselect(null);
					}
				}
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00010AE4 File Offset: 0x0000EEE4
		[Obsolete("This function is no longer used. Please use RectTransformUtility.ScreenPointToLocalPointInRectangle() instead.")]
		public Vector2 ScreenToLocal(Vector2 screen)
		{
			Canvas canvas = this.m_TextComponent.canvas;
			Vector2 result;
			if (canvas == null)
			{
				result = screen;
			}
			else
			{
				Vector3 vector = Vector3.zero;
				if (canvas.renderMode == RenderMode.ScreenSpaceOverlay)
				{
					vector = this.m_TextComponent.transform.InverseTransformPoint(screen);
				}
				else if (canvas.worldCamera != null)
				{
					Ray ray = canvas.worldCamera.ScreenPointToRay(screen);
					Plane plane = new Plane(this.m_TextComponent.transform.forward, this.m_TextComponent.transform.position);
					float distance;
					plane.Raycast(ray, out distance);
					vector = this.m_TextComponent.transform.InverseTransformPoint(ray.GetPoint(distance));
				}
				result = new Vector2(vector.x, vector.y);
			}
			return result;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00010BCC File Offset: 0x0000EFCC
		private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator)
		{
			int result;
			if (!this.multiLine)
			{
				result = 0;
			}
			else
			{
				float num = pos.y * this.m_TextComponent.pixelsPerUnit;
				float num2 = 0f;
				int i = 0;
				while (i < generator.lineCount)
				{
					float topY = generator.lines[i].topY;
					float num3 = topY - (float)generator.lines[i].height;
					if (num > topY)
					{
						float num4 = topY - num2;
						if (num > topY - 0.5f * num4)
						{
							return i - 1;
						}
						return i;
					}
					else
					{
						if (num > num3)
						{
							return i;
						}
						num2 = num3;
						i++;
					}
				}
				result = generator.lineCount;
			}
			return result;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00010CA0 File Offset: 0x0000F0A0
		protected int GetCharacterIndexFromPosition(Vector2 pos)
		{
			TextGenerator cachedTextGenerator = this.m_TextComponent.cachedTextGenerator;
			int result;
			if (cachedTextGenerator.lineCount == 0)
			{
				result = 0;
			}
			else
			{
				int unclampedCharacterLineFromPosition = this.GetUnclampedCharacterLineFromPosition(pos, cachedTextGenerator);
				if (unclampedCharacterLineFromPosition < 0)
				{
					result = 0;
				}
				else if (unclampedCharacterLineFromPosition >= cachedTextGenerator.lineCount)
				{
					result = cachedTextGenerator.characterCountVisible;
				}
				else
				{
					int startCharIdx = cachedTextGenerator.lines[unclampedCharacterLineFromPosition].startCharIdx;
					int lineEndPosition = InputField.GetLineEndPosition(cachedTextGenerator, unclampedCharacterLineFromPosition);
					for (int i = startCharIdx; i < lineEndPosition; i++)
					{
						if (i >= cachedTextGenerator.characterCountVisible)
						{
							break;
						}
						UICharInfo uicharInfo = cachedTextGenerator.characters[i];
						Vector2 vector = uicharInfo.cursorPos / this.m_TextComponent.pixelsPerUnit;
						float num = pos.x - vector.x;
						float num2 = vector.x + uicharInfo.charWidth / this.m_TextComponent.pixelsPerUnit - pos.x;
						if (num < num2)
						{
							return i;
						}
					}
					result = lineEndPosition;
				}
			}
			return result;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00010DC0 File Offset: 0x0000F1C0
		private bool MayDrag(PointerEventData eventData)
		{
			return this.IsActive() && this.IsInteractable() && eventData.button == PointerEventData.InputButton.Left && this.m_TextComponent != null && this.m_Keyboard == null;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00010E13 File Offset: 0x0000F213
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
			if (this.MayDrag(eventData))
			{
				this.m_UpdateDrag = true;
			}
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00010E30 File Offset: 0x0000F230
		public virtual void OnDrag(PointerEventData eventData)
		{
			if (this.MayDrag(eventData))
			{
				Vector2 pos;
				RectTransformUtility.ScreenPointToLocalPointInRectangle(this.textComponent.rectTransform, eventData.position, eventData.pressEventCamera, out pos);
				this.caretSelectPositionInternal = this.GetCharacterIndexFromPosition(pos) + this.m_DrawStart;
				this.MarkGeometryAsDirty();
				this.m_DragPositionOutOfBounds = !RectTransformUtility.RectangleContainsScreenPoint(this.textComponent.rectTransform, eventData.position, eventData.pressEventCamera);
				if (this.m_DragPositionOutOfBounds && this.m_DragCoroutine == null)
				{
					this.m_DragCoroutine = base.StartCoroutine(this.MouseDragOutsideRect(eventData));
				}
				eventData.Use();
			}
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00010EDC File Offset: 0x0000F2DC
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData)
		{
			while (this.m_UpdateDrag && this.m_DragPositionOutOfBounds)
			{
				Vector2 localMousePos;
				RectTransformUtility.ScreenPointToLocalPointInRectangle(this.textComponent.rectTransform, eventData.position, eventData.pressEventCamera, out localMousePos);
				Rect rect = this.textComponent.rectTransform.rect;
				if (this.multiLine)
				{
					if (localMousePos.y > rect.yMax)
					{
						this.MoveUp(true, true);
					}
					else if (localMousePos.y < rect.yMin)
					{
						this.MoveDown(true, true);
					}
				}
				else if (localMousePos.x < rect.xMin)
				{
					this.MoveLeft(true, false);
				}
				else if (localMousePos.x > rect.xMax)
				{
					this.MoveRight(true, false);
				}
				this.UpdateLabel();
				float delay = (!this.multiLine) ? 0.05f : 0.1f;
				yield return new WaitForSecondsRealtime(delay);
			}
			this.m_DragCoroutine = null;
			yield break;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00010F05 File Offset: 0x0000F305
		public virtual void OnEndDrag(PointerEventData eventData)
		{
			if (this.MayDrag(eventData))
			{
				this.m_UpdateDrag = false;
			}
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00010F20 File Offset: 0x0000F320
		public override void OnPointerDown(PointerEventData eventData)
		{
			if (this.MayDrag(eventData))
			{
				EventSystem.current.SetSelectedGameObject(base.gameObject, eventData);
				bool allowInput = this.m_AllowInput;
				base.OnPointerDown(eventData);
				if (!this.InPlaceEditing())
				{
					if (this.m_Keyboard == null || !this.m_Keyboard.active)
					{
						this.OnSelect(eventData);
						return;
					}
				}
				if (allowInput)
				{
					Vector2 pos;
					RectTransformUtility.ScreenPointToLocalPointInRectangle(this.textComponent.rectTransform, eventData.position, eventData.pressEventCamera, out pos);
					int num = this.GetCharacterIndexFromPosition(pos) + this.m_DrawStart;
					this.caretPositionInternal = num;
					this.caretSelectPositionInternal = num;
				}
				this.UpdateLabel();
				eventData.Use();
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00010FE4 File Offset: 0x0000F3E4
		protected InputField.EditState KeyPressed(Event evt)
		{
			EventModifiers modifiers = evt.modifiers;
			bool flag = (SystemInfo.operatingSystemFamily != OperatingSystemFamily.MacOSX) ? ((modifiers & EventModifiers.Control) != EventModifiers.None) : ((modifiers & EventModifiers.Command) != EventModifiers.None);
			bool flag2 = (modifiers & EventModifiers.Shift) != EventModifiers.None;
			bool flag3 = (modifiers & EventModifiers.Alt) != EventModifiers.None;
			bool flag4 = flag && !flag3 && !flag2;
			KeyCode keyCode = evt.keyCode;
			switch (keyCode)
			{
			case KeyCode.KeypadEnter:
				break;
			default:
				switch (keyCode)
				{
				case KeyCode.A:
					if (flag4)
					{
						this.SelectAll();
						return InputField.EditState.Continue;
					}
					goto IL_24D;
				default:
					switch (keyCode)
					{
					case KeyCode.V:
						if (flag4)
						{
							this.Append(InputField.clipboard);
							return InputField.EditState.Continue;
						}
						goto IL_24D;
					default:
						if (keyCode == KeyCode.Backspace)
						{
							this.Backspace();
							return InputField.EditState.Continue;
						}
						if (keyCode != KeyCode.Return)
						{
							if (keyCode == KeyCode.Escape)
							{
								this.m_WasCanceled = true;
								return InputField.EditState.Finish;
							}
							if (keyCode != KeyCode.Delete)
							{
								goto IL_24D;
							}
							this.ForwardSpace();
							return InputField.EditState.Continue;
						}
						break;
					case KeyCode.X:
						if (flag4)
						{
							if (this.inputType != InputField.InputType.Password)
							{
								InputField.clipboard = this.GetSelectedString();
							}
							else
							{
								InputField.clipboard = "";
							}
							this.Delete();
							this.SendOnValueChangedAndUpdateLabel();
							return InputField.EditState.Continue;
						}
						goto IL_24D;
					}
					break;
				case KeyCode.C:
					if (flag4)
					{
						if (this.inputType != InputField.InputType.Password)
						{
							InputField.clipboard = this.GetSelectedString();
						}
						else
						{
							InputField.clipboard = "";
						}
						return InputField.EditState.Continue;
					}
					goto IL_24D;
				}
				break;
			case KeyCode.UpArrow:
				this.MoveUp(flag2);
				return InputField.EditState.Continue;
			case KeyCode.DownArrow:
				this.MoveDown(flag2);
				return InputField.EditState.Continue;
			case KeyCode.RightArrow:
				this.MoveRight(flag2, flag);
				return InputField.EditState.Continue;
			case KeyCode.LeftArrow:
				this.MoveLeft(flag2, flag);
				return InputField.EditState.Continue;
			case KeyCode.Home:
				this.MoveTextStart(flag2);
				return InputField.EditState.Continue;
			case KeyCode.End:
				this.MoveTextEnd(flag2);
				return InputField.EditState.Continue;
			}
			if (this.lineType != InputField.LineType.MultiLineNewline)
			{
				return InputField.EditState.Finish;
			}
			IL_24D:
			char c = evt.character;
			InputField.EditState result;
			if (!this.multiLine && (c == '\t' || c == '\r' || c == '\n'))
			{
				result = InputField.EditState.Continue;
			}
			else
			{
				if (c == '\r' || c == '\u0003')
				{
					c = '\n';
				}
				if (this.IsValidChar(c))
				{
					this.Append(c);
				}
				if (c == '\0')
				{
					if (this.compositionString.Length > 0)
					{
						this.UpdateLabel();
					}
				}
				result = InputField.EditState.Continue;
			}
			return result;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x000112CC File Offset: 0x0000F6CC
		private bool IsValidChar(char c)
		{
			return c != '\u007f' && (c == '\t' || c == '\n' || this.m_TextComponent.font.HasCharacter(c));
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00011318 File Offset: 0x0000F718
		public void ProcessEvent(Event e)
		{
			this.KeyPressed(e);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00011324 File Offset: 0x0000F724
		public virtual void OnUpdateSelected(BaseEventData eventData)
		{
			if (this.isFocused)
			{
				bool flag = false;
				while (Event.PopEvent(this.m_ProcessingEvent))
				{
					if (this.m_ProcessingEvent.rawType == EventType.KeyDown)
					{
						flag = true;
						InputField.EditState editState = this.KeyPressed(this.m_ProcessingEvent);
						if (editState == InputField.EditState.Finish)
						{
							this.DeactivateInputField();
							break;
						}
					}
					EventType type = this.m_ProcessingEvent.type;
					if (type == EventType.ValidateCommand || type == EventType.ExecuteCommand)
					{
						string commandName = this.m_ProcessingEvent.commandName;
						if (commandName != null)
						{
							if (commandName == "SelectAll")
							{
								this.SelectAll();
								flag = true;
							}
						}
					}
				}
				if (flag)
				{
					this.UpdateLabel();
				}
				eventData.Use();
			}
		}

		// Token: 0x06000308 RID: 776 RVA: 0x000113FC File Offset: 0x0000F7FC
		private string GetSelectedString()
		{
			string result;
			if (!this.hasSelection)
			{
				result = "";
			}
			else
			{
				int num = this.caretPositionInternal;
				int num2 = this.caretSelectPositionInternal;
				if (num > num2)
				{
					int num3 = num;
					num = num2;
					num2 = num3;
				}
				result = this.text.Substring(num, num2 - num);
			}
			return result;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00011454 File Offset: 0x0000F854
		private int FindtNextWordBegin()
		{
			int result;
			if (this.caretSelectPositionInternal + 1 >= this.text.Length)
			{
				result = this.text.Length;
			}
			else
			{
				int num = this.text.IndexOfAny(InputField.kSeparators, this.caretSelectPositionInternal + 1);
				if (num == -1)
				{
					num = this.text.Length;
				}
				else
				{
					num++;
				}
				result = num;
			}
			return result;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x000114C8 File Offset: 0x0000F8C8
		private void MoveRight(bool shift, bool ctrl)
		{
			if (this.hasSelection && !shift)
			{
				int num = Mathf.Max(this.caretPositionInternal, this.caretSelectPositionInternal);
				this.caretSelectPositionInternal = num;
				this.caretPositionInternal = num;
			}
			else
			{
				int num2;
				if (ctrl)
				{
					num2 = this.FindtNextWordBegin();
				}
				else
				{
					num2 = this.caretSelectPositionInternal + 1;
				}
				if (shift)
				{
					this.caretSelectPositionInternal = num2;
				}
				else
				{
					int num = num2;
					this.caretPositionInternal = num;
					this.caretSelectPositionInternal = num;
				}
			}
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0001154C File Offset: 0x0000F94C
		private int FindtPrevWordBegin()
		{
			int result;
			if (this.caretSelectPositionInternal - 2 < 0)
			{
				result = 0;
			}
			else
			{
				int num = this.text.LastIndexOfAny(InputField.kSeparators, this.caretSelectPositionInternal - 2);
				if (num == -1)
				{
					num = 0;
				}
				else
				{
					num++;
				}
				result = num;
			}
			return result;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x000115A4 File Offset: 0x0000F9A4
		private void MoveLeft(bool shift, bool ctrl)
		{
			if (this.hasSelection && !shift)
			{
				int num = Mathf.Min(this.caretPositionInternal, this.caretSelectPositionInternal);
				this.caretSelectPositionInternal = num;
				this.caretPositionInternal = num;
			}
			else
			{
				int num2;
				if (ctrl)
				{
					num2 = this.FindtPrevWordBegin();
				}
				else
				{
					num2 = this.caretSelectPositionInternal - 1;
				}
				if (shift)
				{
					this.caretSelectPositionInternal = num2;
				}
				else
				{
					int num = num2;
					this.caretPositionInternal = num;
					this.caretSelectPositionInternal = num;
				}
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00011628 File Offset: 0x0000FA28
		private int DetermineCharacterLine(int charPos, TextGenerator generator)
		{
			for (int i = 0; i < generator.lineCount - 1; i++)
			{
				if (generator.lines[i + 1].startCharIdx > charPos)
				{
					return i;
				}
			}
			return generator.lineCount - 1;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00011684 File Offset: 0x0000FA84
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			int result;
			if (originalPos >= this.cachedInputTextGenerator.characters.Count)
			{
				result = 0;
			}
			else
			{
				UICharInfo uicharInfo = this.cachedInputTextGenerator.characters[originalPos];
				int num = this.DetermineCharacterLine(originalPos, this.cachedInputTextGenerator);
				if (num <= 0)
				{
					result = ((!goToFirstChar) ? originalPos : 0);
				}
				else
				{
					int num2 = this.cachedInputTextGenerator.lines[num].startCharIdx - 1;
					for (int i = this.cachedInputTextGenerator.lines[num - 1].startCharIdx; i < num2; i++)
					{
						if (this.cachedInputTextGenerator.characters[i].cursorPos.x >= uicharInfo.cursorPos.x)
						{
							return i;
						}
					}
					result = num2;
				}
			}
			return result;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0001177C File Offset: 0x0000FB7C
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			int result;
			if (originalPos >= this.cachedInputTextGenerator.characterCountVisible)
			{
				result = this.text.Length;
			}
			else
			{
				UICharInfo uicharInfo = this.cachedInputTextGenerator.characters[originalPos];
				int num = this.DetermineCharacterLine(originalPos, this.cachedInputTextGenerator);
				if (num + 1 >= this.cachedInputTextGenerator.lineCount)
				{
					result = ((!goToLastChar) ? originalPos : this.text.Length);
				}
				else
				{
					int lineEndPosition = InputField.GetLineEndPosition(this.cachedInputTextGenerator, num + 1);
					for (int i = this.cachedInputTextGenerator.lines[num + 1].startCharIdx; i < lineEndPosition; i++)
					{
						if (this.cachedInputTextGenerator.characters[i].cursorPos.x >= uicharInfo.cursorPos.x)
						{
							return i;
						}
					}
					result = lineEndPosition;
				}
			}
			return result;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0001187F File Offset: 0x0000FC7F
		private void MoveDown(bool shift)
		{
			this.MoveDown(shift, true);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0001188C File Offset: 0x0000FC8C
		private void MoveDown(bool shift, bool goToLastChar)
		{
			if (this.hasSelection && !shift)
			{
				int num = Mathf.Max(this.caretPositionInternal, this.caretSelectPositionInternal);
				this.caretSelectPositionInternal = num;
				this.caretPositionInternal = num;
			}
			int num2 = (!this.multiLine) ? this.text.Length : this.LineDownCharacterPosition(this.caretSelectPositionInternal, goToLastChar);
			if (shift)
			{
				this.caretSelectPositionInternal = num2;
			}
			else
			{
				int num = num2;
				this.caretSelectPositionInternal = num;
				this.caretPositionInternal = num;
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00011918 File Offset: 0x0000FD18
		private void MoveUp(bool shift)
		{
			this.MoveUp(shift, true);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00011924 File Offset: 0x0000FD24
		private void MoveUp(bool shift, bool goToFirstChar)
		{
			if (this.hasSelection && !shift)
			{
				int num = Mathf.Min(this.caretPositionInternal, this.caretSelectPositionInternal);
				this.caretSelectPositionInternal = num;
				this.caretPositionInternal = num;
			}
			int num2 = (!this.multiLine) ? 0 : this.LineUpCharacterPosition(this.caretSelectPositionInternal, goToFirstChar);
			if (shift)
			{
				this.caretSelectPositionInternal = num2;
			}
			else
			{
				int num = num2;
				this.caretPositionInternal = num;
				this.caretSelectPositionInternal = num;
			}
		}

		// Token: 0x06000314 RID: 788 RVA: 0x000119A8 File Offset: 0x0000FDA8
		private void Delete()
		{
			if (!this.m_ReadOnly)
			{
				if (this.caretPositionInternal != this.caretSelectPositionInternal)
				{
					if (this.caretPositionInternal < this.caretSelectPositionInternal)
					{
						this.m_Text = this.text.Substring(0, this.caretPositionInternal) + this.text.Substring(this.caretSelectPositionInternal, this.text.Length - this.caretSelectPositionInternal);
						this.caretSelectPositionInternal = this.caretPositionInternal;
					}
					else
					{
						this.m_Text = this.text.Substring(0, this.caretSelectPositionInternal) + this.text.Substring(this.caretPositionInternal, this.text.Length - this.caretPositionInternal);
						this.caretPositionInternal = this.caretSelectPositionInternal;
					}
				}
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00011A90 File Offset: 0x0000FE90
		private void ForwardSpace()
		{
			if (!this.m_ReadOnly)
			{
				if (this.hasSelection)
				{
					this.Delete();
					this.SendOnValueChangedAndUpdateLabel();
				}
				else if (this.caretPositionInternal < this.text.Length)
				{
					this.m_Text = this.text.Remove(this.caretPositionInternal, 1);
					this.SendOnValueChangedAndUpdateLabel();
				}
			}
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00011B04 File Offset: 0x0000FF04
		private void Backspace()
		{
			if (!this.m_ReadOnly)
			{
				if (this.hasSelection)
				{
					this.Delete();
					this.SendOnValueChangedAndUpdateLabel();
				}
				else if (this.caretPositionInternal > 0)
				{
					this.m_Text = this.text.Remove(this.caretPositionInternal - 1, 1);
					int num = this.caretPositionInternal - 1;
					this.caretPositionInternal = num;
					this.caretSelectPositionInternal = num;
					this.SendOnValueChangedAndUpdateLabel();
				}
			}
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00011B88 File Offset: 0x0000FF88
		private void Insert(char c)
		{
			if (!this.m_ReadOnly)
			{
				string text = c.ToString();
				this.Delete();
				if (this.characterLimit <= 0 || this.text.Length < this.characterLimit)
				{
					this.m_Text = this.text.Insert(this.m_CaretPosition, text);
					this.caretSelectPositionInternal = (this.caretPositionInternal += text.Length);
					this.SendOnValueChanged();
				}
			}
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00011C1B File Offset: 0x0001001B
		private void SendOnValueChangedAndUpdateLabel()
		{
			this.SendOnValueChanged();
			this.UpdateLabel();
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00011C2A File Offset: 0x0001002A
		private void SendOnValueChanged()
		{
			if (this.onValueChanged != null)
			{
				this.onValueChanged.Invoke(this.text);
			}
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00011C49 File Offset: 0x00010049
		protected void SendOnSubmit()
		{
			if (this.onEndEdit != null)
			{
				this.onEndEdit.Invoke(this.m_Text);
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00011C68 File Offset: 0x00010068
		protected virtual void Append(string input)
		{
			if (!this.m_ReadOnly)
			{
				if (this.InPlaceEditing())
				{
					int i = 0;
					int length = input.Length;
					while (i < length)
					{
						char c = input[i];
						if (c >= ' ' || c == '\t' || c == '\r' || c == '\n' || c == '\n')
						{
							this.Append(c);
						}
						i++;
					}
				}
			}
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00011CEC File Offset: 0x000100EC
		protected virtual void Append(char input)
		{
			if (!this.m_ReadOnly)
			{
				if (this.InPlaceEditing())
				{
					int num = Math.Min(this.selectionFocusPosition, this.selectionAnchorPosition);
					if (this.onValidateInput != null)
					{
						input = this.onValidateInput(this.text, num, input);
					}
					else if (this.characterValidation != InputField.CharacterValidation.None)
					{
						input = this.Validate(this.text, num, input);
					}
					if (input != '\0')
					{
						this.Insert(input);
					}
				}
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00011D80 File Offset: 0x00010180
		protected void UpdateLabel()
		{
			if (this.m_TextComponent != null && this.m_TextComponent.font != null && !this.m_PreventFontCallback)
			{
				this.m_PreventFontCallback = true;
				string text;
				if (this.compositionString.Length > 0)
				{
					text = this.text.Substring(0, this.m_CaretPosition) + this.compositionString + this.text.Substring(this.m_CaretPosition);
				}
				else
				{
					text = this.text;
				}
				string text2;
				if (this.inputType == InputField.InputType.Password)
				{
					text2 = new string(this.asteriskChar, text.Length);
				}
				else
				{
					text2 = text;
				}
				bool flag = string.IsNullOrEmpty(text);
				if (this.m_Placeholder != null)
				{
					this.m_Placeholder.enabled = flag;
				}
				if (!this.m_AllowInput)
				{
					this.m_DrawStart = 0;
					this.m_DrawEnd = this.m_Text.Length;
				}
				if (!flag)
				{
					Vector2 size = this.m_TextComponent.rectTransform.rect.size;
					TextGenerationSettings generationSettings = this.m_TextComponent.GetGenerationSettings(size);
					generationSettings.generateOutOfBounds = true;
					this.cachedInputTextGenerator.PopulateWithErrors(text2, generationSettings, base.gameObject);
					this.SetDrawRangeToContainCaretPosition(this.caretSelectPositionInternal);
					text2 = text2.Substring(this.m_DrawStart, Mathf.Min(this.m_DrawEnd, text2.Length) - this.m_DrawStart);
					this.SetCaretVisible();
				}
				this.m_TextComponent.text = text2;
				this.MarkGeometryAsDirty();
				this.m_PreventFontCallback = false;
			}
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00011F20 File Offset: 0x00010320
		private bool IsSelectionVisible()
		{
			return this.m_DrawStart <= this.caretPositionInternal && this.m_DrawStart <= this.caretSelectPositionInternal && this.m_DrawEnd >= this.caretPositionInternal && this.m_DrawEnd >= this.caretSelectPositionInternal;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00011F88 File Offset: 0x00010388
		private static int GetLineStartPosition(TextGenerator gen, int line)
		{
			line = Mathf.Clamp(line, 0, gen.lines.Count - 1);
			return gen.lines[line].startCharIdx;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00011FC8 File Offset: 0x000103C8
		private static int GetLineEndPosition(TextGenerator gen, int line)
		{
			line = Mathf.Max(line, 0);
			int result;
			if (line + 1 < gen.lines.Count)
			{
				result = gen.lines[line + 1].startCharIdx - 1;
			}
			else
			{
				result = gen.characterCountVisible;
			}
			return result;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00012020 File Offset: 0x00010420
		private void SetDrawRangeToContainCaretPosition(int caretPos)
		{
			if (this.cachedInputTextGenerator.lineCount > 0)
			{
				Vector2 size = this.cachedInputTextGenerator.rectExtents.size;
				if (this.multiLine)
				{
					IList<UILineInfo> lines = this.cachedInputTextGenerator.lines;
					int num = this.DetermineCharacterLine(caretPos, this.cachedInputTextGenerator);
					if (caretPos > this.m_DrawEnd)
					{
						this.m_DrawEnd = InputField.GetLineEndPosition(this.cachedInputTextGenerator, num);
						float num2 = lines[num].topY - (float)lines[num].height;
						if (num == lines.Count - 1)
						{
							num2 += lines[num].leading;
						}
						int i;
						for (i = num; i > 0; i--)
						{
							float topY = lines[i - 1].topY;
							if (topY - num2 > size.y)
							{
								break;
							}
						}
						this.m_DrawStart = InputField.GetLineStartPosition(this.cachedInputTextGenerator, i);
					}
					else
					{
						if (caretPos < this.m_DrawStart)
						{
							this.m_DrawStart = InputField.GetLineStartPosition(this.cachedInputTextGenerator, num);
						}
						int j = this.DetermineCharacterLine(this.m_DrawStart, this.cachedInputTextGenerator);
						int k = j;
						float topY2 = lines[j].topY;
						float num3 = lines[k].topY - (float)lines[k].height;
						if (k == lines.Count - 1)
						{
							num3 += lines[k].leading;
						}
						while (k < lines.Count - 1)
						{
							num3 = lines[k + 1].topY - (float)lines[k + 1].height;
							if (k + 1 == lines.Count - 1)
							{
								num3 += lines[k + 1].leading;
							}
							if (topY2 - num3 > size.y)
							{
								break;
							}
							k++;
						}
						this.m_DrawEnd = InputField.GetLineEndPosition(this.cachedInputTextGenerator, k);
						while (j > 0)
						{
							topY2 = lines[j - 1].topY;
							if (topY2 - num3 > size.y)
							{
								break;
							}
							j--;
						}
						this.m_DrawStart = InputField.GetLineStartPosition(this.cachedInputTextGenerator, j);
					}
				}
				else
				{
					IList<UICharInfo> characters = this.cachedInputTextGenerator.characters;
					if (this.m_DrawEnd > this.cachedInputTextGenerator.characterCountVisible)
					{
						this.m_DrawEnd = this.cachedInputTextGenerator.characterCountVisible;
					}
					float num4 = 0f;
					if (caretPos > this.m_DrawEnd || (caretPos == this.m_DrawEnd && this.m_DrawStart > 0))
					{
						this.m_DrawEnd = caretPos;
						this.m_DrawStart = this.m_DrawEnd - 1;
						while (this.m_DrawStart >= 0)
						{
							if (num4 + characters[this.m_DrawStart].charWidth > size.x)
							{
								break;
							}
							num4 += characters[this.m_DrawStart].charWidth;
							this.m_DrawStart--;
						}
						this.m_DrawStart++;
					}
					else
					{
						if (caretPos < this.m_DrawStart)
						{
							this.m_DrawStart = caretPos;
						}
						this.m_DrawEnd = this.m_DrawStart;
					}
					while (this.m_DrawEnd < this.cachedInputTextGenerator.characterCountVisible)
					{
						num4 += characters[this.m_DrawEnd].charWidth;
						if (num4 > size.x)
						{
							break;
						}
						this.m_DrawEnd++;
					}
				}
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0001243A File Offset: 0x0001083A
		public void ForceLabelUpdate()
		{
			this.UpdateLabel();
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00012443 File Offset: 0x00010843
		private void MarkGeometryAsDirty()
		{
			CanvasUpdateRegistry.RegisterCanvasElementForGraphicRebuild(this);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0001244C File Offset: 0x0001084C
		public virtual void Rebuild(CanvasUpdate update)
		{
			if (update == CanvasUpdate.LatePreRender)
			{
				this.UpdateGeometry();
			}
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00012466 File Offset: 0x00010866
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00012469 File Offset: 0x00010869
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0001246C File Offset: 0x0001086C
		private void UpdateGeometry()
		{
			if (this.shouldHideMobileInput)
			{
				if (this.m_CachedInputRenderer == null && this.m_TextComponent != null)
				{
					GameObject gameObject = new GameObject(base.transform.name + " Input Caret", new Type[]
					{
						typeof(RectTransform),
						typeof(CanvasRenderer)
					});
					gameObject.hideFlags = HideFlags.DontSave;
					gameObject.transform.SetParent(this.m_TextComponent.transform.parent);
					gameObject.transform.SetAsFirstSibling();
					gameObject.layer = base.gameObject.layer;
					this.caretRectTrans = gameObject.GetComponent<RectTransform>();
					this.m_CachedInputRenderer = gameObject.GetComponent<CanvasRenderer>();
					this.m_CachedInputRenderer.SetMaterial(this.m_TextComponent.GetModifiedMaterial(Graphic.defaultGraphicMaterial), Texture2D.whiteTexture);
					gameObject.AddComponent<LayoutElement>().ignoreLayout = true;
					this.AssignPositioningIfNeeded();
				}
				if (!(this.m_CachedInputRenderer == null))
				{
					this.OnFillVBO(this.mesh);
					this.m_CachedInputRenderer.SetMesh(this.mesh);
				}
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000125A8 File Offset: 0x000109A8
		private void AssignPositioningIfNeeded()
		{
			if (this.m_TextComponent != null && this.caretRectTrans != null && (this.caretRectTrans.localPosition != this.m_TextComponent.rectTransform.localPosition || this.caretRectTrans.localRotation != this.m_TextComponent.rectTransform.localRotation || this.caretRectTrans.localScale != this.m_TextComponent.rectTransform.localScale || this.caretRectTrans.anchorMin != this.m_TextComponent.rectTransform.anchorMin || this.caretRectTrans.anchorMax != this.m_TextComponent.rectTransform.anchorMax || this.caretRectTrans.anchoredPosition != this.m_TextComponent.rectTransform.anchoredPosition || this.caretRectTrans.sizeDelta != this.m_TextComponent.rectTransform.sizeDelta || this.caretRectTrans.pivot != this.m_TextComponent.rectTransform.pivot))
			{
				this.caretRectTrans.localPosition = this.m_TextComponent.rectTransform.localPosition;
				this.caretRectTrans.localRotation = this.m_TextComponent.rectTransform.localRotation;
				this.caretRectTrans.localScale = this.m_TextComponent.rectTransform.localScale;
				this.caretRectTrans.anchorMin = this.m_TextComponent.rectTransform.anchorMin;
				this.caretRectTrans.anchorMax = this.m_TextComponent.rectTransform.anchorMax;
				this.caretRectTrans.anchoredPosition = this.m_TextComponent.rectTransform.anchoredPosition;
				this.caretRectTrans.sizeDelta = this.m_TextComponent.rectTransform.sizeDelta;
				this.caretRectTrans.pivot = this.m_TextComponent.rectTransform.pivot;
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x000127DC File Offset: 0x00010BDC
		private void OnFillVBO(Mesh vbo)
		{
			using (VertexHelper vertexHelper = new VertexHelper())
			{
				if (!this.isFocused)
				{
					vertexHelper.FillMesh(vbo);
				}
				else
				{
					Vector2 roundingOffset = this.m_TextComponent.PixelAdjustPoint(Vector2.zero);
					if (!this.hasSelection)
					{
						this.GenerateCaret(vertexHelper, roundingOffset);
					}
					else
					{
						this.GenerateHightlight(vertexHelper, roundingOffset);
					}
					vertexHelper.FillMesh(vbo);
				}
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00012864 File Offset: 0x00010C64
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset)
		{
			if (this.m_CaretVisible)
			{
				if (this.m_CursorVerts == null)
				{
					this.CreateCursorVerts();
				}
				float num = (float)this.m_CaretWidth;
				int num2 = Mathf.Max(0, this.caretPositionInternal - this.m_DrawStart);
				TextGenerator cachedTextGenerator = this.m_TextComponent.cachedTextGenerator;
				if (cachedTextGenerator != null)
				{
					if (cachedTextGenerator.lineCount != 0)
					{
						Vector2 zero = Vector2.zero;
						if (num2 < cachedTextGenerator.characters.Count)
						{
							zero.x = cachedTextGenerator.characters[num2].cursorPos.x;
						}
						zero.x /= this.m_TextComponent.pixelsPerUnit;
						if (zero.x > this.m_TextComponent.rectTransform.rect.xMax)
						{
							zero.x = this.m_TextComponent.rectTransform.rect.xMax;
						}
						int index = this.DetermineCharacterLine(num2, cachedTextGenerator);
						zero.y = cachedTextGenerator.lines[index].topY / this.m_TextComponent.pixelsPerUnit;
						float num3 = (float)cachedTextGenerator.lines[index].height / this.m_TextComponent.pixelsPerUnit;
						for (int i = 0; i < this.m_CursorVerts.Length; i++)
						{
							this.m_CursorVerts[i].color = this.caretColor;
						}
						this.m_CursorVerts[0].position = new Vector3(zero.x, zero.y - num3, 0f);
						this.m_CursorVerts[1].position = new Vector3(zero.x + num, zero.y - num3, 0f);
						this.m_CursorVerts[2].position = new Vector3(zero.x + num, zero.y, 0f);
						this.m_CursorVerts[3].position = new Vector3(zero.x, zero.y, 0f);
						if (roundingOffset != Vector2.zero)
						{
							for (int j = 0; j < this.m_CursorVerts.Length; j++)
							{
								UIVertex uivertex = this.m_CursorVerts[j];
								uivertex.position.x = uivertex.position.x + roundingOffset.x;
								uivertex.position.y = uivertex.position.y + roundingOffset.y;
							}
						}
						vbo.AddUIVertexQuad(this.m_CursorVerts);
						int num4 = Screen.height;
						int targetDisplay = this.m_TextComponent.canvas.targetDisplay;
						if (targetDisplay > 0 && targetDisplay < Display.displays.Length)
						{
							num4 = Display.displays[targetDisplay].renderingHeight;
						}
						zero.y = (float)num4 - zero.y;
						this.input.compositionCursorPos = zero;
					}
				}
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00012B94 File Offset: 0x00010F94
		private void CreateCursorVerts()
		{
			this.m_CursorVerts = new UIVertex[4];
			for (int i = 0; i < this.m_CursorVerts.Length; i++)
			{
				this.m_CursorVerts[i] = UIVertex.simpleVert;
				this.m_CursorVerts[i].uv0 = Vector2.zero;
			}
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00012BF8 File Offset: 0x00010FF8
		private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset)
		{
			int num = Mathf.Max(0, this.caretPositionInternal - this.m_DrawStart);
			int num2 = Mathf.Max(0, this.caretSelectPositionInternal - this.m_DrawStart);
			if (num > num2)
			{
				int num3 = num;
				num = num2;
				num2 = num3;
			}
			num2--;
			TextGenerator cachedTextGenerator = this.m_TextComponent.cachedTextGenerator;
			if (cachedTextGenerator.lineCount > 0)
			{
				int num4 = this.DetermineCharacterLine(num, cachedTextGenerator);
				int lineEndPosition = InputField.GetLineEndPosition(cachedTextGenerator, num4);
				UIVertex simpleVert = UIVertex.simpleVert;
				simpleVert.uv0 = Vector2.zero;
				simpleVert.color = this.selectionColor;
				int num5 = num;
				while (num5 <= num2 && num5 < cachedTextGenerator.characterCount)
				{
					if (num5 == lineEndPosition || num5 == num2)
					{
						UICharInfo uicharInfo = cachedTextGenerator.characters[num];
						UICharInfo uicharInfo2 = cachedTextGenerator.characters[num5];
						Vector2 vector = new Vector2(uicharInfo.cursorPos.x / this.m_TextComponent.pixelsPerUnit, cachedTextGenerator.lines[num4].topY / this.m_TextComponent.pixelsPerUnit);
						Vector2 vector2 = new Vector2((uicharInfo2.cursorPos.x + uicharInfo2.charWidth) / this.m_TextComponent.pixelsPerUnit, vector.y - (float)cachedTextGenerator.lines[num4].height / this.m_TextComponent.pixelsPerUnit);
						if (vector2.x > this.m_TextComponent.rectTransform.rect.xMax || vector2.x < this.m_TextComponent.rectTransform.rect.xMin)
						{
							vector2.x = this.m_TextComponent.rectTransform.rect.xMax;
						}
						int currentVertCount = vbo.currentVertCount;
						simpleVert.position = new Vector3(vector.x, vector2.y, 0f) + roundingOffset;
						vbo.AddVert(simpleVert);
						simpleVert.position = new Vector3(vector2.x, vector2.y, 0f) + roundingOffset;
						vbo.AddVert(simpleVert);
						simpleVert.position = new Vector3(vector2.x, vector.y, 0f) + roundingOffset;
						vbo.AddVert(simpleVert);
						simpleVert.position = new Vector3(vector.x, vector.y, 0f) + roundingOffset;
						vbo.AddVert(simpleVert);
						vbo.AddTriangle(currentVertCount, currentVertCount + 1, currentVertCount + 2);
						vbo.AddTriangle(currentVertCount + 2, currentVertCount + 3, currentVertCount);
						num = num5 + 1;
						num4++;
						lineEndPosition = InputField.GetLineEndPosition(cachedTextGenerator, num4);
					}
					num5++;
				}
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00012EF0 File Offset: 0x000112F0
		protected char Validate(string text, int pos, char ch)
		{
			char result;
			if (this.characterValidation == InputField.CharacterValidation.None || !base.enabled)
			{
				result = ch;
			}
			else
			{
				if (this.characterValidation == InputField.CharacterValidation.Integer || this.characterValidation == InputField.CharacterValidation.Decimal)
				{
					bool flag = pos == 0 && text.Length > 0 && text[0] == '-';
					bool flag2 = this.caretPositionInternal == 0 || this.caretSelectPositionInternal == 0;
					if (!flag)
					{
						if (ch >= '0' && ch <= '9')
						{
							return ch;
						}
						if (ch == '-' && (pos == 0 || flag2))
						{
							return ch;
						}
						if (ch == '.' && this.characterValidation == InputField.CharacterValidation.Decimal && !text.Contains("."))
						{
							return ch;
						}
					}
				}
				else if (this.characterValidation == InputField.CharacterValidation.Alphanumeric)
				{
					if (ch >= 'A' && ch <= 'Z')
					{
						return ch;
					}
					if (ch >= 'a' && ch <= 'z')
					{
						return ch;
					}
					if (ch >= '0' && ch <= '9')
					{
						return ch;
					}
				}
				else if (this.characterValidation == InputField.CharacterValidation.Name)
				{
					if (char.IsLetter(ch))
					{
						if (char.IsLower(ch) && (pos == 0 || text[pos - 1] == ' '))
						{
							return char.ToUpper(ch);
						}
						if (char.IsUpper(ch) && pos > 0 && text[pos - 1] != ' ' && text[pos - 1] != '\'')
						{
							return char.ToLower(ch);
						}
						return ch;
					}
					else
					{
						if (ch == '\'')
						{
							if (!text.Contains("'") && (pos <= 0 || (text[pos - 1] != ' ' && text[pos - 1] != '\'')) && (pos >= text.Length || (text[pos] != ' ' && text[pos] != '\'')))
							{
								return ch;
							}
						}
						if (ch == ' ')
						{
							if ((pos <= 0 || (text[pos - 1] != ' ' && text[pos - 1] != '\'')) && (pos >= text.Length || (text[pos] != ' ' && text[pos] != '\'')))
							{
								return ch;
							}
						}
					}
				}
				else if (this.characterValidation == InputField.CharacterValidation.EmailAddress)
				{
					if (ch >= 'A' && ch <= 'Z')
					{
						return ch;
					}
					if (ch >= 'a' && ch <= 'z')
					{
						return ch;
					}
					if (ch >= '0' && ch <= '9')
					{
						return ch;
					}
					if (ch == '@' && text.IndexOf('@') == -1)
					{
						return ch;
					}
					if ("!#$%&'*+-/=?^_`{|}~".IndexOf(ch) != -1)
					{
						return ch;
					}
					if (ch == '.')
					{
						char c = (text.Length <= 0) ? ' ' : text[Mathf.Clamp(pos, 0, text.Length - 1)];
						char c2 = (text.Length <= 0) ? '\n' : text[Mathf.Clamp(pos + 1, 0, text.Length - 1)];
						if (c != '.' && c2 != '.')
						{
							return ch;
						}
					}
				}
				result = '\0';
			}
			return result;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0001329C File Offset: 0x0001169C
		public void ActivateInputField()
		{
			if (!(this.m_TextComponent == null) && !(this.m_TextComponent.font == null) && this.IsActive() && this.IsInteractable())
			{
				if (this.isFocused)
				{
					if (this.m_Keyboard != null && !this.m_Keyboard.active)
					{
						this.m_Keyboard.active = true;
						this.m_Keyboard.text = this.m_Text;
					}
				}
				this.m_ShouldActivateNextUpdate = true;
			}
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0001333C File Offset: 0x0001173C
		private void ActivateInputFieldInternal()
		{
			if (!(EventSystem.current == null))
			{
				if (EventSystem.current.currentSelectedGameObject != base.gameObject)
				{
					EventSystem.current.SetSelectedGameObject(base.gameObject);
				}
				if (TouchScreenKeyboard.isSupported)
				{
					if (this.input.touchSupported)
					{
						TouchScreenKeyboard.hideInput = this.shouldHideMobileInput;
					}
					this.m_Keyboard = ((this.inputType != InputField.InputType.Password) ? TouchScreenKeyboard.Open(this.m_Text, this.keyboardType, this.inputType == InputField.InputType.AutoCorrect, this.multiLine) : TouchScreenKeyboard.Open(this.m_Text, this.keyboardType, false, this.multiLine, true));
					this.MoveTextEnd(false);
				}
				else
				{
					this.input.imeCompositionMode = IMECompositionMode.On;
					this.OnFocus();
				}
				this.m_AllowInput = true;
				this.m_OriginalText = this.text;
				this.m_WasCanceled = false;
				this.SetCaretVisible();
				this.UpdateLabel();
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00013448 File Offset: 0x00011848
		public override void OnSelect(BaseEventData eventData)
		{
			base.OnSelect(eventData);
			if (this.shouldActivateOnSelect)
			{
				this.ActivateInputField();
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00013463 File Offset: 0x00011863
		public virtual void OnPointerClick(PointerEventData eventData)
		{
			if (eventData.button == PointerEventData.InputButton.Left)
			{
				this.ActivateInputField();
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0001347C File Offset: 0x0001187C
		public void DeactivateInputField()
		{
			if (this.m_AllowInput)
			{
				this.m_HasDoneFocusTransition = false;
				this.m_AllowInput = false;
				if (this.m_Placeholder != null)
				{
					this.m_Placeholder.enabled = string.IsNullOrEmpty(this.m_Text);
				}
				if (this.m_TextComponent != null && this.IsInteractable())
				{
					if (this.m_WasCanceled)
					{
						this.text = this.m_OriginalText;
					}
					if (this.m_Keyboard != null)
					{
						this.m_Keyboard.active = false;
						this.m_Keyboard = null;
					}
					this.m_CaretPosition = (this.m_CaretSelectPosition = 0);
					this.SendOnSubmit();
					this.input.imeCompositionMode = IMECompositionMode.Auto;
				}
				this.MarkGeometryAsDirty();
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0001354C File Offset: 0x0001194C
		public override void OnDeselect(BaseEventData eventData)
		{
			this.DeactivateInputField();
			base.OnDeselect(eventData);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0001355C File Offset: 0x0001195C
		public virtual void OnSubmit(BaseEventData eventData)
		{
			if (this.IsActive() && this.IsInteractable())
			{
				if (!this.isFocused)
				{
					this.m_ShouldActivateNextUpdate = true;
				}
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0001358C File Offset: 0x0001198C
		private void EnforceContentType()
		{
			switch (this.contentType)
			{
			case InputField.ContentType.Standard:
				this.m_InputType = InputField.InputType.Standard;
				this.m_KeyboardType = TouchScreenKeyboardType.Default;
				this.m_CharacterValidation = InputField.CharacterValidation.None;
				break;
			case InputField.ContentType.Autocorrected:
				this.m_InputType = InputField.InputType.AutoCorrect;
				this.m_KeyboardType = TouchScreenKeyboardType.Default;
				this.m_CharacterValidation = InputField.CharacterValidation.None;
				break;
			case InputField.ContentType.IntegerNumber:
				this.m_LineType = InputField.LineType.SingleLine;
				this.m_InputType = InputField.InputType.Standard;
				this.m_KeyboardType = TouchScreenKeyboardType.NumberPad;
				this.m_CharacterValidation = InputField.CharacterValidation.Integer;
				break;
			case InputField.ContentType.DecimalNumber:
				this.m_LineType = InputField.LineType.SingleLine;
				this.m_InputType = InputField.InputType.Standard;
				this.m_KeyboardType = TouchScreenKeyboardType.NumbersAndPunctuation;
				this.m_CharacterValidation = InputField.CharacterValidation.Decimal;
				break;
			case InputField.ContentType.Alphanumeric:
				this.m_LineType = InputField.LineType.SingleLine;
				this.m_InputType = InputField.InputType.Standard;
				this.m_KeyboardType = TouchScreenKeyboardType.ASCIICapable;
				this.m_CharacterValidation = InputField.CharacterValidation.Alphanumeric;
				break;
			case InputField.ContentType.Name:
				this.m_LineType = InputField.LineType.SingleLine;
				this.m_InputType = InputField.InputType.Standard;
				this.m_KeyboardType = TouchScreenKeyboardType.Default;
				this.m_CharacterValidation = InputField.CharacterValidation.Name;
				break;
			case InputField.ContentType.EmailAddress:
				this.m_LineType = InputField.LineType.SingleLine;
				this.m_InputType = InputField.InputType.Standard;
				this.m_KeyboardType = TouchScreenKeyboardType.EmailAddress;
				this.m_CharacterValidation = InputField.CharacterValidation.EmailAddress;
				break;
			case InputField.ContentType.Password:
				this.m_LineType = InputField.LineType.SingleLine;
				this.m_InputType = InputField.InputType.Password;
				this.m_KeyboardType = TouchScreenKeyboardType.Default;
				this.m_CharacterValidation = InputField.CharacterValidation.None;
				break;
			case InputField.ContentType.Pin:
				this.m_LineType = InputField.LineType.SingleLine;
				this.m_InputType = InputField.InputType.Password;
				this.m_KeyboardType = TouchScreenKeyboardType.NumberPad;
				this.m_CharacterValidation = InputField.CharacterValidation.Integer;
				break;
			}
			this.EnforceTextHOverflow();
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00013700 File Offset: 0x00011B00
		private void EnforceTextHOverflow()
		{
			if (this.m_TextComponent != null)
			{
				if (this.multiLine)
				{
					this.m_TextComponent.horizontalOverflow = HorizontalWrapMode.Wrap;
				}
				else
				{
					this.m_TextComponent.horizontalOverflow = HorizontalWrapMode.Overflow;
				}
			}
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0001373C File Offset: 0x00011B3C
		private void SetToCustomIfContentTypeIsNot(params InputField.ContentType[] allowedContentTypes)
		{
			if (this.contentType != InputField.ContentType.Custom)
			{
				for (int i = 0; i < allowedContentTypes.Length; i++)
				{
					if (this.contentType == allowedContentTypes[i])
					{
						return;
					}
				}
				this.contentType = InputField.ContentType.Custom;
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0001378B File Offset: 0x00011B8B
		private void SetToCustom()
		{
			if (this.contentType != InputField.ContentType.Custom)
			{
				this.contentType = InputField.ContentType.Custom;
			}
		}

		// Token: 0x06000339 RID: 825 RVA: 0x000137A8 File Offset: 0x00011BA8
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
			if (this.m_HasDoneFocusTransition)
			{
				state = Selectable.SelectionState.Highlighted;
			}
			else if (state == Selectable.SelectionState.Pressed)
			{
				this.m_HasDoneFocusTransition = true;
			}
			base.DoStateTransition(state, instant);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000137D4 File Offset: 0x00011BD4
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000137D7 File Offset: 0x00011BD7
		public virtual void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600033C RID: 828 RVA: 0x000137DC File Offset: 0x00011BDC
		public virtual float minWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600033D RID: 829 RVA: 0x000137F8 File Offset: 0x00011BF8
		public virtual float preferredWidth
		{
			get
			{
				float result;
				if (this.textComponent == null)
				{
					result = 0f;
				}
				else
				{
					TextGenerationSettings generationSettings = this.textComponent.GetGenerationSettings(Vector2.zero);
					result = this.textComponent.cachedTextGeneratorForLayout.GetPreferredWidth(this.m_Text, generationSettings) / this.textComponent.pixelsPerUnit;
				}
				return result;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00013860 File Offset: 0x00011C60
		public virtual float flexibleWidth
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600033F RID: 831 RVA: 0x0001387C File Offset: 0x00011C7C
		public virtual float minHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00013898 File Offset: 0x00011C98
		public virtual float preferredHeight
		{
			get
			{
				float result;
				if (this.textComponent == null)
				{
					result = 0f;
				}
				else
				{
					TextGenerationSettings generationSettings = this.textComponent.GetGenerationSettings(new Vector2(this.textComponent.rectTransform.rect.size.x, 0f));
					result = this.textComponent.cachedTextGeneratorForLayout.GetPreferredHeight(this.m_Text, generationSettings) / this.textComponent.pixelsPerUnit;
				}
				return result;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000341 RID: 833 RVA: 0x00013924 File Offset: 0x00011D24
		public virtual float flexibleHeight
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00013940 File Offset: 0x00011D40
		public virtual int layoutPriority
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0001396E File Offset: 0x00011D6E
		Transform ICanvasElement.get_transform()
		{
			return base.transform;
		}

		// Token: 0x04000157 RID: 343
		protected TouchScreenKeyboard m_Keyboard;

		// Token: 0x04000158 RID: 344
		private static readonly char[] kSeparators = new char[]
		{
			' ',
			'.',
			',',
			'\t',
			'\r',
			'\n'
		};

		// Token: 0x04000159 RID: 345
		[SerializeField]
		[FormerlySerializedAs("text")]
		protected Text m_TextComponent;

		// Token: 0x0400015A RID: 346
		[SerializeField]
		protected Graphic m_Placeholder;

		// Token: 0x0400015B RID: 347
		[SerializeField]
		private InputField.ContentType m_ContentType = InputField.ContentType.Standard;

		// Token: 0x0400015C RID: 348
		[FormerlySerializedAs("inputType")]
		[SerializeField]
		private InputField.InputType m_InputType = InputField.InputType.Standard;

		// Token: 0x0400015D RID: 349
		[FormerlySerializedAs("asteriskChar")]
		[SerializeField]
		private char m_AsteriskChar = '*';

		// Token: 0x0400015E RID: 350
		[FormerlySerializedAs("keyboardType")]
		[SerializeField]
		private TouchScreenKeyboardType m_KeyboardType = TouchScreenKeyboardType.Default;

		// Token: 0x0400015F RID: 351
		[SerializeField]
		private InputField.LineType m_LineType = InputField.LineType.SingleLine;

		// Token: 0x04000160 RID: 352
		[FormerlySerializedAs("hideMobileInput")]
		[SerializeField]
		private bool m_HideMobileInput = false;

		// Token: 0x04000161 RID: 353
		[FormerlySerializedAs("validation")]
		[SerializeField]
		private InputField.CharacterValidation m_CharacterValidation = InputField.CharacterValidation.None;

		// Token: 0x04000162 RID: 354
		[FormerlySerializedAs("characterLimit")]
		[SerializeField]
		private int m_CharacterLimit = 0;

		// Token: 0x04000163 RID: 355
		[FormerlySerializedAs("onSubmit")]
		[FormerlySerializedAs("m_OnSubmit")]
		[FormerlySerializedAs("m_EndEdit")]
		[SerializeField]
		private InputField.SubmitEvent m_OnEndEdit = new InputField.SubmitEvent();

		// Token: 0x04000164 RID: 356
		[FormerlySerializedAs("onValueChange")]
		[FormerlySerializedAs("m_OnValueChange")]
		[SerializeField]
		private InputField.OnChangeEvent m_OnValueChanged = new InputField.OnChangeEvent();

		// Token: 0x04000165 RID: 357
		[FormerlySerializedAs("onValidateInput")]
		[SerializeField]
		private InputField.OnValidateInput m_OnValidateInput;

		// Token: 0x04000166 RID: 358
		[SerializeField]
		private Color m_CaretColor = new Color(0.19607843f, 0.19607843f, 0.19607843f, 1f);

		// Token: 0x04000167 RID: 359
		[SerializeField]
		private bool m_CustomCaretColor = false;

		// Token: 0x04000168 RID: 360
		[FormerlySerializedAs("selectionColor")]
		[SerializeField]
		private Color m_SelectionColor = new Color(0.65882355f, 0.80784315f, 1f, 0.7529412f);

		// Token: 0x04000169 RID: 361
		[SerializeField]
		[FormerlySerializedAs("mValue")]
		protected string m_Text = string.Empty;

		// Token: 0x0400016A RID: 362
		[SerializeField]
		[Range(0f, 4f)]
		private float m_CaretBlinkRate = 0.85f;

		// Token: 0x0400016B RID: 363
		[SerializeField]
		[Range(1f, 5f)]
		private int m_CaretWidth = 1;

		// Token: 0x0400016C RID: 364
		[SerializeField]
		private bool m_ReadOnly = false;

		// Token: 0x0400016D RID: 365
		protected int m_CaretPosition = 0;

		// Token: 0x0400016E RID: 366
		protected int m_CaretSelectPosition = 0;

		// Token: 0x0400016F RID: 367
		private RectTransform caretRectTrans = null;

		// Token: 0x04000170 RID: 368
		protected UIVertex[] m_CursorVerts = null;

		// Token: 0x04000171 RID: 369
		private TextGenerator m_InputTextCache;

		// Token: 0x04000172 RID: 370
		private CanvasRenderer m_CachedInputRenderer;

		// Token: 0x04000173 RID: 371
		private bool m_PreventFontCallback = false;

		// Token: 0x04000174 RID: 372
		[NonSerialized]
		protected Mesh m_Mesh;

		// Token: 0x04000175 RID: 373
		private bool m_AllowInput = false;

		// Token: 0x04000176 RID: 374
		private bool m_ShouldActivateNextUpdate = false;

		// Token: 0x04000177 RID: 375
		private bool m_UpdateDrag = false;

		// Token: 0x04000178 RID: 376
		private bool m_DragPositionOutOfBounds = false;

		// Token: 0x04000179 RID: 377
		private const float kHScrollSpeed = 0.05f;

		// Token: 0x0400017A RID: 378
		private const float kVScrollSpeed = 0.1f;

		// Token: 0x0400017B RID: 379
		protected bool m_CaretVisible;

		// Token: 0x0400017C RID: 380
		private Coroutine m_BlinkCoroutine = null;

		// Token: 0x0400017D RID: 381
		private float m_BlinkStartTime = 0f;

		// Token: 0x0400017E RID: 382
		protected int m_DrawStart = 0;

		// Token: 0x0400017F RID: 383
		protected int m_DrawEnd = 0;

		// Token: 0x04000180 RID: 384
		private Coroutine m_DragCoroutine = null;

		// Token: 0x04000181 RID: 385
		private string m_OriginalText = "";

		// Token: 0x04000182 RID: 386
		private bool m_WasCanceled = false;

		// Token: 0x04000183 RID: 387
		private bool m_HasDoneFocusTransition = false;

		// Token: 0x04000184 RID: 388
		private const string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~";

		// Token: 0x04000185 RID: 389
		private Event m_ProcessingEvent = new Event();

		// Token: 0x02000059 RID: 89
		public enum ContentType
		{
			// Token: 0x04000187 RID: 391
			Standard,
			// Token: 0x04000188 RID: 392
			Autocorrected,
			// Token: 0x04000189 RID: 393
			IntegerNumber,
			// Token: 0x0400018A RID: 394
			DecimalNumber,
			// Token: 0x0400018B RID: 395
			Alphanumeric,
			// Token: 0x0400018C RID: 396
			Name,
			// Token: 0x0400018D RID: 397
			EmailAddress,
			// Token: 0x0400018E RID: 398
			Password,
			// Token: 0x0400018F RID: 399
			Pin,
			// Token: 0x04000190 RID: 400
			Custom
		}

		// Token: 0x0200005A RID: 90
		public enum InputType
		{
			// Token: 0x04000192 RID: 402
			Standard,
			// Token: 0x04000193 RID: 403
			AutoCorrect,
			// Token: 0x04000194 RID: 404
			Password
		}

		// Token: 0x0200005B RID: 91
		public enum CharacterValidation
		{
			// Token: 0x04000196 RID: 406
			None,
			// Token: 0x04000197 RID: 407
			Integer,
			// Token: 0x04000198 RID: 408
			Decimal,
			// Token: 0x04000199 RID: 409
			Alphanumeric,
			// Token: 0x0400019A RID: 410
			Name,
			// Token: 0x0400019B RID: 411
			EmailAddress
		}

		// Token: 0x0200005C RID: 92
		public enum LineType
		{
			// Token: 0x0400019D RID: 413
			SingleLine,
			// Token: 0x0400019E RID: 414
			MultiLineSubmit,
			// Token: 0x0400019F RID: 415
			MultiLineNewline
		}

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x06000346 RID: 838
		public delegate char OnValidateInput(string text, int charIndex, char addedChar);

		// Token: 0x0200005E RID: 94
		[Serializable]
		public class SubmitEvent : UnityEvent<string>
		{
		}

		// Token: 0x0200005F RID: 95
		[Serializable]
		public class OnChangeEvent : UnityEvent<string>
		{
		}

		// Token: 0x02000060 RID: 96
		protected enum EditState
		{
			// Token: 0x040001A1 RID: 417
			Continue,
			// Token: 0x040001A2 RID: 418
			Finish
		}
	}
}
