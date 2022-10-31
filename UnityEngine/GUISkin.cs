using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000265 RID: 613
	[ExecuteInEditMode]
	[RequiredByNativeCode]
	[Serializable]
	public sealed class GUISkin : ScriptableObject
	{
		// Token: 0x060028FE RID: 10494 RVA: 0x00036108 File Offset: 0x00034308
		public GUISkin()
		{
			this.m_CustomStyles = new GUIStyle[1];
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x00036130 File Offset: 0x00034330
		internal void OnEnable()
		{
			this.Apply();
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x0003613C File Offset: 0x0003433C
		internal static void CleanupRoots()
		{
			GUISkin.current = null;
			GUISkin.ms_Error = null;
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06002901 RID: 10497 RVA: 0x0003614C File Offset: 0x0003434C
		// (set) Token: 0x06002902 RID: 10498 RVA: 0x00036168 File Offset: 0x00034368
		public Font font
		{
			get
			{
				return this.m_Font;
			}
			set
			{
				this.m_Font = value;
				if (GUISkin.current == this)
				{
					GUIStyle.SetDefaultFont(this.m_Font);
				}
				this.Apply();
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06002903 RID: 10499 RVA: 0x00036194 File Offset: 0x00034394
		// (set) Token: 0x06002904 RID: 10500 RVA: 0x000361B0 File Offset: 0x000343B0
		public GUIStyle box
		{
			get
			{
				return this.m_box;
			}
			set
			{
				this.m_box = value;
				this.Apply();
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06002905 RID: 10501 RVA: 0x000361C0 File Offset: 0x000343C0
		// (set) Token: 0x06002906 RID: 10502 RVA: 0x000361DC File Offset: 0x000343DC
		public GUIStyle label
		{
			get
			{
				return this.m_label;
			}
			set
			{
				this.m_label = value;
				this.Apply();
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06002907 RID: 10503 RVA: 0x000361EC File Offset: 0x000343EC
		// (set) Token: 0x06002908 RID: 10504 RVA: 0x00036208 File Offset: 0x00034408
		public GUIStyle textField
		{
			get
			{
				return this.m_textField;
			}
			set
			{
				this.m_textField = value;
				this.Apply();
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06002909 RID: 10505 RVA: 0x00036218 File Offset: 0x00034418
		// (set) Token: 0x0600290A RID: 10506 RVA: 0x00036234 File Offset: 0x00034434
		public GUIStyle textArea
		{
			get
			{
				return this.m_textArea;
			}
			set
			{
				this.m_textArea = value;
				this.Apply();
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x0600290B RID: 10507 RVA: 0x00036244 File Offset: 0x00034444
		// (set) Token: 0x0600290C RID: 10508 RVA: 0x00036260 File Offset: 0x00034460
		public GUIStyle button
		{
			get
			{
				return this.m_button;
			}
			set
			{
				this.m_button = value;
				this.Apply();
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x0600290D RID: 10509 RVA: 0x00036270 File Offset: 0x00034470
		// (set) Token: 0x0600290E RID: 10510 RVA: 0x0003628C File Offset: 0x0003448C
		public GUIStyle toggle
		{
			get
			{
				return this.m_toggle;
			}
			set
			{
				this.m_toggle = value;
				this.Apply();
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x0600290F RID: 10511 RVA: 0x0003629C File Offset: 0x0003449C
		// (set) Token: 0x06002910 RID: 10512 RVA: 0x000362B8 File Offset: 0x000344B8
		public GUIStyle window
		{
			get
			{
				return this.m_window;
			}
			set
			{
				this.m_window = value;
				this.Apply();
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06002911 RID: 10513 RVA: 0x000362C8 File Offset: 0x000344C8
		// (set) Token: 0x06002912 RID: 10514 RVA: 0x000362E4 File Offset: 0x000344E4
		public GUIStyle horizontalSlider
		{
			get
			{
				return this.m_horizontalSlider;
			}
			set
			{
				this.m_horizontalSlider = value;
				this.Apply();
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06002913 RID: 10515 RVA: 0x000362F4 File Offset: 0x000344F4
		// (set) Token: 0x06002914 RID: 10516 RVA: 0x00036310 File Offset: 0x00034510
		public GUIStyle horizontalSliderThumb
		{
			get
			{
				return this.m_horizontalSliderThumb;
			}
			set
			{
				this.m_horizontalSliderThumb = value;
				this.Apply();
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06002915 RID: 10517 RVA: 0x00036320 File Offset: 0x00034520
		// (set) Token: 0x06002916 RID: 10518 RVA: 0x0003633C File Offset: 0x0003453C
		public GUIStyle verticalSlider
		{
			get
			{
				return this.m_verticalSlider;
			}
			set
			{
				this.m_verticalSlider = value;
				this.Apply();
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06002917 RID: 10519 RVA: 0x0003634C File Offset: 0x0003454C
		// (set) Token: 0x06002918 RID: 10520 RVA: 0x00036368 File Offset: 0x00034568
		public GUIStyle verticalSliderThumb
		{
			get
			{
				return this.m_verticalSliderThumb;
			}
			set
			{
				this.m_verticalSliderThumb = value;
				this.Apply();
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06002919 RID: 10521 RVA: 0x00036378 File Offset: 0x00034578
		// (set) Token: 0x0600291A RID: 10522 RVA: 0x00036394 File Offset: 0x00034594
		public GUIStyle horizontalScrollbar
		{
			get
			{
				return this.m_horizontalScrollbar;
			}
			set
			{
				this.m_horizontalScrollbar = value;
				this.Apply();
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x0600291B RID: 10523 RVA: 0x000363A4 File Offset: 0x000345A4
		// (set) Token: 0x0600291C RID: 10524 RVA: 0x000363C0 File Offset: 0x000345C0
		public GUIStyle horizontalScrollbarThumb
		{
			get
			{
				return this.m_horizontalScrollbarThumb;
			}
			set
			{
				this.m_horizontalScrollbarThumb = value;
				this.Apply();
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x0600291D RID: 10525 RVA: 0x000363D0 File Offset: 0x000345D0
		// (set) Token: 0x0600291E RID: 10526 RVA: 0x000363EC File Offset: 0x000345EC
		public GUIStyle horizontalScrollbarLeftButton
		{
			get
			{
				return this.m_horizontalScrollbarLeftButton;
			}
			set
			{
				this.m_horizontalScrollbarLeftButton = value;
				this.Apply();
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x0600291F RID: 10527 RVA: 0x000363FC File Offset: 0x000345FC
		// (set) Token: 0x06002920 RID: 10528 RVA: 0x00036418 File Offset: 0x00034618
		public GUIStyle horizontalScrollbarRightButton
		{
			get
			{
				return this.m_horizontalScrollbarRightButton;
			}
			set
			{
				this.m_horizontalScrollbarRightButton = value;
				this.Apply();
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06002921 RID: 10529 RVA: 0x00036428 File Offset: 0x00034628
		// (set) Token: 0x06002922 RID: 10530 RVA: 0x00036444 File Offset: 0x00034644
		public GUIStyle verticalScrollbar
		{
			get
			{
				return this.m_verticalScrollbar;
			}
			set
			{
				this.m_verticalScrollbar = value;
				this.Apply();
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06002923 RID: 10531 RVA: 0x00036454 File Offset: 0x00034654
		// (set) Token: 0x06002924 RID: 10532 RVA: 0x00036470 File Offset: 0x00034670
		public GUIStyle verticalScrollbarThumb
		{
			get
			{
				return this.m_verticalScrollbarThumb;
			}
			set
			{
				this.m_verticalScrollbarThumb = value;
				this.Apply();
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06002925 RID: 10533 RVA: 0x00036480 File Offset: 0x00034680
		// (set) Token: 0x06002926 RID: 10534 RVA: 0x0003649C File Offset: 0x0003469C
		public GUIStyle verticalScrollbarUpButton
		{
			get
			{
				return this.m_verticalScrollbarUpButton;
			}
			set
			{
				this.m_verticalScrollbarUpButton = value;
				this.Apply();
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06002927 RID: 10535 RVA: 0x000364AC File Offset: 0x000346AC
		// (set) Token: 0x06002928 RID: 10536 RVA: 0x000364C8 File Offset: 0x000346C8
		public GUIStyle verticalScrollbarDownButton
		{
			get
			{
				return this.m_verticalScrollbarDownButton;
			}
			set
			{
				this.m_verticalScrollbarDownButton = value;
				this.Apply();
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06002929 RID: 10537 RVA: 0x000364D8 File Offset: 0x000346D8
		// (set) Token: 0x0600292A RID: 10538 RVA: 0x000364F4 File Offset: 0x000346F4
		public GUIStyle scrollView
		{
			get
			{
				return this.m_ScrollView;
			}
			set
			{
				this.m_ScrollView = value;
				this.Apply();
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x0600292B RID: 10539 RVA: 0x00036504 File Offset: 0x00034704
		// (set) Token: 0x0600292C RID: 10540 RVA: 0x00036520 File Offset: 0x00034720
		public GUIStyle[] customStyles
		{
			get
			{
				return this.m_CustomStyles;
			}
			set
			{
				this.m_CustomStyles = value;
				this.Apply();
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x0600292D RID: 10541 RVA: 0x00036530 File Offset: 0x00034730
		public GUISettings settings
		{
			get
			{
				return this.m_Settings;
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x0600292E RID: 10542 RVA: 0x0003654C File Offset: 0x0003474C
		internal static GUIStyle error
		{
			get
			{
				if (GUISkin.ms_Error == null)
				{
					GUISkin.ms_Error = new GUIStyle();
				}
				return GUISkin.ms_Error;
			}
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x0003657C File Offset: 0x0003477C
		internal void Apply()
		{
			if (this.m_CustomStyles == null)
			{
				Debug.Log("custom styles is null");
			}
			this.BuildStyleCache();
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x0003659C File Offset: 0x0003479C
		private void BuildStyleCache()
		{
			if (this.m_box == null)
			{
				this.m_box = new GUIStyle();
			}
			if (this.m_button == null)
			{
				this.m_button = new GUIStyle();
			}
			if (this.m_toggle == null)
			{
				this.m_toggle = new GUIStyle();
			}
			if (this.m_label == null)
			{
				this.m_label = new GUIStyle();
			}
			if (this.m_window == null)
			{
				this.m_window = new GUIStyle();
			}
			if (this.m_textField == null)
			{
				this.m_textField = new GUIStyle();
			}
			if (this.m_textArea == null)
			{
				this.m_textArea = new GUIStyle();
			}
			if (this.m_horizontalSlider == null)
			{
				this.m_horizontalSlider = new GUIStyle();
			}
			if (this.m_horizontalSliderThumb == null)
			{
				this.m_horizontalSliderThumb = new GUIStyle();
			}
			if (this.m_verticalSlider == null)
			{
				this.m_verticalSlider = new GUIStyle();
			}
			if (this.m_verticalSliderThumb == null)
			{
				this.m_verticalSliderThumb = new GUIStyle();
			}
			if (this.m_horizontalScrollbar == null)
			{
				this.m_horizontalScrollbar = new GUIStyle();
			}
			if (this.m_horizontalScrollbarThumb == null)
			{
				this.m_horizontalScrollbarThumb = new GUIStyle();
			}
			if (this.m_horizontalScrollbarLeftButton == null)
			{
				this.m_horizontalScrollbarLeftButton = new GUIStyle();
			}
			if (this.m_horizontalScrollbarRightButton == null)
			{
				this.m_horizontalScrollbarRightButton = new GUIStyle();
			}
			if (this.m_verticalScrollbar == null)
			{
				this.m_verticalScrollbar = new GUIStyle();
			}
			if (this.m_verticalScrollbarThumb == null)
			{
				this.m_verticalScrollbarThumb = new GUIStyle();
			}
			if (this.m_verticalScrollbarUpButton == null)
			{
				this.m_verticalScrollbarUpButton = new GUIStyle();
			}
			if (this.m_verticalScrollbarDownButton == null)
			{
				this.m_verticalScrollbarDownButton = new GUIStyle();
			}
			if (this.m_ScrollView == null)
			{
				this.m_ScrollView = new GUIStyle();
			}
			this.m_Styles = new Dictionary<string, GUIStyle>(StringComparer.OrdinalIgnoreCase);
			this.m_Styles["box"] = this.m_box;
			this.m_box.name = "box";
			this.m_Styles["button"] = this.m_button;
			this.m_button.name = "button";
			this.m_Styles["toggle"] = this.m_toggle;
			this.m_toggle.name = "toggle";
			this.m_Styles["label"] = this.m_label;
			this.m_label.name = "label";
			this.m_Styles["window"] = this.m_window;
			this.m_window.name = "window";
			this.m_Styles["textfield"] = this.m_textField;
			this.m_textField.name = "textfield";
			this.m_Styles["textarea"] = this.m_textArea;
			this.m_textArea.name = "textarea";
			this.m_Styles["horizontalslider"] = this.m_horizontalSlider;
			this.m_horizontalSlider.name = "horizontalslider";
			this.m_Styles["horizontalsliderthumb"] = this.m_horizontalSliderThumb;
			this.m_horizontalSliderThumb.name = "horizontalsliderthumb";
			this.m_Styles["verticalslider"] = this.m_verticalSlider;
			this.m_verticalSlider.name = "verticalslider";
			this.m_Styles["verticalsliderthumb"] = this.m_verticalSliderThumb;
			this.m_verticalSliderThumb.name = "verticalsliderthumb";
			this.m_Styles["horizontalscrollbar"] = this.m_horizontalScrollbar;
			this.m_horizontalScrollbar.name = "horizontalscrollbar";
			this.m_Styles["horizontalscrollbarthumb"] = this.m_horizontalScrollbarThumb;
			this.m_horizontalScrollbarThumb.name = "horizontalscrollbarthumb";
			this.m_Styles["horizontalscrollbarleftbutton"] = this.m_horizontalScrollbarLeftButton;
			this.m_horizontalScrollbarLeftButton.name = "horizontalscrollbarleftbutton";
			this.m_Styles["horizontalscrollbarrightbutton"] = this.m_horizontalScrollbarRightButton;
			this.m_horizontalScrollbarRightButton.name = "horizontalscrollbarrightbutton";
			this.m_Styles["verticalscrollbar"] = this.m_verticalScrollbar;
			this.m_verticalScrollbar.name = "verticalscrollbar";
			this.m_Styles["verticalscrollbarthumb"] = this.m_verticalScrollbarThumb;
			this.m_verticalScrollbarThumb.name = "verticalscrollbarthumb";
			this.m_Styles["verticalscrollbarupbutton"] = this.m_verticalScrollbarUpButton;
			this.m_verticalScrollbarUpButton.name = "verticalscrollbarupbutton";
			this.m_Styles["verticalscrollbardownbutton"] = this.m_verticalScrollbarDownButton;
			this.m_verticalScrollbarDownButton.name = "verticalscrollbardownbutton";
			this.m_Styles["scrollview"] = this.m_ScrollView;
			this.m_ScrollView.name = "scrollview";
			if (this.m_CustomStyles != null)
			{
				for (int i = 0; i < this.m_CustomStyles.Length; i++)
				{
					if (this.m_CustomStyles[i] != null)
					{
						this.m_Styles[this.m_CustomStyles[i].name] = this.m_CustomStyles[i];
					}
				}
			}
			GUISkin.error.stretchHeight = true;
			GUISkin.error.normal.textColor = Color.red;
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x00036AE4 File Offset: 0x00034CE4
		public GUIStyle GetStyle(string styleName)
		{
			GUIStyle guistyle = this.FindStyle(styleName);
			GUIStyle result;
			if (guistyle != null)
			{
				result = guistyle;
			}
			else
			{
				Debug.LogWarning(string.Concat(new object[]
				{
					"Unable to find style '",
					styleName,
					"' in skin '",
					base.name,
					"' ",
					Event.current.type
				}));
				result = GUISkin.error;
			}
			return result;
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x00036B5C File Offset: 0x00034D5C
		public GUIStyle FindStyle(string styleName)
		{
			GUIStyle result;
			if (this == null)
			{
				Debug.LogError("GUISkin is NULL");
				result = null;
			}
			else
			{
				if (this.m_Styles == null)
				{
					this.BuildStyleCache();
				}
				GUIStyle guistyle;
				if (this.m_Styles.TryGetValue(styleName, out guistyle))
				{
					result = guistyle;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x00036BBC File Offset: 0x00034DBC
		internal void MakeCurrent()
		{
			GUISkin.current = this;
			GUIStyle.SetDefaultFont(this.font);
			if (GUISkin.m_SkinChanged != null)
			{
				GUISkin.m_SkinChanged();
			}
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x00036BE4 File Offset: 0x00034DE4
		public IEnumerator GetEnumerator()
		{
			if (this.m_Styles == null)
			{
				this.BuildStyleCache();
			}
			return this.m_Styles.Values.GetEnumerator();
		}

		// Token: 0x04000777 RID: 1911
		[SerializeField]
		private Font m_Font;

		// Token: 0x04000778 RID: 1912
		[SerializeField]
		private GUIStyle m_box;

		// Token: 0x04000779 RID: 1913
		[SerializeField]
		private GUIStyle m_button;

		// Token: 0x0400077A RID: 1914
		[SerializeField]
		private GUIStyle m_toggle;

		// Token: 0x0400077B RID: 1915
		[SerializeField]
		private GUIStyle m_label;

		// Token: 0x0400077C RID: 1916
		[SerializeField]
		private GUIStyle m_textField;

		// Token: 0x0400077D RID: 1917
		[SerializeField]
		private GUIStyle m_textArea;

		// Token: 0x0400077E RID: 1918
		[SerializeField]
		private GUIStyle m_window;

		// Token: 0x0400077F RID: 1919
		[SerializeField]
		private GUIStyle m_horizontalSlider;

		// Token: 0x04000780 RID: 1920
		[SerializeField]
		private GUIStyle m_horizontalSliderThumb;

		// Token: 0x04000781 RID: 1921
		[SerializeField]
		private GUIStyle m_verticalSlider;

		// Token: 0x04000782 RID: 1922
		[SerializeField]
		private GUIStyle m_verticalSliderThumb;

		// Token: 0x04000783 RID: 1923
		[SerializeField]
		private GUIStyle m_horizontalScrollbar;

		// Token: 0x04000784 RID: 1924
		[SerializeField]
		private GUIStyle m_horizontalScrollbarThumb;

		// Token: 0x04000785 RID: 1925
		[SerializeField]
		private GUIStyle m_horizontalScrollbarLeftButton;

		// Token: 0x04000786 RID: 1926
		[SerializeField]
		private GUIStyle m_horizontalScrollbarRightButton;

		// Token: 0x04000787 RID: 1927
		[SerializeField]
		private GUIStyle m_verticalScrollbar;

		// Token: 0x04000788 RID: 1928
		[SerializeField]
		private GUIStyle m_verticalScrollbarThumb;

		// Token: 0x04000789 RID: 1929
		[SerializeField]
		private GUIStyle m_verticalScrollbarUpButton;

		// Token: 0x0400078A RID: 1930
		[SerializeField]
		private GUIStyle m_verticalScrollbarDownButton;

		// Token: 0x0400078B RID: 1931
		[SerializeField]
		private GUIStyle m_ScrollView;

		// Token: 0x0400078C RID: 1932
		[SerializeField]
		internal GUIStyle[] m_CustomStyles;

		// Token: 0x0400078D RID: 1933
		[SerializeField]
		private GUISettings m_Settings = new GUISettings();

		// Token: 0x0400078E RID: 1934
		internal static GUIStyle ms_Error;

		// Token: 0x0400078F RID: 1935
		private Dictionary<string, GUIStyle> m_Styles = null;

		// Token: 0x04000790 RID: 1936
		internal static GUISkin.SkinChangedDelegate m_SkinChanged;

		// Token: 0x04000791 RID: 1937
		internal static GUISkin current;

		// Token: 0x02000266 RID: 614
		// (Invoke) Token: 0x06002936 RID: 10550
		internal delegate void SkinChangedDelegate();
	}
}
