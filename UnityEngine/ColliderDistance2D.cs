using System;

namespace UnityEngine
{
	// Token: 0x02000184 RID: 388
	public struct ColliderDistance2D
	{
		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001CEB RID: 7403 RVA: 0x000241A8 File Offset: 0x000223A8
		// (set) Token: 0x06001CEC RID: 7404 RVA: 0x000241C4 File Offset: 0x000223C4
		public Vector2 pointA
		{
			get
			{
				return this.m_PointA;
			}
			set
			{
				this.m_PointA = value;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001CED RID: 7405 RVA: 0x000241D0 File Offset: 0x000223D0
		// (set) Token: 0x06001CEE RID: 7406 RVA: 0x000241EC File Offset: 0x000223EC
		public Vector2 pointB
		{
			get
			{
				return this.m_PointB;
			}
			set
			{
				this.m_PointB = value;
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001CEF RID: 7407 RVA: 0x000241F8 File Offset: 0x000223F8
		public Vector2 normal
		{
			get
			{
				return this.m_Normal;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001CF0 RID: 7408 RVA: 0x00024214 File Offset: 0x00022414
		// (set) Token: 0x06001CF1 RID: 7409 RVA: 0x00024230 File Offset: 0x00022430
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

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x0002423C File Offset: 0x0002243C
		public bool isOverlapped
		{
			get
			{
				return this.m_Distance < 0f;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001CF3 RID: 7411 RVA: 0x00024260 File Offset: 0x00022460
		// (set) Token: 0x06001CF4 RID: 7412 RVA: 0x00024284 File Offset: 0x00022484
		public bool isValid
		{
			get
			{
				return this.m_IsValid != 0;
			}
			set
			{
				this.m_IsValid = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x04000430 RID: 1072
		private Vector2 m_PointA;

		// Token: 0x04000431 RID: 1073
		private Vector2 m_PointB;

		// Token: 0x04000432 RID: 1074
		private Vector2 m_Normal;

		// Token: 0x04000433 RID: 1075
		private float m_Distance;

		// Token: 0x04000434 RID: 1076
		private int m_IsValid;
	}
}
