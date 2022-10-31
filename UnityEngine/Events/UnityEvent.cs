using System;
using System.Reflection;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine.Events
{
	// Token: 0x020003EC RID: 1004
	[Serializable]
	public class UnityEvent : UnityEventBase
	{
		// Token: 0x06003364 RID: 13156 RVA: 0x00050810 File Offset: 0x0004EA10
		[RequiredByNativeCode]
		public UnityEvent()
		{
		}

		// Token: 0x06003365 RID: 13157 RVA: 0x00050828 File Offset: 0x0004EA28
		public void AddListener(UnityAction call)
		{
			base.AddCall(UnityEvent.GetDelegate(call));
		}

		// Token: 0x06003366 RID: 13158 RVA: 0x00050838 File Offset: 0x0004EA38
		public void RemoveListener(UnityAction call)
		{
			base.RemoveListener(call.Target, call.GetMethodInfo());
		}

		// Token: 0x06003367 RID: 13159 RVA: 0x00050850 File Offset: 0x0004EA50
		protected override MethodInfo FindMethod_Impl(string name, object targetObj)
		{
			return UnityEventBase.GetValidMethodInfo(targetObj, name, new Type[0]);
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x00050874 File Offset: 0x0004EA74
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			return new InvokableCall(target, theFunction);
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x00050890 File Offset: 0x0004EA90
		private static BaseInvokableCall GetDelegate(UnityAction action)
		{
			return new InvokableCall(action);
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x000508AC File Offset: 0x0004EAAC
		public void Invoke()
		{
			base.Invoke(this.m_InvokeArray);
		}

		// Token: 0x04000EDE RID: 3806
		private readonly object[] m_InvokeArray = new object[0];
	}
}
