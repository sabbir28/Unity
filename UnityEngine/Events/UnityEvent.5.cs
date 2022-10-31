using System;
using System.Reflection;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine.Events
{
	// Token: 0x020003F4 RID: 1012
	[Serializable]
	public abstract class UnityEvent<T0, T1, T2, T3> : UnityEventBase
	{
		// Token: 0x06003390 RID: 13200 RVA: 0x00050B64 File Offset: 0x0004ED64
		[RequiredByNativeCode]
		public UnityEvent()
		{
		}

		// Token: 0x06003391 RID: 13201 RVA: 0x00050B7C File Offset: 0x0004ED7C
		public void AddListener(UnityAction<T0, T1, T2, T3> call)
		{
			base.AddCall(UnityEvent<T0, T1, T2, T3>.GetDelegate(call));
		}

		// Token: 0x06003392 RID: 13202 RVA: 0x00050B8C File Offset: 0x0004ED8C
		public void RemoveListener(UnityAction<T0, T1, T2, T3> call)
		{
			base.RemoveListener(call.Target, call.GetMethodInfo());
		}

		// Token: 0x06003393 RID: 13203 RVA: 0x00050BA4 File Offset: 0x0004EDA4
		protected override MethodInfo FindMethod_Impl(string name, object targetObj)
		{
			return UnityEventBase.GetValidMethodInfo(targetObj, name, new Type[]
			{
				typeof(T0),
				typeof(T1),
				typeof(T2),
				typeof(T3)
			});
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x00050BFC File Offset: 0x0004EDFC
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			return new InvokableCall<T0, T1, T2, T3>(target, theFunction);
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x00050C18 File Offset: 0x0004EE18
		private static BaseInvokableCall GetDelegate(UnityAction<T0, T1, T2, T3> action)
		{
			return new InvokableCall<T0, T1, T2, T3>(action);
		}

		// Token: 0x06003396 RID: 13206 RVA: 0x00050C34 File Offset: 0x0004EE34
		public void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3)
		{
			this.m_InvokeArray[0] = arg0;
			this.m_InvokeArray[1] = arg1;
			this.m_InvokeArray[2] = arg2;
			this.m_InvokeArray[3] = arg3;
			base.Invoke(this.m_InvokeArray);
		}

		// Token: 0x04000EE2 RID: 3810
		private readonly object[] m_InvokeArray = new object[4];
	}
}
