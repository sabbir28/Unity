using System;

namespace UnityEngine
{
	// Token: 0x02000230 RID: 560
	public struct TextGenerationSettings
	{
		// Token: 0x060025A7 RID: 9639 RVA: 0x0002AF80 File Offset: 0x00029180
		private bool CompareColors(Color left, Color right)
		{
			return Mathf.Approximately(left.r, right.r) && Mathf.Approximately(left.g, right.g) && Mathf.Approximately(left.b, right.b) && Mathf.Approximately(left.a, right.a);
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x0002AFF4 File Offset: 0x000291F4
		private bool CompareVector2(Vector2 left, Vector2 right)
		{
			return Mathf.Approximately(left.x, right.x) && Mathf.Approximately(left.y, right.y);
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x0002B038 File Offset: 0x00029238
		public bool Equals(TextGenerationSettings other)
		{
			return this.CompareColors(this.color, other.color) && this.fontSize == other.fontSize && Mathf.Approximately(this.scaleFactor, other.scaleFactor) && this.resizeTextMinSize == other.resizeTextMinSize && this.resizeTextMaxSize == other.resizeTextMaxSize && Mathf.Approximately(this.lineSpacing, other.lineSpacing) && this.fontStyle == other.fontStyle && this.richText == other.richText && this.textAnchor == other.textAnchor && this.alignByGeometry == other.alignByGeometry && this.resizeTextForBestFit == other.resizeTextForBestFit && this.resizeTextMinSize == other.resizeTextMinSize && this.resizeTextMaxSize == other.resizeTextMaxSize && this.resizeTextForBestFit == other.resizeTextForBestFit && this.updateBounds == other.updateBounds && this.horizontalOverflow == other.horizontalOverflow && this.verticalOverflow == other.verticalOverflow && this.CompareVector2(this.generationExtents, other.generationExtents) && this.CompareVector2(this.pivot, other.pivot) && this.font == other.font;
		}

		// Token: 0x04000677 RID: 1655
		public Font font;

		// Token: 0x04000678 RID: 1656
		public Color color;

		// Token: 0x04000679 RID: 1657
		public int fontSize;

		// Token: 0x0400067A RID: 1658
		public float lineSpacing;

		// Token: 0x0400067B RID: 1659
		public bool richText;

		// Token: 0x0400067C RID: 1660
		public float scaleFactor;

		// Token: 0x0400067D RID: 1661
		public FontStyle fontStyle;

		// Token: 0x0400067E RID: 1662
		public TextAnchor textAnchor;

		// Token: 0x0400067F RID: 1663
		public bool alignByGeometry;

		// Token: 0x04000680 RID: 1664
		public bool resizeTextForBestFit;

		// Token: 0x04000681 RID: 1665
		public int resizeTextMinSize;

		// Token: 0x04000682 RID: 1666
		public int resizeTextMaxSize;

		// Token: 0x04000683 RID: 1667
		public bool updateBounds;

		// Token: 0x04000684 RID: 1668
		public VerticalWrapMode verticalOverflow;

		// Token: 0x04000685 RID: 1669
		public HorizontalWrapMode horizontalOverflow;

		// Token: 0x04000686 RID: 1670
		public Vector2 generationExtents;

		// Token: 0x04000687 RID: 1671
		public Vector2 pivot;

		// Token: 0x04000688 RID: 1672
		public bool generateOutOfBounds;
	}
}
