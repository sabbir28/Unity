using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200018C RID: 396
	[RequireComponent(typeof(Transform), typeof(Rigidbody2D))]
	public class Joint2D : Behaviour
	{
		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001D1D RID: 7453
		// (set) Token: 0x06001D1E RID: 7454
		public extern Rigidbody2D connectedBody { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001D1F RID: 7455
		// (set) Token: 0x06001D20 RID: 7456
		public extern bool enableCollision { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001D21 RID: 7457
		// (set) Token: 0x06001D22 RID: 7458
		public extern float breakForce { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001D23 RID: 7459
		// (set) Token: 0x06001D24 RID: 7460
		public extern float breakTorque { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x000246BC File Offset: 0x000228BC
		public Vector2 reactionForce
		{
			get
			{
				return this.GetReactionForce(Time.fixedDeltaTime);
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001D26 RID: 7462 RVA: 0x000246DC File Offset: 0x000228DC
		public float reactionTorque
		{
			get
			{
				return this.GetReactionTorque(Time.fixedDeltaTime);
			}
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x000246FC File Offset: 0x000228FC
		public Vector2 GetReactionForce(float timeStep)
		{
			Vector2 result;
			Joint2D.Internal_GetReactionForce(this, timeStep, out result);
			return result;
		}

		// Token: 0x06001D28 RID: 7464
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_GetReactionForce(Joint2D joint, float timeStep, out Vector2 value);

		// Token: 0x06001D29 RID: 7465 RVA: 0x0002471C File Offset: 0x0002291C
		public float GetReactionTorque(float timeStep)
		{
			return Joint2D.INTERNAL_CALL_GetReactionTorque(this, timeStep);
		}

		// Token: 0x06001D2A RID: 7466
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float INTERNAL_CALL_GetReactionTorque(Joint2D self, float timeStep);
	}
}
