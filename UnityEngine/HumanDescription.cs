using System;

namespace UnityEngine
{
	// Token: 0x02000206 RID: 518
	public struct HumanDescription
	{
		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06002347 RID: 9031 RVA: 0x00028A00 File Offset: 0x00026C00
		// (set) Token: 0x06002348 RID: 9032 RVA: 0x00028A1C File Offset: 0x00026C1C
		public float upperArmTwist
		{
			get
			{
				return this.m_ArmTwist;
			}
			set
			{
				this.m_ArmTwist = value;
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x00028A28 File Offset: 0x00026C28
		// (set) Token: 0x0600234A RID: 9034 RVA: 0x00028A44 File Offset: 0x00026C44
		public float lowerArmTwist
		{
			get
			{
				return this.m_ForeArmTwist;
			}
			set
			{
				this.m_ForeArmTwist = value;
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x0600234B RID: 9035 RVA: 0x00028A50 File Offset: 0x00026C50
		// (set) Token: 0x0600234C RID: 9036 RVA: 0x00028A6C File Offset: 0x00026C6C
		public float upperLegTwist
		{
			get
			{
				return this.m_UpperLegTwist;
			}
			set
			{
				this.m_UpperLegTwist = value;
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x0600234D RID: 9037 RVA: 0x00028A78 File Offset: 0x00026C78
		// (set) Token: 0x0600234E RID: 9038 RVA: 0x00028A94 File Offset: 0x00026C94
		public float lowerLegTwist
		{
			get
			{
				return this.m_LegTwist;
			}
			set
			{
				this.m_LegTwist = value;
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x0600234F RID: 9039 RVA: 0x00028AA0 File Offset: 0x00026CA0
		// (set) Token: 0x06002350 RID: 9040 RVA: 0x00028ABC File Offset: 0x00026CBC
		public float armStretch
		{
			get
			{
				return this.m_ArmStretch;
			}
			set
			{
				this.m_ArmStretch = value;
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06002351 RID: 9041 RVA: 0x00028AC8 File Offset: 0x00026CC8
		// (set) Token: 0x06002352 RID: 9042 RVA: 0x00028AE4 File Offset: 0x00026CE4
		public float legStretch
		{
			get
			{
				return this.m_LegStretch;
			}
			set
			{
				this.m_LegStretch = value;
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06002353 RID: 9043 RVA: 0x00028AF0 File Offset: 0x00026CF0
		// (set) Token: 0x06002354 RID: 9044 RVA: 0x00028B0C File Offset: 0x00026D0C
		public float feetSpacing
		{
			get
			{
				return this.m_FeetSpacing;
			}
			set
			{
				this.m_FeetSpacing = value;
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06002355 RID: 9045 RVA: 0x00028B18 File Offset: 0x00026D18
		// (set) Token: 0x06002356 RID: 9046 RVA: 0x00028B34 File Offset: 0x00026D34
		public bool hasTranslationDoF
		{
			get
			{
				return this.m_HasTranslationDoF;
			}
			set
			{
				this.m_HasTranslationDoF = value;
			}
		}

		// Token: 0x0400058F RID: 1423
		public HumanBone[] human;

		// Token: 0x04000590 RID: 1424
		public SkeletonBone[] skeleton;

		// Token: 0x04000591 RID: 1425
		internal float m_ArmTwist;

		// Token: 0x04000592 RID: 1426
		internal float m_ForeArmTwist;

		// Token: 0x04000593 RID: 1427
		internal float m_UpperLegTwist;

		// Token: 0x04000594 RID: 1428
		internal float m_LegTwist;

		// Token: 0x04000595 RID: 1429
		internal float m_ArmStretch;

		// Token: 0x04000596 RID: 1430
		internal float m_LegStretch;

		// Token: 0x04000597 RID: 1431
		internal float m_FeetSpacing;

		// Token: 0x04000598 RID: 1432
		internal bool m_HasTranslationDoF;
	}
}
