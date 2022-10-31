using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200019F RID: 415
	public sealed class PointEffector2D : Effector2D
	{
		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06001DE8 RID: 7656
		// (set) Token: 0x06001DE9 RID: 7657
		public extern float forceMagnitude { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06001DEA RID: 7658
		// (set) Token: 0x06001DEB RID: 7659
		public extern float forceVariation { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06001DEC RID: 7660
		// (set) Token: 0x06001DED RID: 7661
		public extern float distanceScale { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06001DEE RID: 7662
		// (set) Token: 0x06001DEF RID: 7663
		public extern float drag { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06001DF0 RID: 7664
		// (set) Token: 0x06001DF1 RID: 7665
		public extern float angularDrag { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06001DF2 RID: 7666
		// (set) Token: 0x06001DF3 RID: 7667
		public extern EffectorSelection2D forceSource { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06001DF4 RID: 7668
		// (set) Token: 0x06001DF5 RID: 7669
		public extern EffectorSelection2D forceTarget { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06001DF6 RID: 7670
		// (set) Token: 0x06001DF7 RID: 7671
		public extern EffectorForceMode2D forceMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
