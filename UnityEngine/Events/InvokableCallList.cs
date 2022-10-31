using System;
using System.Collections.Generic;
using System.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x020003E9 RID: 1001
	internal class InvokableCallList
	{
		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06003345 RID: 13125 RVA: 0x00050258 File Offset: 0x0004E458
		public int Count
		{
			get
			{
				return this.m_PersistentCalls.Count + this.m_RuntimeCalls.Count;
			}
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x00050284 File Offset: 0x0004E484
		public void AddPersistentInvokableCall(BaseInvokableCall call)
		{
			this.m_PersistentCalls.Add(call);
			this.m_NeedsUpdate = true;
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x0005029C File Offset: 0x0004E49C
		public void AddListener(BaseInvokableCall call)
		{
			this.m_RuntimeCalls.Add(call);
			this.m_NeedsUpdate = true;
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x000502B4 File Offset: 0x0004E4B4
		public void RemoveListener(object targetObj, MethodInfo method)
		{
			List<BaseInvokableCall> list = new List<BaseInvokableCall>();
			for (int i = 0; i < this.m_RuntimeCalls.Count; i++)
			{
				if (this.m_RuntimeCalls[i].Find(targetObj, method))
				{
					list.Add(this.m_RuntimeCalls[i]);
				}
			}
			this.m_RuntimeCalls.RemoveAll(new Predicate<BaseInvokableCall>(list.Contains));
			this.m_NeedsUpdate = true;
		}

		// Token: 0x06003349 RID: 13129 RVA: 0x00050330 File Offset: 0x0004E530
		public void Clear()
		{
			this.m_RuntimeCalls.Clear();
			this.m_NeedsUpdate = true;
		}

		// Token: 0x0600334A RID: 13130 RVA: 0x00050348 File Offset: 0x0004E548
		public void ClearPersistent()
		{
			this.m_PersistentCalls.Clear();
			this.m_NeedsUpdate = true;
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x00050360 File Offset: 0x0004E560
		public void Invoke(object[] parameters)
		{
			if (this.m_NeedsUpdate)
			{
				this.m_ExecutingCalls.Clear();
				this.m_ExecutingCalls.AddRange(this.m_PersistentCalls);
				this.m_ExecutingCalls.AddRange(this.m_RuntimeCalls);
				this.m_NeedsUpdate = false;
			}
			for (int i = 0; i < this.m_ExecutingCalls.Count; i++)
			{
				this.m_ExecutingCalls[i].Invoke(parameters);
			}
		}

		// Token: 0x04000ED6 RID: 3798
		private readonly List<BaseInvokableCall> m_PersistentCalls = new List<BaseInvokableCall>();

		// Token: 0x04000ED7 RID: 3799
		private readonly List<BaseInvokableCall> m_RuntimeCalls = new List<BaseInvokableCall>();

		// Token: 0x04000ED8 RID: 3800
		private readonly List<BaseInvokableCall> m_ExecutingCalls = new List<BaseInvokableCall>();

		// Token: 0x04000ED9 RID: 3801
		private bool m_NeedsUpdate = true;
	}
}
