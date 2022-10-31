using System;
using UnityEngine.Events;
using UnityEngine.Rendering;

namespace UnityEngine.UI
{
	// Token: 0x02000062 RID: 98
	public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier
	{
		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000357 RID: 855 RVA: 0x0000C7EC File Offset: 0x0000ABEC
		// (set) Token: 0x06000358 RID: 856 RVA: 0x0000C807 File Offset: 0x0000AC07
		public MaskableGraphic.CullStateChangedEvent onCullStateChanged
		{
			get
			{
				return this.m_OnCullStateChanged;
			}
			set
			{
				this.m_OnCullStateChanged = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000359 RID: 857 RVA: 0x0000C814 File Offset: 0x0000AC14
		// (set) Token: 0x0600035A RID: 858 RVA: 0x0000C82F File Offset: 0x0000AC2F
		public bool maskable
		{
			get
			{
				return this.m_Maskable;
			}
			set
			{
				if (value != this.m_Maskable)
				{
					this.m_Maskable = value;
					this.m_ShouldRecalculateStencil = true;
					this.SetMaterialDirty();
				}
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000C858 File Offset: 0x0000AC58
		public virtual Material GetModifiedMaterial(Material baseMaterial)
		{
			Material material = baseMaterial;
			if (this.m_ShouldRecalculateStencil)
			{
				Transform stopAfter = MaskUtilities.FindRootSortOverrideCanvas(base.transform);
				this.m_StencilValue = ((!this.maskable) ? 0 : MaskUtilities.GetStencilDepth(base.transform, stopAfter));
				this.m_ShouldRecalculateStencil = false;
			}
			Mask component = base.GetComponent<Mask>();
			if (this.m_StencilValue > 0 && (component == null || !component.IsActive()))
			{
				Material maskMaterial = StencilMaterial.Add(material, (1 << this.m_StencilValue) - 1, StencilOp.Keep, CompareFunction.Equal, ColorWriteMask.All, (1 << this.m_StencilValue) - 1, 0);
				StencilMaterial.Remove(this.m_MaskMaterial);
				this.m_MaskMaterial = maskMaterial;
				material = this.m_MaskMaterial;
			}
			return material;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000C920 File Offset: 0x0000AD20
		public virtual void Cull(Rect clipRect, bool validRect)
		{
			bool cull = !validRect || !clipRect.Overlaps(this.rootCanvasRect, true);
			this.UpdateCull(cull);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000C950 File Offset: 0x0000AD50
		private void UpdateCull(bool cull)
		{
			bool flag = base.canvasRenderer.cull != cull;
			base.canvasRenderer.cull = cull;
			if (flag)
			{
				this.m_OnCullStateChanged.Invoke(cull);
				this.SetVerticesDirty();
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000C996 File Offset: 0x0000AD96
		public virtual void SetClipRect(Rect clipRect, bool validRect)
		{
			if (validRect)
			{
				base.canvasRenderer.EnableRectClipping(clipRect);
			}
			else
			{
				base.canvasRenderer.DisableRectClipping();
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000C9BB File Offset: 0x0000ADBB
		protected override void OnEnable()
		{
			base.OnEnable();
			this.m_ShouldRecalculateStencil = true;
			this.UpdateClipParent();
			this.SetMaterialDirty();
			if (base.GetComponent<Mask>() != null)
			{
				MaskUtilities.NotifyStencilStateChanged(this);
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000C9F0 File Offset: 0x0000ADF0
		protected override void OnDisable()
		{
			base.OnDisable();
			this.m_ShouldRecalculateStencil = true;
			this.SetMaterialDirty();
			this.UpdateClipParent();
			StencilMaterial.Remove(this.m_MaskMaterial);
			this.m_MaskMaterial = null;
			if (base.GetComponent<Mask>() != null)
			{
				MaskUtilities.NotifyStencilStateChanged(this);
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000CA42 File Offset: 0x0000AE42
		protected override void OnTransformParentChanged()
		{
			base.OnTransformParentChanged();
			if (base.isActiveAndEnabled)
			{
				this.m_ShouldRecalculateStencil = true;
				this.UpdateClipParent();
				this.SetMaterialDirty();
			}
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000CA6E File Offset: 0x0000AE6E
		[Obsolete("Not used anymore.", true)]
		public virtual void ParentMaskStateChanged()
		{
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000CA71 File Offset: 0x0000AE71
		protected override void OnCanvasHierarchyChanged()
		{
			base.OnCanvasHierarchyChanged();
			if (base.isActiveAndEnabled)
			{
				this.m_ShouldRecalculateStencil = true;
				this.UpdateClipParent();
				this.SetMaterialDirty();
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000364 RID: 868 RVA: 0x0000CAA0 File Offset: 0x0000AEA0
		private Rect rootCanvasRect
		{
			get
			{
				base.rectTransform.GetWorldCorners(this.m_Corners);
				if (base.canvas)
				{
					Canvas rootCanvas = base.canvas.rootCanvas;
					for (int i = 0; i < 4; i++)
					{
						this.m_Corners[i] = rootCanvas.transform.InverseTransformPoint(this.m_Corners[i]);
					}
				}
				return new Rect(this.m_Corners[0].x, this.m_Corners[0].y, this.m_Corners[2].x - this.m_Corners[0].x, this.m_Corners[2].y - this.m_Corners[0].y);
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000CB90 File Offset: 0x0000AF90
		private void UpdateClipParent()
		{
			RectMask2D rectMask2D = (!this.maskable || !this.IsActive()) ? null : MaskUtilities.GetRectMaskForClippable(this);
			if (this.m_ParentMask != null && (rectMask2D != this.m_ParentMask || !rectMask2D.IsActive()))
			{
				this.m_ParentMask.RemoveClippable(this);
				this.UpdateCull(false);
			}
			if (rectMask2D != null && rectMask2D.IsActive())
			{
				rectMask2D.AddClippable(this);
			}
			this.m_ParentMask = rectMask2D;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000CC28 File Offset: 0x0000B028
		public virtual void RecalculateClipping()
		{
			this.UpdateClipParent();
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000CC31 File Offset: 0x0000B031
		public virtual void RecalculateMasking()
		{
			this.m_ShouldRecalculateStencil = true;
			this.SetMaterialDirty();
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000CC41 File Offset: 0x0000B041
		GameObject IClippable.get_gameObject()
		{
			return base.gameObject;
		}

		// Token: 0x040001A8 RID: 424
		[NonSerialized]
		protected bool m_ShouldRecalculateStencil = true;

		// Token: 0x040001A9 RID: 425
		[NonSerialized]
		protected Material m_MaskMaterial;

		// Token: 0x040001AA RID: 426
		[NonSerialized]
		private RectMask2D m_ParentMask;

		// Token: 0x040001AB RID: 427
		[NonSerialized]
		private bool m_Maskable = true;

		// Token: 0x040001AC RID: 428
		[Obsolete("Not used anymore.", true)]
		[NonSerialized]
		protected bool m_IncludeForMasking = false;

		// Token: 0x040001AD RID: 429
		[SerializeField]
		private MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged = new MaskableGraphic.CullStateChangedEvent();

		// Token: 0x040001AE RID: 430
		[Obsolete("Not used anymore", true)]
		[NonSerialized]
		protected bool m_ShouldRecalculate = true;

		// Token: 0x040001AF RID: 431
		[NonSerialized]
		protected int m_StencilValue;

		// Token: 0x040001B0 RID: 432
		private readonly Vector3[] m_Corners = new Vector3[4];

		// Token: 0x02000063 RID: 99
		[Serializable]
		public class CullStateChangedEvent : UnityEvent<bool>
		{
		}
	}
}
