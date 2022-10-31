using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200015D RID: 349
	[RequireComponent(typeof(Rigidbody))]
	[NativeClass("Unity::Joint")]
	public class Joint : Component
	{
		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001949 RID: 6473
		// (set) Token: 0x0600194A RID: 6474
		public extern Rigidbody connectedBody { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x0600194B RID: 6475 RVA: 0x00020048 File Offset: 0x0001E248
		// (set) Token: 0x0600194C RID: 6476 RVA: 0x00020068 File Offset: 0x0001E268
		public Vector3 axis
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_axis(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_axis(ref value);
			}
		}

		// Token: 0x0600194D RID: 6477
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_axis(out Vector3 value);

		// Token: 0x0600194E RID: 6478
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_axis(ref Vector3 value);

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x0600194F RID: 6479 RVA: 0x00020074 File Offset: 0x0001E274
		// (set) Token: 0x06001950 RID: 6480 RVA: 0x00020094 File Offset: 0x0001E294
		public Vector3 anchor
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_anchor(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_anchor(ref value);
			}
		}

		// Token: 0x06001951 RID: 6481
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_anchor(out Vector3 value);

		// Token: 0x06001952 RID: 6482
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_anchor(ref Vector3 value);

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001953 RID: 6483 RVA: 0x000200A0 File Offset: 0x0001E2A0
		// (set) Token: 0x06001954 RID: 6484 RVA: 0x000200C0 File Offset: 0x0001E2C0
		public Vector3 connectedAnchor
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_connectedAnchor(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_connectedAnchor(ref value);
			}
		}

		// Token: 0x06001955 RID: 6485
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_connectedAnchor(out Vector3 value);

		// Token: 0x06001956 RID: 6486
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_connectedAnchor(ref Vector3 value);

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001957 RID: 6487
		// (set) Token: 0x06001958 RID: 6488
		public extern bool autoConfigureConnectedAnchor { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001959 RID: 6489
		// (set) Token: 0x0600195A RID: 6490
		public extern float breakForce { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x0600195B RID: 6491
		// (set) Token: 0x0600195C RID: 6492
		public extern float breakTorque { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x0600195D RID: 6493
		// (set) Token: 0x0600195E RID: 6494
		public extern bool enableCollision { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x0600195F RID: 6495
		// (set) Token: 0x06001960 RID: 6496
		public extern bool enablePreprocessing { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001961 RID: 6497 RVA: 0x000200CC File Offset: 0x0001E2CC
		public Vector3 currentForce
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_currentForce(out result);
				return result;
			}
		}

		// Token: 0x06001962 RID: 6498
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_currentForce(out Vector3 value);

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001963 RID: 6499 RVA: 0x000200EC File Offset: 0x0001E2EC
		public Vector3 currentTorque
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_currentTorque(out result);
				return result;
			}
		}

		// Token: 0x06001964 RID: 6500
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_currentTorque(out Vector3 value);
	}
}
