using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x02000374 RID: 884
	[UsedByNativeCode]
	public enum GraphicsDeviceType
	{
		// Token: 0x04000C70 RID: 3184
		[Obsolete("OpenGL2 is no longer supported in Unity 5.5+")]
		OpenGL2,
		// Token: 0x04000C71 RID: 3185
		Direct3D9,
		// Token: 0x04000C72 RID: 3186
		Direct3D11,
		// Token: 0x04000C73 RID: 3187
		[Obsolete("PS3 is no longer supported in Unity 5.5+")]
		PlayStation3,
		// Token: 0x04000C74 RID: 3188
		Null,
		// Token: 0x04000C75 RID: 3189
		[Obsolete("Xbox360 is no longer supported in Unity 5.5+")]
		Xbox360 = 6,
		// Token: 0x04000C76 RID: 3190
		OpenGLES2 = 8,
		// Token: 0x04000C77 RID: 3191
		OpenGLES3 = 11,
		// Token: 0x04000C78 RID: 3192
		PlayStationVita,
		// Token: 0x04000C79 RID: 3193
		PlayStation4,
		// Token: 0x04000C7A RID: 3194
		XboxOne,
		// Token: 0x04000C7B RID: 3195
		PlayStationMobile,
		// Token: 0x04000C7C RID: 3196
		Metal,
		// Token: 0x04000C7D RID: 3197
		OpenGLCore,
		// Token: 0x04000C7E RID: 3198
		Direct3D12,
		// Token: 0x04000C7F RID: 3199
		N3DS,
		// Token: 0x04000C80 RID: 3200
		Vulkan = 21
	}
}
