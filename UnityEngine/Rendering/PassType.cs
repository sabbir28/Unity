using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000371 RID: 881
	public enum PassType
	{
		// Token: 0x04000C58 RID: 3160
		Normal,
		// Token: 0x04000C59 RID: 3161
		Vertex,
		// Token: 0x04000C5A RID: 3162
		VertexLM,
		// Token: 0x04000C5B RID: 3163
		VertexLMRGBM,
		// Token: 0x04000C5C RID: 3164
		ForwardBase,
		// Token: 0x04000C5D RID: 3165
		ForwardAdd,
		// Token: 0x04000C5E RID: 3166
		LightPrePassBase,
		// Token: 0x04000C5F RID: 3167
		LightPrePassFinal,
		// Token: 0x04000C60 RID: 3168
		ShadowCaster,
		// Token: 0x04000C61 RID: 3169
		Deferred = 10,
		// Token: 0x04000C62 RID: 3170
		Meta,
		// Token: 0x04000C63 RID: 3171
		MotionVectors
	}
}
