using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000238 RID: 568
	[UsedByNativeCode]
	public struct CharacterInfo
	{
		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06002607 RID: 9735 RVA: 0x0002B824 File Offset: 0x00029A24
		// (set) Token: 0x06002608 RID: 9736 RVA: 0x0002B840 File Offset: 0x00029A40
		public int advance
		{
			get
			{
				return (int)this.width;
			}
			set
			{
				this.width = (float)value;
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06002609 RID: 9737 RVA: 0x0002B84C File Offset: 0x00029A4C
		// (set) Token: 0x0600260A RID: 9738 RVA: 0x0002B870 File Offset: 0x00029A70
		public int glyphWidth
		{
			get
			{
				return (int)this.vert.width;
			}
			set
			{
				this.vert.width = (float)value;
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x0600260B RID: 9739 RVA: 0x0002B880 File Offset: 0x00029A80
		// (set) Token: 0x0600260C RID: 9740 RVA: 0x0002B8A4 File Offset: 0x00029AA4
		public int glyphHeight
		{
			get
			{
				return (int)(-(int)this.vert.height);
			}
			set
			{
				float height = this.vert.height;
				this.vert.height = (float)(-(float)value);
				this.vert.y = this.vert.y + (height - this.vert.height);
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x0600260D RID: 9741 RVA: 0x0002B8EC File Offset: 0x00029AEC
		// (set) Token: 0x0600260E RID: 9742 RVA: 0x0002B910 File Offset: 0x00029B10
		public int bearing
		{
			get
			{
				return (int)this.vert.x;
			}
			set
			{
				this.vert.x = (float)value;
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x0600260F RID: 9743 RVA: 0x0002B920 File Offset: 0x00029B20
		// (set) Token: 0x06002610 RID: 9744 RVA: 0x0002B950 File Offset: 0x00029B50
		public int minY
		{
			get
			{
				return (int)(this.vert.y + this.vert.height);
			}
			set
			{
				this.vert.height = (float)value - this.vert.y;
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06002611 RID: 9745 RVA: 0x0002B96C File Offset: 0x00029B6C
		// (set) Token: 0x06002612 RID: 9746 RVA: 0x0002B990 File Offset: 0x00029B90
		public int maxY
		{
			get
			{
				return (int)this.vert.y;
			}
			set
			{
				float y = this.vert.y;
				this.vert.y = (float)value;
				this.vert.height = this.vert.height + (y - this.vert.y);
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06002613 RID: 9747 RVA: 0x0002B9D8 File Offset: 0x00029BD8
		// (set) Token: 0x06002614 RID: 9748 RVA: 0x0002B9FC File Offset: 0x00029BFC
		public int minX
		{
			get
			{
				return (int)this.vert.x;
			}
			set
			{
				float x = this.vert.x;
				this.vert.x = (float)value;
				this.vert.width = this.vert.width + (x - this.vert.x);
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06002615 RID: 9749 RVA: 0x0002BA44 File Offset: 0x00029C44
		// (set) Token: 0x06002616 RID: 9750 RVA: 0x0002BA74 File Offset: 0x00029C74
		public int maxX
		{
			get
			{
				return (int)(this.vert.x + this.vert.width);
			}
			set
			{
				this.vert.width = (float)value - this.vert.x;
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06002617 RID: 9751 RVA: 0x0002BA90 File Offset: 0x00029C90
		// (set) Token: 0x06002618 RID: 9752 RVA: 0x0002BAC0 File Offset: 0x00029CC0
		internal Vector2 uvBottomLeftUnFlipped
		{
			get
			{
				return new Vector2(this.uv.x, this.uv.y);
			}
			set
			{
				Vector2 uvTopRightUnFlipped = this.uvTopRightUnFlipped;
				this.uv.x = value.x;
				this.uv.y = value.y;
				this.uv.width = uvTopRightUnFlipped.x - this.uv.x;
				this.uv.height = uvTopRightUnFlipped.y - this.uv.y;
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06002619 RID: 9753 RVA: 0x0002BB38 File Offset: 0x00029D38
		// (set) Token: 0x0600261A RID: 9754 RVA: 0x0002BB74 File Offset: 0x00029D74
		internal Vector2 uvBottomRightUnFlipped
		{
			get
			{
				return new Vector2(this.uv.x + this.uv.width, this.uv.y);
			}
			set
			{
				Vector2 uvTopRightUnFlipped = this.uvTopRightUnFlipped;
				this.uv.width = value.x - this.uv.x;
				this.uv.y = value.y;
				this.uv.height = uvTopRightUnFlipped.y - this.uv.y;
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x0600261B RID: 9755 RVA: 0x0002BBD8 File Offset: 0x00029DD8
		// (set) Token: 0x0600261C RID: 9756 RVA: 0x0002BC20 File Offset: 0x00029E20
		internal Vector2 uvTopRightUnFlipped
		{
			get
			{
				return new Vector2(this.uv.x + this.uv.width, this.uv.y + this.uv.height);
			}
			set
			{
				this.uv.width = value.x - this.uv.x;
				this.uv.height = value.y - this.uv.y;
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x0600261D RID: 9757 RVA: 0x0002BC60 File Offset: 0x00029E60
		// (set) Token: 0x0600261E RID: 9758 RVA: 0x0002BC9C File Offset: 0x00029E9C
		internal Vector2 uvTopLeftUnFlipped
		{
			get
			{
				return new Vector2(this.uv.x, this.uv.y + this.uv.height);
			}
			set
			{
				Vector2 uvTopRightUnFlipped = this.uvTopRightUnFlipped;
				this.uv.x = value.x;
				this.uv.height = value.y - this.uv.y;
				this.uv.width = uvTopRightUnFlipped.x - this.uv.x;
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x0600261F RID: 9759 RVA: 0x0002BD00 File Offset: 0x00029F00
		// (set) Token: 0x06002620 RID: 9760 RVA: 0x0002BD1C File Offset: 0x00029F1C
		public Vector2 uvBottomLeft
		{
			get
			{
				return this.uvBottomLeftUnFlipped;
			}
			set
			{
				this.uvBottomLeftUnFlipped = value;
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06002621 RID: 9761 RVA: 0x0002BD28 File Offset: 0x00029F28
		// (set) Token: 0x06002622 RID: 9762 RVA: 0x0002BD5C File Offset: 0x00029F5C
		public Vector2 uvBottomRight
		{
			get
			{
				return (!this.flipped) ? this.uvBottomRightUnFlipped : this.uvTopLeftUnFlipped;
			}
			set
			{
				if (this.flipped)
				{
					this.uvTopLeftUnFlipped = value;
				}
				else
				{
					this.uvBottomRightUnFlipped = value;
				}
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06002623 RID: 9763 RVA: 0x0002BD80 File Offset: 0x00029F80
		// (set) Token: 0x06002624 RID: 9764 RVA: 0x0002BD9C File Offset: 0x00029F9C
		public Vector2 uvTopRight
		{
			get
			{
				return this.uvTopRightUnFlipped;
			}
			set
			{
				this.uvTopRightUnFlipped = value;
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06002625 RID: 9765 RVA: 0x0002BDA8 File Offset: 0x00029FA8
		// (set) Token: 0x06002626 RID: 9766 RVA: 0x0002BDDC File Offset: 0x00029FDC
		public Vector2 uvTopLeft
		{
			get
			{
				return (!this.flipped) ? this.uvTopLeftUnFlipped : this.uvBottomRightUnFlipped;
			}
			set
			{
				if (this.flipped)
				{
					this.uvBottomRightUnFlipped = value;
				}
				else
				{
					this.uvTopLeftUnFlipped = value;
				}
			}
		}

		// Token: 0x040006A8 RID: 1704
		public int index;

		// Token: 0x040006A9 RID: 1705
		[Obsolete("CharacterInfo.uv is deprecated. Use uvBottomLeft, uvBottomRight, uvTopRight or uvTopLeft instead.")]
		public Rect uv;

		// Token: 0x040006AA RID: 1706
		[Obsolete("CharacterInfo.vert is deprecated. Use minX, maxX, minY, maxY instead.")]
		public Rect vert;

		// Token: 0x040006AB RID: 1707
		[Obsolete("CharacterInfo.width is deprecated. Use advance instead.")]
		public float width;

		// Token: 0x040006AC RID: 1708
		public int size;

		// Token: 0x040006AD RID: 1709
		public FontStyle style;

		// Token: 0x040006AE RID: 1710
		[Obsolete("CharacterInfo.flipped is deprecated. Use uvBottomLeft, uvBottomRight, uvTopRight or uvTopLeft instead, which will be correct regardless of orientation.")]
		public bool flipped;
	}
}
