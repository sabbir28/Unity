using System;

namespace UnityEngine.Networking.Match
{
	// Token: 0x0200028E RID: 654
	internal interface IResponse
	{
		// Token: 0x06002B90 RID: 11152
		void SetSuccess();

		// Token: 0x06002B91 RID: 11153
		void SetFailure(string info);
	}
}
