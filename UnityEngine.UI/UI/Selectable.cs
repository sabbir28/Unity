using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000072 RID: 114
	[AddComponentMenu("UI/Selectable", 70)]
	[ExecuteInEditMode]
	[SelectionBase]
	[DisallowMultipleComponent]
	public class Selectable : UIBehaviour, IMoveHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler, IEventSystemHandler
	{
		// Token: 0x06000419 RID: 1049 RVA: 0x00006C0C File Offset: 0x0000500C
		protected Selectable()
		{
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x00006C64 File Offset: 0x00005064
		public static List<Selectable> allSelectables
		{
			get
			{
				return Selectable.s_List;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x00006C80 File Offset: 0x00005080
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x00006C9B File Offset: 0x0000509B
		public Navigation navigation
		{
			get
			{
				return this.m_Navigation;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<Navigation>(ref this.m_Navigation, value))
				{
					this.OnSetProperty();
				}
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x00006CB8 File Offset: 0x000050B8
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x00006CD3 File Offset: 0x000050D3
		public Selectable.Transition transition
		{
			get
			{
				return this.m_Transition;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<Selectable.Transition>(ref this.m_Transition, value))
				{
					this.OnSetProperty();
				}
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x00006CF0 File Offset: 0x000050F0
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x00006D0B File Offset: 0x0000510B
		public ColorBlock colors
		{
			get
			{
				return this.m_Colors;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<ColorBlock>(ref this.m_Colors, value))
				{
					this.OnSetProperty();
				}
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x00006D28 File Offset: 0x00005128
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x00006D43 File Offset: 0x00005143
		public SpriteState spriteState
		{
			get
			{
				return this.m_SpriteState;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<SpriteState>(ref this.m_SpriteState, value))
				{
					this.OnSetProperty();
				}
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x00006D60 File Offset: 0x00005160
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x00006D7B File Offset: 0x0000517B
		public AnimationTriggers animationTriggers
		{
			get
			{
				return this.m_AnimationTriggers;
			}
			set
			{
				if (SetPropertyUtility.SetClass<AnimationTriggers>(ref this.m_AnimationTriggers, value))
				{
					this.OnSetProperty();
				}
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x00006D98 File Offset: 0x00005198
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x00006DB3 File Offset: 0x000051B3
		public Graphic targetGraphic
		{
			get
			{
				return this.m_TargetGraphic;
			}
			set
			{
				if (SetPropertyUtility.SetClass<Graphic>(ref this.m_TargetGraphic, value))
				{
					this.OnSetProperty();
				}
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x00006DD0 File Offset: 0x000051D0
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x00006DEC File Offset: 0x000051EC
		public bool interactable
		{
			get
			{
				return this.m_Interactable;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<bool>(ref this.m_Interactable, value))
				{
					if (!this.m_Interactable && EventSystem.current != null && EventSystem.current.currentSelectedGameObject == base.gameObject)
					{
						EventSystem.current.SetSelectedGameObject(null);
					}
					if (this.m_Interactable)
					{
						this.UpdateSelectionState(null);
					}
					this.OnSetProperty();
				}
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00006E68 File Offset: 0x00005268
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x00006E82 File Offset: 0x00005282
		private bool isPointerInside { get; set; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x00006E8C File Offset: 0x0000528C
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x00006EA6 File Offset: 0x000052A6
		private bool isPointerDown { get; set; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x00006EB0 File Offset: 0x000052B0
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x00006ECA File Offset: 0x000052CA
		private bool hasSelection { get; set; }

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x00006ED4 File Offset: 0x000052D4
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x00006EF4 File Offset: 0x000052F4
		public Image image
		{
			get
			{
				return this.m_TargetGraphic as Image;
			}
			set
			{
				this.m_TargetGraphic = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x00006F00 File Offset: 0x00005300
		public Animator animator
		{
			get
			{
				return base.GetComponent<Animator>();
			}
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00006F1B File Offset: 0x0000531B
		protected override void Awake()
		{
			if (this.m_TargetGraphic == null)
			{
				this.m_TargetGraphic = base.GetComponent<Graphic>();
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00006F3C File Offset: 0x0000533C
		protected override void OnCanvasGroupChanged()
		{
			bool flag = true;
			Transform transform = base.transform;
			while (transform != null)
			{
				transform.GetComponents<CanvasGroup>(this.m_CanvasGroupCache);
				bool flag2 = false;
				for (int i = 0; i < this.m_CanvasGroupCache.Count; i++)
				{
					if (!this.m_CanvasGroupCache[i].interactable)
					{
						flag = false;
						flag2 = true;
					}
					if (this.m_CanvasGroupCache[i].ignoreParentGroups)
					{
						flag2 = true;
					}
				}
				if (flag2)
				{
					break;
				}
				transform = transform.parent;
			}
			if (flag != this.m_GroupsAllowInteraction)
			{
				this.m_GroupsAllowInteraction = flag;
				this.OnSetProperty();
			}
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00006FF4 File Offset: 0x000053F4
		public virtual bool IsInteractable()
		{
			return this.m_GroupsAllowInteraction && this.m_Interactable;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0000701D File Offset: 0x0000541D
		protected override void OnDidApplyAnimationProperties()
		{
			this.OnSetProperty();
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00007028 File Offset: 0x00005428
		protected override void OnEnable()
		{
			base.OnEnable();
			Selectable.s_List.Add(this);
			Selectable.SelectionState currentSelectionState = Selectable.SelectionState.Normal;
			if (this.hasSelection)
			{
				currentSelectionState = Selectable.SelectionState.Highlighted;
			}
			this.m_CurrentSelectionState = currentSelectionState;
			this.InternalEvaluateAndTransitionToSelectionState(true);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00007064 File Offset: 0x00005464
		private void OnSetProperty()
		{
			this.InternalEvaluateAndTransitionToSelectionState(false);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0000706E File Offset: 0x0000546E
		protected override void OnDisable()
		{
			Selectable.s_List.Remove(this);
			this.InstantClearState();
			base.OnDisable();
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x0000708C File Offset: 0x0000548C
		protected Selectable.SelectionState currentSelectionState
		{
			get
			{
				return this.m_CurrentSelectionState;
			}
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000070A8 File Offset: 0x000054A8
		protected virtual void InstantClearState()
		{
			string normalTrigger = this.m_AnimationTriggers.normalTrigger;
			this.isPointerInside = false;
			this.isPointerDown = false;
			this.hasSelection = false;
			Selectable.Transition transition = this.m_Transition;
			if (transition != Selectable.Transition.ColorTint)
			{
				if (transition != Selectable.Transition.SpriteSwap)
				{
					if (transition == Selectable.Transition.Animation)
					{
						this.TriggerAnimation(normalTrigger);
					}
				}
				else
				{
					this.DoSpriteSwap(null);
				}
			}
			else
			{
				this.StartColorTween(Color.white, true);
			}
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00007124 File Offset: 0x00005524
		protected virtual void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
			Color a;
			Sprite newSprite;
			string triggername;
			switch (state)
			{
			case Selectable.SelectionState.Normal:
				a = this.m_Colors.normalColor;
				newSprite = null;
				triggername = this.m_AnimationTriggers.normalTrigger;
				break;
			case Selectable.SelectionState.Highlighted:
				a = this.m_Colors.highlightedColor;
				newSprite = this.m_SpriteState.highlightedSprite;
				triggername = this.m_AnimationTriggers.highlightedTrigger;
				break;
			case Selectable.SelectionState.Pressed:
				a = this.m_Colors.pressedColor;
				newSprite = this.m_SpriteState.pressedSprite;
				triggername = this.m_AnimationTriggers.pressedTrigger;
				break;
			case Selectable.SelectionState.Disabled:
				a = this.m_Colors.disabledColor;
				newSprite = this.m_SpriteState.disabledSprite;
				triggername = this.m_AnimationTriggers.disabledTrigger;
				break;
			default:
				a = Color.black;
				newSprite = null;
				triggername = string.Empty;
				break;
			}
			if (base.gameObject.activeInHierarchy)
			{
				Selectable.Transition transition = this.m_Transition;
				if (transition != Selectable.Transition.ColorTint)
				{
					if (transition != Selectable.Transition.SpriteSwap)
					{
						if (transition == Selectable.Transition.Animation)
						{
							this.TriggerAnimation(triggername);
						}
					}
					else
					{
						this.DoSpriteSwap(newSprite);
					}
				}
				else
				{
					this.StartColorTween(a * this.m_Colors.colorMultiplier, instant);
				}
			}
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00007264 File Offset: 0x00005664
		public Selectable FindSelectable(Vector3 dir)
		{
			dir = dir.normalized;
			Vector3 v = Quaternion.Inverse(base.transform.rotation) * dir;
			Vector3 b = base.transform.TransformPoint(Selectable.GetPointOnRectEdge(base.transform as RectTransform, v));
			float num = float.NegativeInfinity;
			Selectable result = null;
			for (int i = 0; i < Selectable.s_List.Count; i++)
			{
				Selectable selectable = Selectable.s_List[i];
				if (!(selectable == this) && !(selectable == null))
				{
					if (selectable.IsInteractable() && selectable.navigation.mode != Navigation.Mode.None)
					{
						RectTransform rectTransform = selectable.transform as RectTransform;
						Vector3 position = (!(rectTransform != null)) ? Vector3.zero : rectTransform.rect.center;
						Vector3 rhs = selectable.transform.TransformPoint(position) - b;
						float num2 = Vector3.Dot(dir, rhs);
						if (num2 > 0f)
						{
							float num3 = num2 / rhs.sqrMagnitude;
							if (num3 > num)
							{
								num = num3;
								result = selectable;
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000073C4 File Offset: 0x000057C4
		private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir)
		{
			Vector3 result;
			if (rect == null)
			{
				result = Vector3.zero;
			}
			else
			{
				if (dir != Vector2.zero)
				{
					dir /= Mathf.Max(Mathf.Abs(dir.x), Mathf.Abs(dir.y));
				}
				dir = rect.rect.center + Vector2.Scale(rect.rect.size, dir * 0.5f);
				result = dir;
			}
			return result;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0000745E File Offset: 0x0000585E
		private void Navigate(AxisEventData eventData, Selectable sel)
		{
			if (sel != null && sel.IsActive())
			{
				eventData.selectedObject = sel.gameObject;
			}
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00007484 File Offset: 0x00005884
		public virtual Selectable FindSelectableOnLeft()
		{
			Selectable result;
			if (this.m_Navigation.mode == Navigation.Mode.Explicit)
			{
				result = this.m_Navigation.selectOnLeft;
			}
			else if ((this.m_Navigation.mode & Navigation.Mode.Horizontal) != Navigation.Mode.None)
			{
				result = this.FindSelectable(base.transform.rotation * Vector3.left);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x000074F4 File Offset: 0x000058F4
		public virtual Selectable FindSelectableOnRight()
		{
			Selectable result;
			if (this.m_Navigation.mode == Navigation.Mode.Explicit)
			{
				result = this.m_Navigation.selectOnRight;
			}
			else if ((this.m_Navigation.mode & Navigation.Mode.Horizontal) != Navigation.Mode.None)
			{
				result = this.FindSelectable(base.transform.rotation * Vector3.right);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00007564 File Offset: 0x00005964
		public virtual Selectable FindSelectableOnUp()
		{
			Selectable result;
			if (this.m_Navigation.mode == Navigation.Mode.Explicit)
			{
				result = this.m_Navigation.selectOnUp;
			}
			else if ((this.m_Navigation.mode & Navigation.Mode.Vertical) != Navigation.Mode.None)
			{
				result = this.FindSelectable(base.transform.rotation * Vector3.up);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000075D4 File Offset: 0x000059D4
		public virtual Selectable FindSelectableOnDown()
		{
			Selectable result;
			if (this.m_Navigation.mode == Navigation.Mode.Explicit)
			{
				result = this.m_Navigation.selectOnDown;
			}
			else if ((this.m_Navigation.mode & Navigation.Mode.Vertical) != Navigation.Mode.None)
			{
				result = this.FindSelectable(base.transform.rotation * Vector3.down);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00007644 File Offset: 0x00005A44
		public virtual void OnMove(AxisEventData eventData)
		{
			switch (eventData.moveDir)
			{
			case MoveDirection.Left:
				this.Navigate(eventData, this.FindSelectableOnLeft());
				break;
			case MoveDirection.Up:
				this.Navigate(eventData, this.FindSelectableOnUp());
				break;
			case MoveDirection.Right:
				this.Navigate(eventData, this.FindSelectableOnRight());
				break;
			case MoveDirection.Down:
				this.Navigate(eventData, this.FindSelectableOnDown());
				break;
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x000076BC File Offset: 0x00005ABC
		private void StartColorTween(Color targetColor, bool instant)
		{
			if (!(this.m_TargetGraphic == null))
			{
				this.m_TargetGraphic.CrossFadeColor(targetColor, (!instant) ? this.m_Colors.fadeDuration : 0f, true, true);
			}
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00007709 File Offset: 0x00005B09
		private void DoSpriteSwap(Sprite newSprite)
		{
			if (!(this.image == null))
			{
				this.image.overrideSprite = newSprite;
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00007730 File Offset: 0x00005B30
		private void TriggerAnimation(string triggername)
		{
			if (this.transition == Selectable.Transition.Animation && !(this.animator == null) && this.animator.isActiveAndEnabled && this.animator.hasBoundPlayables && !string.IsNullOrEmpty(triggername))
			{
				this.animator.ResetTrigger(this.m_AnimationTriggers.normalTrigger);
				this.animator.ResetTrigger(this.m_AnimationTriggers.pressedTrigger);
				this.animator.ResetTrigger(this.m_AnimationTriggers.highlightedTrigger);
				this.animator.ResetTrigger(this.m_AnimationTriggers.disabledTrigger);
				this.animator.SetTrigger(triggername);
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x000077F0 File Offset: 0x00005BF0
		protected bool IsHighlighted(BaseEventData eventData)
		{
			bool result;
			if (!this.IsActive())
			{
				result = false;
			}
			else if (this.IsPressed())
			{
				result = false;
			}
			else
			{
				bool flag = this.hasSelection;
				if (eventData is PointerEventData)
				{
					PointerEventData pointerEventData = eventData as PointerEventData;
					flag |= ((this.isPointerDown && !this.isPointerInside && pointerEventData.pointerPress == base.gameObject) || (!this.isPointerDown && this.isPointerInside && pointerEventData.pointerPress == base.gameObject) || (!this.isPointerDown && this.isPointerInside && pointerEventData.pointerPress == null));
				}
				else
				{
					flag |= this.isPointerInside;
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x000078D8 File Offset: 0x00005CD8
		[Obsolete("Is Pressed no longer requires eventData", false)]
		protected bool IsPressed(BaseEventData eventData)
		{
			return this.IsPressed();
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x000078F4 File Offset: 0x00005CF4
		protected bool IsPressed()
		{
			return this.IsActive() && this.isPointerInside && this.isPointerDown;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0000792F File Offset: 0x00005D2F
		protected void UpdateSelectionState(BaseEventData eventData)
		{
			if (this.IsPressed())
			{
				this.m_CurrentSelectionState = Selectable.SelectionState.Pressed;
			}
			else if (this.IsHighlighted(eventData))
			{
				this.m_CurrentSelectionState = Selectable.SelectionState.Highlighted;
			}
			else
			{
				this.m_CurrentSelectionState = Selectable.SelectionState.Normal;
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0000796A File Offset: 0x00005D6A
		private void EvaluateAndTransitionToSelectionState(BaseEventData eventData)
		{
			if (this.IsActive() && this.IsInteractable())
			{
				this.UpdateSelectionState(eventData);
				this.InternalEvaluateAndTransitionToSelectionState(false);
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00007998 File Offset: 0x00005D98
		private void InternalEvaluateAndTransitionToSelectionState(bool instant)
		{
			Selectable.SelectionState state = this.m_CurrentSelectionState;
			if (this.IsActive() && !this.IsInteractable())
			{
				state = Selectable.SelectionState.Disabled;
			}
			this.DoStateTransition(state, instant);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x000079D0 File Offset: 0x00005DD0
		public virtual void OnPointerDown(PointerEventData eventData)
		{
			if (eventData.button == PointerEventData.InputButton.Left)
			{
				if (this.IsInteractable() && this.navigation.mode != Navigation.Mode.None && EventSystem.current != null)
				{
					EventSystem.current.SetSelectedGameObject(base.gameObject, eventData);
				}
				this.isPointerDown = true;
				this.EvaluateAndTransitionToSelectionState(eventData);
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00007A3B File Offset: 0x00005E3B
		public virtual void OnPointerUp(PointerEventData eventData)
		{
			if (eventData.button == PointerEventData.InputButton.Left)
			{
				this.isPointerDown = false;
				this.EvaluateAndTransitionToSelectionState(eventData);
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00007A5C File Offset: 0x00005E5C
		public virtual void OnPointerEnter(PointerEventData eventData)
		{
			this.isPointerInside = true;
			this.EvaluateAndTransitionToSelectionState(eventData);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00007A6D File Offset: 0x00005E6D
		public virtual void OnPointerExit(PointerEventData eventData)
		{
			this.isPointerInside = false;
			this.EvaluateAndTransitionToSelectionState(eventData);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00007A7E File Offset: 0x00005E7E
		public virtual void OnSelect(BaseEventData eventData)
		{
			this.hasSelection = true;
			this.EvaluateAndTransitionToSelectionState(eventData);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00007A8F File Offset: 0x00005E8F
		public virtual void OnDeselect(BaseEventData eventData)
		{
			this.hasSelection = false;
			this.EvaluateAndTransitionToSelectionState(eventData);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00007AA0 File Offset: 0x00005EA0
		public virtual void Select()
		{
			if (!(EventSystem.current == null) && !EventSystem.current.alreadySelecting)
			{
				EventSystem.current.SetSelectedGameObject(base.gameObject);
			}
		}

		// Token: 0x04000205 RID: 517
		private static List<Selectable> s_List = new List<Selectable>();

		// Token: 0x04000206 RID: 518
		[FormerlySerializedAs("navigation")]
		[SerializeField]
		private Navigation m_Navigation = Navigation.defaultNavigation;

		// Token: 0x04000207 RID: 519
		[FormerlySerializedAs("transition")]
		[SerializeField]
		private Selectable.Transition m_Transition = Selectable.Transition.ColorTint;

		// Token: 0x04000208 RID: 520
		[FormerlySerializedAs("colors")]
		[SerializeField]
		private ColorBlock m_Colors = ColorBlock.defaultColorBlock;

		// Token: 0x04000209 RID: 521
		[FormerlySerializedAs("spriteState")]
		[SerializeField]
		private SpriteState m_SpriteState;

		// Token: 0x0400020A RID: 522
		[FormerlySerializedAs("animationTriggers")]
		[SerializeField]
		private AnimationTriggers m_AnimationTriggers = new AnimationTriggers();

		// Token: 0x0400020B RID: 523
		[Tooltip("Can the Selectable be interacted with?")]
		[SerializeField]
		private bool m_Interactable = true;

		// Token: 0x0400020C RID: 524
		[FormerlySerializedAs("highlightGraphic")]
		[FormerlySerializedAs("m_HighlightGraphic")]
		[SerializeField]
		private Graphic m_TargetGraphic;

		// Token: 0x0400020D RID: 525
		private bool m_GroupsAllowInteraction = true;

		// Token: 0x0400020E RID: 526
		private Selectable.SelectionState m_CurrentSelectionState;

		// Token: 0x04000212 RID: 530
		private readonly List<CanvasGroup> m_CanvasGroupCache = new List<CanvasGroup>();

		// Token: 0x02000073 RID: 115
		public enum Transition
		{
			// Token: 0x04000214 RID: 532
			None,
			// Token: 0x04000215 RID: 533
			ColorTint,
			// Token: 0x04000216 RID: 534
			SpriteSwap,
			// Token: 0x04000217 RID: 535
			Animation
		}

		// Token: 0x02000074 RID: 116
		protected enum SelectionState
		{
			// Token: 0x04000219 RID: 537
			Normal,
			// Token: 0x0400021A RID: 538
			Highlighted,
			// Token: 0x0400021B RID: 539
			Pressed,
			// Token: 0x0400021C RID: 540
			Disabled
		}
	}
}
