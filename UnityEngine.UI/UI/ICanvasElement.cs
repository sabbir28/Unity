using System;

namespace UnityEngine.UI
{
	// Token: 0x0200003D RID: 61
	public interface ICanvasElement
	{
		// Token: 0x06000187 RID: 391
		void Rebuild(CanvasUpdate executing);

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000188 RID: 392
		Transform transform { get; }

		// Token: 0x06000189 RID: 393
		void LayoutComplete();

		// Token: 0x0600018A RID: 394
		void GraphicUpdateComplete();

		// Token: 0x0600018B RID: 395
		bool IsDestroyed();
	}
}
