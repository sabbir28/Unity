using System;

namespace JetBrains.Annotations
{
	// Token: 0x0200038A RID: 906
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
	public sealed class StringFormatMethodAttribute : Attribute
	{
		// Token: 0x06003125 RID: 12581 RVA: 0x0004ADDC File Offset: 0x00048FDC
		public StringFormatMethodAttribute(string formatParameterName)
		{
			this.FormatParameterName = formatParameterName;
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06003126 RID: 12582 RVA: 0x0004ADEC File Offset: 0x00048FEC
		// (set) Token: 0x06003127 RID: 12583 RVA: 0x0004AE08 File Offset: 0x00049008
		public string FormatParameterName { get; private set; }
	}
}
