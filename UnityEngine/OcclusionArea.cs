using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000040 RID: 64
	public sealed class OcclusionArea : Component
	{
		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x0000749C File Offset: 0x0000569C
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x000074BC File Offset: 0x000056BC
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

		// Token: 0x06000489 RID: 1161
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_center(out Vector3 value);

		// Token: 0x0600048A RID: 1162
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_center(ref Vector3 value);

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x000074C8 File Offset: 0x000056C8
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x000074E8 File Offset: 0x000056E8
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

		// Token: 0x0600048D RID: 1165
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_size(out Vector3 value);

		// Token: 0x0600048E RID: 1166
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_size(ref Vector3 value);
	}
}
