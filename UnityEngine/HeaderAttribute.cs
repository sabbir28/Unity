using System;

namespace UnityEngine
{
	// Token: 0x020003BF RID: 959
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
	public class HeaderAttribute : PropertyAttribute
	{
		// Token: 0x06003264 RID: 12900 RVA: 0x0004D738 File Offset: 0x0004B938
		public HeaderAttribute(string header)
		{
			this.header = header;
		}

		// Token: 0x04000E85 RID: 3717
		public readonly string header;
	}
}
