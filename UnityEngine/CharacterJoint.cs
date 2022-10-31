using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000161 RID: 353
	public sealed class CharacterJoint : Joint
	{
		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001987 RID: 6535 RVA: 0x000201B0 File Offset: 0x0001E3B0
		// (set) Token: 0x06001988 RID: 6536 RVA: 0x000201D0 File Offset: 0x0001E3D0
		public Vector3 swingAxis
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_swingAxis(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_swingAxis(ref value);
			}
		}

		// Token: 0x06001989 RID: 6537
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_swingAxis(out Vector3 value);

		// Token: 0x0600198A RID: 6538
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_swingAxis(ref Vector3 value);

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x0600198B RID: 6539 RVA: 0x000201DC File Offset: 0x0001E3DC
		// (set) Token: 0x0600198C RID: 6540 RVA: 0x000201FC File Offset: 0x0001E3FC
		public SoftJointLimitSpring twistLimitSpring
		{
			get
			{
				SoftJointLimitSpring result;
				this.INTERNAL_get_twistLimitSpring(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_twistLimitSpring(ref value);
			}
		}

		// Token: 0x0600198D RID: 6541
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_twistLimitSpring(out SoftJointLimitSpring value);

		// Token: 0x0600198E RID: 6542
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_twistLimitSpring(ref SoftJointLimitSpring value);

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x0600198F RID: 6543 RVA: 0x00020208 File Offset: 0x0001E408
		// (set) Token: 0x06001990 RID: 6544 RVA: 0x00020228 File Offset: 0x0001E428
		public SoftJointLimitSpring swingLimitSpring
		{
			get
			{
				SoftJointLimitSpring result;
				this.INTERNAL_get_swingLimitSpring(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_swingLimitSpring(ref value);
			}
		}

		// Token: 0x06001991 RID: 6545
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_swingLimitSpring(out SoftJointLimitSpring value);

		// Token: 0x06001992 RID: 6546
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_swingLimitSpring(ref SoftJointLimitSpring value);

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001993 RID: 6547 RVA: 0x00020234 File Offset: 0x0001E434
		// (set) Token: 0x06001994 RID: 6548 RVA: 0x00020254 File Offset: 0x0001E454
		public SoftJointLimit lowTwistLimit
		{
			get
			{
				SoftJointLimit result;
				this.INTERNAL_get_lowTwistLimit(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_lowTwistLimit(ref value);
			}
		}

		// Token: 0x06001995 RID: 6549
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_lowTwistLimit(out SoftJointLimit value);

		// Token: 0x06001996 RID: 6550
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_lowTwistLimit(ref SoftJointLimit value);

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001997 RID: 6551 RVA: 0x00020260 File Offset: 0x0001E460
		// (set) Token: 0x06001998 RID: 6552 RVA: 0x00020280 File Offset: 0x0001E480
		public SoftJointLimit highTwistLimit
		{
			get
			{
				SoftJointLimit result;
				this.INTERNAL_get_highTwistLimit(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_highTwistLimit(ref value);
			}
		}

		// Token: 0x06001999 RID: 6553
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_highTwistLimit(out SoftJointLimit value);

		// Token: 0x0600199A RID: 6554
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_highTwistLimit(ref SoftJointLimit value);

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x0600199B RID: 6555 RVA: 0x0002028C File Offset: 0x0001E48C
		// (set) Token: 0x0600199C RID: 6556 RVA: 0x000202AC File Offset: 0x0001E4AC
		public SoftJointLimit swing1Limit
		{
			get
			{
				SoftJointLimit result;
				this.INTERNAL_get_swing1Limit(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_swing1Limit(ref value);
			}
		}

		// Token: 0x0600199D RID: 6557
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_swing1Limit(out SoftJointLimit value);

		// Token: 0x0600199E RID: 6558
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_swing1Limit(ref SoftJointLimit value);

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x0600199F RID: 6559 RVA: 0x000202B8 File Offset: 0x0001E4B8
		// (set) Token: 0x060019A0 RID: 6560 RVA: 0x000202D8 File Offset: 0x0001E4D8
		public SoftJointLimit swing2Limit
		{
			get
			{
				SoftJointLimit result;
				this.INTERNAL_get_swing2Limit(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_swing2Limit(ref value);
			}
		}

		// Token: 0x060019A1 RID: 6561
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_swing2Limit(out SoftJointLimit value);

		// Token: 0x060019A2 RID: 6562
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_swing2Limit(ref SoftJointLimit value);

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x060019A3 RID: 6563
		// (set) Token: 0x060019A4 RID: 6564
		public extern bool enableProjection { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060019A5 RID: 6565
		// (set) Token: 0x060019A6 RID: 6566
		public extern float projectionDistance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060019A7 RID: 6567
		// (set) Token: 0x060019A8 RID: 6568
		public extern float projectionAngle { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x040003DF RID: 991
		[Obsolete("TargetRotation not in use for Unity 5 and assumed disabled.", true)]
		public Quaternion targetRotation;

		// Token: 0x040003E0 RID: 992
		[Obsolete("TargetAngularVelocity not in use for Unity 5 and assumed disabled.", true)]
		public Vector3 targetAngularVelocity;

		// Token: 0x040003E1 RID: 993
		[Obsolete("RotationDrive not in use for Unity 5 and assumed disabled.", true)]
		public JointDrive rotationDrive;
	}
}
