using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200017F RID: 383
	public sealed class CapsuleCollider2D : Collider2D
	{
		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x00024044 File Offset: 0x00022244
		// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x00024064 File Offset: 0x00022264
		public Vector2 size
		{
			get
			{
				Vector2 result;
				this.INTERNAL_get_size(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_size(ref value);
			}
		}

		// Token: 0x06001CC8 RID: 7368
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_size(out Vector2 value);

		// Token: 0x06001CC9 RID: 7369
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_size(ref Vector2 value);

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001CCA RID: 7370
		// (set) Token: 0x06001CCB RID: 7371
		public extern CapsuleDirection2D direction { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
