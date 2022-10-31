using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200003C RID: 60
	[UsedByNativeCode]
	public struct GradientColorKey
	{
		// Token: 0x06000477 RID: 1143 RVA: 0x0000740C File Offset: 0x0000560C
		public GradientColorKey(Color col, float time)
		{
			this.color = col;
			this.time = time;
		}

		// Token: 0x0400005B RID: 91
		public Color color;

		// Token: 0x0400005C RID: 92
		public float time;
	}
}
