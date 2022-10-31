using System;
using System.Diagnostics;
using System.Reflection;
using UnityEngineInternal;

namespace UnityEngine.Events
{
	// Token: 0x020003E2 RID: 994
	internal class InvokableCall<T1, T2> : BaseInvokableCall
	{
		// Token: 0x06003311 RID: 13073 RVA: 0x0004F788 File Offset: 0x0004D988
		public InvokableCall(object target, MethodInfo theFunction) : base(target, theFunction)
		{
			this.Delegate = (UnityAction<T1, T2>)theFunction.CreateDelegate(typeof(UnityAction<T1, T2>), target);
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x0004F7B0 File Offset: 0x0004D9B0
		public InvokableCall(UnityAction<T1, T2> action)
		{
			this.Delegate += action;
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06003313 RID: 13075 RVA: 0x0004F7C0 File Offset: 0x0004D9C0
		// (remove) Token: 0x06003314 RID: 13076 RVA: 0x0004F7F8 File Offset: 0x0004D9F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		protected event UnityAction<T1, T2> Delegate;

		// Token: 0x06003315 RID: 13077 RVA: 0x0004F830 File Offset: 0x0004DA30
		public override void Invoke(object[] args)
		{
			if (args.Length != 2)
			{
				throw new ArgumentException("Passed argument 'args' is invalid size. Expected size is 1");
			}
			BaseInvokableCall.ThrowOnInvalidArg<T1>(args[0]);
			BaseInvokableCall.ThrowOnInvalidArg<T2>(args[1]);
			if (BaseInvokableCall.AllowInvoke(this.Delegate))
			{
				this.Delegate((T1)((object)args[0]), (T2)((object)args[1]));
			}
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x0004F890 File Offset: 0x0004DA90
		public override bool Find(object targetObj, MethodInfo method)
		{
			return this.Delegate.Target == targetObj && this.Delegate.GetMethodInfo().Equals(method);
		}
	}
}
