using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x020000A1 RID: 161
	internal static class ListPool<T>
	{
		// Token: 0x060005E3 RID: 1507 RVA: 0x0001D728 File Offset: 0x0001BB28
		public static List<T> Get()
		{
			return ListPool<T>.s_ListPool.Get();
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0001D747 File Offset: 0x0001BB47
		public static void Release(List<T> toRelease)
		{
			ListPool<T>.s_ListPool.Release(toRelease);
		}

		// Token: 0x040002C0 RID: 704
		private static readonly ObjectPool<List<T>> s_ListPool = new ObjectPool<List<T>>(null, delegate(List<T> l)
		{
			l.Clear();
		});
	}
}
