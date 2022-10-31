using System;
using System.Collections.Generic;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	// Token: 0x0200004C RID: 76
	public class GraphicRegistry
	{
		// Token: 0x0600026A RID: 618 RVA: 0x0000C65C File Offset: 0x0000AA5C
		protected GraphicRegistry()
		{
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0000C67C File Offset: 0x0000AA7C
		public static GraphicRegistry instance
		{
			get
			{
				if (GraphicRegistry.s_Instance == null)
				{
					GraphicRegistry.s_Instance = new GraphicRegistry();
				}
				return GraphicRegistry.s_Instance;
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000C6AC File Offset: 0x0000AAAC
		public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic)
		{
			if (!(c == null))
			{
				IndexedSet<Graphic> indexedSet;
				GraphicRegistry.instance.m_Graphics.TryGetValue(c, out indexedSet);
				if (indexedSet != null)
				{
					indexedSet.AddUnique(graphic);
				}
				else
				{
					indexedSet = new IndexedSet<Graphic>();
					indexedSet.Add(graphic);
					GraphicRegistry.instance.m_Graphics.Add(c, indexedSet);
				}
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000C710 File Offset: 0x0000AB10
		public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic)
		{
			if (!(c == null))
			{
				IndexedSet<Graphic> indexedSet;
				if (GraphicRegistry.instance.m_Graphics.TryGetValue(c, out indexedSet))
				{
					indexedSet.Remove(graphic);
					if (indexedSet.Count == 0)
					{
						GraphicRegistry.instance.m_Graphics.Remove(c);
					}
				}
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000C76C File Offset: 0x0000AB6C
		public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas)
		{
			IndexedSet<Graphic> indexedSet;
			IList<Graphic> result;
			if (GraphicRegistry.instance.m_Graphics.TryGetValue(canvas, out indexedSet))
			{
				result = indexedSet;
			}
			else
			{
				result = GraphicRegistry.s_EmptyList;
			}
			return result;
		}

		// Token: 0x04000125 RID: 293
		private static GraphicRegistry s_Instance;

		// Token: 0x04000126 RID: 294
		private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics = new Dictionary<Canvas, IndexedSet<Graphic>>();

		// Token: 0x04000127 RID: 295
		private static readonly List<Graphic> s_EmptyList = new List<Graphic>();
	}
}
