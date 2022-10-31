using System;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x0200039D RID: 925
	public class LocalUser : UserProfile, ILocalUser, IUserProfile
	{
		// Token: 0x06003158 RID: 12632 RVA: 0x0004B120 File Offset: 0x00049320
		public LocalUser()
		{
			this.m_Friends = new UserProfile[0];
			this.m_Authenticated = false;
			this.m_Underage = false;
		}

		// Token: 0x06003159 RID: 12633 RVA: 0x0004B144 File Offset: 0x00049344
		public void Authenticate(Action<bool> callback)
		{
			ActivePlatform.Instance.Authenticate(this, callback);
		}

		// Token: 0x0600315A RID: 12634 RVA: 0x0004B154 File Offset: 0x00049354
		public void Authenticate(Action<bool, string> callback)
		{
			ActivePlatform.Instance.Authenticate(this, callback);
		}

		// Token: 0x0600315B RID: 12635 RVA: 0x0004B164 File Offset: 0x00049364
		public void LoadFriends(Action<bool> callback)
		{
			ActivePlatform.Instance.LoadFriends(this, callback);
		}

		// Token: 0x0600315C RID: 12636 RVA: 0x0004B174 File Offset: 0x00049374
		public void SetFriends(IUserProfile[] friends)
		{
			this.m_Friends = friends;
		}

		// Token: 0x0600315D RID: 12637 RVA: 0x0004B180 File Offset: 0x00049380
		public void SetAuthenticated(bool value)
		{
			this.m_Authenticated = value;
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x0004B18C File Offset: 0x0004938C
		public void SetUnderage(bool value)
		{
			this.m_Underage = value;
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x0600315F RID: 12639 RVA: 0x0004B198 File Offset: 0x00049398
		public IUserProfile[] friends
		{
			get
			{
				return this.m_Friends;
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x06003160 RID: 12640 RVA: 0x0004B1B4 File Offset: 0x000493B4
		public bool authenticated
		{
			get
			{
				return this.m_Authenticated;
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06003161 RID: 12641 RVA: 0x0004B1D0 File Offset: 0x000493D0
		public bool underage
		{
			get
			{
				return this.m_Underage;
			}
		}

		// Token: 0x04000E27 RID: 3623
		private IUserProfile[] m_Friends;

		// Token: 0x04000E28 RID: 3624
		private bool m_Authenticated;

		// Token: 0x04000E29 RID: 3625
		private bool m_Underage;
	}
}
