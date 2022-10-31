using System;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x020000F9 RID: 249
	public struct ScriptableRenderContext
	{
		// Token: 0x06001176 RID: 4470 RVA: 0x000176C8 File Offset: 0x000158C8
		internal void Initialize(IntPtr ptr)
		{
			this.m_Ptr = ptr;
		}

		// Token: 0x06001177 RID: 4471
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Submit();

		// Token: 0x06001178 RID: 4472
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void DrawRenderers(ref DrawRendererSettings settings);

		// Token: 0x06001179 RID: 4473
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void DrawShadows(ref DrawShadowsSettings settings);

		// Token: 0x0600117A RID: 4474
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ExecuteCommandBuffer(CommandBuffer commandBuffer);

		// Token: 0x0600117B RID: 4475
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetupCameraProperties(Camera camera);

		// Token: 0x0600117C RID: 4476
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void DrawSkybox(Camera camera);

		// Token: 0x0400023B RID: 571
		private IntPtr m_Ptr;
	}
}
