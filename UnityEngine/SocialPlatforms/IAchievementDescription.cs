using System;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x020003B4 RID: 948
	public interface IAchievementDescription
	{
		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x0600322F RID: 12847
		// (set) Token: 0x06003230 RID: 12848
		string id { get; set; }

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06003231 RID: 12849
		string title { get; }

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06003232 RID: 12850
		Texture2D image { get; }

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06003233 RID: 12851
		string achievedDescription { get; }

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06003234 RID: 12852
		string unachievedDescription { get; }

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06003235 RID: 12853
		bool hidden { get; }

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06003236 RID: 12854
		int points { get; }
	}
}
