using System;

namespace UnityEngine
{
	// Token: 0x0200025D RID: 605
	internal class GUILayoutEntry
	{
		// Token: 0x060028AD RID: 10413 RVA: 0x00034464 File Offset: 0x00032664
		public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style)
		{
			this.minWidth = _minWidth;
			this.maxWidth = _maxWidth;
			this.minHeight = _minHeight;
			this.maxHeight = _maxHeight;
			if (_style == null)
			{
				_style = GUIStyle.none;
			}
			this.style = _style;
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x000344D8 File Offset: 0x000326D8
		public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options)
		{
			this.minWidth = _minWidth;
			this.maxWidth = _maxWidth;
			this.minHeight = _minHeight;
			this.maxHeight = _maxHeight;
			this.style = _style;
			this.ApplyOptions(options);
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x060028AF RID: 10415 RVA: 0x00034544 File Offset: 0x00032744
		// (set) Token: 0x060028B0 RID: 10416 RVA: 0x00034560 File Offset: 0x00032760
		public GUIStyle style
		{
			get
			{
				return this.m_Style;
			}
			set
			{
				this.m_Style = value;
				this.ApplyStyleSettings(value);
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x060028B1 RID: 10417 RVA: 0x00034574 File Offset: 0x00032774
		public virtual RectOffset margin
		{
			get
			{
				return this.style.margin;
			}
		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x00034594 File Offset: 0x00032794
		public virtual void CalcWidth()
		{
		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x00034598 File Offset: 0x00032798
		public virtual void CalcHeight()
		{
		}

		// Token: 0x060028B4 RID: 10420 RVA: 0x0003459C File Offset: 0x0003279C
		public virtual void SetHorizontal(float x, float width)
		{
			this.rect.x = x;
			this.rect.width = width;
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x000345B8 File Offset: 0x000327B8
		public virtual void SetVertical(float y, float height)
		{
			this.rect.y = y;
			this.rect.height = height;
		}

		// Token: 0x060028B6 RID: 10422 RVA: 0x000345D4 File Offset: 0x000327D4
		protected virtual void ApplyStyleSettings(GUIStyle style)
		{
			this.stretchWidth = ((style.fixedWidth != 0f || !style.stretchWidth) ? 0 : 1);
			this.stretchHeight = ((style.fixedHeight != 0f || !style.stretchHeight) ? 0 : 1);
			this.m_Style = style;
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x0003463C File Offset: 0x0003283C
		public virtual void ApplyOptions(GUILayoutOption[] options)
		{
			if (options != null)
			{
				foreach (GUILayoutOption guilayoutOption in options)
				{
					switch (guilayoutOption.type)
					{
					case GUILayoutOption.Type.fixedWidth:
						this.minWidth = (this.maxWidth = (float)guilayoutOption.value);
						this.stretchWidth = 0;
						break;
					case GUILayoutOption.Type.fixedHeight:
						this.minHeight = (this.maxHeight = (float)guilayoutOption.value);
						this.stretchHeight = 0;
						break;
					case GUILayoutOption.Type.minWidth:
						this.minWidth = (float)guilayoutOption.value;
						if (this.maxWidth < this.minWidth)
						{
							this.maxWidth = this.minWidth;
						}
						break;
					case GUILayoutOption.Type.maxWidth:
						this.maxWidth = (float)guilayoutOption.value;
						if (this.minWidth > this.maxWidth)
						{
							this.minWidth = this.maxWidth;
						}
						this.stretchWidth = 0;
						break;
					case GUILayoutOption.Type.minHeight:
						this.minHeight = (float)guilayoutOption.value;
						if (this.maxHeight < this.minHeight)
						{
							this.maxHeight = this.minHeight;
						}
						break;
					case GUILayoutOption.Type.maxHeight:
						this.maxHeight = (float)guilayoutOption.value;
						if (this.minHeight > this.maxHeight)
						{
							this.minHeight = this.maxHeight;
						}
						this.stretchHeight = 0;
						break;
					case GUILayoutOption.Type.stretchWidth:
						this.stretchWidth = (int)guilayoutOption.value;
						break;
					case GUILayoutOption.Type.stretchHeight:
						this.stretchHeight = (int)guilayoutOption.value;
						break;
					}
				}
				if (this.maxWidth != 0f && this.maxWidth < this.minWidth)
				{
					this.maxWidth = this.minWidth;
				}
				if (this.maxHeight != 0f && this.maxHeight < this.minHeight)
				{
					this.maxHeight = this.minHeight;
				}
			}
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x00034854 File Offset: 0x00032A54
		public override string ToString()
		{
			string text = "";
			for (int i = 0; i < GUILayoutEntry.indent; i++)
			{
				text += " ";
			}
			return string.Concat(new object[]
			{
				text,
				UnityString.Format("{1}-{0} (x:{2}-{3}, y:{4}-{5})", new object[]
				{
					(this.style == null) ? "NULL" : this.style.name,
					base.GetType(),
					this.rect.x,
					this.rect.xMax,
					this.rect.y,
					this.rect.yMax
				}),
				"   -   W: ",
				this.minWidth,
				"-",
				this.maxWidth,
				(this.stretchWidth == 0) ? "" : "+",
				", H: ",
				this.minHeight,
				"-",
				this.maxHeight,
				(this.stretchHeight == 0) ? "" : "+"
			});
		}

		// Token: 0x04000752 RID: 1874
		public float minWidth;

		// Token: 0x04000753 RID: 1875
		public float maxWidth;

		// Token: 0x04000754 RID: 1876
		public float minHeight;

		// Token: 0x04000755 RID: 1877
		public float maxHeight;

		// Token: 0x04000756 RID: 1878
		public Rect rect = new Rect(0f, 0f, 0f, 0f);

		// Token: 0x04000757 RID: 1879
		public int stretchWidth;

		// Token: 0x04000758 RID: 1880
		public int stretchHeight;

		// Token: 0x04000759 RID: 1881
		private GUIStyle m_Style = GUIStyle.none;

		// Token: 0x0400075A RID: 1882
		internal static Rect kDummyRect = new Rect(0f, 0f, 1f, 1f);

		// Token: 0x0400075B RID: 1883
		protected static int indent = 0;
	}
}
