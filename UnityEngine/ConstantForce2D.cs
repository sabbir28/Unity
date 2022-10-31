using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000199 RID: 409
	[RequireComponent(typeof(Rigidbody2D))]
	public sealed class ConstantForce2D : PhysicsUpdateBehaviour2D
	{
		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x00024A10 File Offset: 0x00022C10
		// (set) Token: 0x06001DB8 RID: 7608 RVA: 0x00024A30 File Offset: 0x00022C30
		public Vector2 force
		{
			get
			{
				Vector2 result;
				this.INTERNAL_get_force(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_force(ref value);
			}
		}

		// Token: 0x06001DB9 RID: 7609
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_force(out Vector2 value);

		// Token: 0x06001DBA RID: 7610
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_force(ref Vector2 value);

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06001DBB RID: 7611 RVA: 0x00024A3C File Offset: 0x00022C3C
		// (set) Token: 0x06001DBC RID: 7612 RVA: 0x00024A5C File Offset: 0x00022C5C
		public Vector2 relativeForce
		{
			get
			{
				Vector2 result;
				this.INTERNAL_get_relativeForce(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_relativeForce(ref value);
			}
		}

		// Token: 0x06001DBD RID: 7613
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_relativeForce(out Vector2 value);

		// Token: 0x06001DBE RID: 7614
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_relativeForce(ref Vector2 value);

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06001DBF RID: 7615
		// (set) Token: 0x06001DC0 RID: 7616
		public extern float torque { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
