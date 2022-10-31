using System;
using UnityEngine.SocialPlatforms;

namespace UnityEngine
{
	// Token: 0x020003AD RID: 941
	public static class Social
	{
		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x060031FC RID: 12796 RVA: 0x0004D310 File Offset: 0x0004B510
		// (set) Token: 0x060031FD RID: 12797 RVA: 0x0004D32C File Offset: 0x0004B52C
		public static ISocialPlatform Active
		{
			get
			{
				return ActivePlatform.Instance;
			}
			set
			{
				ActivePlatform.Instance = value;
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x060031FE RID: 12798 RVA: 0x0004D338 File Offset: 0x0004B538
		public static ILocalUser localUser
		{
			get
			{
				return Social.Active.localUser;
			}
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x0004D358 File Offset: 0x0004B558
		public static void LoadUsers(string[] userIDs, Action<IUserProfile[]> callback)
		{
			Social.Active.LoadUsers(userIDs, callback);
		}

		// Token: 0x06003200 RID: 12800 RVA: 0x0004D368 File Offset: 0x0004B568
		public static void ReportProgress(string achievementID, double progress, Action<bool> callback)
		{
			Social.Active.ReportProgress(achievementID, progress, callback);
		}

		// Token: 0x06003201 RID: 12801 RVA: 0x0004D378 File Offset: 0x0004B578
		public static void LoadAchievementDescriptions(Action<IAchievementDescription[]> callback)
		{
			Social.Active.LoadAchievementDescriptions(callback);
		}

		// Token: 0x06003202 RID: 12802 RVA: 0x0004D388 File Offset: 0x0004B588
		public static void LoadAchievements(Action<IAchievement[]> callback)
		{
			Social.Active.LoadAchievements(callback);
		}

		// Token: 0x06003203 RID: 12803 RVA: 0x0004D398 File Offset: 0x0004B598
		public static void ReportScore(long score, string board, Action<bool> callback)
		{
			Social.Active.ReportScore(score, board, callback);
		}

		// Token: 0x06003204 RID: 12804 RVA: 0x0004D3A8 File Offset: 0x0004B5A8
		public static void LoadScores(string leaderboardID, Action<IScore[]> callback)
		{
			Social.Active.LoadScores(leaderboardID, callback);
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x0004D3B8 File Offset: 0x0004B5B8
		public static ILeaderboard CreateLeaderboard()
		{
			return Social.Active.CreateLeaderboard();
		}

		// Token: 0x06003206 RID: 12806 RVA: 0x0004D3D8 File Offset: 0x0004B5D8
		public static IAchievement CreateAchievement()
		{
			return Social.Active.CreateAchievement();
		}

		// Token: 0x06003207 RID: 12807 RVA: 0x0004D3F8 File Offset: 0x0004B5F8
		public static void ShowAchievementsUI()
		{
			Social.Active.ShowAchievementsUI();
		}

		// Token: 0x06003208 RID: 12808 RVA: 0x0004D408 File Offset: 0x0004B608
		public static void ShowLeaderboardUI()
		{
			Social.Active.ShowLeaderboardUI();
		}
	}
}
