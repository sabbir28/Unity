using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI.CoroutineTween;

namespace UnityEngine.UI
{
	// Token: 0x02000042 RID: 66
	[AddComponentMenu("UI/Dropdown", 35)]
	[RequireComponent(typeof(RectTransform))]
	public class Dropdown : Selectable, IPointerClickHandler, ISubmitHandler, ICancelHandler, IEventSystemHandler
	{
		// Token: 0x060001C3 RID: 451 RVA: 0x000098EF File Offset: 0x00007CEF
		protected Dropdown()
		{
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00009920 File Offset: 0x00007D20
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x0000993B File Offset: 0x00007D3B
		public RectTransform template
		{
			get
			{
				return this.m_Template;
			}
			set
			{
				this.m_Template = value;
				this.RefreshShownValue();
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0000994C File Offset: 0x00007D4C
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00009967 File Offset: 0x00007D67
		public Text captionText
		{
			get
			{
				return this.m_CaptionText;
			}
			set
			{
				this.m_CaptionText = value;
				this.RefreshShownValue();
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00009978 File Offset: 0x00007D78
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x00009993 File Offset: 0x00007D93
		public Image captionImage
		{
			get
			{
				return this.m_CaptionImage;
			}
			set
			{
				this.m_CaptionImage = value;
				this.RefreshShownValue();
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001CA RID: 458 RVA: 0x000099A4 File Offset: 0x00007DA4
		// (set) Token: 0x060001CB RID: 459 RVA: 0x000099BF File Offset: 0x00007DBF
		public Text itemText
		{
			get
			{
				return this.m_ItemText;
			}
			set
			{
				this.m_ItemText = value;
				this.RefreshShownValue();
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001CC RID: 460 RVA: 0x000099D0 File Offset: 0x00007DD0
		// (set) Token: 0x060001CD RID: 461 RVA: 0x000099EB File Offset: 0x00007DEB
		public Image itemImage
		{
			get
			{
				return this.m_ItemImage;
			}
			set
			{
				this.m_ItemImage = value;
				this.RefreshShownValue();
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001CE RID: 462 RVA: 0x000099FC File Offset: 0x00007DFC
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00009A1C File Offset: 0x00007E1C
		public List<Dropdown.OptionData> options
		{
			get
			{
				return this.m_Options.options;
			}
			set
			{
				this.m_Options.options = value;
				this.RefreshShownValue();
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00009A34 File Offset: 0x00007E34
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00009A4F File Offset: 0x00007E4F
		public Dropdown.DropdownEvent onValueChanged
		{
			get
			{
				return this.m_OnValueChanged;
			}
			set
			{
				this.m_OnValueChanged = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00009A5C File Offset: 0x00007E5C
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00009A78 File Offset: 0x00007E78
		public int value
		{
			get
			{
				return this.m_Value;
			}
			set
			{
				if (!Application.isPlaying || (value != this.m_Value && this.options.Count != 0))
				{
					this.m_Value = Mathf.Clamp(value, 0, this.options.Count - 1);
					this.RefreshShownValue();
					this.m_OnValueChanged.Invoke(this.m_Value);
				}
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00009AE4 File Offset: 0x00007EE4
		protected override void Awake()
		{
			this.m_AlphaTweenRunner = new TweenRunner<FloatTween>();
			this.m_AlphaTweenRunner.Init(this);
			if (this.m_CaptionImage)
			{
				this.m_CaptionImage.enabled = (this.m_CaptionImage.sprite != null);
			}
			if (this.m_Template)
			{
				this.m_Template.gameObject.SetActive(false);
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00009B58 File Offset: 0x00007F58
		public void RefreshShownValue()
		{
			Dropdown.OptionData optionData = Dropdown.s_NoOptionData;
			if (this.options.Count > 0)
			{
				optionData = this.options[Mathf.Clamp(this.m_Value, 0, this.options.Count - 1)];
			}
			if (this.m_CaptionText)
			{
				if (optionData != null && optionData.text != null)
				{
					this.m_CaptionText.text = optionData.text;
				}
				else
				{
					this.m_CaptionText.text = "";
				}
			}
			if (this.m_CaptionImage)
			{
				if (optionData != null)
				{
					this.m_CaptionImage.sprite = optionData.image;
				}
				else
				{
					this.m_CaptionImage.sprite = null;
				}
				this.m_CaptionImage.enabled = (this.m_CaptionImage.sprite != null);
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00009C41 File Offset: 0x00008041
		public void AddOptions(List<Dropdown.OptionData> options)
		{
			this.options.AddRange(options);
			this.RefreshShownValue();
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00009C58 File Offset: 0x00008058
		public void AddOptions(List<string> options)
		{
			for (int i = 0; i < options.Count; i++)
			{
				this.options.Add(new Dropdown.OptionData(options[i]));
			}
			this.RefreshShownValue();
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00009C9C File Offset: 0x0000809C
		public void AddOptions(List<Sprite> options)
		{
			for (int i = 0; i < options.Count; i++)
			{
				this.options.Add(new Dropdown.OptionData(options[i]));
			}
			this.RefreshShownValue();
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00009CDE File Offset: 0x000080DE
		public void ClearOptions()
		{
			this.options.Clear();
			this.RefreshShownValue();
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00009CF4 File Offset: 0x000080F4
		private void SetupTemplate()
		{
			this.validTemplate = false;
			if (!this.m_Template)
			{
				Debug.LogError("The dropdown template is not assigned. The template needs to be assigned and must have a child GameObject with a Toggle component serving as the item.", this);
			}
			else
			{
				GameObject gameObject = this.m_Template.gameObject;
				gameObject.SetActive(true);
				Toggle componentInChildren = this.m_Template.GetComponentInChildren<Toggle>();
				this.validTemplate = true;
				if (!componentInChildren || componentInChildren.transform == this.template)
				{
					this.validTemplate = false;
					Debug.LogError("The dropdown template is not valid. The template must have a child GameObject with a Toggle component serving as the item.", this.template);
				}
				else if (!(componentInChildren.transform.parent is RectTransform))
				{
					this.validTemplate = false;
					Debug.LogError("The dropdown template is not valid. The child GameObject with a Toggle component (the item) must have a RectTransform on its parent.", this.template);
				}
				else if (this.itemText != null && !this.itemText.transform.IsChildOf(componentInChildren.transform))
				{
					this.validTemplate = false;
					Debug.LogError("The dropdown template is not valid. The Item Text must be on the item GameObject or children of it.", this.template);
				}
				else if (this.itemImage != null && !this.itemImage.transform.IsChildOf(componentInChildren.transform))
				{
					this.validTemplate = false;
					Debug.LogError("The dropdown template is not valid. The Item Image must be on the item GameObject or children of it.", this.template);
				}
				if (!this.validTemplate)
				{
					gameObject.SetActive(false);
				}
				else
				{
					Dropdown.DropdownItem dropdownItem = componentInChildren.gameObject.AddComponent<Dropdown.DropdownItem>();
					dropdownItem.text = this.m_ItemText;
					dropdownItem.image = this.m_ItemImage;
					dropdownItem.toggle = componentInChildren;
					dropdownItem.rectTransform = (RectTransform)componentInChildren.transform;
					Canvas orAddComponent = Dropdown.GetOrAddComponent<Canvas>(gameObject);
					orAddComponent.overrideSorting = true;
					orAddComponent.sortingOrder = 30000;
					Dropdown.GetOrAddComponent<GraphicRaycaster>(gameObject);
					Dropdown.GetOrAddComponent<CanvasGroup>(gameObject);
					gameObject.SetActive(false);
					this.validTemplate = true;
				}
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00009EDC File Offset: 0x000082DC
		private static T GetOrAddComponent<T>(GameObject go) where T : Component
		{
			T t = go.GetComponent<T>();
			if (!t)
			{
				t = go.AddComponent<T>();
			}
			return t;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00009F10 File Offset: 0x00008310
		public virtual void OnPointerClick(PointerEventData eventData)
		{
			this.Show();
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00009F19 File Offset: 0x00008319
		public virtual void OnSubmit(BaseEventData eventData)
		{
			this.Show();
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00009F22 File Offset: 0x00008322
		public virtual void OnCancel(BaseEventData eventData)
		{
			this.Hide();
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00009F2C File Offset: 0x0000832C
		public void Show()
		{
			if (this.IsActive() && this.IsInteractable() && !(this.m_Dropdown != null))
			{
				if (!this.validTemplate)
				{
					this.SetupTemplate();
					if (!this.validTemplate)
					{
						return;
					}
				}
				List<Canvas> list = ListPool<Canvas>.Get();
				base.gameObject.GetComponentsInParent<Canvas>(false, list);
				if (list.Count != 0)
				{
					Canvas canvas = list[0];
					ListPool<Canvas>.Release(list);
					this.m_Template.gameObject.SetActive(true);
					this.m_Dropdown = this.CreateDropdownList(this.m_Template.gameObject);
					this.m_Dropdown.name = "Dropdown List";
					this.m_Dropdown.SetActive(true);
					RectTransform rectTransform = this.m_Dropdown.transform as RectTransform;
					rectTransform.SetParent(this.m_Template.transform.parent, false);
					Dropdown.DropdownItem componentInChildren = this.m_Dropdown.GetComponentInChildren<Dropdown.DropdownItem>();
					GameObject gameObject = componentInChildren.rectTransform.parent.gameObject;
					RectTransform rectTransform2 = gameObject.transform as RectTransform;
					componentInChildren.rectTransform.gameObject.SetActive(true);
					Rect rect = rectTransform2.rect;
					Rect rect2 = componentInChildren.rectTransform.rect;
					Vector2 vector = rect2.min - rect.min + componentInChildren.rectTransform.localPosition;
					Vector2 vector2 = rect2.max - rect.max + componentInChildren.rectTransform.localPosition;
					Vector2 size = rect2.size;
					this.m_Items.Clear();
					Toggle toggle = null;
					for (int i = 0; i < this.options.Count; i++)
					{
						Dropdown.OptionData data = this.options[i];
						Dropdown.DropdownItem item = this.AddItem(data, this.value == i, componentInChildren, this.m_Items);
						if (!(item == null))
						{
							item.toggle.isOn = (this.value == i);
							item.toggle.onValueChanged.AddListener(delegate(bool x)
							{
								this.OnSelectItem(item.toggle);
							});
							if (item.toggle.isOn)
							{
								item.toggle.Select();
							}
							if (toggle != null)
							{
								Navigation navigation = toggle.navigation;
								Navigation navigation2 = item.toggle.navigation;
								navigation.mode = Navigation.Mode.Explicit;
								navigation2.mode = Navigation.Mode.Explicit;
								navigation.selectOnDown = item.toggle;
								navigation.selectOnRight = item.toggle;
								navigation2.selectOnLeft = toggle;
								navigation2.selectOnUp = toggle;
								toggle.navigation = navigation;
								item.toggle.navigation = navigation2;
							}
							toggle = item.toggle;
						}
					}
					Vector2 sizeDelta = rectTransform2.sizeDelta;
					sizeDelta.y = size.y * (float)this.m_Items.Count + vector.y - vector2.y;
					rectTransform2.sizeDelta = sizeDelta;
					float num = rectTransform.rect.height - rectTransform2.rect.height;
					if (num > 0f)
					{
						rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, rectTransform.sizeDelta.y - num);
					}
					Vector3[] array = new Vector3[4];
					rectTransform.GetWorldCorners(array);
					RectTransform rectTransform3 = canvas.transform as RectTransform;
					Rect rect3 = rectTransform3.rect;
					for (int j = 0; j < 2; j++)
					{
						bool flag = false;
						for (int k = 0; k < 4; k++)
						{
							Vector3 vector3 = rectTransform3.InverseTransformPoint(array[k]);
							if (vector3[j] < rect3.min[j] || vector3[j] > rect3.max[j])
							{
								flag = true;
								break;
							}
						}
						if (flag)
						{
							RectTransformUtility.FlipLayoutOnAxis(rectTransform, j, false, false);
						}
					}
					for (int l = 0; l < this.m_Items.Count; l++)
					{
						RectTransform rectTransform4 = this.m_Items[l].rectTransform;
						rectTransform4.anchorMin = new Vector2(rectTransform4.anchorMin.x, 0f);
						rectTransform4.anchorMax = new Vector2(rectTransform4.anchorMax.x, 0f);
						rectTransform4.anchoredPosition = new Vector2(rectTransform4.anchoredPosition.x, vector.y + size.y * (float)(this.m_Items.Count - 1 - l) + size.y * rectTransform4.pivot.y);
						rectTransform4.sizeDelta = new Vector2(rectTransform4.sizeDelta.x, size.y);
					}
					this.AlphaFadeList(0.15f, 0f, 1f);
					this.m_Template.gameObject.SetActive(false);
					componentInChildren.gameObject.SetActive(false);
					this.m_Blocker = this.CreateBlocker(canvas);
				}
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000A4F0 File Offset: 0x000088F0
		protected virtual GameObject CreateBlocker(Canvas rootCanvas)
		{
			GameObject gameObject = new GameObject("Blocker");
			RectTransform rectTransform = gameObject.AddComponent<RectTransform>();
			rectTransform.SetParent(rootCanvas.transform, false);
			rectTransform.anchorMin = Vector3.zero;
			rectTransform.anchorMax = Vector3.one;
			rectTransform.sizeDelta = Vector2.zero;
			Canvas canvas = gameObject.AddComponent<Canvas>();
			canvas.overrideSorting = true;
			Canvas component = this.m_Dropdown.GetComponent<Canvas>();
			canvas.sortingLayerID = component.sortingLayerID;
			canvas.sortingOrder = component.sortingOrder - 1;
			gameObject.AddComponent<GraphicRaycaster>();
			Image image = gameObject.AddComponent<Image>();
			image.color = Color.clear;
			Button button = gameObject.AddComponent<Button>();
			button.onClick.AddListener(new UnityAction(this.Hide));
			return gameObject;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000A5C1 File Offset: 0x000089C1
		protected virtual void DestroyBlocker(GameObject blocker)
		{
			Object.Destroy(blocker);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000A5CC File Offset: 0x000089CC
		protected virtual GameObject CreateDropdownList(GameObject template)
		{
			return Object.Instantiate<GameObject>(template);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000A5E7 File Offset: 0x000089E7
		protected virtual void DestroyDropdownList(GameObject dropdownList)
		{
			Object.Destroy(dropdownList);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000A5F0 File Offset: 0x000089F0
		protected virtual Dropdown.DropdownItem CreateItem(Dropdown.DropdownItem itemTemplate)
		{
			return Object.Instantiate<Dropdown.DropdownItem>(itemTemplate);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000A60B File Offset: 0x00008A0B
		protected virtual void DestroyItem(Dropdown.DropdownItem item)
		{
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000A610 File Offset: 0x00008A10
		private Dropdown.DropdownItem AddItem(Dropdown.OptionData data, bool selected, Dropdown.DropdownItem itemTemplate, List<Dropdown.DropdownItem> items)
		{
			Dropdown.DropdownItem dropdownItem = this.CreateItem(itemTemplate);
			dropdownItem.rectTransform.SetParent(itemTemplate.rectTransform.parent, false);
			dropdownItem.gameObject.SetActive(true);
			dropdownItem.gameObject.name = "Item " + items.Count + ((data.text == null) ? "" : (": " + data.text));
			if (dropdownItem.toggle != null)
			{
				dropdownItem.toggle.isOn = false;
			}
			if (dropdownItem.text)
			{
				dropdownItem.text.text = data.text;
			}
			if (dropdownItem.image)
			{
				dropdownItem.image.sprite = data.image;
				dropdownItem.image.enabled = (dropdownItem.image.sprite != null);
			}
			items.Add(dropdownItem);
			return dropdownItem;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000A720 File Offset: 0x00008B20
		private void AlphaFadeList(float duration, float alpha)
		{
			CanvasGroup component = this.m_Dropdown.GetComponent<CanvasGroup>();
			this.AlphaFadeList(duration, component.alpha, alpha);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000A748 File Offset: 0x00008B48
		private void AlphaFadeList(float duration, float start, float end)
		{
			if (!end.Equals(start))
			{
				FloatTween info = new FloatTween
				{
					duration = duration,
					startValue = start,
					targetValue = end
				};
				info.AddOnChangedCallback(new UnityAction<float>(this.SetAlpha));
				info.ignoreTimeScale = true;
				this.m_AlphaTweenRunner.StartTween(info);
			}
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000A7B4 File Offset: 0x00008BB4
		private void SetAlpha(float alpha)
		{
			if (this.m_Dropdown)
			{
				CanvasGroup component = this.m_Dropdown.GetComponent<CanvasGroup>();
				component.alpha = alpha;
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000A7EC File Offset: 0x00008BEC
		public void Hide()
		{
			if (this.m_Dropdown != null)
			{
				this.AlphaFadeList(0.15f, 0f);
				if (this.IsActive())
				{
					base.StartCoroutine(this.DelayedDestroyDropdownList(0.15f));
				}
			}
			if (this.m_Blocker != null)
			{
				this.DestroyBlocker(this.m_Blocker);
			}
			this.m_Blocker = null;
			this.Select();
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000A864 File Offset: 0x00008C64
		private IEnumerator DelayedDestroyDropdownList(float delay)
		{
			yield return new WaitForSecondsRealtime(delay);
			for (int i = 0; i < this.m_Items.Count; i++)
			{
				if (this.m_Items[i] != null)
				{
					this.DestroyItem(this.m_Items[i]);
				}
			}
			this.m_Items.Clear();
			if (this.m_Dropdown != null)
			{
				this.DestroyDropdownList(this.m_Dropdown);
			}
			this.m_Dropdown = null;
			yield break;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000A890 File Offset: 0x00008C90
		private void OnSelectItem(Toggle toggle)
		{
			if (!toggle.isOn)
			{
				toggle.isOn = true;
			}
			int num = -1;
			Transform transform = toggle.transform;
			Transform parent = transform.parent;
			for (int i = 0; i < parent.childCount; i++)
			{
				if (parent.GetChild(i) == transform)
				{
					num = i - 1;
					break;
				}
			}
			if (num >= 0)
			{
				this.value = num;
				this.Hide();
			}
		}

		// Token: 0x040000E3 RID: 227
		[SerializeField]
		private RectTransform m_Template;

		// Token: 0x040000E4 RID: 228
		[SerializeField]
		private Text m_CaptionText;

		// Token: 0x040000E5 RID: 229
		[SerializeField]
		private Image m_CaptionImage;

		// Token: 0x040000E6 RID: 230
		[Space]
		[SerializeField]
		private Text m_ItemText;

		// Token: 0x040000E7 RID: 231
		[SerializeField]
		private Image m_ItemImage;

		// Token: 0x040000E8 RID: 232
		[Space]
		[SerializeField]
		private int m_Value;

		// Token: 0x040000E9 RID: 233
		[Space]
		[SerializeField]
		private Dropdown.OptionDataList m_Options = new Dropdown.OptionDataList();

		// Token: 0x040000EA RID: 234
		[Space]
		[SerializeField]
		private Dropdown.DropdownEvent m_OnValueChanged = new Dropdown.DropdownEvent();

		// Token: 0x040000EB RID: 235
		private GameObject m_Dropdown;

		// Token: 0x040000EC RID: 236
		private GameObject m_Blocker;

		// Token: 0x040000ED RID: 237
		private List<Dropdown.DropdownItem> m_Items = new List<Dropdown.DropdownItem>();

		// Token: 0x040000EE RID: 238
		private TweenRunner<FloatTween> m_AlphaTweenRunner;

		// Token: 0x040000EF RID: 239
		private bool validTemplate = false;

		// Token: 0x040000F0 RID: 240
		private static Dropdown.OptionData s_NoOptionData = new Dropdown.OptionData();

		// Token: 0x02000043 RID: 67
		protected internal class DropdownItem : MonoBehaviour, IPointerEnterHandler, ICancelHandler, IEventSystemHandler
		{
			// Token: 0x17000079 RID: 121
			// (get) Token: 0x060001EF RID: 495 RVA: 0x0000A924 File Offset: 0x00008D24
			// (set) Token: 0x060001F0 RID: 496 RVA: 0x0000A93F File Offset: 0x00008D3F
			public Text text
			{
				get
				{
					return this.m_Text;
				}
				set
				{
					this.m_Text = value;
				}
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x060001F1 RID: 497 RVA: 0x0000A94C File Offset: 0x00008D4C
			// (set) Token: 0x060001F2 RID: 498 RVA: 0x0000A967 File Offset: 0x00008D67
			public Image image
			{
				get
				{
					return this.m_Image;
				}
				set
				{
					this.m_Image = value;
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x060001F3 RID: 499 RVA: 0x0000A974 File Offset: 0x00008D74
			// (set) Token: 0x060001F4 RID: 500 RVA: 0x0000A98F File Offset: 0x00008D8F
			public RectTransform rectTransform
			{
				get
				{
					return this.m_RectTransform;
				}
				set
				{
					this.m_RectTransform = value;
				}
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x060001F5 RID: 501 RVA: 0x0000A99C File Offset: 0x00008D9C
			// (set) Token: 0x060001F6 RID: 502 RVA: 0x0000A9B7 File Offset: 0x00008DB7
			public Toggle toggle
			{
				get
				{
					return this.m_Toggle;
				}
				set
				{
					this.m_Toggle = value;
				}
			}

			// Token: 0x060001F7 RID: 503 RVA: 0x0000A9C1 File Offset: 0x00008DC1
			public virtual void OnPointerEnter(PointerEventData eventData)
			{
				EventSystem.current.SetSelectedGameObject(base.gameObject);
			}

			// Token: 0x060001F8 RID: 504 RVA: 0x0000A9D4 File Offset: 0x00008DD4
			public virtual void OnCancel(BaseEventData eventData)
			{
				Dropdown componentInParent = base.GetComponentInParent<Dropdown>();
				if (componentInParent)
				{
					componentInParent.Hide();
				}
			}

			// Token: 0x040000F1 RID: 241
			[SerializeField]
			private Text m_Text;

			// Token: 0x040000F2 RID: 242
			[SerializeField]
			private Image m_Image;

			// Token: 0x040000F3 RID: 243
			[SerializeField]
			private RectTransform m_RectTransform;

			// Token: 0x040000F4 RID: 244
			[SerializeField]
			private Toggle m_Toggle;
		}

		// Token: 0x02000044 RID: 68
		[Serializable]
		public class OptionData
		{
			// Token: 0x060001F9 RID: 505 RVA: 0x0000A9FA File Offset: 0x00008DFA
			public OptionData()
			{
			}

			// Token: 0x060001FA RID: 506 RVA: 0x0000AA03 File Offset: 0x00008E03
			public OptionData(string text)
			{
				this.text = text;
			}

			// Token: 0x060001FB RID: 507 RVA: 0x0000AA13 File Offset: 0x00008E13
			public OptionData(Sprite image)
			{
				this.image = image;
			}

			// Token: 0x060001FC RID: 508 RVA: 0x0000AA23 File Offset: 0x00008E23
			public OptionData(string text, Sprite image)
			{
				this.text = text;
				this.image = image;
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x060001FD RID: 509 RVA: 0x0000AA3C File Offset: 0x00008E3C
			// (set) Token: 0x060001FE RID: 510 RVA: 0x0000AA57 File Offset: 0x00008E57
			public string text
			{
				get
				{
					return this.m_Text;
				}
				set
				{
					this.m_Text = value;
				}
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x060001FF RID: 511 RVA: 0x0000AA64 File Offset: 0x00008E64
			// (set) Token: 0x06000200 RID: 512 RVA: 0x0000AA7F File Offset: 0x00008E7F
			public Sprite image
			{
				get
				{
					return this.m_Image;
				}
				set
				{
					this.m_Image = value;
				}
			}

			// Token: 0x040000F5 RID: 245
			[SerializeField]
			private string m_Text;

			// Token: 0x040000F6 RID: 246
			[SerializeField]
			private Sprite m_Image;
		}

		// Token: 0x02000045 RID: 69
		[Serializable]
		public class OptionDataList
		{
			// Token: 0x06000201 RID: 513 RVA: 0x0000AA89 File Offset: 0x00008E89
			public OptionDataList()
			{
				this.options = new List<Dropdown.OptionData>();
			}

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x06000202 RID: 514 RVA: 0x0000AAA0 File Offset: 0x00008EA0
			// (set) Token: 0x06000203 RID: 515 RVA: 0x0000AABB File Offset: 0x00008EBB
			public List<Dropdown.OptionData> options
			{
				get
				{
					return this.m_Options;
				}
				set
				{
					this.m_Options = value;
				}
			}

			// Token: 0x040000F7 RID: 247
			[SerializeField]
			private List<Dropdown.OptionData> m_Options;
		}

		// Token: 0x02000046 RID: 70
		[Serializable]
		public class DropdownEvent : UnityEvent<int>
		{
		}
	}
}
