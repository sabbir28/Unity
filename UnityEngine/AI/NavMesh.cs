using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI
{
	// Token: 0x020001A7 RID: 423
	[MovedFrom("UnityEngine")]
	public static class NavMesh
	{
		// Token: 0x06001E82 RID: 7810 RVA: 0x00024DAC File Offset: 0x00022FAC
		// Method marked as required by native code, meaning it must be present for the code to function correctly.
		[RequiredByNativeCode]
		// A private static method called internally to trigger the NavMesh pre-update event.
		private static void Internal_CallOnNavMeshPreUpdate()
		{
			// Check if there are any subscribers to the onPreUpdate event.
			if (NavMesh.onPreUpdate != null)
			{
				// Invoke the onPreUpdate event.
				NavMesh.onPreUpdate();
			}
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x00024DC4 File Offset: 0x00022FC4
		public static bool Raycast(Vector3 sourcePosition, Vector3 targetPosition, out NavMeshHit hit, int areaMask)
		{
			return NavMesh.INTERNAL_CALL_Raycast(ref sourcePosition, ref targetPosition, out hit, areaMask);
		}

		// Token: 0x06001E84 RID: 7812
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Raycast(ref Vector3 sourcePosition, ref Vector3 targetPosition, out NavMeshHit hit, int areaMask);

		// Token: 0x06001E85 RID: 7813 RVA: 0x00024DE4 File Offset: 0x00022FE4
		public static bool CalculatePath(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path)
		{
			path.ClearCorners();
			return NavMesh.CalculatePathInternal(sourcePosition, targetPosition, areaMask, path);
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x00024E08 File Offset: 0x00023008
		internal static bool CalculatePathInternal(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path)
		{
			return NavMesh.INTERNAL_CALL_CalculatePathInternal(ref sourcePosition, ref targetPosition, areaMask, path);
		}

		// Token: 0x06001E87 RID: 7815
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_CalculatePathInternal(ref Vector3 sourcePosition, ref Vector3 targetPosition, int areaMask, NavMeshPath path);

		// Token: 0x06001E88 RID: 7816 RVA: 0x00024E28 File Offset: 0x00023028
		public static bool FindClosestEdge(Vector3 sourcePosition, out NavMeshHit hit, int areaMask)
		{
			return NavMesh.INTERNAL_CALL_FindClosestEdge(ref sourcePosition, out hit, areaMask);
		}

		// Token: 0x06001E89 RID: 7817
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_FindClosestEdge(ref Vector3 sourcePosition, out NavMeshHit hit, int areaMask);

		// Token: 0x06001E8A RID: 7818 RVA: 0x00024E48 File Offset: 0x00023048
		public static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask)
		{
			return NavMesh.INTERNAL_CALL_SamplePosition(ref sourcePosition, out hit, maxDistance, areaMask);
		}

		// Token: 0x06001E8B RID: 7819
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_SamplePosition(ref Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask);

		// Token: 0x06001E8C RID: 7820
		[Obsolete("Use SetAreaCost instead.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetLayerCost(int layer, float cost);

		// Token: 0x06001E8D RID: 7821
		[Obsolete("Use GetAreaCost instead.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetLayerCost(int layer);

		// Token: 0x06001E8E RID: 7822
		[Obsolete("Use GetAreaFromName instead.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetNavMeshLayerFromName(string layerName);

		// Token: 0x06001E8F RID: 7823
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetAreaCost(int areaIndex, float cost);

		// Token: 0x06001E90 RID: 7824
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetAreaCost(int areaIndex);

		// Token: 0x06001E91 RID: 7825
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetAreaFromName(string areaName);

		// Token: 0x06001E92 RID: 7826 RVA: 0x00024E68 File Offset: 0x00023068
		public static NavMeshTriangulation CalculateTriangulation()
		{
			return (NavMeshTriangulation)NavMesh.TriangulateInternal();
		}

		// Token: 0x06001E93 RID: 7827
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern object TriangulateInternal();

		// Token: 0x06001E94 RID: 7828
		[Obsolete("use NavMesh.CalculateTriangulation () instead.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Triangulate(out Vector3[] vertices, out int[] indices);

		// Token: 0x06001E95 RID: 7829
		[Obsolete("AddOffMeshLinks has no effect and is deprecated.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void AddOffMeshLinks();

		// Token: 0x06001E96 RID: 7830
		[Obsolete("RestoreNavMesh has no effect and is deprecated.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RestoreNavMesh();

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06001E97 RID: 7831 RVA: 0x00024E8C File Offset: 0x0002308C
		// (set) Token: 0x06001E98 RID: 7832 RVA: 0x00024EA8 File Offset: 0x000230A8
		public static float avoidancePredictionTime
		{
			get
			{
				return NavMesh.GetAvoidancePredictionTime();
			}
			set
			{
				NavMesh.SetAvoidancePredictionTime(value);
			}
		}

		// Token: 0x06001E99 RID: 7833
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void SetAvoidancePredictionTime(float t);

		// Token: 0x06001E9A RID: 7834
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern float GetAvoidancePredictionTime();

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06001E9B RID: 7835 RVA: 0x00024EB4 File Offset: 0x000230B4
		// (set) Token: 0x06001E9C RID: 7836 RVA: 0x00024ED0 File Offset: 0x000230D0
		public static int pathfindingIterationsPerFrame
		{
			get
			{
				return NavMesh.GetPathfindingIterationsPerFrame();
			}
			set
			{
				NavMesh.SetPathfindingIterationsPerFrame(value);
			}
		}

		// Token: 0x06001E9D RID: 7837
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void SetPathfindingIterationsPerFrame(int iter);

		// Token: 0x06001E9E RID: 7838
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetPathfindingIterationsPerFrame();

		// Token: 0x06001E9F RID: 7839 RVA: 0x00024EDC File Offset: 0x000230DC
		public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData)
		{
			if (navMeshData == null)
			{
				throw new ArgumentNullException("navMeshData");
			}
			return new NavMeshDataInstance
			{
				id = NavMesh.AddNavMeshDataInternal(navMeshData)
			};
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x00024F20 File Offset: 0x00023120
		public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData, Vector3 position, Quaternion rotation)
		{
			if (navMeshData == null)
			{
				throw new ArgumentNullException("navMeshData");
			}
			return new NavMeshDataInstance
			{
				id = NavMesh.AddNavMeshDataTransformedInternal(navMeshData, position, rotation)
			};
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x00024F64 File Offset: 0x00023164
		public static void RemoveNavMeshData(NavMeshDataInstance handle)
		{
			NavMesh.RemoveNavMeshDataInternal(handle.id);
		}

		// Token: 0x06001EA2 RID: 7842
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IsValidNavMeshDataHandle(int handle);

		// Token: 0x06001EA3 RID: 7843
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IsValidLinkHandle(int handle);

		// Token: 0x06001EA4 RID: 7844
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Object InternalGetOwner(int dataID);

		// Token: 0x06001EA5 RID: 7845
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool InternalSetOwner(int dataID, int ownerID);

		// Token: 0x06001EA6 RID: 7846
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Object InternalGetLinkOwner(int linkID);

		// Token: 0x06001EA7 RID: 7847
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool InternalSetLinkOwner(int linkID, int ownerID);

		// Token: 0x06001EA8 RID: 7848
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int AddNavMeshDataInternal(NavMeshData navMeshData);

		// Token: 0x06001EA9 RID: 7849 RVA: 0x00024F74 File Offset: 0x00023174
		internal static int AddNavMeshDataTransformedInternal(NavMeshData navMeshData, Vector3 position, Quaternion rotation)
		{
			return NavMesh.INTERNAL_CALL_AddNavMeshDataTransformedInternal(navMeshData, ref position, ref rotation);
		}

		// Token: 0x06001EAA RID: 7850
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_AddNavMeshDataTransformedInternal(NavMeshData navMeshData, ref Vector3 position, ref Quaternion rotation);

		// Token: 0x06001EAB RID: 7851
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void RemoveNavMeshDataInternal(int handle);

		// Token: 0x06001EAC RID: 7852 RVA: 0x00024F94 File Offset: 0x00023194
		public static NavMeshLinkInstance AddLink(NavMeshLinkData link)
		{
			return new NavMeshLinkInstance
			{
				id = NavMesh.AddLinkInternal(link, Vector3.zero, Quaternion.identity)
			};
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x00024FCC File Offset: 0x000231CC
		public static NavMeshLinkInstance AddLink(NavMeshLinkData link, Vector3 position, Quaternion rotation)
		{
			return new NavMeshLinkInstance
			{
				id = NavMesh.AddLinkInternal(link, position, rotation)
			};
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x00024FFC File Offset: 0x000231FC
		public static void RemoveLink(NavMeshLinkInstance handle)
		{
			NavMesh.RemoveLinkInternal(handle.id);
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x0002500C File Offset: 0x0002320C
		internal static int AddLinkInternal(NavMeshLinkData link, Vector3 position, Quaternion rotation)
		{
			return NavMesh.INTERNAL_CALL_AddLinkInternal(ref link, ref position, ref rotation);
		}

		// Token: 0x06001EB0 RID: 7856
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_AddLinkInternal(ref NavMeshLinkData link, ref Vector3 position, ref Quaternion rotation);

		// Token: 0x06001EB1 RID: 7857
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void RemoveLinkInternal(int handle);

		// Token: 0x06001EB2 RID: 7858 RVA: 0x0002502C File Offset: 0x0002322C
		public static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, NavMeshQueryFilter filter)
		{
			return NavMesh.SamplePositionFilter(sourcePosition, out hit, maxDistance, filter.agentTypeID, filter.areaMask);
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x00025058 File Offset: 0x00023258
		private static bool SamplePositionFilter(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int type, int mask)
		{
			return NavMesh.INTERNAL_CALL_SamplePositionFilter(ref sourcePosition, out hit, maxDistance, type, mask);
		}

		// Token: 0x06001EB4 RID: 7860
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_SamplePositionFilter(ref Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int type, int mask);

		// Token: 0x06001EB5 RID: 7861 RVA: 0x0002507C File Offset: 0x0002327C
		public static bool FindClosestEdge(Vector3 sourcePosition, out NavMeshHit hit, NavMeshQueryFilter filter)
		{
			return NavMesh.FindClosestEdgeFilter(sourcePosition, out hit, filter.agentTypeID, filter.areaMask);
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x000250A8 File Offset: 0x000232A8
		private static bool FindClosestEdgeFilter(Vector3 sourcePosition, out NavMeshHit hit, int type, int mask)
		{
			return NavMesh.INTERNAL_CALL_FindClosestEdgeFilter(ref sourcePosition, out hit, type, mask);
		}

		// Token: 0x06001EB7 RID: 7863
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_FindClosestEdgeFilter(ref Vector3 sourcePosition, out NavMeshHit hit, int type, int mask);

		// Token: 0x06001EB8 RID: 7864 RVA: 0x000250C8 File Offset: 0x000232C8
		public static bool Raycast(Vector3 sourcePosition, Vector3 targetPosition, out NavMeshHit hit, NavMeshQueryFilter filter)
		{
			return NavMesh.RaycastFilter(sourcePosition, targetPosition, out hit, filter.agentTypeID, filter.areaMask);
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x000250F4 File Offset: 0x000232F4
		private static bool RaycastFilter(Vector3 sourcePosition, Vector3 targetPosition, out NavMeshHit hit, int type, int mask)
		{
			return NavMesh.INTERNAL_CALL_RaycastFilter(ref sourcePosition, ref targetPosition, out hit, type, mask);
		}

		// Token: 0x06001EBA RID: 7866
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_RaycastFilter(ref Vector3 sourcePosition, ref Vector3 targetPosition, out NavMeshHit hit, int type, int mask);

		// Token: 0x06001EBB RID: 7867 RVA: 0x00025118 File Offset: 0x00023318
		public static bool CalculatePath(Vector3 sourcePosition, Vector3 targetPosition, NavMeshQueryFilter filter, NavMeshPath path)
		{
			path.ClearCorners();
			return NavMesh.CalculatePathFilterInternal(sourcePosition, targetPosition, path, filter.agentTypeID, filter.areaMask, filter.costs);
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x00025150 File Offset: 0x00023350
		internal static bool CalculatePathFilterInternal(Vector3 sourcePosition, Vector3 targetPosition, NavMeshPath path, int type, int mask, float[] costs)
		{
			return NavMesh.INTERNAL_CALL_CalculatePathFilterInternal(ref sourcePosition, ref targetPosition, path, type, mask, costs);
		}

		// Token: 0x06001EBD RID: 7869
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_CalculatePathFilterInternal(ref Vector3 sourcePosition, ref Vector3 targetPosition, NavMeshPath path, int type, int mask, float[] costs);

		// Token: 0x06001EBE RID: 7870 RVA: 0x00025174 File Offset: 0x00023374
		public static NavMeshBuildSettings CreateSettings()
		{
			NavMeshBuildSettings result;
			NavMesh.INTERNAL_CALL_CreateSettings(out result);
			return result;
		}

		// Token: 0x06001EBF RID: 7871
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_CreateSettings(out NavMeshBuildSettings value);

		// Token: 0x06001EC0 RID: 7872
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RemoveSettings(int agentTypeID);

		// Token: 0x06001EC1 RID: 7873 RVA: 0x00025194 File Offset: 0x00023394
		public static NavMeshBuildSettings GetSettingsByID(int agentTypeID)
		{
			NavMeshBuildSettings result;
			NavMesh.INTERNAL_CALL_GetSettingsByID(agentTypeID, out result);
			return result;
		}

		// Token: 0x06001EC2 RID: 7874
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetSettingsByID(int agentTypeID, out NavMeshBuildSettings value);

		// Token: 0x06001EC3 RID: 7875
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetSettingsCount();

		// Token: 0x06001EC4 RID: 7876 RVA: 0x000251B4 File Offset: 0x000233B4
		public static NavMeshBuildSettings GetSettingsByIndex(int index)
		{
			NavMeshBuildSettings result;
			NavMesh.INTERNAL_CALL_GetSettingsByIndex(index, out result);
			return result;
		}

		// Token: 0x06001EC5 RID: 7877
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetSettingsByIndex(int index, out NavMeshBuildSettings value);

		// Token: 0x06001EC6 RID: 7878
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string GetSettingsNameFromID(int agentTypeID);

		// Token: 0x04000468 RID: 1128
		public static NavMesh.OnNavMeshPreUpdate onPreUpdate;

		// Token: 0x04000469 RID: 1129
		public const int AllAreas = -1;

		// Token: 0x020001A8 RID: 424
		// (Invoke) Token: 0x06001EC8 RID: 7880
		public delegate void OnNavMeshPreUpdate();
	}
}
