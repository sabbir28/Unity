using System;

namespace UnityEngine
{
	// Token: 0x02000204 RID: 516
	public struct HumanLimit
	{
		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06002339 RID: 9017 RVA: 0x000288D4 File Offset: 0x00026AD4
		// (set) Token: 0x0600233A RID: 9018 RVA: 0x000288F8 File Offset: 0x00026AF8
		public bool useDefaultValues
		{
			get
			{
				return this.m_UseDefaultValues != 0;
			}
			set
			{
				this.m_UseDefaultValues = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x0600233B RID: 9019 RVA: 0x00028910 File Offset: 0x00026B10
		// (set) Token: 0x0600233C RID: 9020 RVA: 0x0002892C File Offset: 0x00026B2C
		public Vector3 min
		{
			get
			{
				return this.m_Min;
			}
			set
			{
				this.m_Min = value;
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x0600233D RID: 9021 RVA: 0x00028938 File Offset: 0x00026B38
		// (set) Token: 0x0600233E RID: 9022 RVA: 0x00028954 File Offset: 0x00026B54
		public Vector3 max
		{
			get
			{
				return this.m_Max;
			}
			set
			{
				this.m_Max = value;
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x0600233F RID: 9023 RVA: 0x00028960 File Offset: 0x00026B60
		// (set) Token: 0x06002340 RID: 9024 RVA: 0x0002897C File Offset: 0x00026B7C
		public Vector3 center
		{
			get
			{
				return this.m_Center;
			}
			set
			{
				this.m_Center = value;
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06002341 RID: 9025 RVA: 0x00028988 File Offset: 0x00026B88
		// (set) Token: 0x06002342 RID: 9026 RVA: 0x000289A4 File Offset: 0x00026BA4
		public float axisLength
		{
			get
			{
				return this.m_AxisLength;
			}
			set
			{
				this.m_AxisLength = value;
			}
		}

		// Token: 0x04000587 RID: 1415
		private Vector3 m_Min;

		// Token: 0x04000588 RID: 1416
		private Vector3 m_Max;

		// Token: 0x04000589 RID: 1417
		private Vector3 m_Center;

		// Token: 0x0400058A RID: 1418
		private float m_AxisLength;

		// Token: 0x0400058B RID: 1419
		private int m_UseDefaultValues;
	}
}
