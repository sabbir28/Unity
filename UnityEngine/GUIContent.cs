using System;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	// Token: 0x02000250 RID: 592
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GUIContent
	{
		// Token: 0x060027E9 RID: 10217 RVA: 0x00030D9C File Offset: 0x0002EF9C
		public GUIContent()
		{
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x00030DBC File Offset: 0x0002EFBC
		public GUIContent(string text) : this(text, null, string.Empty)
		{
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x00030DCC File Offset: 0x0002EFCC
		public GUIContent(Texture image) : this(string.Empty, image, string.Empty)
		{
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x00030DE0 File Offset: 0x0002EFE0
		public GUIContent(string text, Texture image) : this(text, image, string.Empty)
		{
		}

		// Token: 0x060027ED RID: 10221 RVA: 0x00030DF0 File Offset: 0x0002EFF0
		public GUIContent(string text, string tooltip) : this(text, null, tooltip)
		{
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x00030DFC File Offset: 0x0002EFFC
		public GUIContent(Texture image, string tooltip) : this(string.Empty, image, tooltip)
		{
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x00030E0C File Offset: 0x0002F00C
		public GUIContent(string text, Texture image, string tooltip)
		{
			this.text = text;
			this.image = image;
			this.tooltip = tooltip;
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x00030E40 File Offset: 0x0002F040
		public GUIContent(GUIContent src)
		{
			this.text = src.m_Text;
			this.image = src.m_Image;
			this.tooltip = src.m_Tooltip;
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x060027F1 RID: 10225 RVA: 0x00030E90 File Offset: 0x0002F090
		// (set) Token: 0x060027F2 RID: 10226 RVA: 0x00030EAC File Offset: 0x0002F0AC
		public string text
		{
			get
			{
				return this.m_Text;
			}
			set
			{
				this.m_Text = value;
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x060027F3 RID: 10227 RVA: 0x00030EB8 File Offset: 0x0002F0B8
		// (set) Token: 0x060027F4 RID: 10228 RVA: 0x00030ED4 File Offset: 0x0002F0D4
		public Texture image
		{
			get
			{
				return this.m_Image;
			}
			set
			{
				this.m_Image = value;
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x060027F5 RID: 10229 RVA: 0x00030EE0 File Offset: 0x0002F0E0
		// (set) Token: 0x060027F6 RID: 10230 RVA: 0x00030EFC File Offset: 0x0002F0FC
		public string tooltip
		{
			get
			{
				return this.m_Tooltip;
			}
			set
			{
				this.m_Tooltip = value;
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x060027F7 RID: 10231 RVA: 0x00030F08 File Offset: 0x0002F108
		internal int hash
		{
			get
			{
				int result = 0;
				if (!string.IsNullOrEmpty(this.m_Text))
				{
					result = this.m_Text.GetHashCode() * 37;
				}
				return result;
			}
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x00030F40 File Offset: 0x0002F140
		internal static GUIContent Temp(string t)
		{
			GUIContent.s_Text.m_Text = t;
			GUIContent.s_Text.m_Tooltip = string.Empty;
			return GUIContent.s_Text;
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x00030F74 File Offset: 0x0002F174
		internal static GUIContent Temp(string t, string tooltip)
		{
			GUIContent.s_Text.m_Text = t;
			GUIContent.s_Text.m_Tooltip = tooltip;
			return GUIContent.s_Text;
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x00030FA4 File Offset: 0x0002F1A4
		internal static GUIContent Temp(Texture i)
		{
			GUIContent.s_Image.m_Image = i;
			GUIContent.s_Image.m_Tooltip = string.Empty;
			return GUIContent.s_Image;
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x00030FD8 File Offset: 0x0002F1D8
		internal static GUIContent Temp(Texture i, string tooltip)
		{
			GUIContent.s_Image.m_Image = i;
			GUIContent.s_Image.m_Tooltip = tooltip;
			return GUIContent.s_Image;
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x00031008 File Offset: 0x0002F208
		internal static GUIContent Temp(string t, Texture i)
		{
			GUIContent.s_TextImage.m_Text = t;
			GUIContent.s_TextImage.m_Image = i;
			return GUIContent.s_TextImage;
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x00031038 File Offset: 0x0002F238
		internal static void ClearStaticCache()
		{
			GUIContent.s_Text.m_Text = null;
			GUIContent.s_Text.m_Tooltip = string.Empty;
			GUIContent.s_Image.m_Image = null;
			GUIContent.s_Image.m_Tooltip = string.Empty;
			GUIContent.s_TextImage.m_Text = null;
			GUIContent.s_TextImage.m_Image = null;
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x00031090 File Offset: 0x0002F290
		internal static GUIContent[] Temp(string[] texts)
		{
			GUIContent[] array = new GUIContent[texts.Length];
			for (int i = 0; i < texts.Length; i++)
			{
				array[i] = new GUIContent(texts[i]);
			}
			return array;
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x000310D0 File Offset: 0x0002F2D0
		internal static GUIContent[] Temp(Texture[] images)
		{
			GUIContent[] array = new GUIContent[images.Length];
			for (int i = 0; i < images.Length; i++)
			{
				array[i] = new GUIContent(images[i]);
			}
			return array;
		}

		// Token: 0x0400070F RID: 1807
		[SerializeField]
		private string m_Text = string.Empty;

		// Token: 0x04000710 RID: 1808
		[SerializeField]
		private Texture m_Image;

		// Token: 0x04000711 RID: 1809
		[SerializeField]
		private string m_Tooltip = string.Empty;

		// Token: 0x04000712 RID: 1810
		private static readonly GUIContent s_Text = new GUIContent();

		// Token: 0x04000713 RID: 1811
		private static readonly GUIContent s_Image = new GUIContent();

		// Token: 0x04000714 RID: 1812
		private static readonly GUIContent s_TextImage = new GUIContent();

		// Token: 0x04000715 RID: 1813
		public static GUIContent none = new GUIContent("");
	}
}
