using System;

namespace UnityEngine.UI
{
	// Token: 0x02000086 RID: 134
	internal class RectangularVertexClipper
	{
		// Token: 0x060004F5 RID: 1269 RVA: 0x0001A59C File Offset: 0x0001899C
		public Rect GetCanvasRect(RectTransform t, Canvas c)
		{
			Rect result;
			if (c == null)
			{
				result = default(Rect);
			}
			else
			{
				t.GetWorldCorners(this.m_WorldCorners);
				Transform component = c.GetComponent<Transform>();
				for (int i = 0; i < 4; i++)
				{
					this.m_CanvasCorners[i] = component.InverseTransformPoint(this.m_WorldCorners[i]);
				}
				result = new Rect(this.m_CanvasCorners[0].x, this.m_CanvasCorners[0].y, this.m_CanvasCorners[2].x - this.m_CanvasCorners[0].x, this.m_CanvasCorners[2].y - this.m_CanvasCorners[0].y);
			}
			return result;
		}

		// Token: 0x04000257 RID: 599
		private readonly Vector3[] m_WorldCorners = new Vector3[4];

		// Token: 0x04000258 RID: 600
		private readonly Vector3[] m_CanvasCorners = new Vector3[4];
	}
}
