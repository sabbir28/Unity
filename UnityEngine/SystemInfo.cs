using System;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000015 RID: 21
	public sealed class SystemInfo
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001B3 RID: 435
		public static extern float batteryLevel { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060001B4 RID: 436
		public static extern BatteryStatus batteryStatus { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060001B5 RID: 437
		public static extern string operatingSystem { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001B6 RID: 438
		public static extern OperatingSystemFamily operatingSystemFamily { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001B7 RID: 439
		public static extern string processorType { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001B8 RID: 440
		public static extern int processorFrequency { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001B9 RID: 441
		public static extern int processorCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001BA RID: 442
		public static extern int systemMemorySize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001BB RID: 443
		public static extern int graphicsMemorySize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001BC RID: 444
		public static extern string graphicsDeviceName { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001BD RID: 445
		public static extern string graphicsDeviceVendor { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001BE RID: 446
		public static extern int graphicsDeviceID { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001BF RID: 447
		public static extern int graphicsDeviceVendorID { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001C0 RID: 448
		public static extern GraphicsDeviceType graphicsDeviceType { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001C1 RID: 449
		public static extern bool graphicsUVStartsAtTop { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001C2 RID: 450
		public static extern string graphicsDeviceVersion { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001C3 RID: 451
		public static extern int graphicsShaderLevel { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00004E9C File Offset: 0x0000309C
		[Obsolete("graphicsPixelFillrate is no longer supported in Unity 5.0+.")]
		public static int graphicsPixelFillrate
		{
			get
			{
				return -1;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x00004EB4 File Offset: 0x000030B4
		[Obsolete("Vertex program support is required in Unity 5.0+")]
		public static bool supportsVertexPrograms
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001C6 RID: 454
		public static extern bool graphicsMultiThreaded { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001C7 RID: 455
		public static extern bool supportsShadows { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001C8 RID: 456
		public static extern bool supportsRawShadowDepthSampling { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001C9 RID: 457
		[Obsolete("supportsRenderTextures always returns true, no need to call it")]
		public static extern bool supportsRenderTextures { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001CA RID: 458
		public static extern bool supportsMotionVectors { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001CB RID: 459
		public static extern bool supportsRenderToCubemap { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001CC RID: 460
		public static extern bool supportsImageEffects { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001CD RID: 461
		public static extern bool supports3DTextures { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001CE RID: 462
		public static extern bool supports2DArrayTextures { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001CF RID: 463
		public static extern bool supports3DRenderTextures { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001D0 RID: 464
		public static extern bool supportsCubemapArrayTextures { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001D1 RID: 465
		public static extern CopyTextureSupport copyTextureSupport { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001D2 RID: 466
		public static extern bool supportsComputeShaders { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001D3 RID: 467
		public static extern bool supportsInstancing { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001D4 RID: 468
		public static extern bool supportsSparseTextures { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001D5 RID: 469
		public static extern int supportedRenderTargetCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001D6 RID: 470
		public static extern bool usesReversedZBuffer { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001D7 RID: 471
		[Obsolete("supportsStencil always returns true, no need to call it")]
		public static extern int supportsStencil { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060001D8 RID: 472
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SupportsRenderTextureFormat(RenderTextureFormat format);

		// Token: 0x060001D9 RID: 473
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SupportsTextureFormat(TextureFormat format);

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001DA RID: 474
		public static extern NPOTSupport npotSupport { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001DB RID: 475
		public static extern string deviceUniqueIdentifier { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001DC RID: 476
		public static extern string deviceName { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001DD RID: 477
		public static extern string deviceModel { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001DE RID: 478
		public static extern bool supportsAccelerometer { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001DF RID: 479
		public static extern bool supportsGyroscope { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001E0 RID: 480
		public static extern bool supportsLocationService { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001E1 RID: 481
		public static extern bool supportsVibration { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001E2 RID: 482
		public static extern bool supportsAudio { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001E3 RID: 483
		public static extern DeviceType deviceType { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001E4 RID: 484
		public static extern int maxTextureSize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001E5 RID: 485
		public static extern int maxCubemapSize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001E6 RID: 486
		internal static extern int maxRenderTextureSize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x04000028 RID: 40
		public const string unsupportedIdentifier = "n/a";
	}
}
