using System;

namespace UnityEngine.Rendering
{
	// Token: 0x0200036D RID: 877
	public enum CameraEvent
	{
		// Token: 0x04000C15 RID: 3093
		BeforeDepthTexture,
		// Token: 0x04000C16 RID: 3094
		AfterDepthTexture,
		// Token: 0x04000C17 RID: 3095
		BeforeDepthNormalsTexture,
		// Token: 0x04000C18 RID: 3096
		AfterDepthNormalsTexture,
		// Token: 0x04000C19 RID: 3097
		BeforeGBuffer,
		// Token: 0x04000C1A RID: 3098
		AfterGBuffer,
		// Token: 0x04000C1B RID: 3099
		BeforeLighting,
		// Token: 0x04000C1C RID: 3100
		AfterLighting,
		// Token: 0x04000C1D RID: 3101
		BeforeFinalPass,
		// Token: 0x04000C1E RID: 3102
		AfterFinalPass,
		// Token: 0x04000C1F RID: 3103
		BeforeForwardOpaque,
		// Token: 0x04000C20 RID: 3104
		AfterForwardOpaque,
		// Token: 0x04000C21 RID: 3105
		BeforeImageEffectsOpaque,
		// Token: 0x04000C22 RID: 3106
		AfterImageEffectsOpaque,
		// Token: 0x04000C23 RID: 3107
		BeforeSkybox,
		// Token: 0x04000C24 RID: 3108
		AfterSkybox,
		// Token: 0x04000C25 RID: 3109
		BeforeForwardAlpha,
		// Token: 0x04000C26 RID: 3110
		AfterForwardAlpha,
		// Token: 0x04000C27 RID: 3111
		BeforeImageEffects,
		// Token: 0x04000C28 RID: 3112
		AfterImageEffects,
		// Token: 0x04000C29 RID: 3113
		AfterEverything,
		// Token: 0x04000C2A RID: 3114
		BeforeReflections,
		// Token: 0x04000C2B RID: 3115
		AfterReflections
	}
}
