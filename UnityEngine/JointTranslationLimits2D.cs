using System;

namespace UnityEngine
{
	// Token: 0x02000189 RID: 393
	public struct JointTranslationLimits2D
	{
		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001D0E RID: 7438 RVA: 0x0002459C File Offset: 0x0002279C
		// (set) Token: 0x06001D0F RID: 7439 RVA: 0x000245B8 File Offset: 0x000227B8
		public float min
		{
			get
			{
				return this.m_LowerTranslation;
			}
			set
			{
				this.m_LowerTranslation = value;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001D10 RID: 7440 RVA: 0x000245C4 File Offset: 0x000227C4
		// (set) Token: 0x06001D11 RID: 7441 RVA: 0x000245E0 File Offset: 0x000227E0
		public float max
		{
			get
			{
				return this.m_UpperTranslation;
			}
			set
			{
				this.m_UpperTranslation = value;
			}
		}

		// Token: 0x0400044E RID: 1102
		private float m_LowerTranslation;

		// Token: 0x0400044F RID: 1103
		private float m_UpperTranslation;
	}
}
