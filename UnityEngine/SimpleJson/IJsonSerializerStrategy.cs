using System;
using System.CodeDom.Compiler;

namespace SimpleJson
{
	// Token: 0x020002CA RID: 714
	[GeneratedCode("simple-json", "1.0.0")]
	internal interface IJsonSerializerStrategy
	{
		// Token: 0x06002E46 RID: 11846
		bool TrySerializeNonPrimitiveObject(object input, out object output);

		// Token: 0x06002E47 RID: 11847
		object DeserializeObject(object value, Type type);
	}
}
