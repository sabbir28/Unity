using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	// Token: 0x0200009C RID: 156
	public class LayoutRebuilder : ICanvasElement
	{
		// Token: 0x0600059D RID: 1437 RVA: 0x0001C982 File Offset: 0x0001AD82
		static LayoutRebuilder()
		{
			if (LayoutRebuilder.<>f__mg$cache0 == null)
			{
				LayoutRebuilder.<>f__mg$cache0 = new RectTransform.ReapplyDrivenProperties(LayoutRebuilder.ReapplyDrivenProperties);
			}
			RectTransform.reapplyDrivenProperties += LayoutRebuilder.<>f__mg$cache0;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0001C9C6 File Offset: 0x0001ADC6
		private void Initialize(RectTransform controller)
		{
			this.m_ToRebuild = controller;
			this.m_CachedHashFromTransform = controller.GetHashCode();
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0001C9DC File Offset: 0x0001ADDC
		private void Clear()
		{
			this.m_ToRebuild = null;
			this.m_CachedHashFromTransform = 0;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0001C9ED File Offset: 0x0001ADED
		private static void ReapplyDrivenProperties(RectTransform driven)
		{
			LayoutRebuilder.MarkLayoutForRebuild(driven);
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0001C9F8 File Offset: 0x0001ADF8
		public Transform transform
		{
			get
			{
				return this.m_ToRebuild;
			}
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0001CA14 File Offset: 0x0001AE14
		public bool IsDestroyed()
		{
			return this.m_ToRebuild == null;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0001CA35 File Offset: 0x0001AE35
		private static void StripDisabledBehavioursFromList(List<Component> components)
		{
			components.RemoveAll((Component e) => e is Behaviour && !((Behaviour)e).isActiveAndEnabled);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0001CA5C File Offset: 0x0001AE5C
		public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot)
		{
			LayoutRebuilder layoutRebuilder = LayoutRebuilder.s_Rebuilders.Get();
			layoutRebuilder.Initialize(layoutRoot);
			layoutRebuilder.Rebuild(CanvasUpdate.Layout);
			LayoutRebuilder.s_Rebuilders.Release(layoutRebuilder);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0001CA90 File Offset: 0x0001AE90
		public void Rebuild(CanvasUpdate executing)
		{
			if (executing == CanvasUpdate.Layout)
			{
				this.PerformLayoutCalculation(this.m_ToRebuild, delegate(Component e)
				{
					(e as ILayoutElement).CalculateLayoutInputHorizontal();
				});
				this.PerformLayoutControl(this.m_ToRebuild, delegate(Component e)
				{
					(e as ILayoutController).SetLayoutHorizontal();
				});
				this.PerformLayoutCalculation(this.m_ToRebuild, delegate(Component e)
				{
					(e as ILayoutElement).CalculateLayoutInputVertical();
				});
				this.PerformLayoutControl(this.m_ToRebuild, delegate(Component e)
				{
					(e as ILayoutController).SetLayoutVertical();
				});
			}
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0001CB54 File Offset: 0x0001AF54
		private void PerformLayoutControl(RectTransform rect, UnityAction<Component> action)
		{
			if (!(rect == null))
			{
				List<Component> list = ListPool<Component>.Get();
				rect.GetComponents(typeof(ILayoutController), list);
				LayoutRebuilder.StripDisabledBehavioursFromList(list);
				if (list.Count > 0)
				{
					for (int i = 0; i < list.Count; i++)
					{
						if (list[i] is ILayoutSelfController)
						{
							action(list[i]);
						}
					}
					for (int j = 0; j < list.Count; j++)
					{
						if (!(list[j] is ILayoutSelfController))
						{
							action(list[j]);
						}
					}
					for (int k = 0; k < rect.childCount; k++)
					{
						this.PerformLayoutControl(rect.GetChild(k) as RectTransform, action);
					}
				}
				ListPool<Component>.Release(list);
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0001CC38 File Offset: 0x0001B038
		private void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action)
		{
			if (!(rect == null))
			{
				List<Component> list = ListPool<Component>.Get();
				rect.GetComponents(typeof(ILayoutElement), list);
				LayoutRebuilder.StripDisabledBehavioursFromList(list);
				if (list.Count > 0 || rect.GetComponent(typeof(ILayoutGroup)))
				{
					for (int i = 0; i < rect.childCount; i++)
					{
						this.PerformLayoutCalculation(rect.GetChild(i) as RectTransform, action);
					}
					for (int j = 0; j < list.Count; j++)
					{
						action(list[j]);
					}
				}
				ListPool<Component>.Release(list);
			}
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0001CCF0 File Offset: 0x0001B0F0
		public static void MarkLayoutForRebuild(RectTransform rect)
		{
			if (!(rect == null))
			{
				List<Component> list = ListPool<Component>.Get();
				RectTransform rectTransform = rect;
				for (;;)
				{
					RectTransform rectTransform2 = rectTransform.parent as RectTransform;
					if (!LayoutRebuilder.ValidLayoutGroup(rectTransform2, list))
					{
						break;
					}
					rectTransform = rectTransform2;
				}
				if (rectTransform == rect && !LayoutRebuilder.ValidController(rectTransform, list))
				{
					ListPool<Component>.Release(list);
				}
				else
				{
					LayoutRebuilder.MarkLayoutRootForRebuild(rectTransform);
					ListPool<Component>.Release(list);
				}
			}
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0001CD70 File Offset: 0x0001B170
		private static bool ValidLayoutGroup(RectTransform parent, List<Component> comps)
		{
			bool result;
			if (parent == null)
			{
				result = false;
			}
			else
			{
				parent.GetComponents(typeof(ILayoutGroup), comps);
				LayoutRebuilder.StripDisabledBehavioursFromList(comps);
				bool flag = comps.Count > 0;
				result = flag;
			}
			return result;
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0001CDBC File Offset: 0x0001B1BC
		private static bool ValidController(RectTransform layoutRoot, List<Component> comps)
		{
			bool result;
			if (layoutRoot == null)
			{
				result = false;
			}
			else
			{
				layoutRoot.GetComponents(typeof(ILayoutController), comps);
				LayoutRebuilder.StripDisabledBehavioursFromList(comps);
				bool flag = comps.Count > 0;
				result = flag;
			}
			return result;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0001CE08 File Offset: 0x0001B208
		private static void MarkLayoutRootForRebuild(RectTransform controller)
		{
			if (!(controller == null))
			{
				LayoutRebuilder layoutRebuilder = LayoutRebuilder.s_Rebuilders.Get();
				layoutRebuilder.Initialize(controller);
				if (!CanvasUpdateRegistry.TryRegisterCanvasElementForLayoutRebuild(layoutRebuilder))
				{
					LayoutRebuilder.s_Rebuilders.Release(layoutRebuilder);
				}
			}
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0001CE4F File Offset: 0x0001B24F
		public void LayoutComplete()
		{
			LayoutRebuilder.s_Rebuilders.Release(this);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0001CE5D File Offset: 0x0001B25D
		public void GraphicUpdateComplete()
		{
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0001CE60 File Offset: 0x0001B260
		public override int GetHashCode()
		{
			return this.m_CachedHashFromTransform;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0001CE7C File Offset: 0x0001B27C
		public override bool Equals(object obj)
		{
			return obj.GetHashCode() == this.GetHashCode();
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0001CEA0 File Offset: 0x0001B2A0
		public override string ToString()
		{
			return "(Layout Rebuilder for) " + this.m_ToRebuild;
		}

		// Token: 0x040002AD RID: 685
		private RectTransform m_ToRebuild;

		// Token: 0x040002AE RID: 686
		private int m_CachedHashFromTransform;

		// Token: 0x040002AF RID: 687
		private static ObjectPool<LayoutRebuilder> s_Rebuilders = new ObjectPool<LayoutRebuilder>(null, delegate(LayoutRebuilder x)
		{
			x.Clear();
		});

		// Token: 0x040002B0 RID: 688
		[CompilerGenerated]
		private static RectTransform.ReapplyDrivenProperties <>f__mg$cache0;
	}
}
