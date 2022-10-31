using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x0200009D RID: 157
	public static class LayoutUtility
	{
		// Token: 0x060005B8 RID: 1464 RVA: 0x0001CF34 File Offset: 0x0001B334
		public static float GetMinSize(RectTransform rect, int axis)
		{
			float result;
			if (axis == 0)
			{
				result = LayoutUtility.GetMinWidth(rect);
			}
			else
			{
				result = LayoutUtility.GetMinHeight(rect);
			}
			return result;
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0001CF64 File Offset: 0x0001B364
		public static float GetPreferredSize(RectTransform rect, int axis)
		{
			float result;
			if (axis == 0)
			{
				result = LayoutUtility.GetPreferredWidth(rect);
			}
			else
			{
				result = LayoutUtility.GetPreferredHeight(rect);
			}
			return result;
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0001CF94 File Offset: 0x0001B394
		public static float GetFlexibleSize(RectTransform rect, int axis)
		{
			float result;
			if (axis == 0)
			{
				result = LayoutUtility.GetFlexibleWidth(rect);
			}
			else
			{
				result = LayoutUtility.GetFlexibleHeight(rect);
			}
			return result;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0001CFC4 File Offset: 0x0001B3C4
		public static float GetMinWidth(RectTransform rect)
		{
			return LayoutUtility.GetLayoutProperty(rect, (ILayoutElement e) => e.minWidth, 0f);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0001D004 File Offset: 0x0001B404
		public static float GetPreferredWidth(RectTransform rect)
		{
			return Mathf.Max(LayoutUtility.GetLayoutProperty(rect, (ILayoutElement e) => e.minWidth, 0f), LayoutUtility.GetLayoutProperty(rect, (ILayoutElement e) => e.preferredWidth, 0f));
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0001D070 File Offset: 0x0001B470
		public static float GetFlexibleWidth(RectTransform rect)
		{
			return LayoutUtility.GetLayoutProperty(rect, (ILayoutElement e) => e.flexibleWidth, 0f);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0001D0B0 File Offset: 0x0001B4B0
		public static float GetMinHeight(RectTransform rect)
		{
			return LayoutUtility.GetLayoutProperty(rect, (ILayoutElement e) => e.minHeight, 0f);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0001D0F0 File Offset: 0x0001B4F0
		public static float GetPreferredHeight(RectTransform rect)
		{
			return Mathf.Max(LayoutUtility.GetLayoutProperty(rect, (ILayoutElement e) => e.minHeight, 0f), LayoutUtility.GetLayoutProperty(rect, (ILayoutElement e) => e.preferredHeight, 0f));
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0001D15C File Offset: 0x0001B55C
		public static float GetFlexibleHeight(RectTransform rect)
		{
			return LayoutUtility.GetLayoutProperty(rect, (ILayoutElement e) => e.flexibleHeight, 0f);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0001D19C File Offset: 0x0001B59C
		public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue)
		{
			ILayoutElement layoutElement;
			return LayoutUtility.GetLayoutProperty(rect, property, defaultValue, out layoutElement);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0001D1BC File Offset: 0x0001B5BC
		public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue, out ILayoutElement source)
		{
			source = null;
			float result;
			if (rect == null)
			{
				result = 0f;
			}
			else
			{
				float num = defaultValue;
				int num2 = int.MinValue;
				List<Component> list = ListPool<Component>.Get();
				rect.GetComponents(typeof(ILayoutElement), list);
				for (int i = 0; i < list.Count; i++)
				{
					ILayoutElement layoutElement = list[i] as ILayoutElement;
					if (!(layoutElement is Behaviour) || ((Behaviour)layoutElement).isActiveAndEnabled)
					{
						int layoutPriority = layoutElement.layoutPriority;
						if (layoutPriority >= num2)
						{
							float num3 = property(layoutElement);
							if (num3 >= 0f)
							{
								if (layoutPriority > num2)
								{
									num = num3;
									num2 = layoutPriority;
									source = layoutElement;
								}
								else if (num3 > num)
								{
									num = num3;
									source = layoutElement;
								}
							}
						}
					}
				}
				ListPool<Component>.Release(list);
				result = num;
			}
			return result;
		}
	}
}
