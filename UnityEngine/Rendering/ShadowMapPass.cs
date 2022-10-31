using System;

namespace UnityEngine.Rendering
{
	// Token: 0x0200036F RID: 879
	[Flags]
	public enum ShadowMapPass
	{
		// Token: 0x04000C34 RID: 3124
		PointlightPositiveX = 1,
		// Token: 0x04000C35 RID: 3125
		PointlightNegativeX = 2,
		// Token: 0x04000C36 RID: 3126
		PointlightPositiveY = 4,
		// Token: 0x04000C37 RID: 3127
		PointlightNegativeY = 8,
		// Token: 0x04000C38 RID: 3128
		PointlightPositiveZ = 16,
		// Token: 0x04000C39 RID: 3129
		PointlightNegativeZ = 32,
		// Token: 0x04000C3A RID: 3130
		DirectionalCascade0 = 64,
		// Token: 0x04000C3B RID: 3131
		DirectionalCascade1 = 128,
		// Token: 0x04000C3C RID: 3132
		DirectionalCascade2 = 256,
		// Token: 0x04000C3D RID: 3133
		DirectionalCascade3 = 512,
		// Token: 0x04000C3E RID: 3134
		Spotlight = 1024,
		// Token: 0x04000C3F RID: 3135
		Pointlight = 63,
		// Token: 0x04000C40 RID: 3136
		Directional = 960,
		// Token: 0x04000C41 RID: 3137
		All = 2047
	}
}
