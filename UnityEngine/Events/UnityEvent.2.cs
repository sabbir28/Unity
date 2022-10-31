using System;
using System.Reflection;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine.Events
{
	// Token: 0x020003EE RID: 1006
	[Serializable]
	public abstract class UnityEvent<T0> : UnityEventBase
	{
		// Token: 0x0600336F RID: 13167 RVA: 0x000508BC File Offset: 0x0004EABC
		[RequiredByNativeCode]
		public UnityEvent()
		{
		}

		// Token: 0x06003370 RID: 13168 RVA: 0x000508D4 File Offset: 0x0004EAD4
		public void AddListener(UnityAction<T0> call)
		{
			base.AddCall(UnityEvent<T0>.GetDelegate(call));
		}

		// Token: 0x06003371 RID: 13169 RVA: 0x000508E4 File Offset: 0x0004EAE4
		public void RemoveListener(UnityAction<T0> call)
		{
			base.RemoveListener(call.Target, call.GetMethodInfo());
		}

		// Token: 0x06003372 RID: 13170 RVA: 0x000508FC File Offset: 0x0004EAFC
		protected override MethodInfo FindMethod_Impl(string name, object targetObj)
		{
			return UnityEventBase.GetValidMethodInfo(targetObj, name, new Type[]
			{
				typeof(T0)
			});
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x0005092C File Offset: 0x0004EB2C
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			return new InvokableCall<T0>(target, theFunction);
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x00050948 File Offset: 0x0004EB48
		private static BaseInvokableCall GetDelegate(UnityAction<T0> action)
		{
			return new InvokableCall<T0>(action);
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x00050964 File Offset: 0x0004EB64
		public void Invoke(T0 arg0)
		{
			this.m_InvokeArray[0] = arg0;
			base.Invoke(this.m_InvokeArray);
		}

		// Token: 0x04000EDF RID: 3807
		private readonly object[] m_InvokeArray = new object[1];
	}
}
