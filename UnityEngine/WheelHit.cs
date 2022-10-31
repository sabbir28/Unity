using System;

namespace UnityEngine
{
	// Token: 0x020001A2 RID: 418
	public struct WheelHit
	{
		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06001E14 RID: 7700 RVA: 0x00024A98 File Offset: 0x00022C98
		// (set) Token: 0x06001E15 RID: 7701 RVA: 0x00024AB4 File Offset: 0x00022CB4
		public Collider collider
		{
			get
			{
				return this.m_Collider;
			}
			set
			{
				this.m_Collider = value;
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06001E16 RID: 7702 RVA: 0x00024AC0 File Offset: 0x00022CC0
		// (set) Token: 0x06001E17 RID: 7703 RVA: 0x00024ADC File Offset: 0x00022CDC
		public Vector3 point
		{
			get
			{
				return this.m_Point;
			}
			set
			{
				this.m_Point = value;
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06001E18 RID: 7704 RVA: 0x00024AE8 File Offset: 0x00022CE8
		// (set) Token: 0x06001E19 RID: 7705 RVA: 0x00024B04 File Offset: 0x00022D04
		public Vector3 normal
		{
			get
			{
				return this.m_Normal;
			}
			set
			{
				this.m_Normal = value;
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06001E1A RID: 7706 RVA: 0x00024B10 File Offset: 0x00022D10
		// (set) Token: 0x06001E1B RID: 7707 RVA: 0x00024B2C File Offset: 0x00022D2C
		public Vector3 forwardDir
		{
			get
			{
				return this.m_ForwardDir;
			}
			set
			{
				this.m_ForwardDir = value;
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06001E1C RID: 7708 RVA: 0x00024B38 File Offset: 0x00022D38
		// (set) Token: 0x06001E1D RID: 7709 RVA: 0x00024B54 File Offset: 0x00022D54
		public Vector3 sidewaysDir
		{
			get
			{
				return this.m_SidewaysDir;
			}
			set
			{
				this.m_SidewaysDir = value;
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06001E1E RID: 7710 RVA: 0x00024B60 File Offset: 0x00022D60
		// (set) Token: 0x06001E1F RID: 7711 RVA: 0x00024B7C File Offset: 0x00022D7C
		public float force
		{
			get
			{
				return this.m_Force;
			}
			set
			{
				this.m_Force = value;
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06001E20 RID: 7712 RVA: 0x00024B88 File Offset: 0x00022D88
		// (set) Token: 0x06001E21 RID: 7713 RVA: 0x00024BA4 File Offset: 0x00022DA4
		public float forwardSlip
		{
			get
			{
				return this.m_ForwardSlip;
			}
			set
			{
				this.m_Force = this.m_ForwardSlip;
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06001E22 RID: 7714 RVA: 0x00024BB4 File Offset: 0x00022DB4
		// (set) Token: 0x06001E23 RID: 7715 RVA: 0x00024BD0 File Offset: 0x00022DD0
		public float sidewaysSlip
		{
			get
			{
				return this.m_SidewaysSlip;
			}
			set
			{
				this.m_SidewaysSlip = value;
			}
		}

		// Token: 0x0400045C RID: 1116
		private Vector3 m_Point;

		// Token: 0x0400045D RID: 1117
		private Vector3 m_Normal;

		// Token: 0x0400045E RID: 1118
		private Vector3 m_ForwardDir;

		// Token: 0x0400045F RID: 1119
		private Vector3 m_SidewaysDir;

		// Token: 0x04000460 RID: 1120
		private float m_Force;

		// Token: 0x04000461 RID: 1121
		private float m_ForwardSlip;

		// Token: 0x04000462 RID: 1122
		private float m_SidewaysSlip;

		// Token: 0x04000463 RID: 1123
		private Collider m_Collider;
	}
}
