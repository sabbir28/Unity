using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000361 RID: 865
	public enum RenderQueue
	{
		// Token: 0x04000BAE RID: 2990
		Background = 1000,
		// Token: 0x04000BAF RID: 2991
		Geometry = 2000,
		// Token: 0x04000BB0 RID: 2992
		AlphaTest = 2450,
		// Token: 0x04000BB1 RID: 2993
		GeometryLast = 2500,
		// Token: 0x04000BB2 RID: 2994
		Transparent = 3000,
		// Token: 0x04000BB3 RID: 2995
		Overlay = 4000
	}
}
