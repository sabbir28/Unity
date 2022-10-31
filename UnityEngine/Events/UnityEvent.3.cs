using System;
using System.Reflection;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine.Events
{
	// Token: 0x020003F0 RID: 1008
	[Serializable]
	public abstract class UnityEvent<T0, T1> : UnityEventBase
	{
		// Token: 0x0600337A RID: 13178 RVA: 0x00050984 File Offset: 0x0004EB84
		[RequiredByNativeCode]
		public UnityEvent()
		{
		}

		// Token: 0x0600337B RID: 13179 RVA: 0x0005099C File Offset: 0x0004EB9C
		public void AddListener(UnityAction<T0, T1> call)
		{
			base.AddCall(UnityEvent<T0, T1>.GetDelegate(call));
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x000509AC File Offset: 0x0004EBAC
		public void RemoveListener(UnityAction<T0, T1> call)
		{
			base.RemoveListener(call.Target, call.GetMethodInfo());
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x000509C4 File Offset: 0x0004EBC4
		protected override MethodInfo FindMethod_Impl(string name, object targetObj)
		{
			return UnityEventBase.GetValidMethodInfo(targetObj, name, new Type[]
			{
				typeof(T0),
				typeof(T1)
			});
		}

		// Token: 0x0600337E RID: 13182 RVA: 0x00050A00 File Offset: 0x0004EC00
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			return new InvokableCall<T0, T1>(target, theFunction);
		}

		// Token: 0x0600337F RID: 13183 RVA: 0x00050A1C File Offset: 0x0004EC1C
		private static BaseInvokableCall GetDelegate(UnityAction<T0, T1> action)
		{
			return new InvokableCall<T0, T1>(action);
		}

		// Token: 0x06003380 RID: 13184 RVA: 0x00050A38 File Offset: 0x0004EC38
		public void Invoke(T0 arg0, T1 arg1)
		{
			this.m_InvokeArray[0] = arg0;
			this.m_InvokeArray[1] = arg1;
			base.Invoke(this.m_InvokeArray);
		}

		// Token: 0x04000EE0 RID: 3808
		private readonly object[] m_InvokeArray = new object[2];
	}
}
