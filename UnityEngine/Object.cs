using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x020000D0 RID: 208
	[RequiredByNativeCode]
	[StructLayout(LayoutKind.Sequential)]
	public class Object
	{
		// Token: 0x06000F2F RID: 3887
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Object Internal_CloneSingle(Object data);

		// Token: 0x06000F30 RID: 3888
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Object Internal_CloneSingleWithParent(Object data, Transform parent, bool worldPositionStays);

		// Token: 0x06000F31 RID: 3889 RVA: 0x00013C68 File Offset: 0x00011E68
		[ThreadAndSerializationSafe]
		private static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot)
		{
			return Object.INTERNAL_CALL_Internal_InstantiateSingle(data, ref pos, ref rot);
		}

		// Token: 0x06000F32 RID: 3890
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Object INTERNAL_CALL_Internal_InstantiateSingle(Object data, ref Vector3 pos, ref Quaternion rot);

		// Token: 0x06000F33 RID: 3891 RVA: 0x00013C88 File Offset: 0x00011E88
		private static Object Internal_InstantiateSingleWithParent(Object data, Transform parent, Vector3 pos, Quaternion rot)
		{
			return Object.INTERNAL_CALL_Internal_InstantiateSingleWithParent(data, parent, ref pos, ref rot);
		}

		// Token: 0x06000F34 RID: 3892
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Object INTERNAL_CALL_Internal_InstantiateSingleWithParent(Object data, Transform parent, ref Vector3 pos, ref Quaternion rot);

		// Token: 0x06000F35 RID: 3893
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetOffsetOfInstanceIDInCPlusPlusObject();

		// Token: 0x06000F36 RID: 3894
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void EnsureRunningOnMainThread();

		// Token: 0x06000F37 RID: 3895
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Destroy(Object obj, [DefaultValue("0.0F")] float t);

		// Token: 0x06000F38 RID: 3896 RVA: 0x00013CA8 File Offset: 0x00011EA8
		[ExcludeFromDocs]
		public static void Destroy(Object obj)
		{
			float t = 0f;
			Object.Destroy(obj, t);
		}

		// Token: 0x06000F39 RID: 3897
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyImmediate(Object obj, [DefaultValue("false")] bool allowDestroyingAssets);

		// Token: 0x06000F3A RID: 3898 RVA: 0x00013CC4 File Offset: 0x00011EC4
		[ExcludeFromDocs]
		public static void DestroyImmediate(Object obj)
		{
			bool allowDestroyingAssets = false;
			Object.DestroyImmediate(obj, allowDestroyingAssets);
		}

		// Token: 0x06000F3B RID: 3899
		[TypeInferenceRule(TypeInferenceRules.ArrayOfTypeReferencedByFirstArgument)]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Object[] FindObjectsOfType(Type type);

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000F3C RID: 3900
		// (set) Token: 0x06000F3D RID: 3901
		public extern string name { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000F3E RID: 3902
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DontDestroyOnLoad(Object target);

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000F3F RID: 3903
		// (set) Token: 0x06000F40 RID: 3904
		public extern HideFlags hideFlags { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000F41 RID: 3905
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyObject(Object obj, [DefaultValue("0.0F")] float t);

		// Token: 0x06000F42 RID: 3906 RVA: 0x00013CDC File Offset: 0x00011EDC
		[ExcludeFromDocs]
		public static void DestroyObject(Object obj)
		{
			float t = 0f;
			Object.DestroyObject(obj, t);
		}

		// Token: 0x06000F43 RID: 3907
		[Obsolete("use Object.FindObjectsOfType instead.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Object[] FindSceneObjectsOfType(Type type);

		// Token: 0x06000F44 RID: 3908
		[Obsolete("use Resources.FindObjectsOfTypeAll instead.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Object[] FindObjectsOfTypeIncludingAssets(Type type);

		// Token: 0x06000F45 RID: 3909 RVA: 0x00013CF8 File Offset: 0x00011EF8
		[Obsolete("Please use Resources.FindObjectsOfTypeAll instead")]
		public static Object[] FindObjectsOfTypeAll(Type type)
		{
			return Resources.FindObjectsOfTypeAll(type);
		}

		// Token: 0x06000F46 RID: 3910
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public override extern string ToString();

		// Token: 0x06000F47 RID: 3911
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool DoesObjectWithInstanceIDExist(int instanceID);

		// Token: 0x06000F48 RID: 3912 RVA: 0x00013D14 File Offset: 0x00011F14
		[SecuritySafeCritical]
		public unsafe int GetInstanceID()
		{
			int result;
			if (this.m_CachedPtr == IntPtr.Zero)
			{
				result = 0;
			}
			else
			{
				if (Object.OffsetOfInstanceIDInCPlusPlusObject == -1)
				{
					Object.OffsetOfInstanceIDInCPlusPlusObject = Object.GetOffsetOfInstanceIDInCPlusPlusObject();
				}
				result = *(int*)((void*)new IntPtr(this.m_CachedPtr.ToInt64() + (long)Object.OffsetOfInstanceIDInCPlusPlusObject));
			}
			return result;
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00013D78 File Offset: 0x00011F78
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x00013D94 File Offset: 0x00011F94
		public override bool Equals(object other)
		{
			Object @object = other as Object;
			return (!(@object == null) || other == null || other is Object) && Object.CompareBaseObjects(this, @object);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x00013DDC File Offset: 0x00011FDC
		public static implicit operator bool(Object exists)
		{
			return !Object.CompareBaseObjects(exists, null);
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00013DFC File Offset: 0x00011FFC
		private static bool CompareBaseObjects(Object lhs, Object rhs)
		{
			bool flag = lhs == null;
			bool flag2 = rhs == null;
			bool result;
			if (flag2 && flag)
			{
				result = true;
			}
			else if (flag2)
			{
				result = !Object.IsNativeObjectAlive(lhs);
			}
			else if (flag)
			{
				result = !Object.IsNativeObjectAlive(rhs);
			}
			else
			{
				result = object.ReferenceEquals(lhs, rhs);
			}
			return result;
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x00013E60 File Offset: 0x00012060
		private static bool IsNativeObjectAlive(Object o)
		{
			return o.GetCachedPtr() != IntPtr.Zero;
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00013E88 File Offset: 0x00012088
		private IntPtr GetCachedPtr()
		{
			return this.m_CachedPtr;
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00013EA4 File Offset: 0x000120A4
		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original, Vector3 position, Quaternion rotation)
		{
			Object.CheckNullArgument(original, "The Object you want to instantiate is null.");
			if (original is ScriptableObject)
			{
				throw new ArgumentException("Cannot instantiate a ScriptableObject with a position and rotation");
			}
			return Object.Internal_InstantiateSingle(original, position, rotation);
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00013EE4 File Offset: 0x000120E4
		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent)
		{
			Object result;
			if (parent == null)
			{
				result = Object.Internal_InstantiateSingle(original, position, rotation);
			}
			else
			{
				Object.CheckNullArgument(original, "The Object you want to instantiate is null.");
				result = Object.Internal_InstantiateSingleWithParent(original, parent, position, rotation);
			}
			return result;
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00013F28 File Offset: 0x00012128
		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original)
		{
			Object.CheckNullArgument(original, "The Object you want to instantiate is null.");
			return Object.Internal_CloneSingle(original);
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00013F50 File Offset: 0x00012150
		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original, Transform parent)
		{
			return Object.Instantiate(original, parent, false);
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00013F70 File Offset: 0x00012170
		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace)
		{
			Object result;
			if (parent == null)
			{
				result = Object.Internal_CloneSingle(original);
			}
			else
			{
				Object.CheckNullArgument(original, "The Object you want to instantiate is null.");
				result = Object.Internal_CloneSingleWithParent(original, parent, instantiateInWorldSpace);
			}
			return result;
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00013FB0 File Offset: 0x000121B0
		public static T Instantiate<T>(T original) where T : Object
		{
			Object.CheckNullArgument(original, "The Object you want to instantiate is null.");
			return (T)((object)Object.Internal_CloneSingle(original));
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00013FE8 File Offset: 0x000121E8
		public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) where T : Object
		{
			return (T)((object)Object.Instantiate(original, position, rotation));
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00014010 File Offset: 0x00012210
		public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent) where T : Object
		{
			return (T)((object)Object.Instantiate(original, position, rotation, parent));
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00014038 File Offset: 0x00012238
		public static T Instantiate<T>(T original, Transform parent) where T : Object
		{
			return Object.Instantiate<T>(original, parent, false);
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00014058 File Offset: 0x00012258
		public static T Instantiate<T>(T original, Transform parent, bool worldPositionStays) where T : Object
		{
			return (T)((object)Object.Instantiate(original, parent, worldPositionStays));
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00014080 File Offset: 0x00012280
		public static T[] FindObjectsOfType<T>() where T : Object
		{
			return Resources.ConvertObjects<T>(Object.FindObjectsOfType(typeof(T)));
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x000140AC File Offset: 0x000122AC
		public static T FindObjectOfType<T>() where T : Object
		{
			return (T)((object)Object.FindObjectOfType(typeof(T)));
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x000140D8 File Offset: 0x000122D8
		private static void CheckNullArgument(object arg, string message)
		{
			if (arg == null)
			{
				throw new ArgumentException(message);
			}
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x000140E8 File Offset: 0x000122E8
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public static Object FindObjectOfType(Type type)
		{
			Object[] array = Object.FindObjectsOfType(type);
			Object result;
			if (array.Length > 0)
			{
				result = array[0];
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00014118 File Offset: 0x00012318
		public static bool operator ==(Object x, Object y)
		{
			return Object.CompareBaseObjects(x, y);
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x00014134 File Offset: 0x00012334
		public static bool operator !=(Object x, Object y)
		{
			return !Object.CompareBaseObjects(x, y);
		}

		// Token: 0x040001DB RID: 475
		private IntPtr m_CachedPtr;

		// Token: 0x040001DC RID: 476
		internal static int OffsetOfInstanceIDInCPlusPlusObject = -1;
	}
}
