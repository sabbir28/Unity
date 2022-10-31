using System;

namespace UnityEngine.VR
{
	// Token: 0x020002D7 RID: 727
	[Obsolete("VRDeviceType is deprecated. Use VRSettings.supportedDevices instead.")]
	public enum VRDeviceType
	{
		// Token: 0x04000962 RID: 2402
		[Obsolete("Enum member VRDeviceType.Morpheus has been deprecated. Use VRDeviceType.PlayStationVR instead (UnityUpgradable) -> PlayStationVR", true)]
		Morpheus = -1,
		// Token: 0x04000963 RID: 2403
		None,
		// Token: 0x04000964 RID: 2404
		Stereo,
		// Token: 0x04000965 RID: 2405
		Split,
		// Token: 0x04000966 RID: 2406
		Oculus,
		// Token: 0x04000967 RID: 2407
		PlayStationVR,
		// Token: 0x04000968 RID: 2408
		Unknown
	}
}
