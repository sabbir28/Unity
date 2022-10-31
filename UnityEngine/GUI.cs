using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x0200024A RID: 586
	public class GUI
	{
		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06002710 RID: 10000 RVA: 0x0002DBE4 File Offset: 0x0002BDE4
		// (set) Token: 0x06002711 RID: 10001 RVA: 0x0002DC00 File Offset: 0x0002BE00
		internal static int scrollTroughSide { get; set; }

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06002712 RID: 10002 RVA: 0x0002DC08 File Offset: 0x0002BE08
		// (set) Token: 0x06002713 RID: 10003 RVA: 0x0002DC24 File Offset: 0x0002BE24
		internal static DateTime nextScrollStepTime { get; set; } = DateTime.Now;

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06002715 RID: 10005 RVA: 0x0002DC3C File Offset: 0x0002BE3C
		// (set) Token: 0x06002714 RID: 10004 RVA: 0x0002DC2C File Offset: 0x0002BE2C
		public static GUISkin skin
		{
			get
			{
				GUIUtility.CheckOnGUI();
				return GUI.s_Skin;
			}
			set
			{
				GUIUtility.CheckOnGUI();
				GUI.DoSetSkin(value);
			}
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x0002DC5C File Offset: 0x0002BE5C
		internal static void DoSetSkin(GUISkin newSkin)
		{
			if (!newSkin)
			{
				newSkin = GUIUtility.GetDefaultSkin();
			}
			GUI.s_Skin = newSkin;
			newSkin.MakeCurrent();
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x0002DC80 File Offset: 0x0002BE80
		internal static void CleanupRoots()
		{
			GUI.s_Skin = null;
			GUIUtility.CleanupRoots();
			GUILayoutUtility.CleanupRoots();
			GUISkin.CleanupRoots();
			GUIStyle.CleanupRoots();
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06002718 RID: 10008 RVA: 0x0002DCA0 File Offset: 0x0002BEA0
		// (set) Token: 0x06002719 RID: 10009 RVA: 0x0002DCBC File Offset: 0x0002BEBC
		public static Matrix4x4 matrix
		{
			get
			{
				return GUIClip.GetMatrix();
			}
			set
			{
				GUIClip.SetMatrix(value);
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x0600271A RID: 10010 RVA: 0x0002DCC8 File Offset: 0x0002BEC8
		// (set) Token: 0x0600271B RID: 10011 RVA: 0x0002DCF8 File Offset: 0x0002BEF8
		public static string tooltip
		{
			get
			{
				string text = GUI.Internal_GetTooltip();
				string result;
				if (text != null)
				{
					result = text;
				}
				else
				{
					result = "";
				}
				return result;
			}
			set
			{
				GUI.Internal_SetTooltip(value);
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x0600271C RID: 10012 RVA: 0x0002DD04 File Offset: 0x0002BF04
		protected static string mouseTooltip
		{
			get
			{
				return GUI.Internal_GetMouseTooltip();
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x0600271D RID: 10013 RVA: 0x0002DD20 File Offset: 0x0002BF20
		// (set) Token: 0x0600271E RID: 10014 RVA: 0x0002DD3C File Offset: 0x0002BF3C
		protected static Rect tooltipRect
		{
			get
			{
				return GUI.s_ToolTipRect;
			}
			set
			{
				GUI.s_ToolTipRect = value;
			}
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x0002DD48 File Offset: 0x0002BF48
		public static void Label(Rect position, string text)
		{
			GUI.Label(position, GUIContent.Temp(text), GUI.s_Skin.label);
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x0002DD64 File Offset: 0x0002BF64
		public static void Label(Rect position, Texture image)
		{
			GUI.Label(position, GUIContent.Temp(image), GUI.s_Skin.label);
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x0002DD80 File Offset: 0x0002BF80
		public static void Label(Rect position, GUIContent content)
		{
			GUI.Label(position, content, GUI.s_Skin.label);
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x0002DD94 File Offset: 0x0002BF94
		public static void Label(Rect position, string text, GUIStyle style)
		{
			GUI.Label(position, GUIContent.Temp(text), style);
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x0002DDA4 File Offset: 0x0002BFA4
		public static void Label(Rect position, Texture image, GUIStyle style)
		{
			GUI.Label(position, GUIContent.Temp(image), style);
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x0002DDB4 File Offset: 0x0002BFB4
		public static void Label(Rect position, GUIContent content, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			GUI.DoLabel(position, content, style.m_Ptr);
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x0002DDCC File Offset: 0x0002BFCC
		public static void DrawTexture(Rect position, Texture image)
		{
			GUI.DrawTexture(position, image, ScaleMode.StretchToFill);
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x0002DDD8 File Offset: 0x0002BFD8
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode)
		{
			GUI.DrawTexture(position, image, scaleMode, true);
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x0002DDE4 File Offset: 0x0002BFE4
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend)
		{
			GUI.DrawTexture(position, image, scaleMode, alphaBlend, 0f);
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x0002DDF8 File Offset: 0x0002BFF8
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect)
		{
			GUIUtility.CheckOnGUI();
			if (Event.current.type == EventType.Repaint)
			{
				if (image == null)
				{
					Debug.LogWarning("null texture passed to GUI.DrawTexture");
				}
				else
				{
					if (imageAspect == 0f)
					{
						imageAspect = (float)image.width / (float)image.height;
					}
					Material mat = (!alphaBlend) ? GUI.blitMaterial : GUI.blendMaterial;
					Internal_DrawTextureArguments internal_DrawTextureArguments = default(Internal_DrawTextureArguments);
					internal_DrawTextureArguments.leftBorder = 0;
					internal_DrawTextureArguments.rightBorder = 0;
					internal_DrawTextureArguments.topBorder = 0;
					internal_DrawTextureArguments.bottomBorder = 0;
					internal_DrawTextureArguments.color = GUI.color;
					internal_DrawTextureArguments.texture = image;
					internal_DrawTextureArguments.mat = mat;
					GUI.CalculateScaledTextureRects(position, scaleMode, imageAspect, ref internal_DrawTextureArguments.screenRect, ref internal_DrawTextureArguments.sourceRect);
					Graphics.Internal_DrawTexture(ref internal_DrawTextureArguments);
				}
			}
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x0002DED4 File Offset: 0x0002C0D4
		internal static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, ref Rect outScreenRect, ref Rect outSourceRect)
		{
			float num = position.width / position.height;
			bool result = false;
			if (scaleMode != ScaleMode.StretchToFill)
			{
				if (scaleMode != ScaleMode.ScaleAndCrop)
				{
					if (scaleMode == ScaleMode.ScaleToFit)
					{
						if (num > imageAspect)
						{
							float num2 = imageAspect / num;
							outScreenRect = new Rect(position.xMin + position.width * (1f - num2) * 0.5f, position.yMin, num2 * position.width, position.height);
							outSourceRect = new Rect(0f, 0f, 1f, 1f);
							result = true;
						}
						else
						{
							float num3 = num / imageAspect;
							outScreenRect = new Rect(position.xMin, position.yMin + position.height * (1f - num3) * 0.5f, position.width, num3 * position.height);
							outSourceRect = new Rect(0f, 0f, 1f, 1f);
							result = true;
						}
					}
				}
				else if (num > imageAspect)
				{
					float num4 = imageAspect / num;
					outScreenRect = position;
					outSourceRect = new Rect(0f, (1f - num4) * 0.5f, 1f, num4);
					result = true;
				}
				else
				{
					float num5 = num / imageAspect;
					outScreenRect = position;
					outSourceRect = new Rect(0.5f - num5 * 0.5f, 0f, num5, 1f);
					result = true;
				}
			}
			else
			{
				outScreenRect = position;
				outSourceRect = new Rect(0f, 0f, 1f, 1f);
				result = true;
			}
			return result;
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x0002E080 File Offset: 0x0002C280
		public static void DrawTextureWithTexCoords(Rect position, Texture image, Rect texCoords)
		{
			GUI.DrawTextureWithTexCoords(position, image, texCoords, true);
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x0002E08C File Offset: 0x0002C28C
		public static void DrawTextureWithTexCoords(Rect position, Texture image, Rect texCoords, bool alphaBlend)
		{
			GUIUtility.CheckOnGUI();
			if (Event.current.type == EventType.Repaint)
			{
				Material mat = (!alphaBlend) ? GUI.blitMaterial : GUI.blendMaterial;
				Internal_DrawTextureArguments internal_DrawTextureArguments = default(Internal_DrawTextureArguments);
				internal_DrawTextureArguments.texture = image;
				internal_DrawTextureArguments.mat = mat;
				internal_DrawTextureArguments.leftBorder = 0;
				internal_DrawTextureArguments.rightBorder = 0;
				internal_DrawTextureArguments.topBorder = 0;
				internal_DrawTextureArguments.bottomBorder = 0;
				internal_DrawTextureArguments.color = GUI.color;
				internal_DrawTextureArguments.screenRect = position;
				internal_DrawTextureArguments.sourceRect = texCoords;
				Graphics.Internal_DrawTexture(ref internal_DrawTextureArguments);
			}
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x0002E128 File Offset: 0x0002C328
		public static void Box(Rect position, string text)
		{
			GUI.Box(position, GUIContent.Temp(text), GUI.s_Skin.box);
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x0002E144 File Offset: 0x0002C344
		public static void Box(Rect position, Texture image)
		{
			GUI.Box(position, GUIContent.Temp(image), GUI.s_Skin.box);
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x0002E160 File Offset: 0x0002C360
		public static void Box(Rect position, GUIContent content)
		{
			GUI.Box(position, content, GUI.s_Skin.box);
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x0002E174 File Offset: 0x0002C374
		public static void Box(Rect position, string text, GUIStyle style)
		{
			GUI.Box(position, GUIContent.Temp(text), style);
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x0002E184 File Offset: 0x0002C384
		public static void Box(Rect position, Texture image, GUIStyle style)
		{
			GUI.Box(position, GUIContent.Temp(image), style);
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x0002E194 File Offset: 0x0002C394
		public static void Box(Rect position, GUIContent content, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			int controlID = GUIUtility.GetControlID(GUI.s_BoxHash, FocusType.Passive);
			if (Event.current.type == EventType.Repaint)
			{
				style.Draw(position, content, controlID);
			}
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x0002E1D0 File Offset: 0x0002C3D0
		public static bool Button(Rect position, string text)
		{
			return GUI.Button(position, GUIContent.Temp(text), GUI.s_Skin.button);
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x0002E1FC File Offset: 0x0002C3FC
		public static bool Button(Rect position, Texture image)
		{
			return GUI.Button(position, GUIContent.Temp(image), GUI.s_Skin.button);
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x0002E228 File Offset: 0x0002C428
		public static bool Button(Rect position, GUIContent content)
		{
			return GUI.Button(position, content, GUI.s_Skin.button);
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x0002E250 File Offset: 0x0002C450
		public static bool Button(Rect position, string text, GUIStyle style)
		{
			return GUI.Button(position, GUIContent.Temp(text), style);
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x0002E274 File Offset: 0x0002C474
		public static bool Button(Rect position, Texture image, GUIStyle style)
		{
			return GUI.Button(position, GUIContent.Temp(image), style);
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x0002E298 File Offset: 0x0002C498
		public static bool Button(Rect position, GUIContent content, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoButton(position, content, style.m_Ptr);
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x0002E2C0 File Offset: 0x0002C4C0
		public static bool RepeatButton(Rect position, string text)
		{
			return GUI.DoRepeatButton(position, GUIContent.Temp(text), GUI.s_Skin.button, FocusType.Passive);
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x0002E2EC File Offset: 0x0002C4EC
		public static bool RepeatButton(Rect position, Texture image)
		{
			return GUI.DoRepeatButton(position, GUIContent.Temp(image), GUI.s_Skin.button, FocusType.Passive);
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x0002E318 File Offset: 0x0002C518
		public static bool RepeatButton(Rect position, GUIContent content)
		{
			return GUI.DoRepeatButton(position, content, GUI.s_Skin.button, FocusType.Passive);
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x0002E340 File Offset: 0x0002C540
		public static bool RepeatButton(Rect position, string text, GUIStyle style)
		{
			return GUI.DoRepeatButton(position, GUIContent.Temp(text), style, FocusType.Passive);
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x0002E364 File Offset: 0x0002C564
		public static bool RepeatButton(Rect position, Texture image, GUIStyle style)
		{
			return GUI.DoRepeatButton(position, GUIContent.Temp(image), style, FocusType.Passive);
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x0002E388 File Offset: 0x0002C588
		public static bool RepeatButton(Rect position, GUIContent content, GUIStyle style)
		{
			return GUI.DoRepeatButton(position, content, style, FocusType.Passive);
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x0002E3A8 File Offset: 0x0002C5A8
		private static bool DoRepeatButton(Rect position, GUIContent content, GUIStyle style, FocusType focusType)
		{
			GUIUtility.CheckOnGUI();
			int controlID = GUIUtility.GetControlID(GUI.s_RepeatButtonHash, focusType, position);
			EventType typeForControl = Event.current.GetTypeForControl(controlID);
			bool result;
			if (typeForControl != EventType.MouseDown)
			{
				if (typeForControl != EventType.MouseUp)
				{
					if (typeForControl != EventType.Repaint)
					{
						result = false;
					}
					else
					{
						style.Draw(position, content, controlID);
						result = (controlID == GUIUtility.hotControl && position.Contains(Event.current.mousePosition));
					}
				}
				else if (GUIUtility.hotControl == controlID)
				{
					GUIUtility.hotControl = 0;
					Event.current.Use();
					result = position.Contains(Event.current.mousePosition);
				}
				else
				{
					result = false;
				}
			}
			else
			{
				if (position.Contains(Event.current.mousePosition))
				{
					GUIUtility.hotControl = controlID;
					Event.current.Use();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x0002E48C File Offset: 0x0002C68C
		public static string TextField(Rect position, string text)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, false, -1, GUI.skin.textField);
			return guicontent.text;
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x0002E4C8 File Offset: 0x0002C6C8
		public static string TextField(Rect position, string text, int maxLength)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, false, maxLength, GUI.skin.textField);
			return guicontent.text;
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x0002E504 File Offset: 0x0002C704
		public static string TextField(Rect position, string text, GUIStyle style)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, false, -1, style);
			return guicontent.text;
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x0002E538 File Offset: 0x0002C738
		public static string TextField(Rect position, string text, int maxLength, GUIStyle style)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, false, maxLength, style);
			return guicontent.text;
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x0002E56C File Offset: 0x0002C76C
		public static string PasswordField(Rect position, string password, char maskChar)
		{
			return GUI.PasswordField(position, password, maskChar, -1, GUI.skin.textField);
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x0002E594 File Offset: 0x0002C794
		public static string PasswordField(Rect position, string password, char maskChar, int maxLength)
		{
			return GUI.PasswordField(position, password, maskChar, maxLength, GUI.skin.textField);
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x0002E5BC File Offset: 0x0002C7BC
		public static string PasswordField(Rect position, string password, char maskChar, GUIStyle style)
		{
			return GUI.PasswordField(position, password, maskChar, -1, style);
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x0002E5DC File Offset: 0x0002C7DC
		public static string PasswordField(Rect position, string password, char maskChar, int maxLength, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			string text = GUI.PasswordFieldGetStrToShow(password, maskChar);
			GUIContent guicontent = GUIContent.Temp(text);
			bool changed = GUI.changed;
			GUI.changed = false;
			if (TouchScreenKeyboard.isSupported)
			{
				GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard), guicontent, false, maxLength, style, password, maskChar);
			}
			else
			{
				GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, false, maxLength, style);
			}
			text = ((!GUI.changed) ? password : guicontent.text);
			GUI.changed = (GUI.changed || changed);
			return text;
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x0002E66C File Offset: 0x0002C86C
		internal static string PasswordFieldGetStrToShow(string password, char maskChar)
		{
			return (Event.current.type != EventType.Repaint && Event.current.type != EventType.MouseDown) ? password : "".PadRight(password.Length, maskChar);
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x0002E6B8 File Offset: 0x0002C8B8
		public static string TextArea(Rect position, string text)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, true, -1, GUI.skin.textArea);
			return guicontent.text;
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x0002E6F4 File Offset: 0x0002C8F4
		public static string TextArea(Rect position, string text, int maxLength)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, true, maxLength, GUI.skin.textArea);
			return guicontent.text;
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x0002E730 File Offset: 0x0002C930
		public static string TextArea(Rect position, string text, GUIStyle style)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, true, -1, style);
			return guicontent.text;
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x0002E764 File Offset: 0x0002C964
		public static string TextArea(Rect position, string text, int maxLength, GUIStyle style)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, false, maxLength, style);
			return guicontent.text;
		}

		// Token: 0x0600274C RID: 10060 RVA: 0x0002E798 File Offset: 0x0002C998
		private static string TextArea(Rect position, GUIContent content, int maxLength, GUIStyle style)
		{
			GUIContent guicontent = GUIContent.Temp(content.text, content.image);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, false, maxLength, style);
			return guicontent.text;
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x0002E7D8 File Offset: 0x0002C9D8
		internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style)
		{
			GUI.DoTextField(position, id, content, multiline, maxLength, style, null);
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x0002E7EC File Offset: 0x0002C9EC
		internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText)
		{
			GUI.DoTextField(position, id, content, multiline, maxLength, style, secureText, '\0');
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x0002E800 File Offset: 0x0002CA00
		internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar)
		{
			GUIUtility.CheckOnGUI();
			if (maxLength >= 0 && content.text.Length > maxLength)
			{
				content.text = content.text.Substring(0, maxLength);
			}
			TextEditor textEditor = (TextEditor)GUIUtility.GetStateObject(typeof(TextEditor), id);
			textEditor.text = content.text;
			textEditor.SaveBackup();
			textEditor.position = position;
			textEditor.style = style;
			textEditor.multiline = multiline;
			textEditor.controlID = id;
			textEditor.DetectFocusChange();
			if (TouchScreenKeyboard.isSupported)
			{
				GUI.HandleTextFieldEventForTouchscreen(position, id, content, multiline, maxLength, style, secureText, maskChar, textEditor);
			}
			else
			{
				GUI.HandleTextFieldEventForDesktop(position, id, content, multiline, maxLength, style, textEditor);
			}
			textEditor.UpdateScrollOffsetIfNeeded(Event.current);
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x0002E8CC File Offset: 0x0002CACC
		private static void HandleTextFieldEventForTouchscreen(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar, TextEditor editor)
		{
			Event current = Event.current;
			EventType type = current.type;
			if (type != EventType.MouseDown)
			{
				if (type == EventType.Repaint)
				{
					if (editor.keyboardOnScreen != null)
					{
						content.text = editor.keyboardOnScreen.text;
						if (maxLength >= 0 && content.text.Length > maxLength)
						{
							content.text = content.text.Substring(0, maxLength);
						}
						if (editor.keyboardOnScreen.done)
						{
							editor.keyboardOnScreen = null;
							GUI.changed = true;
						}
					}
					string text = content.text;
					if (secureText != null)
					{
						content.text = GUI.PasswordFieldGetStrToShow(text, maskChar);
					}
					style.Draw(position, content, id, false);
					content.text = text;
				}
			}
			else if (position.Contains(current.mousePosition))
			{
				GUIUtility.hotControl = id;
				if (GUI.s_HotTextField != -1 && GUI.s_HotTextField != id)
				{
					TextEditor textEditor = (TextEditor)GUIUtility.GetStateObject(typeof(TextEditor), GUI.s_HotTextField);
					textEditor.keyboardOnScreen = null;
				}
				GUI.s_HotTextField = id;
				if (GUIUtility.keyboardControl != id)
				{
					GUIUtility.keyboardControl = id;
				}
				editor.keyboardOnScreen = TouchScreenKeyboard.Open((secureText == null) ? content.text : secureText, TouchScreenKeyboardType.Default, true, multiline, secureText != null);
				current.Use();
			}
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x0002EA3C File Offset: 0x0002CC3C
		private static void HandleTextFieldEventForDesktop(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, TextEditor editor)
		{
			Event current = Event.current;
			bool flag = false;
			switch (current.type)
			{
			case EventType.MouseDown:
				if (position.Contains(current.mousePosition))
				{
					GUIUtility.hotControl = id;
					GUIUtility.keyboardControl = id;
					editor.m_HasFocus = true;
					editor.MoveCursorToPosition(Event.current.mousePosition);
					if (Event.current.clickCount == 2 && GUI.skin.settings.doubleClickSelectsWord)
					{
						editor.SelectCurrentWord();
						editor.DblClickSnap(TextEditor.DblClickSnapping.WORDS);
						editor.MouseDragSelectsWholeWords(true);
					}
					if (Event.current.clickCount == 3 && GUI.skin.settings.tripleClickSelectsLine)
					{
						editor.SelectCurrentParagraph();
						editor.MouseDragSelectsWholeWords(true);
						editor.DblClickSnap(TextEditor.DblClickSnapping.PARAGRAPHS);
					}
					current.Use();
				}
				break;
			case EventType.MouseUp:
				if (GUIUtility.hotControl == id)
				{
					editor.MouseDragSelectsWholeWords(false);
					GUIUtility.hotControl = 0;
					current.Use();
				}
				break;
			case EventType.MouseDrag:
				if (GUIUtility.hotControl == id)
				{
					if (current.shift)
					{
						editor.MoveCursorToPosition(Event.current.mousePosition);
					}
					else
					{
						editor.SelectToPosition(Event.current.mousePosition);
					}
					current.Use();
				}
				break;
			case EventType.KeyDown:
				if (GUIUtility.keyboardControl != id)
				{
					return;
				}
				if (editor.HandleKeyEvent(current))
				{
					current.Use();
					flag = true;
					content.text = editor.text;
				}
				else
				{
					if (current.keyCode == KeyCode.Tab || current.character == '\t')
					{
						return;
					}
					char character = current.character;
					if (character == '\n' && !multiline && !current.alt)
					{
						return;
					}
					Font font = style.font;
					if (!font)
					{
						font = GUI.skin.font;
					}
					if (font.HasCharacter(character) || character == '\n')
					{
						editor.Insert(character);
						flag = true;
					}
					else if (character == '\0')
					{
						if (Input.compositionString.Length > 0)
						{
							editor.ReplaceSelection("");
							flag = true;
						}
						current.Use();
					}
				}
				break;
			case EventType.Repaint:
				if (GUIUtility.keyboardControl != id)
				{
					style.Draw(position, content, id, false);
				}
				else
				{
					editor.DrawCursor(content.text);
				}
				break;
			}
			if (GUIUtility.keyboardControl == id)
			{
				GUIUtility.textFieldInput = true;
			}
			if (flag)
			{
				GUI.changed = true;
				content.text = editor.text;
				if (maxLength >= 0 && content.text.Length > maxLength)
				{
					content.text = content.text.Substring(0, maxLength);
				}
				current.Use();
			}
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x0002ED38 File Offset: 0x0002CF38
		public static bool Toggle(Rect position, bool value, string text)
		{
			return GUI.Toggle(position, value, GUIContent.Temp(text), GUI.s_Skin.toggle);
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x0002ED64 File Offset: 0x0002CF64
		public static bool Toggle(Rect position, bool value, Texture image)
		{
			return GUI.Toggle(position, value, GUIContent.Temp(image), GUI.s_Skin.toggle);
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x0002ED90 File Offset: 0x0002CF90
		public static bool Toggle(Rect position, bool value, GUIContent content)
		{
			return GUI.Toggle(position, value, content, GUI.s_Skin.toggle);
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x0002EDB8 File Offset: 0x0002CFB8
		public static bool Toggle(Rect position, bool value, string text, GUIStyle style)
		{
			return GUI.Toggle(position, value, GUIContent.Temp(text), style);
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x0002EDDC File Offset: 0x0002CFDC
		public static bool Toggle(Rect position, bool value, Texture image, GUIStyle style)
		{
			return GUI.Toggle(position, value, GUIContent.Temp(image), style);
		}

		// Token: 0x06002757 RID: 10071 RVA: 0x0002EE00 File Offset: 0x0002D000
		public static bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoToggle(position, GUIUtility.GetControlID(GUI.s_ToggleHash, FocusType.Passive, position), value, content, style.m_Ptr);
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x0002EE34 File Offset: 0x0002D034
		public static bool Toggle(Rect position, int id, bool value, GUIContent content, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoToggle(position, id, value, content, style.m_Ptr);
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x0002EE60 File Offset: 0x0002D060
		public static int Toolbar(Rect position, int selected, string[] texts)
		{
			return GUI.Toolbar(position, selected, GUIContent.Temp(texts), GUI.s_Skin.button);
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x0002EE8C File Offset: 0x0002D08C
		public static int Toolbar(Rect position, int selected, Texture[] images)
		{
			return GUI.Toolbar(position, selected, GUIContent.Temp(images), GUI.s_Skin.button);
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x0002EEB8 File Offset: 0x0002D0B8
		public static int Toolbar(Rect position, int selected, GUIContent[] content)
		{
			return GUI.Toolbar(position, selected, content, GUI.s_Skin.button);
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x0002EEE0 File Offset: 0x0002D0E0
		public static int Toolbar(Rect position, int selected, string[] texts, GUIStyle style)
		{
			return GUI.Toolbar(position, selected, GUIContent.Temp(texts), style);
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x0002EF04 File Offset: 0x0002D104
		public static int Toolbar(Rect position, int selected, Texture[] images, GUIStyle style)
		{
			return GUI.Toolbar(position, selected, GUIContent.Temp(images), style);
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x0002EF28 File Offset: 0x0002D128
		public static int Toolbar(Rect position, int selected, GUIContent[] contents, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			GUIStyle firstStyle;
			GUIStyle midStyle;
			GUIStyle lastStyle;
			GUI.FindStyles(ref style, out firstStyle, out midStyle, out lastStyle, "left", "mid", "right");
			return GUI.DoButtonGrid(position, selected, contents, contents.Length, style, firstStyle, midStyle, lastStyle);
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x0002EF70 File Offset: 0x0002D170
		public static int SelectionGrid(Rect position, int selected, string[] texts, int xCount)
		{
			return GUI.SelectionGrid(position, selected, GUIContent.Temp(texts), xCount, null);
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x0002EF94 File Offset: 0x0002D194
		public static int SelectionGrid(Rect position, int selected, Texture[] images, int xCount)
		{
			return GUI.SelectionGrid(position, selected, GUIContent.Temp(images), xCount, null);
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x0002EFB8 File Offset: 0x0002D1B8
		public static int SelectionGrid(Rect position, int selected, GUIContent[] content, int xCount)
		{
			return GUI.SelectionGrid(position, selected, content, xCount, null);
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x0002EFD8 File Offset: 0x0002D1D8
		public static int SelectionGrid(Rect position, int selected, string[] texts, int xCount, GUIStyle style)
		{
			return GUI.SelectionGrid(position, selected, GUIContent.Temp(texts), xCount, style);
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x0002F000 File Offset: 0x0002D200
		public static int SelectionGrid(Rect position, int selected, Texture[] images, int xCount, GUIStyle style)
		{
			return GUI.SelectionGrid(position, selected, GUIContent.Temp(images), xCount, style);
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x0002F028 File Offset: 0x0002D228
		public static int SelectionGrid(Rect position, int selected, GUIContent[] contents, int xCount, GUIStyle style)
		{
			if (style == null)
			{
				style = GUI.s_Skin.button;
			}
			return GUI.DoButtonGrid(position, selected, contents, xCount, style, style, style, style);
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x0002F064 File Offset: 0x0002D264
		internal static void FindStyles(ref GUIStyle style, out GUIStyle firstStyle, out GUIStyle midStyle, out GUIStyle lastStyle, string first, string mid, string last)
		{
			if (style == null)
			{
				style = GUI.skin.button;
			}
			string name = style.name;
			midStyle = GUI.skin.FindStyle(name + mid);
			if (midStyle == null)
			{
				midStyle = style;
			}
			firstStyle = GUI.skin.FindStyle(name + first);
			if (firstStyle == null)
			{
				firstStyle = midStyle;
			}
			lastStyle = GUI.skin.FindStyle(name + last);
			if (lastStyle == null)
			{
				lastStyle = midStyle;
			}
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x0002F0EC File Offset: 0x0002D2EC
		internal static int CalcTotalHorizSpacing(int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle)
		{
			int result;
			if (xCount < 2)
			{
				result = 0;
			}
			else if (xCount == 2)
			{
				result = Mathf.Max(firstStyle.margin.right, lastStyle.margin.left);
			}
			else
			{
				int num = Mathf.Max(midStyle.margin.left, midStyle.margin.right);
				result = Mathf.Max(firstStyle.margin.right, midStyle.margin.left) + Mathf.Max(midStyle.margin.right, lastStyle.margin.left) + num * (xCount - 3);
			}
			return result;
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x0002F194 File Offset: 0x0002D394
		private static int DoButtonGrid(Rect position, int selected, GUIContent[] contents, int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle)
		{
			GUIUtility.CheckOnGUI();
			int num = contents.Length;
			int result;
			if (num == 0)
			{
				result = selected;
			}
			else if (xCount <= 0)
			{
				Debug.LogWarning("You are trying to create a SelectionGrid with zero or less elements to be displayed in the horizontal direction. Set xCount to a positive value.");
				result = selected;
			}
			else
			{
				int controlID = GUIUtility.GetControlID(GUI.s_ButtonGridHash, FocusType.Passive, position);
				int num2 = num / xCount;
				if (num % xCount != 0)
				{
					num2++;
				}
				float num3 = (float)GUI.CalcTotalHorizSpacing(xCount, style, firstStyle, midStyle, lastStyle);
				float num4 = (float)(Mathf.Max(style.margin.top, style.margin.bottom) * (num2 - 1));
				float elemWidth = (position.width - num3) / (float)xCount;
				float elemHeight = (position.height - num4) / (float)num2;
				if (style.fixedWidth != 0f)
				{
					elemWidth = style.fixedWidth;
				}
				if (style.fixedHeight != 0f)
				{
					elemHeight = style.fixedHeight;
				}
				switch (Event.current.GetTypeForControl(controlID))
				{
				case EventType.MouseDown:
					if (position.Contains(Event.current.mousePosition))
					{
						Rect[] array = GUI.CalcMouseRects(position, num, xCount, elemWidth, elemHeight, style, firstStyle, midStyle, lastStyle, false);
						if (GUI.GetButtonGridMouseSelection(array, Event.current.mousePosition, true) != -1)
						{
							GUIUtility.hotControl = controlID;
							Event.current.Use();
						}
					}
					break;
				case EventType.MouseUp:
					if (GUIUtility.hotControl == controlID)
					{
						GUIUtility.hotControl = 0;
						Event.current.Use();
						Rect[] array = GUI.CalcMouseRects(position, num, xCount, elemWidth, elemHeight, style, firstStyle, midStyle, lastStyle, false);
						int buttonGridMouseSelection = GUI.GetButtonGridMouseSelection(array, Event.current.mousePosition, true);
						GUI.changed = true;
						return buttonGridMouseSelection;
					}
					break;
				case EventType.MouseDrag:
					if (GUIUtility.hotControl == controlID)
					{
						Event.current.Use();
					}
					break;
				case EventType.Repaint:
				{
					GUIStyle guistyle = null;
					GUIClip.Push(position, Vector2.zero, Vector2.zero, false);
					position = new Rect(0f, 0f, position.width, position.height);
					Rect[] array = GUI.CalcMouseRects(position, num, xCount, elemWidth, elemHeight, style, firstStyle, midStyle, lastStyle, false);
					int buttonGridMouseSelection2 = GUI.GetButtonGridMouseSelection(array, Event.current.mousePosition, controlID == GUIUtility.hotControl);
					bool flag = position.Contains(Event.current.mousePosition);
					GUIUtility.mouseUsed = (GUIUtility.mouseUsed || flag);
					for (int i = 0; i < num; i++)
					{
						GUIStyle guistyle2;
						if (i != 0)
						{
							guistyle2 = midStyle;
						}
						else
						{
							guistyle2 = firstStyle;
						}
						if (i == num - 1)
						{
							guistyle2 = lastStyle;
						}
						if (num == 1)
						{
							guistyle2 = style;
						}
						if (i != selected)
						{
							guistyle2.Draw(array[i], contents[i], i == buttonGridMouseSelection2 && (GUI.enabled || controlID == GUIUtility.hotControl) && (controlID == GUIUtility.hotControl || GUIUtility.hotControl == 0), controlID == GUIUtility.hotControl && GUI.enabled, false, false);
						}
						else
						{
							guistyle = guistyle2;
						}
					}
					if (selected < num && selected > -1)
					{
						guistyle.Draw(array[selected], contents[selected], selected == buttonGridMouseSelection2 && (GUI.enabled || controlID == GUIUtility.hotControl) && (controlID == GUIUtility.hotControl || GUIUtility.hotControl == 0), controlID == GUIUtility.hotControl, true, false);
					}
					if (buttonGridMouseSelection2 >= 0)
					{
						GUI.tooltip = contents[buttonGridMouseSelection2].tooltip;
					}
					GUIClip.Pop();
					break;
				}
				}
				result = selected;
			}
			return result;
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x0002F558 File Offset: 0x0002D758
		private static Rect[] CalcMouseRects(Rect position, int count, int xCount, float elemWidth, float elemHeight, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, bool addBorders)
		{
			int num = 0;
			int num2 = 0;
			float num3 = position.xMin;
			float num4 = position.yMin;
			GUIStyle guistyle = style;
			Rect[] array = new Rect[count];
			if (count > 1)
			{
				guistyle = firstStyle;
			}
			for (int i = 0; i < count; i++)
			{
				if (!addBorders)
				{
					array[i] = new Rect(num3, num4, elemWidth, elemHeight);
				}
				else
				{
					array[i] = guistyle.margin.Add(new Rect(num3, num4, elemWidth, elemHeight));
				}
				array[i].width = Mathf.Round(array[i].xMax) - Mathf.Round(array[i].x);
				array[i].x = Mathf.Round(array[i].x);
				GUIStyle guistyle2 = midStyle;
				if (i == count - 2)
				{
					guistyle2 = lastStyle;
				}
				num3 += elemWidth + (float)Mathf.Max(guistyle.margin.right, guistyle2.margin.left);
				num2++;
				if (num2 >= xCount)
				{
					num++;
					num2 = 0;
					num4 += elemHeight + (float)Mathf.Max(style.margin.top, style.margin.bottom);
					num3 = position.xMin;
				}
			}
			return array;
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x0002F6C8 File Offset: 0x0002D8C8
		private static int GetButtonGridMouseSelection(Rect[] buttonRects, Vector2 mousePos, bool findNearest)
		{
			for (int i = 0; i < buttonRects.Length; i++)
			{
				if (buttonRects[i].Contains(mousePos))
				{
					return i;
				}
			}
			if (!findNearest)
			{
				return -1;
			}
			float num = 10000000f;
			int result = -1;
			for (int j = 0; j < buttonRects.Length; j++)
			{
				Rect rect = buttonRects[j];
				Vector2 b = new Vector2(Mathf.Clamp(mousePos.x, rect.xMin, rect.xMax), Mathf.Clamp(mousePos.y, rect.yMin, rect.yMax));
				float sqrMagnitude = (mousePos - b).sqrMagnitude;
				if (sqrMagnitude < num)
				{
					result = j;
					num = sqrMagnitude;
				}
			}
			return result;
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x0002F7AC File Offset: 0x0002D9AC
		public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue)
		{
			return GUI.Slider(position, value, 0f, leftValue, rightValue, GUI.skin.horizontalSlider, GUI.skin.horizontalSliderThumb, true, 0);
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x0002F7E8 File Offset: 0x0002D9E8
		public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb)
		{
			return GUI.Slider(position, value, 0f, leftValue, rightValue, slider, thumb, true, 0);
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x0002F814 File Offset: 0x0002DA14
		public static float VerticalSlider(Rect position, float value, float topValue, float bottomValue)
		{
			return GUI.Slider(position, value, 0f, topValue, bottomValue, GUI.skin.verticalSlider, GUI.skin.verticalSliderThumb, false, 0);
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x0002F850 File Offset: 0x0002DA50
		public static float VerticalSlider(Rect position, float value, float topValue, float bottomValue, GUIStyle slider, GUIStyle thumb)
		{
			return GUI.Slider(position, value, 0f, topValue, bottomValue, slider, thumb, false, 0);
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x0002F87C File Offset: 0x0002DA7C
		public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id)
		{
			GUIUtility.CheckOnGUI();
			if (id == 0)
			{
				id = GUIUtility.GetControlID(GUI.s_SliderHash, FocusType.Passive, position);
			}
			SliderHandler sliderHandler = new SliderHandler(position, value, size, start, end, slider, thumb, horiz, id);
			return sliderHandler.Handle();
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x0002F8CC File Offset: 0x0002DACC
		public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue)
		{
			return GUI.Scroller(position, value, size, leftValue, rightValue, GUI.skin.horizontalScrollbar, GUI.skin.horizontalScrollbarThumb, GUI.skin.horizontalScrollbarLeftButton, GUI.skin.horizontalScrollbarRightButton, true);
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x0002F918 File Offset: 0x0002DB18
		public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style)
		{
			return GUI.Scroller(position, value, size, leftValue, rightValue, style, GUI.skin.GetStyle(style.name + "thumb"), GUI.skin.GetStyle(style.name + "leftbutton"), GUI.skin.GetStyle(style.name + "rightbutton"), true);
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x0002F98C File Offset: 0x0002DB8C
		internal static bool ScrollerRepeatButton(int scrollerID, Rect rect, GUIStyle style)
		{
			bool result = false;
			if (GUI.DoRepeatButton(rect, GUIContent.none, style, FocusType.Passive))
			{
				bool flag = GUI.s_ScrollControlId != scrollerID;
				GUI.s_ScrollControlId = scrollerID;
				if (flag)
				{
					result = true;
					GUI.nextScrollStepTime = DateTime.Now.AddMilliseconds(250.0);
				}
				else if (DateTime.Now >= GUI.nextScrollStepTime)
				{
					result = true;
					GUI.nextScrollStepTime = DateTime.Now.AddMilliseconds(30.0);
				}
				if (Event.current.type == EventType.Repaint)
				{
					GUI.InternalRepaintEditorWindow();
				}
			}
			return result;
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x0002FA40 File Offset: 0x0002DC40
		public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue)
		{
			return GUI.Scroller(position, value, size, topValue, bottomValue, GUI.skin.verticalScrollbar, GUI.skin.verticalScrollbarThumb, GUI.skin.verticalScrollbarUpButton, GUI.skin.verticalScrollbarDownButton, false);
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x0002FA8C File Offset: 0x0002DC8C
		public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style)
		{
			return GUI.Scroller(position, value, size, topValue, bottomValue, style, GUI.skin.GetStyle(style.name + "thumb"), GUI.skin.GetStyle(style.name + "upbutton"), GUI.skin.GetStyle(style.name + "downbutton"), false);
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x0002FB00 File Offset: 0x0002DD00
		internal static float Scroller(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle leftButton, GUIStyle rightButton, bool horiz)
		{
			GUIUtility.CheckOnGUI();
			int controlID = GUIUtility.GetControlID(GUI.s_SliderHash, FocusType.Passive, position);
			Rect position2;
			Rect rect;
			Rect rect2;
			if (horiz)
			{
				position2 = new Rect(position.x + leftButton.fixedWidth, position.y, position.width - leftButton.fixedWidth - rightButton.fixedWidth, position.height);
				rect = new Rect(position.x, position.y, leftButton.fixedWidth, position.height);
				rect2 = new Rect(position.xMax - rightButton.fixedWidth, position.y, rightButton.fixedWidth, position.height);
			}
			else
			{
				position2 = new Rect(position.x, position.y + leftButton.fixedHeight, position.width, position.height - leftButton.fixedHeight - rightButton.fixedHeight);
				rect = new Rect(position.x, position.y, position.width, leftButton.fixedHeight);
				rect2 = new Rect(position.x, position.yMax - rightButton.fixedHeight, position.width, rightButton.fixedHeight);
			}
			value = GUI.Slider(position2, value, size, leftValue, rightValue, slider, thumb, horiz, controlID);
			bool flag = false;
			if (Event.current.type == EventType.MouseUp)
			{
				flag = true;
			}
			if (GUI.ScrollerRepeatButton(controlID, rect, leftButton))
			{
				value -= GUI.s_ScrollStepSize * ((leftValue >= rightValue) ? -1f : 1f);
			}
			if (GUI.ScrollerRepeatButton(controlID, rect2, rightButton))
			{
				value += GUI.s_ScrollStepSize * ((leftValue >= rightValue) ? -1f : 1f);
			}
			if (flag && Event.current.type == EventType.Used)
			{
				GUI.s_ScrollControlId = 0;
			}
			if (leftValue < rightValue)
			{
				value = Mathf.Clamp(value, leftValue, rightValue - size);
			}
			else
			{
				value = Mathf.Clamp(value, rightValue, leftValue - size);
			}
			return value;
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x0002FD1C File Offset: 0x0002DF1C
		public static void BeginClip(Rect position, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
		{
			GUIUtility.CheckOnGUI();
			GUIClip.Push(position, scrollOffset, renderOffset, resetOffset);
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x0002FD30 File Offset: 0x0002DF30
		public static void BeginGroup(Rect position)
		{
			GUI.BeginGroup(position, GUIContent.none, GUIStyle.none);
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x0002FD44 File Offset: 0x0002DF44
		public static void BeginGroup(Rect position, string text)
		{
			GUI.BeginGroup(position, GUIContent.Temp(text), GUIStyle.none);
		}

		// Token: 0x06002778 RID: 10104 RVA: 0x0002FD58 File Offset: 0x0002DF58
		public static void BeginGroup(Rect position, Texture image)
		{
			GUI.BeginGroup(position, GUIContent.Temp(image), GUIStyle.none);
		}

		// Token: 0x06002779 RID: 10105 RVA: 0x0002FD6C File Offset: 0x0002DF6C
		public static void BeginGroup(Rect position, GUIContent content)
		{
			GUI.BeginGroup(position, content, GUIStyle.none);
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x0002FD7C File Offset: 0x0002DF7C
		public static void BeginGroup(Rect position, GUIStyle style)
		{
			GUI.BeginGroup(position, GUIContent.none, style);
		}

		// Token: 0x0600277B RID: 10107 RVA: 0x0002FD8C File Offset: 0x0002DF8C
		public static void BeginGroup(Rect position, string text, GUIStyle style)
		{
			GUI.BeginGroup(position, GUIContent.Temp(text), style);
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x0002FD9C File Offset: 0x0002DF9C
		public static void BeginGroup(Rect position, Texture image, GUIStyle style)
		{
			GUI.BeginGroup(position, GUIContent.Temp(image), style);
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x0002FDAC File Offset: 0x0002DFAC
		public static void BeginGroup(Rect position, GUIContent content, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			int controlID = GUIUtility.GetControlID(GUI.s_BeginGroupHash, FocusType.Passive);
			if (content != GUIContent.none || style != GUIStyle.none)
			{
				EventType type = Event.current.type;
				if (type != EventType.Repaint)
				{
					if (position.Contains(Event.current.mousePosition))
					{
						GUIUtility.mouseUsed = true;
					}
				}
				else
				{
					style.Draw(position, content, controlID);
				}
			}
			GUIClip.Push(position, Vector2.zero, Vector2.zero, false);
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x0002FE3C File Offset: 0x0002E03C
		public static void EndGroup()
		{
			GUIUtility.CheckOnGUI();
			GUIClip.Internal_Pop();
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x0002FE4C File Offset: 0x0002E04C
		public static void BeginClip(Rect position)
		{
			GUIUtility.CheckOnGUI();
			GUIClip.Push(position, Vector2.zero, Vector2.zero, false);
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x0002FE68 File Offset: 0x0002E068
		public static void EndClip()
		{
			GUIUtility.CheckOnGUI();
			GUIClip.Pop();
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x0002FE78 File Offset: 0x0002E078
		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect)
		{
			return GUI.BeginScrollView(position, scrollPosition, viewRect, false, false, GUI.skin.horizontalScrollbar, GUI.skin.verticalScrollbar, GUI.skin.scrollView);
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x0002FEB8 File Offset: 0x0002E0B8
		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical)
		{
			return GUI.BeginScrollView(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical, GUI.skin.horizontalScrollbar, GUI.skin.verticalScrollbar, GUI.skin.scrollView);
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x0002FEF8 File Offset: 0x0002E0F8
		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar)
		{
			return GUI.BeginScrollView(position, scrollPosition, viewRect, false, false, horizontalScrollbar, verticalScrollbar, GUI.skin.scrollView);
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x0002FF24 File Offset: 0x0002E124
		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar)
		{
			return GUI.BeginScrollView(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, GUI.skin.scrollView);
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x0002FF54 File Offset: 0x0002E154
		protected static Vector2 DoBeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background)
		{
			return GUI.BeginScrollView(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background);
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x0002FF7C File Offset: 0x0002E17C
		internal static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background)
		{
			GUIUtility.CheckOnGUI();
			int controlID = GUIUtility.GetControlID(GUI.s_ScrollviewHash, FocusType.Passive);
			ScrollViewState scrollViewState = (ScrollViewState)GUIUtility.GetStateObject(typeof(ScrollViewState), controlID);
			if (scrollViewState.apply)
			{
				scrollPosition = scrollViewState.scrollPosition;
				scrollViewState.apply = false;
			}
			scrollViewState.position = position;
			scrollViewState.scrollPosition = scrollPosition;
			scrollViewState.visibleRect = (scrollViewState.viewRect = viewRect);
			scrollViewState.visibleRect.width = position.width;
			scrollViewState.visibleRect.height = position.height;
			GUI.s_ScrollViewStates.Push(scrollViewState);
			Rect screenRect = new Rect(position);
			EventType type = Event.current.type;
			if (type != EventType.Layout)
			{
				if (type != EventType.Used)
				{
					bool flag = alwaysShowVertical;
					bool flag2 = alwaysShowHorizontal;
					if (flag2 || viewRect.width > screenRect.width)
					{
						scrollViewState.visibleRect.height = position.height - horizontalScrollbar.fixedHeight + (float)horizontalScrollbar.margin.top;
						screenRect.height -= horizontalScrollbar.fixedHeight + (float)horizontalScrollbar.margin.top;
						flag2 = true;
					}
					if (flag || viewRect.height > screenRect.height)
					{
						scrollViewState.visibleRect.width = position.width - verticalScrollbar.fixedWidth + (float)verticalScrollbar.margin.left;
						screenRect.width -= verticalScrollbar.fixedWidth + (float)verticalScrollbar.margin.left;
						flag = true;
						if (!flag2 && viewRect.width > screenRect.width)
						{
							scrollViewState.visibleRect.height = position.height - horizontalScrollbar.fixedHeight + (float)horizontalScrollbar.margin.top;
							screenRect.height -= horizontalScrollbar.fixedHeight + (float)horizontalScrollbar.margin.top;
							flag2 = true;
						}
					}
					if (Event.current.type == EventType.Repaint && background != GUIStyle.none)
					{
						background.Draw(position, position.Contains(Event.current.mousePosition), false, flag2 && flag, false);
					}
					if (flag2 && horizontalScrollbar != GUIStyle.none)
					{
						scrollPosition.x = GUI.HorizontalScrollbar(new Rect(position.x, position.yMax - horizontalScrollbar.fixedHeight, screenRect.width, horizontalScrollbar.fixedHeight), scrollPosition.x, Mathf.Min(screenRect.width, viewRect.width), 0f, viewRect.width, horizontalScrollbar);
					}
					else
					{
						GUIUtility.GetControlID(GUI.s_SliderHash, FocusType.Passive);
						GUIUtility.GetControlID(GUI.s_RepeatButtonHash, FocusType.Passive);
						GUIUtility.GetControlID(GUI.s_RepeatButtonHash, FocusType.Passive);
						if (horizontalScrollbar != GUIStyle.none)
						{
							scrollPosition.x = 0f;
						}
						else
						{
							scrollPosition.x = Mathf.Clamp(scrollPosition.x, 0f, Mathf.Max(viewRect.width - position.width, 0f));
						}
					}
					if (flag && verticalScrollbar != GUIStyle.none)
					{
						scrollPosition.y = GUI.VerticalScrollbar(new Rect(screenRect.xMax + (float)verticalScrollbar.margin.left, screenRect.y, verticalScrollbar.fixedWidth, screenRect.height), scrollPosition.y, Mathf.Min(screenRect.height, viewRect.height), 0f, viewRect.height, verticalScrollbar);
					}
					else
					{
						GUIUtility.GetControlID(GUI.s_SliderHash, FocusType.Passive);
						GUIUtility.GetControlID(GUI.s_RepeatButtonHash, FocusType.Passive);
						GUIUtility.GetControlID(GUI.s_RepeatButtonHash, FocusType.Passive);
						if (verticalScrollbar != GUIStyle.none)
						{
							scrollPosition.y = 0f;
						}
						else
						{
							scrollPosition.y = Mathf.Clamp(scrollPosition.y, 0f, Mathf.Max(viewRect.height - position.height, 0f));
						}
					}
				}
			}
			else
			{
				GUIUtility.GetControlID(GUI.s_SliderHash, FocusType.Passive);
				GUIUtility.GetControlID(GUI.s_RepeatButtonHash, FocusType.Passive);
				GUIUtility.GetControlID(GUI.s_RepeatButtonHash, FocusType.Passive);
				GUIUtility.GetControlID(GUI.s_SliderHash, FocusType.Passive);
				GUIUtility.GetControlID(GUI.s_RepeatButtonHash, FocusType.Passive);
				GUIUtility.GetControlID(GUI.s_RepeatButtonHash, FocusType.Passive);
			}
			GUIClip.Push(screenRect, new Vector2(Mathf.Round(-scrollPosition.x - viewRect.x), Mathf.Round(-scrollPosition.y - viewRect.y)), Vector2.zero, false);
			return scrollPosition;
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x00030448 File Offset: 0x0002E648
		public static void EndScrollView()
		{
			GUI.EndScrollView(true);
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x00030454 File Offset: 0x0002E654
		public static void EndScrollView(bool handleScrollWheel)
		{
			GUIUtility.CheckOnGUI();
			ScrollViewState scrollViewState = (ScrollViewState)GUI.s_ScrollViewStates.Peek();
			GUIClip.Pop();
			GUI.s_ScrollViewStates.Pop();
			if (handleScrollWheel && Event.current.type == EventType.ScrollWheel && scrollViewState.position.Contains(Event.current.mousePosition))
			{
				scrollViewState.scrollPosition.x = Mathf.Clamp(scrollViewState.scrollPosition.x + Event.current.delta.x * 20f, 0f, scrollViewState.viewRect.width - scrollViewState.visibleRect.width);
				scrollViewState.scrollPosition.y = Mathf.Clamp(scrollViewState.scrollPosition.y + Event.current.delta.y * 20f, 0f, scrollViewState.viewRect.height - scrollViewState.visibleRect.height);
				scrollViewState.apply = true;
				Event.current.Use();
			}
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x0003056C File Offset: 0x0002E76C
		internal static ScrollViewState GetTopScrollView()
		{
			ScrollViewState result;
			if (GUI.s_ScrollViewStates.Count != 0)
			{
				result = (ScrollViewState)GUI.s_ScrollViewStates.Peek();
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x000305A8 File Offset: 0x0002E7A8
		public static void ScrollTo(Rect position)
		{
			ScrollViewState topScrollView = GUI.GetTopScrollView();
			if (topScrollView != null)
			{
				topScrollView.ScrollTo(position);
			}
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x000305CC File Offset: 0x0002E7CC
		public static bool ScrollTowards(Rect position, float maxDelta)
		{
			ScrollViewState topScrollView = GUI.GetTopScrollView();
			return topScrollView != null && topScrollView.ScrollTowards(position, maxDelta);
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x000305FC File Offset: 0x0002E7FC
		public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, string text)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoWindow(id, clientRect, func, GUIContent.Temp(text), GUI.skin.window, GUI.skin, true);
		}

		// Token: 0x0600278D RID: 10125 RVA: 0x00030634 File Offset: 0x0002E834
		public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, Texture image)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoWindow(id, clientRect, func, GUIContent.Temp(image), GUI.skin.window, GUI.skin, true);
		}

		// Token: 0x0600278E RID: 10126 RVA: 0x0003066C File Offset: 0x0002E86C
		public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoWindow(id, clientRect, func, content, GUI.skin.window, GUI.skin, true);
		}

		// Token: 0x0600278F RID: 10127 RVA: 0x000306A0 File Offset: 0x0002E8A0
		public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, string text, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoWindow(id, clientRect, func, GUIContent.Temp(text), style, GUI.skin, true);
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x000306D0 File Offset: 0x0002E8D0
		public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, Texture image, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoWindow(id, clientRect, func, GUIContent.Temp(image), style, GUI.skin, true);
		}

		// Token: 0x06002791 RID: 10129 RVA: 0x00030700 File Offset: 0x0002E900
		public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoWindow(id, clientRect, func, title, style, GUI.skin, true);
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x0003072C File Offset: 0x0002E92C
		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, string text)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoModalWindow(id, clientRect, func, GUIContent.Temp(text), GUI.skin.window, GUI.skin);
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x00030764 File Offset: 0x0002E964
		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, Texture image)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoModalWindow(id, clientRect, func, GUIContent.Temp(image), GUI.skin.window, GUI.skin);
		}

		// Token: 0x06002794 RID: 10132 RVA: 0x0003079C File Offset: 0x0002E99C
		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoModalWindow(id, clientRect, func, content, GUI.skin.window, GUI.skin);
		}

		// Token: 0x06002795 RID: 10133 RVA: 0x000307D0 File Offset: 0x0002E9D0
		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, string text, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoModalWindow(id, clientRect, func, GUIContent.Temp(text), style, GUI.skin);
		}

		// Token: 0x06002796 RID: 10134 RVA: 0x00030800 File Offset: 0x0002EA00
		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, Texture image, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoModalWindow(id, clientRect, func, GUIContent.Temp(image), style, GUI.skin);
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x00030830 File Offset: 0x0002EA30
		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoModalWindow(id, clientRect, func, content, style, GUI.skin);
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x0003085C File Offset: 0x0002EA5C
		private static Rect DoWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout)
		{
			return GUI.Internal_DoWindow(id, GUIUtility.s_OriginalID, clientRect, func, title, style, skin, forceRectOnLayout);
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x00030888 File Offset: 0x0002EA88
		private static Rect DoModalWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, GUISkin skin)
		{
			return GUI.Internal_DoModalWindow(id, GUIUtility.s_OriginalID, clientRect, func, content, style, skin);
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x000308B0 File Offset: 0x0002EAB0
		[RequiredByNativeCode]
		internal static void CallWindowDelegate(GUI.WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style)
		{
			GUILayoutUtility.SelectIDList(id, true);
			GUISkin skin = GUI.skin;
			if (Event.current.type == EventType.Layout)
			{
				if (forceRect != 0)
				{
					GUILayoutOption[] options = new GUILayoutOption[]
					{
						GUILayout.Width(width),
						GUILayout.Height(height)
					};
					GUILayoutUtility.BeginWindow(id, style, options);
				}
				else
				{
					GUILayoutUtility.BeginWindow(id, style, null);
				}
			}
			else
			{
				GUILayoutUtility.BeginWindow(id, GUIStyle.none, null);
			}
			GUI.skin = _skin;
			func(id);
			if (Event.current.type == EventType.Layout)
			{
				GUILayoutUtility.Layout();
			}
			GUI.skin = skin;
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x00030958 File Offset: 0x0002EB58
		public static void DragWindow()
		{
			GUI.DragWindow(new Rect(0f, 0f, 10000f, 10000f));
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x0003097C File Offset: 0x0002EB7C
		internal static void BeginWindows(int skinMode, int editorWindowInstanceID)
		{
			GUILayoutGroup topLevel = GUILayoutUtility.current.topLevel;
			GenericStack layoutGroups = GUILayoutUtility.current.layoutGroups;
			GUILayoutGroup windows = GUILayoutUtility.current.windows;
			Matrix4x4 matrix = GUI.matrix;
			GUI.Internal_BeginWindows();
			GUI.matrix = matrix;
			GUILayoutUtility.current.topLevel = topLevel;
			GUILayoutUtility.current.layoutGroups = layoutGroups;
			GUILayoutUtility.current.windows = windows;
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x000309E0 File Offset: 0x0002EBE0
		internal static void EndWindows()
		{
			GUILayoutGroup topLevel = GUILayoutUtility.current.topLevel;
			GenericStack layoutGroups = GUILayoutUtility.current.layoutGroups;
			GUILayoutGroup windows = GUILayoutUtility.current.windows;
			GUI.Internal_EndWindows();
			GUILayoutUtility.current.topLevel = topLevel;
			GUILayoutUtility.current.layoutGroups = layoutGroups;
			GUILayoutUtility.current.windows = windows;
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x0600279E RID: 10142 RVA: 0x00030A38 File Offset: 0x0002EC38
		// (set) Token: 0x0600279F RID: 10143 RVA: 0x00030A58 File Offset: 0x0002EC58
		public static Color color
		{
			get
			{
				Color result;
				GUI.INTERNAL_get_color(out result);
				return result;
			}
			set
			{
				GUI.INTERNAL_set_color(ref value);
			}
		}

		// Token: 0x060027A0 RID: 10144
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_color(out Color value);

		// Token: 0x060027A1 RID: 10145
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_color(ref Color value);

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x060027A2 RID: 10146 RVA: 0x00030A64 File Offset: 0x0002EC64
		// (set) Token: 0x060027A3 RID: 10147 RVA: 0x00030A84 File Offset: 0x0002EC84
		public static Color backgroundColor
		{
			get
			{
				Color result;
				GUI.INTERNAL_get_backgroundColor(out result);
				return result;
			}
			set
			{
				GUI.INTERNAL_set_backgroundColor(ref value);
			}
		}

		// Token: 0x060027A4 RID: 10148
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_backgroundColor(out Color value);

		// Token: 0x060027A5 RID: 10149
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_backgroundColor(ref Color value);

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x060027A6 RID: 10150 RVA: 0x00030A90 File Offset: 0x0002EC90
		// (set) Token: 0x060027A7 RID: 10151 RVA: 0x00030AB0 File Offset: 0x0002ECB0
		public static Color contentColor
		{
			get
			{
				Color result;
				GUI.INTERNAL_get_contentColor(out result);
				return result;
			}
			set
			{
				GUI.INTERNAL_set_contentColor(ref value);
			}
		}

		// Token: 0x060027A8 RID: 10152
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_contentColor(out Color value);

		// Token: 0x060027A9 RID: 10153
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_contentColor(ref Color value);

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x060027AA RID: 10154
		// (set) Token: 0x060027AB RID: 10155
		public static extern bool changed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x060027AC RID: 10156
		// (set) Token: 0x060027AD RID: 10157
		public static extern bool enabled { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060027AE RID: 10158
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string Internal_GetTooltip();

		// Token: 0x060027AF RID: 10159
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetTooltip(string value);

		// Token: 0x060027B0 RID: 10160
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string Internal_GetMouseTooltip();

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x060027B1 RID: 10161
		// (set) Token: 0x060027B2 RID: 10162
		public static extern int depth { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060027B3 RID: 10163 RVA: 0x00030ABC File Offset: 0x0002ECBC
		private static void DoLabel(Rect position, GUIContent content, IntPtr style)
		{
			GUI.INTERNAL_CALL_DoLabel(ref position, content, style);
		}

		// Token: 0x060027B4 RID: 10164
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DoLabel(ref Rect position, GUIContent content, IntPtr style);

		// Token: 0x060027B5 RID: 10165
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InitializeGUIClipTexture();

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x060027B6 RID: 10166
		internal static extern Material blendMaterial { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x060027B7 RID: 10167
		internal static extern Material blitMaterial { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060027B8 RID: 10168 RVA: 0x00030AC8 File Offset: 0x0002ECC8
		private static bool DoButton(Rect position, GUIContent content, IntPtr style)
		{
			return GUI.INTERNAL_CALL_DoButton(ref position, content, style);
		}

		// Token: 0x060027B9 RID: 10169
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_DoButton(ref Rect position, GUIContent content, IntPtr style);

		// Token: 0x060027BA RID: 10170
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetNextControlName(string name);

		// Token: 0x060027BB RID: 10171
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string GetNameOfFocusedControl();

		// Token: 0x060027BC RID: 10172
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FocusControl(string name);

		// Token: 0x060027BD RID: 10173 RVA: 0x00030AE8 File Offset: 0x0002ECE8
		internal static bool DoToggle(Rect position, int id, bool value, GUIContent content, IntPtr style)
		{
			return GUI.INTERNAL_CALL_DoToggle(ref position, id, value, content, style);
		}

		// Token: 0x060027BE RID: 10174
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_DoToggle(ref Rect position, int id, bool value, GUIContent content, IntPtr style);

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x060027BF RID: 10175
		internal static extern bool usePageScrollbars { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060027C0 RID: 10176
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void InternalRepaintEditorWindow();

		// Token: 0x060027C1 RID: 10177 RVA: 0x00030B0C File Offset: 0x0002ED0C
		private static Rect Internal_DoModalWindow(int id, int instanceID, Rect clientRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, GUISkin skin)
		{
			Rect result;
			GUI.INTERNAL_CALL_Internal_DoModalWindow(id, instanceID, ref clientRect, func, content, style, skin, out result);
			return result;
		}

		// Token: 0x060027C2 RID: 10178
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_DoModalWindow(int id, int instanceID, ref Rect clientRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, GUISkin skin, out Rect value);

		// Token: 0x060027C3 RID: 10179 RVA: 0x00030B34 File Offset: 0x0002ED34
		private static Rect Internal_DoWindow(int id, int instanceID, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout)
		{
			Rect result;
			GUI.INTERNAL_CALL_Internal_DoWindow(id, instanceID, ref clientRect, func, title, style, skin, forceRectOnLayout, out result);
			return result;
		}

		// Token: 0x060027C4 RID: 10180
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_DoWindow(int id, int instanceID, ref Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout, out Rect value);

		// Token: 0x060027C5 RID: 10181 RVA: 0x00030B60 File Offset: 0x0002ED60
		public static void DragWindow(Rect position)
		{
			GUI.INTERNAL_CALL_DragWindow(ref position);
		}

		// Token: 0x060027C6 RID: 10182
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DragWindow(ref Rect position);

		// Token: 0x060027C7 RID: 10183
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BringWindowToFront(int windowID);

		// Token: 0x060027C8 RID: 10184
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BringWindowToBack(int windowID);

		// Token: 0x060027C9 RID: 10185
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FocusWindow(int windowID);

		// Token: 0x060027CA RID: 10186
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnfocusWindow();

		// Token: 0x060027CB RID: 10187
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_BeginWindows();

		// Token: 0x060027CC RID: 10188
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_EndWindows();

		// Token: 0x040006FD RID: 1789
		private static float s_ScrollStepSize = 10f;

		// Token: 0x040006FE RID: 1790
		private static int s_ScrollControlId;

		// Token: 0x040006FF RID: 1791
		private static int s_HotTextField = -1;

		// Token: 0x04000700 RID: 1792
		private static readonly int s_BoxHash = "Box".GetHashCode();

		// Token: 0x04000701 RID: 1793
		private static readonly int s_RepeatButtonHash = "repeatButton".GetHashCode();

		// Token: 0x04000702 RID: 1794
		private static readonly int s_ToggleHash = "Toggle".GetHashCode();

		// Token: 0x04000703 RID: 1795
		private static readonly int s_ButtonGridHash = "ButtonGrid".GetHashCode();

		// Token: 0x04000704 RID: 1796
		private static readonly int s_SliderHash = "Slider".GetHashCode();

		// Token: 0x04000705 RID: 1797
		private static readonly int s_BeginGroupHash = "BeginGroup".GetHashCode();

		// Token: 0x04000706 RID: 1798
		private static readonly int s_ScrollviewHash = "scrollView".GetHashCode();

		// Token: 0x04000709 RID: 1801
		private static GUISkin s_Skin;

		// Token: 0x0400070A RID: 1802
		internal static Rect s_ToolTipRect;

		// Token: 0x0400070B RID: 1803
		private static GenericStack s_ScrollViewStates = new GenericStack();

		// Token: 0x0200024B RID: 587
		// (Invoke) Token: 0x060027CE RID: 10190
		public delegate void WindowFunction(int id);

		// Token: 0x0200024C RID: 588
		public abstract class Scope : IDisposable
		{
			// Token: 0x060027D2 RID: 10194
			protected abstract void CloseScope();

			// Token: 0x060027D3 RID: 10195 RVA: 0x00030B74 File Offset: 0x0002ED74
			~Scope()
			{
				if (!this.m_Disposed)
				{
					Debug.LogError("Scope was not disposed! You should use the 'using' keyword or manually call Dispose.");
				}
			}

			// Token: 0x060027D4 RID: 10196 RVA: 0x00030BB4 File Offset: 0x0002EDB4
			public void Dispose()
			{
				if (!this.m_Disposed)
				{
					this.m_Disposed = true;
					if (!GUIUtility.guiIsExiting)
					{
						this.CloseScope();
					}
				}
			}

			// Token: 0x0400070C RID: 1804
			private bool m_Disposed;
		}

		// Token: 0x0200024D RID: 589
		public class GroupScope : GUI.Scope
		{
			// Token: 0x060027D5 RID: 10197 RVA: 0x00030BE0 File Offset: 0x0002EDE0
			public GroupScope(Rect position)
			{
				GUI.BeginGroup(position);
			}

			// Token: 0x060027D6 RID: 10198 RVA: 0x00030BF0 File Offset: 0x0002EDF0
			public GroupScope(Rect position, string text)
			{
				GUI.BeginGroup(position, text);
			}

			// Token: 0x060027D7 RID: 10199 RVA: 0x00030C00 File Offset: 0x0002EE00
			public GroupScope(Rect position, Texture image)
			{
				GUI.BeginGroup(position, image);
			}

			// Token: 0x060027D8 RID: 10200 RVA: 0x00030C10 File Offset: 0x0002EE10
			public GroupScope(Rect position, GUIContent content)
			{
				GUI.BeginGroup(position, content);
			}

			// Token: 0x060027D9 RID: 10201 RVA: 0x00030C20 File Offset: 0x0002EE20
			public GroupScope(Rect position, GUIStyle style)
			{
				GUI.BeginGroup(position, style);
			}

			// Token: 0x060027DA RID: 10202 RVA: 0x00030C30 File Offset: 0x0002EE30
			public GroupScope(Rect position, string text, GUIStyle style)
			{
				GUI.BeginGroup(position, text, style);
			}

			// Token: 0x060027DB RID: 10203 RVA: 0x00030C44 File Offset: 0x0002EE44
			public GroupScope(Rect position, Texture image, GUIStyle style)
			{
				GUI.BeginGroup(position, image, style);
			}

			// Token: 0x060027DC RID: 10204 RVA: 0x00030C58 File Offset: 0x0002EE58
			protected override void CloseScope()
			{
				GUI.EndGroup();
			}
		}

		// Token: 0x0200024E RID: 590
		public class ScrollViewScope : GUI.Scope
		{
			// Token: 0x060027DD RID: 10205 RVA: 0x00030C60 File Offset: 0x0002EE60
			public ScrollViewScope(Rect position, Vector2 scrollPosition, Rect viewRect)
			{
				this.handleScrollWheel = true;
				this.scrollPosition = GUI.BeginScrollView(position, scrollPosition, viewRect);
			}

			// Token: 0x060027DE RID: 10206 RVA: 0x00030C80 File Offset: 0x0002EE80
			public ScrollViewScope(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical)
			{
				this.handleScrollWheel = true;
				this.scrollPosition = GUI.BeginScrollView(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical);
			}

			// Token: 0x060027DF RID: 10207 RVA: 0x00030CA4 File Offset: 0x0002EEA4
			public ScrollViewScope(Rect position, Vector2 scrollPosition, Rect viewRect, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar)
			{
				this.handleScrollWheel = true;
				this.scrollPosition = GUI.BeginScrollView(position, scrollPosition, viewRect, horizontalScrollbar, verticalScrollbar);
			}

			// Token: 0x060027E0 RID: 10208 RVA: 0x00030CC8 File Offset: 0x0002EEC8
			public ScrollViewScope(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar)
			{
				this.handleScrollWheel = true;
				this.scrollPosition = GUI.BeginScrollView(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar);
			}

			// Token: 0x060027E1 RID: 10209 RVA: 0x00030CF0 File Offset: 0x0002EEF0
			internal ScrollViewScope(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background)
			{
				this.handleScrollWheel = true;
				this.scrollPosition = GUI.BeginScrollView(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background);
			}

			// Token: 0x17000999 RID: 2457
			// (get) Token: 0x060027E2 RID: 10210 RVA: 0x00030D24 File Offset: 0x0002EF24
			// (set) Token: 0x060027E3 RID: 10211 RVA: 0x00030D40 File Offset: 0x0002EF40
			public Vector2 scrollPosition { get; private set; }

			// Token: 0x1700099A RID: 2458
			// (get) Token: 0x060027E4 RID: 10212 RVA: 0x00030D4C File Offset: 0x0002EF4C
			// (set) Token: 0x060027E5 RID: 10213 RVA: 0x00030D68 File Offset: 0x0002EF68
			public bool handleScrollWheel { get; set; }

			// Token: 0x060027E6 RID: 10214 RVA: 0x00030D74 File Offset: 0x0002EF74
			protected override void CloseScope()
			{
				GUI.EndScrollView(this.handleScrollWheel);
			}
		}

		// Token: 0x0200024F RID: 591
		public class ClipScope : GUI.Scope
		{
			// Token: 0x060027E7 RID: 10215 RVA: 0x00030D84 File Offset: 0x0002EF84
			public ClipScope(Rect position)
			{
				GUI.BeginClip(position);
			}

			// Token: 0x060027E8 RID: 10216 RVA: 0x00030D94 File Offset: 0x0002EF94
			protected override void CloseScope()
			{
				GUI.EndClip();
			}
		}
	}
}
