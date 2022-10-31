using System;

namespace UnityEngine
{
	// Token: 0x02000188 RID: 392
	public struct JointAngleLimits2D
	{
		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001D0A RID: 7434 RVA: 0x0002454C File Offset: 0x0002274C
		// (set) Token: 0x06001D0B RID: 7435 RVA: 0x00024568 File Offset: 0x00022768
		public float min
		{
			get
			{
				return this.m_LowerAngle;
			}
			set
			{
				this.m_LowerAngle = value;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001D0C RID: 7436 RVA: 0x00024574 File Offset: 0x00022774
		// (set) Token: 0x06001D0D RID: 7437 RVA: 0x00024590 File Offset: 0x00022790
		public float max
		{
			get
			{
				return this.m_UpperAngle;
			}
			set
			{
				this.m_UpperAngle = value;
			}
		}

		// Token: 0x0400044C RID: 1100
		private float m_LowerAngle;

		// Token: 0x0400044D RID: 1101
		private float m_UpperAngle;
	}
}
