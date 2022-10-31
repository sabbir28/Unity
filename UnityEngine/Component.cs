using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x02000028 RID: 40
	[RequiredByNativeCode]
	public class Component : Object
	{
		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000312 RID: 786
		public extern Transform transform { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000313 RID: 787
		public extern GameObject gameObject { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000314 RID: 788 RVA: 0x00005930 File Offset: 0x00003B30
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponent(Type type)
		{
			return this.gameObject.GetComponent(type);
		}

		// Token: 0x06000315 RID: 789
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue);

		// Token: 0x06000316 RID: 790 RVA: 0x00005954 File Offset: 0x00003B54
		[SecuritySafeCritical]
		public unsafe T GetComponent<T>()
		{
			CastHelper<T> castHelper = default(CastHelper<T>);
			this.GetComponentFastPath(typeof(T), new IntPtr((void*)(&castHelper.onePointerFurtherThanT)));
			return castHelper.t;
		}

		// Token: 0x06000317 RID: 791
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Component GetComponent(string type);

		// Token: 0x06000318 RID: 792 RVA: 0x00005994 File Offset: 0x00003B94
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponentInChildren(Type t, bool includeInactive)
		{
			return this.gameObject.GetComponentInChildren(t, includeInactive);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x000059B8 File Offset: 0x00003BB8
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponentInChildren(Type t)
		{
			return this.GetComponentInChildren(t, false);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x000059D8 File Offset: 0x00003BD8
		[ExcludeFromDocs]
		public T GetComponentInChildren<T>()
		{
			bool includeInactive = false;
			return this.GetComponentInChildren<T>(includeInactive);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x000059F8 File Offset: 0x00003BF8
		public T GetComponentInChildren<T>([DefaultValue("false")] bool includeInactive)
		{
			return (T)((object)this.GetComponentInChildren(typeof(T), includeInactive));
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00005A24 File Offset: 0x00003C24
		[ExcludeFromDocs]
		public Component[] GetComponentsInChildren(Type t)
		{
			bool includeInactive = false;
			return this.GetComponentsInChildren(t, includeInactive);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00005A44 File Offset: 0x00003C44
		public Component[] GetComponentsInChildren(Type t, [DefaultValue("false")] bool includeInactive)
		{
			return this.gameObject.GetComponentsInChildren(t, includeInactive);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00005A68 File Offset: 0x00003C68
		public T[] GetComponentsInChildren<T>(bool includeInactive)
		{
			return this.gameObject.GetComponentsInChildren<T>(includeInactive);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00005A8C File Offset: 0x00003C8C
		public void GetComponentsInChildren<T>(bool includeInactive, List<T> result)
		{
			this.gameObject.GetComponentsInChildren<T>(includeInactive, result);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00005A9C File Offset: 0x00003C9C
		public T[] GetComponentsInChildren<T>()
		{
			return this.GetComponentsInChildren<T>(false);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00005AB8 File Offset: 0x00003CB8
		public void GetComponentsInChildren<T>(List<T> results)
		{
			this.GetComponentsInChildren<T>(false, results);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00005AC4 File Offset: 0x00003CC4
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponentInParent(Type t)
		{
			return this.gameObject.GetComponentInParent(t);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00005AE8 File Offset: 0x00003CE8
		public T GetComponentInParent<T>()
		{
			return (T)((object)this.GetComponentInParent(typeof(T)));
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00005B14 File Offset: 0x00003D14
		[ExcludeFromDocs]
		public Component[] GetComponentsInParent(Type t)
		{
			bool includeInactive = false;
			return this.GetComponentsInParent(t, includeInactive);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00005B34 File Offset: 0x00003D34
		public Component[] GetComponentsInParent(Type t, [DefaultValue("false")] bool includeInactive)
		{
			return this.gameObject.GetComponentsInParent(t, includeInactive);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00005B58 File Offset: 0x00003D58
		public T[] GetComponentsInParent<T>(bool includeInactive)
		{
			return this.gameObject.GetComponentsInParent<T>(includeInactive);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00005B7C File Offset: 0x00003D7C
		public void GetComponentsInParent<T>(bool includeInactive, List<T> results)
		{
			this.gameObject.GetComponentsInParent<T>(includeInactive, results);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00005B8C File Offset: 0x00003D8C
		public T[] GetComponentsInParent<T>()
		{
			return this.GetComponentsInParent<T>(false);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00005BA8 File Offset: 0x00003DA8
		public Component[] GetComponents(Type type)
		{
			return this.gameObject.GetComponents(type);
		}

		// Token: 0x0600032A RID: 810
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetComponentsForListInternal(Type searchType, object resultList);

		// Token: 0x0600032B RID: 811 RVA: 0x00005BCC File Offset: 0x00003DCC
		public void GetComponents(Type type, List<Component> results)
		{
			this.GetComponentsForListInternal(type, results);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00005BD8 File Offset: 0x00003DD8
		public void GetComponents<T>(List<T> results)
		{
			this.GetComponentsForListInternal(typeof(T), results);
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00005BEC File Offset: 0x00003DEC
		// (set) Token: 0x0600032E RID: 814 RVA: 0x00005C0C File Offset: 0x00003E0C
		public string tag
		{
			get
			{
				return this.gameObject.tag;
			}
			set
			{
				this.gameObject.tag = value;
			}
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00005C1C File Offset: 0x00003E1C
		public T[] GetComponents<T>()
		{
			return this.gameObject.GetComponents<T>();
		}

		// Token: 0x06000330 RID: 816
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool CompareTag(string tag);

		// Token: 0x06000331 RID: 817
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SendMessageUpwards(string methodName, [DefaultValue("null")] object value, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);

		// Token: 0x06000332 RID: 818 RVA: 0x00005C3C File Offset: 0x00003E3C
		[ExcludeFromDocs]
		public void SendMessageUpwards(string methodName, object value)
		{
			SendMessageOptions options = SendMessageOptions.RequireReceiver;
			this.SendMessageUpwards(methodName, value, options);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00005C58 File Offset: 0x00003E58
		[ExcludeFromDocs]
		public void SendMessageUpwards(string methodName)
		{
			SendMessageOptions options = SendMessageOptions.RequireReceiver;
			object value = null;
			this.SendMessageUpwards(methodName, value, options);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00005C74 File Offset: 0x00003E74
		public void SendMessageUpwards(string methodName, SendMessageOptions options)
		{
			this.SendMessageUpwards(methodName, null, options);
		}

		// Token: 0x06000335 RID: 821
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SendMessage(string methodName, [DefaultValue("null")] object value, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);

		// Token: 0x06000336 RID: 822 RVA: 0x00005C80 File Offset: 0x00003E80
		[ExcludeFromDocs]
		public void SendMessage(string methodName, object value)
		{
			SendMessageOptions options = SendMessageOptions.RequireReceiver;
			this.SendMessage(methodName, value, options);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00005C9C File Offset: 0x00003E9C
		[ExcludeFromDocs]
		public void SendMessage(string methodName)
		{
			SendMessageOptions options = SendMessageOptions.RequireReceiver;
			object value = null;
			this.SendMessage(methodName, value, options);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00005CB8 File Offset: 0x00003EB8
		public void SendMessage(string methodName, SendMessageOptions options)
		{
			this.SendMessage(methodName, null, options);
		}

		// Token: 0x06000339 RID: 825
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void BroadcastMessage(string methodName, [DefaultValue("null")] object parameter, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);

		// Token: 0x0600033A RID: 826 RVA: 0x00005CC4 File Offset: 0x00003EC4
		[ExcludeFromDocs]
		public void BroadcastMessage(string methodName, object parameter)
		{
			SendMessageOptions options = SendMessageOptions.RequireReceiver;
			this.BroadcastMessage(methodName, parameter, options);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00005CE0 File Offset: 0x00003EE0
		[ExcludeFromDocs]
		public void BroadcastMessage(string methodName)
		{
			SendMessageOptions options = SendMessageOptions.RequireReceiver;
			object parameter = null;
			this.BroadcastMessage(methodName, parameter, options);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00005CFC File Offset: 0x00003EFC
		public void BroadcastMessage(string methodName, SendMessageOptions options)
		{
			this.BroadcastMessage(methodName, null, options);
		}
	}
}
