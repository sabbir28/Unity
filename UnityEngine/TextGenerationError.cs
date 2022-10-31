using System;

namespace UnityEngine
{
	// Token: 0x0200022F RID: 559
	[Flags]
	internal enum TextGenerationError
	{
		// Token: 0x04000673 RID: 1651
		None = 0,
		// Token: 0x04000674 RID: 1652
		CustomSizeOnNonDynamicFont = 1,
		// Token: 0x04000675 RID: 1653
		CustomStyleOnNonDynamicFont = 2,
		// Token: 0x04000676 RID: 1654
		NoFont = 4
	}
}
