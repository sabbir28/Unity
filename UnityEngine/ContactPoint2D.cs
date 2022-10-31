using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000185 RID: 389
	[UsedByNativeCode]
	public struct ContactPoint2D
	{
		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001CF5 RID: 7413 RVA: 0x0002429C File Offset: 0x0002249C
		public Vector2 point
		{
			get
			{
				return this.m_Point;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x000242B8 File Offset: 0x000224B8
		public Vector2 normal
		{
			get
			{
				return this.m_Normal;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001CF7 RID: 7415 RVA: 0x000242D4 File Offset: 0x000224D4
		public float separation
		{
			get
			{
				return this.m_Separation;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001CF8 RID: 7416 RVA: 0x000242F0 File Offset: 0x000224F0
		public float normalImpulse
		{
			get
			{
				return this.m_NormalImpulse;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001CF9 RID: 7417 RVA: 0x0002430C File Offset: 0x0002250C
		public float tangentImpulse
		{
			get
			{
				return this.m_TangentImpulse;
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001CFA RID: 7418 RVA: 0x00024328 File Offset: 0x00022528
		public Vector2 relativeVelocity
		{
			get
			{
				return this.m_RelativeVelocity;
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001CFB RID: 7419 RVA: 0x00024344 File Offset: 0x00022544
		public Collider2D collider
		{
			get
			{
				return Physics2D.GetColliderFromInstanceID(this.m_Collider);
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001CFC RID: 7420 RVA: 0x00024364 File Offset: 0x00022564
		public Collider2D otherCollider
		{
			get
			{
				return Physics2D.GetColliderFromInstanceID(this.m_OtherCollider);
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001CFD RID: 7421 RVA: 0x00024384 File Offset: 0x00022584
		public Rigidbody2D rigidbody
		{
			get
			{
				return Physics2D.GetRigidbodyFromInstanceID(this.m_Rigidbody);
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001CFE RID: 7422 RVA: 0x000243A4 File Offset: 0x000225A4
		public Rigidbody2D otherRigidbody
		{
			get
			{
				return Physics2D.GetRigidbodyFromInstanceID(this.m_OtherRigidbody);
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001CFF RID: 7423 RVA: 0x000243C4 File Offset: 0x000225C4
		public bool enabled
		{
			get
			{
				return this.m_Enabled == 1;
			}
		}

		// Token: 0x04000435 RID: 1077
		internal Vector2 m_Point;

		// Token: 0x04000436 RID: 1078
		internal Vector2 m_Normal;

		// Token: 0x04000437 RID: 1079
		internal Vector2 m_RelativeVelocity;

		// Token: 0x04000438 RID: 1080
		internal float m_Separation;

		// Token: 0x04000439 RID: 1081
		internal float m_NormalImpulse;

		// Token: 0x0400043A RID: 1082
		internal float m_TangentImpulse;

		// Token: 0x0400043B RID: 1083
		internal int m_Collider;

		// Token: 0x0400043C RID: 1084
		internal int m_OtherCollider;

		// Token: 0x0400043D RID: 1085
		internal int m_Rigidbody;

		// Token: 0x0400043E RID: 1086
		internal int m_OtherRigidbody;

		// Token: 0x0400043F RID: 1087
		internal int m_Enabled;
	}
}
