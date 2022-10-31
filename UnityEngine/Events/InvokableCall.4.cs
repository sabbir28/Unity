using System;
using System.Diagnostics;
using System.Reflection;
using UnityEngineInternal;

namespace UnityEngine.Events
{
	// Token: 0x020003E3 RID: 995
	internal class InvokableCall<T1, T2, T3> : BaseInvokableCall
	{
		// Token: 0x06003317 RID: 13079 RVA: 0x0004F8CC File Offset: 0x0004DACC
		public InvokableCall(object target, MethodInfo theFunction) : base(target, theFunction)
		{
			this.Delegate = (UnityAction<T1, T2, T3>)theFunction.CreateDelegate(typeof(UnityAction<T1, T2, T3>), target);
		}

		// Token: 0x06003318 RID: 13080 RVA: 0x0004F8F4 File Offset: 0x0004DAF4
		public InvokableCall(UnityAction<T1, T2, T3> action)
		{
			this.Delegate += action;
		}

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06003319 RID: 13081 RVA: 0x0004F904 File Offset: 0x0004DB04
		// (remove) Token: 0x0600331A RID: 13082 RVA: 0x0004F93C File Offset: 0x0004DB3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		protected event UnityAction<T1, T2, T3> Delegate;

		// Token: 0x0600331B RID: 13083 RVA: 0x0004F974 File Offset: 0x0004DB74
		public override void Invoke(object[] args)
		{
			if (args.Length != 3)
			{
				throw new ArgumentException("Passed argument 'args' is invalid size. Expected size is 1");
			}
			BaseInvokableCall.ThrowOnInvalidArg<T1>(args[0]);
			BaseInvokableCall.ThrowOnInvalidArg<T2>(args[1]);
			BaseInvokableCall.ThrowOnInvalidArg<T3>(args[2]);
			if (BaseInvokableCall.AllowInvoke(this.Delegate))
			{
				this.Delegate((T1)((object)args[0]), (T2)((object)args[1]), (T3)((object)args[2]));
			}
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x0004F9E4 File Offset: 0x0004DBE4
		public override bool Find(object targetObj, MethodInfo method)
		{
			return this.Delegate.Target == targetObj && this.Delegate.GetMethodInfo().Equals(method);
		}
	}
}
