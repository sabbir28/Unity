using System;

namespace UnityEngine
{
	// Token: 0x020003A7 RID: 935
	public struct CombineInstance
	{
		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x060031E0 RID: 12768 RVA: 0x0004CB80 File Offset: 0x0004AD80
		// (set) Token: 0x060031E1 RID: 12769 RVA: 0x0004CBA0 File Offset: 0x0004ADA0
		public Mesh mesh
		{
			get
			{
				return CombineInstanceHelper.GetMesh(this.m_MeshInstanceID);
			}
			set
			{
				this.m_MeshInstanceID = ((!(value != null)) ? 0 : value.GetInstanceID());
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x060031E2 RID: 12770 RVA: 0x0004CBC4 File Offset: 0x0004ADC4
		// (set) Token: 0x060031E3 RID: 12771 RVA: 0x0004CBE0 File Offset: 0x0004ADE0
		public int subMeshIndex
		{
			get
			{
				return this.m_SubMeshIndex;
			}
			set
			{
				this.m_SubMeshIndex = value;
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x060031E4 RID: 12772 RVA: 0x0004CBEC File Offset: 0x0004ADEC
		// (set) Token: 0x060031E5 RID: 12773 RVA: 0x0004CC08 File Offset: 0x0004AE08
		public Matrix4x4 transform
		{
			get
			{
				return this.m_Transform;
			}
			set
			{
				this.m_Transform = value;
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x060031E6 RID: 12774 RVA: 0x0004CC14 File Offset: 0x0004AE14
		// (set) Token: 0x060031E7 RID: 12775 RVA: 0x0004CC30 File Offset: 0x0004AE30
		public Vector4 lightmapScaleOffset
		{
			get
			{
				return this.m_LightmapScaleOffset;
			}
			set
			{
				this.m_LightmapScaleOffset = value;
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x060031E8 RID: 12776 RVA: 0x0004CC3C File Offset: 0x0004AE3C
		// (set) Token: 0x060031E9 RID: 12777 RVA: 0x0004CC58 File Offset: 0x0004AE58
		public Vector4 realtimeLightmapScaleOffset
		{
			get
			{
				return this.m_RealtimeLightmapScaleOffset;
			}
			set
			{
				this.m_RealtimeLightmapScaleOffset = value;
			}
		}

		// Token: 0x04000E5F RID: 3679
		private int m_MeshInstanceID;

		// Token: 0x04000E60 RID: 3680
		private int m_SubMeshIndex;

		// Token: 0x04000E61 RID: 3681
		private Matrix4x4 m_Transform;

		// Token: 0x04000E62 RID: 3682
		private Vector4 m_LightmapScaleOffset;

		// Token: 0x04000E63 RID: 3683
		private Vector4 m_RealtimeLightmapScaleOffset;
	}
}
