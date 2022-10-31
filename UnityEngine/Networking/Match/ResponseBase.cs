using System;
using System.Collections.Generic;

namespace UnityEngine.Networking.Match
{
	// Token: 0x0200028D RID: 653
	internal abstract class ResponseBase
	{
		// Token: 0x06002B84 RID: 11140
		public abstract void Parse(object obj);

		// Token: 0x06002B85 RID: 11141 RVA: 0x0003D428 File Offset: 0x0003B628
		public string ParseJSONString(string name, object obj, IDictionary<string, object> dictJsonObj)
		{
			if (dictJsonObj.TryGetValue(name, out obj))
			{
				return obj as string;
			}
			throw new FormatException(name + " not found in JSON dictionary");
		}

		// Token: 0x06002B86 RID: 11142 RVA: 0x0003D464 File Offset: 0x0003B664
		public short ParseJSONInt16(string name, object obj, IDictionary<string, object> dictJsonObj)
		{
			if (dictJsonObj.TryGetValue(name, out obj))
			{
				return Convert.ToInt16(obj);
			}
			throw new FormatException(name + " not found in JSON dictionary");
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x0003D4A0 File Offset: 0x0003B6A0
		public int ParseJSONInt32(string name, object obj, IDictionary<string, object> dictJsonObj)
		{
			if (dictJsonObj.TryGetValue(name, out obj))
			{
				return Convert.ToInt32(obj);
			}
			throw new FormatException(name + " not found in JSON dictionary");
		}

		// Token: 0x06002B88 RID: 11144 RVA: 0x0003D4DC File Offset: 0x0003B6DC
		public long ParseJSONInt64(string name, object obj, IDictionary<string, object> dictJsonObj)
		{
			if (dictJsonObj.TryGetValue(name, out obj))
			{
				return Convert.ToInt64(obj);
			}
			throw new FormatException(name + " not found in JSON dictionary");
		}

		// Token: 0x06002B89 RID: 11145 RVA: 0x0003D518 File Offset: 0x0003B718
		public ushort ParseJSONUInt16(string name, object obj, IDictionary<string, object> dictJsonObj)
		{
			if (dictJsonObj.TryGetValue(name, out obj))
			{
				return Convert.ToUInt16(obj);
			}
			throw new FormatException(name + " not found in JSON dictionary");
		}

		// Token: 0x06002B8A RID: 11146 RVA: 0x0003D554 File Offset: 0x0003B754
		public uint ParseJSONUInt32(string name, object obj, IDictionary<string, object> dictJsonObj)
		{
			if (dictJsonObj.TryGetValue(name, out obj))
			{
				return Convert.ToUInt32(obj);
			}
			throw new FormatException(name + " not found in JSON dictionary");
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x0003D590 File Offset: 0x0003B790
		public ulong ParseJSONUInt64(string name, object obj, IDictionary<string, object> dictJsonObj)
		{
			if (dictJsonObj.TryGetValue(name, out obj))
			{
				return Convert.ToUInt64(obj);
			}
			throw new FormatException(name + " not found in JSON dictionary");
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x0003D5CC File Offset: 0x0003B7CC
		public bool ParseJSONBool(string name, object obj, IDictionary<string, object> dictJsonObj)
		{
			if (dictJsonObj.TryGetValue(name, out obj))
			{
				return Convert.ToBoolean(obj);
			}
			throw new FormatException(name + " not found in JSON dictionary");
		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x0003D608 File Offset: 0x0003B808
		public DateTime ParseJSONDateTime(string name, object obj, IDictionary<string, object> dictJsonObj)
		{
			throw new FormatException(name + " DateTime not yet supported");
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x0003D61C File Offset: 0x0003B81C
		public List<string> ParseJSONListOfStrings(string name, object obj, IDictionary<string, object> dictJsonObj)
		{
			if (dictJsonObj.TryGetValue(name, out obj))
			{
				List<object> list = obj as List<object>;
				if (list != null)
				{
					List<string> list2 = new List<string>();
					foreach (object obj2 in list)
					{
						IDictionary<string, object> dictionary = (IDictionary<string, object>)obj2;
						foreach (KeyValuePair<string, object> keyValuePair in dictionary)
						{
							string item = (string)keyValuePair.Value;
							list2.Add(item);
						}
					}
					return list2;
				}
			}
			throw new FormatException(name + " not found in JSON dictionary");
		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x0003D710 File Offset: 0x0003B910
		public List<T> ParseJSONList<T>(string name, object obj, IDictionary<string, object> dictJsonObj) where T : ResponseBase, new()
		{
			if (dictJsonObj.TryGetValue(name, out obj))
			{
				List<object> list = obj as List<object>;
				if (list != null)
				{
					List<T> list2 = new List<T>();
					foreach (object obj2 in list)
					{
						IDictionary<string, object> obj3 = (IDictionary<string, object>)obj2;
						T item = Activator.CreateInstance<T>();
						item.Parse(obj3);
						list2.Add(item);
					}
					return list2;
				}
			}
			throw new FormatException(name + " not found in JSON dictionary");
		}
	}
}
