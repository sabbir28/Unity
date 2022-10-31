using System;

namespace UnityEngine
{
	// Token: 0x020001FF RID: 511
	public struct MatchTargetWeightMask
	{
		// Token: 0x06002226 RID: 8742 RVA: 0x00027AC4 File Offset: 0x00025CC4
		public MatchTargetWeightMask(Vector3 positionXYZWeight, float rotationWeight)
		{
			this.m_PositionXYZWeight = positionXYZWeight;
			this.m_RotationWeight = rotationWeight;
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06002227 RID: 8743 RVA: 0x00027AD8 File Offset: 0x00025CD8
		// (set) Token: 0x06002228 RID: 8744 RVA: 0x00027AF4 File Offset: 0x00025CF4
		public Vector3 positionXYZWeight
		{
			get
			{
				return this.m_PositionXYZWeight;
			}
			set
			{
				this.m_PositionXYZWeight = value;
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06002229 RID: 8745 RVA: 0x00027B00 File Offset: 0x00025D00
		// (set) Token: 0x0600222A RID: 8746 RVA: 0x00027B1C File Offset: 0x00025D1C
		public float rotationWeight
		{
			get
			{
				return this.m_RotationWeight;
			}
			set
			{
				this.m_RotationWeight = value;
			}
		}

		// Token: 0x0400057B RID: 1403
		private Vector3 m_PositionXYZWeight;

		// Token: 0x0400057C RID: 1404
		private float m_RotationWeight;
	}
}
