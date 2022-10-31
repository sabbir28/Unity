using System;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	[StructLayout(LayoutKind.Explicit)]
	public struct jvalue
	{
		// Token: 0x04000006 RID: 6
		[FieldOffset(0)]
		public bool z;

		// Token: 0x04000007 RID: 7
		[FieldOffset(0)]
		public byte b;

		// Token: 0x04000008 RID: 8
		[FieldOffset(0)]
		public char c;

		// Token: 0x04000009 RID: 9
		[FieldOffset(0)]
		public short s;

		// Token: 0x0400000A RID: 10
		[FieldOffset(0)]
		public int i;

		// Token: 0x0400000B RID: 11
		[FieldOffset(0)]
		public long j;

		// Token: 0x0400000C RID: 12
		[FieldOffset(0)]
		public float f;

		// Token: 0x0400000D RID: 13
		[FieldOffset(0)]
		public double d;

		// Token: 0x0400000E RID: 14
		[FieldOffset(0)]
		public IntPtr l;
	}
}
