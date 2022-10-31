using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001FD RID: 509
	[RequiredByNativeCode]
	public struct AnimatorStateInfo
	{
		// Token: 0x06002212 RID: 8722 RVA: 0x0002782C File Offset: 0x00025A2C
		public bool IsName(string name)
		{
			int num = Animator.StringToHash(name);
			return num == this.m_FullPath || num == this.m_Name || num == this.m_Path;
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06002213 RID: 8723 RVA: 0x0002786C File Offset: 0x00025A6C
		public int fullPathHash
		{
			get
			{
				return this.m_FullPath;
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06002214 RID: 8724 RVA: 0x00027888 File Offset: 0x00025A88
		[Obsolete("Use AnimatorStateInfo.fullPathHash instead.")]
		public int nameHash
		{
			get
			{
				return this.m_Path;
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06002215 RID: 8725 RVA: 0x000278A4 File Offset: 0x00025AA4
		public int shortNameHash
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x000278C0 File Offset: 0x00025AC0
		public float normalizedTime
		{
			get
			{
				return this.m_NormalizedTime;
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06002217 RID: 8727 RVA: 0x000278DC File Offset: 0x00025ADC
		public float length
		{
			get
			{
				return this.m_Length;
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06002218 RID: 8728 RVA: 0x000278F8 File Offset: 0x00025AF8
		public float speed
		{
			get
			{
				return this.m_Speed;
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06002219 RID: 8729 RVA: 0x00027914 File Offset: 0x00025B14
		public float speedMultiplier
		{
			get
			{
				return this.m_SpeedMultiplier;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x0600221A RID: 8730 RVA: 0x00027930 File Offset: 0x00025B30
		public int tagHash
		{
			get
			{
				return this.m_Tag;
			}
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x0002794C File Offset: 0x00025B4C
		public bool IsTag(string tag)
		{
			return Animator.StringToHash(tag) == this.m_Tag;
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x0600221C RID: 8732 RVA: 0x00027970 File Offset: 0x00025B70
		public bool loop
		{
			get
			{
				return this.m_Loop != 0;
			}
		}

		// Token: 0x0400056C RID: 1388
		private int m_Name;

		// Token: 0x0400056D RID: 1389
		private int m_Path;

		// Token: 0x0400056E RID: 1390
		private int m_FullPath;

		// Token: 0x0400056F RID: 1391
		private float m_NormalizedTime;

		// Token: 0x04000570 RID: 1392
		private float m_Length;

		// Token: 0x04000571 RID: 1393
		private float m_Speed;

		// Token: 0x04000572 RID: 1394
		private float m_SpeedMultiplier;

		// Token: 0x04000573 RID: 1395
		private int m_Tag;

		// Token: 0x04000574 RID: 1396
		private int m_Loop;
	}
}
