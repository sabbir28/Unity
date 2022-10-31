using System;
using System.Collections.Generic;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000438 RID: 1080
	public abstract class RenderPipelineAsset : ScriptableObject, IRenderPipelineAsset
	{
		// Token: 0x060034FB RID: 13563 RVA: 0x00053F90 File Offset: 0x00052190
		public void DestroyCreatedInstances()
		{
			foreach (IRenderPipeline renderPipeline in this.m_CreatedPipelines)
			{
				renderPipeline.Dispose();
			}
			this.m_CreatedPipelines.Clear();
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x00053FF8 File Offset: 0x000521F8
		public IRenderPipeline CreatePipeline()
		{
			IRenderPipeline renderPipeline = this.InternalCreatePipeline();
			if (renderPipeline != null)
			{
				this.m_CreatedPipelines.Add(renderPipeline);
			}
			return renderPipeline;
		}

		// Token: 0x060034FD RID: 13565
		protected abstract IRenderPipeline InternalCreatePipeline();

		// Token: 0x060034FE RID: 13566 RVA: 0x00054028 File Offset: 0x00052228
		private void OnValidate()
		{
			this.DestroyCreatedInstances();
		}

		// Token: 0x060034FF RID: 13567 RVA: 0x00054034 File Offset: 0x00052234
		private void OnDisable()
		{
			this.DestroyCreatedInstances();
		}

		// Token: 0x04000F6B RID: 3947
		private readonly List<IRenderPipeline> m_CreatedPipelines = new List<IRenderPipeline>();
	}
}
