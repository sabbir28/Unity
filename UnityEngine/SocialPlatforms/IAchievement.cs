using System;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x020003B3 RID: 947
	public interface IAchievement
	{
		// Token: 0x06003227 RID: 12839
		void ReportProgress(Action<bool> callback);

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06003228 RID: 12840
		// (set) Token: 0x06003229 RID: 12841
		string id { get; set; }

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x0600322A RID: 12842
		// (set) Token: 0x0600322B RID: 12843
		double percentCompleted { get; set; }

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x0600322C RID: 12844
		bool completed { get; }

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x0600322D RID: 12845
		bool hidden { get; }

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x0600322E RID: 12846
		DateTime lastReportedDate { get; }
	}
}
