using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000165 RID: 357
	[RequireComponent(typeof(Rigidbody))]
	public sealed class ConstantForce : Behaviour
	{
		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x00020638 File Offset: 0x0001E838
		// (set) Token: 0x06001A10 RID: 6672 RVA: 0x00020658 File Offset: 0x0001E858
		public Vector3 force
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_force(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_force(ref value);
			}
		}

		// Token: 0x06001A11 RID: 6673
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_force(out Vector3 value);

		// Token: 0x06001A12 RID: 6674
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_force(ref Vector3 value);

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x00020664 File Offset: 0x0001E864
		// (set) Token: 0x06001A14 RID: 6676 RVA: 0x00020684 File Offset: 0x0001E884
		public Vector3 relativeForce
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_relativeForce(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_relativeForce(ref value);
			}
		}

		// Token: 0x06001A15 RID: 6677
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_relativeForce(out Vector3 value);

		// Token: 0x06001A16 RID: 6678
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_relativeForce(ref Vector3 value);

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001A17 RID: 6679 RVA: 0x00020690 File Offset: 0x0001E890
		// (set) Token: 0x06001A18 RID: 6680 RVA: 0x000206B0 File Offset: 0x0001E8B0
		public Vector3 torque
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_torque(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_torque(ref value);
			}
		}

		// Token: 0x06001A19 RID: 6681
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_torque(out Vector3 value);

		// Token: 0x06001A1A RID: 6682
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_torque(ref Vector3 value);

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001A1B RID: 6683 RVA: 0x000206BC File Offset: 0x0001E8BC
		// (set) Token: 0x06001A1C RID: 6684 RVA: 0x000206DC File Offset: 0x0001E8DC
		public Vector3 relativeTorque
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_relativeTorque(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_relativeTorque(ref value);
			}
		}

		// Token: 0x06001A1D RID: 6685
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_relativeTorque(out Vector3 value);

		// Token: 0x06001A1E RID: 6686
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_relativeTorque(ref Vector3 value);
	}
}
