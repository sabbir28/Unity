using System;

namespace UnityEngine
{
	// Token: 0x02000176 RID: 374
	[Flags]
	public enum RigidbodyConstraints2D
	{
		// Token: 0x04000411 RID: 1041
		None = 0,
		// Token: 0x04000412 RID: 1042
		FreezePositionX = 1,
		// Token: 0x04000413 RID: 1043
		FreezePositionY = 2,
		// Token: 0x04000414 RID: 1044
		FreezeRotation = 4,
		// Token: 0x04000415 RID: 1045
		FreezePosition = 3,
		// Token: 0x04000416 RID: 1046
		FreezeAll = 7
	}
}
