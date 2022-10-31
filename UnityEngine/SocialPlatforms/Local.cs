using System;
using System.Collections.Generic;
using UnityEngine.SocialPlatforms.Impl;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x020003A3 RID: 931
	public class Local : ISocialPlatform
	{
		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x060031B2 RID: 12722 RVA: 0x0004BC88 File Offset: 0x00049E88
		public ILocalUser localUser
		{
			get
			{
				if (Local.m_LocalUser == null)
				{
					Local.m_LocalUser = new LocalUser();
				}
				return Local.m_LocalUser;
			}
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x0004BCB8 File Offset: 0x00049EB8
		void ISocialPlatform.Authenticate(ILocalUser user, Action<bool> callback)
		{
			LocalUser localUser = (LocalUser)user;
			this.m_DefaultTexture = this.CreateDummyTexture(32, 32);
			this.PopulateStaticData();
			localUser.SetAuthenticated(true);
			localUser.SetUnderage(false);
			localUser.SetUserID("1000");
			localUser.SetUserName("Lerpz");
			localUser.SetImage(this.m_DefaultTexture);
			if (callback != null)
			{
				callback(true);
			}
		}

		// Token: 0x060031B4 RID: 12724 RVA: 0x0004BD20 File Offset: 0x00049F20
		void ISocialPlatform.Authenticate(ILocalUser user, Action<bool, string> callback)
		{
			((ISocialPlatform)this).Authenticate(user, delegate(bool success)
			{
				callback(success, null);
			});
		}

		// Token: 0x060031B5 RID: 12725 RVA: 0x0004BD50 File Offset: 0x00049F50
		void ISocialPlatform.LoadFriends(ILocalUser user, Action<bool> callback)
		{
			if (this.VerifyUser())
			{
				((LocalUser)user).SetFriends(this.m_Friends.ToArray());
				if (callback != null)
				{
					callback(true);
				}
			}
		}

		// Token: 0x060031B6 RID: 12726 RVA: 0x0004BD88 File Offset: 0x00049F88
		public void LoadUsers(string[] userIDs, Action<IUserProfile[]> callback)
		{
			List<UserProfile> list = new List<UserProfile>();
			if (this.VerifyUser())
			{
				foreach (string b in userIDs)
				{
					foreach (UserProfile userProfile in this.m_Users)
					{
						if (userProfile.id == b)
						{
							list.Add(userProfile);
						}
					}
					foreach (UserProfile userProfile2 in this.m_Friends)
					{
						if (userProfile2.id == b)
						{
							list.Add(userProfile2);
						}
					}
				}
				callback(list.ToArray());
			}
		}

		// Token: 0x060031B7 RID: 12727 RVA: 0x0004BE9C File Offset: 0x0004A09C
		public void ReportProgress(string id, double progress, Action<bool> callback)
		{
			if (this.VerifyUser())
			{
				foreach (Achievement achievement in this.m_Achievements)
				{
					if (achievement.id == id && achievement.percentCompleted <= progress)
					{
						if (progress >= 100.0)
						{
							achievement.SetCompleted(true);
						}
						achievement.SetHidden(false);
						achievement.SetLastReportedDate(DateTime.Now);
						achievement.percentCompleted = progress;
						if (callback != null)
						{
							callback(true);
						}
						return;
					}
				}
				foreach (AchievementDescription achievementDescription in this.m_AchievementDescriptions)
				{
					if (achievementDescription.id == id)
					{
						bool completed = progress >= 100.0;
						Achievement item = new Achievement(id, progress, completed, false, DateTime.Now);
						this.m_Achievements.Add(item);
						if (callback != null)
						{
							callback(true);
						}
						return;
					}
				}
				Debug.LogError("Achievement ID not found");
				if (callback != null)
				{
					callback(false);
				}
			}
		}

		// Token: 0x060031B8 RID: 12728 RVA: 0x0004C01C File Offset: 0x0004A21C
		public void LoadAchievementDescriptions(Action<IAchievementDescription[]> callback)
		{
			if (this.VerifyUser())
			{
				if (callback != null)
				{
					callback(this.m_AchievementDescriptions.ToArray());
				}
			}
		}

		// Token: 0x060031B9 RID: 12729 RVA: 0x0004C048 File Offset: 0x0004A248
		public void LoadAchievements(Action<IAchievement[]> callback)
		{
			if (this.VerifyUser())
			{
				if (callback != null)
				{
					callback(this.m_Achievements.ToArray());
				}
			}
		}

		// Token: 0x060031BA RID: 12730 RVA: 0x0004C074 File Offset: 0x0004A274
		public void ReportScore(long score, string board, Action<bool> callback)
		{
			if (this.VerifyUser())
			{
				foreach (Leaderboard leaderboard in this.m_Leaderboards)
				{
					if (leaderboard.id == board)
					{
						leaderboard.SetScores(new List<Score>((Score[])leaderboard.scores)
						{
							new Score(board, score, this.localUser.id, DateTime.Now, score + " points", 0)
						}.ToArray());
						if (callback != null)
						{
							callback(true);
						}
						return;
					}
				}
				Debug.LogError("Leaderboard not found");
				if (callback != null)
				{
					callback(false);
				}
			}
		}

		// Token: 0x060031BB RID: 12731 RVA: 0x0004C164 File Offset: 0x0004A364
		public void LoadScores(string leaderboardID, Action<IScore[]> callback)
		{
			if (this.VerifyUser())
			{
				foreach (Leaderboard leaderboard in this.m_Leaderboards)
				{
					if (leaderboard.id == leaderboardID)
					{
						this.SortScores(leaderboard);
						if (callback != null)
						{
							callback(leaderboard.scores);
						}
						return;
					}
				}
				Debug.LogError("Leaderboard not found");
				if (callback != null)
				{
					callback(new Score[0]);
				}
			}
		}

		// Token: 0x060031BC RID: 12732 RVA: 0x0004C21C File Offset: 0x0004A41C
		void ISocialPlatform.LoadScores(ILeaderboard board, Action<bool> callback)
		{
			if (this.VerifyUser())
			{
				Leaderboard leaderboard = (Leaderboard)board;
				foreach (Leaderboard leaderboard2 in this.m_Leaderboards)
				{
					if (leaderboard2.id == leaderboard.id)
					{
						leaderboard.SetTitle(leaderboard2.title);
						leaderboard.SetScores(leaderboard2.scores);
						leaderboard.SetMaxRange((uint)leaderboard2.scores.Length);
					}
				}
				this.SortScores(leaderboard);
				this.SetLocalPlayerScore(leaderboard);
				if (callback != null)
				{
					callback(true);
				}
			}
		}

		// Token: 0x060031BD RID: 12733 RVA: 0x0004C2E8 File Offset: 0x0004A4E8
		bool ISocialPlatform.GetLoading(ILeaderboard board)
		{
			return this.VerifyUser() && ((Leaderboard)board).loading;
		}

		// Token: 0x060031BE RID: 12734 RVA: 0x0004C31C File Offset: 0x0004A51C
		private void SortScores(Leaderboard board)
		{
			List<Score> list = new List<Score>((Score[])board.scores);
			list.Sort((Score s1, Score s2) => s2.value.CompareTo(s1.value));
			for (int i = 0; i < list.Count; i++)
			{
				list[i].SetRank(i + 1);
			}
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x0004C384 File Offset: 0x0004A584
		private void SetLocalPlayerScore(Leaderboard board)
		{
			foreach (Score score in board.scores)
			{
				if (score.userID == this.localUser.id)
				{
					board.SetLocalUserScore(score);
					break;
				}
			}
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x0004C3E4 File Offset: 0x0004A5E4
		public void ShowAchievementsUI()
		{
			Debug.Log("ShowAchievementsUI not implemented");
		}

		// Token: 0x060031C1 RID: 12737 RVA: 0x0004C3F4 File Offset: 0x0004A5F4
		public void ShowLeaderboardUI()
		{
			Debug.Log("ShowLeaderboardUI not implemented");
		}

		// Token: 0x060031C2 RID: 12738 RVA: 0x0004C404 File Offset: 0x0004A604
		public ILeaderboard CreateLeaderboard()
		{
			return new Leaderboard();
		}

		// Token: 0x060031C3 RID: 12739 RVA: 0x0004C420 File Offset: 0x0004A620
		public IAchievement CreateAchievement()
		{
			return new Achievement();
		}

		// Token: 0x060031C4 RID: 12740 RVA: 0x0004C43C File Offset: 0x0004A63C
		private bool VerifyUser()
		{
			bool result;
			if (!this.localUser.authenticated)
			{
				Debug.LogError("Must authenticate first");
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060031C5 RID: 12741 RVA: 0x0004C474 File Offset: 0x0004A674
		private void PopulateStaticData()
		{
			this.m_Friends.Add(new UserProfile("Fred", "1001", true, UserState.Online, this.m_DefaultTexture));
			this.m_Friends.Add(new UserProfile("Julia", "1002", true, UserState.Online, this.m_DefaultTexture));
			this.m_Friends.Add(new UserProfile("Jeff", "1003", true, UserState.Online, this.m_DefaultTexture));
			this.m_Users.Add(new UserProfile("Sam", "1004", false, UserState.Offline, this.m_DefaultTexture));
			this.m_Users.Add(new UserProfile("Max", "1005", false, UserState.Offline, this.m_DefaultTexture));
			this.m_AchievementDescriptions.Add(new AchievementDescription("Achievement01", "First achievement", this.m_DefaultTexture, "Get first achievement", "Received first achievement", false, 10));
			this.m_AchievementDescriptions.Add(new AchievementDescription("Achievement02", "Second achievement", this.m_DefaultTexture, "Get second achievement", "Received second achievement", false, 20));
			this.m_AchievementDescriptions.Add(new AchievementDescription("Achievement03", "Third achievement", this.m_DefaultTexture, "Get third achievement", "Received third achievement", false, 15));
			Leaderboard leaderboard = new Leaderboard();
			leaderboard.SetTitle("High Scores");
			leaderboard.id = "Leaderboard01";
			leaderboard.SetScores(new List<Score>
			{
				new Score("Leaderboard01", 300L, "1001", DateTime.Now.AddDays(-1.0), "300 points", 1),
				new Score("Leaderboard01", 255L, "1002", DateTime.Now.AddDays(-1.0), "255 points", 2),
				new Score("Leaderboard01", 55L, "1003", DateTime.Now.AddDays(-1.0), "55 points", 3),
				new Score("Leaderboard01", 10L, "1004", DateTime.Now.AddDays(-1.0), "10 points", 4)
			}.ToArray());
			this.m_Leaderboards.Add(leaderboard);
		}

		// Token: 0x060031C6 RID: 12742 RVA: 0x0004C6C8 File Offset: 0x0004A8C8
		private Texture2D CreateDummyTexture(int width, int height)
		{
			Texture2D texture2D = new Texture2D(width, height);
			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					Color color = ((j & i) <= 0) ? Color.gray : Color.white;
					texture2D.SetPixel(j, i, color);
				}
			}
			texture2D.Apply();
			return texture2D;
		}

		// Token: 0x04000E4B RID: 3659
		private static LocalUser m_LocalUser = null;

		// Token: 0x04000E4C RID: 3660
		private List<UserProfile> m_Friends = new List<UserProfile>();

		// Token: 0x04000E4D RID: 3661
		private List<UserProfile> m_Users = new List<UserProfile>();

		// Token: 0x04000E4E RID: 3662
		private List<AchievementDescription> m_AchievementDescriptions = new List<AchievementDescription>();

		// Token: 0x04000E4F RID: 3663
		private List<Achievement> m_Achievements = new List<Achievement>();

		// Token: 0x04000E50 RID: 3664
		private List<Leaderboard> m_Leaderboards = new List<Leaderboard>();

		// Token: 0x04000E51 RID: 3665
		private Texture2D m_DefaultTexture;
	}
}
