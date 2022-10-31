using System;
using System.Diagnostics;
using System.Reflection;
using UnityEngineInternal;

namespace UnityEngine.Events
{
	// Token: 0x020003E4 RID: 996
	internal class InvokableCall<T1, T2, T3, T4> : BaseInvokableCall
	{
		// Token: 0x0600331D RID: 13085 RVA: 0x0004FA20 File Offset: 0x0004DC20
		public InvokableCall(object target, MethodInfo theFunction) : base(target, theFunction)
		{
			this.Delegate = (UnityAction<T1, T2, T3, T4>)theFunction.CreateDelegate(typeof(UnityAction<T1, T2, T3, T4>), target);
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x0004FA48 File Offset: 0x0004DC48
		public InvokableCall(UnityAction<T1, T2, T3, T4> action)
		{
			this.Delegate += action;
		}

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x0600331F RID: 13087 RVA: 0x0004FA58 File Offset: 0x0004DC58
		// (remove) Token: 0x06003320 RID: 13088 RVA: 0x0004FA90 File Offset: 0x0004DC90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		protected event UnityAction<T1, T2, T3, T4> Delegate;

		// Token: 0x06003321 RID: 13089 RVA: 0x0004FAC8 File Offset: 0x0004DCC8
		public override void Invoke(object[] args)
		{
			if (args.Length != 4)
			{
				throw new ArgumentException("Passed argument 'args' is invalid size. Expected size is 1");
			}
			BaseInvokableCall.ThrowOnInvalidArg<T1>(args[0]);
			BaseInvokableCall.ThrowOnInvalidArg<T2>(args[1]);
			BaseInvokableCall.ThrowOnInvalidArg<T3>(args[2]);
			BaseInvokableCall.ThrowOnInvalidArg<T4>(args[3]);
			if (BaseInvokableCall.AllowInvoke(this.Delegate))
			{
				this.Delegate((T1)((object)args[0]), (T2)((object)args[1]), (T3)((object)args[2]), (T4)((object)args[3]));
			}
		}

		// Token: 0x06003322 RID: 13090 RVA: 0x0004FB48 File Offset: 0x0004DD48
		public override bool Find(object targetObj, MethodInfo method)
		{
			return this.Delegate.Target == targetObj && this.Delegate.GetMethodInfo().Equals(method);
		}
	}
}
