using System;

namespace UnityEngine
{
	// Token: 0x020003C1 RID: 961
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class MultilineAttribute : PropertyAttribute
	{
		// Token: 0x06003266 RID: 12902 RVA: 0x0004D760 File Offset: 0x0004B960
		public MultilineAttribute()
		{
			this.lines = 3;
		}

		// Token: 0x06003267 RID: 12903 RVA: 0x0004D770 File Offset: 0x0004B970
		public MultilineAttribute(int lines)
		{
			this.lines = lines;
		}

		// Token: 0x04000E88 RID: 3720
		public readonly int lines;
	}
}
