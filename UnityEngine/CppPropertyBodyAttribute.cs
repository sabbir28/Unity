using System;

namespace UnityEngine
{
	// Token: 0x0200032C RID: 812
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	internal class CppPropertyBodyAttribute : Attribute
	{
		// Token: 0x060030E5 RID: 12517 RVA: 0x0004A564 File Offset: 0x00048764
		public CppPropertyBodyAttribute(string getterBody, string setterBody)
		{
		}

		// Token: 0x060030E6 RID: 12518 RVA: 0x0004A570 File Offset: 0x00048770
		public CppPropertyBodyAttribute(string getterBody)
		{
		}
	}
}
