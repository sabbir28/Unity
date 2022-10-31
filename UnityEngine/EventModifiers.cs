using System;

namespace UnityEngine
{
	// Token: 0x02000249 RID: 585
	[Flags]
	public enum EventModifiers
	{
		// Token: 0x040006F5 RID: 1781
		None = 0,
		// Token: 0x040006F6 RID: 1782
		Shift = 1,
		// Token: 0x040006F7 RID: 1783
		Control = 2,
		// Token: 0x040006F8 RID: 1784
		Alt = 4,
		// Token: 0x040006F9 RID: 1785
		Command = 8,
		// Token: 0x040006FA RID: 1786
		Numeric = 16,
		// Token: 0x040006FB RID: 1787
		CapsLock = 32,
		// Token: 0x040006FC RID: 1788
		FunctionKey = 64
	}
}
