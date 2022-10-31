using System;

namespace UnityEngine
{
	// Token: 0x02000328 RID: 808
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
	internal class CppIncludeAttribute : Attribute
	{
		// Token: 0x060030E1 RID: 12513 RVA: 0x0004A538 File Offset: 0x00048738
		public CppIncludeAttribute(string header)
		{
		}
	}
}
