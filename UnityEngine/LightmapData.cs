using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000054 RID: 84
	[UsedByNativeCode]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class LightmapData
	{
		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x00009078 File Offset: 0x00007278
		// (set) Token: 0x060006C9 RID: 1737 RVA: 0x00009094 File Offset: 0x00007294
		[Obsolete("Use lightmapColor property (UnityUpgradable) -> lightmapColor")]
		public Texture2D lightmapLight
		{
			get
			{
				return this.m_Light;
			}
			set
			{
				this.m_Light = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x000090A0 File Offset: 0x000072A0
		// (set) Token: 0x060006CB RID: 1739 RVA: 0x000090BC File Offset: 0x000072BC
		public Texture2D lightmapColor
		{
			get
			{
				return this.m_Light;
			}
			set
			{
				this.m_Light = value;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x000090C8 File Offset: 0x000072C8
		// (set) Token: 0x060006CD RID: 1741 RVA: 0x000090E4 File Offset: 0x000072E4
		public Texture2D lightmapDir
		{
			get
			{
				return this.m_Dir;
			}
			set
			{
				this.m_Dir = value;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x000090F0 File Offset: 0x000072F0
		// (set) Token: 0x060006CF RID: 1743 RVA: 0x0000910C File Offset: 0x0000730C
		public Texture2D shadowMask
		{
			get
			{
				return this.m_ShadowMask;
			}
			set
			{
				this.m_ShadowMask = value;
			}
		}

		// Token: 0x0400006D RID: 109
		internal Texture2D m_Light;

		// Token: 0x0400006E RID: 110
		internal Texture2D m_Dir;

		// Token: 0x0400006F RID: 111
		internal Texture2D m_ShadowMask;
	}
}
