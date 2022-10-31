using System;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x020003B9 RID: 953
	public interface ILeaderboard
	{
		// Token: 0x06003241 RID: 12865
		void SetUserFilter(string[] userIDs);

		// Token: 0x06003242 RID: 12866
		void LoadScores(Action<bool> callback);

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x06003243 RID: 12867
		bool loading { get; }

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06003244 RID: 12868
		// (set) Token: 0x06003245 RID: 12869
		string id { get; set; }

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06003246 RID: 12870
		// (set) Token: 0x06003247 RID: 12871
		UserScope userScope { get; set; }

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06003248 RID: 12872
		// (set) Token: 0x06003249 RID: 12873
		Range range { get; set; }

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x0600324A RID: 12874
		// (set) Token: 0x0600324B RID: 12875
		TimeScope timeScope { get; set; }

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x0600324C RID: 12876
		IScore localUserScore { get; }

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x0600324D RID: 12877
		uint maxRange { get; }

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x0600324E RID: 12878
		IScore[] scores { get; }

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x0600324F RID: 12879
		string title { get; }
	}
}
