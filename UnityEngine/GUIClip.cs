using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200026E RID: 622
	internal sealed class GUIClip
	{
		// Token: 0x06002A07 RID: 10759 RVA: 0x00037F58 File Offset: 0x00036158
		internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
		{
			GUIClip.Internal_Push(screenRect, scrollOffset, renderOffset, resetOffset);
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x00037F64 File Offset: 0x00036164
		internal static void Pop()
		{
			GUIClip.Internal_Pop();
		}

		// Token: 0x06002A09 RID: 10761 RVA: 0x00037F6C File Offset: 0x0003616C
		public static Vector2 Unclip(Vector2 pos)
		{
			GUIClip.Unclip_Vector2(ref pos);
			return pos;
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x00037F8C File Offset: 0x0003618C
		public static Rect Unclip(Rect rect)
		{
			GUIClip.Unclip_Rect(ref rect);
			return rect;
		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x00037FAC File Offset: 0x000361AC
		public static Vector2 Clip(Vector2 absolutePos)
		{
			GUIClip.Clip_Vector2(ref absolutePos);
			return absolutePos;
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x00037FCC File Offset: 0x000361CC
		public static Rect Clip(Rect absoluteRect)
		{
			GUIClip.Internal_Clip_Rect(ref absoluteRect);
			return absoluteRect;
		}

		// Token: 0x06002A0D RID: 10765 RVA: 0x00037FEC File Offset: 0x000361EC
		public static Vector2 GetAbsoluteMousePosition()
		{
			Vector2 result;
			GUIClip.Internal_GetAbsoluteMousePosition(out result);
			return result;
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x0003800C File Offset: 0x0003620C
		internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
		{
			GUIClip.INTERNAL_CALL_Internal_Push(ref screenRect, ref scrollOffset, ref renderOffset, resetOffset);
		}

		// Token: 0x06002A0F RID: 10767
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_Push(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset);

		// Token: 0x06002A10 RID: 10768
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_Pop();

		// Token: 0x06002A11 RID: 10769 RVA: 0x0003801C File Offset: 0x0003621C
		internal static Rect GetTopRect()
		{
			Rect result;
			GUIClip.INTERNAL_CALL_GetTopRect(out result);
			return result;
		}

		// Token: 0x06002A12 RID: 10770
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetTopRect(out Rect value);

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06002A13 RID: 10771
		public static extern bool enabled { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002A14 RID: 10772 RVA: 0x0003803C File Offset: 0x0003623C
		private static void Unclip_Vector2(ref Vector2 pos)
		{
			GUIClip.INTERNAL_CALL_Unclip_Vector2(ref pos);
		}

		// Token: 0x06002A15 RID: 10773
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Unclip_Vector2(ref Vector2 pos);

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06002A16 RID: 10774 RVA: 0x00038048 File Offset: 0x00036248
		public static Rect topmostRect
		{
			get
			{
				Rect result;
				GUIClip.INTERNAL_get_topmostRect(out result);
				return result;
			}
		}

		// Token: 0x06002A17 RID: 10775
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_topmostRect(out Rect value);

		// Token: 0x06002A18 RID: 10776 RVA: 0x00038068 File Offset: 0x00036268
		private static void Unclip_Rect(ref Rect rect)
		{
			GUIClip.INTERNAL_CALL_Unclip_Rect(ref rect);
		}

		// Token: 0x06002A19 RID: 10777
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Unclip_Rect(ref Rect rect);

		// Token: 0x06002A1A RID: 10778 RVA: 0x00038074 File Offset: 0x00036274
		private static void Clip_Vector2(ref Vector2 absolutePos)
		{
			GUIClip.INTERNAL_CALL_Clip_Vector2(ref absolutePos);
		}

		// Token: 0x06002A1B RID: 10779
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Clip_Vector2(ref Vector2 absolutePos);

		// Token: 0x06002A1C RID: 10780 RVA: 0x00038080 File Offset: 0x00036280
		private static void Internal_Clip_Rect(ref Rect absoluteRect)
		{
			GUIClip.INTERNAL_CALL_Internal_Clip_Rect(ref absoluteRect);
		}

		// Token: 0x06002A1D RID: 10781
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_Clip_Rect(ref Rect absoluteRect);

		// Token: 0x06002A1E RID: 10782
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Reapply();

		// Token: 0x06002A1F RID: 10783 RVA: 0x0003808C File Offset: 0x0003628C
		internal static Matrix4x4 GetMatrix()
		{
			Matrix4x4 result;
			GUIClip.INTERNAL_CALL_GetMatrix(out result);
			return result;
		}

		// Token: 0x06002A20 RID: 10784
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetMatrix(out Matrix4x4 value);

		// Token: 0x06002A21 RID: 10785 RVA: 0x000380AC File Offset: 0x000362AC
		internal static void SetMatrix(Matrix4x4 m)
		{
			GUIClip.INTERNAL_CALL_SetMatrix(ref m);
		}

		// Token: 0x06002A22 RID: 10786
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetMatrix(ref Matrix4x4 m);

		// Token: 0x06002A23 RID: 10787 RVA: 0x000380B8 File Offset: 0x000362B8
		internal static void SetTransform(Matrix4x4 clipTransform, Matrix4x4 objectTransform, Rect clipRect)
		{
			GUIClip.INTERNAL_CALL_SetTransform(ref clipTransform, ref objectTransform, ref clipRect);
		}

		// Token: 0x06002A24 RID: 10788
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetTransform(ref Matrix4x4 clipTransform, ref Matrix4x4 objectTransform, ref Rect clipRect);

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06002A25 RID: 10789 RVA: 0x000380C8 File Offset: 0x000362C8
		public static Rect visibleRect
		{
			get
			{
				Rect result;
				GUIClip.INTERNAL_get_visibleRect(out result);
				return result;
			}
		}

		// Token: 0x06002A26 RID: 10790
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_visibleRect(out Rect value);

		// Token: 0x06002A27 RID: 10791
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_GetAbsoluteMousePosition(out Vector2 output);
	}
}
