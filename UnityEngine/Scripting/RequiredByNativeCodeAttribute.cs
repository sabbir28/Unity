using System;

namespace UnityEngine.Scripting
{
	// Token: 0x02000440 RID: 1088
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, Inherited = false)]
	internal class RequiredByNativeCodeAttribute : Attribute
	{
		// Token: 0x0600350C RID: 13580 RVA: 0x000542B0 File Offset: 0x000524B0
		public RequiredByNativeCodeAttribute()
		{
		}

		// Token: 0x0600350D RID: 13581 RVA: 0x000542BC File Offset: 0x000524BC
		public RequiredByNativeCodeAttribute(string name)
		{
			this.Name = name;
		}

		// Token: 0x0600350E RID: 13582 RVA: 0x000542CC File Offset: 0x000524CC
		public RequiredByNativeCodeAttribute(bool optional)
		{
			this.Optional = optional;
		}

		// Token: 0x0600350F RID: 13583 RVA: 0x000542DC File Offset: 0x000524DC
		public RequiredByNativeCodeAttribute(string name, bool optional)
		{
			this.Name = name;
			this.Optional = optional;
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x06003510 RID: 13584 RVA: 0x000542F4 File Offset: 0x000524F4
		// (set) Token: 0x06003511 RID: 13585 RVA: 0x00054310 File Offset: 0x00052510
		public string Name { get; set; }

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x06003512 RID: 13586 RVA: 0x0005431C File Offset: 0x0005251C
		// (set) Token: 0x06003513 RID: 13587 RVA: 0x00054338 File Offset: 0x00052538
		public bool Optional { get; set; }
	}
}
