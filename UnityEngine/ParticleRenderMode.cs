using System;

namespace UnityEngine
{
	// Token: 0x020002FE RID: 766
	[Obsolete("This is part of the legacy particle system, which is deprecated and will be removed in a future release. Use the ParticleSystem component instead.", false)]
	public enum ParticleRenderMode
	{
		// Token: 0x040009D9 RID: 2521
		Billboard,
		// Token: 0x040009DA RID: 2522
		Stretch = 3,
		// Token: 0x040009DB RID: 2523
		SortedBillboard = 2,
		// Token: 0x040009DC RID: 2524
		HorizontalBillboard = 4,
		// Token: 0x040009DD RID: 2525
		VerticalBillboard
	}
}
