using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200007B RID: 123
	[UsedByNativeCode]
	public struct LOD
	{
		// Token: 0x06000882 RID: 2178 RVA: 0x0000A2CC File Offset: 0x000084CC
		public LOD(float screenRelativeTransitionHeight, Renderer[] renderers)
		{
			this.screenRelativeTransitionHeight = screenRelativeTransitionHeight;
			this.fadeTransitionWidth = 0f;
			this.renderers = renderers;
		}

		// Token: 0x040000CC RID: 204
		public float screenRelativeTransitionHeight;

		// Token: 0x040000CD RID: 205
		public float fadeTransitionWidth;

		// Token: 0x040000CE RID: 206
		public Renderer[] renderers;
	}
}
