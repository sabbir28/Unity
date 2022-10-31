using System;

namespace UnityEngine
{
	// Token: 0x02000069 RID: 105
	public struct Touch
	{
		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x000098CC File Offset: 0x00007ACC
		// (set) Token: 0x06000788 RID: 1928 RVA: 0x000098E8 File Offset: 0x00007AE8
		public int fingerId
		{
			get
			{
				return this.m_FingerId;
			}
			set
			{
				this.m_FingerId = value;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x000098F4 File Offset: 0x00007AF4
		// (set) Token: 0x0600078A RID: 1930 RVA: 0x00009910 File Offset: 0x00007B10
		public Vector2 position
		{
			get
			{
				return this.m_Position;
			}
			set
			{
				this.m_Position = value;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x0000991C File Offset: 0x00007B1C
		// (set) Token: 0x0600078C RID: 1932 RVA: 0x00009938 File Offset: 0x00007B38
		public Vector2 rawPosition
		{
			get
			{
				return this.m_RawPosition;
			}
			set
			{
				this.m_RawPosition = value;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x00009944 File Offset: 0x00007B44
		// (set) Token: 0x0600078E RID: 1934 RVA: 0x00009960 File Offset: 0x00007B60
		public Vector2 deltaPosition
		{
			get
			{
				return this.m_PositionDelta;
			}
			set
			{
				this.m_PositionDelta = value;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x0000996C File Offset: 0x00007B6C
		// (set) Token: 0x06000790 RID: 1936 RVA: 0x00009988 File Offset: 0x00007B88
		public float deltaTime
		{
			get
			{
				return this.m_TimeDelta;
			}
			set
			{
				this.m_TimeDelta = value;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x00009994 File Offset: 0x00007B94
		// (set) Token: 0x06000792 RID: 1938 RVA: 0x000099B0 File Offset: 0x00007BB0
		public int tapCount
		{
			get
			{
				return this.m_TapCount;
			}
			set
			{
				this.m_TapCount = value;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x000099BC File Offset: 0x00007BBC
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x000099D8 File Offset: 0x00007BD8
		public TouchPhase phase
		{
			get
			{
				return this.m_Phase;
			}
			set
			{
				this.m_Phase = value;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x000099E4 File Offset: 0x00007BE4
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x00009A00 File Offset: 0x00007C00
		public float pressure
		{
			get
			{
				return this.m_Pressure;
			}
			set
			{
				this.m_Pressure = value;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x00009A0C File Offset: 0x00007C0C
		// (set) Token: 0x06000798 RID: 1944 RVA: 0x00009A28 File Offset: 0x00007C28
		public float maximumPossiblePressure
		{
			get
			{
				return this.m_maximumPossiblePressure;
			}
			set
			{
				this.m_maximumPossiblePressure = value;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x00009A34 File Offset: 0x00007C34
		// (set) Token: 0x0600079A RID: 1946 RVA: 0x00009A50 File Offset: 0x00007C50
		public TouchType type
		{
			get
			{
				return this.m_Type;
			}
			set
			{
				this.m_Type = value;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x00009A5C File Offset: 0x00007C5C
		// (set) Token: 0x0600079C RID: 1948 RVA: 0x00009A78 File Offset: 0x00007C78
		public float altitudeAngle
		{
			get
			{
				return this.m_AltitudeAngle;
			}
			set
			{
				this.m_AltitudeAngle = value;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x00009A84 File Offset: 0x00007C84
		// (set) Token: 0x0600079E RID: 1950 RVA: 0x00009AA0 File Offset: 0x00007CA0
		public float azimuthAngle
		{
			get
			{
				return this.m_AzimuthAngle;
			}
			set
			{
				this.m_AzimuthAngle = value;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x00009AAC File Offset: 0x00007CAC
		// (set) Token: 0x060007A0 RID: 1952 RVA: 0x00009AC8 File Offset: 0x00007CC8
		public float radius
		{
			get
			{
				return this.m_Radius;
			}
			set
			{
				this.m_Radius = value;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x00009AD4 File Offset: 0x00007CD4
		// (set) Token: 0x060007A2 RID: 1954 RVA: 0x00009AF0 File Offset: 0x00007CF0
		public float radiusVariance
		{
			get
			{
				return this.m_RadiusVariance;
			}
			set
			{
				this.m_RadiusVariance = value;
			}
		}

		// Token: 0x0400008F RID: 143
		private int m_FingerId;

		// Token: 0x04000090 RID: 144
		private Vector2 m_Position;

		// Token: 0x04000091 RID: 145
		private Vector2 m_RawPosition;

		// Token: 0x04000092 RID: 146
		private Vector2 m_PositionDelta;

		// Token: 0x04000093 RID: 147
		private float m_TimeDelta;

		// Token: 0x04000094 RID: 148
		private int m_TapCount;

		// Token: 0x04000095 RID: 149
		private TouchPhase m_Phase;

		// Token: 0x04000096 RID: 150
		private TouchType m_Type;

		// Token: 0x04000097 RID: 151
		private float m_Pressure;

		// Token: 0x04000098 RID: 152
		private float m_maximumPossiblePressure;

		// Token: 0x04000099 RID: 153
		private float m_Radius;

		// Token: 0x0400009A RID: 154
		private float m_RadiusVariance;

		// Token: 0x0400009B RID: 155
		private float m_AltitudeAngle;

		// Token: 0x0400009C RID: 156
		private float m_AzimuthAngle;
	}
}
