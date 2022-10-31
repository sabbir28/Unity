using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SimpleJson
{
	// Token: 0x020002C8 RID: 712
	[GeneratedCode("simple-json", "1.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class JsonObject : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable
	{
		// Token: 0x06002E14 RID: 11796 RVA: 0x00042894 File Offset: 0x00040A94
		public JsonObject()
		{
			this._members = new Dictionary<string, object>();
		}

		// Token: 0x06002E15 RID: 11797 RVA: 0x000428A8 File Offset: 0x00040AA8
		public JsonObject(IEqualityComparer<string> comparer)
		{
			this._members = new Dictionary<string, object>(comparer);
		}

		// Token: 0x17000ABC RID: 2748
		public object this[int index]
		{
			get
			{
				return JsonObject.GetAtIndex(this._members, index);
			}
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x000428E4 File Offset: 0x00040AE4
		internal static object GetAtIndex(IDictionary<string, object> obj, int index)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			if (index >= obj.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			int num = 0;
			foreach (KeyValuePair<string, object> keyValuePair in obj)
			{
				if (num++ == index)
				{
					return keyValuePair.Value;
				}
			}
			return null;
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x00042980 File Offset: 0x00040B80
		public void Add(string key, object value)
		{
			this._members.Add(key, value);
		}

		// Token: 0x06002E19 RID: 11801 RVA: 0x00042990 File Offset: 0x00040B90
		public bool ContainsKey(string key)
		{
			return this._members.ContainsKey(key);
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06002E1A RID: 11802 RVA: 0x000429B4 File Offset: 0x00040BB4
		public ICollection<string> Keys
		{
			get
			{
				return this._members.Keys;
			}
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x000429D4 File Offset: 0x00040BD4
		public bool Remove(string key)
		{
			return this._members.Remove(key);
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x000429F8 File Offset: 0x00040BF8
		public bool TryGetValue(string key, out object value)
		{
			return this._members.TryGetValue(key, out value);
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06002E1D RID: 11805 RVA: 0x00042A1C File Offset: 0x00040C1C
		public ICollection<object> Values
		{
			get
			{
				return this._members.Values;
			}
		}

		// Token: 0x17000ABF RID: 2751
		public object this[string key]
		{
			get
			{
				return this._members[key];
			}
			set
			{
				this._members[key] = value;
			}
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x00042A70 File Offset: 0x00040C70
		public void Add(KeyValuePair<string, object> item)
		{
			this._members.Add(item.Key, item.Value);
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x00042A8C File Offset: 0x00040C8C
		public void Clear()
		{
			this._members.Clear();
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x00042A9C File Offset: 0x00040C9C
		public bool Contains(KeyValuePair<string, object> item)
		{
			return this._members.ContainsKey(item.Key) && this._members[item.Key] == item.Value;
		}

		// Token: 0x06002E23 RID: 11811 RVA: 0x00042AE8 File Offset: 0x00040CE8
		public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			int num = this.Count;
			foreach (KeyValuePair<string, object> keyValuePair in this)
			{
				array[arrayIndex++] = keyValuePair;
				if (--num <= 0)
				{
					break;
				}
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06002E24 RID: 11812 RVA: 0x00042B74 File Offset: 0x00040D74
		public int Count
		{
			get
			{
				return this._members.Count;
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06002E25 RID: 11813 RVA: 0x00042B94 File Offset: 0x00040D94
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x00042BAC File Offset: 0x00040DAC
		public bool Remove(KeyValuePair<string, object> item)
		{
			return this._members.Remove(item.Key);
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x00042BD4 File Offset: 0x00040DD4
		public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
		{
			return this._members.GetEnumerator();
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x00042BFC File Offset: 0x00040DFC
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this._members.GetEnumerator();
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x00042C24 File Offset: 0x00040E24
		public override string ToString()
		{
			return SimpleJson.SerializeObject(this);
		}

		// Token: 0x04000942 RID: 2370
		private readonly Dictionary<string, object> _members;
	}
}
