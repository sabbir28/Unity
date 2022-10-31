using System;

namespace UnityEngine
{
	// Token: 0x02000227 RID: 551
	[Flags]
	public enum TerrainChangedFlags
	{
		// Token: 0x0400065D RID: 1629
		Heightmap = 1,
		// Token: 0x0400065E RID: 1630
		TreeInstances = 2,
		// Token: 0x0400065F RID: 1631
		DelayedHeightmapUpdate = 4,
		// Token: 0x04000660 RID: 1632
		FlushEverythingImmediately = 8,
		// Token: 0x04000661 RID: 1633
		RemoveDirtyDetailsImmediately = 16,
		// Token: 0x04000662 RID: 1634
		WillBeDestroyed = 256
	}
}
