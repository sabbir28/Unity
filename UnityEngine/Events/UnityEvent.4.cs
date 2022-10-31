using System;
using System.Reflection;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine.Events
{
	// Token: 0x020003F2 RID: 1010
	[Serializable]
	public abstract class UnityEvent<T0, T1, T2> : UnityEventBase
	{
		// Token: 0x06003385 RID: 13189 RVA: 0x00050A64 File Offset: 0x0004EC64
		[RequiredByNativeCode]
		public UnityEvent()
		{
		}

		// Token: 0x06003386 RID: 13190 RVA: 0x00050A7C File Offset: 0x0004EC7C
		public void AddListener(UnityAction<T0, T1, T2> call)
		{
			base.AddCall(UnityEvent<T0, T1, T2>.GetDelegate(call));
		}

		// Token: 0x06003387 RID: 13191 RVA: 0x00050A8C File Offset: 0x0004EC8C
		public void RemoveListener(UnityAction<T0, T1, T2> call)
		{
			base.RemoveListener(call.Target, call.GetMethodInfo());
		}

		// Token: 0x06003388 RID: 13192 RVA: 0x00050AA4 File Offset: 0x0004ECA4
		protected override MethodInfo FindMethod_Impl(string name, object targetObj)
		{
			return UnityEventBase.GetValidMethodInfo(targetObj, name, new Type[]
			{
				typeof(T0),
				typeof(T1),
				typeof(T2)
			});
		}

		// Token: 0x06003389 RID: 13193 RVA: 0x00050AF0 File Offset: 0x0004ECF0
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			return new InvokableCall<T0, T1, T2>(target, theFunction);
		}

		// Token: 0x0600338A RID: 13194 RVA: 0x00050B0C File Offset: 0x0004ED0C
		private static BaseInvokableCall GetDelegate(UnityAction<T0, T1, T2> action)
		{
			return new InvokableCall<T0, T1, T2>(action);
		}

		// Token: 0x0600338B RID: 13195 RVA: 0x00050B28 File Offset: 0x0004ED28
		public void Invoke(T0 arg0, T1 arg1, T2 arg2)
		{
			this.m_InvokeArray[0] = arg0;
			this.m_InvokeArray[1] = arg1;
			this.m_InvokeArray[2] = arg2;
			base.Invoke(this.m_InvokeArray);
		}

		// Token: 0x04000EE1 RID: 3809
		private readonly object[] m_InvokeArray = new object[3];
	}
}
