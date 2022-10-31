using System;
using System.Reflection;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	// Token: 0x020003EA RID: 1002
	[UsedByNativeCode]
	[Serializable]
	public abstract class UnityEventBase : ISerializationCallbackReceiver
	{
		// Token: 0x0600334C RID: 13132 RVA: 0x000503E0 File Offset: 0x0004E5E0
		protected UnityEventBase()
		{
			this.m_Calls = new InvokableCallList();
			this.m_PersistentCalls = new PersistentCallGroup();
			this.m_TypeName = base.GetType().AssemblyQualifiedName;
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x00050418 File Offset: 0x0004E618
		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x0005041C File Offset: 0x0004E61C
		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
			this.DirtyPersistentCalls();
			this.m_TypeName = base.GetType().AssemblyQualifiedName;
		}

		// Token: 0x0600334F RID: 13135
		protected abstract MethodInfo FindMethod_Impl(string name, object targetObj);

		// Token: 0x06003350 RID: 13136
		internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction);

		// Token: 0x06003351 RID: 13137 RVA: 0x00050438 File Offset: 0x0004E638
		internal MethodInfo FindMethod(PersistentCall call)
		{
			Type argumentType = typeof(Object);
			if (!string.IsNullOrEmpty(call.arguments.unityObjectArgumentAssemblyTypeName))
			{
				argumentType = (Type.GetType(call.arguments.unityObjectArgumentAssemblyTypeName, false) ?? typeof(Object));
			}
			return this.FindMethod(call.methodName, call.target, call.mode, argumentType);
		}

		// Token: 0x06003352 RID: 13138 RVA: 0x000504AC File Offset: 0x0004E6AC
		internal MethodInfo FindMethod(string name, object listener, PersistentListenerMode mode, Type argumentType)
		{
			MethodInfo result;
			switch (mode)
			{
			case PersistentListenerMode.EventDefined:
				result = this.FindMethod_Impl(name, listener);
				break;
			case PersistentListenerMode.Void:
				result = UnityEventBase.GetValidMethodInfo(listener, name, new Type[0]);
				break;
			case PersistentListenerMode.Object:
				result = UnityEventBase.GetValidMethodInfo(listener, name, new Type[]
				{
					argumentType ?? typeof(Object)
				});
				break;
			case PersistentListenerMode.Int:
				result = UnityEventBase.GetValidMethodInfo(listener, name, new Type[]
				{
					typeof(int)
				});
				break;
			case PersistentListenerMode.Float:
				result = UnityEventBase.GetValidMethodInfo(listener, name, new Type[]
				{
					typeof(float)
				});
				break;
			case PersistentListenerMode.String:
				result = UnityEventBase.GetValidMethodInfo(listener, name, new Type[]
				{
					typeof(string)
				});
				break;
			case PersistentListenerMode.Bool:
				result = UnityEventBase.GetValidMethodInfo(listener, name, new Type[]
				{
					typeof(bool)
				});
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x06003353 RID: 13139 RVA: 0x000505B4 File Offset: 0x0004E7B4
		public int GetPersistentEventCount()
		{
			return this.m_PersistentCalls.Count;
		}

		// Token: 0x06003354 RID: 13140 RVA: 0x000505D4 File Offset: 0x0004E7D4
		public Object GetPersistentTarget(int index)
		{
			PersistentCall listener = this.m_PersistentCalls.GetListener(index);
			return (listener == null) ? null : listener.target;
		}

		// Token: 0x06003355 RID: 13141 RVA: 0x00050608 File Offset: 0x0004E808
		public string GetPersistentMethodName(int index)
		{
			PersistentCall listener = this.m_PersistentCalls.GetListener(index);
			return (listener == null) ? string.Empty : listener.methodName;
		}

		// Token: 0x06003356 RID: 13142 RVA: 0x00050640 File Offset: 0x0004E840
		private void DirtyPersistentCalls()
		{
			this.m_Calls.ClearPersistent();
			this.m_CallsDirty = true;
		}

		// Token: 0x06003357 RID: 13143 RVA: 0x00050658 File Offset: 0x0004E858
		private void RebuildPersistentCallsIfNeeded()
		{
			if (this.m_CallsDirty)
			{
				this.m_PersistentCalls.Initialize(this.m_Calls, this);
				this.m_CallsDirty = false;
			}
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x00050684 File Offset: 0x0004E884
		public void SetPersistentListenerState(int index, UnityEventCallState state)
		{
			PersistentCall listener = this.m_PersistentCalls.GetListener(index);
			if (listener != null)
			{
				listener.callState = state;
			}
			this.DirtyPersistentCalls();
		}

		// Token: 0x06003359 RID: 13145 RVA: 0x000506B4 File Offset: 0x0004E8B4
		protected void AddListener(object targetObj, MethodInfo method)
		{
			this.m_Calls.AddListener(this.GetDelegate(targetObj, method));
		}

		// Token: 0x0600335A RID: 13146 RVA: 0x000506CC File Offset: 0x0004E8CC
		internal void AddCall(BaseInvokableCall call)
		{
			this.m_Calls.AddListener(call);
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x000506DC File Offset: 0x0004E8DC
		protected void RemoveListener(object targetObj, MethodInfo method)
		{
			this.m_Calls.RemoveListener(targetObj, method);
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x000506EC File Offset: 0x0004E8EC
		public void RemoveAllListeners()
		{
			this.m_Calls.Clear();
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x000506FC File Offset: 0x0004E8FC
		protected void Invoke(object[] parameters)
		{
			this.RebuildPersistentCallsIfNeeded();
			this.m_Calls.Invoke(parameters);
		}

		// Token: 0x0600335E RID: 13150 RVA: 0x00050714 File Offset: 0x0004E914
		public override string ToString()
		{
			return base.ToString() + " " + base.GetType().FullName;
		}

		// Token: 0x0600335F RID: 13151 RVA: 0x00050744 File Offset: 0x0004E944
		public static MethodInfo GetValidMethodInfo(object obj, string functionName, Type[] argumentTypes)
		{
			Type type = obj.GetType();
			while (type != typeof(object) && type != null)
			{
				MethodInfo method = type.GetMethod(functionName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, argumentTypes, null);
				if (method != null)
				{
					ParameterInfo[] parameters = method.GetParameters();
					bool flag = true;
					int num = 0;
					foreach (ParameterInfo parameterInfo in parameters)
					{
						Type type2 = argumentTypes[num];
						Type parameterType = parameterInfo.ParameterType;
						flag = (type2.IsPrimitive == parameterType.IsPrimitive);
						if (!flag)
						{
							break;
						}
						num++;
					}
					if (flag)
					{
						return method;
					}
				}
				type = type.BaseType;
			}
			return null;
		}

		// Token: 0x04000EDA RID: 3802
		private InvokableCallList m_Calls;

		// Token: 0x04000EDB RID: 3803
		[FormerlySerializedAs("m_PersistentListeners")]
		[SerializeField]
		private PersistentCallGroup m_PersistentCalls;

		// Token: 0x04000EDC RID: 3804
		[SerializeField]
		private string m_TypeName;

		// Token: 0x04000EDD RID: 3805
		private bool m_CallsDirty = true;
	}
}
