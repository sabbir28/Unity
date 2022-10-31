using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;
using SimpleJson.Reflection;

namespace SimpleJson
{
	// Token: 0x020002C9 RID: 713
	[GeneratedCode("simple-json", "1.0.0")]
	internal static class SimpleJson
	{
		// Token: 0x06002E2A RID: 11818 RVA: 0x00042C40 File Offset: 0x00040E40
		public static object DeserializeObject(string json)
		{
			object result;
			if (SimpleJson.TryDeserializeObject(json, out result))
			{
				return result;
			}
			throw new SerializationException("Invalid JSON string");
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x00042C70 File Offset: 0x00040E70
		public static bool TryDeserializeObject(string json, out object obj)
		{
			bool result = true;
			if (json != null)
			{
				char[] json2 = json.ToCharArray();
				int num = 0;
				obj = SimpleJson.ParseValue(json2, ref num, ref result);
			}
			else
			{
				obj = null;
			}
			return result;
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x00042CB0 File Offset: 0x00040EB0
		public static object DeserializeObject(string json, Type type, IJsonSerializerStrategy jsonSerializerStrategy)
		{
			object obj = SimpleJson.DeserializeObject(json);
			return (type != null && (obj == null || !ReflectionUtils.IsAssignableFrom(obj.GetType(), type))) ? (jsonSerializerStrategy ?? SimpleJson.CurrentJsonSerializerStrategy).DeserializeObject(obj, type) : obj;
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x00042D04 File Offset: 0x00040F04
		public static object DeserializeObject(string json, Type type)
		{
			return SimpleJson.DeserializeObject(json, type, null);
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x00042D24 File Offset: 0x00040F24
		public static T DeserializeObject<T>(string json, IJsonSerializerStrategy jsonSerializerStrategy)
		{
			return (T)((object)SimpleJson.DeserializeObject(json, typeof(T), jsonSerializerStrategy));
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x00042D50 File Offset: 0x00040F50
		public static T DeserializeObject<T>(string json)
		{
			return (T)((object)SimpleJson.DeserializeObject(json, typeof(T), null));
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x00042D7C File Offset: 0x00040F7C
		public static string SerializeObject(object json, IJsonSerializerStrategy jsonSerializerStrategy)
		{
			StringBuilder stringBuilder = new StringBuilder(2000);
			bool flag = SimpleJson.SerializeValue(jsonSerializerStrategy, json, stringBuilder);
			return (!flag) ? null : stringBuilder.ToString();
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x00042DB8 File Offset: 0x00040FB8
		public static string SerializeObject(object json)
		{
			return SimpleJson.SerializeObject(json, SimpleJson.CurrentJsonSerializerStrategy);
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x00042DD8 File Offset: 0x00040FD8
		public static string EscapeToJavascriptString(string jsonString)
		{
			string result;
			if (string.IsNullOrEmpty(jsonString))
			{
				result = jsonString;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				int i = 0;
				while (i < jsonString.Length)
				{
					char c = jsonString[i++];
					if (c == '\\')
					{
						int num = jsonString.Length - i;
						if (num >= 2)
						{
							char c2 = jsonString[i];
							if (c2 == '\\')
							{
								stringBuilder.Append('\\');
								i++;
							}
							else if (c2 == '"')
							{
								stringBuilder.Append("\"");
								i++;
							}
							else if (c2 == 't')
							{
								stringBuilder.Append('\t');
								i++;
							}
							else if (c2 == 'b')
							{
								stringBuilder.Append('\b');
								i++;
							}
							else if (c2 == 'n')
							{
								stringBuilder.Append('\n');
								i++;
							}
							else if (c2 == 'r')
							{
								stringBuilder.Append('\r');
								i++;
							}
						}
					}
					else
					{
						stringBuilder.Append(c);
					}
				}
				result = stringBuilder.ToString();
			}
			return result;
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x00042F10 File Offset: 0x00041110
		private static IDictionary<string, object> ParseObject(char[] json, ref int index, ref bool success)
		{
			IDictionary<string, object> dictionary = new JsonObject();
			SimpleJson.NextToken(json, ref index);
			bool flag = false;
			while (!flag)
			{
				int num = SimpleJson.LookAhead(json, index);
				if (num != 0)
				{
					if (num == 6)
					{
						SimpleJson.NextToken(json, ref index);
					}
					else
					{
						if (num == 2)
						{
							SimpleJson.NextToken(json, ref index);
							return dictionary;
						}
						string key = SimpleJson.ParseString(json, ref index, ref success);
						if (!success)
						{
							success = false;
							return null;
						}
						num = SimpleJson.NextToken(json, ref index);
						if (num != 5)
						{
							success = false;
							return null;
						}
						object value = SimpleJson.ParseValue(json, ref index, ref success);
						if (!success)
						{
							success = false;
							return null;
						}
						dictionary[key] = value;
					}
					continue;
				}
				success = false;
				return null;
			}
			return dictionary;
		}

		// Token: 0x06002E34 RID: 11828 RVA: 0x00042FE8 File Offset: 0x000411E8
		private static JsonArray ParseArray(char[] json, ref int index, ref bool success)
		{
			JsonArray jsonArray = new JsonArray();
			SimpleJson.NextToken(json, ref index);
			bool flag = false;
			while (!flag)
			{
				int num = SimpleJson.LookAhead(json, index);
				if (num != 0)
				{
					if (num == 6)
					{
						SimpleJson.NextToken(json, ref index);
					}
					else
					{
						if (num == 4)
						{
							SimpleJson.NextToken(json, ref index);
							break;
						}
						object item = SimpleJson.ParseValue(json, ref index, ref success);
						if (!success)
						{
							return null;
						}
						jsonArray.Add(item);
					}
					continue;
				}
				success = false;
				return null;
			}
			return jsonArray;
		}

		// Token: 0x06002E35 RID: 11829 RVA: 0x00043080 File Offset: 0x00041280
		private static object ParseValue(char[] json, ref int index, ref bool success)
		{
			switch (SimpleJson.LookAhead(json, index))
			{
			case 1:
				return SimpleJson.ParseObject(json, ref index, ref success);
			case 3:
				return SimpleJson.ParseArray(json, ref index, ref success);
			case 7:
				return SimpleJson.ParseString(json, ref index, ref success);
			case 8:
				return SimpleJson.ParseNumber(json, ref index, ref success);
			case 9:
				SimpleJson.NextToken(json, ref index);
				return true;
			case 10:
				SimpleJson.NextToken(json, ref index);
				return false;
			case 11:
				SimpleJson.NextToken(json, ref index);
				return null;
			}
			success = false;
			return null;
		}

		// Token: 0x06002E36 RID: 11830 RVA: 0x00043154 File Offset: 0x00041354
		private static string ParseString(char[] json, ref int index, ref bool success)
		{
			StringBuilder stringBuilder = new StringBuilder(2000);
			SimpleJson.EatWhitespace(json, ref index);
			char c = json[index++];
			bool flag = false;
			while (!flag)
			{
				if (index == json.Length)
				{
					break;
				}
				c = json[index++];
				if (c == '"')
				{
					flag = true;
					break;
				}
				if (c == '\\')
				{
					if (index == json.Length)
					{
						break;
					}
					c = json[index++];
					if (c == '"')
					{
						stringBuilder.Append('"');
					}
					else if (c == '\\')
					{
						stringBuilder.Append('\\');
					}
					else if (c == '/')
					{
						stringBuilder.Append('/');
					}
					else if (c == 'b')
					{
						stringBuilder.Append('\b');
					}
					else if (c == 'f')
					{
						stringBuilder.Append('\f');
					}
					else if (c == 'n')
					{
						stringBuilder.Append('\n');
					}
					else if (c == 'r')
					{
						stringBuilder.Append('\r');
					}
					else if (c == 't')
					{
						stringBuilder.Append('\t');
					}
					else if (c == 'u')
					{
						int num = json.Length - index;
						if (num >= 4)
						{
							uint num2;
							string result;
							if (!(success = uint.TryParse(new string(json, index, 4), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out num2)))
							{
								result = "";
							}
							else
							{
								if (55296U > num2 || num2 > 56319U)
								{
									stringBuilder.Append(SimpleJson.ConvertFromUtf32((int)num2));
									index += 4;
									continue;
								}
								index += 4;
								num = json.Length - index;
								if (num >= 6)
								{
									uint num3;
									if (new string(json, index, 2) == "\\u" && uint.TryParse(new string(json, index + 2, 4), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out num3))
									{
										if (56320U <= num3 && num3 <= 57343U)
										{
											stringBuilder.Append((char)num2);
											stringBuilder.Append((char)num3);
											index += 6;
											continue;
										}
									}
								}
								success = false;
								result = "";
							}
							return result;
						}
						break;
					}
				}
				else
				{
					stringBuilder.Append(c);
				}
			}
			if (!flag)
			{
				success = false;
				return null;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x000433DC File Offset: 0x000415DC
		private static string ConvertFromUtf32(int utf32)
		{
			if (utf32 < 0 || utf32 > 1114111)
			{
				throw new ArgumentOutOfRangeException("utf32", "The argument must be from 0 to 0x10FFFF.");
			}
			if (55296 <= utf32 && utf32 <= 57343)
			{
				throw new ArgumentOutOfRangeException("utf32", "The argument must not be in surrogate pair range.");
			}
			string result;
			if (utf32 < 65536)
			{
				result = new string((char)utf32, 1);
			}
			else
			{
				utf32 -= 65536;
				result = new string(new char[]
				{
					(char)((utf32 >> 10) + 55296),
					(char)(utf32 % 1024 + 56320)
				});
			}
			return result;
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x00043488 File Offset: 0x00041688
		private static object ParseNumber(char[] json, ref int index, ref bool success)
		{
			SimpleJson.EatWhitespace(json, ref index);
			int lastIndexOfNumber = SimpleJson.GetLastIndexOfNumber(json, index);
			int length = lastIndexOfNumber - index + 1;
			string text = new string(json, index, length);
			object result;
			if (text.IndexOf(".", StringComparison.OrdinalIgnoreCase) != -1 || text.IndexOf("e", StringComparison.OrdinalIgnoreCase) != -1)
			{
				double num;
				success = double.TryParse(new string(json, index, length), NumberStyles.Any, CultureInfo.InvariantCulture, out num);
				result = num;
			}
			else
			{
				long num2;
				success = long.TryParse(new string(json, index, length), NumberStyles.Any, CultureInfo.InvariantCulture, out num2);
				result = num2;
			}
			index = lastIndexOfNumber + 1;
			return result;
		}

		// Token: 0x06002E39 RID: 11833 RVA: 0x0004353C File Offset: 0x0004173C
		private static int GetLastIndexOfNumber(char[] json, int index)
		{
			int i;
			for (i = index; i < json.Length; i++)
			{
				if ("0123456789+-.eE".IndexOf(json[i]) == -1)
				{
					break;
				}
			}
			return i - 1;
		}

		// Token: 0x06002E3A RID: 11834 RVA: 0x00043580 File Offset: 0x00041780
		private static void EatWhitespace(char[] json, ref int index)
		{
			while (index < json.Length)
			{
				if (" \t\n\r\b\f".IndexOf(json[index]) == -1)
				{
					break;
				}
				index++;
			}
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x000435B4 File Offset: 0x000417B4
		private static int LookAhead(char[] json, int index)
		{
			int num = index;
			return SimpleJson.NextToken(json, ref num);
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x000435D4 File Offset: 0x000417D4
		private static int NextToken(char[] json, ref int index)
		{
			SimpleJson.EatWhitespace(json, ref index);
			int result;
			if (index == json.Length)
			{
				result = 0;
			}
			else
			{
				char c = json[index];
				index++;
				switch (c)
				{
				case ',':
					result = 6;
					break;
				case '-':
				case '0':
				case '1':
				case '2':
				case '3':
				case '4':
				case '5':
				case '6':
				case '7':
				case '8':
				case '9':
					result = 8;
					break;
				default:
					switch (c)
					{
					case '[':
						result = 3;
						break;
					default:
						switch (c)
						{
						case '{':
							result = 1;
							break;
						default:
							if (c != '"')
							{
								index--;
								int num = json.Length - index;
								if (num >= 5)
								{
									if (json[index] == 'f' && json[index + 1] == 'a' && json[index + 2] == 'l' && json[index + 3] == 's' && json[index + 4] == 'e')
									{
										index += 5;
										result = 10;
										break;
									}
								}
								if (num >= 4)
								{
									if (json[index] == 't' && json[index + 1] == 'r' && json[index + 2] == 'u' && json[index + 3] == 'e')
									{
										index += 4;
										result = 9;
										break;
									}
								}
								if (num >= 4)
								{
									if (json[index] == 'n' && json[index + 1] == 'u' && json[index + 2] == 'l' && json[index + 3] == 'l')
									{
										index += 4;
										result = 11;
										break;
									}
								}
								result = 0;
							}
							else
							{
								result = 7;
							}
							break;
						case '}':
							result = 2;
							break;
						}
						break;
					case ']':
						result = 4;
						break;
					}
					break;
				case ':':
					result = 5;
					break;
				}
			}
			return result;
		}

		// Token: 0x06002E3D RID: 11837 RVA: 0x000437BC File Offset: 0x000419BC
		private static bool SerializeValue(IJsonSerializerStrategy jsonSerializerStrategy, object value, StringBuilder builder)
		{
			bool flag = true;
			string text = value as string;
			if (text != null)
			{
				flag = SimpleJson.SerializeString(text, builder);
			}
			else
			{
				IDictionary<string, object> dictionary = value as IDictionary<string, object>;
				if (dictionary != null)
				{
					flag = SimpleJson.SerializeObject(jsonSerializerStrategy, dictionary.Keys, dictionary.Values, builder);
				}
				else
				{
					IDictionary<string, string> dictionary2 = value as IDictionary<string, string>;
					if (dictionary2 != null)
					{
						flag = SimpleJson.SerializeObject(jsonSerializerStrategy, dictionary2.Keys, dictionary2.Values, builder);
					}
					else
					{
						IEnumerable enumerable = value as IEnumerable;
						if (enumerable != null)
						{
							flag = SimpleJson.SerializeArray(jsonSerializerStrategy, enumerable, builder);
						}
						else if (SimpleJson.IsNumeric(value))
						{
							flag = SimpleJson.SerializeNumber(value, builder);
						}
						else if (value is bool)
						{
							builder.Append((!(bool)value) ? "false" : "true");
						}
						else if (value == null)
						{
							builder.Append("null");
						}
						else
						{
							object value2;
							flag = jsonSerializerStrategy.TrySerializeNonPrimitiveObject(value, out value2);
							if (flag)
							{
								SimpleJson.SerializeValue(jsonSerializerStrategy, value2, builder);
							}
						}
					}
				}
			}
			return flag;
		}

		// Token: 0x06002E3E RID: 11838 RVA: 0x000438E0 File Offset: 0x00041AE0
		private static bool SerializeObject(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable keys, IEnumerable values, StringBuilder builder)
		{
			builder.Append("{");
			IEnumerator enumerator = keys.GetEnumerator();
			IEnumerator enumerator2 = values.GetEnumerator();
			bool flag = true;
			while (enumerator.MoveNext() && enumerator2.MoveNext())
			{
				object obj = enumerator.Current;
				object value = enumerator2.Current;
				if (!flag)
				{
					builder.Append(",");
				}
				string text = obj as string;
				if (text != null)
				{
					SimpleJson.SerializeString(text, builder);
				}
				else if (!SimpleJson.SerializeValue(jsonSerializerStrategy, value, builder))
				{
					return false;
				}
				builder.Append(":");
				if (SimpleJson.SerializeValue(jsonSerializerStrategy, value, builder))
				{
					flag = false;
					continue;
				}
				return false;
			}
			builder.Append("}");
			return true;
		}

		// Token: 0x06002E3F RID: 11839 RVA: 0x000439B8 File Offset: 0x00041BB8
		private static bool SerializeArray(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable anArray, StringBuilder builder)
		{
			builder.Append("[");
			bool flag = true;
			IEnumerator enumerator = anArray.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object value = enumerator.Current;
					if (!flag)
					{
						builder.Append(",");
					}
					if (!SimpleJson.SerializeValue(jsonSerializerStrategy, value, builder))
					{
						return false;
					}
					flag = false;
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			builder.Append("]");
			return true;
		}

		// Token: 0x06002E40 RID: 11840 RVA: 0x00043A5C File Offset: 0x00041C5C
		private static bool SerializeString(string aString, StringBuilder builder)
		{
			builder.Append("\"");
			foreach (char c in aString.ToCharArray())
			{
				if (c == '"')
				{
					builder.Append("\\\"");
				}
				else if (c == '\\')
				{
					builder.Append("\\\\");
				}
				else if (c == '\b')
				{
					builder.Append("\\b");
				}
				else if (c == '\f')
				{
					builder.Append("\\f");
				}
				else if (c == '\n')
				{
					builder.Append("\\n");
				}
				else if (c == '\r')
				{
					builder.Append("\\r");
				}
				else if (c == '\t')
				{
					builder.Append("\\t");
				}
				else
				{
					builder.Append(c);
				}
			}
			builder.Append("\"");
			return true;
		}

		// Token: 0x06002E41 RID: 11841 RVA: 0x00043B64 File Offset: 0x00041D64
		private static bool SerializeNumber(object number, StringBuilder builder)
		{
			if (number is long)
			{
				builder.Append(((long)number).ToString(CultureInfo.InvariantCulture));
			}
			else if (number is ulong)
			{
				builder.Append(((ulong)number).ToString(CultureInfo.InvariantCulture));
			}
			else if (number is int)
			{
				builder.Append(((int)number).ToString(CultureInfo.InvariantCulture));
			}
			else if (number is uint)
			{
				builder.Append(((uint)number).ToString(CultureInfo.InvariantCulture));
			}
			else if (number is decimal)
			{
				builder.Append(((decimal)number).ToString(CultureInfo.InvariantCulture));
			}
			else if (number is float)
			{
				builder.Append(((float)number).ToString(CultureInfo.InvariantCulture));
			}
			else
			{
				builder.Append(Convert.ToDouble(number, CultureInfo.InvariantCulture).ToString("r", CultureInfo.InvariantCulture));
			}
			return true;
		}

		// Token: 0x06002E42 RID: 11842 RVA: 0x00043CA0 File Offset: 0x00041EA0
		private static bool IsNumeric(object value)
		{
			return value is sbyte || value is byte || value is short || value is ushort || value is int || value is uint || value is long || value is ulong || value is float || value is double || value is decimal;
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06002E43 RID: 11843 RVA: 0x00043D7C File Offset: 0x00041F7C
		// (set) Token: 0x06002E44 RID: 11844 RVA: 0x00043DA8 File Offset: 0x00041FA8
		public static IJsonSerializerStrategy CurrentJsonSerializerStrategy
		{
			get
			{
				IJsonSerializerStrategy result;
				if ((result = SimpleJson._currentJsonSerializerStrategy) == null)
				{
					result = (SimpleJson._currentJsonSerializerStrategy = SimpleJson.PocoJsonSerializerStrategy);
				}
				return result;
			}
			set
			{
				SimpleJson._currentJsonSerializerStrategy = value;
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06002E45 RID: 11845 RVA: 0x00043DB4 File Offset: 0x00041FB4
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static PocoJsonSerializerStrategy PocoJsonSerializerStrategy
		{
			get
			{
				PocoJsonSerializerStrategy result;
				if ((result = SimpleJson._pocoJsonSerializerStrategy) == null)
				{
					result = (SimpleJson._pocoJsonSerializerStrategy = new PocoJsonSerializerStrategy());
				}
				return result;
			}
		}

		// Token: 0x04000943 RID: 2371
		private const int TOKEN_NONE = 0;

		// Token: 0x04000944 RID: 2372
		private const int TOKEN_CURLY_OPEN = 1;

		// Token: 0x04000945 RID: 2373
		private const int TOKEN_CURLY_CLOSE = 2;

		// Token: 0x04000946 RID: 2374
		private const int TOKEN_SQUARED_OPEN = 3;

		// Token: 0x04000947 RID: 2375
		private const int TOKEN_SQUARED_CLOSE = 4;

		// Token: 0x04000948 RID: 2376
		private const int TOKEN_COLON = 5;

		// Token: 0x04000949 RID: 2377
		private const int TOKEN_COMMA = 6;

		// Token: 0x0400094A RID: 2378
		private const int TOKEN_STRING = 7;

		// Token: 0x0400094B RID: 2379
		private const int TOKEN_NUMBER = 8;

		// Token: 0x0400094C RID: 2380
		private const int TOKEN_TRUE = 9;

		// Token: 0x0400094D RID: 2381
		private const int TOKEN_FALSE = 10;

		// Token: 0x0400094E RID: 2382
		private const int TOKEN_NULL = 11;

		// Token: 0x0400094F RID: 2383
		private const int BUILDER_CAPACITY = 2000;

		// Token: 0x04000950 RID: 2384
		private static IJsonSerializerStrategy _currentJsonSerializerStrategy;

		// Token: 0x04000951 RID: 2385
		private static PocoJsonSerializerStrategy _pocoJsonSerializerStrategy;
	}
}
