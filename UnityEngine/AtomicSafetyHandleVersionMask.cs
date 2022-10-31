using System;

namespace UnityEngine
{
	// Token: 0x02000309 RID: 777
	[Flags]
	internal enum AtomicSafetyHandleVersionMask
	{
		// Token: 0x040009EC RID: 2540
		Read = 1,
		// Token: 0x040009ED RID: 2541
		Write = 2,
		// Token: 0x040009EE RID: 2542
		ReadAndWrite = 3,
		// Token: 0x040009EF RID: 2543
		WriteInv = -3,
		// Token: 0x040009F0 RID: 2544
		ReadInv = -2,
		// Token: 0x040009F1 RID: 2545
		ReadAndWriteInv = -4
	}
}
