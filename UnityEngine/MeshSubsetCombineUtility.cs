using System;
using System.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x0200044A RID: 1098
	internal class MeshSubsetCombineUtility
	{
		// Token: 0x0200044B RID: 1099
		public struct MeshInstance
		{
			// Token: 0x04000F89 RID: 3977
			public int meshInstanceID;

			// Token: 0x04000F8A RID: 3978
			public int rendererInstanceID;

			// Token: 0x04000F8B RID: 3979
			public int additionalVertexStreamsMeshInstanceID;

			// Token: 0x04000F8C RID: 3980
			public Matrix4x4 transform;

			// Token: 0x04000F8D RID: 3981
			public Vector4 lightmapScaleOffset;

			// Token: 0x04000F8E RID: 3982
			public Vector4 realtimeLightmapScaleOffset;
		}

		// Token: 0x0200044C RID: 1100
		public struct SubMeshInstance
		{
			// Token: 0x04000F8F RID: 3983
			public int meshInstanceID;

			// Token: 0x04000F90 RID: 3984
			public int vertexOffset;

			// Token: 0x04000F91 RID: 3985
			public int gameObjectInstanceID;

			// Token: 0x04000F92 RID: 3986
			public int subMeshIndex;

			// Token: 0x04000F93 RID: 3987
			public Matrix4x4 transform;
		}

		// Token: 0x0200044D RID: 1101
		public struct MeshContainer
		{
			// Token: 0x04000F94 RID: 3988
			public GameObject gameObject;

			// Token: 0x04000F95 RID: 3989
			public MeshSubsetCombineUtility.MeshInstance instance;

			// Token: 0x04000F96 RID: 3990
			public List<MeshSubsetCombineUtility.SubMeshInstance> subMeshInstances;
		}
	}
}
