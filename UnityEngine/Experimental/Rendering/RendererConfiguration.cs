using System;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000437 RID: 1079
	[Flags]
	public enum RendererConfiguration
	{
		// Token: 0x04000F65 RID: 3941
		None = 0,
		// Token: 0x04000F66 RID: 3942
		PerObjectLightProbe = 1,
		// Token: 0x04000F67 RID: 3943
		PerObjectReflectionProbes = 2,
		// Token: 0x04000F68 RID: 3944
		PerObjectLightProbeProxyVolume = 4,
		// Token: 0x04000F69 RID: 3945
		PerObjectLightmaps = 8,
		// Token: 0x04000F6A RID: 3946
		ProvideLightIndices = 16
	}
}
