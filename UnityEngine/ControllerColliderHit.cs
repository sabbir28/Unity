using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000155 RID: 341
	[RequiredByNativeCode]
	[StructLayout(LayoutKind.Sequential)]
	public class ControllerColliderHit
	{
		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x060017E3 RID: 6115 RVA: 0x0001E078 File Offset: 0x0001C278
		public CharacterController controller
		{
			get
			{
				return this.m_Controller;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x060017E4 RID: 6116 RVA: 0x0001E094 File Offset: 0x0001C294
		public Collider collider
		{
			get
			{
				return this.m_Collider;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x060017E5 RID: 6117 RVA: 0x0001E0B0 File Offset: 0x0001C2B0
		public Rigidbody rigidbody
		{
			get
			{
				return this.m_Collider.attachedRigidbody;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x060017E6 RID: 6118 RVA: 0x0001E0D0 File Offset: 0x0001C2D0
		public GameObject gameObject
		{
			get
			{
				return this.m_Collider.gameObject;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x060017E7 RID: 6119 RVA: 0x0001E0F0 File Offset: 0x0001C2F0
		public Transform transform
		{
			get
			{
				return this.m_Collider.transform;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x060017E8 RID: 6120 RVA: 0x0001E110 File Offset: 0x0001C310
		public Vector3 point
		{
			get
			{
				return this.m_Point;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x060017E9 RID: 6121 RVA: 0x0001E12C File Offset: 0x0001C32C
		public Vector3 normal
		{
			get
			{
				return this.m_Normal;
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x060017EA RID: 6122 RVA: 0x0001E148 File Offset: 0x0001C348
		public Vector3 moveDirection
		{
			get
			{
				return this.m_MoveDirection;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x060017EB RID: 6123 RVA: 0x0001E164 File Offset: 0x0001C364
		public float moveLength
		{
			get
			{
				return this.m_MoveLength;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x060017EC RID: 6124 RVA: 0x0001E180 File Offset: 0x0001C380
		// (set) Token: 0x060017ED RID: 6125 RVA: 0x0001E1A4 File Offset: 0x0001C3A4
		private bool push
		{
			get
			{
				return this.m_Push != 0;
			}
			set
			{
				this.m_Push = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x040003B7 RID: 951
		internal CharacterController m_Controller;

		// Token: 0x040003B8 RID: 952
		internal Collider m_Collider;

		// Token: 0x040003B9 RID: 953
		internal Vector3 m_Point;

		// Token: 0x040003BA RID: 954
		internal Vector3 m_Normal;

		// Token: 0x040003BB RID: 955
		internal Vector3 m_MoveDirection;

		// Token: 0x040003BC RID: 956
		internal float m_MoveLength;

		// Token: 0x040003BD RID: 957
		internal int m_Push;
	}
}
