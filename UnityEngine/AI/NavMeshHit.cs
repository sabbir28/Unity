using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI
{
	// Token: 0x020001A9 RID: 425
	[MovedFrom("UnityEngine")]
	public struct NavMeshHit
	{
		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06001ECB RID: 7883 RVA: 0x000251D4 File Offset: 0x000233D4
		// (set) Token: 0x06001ECC RID: 7884 RVA: 0x000251F0 File Offset: 0x000233F0
		public Vector3 position
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

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06001ECD RID: 7885 RVA: 0x000251FC File Offset: 0x000233FC
		// (set) Token: 0x06001ECE RID: 7886 RVA: 0x00025218 File Offset: 0x00023418
		public Vector3 normal
		{
			get
			{
				return this.m_Normal;
			}
			set
			{
				this.m_Normal = value;
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06001ECF RID: 7887 RVA: 0x00025224 File Offset: 0x00023424
		// (set) Token: 0x06001ED0 RID: 7888 RVA: 0x00025240 File Offset: 0x00023440
		public float distance
		{
			get
			{
				return this.m_Distance;
			}
			set
			{
				this.m_Distance = value;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06001ED1 RID: 7889 RVA: 0x0002524C File Offset: 0x0002344C
		// (set) Token: 0x06001ED2 RID: 7890 RVA: 0x00025268 File Offset: 0x00023468
		public int mask
		{
			get
			{
				return this.m_Mask;
			}
			set
			{
				this.m_Mask = value;
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x00025274 File Offset: 0x00023474
		// (set) Token: 0x06001ED4 RID: 7892 RVA: 0x00025298 File Offset: 0x00023498
		public bool hit
		{
			get
			{
				return this.m_Hit != 0;
			}
			set
			{
				this.m_Hit = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x0400046A RID: 1130
		private Vector3 m_Position;

		// Token: 0x0400046B RID: 1131
		private Vector3 m_Normal;

		// Token: 0x0400046C RID: 1132
		private float m_Distance;

		// Token: 0x0400046D RID: 1133
		private int m_Mask;

		// Token: 0x0400046E RID: 1134
		private int m_Hit;
	}
}
