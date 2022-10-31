using System;

namespace UnityEngine
{
	// Token: 0x0200008C RID: 140
	public enum ConnectionTesterStatus
	{
		// Token: 0x0400010F RID: 271
		Error = -2,
		// Token: 0x04000110 RID: 272
		Undetermined,
		// Token: 0x04000111 RID: 273
		[Obsolete("No longer returned, use newer connection tester enums instead.")]
		PrivateIPNoNATPunchthrough,
		// Token: 0x04000112 RID: 274
		[Obsolete("No longer returned, use newer connection tester enums instead.")]
		PrivateIPHasNATPunchThrough,
		// Token: 0x04000113 RID: 275
		PublicIPIsConnectable,
		// Token: 0x04000114 RID: 276
		PublicIPPortBlocked,
		// Token: 0x04000115 RID: 277
		PublicIPNoServerStarted,
		// Token: 0x04000116 RID: 278
		LimitedNATPunchthroughPortRestricted,
		// Token: 0x04000117 RID: 279
		LimitedNATPunchthroughSymmetric,
		// Token: 0x04000118 RID: 280
		NATpunchthroughFullCone,
		// Token: 0x04000119 RID: 281
		NATpunchthroughAddressRestrictedCone
	}
}
