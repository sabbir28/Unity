using System;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x020003B8 RID: 952
	public struct Range
	{
		// Token: 0x06003240 RID: 12864 RVA: 0x0004D470 File Offset: 0x0004B670
		public Range(int fromValue, int valueCount)
		{
			this.from = fromValue;
			this.count = valueCount;
		}

		// Token: 0x04000E7C RID: 3708
		public int from;

		// Token: 0x04000E7D RID: 3709
		public int count;
	}
}
