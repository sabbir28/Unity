using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000229 RID: 553
	[UsedByNativeCode]
	public sealed class Terrain : Behaviour
	{
		// Token: 0x06002550 RID: 9552
		[RequiredByNativeCode]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern TerrainData GetTerrainDataInternal();

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06002551 RID: 9553
		// (set) Token: 0x06002552 RID: 9554
		public extern TerrainData terrainData { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06002553 RID: 9555
		// (set) Token: 0x06002554 RID: 9556
		public extern float treeDistance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06002555 RID: 9557
		// (set) Token: 0x06002556 RID: 9558
		public extern float treeBillboardDistance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06002557 RID: 9559
		// (set) Token: 0x06002558 RID: 9560
		public extern float treeCrossFadeLength { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06002559 RID: 9561
		// (set) Token: 0x0600255A RID: 9562
		public extern int treeMaximumFullLODCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x0600255B RID: 9563
		// (set) Token: 0x0600255C RID: 9564
		public extern float detailObjectDistance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x0600255D RID: 9565
		// (set) Token: 0x0600255E RID: 9566
		public extern float detailObjectDensity { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x0600255F RID: 9567
		// (set) Token: 0x06002560 RID: 9568
		public extern float heightmapPixelError { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06002561 RID: 9569
		// (set) Token: 0x06002562 RID: 9570
		public extern int heightmapMaximumLOD { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06002563 RID: 9571
		// (set) Token: 0x06002564 RID: 9572
		public extern float basemapDistance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06002565 RID: 9573 RVA: 0x0002AD94 File Offset: 0x00028F94
		// (set) Token: 0x06002566 RID: 9574 RVA: 0x0002ADB0 File Offset: 0x00028FB0
		[Obsolete("use basemapDistance", true)]
		public float splatmapDistance
		{
			get
			{
				return this.basemapDistance;
			}
			set
			{
				this.basemapDistance = value;
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06002567 RID: 9575
		// (set) Token: 0x06002568 RID: 9576
		public extern int lightmapIndex { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06002569 RID: 9577
		// (set) Token: 0x0600256A RID: 9578
		public extern int realtimeLightmapIndex { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x0600256B RID: 9579 RVA: 0x0002ADBC File Offset: 0x00028FBC
		// (set) Token: 0x0600256C RID: 9580 RVA: 0x0002ADDC File Offset: 0x00028FDC
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

		// Token: 0x0600256D RID: 9581
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_lightmapScaleOffset(out Vector4 value);

		// Token: 0x0600256E RID: 9582
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_lightmapScaleOffset(ref Vector4 value);

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x0600256F RID: 9583 RVA: 0x0002ADE8 File Offset: 0x00028FE8
		// (set) Token: 0x06002570 RID: 9584 RVA: 0x0002AE08 File Offset: 0x00029008
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

		// Token: 0x06002571 RID: 9585
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_realtimeLightmapScaleOffset(out Vector4 value);

		// Token: 0x06002572 RID: 9586
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_realtimeLightmapScaleOffset(ref Vector4 value);

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06002573 RID: 9587
		// (set) Token: 0x06002574 RID: 9588
		public extern bool castShadows { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06002575 RID: 9589
		// (set) Token: 0x06002576 RID: 9590
		public extern ReflectionProbeUsage reflectionProbeUsage { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002577 RID: 9591
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetClosestReflectionProbesInternal(object result);

		// Token: 0x06002578 RID: 9592 RVA: 0x0002AE14 File Offset: 0x00029014
		public void GetClosestReflectionProbes(List<ReflectionProbeBlendInfo> result)
		{
			this.GetClosestReflectionProbesInternal(result);
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06002579 RID: 9593
		// (set) Token: 0x0600257A RID: 9594
		public extern Terrain.MaterialType materialType { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x0600257B RID: 9595
		// (set) Token: 0x0600257C RID: 9596
		public extern Material materialTemplate { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x0600257D RID: 9597 RVA: 0x0002AE20 File Offset: 0x00029020
		// (set) Token: 0x0600257E RID: 9598 RVA: 0x0002AE40 File Offset: 0x00029040
		public Color legacySpecular
		{
			get
			{
				Color result;
				this.INTERNAL_get_legacySpecular(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_legacySpecular(ref value);
			}
		}

		// Token: 0x0600257F RID: 9599
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_legacySpecular(out Color value);

		// Token: 0x06002580 RID: 9600
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_legacySpecular(ref Color value);

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06002581 RID: 9601
		// (set) Token: 0x06002582 RID: 9602
		public extern float legacyShininess { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06002583 RID: 9603
		// (set) Token: 0x06002584 RID: 9604
		public extern bool drawHeightmap { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06002585 RID: 9605
		// (set) Token: 0x06002586 RID: 9606
		public extern bool drawTreesAndFoliage { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002587 RID: 9607 RVA: 0x0002AE4C File Offset: 0x0002904C
		public float SampleHeight(Vector3 worldPosition)
		{
			return Terrain.INTERNAL_CALL_SampleHeight(this, ref worldPosition);
		}

		// Token: 0x06002588 RID: 9608
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float INTERNAL_CALL_SampleHeight(Terrain self, ref Vector3 worldPosition);

		// Token: 0x06002589 RID: 9609
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ApplyDelayedHeightmapModification();

		// Token: 0x0600258A RID: 9610 RVA: 0x0002AE6C File Offset: 0x0002906C
		public void AddTreeInstance(TreeInstance instance)
		{
			Terrain.INTERNAL_CALL_AddTreeInstance(this, ref instance);
		}

		// Token: 0x0600258B RID: 9611
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AddTreeInstance(Terrain self, ref TreeInstance instance);

		// Token: 0x0600258C RID: 9612
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom);

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x0600258D RID: 9613
		// (set) Token: 0x0600258E RID: 9614
		public extern float treeLODBiasMultiplier { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x0600258F RID: 9615
		// (set) Token: 0x06002590 RID: 9616
		public extern bool collectDetailPatches { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06002591 RID: 9617
		// (set) Token: 0x06002592 RID: 9618
		public extern TerrainRenderFlags editorRenderFlags { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002593 RID: 9619 RVA: 0x0002AE78 File Offset: 0x00029078
		public Vector3 GetPosition()
		{
			Vector3 result;
			Terrain.INTERNAL_CALL_GetPosition(this, out result);
			return result;
		}

		// Token: 0x06002594 RID: 9620
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetPosition(Terrain self, out Vector3 value);

		// Token: 0x06002595 RID: 9621
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Flush();

		// Token: 0x06002596 RID: 9622 RVA: 0x0002AE98 File Offset: 0x00029098
		internal void RemoveTrees(Vector2 position, float radius, int prototypeIndex)
		{
			Terrain.INTERNAL_CALL_RemoveTrees(this, ref position, radius, prototypeIndex);
		}

		// Token: 0x06002597 RID: 9623
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_RemoveTrees(Terrain self, ref Vector2 position, float radius, int prototypeIndex);

		// Token: 0x06002598 RID: 9624
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetSplatMaterialPropertyBlock(MaterialPropertyBlock properties);

		// Token: 0x06002599 RID: 9625 RVA: 0x0002AEA8 File Offset: 0x000290A8
		public void GetSplatMaterialPropertyBlock(MaterialPropertyBlock dest)
		{
			if (dest == null)
			{
				throw new ArgumentNullException("dest");
			}
			this.Internal_GetSplatMaterialPropertyBlock(dest);
		}

		// Token: 0x0600259A RID: 9626
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_GetSplatMaterialPropertyBlock(MaterialPropertyBlock dest);

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x0600259B RID: 9627
		public static extern Terrain activeTerrain { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x0600259C RID: 9628
		public static extern Terrain[] activeTerrains { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600259D RID: 9629
		[UsedByNativeCode]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern GameObject CreateTerrainGameObject(TerrainData assignTerrain);

		// Token: 0x0200022A RID: 554
		public enum MaterialType
		{
			// Token: 0x04000669 RID: 1641
			BuiltInStandard,
			// Token: 0x0400066A RID: 1642
			BuiltInLegacyDiffuse,
			// Token: 0x0400066B RID: 1643
			BuiltInLegacySpecular,
			// Token: 0x0400066C RID: 1644
			Custom
		}
	}
}
