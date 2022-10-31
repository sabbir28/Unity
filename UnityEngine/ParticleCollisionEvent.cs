using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000146 RID: 326
	[RequiredByNativeCode(Optional = true)]
	public struct ParticleCollisionEvent
	{
		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x0001DA7C File Offset: 0x0001BC7C
		public Vector3 intersection
		{
			get
			{
				return this.m_Intersection;
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x0600179D RID: 6045 RVA: 0x0001DA98 File Offset: 0x0001BC98
		public Vector3 normal
		{
			get
			{
				return this.m_Normal;
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x0001DAB4 File Offset: 0x0001BCB4
		public Vector3 velocity
		{
			get
			{
				return this.m_Velocity;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x0600179F RID: 6047 RVA: 0x0001DAD0 File Offset: 0x0001BCD0
		[Obsolete("collider property is deprecated. Use colliderComponent instead, which supports Collider and Collider2D components.", true)]
		public Component collider
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060017A0 RID: 6048 RVA: 0x0001DAE8 File Offset: 0x0001BCE8
		public Component colliderComponent
		{
			get
			{
				return ParticleCollisionEvent.InstanceIDToColliderComponent(this.m_ColliderInstanceID);
			}
		}

		// Token: 0x060017A1 RID: 6049
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Component InstanceIDToColliderComponent(int instanceID);

		// Token: 0x0400037C RID: 892
		private Vector3 m_Intersection;

		// Token: 0x0400037D RID: 893
		private Vector3 m_Normal;

		// Token: 0x0400037E RID: 894
		private Vector3 m_Velocity;

		// Token: 0x0400037F RID: 895
		private int m_ColliderInstanceID;
	}
}
