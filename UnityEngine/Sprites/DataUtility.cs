using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Sprites
{
	// Token: 0x020000BB RID: 187
	public sealed class DataUtility
	{
		// Token: 0x06000DEB RID: 3563 RVA: 0x00012FF8 File Offset: 0x000111F8
		public static Vector4 GetInnerUV(Sprite sprite)
		{
			Vector4 result;
			DataUtility.INTERNAL_CALL_GetInnerUV(sprite, out result);
			return result;
		}

		// Token: 0x06000DEC RID: 3564
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetInnerUV(Sprite sprite, out Vector4 value);

		// Token: 0x06000DED RID: 3565 RVA: 0x00013018 File Offset: 0x00011218
		public static Vector4 GetOuterUV(Sprite sprite)
		{
			Vector4 result;
			DataUtility.INTERNAL_CALL_GetOuterUV(sprite, out result);
			return result;
		}

		// Token: 0x06000DEE RID: 3566
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetOuterUV(Sprite sprite, out Vector4 value);

		// Token: 0x06000DEF RID: 3567 RVA: 0x00013038 File Offset: 0x00011238
		public static Vector4 GetPadding(Sprite sprite)
		{
			Vector4 result;
			DataUtility.INTERNAL_CALL_GetPadding(sprite, out result);
			return result;
		}

		// Token: 0x06000DF0 RID: 3568
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetPadding(Sprite sprite, out Vector4 value);

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00013058 File Offset: 0x00011258
		public static Vector2 GetMinSize(Sprite sprite)
		{
			Vector2 result;
			DataUtility.Internal_GetMinSize(sprite, out result);
			return result;
		}

		// Token: 0x06000DF2 RID: 3570
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_GetMinSize(Sprite sprite, out Vector2 output);
	}
}
