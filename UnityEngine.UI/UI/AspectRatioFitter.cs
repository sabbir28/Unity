using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000087 RID: 135
	[AddComponentMenu("Layout/Aspect Ratio Fitter", 142)]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	[DisallowMultipleComponent]
	public class AspectRatioFitter : UIBehaviour, ILayoutSelfController, ILayoutController
	{
		// Token: 0x060004F6 RID: 1270 RVA: 0x0001A686 File Offset: 0x00018A86
		protected AspectRatioFitter()
		{
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x0001A6A4 File Offset: 0x00018AA4
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x0001A6BF File Offset: 0x00018ABF
		public AspectRatioFitter.AspectMode aspectMode
		{
			get
			{
				return this.m_AspectMode;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<AspectRatioFitter.AspectMode>(ref this.m_AspectMode, value))
				{
					this.SetDirty();
				}
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x0001A6DC File Offset: 0x00018ADC
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x0001A6F7 File Offset: 0x00018AF7
		public float aspectRatio
		{
			get
			{
				return this.m_AspectRatio;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<float>(ref this.m_AspectRatio, value))
				{
					this.SetDirty();
				}
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x0001A714 File Offset: 0x00018B14
		private RectTransform rectTransform
		{
			get
			{
				if (this.m_Rect == null)
				{
					this.m_Rect = base.GetComponent<RectTransform>();
				}
				return this.m_Rect;
			}
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0001A74C File Offset: 0x00018B4C
		protected override void OnEnable()
		{
			base.OnEnable();
			this.SetDirty();
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0001A75B File Offset: 0x00018B5B
		protected override void OnDisable()
		{
			this.m_Tracker.Clear();
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
			base.OnDisable();
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0001A77A File Offset: 0x00018B7A
		protected override void OnRectTransformDimensionsChange()
		{
			this.UpdateRect();
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0001A784 File Offset: 0x00018B84
		private void UpdateRect()
		{
			if (this.IsActive())
			{
				this.m_Tracker.Clear();
				switch (this.m_AspectMode)
				{
				case AspectRatioFitter.AspectMode.WidthControlsHeight:
					this.m_Tracker.Add(this, this.rectTransform, DrivenTransformProperties.SizeDeltaY);
					this.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.rectTransform.rect.width / this.m_AspectRatio);
					break;
				case AspectRatioFitter.AspectMode.HeightControlsWidth:
					this.m_Tracker.Add(this, this.rectTransform, DrivenTransformProperties.SizeDeltaX);
					this.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.rectTransform.rect.height * this.m_AspectRatio);
					break;
				case AspectRatioFitter.AspectMode.FitInParent:
				case AspectRatioFitter.AspectMode.EnvelopeParent:
				{
					this.m_Tracker.Add(this, this.rectTransform, DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.AnchorMinX | DrivenTransformProperties.AnchorMinY | DrivenTransformProperties.AnchorMaxX | DrivenTransformProperties.AnchorMaxY | DrivenTransformProperties.SizeDeltaX | DrivenTransformProperties.SizeDeltaY);
					this.rectTransform.anchorMin = Vector2.zero;
					this.rectTransform.anchorMax = Vector2.one;
					this.rectTransform.anchoredPosition = Vector2.zero;
					Vector2 zero = Vector2.zero;
					Vector2 parentSize = this.GetParentSize();
					if (parentSize.y * this.aspectRatio < parentSize.x ^ this.m_AspectMode == AspectRatioFitter.AspectMode.FitInParent)
					{
						zero.y = this.GetSizeDeltaToProduceSize(parentSize.x / this.aspectRatio, 1);
					}
					else
					{
						zero.x = this.GetSizeDeltaToProduceSize(parentSize.y * this.aspectRatio, 0);
					}
					this.rectTransform.sizeDelta = zero;
					break;
				}
				}
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0001A928 File Offset: 0x00018D28
		private float GetSizeDeltaToProduceSize(float size, int axis)
		{
			return size - this.GetParentSize()[axis] * (this.rectTransform.anchorMax[axis] - this.rectTransform.anchorMin[axis]);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0001A978 File Offset: 0x00018D78
		private Vector2 GetParentSize()
		{
			RectTransform rectTransform = this.rectTransform.parent as RectTransform;
			Vector2 result;
			if (!rectTransform)
			{
				result = Vector2.zero;
			}
			else
			{
				result = rectTransform.rect.size;
			}
			return result;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0001A9C2 File Offset: 0x00018DC2
		public virtual void SetLayoutHorizontal()
		{
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0001A9C5 File Offset: 0x00018DC5
		public virtual void SetLayoutVertical()
		{
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0001A9C8 File Offset: 0x00018DC8
		protected void SetDirty()
		{
			this.UpdateRect();
		}

		// Token: 0x04000259 RID: 601
		[SerializeField]
		private AspectRatioFitter.AspectMode m_AspectMode = AspectRatioFitter.AspectMode.None;

		// Token: 0x0400025A RID: 602
		[SerializeField]
		private float m_AspectRatio = 1f;

		// Token: 0x0400025B RID: 603
		[NonSerialized]
		private RectTransform m_Rect;

		// Token: 0x0400025C RID: 604
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x02000088 RID: 136
		public enum AspectMode
		{
			// Token: 0x0400025E RID: 606
			None,
			// Token: 0x0400025F RID: 607
			WidthControlsHeight,
			// Token: 0x04000260 RID: 608
			HeightControlsWidth,
			// Token: 0x04000261 RID: 609
			FitInParent,
			// Token: 0x04000262 RID: 610
			EnvelopeParent
		}
	}
}
