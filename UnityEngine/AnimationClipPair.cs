using System;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	// Token: 0x020001E7 RID: 487
	[Obsolete("This class is not used anymore.  See AnimatorOverrideController.GetOverrides() and AnimatorOverrideController.ApplyOverrides()")]
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class AnimationClipPair
	{
		// Token: 0x0400051F RID: 1311
		public AnimationClip originalClip;

		// Token: 0x04000520 RID: 1312
		public AnimationClip overrideClip;
	}
}
