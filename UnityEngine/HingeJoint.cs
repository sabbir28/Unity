using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200015E RID: 350
	public sealed class HingeJoint : Joint
	{
		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x00020114 File Offset: 0x0001E314
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x00020134 File Offset: 0x0001E334
		public JointMotor motor
		{
			get
			{
				JointMotor result;
				this.INTERNAL_get_motor(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_motor(ref value);
			}
		}

		// Token: 0x06001968 RID: 6504
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_motor(out JointMotor value);

		// Token: 0x06001969 RID: 6505
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_motor(ref JointMotor value);

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x00020140 File Offset: 0x0001E340
		// (set) Token: 0x0600196B RID: 6507 RVA: 0x00020160 File Offset: 0x0001E360
		public JointLimits limits
		{
			get
			{
				JointLimits result;
				this.INTERNAL_get_limits(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_limits(ref value);
			}
		}

		// Token: 0x0600196C RID: 6508
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_limits(out JointLimits value);

		// Token: 0x0600196D RID: 6509
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_limits(ref JointLimits value);

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x0600196E RID: 6510 RVA: 0x0002016C File Offset: 0x0001E36C
		// (set) Token: 0x0600196F RID: 6511 RVA: 0x0002018C File Offset: 0x0001E38C
		public JointSpring spring
		{
			get
			{
				JointSpring result;
				this.INTERNAL_get_spring(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_spring(ref value);
			}
		}

		// Token: 0x06001970 RID: 6512
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_spring(out JointSpring value);

		// Token: 0x06001971 RID: 6513
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_spring(ref JointSpring value);

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001972 RID: 6514
		// (set) Token: 0x06001973 RID: 6515
		public extern bool useMotor { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001974 RID: 6516
		// (set) Token: 0x06001975 RID: 6517
		public extern bool useLimits { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001976 RID: 6518
		// (set) Token: 0x06001977 RID: 6519
		public extern bool useSpring { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001978 RID: 6520
		public extern float velocity { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001979 RID: 6521
		public extern float angle { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
