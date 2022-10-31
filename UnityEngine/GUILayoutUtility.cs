using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x02000261 RID: 609
	public class GUILayoutUtility
	{
		// Token: 0x060028C3 RID: 10435 RVA: 0x00035068 File Offset: 0x00033268
		internal static void CleanupRoots()
		{
			GUILayoutUtility.s_SpaceStyle = null;
			GUILayoutUtility.s_StoredLayouts = null;
			GUILayoutUtility.s_StoredWindows = null;
			GUILayoutUtility.current = null;
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x00035084 File Offset: 0x00033284
		internal static GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow)
		{
			Dictionary<int, GUILayoutUtility.LayoutCache> dictionary = (!isWindow) ? GUILayoutUtility.s_StoredLayouts : GUILayoutUtility.s_StoredWindows;
			GUILayoutUtility.LayoutCache layoutCache;
			if (!dictionary.TryGetValue(instanceID, out layoutCache))
			{
				layoutCache = new GUILayoutUtility.LayoutCache();
				dictionary[instanceID] = layoutCache;
			}
			GUILayoutUtility.current.topLevel = layoutCache.topLevel;
			GUILayoutUtility.current.layoutGroups = layoutCache.layoutGroups;
			GUILayoutUtility.current.windows = layoutCache.windows;
			return layoutCache;
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x00035108 File Offset: 0x00033308
		internal static void Begin(int instanceID)
		{
			GUILayoutUtility.LayoutCache layoutCache = GUILayoutUtility.SelectIDList(instanceID, false);
			if (Event.current.type == EventType.Layout)
			{
				GUILayoutUtility.current.topLevel = (layoutCache.topLevel = new GUILayoutGroup());
				GUILayoutUtility.current.layoutGroups.Clear();
				GUILayoutUtility.current.layoutGroups.Push(GUILayoutUtility.current.topLevel);
				GUILayoutUtility.current.windows = (layoutCache.windows = new GUILayoutGroup());
			}
			else
			{
				GUILayoutUtility.current.topLevel = layoutCache.topLevel;
				GUILayoutUtility.current.layoutGroups = layoutCache.layoutGroups;
				GUILayoutUtility.current.windows = layoutCache.windows;
			}
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x000351C0 File Offset: 0x000333C0
		internal static void BeginContainer(GUILayoutUtility.LayoutCache cache)
		{
			if (Event.current.type == EventType.Layout)
			{
				GUILayoutUtility.current.topLevel = (cache.topLevel = new GUILayoutGroup());
				GUILayoutUtility.current.layoutGroups.Clear();
				GUILayoutUtility.current.layoutGroups.Push(GUILayoutUtility.current.topLevel);
				GUILayoutUtility.current.windows = (cache.windows = new GUILayoutGroup());
			}
			else
			{
				GUILayoutUtility.current.topLevel = cache.topLevel;
				GUILayoutUtility.current.layoutGroups = cache.layoutGroups;
				GUILayoutUtility.current.windows = cache.windows;
			}
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x00035270 File Offset: 0x00033470
		internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options)
		{
			GUILayoutUtility.LayoutCache layoutCache = GUILayoutUtility.SelectIDList(windowID, true);
			if (Event.current.type == EventType.Layout)
			{
				GUILayoutUtility.current.topLevel = (layoutCache.topLevel = new GUILayoutGroup());
				GUILayoutUtility.current.topLevel.style = style;
				GUILayoutUtility.current.topLevel.windowID = windowID;
				if (options != null)
				{
					GUILayoutUtility.current.topLevel.ApplyOptions(options);
				}
				GUILayoutUtility.current.layoutGroups.Clear();
				GUILayoutUtility.current.layoutGroups.Push(GUILayoutUtility.current.topLevel);
				GUILayoutUtility.current.windows = (layoutCache.windows = new GUILayoutGroup());
			}
			else
			{
				GUILayoutUtility.current.topLevel = layoutCache.topLevel;
				GUILayoutUtility.current.layoutGroups = layoutCache.layoutGroups;
				GUILayoutUtility.current.windows = layoutCache.windows;
			}
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x00035360 File Offset: 0x00033560
		[Obsolete("BeginGroup has no effect and will be removed", false)]
		public static void BeginGroup(string GroupName)
		{
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x00035364 File Offset: 0x00033564
		[Obsolete("EndGroup has no effect and will be removed", false)]
		public static void EndGroup(string groupName)
		{
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x00035368 File Offset: 0x00033568
		internal static void Layout()
		{
			if (GUILayoutUtility.current.topLevel.windowID == -1)
			{
				GUILayoutUtility.current.topLevel.CalcWidth();
				GUILayoutUtility.current.topLevel.SetHorizontal(0f, Mathf.Min((float)Screen.width / GUIUtility.pixelsPerPoint, GUILayoutUtility.current.topLevel.maxWidth));
				GUILayoutUtility.current.topLevel.CalcHeight();
				GUILayoutUtility.current.topLevel.SetVertical(0f, Mathf.Min((float)Screen.height / GUIUtility.pixelsPerPoint, GUILayoutUtility.current.topLevel.maxHeight));
				GUILayoutUtility.LayoutFreeGroup(GUILayoutUtility.current.windows);
			}
			else
			{
				GUILayoutUtility.LayoutSingleGroup(GUILayoutUtility.current.topLevel);
				GUILayoutUtility.LayoutFreeGroup(GUILayoutUtility.current.windows);
			}
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x00035448 File Offset: 0x00033648
		internal static void LayoutFromEditorWindow()
		{
			GUILayoutUtility.current.topLevel.CalcWidth();
			GUILayoutUtility.current.topLevel.SetHorizontal(0f, (float)Screen.width / GUIUtility.pixelsPerPoint);
			GUILayoutUtility.current.topLevel.CalcHeight();
			GUILayoutUtility.current.topLevel.SetVertical(0f, (float)Screen.height / GUIUtility.pixelsPerPoint);
			GUILayoutUtility.LayoutFreeGroup(GUILayoutUtility.current.windows);
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x000354C4 File Offset: 0x000336C4
		internal static void LayoutFromContainer(float w, float h)
		{
			GUILayoutUtility.current.topLevel.CalcWidth();
			GUILayoutUtility.current.topLevel.SetHorizontal(0f, w);
			GUILayoutUtility.current.topLevel.CalcHeight();
			GUILayoutUtility.current.topLevel.SetVertical(0f, h);
			GUILayoutUtility.LayoutFreeGroup(GUILayoutUtility.current.windows);
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x0003552C File Offset: 0x0003372C
		internal static float LayoutFromInspector(float width)
		{
			float result;
			if (GUILayoutUtility.current.topLevel != null && GUILayoutUtility.current.topLevel.windowID == -1)
			{
				GUILayoutUtility.current.topLevel.CalcWidth();
				GUILayoutUtility.current.topLevel.SetHorizontal(0f, width);
				GUILayoutUtility.current.topLevel.CalcHeight();
				GUILayoutUtility.current.topLevel.SetVertical(0f, Mathf.Min((float)Screen.height / GUIUtility.pixelsPerPoint, GUILayoutUtility.current.topLevel.maxHeight));
				float minHeight = GUILayoutUtility.current.topLevel.minHeight;
				GUILayoutUtility.LayoutFreeGroup(GUILayoutUtility.current.windows);
				result = minHeight;
			}
			else
			{
				if (GUILayoutUtility.current.topLevel != null)
				{
					GUILayoutUtility.LayoutSingleGroup(GUILayoutUtility.current.topLevel);
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x00035618 File Offset: 0x00033818
		internal static void LayoutFreeGroup(GUILayoutGroup toplevel)
		{
			foreach (GUILayoutEntry guilayoutEntry in toplevel.entries)
			{
				GUILayoutGroup i = (GUILayoutGroup)guilayoutEntry;
				GUILayoutUtility.LayoutSingleGroup(i);
			}
			toplevel.ResetCursor();
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x00035684 File Offset: 0x00033884
		private static void LayoutSingleGroup(GUILayoutGroup i)
		{
			if (!i.isWindow)
			{
				float minWidth = i.minWidth;
				float maxWidth = i.maxWidth;
				i.CalcWidth();
				i.SetHorizontal(i.rect.x, Mathf.Clamp(i.maxWidth, minWidth, maxWidth));
				float minHeight = i.minHeight;
				float maxHeight = i.maxHeight;
				i.CalcHeight();
				i.SetVertical(i.rect.y, Mathf.Clamp(i.maxHeight, minHeight, maxHeight));
			}
			else
			{
				i.CalcWidth();
				Rect rect = GUILayoutUtility.Internal_GetWindowRect(i.windowID);
				i.SetHorizontal(rect.x, Mathf.Clamp(rect.width, i.minWidth, i.maxWidth));
				i.CalcHeight();
				i.SetVertical(rect.y, Mathf.Clamp(rect.height, i.minHeight, i.maxHeight));
				GUILayoutUtility.Internal_MoveWindow(i.windowID, i.rect);
			}
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x00035780 File Offset: 0x00033980
		[SecuritySafeCritical]
		private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType)
		{
			if (!typeof(GUILayoutGroup).IsAssignableFrom(LayoutType))
			{
				throw new ArgumentException("LayoutType needs to be of type GUILayoutGroup");
			}
			return (GUILayoutGroup)Activator.CreateInstance(LayoutType);
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x000357C0 File Offset: 0x000339C0
		internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType)
		{
			EventType type = Event.current.type;
			GUILayoutGroup guilayoutGroup;
			if (type != EventType.Used && type != EventType.Layout)
			{
				guilayoutGroup = (GUILayoutUtility.current.topLevel.GetNext() as GUILayoutGroup);
				if (guilayoutGroup == null)
				{
					throw new ArgumentException("GUILayout: Mismatched LayoutGroup." + Event.current.type);
				}
				guilayoutGroup.ResetCursor();
			}
			else
			{
				guilayoutGroup = GUILayoutUtility.CreateGUILayoutGroupInstanceOfType(layoutType);
				guilayoutGroup.style = style;
				if (options != null)
				{
					guilayoutGroup.ApplyOptions(options);
				}
				GUILayoutUtility.current.topLevel.Add(guilayoutGroup);
			}
			GUILayoutUtility.current.layoutGroups.Push(guilayoutGroup);
			GUILayoutUtility.current.topLevel = guilayoutGroup;
			return guilayoutGroup;
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x00035888 File Offset: 0x00033A88
		internal static void EndLayoutGroup()
		{
			EventType type = Event.current.type;
			GUILayoutUtility.current.layoutGroups.Pop();
			GUILayoutUtility.current.topLevel = ((0 >= GUILayoutUtility.current.layoutGroups.Count) ? null : ((GUILayoutGroup)GUILayoutUtility.current.layoutGroups.Peek()));
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x000358F0 File Offset: 0x00033AF0
		internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType)
		{
			EventType type = Event.current.type;
			GUILayoutGroup guilayoutGroup;
			if (type != EventType.Used && type != EventType.Layout)
			{
				guilayoutGroup = (GUILayoutUtility.current.windows.GetNext() as GUILayoutGroup);
				if (guilayoutGroup == null)
				{
					throw new ArgumentException("GUILayout: Mismatched LayoutGroup." + Event.current.type);
				}
				guilayoutGroup.ResetCursor();
			}
			else
			{
				guilayoutGroup = GUILayoutUtility.CreateGUILayoutGroupInstanceOfType(layoutType);
				guilayoutGroup.style = style;
				GUILayoutUtility.current.windows.Add(guilayoutGroup);
			}
			GUILayoutUtility.current.layoutGroups.Push(guilayoutGroup);
			GUILayoutUtility.current.topLevel = guilayoutGroup;
			return guilayoutGroup;
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x000359A8 File Offset: 0x00033BA8
		internal static GUILayoutGroup DoBeginLayoutArea(GUIStyle style, Type layoutType)
		{
			return GUILayoutUtility.BeginLayoutArea(style, layoutType);
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x060028D5 RID: 10453 RVA: 0x000359C4 File Offset: 0x00033BC4
		internal static GUILayoutGroup topLevel
		{
			get
			{
				return GUILayoutUtility.current.topLevel;
			}
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x000359E4 File Offset: 0x00033BE4
		public static Rect GetRect(GUIContent content, GUIStyle style)
		{
			return GUILayoutUtility.DoGetRect(content, style, null);
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x00035A04 File Offset: 0x00033C04
		public static Rect GetRect(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.DoGetRect(content, style, options);
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x00035A24 File Offset: 0x00033C24
		private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			GUIUtility.CheckOnGUI();
			EventType type = Event.current.type;
			Rect rect;
			if (type != EventType.Layout)
			{
				if (type != EventType.Used)
				{
					GUILayoutEntry next = GUILayoutUtility.current.topLevel.GetNext();
					rect = next.rect;
				}
				else
				{
					rect = GUILayoutUtility.kDummyRect;
				}
			}
			else
			{
				if (style.isHeightDependantOnWidth)
				{
					GUILayoutUtility.current.topLevel.Add(new GUIWordWrapSizer(style, content, options));
				}
				else
				{
					Vector2 constraints = new Vector2(0f, 0f);
					if (options != null)
					{
						foreach (GUILayoutOption guilayoutOption in options)
						{
							GUILayoutOption.Type type2 = guilayoutOption.type;
							if (type2 != GUILayoutOption.Type.maxHeight)
							{
								if (type2 == GUILayoutOption.Type.maxWidth)
								{
									constraints.x = (float)guilayoutOption.value;
								}
							}
							else
							{
								constraints.y = (float)guilayoutOption.value;
							}
						}
					}
					Vector2 vector = style.CalcSizeWithConstraints(content, constraints);
					GUILayoutUtility.current.topLevel.Add(new GUILayoutEntry(vector.x, vector.x, vector.y, vector.y, style, options));
				}
				rect = GUILayoutUtility.kDummyRect;
			}
			return rect;
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x00035B7C File Offset: 0x00033D7C
		public static Rect GetRect(float width, float height)
		{
			return GUILayoutUtility.DoGetRect(width, width, height, height, GUIStyle.none, null);
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x00035BA0 File Offset: 0x00033DA0
		public static Rect GetRect(float width, float height, GUIStyle style)
		{
			return GUILayoutUtility.DoGetRect(width, width, height, height, style, null);
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x00035BC0 File Offset: 0x00033DC0
		public static Rect GetRect(float width, float height, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.DoGetRect(width, width, height, height, GUIStyle.none, options);
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x00035BE4 File Offset: 0x00033DE4
		public static Rect GetRect(float width, float height, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.DoGetRect(width, width, height, height, style, options);
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x00035C04 File Offset: 0x00033E04
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight)
		{
			return GUILayoutUtility.DoGetRect(minWidth, maxWidth, minHeight, maxHeight, GUIStyle.none, null);
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x00035C28 File Offset: 0x00033E28
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style)
		{
			return GUILayoutUtility.DoGetRect(minWidth, maxWidth, minHeight, maxHeight, style, null);
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x00035C4C File Offset: 0x00033E4C
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.DoGetRect(minWidth, maxWidth, minHeight, maxHeight, GUIStyle.none, options);
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x00035C74 File Offset: 0x00033E74
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.DoGetRect(minWidth, maxWidth, minHeight, maxHeight, style, options);
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x00035C98 File Offset: 0x00033E98
		private static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options)
		{
			EventType type = Event.current.type;
			Rect rect;
			if (type != EventType.Layout)
			{
				if (type != EventType.Used)
				{
					rect = GUILayoutUtility.current.topLevel.GetNext().rect;
				}
				else
				{
					rect = GUILayoutUtility.kDummyRect;
				}
			}
			else
			{
				GUILayoutUtility.current.topLevel.Add(new GUILayoutEntry(minWidth, maxWidth, minHeight, maxHeight, style, options));
				rect = GUILayoutUtility.kDummyRect;
			}
			return rect;
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x00035D14 File Offset: 0x00033F14
		public static Rect GetLastRect()
		{
			EventType type = Event.current.type;
			Rect last;
			if (type != EventType.Layout)
			{
				if (type != EventType.Used)
				{
					last = GUILayoutUtility.current.topLevel.GetLast();
				}
				else
				{
					last = GUILayoutUtility.kDummyRect;
				}
			}
			else
			{
				last = GUILayoutUtility.kDummyRect;
			}
			return last;
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x00035D70 File Offset: 0x00033F70
		public static Rect GetAspectRect(float aspect)
		{
			return GUILayoutUtility.DoGetAspectRect(aspect, GUIStyle.none, null);
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x00035D94 File Offset: 0x00033F94
		public static Rect GetAspectRect(float aspect, GUIStyle style)
		{
			return GUILayoutUtility.DoGetAspectRect(aspect, style, null);
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x00035DB4 File Offset: 0x00033FB4
		public static Rect GetAspectRect(float aspect, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.DoGetAspectRect(aspect, GUIStyle.none, options);
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x00035DD8 File Offset: 0x00033FD8
		public static Rect GetAspectRect(float aspect, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.DoGetAspectRect(aspect, GUIStyle.none, options);
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x00035DFC File Offset: 0x00033FFC
		private static Rect DoGetAspectRect(float aspect, GUIStyle style, GUILayoutOption[] options)
		{
			EventType type = Event.current.type;
			Rect rect;
			if (type != EventType.Layout)
			{
				if (type != EventType.Used)
				{
					rect = GUILayoutUtility.current.topLevel.GetNext().rect;
				}
				else
				{
					rect = GUILayoutUtility.kDummyRect;
				}
			}
			else
			{
				GUILayoutUtility.current.topLevel.Add(new GUIAspectSizer(aspect, options));
				rect = GUILayoutUtility.kDummyRect;
			}
			return rect;
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x060028E8 RID: 10472 RVA: 0x00035E70 File Offset: 0x00034070
		internal static GUIStyle spaceStyle
		{
			get
			{
				if (GUILayoutUtility.s_SpaceStyle == null)
				{
					GUILayoutUtility.s_SpaceStyle = new GUIStyle();
				}
				GUILayoutUtility.s_SpaceStyle.stretchWidth = false;
				return GUILayoutUtility.s_SpaceStyle;
			}
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x00035EAC File Offset: 0x000340AC
		private static Rect Internal_GetWindowRect(int windowID)
		{
			Rect result;
			GUILayoutUtility.INTERNAL_CALL_Internal_GetWindowRect(windowID, out result);
			return result;
		}

		// Token: 0x060028EA RID: 10474
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_GetWindowRect(int windowID, out Rect value);

		// Token: 0x060028EB RID: 10475 RVA: 0x00035ECC File Offset: 0x000340CC
		private static void Internal_MoveWindow(int windowID, Rect r)
		{
			GUILayoutUtility.INTERNAL_CALL_Internal_MoveWindow(windowID, ref r);
		}

		// Token: 0x060028EC RID: 10476
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_MoveWindow(int windowID, ref Rect r);

		// Token: 0x060028ED RID: 10477 RVA: 0x00035ED8 File Offset: 0x000340D8
		internal static Rect GetWindowsBounds()
		{
			Rect result;
			GUILayoutUtility.INTERNAL_CALL_GetWindowsBounds(out result);
			return result;
		}

		// Token: 0x060028EE RID: 10478
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetWindowsBounds(out Rect value);

		// Token: 0x04000766 RID: 1894
		private static Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredLayouts = new Dictionary<int, GUILayoutUtility.LayoutCache>();

		// Token: 0x04000767 RID: 1895
		private static Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredWindows = new Dictionary<int, GUILayoutUtility.LayoutCache>();

		// Token: 0x04000768 RID: 1896
		internal static GUILayoutUtility.LayoutCache current = new GUILayoutUtility.LayoutCache();

		// Token: 0x04000769 RID: 1897
		internal static readonly Rect kDummyRect = new Rect(0f, 0f, 1f, 1f);

		// Token: 0x0400076A RID: 1898
		private static GUIStyle s_SpaceStyle;

		// Token: 0x02000262 RID: 610
		internal sealed class LayoutCache
		{
			// Token: 0x060028F0 RID: 10480 RVA: 0x00035F38 File Offset: 0x00034138
			internal LayoutCache()
			{
				this.layoutGroups.Push(this.topLevel);
			}

			// Token: 0x060028F1 RID: 10481 RVA: 0x00035F74 File Offset: 0x00034174
			internal LayoutCache(GUILayoutUtility.LayoutCache other)
			{
				this.topLevel = other.topLevel;
				this.layoutGroups = other.layoutGroups;
				this.windows = other.windows;
			}

			// Token: 0x0400076B RID: 1899
			internal GUILayoutGroup topLevel = new GUILayoutGroup();

			// Token: 0x0400076C RID: 1900
			internal GenericStack layoutGroups = new GenericStack();

			// Token: 0x0400076D RID: 1901
			internal GUILayoutGroup windows = new GUILayoutGroup();
		}
	}
}
