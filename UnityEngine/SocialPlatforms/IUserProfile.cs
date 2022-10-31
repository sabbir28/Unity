using System;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x020003B2 RID: 946
	public interface IUserProfile
	{
		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06003222 RID: 12834
		string userName { get; }

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06003223 RID: 12835
		string id { get; }

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x06003224 RID: 12836
		bool isFriend { get; }

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06003225 RID: 12837
		UserState state { get; }

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06003226 RID: 12838
		Texture2D image { get; }
	}
}
