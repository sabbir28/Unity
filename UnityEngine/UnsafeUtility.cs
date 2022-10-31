using System;
using System.Runtime.CompilerServices;
using UnityEngine.Collections;

namespace UnityEngine
{
	// Token: 0x02000452 RID: 1106
	internal static class UnsafeUtility
	{
		// Token: 0x0600353B RID: 13627 RVA: 0x00054E8C File Offset: 0x0005308C
		public unsafe static void CopyPtrToStructure<T>(IntPtr ptr, out T output) where T : struct
		{
			output = *ptr;
		}

		// Token: 0x0600353C RID: 13628 RVA: 0x00054E9C File Offset: 0x0005309C
		public unsafe static void CopyStructureToPtr<T>(ref T output, IntPtr ptr) where T : struct
		{
			*ptr = output;
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x00054EAC File Offset: 0x000530AC
		public unsafe static T ReadArrayElement<T>(IntPtr source, int index)
		{
			return *(source + (IntPtr)index);
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x00054EB8 File Offset: 0x000530B8
		public unsafe static void WriteArrayElement<T>(IntPtr destination, int index, T value)
		{
			*(destination + (IntPtr)index) = value;
		}

		// Token: 0x0600353F RID: 13631 RVA: 0x00054EC4 File Offset: 0x000530C4
		public static IntPtr AddressOf<T>(ref T output) where T : struct
		{
			return ref output;
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x00054EC8 File Offset: 0x000530C8
		public static int SizeOf<T>() where T : struct
		{
			return UnsafeUtility.SizeOfStruct(typeof(T));
		}

		// Token: 0x06003541 RID: 13633 RVA: 0x00054EEC File Offset: 0x000530EC
		public static int AlignOf<T>() where T : struct
		{
			return 4;
		}

		// Token: 0x06003542 RID: 13634
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr Malloc(int size, int alignment, Allocator label);

		// Token: 0x06003543 RID: 13635
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Free(IntPtr memory, Allocator label);

		// Token: 0x06003544 RID: 13636
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MemCpy(IntPtr destination, IntPtr source, int size);

		// Token: 0x06003545 RID: 13637
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int SizeOfStruct(Type type);

		// Token: 0x06003546 RID: 13638
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LogError(string msg, string filename, int linenumber);
	}
}
