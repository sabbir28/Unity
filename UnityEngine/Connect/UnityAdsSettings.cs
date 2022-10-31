using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Connect
{
	// Token: 0x020002BC RID: 700
	internal class UnityAdsSettings
	{
		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06002D9D RID: 11677
		// (set) Token: 0x06002D9E RID: 11678
		[ThreadAndSerializationSafe]
		public static extern bool enabled { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002D9F RID: 11679
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsPlatformEnabled(RuntimePlatform platform);

		// Token: 0x06002DA0 RID: 11680
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetPlatformEnabled(RuntimePlatform platform, bool value);

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06002DA1 RID: 11681
		// (set) Token: 0x06002DA2 RID: 11682
		public static extern bool initializeOnStartup { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06002DA3 RID: 11683
		// (set) Token: 0x06002DA4 RID: 11684
		public static extern bool testMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002DA5 RID: 11685
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string GetGameId(RuntimePlatform platform);

		// Token: 0x06002DA6 RID: 11686
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGameId(RuntimePlatform platform, string gameId);
	}
}
