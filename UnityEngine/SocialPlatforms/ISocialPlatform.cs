using System;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x020003AF RID: 943
	public interface ISocialPlatform
	{
		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x0600320C RID: 12812
		ILocalUser localUser { get; }

		// Token: 0x0600320D RID: 12813
		void LoadUsers(string[] userIDs, Action<IUserProfile[]> callback);

		// Token: 0x0600320E RID: 12814
		void ReportProgress(string achievementID, double progress, Action<bool> callback);

		// Token: 0x0600320F RID: 12815
		void LoadAchievementDescriptions(Action<IAchievementDescription[]> callback);

		// Token: 0x06003210 RID: 12816
		void LoadAchievements(Action<IAchievement[]> callback);

		// Token: 0x06003211 RID: 12817
		IAchievement CreateAchievement();

		// Token: 0x06003212 RID: 12818
		void ReportScore(long score, string board, Action<bool> callback);

		// Token: 0x06003213 RID: 12819
		void LoadScores(string leaderboardID, Action<IScore[]> callback);

		// Token: 0x06003214 RID: 12820
		ILeaderboard CreateLeaderboard();

		// Token: 0x06003215 RID: 12821
		void ShowAchievementsUI();

		// Token: 0x06003216 RID: 12822
		void ShowLeaderboardUI();

		// Token: 0x06003217 RID: 12823
		void Authenticate(ILocalUser user, Action<bool> callback);

		// Token: 0x06003218 RID: 12824
		void Authenticate(ILocalUser user, Action<bool, string> callback);

		// Token: 0x06003219 RID: 12825
		void LoadFriends(ILocalUser user, Action<bool> callback);

		// Token: 0x0600321A RID: 12826
		void LoadScores(ILeaderboard board, Action<bool> callback);

		// Token: 0x0600321B RID: 12827
		bool GetLoading(ILeaderboard board);
	}
}
