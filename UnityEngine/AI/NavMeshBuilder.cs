using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.AI
{
	// Token: 0x020001BF RID: 447
	public static class NavMeshBuilder
	{
		// Token: 0x06001FE6 RID: 8166 RVA: 0x00026188 File Offset: 0x00024388
		public static void CollectSources(Bounds includedWorldBounds, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results)
		{
			if (markups == null)
			{
				throw new ArgumentNullException("markups");
			}
			if (results == null)
			{
				throw new ArgumentNullException("results");
			}
			includedWorldBounds.extents = Vector3.Max(includedWorldBounds.extents, 0.001f * Vector3.one);
			NavMeshBuildSource[] collection = NavMeshBuilder.CollectSourcesInternal(includedLayerMask, includedWorldBounds, null, true, geometry, defaultArea, markups.ToArray());
			results.Clear();
			results.AddRange(collection);
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x00026200 File Offset: 0x00024400
		public static void CollectSources(Transform root, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results)
		{
			if (markups == null)
			{
				throw new ArgumentNullException("markups");
			}
			if (results == null)
			{
				throw new ArgumentNullException("results");
			}
			NavMeshBuildSource[] collection = NavMeshBuilder.CollectSourcesInternal(includedLayerMask, default(Bounds), root, false, geometry, defaultArea, markups.ToArray());
			results.Clear();
			results.AddRange(collection);
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x0002625C File Offset: 0x0002445C
		private static NavMeshBuildSource[] CollectSourcesInternal(int includedLayerMask, Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, NavMeshBuildMarkup[] markups)
		{
			return NavMeshBuilder.INTERNAL_CALL_CollectSourcesInternal(includedLayerMask, ref includedWorldBounds, root, useBounds, geometry, defaultArea, markups);
		}

		// Token: 0x06001FE9 RID: 8169
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern NavMeshBuildSource[] INTERNAL_CALL_CollectSourcesInternal(int includedLayerMask, ref Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, NavMeshBuildMarkup[] markups);

		// Token: 0x06001FEA RID: 8170 RVA: 0x00026284 File Offset: 0x00024484
		public static NavMeshData BuildNavMeshData(NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, Vector3 position, Quaternion rotation)
		{
			if (sources == null)
			{
				throw new ArgumentNullException("sources");
			}
			return NavMeshBuilder.BuildNavMeshData(buildSettings, sources, localBounds, position, rotation, default(NavMeshBuildDebugSettings));
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x000262C0 File Offset: 0x000244C0
		private static NavMeshData BuildNavMeshData(NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, Vector3 position, Quaternion rotation, NavMeshBuildDebugSettings debug)
		{
			if (sources == null)
			{
				throw new ArgumentNullException("sources");
			}
			NavMeshData navMeshData = new NavMeshData(buildSettings.agentTypeID);
			navMeshData.position = position;
			navMeshData.rotation = rotation;
			NavMeshBuilder.UpdateNavMeshDataListInternal(navMeshData, buildSettings, sources, localBounds, debug);
			return navMeshData;
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x00026310 File Offset: 0x00024510
		public static bool UpdateNavMeshData(NavMeshData data, NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			if (sources == null)
			{
				throw new ArgumentNullException("sources");
			}
			return NavMeshBuilder.UpdateNavMeshData(data, buildSettings, sources, localBounds, default(NavMeshBuildDebugSettings));
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x00026360 File Offset: 0x00024560
		private static bool UpdateNavMeshData(NavMeshData data, NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, NavMeshBuildDebugSettings debug)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			if (sources == null)
			{
				throw new ArgumentNullException("sources");
			}
			return NavMeshBuilder.UpdateNavMeshDataListInternal(data, buildSettings, sources, localBounds, debug);
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x000263A8 File Offset: 0x000245A8
		private static bool UpdateNavMeshDataListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds, NavMeshBuildDebugSettings debug)
		{
			return NavMeshBuilder.INTERNAL_CALL_UpdateNavMeshDataListInternal(data, ref buildSettings, sources, ref localBounds, ref debug);
		}

		// Token: 0x06001FEF RID: 8175
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_UpdateNavMeshDataListInternal(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds, ref NavMeshBuildDebugSettings debug);

		// Token: 0x06001FF0 RID: 8176 RVA: 0x000263CC File Offset: 0x000245CC
		public static AsyncOperation UpdateNavMeshDataAsync(NavMeshData data, NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			if (sources == null)
			{
				throw new ArgumentNullException("sources");
			}
			return NavMeshBuilder.UpdateNavMeshDataAsync(data, buildSettings, sources, localBounds, default(NavMeshBuildDebugSettings));
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x0002641C File Offset: 0x0002461C
		private static AsyncOperation UpdateNavMeshDataAsync(NavMeshData data, NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, NavMeshBuildDebugSettings debug)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			if (sources == null)
			{
				throw new ArgumentNullException("sources");
			}
			return NavMeshBuilder.UpdateNavMeshDataAsyncListInternal(data, buildSettings, sources, localBounds, debug);
		}

		// Token: 0x06001FF2 RID: 8178
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Cancel(NavMeshData data);

		// Token: 0x06001FF3 RID: 8179 RVA: 0x00026464 File Offset: 0x00024664
		private static AsyncOperation UpdateNavMeshDataAsyncListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds, NavMeshBuildDebugSettings debug)
		{
			return NavMeshBuilder.INTERNAL_CALL_UpdateNavMeshDataAsyncListInternal(data, ref buildSettings, sources, ref localBounds, ref debug);
		}

		// Token: 0x06001FF4 RID: 8180
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AsyncOperation INTERNAL_CALL_UpdateNavMeshDataAsyncListInternal(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds, ref NavMeshBuildDebugSettings debug);
	}
}
