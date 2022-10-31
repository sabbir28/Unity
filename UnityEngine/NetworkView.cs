using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000095 RID: 149
	public sealed class NetworkView : Behaviour
	{
		// Token: 0x06000A95 RID: 2709
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_RPC(NetworkView view, string name, RPCMode mode, object[] args);

		// Token: 0x06000A96 RID: 2710 RVA: 0x0000F47C File Offset: 0x0000D67C
		private static void Internal_RPC_Target(NetworkView view, string name, NetworkPlayer target, object[] args)
		{
			NetworkView.INTERNAL_CALL_Internal_RPC_Target(view, name, ref target, args);
		}

		// Token: 0x06000A97 RID: 2711
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_RPC_Target(NetworkView view, string name, ref NetworkPlayer target, object[] args);

		// Token: 0x06000A98 RID: 2712 RVA: 0x0000F48C File Offset: 0x0000D68C
		[Obsolete("NetworkView RPC functions are deprecated. Refer to the new Multiplayer Networking system.")]
		public void RPC(string name, RPCMode mode, params object[] args)
		{
			NetworkView.Internal_RPC(this, name, mode, args);
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x0000F498 File Offset: 0x0000D698
		[Obsolete("NetworkView RPC functions are deprecated. Refer to the new Multiplayer Networking system.")]
		public void RPC(string name, NetworkPlayer target, params object[] args)
		{
			NetworkView.Internal_RPC_Target(this, name, target, args);
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000A9A RID: 2714
		// (set) Token: 0x06000A9B RID: 2715
		public extern Component observed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000A9C RID: 2716
		// (set) Token: 0x06000A9D RID: 2717
		public extern NetworkStateSynchronization stateSynchronization { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000A9E RID: 2718
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_GetViewID(out NetworkViewID viewID);

		// Token: 0x06000A9F RID: 2719 RVA: 0x0000F4A4 File Offset: 0x0000D6A4
		private void Internal_SetViewID(NetworkViewID viewID)
		{
			NetworkView.INTERNAL_CALL_Internal_SetViewID(this, ref viewID);
		}

		// Token: 0x06000AA0 RID: 2720
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_SetViewID(NetworkView self, ref NetworkViewID viewID);

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x0000F4B0 File Offset: 0x0000D6B0
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x0000F4D0 File Offset: 0x0000D6D0
		public NetworkViewID viewID
		{
			get
			{
				NetworkViewID result;
				this.Internal_GetViewID(out result);
				return result;
			}
			set
			{
				this.Internal_SetViewID(value);
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000AA3 RID: 2723
		// (set) Token: 0x06000AA4 RID: 2724
		public extern int group { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x0000F4DC File Offset: 0x0000D6DC
		public bool isMine
		{
			get
			{
				return this.viewID.isMine;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x0000F500 File Offset: 0x0000D700
		public NetworkPlayer owner
		{
			get
			{
				return this.viewID.owner;
			}
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x0000F524 File Offset: 0x0000D724
		public bool SetScope(NetworkPlayer player, bool relevancy)
		{
			return NetworkView.INTERNAL_CALL_SetScope(this, ref player, relevancy);
		}

		// Token: 0x06000AA8 RID: 2728
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_SetScope(NetworkView self, ref NetworkPlayer player, bool relevancy);

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0000F544 File Offset: 0x0000D744
		public static NetworkView Find(NetworkViewID viewID)
		{
			return NetworkView.INTERNAL_CALL_Find(ref viewID);
		}

		// Token: 0x06000AAA RID: 2730
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern NetworkView INTERNAL_CALL_Find(ref NetworkViewID viewID);
	}
}
