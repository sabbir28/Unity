using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200009A RID: 154
	public sealed class MasterServer
	{
		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000B39 RID: 2873
		// (set) Token: 0x06000B3A RID: 2874
		public static extern string ipAddress { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000B3B RID: 2875
		// (set) Token: 0x06000B3C RID: 2876
		public static extern int port { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000B3D RID: 2877
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RequestHostList(string gameTypeName);

		// Token: 0x06000B3E RID: 2878
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern HostData[] PollHostList();

		// Token: 0x06000B3F RID: 2879
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RegisterHost(string gameTypeName, string gameName, [DefaultValue("\"\"")] string comment);

		// Token: 0x06000B40 RID: 2880 RVA: 0x0000FC2C File Offset: 0x0000DE2C
		[ExcludeFromDocs]
		public static void RegisterHost(string gameTypeName, string gameName)
		{
			string comment = "";
			MasterServer.RegisterHost(gameTypeName, gameName, comment);
		}

		// Token: 0x06000B41 RID: 2881
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnregisterHost();

		// Token: 0x06000B42 RID: 2882
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearHostList();

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000B43 RID: 2883
		// (set) Token: 0x06000B44 RID: 2884
		public static extern int updateRate { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000B45 RID: 2885
		// (set) Token: 0x06000B46 RID: 2886
		public static extern bool dedicatedServer { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
