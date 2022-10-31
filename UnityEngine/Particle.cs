using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020002F8 RID: 760
	[UsedByNativeCode]
	[Obsolete("This is part of the legacy particle system, which is deprecated and will be removed in a future release. Use the ParticleSystem component instead.", false)]
	public struct Particle
	{
		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06002F6B RID: 12139 RVA: 0x000458FC File Offset: 0x00043AFC
		// (set) Token: 0x06002F6C RID: 12140 RVA: 0x00045918 File Offset: 0x00043B18
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

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06002F6D RID: 12141 RVA: 0x00045924 File Offset: 0x00043B24
		// (set) Token: 0x06002F6E RID: 12142 RVA: 0x00045940 File Offset: 0x00043B40
		public Vector3 velocity
		{
			get
			{
				return this.m_Velocity;
			}
			set
			{
				this.m_Velocity = value;
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06002F6F RID: 12143 RVA: 0x0004594C File Offset: 0x00043B4C
		// (set) Token: 0x06002F70 RID: 12144 RVA: 0x00045968 File Offset: 0x00043B68
		public float energy
		{
			get
			{
				return this.m_Energy;
			}
			set
			{
				this.m_Energy = value;
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06002F71 RID: 12145 RVA: 0x00045974 File Offset: 0x00043B74
		// (set) Token: 0x06002F72 RID: 12146 RVA: 0x00045990 File Offset: 0x00043B90
		public float startEnergy
		{
			get
			{
				return this.m_StartEnergy;
			}
			set
			{
				this.m_StartEnergy = value;
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06002F73 RID: 12147 RVA: 0x0004599C File Offset: 0x00043B9C
		// (set) Token: 0x06002F74 RID: 12148 RVA: 0x000459B8 File Offset: 0x00043BB8
		public float size
		{
			get
			{
				return this.m_Size;
			}
			set
			{
				this.m_Size = value;
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06002F75 RID: 12149 RVA: 0x000459C4 File Offset: 0x00043BC4
		// (set) Token: 0x06002F76 RID: 12150 RVA: 0x000459E0 File Offset: 0x00043BE0
		public float rotation
		{
			get
			{
				return this.m_Rotation;
			}
			set
			{
				this.m_Rotation = value;
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06002F77 RID: 12151 RVA: 0x000459EC File Offset: 0x00043BEC
		// (set) Token: 0x06002F78 RID: 12152 RVA: 0x00045A08 File Offset: 0x00043C08
		public float angularVelocity
		{
			get
			{
				return this.m_AngularVelocity;
			}
			set
			{
				this.m_AngularVelocity = value;
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06002F79 RID: 12153 RVA: 0x00045A14 File Offset: 0x00043C14
		// (set) Token: 0x06002F7A RID: 12154 RVA: 0x00045A30 File Offset: 0x00043C30
		public Color color
		{
			get
			{
				return this.m_Color;
			}
			set
			{
				this.m_Color = value;
			}
		}

		// Token: 0x040009C9 RID: 2505
		private Vector3 m_Position;

		// Token: 0x040009CA RID: 2506
		private Vector3 m_Velocity;

		// Token: 0x040009CB RID: 2507
		private float m_Size;

		// Token: 0x040009CC RID: 2508
		private float m_Rotation;

		// Token: 0x040009CD RID: 2509
		private float m_AngularVelocity;

		// Token: 0x040009CE RID: 2510
		private float m_Energy;

		// Token: 0x040009CF RID: 2511
		private float m_StartEnergy;

		// Token: 0x040009D0 RID: 2512
		private Color m_Color;
	}
}
