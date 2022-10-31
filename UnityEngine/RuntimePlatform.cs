using System;

namespace UnityEngine
{
	// Token: 0x0200031C RID: 796
	public enum RuntimePlatform
	{
		// Token: 0x04000A11 RID: 2577
		OSXEditor,
		// Token: 0x04000A12 RID: 2578
		OSXPlayer,
		// Token: 0x04000A13 RID: 2579
		WindowsPlayer,
		// Token: 0x04000A14 RID: 2580
		[Obsolete("WebPlayer export is no longer supported in Unity 5.4+.")]
		OSXWebPlayer,
		// Token: 0x04000A15 RID: 2581
		OSXDashboardPlayer,
		// Token: 0x04000A16 RID: 2582
		[Obsolete("WebPlayer export is no longer supported in Unity 5.4+.")]
		WindowsWebPlayer,
		// Token: 0x04000A17 RID: 2583
		WindowsEditor = 7,
		// Token: 0x04000A18 RID: 2584
		IPhonePlayer,
		// Token: 0x04000A19 RID: 2585
		[Obsolete("Xbox360 export is no longer supported in Unity 5.5+.")]
		XBOX360 = 10,
		// Token: 0x04000A1A RID: 2586
		[Obsolete("PS3 export is no longer supported in Unity >=5.5.")]
		PS3 = 9,
		// Token: 0x04000A1B RID: 2587
		Android = 11,
		// Token: 0x04000A1C RID: 2588
		[Obsolete("NaCl export is no longer supported in Unity 5.0+.")]
		NaCl,
		// Token: 0x04000A1D RID: 2589
		[Obsolete("FlashPlayer export is no longer supported in Unity 5.0+.")]
		FlashPlayer = 15,
		// Token: 0x04000A1E RID: 2590
		LinuxPlayer = 13,
		// Token: 0x04000A1F RID: 2591
		LinuxEditor = 16,
		// Token: 0x04000A20 RID: 2592
		WebGLPlayer,
		// Token: 0x04000A21 RID: 2593
		[Obsolete("Use WSAPlayerX86 instead")]
		MetroPlayerX86,
		// Token: 0x04000A22 RID: 2594
		WSAPlayerX86 = 18,
		// Token: 0x04000A23 RID: 2595
		[Obsolete("Use WSAPlayerX64 instead")]
		MetroPlayerX64,
		// Token: 0x04000A24 RID: 2596
		WSAPlayerX64 = 19,
		// Token: 0x04000A25 RID: 2597
		[Obsolete("Use WSAPlayerARM instead")]
		MetroPlayerARM,
		// Token: 0x04000A26 RID: 2598
		WSAPlayerARM = 20,
		// Token: 0x04000A27 RID: 2599
		[Obsolete("Windows Phone 8 was removed in 5.3")]
		WP8Player,
		// Token: 0x04000A28 RID: 2600
		[Obsolete("BlackBerryPlayer export is no longer supported in Unity 5.4+.")]
		BlackBerryPlayer,
		// Token: 0x04000A29 RID: 2601
		TizenPlayer,
		// Token: 0x04000A2A RID: 2602
		PSP2,
		// Token: 0x04000A2B RID: 2603
		PS4,
		// Token: 0x04000A2C RID: 2604
		PSM,
		// Token: 0x04000A2D RID: 2605
		XboxOne,
		// Token: 0x04000A2E RID: 2606
		SamsungTVPlayer,
		// Token: 0x04000A2F RID: 2607
		WiiU = 30,
		// Token: 0x04000A30 RID: 2608
		tvOS,
		// Token: 0x04000A31 RID: 2609
		Switch
	}
}
