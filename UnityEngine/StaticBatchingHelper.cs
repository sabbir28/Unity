using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000086 RID: 134
	internal struct StaticBatchingHelper
	{
		// Token: 0x060009D2 RID: 2514
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Mesh InternalCombineVertices(MeshSubsetCombineUtility.MeshInstance[] meshes, string meshName);

		// Token: 0x060009D3 RID: 2515
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void InternalCombineIndices(MeshSubsetCombineUtility.SubMeshInstance[] submeshes, [Writable] Mesh combinedMesh);
	}
}
