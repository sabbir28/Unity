using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000197 RID: 407
	public sealed class PhysicsMaterial2D : Object
	{
		// Token: 0x06001DAE RID: 7598 RVA: 0x000249E0 File Offset: 0x00022BE0
		public PhysicsMaterial2D()
		{
			PhysicsMaterial2D.Internal_Create(this, null);
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x000249F0 File Offset: 0x00022BF0
		public PhysicsMaterial2D(string name)
		{
			PhysicsMaterial2D.Internal_Create(this, name);
		}

		// Token: 0x06001DB0 RID: 7600
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Create([Writable] PhysicsMaterial2D mat, string name);

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06001DB1 RID: 7601
		// (set) Token: 0x06001DB2 RID: 7602
		public extern float bounciness { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06001DB3 RID: 7603
		// (set) Token: 0x06001DB4 RID: 7604
		public extern float friction { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
