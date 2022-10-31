using System;

namespace UnityEngine
{
	// Token: 0x02000152 RID: 338
	public struct JointMotor
	{
		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x060017D2 RID: 6098 RVA: 0x0001DF20 File Offset: 0x0001C120
		// (set) Token: 0x060017D3 RID: 6099 RVA: 0x0001DF3C File Offset: 0x0001C13C
		public float targetVelocity
		{
			get
			{
				return this.m_TargetVelocity;
			}
			set
			{
				this.m_TargetVelocity = value;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x060017D4 RID: 6100 RVA: 0x0001DF48 File Offset: 0x0001C148
		// (set) Token: 0x060017D5 RID: 6101 RVA: 0x0001DF64 File Offset: 0x0001C164
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

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x0001DF70 File Offset: 0x0001C170
		// (set) Token: 0x060017D7 RID: 6103 RVA: 0x0001DF90 File Offset: 0x0001C190
		public bool freeSpin
		{
			get
			{
				return this.m_FreeSpin == 1;
			}
			set
			{
				this.m_FreeSpin = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x040003AA RID: 938
		private float m_TargetVelocity;

		// Token: 0x040003AB RID: 939
		private float m_Force;

		// Token: 0x040003AC RID: 940
		private int m_FreeSpin;
	}
}
