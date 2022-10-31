using System;

namespace UnityEngine.UI
{
	// Token: 0x02000095 RID: 149
	public interface ILayoutElement
	{
		// Token: 0x06000556 RID: 1366
		void CalculateLayoutInputHorizontal();

		// Token: 0x06000557 RID: 1367
		void CalculateLayoutInputVertical();

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000558 RID: 1368
		float minWidth { get; }

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000559 RID: 1369
		float preferredWidth { get; }

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600055A RID: 1370
		float flexibleWidth { get; }

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600055B RID: 1371
		float minHeight { get; }

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600055C RID: 1372
		float preferredHeight { get; }

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600055D RID: 1373
		float flexibleHeight { get; }

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600055E RID: 1374
		int layoutPriority { get; }
	}
}
