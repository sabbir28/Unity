using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200016A RID: 362
	public sealed class MeshCollider : Collider
	{
		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001A47 RID: 6727
		// (set) Token: 0x06001A48 RID: 6728
		public extern Mesh sharedMesh { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001A49 RID: 6729
		// (set) Token: 0x06001A4A RID: 6730
		public extern bool convex { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001A4B RID: 6731
		// (set) Token: 0x06001A4C RID: 6732
		public extern bool inflateMesh { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001A4D RID: 6733
		// (set) Token: 0x06001A4E RID: 6734
		public extern float skinWidth { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001A4F RID: 6735 RVA: 0x00020868 File Offset: 0x0001EA68
		// (set) Token: 0x06001A50 RID: 6736 RVA: 0x00020880 File Offset: 0x0001EA80
		[Obsolete("Configuring smooth sphere collisions is no longer needed. PhysX3 has a better behaviour in place.")]
		public bool smoothSphereCollisions
		{
			get
			{
				return true;
			}
			set
			{
			}
		}
	}
}
