using System;

namespace UnityEngine
{
	// Token: 0x0200018A RID: 394
	public struct JointMotor2D
	{
		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001D12 RID: 7442 RVA: 0x000245EC File Offset: 0x000227EC
		// (set) Token: 0x06001D13 RID: 7443 RVA: 0x00024608 File Offset: 0x00022808
		public float motorSpeed
		{
			get
			{
				return this.m_MotorSpeed;
			}
			set
			{
				this.m_MotorSpeed = value;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001D14 RID: 7444 RVA: 0x00024614 File Offset: 0x00022814
		// (set) Token: 0x06001D15 RID: 7445 RVA: 0x00024630 File Offset: 0x00022830
		public float maxMotorTorque
		{
			get
			{
				return this.m_MaximumMotorTorque;
			}
			set
			{
				this.m_MaximumMotorTorque = value;
			}
		}

		// Token: 0x04000450 RID: 1104
		private float m_MotorSpeed;

		// Token: 0x04000451 RID: 1105
		private float m_MaximumMotorTorque;
	}
}
