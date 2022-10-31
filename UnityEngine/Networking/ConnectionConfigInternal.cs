using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Networking
{
	// Token: 0x020002B9 RID: 697
	internal sealed class ConnectionConfigInternal : IDisposable
	{
		// Token: 0x06002D61 RID: 11617 RVA: 0x00041974 File Offset: 0x0003FB74
		private ConnectionConfigInternal()
		{
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x00041980 File Offset: 0x0003FB80
		public ConnectionConfigInternal(ConnectionConfig config)
		{
			if (config == null)
			{
				throw new NullReferenceException("config is not defined");
			}
			this.InitWrapper();
			this.InitPacketSize(config.PacketSize);
			this.InitFragmentSize(config.FragmentSize);
			this.InitResendTimeout(config.ResendTimeout);
			this.InitDisconnectTimeout(config.DisconnectTimeout);
			this.InitConnectTimeout(config.ConnectTimeout);
			this.InitMinUpdateTimeout(config.MinUpdateTimeout);
			this.InitPingTimeout(config.PingTimeout);
			this.InitReducedPingTimeout(config.ReducedPingTimeout);
			this.InitAllCostTimeout(config.AllCostTimeout);
			this.InitNetworkDropThreshold(config.NetworkDropThreshold);
			this.InitOverflowDropThreshold(config.OverflowDropThreshold);
			this.InitMaxConnectionAttempt(config.MaxConnectionAttempt);
			this.InitAckDelay(config.AckDelay);
			this.InitSendDelay(config.SendDelay);
			this.InitMaxCombinedReliableMessageSize(config.MaxCombinedReliableMessageSize);
			this.InitMaxCombinedReliableMessageCount(config.MaxCombinedReliableMessageCount);
			this.InitMaxSentMessageQueueSize(config.MaxSentMessageQueueSize);
			this.InitAcksType((int)config.AcksType);
			this.InitUsePlatformSpecificProtocols(config.UsePlatformSpecificProtocols);
			this.InitInitialBandwidth(config.InitialBandwidth);
			this.InitBandwidthPeakFactor(config.BandwidthPeakFactor);
			this.InitWebSocketReceiveBufferMaxSize(config.WebSocketReceiveBufferMaxSize);
			this.InitUdpSocketReceiveBufferMaxSize(config.UdpSocketReceiveBufferMaxSize);
			if (config.SSLCertFilePath != null)
			{
				int num = this.InitSSLCertFilePath(config.SSLCertFilePath);
				if (num != 0)
				{
					throw new ArgumentOutOfRangeException("SSLCertFilePath cannot be > than " + num.ToString());
				}
			}
			if (config.SSLPrivateKeyFilePath != null)
			{
				int num2 = this.InitSSLPrivateKeyFilePath(config.SSLPrivateKeyFilePath);
				if (num2 != 0)
				{
					throw new ArgumentOutOfRangeException("SSLPrivateKeyFilePath cannot be > than " + num2.ToString());
				}
			}
			if (config.SSLCAFilePath != null)
			{
				int num3 = this.InitSSLCAFilePath(config.SSLCAFilePath);
				if (num3 != 0)
				{
					throw new ArgumentOutOfRangeException("SSLCAFilePath cannot be > than " + num3.ToString());
				}
			}
			byte b = 0;
			while ((int)b < config.ChannelCount)
			{
				this.AddChannel(config.GetChannel(b));
				b += 1;
			}
		}

		// Token: 0x06002D63 RID: 11619
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitWrapper();

		// Token: 0x06002D64 RID: 11620
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern byte AddChannel(QosType value);

		// Token: 0x06002D65 RID: 11621
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern QosType GetChannel(int i);

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06002D66 RID: 11622
		public extern int ChannelSize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002D67 RID: 11623
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitPacketSize(ushort value);

		// Token: 0x06002D68 RID: 11624
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitFragmentSize(ushort value);

		// Token: 0x06002D69 RID: 11625
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitResendTimeout(uint value);

		// Token: 0x06002D6A RID: 11626
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitDisconnectTimeout(uint value);

		// Token: 0x06002D6B RID: 11627
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitConnectTimeout(uint value);

		// Token: 0x06002D6C RID: 11628
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitMinUpdateTimeout(uint value);

		// Token: 0x06002D6D RID: 11629
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitPingTimeout(uint value);

		// Token: 0x06002D6E RID: 11630
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitReducedPingTimeout(uint value);

		// Token: 0x06002D6F RID: 11631
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitAllCostTimeout(uint value);

		// Token: 0x06002D70 RID: 11632
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitNetworkDropThreshold(byte value);

		// Token: 0x06002D71 RID: 11633
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitOverflowDropThreshold(byte value);

		// Token: 0x06002D72 RID: 11634
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitMaxConnectionAttempt(byte value);

		// Token: 0x06002D73 RID: 11635
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitAckDelay(uint value);

		// Token: 0x06002D74 RID: 11636
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitSendDelay(uint value);

		// Token: 0x06002D75 RID: 11637
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitMaxCombinedReliableMessageSize(ushort value);

		// Token: 0x06002D76 RID: 11638
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitMaxCombinedReliableMessageCount(ushort value);

		// Token: 0x06002D77 RID: 11639
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitMaxSentMessageQueueSize(ushort value);

		// Token: 0x06002D78 RID: 11640
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitAcksType(int value);

		// Token: 0x06002D79 RID: 11641
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitUsePlatformSpecificProtocols(bool value);

		// Token: 0x06002D7A RID: 11642
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitInitialBandwidth(uint value);

		// Token: 0x06002D7B RID: 11643
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitBandwidthPeakFactor(float value);

		// Token: 0x06002D7C RID: 11644
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitWebSocketReceiveBufferMaxSize(ushort value);

		// Token: 0x06002D7D RID: 11645
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitUdpSocketReceiveBufferMaxSize(uint value);

		// Token: 0x06002D7E RID: 11646
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int InitSSLCertFilePath(string value);

		// Token: 0x06002D7F RID: 11647
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int InitSSLPrivateKeyFilePath(string value);

		// Token: 0x06002D80 RID: 11648
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int InitSSLCAFilePath(string value);

		// Token: 0x06002D81 RID: 11649
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Dispose();

		// Token: 0x06002D82 RID: 11650 RVA: 0x00041BA0 File Offset: 0x0003FDA0
		~ConnectionConfigInternal()
		{
			this.Dispose();
		}

		// Token: 0x0400092E RID: 2350
		internal IntPtr m_Ptr;
	}
}
