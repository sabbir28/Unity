using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.UI.Collections
{
	// Token: 0x020000A0 RID: 160
	internal class IndexedSet<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		// Token: 0x060005D2 RID: 1490 RVA: 0x0001D3F3 File Offset: 0x0001B7F3
		public void Add(T item)
		{
			this.m_List.Add(item);
			this.m_Dictionary.Add(item, this.m_List.Count - 1);
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0001D41C File Offset: 0x0001B81C
		public bool AddUnique(T item)
		{
			bool result;
			if (this.m_Dictionary.ContainsKey(item))
			{
				result = false;
			}
			else
			{
				this.m_List.Add(item);
				this.m_Dictionary.Add(item, this.m_List.Count - 1);
				result = true;
			}
			return result;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0001D470 File Offset: 0x0001B870
		public bool Remove(T item)
		{
			int index = -1;
			bool result;
			if (!this.m_Dictionary.TryGetValue(item, out index))
			{
				result = false;
			}
			else
			{
				this.RemoveAt(index);
				result = true;
			}
			return result;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0001D4A9 File Offset: 0x0001B8A9
		public IEnumerator<T> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0001D4B4 File Offset: 0x0001B8B4
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0001D4CF File Offset: 0x0001B8CF
		public void Clear()
		{
			this.m_List.Clear();
			this.m_Dictionary.Clear();
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0001D4E8 File Offset: 0x0001B8E8
		public bool Contains(T item)
		{
			return this.m_Dictionary.ContainsKey(item);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0001D509 File Offset: 0x0001B909
		public void CopyTo(T[] array, int arrayIndex)
		{
			this.m_List.CopyTo(array, arrayIndex);
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x0001D51C File Offset: 0x0001B91C
		public int Count
		{
			get
			{
				return this.m_List.Count;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x0001D53C File Offset: 0x0001B93C
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0001D554 File Offset: 0x0001B954
		public int IndexOf(T item)
		{
			int result = -1;
			this.m_Dictionary.TryGetValue(item, out result);
			return result;
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0001D57B File Offset: 0x0001B97B
		public void Insert(int index, T item)
		{
			throw new NotSupportedException("Random Insertion is semantically invalid, since this structure does not guarantee ordering.");
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0001D588 File Offset: 0x0001B988
		public void RemoveAt(int index)
		{
			T key = this.m_List[index];
			this.m_Dictionary.Remove(key);
			if (index == this.m_List.Count - 1)
			{
				this.m_List.RemoveAt(index);
			}
			else
			{
				int index2 = this.m_List.Count - 1;
				T t = this.m_List[index2];
				this.m_List[index] = t;
				this.m_Dictionary[t] = index;
				this.m_List.RemoveAt(index2);
			}
		}

		// Token: 0x17000193 RID: 403
		public T this[int index]
		{
			get
			{
				return this.m_List[index];
			}
			set
			{
				T key = this.m_List[index];
				this.m_Dictionary.Remove(key);
				this.m_List[index] = value;
				this.m_Dictionary.Add(key, index);
			}
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0001D680 File Offset: 0x0001BA80
		public void RemoveAll(Predicate<T> match)
		{
			int i = 0;
			while (i < this.m_List.Count)
			{
				T t = this.m_List[i];
				if (match(t))
				{
					this.Remove(t);
				}
				else
				{
					i++;
				}
			}
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0001D6D4 File Offset: 0x0001BAD4
		public void Sort(Comparison<T> sortLayoutFunction)
		{
			this.m_List.Sort(sortLayoutFunction);
			for (int i = 0; i < this.m_List.Count; i++)
			{
				T key = this.m_List[i];
				this.m_Dictionary[key] = i;
			}
		}

		// Token: 0x040002BE RID: 702
		private readonly List<T> m_List = new List<T>();

		// Token: 0x040002BF RID: 703
		private Dictionary<T, int> m_Dictionary = new Dictionary<T, int>();
	}
}
