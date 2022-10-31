﻿using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using SimpleJson.Reflection;

namespace SimpleJson
{
	// Token: 0x020002CB RID: 715
	[GeneratedCode("simple-json", "1.0.0")]
	internal class PocoJsonSerializerStrategy : IJsonSerializerStrategy
	{
		// Token: 0x06002E48 RID: 11848 RVA: 0x00043DE0 File Offset: 0x00041FE0
		public PocoJsonSerializerStrategy()
		{
			this.ConstructorCache = new ReflectionUtils.ThreadSafeDictionary<Type, ReflectionUtils.ConstructorDelegate>(new ReflectionUtils.ThreadSafeDictionaryValueFactory<Type, ReflectionUtils.ConstructorDelegate>(this.ContructorDelegateFactory));
			this.GetCache = new ReflectionUtils.ThreadSafeDictionary<Type, IDictionary<string, ReflectionUtils.GetDelegate>>(new ReflectionUtils.ThreadSafeDictionaryValueFactory<Type, IDictionary<string, ReflectionUtils.GetDelegate>>(this.GetterValueFactory));
			this.SetCache = new ReflectionUtils.ThreadSafeDictionary<Type, IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>>>(new ReflectionUtils.ThreadSafeDictionaryValueFactory<Type, IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>>>(this.SetterValueFactory));
		}

		// Token: 0x06002E49 RID: 11849 RVA: 0x00043E3C File Offset: 0x0004203C
		protected virtual string MapClrMemberNameToJsonFieldName(string clrPropertyName)
		{
			return clrPropertyName;
		}

		// Token: 0x06002E4A RID: 11850 RVA: 0x00043E54 File Offset: 0x00042054
		internal virtual ReflectionUtils.ConstructorDelegate ContructorDelegateFactory(Type key)
		{
			return ReflectionUtils.GetContructor(key, (!key.IsArray) ? PocoJsonSerializerStrategy.EmptyTypes : PocoJsonSerializerStrategy.ArrayConstructorParameterTypes);
		}

		// Token: 0x06002E4B RID: 11851 RVA: 0x00043E8C File Offset: 0x0004208C
		internal virtual IDictionary<string, ReflectionUtils.GetDelegate> GetterValueFactory(Type type)
		{
			IDictionary<string, ReflectionUtils.GetDelegate> dictionary = new Dictionary<string, ReflectionUtils.GetDelegate>();
			foreach (PropertyInfo propertyInfo in ReflectionUtils.GetProperties(type))
			{
				if (propertyInfo.CanRead)
				{
					MethodInfo getterMethodInfo = ReflectionUtils.GetGetterMethodInfo(propertyInfo);
					if (!getterMethodInfo.IsStatic && getterMethodInfo.IsPublic)
					{
						dictionary[this.MapClrMemberNameToJsonFieldName(propertyInfo.Name)] = ReflectionUtils.GetGetMethod(propertyInfo);
					}
				}
			}
			foreach (FieldInfo fieldInfo in ReflectionUtils.GetFields(type))
			{
				if (!fieldInfo.IsStatic && fieldInfo.IsPublic)
				{
					dictionary[this.MapClrMemberNameToJsonFieldName(fieldInfo.Name)] = ReflectionUtils.GetGetMethod(fieldInfo);
				}
			}
			return dictionary;
		}

		// Token: 0x06002E4C RID: 11852 RVA: 0x00043FBC File Offset: 0x000421BC
		internal virtual IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>> SetterValueFactory(Type type)
		{
			IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>> dictionary = new Dictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>>();
			foreach (PropertyInfo propertyInfo in ReflectionUtils.GetProperties(type))
			{
				if (propertyInfo.CanWrite)
				{
					MethodInfo setterMethodInfo = ReflectionUtils.GetSetterMethodInfo(propertyInfo);
					if (!setterMethodInfo.IsStatic && setterMethodInfo.IsPublic)
					{
						dictionary[this.MapClrMemberNameToJsonFieldName(propertyInfo.Name)] = new KeyValuePair<Type, ReflectionUtils.SetDelegate>(propertyInfo.PropertyType, ReflectionUtils.GetSetMethod(propertyInfo));
					}
				}
			}
			foreach (FieldInfo fieldInfo in ReflectionUtils.GetFields(type))
			{
				if (!fieldInfo.IsInitOnly && !fieldInfo.IsStatic && fieldInfo.IsPublic)
				{
					dictionary[this.MapClrMemberNameToJsonFieldName(fieldInfo.Name)] = new KeyValuePair<Type, ReflectionUtils.SetDelegate>(fieldInfo.FieldType, ReflectionUtils.GetSetMethod(fieldInfo));
				}
			}
			return dictionary;
		}

		// Token: 0x06002E4D RID: 11853 RVA: 0x00044110 File Offset: 0x00042310
		public virtual bool TrySerializeNonPrimitiveObject(object input, out object output)
		{
			return this.TrySerializeKnownTypes(input, out output) || this.TrySerializeUnknownTypes(input, out output);
		}

		// Token: 0x06002E4E RID: 11854 RVA: 0x00044140 File Offset: 0x00042340
		public virtual object DeserializeObject(object value, Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			string text = value as string;
			object result;
			if (type == typeof(Guid) && string.IsNullOrEmpty(text))
			{
				result = default(Guid);
			}
			else if (value == null)
			{
				result = null;
			}
			else
			{
				object obj = null;
				if (text != null)
				{
					if (text.Length != 0)
					{
						if (type == typeof(DateTime) || (ReflectionUtils.IsNullableType(type) && Nullable.GetUnderlyingType(type) == typeof(DateTime)))
						{
							return DateTime.ParseExact(text, PocoJsonSerializerStrategy.Iso8601Format, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal);
						}
						if (type == typeof(DateTimeOffset) || (ReflectionUtils.IsNullableType(type) && Nullable.GetUnderlyingType(type) == typeof(DateTimeOffset)))
						{
							return DateTimeOffset.ParseExact(text, PocoJsonSerializerStrategy.Iso8601Format, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal);
						}
						if (type == typeof(Guid) || (ReflectionUtils.IsNullableType(type) && Nullable.GetUnderlyingType(type) == typeof(Guid)))
						{
							return new Guid(text);
						}
						return text;
					}
					else
					{
						if (type == typeof(Guid))
						{
							obj = default(Guid);
						}
						else if (ReflectionUtils.IsNullableType(type) && Nullable.GetUnderlyingType(type) == typeof(Guid))
						{
							obj = null;
						}
						else
						{
							obj = text;
						}
						if (!ReflectionUtils.IsNullableType(type) && Nullable.GetUnderlyingType(type) == typeof(Guid))
						{
							return text;
						}
					}
				}
				else if (value is bool)
				{
					return value;
				}
				bool flag = value is long;
				bool flag2 = value is double;
				if ((flag && type == typeof(long)) || (flag2 && type == typeof(double)))
				{
					result = value;
				}
				else if ((flag2 && type != typeof(double)) || (flag && type != typeof(long)))
				{
					obj = ((!typeof(IConvertible).IsAssignableFrom(type)) ? value : Convert.ChangeType(value, type, CultureInfo.InvariantCulture));
					if (ReflectionUtils.IsNullableType(type))
					{
						result = ReflectionUtils.ToNullableType(obj, type);
					}
					else
					{
						result = obj;
					}
				}
				else
				{
					IDictionary<string, object> dictionary = value as IDictionary<string, object>;
					if (dictionary != null)
					{
						IDictionary<string, object> dictionary2 = dictionary;
						if (ReflectionUtils.IsTypeDictionary(type))
						{
							Type[] genericTypeArguments = ReflectionUtils.GetGenericTypeArguments(type);
							Type type2 = genericTypeArguments[0];
							Type type3 = genericTypeArguments[1];
							Type key = typeof(Dictionary<, >).MakeGenericType(new Type[]
							{
								type2,
								type3
							});
							IDictionary dictionary3 = (IDictionary)this.ConstructorCache[key](null);
							foreach (KeyValuePair<string, object> keyValuePair in dictionary2)
							{
								dictionary3.Add(keyValuePair.Key, this.DeserializeObject(keyValuePair.Value, type3));
							}
							obj = dictionary3;
						}
						else if (type == typeof(object))
						{
							obj = value;
						}
						else
						{
							obj = this.ConstructorCache[type](null);
							foreach (KeyValuePair<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>> keyValuePair2 in this.SetCache[type])
							{
								object value2;
								if (dictionary2.TryGetValue(keyValuePair2.Key, out value2))
								{
									value2 = this.DeserializeObject(value2, keyValuePair2.Value.Key);
									keyValuePair2.Value.Value(obj, value2);
								}
							}
						}
					}
					else
					{
						IList<object> list = value as IList<object>;
						if (list != null)
						{
							IList<object> list2 = list;
							IList list3 = null;
							if (type.IsArray)
							{
								list3 = (IList)this.ConstructorCache[type](new object[]
								{
									list2.Count
								});
								int num = 0;
								foreach (object value3 in list2)
								{
									list3[num++] = this.DeserializeObject(value3, type.GetElementType());
								}
							}
							else if (ReflectionUtils.IsTypeGenericeCollectionInterface(type) || ReflectionUtils.IsAssignableFrom(typeof(IList), type))
							{
								Type type4 = ReflectionUtils.GetGenericTypeArguments(type)[0];
								Type key2 = typeof(List<>).MakeGenericType(new Type[]
								{
									type4
								});
								list3 = (IList)this.ConstructorCache[key2](new object[]
								{
									list2.Count
								});
								foreach (object value4 in list2)
								{
									list3.Add(this.DeserializeObject(value4, type4));
								}
							}
							obj = list3;
						}
					}
					result = obj;
				}
			}
			return result;
		}

		// Token: 0x06002E4F RID: 11855 RVA: 0x0004472C File Offset: 0x0004292C
		protected virtual object SerializeEnum(Enum p)
		{
			return Convert.ToDouble(p, CultureInfo.InvariantCulture);
		}

		// Token: 0x06002E50 RID: 11856 RVA: 0x00044754 File Offset: 0x00042954
		protected virtual bool TrySerializeKnownTypes(object input, out object output)
		{
			bool result = true;
			if (input is DateTime)
			{
				output = ((DateTime)input).ToUniversalTime().ToString(PocoJsonSerializerStrategy.Iso8601Format[0], CultureInfo.InvariantCulture);
			}
			else if (input is DateTimeOffset)
			{
				output = ((DateTimeOffset)input).ToUniversalTime().ToString(PocoJsonSerializerStrategy.Iso8601Format[0], CultureInfo.InvariantCulture);
			}
			else if (input is Guid)
			{
				output = ((Guid)input).ToString("D");
			}
			else if (input is Uri)
			{
				output = input.ToString();
			}
			else
			{
				Enum @enum = input as Enum;
				if (@enum != null)
				{
					output = this.SerializeEnum(@enum);
				}
				else
				{
					result = false;
					output = null;
				}
			}
			return result;
		}

		// Token: 0x06002E51 RID: 11857 RVA: 0x0004483C File Offset: 0x00042A3C
		protected virtual bool TrySerializeUnknownTypes(object input, out object output)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			output = null;
			Type type = input.GetType();
			bool result;
			if (type.FullName == null)
			{
				result = false;
			}
			else
			{
				IDictionary<string, object> dictionary = new JsonObject();
				IDictionary<string, ReflectionUtils.GetDelegate> dictionary2 = this.GetCache[type];
				foreach (KeyValuePair<string, ReflectionUtils.GetDelegate> keyValuePair in dictionary2)
				{
					if (keyValuePair.Value != null)
					{
						dictionary.Add(this.MapClrMemberNameToJsonFieldName(keyValuePair.Key), keyValuePair.Value(input));
					}
				}
				output = dictionary;
				result = true;
			}
			return result;
		}

		// Token: 0x04000952 RID: 2386
		internal IDictionary<Type, ReflectionUtils.ConstructorDelegate> ConstructorCache;

		// Token: 0x04000953 RID: 2387
		internal IDictionary<Type, IDictionary<string, ReflectionUtils.GetDelegate>> GetCache;

		// Token: 0x04000954 RID: 2388
		internal IDictionary<Type, IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>>> SetCache;

		// Token: 0x04000955 RID: 2389
		internal static readonly Type[] EmptyTypes = new Type[0];

		// Token: 0x04000956 RID: 2390
		internal static readonly Type[] ArrayConstructorParameterTypes = new Type[]
		{
			typeof(int)
		};

		// Token: 0x04000957 RID: 2391
		private static readonly string[] Iso8601Format = new string[]
		{
			"yyyy-MM-dd\\THH:mm:ss.FFFFFFF\\Z",
			"yyyy-MM-dd\\THH:mm:ss\\Z",
			"yyyy-MM-dd\\THH:mm:ssK"
		};
	}
}
