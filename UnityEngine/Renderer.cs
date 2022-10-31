using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000049 RID: 73
	[RequireComponent(typeof(Transform))]
	public class Renderer : Component
	{
		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600053B RID: 1339
		// (set) Token: 0x0600053C RID: 1340
		internal extern Transform staticBatchRootTransform { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600053D RID: 1341
		internal extern int staticBatchIndex { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600053E RID: 1342
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetStaticBatchInfo(int firstSubMesh, int subMeshCount);

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600053F RID: 1343
		public extern bool isPartOfStaticBatch { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x0000778C File Offset: 0x0000598C
		public Matrix4x4 worldToLocalMatrix
		{
			get
			{
				Matrix4x4 result;
				this.INTERNAL_get_worldToLocalMatrix(out result);
				return result;
			}
		}

		// Token: 0x06000541 RID: 1345
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_worldToLocalMatrix(out Matrix4x4 value);

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x000077AC File Offset: 0x000059AC
		public Matrix4x4 localToWorldMatrix
		{
			get
			{
				Matrix4x4 result;
				this.INTERNAL_get_localToWorldMatrix(out result);
				return result;
			}
		}

		// Token: 0x06000543 RID: 1347
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_localToWorldMatrix(out Matrix4x4 value);

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000544 RID: 1348
		// (set) Token: 0x06000545 RID: 1349
		public extern bool enabled { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000546 RID: 1350
		// (set) Token: 0x06000547 RID: 1351
		public extern ShadowCastingMode shadowCastingMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000548 RID: 1352
		// (set) Token: 0x06000549 RID: 1353
		public extern bool receiveShadows { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600054A RID: 1354
		// (set) Token: 0x0600054B RID: 1355
		public extern Material material { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600054C RID: 1356
		// (set) Token: 0x0600054D RID: 1357
		public extern Material sharedMaterial { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600054E RID: 1358
		// (set) Token: 0x0600054F RID: 1359
		public extern Material[] materials { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000550 RID: 1360
		// (set) Token: 0x06000551 RID: 1361
		public extern Material[] sharedMaterials { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x000077CC File Offset: 0x000059CC
		public Bounds bounds
		{
			get
			{
				Bounds result;
				this.INTERNAL_get_bounds(out result);
				return result;
			}
		}

		// Token: 0x06000553 RID: 1363
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_bounds(out Bounds value);

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000554 RID: 1364
		// (set) Token: 0x06000555 RID: 1365
		public extern int lightmapIndex { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000556 RID: 1366
		// (set) Token: 0x06000557 RID: 1367
		public extern int realtimeLightmapIndex { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x000077EC File Offset: 0x000059EC
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x0000780C File Offset: 0x00005A0C
		public Vector4 lightmapScaleOffset
		{
			get
			{
				Vector4 result;
				this.INTERNAL_get_lightmapScaleOffset(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_lightmapScaleOffset(ref value);
			}
		}

		// Token: 0x0600055A RID: 1370
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_lightmapScaleOffset(out Vector4 value);

		// Token: 0x0600055B RID: 1371
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_lightmapScaleOffset(ref Vector4 value);

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600055C RID: 1372
		// (set) Token: 0x0600055D RID: 1373
		public extern MotionVectorGenerationMode motionVectorGenerationMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x00007818 File Offset: 0x00005A18
		// (set) Token: 0x0600055F RID: 1375 RVA: 0x00007838 File Offset: 0x00005A38
		public Vector4 realtimeLightmapScaleOffset
		{
			get
			{
				Vector4 result;
				this.INTERNAL_get_realtimeLightmapScaleOffset(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_realtimeLightmapScaleOffset(ref value);
			}
		}

		// Token: 0x06000560 RID: 1376
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_realtimeLightmapScaleOffset(out Vector4 value);

		// Token: 0x06000561 RID: 1377
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_realtimeLightmapScaleOffset(ref Vector4 value);

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000562 RID: 1378
		public extern bool isVisible { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000563 RID: 1379
		// (set) Token: 0x06000564 RID: 1380
		public extern LightProbeUsage lightProbeUsage { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000565 RID: 1381
		// (set) Token: 0x06000566 RID: 1382
		public extern GameObject lightProbeProxyVolumeOverride { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000567 RID: 1383
		// (set) Token: 0x06000568 RID: 1384
		public extern Transform probeAnchor { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000569 RID: 1385
		// (set) Token: 0x0600056A RID: 1386
		public extern ReflectionProbeUsage reflectionProbeUsage { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x0600056B RID: 1387
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetPropertyBlock(MaterialPropertyBlock properties);

		// Token: 0x0600056C RID: 1388
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void GetPropertyBlock(MaterialPropertyBlock dest);

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600056D RID: 1389
		// (set) Token: 0x0600056E RID: 1390
		public extern string sortingLayerName { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600056F RID: 1391
		// (set) Token: 0x06000570 RID: 1392
		public extern int sortingLayerID { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000571 RID: 1393
		// (set) Token: 0x06000572 RID: 1394
		public extern int sortingOrder { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000573 RID: 1395
		internal extern int sortingGroupID { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000574 RID: 1396
		internal extern int sortingGroupOrder { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000575 RID: 1397
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetClosestReflectionProbesInternal(object result);

		// Token: 0x06000576 RID: 1398 RVA: 0x00007844 File Offset: 0x00005A44
		public void GetClosestReflectionProbes(List<ReflectionProbeBlendInfo> result)
		{
			this.GetClosestReflectionProbesInternal(result);
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x00007850 File Offset: 0x00005A50
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x00007874 File Offset: 0x00005A74
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use shadowCastingMode instead.", false)]
		public bool castShadows
		{
			get
			{
				return this.shadowCastingMode != ShadowCastingMode.Off;
			}
			set
			{
				this.shadowCastingMode = ((!value) ? ShadowCastingMode.Off : ShadowCastingMode.On);
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0000788C File Offset: 0x00005A8C
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x000078AC File Offset: 0x00005AAC
		[Obsolete("Use motionVectorGenerationMode instead.", false)]
		public bool motionVectors
		{
			get
			{
				return this.motionVectorGenerationMode == MotionVectorGenerationMode.Object;
			}
			set
			{
				this.motionVectorGenerationMode = ((!value) ? MotionVectorGenerationMode.Camera : MotionVectorGenerationMode.Object);
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x000078C4 File Offset: 0x00005AC4
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x000078E8 File Offset: 0x00005AE8
		[Obsolete("Use lightProbeUsage instead.", false)]
		public bool useLightProbes
		{
			get
			{
				return this.lightProbeUsage != LightProbeUsage.Off;
			}
			set
			{
				this.lightProbeUsage = ((!value) ? LightProbeUsage.Off : LightProbeUsage.BlendProbes);
			}
		}
	}
}
