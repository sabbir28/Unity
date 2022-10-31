using System;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x020003A0 RID: 928
	public class AchievementDescription : IAchievementDescription
	{
		// Token: 0x0600317F RID: 12671 RVA: 0x0004B57C File Offset: 0x0004977C
		public AchievementDescription(string id, string title, Texture2D image, string achievedDescription, string unachievedDescription, bool hidden, int points)
		{
			this.id = id;
			this.m_Title = title;
			this.m_Image = image;
			this.m_AchievedDescription = achievedDescription;
			this.m_UnachievedDescription = unachievedDescription;
			this.m_Hidden = hidden;
			this.m_Points = points;
		}

		// Token: 0x06003180 RID: 12672 RVA: 0x0004B5BC File Offset: 0x000497BC
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				this.id,
				" - ",
				this.title,
				" - ",
				this.achievedDescription,
				" - ",
				this.unachievedDescription,
				" - ",
				this.points,
				" - ",
				this.hidden
			});
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x0004B648 File Offset: 0x00049848
		public void SetImage(Texture2D image)
		{
			this.m_Image = image;
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06003182 RID: 12674 RVA: 0x0004B654 File Offset: 0x00049854
		// (set) Token: 0x06003183 RID: 12675 RVA: 0x0004B670 File Offset: 0x00049870
		public string id { get; set; }

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06003184 RID: 12676 RVA: 0x0004B67C File Offset: 0x0004987C
		public string title
		{
			get
			{
				return this.m_Title;
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06003185 RID: 12677 RVA: 0x0004B698 File Offset: 0x00049898
		public Texture2D image
		{
			get
			{
				return this.m_Image;
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06003186 RID: 12678 RVA: 0x0004B6B4 File Offset: 0x000498B4
		public string achievedDescription
		{
			get
			{
				return this.m_AchievedDescription;
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06003187 RID: 12679 RVA: 0x0004B6D0 File Offset: 0x000498D0
		public string unachievedDescription
		{
			get
			{
				return this.m_UnachievedDescription;
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06003188 RID: 12680 RVA: 0x0004B6EC File Offset: 0x000498EC
		public bool hidden
		{
			get
			{
				return this.m_Hidden;
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06003189 RID: 12681 RVA: 0x0004B708 File Offset: 0x00049908
		public int points
		{
			get
			{
				return this.m_Points;
			}
		}

		// Token: 0x04000E34 RID: 3636
		private string m_Title;

		// Token: 0x04000E35 RID: 3637
		private Texture2D m_Image;

		// Token: 0x04000E36 RID: 3638
		private string m_AchievedDescription;

		// Token: 0x04000E37 RID: 3639
		private string m_UnachievedDescription;

		// Token: 0x04000E38 RID: 3640
		private bool m_Hidden;

		// Token: 0x04000E39 RID: 3641
		private int m_Points;
	}
}
