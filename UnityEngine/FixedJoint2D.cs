using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000195 RID: 405
	public sealed class FixedJoint2D : AnchoredJoint2D
	{
		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06001D98 RID: 7576
		// (set) Token: 0x06001D99 RID: 7577
		public extern float dampingRatio { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06001D9A RID: 7578
		// (set) Token: 0x06001D9B RID: 7579
		public extern float frequency { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06001D9C RID: 7580
		public extern float referenceAngle { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
