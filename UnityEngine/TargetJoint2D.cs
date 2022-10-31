using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000194 RID: 404
	public sealed class TargetJoint2D : Joint2D
	{
		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06001D87 RID: 7559 RVA: 0x00024904 File Offset: 0x00022B04
		// (set) Token: 0x06001D88 RID: 7560 RVA: 0x00024924 File Offset: 0x00022B24
		public Vector2 anchor
		{
			get
			{
				Vector2 result;
				this.INTERNAL_get_anchor(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_anchor(ref value);
			}
		}

		// Token: 0x06001D89 RID: 7561
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_anchor(out Vector2 value);

		// Token: 0x06001D8A RID: 7562
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_anchor(ref Vector2 value);

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06001D8B RID: 7563 RVA: 0x00024930 File Offset: 0x00022B30
		// (set) Token: 0x06001D8C RID: 7564 RVA: 0x00024950 File Offset: 0x00022B50
		public Vector2 target
		{
			get
			{
				Vector2 result;
				this.INTERNAL_get_target(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_target(ref value);
			}
		}

		// Token: 0x06001D8D RID: 7565
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_target(out Vector2 value);

		// Token: 0x06001D8E RID: 7566
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_target(ref Vector2 value);

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06001D8F RID: 7567
		// (set) Token: 0x06001D90 RID: 7568
		public extern bool autoConfigureTarget { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06001D91 RID: 7569
		// (set) Token: 0x06001D92 RID: 7570
		public extern float maxForce { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06001D93 RID: 7571
		// (set) Token: 0x06001D94 RID: 7572
		public extern float dampingRatio { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06001D95 RID: 7573
		// (set) Token: 0x06001D96 RID: 7574
		public extern float frequency { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
