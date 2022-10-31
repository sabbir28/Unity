using System;

namespace UnityEngineInternal
{
	// Token: 0x020003A5 RID: 933
	public struct MathfInternal
	{
		// Token: 0x04000E54 RID: 3668
		public static volatile float FloatMinNormal = 1.1754944E-38f;

		// Token: 0x04000E55 RID: 3669
		public static volatile float FloatMinDenormal = float.Epsilon;

		// Token: 0x04000E56 RID: 3670
		public static bool IsFlushToZeroEnabled = MathfInternal.FloatMinDenormal == 0f;
	}
}
