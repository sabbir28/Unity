using System;
using System.Collections.Generic;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200030C RID: 780
	internal class AttributeHelperEngine
	{
		// Token: 0x06003088 RID: 12424 RVA: 0x00048F18 File Offset: 0x00047118
		[RequiredByNativeCode]
		private static Type GetParentTypeDisallowingMultipleInclusion(Type type)
		{
			Stack<Type> stack = new Stack<Type>();
			while (type != null && type != typeof(MonoBehaviour))
			{
				stack.Push(type);
				type = type.BaseType;
			}
			while (stack.Count > 0)
			{
				Type type2 = stack.Pop();
				object[] customAttributes = type2.GetCustomAttributes(typeof(DisallowMultipleComponent), false);
				int num = customAttributes.Length;
				if (num != 0)
				{
					return type2;
				}
			}
			return null;
		}

		// Token: 0x06003089 RID: 12425 RVA: 0x00048FA4 File Offset: 0x000471A4
		[RequiredByNativeCode]
		private static Type[] GetRequiredComponents(Type klass)
		{
			List<Type> list = null;
			while (klass != null && klass != typeof(MonoBehaviour))
			{
				RequireComponent[] array = (RequireComponent[])klass.GetCustomAttributes(typeof(RequireComponent), false);
				Type baseType = klass.BaseType;
				foreach (RequireComponent requireComponent in array)
				{
					if (list == null && array.Length == 1 && baseType == typeof(MonoBehaviour))
					{
						return new Type[]
						{
							requireComponent.m_Type0,
							requireComponent.m_Type1,
							requireComponent.m_Type2
						};
					}
					if (list == null)
					{
						list = new List<Type>();
					}
					if (requireComponent.m_Type0 != null)
					{
						list.Add(requireComponent.m_Type0);
					}
					if (requireComponent.m_Type1 != null)
					{
						list.Add(requireComponent.m_Type1);
					}
					if (requireComponent.m_Type2 != null)
					{
						list.Add(requireComponent.m_Type2);
					}
				}
				klass = baseType;
			}
			if (list == null)
			{
				return null;
			}
			return list.ToArray();
		}

		// Token: 0x0600308A RID: 12426 RVA: 0x000490D4 File Offset: 0x000472D4
		[RequiredByNativeCode]
		private static bool CheckIsEditorScript(Type klass)
		{
			while (klass != null && klass != typeof(MonoBehaviour))
			{
				object[] customAttributes = klass.GetCustomAttributes(typeof(ExecuteInEditMode), false);
				int num = customAttributes.Length;
				if (num != 0)
				{
					return true;
				}
				klass = klass.BaseType;
			}
			return false;
		}

		// Token: 0x0600308B RID: 12427 RVA: 0x00049134 File Offset: 0x00047334
		[RequiredByNativeCode]
		private static int GetDefaultExecutionOrderFor(Type klass)
		{
			DefaultExecutionOrder customAttributeOfType = AttributeHelperEngine.GetCustomAttributeOfType<DefaultExecutionOrder>(klass);
			int result;
			if (customAttributeOfType == null)
			{
				result = 0;
			}
			else
			{
				result = customAttributeOfType.order;
			}
			return result;
		}

		// Token: 0x0600308C RID: 12428 RVA: 0x00049164 File Offset: 0x00047364
		private static T GetCustomAttributeOfType<T>(Type klass) where T : Attribute
		{
			Type typeFromHandle = typeof(T);
			object[] customAttributes = klass.GetCustomAttributes(typeFromHandle, true);
			T result;
			if (customAttributes != null && customAttributes.Length != 0)
			{
				result = (T)((object)customAttributes[0]);
			}
			else
			{
				result = (T)((object)null);
			}
			return result;
		}
	}
}
