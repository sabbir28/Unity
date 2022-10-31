using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace SimpleJson.Reflection
{
	// Token: 0x020002CC RID: 716
	[GeneratedCode("reflection-utils", "1.0.0")]
	internal class ReflectionUtils
	{
		// Token: 0x06002E54 RID: 11860 RVA: 0x00044968 File Offset: 0x00042B68
		public static Attribute GetAttribute(MemberInfo info, Type type)
		{
			Attribute result;
			if (info == null || type == null || !Attribute.IsDefined(info, type))
			{
				result = null;
			}
			else
			{
				result = Attribute.GetCustomAttribute(info, type);
			}
			return result;
		}

		// Token: 0x06002E55 RID: 11861 RVA: 0x000449A4 File Offset: 0x00042BA4
		public static Attribute GetAttribute(Type objectType, Type attributeType)
		{
			Attribute result;
			if (objectType == null || attributeType == null || !Attribute.IsDefined(objectType, attributeType))
			{
				result = null;
			}
			else
			{
				result = Attribute.GetCustomAttribute(objectType, attributeType);
			}
			return result;
		}

		// Token: 0x06002E56 RID: 11862 RVA: 0x000449E0 File Offset: 0x00042BE0
		public static Type[] GetGenericTypeArguments(Type type)
		{
			return type.GetGenericArguments();
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x000449FC File Offset: 0x00042BFC
		public static bool IsTypeGenericeCollectionInterface(Type type)
		{
			bool result;
			if (!type.IsGenericType)
			{
				result = false;
			}
			else
			{
				Type genericTypeDefinition = type.GetGenericTypeDefinition();
				result = (genericTypeDefinition == typeof(IList<>) || genericTypeDefinition == typeof(ICollection<>) || genericTypeDefinition == typeof(IEnumerable<>));
			}
			return result;
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x00044A5C File Offset: 0x00042C5C
		public static bool IsAssignableFrom(Type type1, Type type2)
		{
			return type1.IsAssignableFrom(type2);
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x00044A78 File Offset: 0x00042C78
		public static bool IsTypeDictionary(Type type)
		{
			bool result;
			if (typeof(IDictionary).IsAssignableFrom(type))
			{
				result = true;
			}
			else if (!type.IsGenericType)
			{
				result = false;
			}
			else
			{
				Type genericTypeDefinition = type.GetGenericTypeDefinition();
				result = (genericTypeDefinition == typeof(IDictionary<, >));
			}
			return result;
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x00044AD0 File Offset: 0x00042CD0
		public static bool IsNullableType(Type type)
		{
			return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
		}

		// Token: 0x06002E5B RID: 11867 RVA: 0x00044B08 File Offset: 0x00042D08
		public static object ToNullableType(object obj, Type nullableType)
		{
			return (obj != null) ? Convert.ChangeType(obj, Nullable.GetUnderlyingType(nullableType), CultureInfo.InvariantCulture) : null;
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x00044B3C File Offset: 0x00042D3C
		public static bool IsValueType(Type type)
		{
			return type.IsValueType;
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x00044B58 File Offset: 0x00042D58
		public static IEnumerable<ConstructorInfo> GetConstructors(Type type)
		{
			return type.GetConstructors();
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x00044B74 File Offset: 0x00042D74
		public static ConstructorInfo GetConstructorInfo(Type type, params Type[] argsType)
		{
			IEnumerable<ConstructorInfo> constructors = ReflectionUtils.GetConstructors(type);
			foreach (ConstructorInfo constructorInfo in constructors)
			{
				ParameterInfo[] parameters = constructorInfo.GetParameters();
				if (argsType.Length == parameters.Length)
				{
					int num = 0;
					bool flag = true;
					foreach (ParameterInfo parameterInfo in constructorInfo.GetParameters())
					{
						if (parameterInfo.ParameterType != argsType[num])
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						return constructorInfo;
					}
				}
			}
			return null;
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x00044C48 File Offset: 0x00042E48
		public static IEnumerable<PropertyInfo> GetProperties(Type type)
		{
			return type.GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x00044C68 File Offset: 0x00042E68
		public static IEnumerable<FieldInfo> GetFields(Type type)
		{
			return type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x00044C88 File Offset: 0x00042E88
		public static MethodInfo GetGetterMethodInfo(PropertyInfo propertyInfo)
		{
			return propertyInfo.GetGetMethod(true);
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x00044CA4 File Offset: 0x00042EA4
		public static MethodInfo GetSetterMethodInfo(PropertyInfo propertyInfo)
		{
			return propertyInfo.GetSetMethod(true);
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x00044CC0 File Offset: 0x00042EC0
		public static ReflectionUtils.ConstructorDelegate GetContructor(ConstructorInfo constructorInfo)
		{
			return ReflectionUtils.GetConstructorByReflection(constructorInfo);
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x00044CDC File Offset: 0x00042EDC
		public static ReflectionUtils.ConstructorDelegate GetContructor(Type type, params Type[] argsType)
		{
			return ReflectionUtils.GetConstructorByReflection(type, argsType);
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x00044CF8 File Offset: 0x00042EF8
		public static ReflectionUtils.ConstructorDelegate GetConstructorByReflection(ConstructorInfo constructorInfo)
		{
			return (object[] args) => constructorInfo.Invoke(args);
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x00044D28 File Offset: 0x00042F28
		public static ReflectionUtils.ConstructorDelegate GetConstructorByReflection(Type type, params Type[] argsType)
		{
			ConstructorInfo constructorInfo = ReflectionUtils.GetConstructorInfo(type, argsType);
			return (constructorInfo != null) ? ReflectionUtils.GetConstructorByReflection(constructorInfo) : null;
		}

		// Token: 0x06002E67 RID: 11879 RVA: 0x00044D58 File Offset: 0x00042F58
		public static ReflectionUtils.GetDelegate GetGetMethod(PropertyInfo propertyInfo)
		{
			return ReflectionUtils.GetGetMethodByReflection(propertyInfo);
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x00044D74 File Offset: 0x00042F74
		public static ReflectionUtils.GetDelegate GetGetMethod(FieldInfo fieldInfo)
		{
			return ReflectionUtils.GetGetMethodByReflection(fieldInfo);
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x00044D90 File Offset: 0x00042F90
		public static ReflectionUtils.GetDelegate GetGetMethodByReflection(PropertyInfo propertyInfo)
		{
			MethodInfo methodInfo = ReflectionUtils.GetGetterMethodInfo(propertyInfo);
			return (object source) => methodInfo.Invoke(source, ReflectionUtils.EmptyObjects);
		}

		// Token: 0x06002E6A RID: 11882 RVA: 0x00044DC4 File Offset: 0x00042FC4
		public static ReflectionUtils.GetDelegate GetGetMethodByReflection(FieldInfo fieldInfo)
		{
			return (object source) => fieldInfo.GetValue(source);
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x00044DF4 File Offset: 0x00042FF4
		public static ReflectionUtils.SetDelegate GetSetMethod(PropertyInfo propertyInfo)
		{
			return ReflectionUtils.GetSetMethodByReflection(propertyInfo);
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x00044E10 File Offset: 0x00043010
		public static ReflectionUtils.SetDelegate GetSetMethod(FieldInfo fieldInfo)
		{
			return ReflectionUtils.GetSetMethodByReflection(fieldInfo);
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x00044E2C File Offset: 0x0004302C
		public static ReflectionUtils.SetDelegate GetSetMethodByReflection(PropertyInfo propertyInfo)
		{
			MethodInfo methodInfo = ReflectionUtils.GetSetterMethodInfo(propertyInfo);
			return delegate(object source, object value)
			{
				methodInfo.Invoke(source, new object[]
				{
					value
				});
			};
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x00044E60 File Offset: 0x00043060
		public static ReflectionUtils.SetDelegate GetSetMethodByReflection(FieldInfo fieldInfo)
		{
			return delegate(object source, object value)
			{
				fieldInfo.SetValue(source, value);
			};
		}

		// Token: 0x04000958 RID: 2392
		private static readonly object[] EmptyObjects = new object[0];

		// Token: 0x020002CD RID: 717
		// (Invoke) Token: 0x06002E71 RID: 11889
		public delegate object GetDelegate(object source);

		// Token: 0x020002CE RID: 718
		// (Invoke) Token: 0x06002E75 RID: 11893
		public delegate void SetDelegate(object source, object value);

		// Token: 0x020002CF RID: 719
		// (Invoke) Token: 0x06002E79 RID: 11897
		public delegate object ConstructorDelegate(params object[] args);

		// Token: 0x020002D0 RID: 720
		// (Invoke) Token: 0x06002E7D RID: 11901
		public delegate TValue ThreadSafeDictionaryValueFactory<TKey, TValue>(TKey key);

		// Token: 0x020002D1 RID: 721
		public sealed class ThreadSafeDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
		{
			// Token: 0x06002E80 RID: 11904 RVA: 0x00044EA0 File Offset: 0x000430A0
			public ThreadSafeDictionary(ReflectionUtils.ThreadSafeDictionaryValueFactory<TKey, TValue> valueFactory)
			{
				this._valueFactory = valueFactory;
			}

			// Token: 0x06002E81 RID: 11905 RVA: 0x00044EBC File Offset: 0x000430BC
			private TValue Get(TKey key)
			{
				TValue result;
				TValue tvalue;
				if (this._dictionary == null)
				{
					result = this.AddValue(key);
				}
				else if (!this._dictionary.TryGetValue(key, out tvalue))
				{
					result = this.AddValue(key);
				}
				else
				{
					result = tvalue;
				}
				return result;
			}

			// Token: 0x06002E82 RID: 11906 RVA: 0x00044F0C File Offset: 0x0004310C
			private TValue AddValue(TKey key)
			{
				TValue tvalue = this._valueFactory(key);
				object @lock = this._lock;
				lock (@lock)
				{
					if (this._dictionary == null)
					{
						this._dictionary = new Dictionary<TKey, TValue>();
						this._dictionary[key] = tvalue;
					}
					else
					{
						TValue result;
						if (this._dictionary.TryGetValue(key, out result))
						{
							return result;
						}
						Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>(this._dictionary);
						dictionary[key] = tvalue;
						this._dictionary = dictionary;
					}
				}
				return tvalue;
			}

			// Token: 0x06002E83 RID: 11907 RVA: 0x00044FC0 File Offset: 0x000431C0
			public void Add(TKey key, TValue value)
			{
				throw new NotImplementedException();
			}

			// Token: 0x06002E84 RID: 11908 RVA: 0x00044FC8 File Offset: 0x000431C8
			public bool ContainsKey(TKey key)
			{
				return this._dictionary.ContainsKey(key);
			}

			// Token: 0x17000AC4 RID: 2756
			// (get) Token: 0x06002E85 RID: 11909 RVA: 0x00044FEC File Offset: 0x000431EC
			public ICollection<TKey> Keys
			{
				get
				{
					return this._dictionary.Keys;
				}
			}

			// Token: 0x06002E86 RID: 11910 RVA: 0x0004500C File Offset: 0x0004320C
			public bool Remove(TKey key)
			{
				throw new NotImplementedException();
			}

			// Token: 0x06002E87 RID: 11911 RVA: 0x00045014 File Offset: 0x00043214
			public bool TryGetValue(TKey key, out TValue value)
			{
				value = this[key];
				return true;
			}

			// Token: 0x17000AC5 RID: 2757
			// (get) Token: 0x06002E88 RID: 11912 RVA: 0x00045038 File Offset: 0x00043238
			public ICollection<TValue> Values
			{
				get
				{
					return this._dictionary.Values;
				}
			}

			// Token: 0x17000AC6 RID: 2758
			public TValue this[TKey key]
			{
				get
				{
					return this.Get(key);
				}
				set
				{
					throw new NotImplementedException();
				}
			}

			// Token: 0x06002E8B RID: 11915 RVA: 0x0004507C File Offset: 0x0004327C
			public void Add(KeyValuePair<TKey, TValue> item)
			{
				throw new NotImplementedException();
			}

			// Token: 0x06002E8C RID: 11916 RVA: 0x00045084 File Offset: 0x00043284
			public void Clear()
			{
				throw new NotImplementedException();
			}

			// Token: 0x06002E8D RID: 11917 RVA: 0x0004508C File Offset: 0x0004328C
			public bool Contains(KeyValuePair<TKey, TValue> item)
			{
				throw new NotImplementedException();
			}

			// Token: 0x06002E8E RID: 11918 RVA: 0x00045094 File Offset: 0x00043294
			public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
			{
				throw new NotImplementedException();
			}

			// Token: 0x17000AC7 RID: 2759
			// (get) Token: 0x06002E8F RID: 11919 RVA: 0x0004509C File Offset: 0x0004329C
			public int Count
			{
				get
				{
					return this._dictionary.Count;
				}
			}

			// Token: 0x17000AC8 RID: 2760
			// (get) Token: 0x06002E90 RID: 11920 RVA: 0x000450BC File Offset: 0x000432BC
			public bool IsReadOnly
			{
				get
				{
					throw new NotImplementedException();
				}
			}

			// Token: 0x06002E91 RID: 11921 RVA: 0x000450C4 File Offset: 0x000432C4
			public bool Remove(KeyValuePair<TKey, TValue> item)
			{
				throw new NotImplementedException();
			}

			// Token: 0x06002E92 RID: 11922 RVA: 0x000450CC File Offset: 0x000432CC
			public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
			{
				return this._dictionary.GetEnumerator();
			}

			// Token: 0x06002E93 RID: 11923 RVA: 0x000450F4 File Offset: 0x000432F4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this._dictionary.GetEnumerator();
			}

			// Token: 0x04000959 RID: 2393
			private readonly object _lock = new object();

			// Token: 0x0400095A RID: 2394
			private readonly ReflectionUtils.ThreadSafeDictionaryValueFactory<TKey, TValue> _valueFactory;

			// Token: 0x0400095B RID: 2395
			private Dictionary<TKey, TValue> _dictionary;
		}
	}
}
