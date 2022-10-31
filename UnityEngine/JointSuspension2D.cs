using System;

namespace UnityEngine
{
	// Token: 0x0200018B RID: 395
	public struct JointSuspension2D
	{
		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001D16 RID: 7446 RVA: 0x0002463C File Offset: 0x0002283C
		// (set) Token: 0x06001D17 RID: 7447 RVA: 0x00024658 File Offset: 0x00022858
		public float dampingRatio
		{
			get
			{
				return this.m_DampingRatio;
			}
			set
			{
				this.m_DampingRatio = value;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001D18 RID: 7448 RVA: 0x00024664 File Offset: 0x00022864
		// (set) Token: 0x06001D19 RID: 7449 RVA: 0x00024680 File Offset: 0x00022880
		public float frequency
		{
			get
			{
				return this.m_Frequency;
			}
			set
			{
				this.m_Frequency = value;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001D1A RID: 7450 RVA: 0x0002468C File Offset: 0x0002288C
		// (set) Token: 0x06001D1B RID: 7451 RVA: 0x000246A8 File Offset: 0x000228A8
		public float angle
		{
			get
			{
				return this.m_Angle;
			}
			set
			{
				this.m_Angle = value;
			}
		}

		// Token: 0x04000452 RID: 1106
		private float m_DampingRatio;

		// Token: 0x04000453 RID: 1107
		private float m_Frequency;

		// Token: 0x04000454 RID: 1108
		private float m_Angle;
	}
}
