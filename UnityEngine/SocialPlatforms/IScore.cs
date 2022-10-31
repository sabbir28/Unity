using System;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x020003B5 RID: 949
	public interface IScore
	{
		// Token: 0x06003237 RID: 12855
		void ReportScore(Action<bool> callback);

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06003238 RID: 12856
		// (set) Token: 0x06003239 RID: 12857
		string leaderboardID { get; set; }

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x0600323A RID: 12858
		// (set) Token: 0x0600323B RID: 12859
		long value { get; set; }

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x0600323C RID: 12860
		DateTime date { get; }

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x0600323D RID: 12861
		string formattedValue { get; }

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x0600323E RID: 12862
		string userID { get; }

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x0600323F RID: 12863
		int rank { get; }
	}
}
