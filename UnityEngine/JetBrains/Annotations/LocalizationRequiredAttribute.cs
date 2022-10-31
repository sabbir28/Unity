using System;

namespace JetBrains.Annotations
{
	// Token: 0x0200038E RID: 910
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class LocalizationRequiredAttribute : Attribute
	{
		// Token: 0x06003133 RID: 12595 RVA: 0x0004AED4 File Offset: 0x000490D4
		public LocalizationRequiredAttribute() : this(true)
		{
		}

		// Token: 0x06003134 RID: 12596 RVA: 0x0004AEE0 File Offset: 0x000490E0
		public LocalizationRequiredAttribute(bool required)
		{
			this.Required = required;
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06003135 RID: 12597 RVA: 0x0004AEF0 File Offset: 0x000490F0
		// (set) Token: 0x06003136 RID: 12598 RVA: 0x0004AF0C File Offset: 0x0004910C
		public bool Required { get; private set; }
	}
}
