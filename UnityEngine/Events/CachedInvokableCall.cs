using System;
using System.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x020003E5 RID: 997
	internal class CachedInvokableCall<T> : InvokableCall<T>
	{
		// Token: 0x06003323 RID: 13091 RVA: 0x0004FB84 File Offset: 0x0004DD84
		public CachedInvokableCall(Object target, MethodInfo theFunction, T argument) : base(target, theFunction)
		{
			this.m_Arg1[0] = argument;
		}

		// Token: 0x06003324 RID: 13092 RVA: 0x0004FBAC File Offset: 0x0004DDAC
		public override void Invoke(object[] args)
		{
			base.Invoke(this.m_Arg1);
		}

		// Token: 0x04000ECB RID: 3787
		private readonly object[] m_Arg1 = new object[1];
	}
}
