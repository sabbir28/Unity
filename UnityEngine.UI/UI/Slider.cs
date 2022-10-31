using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000076 RID: 118
	[AddComponentMenu("UI/Slider", 33)]
	[RequireComponent(typeof(RectTransform))]
	public class Slider : Selectable, IDragHandler, IInitializePotentialDragHandler, ICanvasElement, IEventSystemHandler
	{
		// Token: 0x06000458 RID: 1112 RVA: 0x00017DAC File Offset: 0x000161AC
		protected Slider()
		{
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x00017DFC File Offset: 0x000161FC
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x00017E17 File Offset: 0x00016217
		public RectTransform fillRect
		{
			get
			{
				return this.m_FillRect;
			}
			set
			{
				if (SetPropertyUtility.SetClass<RectTransform>(ref this.m_FillRect, value))
				{
					this.UpdateCachedReferences();
					this.UpdateVisuals();
				}
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x00017E3C File Offset: 0x0001623C
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x00017E57 File Offset: 0x00016257
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

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x00017E7C File Offset: 0x0001627C
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x00017E97 File Offset: 0x00016297
		public Slider.Direction direction
		{
			get
			{
				return this.m_Direction;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<Slider.Direction>(ref this.m_Direction, value))
				{
					this.UpdateVisuals();
				}
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x00017EB4 File Offset: 0x000162B4
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x00017ECF File Offset: 0x000162CF
		public float minValue
		{
			get
			{
				return this.m_MinValue;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<float>(ref this.m_MinValue, value))
				{
					this.Set(this.m_Value);
					this.UpdateVisuals();
				}
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x00017EF8 File Offset: 0x000162F8
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x00017F13 File Offset: 0x00016313
		public float maxValue
		{
			get
			{
				return this.m_MaxValue;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<float>(ref this.m_MaxValue, value))
				{
					this.Set(this.m_Value);
					this.UpdateVisuals();
				}
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x00017F3C File Offset: 0x0001633C
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x00017F57 File Offset: 0x00016357
		public bool wholeNumbers
		{
			get
			{
				return this.m_WholeNumbers;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<bool>(ref this.m_WholeNumbers, value))
				{
					this.Set(this.m_Value);
					this.UpdateVisuals();
				}
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x00017F80 File Offset: 0x00016380
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x00017FB7 File Offset: 0x000163B7
		public virtual float value
		{
			get
			{
				float result;
				if (this.wholeNumbers)
				{
					result = Mathf.Round(this.m_Value);
				}
				else
				{
					result = this.m_Value;
				}
				return result;
			}
			set
			{
				this.Set(value);
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00017FC4 File Offset: 0x000163C4
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x00018011 File Offset: 0x00016411
		public float normalizedValue
		{
			get
			{
				float result;
				if (Mathf.Approximately(this.minValue, this.maxValue))
				{
					result = 0f;
				}
				else
				{
					result = Mathf.InverseLerp(this.minValue, this.maxValue, this.value);
				}
				return result;
			}
			set
			{
				this.value = Mathf.Lerp(this.minValue, this.maxValue, value);
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x0001802C File Offset: 0x0001642C
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x00018047 File Offset: 0x00016447
		public Slider.SliderEvent onValueChanged
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

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x00018054 File Offset: 0x00016454
		private float stepSize
		{
			get
			{
				return (!this.wholeNumbers) ? ((this.maxValue - this.minValue) * 0.1f) : 1f;
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00018091 File Offset: 0x00016491
		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00018094 File Offset: 0x00016494
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00018097 File Offset: 0x00016497
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0001809A File Offset: 0x0001649A
		protected override void OnEnable()
		{
			base.OnEnable();
			this.UpdateCachedReferences();
			this.Set(this.m_Value, false);
			this.UpdateVisuals();
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x000180BC File Offset: 0x000164BC
		protected override void OnDisable()
		{
			this.m_Tracker.Clear();
			base.OnDisable();
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x000180D0 File Offset: 0x000164D0
		protected override void OnDidApplyAnimationProperties()
		{
			this.m_Value = this.ClampValue(this.m_Value);
			float num = this.normalizedValue;
			if (this.m_FillContainerRect != null)
			{
				if (this.m_FillImage != null && this.m_FillImage.type == Image.Type.Filled)
				{
					num = this.m_FillImage.fillAmount;
				}
				else
				{
					num = ((!this.reverseValue) ? this.m_FillRect.anchorMax[(int)this.axis] : (1f - this.m_FillRect.anchorMin[(int)this.axis]));
				}
			}
			else if (this.m_HandleContainerRect != null)
			{
				num = ((!this.reverseValue) ? this.m_HandleRect.anchorMin[(int)this.axis] : (1f - this.m_HandleRect.anchorMin[(int)this.axis]));
			}
			this.UpdateVisuals();
			if (num != this.normalizedValue)
			{
				this.onValueChanged.Invoke(this.m_Value);
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0001820C File Offset: 0x0001660C
		private void UpdateCachedReferences()
		{
			if (this.m_FillRect)
			{
				this.m_FillTransform = this.m_FillRect.transform;
				this.m_FillImage = this.m_FillRect.GetComponent<Image>();
				if (this.m_FillTransform.parent != null)
				{
					this.m_FillContainerRect = this.m_FillTransform.parent.GetComponent<RectTransform>();
				}
			}
			else
			{
				this.m_FillContainerRect = null;
				this.m_FillImage = null;
			}
			if (this.m_HandleRect)
			{
				this.m_HandleTransform = this.m_HandleRect.transform;
				if (this.m_HandleTransform.parent != null)
				{
					this.m_HandleContainerRect = this.m_HandleTransform.parent.GetComponent<RectTransform>();
				}
			}
			else
			{
				this.m_HandleContainerRect = null;
			}
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x000182EC File Offset: 0x000166EC
		private float ClampValue(float input)
		{
			float num = Mathf.Clamp(input, this.minValue, this.maxValue);
			if (this.wholeNumbers)
			{
				num = Mathf.Round(num);
			}
			return num;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00018327 File Offset: 0x00016727
		private void Set(float input)
		{
			this.Set(input, true);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00018334 File Offset: 0x00016734
		protected virtual void Set(float input, bool sendCallback)
		{
			float num = this.ClampValue(input);
			if (this.m_Value != num)
			{
				this.m_Value = num;
				this.UpdateVisuals();
				if (sendCallback)
				{
					this.m_OnValueChanged.Invoke(num);
				}
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0001837A File Offset: 0x0001677A
		protected override void OnRectTransformDimensionsChange()
		{
			base.OnRectTransformDimensionsChange();
			if (this.IsActive())
			{
				this.UpdateVisuals();
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x0001839C File Offset: 0x0001679C
		private Slider.Axis axis
		{
			get
			{
				return (this.m_Direction != Slider.Direction.LeftToRight && this.m_Direction != Slider.Direction.RightToLeft) ? Slider.Axis.Vertical : Slider.Axis.Horizontal;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x000183D0 File Offset: 0x000167D0
		private bool reverseValue
		{
			get
			{
				return this.m_Direction == Slider.Direction.RightToLeft || this.m_Direction == Slider.Direction.TopToBottom;
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00018400 File Offset: 0x00016800
		private void UpdateVisuals()
		{
			this.m_Tracker.Clear();
			if (this.m_FillContainerRect != null)
			{
				this.m_Tracker.Add(this, this.m_FillRect, DrivenTransformProperties.Anchors);
				Vector2 zero = Vector2.zero;
				Vector2 one = Vector2.one;
				if (this.m_FillImage != null && this.m_FillImage.type == Image.Type.Filled)
				{
					this.m_FillImage.fillAmount = this.normalizedValue;
				}
				else if (this.reverseValue)
				{
					zero[(int)this.axis] = 1f - this.normalizedValue;
				}
				else
				{
					one[(int)this.axis] = this.normalizedValue;
				}
				this.m_FillRect.anchorMin = zero;
				this.m_FillRect.anchorMax = one;
			}
			if (this.m_HandleContainerRect != null)
			{
				this.m_Tracker.Add(this, this.m_HandleRect, DrivenTransformProperties.Anchors);
				Vector2 zero2 = Vector2.zero;
				Vector2 one2 = Vector2.one;
				int axis = (int)this.axis;
				float value = (!this.reverseValue) ? this.normalizedValue : (1f - this.normalizedValue);
				one2[(int)this.axis] = value;
				zero2[axis] = value;
				this.m_HandleRect.anchorMin = zero2;
				this.m_HandleRect.anchorMax = one2;
			}
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00018570 File Offset: 0x00016970
		private void UpdateDrag(PointerEventData eventData, Camera cam)
		{
			RectTransform rectTransform = this.m_HandleContainerRect ?? this.m_FillContainerRect;
			if (rectTransform != null && rectTransform.rect.size[(int)this.axis] > 0f)
			{
				Vector2 a;
				if (RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, eventData.position, cam, out a))
				{
					a -= rectTransform.rect.position;
					float num = Mathf.Clamp01((a - this.m_Offset)[(int)this.axis] / rectTransform.rect.size[(int)this.axis]);
					this.normalizedValue = ((!this.reverseValue) ? num : (1f - num));
				}
			}
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00018658 File Offset: 0x00016A58
		private bool MayDrag(PointerEventData eventData)
		{
			return this.IsActive() && this.IsInteractable() && eventData.button == PointerEventData.InputButton.Left;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00018690 File Offset: 0x00016A90
		public override void OnPointerDown(PointerEventData eventData)
		{
			if (this.MayDrag(eventData))
			{
				base.OnPointerDown(eventData);
				this.m_Offset = Vector2.zero;
				if (this.m_HandleContainerRect != null && RectTransformUtility.RectangleContainsScreenPoint(this.m_HandleRect, eventData.position, eventData.enterEventCamera))
				{
					Vector2 offset;
					if (RectTransformUtility.ScreenPointToLocalPointInRectangle(this.m_HandleRect, eventData.position, eventData.pressEventCamera, out offset))
					{
						this.m_Offset = offset;
					}
				}
				else
				{
					this.UpdateDrag(eventData, eventData.pressEventCamera);
				}
			}
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00018729 File Offset: 0x00016B29
		public virtual void OnDrag(PointerEventData eventData)
		{
			if (this.MayDrag(eventData))
			{
				this.UpdateDrag(eventData, eventData.pressEventCamera);
			}
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0001874C File Offset: 0x00016B4C
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
					if (this.axis == Slider.Axis.Horizontal && this.FindSelectableOnLeft() == null)
					{
						this.Set((!this.reverseValue) ? (this.value - this.stepSize) : (this.value + this.stepSize));
					}
					else
					{
						base.OnMove(eventData);
					}
					break;
				case MoveDirection.Up:
					if (this.axis == Slider.Axis.Vertical && this.FindSelectableOnUp() == null)
					{
						this.Set((!this.reverseValue) ? (this.value + this.stepSize) : (this.value - this.stepSize));
					}
					else
					{
						base.OnMove(eventData);
					}
					break;
				case MoveDirection.Right:
					if (this.axis == Slider.Axis.Horizontal && this.FindSelectableOnRight() == null)
					{
						this.Set((!this.reverseValue) ? (this.value + this.stepSize) : (this.value - this.stepSize));
					}
					else
					{
						base.OnMove(eventData);
					}
					break;
				case MoveDirection.Down:
					if (this.axis == Slider.Axis.Vertical && this.FindSelectableOnDown() == null)
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

		// Token: 0x0600047F RID: 1151 RVA: 0x00018918 File Offset: 0x00016D18
		public override Selectable FindSelectableOnLeft()
		{
			Selectable result;
			if (base.navigation.mode == Navigation.Mode.Automatic && this.axis == Slider.Axis.Horizontal)
			{
				result = null;
			}
			else
			{
				result = base.FindSelectableOnLeft();
			}
			return result;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0001895C File Offset: 0x00016D5C
		public override Selectable FindSelectableOnRight()
		{
			Selectable result;
			if (base.navigation.mode == Navigation.Mode.Automatic && this.axis == Slider.Axis.Horizontal)
			{
				result = null;
			}
			else
			{
				result = base.FindSelectableOnRight();
			}
			return result;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x000189A0 File Offset: 0x00016DA0
		public override Selectable FindSelectableOnUp()
		{
			Selectable result;
			if (base.navigation.mode == Navigation.Mode.Automatic && this.axis == Slider.Axis.Vertical)
			{
				result = null;
			}
			else
			{
				result = base.FindSelectableOnUp();
			}
			return result;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x000189E4 File Offset: 0x00016DE4
		public override Selectable FindSelectableOnDown()
		{
			Selectable result;
			if (base.navigation.mode == Navigation.Mode.Automatic && this.axis == Slider.Axis.Vertical)
			{
				result = null;
			}
			else
			{
				result = base.FindSelectableOnDown();
			}
			return result;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00018A26 File Offset: 0x00016E26
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
			eventData.useDragThreshold = false;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00018A30 File Offset: 0x00016E30
		public void SetDirection(Slider.Direction direction, bool includeRectLayouts)
		{
			Slider.Axis axis = this.axis;
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

		// Token: 0x06000485 RID: 1157 RVA: 0x00018AA0 File Offset: 0x00016EA0
		Transform ICanvasElement.get_transform()
		{
			return base.transform;
		}

		// Token: 0x0400021D RID: 541
		[SerializeField]
		private RectTransform m_FillRect;

		// Token: 0x0400021E RID: 542
		[SerializeField]
		private RectTransform m_HandleRect;

		// Token: 0x0400021F RID: 543
		[Space]
		[SerializeField]
		private Slider.Direction m_Direction = Slider.Direction.LeftToRight;

		// Token: 0x04000220 RID: 544
		[SerializeField]
		private float m_MinValue = 0f;

		// Token: 0x04000221 RID: 545
		[SerializeField]
		private float m_MaxValue = 1f;

		// Token: 0x04000222 RID: 546
		[SerializeField]
		private bool m_WholeNumbers = false;

		// Token: 0x04000223 RID: 547
		[SerializeField]
		protected float m_Value;

		// Token: 0x04000224 RID: 548
		[Space]
		[SerializeField]
		private Slider.SliderEvent m_OnValueChanged = new Slider.SliderEvent();

		// Token: 0x04000225 RID: 549
		private Image m_FillImage;

		// Token: 0x04000226 RID: 550
		private Transform m_FillTransform;

		// Token: 0x04000227 RID: 551
		private RectTransform m_FillContainerRect;

		// Token: 0x04000228 RID: 552
		private Transform m_HandleTransform;

		// Token: 0x04000229 RID: 553
		private RectTransform m_HandleContainerRect;

		// Token: 0x0400022A RID: 554
		private Vector2 m_Offset = Vector2.zero;

		// Token: 0x0400022B RID: 555
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x02000077 RID: 119
		public enum Direction
		{
			// Token: 0x0400022D RID: 557
			LeftToRight,
			// Token: 0x0400022E RID: 558
			RightToLeft,
			// Token: 0x0400022F RID: 559
			BottomToTop,
			// Token: 0x04000230 RID: 560
			TopToBottom
		}

		// Token: 0x02000078 RID: 120
		[Serializable]
		public class SliderEvent : UnityEvent<float>
		{
		}

		// Token: 0x02000079 RID: 121
		private enum Axis
		{
			// Token: 0x04000232 RID: 562
			Horizontal,
			// Token: 0x04000233 RID: 563
			Vertical
		}
	}
}
