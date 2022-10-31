using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200025C RID: 604
	internal sealed class GUIScrollGroup : GUILayoutGroup
	{
		// Token: 0x060028A8 RID: 10408 RVA: 0x00034020 File Offset: 0x00032220
		[RequiredByNativeCode]
		public GUIScrollGroup()
		{
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x00034038 File Offset: 0x00032238
		public override void CalcWidth()
		{
			float minWidth = this.minWidth;
			float maxWidth = this.maxWidth;
			if (this.allowHorizontalScroll)
			{
				this.minWidth = 0f;
				this.maxWidth = 0f;
			}
			base.CalcWidth();
			this.calcMinWidth = this.minWidth;
			this.calcMaxWidth = this.maxWidth;
			if (this.allowHorizontalScroll)
			{
				if (this.minWidth > 32f)
				{
					this.minWidth = 32f;
				}
				if (minWidth != 0f)
				{
					this.minWidth = minWidth;
				}
				if (maxWidth != 0f)
				{
					this.maxWidth = maxWidth;
					this.stretchWidth = 0;
				}
			}
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x000340EC File Offset: 0x000322EC
		public override void SetHorizontal(float x, float width)
		{
			float num = (!this.needsVerticalScrollbar) ? width : (width - this.verticalScrollbar.fixedWidth - (float)this.verticalScrollbar.margin.left);
			if (this.allowHorizontalScroll && num < this.calcMinWidth)
			{
				this.needsHorizontalScrollbar = true;
				this.minWidth = this.calcMinWidth;
				this.maxWidth = this.calcMaxWidth;
				base.SetHorizontal(x, this.calcMinWidth);
				this.rect.width = width;
				this.clientWidth = this.calcMinWidth;
			}
			else
			{
				this.needsHorizontalScrollbar = false;
				if (this.allowHorizontalScroll)
				{
					this.minWidth = this.calcMinWidth;
					this.maxWidth = this.calcMaxWidth;
				}
				base.SetHorizontal(x, num);
				this.rect.width = width;
				this.clientWidth = num;
			}
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x000341D8 File Offset: 0x000323D8
		public override void CalcHeight()
		{
			float minHeight = this.minHeight;
			float maxHeight = this.maxHeight;
			if (this.allowVerticalScroll)
			{
				this.minHeight = 0f;
				this.maxHeight = 0f;
			}
			base.CalcHeight();
			this.calcMinHeight = this.minHeight;
			this.calcMaxHeight = this.maxHeight;
			if (this.needsHorizontalScrollbar)
			{
				float num = this.horizontalScrollbar.fixedHeight + (float)this.horizontalScrollbar.margin.top;
				this.minHeight += num;
				this.maxHeight += num;
			}
			if (this.allowVerticalScroll)
			{
				if (this.minHeight > 32f)
				{
					this.minHeight = 32f;
				}
				if (minHeight != 0f)
				{
					this.minHeight = minHeight;
				}
				if (maxHeight != 0f)
				{
					this.maxHeight = maxHeight;
					this.stretchHeight = 0;
				}
			}
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x000342D4 File Offset: 0x000324D4
		public override void SetVertical(float y, float height)
		{
			float num = height;
			if (this.needsHorizontalScrollbar)
			{
				num -= this.horizontalScrollbar.fixedHeight + (float)this.horizontalScrollbar.margin.top;
			}
			if (this.allowVerticalScroll && num < this.calcMinHeight)
			{
				if (!this.needsHorizontalScrollbar && !this.needsVerticalScrollbar)
				{
					this.clientWidth = this.rect.width - this.verticalScrollbar.fixedWidth - (float)this.verticalScrollbar.margin.left;
					if (this.clientWidth < this.calcMinWidth)
					{
						this.clientWidth = this.calcMinWidth;
					}
					float width = this.rect.width;
					this.SetHorizontal(this.rect.x, this.clientWidth);
					this.CalcHeight();
					this.rect.width = width;
				}
				float minHeight = this.minHeight;
				float maxHeight = this.maxHeight;
				this.minHeight = this.calcMinHeight;
				this.maxHeight = this.calcMaxHeight;
				base.SetVertical(y, this.calcMinHeight);
				this.minHeight = minHeight;
				this.maxHeight = maxHeight;
				this.rect.height = height;
				this.clientHeight = this.calcMinHeight;
			}
			else
			{
				if (this.allowVerticalScroll)
				{
					this.minHeight = this.calcMinHeight;
					this.maxHeight = this.calcMaxHeight;
				}
				base.SetVertical(y, num);
				this.rect.height = height;
				this.clientHeight = num;
			}
		}

		// Token: 0x04000746 RID: 1862
		public float calcMinWidth;

		// Token: 0x04000747 RID: 1863
		public float calcMaxWidth;

		// Token: 0x04000748 RID: 1864
		public float calcMinHeight;

		// Token: 0x04000749 RID: 1865
		public float calcMaxHeight;

		// Token: 0x0400074A RID: 1866
		public float clientWidth;

		// Token: 0x0400074B RID: 1867
		public float clientHeight;

		// Token: 0x0400074C RID: 1868
		public bool allowHorizontalScroll = true;

		// Token: 0x0400074D RID: 1869
		public bool allowVerticalScroll = true;

		// Token: 0x0400074E RID: 1870
		public bool needsHorizontalScrollbar;

		// Token: 0x0400074F RID: 1871
		public bool needsVerticalScrollbar;

		// Token: 0x04000750 RID: 1872
		public GUIStyle horizontalScrollbar;

		// Token: 0x04000751 RID: 1873
		public GUIStyle verticalScrollbar;
	}
}
