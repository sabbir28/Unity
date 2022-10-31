using System;

namespace UnityEngine
{
	// Token: 0x0200014E RID: 334
	public struct SoftJointLimit
	{
		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060017BA RID: 6074 RVA: 0x0001DD5C File Offset: 0x0001BF5C
		// (set) Token: 0x060017BB RID: 6075 RVA: 0x0001DD78 File Offset: 0x0001BF78
		public float limit
		{
			get
			{
				return this.m_Limit;
			}
			set
			{
				this.m_Limit = value;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060017BC RID: 6076 RVA: 0x0001DD84 File Offset: 0x0001BF84
		// (set) Token: 0x060017BD RID: 6077 RVA: 0x0001DDA0 File Offset: 0x0001BFA0
		[Obsolete("Spring has been moved to SoftJointLimitSpring class in Unity 5", true)]
		public float spring
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x060017BE RID: 6078 RVA: 0x0001DDA4 File Offset: 0x0001BFA4
		// (set) Token: 0x060017BF RID: 6079 RVA: 0x0001DDC0 File Offset: 0x0001BFC0
		[Obsolete("Damper has been moved to SoftJointLimitSpring class in Unity 5", true)]
		public float damper
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x060017C0 RID: 6080 RVA: 0x0001DDC4 File Offset: 0x0001BFC4
		// (set) Token: 0x060017C1 RID: 6081 RVA: 0x0001DDE0 File Offset: 0x0001BFE0
		public float bounciness
		{
			get
			{
				return this.m_Bounciness;
			}
			set
			{
				this.m_Bounciness = value;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060017C2 RID: 6082 RVA: 0x0001DDEC File Offset: 0x0001BFEC
		// (set) Token: 0x060017C3 RID: 6083 RVA: 0x0001DE08 File Offset: 0x0001C008
		public float contactDistance
		{
			get
			{
				return this.m_ContactDistance;
			}
			set
			{
				this.m_ContactDistance = value;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x0001DE14 File Offset: 0x0001C014
		// (set) Token: 0x060017C5 RID: 6085 RVA: 0x0001DE30 File Offset: 0x0001C030
		[Obsolete("Use SoftJointLimit.bounciness instead", true)]
		public float bouncyness
		{
			get
			{
				return this.m_Bounciness;
			}
			set
			{
				this.m_Bounciness = value;
			}
		}

		// Token: 0x0400039E RID: 926
		private float m_Limit;

		// Token: 0x0400039F RID: 927
		private float m_Bounciness;

		// Token: 0x040003A0 RID: 928
		private float m_ContactDistance;
	}
}
