using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000192 RID: 402
	public sealed class RelativeJoint2D : Joint2D
	{
		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001D5F RID: 7519
		// (set) Token: 0x06001D60 RID: 7520
		public extern float maxForce { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001D61 RID: 7521
		// (set) Token: 0x06001D62 RID: 7522
		public extern float maxTorque { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001D63 RID: 7523
		// (set) Token: 0x06001D64 RID: 7524
		public extern float correctionScale { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001D65 RID: 7525
		// (set) Token: 0x06001D66 RID: 7526
		public extern bool autoConfigureOffset { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001D67 RID: 7527 RVA: 0x00024834 File Offset: 0x00022A34
		// (set) Token: 0x06001D68 RID: 7528 RVA: 0x00024854 File Offset: 0x00022A54
		public Vector2 linearOffset
		{
			get
			{
				Vector2 result;
				this.INTERNAL_get_linearOffset(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_linearOffset(ref value);
			}
		}

		// Token: 0x06001D69 RID: 7529
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_linearOffset(out Vector2 value);

		// Token: 0x06001D6A RID: 7530
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_linearOffset(ref Vector2 value);

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001D6B RID: 7531
		// (set) Token: 0x06001D6C RID: 7532
		public extern float angularOffset { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x00024860 File Offset: 0x00022A60
		public Vector2 target
		{
			get
			{
				Vector2 result;
				this.INTERNAL_get_target(out result);
				return result;
			}
		}

		// Token: 0x06001D6E RID: 7534
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_target(out Vector2 value);
	}
}
