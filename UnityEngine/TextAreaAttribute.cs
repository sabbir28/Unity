using System;

namespace UnityEngine
{
	// Token: 0x020003C2 RID: 962
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class TextAreaAttribute : PropertyAttribute
	{
		// Token: 0x06003268 RID: 12904 RVA: 0x0004D780 File Offset: 0x0004B980
		public TextAreaAttribute()
		{
			this.minLines = 3;
			this.maxLines = 3;
		}

		// Token: 0x06003269 RID: 12905 RVA: 0x0004D798 File Offset: 0x0004B998
		public TextAreaAttribute(int minLines, int maxLines)
		{
			this.minLines = minLines;
			this.maxLines = maxLines;
		}

		// Token: 0x04000E89 RID: 3721
		public readonly int minLines;

		// Token: 0x04000E8A RID: 3722
		public readonly int maxLines;
	}
}
