using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200016B RID: 363
	public sealed class CapsuleCollider : Collider
	{
		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x0002088C File Offset: 0x0001EA8C
		// (set) Token: 0x06001A53 RID: 6739 RVA: 0x000208AC File Offset: 0x0001EAAC
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

		// Token: 0x06001A54 RID: 6740
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_center(out Vector3 value);

		// Token: 0x06001A55 RID: 6741
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_center(ref Vector3 value);

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001A56 RID: 6742
		// (set) Token: 0x06001A57 RID: 6743
		public extern float radius { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001A58 RID: 6744
		// (set) Token: 0x06001A59 RID: 6745
		public extern float height { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001A5A RID: 6746
		// (set) Token: 0x06001A5B RID: 6747
		public extern int direction { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
