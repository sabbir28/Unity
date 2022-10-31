using System;

namespace UnityEngine.AI
{
	// Token: 0x020001AD RID: 429
	public struct NavMeshLinkData
	{
		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06001EE9 RID: 7913 RVA: 0x00025430 File Offset: 0x00023630
		// (set) Token: 0x06001EEA RID: 7914 RVA: 0x0002544C File Offset: 0x0002364C
		public Vector3 startPosition
		{
			get
			{
				return this.m_StartPosition;
			}
			set
			{
				this.m_StartPosition = value;
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06001EEB RID: 7915 RVA: 0x00025458 File Offset: 0x00023658
		// (set) Token: 0x06001EEC RID: 7916 RVA: 0x00025474 File Offset: 0x00023674
		public Vector3 endPosition
		{
			get
			{
				return this.m_EndPosition;
			}
			set
			{
				this.m_EndPosition = value;
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06001EED RID: 7917 RVA: 0x00025480 File Offset: 0x00023680
		// (set) Token: 0x06001EEE RID: 7918 RVA: 0x0002549C File Offset: 0x0002369C
		public float costModifier
		{
			get
			{
				return this.m_CostModifier;
			}
			set
			{
				this.m_CostModifier = value;
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06001EEF RID: 7919 RVA: 0x000254A8 File Offset: 0x000236A8
		// (set) Token: 0x06001EF0 RID: 7920 RVA: 0x000254CC File Offset: 0x000236CC
		public bool bidirectional
		{
			get
			{
				return this.m_Bidirectional != 0;
			}
			set
			{
				this.m_Bidirectional = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06001EF1 RID: 7921 RVA: 0x000254E4 File Offset: 0x000236E4
		// (set) Token: 0x06001EF2 RID: 7922 RVA: 0x00025500 File Offset: 0x00023700
		public float width
		{
			get
			{
				return this.m_Width;
			}
			set
			{
				this.m_Width = value;
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x0002550C File Offset: 0x0002370C
		// (set) Token: 0x06001EF4 RID: 7924 RVA: 0x00025528 File Offset: 0x00023728
		public int area
		{
			get
			{
				return this.m_Area;
			}
			set
			{
				this.m_Area = value;
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x00025534 File Offset: 0x00023734
		// (set) Token: 0x06001EF6 RID: 7926 RVA: 0x00025550 File Offset: 0x00023750
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

		// Token: 0x04000473 RID: 1139
		private Vector3 m_StartPosition;

		// Token: 0x04000474 RID: 1140
		private Vector3 m_EndPosition;

		// Token: 0x04000475 RID: 1141
		private float m_CostModifier;

		// Token: 0x04000476 RID: 1142
		private int m_Bidirectional;

		// Token: 0x04000477 RID: 1143
		private float m_Width;

		// Token: 0x04000478 RID: 1144
		private int m_Area;

		// Token: 0x04000479 RID: 1145
		private int m_AgentTypeID;
	}
}
