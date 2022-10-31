using System;

namespace UnityEngine.AI
{
	// Token: 0x020001AF RID: 431
	public struct NavMeshQueryFilter
	{
		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06001EFD RID: 7933 RVA: 0x00025628 File Offset: 0x00023828
		internal float[] costs
		{
			get
			{
				return this.m_AreaCost;
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06001EFE RID: 7934 RVA: 0x00025644 File Offset: 0x00023844
		// (set) Token: 0x06001EFF RID: 7935 RVA: 0x00025660 File Offset: 0x00023860
		public int areaMask
		{
			get
			{
				return this.m_AreaMask;
			}
			set
			{
				this.m_AreaMask = value;
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06001F00 RID: 7936 RVA: 0x0002566C File Offset: 0x0002386C
		// (set) Token: 0x06001F01 RID: 7937 RVA: 0x00025688 File Offset: 0x00023888
		public int agentTypeID
		{
			get
			{
				return this.m_AgentTypeID;
			}
			set
			{
				this.m_AgentTypeID = value;
			}
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x00025694 File Offset: 0x00023894
		public float GetAreaCost(int areaIndex)
		{
			float result;
			if (this.m_AreaCost == null)
			{
				if (areaIndex < 0 || areaIndex >= 32)
				{
					string message = string.Format("The valid range is [0:{0}]", 31);
					throw new IndexOutOfRangeException(message);
				}
				result = 1f;
			}
			else
			{
				result = this.m_AreaCost[areaIndex];
			}
			return result;
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x000256F4 File Offset: 0x000238F4
		public void SetAreaCost(int areaIndex, float cost)
		{
			if (this.m_AreaCost == null)
			{
				this.m_AreaCost = new float[32];
				for (int i = 0; i < 32; i++)
				{
					this.m_AreaCost[i] = 1f;
				}
			}
			this.m_AreaCost[areaIndex] = cost;
		}

		// Token: 0x0400047B RID: 1147
		private const int AREA_COST_ELEMENT_COUNT = 32;

		// Token: 0x0400047C RID: 1148
		private int m_AreaMask;

		// Token: 0x0400047D RID: 1149
		private int m_AgentTypeID;

		// Token: 0x0400047E RID: 1150
		private float[] m_AreaCost;
	}
}
