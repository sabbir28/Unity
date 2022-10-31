using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000226 RID: 550
	public sealed class TerrainData : Object
	{
		// Token: 0x060024E7 RID: 9447 RVA: 0x0002A6C0 File Offset: 0x000288C0
		public TerrainData()
		{
			this.Internal_Create(this);
		}

		// Token: 0x060024E8 RID: 9448
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetMaximumResolution();

		// Token: 0x060024E9 RID: 9449
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetMinimumDetailResolutionPerPatch();

		// Token: 0x060024EA RID: 9450
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetMaximumDetailResolutionPerPatch();

		// Token: 0x060024EB RID: 9451
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetMaximumDetailPatchCount();

		// Token: 0x060024EC RID: 9452
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetMinimumAlphamapResolution();

		// Token: 0x060024ED RID: 9453
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetMaximumAlphamapResolution();

		// Token: 0x060024EE RID: 9454
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetMinimumBaseMapResolution();

		// Token: 0x060024EF RID: 9455
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetMaximumBaseMapResolution();

		// Token: 0x060024F0 RID: 9456
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void Internal_Create([Writable] TerrainData terrainData);

		// Token: 0x060024F1 RID: 9457
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern bool HasUser(GameObject user);

		// Token: 0x060024F2 RID: 9458
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void AddUser(GameObject user);

		// Token: 0x060024F3 RID: 9459
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void RemoveUser(GameObject user);

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x060024F4 RID: 9460
		public extern int heightmapWidth { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x060024F5 RID: 9461
		public extern int heightmapHeight { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x060024F6 RID: 9462 RVA: 0x0002A6D0 File Offset: 0x000288D0
		// (set) Token: 0x060024F7 RID: 9463 RVA: 0x0002A6EC File Offset: 0x000288EC
		public int heightmapResolution
		{
			get
			{
				return this.Internal_heightmapResolution;
			}
			set
			{
				int internal_heightmapResolution = value;
				if (value < 0 || value > TerrainData.kMaximumResolution)
				{
					Debug.LogWarning("heightmapResolution is clamped to the range of [0, " + TerrainData.kMaximumResolution + "].");
					internal_heightmapResolution = Math.Min(TerrainData.kMaximumResolution, Math.Max(value, 0));
				}
				this.Internal_heightmapResolution = internal_heightmapResolution;
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x060024F8 RID: 9464
		// (set) Token: 0x060024F9 RID: 9465
		private extern int Internal_heightmapResolution { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x060024FA RID: 9466 RVA: 0x0002A748 File Offset: 0x00028948
		public Vector3 heightmapScale
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_heightmapScale(out result);
				return result;
			}
		}

		// Token: 0x060024FB RID: 9467
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_heightmapScale(out Vector3 value);

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x060024FC RID: 9468 RVA: 0x0002A768 File Offset: 0x00028968
		// (set) Token: 0x060024FD RID: 9469 RVA: 0x0002A788 File Offset: 0x00028988
		public Vector3 size
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_size(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_size(ref value);
			}
		}

		// Token: 0x060024FE RID: 9470
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_size(out Vector3 value);

		// Token: 0x060024FF RID: 9471
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_size(ref Vector3 value);

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06002500 RID: 9472 RVA: 0x0002A794 File Offset: 0x00028994
		public Bounds bounds
		{
			get
			{
				Bounds result;
				this.INTERNAL_get_bounds(out result);
				return result;
			}
		}

		// Token: 0x06002501 RID: 9473
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_bounds(out Bounds value);

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06002502 RID: 9474
		// (set) Token: 0x06002503 RID: 9475
		public extern float thickness { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002504 RID: 9476
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float GetHeight(int x, int y);

		// Token: 0x06002505 RID: 9477
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float GetInterpolatedHeight(float x, float y);

		// Token: 0x06002506 RID: 9478
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float[,] GetHeights(int xBase, int yBase, int width, int height);

		// Token: 0x06002507 RID: 9479 RVA: 0x0002A7B4 File Offset: 0x000289B4
		public void SetHeights(int xBase, int yBase, float[,] heights)
		{
			if (heights == null)
			{
				throw new NullReferenceException();
			}
			if (xBase + heights.GetLength(1) > this.heightmapWidth || xBase + heights.GetLength(1) < 0 || yBase + heights.GetLength(0) < 0 || xBase < 0 || yBase < 0 || yBase + heights.GetLength(0) > this.heightmapHeight)
			{
				throw new ArgumentException(UnityString.Format("X or Y base out of bounds. Setting up to {0}x{1} while map size is {2}x{3}", new object[]
				{
					xBase + heights.GetLength(1),
					yBase + heights.GetLength(0),
					this.heightmapWidth,
					this.heightmapHeight
				}));
			}
			this.Internal_SetHeights(xBase, yBase, heights.GetLength(1), heights.GetLength(0), heights);
		}

		// Token: 0x06002508 RID: 9480
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_SetHeights(int xBase, int yBase, int width, int height, float[,] heights);

		// Token: 0x06002509 RID: 9481
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_SetHeightsDelayLOD(int xBase, int yBase, int width, int height, float[,] heights);

		// Token: 0x0600250A RID: 9482 RVA: 0x0002A890 File Offset: 0x00028A90
		public void SetHeightsDelayLOD(int xBase, int yBase, float[,] heights)
		{
			if (heights == null)
			{
				throw new ArgumentNullException("heights");
			}
			int length = heights.GetLength(0);
			int length2 = heights.GetLength(1);
			if (xBase < 0 || xBase + length2 < 0 || xBase + length2 > this.heightmapWidth)
			{
				throw new ArgumentException(UnityString.Format("X out of bounds - trying to set {0}-{1} but the terrain ranges from 0-{2}", new object[]
				{
					xBase,
					xBase + length2,
					this.heightmapWidth
				}));
			}
			if (yBase < 0 || yBase + length < 0 || yBase + length > this.heightmapHeight)
			{
				throw new ArgumentException(UnityString.Format("Y out of bounds - trying to set {0}-{1} but the terrain ranges from 0-{2}", new object[]
				{
					yBase,
					yBase + length,
					this.heightmapHeight
				}));
			}
			this.Internal_SetHeightsDelayLOD(xBase, yBase, length2, length, heights);
		}

		// Token: 0x0600250B RID: 9483
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float GetSteepness(float x, float y);

		// Token: 0x0600250C RID: 9484 RVA: 0x0002A978 File Offset: 0x00028B78
		public Vector3 GetInterpolatedNormal(float x, float y)
		{
			Vector3 result;
			TerrainData.INTERNAL_CALL_GetInterpolatedNormal(this, x, y, out result);
			return result;
		}

		// Token: 0x0600250D RID: 9485
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetInterpolatedNormal(TerrainData self, float x, float y, out Vector3 value);

		// Token: 0x0600250E RID: 9486
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern int GetAdjustedSize(int size);

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x0600250F RID: 9487
		// (set) Token: 0x06002510 RID: 9488
		public extern float wavingGrassStrength { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06002511 RID: 9489
		// (set) Token: 0x06002512 RID: 9490
		public extern float wavingGrassAmount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06002513 RID: 9491
		// (set) Token: 0x06002514 RID: 9492
		public extern float wavingGrassSpeed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06002515 RID: 9493 RVA: 0x0002A998 File Offset: 0x00028B98
		// (set) Token: 0x06002516 RID: 9494 RVA: 0x0002A9B8 File Offset: 0x00028BB8
		public Color wavingGrassTint
		{
			get
			{
				Color result;
				this.INTERNAL_get_wavingGrassTint(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_wavingGrassTint(ref value);
			}
		}

		// Token: 0x06002517 RID: 9495
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_wavingGrassTint(out Color value);

		// Token: 0x06002518 RID: 9496
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_wavingGrassTint(ref Color value);

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06002519 RID: 9497
		public extern int detailWidth { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x0600251A RID: 9498
		public extern int detailHeight { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600251B RID: 9499 RVA: 0x0002A9C4 File Offset: 0x00028BC4
		public void SetDetailResolution(int detailResolution, int resolutionPerPatch)
		{
			if (detailResolution < 0)
			{
				Debug.LogWarning("detailResolution must not be negative.");
				detailResolution = 0;
			}
			if (resolutionPerPatch < TerrainData.kMinimumDetailResolutionPerPatch || resolutionPerPatch > TerrainData.kMaximumDetailResolutionPerPatch)
			{
				Debug.LogWarning(string.Concat(new object[]
				{
					"resolutionPerPatch is clamped to the range of [",
					TerrainData.kMinimumDetailResolutionPerPatch,
					", ",
					TerrainData.kMaximumDetailResolutionPerPatch,
					"]."
				}));
				resolutionPerPatch = Math.Min(TerrainData.kMaximumDetailResolutionPerPatch, Math.Max(resolutionPerPatch, TerrainData.kMinimumDetailResolutionPerPatch));
			}
			int num = detailResolution / resolutionPerPatch;
			if (num > TerrainData.kMaximumDetailPatchCount)
			{
				Debug.LogWarning("Patch count (detailResolution / resolutionPerPatch) is clamped to the range of [0, " + TerrainData.kMaximumDetailPatchCount + "].");
				num = Math.Min(TerrainData.kMaximumDetailPatchCount, Math.Max(num, 0));
			}
			this.Internal_SetDetailResolution(num, resolutionPerPatch);
		}

		// Token: 0x0600251C RID: 9500
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_SetDetailResolution(int patchCount, int resolutionPerPatch);

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x0600251D RID: 9501
		public extern int detailResolution { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x0600251E RID: 9502
		internal extern int detailResolutionPerPatch { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600251F RID: 9503
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void ResetDirtyDetails();

		// Token: 0x06002520 RID: 9504
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RefreshPrototypes();

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06002521 RID: 9505
		// (set) Token: 0x06002522 RID: 9506
		public extern DetailPrototype[] detailPrototypes { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002523 RID: 9507
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int[] GetSupportedLayers(int xBase, int yBase, int totalWidth, int totalHeight);

		// Token: 0x06002524 RID: 9508
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int[,] GetDetailLayer(int xBase, int yBase, int width, int height, int layer);

		// Token: 0x06002525 RID: 9509 RVA: 0x0002AAA4 File Offset: 0x00028CA4
		public void SetDetailLayer(int xBase, int yBase, int layer, int[,] details)
		{
			this.Internal_SetDetailLayer(xBase, yBase, details.GetLength(1), details.GetLength(0), layer, details);
		}

		// Token: 0x06002526 RID: 9510
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_SetDetailLayer(int xBase, int yBase, int totalWidth, int totalHeight, int detailIndex, int[,] data);

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06002527 RID: 9511
		// (set) Token: 0x06002528 RID: 9512
		public extern TreeInstance[] treeInstances { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002529 RID: 9513 RVA: 0x0002AAC4 File Offset: 0x00028CC4
		public TreeInstance GetTreeInstance(int index)
		{
			TreeInstance result;
			TerrainData.INTERNAL_CALL_GetTreeInstance(this, index, out result);
			return result;
		}

		// Token: 0x0600252A RID: 9514
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetTreeInstance(TerrainData self, int index, out TreeInstance value);

		// Token: 0x0600252B RID: 9515 RVA: 0x0002AAE4 File Offset: 0x00028CE4
		public void SetTreeInstance(int index, TreeInstance instance)
		{
			TerrainData.INTERNAL_CALL_SetTreeInstance(this, index, ref instance);
		}

		// Token: 0x0600252C RID: 9516
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetTreeInstance(TerrainData self, int index, ref TreeInstance instance);

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x0600252D RID: 9517
		public extern int treeInstanceCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x0600252E RID: 9518
		// (set) Token: 0x0600252F RID: 9519
		public extern TreePrototype[] treePrototypes { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002530 RID: 9520
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void RemoveTreePrototype(int index);

		// Token: 0x06002531 RID: 9521
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void RecalculateTreePositions();

		// Token: 0x06002532 RID: 9522
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void RemoveDetailPrototype(int index);

		// Token: 0x06002533 RID: 9523
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern bool NeedUpgradeScaledTreePrototypes();

		// Token: 0x06002534 RID: 9524
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void UpgradeScaledTreePrototype();

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06002535 RID: 9525
		public extern int alphamapLayers { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002536 RID: 9526
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float[,,] GetAlphamaps(int x, int y, int width, int height);

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06002537 RID: 9527 RVA: 0x0002AAF0 File Offset: 0x00028CF0
		// (set) Token: 0x06002538 RID: 9528 RVA: 0x0002AB0C File Offset: 0x00028D0C
		public int alphamapResolution
		{
			get
			{
				return this.Internal_alphamapResolution;
			}
			set
			{
				int internal_alphamapResolution = value;
				if (value < TerrainData.kMinimumAlphamapResolution || value > TerrainData.kMaximumAlphamapResolution)
				{
					Debug.LogWarning(string.Concat(new object[]
					{
						"alphamapResolution is clamped to the range of [",
						TerrainData.kMinimumAlphamapResolution,
						", ",
						TerrainData.kMaximumAlphamapResolution,
						"]."
					}));
					internal_alphamapResolution = Math.Min(TerrainData.kMaximumAlphamapResolution, Math.Max(value, TerrainData.kMinimumAlphamapResolution));
				}
				this.Internal_alphamapResolution = internal_alphamapResolution;
			}
		}

		// Token: 0x06002539 RID: 9529
		[RequiredByNativeCode]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern float GetAlphamapResolutionInternal();

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x0600253A RID: 9530
		// (set) Token: 0x0600253B RID: 9531
		private extern int Internal_alphamapResolution { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x0600253C RID: 9532 RVA: 0x0002AB94 File Offset: 0x00028D94
		public int alphamapWidth
		{
			get
			{
				return this.alphamapResolution;
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x0600253D RID: 9533 RVA: 0x0002ABB0 File Offset: 0x00028DB0
		public int alphamapHeight
		{
			get
			{
				return this.alphamapResolution;
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x0600253E RID: 9534 RVA: 0x0002ABCC File Offset: 0x00028DCC
		// (set) Token: 0x0600253F RID: 9535 RVA: 0x0002ABE8 File Offset: 0x00028DE8
		public int baseMapResolution
		{
			get
			{
				return this.Internal_baseMapResolution;
			}
			set
			{
				int internal_baseMapResolution = value;
				if (value < TerrainData.kMinimumBaseMapResolution || value > TerrainData.kMaximumBaseMapResolution)
				{
					Debug.LogWarning(string.Concat(new object[]
					{
						"baseMapResolution is clamped to the range of [",
						TerrainData.kMinimumBaseMapResolution,
						", ",
						TerrainData.kMaximumBaseMapResolution,
						"]."
					}));
					internal_baseMapResolution = Math.Min(TerrainData.kMaximumBaseMapResolution, Math.Max(value, TerrainData.kMinimumBaseMapResolution));
				}
				this.Internal_baseMapResolution = internal_baseMapResolution;
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06002540 RID: 9536
		// (set) Token: 0x06002541 RID: 9537
		private extern int Internal_baseMapResolution { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002542 RID: 9538 RVA: 0x0002AC70 File Offset: 0x00028E70
		public void SetAlphamaps(int x, int y, float[,,] map)
		{
			if (map.GetLength(2) != this.alphamapLayers)
			{
				throw new Exception(UnityString.Format("Float array size wrong (layers should be {0})", new object[]
				{
					this.alphamapLayers
				}));
			}
			this.Internal_SetAlphamaps(x, y, map.GetLength(1), map.GetLength(0), map);
		}

		// Token: 0x06002543 RID: 9539
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_SetAlphamaps(int x, int y, int width, int height, float[,,] map);

		// Token: 0x06002544 RID: 9540
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void RecalculateBasemapIfDirty();

		// Token: 0x06002545 RID: 9541
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetBasemapDirty(bool dirty);

		// Token: 0x06002546 RID: 9542
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Texture2D GetAlphamapTexture(int index);

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06002547 RID: 9543
		private extern int alphamapTextureCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06002548 RID: 9544 RVA: 0x0002ACCC File Offset: 0x00028ECC
		public Texture2D[] alphamapTextures
		{
			get
			{
				Texture2D[] array = new Texture2D[this.alphamapTextureCount];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = this.GetAlphamapTexture(i);
				}
				return array;
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06002549 RID: 9545
		// (set) Token: 0x0600254A RID: 9546
		public extern SplatPrototype[] splatPrototypes { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x0600254B RID: 9547
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void AddTree(out TreeInstance tree);

		// Token: 0x0600254C RID: 9548 RVA: 0x0002AD0C File Offset: 0x00028F0C
		internal int RemoveTrees(Vector2 position, float radius, int prototypeIndex)
		{
			return TerrainData.INTERNAL_CALL_RemoveTrees(this, ref position, radius, prototypeIndex);
		}

		// Token: 0x0600254D RID: 9549
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_RemoveTrees(TerrainData self, ref Vector2 position, float radius, int prototypeIndex);

		// Token: 0x04000654 RID: 1620
		private static readonly int kMaximumResolution = TerrainData.Internal_GetMaximumResolution();

		// Token: 0x04000655 RID: 1621
		private static readonly int kMinimumDetailResolutionPerPatch = TerrainData.Internal_GetMinimumDetailResolutionPerPatch();

		// Token: 0x04000656 RID: 1622
		private static readonly int kMaximumDetailResolutionPerPatch = TerrainData.Internal_GetMaximumDetailResolutionPerPatch();

		// Token: 0x04000657 RID: 1623
		private static readonly int kMaximumDetailPatchCount = TerrainData.Internal_GetMaximumDetailPatchCount();

		// Token: 0x04000658 RID: 1624
		private static readonly int kMinimumAlphamapResolution = TerrainData.Internal_GetMinimumAlphamapResolution();

		// Token: 0x04000659 RID: 1625
		private static readonly int kMaximumAlphamapResolution = TerrainData.Internal_GetMaximumAlphamapResolution();

		// Token: 0x0400065A RID: 1626
		private static readonly int kMinimumBaseMapResolution = TerrainData.Internal_GetMinimumBaseMapResolution();

		// Token: 0x0400065B RID: 1627
		private static readonly int kMaximumBaseMapResolution = TerrainData.Internal_GetMaximumBaseMapResolution();
	}
}
