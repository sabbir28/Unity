using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200002A RID: 42
	public sealed class ComputeBuffer : IDisposable
	{
		// Token: 0x0600035A RID: 858 RVA: 0x00005E50 File Offset: 0x00004050
		public ComputeBuffer(int count, int stride) : this(count, stride, ComputeBufferType.Default, 3)
		{
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00005E60 File Offset: 0x00004060
		public ComputeBuffer(int count, int stride, ComputeBufferType type) : this(count, stride, type, 3)
		{
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00005E70 File Offset: 0x00004070
		internal ComputeBuffer(int count, int stride, ComputeBufferType type, int stackDepth)
		{
			if (count <= 0)
			{
				throw new ArgumentException("Attempting to create a zero length compute buffer", "count");
			}
			if (stride < 0)
			{
				throw new ArgumentException("Attempting to create a compute buffer with a negative stride", "stride");
			}
			this.m_Ptr = IntPtr.Zero;
			ComputeBuffer.InitBuffer(this, count, stride, type);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00005EC8 File Offset: 0x000040C8
		~ComputeBuffer()
		{
			this.Dispose(false);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00005EFC File Offset: 0x000040FC
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00005F0C File Offset: 0x0000410C
		private void Dispose(bool disposing)
		{
			if (disposing)
			{
				ComputeBuffer.DestroyBuffer(this);
			}
			else if (this.m_Ptr != IntPtr.Zero)
			{
				Debug.LogWarning("GarbageCollector disposing of ComputeBuffer. Please use ComputeBuffer.Release() or .Dispose() to manually release the buffer.");
			}
			this.m_Ptr = IntPtr.Zero;
		}

		// Token: 0x06000360 RID: 864
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InitBuffer(ComputeBuffer buf, int count, int stride, ComputeBufferType type);

		// Token: 0x06000361 RID: 865
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void DestroyBuffer(ComputeBuffer buf);

		// Token: 0x06000362 RID: 866 RVA: 0x00005F5C File Offset: 0x0000415C
		public void Release()
		{
			this.Dispose();
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000363 RID: 867
		public extern int count { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000364 RID: 868
		public extern int stride { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000365 RID: 869 RVA: 0x00005F68 File Offset: 0x00004168
		[SecuritySafeCritical]
		public void SetData(Array data)
		{
			this.InternalSetData(data, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06000366 RID: 870
		[SecurityCritical]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InternalSetData(Array data, int elemSize);

		// Token: 0x06000367 RID: 871
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetCounterValue(uint counterValue);

		// Token: 0x06000368 RID: 872 RVA: 0x00005F84 File Offset: 0x00004184
		[SecuritySafeCritical]
		public void GetData(Array data)
		{
			this.InternalGetData(data, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06000369 RID: 873
		[SecurityCritical]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InternalGetData(Array data, int elemSize);

		// Token: 0x0600036A RID: 874
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffset);

		// Token: 0x0600036B RID: 875 RVA: 0x00005FA0 File Offset: 0x000041A0
		public IntPtr GetNativeBufferPtr()
		{
			IntPtr result;
			ComputeBuffer.INTERNAL_CALL_GetNativeBufferPtr(this, out result);
			return result;
		}

		// Token: 0x0600036C RID: 876
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetNativeBufferPtr(ComputeBuffer self, out IntPtr value);

		// Token: 0x0400003A RID: 58
		internal IntPtr m_Ptr;
	}
}
