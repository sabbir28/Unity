using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000193 RID: 403
	public sealed class SliderJoint2D : AnchoredJoint2D
	{
		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06001D70 RID: 7536
		// (set) Token: 0x06001D71 RID: 7537
		public extern bool autoConfigureAngle { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06001D72 RID: 7538
		// (set) Token: 0x06001D73 RID: 7539
		public extern float angle { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001D74 RID: 7540
		// (set) Token: 0x06001D75 RID: 7541
		public extern bool useMotor { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06001D76 RID: 7542
		// (set) Token: 0x06001D77 RID: 7543
		public extern bool useLimits { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001D78 RID: 7544 RVA: 0x00024888 File Offset: 0x00022A88
		// (set) Token: 0x06001D79 RID: 7545 RVA: 0x000248A8 File Offset: 0x00022AA8
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

		// Token: 0x06001D7A RID: 7546
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_motor(out JointMotor2D value);

		// Token: 0x06001D7B RID: 7547
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_motor(ref JointMotor2D value);

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x000248B4 File Offset: 0x00022AB4
		// (set) Token: 0x06001D7D RID: 7549 RVA: 0x000248D4 File Offset: 0x00022AD4
		public JointTranslationLimits2D limits
		{
			get
			{
				JointTranslationLimits2D result;
				this.INTERNAL_get_limits(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_limits(ref value);
			}
		}

		// Token: 0x06001D7E RID: 7550
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_limits(out JointTranslationLimits2D value);

		// Token: 0x06001D7F RID: 7551
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_limits(ref JointTranslationLimits2D value);

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06001D80 RID: 7552
		public extern JointLimitState2D limitState { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06001D81 RID: 7553
		public extern float referenceAngle { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06001D82 RID: 7554
		public extern float jointTranslation { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06001D83 RID: 7555
		public extern float jointSpeed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06001D84 RID: 7556 RVA: 0x000248E0 File Offset: 0x00022AE0
		public float GetMotorForce(float timeStep)
		{
			return SliderJoint2D.INTERNAL_CALL_GetMotorForce(this, timeStep);
		}

		// Token: 0x06001D85 RID: 7557
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float INTERNAL_CALL_GetMotorForce(SliderJoint2D self, float timeStep);
	}
}
