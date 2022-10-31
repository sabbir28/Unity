using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000058 RID: 88
	public sealed class LightmapSettings : Object
	{
		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060006DC RID: 1756
		// (set) Token: 0x060006DD RID: 1757
		public static extern LightmapData[] lightmaps { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060006DE RID: 1758
		// (set) Token: 0x060006DF RID: 1759
		public static extern LightmapsMode lightmapsMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060006E0 RID: 1760
		// (set) Token: 0x060006E1 RID: 1761
		public static extern LightProbes lightProbes { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060006E2 RID: 1762
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Reset();

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x00009158 File Offset: 0x00007358
		// (set) Token: 0x060006E4 RID: 1764 RVA: 0x00009170 File Offset: 0x00007370
		[Obsolete("Use lightmapsMode instead.", false)]
		public static LightmapsModeLegacy lightmapsModeLegacy
		{
			get
			{
				return LightmapsModeLegacy.Single;
			}
			set
			{
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00009174 File Offset: 0x00007374
		// (set) Token: 0x060006E6 RID: 1766 RVA: 0x00009190 File Offset: 0x00007390
		[Obsolete("Use QualitySettings.desiredColorSpace instead.", false)]
		public static ColorSpace bakedColorSpace
		{
			get
			{
				return QualitySettings.desiredColorSpace;
			}
			set
			{
			}
		}
	}
}
