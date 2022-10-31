using System;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000439 RID: 1081
	internal static class RenderPipelineManager
	{
		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x06003500 RID: 13568 RVA: 0x00054040 File Offset: 0x00052240
		// (set) Token: 0x06003501 RID: 13569 RVA: 0x0005405C File Offset: 0x0005225C
		public static IRenderPipeline currentPipeline { get; private set; }

		// Token: 0x06003502 RID: 13570 RVA: 0x00054064 File Offset: 0x00052264
		[RequiredByNativeCode]
		internal static void CleanupRenderPipeline()
		{
			if (RenderPipelineManager.s_CurrentPipelineAsset != null)
			{
				RenderPipelineManager.s_CurrentPipelineAsset.DestroyCreatedInstances();
			}
			RenderPipelineManager.s_CurrentPipelineAsset = null;
			RenderPipelineManager.currentPipeline = null;
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x00054088 File Offset: 0x00052288
		[RequiredByNativeCode]
		private static bool DoRenderLoop_Internal(IRenderPipelineAsset pipe, Camera[] cameras, IntPtr loopPtr)
		{
			bool result;
			if (!RenderPipelineManager.PrepareRenderPipeline(pipe))
			{
				result = false;
			}
			else
			{
				ScriptableRenderContext renderContext = default(ScriptableRenderContext);
				renderContext.Initialize(loopPtr);
				RenderPipelineManager.currentPipeline.Render(renderContext, cameras);
				result = true;
			}
			return result;
		}

		// Token: 0x06003504 RID: 13572 RVA: 0x000540CC File Offset: 0x000522CC
		private static bool PrepareRenderPipeline(IRenderPipelineAsset pipe)
		{
			if (RenderPipelineManager.s_CurrentPipelineAsset != pipe)
			{
				if (RenderPipelineManager.s_CurrentPipelineAsset != null)
				{
					RenderPipelineManager.CleanupRenderPipeline();
				}
				RenderPipelineManager.s_CurrentPipelineAsset = pipe;
			}
			if (RenderPipelineManager.s_CurrentPipelineAsset != null && (RenderPipelineManager.currentPipeline == null || RenderPipelineManager.currentPipeline.disposed))
			{
				RenderPipelineManager.currentPipeline = RenderPipelineManager.s_CurrentPipelineAsset.CreatePipeline();
			}
			return RenderPipelineManager.s_CurrentPipelineAsset != null;
		}

		// Token: 0x04000F6C RID: 3948
		private static IRenderPipelineAsset s_CurrentPipelineAsset;
	}
}
