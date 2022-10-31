using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200003D RID: 61
	[UsedByNativeCode]
	public struct GradientAlphaKey
	{
		// Token: 0x06000478 RID: 1144 RVA: 0x00007420 File Offset: 0x00005620
		public GradientAlphaKey(float alpha, float time)
		{
			this.alpha = alpha;
			this.time = time;
		}

		// Token: 0x0400005D RID: 93
		public float alpha;

		// Token: 0x0400005E RID: 94
		public float time;
	}
}
