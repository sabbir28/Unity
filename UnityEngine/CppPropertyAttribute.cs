using System;

namespace UnityEngine
{
	// Token: 0x0200032D RID: 813
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	internal class CppPropertyAttribute : Attribute
	{
		// Token: 0x060030E7 RID: 12519 RVA: 0x0004A57C File Offset: 0x0004877C
		public CppPropertyAttribute(string getter, string setter)
		{
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x0004A588 File Offset: 0x00048788
		public CppPropertyAttribute(string getter)
		{
		}
	}
}
