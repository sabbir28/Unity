using System;

namespace UnityEngine
{
	// Token: 0x02000253 RID: 595
	public class GUILayout
	{
		// Token: 0x06002802 RID: 10242 RVA: 0x00031148 File Offset: 0x0002F348
		public static void Label(Texture image, params GUILayoutOption[] options)
		{
			GUILayout.DoLabel(GUIContent.Temp(image), GUI.skin.label, options);
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x00031164 File Offset: 0x0002F364
		public static void Label(string text, params GUILayoutOption[] options)
		{
			GUILayout.DoLabel(GUIContent.Temp(text), GUI.skin.label, options);
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x00031180 File Offset: 0x0002F380
		public static void Label(GUIContent content, params GUILayoutOption[] options)
		{
			GUILayout.DoLabel(content, GUI.skin.label, options);
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x00031194 File Offset: 0x0002F394
		public static void Label(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.DoLabel(GUIContent.Temp(image), style, options);
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x000311A4 File Offset: 0x0002F3A4
		public static void Label(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.DoLabel(GUIContent.Temp(text), style, options);
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x000311B4 File Offset: 0x0002F3B4
		public static void Label(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.DoLabel(content, style, options);
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x000311C0 File Offset: 0x0002F3C0
		private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			GUI.Label(GUILayoutUtility.GetRect(content, style, options), content, style);
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x000311D4 File Offset: 0x0002F3D4
		public static void Box(Texture image, params GUILayoutOption[] options)
		{
			GUILayout.DoBox(GUIContent.Temp(image), GUI.skin.box, options);
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x000311F0 File Offset: 0x0002F3F0
		public static void Box(string text, params GUILayoutOption[] options)
		{
			GUILayout.DoBox(GUIContent.Temp(text), GUI.skin.box, options);
		}

		// Token: 0x0600280B RID: 10251 RVA: 0x0003120C File Offset: 0x0002F40C
		public static void Box(GUIContent content, params GUILayoutOption[] options)
		{
			GUILayout.DoBox(content, GUI.skin.box, options);
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x00031220 File Offset: 0x0002F420
		public static void Box(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.DoBox(GUIContent.Temp(image), style, options);
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x00031230 File Offset: 0x0002F430
		public static void Box(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.DoBox(GUIContent.Temp(text), style, options);
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x00031240 File Offset: 0x0002F440
		public static void Box(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.DoBox(content, style, options);
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x0003124C File Offset: 0x0002F44C
		private static void DoBox(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			GUI.Box(GUILayoutUtility.GetRect(content, style, options), content, style);
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x00031260 File Offset: 0x0002F460
		public static bool Button(Texture image, params GUILayoutOption[] options)
		{
			return GUILayout.DoButton(GUIContent.Temp(image), GUI.skin.button, options);
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x0003128C File Offset: 0x0002F48C
		public static bool Button(string text, params GUILayoutOption[] options)
		{
			return GUILayout.DoButton(GUIContent.Temp(text), GUI.skin.button, options);
		}

		// Token: 0x06002812 RID: 10258 RVA: 0x000312B8 File Offset: 0x0002F4B8
		public static bool Button(GUIContent content, params GUILayoutOption[] options)
		{
			return GUILayout.DoButton(content, GUI.skin.button, options);
		}

		// Token: 0x06002813 RID: 10259 RVA: 0x000312E0 File Offset: 0x0002F4E0
		public static bool Button(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoButton(GUIContent.Temp(image), style, options);
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x00031304 File Offset: 0x0002F504
		public static bool Button(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoButton(GUIContent.Temp(text), style, options);
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x00031328 File Offset: 0x0002F528
		public static bool Button(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoButton(content, style, options);
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x00031348 File Offset: 0x0002F548
		private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			return GUI.Button(GUILayoutUtility.GetRect(content, style, options), content, style);
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x0003136C File Offset: 0x0002F56C
		public static bool RepeatButton(Texture image, params GUILayoutOption[] options)
		{
			return GUILayout.DoRepeatButton(GUIContent.Temp(image), GUI.skin.button, options);
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x00031398 File Offset: 0x0002F598
		public static bool RepeatButton(string text, params GUILayoutOption[] options)
		{
			return GUILayout.DoRepeatButton(GUIContent.Temp(text), GUI.skin.button, options);
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x000313C4 File Offset: 0x0002F5C4
		public static bool RepeatButton(GUIContent content, params GUILayoutOption[] options)
		{
			return GUILayout.DoRepeatButton(content, GUI.skin.button, options);
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x000313EC File Offset: 0x0002F5EC
		public static bool RepeatButton(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoRepeatButton(GUIContent.Temp(image), style, options);
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x00031410 File Offset: 0x0002F610
		public static bool RepeatButton(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoRepeatButton(GUIContent.Temp(text), style, options);
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x00031434 File Offset: 0x0002F634
		public static bool RepeatButton(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoRepeatButton(content, style, options);
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x00031454 File Offset: 0x0002F654
		private static bool DoRepeatButton(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			return GUI.RepeatButton(GUILayoutUtility.GetRect(content, style, options), content, style);
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x00031478 File Offset: 0x0002F678
		public static string TextField(string text, params GUILayoutOption[] options)
		{
			return GUILayout.DoTextField(text, -1, false, GUI.skin.textField, options);
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x000314A0 File Offset: 0x0002F6A0
		public static string TextField(string text, int maxLength, params GUILayoutOption[] options)
		{
			return GUILayout.DoTextField(text, maxLength, false, GUI.skin.textField, options);
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x000314C8 File Offset: 0x0002F6C8
		public static string TextField(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoTextField(text, -1, false, style, options);
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x000314E8 File Offset: 0x0002F6E8
		public static string TextField(string text, int maxLength, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoTextField(text, maxLength, true, style, options);
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x00031508 File Offset: 0x0002F708
		public static string PasswordField(string password, char maskChar, params GUILayoutOption[] options)
		{
			return GUILayout.PasswordField(password, maskChar, -1, GUI.skin.textField, options);
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x00031530 File Offset: 0x0002F730
		public static string PasswordField(string password, char maskChar, int maxLength, params GUILayoutOption[] options)
		{
			return GUILayout.PasswordField(password, maskChar, maxLength, GUI.skin.textField, options);
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x00031558 File Offset: 0x0002F758
		public static string PasswordField(string password, char maskChar, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.PasswordField(password, maskChar, -1, style, options);
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x00031578 File Offset: 0x0002F778
		public static string PasswordField(string password, char maskChar, int maxLength, GUIStyle style, params GUILayoutOption[] options)
		{
			GUIContent content = GUIContent.Temp(GUI.PasswordFieldGetStrToShow(password, maskChar));
			return GUI.PasswordField(GUILayoutUtility.GetRect(content, GUI.skin.textField, options), password, maskChar, maxLength, style);
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x000315B8 File Offset: 0x0002F7B8
		public static string TextArea(string text, params GUILayoutOption[] options)
		{
			return GUILayout.DoTextField(text, -1, true, GUI.skin.textArea, options);
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x000315E0 File Offset: 0x0002F7E0
		public static string TextArea(string text, int maxLength, params GUILayoutOption[] options)
		{
			return GUILayout.DoTextField(text, maxLength, true, GUI.skin.textArea, options);
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x00031608 File Offset: 0x0002F808
		public static string TextArea(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoTextField(text, -1, true, style, options);
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x00031628 File Offset: 0x0002F828
		public static string TextArea(string text, int maxLength, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoTextField(text, maxLength, true, style, options);
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x00031648 File Offset: 0x0002F848
		private static string DoTextField(string text, int maxLength, bool multiline, GUIStyle style, GUILayoutOption[] options)
		{
			int controlID = GUIUtility.GetControlID(FocusType.Keyboard);
			GUIContent guicontent = GUIContent.Temp(text);
			if (GUIUtility.keyboardControl != controlID)
			{
				guicontent = GUIContent.Temp(text);
			}
			else
			{
				guicontent = GUIContent.Temp(text + Input.compositionString);
			}
			Rect rect = GUILayoutUtility.GetRect(guicontent, style, options);
			if (GUIUtility.keyboardControl == controlID)
			{
				guicontent = GUIContent.Temp(text);
			}
			GUI.DoTextField(rect, controlID, guicontent, multiline, maxLength, style);
			return guicontent.text;
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x000316C0 File Offset: 0x0002F8C0
		public static bool Toggle(bool value, Texture image, params GUILayoutOption[] options)
		{
			return GUILayout.DoToggle(value, GUIContent.Temp(image), GUI.skin.toggle, options);
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x000316EC File Offset: 0x0002F8EC
		public static bool Toggle(bool value, string text, params GUILayoutOption[] options)
		{
			return GUILayout.DoToggle(value, GUIContent.Temp(text), GUI.skin.toggle, options);
		}

		// Token: 0x0600282D RID: 10285 RVA: 0x00031718 File Offset: 0x0002F918
		public static bool Toggle(bool value, GUIContent content, params GUILayoutOption[] options)
		{
			return GUILayout.DoToggle(value, content, GUI.skin.toggle, options);
		}

		// Token: 0x0600282E RID: 10286 RVA: 0x00031740 File Offset: 0x0002F940
		public static bool Toggle(bool value, Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoToggle(value, GUIContent.Temp(image), style, options);
		}

		// Token: 0x0600282F RID: 10287 RVA: 0x00031764 File Offset: 0x0002F964
		public static bool Toggle(bool value, string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoToggle(value, GUIContent.Temp(text), style, options);
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x00031788 File Offset: 0x0002F988
		public static bool Toggle(bool value, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoToggle(value, content, style, options);
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x000317A8 File Offset: 0x0002F9A8
		private static bool DoToggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			return GUI.Toggle(GUILayoutUtility.GetRect(content, style, options), value, content, style);
		}

		// Token: 0x06002832 RID: 10290 RVA: 0x000317D0 File Offset: 0x0002F9D0
		public static int Toolbar(int selected, string[] texts, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(texts), GUI.skin.button, options);
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x000317FC File Offset: 0x0002F9FC
		public static int Toolbar(int selected, Texture[] images, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(images), GUI.skin.button, options);
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x00031828 File Offset: 0x0002FA28
		public static int Toolbar(int selected, GUIContent[] content, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, content, GUI.skin.button, options);
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x00031850 File Offset: 0x0002FA50
		public static int Toolbar(int selected, string[] texts, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(texts), style, options);
		}

		// Token: 0x06002836 RID: 10294 RVA: 0x00031874 File Offset: 0x0002FA74
		public static int Toolbar(int selected, Texture[] images, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(images), style, options);
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x00031898 File Offset: 0x0002FA98
		public static int Toolbar(int selected, GUIContent[] contents, GUIStyle style, params GUILayoutOption[] options)
		{
			GUIStyle guistyle;
			GUIStyle guistyle2;
			GUIStyle guistyle3;
			GUI.FindStyles(ref style, out guistyle, out guistyle2, out guistyle3, "left", "mid", "right");
			Vector2 vector = default(Vector2);
			int num = contents.Length;
			GUIStyle guistyle4 = (num <= 1) ? style : guistyle;
			GUIStyle guistyle5 = (num <= 1) ? style : guistyle2;
			GUIStyle guistyle6 = (num <= 1) ? style : guistyle3;
			int num2 = guistyle4.margin.left;
			for (int i = 0; i < contents.Length; i++)
			{
				if (i == num - 2)
				{
					guistyle4 = guistyle5;
					guistyle5 = guistyle6;
				}
				if (i == num - 1)
				{
					guistyle4 = guistyle6;
				}
				Vector2 vector2 = guistyle4.CalcSize(contents[i]);
				if (vector2.x > vector.x)
				{
					vector.x = vector2.x;
				}
				if (vector2.y > vector.y)
				{
					vector.y = vector2.y;
				}
				if (i == num - 1)
				{
					num2 += guistyle4.margin.right;
				}
				else
				{
					num2 += Mathf.Max(guistyle4.margin.right, guistyle5.margin.left);
				}
			}
			vector.x = vector.x * (float)contents.Length + (float)num2;
			return GUI.Toolbar(GUILayoutUtility.GetRect(vector.x, vector.y, style, options), selected, contents, style);
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x00031A20 File Offset: 0x0002FC20
		public static int SelectionGrid(int selected, string[] texts, int xCount, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, GUIContent.Temp(texts), xCount, GUI.skin.button, options);
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x00031A50 File Offset: 0x0002FC50
		public static int SelectionGrid(int selected, Texture[] images, int xCount, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, GUIContent.Temp(images), xCount, GUI.skin.button, options);
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x00031A80 File Offset: 0x0002FC80
		public static int SelectionGrid(int selected, GUIContent[] content, int xCount, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, content, xCount, GUI.skin.button, options);
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x00031AA8 File Offset: 0x0002FCA8
		public static int SelectionGrid(int selected, string[] texts, int xCount, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, GUIContent.Temp(texts), xCount, style, options);
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x00031AD0 File Offset: 0x0002FCD0
		public static int SelectionGrid(int selected, Texture[] images, int xCount, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, GUIContent.Temp(images), xCount, style, options);
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x00031AF8 File Offset: 0x0002FCF8
		public static int SelectionGrid(int selected, GUIContent[] contents, int xCount, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUI.SelectionGrid(GUIGridSizer.GetRect(contents, xCount, style, options), selected, contents, xCount, style);
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x00031B20 File Offset: 0x0002FD20
		public static float HorizontalSlider(float value, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			return GUILayout.DoHorizontalSlider(value, leftValue, rightValue, GUI.skin.horizontalSlider, GUI.skin.horizontalSliderThumb, options);
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x00031B54 File Offset: 0x0002FD54
		public static float HorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
		{
			return GUILayout.DoHorizontalSlider(value, leftValue, rightValue, slider, thumb, options);
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x00031B78 File Offset: 0x0002FD78
		private static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options)
		{
			return GUI.HorizontalSlider(GUILayoutUtility.GetRect(GUIContent.Temp("mmmm"), slider, options), value, leftValue, rightValue, slider, thumb);
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x00031BAC File Offset: 0x0002FDAC
		public static float VerticalSlider(float value, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			return GUILayout.DoVerticalSlider(value, leftValue, rightValue, GUI.skin.verticalSlider, GUI.skin.verticalSliderThumb, options);
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x00031BE0 File Offset: 0x0002FDE0
		public static float VerticalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
		{
			return GUILayout.DoVerticalSlider(value, leftValue, rightValue, slider, thumb, options);
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x00031C04 File Offset: 0x0002FE04
		private static float DoVerticalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
		{
			return GUI.VerticalSlider(GUILayoutUtility.GetRect(GUIContent.Temp("\n\n\n\n\n"), slider, options), value, leftValue, rightValue, slider, thumb);
		}

		// Token: 0x06002844 RID: 10308 RVA: 0x00031C38 File Offset: 0x0002FE38
		public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			return GUILayout.HorizontalScrollbar(value, size, leftValue, rightValue, GUI.skin.horizontalScrollbar, options);
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x00031C64 File Offset: 0x0002FE64
		public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUI.HorizontalScrollbar(GUILayoutUtility.GetRect(GUIContent.Temp("mmmm"), style, options), value, size, leftValue, rightValue, style);
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x00031C98 File Offset: 0x0002FE98
		public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, params GUILayoutOption[] options)
		{
			return GUILayout.VerticalScrollbar(value, size, topValue, bottomValue, GUI.skin.verticalScrollbar, options);
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x00031CC4 File Offset: 0x0002FEC4
		public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUI.VerticalScrollbar(GUILayoutUtility.GetRect(GUIContent.Temp("\n\n\n\n"), style, options), value, size, topValue, bottomValue, style);
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x00031CF8 File Offset: 0x0002FEF8
		public static void Space(float pixels)
		{
			GUIUtility.CheckOnGUI();
			if (GUILayoutUtility.current.topLevel.isVertical)
			{
				GUILayoutUtility.GetRect(0f, pixels, GUILayoutUtility.spaceStyle, new GUILayoutOption[]
				{
					GUILayout.Height(pixels)
				});
			}
			else
			{
				GUILayoutUtility.GetRect(pixels, 0f, GUILayoutUtility.spaceStyle, new GUILayoutOption[]
				{
					GUILayout.Width(pixels)
				});
			}
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x00031D64 File Offset: 0x0002FF64
		public static void FlexibleSpace()
		{
			GUIUtility.CheckOnGUI();
			GUILayoutOption guilayoutOption;
			if (GUILayoutUtility.current.topLevel.isVertical)
			{
				guilayoutOption = GUILayout.ExpandHeight(true);
			}
			else
			{
				guilayoutOption = GUILayout.ExpandWidth(true);
			}
			guilayoutOption.value = 10000;
			GUILayoutUtility.GetRect(0f, 0f, GUILayoutUtility.spaceStyle, new GUILayoutOption[]
			{
				guilayoutOption
			});
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x00031DD0 File Offset: 0x0002FFD0
		public static void BeginHorizontal(params GUILayoutOption[] options)
		{
			GUILayout.BeginHorizontal(GUIContent.none, GUIStyle.none, options);
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x00031DE4 File Offset: 0x0002FFE4
		public static void BeginHorizontal(GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginHorizontal(GUIContent.none, style, options);
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x00031DF4 File Offset: 0x0002FFF4
		public static void BeginHorizontal(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginHorizontal(GUIContent.Temp(text), style, options);
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x00031E04 File Offset: 0x00030004
		public static void BeginHorizontal(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginHorizontal(GUIContent.Temp(image), style, options);
		}

		// Token: 0x0600284E RID: 10318 RVA: 0x00031E14 File Offset: 0x00030014
		public static void BeginHorizontal(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayoutGroup guilayoutGroup = GUILayoutUtility.BeginLayoutGroup(style, options, typeof(GUILayoutGroup));
			guilayoutGroup.isVertical = false;
			if (style != GUIStyle.none || content != GUIContent.none)
			{
				GUI.Box(guilayoutGroup.rect, content, style);
			}
		}

		// Token: 0x0600284F RID: 10319 RVA: 0x00031E60 File Offset: 0x00030060
		public static void EndHorizontal()
		{
			GUILayoutUtility.EndLayoutGroup();
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x00031E68 File Offset: 0x00030068
		public static void BeginVertical(params GUILayoutOption[] options)
		{
			GUILayout.BeginVertical(GUIContent.none, GUIStyle.none, options);
		}

		// Token: 0x06002851 RID: 10321 RVA: 0x00031E7C File Offset: 0x0003007C
		public static void BeginVertical(GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginVertical(GUIContent.none, style, options);
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x00031E8C File Offset: 0x0003008C
		public static void BeginVertical(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginVertical(GUIContent.Temp(text), style, options);
		}

		// Token: 0x06002853 RID: 10323 RVA: 0x00031E9C File Offset: 0x0003009C
		public static void BeginVertical(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginVertical(GUIContent.Temp(image), style, options);
		}

		// Token: 0x06002854 RID: 10324 RVA: 0x00031EAC File Offset: 0x000300AC
		public static void BeginVertical(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayoutGroup guilayoutGroup = GUILayoutUtility.BeginLayoutGroup(style, options, typeof(GUILayoutGroup));
			guilayoutGroup.isVertical = true;
			if (style != GUIStyle.none || content != GUIContent.none)
			{
				GUI.Box(guilayoutGroup.rect, content, style);
			}
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x00031EF8 File Offset: 0x000300F8
		public static void EndVertical()
		{
			GUILayoutUtility.EndLayoutGroup();
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x00031F00 File Offset: 0x00030100
		public static void BeginArea(Rect screenRect)
		{
			GUILayout.BeginArea(screenRect, GUIContent.none, GUIStyle.none);
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x00031F14 File Offset: 0x00030114
		public static void BeginArea(Rect screenRect, string text)
		{
			GUILayout.BeginArea(screenRect, GUIContent.Temp(text), GUIStyle.none);
		}

		// Token: 0x06002858 RID: 10328 RVA: 0x00031F28 File Offset: 0x00030128
		public static void BeginArea(Rect screenRect, Texture image)
		{
			GUILayout.BeginArea(screenRect, GUIContent.Temp(image), GUIStyle.none);
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x00031F3C File Offset: 0x0003013C
		public static void BeginArea(Rect screenRect, GUIContent content)
		{
			GUILayout.BeginArea(screenRect, content, GUIStyle.none);
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x00031F4C File Offset: 0x0003014C
		public static void BeginArea(Rect screenRect, GUIStyle style)
		{
			GUILayout.BeginArea(screenRect, GUIContent.none, style);
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x00031F5C File Offset: 0x0003015C
		public static void BeginArea(Rect screenRect, string text, GUIStyle style)
		{
			GUILayout.BeginArea(screenRect, GUIContent.Temp(text), style);
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x00031F6C File Offset: 0x0003016C
		public static void BeginArea(Rect screenRect, Texture image, GUIStyle style)
		{
			GUILayout.BeginArea(screenRect, GUIContent.Temp(image), style);
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x00031F7C File Offset: 0x0003017C
		public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			GUILayoutGroup guilayoutGroup = GUILayoutUtility.BeginLayoutArea(style, typeof(GUILayoutGroup));
			if (Event.current.type == EventType.Layout)
			{
				guilayoutGroup.resetCoords = true;
				guilayoutGroup.minWidth = (guilayoutGroup.maxWidth = screenRect.width);
				guilayoutGroup.minHeight = (guilayoutGroup.maxHeight = screenRect.height);
				guilayoutGroup.rect = Rect.MinMaxRect(screenRect.xMin, screenRect.yMin, guilayoutGroup.rect.xMax, guilayoutGroup.rect.yMax);
			}
			GUI.BeginGroup(guilayoutGroup.rect, content, style);
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x00032024 File Offset: 0x00030224
		public static void EndArea()
		{
			GUIUtility.CheckOnGUI();
			if (Event.current.type != EventType.Used)
			{
				GUILayoutUtility.current.layoutGroups.Pop();
				GUILayoutUtility.current.topLevel = (GUILayoutGroup)GUILayoutUtility.current.layoutGroups.Peek();
				GUI.EndGroup();
			}
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x00032080 File Offset: 0x00030280
		public static Vector2 BeginScrollView(Vector2 scrollPosition, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, false, false, GUI.skin.horizontalScrollbar, GUI.skin.verticalScrollbar, GUI.skin.scrollView, options);
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x000320BC File Offset: 0x000302BC
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, GUI.skin.horizontalScrollbar, GUI.skin.verticalScrollbar, GUI.skin.scrollView, options);
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x000320F8 File Offset: 0x000302F8
		public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, false, false, horizontalScrollbar, verticalScrollbar, GUI.skin.scrollView, options);
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x00032124 File Offset: 0x00030324
		public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style)
		{
			GUILayoutOption[] options = null;
			return GUILayout.BeginScrollView(scrollPosition, style, options);
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x00032144 File Offset: 0x00030344
		public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style, params GUILayoutOption[] options)
		{
			string name = style.name;
			GUIStyle guistyle = GUI.skin.FindStyle(name + "VerticalScrollbar");
			if (guistyle == null)
			{
				guistyle = GUI.skin.verticalScrollbar;
			}
			GUIStyle guistyle2 = GUI.skin.FindStyle(name + "HorizontalScrollbar");
			if (guistyle2 == null)
			{
				guistyle2 = GUI.skin.horizontalScrollbar;
			}
			return GUILayout.BeginScrollView(scrollPosition, false, false, guistyle2, guistyle, style, options);
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x000321BC File Offset: 0x000303BC
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, GUI.skin.scrollView, options);
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x000321E8 File Offset: 0x000303E8
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options)
		{
			GUIUtility.CheckOnGUI();
			GUIScrollGroup guiscrollGroup = (GUIScrollGroup)GUILayoutUtility.BeginLayoutGroup(background, null, typeof(GUIScrollGroup));
			EventType type = Event.current.type;
			if (type == EventType.Layout)
			{
				guiscrollGroup.resetCoords = true;
				guiscrollGroup.isVertical = true;
				guiscrollGroup.stretchWidth = 1;
				guiscrollGroup.stretchHeight = 1;
				guiscrollGroup.verticalScrollbar = verticalScrollbar;
				guiscrollGroup.horizontalScrollbar = horizontalScrollbar;
				guiscrollGroup.needsVerticalScrollbar = alwaysShowVertical;
				guiscrollGroup.needsHorizontalScrollbar = alwaysShowHorizontal;
				guiscrollGroup.ApplyOptions(options);
			}
			return GUI.BeginScrollView(guiscrollGroup.rect, scrollPosition, new Rect(0f, 0f, guiscrollGroup.clientWidth, guiscrollGroup.clientHeight), alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background);
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x000322AC File Offset: 0x000304AC
		public static void EndScrollView()
		{
			GUILayout.EndScrollView(true);
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x000322B8 File Offset: 0x000304B8
		internal static void EndScrollView(bool handleScrollWheel)
		{
			GUILayoutUtility.EndLayoutGroup();
			GUI.EndScrollView(handleScrollWheel);
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x000322C8 File Offset: 0x000304C8
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, params GUILayoutOption[] options)
		{
			return GUILayout.DoWindow(id, screenRect, func, GUIContent.Temp(text), GUI.skin.window, options);
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x000322F8 File Offset: 0x000304F8
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, params GUILayoutOption[] options)
		{
			return GUILayout.DoWindow(id, screenRect, func, GUIContent.Temp(image), GUI.skin.window, options);
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x00032328 File Offset: 0x00030528
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, params GUILayoutOption[] options)
		{
			return GUILayout.DoWindow(id, screenRect, func, content, GUI.skin.window, options);
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x00032354 File Offset: 0x00030554
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoWindow(id, screenRect, func, GUIContent.Temp(text), style, options);
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x0003237C File Offset: 0x0003057C
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoWindow(id, screenRect, func, GUIContent.Temp(image), style, options);
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x000323A4 File Offset: 0x000305A4
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoWindow(id, screenRect, func, content, style, options);
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x000323C8 File Offset: 0x000305C8
		private static Rect DoWindow(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			GUIUtility.CheckOnGUI();
			GUILayout.LayoutedWindow @object = new GUILayout.LayoutedWindow(func, screenRect, content, options, style);
			return GUI.Window(id, screenRect, new GUI.WindowFunction(@object.DoWindow), content, style);
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x00032408 File Offset: 0x00030608
		public static GUILayoutOption Width(float width)
		{
			return new GUILayoutOption(GUILayoutOption.Type.fixedWidth, width);
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x0003242C File Offset: 0x0003062C
		public static GUILayoutOption MinWidth(float minWidth)
		{
			return new GUILayoutOption(GUILayoutOption.Type.minWidth, minWidth);
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x00032450 File Offset: 0x00030650
		public static GUILayoutOption MaxWidth(float maxWidth)
		{
			return new GUILayoutOption(GUILayoutOption.Type.maxWidth, maxWidth);
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x00032474 File Offset: 0x00030674
		public static GUILayoutOption Height(float height)
		{
			return new GUILayoutOption(GUILayoutOption.Type.fixedHeight, height);
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x00032498 File Offset: 0x00030698
		public static GUILayoutOption MinHeight(float minHeight)
		{
			return new GUILayoutOption(GUILayoutOption.Type.minHeight, minHeight);
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x000324BC File Offset: 0x000306BC
		public static GUILayoutOption MaxHeight(float maxHeight)
		{
			return new GUILayoutOption(GUILayoutOption.Type.maxHeight, maxHeight);
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x000324E0 File Offset: 0x000306E0
		public static GUILayoutOption ExpandWidth(bool expand)
		{
			return new GUILayoutOption(GUILayoutOption.Type.stretchWidth, (!expand) ? 0 : 1);
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x00032510 File Offset: 0x00030710
		public static GUILayoutOption ExpandHeight(bool expand)
		{
			return new GUILayoutOption(GUILayoutOption.Type.stretchHeight, (!expand) ? 0 : 1);
		}

		// Token: 0x02000254 RID: 596
		private sealed class LayoutedWindow
		{
			// Token: 0x06002877 RID: 10359 RVA: 0x00032540 File Offset: 0x00030740
			internal LayoutedWindow(GUI.WindowFunction f, Rect screenRect, GUIContent content, GUILayoutOption[] options, GUIStyle style)
			{
				this.m_Func = f;
				this.m_ScreenRect = screenRect;
				this.m_Options = options;
				this.m_Style = style;
			}

			// Token: 0x06002878 RID: 10360 RVA: 0x00032568 File Offset: 0x00030768
			public void DoWindow(int windowID)
			{
				GUILayoutGroup topLevel = GUILayoutUtility.current.topLevel;
				EventType type = Event.current.type;
				if (type != EventType.Layout)
				{
					topLevel.ResetCursor();
				}
				else
				{
					topLevel.resetCoords = true;
					topLevel.rect = this.m_ScreenRect;
					if (this.m_Options != null)
					{
						topLevel.ApplyOptions(this.m_Options);
					}
					topLevel.isWindow = true;
					topLevel.windowID = windowID;
					topLevel.style = this.m_Style;
				}
				this.m_Func(windowID);
			}

			// Token: 0x0400071E RID: 1822
			private readonly GUI.WindowFunction m_Func;

			// Token: 0x0400071F RID: 1823
			private readonly Rect m_ScreenRect;

			// Token: 0x04000720 RID: 1824
			private readonly GUILayoutOption[] m_Options;

			// Token: 0x04000721 RID: 1825
			private readonly GUIStyle m_Style;
		}

		// Token: 0x02000255 RID: 597
		public class HorizontalScope : GUI.Scope
		{
			// Token: 0x06002879 RID: 10361 RVA: 0x000325F8 File Offset: 0x000307F8
			public HorizontalScope(params GUILayoutOption[] options)
			{
				GUILayout.BeginHorizontal(options);
			}

			// Token: 0x0600287A RID: 10362 RVA: 0x00032608 File Offset: 0x00030808
			public HorizontalScope(GUIStyle style, params GUILayoutOption[] options)
			{
				GUILayout.BeginHorizontal(style, options);
			}

			// Token: 0x0600287B RID: 10363 RVA: 0x00032618 File Offset: 0x00030818
			public HorizontalScope(string text, GUIStyle style, params GUILayoutOption[] options)
			{
				GUILayout.BeginHorizontal(text, style, options);
			}

			// Token: 0x0600287C RID: 10364 RVA: 0x0003262C File Offset: 0x0003082C
			public HorizontalScope(Texture image, GUIStyle style, params GUILayoutOption[] options)
			{
				GUILayout.BeginHorizontal(image, style, options);
			}

			// Token: 0x0600287D RID: 10365 RVA: 0x00032640 File Offset: 0x00030840
			public HorizontalScope(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
			{
				GUILayout.BeginHorizontal(content, style, options);
			}

			// Token: 0x0600287E RID: 10366 RVA: 0x00032654 File Offset: 0x00030854
			protected override void CloseScope()
			{
				GUILayout.EndHorizontal();
			}
		}

		// Token: 0x02000256 RID: 598
		public class VerticalScope : GUI.Scope
		{
			// Token: 0x0600287F RID: 10367 RVA: 0x0003265C File Offset: 0x0003085C
			public VerticalScope(params GUILayoutOption[] options)
			{
				GUILayout.BeginVertical(options);
			}

			// Token: 0x06002880 RID: 10368 RVA: 0x0003266C File Offset: 0x0003086C
			public VerticalScope(GUIStyle style, params GUILayoutOption[] options)
			{
				GUILayout.BeginVertical(style, options);
			}

			// Token: 0x06002881 RID: 10369 RVA: 0x0003267C File Offset: 0x0003087C
			public VerticalScope(string text, GUIStyle style, params GUILayoutOption[] options)
			{
				GUILayout.BeginVertical(text, style, options);
			}

			// Token: 0x06002882 RID: 10370 RVA: 0x00032690 File Offset: 0x00030890
			public VerticalScope(Texture image, GUIStyle style, params GUILayoutOption[] options)
			{
				GUILayout.BeginVertical(image, style, options);
			}

			// Token: 0x06002883 RID: 10371 RVA: 0x000326A4 File Offset: 0x000308A4
			public VerticalScope(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
			{
				GUILayout.BeginVertical(content, style, options);
			}

			// Token: 0x06002884 RID: 10372 RVA: 0x000326B8 File Offset: 0x000308B8
			protected override void CloseScope()
			{
				GUILayout.EndVertical();
			}
		}

		// Token: 0x02000257 RID: 599
		public class AreaScope : GUI.Scope
		{
			// Token: 0x06002885 RID: 10373 RVA: 0x000326C0 File Offset: 0x000308C0
			public AreaScope(Rect screenRect)
			{
				GUILayout.BeginArea(screenRect);
			}

			// Token: 0x06002886 RID: 10374 RVA: 0x000326D0 File Offset: 0x000308D0
			public AreaScope(Rect screenRect, string text)
			{
				GUILayout.BeginArea(screenRect, text);
			}

			// Token: 0x06002887 RID: 10375 RVA: 0x000326E0 File Offset: 0x000308E0
			public AreaScope(Rect screenRect, Texture image)
			{
				GUILayout.BeginArea(screenRect, image);
			}

			// Token: 0x06002888 RID: 10376 RVA: 0x000326F0 File Offset: 0x000308F0
			public AreaScope(Rect screenRect, GUIContent content)
			{
				GUILayout.BeginArea(screenRect, content);
			}

			// Token: 0x06002889 RID: 10377 RVA: 0x00032700 File Offset: 0x00030900
			public AreaScope(Rect screenRect, string text, GUIStyle style)
			{
				GUILayout.BeginArea(screenRect, text, style);
			}

			// Token: 0x0600288A RID: 10378 RVA: 0x00032714 File Offset: 0x00030914
			public AreaScope(Rect screenRect, Texture image, GUIStyle style)
			{
				GUILayout.BeginArea(screenRect, image, style);
			}

			// Token: 0x0600288B RID: 10379 RVA: 0x00032728 File Offset: 0x00030928
			public AreaScope(Rect screenRect, GUIContent content, GUIStyle style)
			{
				GUILayout.BeginArea(screenRect, content, style);
			}

			// Token: 0x0600288C RID: 10380 RVA: 0x0003273C File Offset: 0x0003093C
			protected override void CloseScope()
			{
				GUILayout.EndArea();
			}
		}

		// Token: 0x02000258 RID: 600
		public class ScrollViewScope : GUI.Scope
		{
			// Token: 0x0600288D RID: 10381 RVA: 0x00032744 File Offset: 0x00030944
			public ScrollViewScope(Vector2 scrollPosition, params GUILayoutOption[] options)
			{
				this.handleScrollWheel = true;
				this.scrollPosition = GUILayout.BeginScrollView(scrollPosition, options);
			}

			// Token: 0x0600288E RID: 10382 RVA: 0x00032764 File Offset: 0x00030964
			public ScrollViewScope(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, params GUILayoutOption[] options)
			{
				this.handleScrollWheel = true;
				this.scrollPosition = GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, options);
			}

			// Token: 0x0600288F RID: 10383 RVA: 0x00032784 File Offset: 0x00030984
			public ScrollViewScope(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
			{
				this.handleScrollWheel = true;
				this.scrollPosition = GUILayout.BeginScrollView(scrollPosition, horizontalScrollbar, verticalScrollbar, options);
			}

			// Token: 0x06002890 RID: 10384 RVA: 0x000327A4 File Offset: 0x000309A4
			public ScrollViewScope(Vector2 scrollPosition, GUIStyle style, params GUILayoutOption[] options)
			{
				this.handleScrollWheel = true;
				this.scrollPosition = GUILayout.BeginScrollView(scrollPosition, style, options);
			}

			// Token: 0x06002891 RID: 10385 RVA: 0x000327C4 File Offset: 0x000309C4
			public ScrollViewScope(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
			{
				this.handleScrollWheel = true;
				this.scrollPosition = GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, options);
			}

			// Token: 0x06002892 RID: 10386 RVA: 0x000327E8 File Offset: 0x000309E8
			public ScrollViewScope(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options)
			{
				this.handleScrollWheel = true;
				this.scrollPosition = GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background, options);
			}

			// Token: 0x1700099F RID: 2463
			// (get) Token: 0x06002893 RID: 10387 RVA: 0x00032810 File Offset: 0x00030A10
			// (set) Token: 0x06002894 RID: 10388 RVA: 0x0003282C File Offset: 0x00030A2C
			public Vector2 scrollPosition { get; private set; }

			// Token: 0x170009A0 RID: 2464
			// (get) Token: 0x06002895 RID: 10389 RVA: 0x00032838 File Offset: 0x00030A38
			// (set) Token: 0x06002896 RID: 10390 RVA: 0x00032854 File Offset: 0x00030A54
			public bool handleScrollWheel { get; set; }

			// Token: 0x06002897 RID: 10391 RVA: 0x00032860 File Offset: 0x00030A60
			protected override void CloseScope()
			{
				GUILayout.EndScrollView(this.handleScrollWheel);
			}
		}
	}
}
