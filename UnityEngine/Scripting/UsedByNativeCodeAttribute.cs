using System;

namespace UnityEngine.Scripting
{
	// Token: 0x0200043F RID: 1087
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, Inherited = false)]
	internal class UsedByNativeCodeAttribute : Attribute
	{
		// Token: 0x06003508 RID: 13576 RVA: 0x0005426C File Offset: 0x0005246C
		public UsedByNativeCodeAttribute()
		{
		}

		// Token: 0x06003509 RID: 13577 RVA: 0x00054278 File Offset: 0x00052478
		public UsedByNativeCodeAttribute(string name)
		{
			this.Name = name;
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x0600350A RID: 13578 RVA: 0x00054288 File Offset: 0x00052488
		// (set) Token: 0x0600350B RID: 13579 RVA: 0x000542A4 File Offset: 0x000524A4
		public string Name { get; set; }
	}
}
