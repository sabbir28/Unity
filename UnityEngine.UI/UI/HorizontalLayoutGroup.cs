using System;

namespace UnityEngine.UI
{
	// Token: 0x02000093 RID: 147
	[AddComponentMenu("Layout/Horizontal Layout Group", 150)]
	public class HorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup
	{
		// Token: 0x06000543 RID: 1347 RVA: 0x0001C6E6 File Offset: 0x0001AAE6
		protected HorizontalLayoutGroup()
		{
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0001C6EF File Offset: 0x0001AAEF
		public override void CalculateLayoutInputHorizontal()
		{
			base.CalculateLayoutInputHorizontal();
			base.CalcAlongAxis(0, false);
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0001C700 File Offset: 0x0001AB00
		public override void CalculateLayoutInputVertical()
		{
			base.CalcAlongAxis(1, false);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0001C70B File Offset: 0x0001AB0B
		public override void SetLayoutHorizontal()
		{
			base.SetChildrenAlongAxis(0, false);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0001C716 File Offset: 0x0001AB16
		public override void SetLayoutVertical()
		{
			base.SetChildrenAlongAxis(1, false);
		}
	}
}
