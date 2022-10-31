using System;
using System.Collections.Generic;

namespace UnityEngine.Networking
{
	// Token: 0x020002B6 RID: 694
	[Serializable]
	public class HostTopology
	{
		// Token: 0x06002D39 RID: 11577 RVA: 0x00041340 File Offset: 0x0003F540
		public HostTopology(ConnectionConfig defaultConfig, int maxDefaultConnections)
		{
			if (defaultConfig == null)
			{
				throw new NullReferenceException("config is not defined");
			}
			if (maxDefaultConnections <= 0)
			{
				throw new ArgumentOutOfRangeException("maxDefaultConnections", "Number of connections should be > 0");
			}
			if (maxDefaultConnections >= 65535)
			{
				throw new ArgumentOutOfRangeException("maxDefaultConnections", "Number of connections should be < 65535");
			}
			ConnectionConfig.Validate(defaultConfig);
			this.m_DefConfig = new ConnectionConfig(defaultConfig);
			this.m_MaxDefConnections = maxDefaultConnections;
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x000413EC File Offset: 0x0003F5EC
		private HostTopology()
		{
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06002D3B RID: 11579 RVA: 0x0004143C File Offset: 0x0003F63C
		public ConnectionConfig DefaultConfig
		{
			get
			{
				return this.m_DefConfig;
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06002D3C RID: 11580 RVA: 0x00041458 File Offset: 0x0003F658
		public int MaxDefaultConnections
		{
			get
			{
				return this.m_MaxDefConnections;
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06002D3D RID: 11581 RVA: 0x00041474 File Offset: 0x0003F674
		public int SpecialConnectionConfigsCount
		{
			get
			{
				return this.m_SpecialConnections.Count;
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06002D3E RID: 11582 RVA: 0x00041494 File Offset: 0x0003F694
		public List<ConnectionConfig> SpecialConnectionConfigs
		{
			get
			{
				return this.m_SpecialConnections;
			}
		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x000414B0 File Offset: 0x0003F6B0
		public ConnectionConfig GetSpecialConnectionConfig(int i)
		{
			if (i > this.m_SpecialConnections.Count || i == 0)
			{
				throw new ArgumentException("special configuration index is out of valid range");
			}
			return this.m_SpecialConnections[i - 1];
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06002D40 RID: 11584 RVA: 0x000414F8 File Offset: 0x0003F6F8
		// (set) Token: 0x06002D41 RID: 11585 RVA: 0x00041514 File Offset: 0x0003F714
		public ushort ReceivedMessagePoolSize
		{
			get
			{
				return this.m_ReceivedMessagePoolSize;
			}
			set
			{
				this.m_ReceivedMessagePoolSize = value;
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06002D42 RID: 11586 RVA: 0x00041520 File Offset: 0x0003F720
		// (set) Token: 0x06002D43 RID: 11587 RVA: 0x0004153C File Offset: 0x0003F73C
		public ushort SentMessagePoolSize
		{
			get
			{
				return this.m_SentMessagePoolSize;
			}
			set
			{
				this.m_SentMessagePoolSize = value;
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06002D44 RID: 11588 RVA: 0x00041548 File Offset: 0x0003F748
		// (set) Token: 0x06002D45 RID: 11589 RVA: 0x00041564 File Offset: 0x0003F764
		public float MessagePoolSizeGrowthFactor
		{
			get
			{
				return this.m_MessagePoolSizeGrowthFactor;
			}
			set
			{
				if ((double)value <= 0.5 || (double)value > 1.0)
				{
					throw new ArgumentException("pool growth factor should be varied between 0.5 and 1.0");
				}
				this.m_MessagePoolSizeGrowthFactor = value;
			}
		}

		// Token: 0x06002D46 RID: 11590 RVA: 0x0004159C File Offset: 0x0003F79C
		public int AddSpecialConnectionConfig(ConnectionConfig config)
		{
			this.m_SpecialConnections.Add(new ConnectionConfig(config));
			return this.m_SpecialConnections.Count;
		}

		// Token: 0x04000919 RID: 2329
		[SerializeField]
		private ConnectionConfig m_DefConfig = null;

		// Token: 0x0400091A RID: 2330
		[SerializeField]
		private int m_MaxDefConnections = 0;

		// Token: 0x0400091B RID: 2331
		[SerializeField]
		private List<ConnectionConfig> m_SpecialConnections = new List<ConnectionConfig>();

		// Token: 0x0400091C RID: 2332
		[SerializeField]
		private ushort m_ReceivedMessagePoolSize = 1024;

		// Token: 0x0400091D RID: 2333
		[SerializeField]
		private ushort m_SentMessagePoolSize = 1024;

		// Token: 0x0400091E RID: 2334
		[SerializeField]
		private float m_MessagePoolSizeGrowthFactor = 0.75f;
	}
}
