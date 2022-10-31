using System;

namespace UnityEngine
{
	// Token: 0x02000150 RID: 336
	public struct JointDrive
	{
		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x0001DE8C File Offset: 0x0001C08C
		// (set) Token: 0x060017CB RID: 6091 RVA: 0x0001DEA4 File Offset: 0x0001C0A4
		[Obsolete("JointDriveMode is obsolete")]
		public JointDriveMode mode
		{
			get
			{
				return JointDriveMode.None;
			}
			set
			{
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x0001DEA8 File Offset: 0x0001C0A8
		// (set) Token: 0x060017CD RID: 6093 RVA: 0x0001DEC4 File Offset: 0x0001C0C4
		public float positionSpring
		{
			get
			{
				return this.m_PositionSpring;
			}
			set
			{
				this.m_PositionSpring = value;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x0001DED0 File Offset: 0x0001C0D0
		// (set) Token: 0x060017CF RID: 6095 RVA: 0x0001DEEC File Offset: 0x0001C0EC
		public float positionDamper
		{
			get
			{
				return this.m_PositionDamper;
			}
			set
			{
				this.m_PositionDamper = value;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x060017D0 RID: 6096 RVA: 0x0001DEF8 File Offset: 0x0001C0F8
		// (set) Token: 0x060017D1 RID: 6097 RVA: 0x0001DF14 File Offset: 0x0001C114
		public float maximumForce
		{
			get
			{
				return this.m_MaximumForce;
			}
			set
			{
				this.m_MaximumForce = value;
			}
		}

		// Token: 0x040003A3 RID: 931
		private float m_PositionSpring;

		// Token: 0x040003A4 RID: 932
		private float m_PositionDamper;

		// Token: 0x040003A5 RID: 933
		private float m_MaximumForce;
	}
}
