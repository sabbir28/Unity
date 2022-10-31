using System;

namespace UnityEngine
{
	// Token: 0x0200014F RID: 335
	public struct SoftJointLimitSpring
	{
		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x0001DE3C File Offset: 0x0001C03C
		// (set) Token: 0x060017C7 RID: 6087 RVA: 0x0001DE58 File Offset: 0x0001C058
		public float spring
		{
			get
			{
				return this.m_Spring;
			}
			set
			{
				this.m_Spring = value;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x060017C8 RID: 6088 RVA: 0x0001DE64 File Offset: 0x0001C064
		// (set) Token: 0x060017C9 RID: 6089 RVA: 0x0001DE80 File Offset: 0x0001C080
		public float damper
		{
			get
			{
				return this.m_Damper;
			}
			set
			{
				this.m_Damper = value;
			}
		}

		// Token: 0x040003A1 RID: 929
		private float m_Spring;

		// Token: 0x040003A2 RID: 930
		private float m_Damper;
	}
}
