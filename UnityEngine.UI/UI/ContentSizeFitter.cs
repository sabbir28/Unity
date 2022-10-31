using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200008D RID: 141
	[AddComponentMenu("Layout/Content Size Fitter", 141)]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class ContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController
	{
		// Token: 0x06000524 RID: 1316 RVA: 0x0001B013 File Offset: 0x00019413
		protected ContentSizeFitter()
		{
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x0001B02C File Offset: 0x0001942C
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x0001B047 File Offset: 0x00019447
		public ContentSizeFitter.FitMode horizontalFit
		{
			get
			{
				return this.m_HorizontalFit;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<ContentSizeFitter.FitMode>(ref this.m_HorizontalFit, value))
				{
					this.SetDirty();
				}
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x0001B064 File Offset: 0x00019464
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x0001B07F File Offset: 0x0001947F
		public ContentSizeFitter.FitMode verticalFit
		{
			get
			{
				return this.m_VerticalFit;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<ContentSizeFitter.FitMode>(ref this.m_VerticalFit, value))
				{
					this.SetDirty();
				}
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x0001B09C File Offset: 0x0001949C
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

		// Token: 0x0600052A RID: 1322 RVA: 0x0001B0D4 File Offset: 0x000194D4
		protected override void OnEnable()
		{
			base.OnEnable();
			this.SetDirty();
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0001B0E3 File Offset: 0x000194E3
		protected override void OnDisable()
		{
			this.m_Tracker.Clear();
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
			base.OnDisable();
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0001B102 File Offset: 0x00019502
		protected override void OnRectTransformDimensionsChange()
		{
			this.SetDirty();
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0001B10C File Offset: 0x0001950C
		private void HandleSelfFittingAlongAxis(int axis)
		{
			ContentSizeFitter.FitMode fitMode = (axis != 0) ? this.verticalFit : this.horizontalFit;
			if (fitMode == ContentSizeFitter.FitMode.Unconstrained)
			{
				this.m_Tracker.Add(this, this.rectTransform, DrivenTransformProperties.None);
			}
			else
			{
				this.m_Tracker.Add(this, this.rectTransform, (axis != 0) ? DrivenTransformProperties.SizeDeltaY : DrivenTransformProperties.SizeDeltaX);
				if (fitMode == ContentSizeFitter.FitMode.MinSize)
				{
					this.rectTransform.SetSizeWithCurrentAnchors((RectTransform.Axis)axis, LayoutUtility.GetMinSize(this.m_Rect, axis));
				}
				else
				{
					this.rectTransform.SetSizeWithCurrentAnchors((RectTransform.Axis)axis, LayoutUtility.GetPreferredSize(this.m_Rect, axis));
				}
			}
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0001B1B4 File Offset: 0x000195B4
		public virtual void SetLayoutHorizontal()
		{
			this.m_Tracker.Clear();
			this.HandleSelfFittingAlongAxis(0);
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0001B1C9 File Offset: 0x000195C9
		public virtual void SetLayoutVertical()
		{
			this.HandleSelfFittingAlongAxis(1);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0001B1D3 File Offset: 0x000195D3
		protected void SetDirty()
		{
			if (this.IsActive())
			{
				LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
			}
		}

		// Token: 0x0400027F RID: 639
		[SerializeField]
		protected ContentSizeFitter.FitMode m_HorizontalFit = ContentSizeFitter.FitMode.Unconstrained;

		// Token: 0x04000280 RID: 640
		[SerializeField]
		protected ContentSizeFitter.FitMode m_VerticalFit = ContentSizeFitter.FitMode.Unconstrained;

		// Token: 0x04000281 RID: 641
		[NonSerialized]
		private RectTransform m_Rect;

		// Token: 0x04000282 RID: 642
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x0200008E RID: 142
		public enum FitMode
		{
			// Token: 0x04000284 RID: 644
			Unconstrained,
			// Token: 0x04000285 RID: 645
			MinSize,
			// Token: 0x04000286 RID: 646
			PreferredSize
		}
	}
}
