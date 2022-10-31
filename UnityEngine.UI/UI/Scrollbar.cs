using System;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200006A RID: 106
	[AddComponentMenu("UI/Scrollbar", 34)]
	[RequireComponent(typeof(RectTransform))]
	public class Scrollbar : Selectable, IBeginDragHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement, IEventSystemHandler
	{
		// Token: 0x06000393 RID: 915 RVA: 0x00014E3C File Offset: 0x0001323C
		protected Scrollbar()
		{
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00014E7C File Offset: 0x0001327C
		// (set) Token: 0x06000395 RID: 917 RVA: 0x00014E97 File Offset: 0x00013297
		public RectTransform handleRect
		{
			get
			{
				return this.m_HandleRect;
			}
			set
			{
				if (SetPropertyUtility.SetClass<RectTransform>(ref this.m_HandleRect, value))
				{
					this.UpdateCachedReferences();
					this.UpdateVisuals();
				}
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00014EBC File Offset: 0x000132BC
		// (set) Token: 0x06000397 RID: 919 RVA: 0x00014ED7 File Offset: 0x000132D7
		public Scrollbar.Direction direction
		{
			get
			{
				return this.m_Direction;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<Scrollbar.Direction>(ref this.m_Direction, value))
				{
					this.UpdateVisuals();
				}
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00014EF4 File Offset: 0x000132F4
		// (set) Token: 0x06000399 RID: 921 RVA: 0x00014F38 File Offset: 0x00013338
		public float value
		{
			get
			{
				float num = this.m_Value;
				if (this.m_NumberOfSteps > 1)
				{
					num = Mathf.Round(num * (float)(this.m_NumberOfSteps - 1)) / (float)(this.m_NumberOfSteps - 1);
				}
				return num;
			}
			set
			{
				this.Set(value);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00014F44 File Offset: 0x00013344
		// (set) Token: 0x0600039B RID: 923 RVA: 0x00014F5F File Offset: 0x0001335F
		public float size
		{
			get
			{
				return this.m_Size;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<float>(ref this.m_Size, Mathf.Clamp01(value)))
				{
					this.UpdateVisuals();
				}
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00014F80 File Offset: 0x00013380
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00014F9B File Offset: 0x0001339B
		public int numberOfSteps
		{
			get
			{
				return this.m_NumberOfSteps;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<int>(ref this.m_NumberOfSteps, value))
				{
					this.Set(this.m_Value);
					this.UpdateVisuals();
				}
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00014FC4 File Offset: 0x000133C4
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00014FDF File Offset: 0x000133DF
		public Scrollbar.ScrollEvent onValueChanged
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

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00014FEC File Offset: 0x000133EC
		private float stepSize
		{
			get
			{
				return (this.m_NumberOfSteps <= 1) ? 0.1f : (1f / (float)(this.m_NumberOfSteps - 1));
			}
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00015026 File Offset: 0x00013426
		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00015029 File Offset: 0x00013429
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0001502C File Offset: 0x0001342C
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0001502F File Offset: 0x0001342F
		protected override void OnEnable()
		{
			base.OnEnable();
			this.UpdateCachedReferences();
			this.Set(this.m_Value, false);
			this.UpdateVisuals();
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00015051 File Offset: 0x00013451
		protected override void OnDisable()
		{
			this.m_Tracker.Clear();
			base.OnDisable();
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00015068 File Offset: 0x00013468
		private void UpdateCachedReferences()
		{
			if (this.m_HandleRect && this.m_HandleRect.parent != null)
			{
				this.m_ContainerRect = this.m_HandleRect.parent.GetComponent<RectTransform>();
			}
			else
			{
				this.m_ContainerRect = null;
			}
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000150BE File Offset: 0x000134BE
		private void Set(float input)
		{
			this.Set(input, true);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x000150CC File Offset: 0x000134CC
		private void Set(float input, bool sendCallback)
		{
			float value = this.m_Value;
			this.m_Value = Mathf.Clamp01(input);
			if (value != this.value)
			{
				this.UpdateVisuals();
				if (sendCallback)
				{
					this.m_OnValueChanged.Invoke(this.value);
				}
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0001511B File Offset: 0x0001351B
		protected override void OnRectTransformDimensionsChange()
		{
			base.OnRectTransformDimensionsChange();
			if (this.IsActive())
			{
				this.UpdateVisuals();
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0001513C File Offset: 0x0001353C
		private Scrollbar.Axis axis
		{
			get
			{
				return (this.m_Direction != Scrollbar.Direction.LeftToRight && this.m_Direction != Scrollbar.Direction.RightToLeft) ? Scrollbar.Axis.Vertical : Scrollbar.Axis.Horizontal;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060003AB RID: 939 RVA: 0x00015170 File Offset: 0x00013570
		private bool reverseValue
		{
			get
			{
				return this.m_Direction == Scrollbar.Direction.RightToLeft || this.m_Direction == Scrollbar.Direction.TopToBottom;
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x000151A0 File Offset: 0x000135A0
		private void UpdateVisuals()
		{
			this.m_Tracker.Clear();
			if (this.m_ContainerRect != null)
			{
				this.m_Tracker.Add(this, this.m_HandleRect, DrivenTransformProperties.Anchors);
				Vector2 zero = Vector2.zero;
				Vector2 one = Vector2.one;
				float num = this.value * (1f - this.size);
				if (this.reverseValue)
				{
					zero[(int)this.axis] = 1f - num - this.size;
					one[(int)this.axis] = 1f - num;
				}
				else
				{
					zero[(int)this.axis] = num;
					one[(int)this.axis] = num + this.size;
				}
				this.m_HandleRect.anchorMin = zero;
				this.m_HandleRect.anchorMax = one;
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00015284 File Offset: 0x00013684
		private void UpdateDrag(PointerEventData eventData)
		{
			if (eventData.button == PointerEventData.InputButton.Left)
			{
				if (!(this.m_ContainerRect == null))
				{
					Vector2 a;
					if (RectTransformUtility.ScreenPointToLocalPointInRectangle(this.m_ContainerRect, eventData.position, eventData.pressEventCamera, out a))
					{
						Vector2 a2 = a - this.m_Offset - this.m_ContainerRect.rect.position;
						Vector2 vector = a2 - (this.m_HandleRect.rect.size - this.m_HandleRect.sizeDelta) * 0.5f;
						float num = (this.axis != Scrollbar.Axis.Horizontal) ? this.m_ContainerRect.rect.height : this.m_ContainerRect.rect.width;
						float num2 = num * (1f - this.size);
						if (num2 > 0f)
						{
							switch (this.m_Direction)
							{
							case Scrollbar.Direction.LeftToRight:
								this.Set(vector.x / num2);
								break;
							case Scrollbar.Direction.RightToLeft:
								this.Set(1f - vector.x / num2);
								break;
							case Scrollbar.Direction.BottomToTop:
								this.Set(vector.y / num2);
								break;
							case Scrollbar.Direction.TopToBottom:
								this.Set(1f - vector.y / num2);
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00015418 File Offset: 0x00013818
		private bool MayDrag(PointerEventData eventData)
		{
			return this.IsActive() && this.IsInteractable() && eventData.button == PointerEventData.InputButton.Left;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00015450 File Offset: 0x00013850
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
			this.isPointerDownAndNotDragging = false;
			if (this.MayDrag(eventData))
			{
				if (!(this.m_ContainerRect == null))
				{
					this.m_Offset = Vector2.zero;
					if (RectTransformUtility.RectangleContainsScreenPoint(this.m_HandleRect, eventData.position, eventData.enterEventCamera))
					{
						Vector2 a;
						if (RectTransformUtility.ScreenPointToLocalPointInRectangle(this.m_HandleRect, eventData.position, eventData.pressEventCamera, out a))
						{
							this.m_Offset = a - this.m_HandleRect.rect.center;
						}
					}
				}
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x000154F2 File Offset: 0x000138F2
		public virtual void OnDrag(PointerEventData eventData)
		{
			if (this.MayDrag(eventData))
			{
				if (this.m_ContainerRect != null)
				{
					this.UpdateDrag(eventData);
				}
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0001551E File Offset: 0x0001391E
		public override void OnPointerDown(PointerEventData eventData)
		{
			if (this.MayDrag(eventData))
			{
				base.OnPointerDown(eventData);
				this.isPointerDownAndNotDragging = true;
				this.m_PointerDownRepeat = base.StartCoroutine(this.ClickRepeat(eventData));
			}
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00015554 File Offset: 0x00013954
		protected IEnumerator ClickRepeat(PointerEventData eventData)
		{
			while (this.isPointerDownAndNotDragging)
			{
				if (!RectTransformUtility.RectangleContainsScreenPoint(this.m_HandleRect, eventData.position, eventData.enterEventCamera))
				{
					Vector2 vector;
					if (RectTransformUtility.ScreenPointToLocalPointInRectangle(this.m_HandleRect, eventData.position, eventData.pressEventCamera, out vector))
					{
						float num = (this.axis != Scrollbar.Axis.Horizontal) ? vector.y : vector.x;
						if (num < 0f)
						{
							this.value -= this.size;
						}
						else
						{
							this.value += this.size;
						}
					}
				}
				yield return new WaitForEndOfFrame();
			}
			base.StopCoroutine(this.m_PointerDownRepeat);
			yield break;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0001557D File Offset: 0x0001397D
		public override void OnPointerUp(PointerEventData eventData)
		{
			base.OnPointerUp(eventData);
			this.isPointerDownAndNotDragging = false;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00015590 File Offset: 0x00013990
		public override void OnMove(AxisEventData eventData)
		{
			if (!this.IsActive() || !this.IsInteractable())
			{
				base.OnMove(eventData);
			}
			else
			{
				switch (eventData.moveDir)
				{
				case MoveDirection.Left:
					if (this.axis == Scrollbar.Axis.Horizontal && this.FindSelectableOnLeft() == null)
					{
						this.Set((!this.reverseValue) ? (this.value - this.stepSize) : (this.value + this.stepSize));
					}
					else
					{
						base.OnMove(eventData);
					}
					break;
				case MoveDirection.Up:
					if (this.axis == Scrollbar.Axis.Vertical && this.FindSelectableOnUp() == null)
					{
						this.Set((!this.reverseValue) ? (this.value + this.stepSize) : (this.value - this.stepSize));
					}
					else
					{
						base.OnMove(eventData);
					}
					break;
				case MoveDirection.Right:
					if (this.axis == Scrollbar.Axis.Horizontal && this.FindSelectableOnRight() == null)
					{
						this.Set((!this.reverseValue) ? (this.value + this.stepSize) : (this.value - this.stepSize));
					}
					else
					{
						base.OnMove(eventData);
					}
					break;
				case MoveDirection.Down:
					if (this.axis == Scrollbar.Axis.Vertical && this.FindSelectableOnDown() == null)
					{
						this.Set((!this.reverseValue) ? (this.value - this.stepSize) : (this.value + this.stepSize));
					}
					else
					{
						base.OnMove(eventData);
					}
					break;
				}
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0001575C File Offset: 0x00013B5C
		public override Selectable FindSelectableOnLeft()
		{
			Selectable result;
			if (base.navigation.mode == Navigation.Mode.Automatic && this.axis == Scrollbar.Axis.Horizontal)
			{
				result = null;
			}
			else
			{
				result = base.FindSelectableOnLeft();
			}
			return result;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x000157A0 File Offset: 0x00013BA0
		public override Selectable FindSelectableOnRight()
		{
			Selectable result;
			if (base.navigation.mode == Navigation.Mode.Automatic && this.axis == Scrollbar.Axis.Horizontal)
			{
				result = null;
			}
			else
			{
				result = base.FindSelectableOnRight();
			}
			return result;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x000157E4 File Offset: 0x00013BE4
		public override Selectable FindSelectableOnUp()
		{
			Selectable result;
			if (base.navigation.mode == Navigation.Mode.Automatic && this.axis == Scrollbar.Axis.Vertical)
			{
				result = null;
			}
			else
			{
				result = base.FindSelectableOnUp();
			}
			return result;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00015828 File Offset: 0x00013C28
		public override Selectable FindSelectableOnDown()
		{
			Selectable result;
			if (base.navigation.mode == Navigation.Mode.Automatic && this.axis == Scrollbar.Axis.Vertical)
			{
				result = null;
			}
			else
			{
				result = base.FindSelectableOnDown();
			}
			return result;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0001586A File Offset: 0x00013C6A
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
			eventData.useDragThreshold = false;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00015874 File Offset: 0x00013C74
		public void SetDirection(Scrollbar.Direction direction, bool includeRectLayouts)
		{
			Scrollbar.Axis axis = this.axis;
			bool reverseValue = this.reverseValue;
			this.direction = direction;
			if (includeRectLayouts)
			{
				if (this.axis != axis)
				{
					RectTransformUtility.FlipLayoutAxes(base.transform as RectTransform, true, true);
				}
				if (this.reverseValue != reverseValue)
				{
					RectTransformUtility.FlipLayoutOnAxis(base.transform as RectTransform, (int)this.axis, true, true);
				}
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x000158E4 File Offset: 0x00013CE4
		Transform ICanvasElement.get_transform()
		{
			return base.transform;
		}

		// Token: 0x040001C6 RID: 454
		[SerializeField]
		private RectTransform m_HandleRect;

		// Token: 0x040001C7 RID: 455
		[SerializeField]
		private Scrollbar.Direction m_Direction = Scrollbar.Direction.LeftToRight;

		// Token: 0x040001C8 RID: 456
		[Range(0f, 1f)]
		[SerializeField]
		private float m_Value;

		// Token: 0x040001C9 RID: 457
		[Range(0f, 1f)]
		[SerializeField]
		private float m_Size = 0.2f;

		// Token: 0x040001CA RID: 458
		[Range(0f, 11f)]
		[SerializeField]
		private int m_NumberOfSteps = 0;

		// Token: 0x040001CB RID: 459
		[Space(6f)]
		[SerializeField]
		private Scrollbar.ScrollEvent m_OnValueChanged = new Scrollbar.ScrollEvent();

		// Token: 0x040001CC RID: 460
		private RectTransform m_ContainerRect;

		// Token: 0x040001CD RID: 461
		private Vector2 m_Offset = Vector2.zero;

		// Token: 0x040001CE RID: 462
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x040001CF RID: 463
		private Coroutine m_PointerDownRepeat;

		// Token: 0x040001D0 RID: 464
		private bool isPointerDownAndNotDragging = false;

		// Token: 0x0200006B RID: 107
		public enum Direction
		{
			// Token: 0x040001D2 RID: 466
			LeftToRight,
			// Token: 0x040001D3 RID: 467
			RightToLeft,
			// Token: 0x040001D4 RID: 468
			BottomToTop,
			// Token: 0x040001D5 RID: 469
			TopToBottom
		}

		// Token: 0x0200006C RID: 108
		[Serializable]
		public class ScrollEvent : UnityEvent<float>
		{
		}

		// Token: 0x0200006D RID: 109
		private enum Axis
		{
			// Token: 0x040001D7 RID: 471
			Horizontal,
			// Token: 0x040001D8 RID: 472
			Vertical
		}
	}
}
