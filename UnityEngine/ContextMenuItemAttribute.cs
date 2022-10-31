using System;

namespace UnityEngine
{
	// Token: 0x020003BC RID: 956
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
	public class ContextMenuItemAttribute : PropertyAttribute
	{
		// Token: 0x06003260 RID: 12896 RVA: 0x0004D6EC File Offset: 0x0004B8EC
		public ContextMenuItemAttribute(string name, string function)
		{
			this.name = name;
			this.function = function;
		}

		// Token: 0x04000E81 RID: 3713
		public readonly string name;

		// Token: 0x04000E82 RID: 3714
		public readonly string function;
	}
}
