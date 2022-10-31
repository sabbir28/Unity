using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000C2 RID: 194
	public sealed class ProceduralMaterial : Material
	{
		// Token: 0x06000DF4 RID: 3572 RVA: 0x00013080 File Offset: 0x00011280
		internal ProceduralMaterial() : base(null)
		{
		}

		// Token: 0x06000DF5 RID: 3573
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern ProceduralPropertyDescription[] GetProceduralPropertyDescriptions();

		// Token: 0x06000DF6 RID: 3574
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool HasProceduralProperty(string inputName);

		// Token: 0x06000DF7 RID: 3575
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool GetProceduralBoolean(string inputName);

		// Token: 0x06000DF8 RID: 3576
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsProceduralPropertyVisible(string inputName);

		// Token: 0x06000DF9 RID: 3577
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetProceduralBoolean(string inputName, bool value);

		// Token: 0x06000DFA RID: 3578
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float GetProceduralFloat(string inputName);

		// Token: 0x06000DFB RID: 3579
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetProceduralFloat(string inputName, float value);

		// Token: 0x06000DFC RID: 3580 RVA: 0x0001308C File Offset: 0x0001128C
		public Vector4 GetProceduralVector(string inputName)
		{
			Vector4 result;
			ProceduralMaterial.INTERNAL_CALL_GetProceduralVector(this, inputName, out result);
			return result;
		}

		// Token: 0x06000DFD RID: 3581
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetProceduralVector(ProceduralMaterial self, string inputName, out Vector4 value);

		// Token: 0x06000DFE RID: 3582 RVA: 0x000130AC File Offset: 0x000112AC
		public void SetProceduralVector(string inputName, Vector4 value)
		{
			ProceduralMaterial.INTERNAL_CALL_SetProceduralVector(this, inputName, ref value);
		}

		// Token: 0x06000DFF RID: 3583
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetProceduralVector(ProceduralMaterial self, string inputName, ref Vector4 value);

		// Token: 0x06000E00 RID: 3584 RVA: 0x000130B8 File Offset: 0x000112B8
		public Color GetProceduralColor(string inputName)
		{
			Color result;
			ProceduralMaterial.INTERNAL_CALL_GetProceduralColor(this, inputName, out result);
			return result;
		}

		// Token: 0x06000E01 RID: 3585
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetProceduralColor(ProceduralMaterial self, string inputName, out Color value);

		// Token: 0x06000E02 RID: 3586 RVA: 0x000130D8 File Offset: 0x000112D8
		public void SetProceduralColor(string inputName, Color value)
		{
			ProceduralMaterial.INTERNAL_CALL_SetProceduralColor(this, inputName, ref value);
		}

		// Token: 0x06000E03 RID: 3587
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetProceduralColor(ProceduralMaterial self, string inputName, ref Color value);

		// Token: 0x06000E04 RID: 3588
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetProceduralEnum(string inputName);

		// Token: 0x06000E05 RID: 3589
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetProceduralEnum(string inputName, int value);

		// Token: 0x06000E06 RID: 3590
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Texture2D GetProceduralTexture(string inputName);

		// Token: 0x06000E07 RID: 3591
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetProceduralTexture(string inputName, Texture2D value);

		// Token: 0x06000E08 RID: 3592
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsProceduralPropertyCached(string inputName);

		// Token: 0x06000E09 RID: 3593
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void CacheProceduralProperty(string inputName, bool value);

		// Token: 0x06000E0A RID: 3594
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ClearCache();

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000E0B RID: 3595
		// (set) Token: 0x06000E0C RID: 3596
		public extern ProceduralCacheSize cacheSize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000E0D RID: 3597
		// (set) Token: 0x06000E0E RID: 3598
		public extern int animationUpdateRate { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000E0F RID: 3599
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RebuildTextures();

		// Token: 0x06000E10 RID: 3600
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RebuildTexturesImmediately();

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000E11 RID: 3601
		public extern bool isProcessing { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000E12 RID: 3602
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StopRebuilds();

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000E13 RID: 3603
		public extern bool isCachedDataAvailable { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000E14 RID: 3604
		// (set) Token: 0x06000E15 RID: 3605
		public extern bool isLoadTimeGenerated { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000E16 RID: 3606
		public extern ProceduralLoadingBehavior loadingBehavior { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000E17 RID: 3607
		public static extern bool isSupported { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000E18 RID: 3608
		// (set) Token: 0x06000E19 RID: 3609
		public static extern ProceduralProcessorUsage substanceProcessorUsage { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000E1A RID: 3610
		// (set) Token: 0x06000E1B RID: 3611
		public extern string preset { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000E1C RID: 3612
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Texture[] GetGeneratedTextures();

		// Token: 0x06000E1D RID: 3613
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern ProceduralTexture GetGeneratedTexture(string textureName);

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000E1E RID: 3614
		// (set) Token: 0x06000E1F RID: 3615
		public extern bool isReadable { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000E20 RID: 3616
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void FreezeAndReleaseSourceData();

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000E21 RID: 3617
		public extern bool isFrozen { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
