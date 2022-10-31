using System;

namespace UnityEngine
{
	// Token: 0x020003C7 RID: 967
	public struct RangeInt
	{
		// Token: 0x0600327B RID: 12923 RVA: 0x0004D9FC File Offset: 0x0004BBFC
		public RangeInt(int start, int length)
		{
			this.start = start;
			this.length = length;
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x0600327C RID: 12924 RVA: 0x0004DA10 File Offset: 0x0004BC10
		public int end
		{
			get
			{
				return this.start + this.length;
			}
		}

		// Token: 0x04000E92 RID: 3730
		public int start;

		// Token: 0x04000E93 RID: 3731
		public int length;
	}
}
