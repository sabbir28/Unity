using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000167 RID: 359
	[RequireComponent(typeof(Transform))]
	public class Collider : Component
	{
		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001A20 RID: 6688
		// (set) Token: 0x06001A21 RID: 6689
		public extern bool enabled { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001A22 RID: 6690
		public extern Rigidbody attachedRigidbody { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001A23 RID: 6691
		// (set) Token: 0x06001A24 RID: 6692
		public extern bool isTrigger { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001A25 RID: 6693
		// (set) Token: 0x06001A26 RID: 6694
		public extern float contactOffset { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001A27 RID: 6695
		// (set) Token: 0x06001A28 RID: 6696
		public extern PhysicMaterial material { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06001A29 RID: 6697 RVA: 0x000206F0 File Offset: 0x0001E8F0
		public Vector3 ClosestPointOnBounds(Vector3 position)
		{
			Vector3 result;
			Collider.INTERNAL_CALL_ClosestPointOnBounds(this, ref position, out result);
			return result;
		}

		// Token: 0x06001A2A RID: 6698
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ClosestPointOnBounds(Collider self, ref Vector3 position, out Vector3 value);

		// Token: 0x06001A2B RID: 6699 RVA: 0x00020710 File Offset: 0x0001E910
		public Vector3 ClosestPoint(Vector3 position)
		{
			Vector3 result;
			Collider.INTERNAL_CALL_ClosestPoint(this, ref position, out result);
			return result;
		}

		// Token: 0x06001A2C RID: 6700
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ClosestPoint(Collider self, ref Vector3 position, out Vector3 value);

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001A2D RID: 6701
		// (set) Token: 0x06001A2E RID: 6702
		public extern PhysicMaterial sharedMaterial { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001A2F RID: 6703 RVA: 0x00020730 File Offset: 0x0001E930
		public Bounds bounds
		{
			get
			{
				Bounds result;
				this.INTERNAL_get_bounds(out result);
				return result;
			}
		}

		// Token: 0x06001A30 RID: 6704
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_bounds(out Bounds value);

		// Token: 0x06001A31 RID: 6705 RVA: 0x00020750 File Offset: 0x0001E950
		private static bool Internal_Raycast(Collider col, Ray ray, out RaycastHit hitInfo, float maxDistance)
		{
			return Collider.INTERNAL_CALL_Internal_Raycast(col, ref ray, out hitInfo, maxDistance);
		}

		// Token: 0x06001A32 RID: 6706
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Internal_Raycast(Collider col, ref Ray ray, out RaycastHit hitInfo, float maxDistance);

		// Token: 0x06001A33 RID: 6707 RVA: 0x00020770 File Offset: 0x0001E970
		public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance)
		{
			return Collider.Internal_Raycast(this, ray, out hitInfo, maxDistance);
		}
	}
}
