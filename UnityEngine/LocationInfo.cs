using System;

namespace UnityEngine
{
	// Token: 0x0200006D RID: 109
	public struct LocationInfo
	{
		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x00009CF4 File Offset: 0x00007EF4
		public float latitude
		{
			get
			{
				return this.m_Latitude;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x00009D10 File Offset: 0x00007F10
		public float longitude
		{
			get
			{
				return this.m_Longitude;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x00009D2C File Offset: 0x00007F2C
		public float altitude
		{
			get
			{
				return this.m_Altitude;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x00009D48 File Offset: 0x00007F48
		public float horizontalAccuracy
		{
			get
			{
				return this.m_HorizontalAccuracy;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x00009D64 File Offset: 0x00007F64
		public float verticalAccuracy
		{
			get
			{
				return this.m_VerticalAccuracy;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00009D80 File Offset: 0x00007F80
		public double timestamp
		{
			get
			{
				return this.m_Timestamp;
			}
		}

		// Token: 0x040000AA RID: 170
		private double m_Timestamp;

		// Token: 0x040000AB RID: 171
		private float m_Latitude;

		// Token: 0x040000AC RID: 172
		private float m_Longitude;

		// Token: 0x040000AD RID: 173
		private float m_Altitude;

		// Token: 0x040000AE RID: 174
		private float m_HorizontalAccuracy;

		// Token: 0x040000AF RID: 175
		private float m_VerticalAccuracy;
	}
}
