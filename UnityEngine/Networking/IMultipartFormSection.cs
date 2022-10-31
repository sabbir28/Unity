using System;

namespace UnityEngine.Networking
{
	// Token: 0x0200027C RID: 636
	public interface IMultipartFormSection
	{
		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06002AF3 RID: 10995
		string sectionName { get; }

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06002AF4 RID: 10996
		byte[] sectionData { get; }

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06002AF5 RID: 10997
		string fileName { get; }

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06002AF6 RID: 10998
		string contentType { get; }
	}
}
