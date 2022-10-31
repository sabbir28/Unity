using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine.Internal;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x0200003A RID: 58
	public sealed class GameObject : Object
	{
		// Token: 0x06000400 RID: 1024 RVA: 0x00006BE0 File Offset: 0x00004DE0
		public GameObject(string name)
		{
			GameObject.Internal_CreateGameObject(this, name);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00006BF0 File Offset: 0x00004DF0
		public GameObject()
		{
			GameObject.Internal_CreateGameObject(this, null);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00006C00 File Offset: 0x00004E00
		public GameObject(string name, params Type[] components)
		{
			GameObject.Internal_CreateGameObject(this, name);
			foreach (Type componentType in components)
			{
				this.AddComponent(componentType);
			}
		}

		// Token: 0x06000403 RID: 1027
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern GameObject CreatePrimitive(PrimitiveType type);

		// Token: 0x06000404 RID: 1028
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Component GetComponent(Type type);

		// Token: 0x06000405 RID: 1029
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue);

		// Token: 0x06000406 RID: 1030 RVA: 0x00006C40 File Offset: 0x00004E40
		[SecuritySafeCritical]
		public unsafe T GetComponent<T>()
		{
			CastHelper<T> castHelper = default(CastHelper<T>);
			this.GetComponentFastPath(typeof(T), new IntPtr((void*)(&castHelper.onePointerFurtherThanT)));
			return castHelper.t;
		}

		// Token: 0x06000407 RID: 1031
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Component GetComponentByName(string type);

		// Token: 0x06000408 RID: 1032 RVA: 0x00006C80 File Offset: 0x00004E80
		public Component GetComponent(string type)
		{
			return this.GetComponentByName(type);
		}

		// Token: 0x06000409 RID: 1033
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Component GetComponentInChildren(Type type, bool includeInactive);

		// Token: 0x0600040A RID: 1034 RVA: 0x00006C9C File Offset: 0x00004E9C
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponentInChildren(Type type)
		{
			return this.GetComponentInChildren(type, false);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00006CBC File Offset: 0x00004EBC
		[ExcludeFromDocs]
		public T GetComponentInChildren<T>()
		{
			bool includeInactive = false;
			return this.GetComponentInChildren<T>(includeInactive);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00006CDC File Offset: 0x00004EDC
		public T GetComponentInChildren<T>([DefaultValue("false")] bool includeInactive)
		{
			return (T)((object)this.GetComponentInChildren(typeof(T), includeInactive));
		}

		// Token: 0x0600040D RID: 1037
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Component GetComponentInParent(Type type);

		// Token: 0x0600040E RID: 1038 RVA: 0x00006D08 File Offset: 0x00004F08
		public T GetComponentInParent<T>()
		{
			return (T)((object)this.GetComponentInParent(typeof(T)));
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00006D34 File Offset: 0x00004F34
		public Component[] GetComponents(Type type)
		{
			return (Component[])this.GetComponentsInternal(type, false, false, true, false, null);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00006D5C File Offset: 0x00004F5C
		public T[] GetComponents<T>()
		{
			return (T[])this.GetComponentsInternal(typeof(T), true, false, true, false, null);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00006D8C File Offset: 0x00004F8C
		public void GetComponents(Type type, List<Component> results)
		{
			this.GetComponentsInternal(type, false, false, true, false, results);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00006D9C File Offset: 0x00004F9C
		public void GetComponents<T>(List<T> results)
		{
			this.GetComponentsInternal(typeof(T), false, false, true, false, results);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00006DB8 File Offset: 0x00004FB8
		[ExcludeFromDocs]
		public Component[] GetComponentsInChildren(Type type)
		{
			bool includeInactive = false;
			return this.GetComponentsInChildren(type, includeInactive);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00006DD8 File Offset: 0x00004FD8
		public Component[] GetComponentsInChildren(Type type, [DefaultValue("false")] bool includeInactive)
		{
			return (Component[])this.GetComponentsInternal(type, false, true, includeInactive, false, null);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00006E00 File Offset: 0x00005000
		public T[] GetComponentsInChildren<T>(bool includeInactive)
		{
			return (T[])this.GetComponentsInternal(typeof(T), true, true, includeInactive, false, null);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00006E30 File Offset: 0x00005030
		public void GetComponentsInChildren<T>(bool includeInactive, List<T> results)
		{
			this.GetComponentsInternal(typeof(T), true, true, includeInactive, false, results);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00006E4C File Offset: 0x0000504C
		public T[] GetComponentsInChildren<T>()
		{
			return this.GetComponentsInChildren<T>(false);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00006E68 File Offset: 0x00005068
		public void GetComponentsInChildren<T>(List<T> results)
		{
			this.GetComponentsInChildren<T>(false, results);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00006E74 File Offset: 0x00005074
		[ExcludeFromDocs]
		public Component[] GetComponentsInParent(Type type)
		{
			bool includeInactive = false;
			return this.GetComponentsInParent(type, includeInactive);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00006E94 File Offset: 0x00005094
		public Component[] GetComponentsInParent(Type type, [DefaultValue("false")] bool includeInactive)
		{
			return (Component[])this.GetComponentsInternal(type, false, true, includeInactive, true, null);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00006EBC File Offset: 0x000050BC
		public void GetComponentsInParent<T>(bool includeInactive, List<T> results)
		{
			this.GetComponentsInternal(typeof(T), true, true, includeInactive, true, results);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00006ED8 File Offset: 0x000050D8
		public T[] GetComponentsInParent<T>(bool includeInactive)
		{
			return (T[])this.GetComponentsInternal(typeof(T), true, true, includeInactive, true, null);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00006F08 File Offset: 0x00005108
		public T[] GetComponentsInParent<T>()
		{
			return this.GetComponentsInParent<T>(false);
		}

		// Token: 0x0600041E RID: 1054
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList);

		// Token: 0x0600041F RID: 1055
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Component AddComponentInternal(string className);

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000420 RID: 1056
		public extern Transform transform { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000421 RID: 1057
		// (set) Token: 0x06000422 RID: 1058
		public extern int layer { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000423 RID: 1059
		// (set) Token: 0x06000424 RID: 1060
		[Obsolete("GameObject.active is obsolete. Use GameObject.SetActive(), GameObject.activeSelf or GameObject.activeInHierarchy.")]
		public extern bool active { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000425 RID: 1061
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetActive(bool value);

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000426 RID: 1062
		public extern bool activeSelf { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000427 RID: 1063
		public extern bool activeInHierarchy { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000428 RID: 1064
		[Obsolete("gameObject.SetActiveRecursively() is obsolete. Use GameObject.SetActive(), which is now inherited by children.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetActiveRecursively(bool state);

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000429 RID: 1065
		// (set) Token: 0x0600042A RID: 1066
		public extern bool isStatic { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600042B RID: 1067
		internal extern bool isStaticBatchable { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600042C RID: 1068
		// (set) Token: 0x0600042D RID: 1069
		public extern string tag { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x0600042E RID: 1070
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool CompareTag(string tag);

		// Token: 0x0600042F RID: 1071
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern GameObject FindGameObjectWithTag(string tag);

		// Token: 0x06000430 RID: 1072 RVA: 0x00006F24 File Offset: 0x00005124
		public static GameObject FindWithTag(string tag)
		{
			return GameObject.FindGameObjectWithTag(tag);
		}

		// Token: 0x06000431 RID: 1073
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern GameObject[] FindGameObjectsWithTag(string tag);

		// Token: 0x06000432 RID: 1074
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SendMessageUpwards(string methodName, [DefaultValue("null")] object value, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);

		// Token: 0x06000433 RID: 1075 RVA: 0x00006F40 File Offset: 0x00005140
		[ExcludeFromDocs]
		public void SendMessageUpwards(string methodName, object value)
		{
			SendMessageOptions options = SendMessageOptions.RequireReceiver;
			this.SendMessageUpwards(methodName, value, options);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00006F5C File Offset: 0x0000515C
		[ExcludeFromDocs]
		public void SendMessageUpwards(string methodName)
		{
			SendMessageOptions options = SendMessageOptions.RequireReceiver;
			object value = null;
			this.SendMessageUpwards(methodName, value, options);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00006F78 File Offset: 0x00005178
		public void SendMessageUpwards(string methodName, SendMessageOptions options)
		{
			this.SendMessageUpwards(methodName, null, options);
		}

		// Token: 0x06000436 RID: 1078
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SendMessage(string methodName, [DefaultValue("null")] object value, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);

		// Token: 0x06000437 RID: 1079 RVA: 0x00006F84 File Offset: 0x00005184
		[ExcludeFromDocs]
		public void SendMessage(string methodName, object value)
		{
			SendMessageOptions options = SendMessageOptions.RequireReceiver;
			this.SendMessage(methodName, value, options);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00006FA0 File Offset: 0x000051A0
		[ExcludeFromDocs]
		public void SendMessage(string methodName)
		{
			SendMessageOptions options = SendMessageOptions.RequireReceiver;
			object value = null;
			this.SendMessage(methodName, value, options);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00006FBC File Offset: 0x000051BC
		public void SendMessage(string methodName, SendMessageOptions options)
		{
			this.SendMessage(methodName, null, options);
		}

		// Token: 0x0600043A RID: 1082
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void BroadcastMessage(string methodName, [DefaultValue("null")] object parameter, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);

		// Token: 0x0600043B RID: 1083 RVA: 0x00006FC8 File Offset: 0x000051C8
		[ExcludeFromDocs]
		public void BroadcastMessage(string methodName, object parameter)
		{
			SendMessageOptions options = SendMessageOptions.RequireReceiver;
			this.BroadcastMessage(methodName, parameter, options);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00006FE4 File Offset: 0x000051E4
		[ExcludeFromDocs]
		public void BroadcastMessage(string methodName)
		{
			SendMessageOptions options = SendMessageOptions.RequireReceiver;
			object parameter = null;
			this.BroadcastMessage(methodName, parameter, options);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00007000 File Offset: 0x00005200
		public void BroadcastMessage(string methodName, SendMessageOptions options)
		{
			this.BroadcastMessage(methodName, null, options);
		}

		// Token: 0x0600043E RID: 1086
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Component Internal_AddComponentWithType(Type componentType);

		// Token: 0x0600043F RID: 1087 RVA: 0x0000700C File Offset: 0x0000520C
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component AddComponent(Type componentType)
		{
			return this.Internal_AddComponentWithType(componentType);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00007028 File Offset: 0x00005228
		public T AddComponent<T>() where T : Component
		{
			return this.AddComponent(typeof(T)) as T;
		}

		// Token: 0x06000441 RID: 1089
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateGameObject([Writable] GameObject mono, string name);

		// Token: 0x06000442 RID: 1090
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern GameObject Find(string name);

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x00007058 File Offset: 0x00005258
		public Scene scene
		{
			get
			{
				Scene result;
				this.INTERNAL_get_scene(out result);
				return result;
			}
		}

		// Token: 0x06000444 RID: 1092
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_scene(out Scene value);

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x00007078 File Offset: 0x00005278
		public GameObject gameObject
		{
			get
			{
				return this;
			}
		}
	}
}
