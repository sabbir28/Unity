using System;

namespace UnityEngine
{
	// Token: 0x02000154 RID: 340
	public struct JointLimits
	{
		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x060017D8 RID: 6104 RVA: 0x0001DFA8 File Offset: 0x0001C1A8
		// (set) Token: 0x060017D9 RID: 6105 RVA: 0x0001DFC4 File Offset: 0x0001C1C4
		public float min
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

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x060017DA RID: 6106 RVA: 0x0001DFD0 File Offset: 0x0001C1D0
		// (set) Token: 0x060017DB RID: 6107 RVA: 0x0001DFEC File Offset: 0x0001C1EC
		public float max
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

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x060017DC RID: 6108 RVA: 0x0001DFF8 File Offset: 0x0001C1F8
		// (set) Token: 0x060017DD RID: 6109 RVA: 0x0001E014 File Offset: 0x0001C214
		public float bounciness
		{
			get
			{
				return this.m_Bounciness;
			}
			set
			{
				this.m_Bounciness = value;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x060017DE RID: 6110 RVA: 0x0001E020 File Offset: 0x0001C220
		// (set) Token: 0x060017DF RID: 6111 RVA: 0x0001E03C File Offset: 0x0001C23C
		public float bounceMinVelocity
		{
			get
			{
				return this.m_BounceMinVelocity;
			}
			set
			{
				this.m_BounceMinVelocity = value;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x060017E0 RID: 6112 RVA: 0x0001E048 File Offset: 0x0001C248
		// (set) Token: 0x060017E1 RID: 6113 RVA: 0x0001E064 File Offset: 0x0001C264
		public float contactDistance
		{
			get
			{
				return this.m_ContactDistance;
			}
			set
			{
				this.m_ContactDistance = value;
			}
		}

		// Token: 0x040003B0 RID: 944
		private float m_Min;

		// Token: 0x040003B1 RID: 945
		private float m_Max;

		// Token: 0x040003B2 RID: 946
		private float m_Bounciness;

		// Token: 0x040003B3 RID: 947
		private float m_BounceMinVelocity;

		// Token: 0x040003B4 RID: 948
		private float m_ContactDistance;

		// Token: 0x040003B5 RID: 949
		[Obsolete("minBounce and maxBounce are replaced by a single JointLimits.bounciness for both limit ends.", true)]
		public float minBounce;

		// Token: 0x040003B6 RID: 950
		[Obsolete("minBounce and maxBounce are replaced by a single JointLimits.bounciness for both limit ends.", true)]
		public float maxBounce;
	}
}
