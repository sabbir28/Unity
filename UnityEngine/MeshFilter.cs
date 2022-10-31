using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000045 RID: 69
	[RequireComponent(typeof(Transform))]
	public sealed class MeshFilter : Component
	{
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000516 RID: 1302
		// (set) Token: 0x06000517 RID: 1303
		public extern Mesh mesh { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000518 RID: 1304
		// (set) Token: 0x06000519 RID: 1305
		public extern Mesh sharedMesh { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
