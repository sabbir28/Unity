using System;

namespace UnityEngine.Networking
{
	// Token: 0x020002B0 RID: 688
	public enum QosType
	{
		// Token: 0x040008DD RID: 2269
		Unreliable,
		// Token: 0x040008DE RID: 2270
		UnreliableFragmented,
		// Token: 0x040008DF RID: 2271
		UnreliableSequenced,
		// Token: 0x040008E0 RID: 2272
		Reliable,
		// Token: 0x040008E1 RID: 2273
		ReliableFragmented,
		// Token: 0x040008E2 RID: 2274
		ReliableSequenced,
		// Token: 0x040008E3 RID: 2275
		StateUpdate,
		// Token: 0x040008E4 RID: 2276
		ReliableStateUpdate,
		// Token: 0x040008E5 RID: 2277
		AllCostDelivery
	}
}
