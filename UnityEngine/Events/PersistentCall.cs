using System;
using System.Reflection;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	// Token: 0x020003E7 RID: 999
	[Serializable]
	internal class PersistentCall
	{
		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06003326 RID: 13094 RVA: 0x0004FBE0 File Offset: 0x0004DDE0
		public Object target
		{
			get
			{
				return this.m_Target;
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06003327 RID: 13095 RVA: 0x0004FBFC File Offset: 0x0004DDFC
		public string methodName
		{
			get
			{
				return this.m_MethodName;
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06003328 RID: 13096 RVA: 0x0004FC18 File Offset: 0x0004DE18
		// (set) Token: 0x06003329 RID: 13097 RVA: 0x0004FC34 File Offset: 0x0004DE34
		public PersistentListenerMode mode
		{
			get
			{
				return this.m_Mode;
			}
			set
			{
				this.m_Mode = value;
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x0600332A RID: 13098 RVA: 0x0004FC40 File Offset: 0x0004DE40
		public ArgumentCache arguments
		{
			get
			{
				return this.m_Arguments;
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x0600332B RID: 13099 RVA: 0x0004FC5C File Offset: 0x0004DE5C
		// (set) Token: 0x0600332C RID: 13100 RVA: 0x0004FC78 File Offset: 0x0004DE78
		public UnityEventCallState callState
		{
			get
			{
				return this.m_CallState;
			}
			set
			{
				this.m_CallState = value;
			}
		}

		// Token: 0x0600332D RID: 13101 RVA: 0x0004FC84 File Offset: 0x0004DE84
		public bool IsValid()
		{
			return this.target != null && !string.IsNullOrEmpty(this.methodName);
		}

		// Token: 0x0600332E RID: 13102 RVA: 0x0004FCBC File Offset: 0x0004DEBC
		public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent)
		{
			BaseInvokableCall result;
			if (this.m_CallState == UnityEventCallState.Off || theEvent == null)
			{
				result = null;
			}
			else
			{
				MethodInfo methodInfo = theEvent.FindMethod(this);
				if (methodInfo == null)
				{
					result = null;
				}
				else
				{
					switch (this.m_Mode)
					{
					case PersistentListenerMode.EventDefined:
						result = theEvent.GetDelegate(this.target, methodInfo);
						break;
					case PersistentListenerMode.Void:
						result = new InvokableCall(this.target, methodInfo);
						break;
					case PersistentListenerMode.Object:
						result = PersistentCall.GetObjectCall(this.target, methodInfo, this.m_Arguments);
						break;
					case PersistentListenerMode.Int:
						result = new CachedInvokableCall<int>(this.target, methodInfo, this.m_Arguments.intArgument);
						break;
					case PersistentListenerMode.Float:
						result = new CachedInvokableCall<float>(this.target, methodInfo, this.m_Arguments.floatArgument);
						break;
					case PersistentListenerMode.String:
						result = new CachedInvokableCall<string>(this.target, methodInfo, this.m_Arguments.stringArgument);
						break;
					case PersistentListenerMode.Bool:
						result = new CachedInvokableCall<bool>(this.target, methodInfo, this.m_Arguments.boolArgument);
						break;
					default:
						result = null;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x0600332F RID: 13103 RVA: 0x0004FDE0 File Offset: 0x0004DFE0
		private static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments)
		{
			Type type = typeof(Object);
			if (!string.IsNullOrEmpty(arguments.unityObjectArgumentAssemblyTypeName))
			{
				type = (Type.GetType(arguments.unityObjectArgumentAssemblyTypeName, false) ?? typeof(Object));
			}
			Type typeFromHandle = typeof(CachedInvokableCall<>);
			Type type2 = typeFromHandle.MakeGenericType(new Type[]
			{
				type
			});
			ConstructorInfo constructor = type2.GetConstructor(new Type[]
			{
				typeof(Object),
				typeof(MethodInfo),
				type
			});
			Object @object = arguments.unityObjectArgument;
			if (@object != null && !type.IsAssignableFrom(@object.GetType()))
			{
				@object = null;
			}
			return constructor.Invoke(new object[]
			{
				target,
				method,
				@object
			}) as BaseInvokableCall;
		}

		// Token: 0x06003330 RID: 13104 RVA: 0x0004FEC0 File Offset: 0x0004E0C0
		public void RegisterPersistentListener(Object ttarget, string mmethodName)
		{
			this.m_Target = ttarget;
			this.m_MethodName = mmethodName;
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x0004FED4 File Offset: 0x0004E0D4
		public void UnregisterPersistentListener()
		{
			this.m_MethodName = string.Empty;
			this.m_Target = null;
		}

		// Token: 0x04000ED0 RID: 3792
		[FormerlySerializedAs("instance")]
		[SerializeField]
		private Object m_Target;

		// Token: 0x04000ED1 RID: 3793
		[FormerlySerializedAs("methodName")]
		[SerializeField]
		private string m_MethodName;

		// Token: 0x04000ED2 RID: 3794
		[FormerlySerializedAs("mode")]
		[SerializeField]
		private PersistentListenerMode m_Mode = PersistentListenerMode.EventDefined;

		// Token: 0x04000ED3 RID: 3795
		[FormerlySerializedAs("arguments")]
		[SerializeField]
		private ArgumentCache m_Arguments = new ArgumentCache();

		// Token: 0x04000ED4 RID: 3796
		[FormerlySerializedAs("enabled")]
		[FormerlySerializedAs("m_Enabled")]
		[SerializeField]
		private UnityEventCallState m_CallState = UnityEventCallState.RuntimeOnly;
	}
}
