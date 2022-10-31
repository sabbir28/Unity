using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200005A RID: 90
	public sealed class Screen
	{
		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060006F2 RID: 1778
		public static extern Resolution[] resolutions { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060006F3 RID: 1779
		public static extern Resolution currentResolution { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060006F4 RID: 1780
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetResolution(int width, int height, bool fullscreen, [UnityEngine.Internal.DefaultValue("0")] int preferredRefreshRate);

		// Token: 0x060006F5 RID: 1781 RVA: 0x00009288 File Offset: 0x00007488
		[ExcludeFromDocs]
		public static void SetResolution(int width, int height, bool fullscreen)
		{
			int preferredRefreshRate = 0;
			Screen.SetResolution(width, height, fullscreen, preferredRefreshRate);
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060006F6 RID: 1782
		[ThreadAndSerializationSafe]
		public static extern int width { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060006F7 RID: 1783
		[ThreadAndSerializationSafe]
		public static extern int height { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060006F8 RID: 1784
		public static extern float dpi { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060006F9 RID: 1785
		// (set) Token: 0x060006FA RID: 1786
		public static extern bool fullScreen { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060006FB RID: 1787
		// (set) Token: 0x060006FC RID: 1788
		public static extern bool autorotateToPortrait { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060006FD RID: 1789
		// (set) Token: 0x060006FE RID: 1790
		public static extern bool autorotateToPortraitUpsideDown { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060006FF RID: 1791
		// (set) Token: 0x06000700 RID: 1792
		public static extern bool autorotateToLandscapeLeft { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000701 RID: 1793
		// (set) Token: 0x06000702 RID: 1794
		public static extern bool autorotateToLandscapeRight { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000703 RID: 1795
		// (set) Token: 0x06000704 RID: 1796
		public static extern ScreenOrientation orientation { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000705 RID: 1797
		// (set) Token: 0x06000706 RID: 1798
		public static extern int sleepTimeout { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x000092A4 File Offset: 0x000074A4
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x000092C4 File Offset: 0x000074C4
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Cursor.lockState and Cursor.visible instead.", false)]
		public static bool lockCursor
		{
			get
			{
				return CursorLockMode.Locked == Cursor.lockState;
			}
			set
			{
				if (value)
				{
					Cursor.visible = false;
					Cursor.lockState = CursorLockMode.Locked;
				}
				else
				{
					Cursor.lockState = CursorLockMode.None;
					Cursor.visible = true;
				}
			}
		}
	}
}
