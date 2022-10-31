using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200015A RID: 346
	public class Physics
	{
		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x0001E370 File Offset: 0x0001C570
		// (set) Token: 0x060017FC RID: 6140 RVA: 0x0001E390 File Offset: 0x0001C590
		[ThreadAndSerializationSafe]
		public static Vector3 gravity
		{
			get
			{
				Vector3 result;
				Physics.INTERNAL_get_gravity(out result);
				return result;
			}
			set
			{
				Physics.INTERNAL_set_gravity(ref value);
			}
		}

		// Token: 0x060017FD RID: 6141
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_gravity(out Vector3 value);

		// Token: 0x060017FE RID: 6142
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_gravity(ref Vector3 value);

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x060017FF RID: 6143
		// (set) Token: 0x06001800 RID: 6144
		[Obsolete("use Physics.defaultContactOffset or Collider.contactOffset instead.", true)]
		public static extern float minPenetrationForPenalty { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001801 RID: 6145
		// (set) Token: 0x06001802 RID: 6146
		public static extern float defaultContactOffset { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001803 RID: 6147
		// (set) Token: 0x06001804 RID: 6148
		public static extern float bounceThreshold { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001805 RID: 6149 RVA: 0x0001E39C File Offset: 0x0001C59C
		// (set) Token: 0x06001806 RID: 6150 RVA: 0x0001E3B8 File Offset: 0x0001C5B8
		[Obsolete("Please use bounceThreshold instead.")]
		public static float bounceTreshold
		{
			get
			{
				return Physics.bounceThreshold;
			}
			set
			{
				Physics.bounceThreshold = value;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001807 RID: 6151
		// (set) Token: 0x06001808 RID: 6152
		[Obsolete("The sleepVelocity is no longer supported. Use sleepThreshold. Note that sleepThreshold is energy but not velocity.")]
		public static extern float sleepVelocity { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001809 RID: 6153
		// (set) Token: 0x0600180A RID: 6154
		[Obsolete("The sleepAngularVelocity is no longer supported. Use sleepThreshold. Note that sleepThreshold is energy but not velocity.")]
		public static extern float sleepAngularVelocity { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x0600180B RID: 6155
		// (set) Token: 0x0600180C RID: 6156
		[Obsolete("use Rigidbody.maxAngularVelocity instead.", true)]
		public static extern float maxAngularVelocity { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x0600180D RID: 6157
		// (set) Token: 0x0600180E RID: 6158
		public static extern int defaultSolverIterations { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x0600180F RID: 6159 RVA: 0x0001E3C4 File Offset: 0x0001C5C4
		// (set) Token: 0x06001810 RID: 6160 RVA: 0x0001E3E0 File Offset: 0x0001C5E0
		[Obsolete("Please use Physics.defaultSolverIterations instead. (UnityUpgradable) -> defaultSolverIterations")]
		public static int solverIterationCount
		{
			get
			{
				return Physics.defaultSolverIterations;
			}
			set
			{
				Physics.defaultSolverIterations = value;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001811 RID: 6161
		// (set) Token: 0x06001812 RID: 6162
		public static extern int defaultSolverVelocityIterations { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001813 RID: 6163 RVA: 0x0001E3EC File Offset: 0x0001C5EC
		// (set) Token: 0x06001814 RID: 6164 RVA: 0x0001E408 File Offset: 0x0001C608
		[Obsolete("Please use Physics.defaultSolverVelocityIterations instead. (UnityUpgradable) -> defaultSolverVelocityIterations")]
		public static int solverVelocityIterationCount
		{
			get
			{
				return Physics.defaultSolverVelocityIterations;
			}
			set
			{
				Physics.defaultSolverVelocityIterations = value;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001815 RID: 6165
		// (set) Token: 0x06001816 RID: 6166
		public static extern float sleepThreshold { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001817 RID: 6167
		// (set) Token: 0x06001818 RID: 6168
		public static extern bool queriesHitTriggers { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001819 RID: 6169
		// (set) Token: 0x0600181A RID: 6170
		public static extern bool queriesHitBackfaces { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x0600181B RID: 6171 RVA: 0x0001E414 File Offset: 0x0001C614
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.Raycast(origin, direction, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x0001E438 File Offset: 0x0001C638
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			return Physics.Raycast(origin, direction, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x0001E45C File Offset: 0x0001C65C
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics.Raycast(origin, direction, positiveInfinity, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x0001E488 File Offset: 0x0001C688
		public static bool Raycast(Vector3 origin, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.Internal_RaycastTest(origin, direction, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x0001E4A8 File Offset: 0x0001C6A8
		[RequiredByNativeCode]
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.Raycast(origin, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x0001E4CC File Offset: 0x0001C6CC
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			return Physics.Raycast(origin, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x0001E4F4 File Offset: 0x0001C6F4
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics.Raycast(origin, direction, out hitInfo, positiveInfinity, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x0001E520 File Offset: 0x0001C720
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.Internal_Raycast(origin, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x0001E544 File Offset: 0x0001C744
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, float maxDistance, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.Raycast(ray, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x0001E564 File Offset: 0x0001C764
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			return Physics.Raycast(ray, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x0001E588 File Offset: 0x0001C788
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics.Raycast(ray, positiveInfinity, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x0001E5B4 File Offset: 0x0001C7B4
		public static bool Raycast(Ray ray, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.Raycast(ray.origin, ray.direction, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x0001E5E0 File Offset: 0x0001C7E0
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.Raycast(ray, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x0001E604 File Offset: 0x0001C804
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			return Physics.Raycast(ray, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x0001E628 File Offset: 0x0001C828
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, out RaycastHit hitInfo)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics.Raycast(ray, out hitInfo, positiveInfinity, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x0001E654 File Offset: 0x0001C854
		public static bool Raycast(Ray ray, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.Raycast(ray.origin, ray.direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x0001E684 File Offset: 0x0001C884
		[RequiredByNativeCode]
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.RaycastAll(ray, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x0001E6A4 File Offset: 0x0001C8A4
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Ray ray, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			return Physics.RaycastAll(ray, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x0001E6C8 File Offset: 0x0001C8C8
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Ray ray)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics.RaycastAll(ray, positiveInfinity, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x0001E6F4 File Offset: 0x0001C8F4
		public static RaycastHit[] RaycastAll(Ray ray, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.RaycastAll(ray.origin, ray.direction, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x0001E720 File Offset: 0x0001C920
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layermask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.INTERNAL_CALL_RaycastAll(ref origin, ref direction, maxDistance, layermask, queryTriggerInteraction);
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x0001E744 File Offset: 0x0001C944
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layermask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.INTERNAL_CALL_RaycastAll(ref origin, ref direction, maxDistance, layermask, queryTriggerInteraction);
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x0001E768 File Offset: 0x0001C968
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layermask = -5;
			return Physics.INTERNAL_CALL_RaycastAll(ref origin, ref direction, maxDistance, layermask, queryTriggerInteraction);
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x0001E790 File Offset: 0x0001C990
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layermask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics.INTERNAL_CALL_RaycastAll(ref origin, ref direction, positiveInfinity, layermask, queryTriggerInteraction);
		}

		// Token: 0x06001833 RID: 6195
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RaycastHit[] INTERNAL_CALL_RaycastAll(ref Vector3 origin, ref Vector3 direction, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x06001834 RID: 6196 RVA: 0x0001E7BC File Offset: 0x0001C9BC
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.RaycastNonAlloc(ray, results, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x0001E7E0 File Offset: 0x0001C9E0
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			return Physics.RaycastNonAlloc(ray, results, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x0001E804 File Offset: 0x0001CA04
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics.RaycastNonAlloc(ray, results, positiveInfinity, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x0001E830 File Offset: 0x0001CA30
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.RaycastNonAlloc(ray.origin, ray.direction, results, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x0001E860 File Offset: 0x0001CA60
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layermask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.INTERNAL_CALL_RaycastNonAlloc(ref origin, ref direction, results, maxDistance, layermask, queryTriggerInteraction);
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x0001E884 File Offset: 0x0001CA84
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layermask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.INTERNAL_CALL_RaycastNonAlloc(ref origin, ref direction, results, maxDistance, layermask, queryTriggerInteraction);
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x0001E8AC File Offset: 0x0001CAAC
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layermask = -5;
			return Physics.INTERNAL_CALL_RaycastNonAlloc(ref origin, ref direction, results, maxDistance, layermask, queryTriggerInteraction);
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x0001E8D4 File Offset: 0x0001CAD4
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layermask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics.INTERNAL_CALL_RaycastNonAlloc(ref origin, ref direction, results, positiveInfinity, layermask, queryTriggerInteraction);
		}

		// Token: 0x0600183C RID: 6204
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_RaycastNonAlloc(ref Vector3 origin, ref Vector3 direction, RaycastHit[] results, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x0600183D RID: 6205 RVA: 0x0001E904 File Offset: 0x0001CB04
		[ExcludeFromDocs]
		public static bool Linecast(Vector3 start, Vector3 end, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.Linecast(start, end, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x0001E924 File Offset: 0x0001CB24
		[ExcludeFromDocs]
		public static bool Linecast(Vector3 start, Vector3 end)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			return Physics.Linecast(start, end, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x0001E948 File Offset: 0x0001CB48
		public static bool Linecast(Vector3 start, Vector3 end, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			Vector3 direction = end - start;
			return Physics.Raycast(start, direction, direction.magnitude, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x0001E978 File Offset: 0x0001CB78
		[ExcludeFromDocs]
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.Linecast(start, end, out hitInfo, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x0001E99C File Offset: 0x0001CB9C
		[ExcludeFromDocs]
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			return Physics.Linecast(start, end, out hitInfo, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x0001E9C0 File Offset: 0x0001CBC0
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			Vector3 direction = end - start;
			return Physics.Raycast(start, direction, out hitInfo, direction.magnitude, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x0001E9F0 File Offset: 0x0001CBF0
		public static Collider[] OverlapSphere(Vector3 position, float radius, [DefaultValue("AllLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.INTERNAL_CALL_OverlapSphere(ref position, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x0001EA10 File Offset: 0x0001CC10
		[ExcludeFromDocs]
		public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.INTERNAL_CALL_OverlapSphere(ref position, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x0001EA34 File Offset: 0x0001CC34
		[ExcludeFromDocs]
		public static Collider[] OverlapSphere(Vector3 position, float radius)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -1;
			return Physics.INTERNAL_CALL_OverlapSphere(ref position, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001846 RID: 6214
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Collider[] INTERNAL_CALL_OverlapSphere(ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x06001847 RID: 6215 RVA: 0x0001EA58 File Offset: 0x0001CC58
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, [DefaultValue("AllLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.INTERNAL_CALL_OverlapSphereNonAlloc(ref position, radius, results, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x0001EA7C File Offset: 0x0001CC7C
		[ExcludeFromDocs]
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.INTERNAL_CALL_OverlapSphereNonAlloc(ref position, radius, results, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x0001EAA0 File Offset: 0x0001CCA0
		[ExcludeFromDocs]
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -1;
			return Physics.INTERNAL_CALL_OverlapSphereNonAlloc(ref position, radius, results, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600184A RID: 6218
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_OverlapSphereNonAlloc(ref Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x0600184B RID: 6219 RVA: 0x0001EAC4 File Offset: 0x0001CCC4
		public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius, [DefaultValue("AllLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.INTERNAL_CALL_OverlapCapsule(ref point0, ref point1, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x0001EAE8 File Offset: 0x0001CCE8
		[ExcludeFromDocs]
		public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.INTERNAL_CALL_OverlapCapsule(ref point0, ref point1, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x0001EB0C File Offset: 0x0001CD0C
		[ExcludeFromDocs]
		public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -1;
			return Physics.INTERNAL_CALL_OverlapCapsule(ref point0, ref point1, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600184E RID: 6222
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Collider[] INTERNAL_CALL_OverlapCapsule(ref Vector3 point0, ref Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x0600184F RID: 6223 RVA: 0x0001EB34 File Offset: 0x0001CD34
		public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, [DefaultValue("AllLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.INTERNAL_CALL_OverlapCapsuleNonAlloc(ref point0, ref point1, radius, results, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x0001EB58 File Offset: 0x0001CD58
		[ExcludeFromDocs]
		public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.INTERNAL_CALL_OverlapCapsuleNonAlloc(ref point0, ref point1, radius, results, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x0001EB80 File Offset: 0x0001CD80
		[ExcludeFromDocs]
		public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -1;
			return Physics.INTERNAL_CALL_OverlapCapsuleNonAlloc(ref point0, ref point1, radius, results, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001852 RID: 6226
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_OverlapCapsuleNonAlloc(ref Vector3 point0, ref Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x06001853 RID: 6227 RVA: 0x0001EBA8 File Offset: 0x0001CDA8
		[ExcludeFromDocs]
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x0001EBD0 File Offset: 0x0001CDD0
		[ExcludeFromDocs]
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			return Physics.CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x0001EBF8 File Offset: 0x0001CDF8
		[ExcludeFromDocs]
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics.CapsuleCast(point1, point2, radius, direction, positiveInfinity, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x0001EC24 File Offset: 0x0001CE24
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			RaycastHit raycastHit;
			return Physics.Internal_CapsuleCast(point1, point2, radius, direction, out raycastHit, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x0001EC4C File Offset: 0x0001CE4C
		[ExcludeFromDocs]
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.CapsuleCast(point1, point2, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x0001EC74 File Offset: 0x0001CE74
		[ExcludeFromDocs]
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			return Physics.CapsuleCast(point1, point2, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x0001ECA0 File Offset: 0x0001CEA0
		[ExcludeFromDocs]
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics.CapsuleCast(point1, point2, radius, direction, out hitInfo, positiveInfinity, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x0001ECD0 File Offset: 0x0001CED0
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.Internal_CapsuleCast(point1, point2, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x0001ECF8 File Offset: 0x0001CEF8
		[ExcludeFromDocs]
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.SphereCast(origin, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x0001ED20 File Offset: 0x0001CF20
		[ExcludeFromDocs]
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			return Physics.SphereCast(origin, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x0001ED48 File Offset: 0x0001CF48
		[ExcludeFromDocs]
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics.SphereCast(origin, radius, direction, out hitInfo, positiveInfinity, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x0001ED74 File Offset: 0x0001CF74
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.Internal_CapsuleCast(origin, origin, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x0001ED9C File Offset: 0x0001CF9C
		[ExcludeFromDocs]
		public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.SphereCast(ray, radius, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x0001EDC0 File Offset: 0x0001CFC0
		[ExcludeFromDocs]
		public static bool SphereCast(Ray ray, float radius, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			return Physics.SphereCast(ray, radius, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x0001EDE4 File Offset: 0x0001CFE4
		[ExcludeFromDocs]
		public static bool SphereCast(Ray ray, float radius)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics.SphereCast(ray, radius, positiveInfinity, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x0001EE10 File Offset: 0x0001D010
		public static bool SphereCast(Ray ray, float radius, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			RaycastHit raycastHit;
			return Physics.Internal_CapsuleCast(ray.origin, ray.origin, radius, ray.direction, out raycastHit, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x0001EE48 File Offset: 0x0001D048
		[ExcludeFromDocs]
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.SphereCast(ray, radius, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x0001EE6C File Offset: 0x0001D06C
		[ExcludeFromDocs]
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			return Physics.SphereCast(ray, radius, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x0001EE94 File Offset: 0x0001D094
		[ExcludeFromDocs]
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics.SphereCast(ray, radius, out hitInfo, positiveInfinity, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x0001EEC0 File Offset: 0x0001D0C0
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.Internal_CapsuleCast(ray.origin, ray.origin, radius, ray.direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x0001EEF8 File Offset: 0x0001D0F8
		public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layermask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.INTERNAL_CALL_CapsuleCastAll(ref point1, ref point2, radius, ref direction, maxDistance, layermask, queryTriggerInteraction);
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x0001EF20 File Offset: 0x0001D120
		[ExcludeFromDocs]
		public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layermask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.INTERNAL_CALL_CapsuleCastAll(ref point1, ref point2, radius, ref direction, maxDistance, layermask, queryTriggerInteraction);
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x0001EF48 File Offset: 0x0001D148
		[ExcludeFromDocs]
		public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layermask = -5;
			return Physics.INTERNAL_CALL_CapsuleCastAll(ref point1, ref point2, radius, ref direction, maxDistance, layermask, queryTriggerInteraction);
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x0001EF74 File Offset: 0x0001D174
		[ExcludeFromDocs]
		public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layermask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics.INTERNAL_CALL_CapsuleCastAll(ref point1, ref point2, radius, ref direction, positiveInfinity, layermask, queryTriggerInteraction);
		}

		// Token: 0x0600186B RID: 6251
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RaycastHit[] INTERNAL_CALL_CapsuleCastAll(ref Vector3 point1, ref Vector3 point2, float radius, ref Vector3 direction, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x0600186C RID: 6252 RVA: 0x0001EFA4 File Offset: 0x0001D1A4
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layermask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.INTERNAL_CALL_CapsuleCastNonAlloc(ref point1, ref point2, radius, ref direction, results, maxDistance, layermask, queryTriggerInteraction);
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x0001EFD0 File Offset: 0x0001D1D0
		[ExcludeFromDocs]
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layermask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.INTERNAL_CALL_CapsuleCastNonAlloc(ref point1, ref point2, radius, ref direction, results, maxDistance, layermask, queryTriggerInteraction);
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x0001EFFC File Offset: 0x0001D1FC
		[ExcludeFromDocs]
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layermask = -5;
			return Physics.INTERNAL_CALL_CapsuleCastNonAlloc(ref point1, ref point2, radius, ref direction, results, maxDistance, layermask, queryTriggerInteraction);
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x0001F028 File Offset: 0x0001D228
		[ExcludeFromDocs]
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layermask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics.INTERNAL_CALL_CapsuleCastNonAlloc(ref point1, ref point2, radius, ref direction, results, positiveInfinity, layermask, queryTriggerInteraction);
		}

		// Token: 0x06001870 RID: 6256
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_CapsuleCastNonAlloc(ref Vector3 point1, ref Vector3 point2, float radius, ref Vector3 direction, RaycastHit[] results, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x06001871 RID: 6257 RVA: 0x0001F05C File Offset: 0x0001D25C
		[ExcludeFromDocs]
		public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.SphereCastAll(origin, radius, direction, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x0001F080 File Offset: 0x0001D280
		[ExcludeFromDocs]
		public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			return Physics.SphereCastAll(origin, radius, direction, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x0001F0A8 File Offset: 0x0001D2A8
		[ExcludeFromDocs]
		public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics.SphereCastAll(origin, radius, direction, positiveInfinity, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x0001F0D4 File Offset: 0x0001D2D4
		public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CapsuleCastAll(origin, origin, radius, direction, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x0001F0F8 File Offset: 0x0001D2F8
		[ExcludeFromDocs]
		public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.SphereCastAll(ray, radius, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x0001F11C File Offset: 0x0001D31C
		[ExcludeFromDocs]
		public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			return Physics.SphereCastAll(ray, radius, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x0001F140 File Offset: 0x0001D340
		[ExcludeFromDocs]
		public static RaycastHit[] SphereCastAll(Ray ray, float radius)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics.SphereCastAll(ray, radius, positiveInfinity, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x0001F16C File Offset: 0x0001D36C
		public static RaycastHit[] SphereCastAll(Ray ray, float radius, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CapsuleCastAll(ray.origin, ray.origin, radius, ray.direction, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x0001F1A0 File Offset: 0x0001D3A0
		[ExcludeFromDocs]
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.SphereCastNonAlloc(origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x0001F1C8 File Offset: 0x0001D3C8
		[ExcludeFromDocs]
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			return Physics.SphereCastNonAlloc(origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x0001F1F0 File Offset: 0x0001D3F0
		[ExcludeFromDocs]
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics.SphereCastNonAlloc(origin, radius, direction, results, positiveInfinity, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x0001F21C File Offset: 0x0001D41C
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CapsuleCastNonAlloc(origin, origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x0001F244 File Offset: 0x0001D444
		[ExcludeFromDocs]
		public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.SphereCastNonAlloc(ray, radius, results, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x0001F268 File Offset: 0x0001D468
		[ExcludeFromDocs]
		public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			return Physics.SphereCastNonAlloc(ray, radius, results, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x0001F290 File Offset: 0x0001D490
		[ExcludeFromDocs]
		public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics.SphereCastNonAlloc(ray, radius, results, positiveInfinity, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x0001F2BC File Offset: 0x0001D4BC
		public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CapsuleCastNonAlloc(ray.origin, ray.origin, radius, ray.direction, results, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x0001F2F4 File Offset: 0x0001D4F4
		public static bool CheckSphere(Vector3 position, float radius, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.INTERNAL_CALL_CheckSphere(ref position, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x0001F314 File Offset: 0x0001D514
		[ExcludeFromDocs]
		public static bool CheckSphere(Vector3 position, float radius, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.INTERNAL_CALL_CheckSphere(ref position, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x0001F338 File Offset: 0x0001D538
		[ExcludeFromDocs]
		public static bool CheckSphere(Vector3 position, float radius)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			return Physics.INTERNAL_CALL_CheckSphere(ref position, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001884 RID: 6276
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_CheckSphere(ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x06001885 RID: 6277 RVA: 0x0001F35C File Offset: 0x0001D55C
		public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, [DefaultValue("DefaultRaycastLayers")] int layermask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.INTERNAL_CALL_CheckCapsule(ref start, ref end, radius, layermask, queryTriggerInteraction);
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x0001F380 File Offset: 0x0001D580
		[ExcludeFromDocs]
		public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layermask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.INTERNAL_CALL_CheckCapsule(ref start, ref end, radius, layermask, queryTriggerInteraction);
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x0001F3A4 File Offset: 0x0001D5A4
		[ExcludeFromDocs]
		public static bool CheckCapsule(Vector3 start, Vector3 end, float radius)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layermask = -5;
			return Physics.INTERNAL_CALL_CheckCapsule(ref start, ref end, radius, layermask, queryTriggerInteraction);
		}

		// Token: 0x06001888 RID: 6280
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_CheckCapsule(ref Vector3 start, ref Vector3 end, float radius, int layermask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x06001889 RID: 6281 RVA: 0x0001F3CC File Offset: 0x0001D5CC
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("DefaultRaycastLayers")] int layermask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.INTERNAL_CALL_CheckBox(ref center, ref halfExtents, ref orientation, layermask, queryTriggerInteraction);
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x0001F3F0 File Offset: 0x0001D5F0
		[ExcludeFromDocs]
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.INTERNAL_CALL_CheckBox(ref center, ref halfExtents, ref orientation, layermask, queryTriggerInteraction);
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x0001F414 File Offset: 0x0001D614
		[ExcludeFromDocs]
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layermask = -5;
			return Physics.INTERNAL_CALL_CheckBox(ref center, ref halfExtents, ref orientation, layermask, queryTriggerInteraction);
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x0001F43C File Offset: 0x0001D63C
		[ExcludeFromDocs]
		public static bool CheckBox(Vector3 center, Vector3 halfExtents)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layermask = -5;
			Quaternion identity = Quaternion.identity;
			return Physics.INTERNAL_CALL_CheckBox(ref center, ref halfExtents, ref identity, layermask, queryTriggerInteraction);
		}

		// Token: 0x0600188D RID: 6285
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_CheckBox(ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x0600188E RID: 6286 RVA: 0x0001F46C File Offset: 0x0001D66C
		public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("AllLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.INTERNAL_CALL_OverlapBox(ref center, ref halfExtents, ref orientation, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x0001F490 File Offset: 0x0001D690
		[ExcludeFromDocs]
		public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.INTERNAL_CALL_OverlapBox(ref center, ref halfExtents, ref orientation, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x0001F4B4 File Offset: 0x0001D6B4
		[ExcludeFromDocs]
		public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -1;
			return Physics.INTERNAL_CALL_OverlapBox(ref center, ref halfExtents, ref orientation, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x0001F4DC File Offset: 0x0001D6DC
		[ExcludeFromDocs]
		public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -1;
			Quaternion identity = Quaternion.identity;
			return Physics.INTERNAL_CALL_OverlapBox(ref center, ref halfExtents, ref identity, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001892 RID: 6290
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Collider[] INTERNAL_CALL_OverlapBox(ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x06001893 RID: 6291 RVA: 0x0001F508 File Offset: 0x0001D708
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("AllLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.INTERNAL_CALL_OverlapBoxNonAlloc(ref center, ref halfExtents, results, ref orientation, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x0001F530 File Offset: 0x0001D730
		[ExcludeFromDocs]
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.INTERNAL_CALL_OverlapBoxNonAlloc(ref center, ref halfExtents, results, ref orientation, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x0001F558 File Offset: 0x0001D758
		[ExcludeFromDocs]
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -1;
			return Physics.INTERNAL_CALL_OverlapBoxNonAlloc(ref center, ref halfExtents, results, ref orientation, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x0001F580 File Offset: 0x0001D780
		[ExcludeFromDocs]
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -1;
			Quaternion identity = Quaternion.identity;
			return Physics.INTERNAL_CALL_OverlapBoxNonAlloc(ref center, ref halfExtents, results, ref identity, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06001897 RID: 6295
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_OverlapBoxNonAlloc(ref Vector3 center, ref Vector3 halfExtents, Collider[] results, ref Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x06001898 RID: 6296 RVA: 0x0001F5B0 File Offset: 0x0001D7B0
		public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layermask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.INTERNAL_CALL_BoxCastAll(ref center, ref halfExtents, ref direction, ref orientation, maxDistance, layermask, queryTriggerInteraction);
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x0001F5D8 File Offset: 0x0001D7D8
		[ExcludeFromDocs]
		public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layermask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.INTERNAL_CALL_BoxCastAll(ref center, ref halfExtents, ref direction, ref orientation, maxDistance, layermask, queryTriggerInteraction);
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x0001F604 File Offset: 0x0001D804
		[ExcludeFromDocs]
		public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layermask = -5;
			return Physics.INTERNAL_CALL_BoxCastAll(ref center, ref halfExtents, ref direction, ref orientation, maxDistance, layermask, queryTriggerInteraction);
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x0001F630 File Offset: 0x0001D830
		[ExcludeFromDocs]
		public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layermask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics.INTERNAL_CALL_BoxCastAll(ref center, ref halfExtents, ref direction, ref orientation, positiveInfinity, layermask, queryTriggerInteraction);
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x0001F660 File Offset: 0x0001D860
		[ExcludeFromDocs]
		public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layermask = -5;
			float positiveInfinity = float.PositiveInfinity;
			Quaternion identity = Quaternion.identity;
			return Physics.INTERNAL_CALL_BoxCastAll(ref center, ref halfExtents, ref direction, ref identity, positiveInfinity, layermask, queryTriggerInteraction);
		}

		// Token: 0x0600189D RID: 6301
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RaycastHit[] INTERNAL_CALL_BoxCastAll(ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, ref Quaternion orientation, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x0600189E RID: 6302 RVA: 0x0001F698 File Offset: 0x0001D898
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layermask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.INTERNAL_CALL_BoxCastNonAlloc(ref center, ref halfExtents, ref direction, results, ref orientation, maxDistance, layermask, queryTriggerInteraction);
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0001F6C4 File Offset: 0x0001D8C4
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance, int layermask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.INTERNAL_CALL_BoxCastNonAlloc(ref center, ref halfExtents, ref direction, results, ref orientation, maxDistance, layermask, queryTriggerInteraction);
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x0001F6F0 File Offset: 0x0001D8F0
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layermask = -5;
			return Physics.INTERNAL_CALL_BoxCastNonAlloc(ref center, ref halfExtents, ref direction, results, ref orientation, maxDistance, layermask, queryTriggerInteraction);
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x0001F71C File Offset: 0x0001D91C
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layermask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics.INTERNAL_CALL_BoxCastNonAlloc(ref center, ref halfExtents, ref direction, results, ref orientation, positiveInfinity, layermask, queryTriggerInteraction);
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x0001F750 File Offset: 0x0001D950
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layermask = -5;
			float positiveInfinity = float.PositiveInfinity;
			Quaternion identity = Quaternion.identity;
			return Physics.INTERNAL_CALL_BoxCastNonAlloc(ref center, ref halfExtents, ref direction, results, ref identity, positiveInfinity, layermask, queryTriggerInteraction);
		}

		// Token: 0x060018A3 RID: 6307
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_BoxCastNonAlloc(ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, RaycastHit[] results, ref Quaternion orientation, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x060018A4 RID: 6308 RVA: 0x0001F78C File Offset: 0x0001D98C
		private static bool Internal_BoxCast(Vector3 center, Vector3 halfExtents, Quaternion orientation, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.INTERNAL_CALL_Internal_BoxCast(ref center, ref halfExtents, ref orientation, ref direction, out hitInfo, maxDistance, layermask, queryTriggerInteraction);
		}

		// Token: 0x060018A5 RID: 6309
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Internal_BoxCast(ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, ref Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x060018A6 RID: 6310 RVA: 0x0001F7B8 File Offset: 0x0001D9B8
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x0001F7E0 File Offset: 0x0001D9E0
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			return Physics.BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x0001F808 File Offset: 0x0001DA08
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics.BoxCast(center, halfExtents, direction, orientation, positiveInfinity, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x0001F834 File Offset: 0x0001DA34
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			float positiveInfinity = float.PositiveInfinity;
			Quaternion identity = Quaternion.identity;
			return Physics.BoxCast(center, halfExtents, direction, identity, positiveInfinity, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x0001F868 File Offset: 0x0001DA68
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			RaycastHit raycastHit;
			return Physics.Internal_BoxCast(center, halfExtents, orientation, direction, out raycastHit, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x0001F890 File Offset: 0x0001DA90
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Physics.BoxCast(center, halfExtents, direction, out hitInfo, orientation, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x0001F8B8 File Offset: 0x0001DAB8
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			return Physics.BoxCast(center, halfExtents, direction, out hitInfo, orientation, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x0001F8E4 File Offset: 0x0001DAE4
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics.BoxCast(center, halfExtents, direction, out hitInfo, orientation, positiveInfinity, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x0001F914 File Offset: 0x0001DB14
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			int layerMask = -5;
			float positiveInfinity = float.PositiveInfinity;
			Quaternion identity = Quaternion.identity;
			return Physics.BoxCast(center, halfExtents, direction, out hitInfo, identity, positiveInfinity, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x0001F94C File Offset: 0x0001DB4C
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.Internal_BoxCast(center, halfExtents, orientation, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x060018B0 RID: 6320
		// (set) Token: 0x060018B1 RID: 6321
		[Obsolete("penetrationPenaltyForce has no effect.")]
		public static extern float penetrationPenaltyForce { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060018B2 RID: 6322
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void IgnoreCollision(Collider collider1, Collider collider2, [DefaultValue("true")] bool ignore);

		// Token: 0x060018B3 RID: 6323 RVA: 0x0001F974 File Offset: 0x0001DB74
		[ExcludeFromDocs]
		public static void IgnoreCollision(Collider collider1, Collider collider2)
		{
			bool ignore = true;
			Physics.IgnoreCollision(collider1, collider2, ignore);
		}

		// Token: 0x060018B4 RID: 6324
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void IgnoreLayerCollision(int layer1, int layer2, [DefaultValue("true")] bool ignore);

		// Token: 0x060018B5 RID: 6325 RVA: 0x0001F98C File Offset: 0x0001DB8C
		[ExcludeFromDocs]
		public static void IgnoreLayerCollision(int layer1, int layer2)
		{
			bool ignore = true;
			Physics.IgnoreLayerCollision(layer1, layer2, ignore);
		}

		// Token: 0x060018B6 RID: 6326
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetIgnoreLayerCollision(int layer1, int layer2);

		// Token: 0x060018B7 RID: 6327 RVA: 0x0001F9A4 File Offset: 0x0001DBA4
		private static bool Internal_Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.INTERNAL_CALL_Internal_Raycast(ref origin, ref direction, out hitInfo, maxDistance, layermask, queryTriggerInteraction);
		}

		// Token: 0x060018B8 RID: 6328
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Internal_Raycast(ref Vector3 origin, ref Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x060018B9 RID: 6329 RVA: 0x0001F9C8 File Offset: 0x0001DBC8
		private static bool Internal_CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.INTERNAL_CALL_Internal_CapsuleCast(ref point1, ref point2, radius, ref direction, out hitInfo, maxDistance, layermask, queryTriggerInteraction);
		}

		// Token: 0x060018BA RID: 6330
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Internal_CapsuleCast(ref Vector3 point1, ref Vector3 point2, float radius, ref Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x060018BB RID: 6331 RVA: 0x0001F9F4 File Offset: 0x0001DBF4
		private static bool Internal_RaycastTest(Vector3 origin, Vector3 direction, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.INTERNAL_CALL_Internal_RaycastTest(ref origin, ref direction, maxDistance, layermask, queryTriggerInteraction);
		}

		// Token: 0x060018BC RID: 6332
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Internal_RaycastTest(ref Vector3 origin, ref Vector3 direction, float maxDistance, int layermask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x060018BD RID: 6333 RVA: 0x0001FA18 File Offset: 0x0001DC18
		public static bool ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance)
		{
			return Physics.INTERNAL_CALL_ComputePenetration(colliderA, ref positionA, ref rotationA, colliderB, ref positionB, ref rotationB, out direction, out distance);
		}

		// Token: 0x060018BE RID: 6334
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_ComputePenetration(Collider colliderA, ref Vector3 positionA, ref Quaternion rotationA, Collider colliderB, ref Vector3 positionB, ref Quaternion rotationB, out Vector3 direction, out float distance);

		// Token: 0x060018BF RID: 6335 RVA: 0x0001FA40 File Offset: 0x0001DC40
		public static Vector3 ClosestPoint(Vector3 point, Collider collider, Vector3 position, Quaternion rotation)
		{
			Vector3 result;
			Physics.INTERNAL_CALL_ClosestPoint(ref point, collider, ref position, ref rotation, out result);
			return result;
		}

		// Token: 0x060018C0 RID: 6336
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ClosestPoint(ref Vector3 point, Collider collider, ref Vector3 position, ref Quaternion rotation, out Vector3 value);

		// Token: 0x040003D4 RID: 980
		public const int IgnoreRaycastLayer = 4;

		// Token: 0x040003D5 RID: 981
		[Obsolete("Please use Physics.IgnoreRaycastLayer instead. (UnityUpgradable) -> IgnoreRaycastLayer", true)]
		public const int kIgnoreRaycastLayer = 4;

		// Token: 0x040003D6 RID: 982
		public const int DefaultRaycastLayers = -5;

		// Token: 0x040003D7 RID: 983
		[Obsolete("Please use Physics.DefaultRaycastLayers instead. (UnityUpgradable) -> DefaultRaycastLayers", true)]
		public const int kDefaultRaycastLayers = -5;

		// Token: 0x040003D8 RID: 984
		public const int AllLayers = -1;

		// Token: 0x040003D9 RID: 985
		[Obsolete("Please use Physics.AllLayers instead. (UnityUpgradable) -> AllLayers", true)]
		public const int kAllLayers = -1;
	}
}
