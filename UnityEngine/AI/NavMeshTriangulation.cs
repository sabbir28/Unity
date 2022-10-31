using System;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI
{
	// Token: 0x020001AA RID: 426
	[UsedByNativeCode]
	[MovedFrom("UnityEngine")]
	public struct NavMeshTriangulation
	{
		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x000252B0 File Offset: 0x000234B0
		[Obsolete("Use areas instead.")]
		public int[] layers
		{
			get
			{
				return this.areas;
			}
		}

		// Token: 0x0400046F RID: 1135
		public Vector3[] vertices;

		// Token: 0x04000470 RID: 1136
		public int[] indices;

		// Token: 0x04000471 RID: 1137
		public int[] areas;
	}
}
