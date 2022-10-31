using System;

namespace UnityEngine
{
	// Token: 0x020000CF RID: 207
	[Flags]
	public enum HideFlags
	{
		// Token: 0x040001D2 RID: 466
		None = 0,
		// Token: 0x040001D3 RID: 467
		HideInHierarchy = 1,
		// Token: 0x040001D4 RID: 468
		HideInInspector = 2,
		// Token: 0x040001D5 RID: 469
		DontSaveInEditor = 4,
		// Token: 0x040001D6 RID: 470
		NotEditable = 8,
		// Token: 0x040001D7 RID: 471
		DontSaveInBuild = 16,
		// Token: 0x040001D8 RID: 472
		DontUnloadUnusedAsset = 32,
		// Token: 0x040001D9 RID: 473
		DontSave = 52,
		// Token: 0x040001DA RID: 474
		HideAndDontSave = 61
	}
}
