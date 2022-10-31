using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000383 RID: 899
	[Flags]
	public enum CopyTextureSupport
	{
		// Token: 0x04000CBF RID: 3263
		None = 0,
		// Token: 0x04000CC0 RID: 3264
		Basic = 1,
		// Token: 0x04000CC1 RID: 3265
		Copy3D = 2,
		// Token: 0x04000CC2 RID: 3266
		DifferentTypes = 4,
		// Token: 0x04000CC3 RID: 3267
		TextureToRT = 8,
		// Token: 0x04000CC4 RID: 3268
		RTToTexture = 16
	}
}
