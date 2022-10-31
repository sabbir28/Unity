using System;
using System.Collections.Generic;

namespace UnityEngine.Networking
{
	// Token: 0x020002B5 RID: 693
	[Serializable]
	public class ConnectionConfig
	{
		// Token: 0x06002CFC RID: 11516 RVA: 0x00040A14 File Offset: 0x0003EC14
		public ConnectionConfig()
		{
			this.m_PacketSize = 1440;
			this.m_FragmentSize = 500;
			this.m_ResendTimeout = 1200U;
			this.m_DisconnectTimeout = 2000U;
			this.m_ConnectTimeout = 2000U;
			this.m_MinUpdateTimeout = 10U;
			this.m_PingTimeout = 500U;
			this.m_ReducedPingTimeout = 100U;
			this.m_AllCostTimeout = 20U;
			this.m_NetworkDropThreshold = 5;
			this.m_OverflowDropThreshold = 5;
			this.m_MaxConnectionAttempt = 10;
			this.m_AckDelay = 33U;
			this.m_SendDelay = 10U;
			this.m_MaxCombinedReliableMessageSize = 100;
			this.m_MaxCombinedReliableMessageCount = 10;
			this.m_MaxSentMessageQueueSize = 512;
			this.m_AcksType = ConnectionAcksType.Acks32;
			this.m_UsePlatformSpecificProtocols = false;
			this.m_InitialBandwidth = 0U;
			this.m_BandwidthPeakFactor = 2f;
			this.m_WebSocketReceiveBufferMaxSize = 0;
			this.m_UdpSocketReceiveBufferMaxSize = 0U;
			this.m_SSLCertFilePath = null;
			this.m_SSLPrivateKeyFilePath = null;
			this.m_SSLCAFilePath = null;
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x00040B14 File Offset: 0x0003ED14
		public ConnectionConfig(ConnectionConfig config)
		{
			if (config == null)
			{
				throw new NullReferenceException("config is not defined");
			}
			this.m_PacketSize = config.m_PacketSize;
			this.m_FragmentSize = config.m_FragmentSize;
			this.m_ResendTimeout = config.m_ResendTimeout;
			this.m_DisconnectTimeout = config.m_DisconnectTimeout;
			this.m_ConnectTimeout = config.m_ConnectTimeout;
			this.m_MinUpdateTimeout = config.m_MinUpdateTimeout;
			this.m_PingTimeout = config.m_PingTimeout;
			this.m_ReducedPingTimeout = config.m_ReducedPingTimeout;
			this.m_AllCostTimeout = config.m_AllCostTimeout;
			this.m_NetworkDropThreshold = config.m_NetworkDropThreshold;
			this.m_OverflowDropThreshold = config.m_OverflowDropThreshold;
			this.m_MaxConnectionAttempt = config.m_MaxConnectionAttempt;
			this.m_AckDelay = config.m_AckDelay;
			this.m_SendDelay = config.m_SendDelay;
			this.m_MaxCombinedReliableMessageSize = config.MaxCombinedReliableMessageSize;
			this.m_MaxCombinedReliableMessageCount = config.m_MaxCombinedReliableMessageCount;
			this.m_MaxSentMessageQueueSize = config.m_MaxSentMessageQueueSize;
			this.m_AcksType = config.m_AcksType;
			this.m_UsePlatformSpecificProtocols = config.m_UsePlatformSpecificProtocols;
			this.m_InitialBandwidth = config.m_InitialBandwidth;
			if (this.m_InitialBandwidth == 0U)
			{
				this.m_InitialBandwidth = (uint)(this.m_PacketSize * 1000) / this.m_MinUpdateTimeout;
			}
			this.m_BandwidthPeakFactor = config.m_BandwidthPeakFactor;
			this.m_WebSocketReceiveBufferMaxSize = config.m_WebSocketReceiveBufferMaxSize;
			this.m_UdpSocketReceiveBufferMaxSize = config.m_UdpSocketReceiveBufferMaxSize;
			this.m_SSLCertFilePath = config.m_SSLCertFilePath;
			this.m_SSLPrivateKeyFilePath = config.m_SSLPrivateKeyFilePath;
			this.m_SSLCAFilePath = config.m_SSLCAFilePath;
			foreach (ChannelQOS channel in config.m_Channels)
			{
				this.m_Channels.Add(new ChannelQOS(channel));
			}
		}

		// Token: 0x06002CFE RID: 11518 RVA: 0x00040D00 File Offset: 0x0003EF00
		public static void Validate(ConnectionConfig config)
		{
			if (config.m_PacketSize < 128)
			{
				throw new ArgumentOutOfRangeException("PacketSize should be > " + 128.ToString());
			}
			if (config.m_FragmentSize >= config.m_PacketSize - 128)
			{
				throw new ArgumentOutOfRangeException("FragmentSize should be < PacketSize - " + 128.ToString());
			}
			if (config.m_Channels.Count > 255)
			{
				throw new ArgumentOutOfRangeException("Channels number should be less than 256");
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06002CFF RID: 11519 RVA: 0x00040D9C File Offset: 0x0003EF9C
		// (set) Token: 0x06002D00 RID: 11520 RVA: 0x00040DB8 File Offset: 0x0003EFB8
		public ushort PacketSize
		{
			get
			{
				return this.m_PacketSize;
			}
			set
			{
				this.m_PacketSize = value;
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06002D01 RID: 11521 RVA: 0x00040DC4 File Offset: 0x0003EFC4
		// (set) Token: 0x06002D02 RID: 11522 RVA: 0x00040DE0 File Offset: 0x0003EFE0
		public ushort FragmentSize
		{
			get
			{
				return this.m_FragmentSize;
			}
			set
			{
				this.m_FragmentSize = value;
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06002D03 RID: 11523 RVA: 0x00040DEC File Offset: 0x0003EFEC
		// (set) Token: 0x06002D04 RID: 11524 RVA: 0x00040E08 File Offset: 0x0003F008
		public uint ResendTimeout
		{
			get
			{
				return this.m_ResendTimeout;
			}
			set
			{
				this.m_ResendTimeout = value;
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06002D05 RID: 11525 RVA: 0x00040E14 File Offset: 0x0003F014
		// (set) Token: 0x06002D06 RID: 11526 RVA: 0x00040E30 File Offset: 0x0003F030
		public uint DisconnectTimeout
		{
			get
			{
				return this.m_DisconnectTimeout;
			}
			set
			{
				this.m_DisconnectTimeout = value;
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06002D07 RID: 11527 RVA: 0x00040E3C File Offset: 0x0003F03C
		// (set) Token: 0x06002D08 RID: 11528 RVA: 0x00040E58 File Offset: 0x0003F058
		public uint ConnectTimeout
		{
			get
			{
				return this.m_ConnectTimeout;
			}
			set
			{
				this.m_ConnectTimeout = value;
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06002D09 RID: 11529 RVA: 0x00040E64 File Offset: 0x0003F064
		// (set) Token: 0x06002D0A RID: 11530 RVA: 0x00040E80 File Offset: 0x0003F080
		public uint MinUpdateTimeout
		{
			get
			{
				return this.m_MinUpdateTimeout;
			}
			set
			{
				if (value == 0U)
				{
					throw new ArgumentOutOfRangeException("Minimal update timeout should be > 0");
				}
				this.m_MinUpdateTimeout = value;
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06002D0B RID: 11531 RVA: 0x00040E9C File Offset: 0x0003F09C
		// (set) Token: 0x06002D0C RID: 11532 RVA: 0x00040EB8 File Offset: 0x0003F0B8
		public uint PingTimeout
		{
			get
			{
				return this.m_PingTimeout;
			}
			set
			{
				this.m_PingTimeout = value;
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06002D0D RID: 11533 RVA: 0x00040EC4 File Offset: 0x0003F0C4
		// (set) Token: 0x06002D0E RID: 11534 RVA: 0x00040EE0 File Offset: 0x0003F0E0
		public uint ReducedPingTimeout
		{
			get
			{
				return this.m_ReducedPingTimeout;
			}
			set
			{
				this.m_ReducedPingTimeout = value;
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06002D0F RID: 11535 RVA: 0x00040EEC File Offset: 0x0003F0EC
		// (set) Token: 0x06002D10 RID: 11536 RVA: 0x00040F08 File Offset: 0x0003F108
		public uint AllCostTimeout
		{
			get
			{
				return this.m_AllCostTimeout;
			}
			set
			{
				this.m_AllCostTimeout = value;
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06002D11 RID: 11537 RVA: 0x00040F14 File Offset: 0x0003F114
		// (set) Token: 0x06002D12 RID: 11538 RVA: 0x00040F30 File Offset: 0x0003F130
		public byte NetworkDropThreshold
		{
			get
			{
				return this.m_NetworkDropThreshold;
			}
			set
			{
				this.m_NetworkDropThreshold = value;
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06002D13 RID: 11539 RVA: 0x00040F3C File Offset: 0x0003F13C
		// (set) Token: 0x06002D14 RID: 11540 RVA: 0x00040F58 File Offset: 0x0003F158
		public byte OverflowDropThreshold
		{
			get
			{
				return this.m_OverflowDropThreshold;
			}
			set
			{
				this.m_OverflowDropThreshold = value;
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06002D15 RID: 11541 RVA: 0x00040F64 File Offset: 0x0003F164
		// (set) Token: 0x06002D16 RID: 11542 RVA: 0x00040F80 File Offset: 0x0003F180
		public byte MaxConnectionAttempt
		{
			get
			{
				return this.m_MaxConnectionAttempt;
			}
			set
			{
				this.m_MaxConnectionAttempt = value;
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06002D17 RID: 11543 RVA: 0x00040F8C File Offset: 0x0003F18C
		// (set) Token: 0x06002D18 RID: 11544 RVA: 0x00040FA8 File Offset: 0x0003F1A8
		public uint AckDelay
		{
			get
			{
				return this.m_AckDelay;
			}
			set
			{
				this.m_AckDelay = value;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06002D19 RID: 11545 RVA: 0x00040FB4 File Offset: 0x0003F1B4
		// (set) Token: 0x06002D1A RID: 11546 RVA: 0x00040FD0 File Offset: 0x0003F1D0
		public uint SendDelay
		{
			get
			{
				return this.m_SendDelay;
			}
			set
			{
				this.m_SendDelay = value;
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06002D1B RID: 11547 RVA: 0x00040FDC File Offset: 0x0003F1DC
		// (set) Token: 0x06002D1C RID: 11548 RVA: 0x00040FF8 File Offset: 0x0003F1F8
		public ushort MaxCombinedReliableMessageSize
		{
			get
			{
				return this.m_MaxCombinedReliableMessageSize;
			}
			set
			{
				this.m_MaxCombinedReliableMessageSize = value;
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06002D1D RID: 11549 RVA: 0x00041004 File Offset: 0x0003F204
		// (set) Token: 0x06002D1E RID: 11550 RVA: 0x00041020 File Offset: 0x0003F220
		public ushort MaxCombinedReliableMessageCount
		{
			get
			{
				return this.m_MaxCombinedReliableMessageCount;
			}
			set
			{
				this.m_MaxCombinedReliableMessageCount = value;
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06002D1F RID: 11551 RVA: 0x0004102C File Offset: 0x0003F22C
		// (set) Token: 0x06002D20 RID: 11552 RVA: 0x00041048 File Offset: 0x0003F248
		public ushort MaxSentMessageQueueSize
		{
			get
			{
				return this.m_MaxSentMessageQueueSize;
			}
			set
			{
				this.m_MaxSentMessageQueueSize = value;
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06002D21 RID: 11553 RVA: 0x00041054 File Offset: 0x0003F254
		// (set) Token: 0x06002D22 RID: 11554 RVA: 0x00041070 File Offset: 0x0003F270
		public ConnectionAcksType AcksType
		{
			get
			{
				return this.m_AcksType;
			}
			set
			{
				this.m_AcksType = value;
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06002D23 RID: 11555 RVA: 0x0004107C File Offset: 0x0003F27C
		// (set) Token: 0x06002D24 RID: 11556 RVA: 0x000410A0 File Offset: 0x0003F2A0
		[Obsolete("IsAcksLong is deprecated. Use AcksType = ConnectionAcksType.Acks64", false)]
		public bool IsAcksLong
		{
			get
			{
				return this.m_AcksType != ConnectionAcksType.Acks32;
			}
			set
			{
				if (value && this.m_AcksType == ConnectionAcksType.Acks32)
				{
					this.m_AcksType = ConnectionAcksType.Acks64;
				}
				else if (!value)
				{
					this.m_AcksType = ConnectionAcksType.Acks32;
				}
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06002D25 RID: 11557 RVA: 0x000410D0 File Offset: 0x0003F2D0
		// (set) Token: 0x06002D26 RID: 11558 RVA: 0x000410EC File Offset: 0x0003F2EC
		public bool UsePlatformSpecificProtocols
		{
			get
			{
				return this.m_UsePlatformSpecificProtocols;
			}
			set
			{
				if (value && Application.platform != RuntimePlatform.PS4 && Application.platform != RuntimePlatform.PSP2)
				{
					throw new ArgumentOutOfRangeException("Platform specific protocols are not supported on this platform");
				}
				this.m_UsePlatformSpecificProtocols = value;
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06002D27 RID: 11559 RVA: 0x00041120 File Offset: 0x0003F320
		// (set) Token: 0x06002D28 RID: 11560 RVA: 0x0004113C File Offset: 0x0003F33C
		public uint InitialBandwidth
		{
			get
			{
				return this.m_InitialBandwidth;
			}
			set
			{
				this.m_InitialBandwidth = value;
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06002D29 RID: 11561 RVA: 0x00041148 File Offset: 0x0003F348
		// (set) Token: 0x06002D2A RID: 11562 RVA: 0x00041164 File Offset: 0x0003F364
		public float BandwidthPeakFactor
		{
			get
			{
				return this.m_BandwidthPeakFactor;
			}
			set
			{
				this.m_BandwidthPeakFactor = value;
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06002D2B RID: 11563 RVA: 0x00041170 File Offset: 0x0003F370
		// (set) Token: 0x06002D2C RID: 11564 RVA: 0x0004118C File Offset: 0x0003F38C
		public ushort WebSocketReceiveBufferMaxSize
		{
			get
			{
				return this.m_WebSocketReceiveBufferMaxSize;
			}
			set
			{
				this.m_WebSocketReceiveBufferMaxSize = value;
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06002D2D RID: 11565 RVA: 0x00041198 File Offset: 0x0003F398
		// (set) Token: 0x06002D2E RID: 11566 RVA: 0x000411B4 File Offset: 0x0003F3B4
		public uint UdpSocketReceiveBufferMaxSize
		{
			get
			{
				return this.m_UdpSocketReceiveBufferMaxSize;
			}
			set
			{
				this.m_UdpSocketReceiveBufferMaxSize = value;
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06002D2F RID: 11567 RVA: 0x000411C0 File Offset: 0x0003F3C0
		// (set) Token: 0x06002D30 RID: 11568 RVA: 0x000411DC File Offset: 0x0003F3DC
		public string SSLCertFilePath
		{
			get
			{
				return this.m_SSLCertFilePath;
			}
			set
			{
				this.m_SSLCertFilePath = value;
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06002D31 RID: 11569 RVA: 0x000411E8 File Offset: 0x0003F3E8
		// (set) Token: 0x06002D32 RID: 11570 RVA: 0x00041204 File Offset: 0x0003F404
		public string SSLPrivateKeyFilePath
		{
			get
			{
				return this.m_SSLPrivateKeyFilePath;
			}
			set
			{
				this.m_SSLPrivateKeyFilePath = value;
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06002D33 RID: 11571 RVA: 0x00041210 File Offset: 0x0003F410
		// (set) Token: 0x06002D34 RID: 11572 RVA: 0x0004122C File Offset: 0x0003F42C
		public string SSLCAFilePath
		{
			get
			{
				return this.m_SSLCAFilePath;
			}
			set
			{
				this.m_SSLCAFilePath = value;
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06002D35 RID: 11573 RVA: 0x00041238 File Offset: 0x0003F438
		public int ChannelCount
		{
			get
			{
				return this.m_Channels.Count;
			}
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x00041258 File Offset: 0x0003F458
		public byte AddChannel(QosType value)
		{
			if (this.m_Channels.Count > 255)
			{
				throw new ArgumentOutOfRangeException("Channels Count should be less than 256");
			}
			if (!Enum.IsDefined(typeof(QosType), value))
			{
				throw new ArgumentOutOfRangeException("requested qos type doesn't exist: " + (int)value);
			}
			ChannelQOS item = new ChannelQOS(value);
			this.m_Channels.Add(item);
			return (byte)(this.m_Channels.Count - 1);
		}

		// Token: 0x06002D37 RID: 11575 RVA: 0x000412E0 File Offset: 0x0003F4E0
		public QosType GetChannel(byte idx)
		{
			if ((int)idx >= this.m_Channels.Count)
			{
				throw new ArgumentOutOfRangeException("requested index greater than maximum channels count");
			}
			return this.m_Channels[(int)idx].QOS;
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06002D38 RID: 11576 RVA: 0x00041324 File Offset: 0x0003F524
		public List<ChannelQOS> Channels
		{
			get
			{
				return this.m_Channels;
			}
		}

		// Token: 0x040008FD RID: 2301
		private const int g_MinPacketSize = 128;

		// Token: 0x040008FE RID: 2302
		[SerializeField]
		private ushort m_PacketSize;

		// Token: 0x040008FF RID: 2303
		[SerializeField]
		private ushort m_FragmentSize;

		// Token: 0x04000900 RID: 2304
		[SerializeField]
		private uint m_ResendTimeout;

		// Token: 0x04000901 RID: 2305
		[SerializeField]
		private uint m_DisconnectTimeout;

		// Token: 0x04000902 RID: 2306
		[SerializeField]
		private uint m_ConnectTimeout;

		// Token: 0x04000903 RID: 2307
		[SerializeField]
		private uint m_MinUpdateTimeout;

		// Token: 0x04000904 RID: 2308
		[SerializeField]
		private uint m_PingTimeout;

		// Token: 0x04000905 RID: 2309
		[SerializeField]
		private uint m_ReducedPingTimeout;

		// Token: 0x04000906 RID: 2310
		[SerializeField]
		private uint m_AllCostTimeout;

		// Token: 0x04000907 RID: 2311
		[SerializeField]
		private byte m_NetworkDropThreshold;

		// Token: 0x04000908 RID: 2312
		[SerializeField]
		private byte m_OverflowDropThreshold;

		// Token: 0x04000909 RID: 2313
		[SerializeField]
		private byte m_MaxConnectionAttempt;

		// Token: 0x0400090A RID: 2314
		[SerializeField]
		private uint m_AckDelay;

		// Token: 0x0400090B RID: 2315
		[SerializeField]
		private uint m_SendDelay;

		// Token: 0x0400090C RID: 2316
		[SerializeField]
		private ushort m_MaxCombinedReliableMessageSize;

		// Token: 0x0400090D RID: 2317
		[SerializeField]
		private ushort m_MaxCombinedReliableMessageCount;

		// Token: 0x0400090E RID: 2318
		[SerializeField]
		private ushort m_MaxSentMessageQueueSize;

		// Token: 0x0400090F RID: 2319
		[SerializeField]
		private ConnectionAcksType m_AcksType;

		// Token: 0x04000910 RID: 2320
		[SerializeField]
		private bool m_UsePlatformSpecificProtocols;

		// Token: 0x04000911 RID: 2321
		[SerializeField]
		private uint m_InitialBandwidth;

		// Token: 0x04000912 RID: 2322
		[SerializeField]
		private float m_BandwidthPeakFactor;

		// Token: 0x04000913 RID: 2323
		[SerializeField]
		private ushort m_WebSocketReceiveBufferMaxSize;

		// Token: 0x04000914 RID: 2324
		[SerializeField]
		private uint m_UdpSocketReceiveBufferMaxSize;

		// Token: 0x04000915 RID: 2325
		[SerializeField]
		private string m_SSLCertFilePath;

		// Token: 0x04000916 RID: 2326
		[SerializeField]
		private string m_SSLPrivateKeyFilePath;

		// Token: 0x04000917 RID: 2327
		[SerializeField]
		private string m_SSLCAFilePath;

		// Token: 0x04000918 RID: 2328
		[SerializeField]
		internal List<ChannelQOS> m_Channels = new List<ChannelQOS>();
	}
}
