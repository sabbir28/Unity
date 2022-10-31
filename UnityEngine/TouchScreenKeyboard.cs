using System;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x02000065 RID: 101
	public sealed class TouchScreenKeyboard
	{
		// Token: 0x06000773 RID: 1907 RVA: 0x00009688 File Offset: 0x00007888
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert)
		{
			string textPlaceholder = "";
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x000096B4 File Offset: 0x000078B4
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure)
		{
			string textPlaceholder = "";
			bool alert = false;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x000096E0 File Offset: 0x000078E0
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline)
		{
			string textPlaceholder = "";
			bool alert = false;
			bool secure = false;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0000970C File Offset: 0x0000790C
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection)
		{
			string textPlaceholder = "";
			bool alert = false;
			bool secure = false;
			bool multiline = false;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder);
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x0000973C File Offset: 0x0000793C
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType)
		{
			string textPlaceholder = "";
			bool alert = false;
			bool secure = false;
			bool multiline = false;
			bool autocorrection = true;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder);
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00009770 File Offset: 0x00007970
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text)
		{
			string textPlaceholder = "";
			bool alert = false;
			bool secure = false;
			bool multiline = false;
			bool autocorrection = true;
			TouchScreenKeyboardType keyboardType = TouchScreenKeyboardType.Default;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x000097A8 File Offset: 0x000079A8
		public static TouchScreenKeyboard Open(string text, [DefaultValue("TouchScreenKeyboardType.Default")] TouchScreenKeyboardType keyboardType, [DefaultValue("true")] bool autocorrection, [DefaultValue("false")] bool multiline, [DefaultValue("false")] bool secure, [DefaultValue("false")] bool alert, [DefaultValue("\"\"")] string textPlaceholder)
		{
			return null;
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x000097C0 File Offset: 0x000079C0
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x000097DC File Offset: 0x000079DC
		public string text
		{
			get
			{
				return string.Empty;
			}
			set
			{
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x000097E0 File Offset: 0x000079E0
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x000097F8 File Offset: 0x000079F8
		public static bool hideInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x000097FC File Offset: 0x000079FC
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x00009814 File Offset: 0x00007A14
		public bool active
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x00009818 File Offset: 0x00007A18
		public bool done
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x00009830 File Offset: 0x00007A30
		public bool wasCanceled
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00009848 File Offset: 0x00007A48
		private static Rect area
		{
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x00009868 File Offset: 0x00007A68
		private static bool visible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x00009880 File Offset: 0x00007A80
		public static bool isSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x00009898 File Offset: 0x00007A98
		public bool canGetSelection
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x000098B0 File Offset: 0x00007AB0
		public RangeInt selection
		{
			get
			{
				return new RangeInt(0, 0);
			}
		}
	}
}
