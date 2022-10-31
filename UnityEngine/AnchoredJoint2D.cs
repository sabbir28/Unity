using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200018D RID: 397
	public class AnchoredJoint2D : Joint2D
	{
		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x00024740 File Offset: 0x00022940
		// (set) Token: 0x06001D2D RID: 7469 RVA: 0x00024760 File Offset: 0x00022960
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

		// Token: 0x06001D2E RID: 7470
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_anchor(out Vector2 value);

		// Token: 0x06001D2F RID: 7471
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_anchor(ref Vector2 value);

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06001D30 RID: 7472 RVA: 0x0002476C File Offset: 0x0002296C
		// (set) Token: 0x06001D31 RID: 7473 RVA: 0x0002478C File Offset: 0x0002298C
		public Vector2 connectedAnchor
		{
			get
			{
				Vector2 result;
				this.INTERNAL_get_connectedAnchor(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_connectedAnchor(ref value);
			}
		}

		// Token: 0x06001D32 RID: 7474
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_connectedAnchor(out Vector2 value);

		// Token: 0x06001D33 RID: 7475
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_connectedAnchor(ref Vector2 value);

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06001D34 RID: 7476
		// (set) Token: 0x06001D35 RID: 7477
		public extern bool autoConfigureConnectedAnchor { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
