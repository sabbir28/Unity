using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200016E RID: 366
	public sealed class CharacterController : Collider
	{
		// Token: 0x06001A86 RID: 6790 RVA: 0x00020C40 File Offset: 0x0001EE40
		public bool SimpleMove(Vector3 speed)
		{
			return CharacterController.INTERNAL_CALL_SimpleMove(this, ref speed);
		}

		// Token: 0x06001A87 RID: 6791
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_SimpleMove(CharacterController self, ref Vector3 speed);

		// Token: 0x06001A88 RID: 6792 RVA: 0x00020C60 File Offset: 0x0001EE60
		public CollisionFlags Move(Vector3 motion)
		{
			return CharacterController.INTERNAL_CALL_Move(this, ref motion);
		}

		// Token: 0x06001A89 RID: 6793
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern CollisionFlags INTERNAL_CALL_Move(CharacterController self, ref Vector3 motion);

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001A8A RID: 6794
		public extern bool isGrounded { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001A8B RID: 6795 RVA: 0x00020C80 File Offset: 0x0001EE80
		public Vector3 velocity
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_velocity(out result);
				return result;
			}
		}

		// Token: 0x06001A8C RID: 6796
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_velocity(out Vector3 value);

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001A8D RID: 6797
		public extern CollisionFlags collisionFlags { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001A8E RID: 6798
		// (set) Token: 0x06001A8F RID: 6799
		public extern float radius { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001A90 RID: 6800
		// (set) Token: 0x06001A91 RID: 6801
		public extern float height { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001A92 RID: 6802 RVA: 0x00020CA0 File Offset: 0x0001EEA0
		// (set) Token: 0x06001A93 RID: 6803 RVA: 0x00020CC0 File Offset: 0x0001EEC0
		public Vector3 center
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_center(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_center(ref value);
			}
		}

		// Token: 0x06001A94 RID: 6804
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_center(out Vector3 value);

		// Token: 0x06001A95 RID: 6805
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_center(ref Vector3 value);

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001A96 RID: 6806
		// (set) Token: 0x06001A97 RID: 6807
		public extern float slopeLimit { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001A98 RID: 6808
		// (set) Token: 0x06001A99 RID: 6809
		public extern float stepOffset { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001A9A RID: 6810
		// (set) Token: 0x06001A9B RID: 6811
		public extern float skinWidth { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001A9C RID: 6812
		// (set) Token: 0x06001A9D RID: 6813
		public extern float minMoveDistance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001A9E RID: 6814
		// (set) Token: 0x06001A9F RID: 6815
		public extern bool detectCollisions { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001AA0 RID: 6816
		// (set) Token: 0x06001AA1 RID: 6817
		public extern bool enableOverlapRecovery { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
