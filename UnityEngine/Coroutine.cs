using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200001C RID: 28
	[RequiredByNativeCode]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class Coroutine : YieldInstruction
	{
		// Token: 0x060001F3 RID: 499 RVA: 0x00004F90 File Offset: 0x00003190
		private Coroutine()
		{
		}

		// Token: 0x060001F4 RID: 500
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void ReleaseCoroutine();

		// Token: 0x060001F5 RID: 501 RVA: 0x00004F9C File Offset: 0x0000319C
		~Coroutine()
		{
			this.ReleaseCoroutine();
		}

		// Token: 0x0400002C RID: 44
		internal IntPtr m_Ptr;
	}
}
