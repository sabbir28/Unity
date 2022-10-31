using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000196 RID: 406
	public sealed class WheelJoint2D : AnchoredJoint2D
	{
		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06001D9E RID: 7582 RVA: 0x0002496C File Offset: 0x00022B6C
		// (set) Token: 0x06001D9F RID: 7583 RVA: 0x0002498C File Offset: 0x00022B8C
		public JointSuspension2D suspension
		{
			get
			{
				JointSuspension2D result;
				this.INTERNAL_get_suspension(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_suspension(ref value);
			}
		}

		// Token: 0x06001DA0 RID: 7584
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_suspension(out JointSuspension2D value);

		// Token: 0x06001DA1 RID: 7585
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_suspension(ref JointSuspension2D value);

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06001DA2 RID: 7586
		// (set) Token: 0x06001DA3 RID: 7587
		public extern bool useMotor { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x00024998 File Offset: 0x00022B98
		// (set) Token: 0x06001DA5 RID: 7589 RVA: 0x000249B8 File Offset: 0x00022BB8
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

		// Token: 0x06001DA6 RID: 7590
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_motor(out JointMotor2D value);

		// Token: 0x06001DA7 RID: 7591
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_motor(ref JointMotor2D value);

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06001DA8 RID: 7592
		public extern float jointTranslation { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06001DA9 RID: 7593
		public extern float jointLinearSpeed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06001DAA RID: 7594
		public extern float jointSpeed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06001DAB RID: 7595
		public extern float jointAngle { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06001DAC RID: 7596 RVA: 0x000249C4 File Offset: 0x00022BC4
		public float GetMotorTorque(float timeStep)
		{
			return WheelJoint2D.INTERNAL_CALL_GetMotorTorque(this, timeStep);
		}

		// Token: 0x06001DAD RID: 7597
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float INTERNAL_CALL_GetMotorTorque(WheelJoint2D self, float timeStep);
	}
}
