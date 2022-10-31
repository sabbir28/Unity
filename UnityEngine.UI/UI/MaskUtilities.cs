using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x02000064 RID: 100
	public class MaskUtilities
	{
		// Token: 0x0600036B RID: 875 RVA: 0x000140DC File Offset: 0x000124DC
		public static void Notify2DMaskStateChanged(Component mask)
		{
			List<Component> list = ListPool<Component>.Get();
			mask.GetComponentsInChildren<Component>(list);
			for (int i = 0; i < list.Count; i++)
			{
				if (!(list[i] == null) && !(list[i].gameObject == mask.gameObject))
				{
					IClippable clippable = list[i] as IClippable;
					if (clippable != null)
					{
						clippable.RecalculateClipping();
					}
				}
			}
			ListPool<Component>.Release(list);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00014164 File Offset: 0x00012564
		public static void NotifyStencilStateChanged(Component mask)
		{
			List<Component> list = ListPool<Component>.Get();
			mask.GetComponentsInChildren<Component>(list);
			for (int i = 0; i < list.Count; i++)
			{
				if (!(list[i] == null) && !(list[i].gameObject == mask.gameObject))
				{
					IMaskable maskable = list[i] as IMaskable;
					if (maskable != null)
					{
						maskable.RecalculateMasking();
					}
				}
			}
			ListPool<Component>.Release(list);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x000141EC File Offset: 0x000125EC
		public static Transform FindRootSortOverrideCanvas(Transform start)
		{
			List<Canvas> list = ListPool<Canvas>.Get();
			start.GetComponentsInParent<Canvas>(false, list);
			Canvas canvas = null;
			for (int i = 0; i < list.Count; i++)
			{
				canvas = list[i];
				if (canvas.overrideSorting)
				{
					break;
				}
			}
			ListPool<Canvas>.Release(list);
			return (!(canvas != null)) ? null : canvas.transform;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00014260 File Offset: 0x00012660
		public static int GetStencilDepth(Transform transform, Transform stopAfter)
		{
			int num = 0;
			int result;
			if (transform == stopAfter)
			{
				result = num;
			}
			else
			{
				Transform parent = transform.parent;
				List<Mask> list = ListPool<Mask>.Get();
				while (parent != null)
				{
					parent.GetComponents<Mask>(list);
					for (int i = 0; i < list.Count; i++)
					{
						if (list[i] != null && list[i].MaskEnabled() && list[i].graphic.IsActive())
						{
							num++;
							break;
						}
					}
					if (parent == stopAfter)
					{
						break;
					}
					parent = parent.parent;
				}
				ListPool<Mask>.Release(list);
				result = num;
			}
			return result;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00014334 File Offset: 0x00012734
		public static bool IsDescendantOrSelf(Transform father, Transform child)
		{
			bool result;
			if (father == null || child == null)
			{
				result = false;
			}
			else if (father == child)
			{
				result = true;
			}
			else
			{
				while (child.parent != null)
				{
					if (child.parent == father)
					{
						return true;
					}
					child = child.parent;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x000143B4 File Offset: 0x000127B4
		public static RectMask2D GetRectMaskForClippable(IClippable clippable)
		{
			List<RectMask2D> list = ListPool<RectMask2D>.Get();
			List<Canvas> list2 = ListPool<Canvas>.Get();
			RectMask2D rectMask2D = null;
			clippable.rectTransform.GetComponentsInParent<RectMask2D>(false, list);
			if (list.Count > 0)
			{
				for (int i = 0; i < list.Count; i++)
				{
					rectMask2D = list[i];
					if (rectMask2D.gameObject == clippable.gameObject)
					{
						rectMask2D = null;
					}
					else
					{
						if (rectMask2D.isActiveAndEnabled)
						{
							clippable.rectTransform.GetComponentsInParent<Canvas>(false, list2);
							for (int j = list2.Count - 1; j >= 0; j--)
							{
								if (!MaskUtilities.IsDescendantOrSelf(list2[j].transform, rectMask2D.transform) && list2[j].overrideSorting)
								{
									rectMask2D = null;
									break;
								}
							}
							return rectMask2D;
						}
						rectMask2D = null;
					}
				}
			}
			ListPool<RectMask2D>.Release(list);
			ListPool<Canvas>.Release(list2);
			return rectMask2D;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x000144C0 File Offset: 0x000128C0
		public static void GetRectMasksForClip(RectMask2D clipper, List<RectMask2D> masks)
		{
			masks.Clear();
			List<Canvas> list = ListPool<Canvas>.Get();
			List<RectMask2D> list2 = ListPool<RectMask2D>.Get();
			clipper.transform.GetComponentsInParent<RectMask2D>(false, list2);
			if (list2.Count > 0)
			{
				clipper.transform.GetComponentsInParent<Canvas>(false, list);
				for (int i = list2.Count - 1; i >= 0; i--)
				{
					if (list2[i].IsActive())
					{
						bool flag = true;
						for (int j = list.Count - 1; j >= 0; j--)
						{
							if (!MaskUtilities.IsDescendantOrSelf(list[j].transform, list2[i].transform) && list[j].overrideSorting)
							{
								flag = false;
								break;
							}
						}
						if (flag)
						{
							masks.Add(list2[i]);
						}
					}
				}
			}
			ListPool<RectMask2D>.Release(list2);
			ListPool<Canvas>.Release(list);
		}
	}
}
