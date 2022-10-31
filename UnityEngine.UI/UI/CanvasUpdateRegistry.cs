using System;
using System.Runtime.CompilerServices;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	// Token: 0x0200003E RID: 62
	public class CanvasUpdateRegistry
	{
		// Token: 0x0600018C RID: 396 RVA: 0x00007CD5 File Offset: 0x000060D5
		protected CanvasUpdateRegistry()
		{
			Canvas.willRenderCanvases += this.PerformUpdate;
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00007D08 File Offset: 0x00006108
		public static CanvasUpdateRegistry instance
		{
			get
			{
				if (CanvasUpdateRegistry.s_Instance == null)
				{
					CanvasUpdateRegistry.s_Instance = new CanvasUpdateRegistry();
				}
				return CanvasUpdateRegistry.s_Instance;
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00007D38 File Offset: 0x00006138
		private bool ObjectValidForUpdate(ICanvasElement element)
		{
			bool result = element != null;
			bool flag = element is Object;
			if (flag)
			{
				result = (element as Object != null);
			}
			return result;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00007D74 File Offset: 0x00006174
		private void CleanInvalidItems()
		{
			for (int i = this.m_LayoutRebuildQueue.Count - 1; i >= 0; i--)
			{
				ICanvasElement canvasElement = this.m_LayoutRebuildQueue[i];
				if (canvasElement == null)
				{
					this.m_LayoutRebuildQueue.RemoveAt(i);
				}
				else if (canvasElement.IsDestroyed())
				{
					this.m_LayoutRebuildQueue.RemoveAt(i);
					canvasElement.LayoutComplete();
				}
			}
			for (int j = this.m_GraphicRebuildQueue.Count - 1; j >= 0; j--)
			{
				ICanvasElement canvasElement2 = this.m_GraphicRebuildQueue[j];
				if (canvasElement2 == null)
				{
					this.m_GraphicRebuildQueue.RemoveAt(j);
				}
				else if (canvasElement2.IsDestroyed())
				{
					this.m_GraphicRebuildQueue.RemoveAt(j);
					canvasElement2.GraphicUpdateComplete();
				}
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00007E4C File Offset: 0x0000624C
		private void PerformUpdate()
		{
			this.CleanInvalidItems();
			this.m_PerformingLayoutUpdate = true;
			this.m_LayoutRebuildQueue.Sort(CanvasUpdateRegistry.s_SortLayoutFunction);
			for (int i = 0; i <= 2; i++)
			{
				for (int j = 0; j < this.m_LayoutRebuildQueue.Count; j++)
				{
					ICanvasElement canvasElement = CanvasUpdateRegistry.instance.m_LayoutRebuildQueue[j];
					try
					{
						if (this.ObjectValidForUpdate(canvasElement))
						{
							canvasElement.Rebuild((CanvasUpdate)i);
						}
					}
					catch (Exception exception)
					{
						Debug.LogException(exception, canvasElement.transform);
					}
				}
			}
			for (int k = 0; k < this.m_LayoutRebuildQueue.Count; k++)
			{
				this.m_LayoutRebuildQueue[k].LayoutComplete();
			}
			CanvasUpdateRegistry.instance.m_LayoutRebuildQueue.Clear();
			this.m_PerformingLayoutUpdate = false;
			ClipperRegistry.instance.Cull();
			this.m_PerformingGraphicUpdate = true;
			for (int l = 3; l < 5; l++)
			{
				for (int m = 0; m < CanvasUpdateRegistry.instance.m_GraphicRebuildQueue.Count; m++)
				{
					try
					{
						ICanvasElement canvasElement2 = CanvasUpdateRegistry.instance.m_GraphicRebuildQueue[m];
						if (this.ObjectValidForUpdate(canvasElement2))
						{
							canvasElement2.Rebuild((CanvasUpdate)l);
						}
					}
					catch (Exception exception2)
					{
						Debug.LogException(exception2, CanvasUpdateRegistry.instance.m_GraphicRebuildQueue[m].transform);
					}
				}
			}
			for (int n = 0; n < this.m_GraphicRebuildQueue.Count; n++)
			{
				this.m_GraphicRebuildQueue[n].GraphicUpdateComplete();
			}
			CanvasUpdateRegistry.instance.m_GraphicRebuildQueue.Clear();
			this.m_PerformingGraphicUpdate = false;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000803C File Offset: 0x0000643C
		private static int ParentCount(Transform child)
		{
			int result;
			if (child == null)
			{
				result = 0;
			}
			else
			{
				Transform parent = child.parent;
				int num = 0;
				while (parent != null)
				{
					num++;
					parent = parent.parent;
				}
				result = num;
			}
			return result;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000808C File Offset: 0x0000648C
		private static int SortLayoutList(ICanvasElement x, ICanvasElement y)
		{
			Transform transform = x.transform;
			Transform transform2 = y.transform;
			return CanvasUpdateRegistry.ParentCount(transform) - CanvasUpdateRegistry.ParentCount(transform2);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000080BC File Offset: 0x000064BC
		public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			CanvasUpdateRegistry.instance.InternalRegisterCanvasElementForLayoutRebuild(element);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000080CC File Offset: 0x000064CC
		public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			return CanvasUpdateRegistry.instance.InternalRegisterCanvasElementForLayoutRebuild(element);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000080EC File Offset: 0x000064EC
		private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			return !this.m_LayoutRebuildQueue.Contains(element) && this.m_LayoutRebuildQueue.AddUnique(element);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00008125 File Offset: 0x00006525
		public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			CanvasUpdateRegistry.instance.InternalRegisterCanvasElementForGraphicRebuild(element);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00008134 File Offset: 0x00006534
		public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			return CanvasUpdateRegistry.instance.InternalRegisterCanvasElementForGraphicRebuild(element);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00008154 File Offset: 0x00006554
		private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			bool result;
			if (this.m_PerformingGraphicUpdate)
			{
				Debug.LogError(string.Format("Trying to add {0} for graphic rebuild while we are already inside a graphic rebuild loop. This is not supported.", element));
				result = false;
			}
			else
			{
				result = this.m_GraphicRebuildQueue.AddUnique(element);
			}
			return result;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00008198 File Offset: 0x00006598
		public static void UnRegisterCanvasElementForRebuild(ICanvasElement element)
		{
			CanvasUpdateRegistry.instance.InternalUnRegisterCanvasElementForLayoutRebuild(element);
			CanvasUpdateRegistry.instance.InternalUnRegisterCanvasElementForGraphicRebuild(element);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000081B1 File Offset: 0x000065B1
		private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			if (this.m_PerformingLayoutUpdate)
			{
				Debug.LogError(string.Format("Trying to remove {0} from rebuild list while we are already inside a rebuild loop. This is not supported.", element));
			}
			else
			{
				element.LayoutComplete();
				CanvasUpdateRegistry.instance.m_LayoutRebuildQueue.Remove(element);
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000081EC File Offset: 0x000065EC
		private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			if (this.m_PerformingGraphicUpdate)
			{
				Debug.LogError(string.Format("Trying to remove {0} from rebuild list while we are already inside a rebuild loop. This is not supported.", element));
			}
			else
			{
				element.GraphicUpdateComplete();
				CanvasUpdateRegistry.instance.m_GraphicRebuildQueue.Remove(element);
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00008228 File Offset: 0x00006628
		public static bool IsRebuildingLayout()
		{
			return CanvasUpdateRegistry.instance.m_PerformingLayoutUpdate;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00008248 File Offset: 0x00006648
		public static bool IsRebuildingGraphics()
		{
			return CanvasUpdateRegistry.instance.m_PerformingGraphicUpdate;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00008267 File Offset: 0x00006667
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasUpdateRegistry()
		{
			if (CanvasUpdateRegistry.<>f__mg$cache0 == null)
			{
				CanvasUpdateRegistry.<>f__mg$cache0 = new Comparison<ICanvasElement>(CanvasUpdateRegistry.SortLayoutList);
			}
			CanvasUpdateRegistry.s_SortLayoutFunction = CanvasUpdateRegistry.<>f__mg$cache0;
		}

		// Token: 0x040000C6 RID: 198
		private static CanvasUpdateRegistry s_Instance;

		// Token: 0x040000C7 RID: 199
		private bool m_PerformingLayoutUpdate;

		// Token: 0x040000C8 RID: 200
		private bool m_PerformingGraphicUpdate;

		// Token: 0x040000C9 RID: 201
		private readonly IndexedSet<ICanvasElement> m_LayoutRebuildQueue = new IndexedSet<ICanvasElement>();

		// Token: 0x040000CA RID: 202
		private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue = new IndexedSet<ICanvasElement>();

		// Token: 0x040000CB RID: 203
		private static readonly Comparison<ICanvasElement> s_SortLayoutFunction;

		// Token: 0x040000CC RID: 204
		[CompilerGenerated]
		private static Comparison<ICanvasElement> <>f__mg$cache0;
	}
}
