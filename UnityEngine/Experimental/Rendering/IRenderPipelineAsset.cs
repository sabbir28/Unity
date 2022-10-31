using System;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000434 RID: 1076
	public interface IRenderPipelineAsset
	{
		// Token: 0x060034F8 RID: 13560
		void DestroyCreatedInstances();

		// Token: 0x060034F9 RID: 13561
		IRenderPipeline CreatePipeline();
	}
}
