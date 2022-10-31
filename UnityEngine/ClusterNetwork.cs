using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200028A RID: 650
	public sealed class ClusterNetwork
	{
		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06002B6A RID: 11114
		public static extern bool isMasterOfCluster { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06002B6B RID: 11115
		public static extern bool isDisconnected { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06002B6C RID: 11116
		// (set) Token: 0x06002B6D RID: 11117
		public static extern int nodeIndex { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
