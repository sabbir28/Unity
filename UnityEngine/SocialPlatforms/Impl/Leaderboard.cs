using System;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x020003A2 RID: 930
	public class Leaderboard : ILeaderboard
	{
		// Token: 0x0600319B RID: 12699 RVA: 0x0004B91C File Offset: 0x00049B1C
		public Leaderboard()
		{
			this.id = "Invalid";
			this.range = new Range(1, 10);
			this.userScope = UserScope.Global;
			this.timeScope = TimeScope.AllTime;
			this.m_Loading = false;
			this.m_LocalUserScore = new Score("Invalid", 0L);
			this.m_MaxRange = 0U;
			this.m_Scores = new Score[0];
			this.m_Title = "Invalid";
			this.m_UserIDs = new string[0];
		}

		// Token: 0x0600319C RID: 12700 RVA: 0x0004B99C File Offset: 0x00049B9C
		public void SetUserFilter(string[] userIDs)
		{
			this.m_UserIDs = userIDs;
		}

		// Token: 0x0600319D RID: 12701 RVA: 0x0004B9A8 File Offset: 0x00049BA8
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				"ID: '",
				this.id,
				"' Title: '",
				this.m_Title,
				"' Loading: '",
				this.m_Loading,
				"' Range: [",
				this.range.from,
				",",
				this.range.count,
				"] MaxRange: '",
				this.m_MaxRange,
				"' Scores: '",
				this.m_Scores.Length,
				"' UserScope: '",
				this.userScope,
				"' TimeScope: '",
				this.timeScope,
				"' UserFilter: '",
				this.m_UserIDs.Length
			});
		}

		// Token: 0x0600319E RID: 12702 RVA: 0x0004BABC File Offset: 0x00049CBC
		public void LoadScores(Action<bool> callback)
		{
			ActivePlatform.Instance.LoadScores(this, callback);
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x0600319F RID: 12703 RVA: 0x0004BACC File Offset: 0x00049CCC
		public bool loading
		{
			get
			{
				return ActivePlatform.Instance.GetLoading(this);
			}
		}

		// Token: 0x060031A0 RID: 12704 RVA: 0x0004BAEC File Offset: 0x00049CEC
		public void SetLocalUserScore(IScore score)
		{
			this.m_LocalUserScore = score;
		}

		// Token: 0x060031A1 RID: 12705 RVA: 0x0004BAF8 File Offset: 0x00049CF8
		public void SetMaxRange(uint maxRange)
		{
			this.m_MaxRange = maxRange;
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x0004BB04 File Offset: 0x00049D04
		public void SetScores(IScore[] scores)
		{
			this.m_Scores = scores;
		}

		// Token: 0x060031A3 RID: 12707 RVA: 0x0004BB10 File Offset: 0x00049D10
		public void SetTitle(string title)
		{
			this.m_Title = title;
		}

		// Token: 0x060031A4 RID: 12708 RVA: 0x0004BB1C File Offset: 0x00049D1C
		public string[] GetUserFilter()
		{
			return this.m_UserIDs;
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x060031A5 RID: 12709 RVA: 0x0004BB38 File Offset: 0x00049D38
		// (set) Token: 0x060031A6 RID: 12710 RVA: 0x0004BB54 File Offset: 0x00049D54
		public string id { get; set; }

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x060031A7 RID: 12711 RVA: 0x0004BB60 File Offset: 0x00049D60
		// (set) Token: 0x060031A8 RID: 12712 RVA: 0x0004BB7C File Offset: 0x00049D7C
		public UserScope userScope { get; set; }

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x060031A9 RID: 12713 RVA: 0x0004BB88 File Offset: 0x00049D88
		// (set) Token: 0x060031AA RID: 12714 RVA: 0x0004BBA4 File Offset: 0x00049DA4
		public Range range { get; set; }

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x060031AB RID: 12715 RVA: 0x0004BBB0 File Offset: 0x00049DB0
		// (set) Token: 0x060031AC RID: 12716 RVA: 0x0004BBCC File Offset: 0x00049DCC
		public TimeScope timeScope { get; set; }

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x060031AD RID: 12717 RVA: 0x0004BBD8 File Offset: 0x00049DD8
		public IScore localUserScore
		{
			get
			{
				return this.m_LocalUserScore;
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x060031AE RID: 12718 RVA: 0x0004BBF4 File Offset: 0x00049DF4
		public uint maxRange
		{
			get
			{
				return this.m_MaxRange;
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x060031AF RID: 12719 RVA: 0x0004BC10 File Offset: 0x00049E10
		public IScore[] scores
		{
			get
			{
				return this.m_Scores;
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x060031B0 RID: 12720 RVA: 0x0004BC2C File Offset: 0x00049E2C
		public string title
		{
			get
			{
				return this.m_Title;
			}
		}

		// Token: 0x04000E41 RID: 3649
		private bool m_Loading;

		// Token: 0x04000E42 RID: 3650
		private IScore m_LocalUserScore;

		// Token: 0x04000E43 RID: 3651
		private uint m_MaxRange;

		// Token: 0x04000E44 RID: 3652
		private IScore[] m_Scores;

		// Token: 0x04000E45 RID: 3653
		private string m_Title;

		// Token: 0x04000E46 RID: 3654
		private string[] m_UserIDs;
	}
}
