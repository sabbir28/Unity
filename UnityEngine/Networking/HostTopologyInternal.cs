using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Networking
{
	// Token: 0x020002BA RID: 698
	internal sealed class HostTopologyInternal : IDisposable
	{
		// Token: 0x06002D83 RID: 11651 RVA: 0x00041BD0 File Offset: 0x0003FDD0
		public HostTopologyInternal(HostTopology topology)
		{
			ConnectionConfigInternal config = new ConnectionConfigInternal(topology.DefaultConfig);
			this.InitWrapper(config, topology.MaxDefaultConnections);
			for (int i = 1; i <= topology.SpecialConnectionConfigsCount; i++)
			{
				ConnectionConfig specialConnectionConfig = topology.GetSpecialConnectionConfig(i);
				ConnectionConfigInternal config2 = new ConnectionConfigInternal(specialConnectionConfig);
				this.AddSpecialConnectionConfig(config2);
			}
			this.InitOtherParameters(topology);
		}

		// Token: 0x06002D84 RID: 11652
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitWrapper(ConnectionConfigInternal config, int maxDefaultConnections);

		// Token: 0x06002D85 RID: 11653 RVA: 0x00041C34 File Offset: 0x0003FE34
		private int AddSpecialConnectionConfig(ConnectionConfigInternal config)
		{
			return this.AddSpecialConnectionConfigWrapper(config);
		}

		// Token: 0x06002D86 RID: 11654
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int AddSpecialConnectionConfigWrapper(ConnectionConfigInternal config);

		// Token: 0x06002D87 RID: 11655 RVA: 0x00041C50 File Offset: 0x0003FE50
		private void InitOtherParameters(HostTopology topology)
		{
			this.InitReceivedPoolSize(topology.ReceivedMessagePoolSize);
			this.InitSentMessagePoolSize(topology.SentMessagePoolSize);
			this.InitMessagePoolSizeGrowthFactor(topology.MessagePoolSizeGrowthFactor);
		}

		// Token: 0x06002D88 RID: 11656
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitReceivedPoolSize(ushort pool);

		// Token: 0x06002D89 RID: 11657
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitSentMessagePoolSize(ushort pool);

		// Token: 0x06002D8A RID: 11658
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitMessagePoolSizeGrowthFactor(float factor);

		// Token: 0x06002D8B RID: 11659
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Dispose();

		// Token: 0x06002D8C RID: 11660 RVA: 0x00041C78 File Offset: 0x0003FE78
		~HostTopologyInternal()
		{
			this.Dispose();
		}

		// Token: 0x0400092F RID: 2351
		internal IntPtr m_Ptr;
	}
}
