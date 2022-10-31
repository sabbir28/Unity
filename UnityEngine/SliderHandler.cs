using System;

namespace UnityEngine
{
	// Token: 0x02000271 RID: 625
	internal struct SliderHandler
	{
		// Token: 0x06002A2D RID: 10797 RVA: 0x00038400 File Offset: 0x00036600
		public SliderHandler(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id)
		{
			this.position = position;
			this.currentValue = currentValue;
			this.size = size;
			this.start = start;
			this.end = end;
			this.slider = slider;
			this.thumb = thumb;
			this.horiz = horiz;
			this.id = id;
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x00038454 File Offset: 0x00036654
		public float Handle()
		{
			float result;
			if (this.slider == null || this.thumb == null)
			{
				result = this.currentValue;
			}
			else
			{
				switch (this.CurrentEventType())
				{
				case EventType.MouseDown:
					return this.OnMouseDown();
				case EventType.MouseUp:
					return this.OnMouseUp();
				case EventType.MouseDrag:
					return this.OnMouseDrag();
				case EventType.Repaint:
					return this.OnRepaint();
				}
				result = this.currentValue;
			}
			return result;
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x000384F4 File Offset: 0x000366F4
		private float OnMouseDown()
		{
			float result;
			if (!this.position.Contains(this.CurrentEvent().mousePosition) || this.IsEmptySlider())
			{
				result = this.currentValue;
			}
			else
			{
				GUI.scrollTroughSide = 0;
				GUIUtility.hotControl = this.id;
				this.CurrentEvent().Use();
				if (this.ThumbSelectionRect().Contains(this.CurrentEvent().mousePosition))
				{
					this.StartDraggingWithValue(this.ClampedCurrentValue());
					result = this.currentValue;
				}
				else
				{
					GUI.changed = true;
					if (this.SupportsPageMovements())
					{
						this.SliderState().isDragging = false;
						GUI.nextScrollStepTime = SystemClock.now.AddMilliseconds(250.0);
						GUI.scrollTroughSide = this.CurrentScrollTroughSide();
						result = this.PageMovementValue();
					}
					else
					{
						float num = this.ValueForCurrentMousePosition();
						this.StartDraggingWithValue(num);
						result = this.Clamp(num);
					}
				}
			}
			return result;
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x000385FC File Offset: 0x000367FC
		private float OnMouseDrag()
		{
			float result;
			if (GUIUtility.hotControl != this.id)
			{
				result = this.currentValue;
			}
			else
			{
				SliderState sliderState = this.SliderState();
				if (!sliderState.isDragging)
				{
					result = this.currentValue;
				}
				else
				{
					GUI.changed = true;
					this.CurrentEvent().Use();
					float num = this.MousePosition() - sliderState.dragStartPos;
					float value = sliderState.dragStartValue + num / this.ValuesPerPixel();
					result = this.Clamp(value);
				}
			}
			return result;
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x00038684 File Offset: 0x00036884
		private float OnMouseUp()
		{
			if (GUIUtility.hotControl == this.id)
			{
				this.CurrentEvent().Use();
				GUIUtility.hotControl = 0;
			}
			return this.currentValue;
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x000386C4 File Offset: 0x000368C4
		private float OnRepaint()
		{
			this.slider.Draw(this.position, GUIContent.none, this.id);
			if (!this.IsEmptySlider())
			{
				this.thumb.Draw(this.ThumbRect(), GUIContent.none, this.id);
			}
			float result;
			if (GUIUtility.hotControl != this.id || !this.position.Contains(this.CurrentEvent().mousePosition) || this.IsEmptySlider())
			{
				result = this.currentValue;
			}
			else if (this.ThumbRect().Contains(this.CurrentEvent().mousePosition))
			{
				if (GUI.scrollTroughSide != 0)
				{
					GUIUtility.hotControl = 0;
				}
				result = this.currentValue;
			}
			else
			{
				GUI.InternalRepaintEditorWindow();
				if (SystemClock.now < GUI.nextScrollStepTime)
				{
					result = this.currentValue;
				}
				else if (this.CurrentScrollTroughSide() != GUI.scrollTroughSide)
				{
					result = this.currentValue;
				}
				else
				{
					GUI.nextScrollStepTime = SystemClock.now.AddMilliseconds(30.0);
					if (this.SupportsPageMovements())
					{
						this.SliderState().isDragging = false;
						GUI.changed = true;
						result = this.PageMovementValue();
					}
					else
					{
						result = this.ClampedCurrentValue();
					}
				}
			}
			return result;
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x0003882C File Offset: 0x00036A2C
		private EventType CurrentEventType()
		{
			return this.CurrentEvent().GetTypeForControl(this.id);
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x00038854 File Offset: 0x00036A54
		private int CurrentScrollTroughSide()
		{
			float num = (!this.horiz) ? this.CurrentEvent().mousePosition.y : this.CurrentEvent().mousePosition.x;
			float num2 = (!this.horiz) ? this.ThumbRect().y : this.ThumbRect().x;
			return (num <= num2) ? -1 : 1;
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x000388E0 File Offset: 0x00036AE0
		private bool IsEmptySlider()
		{
			return this.start == this.end;
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x00038904 File Offset: 0x00036B04
		private bool SupportsPageMovements()
		{
			return this.size != 0f && GUI.usePageScrollbars;
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x00038934 File Offset: 0x00036B34
		private float PageMovementValue()
		{
			float num = this.currentValue;
			int num2 = (this.start <= this.end) ? 1 : -1;
			if (this.MousePosition() > this.PageUpMovementBound())
			{
				num += this.size * (float)num2 * 0.9f;
			}
			else
			{
				num -= this.size * (float)num2 * 0.9f;
			}
			return this.Clamp(num);
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x000389AC File Offset: 0x00036BAC
		private float PageUpMovementBound()
		{
			float result;
			if (this.horiz)
			{
				result = this.ThumbRect().xMax - this.position.x;
			}
			else
			{
				result = this.ThumbRect().yMax - this.position.y;
			}
			return result;
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x00038A10 File Offset: 0x00036C10
		private Event CurrentEvent()
		{
			return Event.current;
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x00038A2C File Offset: 0x00036C2C
		private float ValueForCurrentMousePosition()
		{
			float result;
			if (this.horiz)
			{
				result = (this.MousePosition() - this.ThumbRect().width * 0.5f) / this.ValuesPerPixel() + this.start - this.size * 0.5f;
			}
			else
			{
				result = (this.MousePosition() - this.ThumbRect().height * 0.5f) / this.ValuesPerPixel() + this.start - this.size * 0.5f;
			}
			return result;
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x00038AC0 File Offset: 0x00036CC0
		private float Clamp(float value)
		{
			return Mathf.Clamp(value, this.MinValue(), this.MaxValue());
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x00038AE8 File Offset: 0x00036CE8
		private Rect ThumbSelectionRect()
		{
			return this.ThumbRect();
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x00038B08 File Offset: 0x00036D08
		private void StartDraggingWithValue(float dragStartValue)
		{
			SliderState sliderState = this.SliderState();
			sliderState.dragStartPos = this.MousePosition();
			sliderState.dragStartValue = dragStartValue;
			sliderState.isDragging = true;
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x00038B38 File Offset: 0x00036D38
		private SliderState SliderState()
		{
			return (SliderState)GUIUtility.GetStateObject(typeof(SliderState), this.id);
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x00038B68 File Offset: 0x00036D68
		private Rect ThumbRect()
		{
			return (!this.horiz) ? this.VerticalThumbRect() : this.HorizontalThumbRect();
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x00038B9C File Offset: 0x00036D9C
		private Rect VerticalThumbRect()
		{
			float num = this.ValuesPerPixel();
			Rect result;
			if (this.start < this.end)
			{
				result = new Rect(this.position.x + (float)this.slider.padding.left, (this.ClampedCurrentValue() - this.start) * num + this.position.y + (float)this.slider.padding.top, this.position.width - (float)this.slider.padding.horizontal, this.size * num + this.ThumbSize());
			}
			else
			{
				result = new Rect(this.position.x + (float)this.slider.padding.left, (this.ClampedCurrentValue() + this.size - this.start) * num + this.position.y + (float)this.slider.padding.top, this.position.width - (float)this.slider.padding.horizontal, this.size * -num + this.ThumbSize());
			}
			return result;
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x00038CE8 File Offset: 0x00036EE8
		private Rect HorizontalThumbRect()
		{
			float num = this.ValuesPerPixel();
			Rect result;
			if (this.start < this.end)
			{
				result = new Rect((this.ClampedCurrentValue() - this.start) * num + this.position.x + (float)this.slider.padding.left, this.position.y + (float)this.slider.padding.top, this.size * num + this.ThumbSize(), this.position.height - (float)this.slider.padding.vertical);
			}
			else
			{
				result = new Rect((this.ClampedCurrentValue() + this.size - this.start) * num + this.position.x + (float)this.slider.padding.left, this.position.y, this.size * -num + this.ThumbSize(), this.position.height);
			}
			return result;
		}

		// Token: 0x06002A42 RID: 10818 RVA: 0x00038E10 File Offset: 0x00037010
		private float ClampedCurrentValue()
		{
			return this.Clamp(this.currentValue);
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x00038E34 File Offset: 0x00037034
		private float MousePosition()
		{
			float result;
			if (this.horiz)
			{
				result = this.CurrentEvent().mousePosition.x - this.position.x;
			}
			else
			{
				result = this.CurrentEvent().mousePosition.y - this.position.y;
			}
			return result;
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x00038EA0 File Offset: 0x000370A0
		private float ValuesPerPixel()
		{
			float result;
			if (this.horiz)
			{
				result = (this.position.width - (float)this.slider.padding.horizontal - this.ThumbSize()) / (this.end - this.start);
			}
			else
			{
				result = (this.position.height - (float)this.slider.padding.vertical - this.ThumbSize()) / (this.end - this.start);
			}
			return result;
		}

		// Token: 0x06002A45 RID: 10821 RVA: 0x00038F30 File Offset: 0x00037130
		private float ThumbSize()
		{
			float result;
			if (this.horiz)
			{
				result = ((this.thumb.fixedWidth == 0f) ? ((float)this.thumb.padding.horizontal) : this.thumb.fixedWidth);
			}
			else
			{
				result = ((this.thumb.fixedHeight == 0f) ? ((float)this.thumb.padding.vertical) : this.thumb.fixedHeight);
			}
			return result;
		}

		// Token: 0x06002A46 RID: 10822 RVA: 0x00038FC4 File Offset: 0x000371C4
		private float MaxValue()
		{
			return Mathf.Max(this.start, this.end) - this.size;
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x00038FF4 File Offset: 0x000371F4
		private float MinValue()
		{
			return Mathf.Min(this.start, this.end);
		}

		// Token: 0x040007BA RID: 1978
		private readonly Rect position;

		// Token: 0x040007BB RID: 1979
		private readonly float currentValue;

		// Token: 0x040007BC RID: 1980
		private readonly float size;

		// Token: 0x040007BD RID: 1981
		private readonly float start;

		// Token: 0x040007BE RID: 1982
		private readonly float end;

		// Token: 0x040007BF RID: 1983
		private readonly GUIStyle slider;

		// Token: 0x040007C0 RID: 1984
		private readonly GUIStyle thumb;

		// Token: 0x040007C1 RID: 1985
		private readonly bool horiz;

		// Token: 0x040007C2 RID: 1986
		private readonly int id;
	}
}
