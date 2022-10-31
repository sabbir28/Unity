using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000269 RID: 617
	[RequiredByNativeCode]
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class GUIStyle
	{
		// Token: 0x06002949 RID: 10569 RVA: 0x00036D38 File Offset: 0x00034F38
		public GUIStyle()
		{
			this.Init();
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x00036D48 File Offset: 0x00034F48
		public GUIStyle(GUIStyle other)
		{
			this.InitCopy(other);
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x00036D58 File Offset: 0x00034F58
		~GUIStyle()
		{
			this.Cleanup();
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x00036D88 File Offset: 0x00034F88
		internal static void CleanupRoots()
		{
			GUIStyle.s_None = null;
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x00036D94 File Offset: 0x00034F94
		internal void InternalOnAfterDeserialize()
		{
			this.m_FontInternal = this.GetFontInternalDuringLoadingThread();
			this.m_Normal = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(0));
			this.m_Hover = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(1));
			this.m_Active = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(2));
			this.m_Focused = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(3));
			this.m_OnNormal = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(4));
			this.m_OnHover = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(5));
			this.m_OnActive = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(6));
			this.m_OnFocused = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(7));
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x0600294E RID: 10574 RVA: 0x00036E48 File Offset: 0x00035048
		// (set) Token: 0x0600294F RID: 10575 RVA: 0x00036E84 File Offset: 0x00035084
		public GUIStyleState normal
		{
			get
			{
				if (this.m_Normal == null)
				{
					this.m_Normal = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(0));
				}
				return this.m_Normal;
			}
			set
			{
				this.AssignStyleState(0, value.m_Ptr);
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06002950 RID: 10576 RVA: 0x00036E94 File Offset: 0x00035094
		// (set) Token: 0x06002951 RID: 10577 RVA: 0x00036ED0 File Offset: 0x000350D0
		public GUIStyleState hover
		{
			get
			{
				if (this.m_Hover == null)
				{
					this.m_Hover = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(1));
				}
				return this.m_Hover;
			}
			set
			{
				this.AssignStyleState(1, value.m_Ptr);
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06002952 RID: 10578 RVA: 0x00036EE0 File Offset: 0x000350E0
		// (set) Token: 0x06002953 RID: 10579 RVA: 0x00036F1C File Offset: 0x0003511C
		public GUIStyleState active
		{
			get
			{
				if (this.m_Active == null)
				{
					this.m_Active = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(2));
				}
				return this.m_Active;
			}
			set
			{
				this.AssignStyleState(2, value.m_Ptr);
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06002954 RID: 10580 RVA: 0x00036F2C File Offset: 0x0003512C
		// (set) Token: 0x06002955 RID: 10581 RVA: 0x00036F68 File Offset: 0x00035168
		public GUIStyleState onNormal
		{
			get
			{
				if (this.m_OnNormal == null)
				{
					this.m_OnNormal = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(4));
				}
				return this.m_OnNormal;
			}
			set
			{
				this.AssignStyleState(4, value.m_Ptr);
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06002956 RID: 10582 RVA: 0x00036F78 File Offset: 0x00035178
		// (set) Token: 0x06002957 RID: 10583 RVA: 0x00036FB4 File Offset: 0x000351B4
		public GUIStyleState onHover
		{
			get
			{
				if (this.m_OnHover == null)
				{
					this.m_OnHover = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(5));
				}
				return this.m_OnHover;
			}
			set
			{
				this.AssignStyleState(5, value.m_Ptr);
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06002958 RID: 10584 RVA: 0x00036FC4 File Offset: 0x000351C4
		// (set) Token: 0x06002959 RID: 10585 RVA: 0x00037000 File Offset: 0x00035200
		public GUIStyleState onActive
		{
			get
			{
				if (this.m_OnActive == null)
				{
					this.m_OnActive = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(6));
				}
				return this.m_OnActive;
			}
			set
			{
				this.AssignStyleState(6, value.m_Ptr);
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x0600295A RID: 10586 RVA: 0x00037010 File Offset: 0x00035210
		// (set) Token: 0x0600295B RID: 10587 RVA: 0x0003704C File Offset: 0x0003524C
		public GUIStyleState focused
		{
			get
			{
				if (this.m_Focused == null)
				{
					this.m_Focused = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(3));
				}
				return this.m_Focused;
			}
			set
			{
				this.AssignStyleState(3, value.m_Ptr);
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x0600295C RID: 10588 RVA: 0x0003705C File Offset: 0x0003525C
		// (set) Token: 0x0600295D RID: 10589 RVA: 0x00037098 File Offset: 0x00035298
		public GUIStyleState onFocused
		{
			get
			{
				if (this.m_OnFocused == null)
				{
					this.m_OnFocused = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(7));
				}
				return this.m_OnFocused;
			}
			set
			{
				this.AssignStyleState(7, value.m_Ptr);
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x0600295E RID: 10590 RVA: 0x000370A8 File Offset: 0x000352A8
		// (set) Token: 0x0600295F RID: 10591 RVA: 0x000370E4 File Offset: 0x000352E4
		public RectOffset border
		{
			get
			{
				if (this.m_Border == null)
				{
					this.m_Border = new RectOffset(this, this.GetRectOffsetPtr(0));
				}
				return this.m_Border;
			}
			set
			{
				this.AssignRectOffset(0, value.m_Ptr);
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06002960 RID: 10592 RVA: 0x000370F4 File Offset: 0x000352F4
		// (set) Token: 0x06002961 RID: 10593 RVA: 0x00037130 File Offset: 0x00035330
		public RectOffset margin
		{
			get
			{
				if (this.m_Margin == null)
				{
					this.m_Margin = new RectOffset(this, this.GetRectOffsetPtr(1));
				}
				return this.m_Margin;
			}
			set
			{
				this.AssignRectOffset(1, value.m_Ptr);
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06002962 RID: 10594 RVA: 0x00037140 File Offset: 0x00035340
		// (set) Token: 0x06002963 RID: 10595 RVA: 0x0003717C File Offset: 0x0003537C
		public RectOffset padding
		{
			get
			{
				if (this.m_Padding == null)
				{
					this.m_Padding = new RectOffset(this, this.GetRectOffsetPtr(2));
				}
				return this.m_Padding;
			}
			set
			{
				this.AssignRectOffset(2, value.m_Ptr);
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06002964 RID: 10596 RVA: 0x0003718C File Offset: 0x0003538C
		// (set) Token: 0x06002965 RID: 10597 RVA: 0x000371C8 File Offset: 0x000353C8
		public RectOffset overflow
		{
			get
			{
				if (this.m_Overflow == null)
				{
					this.m_Overflow = new RectOffset(this, this.GetRectOffsetPtr(3));
				}
				return this.m_Overflow;
			}
			set
			{
				this.AssignRectOffset(3, value.m_Ptr);
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06002966 RID: 10598 RVA: 0x000371D8 File Offset: 0x000353D8
		// (set) Token: 0x06002967 RID: 10599 RVA: 0x000371F4 File Offset: 0x000353F4
		[Obsolete("warning Don't use clipOffset - put things inside BeginGroup instead. This functionality will be removed in a later version.")]
		public Vector2 clipOffset
		{
			get
			{
				return this.Internal_clipOffset;
			}
			set
			{
				this.Internal_clipOffset = value;
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06002968 RID: 10600 RVA: 0x00037200 File Offset: 0x00035400
		// (set) Token: 0x06002969 RID: 10601 RVA: 0x0003721C File Offset: 0x0003541C
		public Font font
		{
			get
			{
				return this.GetFontInternal();
			}
			set
			{
				this.SetFontInternal(value);
				this.m_FontInternal = value;
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x0600296A RID: 10602 RVA: 0x00037230 File Offset: 0x00035430
		public float lineHeight
		{
			get
			{
				return Mathf.Round(GUIStyle.Internal_GetLineHeight(this.m_Ptr));
			}
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x00037258 File Offset: 0x00035458
		private static void Internal_Draw(IntPtr target, Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			Internal_DrawArguments internal_DrawArguments = default(Internal_DrawArguments);
			internal_DrawArguments.target = target;
			internal_DrawArguments.position = position;
			internal_DrawArguments.isHover = ((!isHover) ? 0 : 1);
			internal_DrawArguments.isActive = ((!isActive) ? 0 : 1);
			internal_DrawArguments.on = ((!on) ? 0 : 1);
			internal_DrawArguments.hasKeyboardFocus = ((!hasKeyboardFocus) ? 0 : 1);
			GUIStyle.Internal_Draw(content, ref internal_DrawArguments);
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x000372DC File Offset: 0x000354DC
		public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			GUIStyle.Internal_Draw(this.m_Ptr, position, GUIContent.none, isHover, isActive, on, hasKeyboardFocus);
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x000372F8 File Offset: 0x000354F8
		public void Draw(Rect position, string text, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			GUIStyle.Internal_Draw(this.m_Ptr, position, GUIContent.Temp(text), isHover, isActive, on, hasKeyboardFocus);
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x00037314 File Offset: 0x00035514
		public void Draw(Rect position, Texture image, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			GUIStyle.Internal_Draw(this.m_Ptr, position, GUIContent.Temp(image), isHover, isActive, on, hasKeyboardFocus);
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x00037330 File Offset: 0x00035530
		public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			GUIStyle.Internal_Draw(this.m_Ptr, position, content, isHover, isActive, on, hasKeyboardFocus);
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x00037348 File Offset: 0x00035548
		public void Draw(Rect position, GUIContent content, int controlID)
		{
			this.Draw(position, content, controlID, false);
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x00037358 File Offset: 0x00035558
		public void Draw(Rect position, GUIContent content, int controlID, bool on)
		{
			if (content != null)
			{
				GUIStyle.Internal_Draw2(this.m_Ptr, position, content, controlID, on);
			}
			else
			{
				Debug.LogError("Style.Draw may not be called with GUIContent that is null.");
			}
		}

		// Token: 0x06002972 RID: 10610 RVA: 0x00037380 File Offset: 0x00035580
		public void DrawCursor(Rect position, GUIContent content, int controlID, int Character)
		{
			Event current = Event.current;
			if (current.type == EventType.Repaint)
			{
				Color cursorColor = new Color(0f, 0f, 0f, 0f);
				float cursorFlashSpeed = GUI.skin.settings.cursorFlashSpeed;
				float num = (Time.realtimeSinceStartup - GUIStyle.Internal_GetCursorFlashOffset()) % cursorFlashSpeed / cursorFlashSpeed;
				if (cursorFlashSpeed == 0f || num < 0.5f)
				{
					cursorColor = GUI.skin.settings.cursorColor;
				}
				GUIStyle.Internal_DrawCursor(this.m_Ptr, position, content, Character, cursorColor);
			}
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x00037418 File Offset: 0x00035618
		internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition)
		{
			Event current = Event.current;
			Color cursorColor = new Color(0f, 0f, 0f, 0f);
			float cursorFlashSpeed = GUI.skin.settings.cursorFlashSpeed;
			float num = (Time.realtimeSinceStartup - GUIStyle.Internal_GetCursorFlashOffset()) % cursorFlashSpeed / cursorFlashSpeed;
			if (cursorFlashSpeed == 0f || num < 0.5f)
			{
				cursorColor = GUI.skin.settings.cursorColor;
			}
			Internal_DrawWithTextSelectionArguments internal_DrawWithTextSelectionArguments = default(Internal_DrawWithTextSelectionArguments);
			internal_DrawWithTextSelectionArguments.target = this.m_Ptr;
			internal_DrawWithTextSelectionArguments.position = position;
			internal_DrawWithTextSelectionArguments.firstPos = firstSelectedCharacter;
			internal_DrawWithTextSelectionArguments.lastPos = lastSelectedCharacter;
			internal_DrawWithTextSelectionArguments.cursorColor = cursorColor;
			internal_DrawWithTextSelectionArguments.selectionColor = GUI.skin.settings.selectionColor;
			internal_DrawWithTextSelectionArguments.isHover = ((!position.Contains(current.mousePosition)) ? 0 : 1);
			internal_DrawWithTextSelectionArguments.isActive = ((controlID != GUIUtility.hotControl) ? 0 : 1);
			internal_DrawWithTextSelectionArguments.on = 0;
			internal_DrawWithTextSelectionArguments.hasKeyboardFocus = ((controlID != GUIUtility.keyboardControl || !GUIStyle.showKeyboardFocus) ? 0 : 1);
			internal_DrawWithTextSelectionArguments.drawSelectionAsComposition = ((!drawSelectionAsComposition) ? 0 : 1);
			GUIStyle.Internal_DrawWithTextSelection(content, ref internal_DrawWithTextSelectionArguments);
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x0003755C File Offset: 0x0003575C
		public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter)
		{
			this.DrawWithTextSelection(position, content, controlID, firstSelectedCharacter, lastSelectedCharacter, false);
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x00037570 File Offset: 0x00035770
		public static implicit operator GUIStyle(string str)
		{
			GUIStyle result;
			if (GUISkin.current == null)
			{
				Debug.LogError("Unable to use a named GUIStyle without a current skin. Most likely you need to move your GUIStyle initialization code to OnGUI");
				result = GUISkin.error;
			}
			else
			{
				result = GUISkin.current.GetStyle(str);
			}
			return result;
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06002976 RID: 10614 RVA: 0x000375B8 File Offset: 0x000357B8
		public static GUIStyle none
		{
			get
			{
				if (GUIStyle.s_None == null)
				{
					GUIStyle.s_None = new GUIStyle();
				}
				return GUIStyle.s_None;
			}
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x000375E8 File Offset: 0x000357E8
		public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex)
		{
			Vector2 result;
			GUIStyle.Internal_GetCursorPixelPosition(this.m_Ptr, position, content, cursorStringIndex, out result);
			return result;
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x00037610 File Offset: 0x00035810
		public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition)
		{
			return GUIStyle.Internal_GetCursorStringIndex(this.m_Ptr, position, content, cursorPixelPosition);
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x00037634 File Offset: 0x00035834
		internal int GetNumCharactersThatFitWithinWidth(string text, float width)
		{
			return GUIStyle.Internal_GetNumCharactersThatFitWithinWidth(this.m_Ptr, text, width);
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x00037658 File Offset: 0x00035858
		public Vector2 CalcSize(GUIContent content)
		{
			Vector2 result;
			GUIStyle.Internal_CalcSize(this.m_Ptr, content, out result);
			return result;
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x0003767C File Offset: 0x0003587C
		internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints)
		{
			Vector2 result;
			GUIStyle.Internal_CalcSizeWithConstraints(this.m_Ptr, content, constraints, out result);
			return result;
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x000376A4 File Offset: 0x000358A4
		public Vector2 CalcScreenSize(Vector2 contentSize)
		{
			return new Vector2((this.fixedWidth == 0f) ? Mathf.Ceil(contentSize.x + (float)this.padding.left + (float)this.padding.right) : this.fixedWidth, (this.fixedHeight == 0f) ? Mathf.Ceil(contentSize.y + (float)this.padding.top + (float)this.padding.bottom) : this.fixedHeight);
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x00037740 File Offset: 0x00035940
		public float CalcHeight(GUIContent content, float width)
		{
			return GUIStyle.Internal_CalcHeight(this.m_Ptr, content, width);
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x0600297E RID: 10622 RVA: 0x00037764 File Offset: 0x00035964
		public bool isHeightDependantOnWidth
		{
			get
			{
				return this.fixedHeight == 0f && this.wordWrap && this.imagePosition != ImagePosition.ImageOnly;
			}
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x000377A8 File Offset: 0x000359A8
		public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth)
		{
			GUIStyle.Internal_CalcMinMaxWidth(this.m_Ptr, content, out minWidth, out maxWidth);
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x000377BC File Offset: 0x000359BC
		public override string ToString()
		{
			return UnityString.Format("GUIStyle '{0}'", new object[]
			{
				this.name
			});
		}

		// Token: 0x06002981 RID: 10625
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Init();

		// Token: 0x06002982 RID: 10626
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InitCopy(GUIStyle other);

		// Token: 0x06002983 RID: 10627
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Cleanup();

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06002984 RID: 10628
		// (set) Token: 0x06002985 RID: 10629
		public extern string name { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002986 RID: 10630 RVA: 0x000377EC File Offset: 0x000359EC
		[ThreadAndSerializationSafe]
		private IntPtr GetStyleStatePtr(int idx)
		{
			IntPtr result;
			GUIStyle.INTERNAL_CALL_GetStyleStatePtr(this, idx, out result);
			return result;
		}

		// Token: 0x06002987 RID: 10631
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetStyleStatePtr(GUIStyle self, int idx, out IntPtr value);

		// Token: 0x06002988 RID: 10632
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void AssignStyleState(int idx, IntPtr srcStyleState);

		// Token: 0x06002989 RID: 10633 RVA: 0x0003780C File Offset: 0x00035A0C
		private IntPtr GetRectOffsetPtr(int idx)
		{
			IntPtr result;
			GUIStyle.INTERNAL_CALL_GetRectOffsetPtr(this, idx, out result);
			return result;
		}

		// Token: 0x0600298A RID: 10634
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetRectOffsetPtr(GUIStyle self, int idx, out IntPtr value);

		// Token: 0x0600298B RID: 10635
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void AssignRectOffset(int idx, IntPtr srcRectOffset);

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x0600298C RID: 10636
		// (set) Token: 0x0600298D RID: 10637
		public extern ImagePosition imagePosition { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x0600298E RID: 10638
		// (set) Token: 0x0600298F RID: 10639
		public extern TextAnchor alignment { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06002990 RID: 10640
		// (set) Token: 0x06002991 RID: 10641
		public extern bool wordWrap { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06002992 RID: 10642
		// (set) Token: 0x06002993 RID: 10643
		public extern TextClipping clipping { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06002994 RID: 10644 RVA: 0x0003782C File Offset: 0x00035A2C
		// (set) Token: 0x06002995 RID: 10645 RVA: 0x0003784C File Offset: 0x00035A4C
		public Vector2 contentOffset
		{
			get
			{
				Vector2 result;
				this.INTERNAL_get_contentOffset(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_contentOffset(ref value);
			}
		}

		// Token: 0x06002996 RID: 10646
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_contentOffset(out Vector2 value);

		// Token: 0x06002997 RID: 10647
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_contentOffset(ref Vector2 value);

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06002998 RID: 10648 RVA: 0x00037858 File Offset: 0x00035A58
		// (set) Token: 0x06002999 RID: 10649 RVA: 0x00037878 File Offset: 0x00035A78
		internal Vector2 Internal_clipOffset
		{
			get
			{
				Vector2 result;
				this.INTERNAL_get_Internal_clipOffset(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_Internal_clipOffset(ref value);
			}
		}

		// Token: 0x0600299A RID: 10650
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_Internal_clipOffset(out Vector2 value);

		// Token: 0x0600299B RID: 10651
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_Internal_clipOffset(ref Vector2 value);

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x0600299C RID: 10652
		// (set) Token: 0x0600299D RID: 10653
		public extern float fixedWidth { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x0600299E RID: 10654
		// (set) Token: 0x0600299F RID: 10655
		public extern float fixedHeight { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x060029A0 RID: 10656
		// (set) Token: 0x060029A1 RID: 10657
		public extern bool stretchWidth { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x060029A2 RID: 10658
		// (set) Token: 0x060029A3 RID: 10659
		public extern bool stretchHeight { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060029A4 RID: 10660
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetLineHeight(IntPtr target);

		// Token: 0x060029A5 RID: 10661
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetFontInternal(Font value);

		// Token: 0x060029A6 RID: 10662
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Font GetFontInternalDuringLoadingThread();

		// Token: 0x060029A7 RID: 10663
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Font GetFontInternal();

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x060029A8 RID: 10664
		// (set) Token: 0x060029A9 RID: 10665
		public extern int fontSize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x060029AA RID: 10666
		// (set) Token: 0x060029AB RID: 10667
		public extern FontStyle fontStyle { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x060029AC RID: 10668
		// (set) Token: 0x060029AD RID: 10669
		public extern bool richText { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060029AE RID: 10670
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Draw(GUIContent content, ref Internal_DrawArguments arguments);

		// Token: 0x060029AF RID: 10671 RVA: 0x00037884 File Offset: 0x00035A84
		private static void Internal_Draw2(IntPtr style, Rect position, GUIContent content, int controlID, bool on)
		{
			GUIStyle.INTERNAL_CALL_Internal_Draw2(style, ref position, content, controlID, on);
		}

		// Token: 0x060029B0 RID: 10672
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_Draw2(IntPtr style, ref Rect position, GUIContent content, int controlID, bool on);

		// Token: 0x060029B1 RID: 10673 RVA: 0x00037894 File Offset: 0x00035A94
		internal void SetMouseTooltip(string tooltip, Rect screenRect)
		{
			GUIStyle.INTERNAL_CALL_SetMouseTooltip(this, tooltip, ref screenRect);
		}

		// Token: 0x060029B2 RID: 10674
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetMouseTooltip(GUIStyle self, string tooltip, ref Rect screenRect);

		// Token: 0x060029B3 RID: 10675 RVA: 0x000378A0 File Offset: 0x00035AA0
		private static void Internal_DrawPrefixLabel(IntPtr style, Rect position, GUIContent content, int controlID, bool on)
		{
			GUIStyle.INTERNAL_CALL_Internal_DrawPrefixLabel(style, ref position, content, controlID, on);
		}

		// Token: 0x060029B4 RID: 10676
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_DrawPrefixLabel(IntPtr style, ref Rect position, GUIContent content, int controlID, bool on);

		// Token: 0x060029B5 RID: 10677
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetCursorFlashOffset();

		// Token: 0x060029B6 RID: 10678 RVA: 0x000378B0 File Offset: 0x00035AB0
		private static void Internal_DrawCursor(IntPtr target, Rect position, GUIContent content, int pos, Color cursorColor)
		{
			GUIStyle.INTERNAL_CALL_Internal_DrawCursor(target, ref position, content, pos, ref cursorColor);
		}

		// Token: 0x060029B7 RID: 10679
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_DrawCursor(IntPtr target, ref Rect position, GUIContent content, int pos, ref Color cursorColor);

		// Token: 0x060029B8 RID: 10680
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_DrawWithTextSelection(GUIContent content, ref Internal_DrawWithTextSelectionArguments arguments);

		// Token: 0x060029B9 RID: 10681
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void SetDefaultFont(Font font);

		// Token: 0x060029BA RID: 10682 RVA: 0x000378C0 File Offset: 0x00035AC0
		internal static void Internal_GetCursorPixelPosition(IntPtr target, Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret)
		{
			GUIStyle.INTERNAL_CALL_Internal_GetCursorPixelPosition(target, ref position, content, cursorStringIndex, out ret);
		}

		// Token: 0x060029BB RID: 10683
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_GetCursorPixelPosition(IntPtr target, ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret);

		// Token: 0x060029BC RID: 10684 RVA: 0x000378D0 File Offset: 0x00035AD0
		internal static int Internal_GetCursorStringIndex(IntPtr target, Rect position, GUIContent content, Vector2 cursorPixelPosition)
		{
			return GUIStyle.INTERNAL_CALL_Internal_GetCursorStringIndex(target, ref position, content, ref cursorPixelPosition);
		}

		// Token: 0x060029BD RID: 10685
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_Internal_GetCursorStringIndex(IntPtr target, ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition);

		// Token: 0x060029BE RID: 10686
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int Internal_GetNumCharactersThatFitWithinWidth(IntPtr target, string text, float width);

		// Token: 0x060029BF RID: 10687
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_CalcSize(IntPtr target, GUIContent content, out Vector2 ret);

		// Token: 0x060029C0 RID: 10688 RVA: 0x000378F0 File Offset: 0x00035AF0
		internal static void Internal_CalcSizeWithConstraints(IntPtr target, GUIContent content, Vector2 maxSize, out Vector2 ret)
		{
			GUIStyle.INTERNAL_CALL_Internal_CalcSizeWithConstraints(target, content, ref maxSize, out ret);
		}

		// Token: 0x060029C1 RID: 10689
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_CalcSizeWithConstraints(IntPtr target, GUIContent content, ref Vector2 maxSize, out Vector2 ret);

		// Token: 0x060029C2 RID: 10690
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_CalcHeight(IntPtr target, GUIContent content, float width);

		// Token: 0x060029C3 RID: 10691
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CalcMinMaxWidth(IntPtr target, GUIContent content, out float minWidth, out float maxWidth);

		// Token: 0x0400079A RID: 1946
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x0400079B RID: 1947
		[NonSerialized]
		private GUIStyleState m_Normal;

		// Token: 0x0400079C RID: 1948
		[NonSerialized]
		private GUIStyleState m_Hover;

		// Token: 0x0400079D RID: 1949
		[NonSerialized]
		private GUIStyleState m_Active;

		// Token: 0x0400079E RID: 1950
		[NonSerialized]
		private GUIStyleState m_Focused;

		// Token: 0x0400079F RID: 1951
		[NonSerialized]
		private GUIStyleState m_OnNormal;

		// Token: 0x040007A0 RID: 1952
		[NonSerialized]
		private GUIStyleState m_OnHover;

		// Token: 0x040007A1 RID: 1953
		[NonSerialized]
		private GUIStyleState m_OnActive;

		// Token: 0x040007A2 RID: 1954
		[NonSerialized]
		private GUIStyleState m_OnFocused;

		// Token: 0x040007A3 RID: 1955
		[NonSerialized]
		private RectOffset m_Border;

		// Token: 0x040007A4 RID: 1956
		[NonSerialized]
		private RectOffset m_Padding;

		// Token: 0x040007A5 RID: 1957
		[NonSerialized]
		private RectOffset m_Margin;

		// Token: 0x040007A6 RID: 1958
		[NonSerialized]
		private RectOffset m_Overflow;

		// Token: 0x040007A7 RID: 1959
		[NonSerialized]
		private Font m_FontInternal;

		// Token: 0x040007A8 RID: 1960
		internal static bool showKeyboardFocus = true;

		// Token: 0x040007A9 RID: 1961
		private static GUIStyle s_None;
	}
}
