using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200017D RID: 381
	public sealed class EdgeCollider2D : Collider2D
	{
		// Token: 0x06001CBE RID: 7358
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Reset();

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001CBF RID: 7359
		// (set) Token: 0x06001CC0 RID: 7360
		public extern float edgeRadius { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001CC1 RID: 7361
		public extern int edgeCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001CC2 RID: 7362
		public extern int pointCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001CC3 RID: 7363
		// (set) Token: 0x06001CC4 RID: 7364
		public extern Vector2[] points { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
