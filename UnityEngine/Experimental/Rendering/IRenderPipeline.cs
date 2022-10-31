using System;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000433 RID: 1075
	public interface IRenderPipeline : IDisposable
	{
		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x060034F6 RID: 13558
		bool disposed { get; }

		// Token: 0x060034F7 RID: 13559
		void Render(ScriptableRenderContext renderContext, Camera[] cameras);
	}
}
