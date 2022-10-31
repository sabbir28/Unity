using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x02000083 RID: 131
	public static class Clipping
	{
		// Token: 0x060004EC RID: 1260 RVA: 0x0001A394 File Offset: 0x00018794
		public static Rect FindCullAndClipWorldRect(List<RectMask2D> rectMaskParents, out bool validRect)
		{
			Rect result;
			if (rectMaskParents.Count == 0)
			{
				validRect = false;
				result = default(Rect);
			}
			else
			{
				Rect a = rectMaskParents[0].canvasRect;
				for (int i = 0; i < rectMaskParents.Count; i++)
				{
					a = Clipping.RectIntersect(a, rectMaskParents[i].canvasRect);
				}
				bool flag = a.width <= 0f || a.height <= 0f;
				if (flag)
				{
					validRect = false;
					result = default(Rect);
				}
				else
				{
					Vector3 vector = new Vector3(a.x, a.y, 0f);
					Vector3 vector2 = new Vector3(a.x + a.width, a.y + a.height, 0f);
					validRect = true;
					result = new Rect(vector.x, vector.y, vector2.x - vector.x, vector2.y - vector.y);
				}
			}
			return result;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0001A4B8 File Offset: 0x000188B8
		private static Rect RectIntersect(Rect a, Rect b)
		{
			float num = Mathf.Max(a.x, b.x);
			float num2 = Mathf.Min(a.x + a.width, b.x + b.width);
			float num3 = Mathf.Max(a.y, b.y);
			float num4 = Mathf.Min(a.y + a.height, b.y + b.height);
			Rect result;
			if (num2 >= num && num4 >= num3)
			{
				result = new Rect(num, num3, num2 - num, num4 - num3);
			}
			else
			{
				result = new Rect(0f, 0f, 0f, 0f);
			}
			return result;
		}
	}
}
