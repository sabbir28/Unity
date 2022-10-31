using System;

namespace UnityEngine
{
	// Token: 0x0200035C RID: 860
	[Flags]
	public enum MaterialGlobalIlluminationFlags
	{
		// Token: 0x04000B9A RID: 2970
		None = 0,
		// Token: 0x04000B9B RID: 2971
		RealtimeEmissive = 1,
		// Token: 0x04000B9C RID: 2972
		BakedEmissive = 2,
		// Token: 0x04000B9D RID: 2973
		EmissiveIsBlack = 4,
		// Token: 0x04000B9E RID: 2974
		AnyEmissive = 3
	}
}
