using System;

namespace UnityEngine.Networking
{
	// Token: 0x020002B7 RID: 695
	[Serializable]
	public class GlobalConfig
	{
		// Token: 0x06002D47 RID: 11591 RVA: 0x000415D0 File Offset: 0x0003F7D0
		public GlobalConfig()
		{
			this.m_ThreadAwakeTimeout = 1U;
			this.m_ReactorModel = ReactorModel.SelectReactor;
			this.m_ReactorMaximumReceivedMessages = 1024;
			this.m_ReactorMaximumSentMessages = 1024;
			this.m_MaxPacketSize = 2000;
			this.m_MaxHosts = 16;
			this.m_ThreadPoolSize = 1;
			this.m_MinTimerTimeout = 1U;
			this.m_MaxTimerTimeout = 12000U;
			this.m_MinNetSimulatorTimeout = 1U;
			this.m_MaxNetSimulatorTimeout = 12000U;
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06002D48 RID: 11592 RVA: 0x00041648 File Offset: 0x0003F848
		// (set) Token: 0x06002D49 RID: 11593 RVA: 0x00041664 File Offset: 0x0003F864
		public uint ThreadAwakeTimeout
		{
			get
			{
				return this.m_ThreadAwakeTimeout;
			}
			set
			{
				if (value == 0U)
				{
					throw new ArgumentOutOfRangeException("Minimal thread awake timeout should be > 0");
				}
				this.m_ThreadAwakeTimeout = value;
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06002D4A RID: 11594 RVA: 0x00041680 File Offset: 0x0003F880
		// (set) Token: 0x06002D4B RID: 11595 RVA: 0x0004169C File Offset: 0x0003F89C
		public ReactorModel ReactorModel
		{
			get
			{
				return this.m_ReactorModel;
			}
			set
			{
				this.m_ReactorModel = value;
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06002D4C RID: 11596 RVA: 0x000416A8 File Offset: 0x0003F8A8
		// (set) Token: 0x06002D4D RID: 11597 RVA: 0x000416C4 File Offset: 0x0003F8C4
		public ushort ReactorMaximumReceivedMessages
		{
			get
			{
				return this.m_ReactorMaximumReceivedMessages;
			}
			set
			{
				this.m_ReactorMaximumReceivedMessages = value;
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06002D4E RID: 11598 RVA: 0x000416D0 File Offset: 0x0003F8D0
		// (set) Token: 0x06002D4F RID: 11599 RVA: 0x000416EC File Offset: 0x0003F8EC
		public ushort ReactorMaximumSentMessages
		{
			get
			{
				return this.m_ReactorMaximumSentMessages;
			}
			set
			{
				this.m_ReactorMaximumSentMessages = value;
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06002D50 RID: 11600 RVA: 0x000416F8 File Offset: 0x0003F8F8
		// (set) Token: 0x06002D51 RID: 11601 RVA: 0x00041714 File Offset: 0x0003F914
		public ushort MaxPacketSize
		{
			get
			{
				return this.m_MaxPacketSize;
			}
			set
			{
				this.m_MaxPacketSize = value;
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06002D52 RID: 11602 RVA: 0x00041720 File Offset: 0x0003F920
		// (set) Token: 0x06002D53 RID: 11603 RVA: 0x0004173C File Offset: 0x0003F93C
		public ushort MaxHosts
		{
			get
			{
				return this.m_MaxHosts;
			}
			set
			{
				if (value == 0)
				{
					throw new ArgumentOutOfRangeException("MaxHosts", "Maximum hosts number should be > 0");
				}
				if (value > 128)
				{
					throw new ArgumentOutOfRangeException("MaxHosts", "Maximum hosts number should be <= " + 128.ToString());
				}
				this.m_MaxHosts = value;
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06002D54 RID: 11604 RVA: 0x0004179C File Offset: 0x0003F99C
		// (set) Token: 0x06002D55 RID: 11605 RVA: 0x000417B8 File Offset: 0x0003F9B8
		public byte ThreadPoolSize
		{
			get
			{
				return this.m_ThreadPoolSize;
			}
			set
			{
				this.m_ThreadPoolSize = value;
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06002D56 RID: 11606 RVA: 0x000417C4 File Offset: 0x0003F9C4
		// (set) Token: 0x06002D57 RID: 11607 RVA: 0x000417E0 File Offset: 0x0003F9E0
		public uint MinTimerTimeout
		{
			get
			{
				return this.m_MinTimerTimeout;
			}
			set
			{
				if (value > this.MaxTimerTimeout)
				{
					throw new ArgumentOutOfRangeException("MinTimerTimeout should be < MaxTimerTimeout");
				}
				if (value == 0U)
				{
					throw new ArgumentOutOfRangeException("MinTimerTimeout should be > 0");
				}
				this.m_MinTimerTimeout = value;
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06002D58 RID: 11608 RVA: 0x00041814 File Offset: 0x0003FA14
		// (set) Token: 0x06002D59 RID: 11609 RVA: 0x00041830 File Offset: 0x0003FA30
		public uint MaxTimerTimeout
		{
			get
			{
				return this.m_MaxTimerTimeout;
			}
			set
			{
				if (value == 0U)
				{
					throw new ArgumentOutOfRangeException("MaxTimerTimeout should be > 0");
				}
				if (value > 12000U)
				{
					throw new ArgumentOutOfRangeException("MaxTimerTimeout should be <=" + 12000U.ToString());
				}
				this.m_MaxTimerTimeout = value;
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06002D5A RID: 11610 RVA: 0x00041884 File Offset: 0x0003FA84
		// (set) Token: 0x06002D5B RID: 11611 RVA: 0x000418A0 File Offset: 0x0003FAA0
		public uint MinNetSimulatorTimeout
		{
			get
			{
				return this.m_MinNetSimulatorTimeout;
			}
			set
			{
				if (value > this.MaxNetSimulatorTimeout)
				{
					throw new ArgumentOutOfRangeException("MinNetSimulatorTimeout should be < MaxTimerTimeout");
				}
				if (value == 0U)
				{
					throw new ArgumentOutOfRangeException("MinNetSimulatorTimeout should be > 0");
				}
				this.m_MinNetSimulatorTimeout = value;
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06002D5C RID: 11612 RVA: 0x000418D4 File Offset: 0x0003FAD4
		// (set) Token: 0x06002D5D RID: 11613 RVA: 0x000418F0 File Offset: 0x0003FAF0
		public uint MaxNetSimulatorTimeout
		{
			get
			{
				return this.m_MaxNetSimulatorTimeout;
			}
			set
			{
				if (value == 0U)
				{
					throw new ArgumentOutOfRangeException("MaxNetSimulatorTimeout should be > 0");
				}
				if (value > 12000U)
				{
					throw new ArgumentOutOfRangeException("MaxNetSimulatorTimeout should be <=" + 12000U.ToString());
				}
				this.m_MaxNetSimulatorTimeout = value;
			}
		}

		// Token: 0x0400091F RID: 2335
		private const uint g_MaxTimerTimeout = 12000U;

		// Token: 0x04000920 RID: 2336
		private const uint g_MaxNetSimulatorTimeout = 12000U;

		// Token: 0x04000921 RID: 2337
		private const ushort g_MaxHosts = 128;

		// Token: 0x04000922 RID: 2338
		[SerializeField]
		private uint m_ThreadAwakeTimeout;

		// Token: 0x04000923 RID: 2339
		[SerializeField]
		private ReactorModel m_ReactorModel;

		// Token: 0x04000924 RID: 2340
		[SerializeField]
		private ushort m_ReactorMaximumReceivedMessages;

		// Token: 0x04000925 RID: 2341
		[SerializeField]
		private ushort m_ReactorMaximumSentMessages;

		// Token: 0x04000926 RID: 2342
		[SerializeField]
		private ushort m_MaxPacketSize;

		// Token: 0x04000927 RID: 2343
		[SerializeField]
		private ushort m_MaxHosts;

		// Token: 0x04000928 RID: 2344
		[SerializeField]
		private byte m_ThreadPoolSize;

		// Token: 0x04000929 RID: 2345
		[SerializeField]
		private uint m_MinTimerTimeout;

		// Token: 0x0400092A RID: 2346
		[SerializeField]
		private uint m_MaxTimerTimeout;

		// Token: 0x0400092B RID: 2347
		[SerializeField]
		private uint m_MinNetSimulatorTimeout;

		// Token: 0x0400092C RID: 2348
		[SerializeField]
		private uint m_MaxNetSimulatorTimeout;
	}
}
