using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.UI
{
	// Token: 0x02000048 RID: 72
	public static class FontUpdateTracker
	{
		// Token: 0x06000221 RID: 545 RVA: 0x0000AF04 File Offset: 0x00009304
		public static void TrackText(Text t)
		{
			if (!(t.font == null))
			{
				HashSet<Text> hashSet;
				FontUpdateTracker.m_Tracked.TryGetValue(t.font, out hashSet);
				if (hashSet == null)
				{
					if (FontUpdateTracker.m_Tracked.Count == 0)
					{
						if (FontUpdateTracker.<>f__mg$cache0 == null)
						{
							FontUpdateTracker.<>f__mg$cache0 = new Action<Font>(FontUpdateTracker.RebuildForFont);
						}
						Font.textureRebuilt += FontUpdateTracker.<>f__mg$cache0;
					}
					hashSet = new HashSet<Text>();
					FontUpdateTracker.m_Tracked.Add(t.font, hashSet);
				}
				if (!hashSet.Contains(t))
				{
					hashSet.Add(t);
				}
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000AFA0 File Offset: 0x000093A0
		private static void RebuildForFont(Font f)
		{
			HashSet<Text> hashSet;
			FontUpdateTracker.m_Tracked.TryGetValue(f, out hashSet);
			if (hashSet != null)
			{
				foreach (Text text in hashSet)
				{
					text.FontTextureChanged();
				}
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000B014 File Offset: 0x00009414
		public static void UntrackText(Text t)
		{
			if (!(t.font == null))
			{
				HashSet<Text> hashSet;
				FontUpdateTracker.m_Tracked.TryGetValue(t.font, out hashSet);
				if (hashSet != null)
				{
					hashSet.Remove(t);
					if (hashSet.Count == 0)
					{
						FontUpdateTracker.m_Tracked.Remove(t.font);
						if (FontUpdateTracker.m_Tracked.Count == 0)
						{
							if (FontUpdateTracker.<>f__mg$cache1 == null)
							{
								FontUpdateTracker.<>f__mg$cache1 = new Action<Font>(FontUpdateTracker.RebuildForFont);
							}
							Font.textureRebuilt -= FontUpdateTracker.<>f__mg$cache1;
						}
					}
				}
			}
		}

		// Token: 0x04000104 RID: 260
		private static Dictionary<Font, HashSet<Text>> m_Tracked = new Dictionary<Font, HashSet<Text>>();

		// Token: 0x04000105 RID: 261
		[CompilerGenerated]
		private static Action<Font> <>f__mg$cache0;

		// Token: 0x04000106 RID: 262
		[CompilerGenerated]
		private static Action<Font> <>f__mg$cache1;
	}
}
