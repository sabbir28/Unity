using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001A3 RID: 419
	public sealed class WheelCollider : Collider
	{
		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x00024BE4 File Offset: 0x00022DE4
		// (set) Token: 0x06001E26 RID: 7718 RVA: 0x00024C04 File Offset: 0x00022E04
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

		// Token: 0x06001E27 RID: 7719
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_center(out Vector3 value);

		// Token: 0x06001E28 RID: 7720
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_center(ref Vector3 value);

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06001E29 RID: 7721
		// (set) Token: 0x06001E2A RID: 7722
		public extern float radius { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06001E2B RID: 7723
		// (set) Token: 0x06001E2C RID: 7724
		public extern float suspensionDistance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06001E2D RID: 7725 RVA: 0x00024C10 File Offset: 0x00022E10
		// (set) Token: 0x06001E2E RID: 7726 RVA: 0x00024C30 File Offset: 0x00022E30
		public JointSpring suspensionSpring
		{
			get
			{
				JointSpring result;
				this.INTERNAL_get_suspensionSpring(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_suspensionSpring(ref value);
			}
		}

		// Token: 0x06001E2F RID: 7727
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_suspensionSpring(out JointSpring value);

		// Token: 0x06001E30 RID: 7728
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_suspensionSpring(ref JointSpring value);

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06001E31 RID: 7729
		// (set) Token: 0x06001E32 RID: 7730
		public extern float forceAppPointDistance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06001E33 RID: 7731
		// (set) Token: 0x06001E34 RID: 7732
		public extern float mass { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06001E35 RID: 7733
		// (set) Token: 0x06001E36 RID: 7734
		public extern float wheelDampingRate { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06001E37 RID: 7735 RVA: 0x00024C3C File Offset: 0x00022E3C
		// (set) Token: 0x06001E38 RID: 7736 RVA: 0x00024C5C File Offset: 0x00022E5C
		public WheelFrictionCurve forwardFriction
		{
			get
			{
				WheelFrictionCurve result;
				this.INTERNAL_get_forwardFriction(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_forwardFriction(ref value);
			}
		}

		// Token: 0x06001E39 RID: 7737
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_forwardFriction(out WheelFrictionCurve value);

		// Token: 0x06001E3A RID: 7738
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_forwardFriction(ref WheelFrictionCurve value);

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06001E3B RID: 7739 RVA: 0x00024C68 File Offset: 0x00022E68
		// (set) Token: 0x06001E3C RID: 7740 RVA: 0x00024C88 File Offset: 0x00022E88
		public WheelFrictionCurve sidewaysFriction
		{
			get
			{
				WheelFrictionCurve result;
				this.INTERNAL_get_sidewaysFriction(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_sidewaysFriction(ref value);
			}
		}

		// Token: 0x06001E3D RID: 7741
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_sidewaysFriction(out WheelFrictionCurve value);

		// Token: 0x06001E3E RID: 7742
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_sidewaysFriction(ref WheelFrictionCurve value);

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06001E3F RID: 7743
		// (set) Token: 0x06001E40 RID: 7744
		public extern float motorTorque { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06001E41 RID: 7745
		// (set) Token: 0x06001E42 RID: 7746
		public extern float brakeTorque { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06001E43 RID: 7747
		// (set) Token: 0x06001E44 RID: 7748
		public extern float steerAngle { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06001E45 RID: 7749
		public extern bool isGrounded { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06001E46 RID: 7750
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ConfigureVehicleSubsteps(float speedThreshold, int stepsBelowThreshold, int stepsAboveThreshold);

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06001E47 RID: 7751
		public extern float sprungMass { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06001E48 RID: 7752
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool GetGroundHit(out WheelHit hit);

		// Token: 0x06001E49 RID: 7753
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void GetWorldPose(out Vector3 pos, out Quaternion quat);

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06001E4A RID: 7754
		public extern float rpm { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
