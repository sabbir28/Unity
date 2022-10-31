using System;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x0200039E RID: 926
	public class UserProfile : IUserProfile
	{
		// Token: 0x06003162 RID: 12642 RVA: 0x0004B1EC File Offset: 0x000493EC
		public UserProfile()
		{
			this.m_UserName = "Uninitialized";
			this.m_ID = "0";
			this.m_IsFriend = false;
			this.m_State = UserState.Offline;
			this.m_Image = new Texture2D(32, 32);
		}

		// Token: 0x06003163 RID: 12643 RVA: 0x0004B228 File Offset: 0x00049428
		public UserProfile(string name, string id, bool friend) : this(name, id, friend, UserState.Offline, new Texture2D(0, 0))
		{
		}

		// Token: 0x06003164 RID: 12644 RVA: 0x0004B23C File Offset: 0x0004943C
		public UserProfile(string name, string id, bool friend, UserState state, Texture2D image)
		{
			this.m_UserName = name;
			this.m_ID = id;
			this.m_IsFriend = friend;
			this.m_State = state;
			this.m_Image = image;
		}

		// Token: 0x06003165 RID: 12645 RVA: 0x0004B26C File Offset: 0x0004946C
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				this.id,
				" - ",
				this.userName,
				" - ",
				this.isFriend,
				" - ",
				this.state
			});
		}

		// Token: 0x06003166 RID: 12646 RVA: 0x0004B2D4 File Offset: 0x000494D4
		public void SetUserName(string name)
		{
			this.m_UserName = name;
		}

		// Token: 0x06003167 RID: 12647 RVA: 0x0004B2E0 File Offset: 0x000494E0
		public void SetUserID(string id)
		{
			this.m_ID = id;
		}

		// Token: 0x06003168 RID: 12648 RVA: 0x0004B2EC File Offset: 0x000494EC
		public void SetImage(Texture2D image)
		{
			this.m_Image = image;
		}

		// Token: 0x06003169 RID: 12649 RVA: 0x0004B2F8 File Offset: 0x000494F8
		public void SetIsFriend(bool value)
		{
			this.m_IsFriend = value;
		}

		// Token: 0x0600316A RID: 12650 RVA: 0x0004B304 File Offset: 0x00049504
		public void SetState(UserState state)
		{
			this.m_State = state;
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x0600316B RID: 12651 RVA: 0x0004B310 File Offset: 0x00049510
		public string userName
		{
			get
			{
				return this.m_UserName;
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x0600316C RID: 12652 RVA: 0x0004B32C File Offset: 0x0004952C
		public string id
		{
			get
			{
				return this.m_ID;
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x0600316D RID: 12653 RVA: 0x0004B348 File Offset: 0x00049548
		public bool isFriend
		{
			get
			{
				return this.m_IsFriend;
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x0600316E RID: 12654 RVA: 0x0004B364 File Offset: 0x00049564
		public UserState state
		{
			get
			{
				return this.m_State;
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x0600316F RID: 12655 RVA: 0x0004B380 File Offset: 0x00049580
		public Texture2D image
		{
			get
			{
				return this.m_Image;
			}
		}

		// Token: 0x04000E2A RID: 3626
		protected string m_UserName;

		// Token: 0x04000E2B RID: 3627
		protected string m_ID;

		// Token: 0x04000E2C RID: 3628
		protected bool m_IsFriend;

		// Token: 0x04000E2D RID: 3629
		protected UserState m_State;

		// Token: 0x04000E2E RID: 3630
		protected Texture2D m_Image;
	}
}
