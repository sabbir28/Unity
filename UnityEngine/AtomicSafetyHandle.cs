using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200030A RID: 778
	[UsedByNativeCode]
	internal struct AtomicSafetyHandle
	{
		// Token: 0x06003075 RID: 12405 RVA: 0x00048E30 File Offset: 0x00047030
		internal static AtomicSafetyHandle Create()
		{
			AtomicSafetyHandle result;
			AtomicSafetyHandle.Create_Injected(out result);
			return result;
		}

		// Token: 0x06003076 RID: 12406 RVA: 0x00048E48 File Offset: 0x00047048
		internal static void Release(AtomicSafetyHandle handle)
		{
			AtomicSafetyHandle.Release_Injected(ref handle);
		}

		// Token: 0x06003077 RID: 12407
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void PrepareUndisposable(ref AtomicSafetyHandle handle);

		// Token: 0x06003078 RID: 12408
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void UseSecondaryVersion(ref AtomicSafetyHandle handle);

		// Token: 0x06003079 RID: 12409
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void BumpSecondaryVersion(ref AtomicSafetyHandle handle);

		// Token: 0x0600307A RID: 12410 RVA: 0x00048E54 File Offset: 0x00047054
		internal static void EnforceAllBufferJobsHaveCompletedAndRelease(AtomicSafetyHandle handle)
		{
			AtomicSafetyHandle.EnforceAllBufferJobsHaveCompletedAndRelease_Injected(ref handle);
		}

		// Token: 0x0600307B RID: 12411 RVA: 0x00048E60 File Offset: 0x00047060
		internal static void CheckReadAndThrowNoEarlyOut(AtomicSafetyHandle handle)
		{
			AtomicSafetyHandle.CheckReadAndThrowNoEarlyOut_Injected(ref handle);
		}

		// Token: 0x0600307C RID: 12412 RVA: 0x00048E6C File Offset: 0x0004706C
		internal static void CheckWriteAndThrowNoEarlyOut(AtomicSafetyHandle handle)
		{
			AtomicSafetyHandle.CheckWriteAndThrowNoEarlyOut_Injected(ref handle);
		}

		// Token: 0x0600307D RID: 12413 RVA: 0x00048E78 File Offset: 0x00047078
		internal static void CheckDeallocateAndThrow(AtomicSafetyHandle handle)
		{
			AtomicSafetyHandle.CheckDeallocateAndThrow_Injected(ref handle);
		}

		// Token: 0x0600307E RID: 12414 RVA: 0x00048E84 File Offset: 0x00047084
		internal unsafe static void CheckReadAndThrow(AtomicSafetyHandle handle)
		{
			AtomicSafetyHandleVersionMask* ptr = (AtomicSafetyHandleVersionMask*)((void*)handle.versionNode);
			if ((handle.version & AtomicSafetyHandleVersionMask.Read) == (AtomicSafetyHandleVersionMask)0 && handle.version != (*ptr & AtomicSafetyHandleVersionMask.ReadInv))
			{
				AtomicSafetyHandle.CheckReadAndThrowNoEarlyOut(handle);
			}
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x00048EC4 File Offset: 0x000470C4
		internal unsafe static void CheckWriteAndThrow(AtomicSafetyHandle handle)
		{
			AtomicSafetyHandleVersionMask* ptr = (AtomicSafetyHandleVersionMask*)((void*)handle.versionNode);
			if ((handle.version & AtomicSafetyHandleVersionMask.Write) == (AtomicSafetyHandleVersionMask)0 && handle.version != (*ptr & AtomicSafetyHandleVersionMask.WriteInv))
			{
				AtomicSafetyHandle.CheckWriteAndThrowNoEarlyOut(handle);
			}
		}

		// Token: 0x06003080 RID: 12416
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Create_Injected(out AtomicSafetyHandle ret);

		// Token: 0x06003081 RID: 12417
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Release_Injected(ref AtomicSafetyHandle handle);

		// Token: 0x06003082 RID: 12418
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void EnforceAllBufferJobsHaveCompletedAndRelease_Injected(ref AtomicSafetyHandle handle);

		// Token: 0x06003083 RID: 12419
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void CheckReadAndThrowNoEarlyOut_Injected(ref AtomicSafetyHandle handle);

		// Token: 0x06003084 RID: 12420
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void CheckWriteAndThrowNoEarlyOut_Injected(ref AtomicSafetyHandle handle);

		// Token: 0x06003085 RID: 12421
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void CheckDeallocateAndThrow_Injected(ref AtomicSafetyHandle handle);

		// Token: 0x040009F2 RID: 2546
		internal IntPtr versionNode;

		// Token: 0x040009F3 RID: 2547
		internal AtomicSafetyHandleVersionMask version;
	}
}
