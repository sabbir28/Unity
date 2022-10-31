using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI
{
	// Token: 0x020001B1 RID: 433
	[MovedFrom("UnityEngine")]
	public sealed class NavMeshAgent : Behaviour
	{
		// Token: 0x06001F05 RID: 7941 RVA: 0x00025750 File Offset: 0x00023950
		public bool SetDestination(Vector3 target)
		{
			return NavMeshAgent.INTERNAL_CALL_SetDestination(this, ref target);
		}

		// Token: 0x06001F06 RID: 7942
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_SetDestination(NavMeshAgent self, ref Vector3 target);

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06001F07 RID: 7943 RVA: 0x00025770 File Offset: 0x00023970
		// (set) Token: 0x06001F08 RID: 7944 RVA: 0x00025790 File Offset: 0x00023990
		public Vector3 destination
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_destination(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_destination(ref value);
			}
		}

		// Token: 0x06001F09 RID: 7945
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_destination(out Vector3 value);

		// Token: 0x06001F0A RID: 7946
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_destination(ref Vector3 value);

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06001F0B RID: 7947
		// (set) Token: 0x06001F0C RID: 7948
		public extern float stoppingDistance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06001F0D RID: 7949 RVA: 0x0002579C File Offset: 0x0002399C
		// (set) Token: 0x06001F0E RID: 7950 RVA: 0x000257BC File Offset: 0x000239BC
		public Vector3 velocity
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_velocity(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_velocity(ref value);
			}
		}

		// Token: 0x06001F0F RID: 7951
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_velocity(out Vector3 value);

		// Token: 0x06001F10 RID: 7952
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_velocity(ref Vector3 value);

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06001F11 RID: 7953 RVA: 0x000257C8 File Offset: 0x000239C8
		// (set) Token: 0x06001F12 RID: 7954 RVA: 0x000257E8 File Offset: 0x000239E8
		public Vector3 nextPosition
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_nextPosition(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_nextPosition(ref value);
			}
		}

		// Token: 0x06001F13 RID: 7955
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_nextPosition(out Vector3 value);

		// Token: 0x06001F14 RID: 7956
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_nextPosition(ref Vector3 value);

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06001F15 RID: 7957 RVA: 0x000257F4 File Offset: 0x000239F4
		public Vector3 steeringTarget
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_steeringTarget(out result);
				return result;
			}
		}

		// Token: 0x06001F16 RID: 7958
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_steeringTarget(out Vector3 value);

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06001F17 RID: 7959 RVA: 0x00025814 File Offset: 0x00023A14
		public Vector3 desiredVelocity
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_desiredVelocity(out result);
				return result;
			}
		}

		// Token: 0x06001F18 RID: 7960
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_desiredVelocity(out Vector3 value);

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06001F19 RID: 7961
		public extern float remainingDistance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06001F1A RID: 7962
		// (set) Token: 0x06001F1B RID: 7963
		public extern float baseOffset { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06001F1C RID: 7964
		public extern bool isOnOffMeshLink { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06001F1D RID: 7965
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ActivateCurrentOffMeshLink(bool activated);

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06001F1E RID: 7966 RVA: 0x00025834 File Offset: 0x00023A34
		public OffMeshLinkData currentOffMeshLinkData
		{
			get
			{
				return this.GetCurrentOffMeshLinkDataInternal();
			}
		}

		// Token: 0x06001F1F RID: 7967
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern OffMeshLinkData GetCurrentOffMeshLinkDataInternal();

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06001F20 RID: 7968 RVA: 0x00025850 File Offset: 0x00023A50
		public OffMeshLinkData nextOffMeshLinkData
		{
			get
			{
				return this.GetNextOffMeshLinkDataInternal();
			}
		}

		// Token: 0x06001F21 RID: 7969
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern OffMeshLinkData GetNextOffMeshLinkDataInternal();

		// Token: 0x06001F22 RID: 7970
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void CompleteOffMeshLink();

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06001F23 RID: 7971
		// (set) Token: 0x06001F24 RID: 7972
		public extern bool autoTraverseOffMeshLink { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06001F25 RID: 7973
		// (set) Token: 0x06001F26 RID: 7974
		public extern bool autoBraking { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06001F27 RID: 7975
		// (set) Token: 0x06001F28 RID: 7976
		public extern bool autoRepath { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06001F29 RID: 7977
		public extern bool hasPath { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06001F2A RID: 7978
		public extern bool pathPending { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06001F2B RID: 7979
		public extern bool isPathStale { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06001F2C RID: 7980
		public extern NavMeshPathStatus pathStatus { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06001F2D RID: 7981 RVA: 0x0002586C File Offset: 0x00023A6C
		public Vector3 pathEndPosition
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_pathEndPosition(out result);
				return result;
			}
		}

		// Token: 0x06001F2E RID: 7982
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_pathEndPosition(out Vector3 value);

		// Token: 0x06001F2F RID: 7983 RVA: 0x0002588C File Offset: 0x00023A8C
		public bool Warp(Vector3 newPosition)
		{
			return NavMeshAgent.INTERNAL_CALL_Warp(this, ref newPosition);
		}

		// Token: 0x06001F30 RID: 7984
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Warp(NavMeshAgent self, ref Vector3 newPosition);

		// Token: 0x06001F31 RID: 7985 RVA: 0x000258AC File Offset: 0x00023AAC
		public void Move(Vector3 offset)
		{
			NavMeshAgent.INTERNAL_CALL_Move(this, ref offset);
		}

		// Token: 0x06001F32 RID: 7986
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Move(NavMeshAgent self, ref Vector3 offset);

		// Token: 0x06001F33 RID: 7987 RVA: 0x000258B8 File Offset: 0x00023AB8
		[Obsolete("Set isStopped to true instead")]
		public void Stop()
		{
			this.StopInternal();
		}

		// Token: 0x06001F34 RID: 7988
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void StopInternal();

		// Token: 0x06001F35 RID: 7989 RVA: 0x000258C4 File Offset: 0x00023AC4
		[Obsolete("Set isStopped to true instead")]
		public void Stop(bool stopUpdates)
		{
			this.StopInternal();
		}

		// Token: 0x06001F36 RID: 7990
		[Obsolete("Set isStopped to false instead")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Resume();

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06001F37 RID: 7991
		// (set) Token: 0x06001F38 RID: 7992
		public extern bool isStopped { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06001F39 RID: 7993
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ResetPath();

		// Token: 0x06001F3A RID: 7994
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool SetPath(NavMeshPath path);

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06001F3B RID: 7995 RVA: 0x000258D0 File Offset: 0x00023AD0
		// (set) Token: 0x06001F3C RID: 7996 RVA: 0x000258F4 File Offset: 0x00023AF4
		public NavMeshPath path
		{
			get
			{
				NavMeshPath navMeshPath = new NavMeshPath();
				this.CopyPathTo(navMeshPath);
				return navMeshPath;
			}
			set
			{
				if (value == null)
				{
					throw new NullReferenceException();
				}
				this.SetPath(value);
			}
		}

		// Token: 0x06001F3D RID: 7997
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void CopyPathTo(NavMeshPath path);

		// Token: 0x06001F3E RID: 7998
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool FindClosestEdge(out NavMeshHit hit);

		// Token: 0x06001F3F RID: 7999 RVA: 0x0002590C File Offset: 0x00023B0C
		public bool Raycast(Vector3 targetPosition, out NavMeshHit hit)
		{
			return NavMeshAgent.INTERNAL_CALL_Raycast(this, ref targetPosition, out hit);
		}

		// Token: 0x06001F40 RID: 8000
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Raycast(NavMeshAgent self, ref Vector3 targetPosition, out NavMeshHit hit);

		// Token: 0x06001F41 RID: 8001 RVA: 0x0002592C File Offset: 0x00023B2C
		public bool CalculatePath(Vector3 targetPosition, NavMeshPath path)
		{
			path.ClearCorners();
			return this.CalculatePathInternal(targetPosition, path);
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x00025950 File Offset: 0x00023B50
		private bool CalculatePathInternal(Vector3 targetPosition, NavMeshPath path)
		{
			return NavMeshAgent.INTERNAL_CALL_CalculatePathInternal(this, ref targetPosition, path);
		}

		// Token: 0x06001F43 RID: 8003
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_CalculatePathInternal(NavMeshAgent self, ref Vector3 targetPosition, NavMeshPath path);

		// Token: 0x06001F44 RID: 8004
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool SamplePathPosition(int areaMask, float maxDistance, out NavMeshHit hit);

		// Token: 0x06001F45 RID: 8005
		[Obsolete("Use SetAreaCost instead.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetLayerCost(int layer, float cost);

		// Token: 0x06001F46 RID: 8006
		[Obsolete("Use GetAreaCost instead.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float GetLayerCost(int layer);

		// Token: 0x06001F47 RID: 8007
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetAreaCost(int areaIndex, float areaCost);

		// Token: 0x06001F48 RID: 8008
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float GetAreaCost(int areaIndex);

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06001F49 RID: 8009 RVA: 0x00025970 File Offset: 0x00023B70
		public Object navMeshOwner
		{
			get
			{
				return this.GetOwnerInternal();
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06001F4A RID: 8010
		// (set) Token: 0x06001F4B RID: 8011
		public extern int agentTypeID { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06001F4C RID: 8012
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Object GetOwnerInternal();

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06001F4D RID: 8013
		// (set) Token: 0x06001F4E RID: 8014
		[Obsolete("Use areaMask instead.")]
		public extern int walkableMask { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06001F4F RID: 8015
		// (set) Token: 0x06001F50 RID: 8016
		public extern int areaMask { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06001F51 RID: 8017
		// (set) Token: 0x06001F52 RID: 8018
		public extern float speed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06001F53 RID: 8019
		// (set) Token: 0x06001F54 RID: 8020
		public extern float angularSpeed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001F55 RID: 8021
		// (set) Token: 0x06001F56 RID: 8022
		public extern float acceleration { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001F57 RID: 8023
		// (set) Token: 0x06001F58 RID: 8024
		public extern bool updatePosition { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06001F59 RID: 8025
		// (set) Token: 0x06001F5A RID: 8026
		public extern bool updateRotation { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06001F5B RID: 8027
		// (set) Token: 0x06001F5C RID: 8028
		public extern bool updateUpAxis { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06001F5D RID: 8029
		// (set) Token: 0x06001F5E RID: 8030
		public extern float radius { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001F5F RID: 8031
		// (set) Token: 0x06001F60 RID: 8032
		public extern float height { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001F61 RID: 8033
		// (set) Token: 0x06001F62 RID: 8034
		public extern ObstacleAvoidanceType obstacleAvoidanceType { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001F63 RID: 8035
		// (set) Token: 0x06001F64 RID: 8036
		public extern int avoidancePriority { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001F65 RID: 8037
		public extern bool isOnNavMesh { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
