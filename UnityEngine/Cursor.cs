using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000033 RID: 51
	public sealed class Cursor
	{
		// Token: 0x060003A0 RID: 928 RVA: 0x00006518 File Offset: 0x00004718
		private static void SetCursor(Texture2D texture, CursorMode cursorMode)
		{
			Cursor.SetCursor(texture, Vector2.zero, cursorMode);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00006528 File Offset: 0x00004728
		public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode)
		{
			Cursor.INTERNAL_CALL_SetCursor(texture, ref hotspot, cursorMode);
		}

		// Token: 0x060003A2 RID: 930
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetCursor(Texture2D texture, ref Vector2 hotspot, CursorMode cursorMode);

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060003A3 RID: 931
		// (set) Token: 0x060003A4 RID: 932
		public static extern bool visible { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060003A5 RID: 933
		// (set) Token: 0x060003A6 RID: 934
		public static extern CursorLockMode lockState { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
