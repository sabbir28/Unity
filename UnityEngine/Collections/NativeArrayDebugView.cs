using System;

namespace UnityEngine.Collections
{
	// Token: 0x02000420 RID: 1056
	internal sealed class NativeArrayDebugView<T> where T : struct
	{
		// Token: 0x060034C4 RID: 13508 RVA: 0x00053698 File Offset: 0x00051898
		public NativeArrayDebugView(NativeArray<T> array)
		{
			this.array = array;
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x060034C5 RID: 13509 RVA: 0x000536A8 File Offset: 0x000518A8
		public T[] Items
		{
			get
			{
				return this.array.ToArray();
			}
		}

		// Token: 0x04000F2B RID: 3883
		private NativeArray<T> array;
	}
}
