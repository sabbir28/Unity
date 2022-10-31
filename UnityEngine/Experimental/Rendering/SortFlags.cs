using System;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200043C RID: 1084
	[Flags]
	public enum SortFlags
	{
		// Token: 0x04000F73 RID: 3955
		None = 0,
		// Token: 0x04000F74 RID: 3956
		SortingLayer = 1,
		// Token: 0x04000F75 RID: 3957
		RenderQueue = 2,
		// Token: 0x04000F76 RID: 3958
		BackToFront = 4,
		// Token: 0x04000F77 RID: 3959
		QuantizedFrontToBack = 8,
		// Token: 0x04000F78 RID: 3960
		OptimizeStateChanges = 16,
		// Token: 0x04000F79 RID: 3961
		CanvasOrder = 32,
		// Token: 0x04000F7A RID: 3962
		CommonOpaque = 59,
		// Token: 0x04000F7B RID: 3963
		CommonTransparent = 23
	}
}
