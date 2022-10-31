using System;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x020003A1 RID: 929
	public class Score : IScore
	{
		// Token: 0x0600318A RID: 12682 RVA: 0x0004B724 File Offset: 0x00049924
		public Score() : this("unkown", -1L)
		{
		}

		// Token: 0x0600318B RID: 12683 RVA: 0x0004B734 File Offset: 0x00049934
		public Score(string leaderboardID, long value) : this(leaderboardID, value, "0", DateTime.Now, "", -1)
		{
		}

		// Token: 0x0600318C RID: 12684 RVA: 0x0004B750 File Offset: 0x00049950
		public Score(string leaderboardID, long value, string userID, DateTime date, string formattedValue, int rank)
		{
			this.leaderboardID = leaderboardID;
			this.value = value;
			this.m_UserID = userID;
			this.m_Date = date;
			this.m_FormattedValue = formattedValue;
			this.m_Rank = rank;
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x0004B788 File Offset: 0x00049988
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				"Rank: '",
				this.m_Rank,
				"' Value: '",
				this.value,
				"' Category: '",
				this.leaderboardID,
				"' PlayerID: '",
				this.m_UserID,
				"' Date: '",
				this.m_Date
			});
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x0004B810 File Offset: 0x00049A10
		public void ReportScore(Action<bool> callback)
		{
			ActivePlatform.Instance.ReportScore(this.value, this.leaderboardID, callback);
		}

		// Token: 0x0600318F RID: 12687 RVA: 0x0004B82C File Offset: 0x00049A2C
		public void SetDate(DateTime date)
		{
			this.m_Date = date;
		}

		// Token: 0x06003190 RID: 12688 RVA: 0x0004B838 File Offset: 0x00049A38
		public void SetFormattedValue(string value)
		{
			this.m_FormattedValue = value;
		}

		// Token: 0x06003191 RID: 12689 RVA: 0x0004B844 File Offset: 0x00049A44
		public void SetUserID(string userID)
		{
			this.m_UserID = userID;
		}

		// Token: 0x06003192 RID: 12690 RVA: 0x0004B850 File Offset: 0x00049A50
		public void SetRank(int rank)
		{
			this.m_Rank = rank;
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06003193 RID: 12691 RVA: 0x0004B85C File Offset: 0x00049A5C
		// (set) Token: 0x06003194 RID: 12692 RVA: 0x0004B878 File Offset: 0x00049A78
		public string leaderboardID { get; set; }

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06003195 RID: 12693 RVA: 0x0004B884 File Offset: 0x00049A84
		// (set) Token: 0x06003196 RID: 12694 RVA: 0x0004B8A0 File Offset: 0x00049AA0
		public long value { get; set; }

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06003197 RID: 12695 RVA: 0x0004B8AC File Offset: 0x00049AAC
		public DateTime date
		{
			get
			{
				return this.m_Date;
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06003198 RID: 12696 RVA: 0x0004B8C8 File Offset: 0x00049AC8
		public string formattedValue
		{
			get
			{
				return this.m_FormattedValue;
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06003199 RID: 12697 RVA: 0x0004B8E4 File Offset: 0x00049AE4
		public string userID
		{
			get
			{
				return this.m_UserID;
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x0600319A RID: 12698 RVA: 0x0004B900 File Offset: 0x00049B00
		public int rank
		{
			get
			{
				return this.m_Rank;
			}
		}

		// Token: 0x04000E3B RID: 3643
		private DateTime m_Date;

		// Token: 0x04000E3C RID: 3644
		private string m_FormattedValue;

		// Token: 0x04000E3D RID: 3645
		private string m_UserID;

		// Token: 0x04000E3E RID: 3646
		private int m_Rank;
	}
}
