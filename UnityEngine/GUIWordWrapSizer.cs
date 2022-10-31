using System;

namespace UnityEngine
{
	// Token: 0x02000260 RID: 608
	internal sealed class GUIWordWrapSizer : GUILayoutEntry
	{
		// Token: 0x060028BF RID: 10431 RVA: 0x00034EF8 File Offset: 0x000330F8
		public GUIWordWrapSizer(GUIStyle style, GUIContent content, GUILayoutOption[] options) : base(0f, 0f, 0f, 0f, style)
		{
			this.m_Content = new GUIContent(content);
			this.ApplyOptions(options);
			this.m_ForcedMinHeight = this.minHeight;
			this.m_ForcedMaxHeight = this.maxHeight;
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x00034F4C File Offset: 0x0003314C
		public override void CalcWidth()
		{
			if (this.minWidth == 0f || this.maxWidth == 0f)
			{
				float minWidth;
				float maxWidth;
				base.style.CalcMinMaxWidth(this.m_Content, out minWidth, out maxWidth);
				if (this.minWidth == 0f)
				{
					this.minWidth = minWidth;
				}
				if (this.maxWidth == 0f)
				{
					this.maxWidth = maxWidth;
				}
			}
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x00034FC0 File Offset: 0x000331C0
		public override void CalcHeight()
		{
			if (this.m_ForcedMinHeight == 0f || this.m_ForcedMaxHeight == 0f)
			{
				float num = base.style.CalcHeight(this.m_Content, this.rect.width);
				if (this.m_ForcedMinHeight == 0f)
				{
					this.minHeight = num;
				}
				else
				{
					this.minHeight = this.m_ForcedMinHeight;
				}
				if (this.m_ForcedMaxHeight == 0f)
				{
					this.maxHeight = num;
				}
				else
				{
					this.maxHeight = this.m_ForcedMaxHeight;
				}
			}
		}

		// Token: 0x04000763 RID: 1891
		private readonly GUIContent m_Content;

		// Token: 0x04000764 RID: 1892
		private readonly float m_ForcedMinHeight;

		// Token: 0x04000765 RID: 1893
		private readonly float m_ForcedMaxHeight;
	}
}
