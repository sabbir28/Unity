using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000224 RID: 548
	[UsedByNativeCode]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class SplatPrototype
	{
		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x060024D9 RID: 9433 RVA: 0x0002A550 File Offset: 0x00028750
		// (set) Token: 0x060024DA RID: 9434 RVA: 0x0002A56C File Offset: 0x0002876C
		public Texture2D texture
		{
			get
			{
				return this.m_Texture;
			}
			set
			{
				this.m_Texture = value;
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x060024DB RID: 9435 RVA: 0x0002A578 File Offset: 0x00028778
		// (set) Token: 0x060024DC RID: 9436 RVA: 0x0002A594 File Offset: 0x00028794
		public Texture2D normalMap
		{
			get
			{
				return this.m_NormalMap;
			}
			set
			{
				this.m_NormalMap = value;
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x060024DD RID: 9437 RVA: 0x0002A5A0 File Offset: 0x000287A0
		// (set) Token: 0x060024DE RID: 9438 RVA: 0x0002A5BC File Offset: 0x000287BC
		public Vector2 tileSize
		{
			get
			{
				return this.m_TileSize;
			}
			set
			{
				this.m_TileSize = value;
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x060024DF RID: 9439 RVA: 0x0002A5C8 File Offset: 0x000287C8
		// (set) Token: 0x060024E0 RID: 9440 RVA: 0x0002A5E4 File Offset: 0x000287E4
		public Vector2 tileOffset
		{
			get
			{
				return this.m_TileOffset;
			}
			set
			{
				this.m_TileOffset = value;
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x060024E1 RID: 9441 RVA: 0x0002A5F0 File Offset: 0x000287F0
		// (set) Token: 0x060024E2 RID: 9442 RVA: 0x0002A62C File Offset: 0x0002882C
		public Color specular
		{
			get
			{
				return new Color(this.m_SpecularMetallic.x, this.m_SpecularMetallic.y, this.m_SpecularMetallic.z);
			}
			set
			{
				this.m_SpecularMetallic.x = value.r;
				this.m_SpecularMetallic.y = value.g;
				this.m_SpecularMetallic.z = value.b;
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x060024E3 RID: 9443 RVA: 0x0002A668 File Offset: 0x00028868
		// (set) Token: 0x060024E4 RID: 9444 RVA: 0x0002A688 File Offset: 0x00028888
		public float metallic
		{
			get
			{
				return this.m_SpecularMetallic.w;
			}
			set
			{
				this.m_SpecularMetallic.w = value;
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x060024E5 RID: 9445 RVA: 0x0002A698 File Offset: 0x00028898
		// (set) Token: 0x060024E6 RID: 9446 RVA: 0x0002A6B4 File Offset: 0x000288B4
		public float smoothness
		{
			get
			{
				return this.m_Smoothness;
			}
			set
			{
				this.m_Smoothness = value;
			}
		}

		// Token: 0x04000646 RID: 1606
		internal Texture2D m_Texture;

		// Token: 0x04000647 RID: 1607
		internal Texture2D m_NormalMap;

		// Token: 0x04000648 RID: 1608
		internal Vector2 m_TileSize = new Vector2(15f, 15f);

		// Token: 0x04000649 RID: 1609
		internal Vector2 m_TileOffset = new Vector2(0f, 0f);

		// Token: 0x0400064A RID: 1610
		internal Vector4 m_SpecularMetallic = new Vector4(0f, 0f, 0f, 0f);

		// Token: 0x0400064B RID: 1611
		internal float m_Smoothness = 0f;
	}
}
