using System;

namespace UnityEngine
{
	// Token: 0x020003BD RID: 957
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public class TooltipAttribute : PropertyAttribute
	{
		// Token: 0x06003261 RID: 12897 RVA: 0x0004D704 File Offset: 0x0004B904
		public TooltipAttribute(string tooltip)
		{
			this.tooltip = tooltip;
		}

		// Token: 0x04000E83 RID: 3715
		public readonly string tooltip;
	}
}
