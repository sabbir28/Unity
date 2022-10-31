using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Networking
{
	// Token: 0x020002BB RID: 699
	internal sealed class GlobalConfigInternal : IDisposable
	{
		// Token: 0x06002D8D RID: 11661 RVA: 0x00041CA8 File Offset: 0x0003FEA8
		public GlobalConfigInternal(GlobalConfig config)
		{
			this.InitWrapper();
			this.InitThreadAwakeTimeout(config.ThreadAwakeTimeout);
			this.InitReactorModel((byte)config.ReactorModel);
			this.InitReactorMaximumReceivedMessages(config.ReactorMaximumReceivedMessages);
			this.InitReactorMaximumSentMessages(config.ReactorMaximumSentMessages);
			this.InitMaxPacketSize(config.MaxPacketSize);
			this.InitMaxHosts(config.MaxHosts);
			if (config.ThreadPoolSize == 0 || config.ThreadPoolSize > 254)
			{
				throw new ArgumentOutOfRangeException("Worker thread pool size should be >= 1 && < 254 (for server only)");
			}
			this.InitThreadPoolSize(config.ThreadPoolSize);
			this.InitMinTimerTimeout(config.MinTimerTimeout);
			this.InitMaxTimerTimeout(config.MaxTimerTimeout);
			this.InitMinNetSimulatorTimeout(config.MinNetSimulatorTimeout);
			this.InitMaxNetSimulatorTimeout(config.MaxNetSimulatorTimeout);
		}

		// Token: 0x06002D8E RID: 11662
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitWrapper();

		// Token: 0x06002D8F RID: 11663
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitThreadAwakeTimeout(uint ms);

		// Token: 0x06002D90 RID: 11664
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitReactorModel(byte model);

		// Token: 0x06002D91 RID: 11665
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitReactorMaximumReceivedMessages(ushort size);

		// Token: 0x06002D92 RID: 11666
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitReactorMaximumSentMessages(ushort size);

		// Token: 0x06002D93 RID: 11667
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitMaxPacketSize(ushort size);

		// Token: 0x06002D94 RID: 11668
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitMaxHosts(ushort size);

		// Token: 0x06002D95 RID: 11669
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitThreadPoolSize(byte size);

		// Token: 0x06002D96 RID: 11670
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitMinTimerTimeout(uint ms);

		// Token: 0x06002D97 RID: 11671
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitMaxTimerTimeout(uint ms);

		// Token: 0x06002D98 RID: 11672
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitMinNetSimulatorTimeout(uint ms);

		// Token: 0x06002D99 RID: 11673
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitMaxNetSimulatorTimeout(uint ms);

		// Token: 0x06002D9A RID: 11674
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Dispose();

		// Token: 0x06002D9B RID: 11675 RVA: 0x00041D70 File Offset: 0x0003FF70
		~GlobalConfigInternal()
		{
			this.Dispose();
		}

		// Token: 0x04000930 RID: 2352
		internal IntPtr m_Ptr;
	}
}
