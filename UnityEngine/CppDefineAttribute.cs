using System;

namespace UnityEngine
{
	// Token: 0x02000329 RID: 809
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
	internal class CppDefineAttribute : Attribute
	{
		// Token: 0x060030E2 RID: 12514 RVA: 0x0004A544 File Offset: 0x00048744
		public CppDefineAttribute(string symbol, string value)
		{
		}
	}
}
