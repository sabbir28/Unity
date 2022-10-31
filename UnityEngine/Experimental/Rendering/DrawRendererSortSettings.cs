using System;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000430 RID: 1072
	public struct DrawRendererSortSettings
	{
		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x060034EF RID: 13551 RVA: 0x00053E8C File Offset: 0x0005208C
		// (set) Token: 0x060034F0 RID: 13552 RVA: 0x00053EB0 File Offset: 0x000520B0
		public bool sortOrthographic
		{
			get
			{
				return this._sortOrthographic != 0;
			}
			set
			{
				this._sortOrthographic = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x04000F50 RID: 3920
		public Matrix4x4 worldToCameraMatrix;

		// Token: 0x04000F51 RID: 3921
		public Vector3 cameraPosition;

		// Token: 0x04000F52 RID: 3922
		public SortFlags flags;

		// Token: 0x04000F53 RID: 3923
		private int _sortOrthographic;
	}
}
