using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x020000AA RID: 170
	[ExecuteInEditMode]
	public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier
	{
		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x0001E258 File Offset: 0x0001C658
		protected Graphic graphic
		{
			get
			{
				if (this.m_Graphic == null)
				{
					this.m_Graphic = base.GetComponent<Graphic>();
				}
				return this.m_Graphic;
			}
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0001E290 File Offset: 0x0001C690
		protected override void OnEnable()
		{
			base.OnEnable();
			if (this.graphic != null)
			{
				this.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0001E2B5 File Offset: 0x0001C6B5
		protected override void OnDisable()
		{
			if (this.graphic != null)
			{
				this.graphic.SetVerticesDirty();
			}
			base.OnDisable();
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0001E2DA File Offset: 0x0001C6DA
		protected override void OnDidApplyAnimationProperties()
		{
			if (this.graphic != null)
			{
				this.graphic.SetVerticesDirty();
			}
			base.OnDidApplyAnimationProperties();
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0001E300 File Offset: 0x0001C700
		public virtual void ModifyMesh(Mesh mesh)
		{
			using (VertexHelper vertexHelper = new VertexHelper(mesh))
			{
				this.ModifyMesh(vertexHelper);
				vertexHelper.FillMesh(mesh);
			}
		}

		// Token: 0x0600061B RID: 1563
		public abstract void ModifyMesh(VertexHelper vh);

		// Token: 0x040002D5 RID: 725
		[NonSerialized]
		private Graphic m_Graphic;
	}
}
