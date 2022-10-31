using System;

namespace UnityEngine
{
	// Token: 0x02000310 RID: 784
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public sealed class CreateAssetMenuAttribute : Attribute
	{
		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06003096 RID: 12438 RVA: 0x00049270 File Offset: 0x00047470
		// (set) Token: 0x06003097 RID: 12439 RVA: 0x0004928C File Offset: 0x0004748C
		public string menuName { get; set; }

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06003098 RID: 12440 RVA: 0x00049298 File Offset: 0x00047498
		// (set) Token: 0x06003099 RID: 12441 RVA: 0x000492B4 File Offset: 0x000474B4
		public string fileName { get; set; }

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x0600309A RID: 12442 RVA: 0x000492C0 File Offset: 0x000474C0
		// (set) Token: 0x0600309B RID: 12443 RVA: 0x000492DC File Offset: 0x000474DC
		public int order { get; set; }
	}
}
