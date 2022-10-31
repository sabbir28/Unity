using System;

namespace UnityEngine
{
	// Token: 0x0200014D RID: 333
	public struct WheelFrictionCurve
	{
		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060017B0 RID: 6064 RVA: 0x0001DC94 File Offset: 0x0001BE94
		// (set) Token: 0x060017B1 RID: 6065 RVA: 0x0001DCB0 File Offset: 0x0001BEB0
		public float extremumSlip
		{
			get
			{
				return this.m_ExtremumSlip;
			}
			set
			{
				this.m_ExtremumSlip = value;
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x0001DCBC File Offset: 0x0001BEBC
		// (set) Token: 0x060017B3 RID: 6067 RVA: 0x0001DCD8 File Offset: 0x0001BED8
		public float extremumValue
		{
			get
			{
				return this.m_ExtremumValue;
			}
			set
			{
				this.m_ExtremumValue = value;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x0001DCE4 File Offset: 0x0001BEE4
		// (set) Token: 0x060017B5 RID: 6069 RVA: 0x0001DD00 File Offset: 0x0001BF00
		public float asymptoteSlip
		{
			get
			{
				return this.m_AsymptoteSlip;
			}
			set
			{
				this.m_AsymptoteSlip = value;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060017B6 RID: 6070 RVA: 0x0001DD0C File Offset: 0x0001BF0C
		// (set) Token: 0x060017B7 RID: 6071 RVA: 0x0001DD28 File Offset: 0x0001BF28
		public float asymptoteValue
		{
			get
			{
				return this.m_AsymptoteValue;
			}
			set
			{
				this.m_AsymptoteValue = value;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x060017B8 RID: 6072 RVA: 0x0001DD34 File Offset: 0x0001BF34
		// (set) Token: 0x060017B9 RID: 6073 RVA: 0x0001DD50 File Offset: 0x0001BF50
		public float stiffness
		{
			get
			{
				return this.m_Stiffness;
			}
			set
			{
				this.m_Stiffness = value;
			}
		}

		// Token: 0x04000399 RID: 921
		private float m_ExtremumSlip;

		// Token: 0x0400039A RID: 922
		private float m_ExtremumValue;

		// Token: 0x0400039B RID: 923
		private float m_AsymptoteSlip;

		// Token: 0x0400039C RID: 924
		private float m_AsymptoteValue;

		// Token: 0x0400039D RID: 925
		private float m_Stiffness;
	}
}
