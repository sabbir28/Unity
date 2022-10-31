using System;
using System.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	// Token: 0x020000A2 RID: 162
	internal class ObjectPool<T> where T : new()
	{
		// Token: 0x060005E7 RID: 1511 RVA: 0x0001D776 File Offset: 0x0001BB76
		public ObjectPool(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease)
		{
			this.m_ActionOnGet = actionOnGet;
			this.m_ActionOnRelease = actionOnRelease;
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x0001D798 File Offset: 0x0001BB98
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x0001D7B2 File Offset: 0x0001BBB2
		public int countAll { get; private set; }

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x0001D7BC File Offset: 0x0001BBBC
		public int countActive
		{
			get
			{
				return this.countAll - this.countInactive;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x0001D7E0 File Offset: 0x0001BBE0
		public int countInactive
		{
			get
			{
				return this.m_Stack.Count;
			}
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x0001D800 File Offset: 0x0001BC00
		public T Get()
		{
			T t;
			if (this.m_Stack.Count == 0)
			{
				t = Activator.CreateInstance<T>();
				this.countAll++;
			}
			else
			{
				t = this.m_Stack.Pop();
			}
			if (this.m_ActionOnGet != null)
			{
				this.m_ActionOnGet(t);
			}
			return t;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0001D868 File Offset: 0x0001BC68
		public void Release(T element)
		{
			if (this.m_Stack.Count > 0 && object.ReferenceEquals(this.m_Stack.Peek(), element))
			{
				Debug.LogError("Internal error. Trying to destroy object that is already released to pool.");
			}
			if (this.m_ActionOnRelease != null)
			{
				this.m_ActionOnRelease(element);
			}
			this.m_Stack.Push(element);
		}

		// Token: 0x040002C1 RID: 705
		private readonly Stack<T> m_Stack = new Stack<T>();

		// Token: 0x040002C2 RID: 706
		private readonly UnityAction<T> m_ActionOnGet;

		// Token: 0x040002C3 RID: 707
		private readonly UnityAction<T> m_ActionOnRelease;
	}
}
