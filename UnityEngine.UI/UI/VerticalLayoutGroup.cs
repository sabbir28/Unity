using System;

namespace UnityEngine.UI
{
	// Token: 0x0200009E RID: 158
	[AddComponentMenu("Layout/Vertical Layout Group", 151)]
	public class VerticalLayoutGroup : HorizontalOrVerticalLayoutGroup
	{
		// Token: 0x060005CB RID: 1483 RVA: 0x0001D39A File Offset: 0x0001B79A
		protected VerticalLayoutGroup()
		{
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0001D3A3 File Offset: 0x0001B7A3
		public override void CalculateLayoutInputHorizontal()
		{
			base.CalculateLayoutInputHorizontal();
			base.CalcAlongAxis(0, true);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x0001D3B4 File Offset: 0x0001B7B4
		public override void CalculateLayoutInputVertical()
		{
			base.CalcAlongAxis(1, true);
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0001D3BF File Offset: 0x0001B7BF
		public override void SetLayoutHorizontal()
		{
			base.SetChildrenAlongAxis(0, true);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0001D3CA File Offset: 0x0001B7CA
		public override void SetLayoutVertical()
		{
			base.SetChildrenAlongAxis(1, true);
		}
	}
}
