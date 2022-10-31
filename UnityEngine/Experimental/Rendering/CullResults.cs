using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x020000FC RID: 252
	[UsedByNativeCode]
	public struct CullResults
	{
		// Token: 0x06001183 RID: 4483 RVA: 0x00017734 File Offset: 0x00015934
		public static bool GetCullingParameters(Camera camera, out CullingParameters cullingParameters)
		{
			return CullResults.GetCullingParameters_Internal(camera, out cullingParameters, sizeof(CullingParameters));
		}

		// Token: 0x06001184 RID: 4484
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetCullingParameters_Internal(Camera camera, out CullingParameters cullingParameters, int managedCullingParametersSize);

		// Token: 0x06001185 RID: 4485 RVA: 0x00017758 File Offset: 0x00015958
		internal static void Internal_Cull(ref CullingParameters parameters, ScriptableRenderContext renderLoop, out CullResults results)
		{
			CullResults.INTERNAL_CALL_Internal_Cull(ref parameters, ref renderLoop, out results);
		}

		// Token: 0x06001186 RID: 4486
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_Cull(ref CullingParameters parameters, ref ScriptableRenderContext renderLoop, out CullResults results);

		// Token: 0x06001187 RID: 4487 RVA: 0x00017764 File Offset: 0x00015964
		public static CullResults Cull(ref CullingParameters parameters, ScriptableRenderContext renderLoop)
		{
			CullResults result;
			CullResults.Internal_Cull(ref parameters, renderLoop, out result);
			return result;
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x00017784 File Offset: 0x00015984
		public static bool Cull(Camera camera, ScriptableRenderContext renderLoop, out CullResults results)
		{
			results.cullResults = IntPtr.Zero;
			results.visibleLights = null;
			results.visibleReflectionProbes = null;
			CullingParameters cullingParameters;
			bool result;
			if (!CullResults.GetCullingParameters(camera, out cullingParameters))
			{
				result = false;
			}
			else
			{
				results = CullResults.Cull(ref cullingParameters, renderLoop);
				result = true;
			}
			return result;
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x000177D8 File Offset: 0x000159D8
		public bool GetShadowCasterBounds(int lightIndex, out Bounds outBounds)
		{
			return CullResults.GetShadowCasterBounds(this.cullResults, lightIndex, out outBounds);
		}

		// Token: 0x0600118A RID: 4490
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetShadowCasterBounds(IntPtr cullResults, int lightIndex, out Bounds bounds);

		// Token: 0x0600118B RID: 4491 RVA: 0x000177FC File Offset: 0x000159FC
		public int GetLightIndicesCount()
		{
			return CullResults.GetLightIndicesCount(this.cullResults);
		}

		// Token: 0x0600118C RID: 4492
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetLightIndicesCount(IntPtr cullResults);

		// Token: 0x0600118D RID: 4493 RVA: 0x0001781C File Offset: 0x00015A1C
		public void FillLightIndices(ComputeBuffer computeBuffer)
		{
			CullResults.FillLightIndices(this.cullResults, computeBuffer);
		}

		// Token: 0x0600118E RID: 4494
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void FillLightIndices(IntPtr cullResults, ComputeBuffer computeBuffer);

		// Token: 0x0600118F RID: 4495 RVA: 0x0001782C File Offset: 0x00015A2C
		public bool ComputeSpotShadowMatricesAndCullingPrimitives(int activeLightIndex, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
		{
			return CullResults.ComputeSpotShadowMatricesAndCullingPrimitives(this.cullResults, activeLightIndex, out viewMatrix, out projMatrix, out shadowSplitData);
		}

		// Token: 0x06001190 RID: 4496
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool ComputeSpotShadowMatricesAndCullingPrimitives(IntPtr cullResults, int activeLightIndex, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData);

		// Token: 0x06001191 RID: 4497 RVA: 0x00017854 File Offset: 0x00015A54
		public bool ComputePointShadowMatricesAndCullingPrimitives(int activeLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
		{
			return CullResults.ComputePointShadowMatricesAndCullingPrimitives(this.cullResults, activeLightIndex, cubemapFace, fovBias, out viewMatrix, out projMatrix, out shadowSplitData);
		}

		// Token: 0x06001192 RID: 4498
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool ComputePointShadowMatricesAndCullingPrimitives(IntPtr cullResults, int activeLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData);

		// Token: 0x06001193 RID: 4499 RVA: 0x00017880 File Offset: 0x00015A80
		public bool ComputeDirectionalShadowMatricesAndCullingPrimitives(int activeLightIndex, int splitIndex, int splitCount, Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
		{
			return CullResults.ComputeDirectionalShadowMatricesAndCullingPrimitives(this.cullResults, activeLightIndex, splitIndex, splitCount, splitRatio, shadowResolution, shadowNearPlaneOffset, out viewMatrix, out projMatrix, out shadowSplitData);
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x000178B0 File Offset: 0x00015AB0
		private static bool ComputeDirectionalShadowMatricesAndCullingPrimitives(IntPtr cullResults, int activeLightIndex, int splitIndex, int splitCount, Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
		{
			return CullResults.INTERNAL_CALL_ComputeDirectionalShadowMatricesAndCullingPrimitives(cullResults, activeLightIndex, splitIndex, splitCount, ref splitRatio, shadowResolution, shadowNearPlaneOffset, out viewMatrix, out projMatrix, out shadowSplitData);
		}

		// Token: 0x06001195 RID: 4501
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_ComputeDirectionalShadowMatricesAndCullingPrimitives(IntPtr cullResults, int activeLightIndex, int splitIndex, int splitCount, ref Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData);

		// Token: 0x0400024D RID: 589
		public VisibleLight[] visibleLights;

		// Token: 0x0400024E RID: 590
		public VisibleReflectionProbe[] visibleReflectionProbes;

		// Token: 0x0400024F RID: 591
		internal IntPtr cullResults;
	}
}
