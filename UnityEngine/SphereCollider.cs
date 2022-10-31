using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000169 RID: 361
	public sealed class SphereCollider : Collider
	{
		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001A40 RID: 6720 RVA: 0x00020834 File Offset: 0x0001EA34
		// (set) Token: 0x06001A41 RID: 6721 RVA: 0x00020854 File Offset: 0x0001EA54
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

		// Token: 0x06001A42 RID: 6722
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_center(out Vector3 value);

		// Token: 0x06001A43 RID: 6723
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_center(ref Vector3 value);

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001A44 RID: 6724
		// (set) Token: 0x06001A45 RID: 6725
		public extern float radius { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
