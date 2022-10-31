using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x020000AF RID: 175
	[AddComponentMenu("UI/Effects/Shadow", 14)]
	public class Shadow : BaseMeshEffect
	{
		// Token: 0x06000623 RID: 1571 RVA: 0x0001E348 File Offset: 0x0001C748
		protected Shadow()
		{
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x0001E398 File Offset: 0x0001C798
		// (set) Token: 0x06000625 RID: 1573 RVA: 0x0001E3B3 File Offset: 0x0001C7B3
		public Color effectColor
		{
			get
			{
				return this.m_EffectColor;
			}
			set
			{
				this.m_EffectColor = value;
				if (base.graphic != null)
				{
					base.graphic.SetVerticesDirty();
				}
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x0001E3DC File Offset: 0x0001C7DC
		// (set) Token: 0x06000627 RID: 1575 RVA: 0x0001E3F8 File Offset: 0x0001C7F8
		public Vector2 effectDistance
		{
			get
			{
				return this.m_EffectDistance;
			}
			set
			{
				if (value.x > 600f)
				{
					value.x = 600f;
				}
				if (value.x < -600f)
				{
					value.x = -600f;
				}
				if (value.y > 600f)
				{
					value.y = 600f;
				}
				if (value.y < -600f)
				{
					value.y = -600f;
				}
				if (!(this.m_EffectDistance == value))
				{
					this.m_EffectDistance = value;
					if (base.graphic != null)
					{
						base.graphic.SetVerticesDirty();
					}
				}
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x0001E4B4 File Offset: 0x0001C8B4
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x0001E4CF File Offset: 0x0001C8CF
		public bool useGraphicAlpha
		{
			get
			{
				return this.m_UseGraphicAlpha;
			}
			set
			{
				this.m_UseGraphicAlpha = value;
				if (base.graphic != null)
				{
					base.graphic.SetVerticesDirty();
				}
			}
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0001E4F8 File Offset: 0x0001C8F8
		protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y)
		{
			int num = verts.Count + end - start;
			if (verts.Capacity < num)
			{
				verts.Capacity = num;
			}
			for (int i = start; i < end; i++)
			{
				UIVertex uivertex = verts[i];
				verts.Add(uivertex);
				Vector3 position = uivertex.position;
				position.x += x;
				position.y += y;
				uivertex.position = position;
				Color32 color2 = color;
				if (this.m_UseGraphicAlpha)
				{
					color2.a = color2.a * verts[i].color.a / byte.MaxValue;
				}
				uivertex.color = color2;
				verts[i] = uivertex;
			}
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0001E5C3 File Offset: 0x0001C9C3
		protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y)
		{
			this.ApplyShadowZeroAlloc(verts, color, start, end, x, y);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0001E5D8 File Offset: 0x0001C9D8
		public override void ModifyMesh(VertexHelper vh)
		{
			if (this.IsActive())
			{
				List<UIVertex> list = ListPool<UIVertex>.Get();
				vh.GetUIVertexStream(list);
				this.ApplyShadow(list, this.effectColor, 0, list.Count, this.effectDistance.x, this.effectDistance.y);
				vh.Clear();
				vh.AddUIVertexTriangleStream(list);
				ListPool<UIVertex>.Release(list);
			}
		}

		// Token: 0x040002D6 RID: 726
		[SerializeField]
		private Color m_EffectColor = new Color(0f, 0f, 0f, 0.5f);

		// Token: 0x040002D7 RID: 727
		[SerializeField]
		private Vector2 m_EffectDistance = new Vector2(1f, -1f);

		// Token: 0x040002D8 RID: 728
		[SerializeField]
		private bool m_UseGraphicAlpha = true;

		// Token: 0x040002D9 RID: 729
		private const float kMaxEffectDistance = 600f;
	}
}
