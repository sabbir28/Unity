using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace UnityEngine.Serialization
{
	// Token: 0x02000444 RID: 1092
	public class UnitySurrogateSelector : ISurrogateSelector
	{
		// Token: 0x0600351B RID: 13595 RVA: 0x000543B8 File Offset: 0x000525B8
		public ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector)
		{
			if (type.IsGenericType)
			{
				Type genericTypeDefinition = type.GetGenericTypeDefinition();
				if (genericTypeDefinition == typeof(List<>))
				{
					selector = this;
					return ListSerializationSurrogate.Default;
				}
				if (genericTypeDefinition == typeof(Dictionary<, >))
				{
					selector = this;
					Type type2 = typeof(DictionarySerializationSurrogate<, >).MakeGenericType(type.GetGenericArguments());
					return (ISerializationSurrogate)Activator.CreateInstance(type2);
				}
			}
			selector = null;
			return null;
		}

		// Token: 0x0600351C RID: 13596 RVA: 0x00054440 File Offset: 0x00052640
		public void ChainSelector(ISurrogateSelector selector)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600351D RID: 13597 RVA: 0x00054448 File Offset: 0x00052648
		public ISurrogateSelector GetNextSelector()
		{
			throw new NotImplementedException();
		}
	}
}
