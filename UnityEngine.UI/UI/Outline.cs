using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x020000AD RID: 173
	[AddComponentMenu("UI/Effects/Outline", 15)]
	public class Outline : Shadow
	{
		// Token: 0x0600061F RID: 1567 RVA: 0x0001E64B File Offset: 0x0001CA4B
		protected Outline()
		{
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0001E654 File Offset: 0x0001CA54
		public override void ModifyMesh(VertexHelper vh)
		{
			if (this.IsActive())
			{
				List<UIVertex> list = ListPool<UIVertex>.Get();
				vh.GetUIVertexStream(list);
				int num = list.Count * 5;
				if (list.Capacity < num)
				{
					list.Capacity = num;
				}
				int start = 0;
				int count = list.Count;
				base.ApplyShadowZeroAlloc(list, base.effectColor, start, list.Count, base.effectDistance.x, base.effectDistance.y);
				start = count;
				count = list.Count;
				base.ApplyShadowZeroAlloc(list, base.effectColor, start, list.Count, base.effectDistance.x, -base.effectDistance.y);
				start = count;
				count = list.Count;
				base.ApplyShadowZeroAlloc(list, base.effectColor, start, list.Count, -base.effectDistance.x, base.effectDistance.y);
				start = count;
				count = list.Count;
				base.ApplyShadowZeroAlloc(list, base.effectColor, start, list.Count, -base.effectDistance.x, -base.effectDistance.y);
				vh.Clear();
				vh.AddUIVertexTriangleStream(list);
				ListPool<UIVertex>.Release(list);
			}
		}
	}
}
