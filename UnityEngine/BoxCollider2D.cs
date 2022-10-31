using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200017C RID: 380
	public sealed class BoxCollider2D : Collider2D
	{
		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001CB5 RID: 7349 RVA: 0x00024008 File Offset: 0x00022208
		// (set) Token: 0x06001CB6 RID: 7350 RVA: 0x00024028 File Offset: 0x00022228
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

		// Token: 0x06001CB7 RID: 7351
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_size(out Vector2 value);

		// Token: 0x06001CB8 RID: 7352
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_size(ref Vector2 value);

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001CB9 RID: 7353
		// (set) Token: 0x06001CBA RID: 7354
		public extern float edgeRadius { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001CBB RID: 7355
		// (set) Token: 0x06001CBC RID: 7356
		public extern bool autoTiling { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
