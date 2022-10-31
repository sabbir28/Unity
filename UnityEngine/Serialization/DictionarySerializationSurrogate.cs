using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace UnityEngine.Serialization
{
	// Token: 0x02000446 RID: 1094
	internal class DictionarySerializationSurrogate<TKey, TValue> : ISerializationSurrogate
	{
		// Token: 0x06003524 RID: 13604 RVA: 0x00054580 File Offset: 0x00052780
		public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
		{
			Dictionary<TKey, TValue> dictionary = (Dictionary<TKey, TValue>)obj;
			dictionary.GetObjectData(info, context);
		}

		// Token: 0x06003525 RID: 13605 RVA: 0x000545A0 File Offset: 0x000527A0
		public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
		{
			IEqualityComparer<TKey> comparer = (IEqualityComparer<TKey>)info.GetValue("Comparer", typeof(IEqualityComparer<TKey>));
			Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>(comparer);
			if (info.MemberCount > 3)
			{
				KeyValuePair<TKey, TValue>[] array = (KeyValuePair<TKey, TValue>[])info.GetValue("KeyValuePairs", typeof(KeyValuePair<TKey, TValue>[]));
				if (array != null)
				{
					foreach (KeyValuePair<TKey, TValue> keyValuePair in array)
					{
						dictionary.Add(keyValuePair.Key, keyValuePair.Value);
					}
				}
			}
			return dictionary;
		}
	}
}
