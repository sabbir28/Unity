using System;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x020003AE RID: 942
	internal static class ActivePlatform
	{
		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x06003209 RID: 12809 RVA: 0x0004D418 File Offset: 0x0004B618
		// (set) Token: 0x0600320A RID: 12810 RVA: 0x0004D448 File Offset: 0x0004B648
		internal static ISocialPlatform Instance
		{
			get
			{
				if (ActivePlatform._active == null)
				{
					ActivePlatform._active = ActivePlatform.SelectSocialPlatform();
				}
				return ActivePlatform._active;
			}
			set
			{
				ActivePlatform._active = value;
			}
		}

		// Token: 0x0600320B RID: 12811 RVA: 0x0004D454 File Offset: 0x0004B654
		private static ISocialPlatform SelectSocialPlatform()
		{
			return new Local();
		}

		// Token: 0x04000E6E RID: 3694
		private static ISocialPlatform _active;
	}
}
