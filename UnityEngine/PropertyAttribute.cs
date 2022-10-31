using System;

namespace UnityEngine
{
	// Token: 0x020003BB RID: 955
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public abstract class PropertyAttribute : Attribute
	{
		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x0600325E RID: 12894 RVA: 0x0004D6C4 File Offset: 0x0004B8C4
		// (set) Token: 0x0600325F RID: 12895 RVA: 0x0004D6E0 File Offset: 0x0004B8E0
		public int order { get; set; }
	}
}
