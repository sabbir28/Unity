using System;
using System.Diagnostics;
using System.Reflection;
using UnityEngineInternal;

namespace UnityEngine.Events
{
	// Token: 0x020003E1 RID: 993
	internal class InvokableCall<T1> : BaseInvokableCall
	{
		// Token: 0x0600330B RID: 13067 RVA: 0x0004F654 File Offset: 0x0004D854
		public InvokableCall(object target, MethodInfo theFunction) : base(target, theFunction)
		{
			this.Delegate += (UnityAction<T1>)theFunction.CreateDelegate(typeof(UnityAction<T1>), target);
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x0004F67C File Offset: 0x0004D87C
		public InvokableCall(UnityAction<T1> action)
		{
			this.Delegate += action;
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x0600330D RID: 13069 RVA: 0x0004F68C File Offset: 0x0004D88C
		// (remove) Token: 0x0600330E RID: 13070 RVA: 0x0004F6C4 File Offset: 0x0004D8C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		protected event UnityAction<T1> Delegate;

		// Token: 0x0600330F RID: 13071 RVA: 0x0004F6FC File Offset: 0x0004D8FC
		public override void Invoke(object[] args)
		{
			if (args.Length != 1)
			{
				throw new ArgumentException("Passed argument 'args' is invalid size. Expected size is 1");
			}
			BaseInvokableCall.ThrowOnInvalidArg<T1>(args[0]);
			if (BaseInvokableCall.AllowInvoke(this.Delegate))
			{
				this.Delegate((T1)((object)args[0]));
			}
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x0004F74C File Offset: 0x0004D94C
		public override bool Find(object targetObj, MethodInfo method)
		{
			return this.Delegate.Target == targetObj && this.Delegate.GetMethodInfo().Equals(method);
		}
	}
}
