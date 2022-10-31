using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;

namespace SimpleJson
{
	// Token: 0x020002C7 RID: 711
	[GeneratedCode("simple-json", "1.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class JsonArray : List<object>
	{
		// Token: 0x06002E11 RID: 11793 RVA: 0x00042854 File Offset: 0x00040A54
		public JsonArray()
		{
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x00042860 File Offset: 0x00040A60
		public JsonArray(int capacity) : base(capacity)
		{
		}

		// Token: 0x06002E13 RID: 11795 RVA: 0x0004286C File Offset: 0x00040A6C
		public override string ToString()
		{
			return SimpleJson.SerializeObject(this) ?? string.Empty;
		}
	}
}
