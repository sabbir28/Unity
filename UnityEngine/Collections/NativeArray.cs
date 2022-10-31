using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnityEngine.Collections
{
	// Token: 0x0200041E RID: 1054
	[NativeContainer]
	[NativeContainerSupportsMinMaxWriteRestriction]
	[DebuggerDisplay("Length = {Length}")]
	[DebuggerTypeProxy(typeof(NativeArrayDebugView<>))]
	public struct NativeArray<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
	{
		// Token: 0x060034AD RID: 13485 RVA: 0x000532AC File Offset: 0x000514AC
		public NativeArray(int length, Allocator allocMode)
		{
			NativeArray<T>.Allocate(length, allocMode, out this);
		}

		// Token: 0x060034AE RID: 13486 RVA: 0x000532B8 File Offset: 0x000514B8
		public NativeArray(T[] array, Allocator allocMode)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			NativeArray<T>.Allocate(array.Length, allocMode, out this);
			this.FromArray(array);
		}

		// Token: 0x060034AF RID: 13487 RVA: 0x000532E0 File Offset: 0x000514E0
		internal NativeArray(IntPtr dataPointer, int length)
		{
			this = new NativeArray<T>(dataPointer, length, Allocator.None);
		}

		// Token: 0x060034B0 RID: 13488 RVA: 0x000532EC File Offset: 0x000514EC
		internal NativeArray(IntPtr dataPointer, int length, int stride, AtomicSafetyHandle safety, Allocator allocMode)
		{
			this.m_Buffer = dataPointer;
			this.m_Length = length;
			this.m_Stride = stride;
			this.m_AllocatorLabel = allocMode;
		}

		// Token: 0x060034B1 RID: 13489 RVA: 0x0005330C File Offset: 0x0005150C
		private NativeArray(IntPtr dataPointer, int length, Allocator allocMode)
		{
			if (dataPointer == IntPtr.Zero)
			{
				throw new ArgumentOutOfRangeException("dataPointer", "Pointer must not be zero");
			}
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length", "Length must be >= 0");
			}
			this.m_Buffer = dataPointer;
			this.m_Length = length;
			this.m_Stride = UnsafeUtility.SizeOf<T>();
			this.m_AllocatorLabel = allocMode;
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x060034B2 RID: 13490 RVA: 0x00053374 File Offset: 0x00051574
		public int Length
		{
			get
			{
				return this.m_Length;
			}
		}

		// Token: 0x17000C17 RID: 3095
		public T this[int index]
		{
			get
			{
				if (index >= this.m_Length)
				{
					this.FailOutOfRangeError(index);
				}
				return UnsafeUtility.ReadArrayElement<T>(this.m_Buffer, index * this.m_Stride);
			}
			set
			{
				if (index >= this.m_Length)
				{
					this.FailOutOfRangeError(index);
				}
				UnsafeUtility.WriteArrayElement<T>(this.m_Buffer, index * this.m_Stride, value);
			}
		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x000533F8 File Offset: 0x000515F8
		public void Dispose()
		{
			UnsafeUtility.Free(this.m_Buffer, this.m_AllocatorLabel);
			this.m_Buffer = IntPtr.Zero;
			this.m_Length = 0;
		}

		// Token: 0x060034B6 RID: 13494 RVA: 0x00053420 File Offset: 0x00051620
		public IntPtr GetUnsafeReadBufferPtr()
		{
			return this.m_Buffer;
		}

		// Token: 0x060034B7 RID: 13495 RVA: 0x0005343C File Offset: 0x0005163C
		public IntPtr GetUnsafeWriteBufferPtr()
		{
			return this.m_Buffer;
		}

		// Token: 0x060034B8 RID: 13496 RVA: 0x00053458 File Offset: 0x00051658
		public void FromArray(T[] array)
		{
			if (this.Length != array.Length)
			{
				throw new ArgumentException("Array length does not match the length of this instance");
			}
			for (int i = 0; i < this.Length; i++)
			{
				UnsafeUtility.WriteArrayElement<T>(this.m_Buffer, i * this.m_Stride, array[i]);
			}
		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x000534B0 File Offset: 0x000516B0
		public T[] ToArray()
		{
			T[] array = new T[this.Length];
			for (int i = 0; i < this.Length; i++)
			{
				array[i] = UnsafeUtility.ReadArrayElement<T>(this.m_Buffer, i * this.m_Stride);
			}
			return array;
		}

		// Token: 0x060034BA RID: 13498 RVA: 0x00053504 File Offset: 0x00051704
		private void FailOutOfRangeError(int index)
		{
			throw new IndexOutOfRangeException(string.Format("Index {0} is out of range of '{1}' Length.", index, this.Length));
		}

		// Token: 0x060034BB RID: 13499 RVA: 0x00053528 File Offset: 0x00051728
		private static void Allocate(int length, Allocator allocMode, out NativeArray<T> outArray)
		{
			if (allocMode <= Allocator.None)
			{
				throw new ArgumentOutOfRangeException("allocMode", "Allocator must be Temp, Job or Persistent");
			}
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length", "Length must be >= 0");
			}
			long num = (long)UnsafeUtility.SizeOf<T>() * (long)length;
			if (num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("length", "Length * sizeof(T) cannot exceed " + int.MaxValue + "bytes");
			}
			outArray = new NativeArray<T>(UnsafeUtility.Malloc((int)num, UnsafeUtility.AlignOf<T>(), allocMode), length, allocMode);
		}

		// Token: 0x060034BC RID: 13500 RVA: 0x000535B4 File Offset: 0x000517B4
		public IEnumerator<T> GetEnumerator()
		{
			return new NativeArray<T>.Enumerator(ref this);
		}

		// Token: 0x060034BD RID: 13501 RVA: 0x000535D4 File Offset: 0x000517D4
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000F25 RID: 3877
		private IntPtr m_Buffer;

		// Token: 0x04000F26 RID: 3878
		private int m_Length;

		// Token: 0x04000F27 RID: 3879
		private int m_Stride;

		// Token: 0x04000F28 RID: 3880
		private readonly Allocator m_AllocatorLabel;

		// Token: 0x0200041F RID: 1055
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			// Token: 0x060034BE RID: 13502 RVA: 0x000535F0 File Offset: 0x000517F0
			public Enumerator(ref NativeArray<T> array)
			{
				this.array = array;
				this.index = -1;
			}

			// Token: 0x060034BF RID: 13503 RVA: 0x00053608 File Offset: 0x00051808
			public void Dispose()
			{
			}

			// Token: 0x060034C0 RID: 13504 RVA: 0x0005360C File Offset: 0x0005180C
			public bool MoveNext()
			{
				this.index++;
				return this.index < this.array.Length;
			}

			// Token: 0x060034C1 RID: 13505 RVA: 0x00053644 File Offset: 0x00051844
			public void Reset()
			{
				this.index = -1;
			}

			// Token: 0x17000C19 RID: 3097
			// (get) Token: 0x060034C2 RID: 13506 RVA: 0x00053650 File Offset: 0x00051850
			public T Current
			{
				get
				{
					return this.array[this.index];
				}
			}

			// Token: 0x17000C18 RID: 3096
			// (get) Token: 0x060034C3 RID: 13507 RVA: 0x00053678 File Offset: 0x00051878
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x04000F29 RID: 3881
			private NativeArray<T> array;

			// Token: 0x04000F2A RID: 3882
			private int index;
		}
	}
}
