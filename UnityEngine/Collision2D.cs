using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000186 RID: 390
	[RequiredByNativeCode]
	[StructLayout(LayoutKind.Sequential)]
	public class Collision2D
	{
		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001D01 RID: 7425 RVA: 0x000243EC File Offset: 0x000225EC
		public Collider2D collider
		{
			get
			{
				return Physics2D.GetColliderFromInstanceID(this.m_Collider);
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001D02 RID: 7426 RVA: 0x0002440C File Offset: 0x0002260C
		public Collider2D otherCollider
		{
			get
			{
				return Physics2D.GetColliderFromInstanceID(this.m_OtherCollider);
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001D03 RID: 7427 RVA: 0x0002442C File Offset: 0x0002262C
		public Rigidbody2D rigidbody
		{
			get
			{
				return Physics2D.GetRigidbodyFromInstanceID(this.m_Rigidbody);
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001D04 RID: 7428 RVA: 0x0002444C File Offset: 0x0002264C
		public Rigidbody2D otherRigidbody
		{
			get
			{
				return Physics2D.GetRigidbodyFromInstanceID(this.m_OtherRigidbody);
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001D05 RID: 7429 RVA: 0x0002446C File Offset: 0x0002266C
		public Transform transform
		{
			get
			{
				return (!(this.rigidbody != null)) ? this.collider.transform : this.rigidbody.transform;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001D06 RID: 7430 RVA: 0x000244B0 File Offset: 0x000226B0
		public GameObject gameObject
		{
			get
			{
				return (!(this.rigidbody != null)) ? this.collider.gameObject : this.rigidbody.gameObject;
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001D07 RID: 7431 RVA: 0x000244F4 File Offset: 0x000226F4
		public ContactPoint2D[] contacts
		{
			get
			{
				return this.m_Contacts;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001D08 RID: 7432 RVA: 0x00024510 File Offset: 0x00022710
		public Vector2 relativeVelocity
		{
			get
			{
				return this.m_RelativeVelocity;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x0002452C File Offset: 0x0002272C
		public bool enabled
		{
			get
			{
				return this.m_Enabled == 1;
			}
		}

		// Token: 0x04000440 RID: 1088
		internal int m_Collider;

		// Token: 0x04000441 RID: 1089
		internal int m_OtherCollider;

		// Token: 0x04000442 RID: 1090
		internal int m_Rigidbody;

		// Token: 0x04000443 RID: 1091
		internal int m_OtherRigidbody;

		// Token: 0x04000444 RID: 1092
		internal ContactPoint2D[] m_Contacts;

		// Token: 0x04000445 RID: 1093
		internal Vector2 m_RelativeVelocity;

		// Token: 0x04000446 RID: 1094
		internal int m_Enabled;
	}
}
