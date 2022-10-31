using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000052 RID: 82
	internal struct RenderBufferHelper
	{
		// Token: 0x0600063B RID: 1595
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetLoadAction(out RenderBuffer b);

		// Token: 0x0600063C RID: 1596
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void SetLoadAction(out RenderBuffer b, int a);

		// Token: 0x0600063D RID: 1597
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetStoreAction(out RenderBuffer b);

		// Token: 0x0600063E RID: 1598
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void SetStoreAction(out RenderBuffer b, int a);

		// Token: 0x0600063F RID: 1599 RVA: 0x00007FC8 File Offset: 0x000061C8
		internal static IntPtr GetNativeRenderBufferPtr(IntPtr rb)
		{
			IntPtr result;
			RenderBufferHelper.INTERNAL_CALL_GetNativeRenderBufferPtr(rb, out result);
			return result;
		}

		// Token: 0x06000640 RID: 1600
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetNativeRenderBufferPtr(IntPtr rb, out IntPtr value);
	}
}
