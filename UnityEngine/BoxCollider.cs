using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000168 RID: 360
	public sealed class BoxCollider : Collider
	{
		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001A35 RID: 6709 RVA: 0x00020798 File Offset: 0x0001E998
		// (set) Token: 0x06001A36 RID: 6710 RVA: 0x000207B8 File Offset: 0x0001E9B8
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

		// Token: 0x06001A37 RID: 6711
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_center(out Vector3 value);

		// Token: 0x06001A38 RID: 6712
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_center(ref Vector3 value);

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001A39 RID: 6713 RVA: 0x000207C4 File Offset: 0x0001E9C4
		// (set) Token: 0x06001A3A RID: 6714 RVA: 0x000207E4 File Offset: 0x0001E9E4
		public Vector3 size
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_size(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_size(ref value);
			}
		}

		// Token: 0x06001A3B RID: 6715
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_size(out Vector3 value);

		// Token: 0x06001A3C RID: 6716
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_size(ref Vector3 value);

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001A3D RID: 6717 RVA: 0x000207F0 File Offset: 0x0001E9F0
		// (set) Token: 0x06001A3E RID: 6718 RVA: 0x00020818 File Offset: 0x0001EA18
		[Obsolete("use BoxCollider.size instead.")]
		public Vector3 extents
		{
			get
			{
				return this.size * 0.5f;
			}
			set
			{
				this.size = value * 2f;
			}
		}
	}
}
