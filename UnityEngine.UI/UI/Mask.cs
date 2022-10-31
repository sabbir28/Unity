using System;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000061 RID: 97
	[AddComponentMenu("UI/Mask", 13)]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	[DisallowMultipleComponent]
	public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier
	{
		// Token: 0x0600034B RID: 843 RVA: 0x00013D49 File Offset: 0x00012149
		protected Mask()
		{
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600034C RID: 844 RVA: 0x00013D5C File Offset: 0x0001215C
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

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600034D RID: 845 RVA: 0x00013D90 File Offset: 0x00012190
		// (set) Token: 0x0600034E RID: 846 RVA: 0x00013DAB File Offset: 0x000121AB
		public bool showMaskGraphic
		{
			get
			{
				return this.m_ShowMaskGraphic;
			}
			set
			{
				if (this.m_ShowMaskGraphic != value)
				{
					this.m_ShowMaskGraphic = value;
					if (this.graphic != null)
					{
						this.graphic.SetMaterialDirty();
					}
				}
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600034F RID: 847 RVA: 0x00013DE4 File Offset: 0x000121E4
		public Graphic graphic
		{
			get
			{
				Graphic result;
				if ((result = this.m_Graphic) == null)
				{
					result = (this.m_Graphic = base.GetComponent<Graphic>());
				}
				return result;
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00013E18 File Offset: 0x00012218
		public virtual bool MaskEnabled()
		{
			return this.IsActive() && this.graphic != null;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00013E47 File Offset: 0x00012247
		[Obsolete("Not used anymore.")]
		public virtual void OnSiblingGraphicEnabledDisabled()
		{
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00013E4A File Offset: 0x0001224A
		protected override void OnEnable()
		{
			base.OnEnable();
			if (this.graphic != null)
			{
				this.graphic.canvasRenderer.hasPopInstruction = true;
				this.graphic.SetMaterialDirty();
			}
			MaskUtilities.NotifyStencilStateChanged(this);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00013E88 File Offset: 0x00012288
		protected override void OnDisable()
		{
			base.OnDisable();
			if (this.graphic != null)
			{
				this.graphic.SetMaterialDirty();
				this.graphic.canvasRenderer.hasPopInstruction = false;
				this.graphic.canvasRenderer.popMaterialCount = 0;
			}
			StencilMaterial.Remove(this.m_MaskMaterial);
			this.m_MaskMaterial = null;
			StencilMaterial.Remove(this.m_UnmaskMaterial);
			this.m_UnmaskMaterial = null;
			MaskUtilities.NotifyStencilStateChanged(this);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00013F08 File Offset: 0x00012308
		public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return !base.isActiveAndEnabled || RectTransformUtility.RectangleContainsScreenPoint(this.rectTransform, sp, eventCamera);
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00013F3C File Offset: 0x0001233C
		public virtual Material GetModifiedMaterial(Material baseMaterial)
		{
			Material result;
			if (!this.MaskEnabled())
			{
				result = baseMaterial;
			}
			else
			{
				Transform stopAfter = MaskUtilities.FindRootSortOverrideCanvas(base.transform);
				int stencilDepth = MaskUtilities.GetStencilDepth(base.transform, stopAfter);
				if (stencilDepth >= 8)
				{
					Debug.LogError("Attempting to use a stencil mask with depth > 8", base.gameObject);
					result = baseMaterial;
				}
				else
				{
					int num = 1 << stencilDepth;
					if (num == 1)
					{
						Material maskMaterial = StencilMaterial.Add(baseMaterial, 1, StencilOp.Replace, CompareFunction.Always, (!this.m_ShowMaskGraphic) ? ((ColorWriteMask)0) : ColorWriteMask.All);
						StencilMaterial.Remove(this.m_MaskMaterial);
						this.m_MaskMaterial = maskMaterial;
						Material unmaskMaterial = StencilMaterial.Add(baseMaterial, 1, StencilOp.Zero, CompareFunction.Always, (ColorWriteMask)0);
						StencilMaterial.Remove(this.m_UnmaskMaterial);
						this.m_UnmaskMaterial = unmaskMaterial;
						this.graphic.canvasRenderer.popMaterialCount = 1;
						this.graphic.canvasRenderer.SetPopMaterial(this.m_UnmaskMaterial, 0);
						result = this.m_MaskMaterial;
					}
					else
					{
						Material maskMaterial2 = StencilMaterial.Add(baseMaterial, num | num - 1, StencilOp.Replace, CompareFunction.Equal, (!this.m_ShowMaskGraphic) ? ((ColorWriteMask)0) : ColorWriteMask.All, num - 1, num | num - 1);
						StencilMaterial.Remove(this.m_MaskMaterial);
						this.m_MaskMaterial = maskMaterial2;
						this.graphic.canvasRenderer.hasPopInstruction = true;
						Material unmaskMaterial2 = StencilMaterial.Add(baseMaterial, num - 1, StencilOp.Replace, CompareFunction.Equal, (ColorWriteMask)0, num - 1, num | num - 1);
						StencilMaterial.Remove(this.m_UnmaskMaterial);
						this.m_UnmaskMaterial = unmaskMaterial2;
						this.graphic.canvasRenderer.popMaterialCount = 1;
						this.graphic.canvasRenderer.SetPopMaterial(this.m_UnmaskMaterial, 0);
						result = this.m_MaskMaterial;
					}
				}
			}
			return result;
		}

		// Token: 0x040001A3 RID: 419
		[NonSerialized]
		private RectTransform m_RectTransform;

		// Token: 0x040001A4 RID: 420
		[SerializeField]
		[FormerlySerializedAs("m_ShowGraphic")]
		private bool m_ShowMaskGraphic = true;

		// Token: 0x040001A5 RID: 421
		[NonSerialized]
		private Graphic m_Graphic;

		// Token: 0x040001A6 RID: 422
		[NonSerialized]
		private Material m_MaskMaterial;

		// Token: 0x040001A7 RID: 423
		[NonSerialized]
		private Material m_UnmaskMaterial;
	}
}
