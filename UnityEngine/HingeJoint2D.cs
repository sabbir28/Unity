using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000191 RID: 401
	public sealed class HingeJoint2D : AnchoredJoint2D
	{
		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001D4C RID: 7500
		// (set) Token: 0x06001D4D RID: 7501
		public extern bool useMotor { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001D4E RID: 7502
		// (set) Token: 0x06001D4F RID: 7503
		public extern bool useLimits { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001D50 RID: 7504 RVA: 0x000247B8 File Offset: 0x000229B8
		// (set) Token: 0x06001D51 RID: 7505 RVA: 0x000247D8 File Offset: 0x000229D8
		public JointMotor2D motor
		{
			get
			{
				JointMotor2D result;
				this.INTERNAL_get_motor(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_motor(ref value);
			}
		}

		// Token: 0x06001D52 RID: 7506
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_motor(out JointMotor2D value);

		// Token: 0x06001D53 RID: 7507
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_motor(ref JointMotor2D value);

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06001D54 RID: 7508 RVA: 0x000247E4 File Offset: 0x000229E4
		// (set) Token: 0x06001D55 RID: 7509 RVA: 0x00024804 File Offset: 0x00022A04
		public JointAngleLimits2D limits
		{
			get
			{
				JointAngleLimits2D result;
				this.INTERNAL_get_limits(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_limits(ref value);
			}
		}

		// Token: 0x06001D56 RID: 7510
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_limits(out JointAngleLimits2D value);

		// Token: 0x06001D57 RID: 7511
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_limits(ref JointAngleLimits2D value);

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06001D58 RID: 7512
		public extern JointLimitState2D limitState { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06001D59 RID: 7513
		public extern float referenceAngle { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06001D5A RID: 7514
		public extern float jointAngle { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001D5B RID: 7515
		public extern float jointSpeed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06001D5C RID: 7516 RVA: 0x00024810 File Offset: 0x00022A10
		public float GetMotorTorque(float timeStep)
		{
			return HingeJoint2D.INTERNAL_CALL_GetMotorTorque(this, timeStep);
		}

		// Token: 0x06001D5D RID: 7517
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float INTERNAL_CALL_GetMotorTorque(HingeJoint2D self, float timeStep);
	}
}
