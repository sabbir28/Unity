using System;

namespace UnityEngine
{
	// Token: 0x02000259 RID: 601
	public sealed class GUILayoutOption
	{
		// Token: 0x06002898 RID: 10392 RVA: 0x00032870 File Offset: 0x00030A70
		internal GUILayoutOption(GUILayoutOption.Type type, object value)
		{
			this.type = type;
			this.value = value;
		}

		// Token: 0x04000724 RID: 1828
		internal GUILayoutOption.Type type;

		// Token: 0x04000725 RID: 1829
		internal object value;

		// Token: 0x0200025A RID: 602
		internal enum Type
		{
			// Token: 0x04000727 RID: 1831
			fixedWidth,
			// Token: 0x04000728 RID: 1832
			fixedHeight,
			// Token: 0x04000729 RID: 1833
			minWidth,
			// Token: 0x0400072A RID: 1834
			maxWidth,
			// Token: 0x0400072B RID: 1835
			minHeight,
			// Token: 0x0400072C RID: 1836
			maxHeight,
			// Token: 0x0400072D RID: 1837
			stretchWidth,
			// Token: 0x0400072E RID: 1838
			stretchHeight,
			// Token: 0x0400072F RID: 1839
			alignStart,
			// Token: 0x04000730 RID: 1840
			alignMiddle,
			// Token: 0x04000731 RID: 1841
			alignEnd,
			// Token: 0x04000732 RID: 1842
			alignJustify,
			// Token: 0x04000733 RID: 1843
			equalSize,
			// Token: 0x04000734 RID: 1844
			spacing
		}
	}
}
