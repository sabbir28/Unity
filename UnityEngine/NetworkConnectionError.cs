using System;

namespace UnityEngine
{
	// Token: 0x0200008D RID: 141
	public enum NetworkConnectionError
	{
		// Token: 0x0400011B RID: 283
		NoError,
		// Token: 0x0400011C RID: 284
		RSAPublicKeyMismatch = 21,
		// Token: 0x0400011D RID: 285
		InvalidPassword = 23,
		// Token: 0x0400011E RID: 286
		ConnectionFailed = 15,
		// Token: 0x0400011F RID: 287
		TooManyConnectedPlayers = 18,
		// Token: 0x04000120 RID: 288
		ConnectionBanned = 22,
		// Token: 0x04000121 RID: 289
		AlreadyConnectedToServer = 16,
		// Token: 0x04000122 RID: 290
		AlreadyConnectedToAnotherServer = -1,
		// Token: 0x04000123 RID: 291
		CreateSocketOrThreadFailure = -2,
		// Token: 0x04000124 RID: 292
		IncorrectParameters = -3,
		// Token: 0x04000125 RID: 293
		EmptyConnectTarget = -4,
		// Token: 0x04000126 RID: 294
		InternalDirectConnectFailed = -5,
		// Token: 0x04000127 RID: 295
		NATTargetNotConnected = 69,
		// Token: 0x04000128 RID: 296
		NATTargetConnectionLost = 71,
		// Token: 0x04000129 RID: 297
		NATPunchthroughFailed = 73
	}
}
