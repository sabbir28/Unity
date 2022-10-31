using System;
using System.Diagnostics;
using System.Reflection;
using UnityEngineInternal;

namespace UnityEngine.Events
{
	// Token: 0x020003E0 RID: 992
	internal class InvokableCall : BaseInvokableCall
	{
		// Token: 0x06003305 RID: 13061 RVA: 0x0004F550 File Offset: 0x0004D750
		public InvokableCall(object target, MethodInfo theFunction) : base(target, theFunction)
		{
			this.Delegate += (UnityAction)theFunction.CreateDelegate(typeof(UnityAction), target);
		}

		// Token: 0x06003306 RID: 13062 RVA: 0x0004F578 File Offset: 0x0004D778
		public InvokableCall(UnityAction action)
		{
			this.Delegate += action;
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06003307 RID: 13063 RVA: 0x0004F588 File Offset: 0x0004D788
		// (remove) Token: 0x06003308 RID: 13064 RVA: 0x0004F5C0 File Offset: 0x0004D7C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private event UnityAction Delegate;

		// Token: 0x06003309 RID: 13065 RVA: 0x0004F5F8 File Offset: 0x0004D7F8
		public override void Invoke(object[] args)
		{
			if (BaseInvokableCall.AllowInvoke(this.Delegate))
			{
				this.Delegate();
			}
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x0004F618 File Offset: 0x0004D818
		public override bool Find(object targetObj, MethodInfo method)
		{
			return this.Delegate.Target == targetObj && this.Delegate.GetMethodInfo().Equals(method);
		}
	}
}
