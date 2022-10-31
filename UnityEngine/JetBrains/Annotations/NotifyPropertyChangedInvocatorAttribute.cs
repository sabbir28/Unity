using System;

namespace JetBrains.Annotations
{
	// Token: 0x0200038C RID: 908
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
	public sealed class NotifyPropertyChangedInvocatorAttribute : Attribute
	{
		// Token: 0x06003129 RID: 12585 RVA: 0x0004AE1C File Offset: 0x0004901C
		public NotifyPropertyChangedInvocatorAttribute()
		{
		}

		// Token: 0x0600312A RID: 12586 RVA: 0x0004AE28 File Offset: 0x00049028
		public NotifyPropertyChangedInvocatorAttribute(string parameterName)
		{
			this.ParameterName = parameterName;
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x0600312B RID: 12587 RVA: 0x0004AE38 File Offset: 0x00049038
		// (set) Token: 0x0600312C RID: 12588 RVA: 0x0004AE54 File Offset: 0x00049054
		public string ParameterName { get; private set; }
	}
}
