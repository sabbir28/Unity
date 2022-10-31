using System;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x0200039F RID: 927
	public class Achievement : IAchievement
	{
		// Token: 0x06003170 RID: 12656 RVA: 0x0004B39C File Offset: 0x0004959C
		public Achievement(string id, double percentCompleted, bool completed, bool hidden, DateTime lastReportedDate)
		{
			this.id = id;
			this.percentCompleted = percentCompleted;
			this.m_Completed = completed;
			this.m_Hidden = hidden;
			this.m_LastReportedDate = lastReportedDate;
		}

		// Token: 0x06003171 RID: 12657 RVA: 0x0004B3CC File Offset: 0x000495CC
		public Achievement(string id, double percent)
		{
			this.id = id;
			this.percentCompleted = percent;
			this.m_Hidden = false;
			this.m_Completed = false;
			this.m_LastReportedDate = DateTime.MinValue;
		}

		// Token: 0x06003172 RID: 12658 RVA: 0x0004B3FC File Offset: 0x000495FC
		public Achievement() : this("unknown", 0.0)
		{
		}

		// Token: 0x06003173 RID: 12659 RVA: 0x0004B414 File Offset: 0x00049614
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				this.id,
				" - ",
				this.percentCompleted,
				" - ",
				this.completed,
				" - ",
				this.hidden,
				" - ",
				this.lastReportedDate
			});
		}

		// Token: 0x06003174 RID: 12660 RVA: 0x0004B498 File Offset: 0x00049698
		public void ReportProgress(Action<bool> callback)
		{
			ActivePlatform.Instance.ReportProgress(this.id, this.percentCompleted, callback);
		}

		// Token: 0x06003175 RID: 12661 RVA: 0x0004B4B4 File Offset: 0x000496B4
		public void SetCompleted(bool value)
		{
			this.m_Completed = value;
		}

		// Token: 0x06003176 RID: 12662 RVA: 0x0004B4C0 File Offset: 0x000496C0
		public void SetHidden(bool value)
		{
			this.m_Hidden = value;
		}

		// Token: 0x06003177 RID: 12663 RVA: 0x0004B4CC File Offset: 0x000496CC
		public void SetLastReportedDate(DateTime date)
		{
			this.m_LastReportedDate = date;
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06003178 RID: 12664 RVA: 0x0004B4D8 File Offset: 0x000496D8
		// (set) Token: 0x06003179 RID: 12665 RVA: 0x0004B4F4 File Offset: 0x000496F4
		public string id { get; set; }

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x0600317A RID: 12666 RVA: 0x0004B500 File Offset: 0x00049700
		// (set) Token: 0x0600317B RID: 12667 RVA: 0x0004B51C File Offset: 0x0004971C
		public double percentCompleted { get; set; }

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x0600317C RID: 12668 RVA: 0x0004B528 File Offset: 0x00049728
		public bool completed
		{
			get
			{
				return this.m_Completed;
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x0600317D RID: 12669 RVA: 0x0004B544 File Offset: 0x00049744
		public bool hidden
		{
			get
			{
				return this.m_Hidden;
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x0600317E RID: 12670 RVA: 0x0004B560 File Offset: 0x00049760
		public DateTime lastReportedDate
		{
			get
			{
				return this.m_LastReportedDate;
			}
		}

		// Token: 0x04000E2F RID: 3631
		private bool m_Completed;

		// Token: 0x04000E30 RID: 3632
		private bool m_Hidden;

		// Token: 0x04000E31 RID: 3633
		private DateTime m_LastReportedDate;
	}
}
