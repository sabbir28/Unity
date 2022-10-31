using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000059 RID: 89
	public sealed class GeometryUtility
	{
		// Token: 0x060006E8 RID: 1768 RVA: 0x0000919C File Offset: 0x0000739C
		private static void Internal_ExtractPlanes(Plane[] planes, Matrix4x4 worldToProjectionMatrix)
		{
			GeometryUtility.INTERNAL_CALL_Internal_ExtractPlanes(planes, ref worldToProjectionMatrix);
		}

		// Token: 0x060006E9 RID: 1769
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_ExtractPlanes(Plane[] planes, ref Matrix4x4 worldToProjectionMatrix);

		// Token: 0x060006EA RID: 1770 RVA: 0x000091A8 File Offset: 0x000073A8
		public static bool TestPlanesAABB(Plane[] planes, Bounds bounds)
		{
			return GeometryUtility.INTERNAL_CALL_TestPlanesAABB(planes, ref bounds);
		}

		// Token: 0x060006EB RID: 1771
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_TestPlanesAABB(Plane[] planes, ref Bounds bounds);

		// Token: 0x060006EC RID: 1772 RVA: 0x000091C8 File Offset: 0x000073C8
		private static Bounds Internal_CalculateBounds(Vector3[] positions, Matrix4x4 transform)
		{
			Bounds result;
			GeometryUtility.INTERNAL_CALL_Internal_CalculateBounds(positions, ref transform, out result);
			return result;
		}

		// Token: 0x060006ED RID: 1773
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_CalculateBounds(Vector3[] positions, ref Matrix4x4 transform, out Bounds value);

		// Token: 0x060006EE RID: 1774 RVA: 0x000091E8 File Offset: 0x000073E8
		public static Plane[] CalculateFrustumPlanes(Camera camera)
		{
			return GeometryUtility.CalculateFrustumPlanes(camera.projectionMatrix * camera.worldToCameraMatrix);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00009214 File Offset: 0x00007414
		public static Plane[] CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix)
		{
			Plane[] array = new Plane[6];
			GeometryUtility.Internal_ExtractPlanes(array, worldToProjectionMatrix);
			return array;
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00009238 File Offset: 0x00007438
		public static Bounds CalculateBounds(Vector3[] positions, Matrix4x4 transform)
		{
			if (positions == null)
			{
				throw new ArgumentNullException("positions");
			}
			if (positions.Length == 0)
			{
				throw new ArgumentException("Zero-sized array is not allowed.", "positions");
			}
			return GeometryUtility.Internal_CalculateBounds(positions, transform);
		}
	}
}
