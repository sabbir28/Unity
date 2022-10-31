using System;
using System.Collections;
using System.Runtime.Serialization;

namespace UnityEngine.Serialization
{
	// Token: 0x02000445 RID: 1093
	internal class ListSerializationSurrogate : ISerializationSurrogate
	{
		// Token: 0x0600351F RID: 13599 RVA: 0x00054458 File Offset: 0x00052658
		public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
		{
			IList list = (IList)obj;
			info.AddValue("_size", list.Count);
			info.AddValue("_items", ListSerializationSurrogate.ArrayFromGenericList(list));
			info.AddValue("_version", 0);
		}

		// Token: 0x06003520 RID: 13600 RVA: 0x0005449C File Offset: 0x0005269C
		public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
		{
			IList list = (IList)Activator.CreateInstance(obj.GetType());
			int @int = info.GetInt32("_size");
			object result;
			if (@int == 0)
			{
				result = list;
			}
			else
			{
				IEnumerator enumerator = ((IEnumerable)info.GetValue("_items", typeof(IEnumerable))).GetEnumerator();
				for (int i = 0; i < @int; i++)
				{
					if (!enumerator.MoveNext())
					{
						throw new InvalidOperationException();
					}
					list.Add(enumerator.Current);
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06003521 RID: 13601 RVA: 0x00054534 File Offset: 0x00052734
		private static Array ArrayFromGenericList(IList list)
		{
			Array array = Array.CreateInstance(list.GetType().GetGenericArguments()[0], list.Count);
			list.CopyTo(array, 0);
			return array;
		}

		// Token: 0x04000F85 RID: 3973
		public static readonly ISerializationSurrogate Default = new ListSerializationSurrogate();
	}
}
