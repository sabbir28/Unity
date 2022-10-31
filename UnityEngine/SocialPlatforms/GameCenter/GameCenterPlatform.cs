using System;

namespace UnityEngine.SocialPlatforms.GameCenter
{
	// Token: 0x02000336 RID: 822
	public class GameCenterPlatform : Local
	{
		// Token: 0x060030F2 RID: 12530 RVA: 0x0004A6B4 File Offset: 0x000488B4
		public static void ResetAllAchievements(Action<bool> callback)
		{
			Debug.Log("ResetAllAchievements - no effect in editor");
			if (callback != null)
			{
				callback(true);
			}
		}

		// Token: 0x060030F3 RID: 12531 RVA: 0x0004A6D0 File Offset: 0x000488D0
		public static void ShowDefaultAchievementCompletionBanner(bool value)
		{
			Debug.Log("ShowDefaultAchievementCompletionBanner - no effect in editor");
		}

		// Token: 0x060030F4 RID: 12532 RVA: 0x0004A6E0 File Offset: 0x000488E0
		public static void ShowLeaderboardUI(string leaderboardID, TimeScope timeScope)
		{
			Debug.Log("ShowLeaderboardUI - no effect in editor");
		}
	}
}
