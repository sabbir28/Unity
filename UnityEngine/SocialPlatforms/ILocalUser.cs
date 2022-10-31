using System;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x020003B0 RID: 944
	public interface ILocalUser : IUserProfile
	{
		// Token: 0x0600321C RID: 12828
		void Authenticate(Action<bool> callback);

		// Token: 0x0600321D RID: 12829
		void Authenticate(Action<bool, string> callback);

		// Token: 0x0600321E RID: 12830
		void LoadFriends(Action<bool> callback);

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x0600321F RID: 12831
		IUserProfile[] friends { get; }

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06003220 RID: 12832
		bool authenticated { get; }

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06003221 RID: 12833
		bool underage { get; }
	}
}
