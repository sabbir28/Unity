using System;
using System.Collections.Generic;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	// Token: 0x020003E8 RID: 1000
	[Serializable]
	internal class PersistentCallGroup
	{
		// Token: 0x06003332 RID: 13106 RVA: 0x0004FEEC File Offset: 0x0004E0EC
		public PersistentCallGroup()
		{
			this.m_Calls = new List<PersistentCall>();
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06003333 RID: 13107 RVA: 0x0004FF00 File Offset: 0x0004E100
		public int Count
		{
			get
			{
				return this.m_Calls.Count;
			}
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x0004FF20 File Offset: 0x0004E120
		public PersistentCall GetListener(int index)
		{
			return this.m_Calls[index];
		}

		// Token: 0x06003335 RID: 13109 RVA: 0x0004FF44 File Offset: 0x0004E144
		public IEnumerable<PersistentCall> GetListeners()
		{
			return this.m_Calls;
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x0004FF60 File Offset: 0x0004E160
		public void AddListener()
		{
			this.m_Calls.Add(new PersistentCall());
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x0004FF74 File Offset: 0x0004E174
		public void AddListener(PersistentCall call)
		{
			this.m_Calls.Add(call);
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x0004FF84 File Offset: 0x0004E184
		public void RemoveListener(int index)
		{
			this.m_Calls.RemoveAt(index);
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x0004FF94 File Offset: 0x0004E194
		public void Clear()
		{
			this.m_Calls.Clear();
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x0004FFA4 File Offset: 0x0004E1A4
		public void RegisterEventPersistentListener(int index, Object targetObj, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, methodName);
			listener.mode = PersistentListenerMode.EventDefined;
		}

		// Token: 0x0600333B RID: 13115 RVA: 0x0004FFCC File Offset: 0x0004E1CC
		public void RegisterVoidPersistentListener(int index, Object targetObj, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, methodName);
			listener.mode = PersistentListenerMode.Void;
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x0004FFF4 File Offset: 0x0004E1F4
		public void RegisterObjectPersistentListener(int index, Object targetObj, Object argument, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, methodName);
			listener.mode = PersistentListenerMode.Object;
			listener.arguments.unityObjectArgument = argument;
		}

		// Token: 0x0600333D RID: 13117 RVA: 0x00050028 File Offset: 0x0004E228
		public void RegisterIntPersistentListener(int index, Object targetObj, int argument, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, methodName);
			listener.mode = PersistentListenerMode.Int;
			listener.arguments.intArgument = argument;
		}

		// Token: 0x0600333E RID: 13118 RVA: 0x0005005C File Offset: 0x0004E25C
		public void RegisterFloatPersistentListener(int index, Object targetObj, float argument, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, methodName);
			listener.mode = PersistentListenerMode.Float;
			listener.arguments.floatArgument = argument;
		}

		// Token: 0x0600333F RID: 13119 RVA: 0x00050090 File Offset: 0x0004E290
		public void RegisterStringPersistentListener(int index, Object targetObj, string argument, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, methodName);
			listener.mode = PersistentListenerMode.String;
			listener.arguments.stringArgument = argument;
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x000500C4 File Offset: 0x0004E2C4
		public void RegisterBoolPersistentListener(int index, Object targetObj, bool argument, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, methodName);
			listener.mode = PersistentListenerMode.Bool;
			listener.arguments.boolArgument = argument;
		}

		// Token: 0x06003341 RID: 13121 RVA: 0x000500F8 File Offset: 0x0004E2F8
		public void UnregisterPersistentListener(int index)
		{
			PersistentCall listener = this.GetListener(index);
			listener.UnregisterPersistentListener();
		}

		// Token: 0x06003342 RID: 13122 RVA: 0x00050114 File Offset: 0x0004E314
		public void RemoveListeners(Object target, string methodName)
		{
			List<PersistentCall> list = new List<PersistentCall>();
			for (int i = 0; i < this.m_Calls.Count; i++)
			{
				if (this.m_Calls[i].target == target && this.m_Calls[i].methodName == methodName)
				{
					list.Add(this.m_Calls[i]);
				}
			}
			this.m_Calls.RemoveAll(new Predicate<PersistentCall>(list.Contains));
		}

		// Token: 0x06003343 RID: 13123 RVA: 0x000501A8 File Offset: 0x0004E3A8
		public void Initialize(InvokableCallList invokableList, UnityEventBase unityEventBase)
		{
			foreach (PersistentCall persistentCall in this.m_Calls)
			{
				if (persistentCall.IsValid())
				{
					BaseInvokableCall runtimeCall = persistentCall.GetRuntimeCall(unityEventBase);
					if (runtimeCall != null)
					{
						invokableList.AddPersistentInvokableCall(runtimeCall);
					}
				}
			}
		}

		// Token: 0x04000ED5 RID: 3797
		[FormerlySerializedAs("m_Listeners")]
		[SerializeField]
		private List<PersistentCall> m_Calls;
	}
}
