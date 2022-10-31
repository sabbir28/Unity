using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200015B RID: 347
	[UsedByNativeCode]
	public struct ContactPoint
	{
		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x060018C1 RID: 6337 RVA: 0x0001FA64 File Offset: 0x0001DC64
		public Vector3 point
		{
			get
			{
				return this.m_Point;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x060018C2 RID: 6338 RVA: 0x0001FA80 File Offset: 0x0001DC80
		public Vector3 normal
		{
			get
			{
				return this.m_Normal;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x060018C3 RID: 6339 RVA: 0x0001FA9C File Offset: 0x0001DC9C
		public Collider thisCollider
		{
			get
			{
				return ContactPoint.ColliderFromInstanceId(this.m_ThisColliderInstanceID);
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x060018C4 RID: 6340 RVA: 0x0001FABC File Offset: 0x0001DCBC
		public Collider otherCollider
		{
			get
			{
				return ContactPoint.ColliderFromInstanceId(this.m_OtherColliderInstanceID);
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x060018C5 RID: 6341 RVA: 0x0001FADC File Offset: 0x0001DCDC
		public float separation
		{
			get
			{
				return this.m_Separation;
			}
		}

		// Token: 0x060018C6 RID: 6342
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Collider ColliderFromInstanceId(int instanceID);

		// Token: 0x040003DA RID: 986
		internal Vector3 m_Point;

		// Token: 0x040003DB RID: 987
		internal Vector3 m_Normal;

		// Token: 0x040003DC RID: 988
		internal int m_ThisColliderInstanceID;

		// Token: 0x040003DD RID: 989
		internal int m_OtherColliderInstanceID;

		// Token: 0x040003DE RID: 990
		internal float m_Separation;
	}
}
