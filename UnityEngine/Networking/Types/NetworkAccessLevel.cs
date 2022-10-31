using System;
using System.ComponentModel;

namespace UnityEngine.Networking.Types
{
	// Token: 0x0200029E RID: 670
	[DefaultValue(NetworkAccessLevel.Invalid)]
	public enum NetworkAccessLevel : ulong
	{
		// Token: 0x040008A9 RID: 2217
		Invalid,
		// Token: 0x040008AA RID: 2218
		User,
		// Token: 0x040008AB RID: 2219
		Owner,
		// Token: 0x040008AC RID: 2220
		Admin = 4UL
	}
}
