using System;

namespace UnityEngine.Networking
{
	// Token: 0x020002B1 RID: 689
	public enum NetworkError
	{
		// Token: 0x040008E7 RID: 2279
		Ok,
		// Token: 0x040008E8 RID: 2280
		WrongHost,
		// Token: 0x040008E9 RID: 2281
		WrongConnection,
		// Token: 0x040008EA RID: 2282
		WrongChannel,
		// Token: 0x040008EB RID: 2283
		NoResources,
		// Token: 0x040008EC RID: 2284
		BadMessage,
		// Token: 0x040008ED RID: 2285
		Timeout,
		// Token: 0x040008EE RID: 2286
		MessageToLong,
		// Token: 0x040008EF RID: 2287
		WrongOperation,
		// Token: 0x040008F0 RID: 2288
		VersionMismatch,
		// Token: 0x040008F1 RID: 2289
		CRCMismatch,
		// Token: 0x040008F2 RID: 2290
		DNSFailure,
		// Token: 0x040008F3 RID: 2291
		UsageError
	}
}
