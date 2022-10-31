using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000069 RID: 105
	[AddComponentMenu("UI/Rect Mask 2D", 13)]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(RectTransform))]
	public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter
	{
		// Token: 0x06000388 RID: 904 RVA: 0x00014B18 File Offset: 0x00012F18
		protected RectMask2D()
		{
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000389 RID: 905 RVA: 0x00014B44 File Offset: 0x00012F44
		public Rect canvasRect
		{
			get
			{
				Canvas c = null;
				List<Canvas> list = ListPool<Canvas>.Get();
				base.gameObject.GetComponentsInParent<Canvas>(false, list);
				if (list.Count > 0)
				{
					c = list[list.Count - 1];
				}
				ListPool<Canvas>.Release(list);
				return this.m_VertexClipper.GetCanvasRect(this.rectTransform, c);
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600038A RID: 906 RVA: 0x00014BA4 File Offset: 0x00012FA4
		public RectTransform rectTransform
		{
			get
			{
				RectTransform result;
				if ((result = this.m_RectTransform) == null)
				{
					result = (this.m_RectTransform = base.GetComponent<RectTransform>());
				}
				return result;
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00014BD5 File Offset: 0x00012FD5
		protected override void OnEnable()
		{
			base.OnEnable();
			this.m_ShouldRecalculateClipRects = true;
			ClipperRegistry.Register(this);
			MaskUtilities.Notify2DMaskStateChanged(this);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00014BF1 File Offset: 0x00012FF1
		protected override void OnDisable()
		{
			base.OnDisable();
			this.m_ClipTargets.Clear();
			this.m_Clippers.Clear();
			ClipperRegistry.Unregister(this);
			MaskUtilities.Notify2DMaskStateChanged(this);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00014C1C File Offset: 0x0001301C
		public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return !base.isActiveAndEnabled || RectTransformUtility.RectangleContainsScreenPoint(this.rectTransform, sp, eventCamera);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00014C50 File Offset: 0x00013050
		public virtual void PerformClipping()
		{
			if (this.m_ShouldRecalculateClipRects)
			{
				MaskUtilities.GetRectMasksForClip(this, this.m_Clippers);
				this.m_ShouldRecalculateClipRects = false;
			}
			bool flag = true;
			Rect rect = Clipping.FindCullAndClipWorldRect(this.m_Clippers, out flag);
			bool flag2 = rect != this.m_LastClipRectCanvasSpace;
			if (flag2 || this.m_ForceClip)
			{
				foreach (IClippable clippable in this.m_ClipTargets)
				{
					clippable.SetClipRect(rect, flag);
				}
				this.m_LastClipRectCanvasSpace = rect;
				this.m_LastValidClipRect = flag;
			}
			foreach (IClippable clippable2 in this.m_ClipTargets)
			{
				MaskableGraphic maskableGraphic = clippable2 as MaskableGraphic;
				if (!(maskableGraphic != null) || maskableGraphic.canvasRenderer.hasMoved || flag2)
				{
					clippable2.Cull(this.m_LastClipRectCanvasSpace, this.m_LastValidClipRect);
				}
			}
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00014D9C File Offset: 0x0001319C
		public void AddClippable(IClippable clippable)
		{
			if (clippable != null)
			{
				this.m_ShouldRecalculateClipRects = true;
				if (!this.m_ClipTargets.Contains(clippable))
				{
					this.m_ClipTargets.Add(clippable);
				}
				this.m_ForceClip = true;
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00014DD8 File Offset: 0x000131D8
		public void RemoveClippable(IClippable clippable)
		{
			if (clippable != null)
			{
				this.m_ShouldRecalculateClipRects = true;
				clippable.SetClipRect(default(Rect), false);
				this.m_ClipTargets.Remove(clippable);
				this.m_ForceClip = true;
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00014E1C File Offset: 0x0001321C
		protected override void OnTransformParentChanged()
		{
			base.OnTransformParentChanged();
			this.m_ShouldRecalculateClipRects = true;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00014E2C File Offset: 0x0001322C
		protected override void OnCanvasHierarchyChanged()
		{
			base.OnCanvasHierarchyChanged();
			this.m_ShouldRecalculateClipRects = true;
		}

		// Token: 0x040001BE RID: 446
		[NonSerialized]
		private readonly RectangularVertexClipper m_VertexClipper = new RectangularVertexClipper();

		// Token: 0x040001BF RID: 447
		[NonSerialized]
		private RectTransform m_RectTransform;

		// Token: 0x040001C0 RID: 448
		[NonSerialized]
		private HashSet<IClippable> m_ClipTargets = new HashSet<IClippable>();

		// Token: 0x040001C1 RID: 449
		[NonSerialized]
		private bool m_ShouldRecalculateClipRects;

		// Token: 0x040001C2 RID: 450
		[NonSerialized]
		private List<RectMask2D> m_Clippers = new List<RectMask2D>();

		// Token: 0x040001C3 RID: 451
		[NonSerialized]
		private Rect m_LastClipRectCanvasSpace;

		// Token: 0x040001C4 RID: 452
		[NonSerialized]
		private bool m_LastValidClipRect;

		// Token: 0x040001C5 RID: 453
		[NonSerialized]
		private bool m_ForceClip;
	}
}
