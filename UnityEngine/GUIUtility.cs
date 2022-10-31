using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200026D RID: 621
	public class GUIUtility
	{
		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x060029CC RID: 10700 RVA: 0x00037A30 File Offset: 0x00035C30
		internal static float pixelsPerPoint
		{
			get
			{
				return GUIUtility.Internal_GetPixelsPerPoint();
			}
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x00037A4C File Offset: 0x00035C4C
		public static int GetControlID(FocusType focus)
		{
			return GUIUtility.GetControlID(0, focus);
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x00037A68 File Offset: 0x00035C68
		public static int GetControlID(GUIContent contents, FocusType focus)
		{
			return GUIUtility.GetControlID(contents.hash, focus);
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x00037A8C File Offset: 0x00035C8C
		public static int GetControlID(FocusType focus, Rect position)
		{
			return GUIUtility.Internal_GetNextControlID2(0, focus, position);
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x00037AAC File Offset: 0x00035CAC
		public static int GetControlID(int hint, FocusType focus, Rect position)
		{
			return GUIUtility.Internal_GetNextControlID2(hint, focus, position);
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x00037ACC File Offset: 0x00035CCC
		public static int GetControlID(GUIContent contents, FocusType focus, Rect position)
		{
			return GUIUtility.Internal_GetNextControlID2(contents.hash, focus, position);
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x00037AF0 File Offset: 0x00035CF0
		public static object GetStateObject(Type t, int controlID)
		{
			return GUIStateObjects.GetStateObject(t, controlID);
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x00037B0C File Offset: 0x00035D0C
		public static object QueryStateObject(Type t, int controlID)
		{
			return GUIStateObjects.QueryStateObject(t, controlID);
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x060029D4 RID: 10708 RVA: 0x00037B28 File Offset: 0x00035D28
		// (set) Token: 0x060029D5 RID: 10709 RVA: 0x00037B44 File Offset: 0x00035D44
		internal static bool guiIsExiting { get; set; }

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x060029D6 RID: 10710 RVA: 0x00037B4C File Offset: 0x00035D4C
		// (set) Token: 0x060029D7 RID: 10711 RVA: 0x00037B68 File Offset: 0x00035D68
		public static int hotControl
		{
			get
			{
				return GUIUtility.Internal_GetHotControl();
			}
			set
			{
				GUIUtility.Internal_SetHotControl(value);
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x060029D8 RID: 10712 RVA: 0x00037B74 File Offset: 0x00035D74
		// (set) Token: 0x060029D9 RID: 10713 RVA: 0x00037B90 File Offset: 0x00035D90
		public static int keyboardControl
		{
			get
			{
				return GUIUtility.Internal_GetKeyboardControl();
			}
			set
			{
				GUIUtility.Internal_SetKeyboardControl(value);
			}
		}

		// Token: 0x060029DA RID: 10714 RVA: 0x00037B9C File Offset: 0x00035D9C
		public static void ExitGUI()
		{
			GUIUtility.guiIsExiting = true;
			throw new ExitGUIException();
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x00037BAC File Offset: 0x00035DAC
		internal static GUISkin GetDefaultSkin()
		{
			return GUIUtility.Internal_GetDefaultSkin(GUIUtility.s_SkinMode);
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x00037BCC File Offset: 0x00035DCC
		internal static GUISkin GetBuiltinSkin(int skin)
		{
			return GUIUtility.Internal_GetBuiltinSkin(skin) as GUISkin;
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x00037BEC File Offset: 0x00035DEC
		[RequiredByNativeCode]
		internal static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr)
		{
			return false;
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x00037C04 File Offset: 0x00035E04
		internal static void CleanupRoots()
		{
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x00037C08 File Offset: 0x00035E08
		[RequiredByNativeCode]
		internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout)
		{
			GUIUtility.s_SkinMode = skinMode;
			GUIUtility.s_OriginalID = instanceID;
			GUI.skin = null;
			GUIUtility.guiIsExiting = false;
			if (useGUILayout != 0)
			{
				GUILayoutUtility.Begin(instanceID);
			}
			GUI.changed = false;
		}

		// Token: 0x060029E0 RID: 10720 RVA: 0x00037C38 File Offset: 0x00035E38
		[RequiredByNativeCode]
		internal static void EndGUI(int layoutType)
		{
			try
			{
				if (Event.current.type == EventType.Layout)
				{
					if (layoutType != 0)
					{
						if (layoutType != 1)
						{
							if (layoutType == 2)
							{
								GUILayoutUtility.LayoutFromEditorWindow();
							}
						}
						else
						{
							GUILayoutUtility.Layout();
						}
					}
				}
				GUILayoutUtility.SelectIDList(GUIUtility.s_OriginalID, false);
				GUIContent.ClearStaticCache();
			}
			finally
			{
				GUIUtility.Internal_ExitGUI();
			}
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x00037CBC File Offset: 0x00035EBC
		[RequiredByNativeCode]
		internal static bool EndGUIFromException(Exception exception)
		{
			GUIUtility.Internal_ExitGUI();
			return GUIUtility.ShouldRethrowException(exception);
		}

		// Token: 0x060029E2 RID: 10722 RVA: 0x00037CDC File Offset: 0x00035EDC
		[RequiredByNativeCode]
		internal static bool EndContainerGUIFromException(Exception exception)
		{
			return GUIUtility.ShouldRethrowException(exception);
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x00037CF8 File Offset: 0x00035EF8
		internal static bool ShouldRethrowException(Exception exception)
		{
			while (exception is TargetInvocationException && exception.InnerException != null)
			{
				exception = exception.InnerException;
			}
			return exception is ExitGUIException;
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x00037D3C File Offset: 0x00035F3C
		internal static void CheckOnGUI()
		{
			if (GUIUtility.Internal_GetGUIDepth() <= 0)
			{
				throw new ArgumentException("You can only call GUI functions from inside OnGUI.");
			}
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x00037D58 File Offset: 0x00035F58
		public static Vector2 GUIToScreenPoint(Vector2 guiPoint)
		{
			return GUIClip.Unclip(guiPoint) + GUIUtility.s_EditorScreenPointOffset;
		}

		// Token: 0x060029E6 RID: 10726 RVA: 0x00037D80 File Offset: 0x00035F80
		internal static Rect GUIToScreenRect(Rect guiRect)
		{
			Vector2 vector = GUIUtility.GUIToScreenPoint(new Vector2(guiRect.x, guiRect.y));
			guiRect.x = vector.x;
			guiRect.y = vector.y;
			return guiRect;
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x00037DCC File Offset: 0x00035FCC
		public static Vector2 ScreenToGUIPoint(Vector2 screenPoint)
		{
			return GUIClip.Clip(screenPoint) - GUIUtility.s_EditorScreenPointOffset;
		}

		// Token: 0x060029E8 RID: 10728 RVA: 0x00037DF4 File Offset: 0x00035FF4
		public static Rect ScreenToGUIRect(Rect screenRect)
		{
			Vector2 vector = GUIUtility.ScreenToGUIPoint(new Vector2(screenRect.x, screenRect.y));
			screenRect.x = vector.x;
			screenRect.y = vector.y;
			return screenRect;
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x00037E40 File Offset: 0x00036040
		public static void RotateAroundPivot(float angle, Vector2 pivotPoint)
		{
			Matrix4x4 matrix = GUI.matrix;
			GUI.matrix = Matrix4x4.identity;
			Vector2 vector = GUIClip.Unclip(pivotPoint);
			Matrix4x4 lhs = Matrix4x4.TRS(vector, Quaternion.Euler(0f, 0f, angle), Vector3.one) * Matrix4x4.TRS(-vector, Quaternion.identity, Vector3.one);
			GUI.matrix = lhs * matrix;
		}

		// Token: 0x060029EA RID: 10730 RVA: 0x00037EB4 File Offset: 0x000360B4
		public static void ScaleAroundPivot(Vector2 scale, Vector2 pivotPoint)
		{
			Matrix4x4 matrix = GUI.matrix;
			Vector2 vector = GUIClip.Unclip(pivotPoint);
			Matrix4x4 lhs = Matrix4x4.TRS(vector, Quaternion.identity, new Vector3(scale.x, scale.y, 1f)) * Matrix4x4.TRS(-vector, Quaternion.identity, Vector3.one);
			GUI.matrix = lhs * matrix;
		}

		// Token: 0x060029EB RID: 10731
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetPixelsPerPoint();

		// Token: 0x060029EC RID: 10732
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetControlID(int hint, FocusType focus);

		// Token: 0x060029ED RID: 10733 RVA: 0x00037F24 File Offset: 0x00036124
		private static int Internal_GetNextControlID2(int hint, FocusType focusType, Rect rect)
		{
			return GUIUtility.INTERNAL_CALL_Internal_GetNextControlID2(hint, focusType, ref rect);
		}

		// Token: 0x060029EE RID: 10734
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_Internal_GetNextControlID2(int hint, FocusType focusType, ref Rect rect);

		// Token: 0x060029EF RID: 10735
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetPermanentControlID();

		// Token: 0x060029F0 RID: 10736
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetHotControl();

		// Token: 0x060029F1 RID: 10737
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetHotControl(int value);

		// Token: 0x060029F2 RID: 10738
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void UpdateUndoName();

		// Token: 0x060029F3 RID: 10739
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool GetChanged();

		// Token: 0x060029F4 RID: 10740
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void SetChanged(bool changed);

		// Token: 0x060029F5 RID: 10741
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetKeyboardControl();

		// Token: 0x060029F6 RID: 10742
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetKeyboardControl(int value);

		// Token: 0x060029F7 RID: 10743
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void SetDidGUIWindowsEatLastEvent(bool value);

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x060029F8 RID: 10744
		// (set) Token: 0x060029F9 RID: 10745
		public static extern string systemCopyBuffer { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060029FA RID: 10746
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern GUISkin Internal_GetDefaultSkin(int skinMode);

		// Token: 0x060029FB RID: 10747
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Object Internal_GetBuiltinSkin(int skin);

		// Token: 0x060029FC RID: 10748
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ExitGUI();

		// Token: 0x060029FD RID: 10749
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int Internal_GetGUIDepth();

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x060029FE RID: 10750
		// (set) Token: 0x060029FF RID: 10751
		internal static extern bool mouseUsed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06002A00 RID: 10752
		public static extern bool hasModalWindow { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06002A01 RID: 10753
		// (set) Token: 0x06002A02 RID: 10754
		internal static extern bool textFieldInput { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002A03 RID: 10755
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_BeginContainer(int instanceID);

		// Token: 0x06002A04 RID: 10756
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_EndContainer();

		// Token: 0x040007AE RID: 1966
		internal static int s_SkinMode;

		// Token: 0x040007AF RID: 1967
		internal static int s_OriginalID;

		// Token: 0x040007B1 RID: 1969
		internal static Vector2 s_EditorScreenPointOffset = Vector2.zero;
	}
}
