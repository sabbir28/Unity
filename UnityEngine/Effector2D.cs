using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200019C RID: 412
	public class Effector2D : Behaviour
	{
		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06001DC2 RID: 7618
		// (set) Token: 0x06001DC3 RID: 7619
		public extern bool useColliderMask { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001DC4 RID: 7620
		// (set) Token: 0x06001DC5 RID: 7621
		public extern int colliderMask { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06001DC6 RID: 7622
		internal extern bool requiresCollider { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06001DC7 RID: 7623
		internal extern bool designedForTrigger { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06001DC8 RID: 7624
		internal extern bool designedForNonTrigger { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
