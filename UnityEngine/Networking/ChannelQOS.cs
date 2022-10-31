using System;

namespace UnityEngine.Networking
{
	// Token: 0x020002B4 RID: 692
	[Serializable]
	public class ChannelQOS
	{
		// Token: 0x06002CF8 RID: 11512 RVA: 0x000409B0 File Offset: 0x0003EBB0
		public ChannelQOS(QosType value)
		{
			this.m_Type = value;
		}

		// Token: 0x06002CF9 RID: 11513 RVA: 0x000409C0 File Offset: 0x0003EBC0
		public ChannelQOS()
		{
			this.m_Type = QosType.Unreliable;
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x000409D0 File Offset: 0x0003EBD0
		public ChannelQOS(ChannelQOS channel)
		{
			if (channel == null)
			{
				throw new NullReferenceException("channel is not defined");
			}
			this.m_Type = channel.m_Type;
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06002CFB RID: 11515 RVA: 0x000409F8 File Offset: 0x0003EBF8
		public QosType QOS
		{
			get
			{
				return this.m_Type;
			}
		}

		// Token: 0x040008FC RID: 2300
		[SerializeField]
		internal QosType m_Type;
	}
}
