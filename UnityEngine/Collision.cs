using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000157 RID: 343
	[RequiredByNativeCode]
	[StructLayout(LayoutKind.Sequential)]
	public class Collision
	{
		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060017EF RID: 6127 RVA: 0x0001E1C4 File Offset: 0x0001C3C4
		public Vector3 relativeVelocity
		{
			get
			{
				return this.m_RelativeVelocity;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x060017F0 RID: 6128 RVA: 0x0001E1E0 File Offset: 0x0001C3E0
		public Rigidbody rigidbody
		{
			get
			{
				return this.m_Rigidbody;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060017F1 RID: 6129 RVA: 0x0001E1FC File Offset: 0x0001C3FC
		public Collider collider
		{
			get
			{
				return this.m_Collider;
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x060017F2 RID: 6130 RVA: 0x0001E218 File Offset: 0x0001C418
		public Transform transform
		{
			get
			{
				return (!(this.rigidbody != null)) ? this.collider.transform : this.rigidbody.transform;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x060017F3 RID: 6131 RVA: 0x0001E25C File Offset: 0x0001C45C
		public GameObject gameObject
		{
			get
			{
				return (!(this.m_Rigidbody != null)) ? this.m_Collider.gameObject : this.m_Rigidbody.gameObject;
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x060017F4 RID: 6132 RVA: 0x0001E2A0 File Offset: 0x0001C4A0
		public ContactPoint[] contacts
		{
			get
			{
				return this.m_Contacts;
			}
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x0001E2BC File Offset: 0x0001C4BC
		public virtual IEnumerator GetEnumerator()
		{
			return this.contacts.GetEnumerator();
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x060017F6 RID: 6134 RVA: 0x0001E2DC File Offset: 0x0001C4DC
		public Vector3 impulse
		{
			get
			{
				return this.m_Impulse;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x060017F7 RID: 6135 RVA: 0x0001E2F8 File Offset: 0x0001C4F8
		[Obsolete("Use Collision.relativeVelocity instead.", false)]
		public Vector3 impactForceSum
		{
			get
			{
				return this.relativeVelocity;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x060017F8 RID: 6136 RVA: 0x0001E314 File Offset: 0x0001C514
		[Obsolete("Will always return zero.", false)]
		public Vector3 frictionForceSum
		{
			get
			{
				return Vector3.zero;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x060017F9 RID: 6137 RVA: 0x0001E330 File Offset: 0x0001C530
		[Obsolete("Please use Collision.rigidbody, Collision.transform or Collision.collider instead", false)]
		public Component other
		{
			get
			{
				return (!(this.m_Rigidbody != null)) ? this.m_Collider : this.m_Rigidbody;
			}
		}

		// Token: 0x040003C3 RID: 963
		internal Vector3 m_Impulse;

		// Token: 0x040003C4 RID: 964
		internal Vector3 m_RelativeVelocity;

		// Token: 0x040003C5 RID: 965
		internal Rigidbody m_Rigidbody;

		// Token: 0x040003C6 RID: 966
		internal Collider m_Collider;

		// Token: 0x040003C7 RID: 967
		internal ContactPoint[] m_Contacts;
	}
}
