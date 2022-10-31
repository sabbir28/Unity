using System;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000047 RID: 71
	[Serializable]
	public class FontData : ISerializationCallbackReceiver
	{
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000206 RID: 518 RVA: 0x0000AC54 File Offset: 0x00009054
		public static FontData defaultFontData
		{
			get
			{
				return new FontData
				{
					m_FontSize = 14,
					m_LineSpacing = 1f,
					m_FontStyle = FontStyle.Normal,
					m_BestFit = false,
					m_MinSize = 10,
					m_MaxSize = 40,
					m_Alignment = TextAnchor.UpperLeft,
					m_HorizontalOverflow = HorizontalWrapMode.Wrap,
					m_VerticalOverflow = VerticalWrapMode.Truncate,
					m_RichText = true,
					m_AlignByGeometry = false
				};
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0000ACC8 File Offset: 0x000090C8
		// (set) Token: 0x06000208 RID: 520 RVA: 0x0000ACE3 File Offset: 0x000090E3
		public Font font
		{
			get
			{
				return this.m_Font;
			}
			set
			{
				this.m_Font = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000209 RID: 521 RVA: 0x0000ACF0 File Offset: 0x000090F0
		// (set) Token: 0x0600020A RID: 522 RVA: 0x0000AD0B File Offset: 0x0000910B
		public int fontSize
		{
			get
			{
				return this.m_FontSize;
			}
			set
			{
				this.m_FontSize = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600020B RID: 523 RVA: 0x0000AD18 File Offset: 0x00009118
		// (set) Token: 0x0600020C RID: 524 RVA: 0x0000AD33 File Offset: 0x00009133
		public FontStyle fontStyle
		{
			get
			{
				return this.m_FontStyle;
			}
			set
			{
				this.m_FontStyle = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0000AD40 File Offset: 0x00009140
		// (set) Token: 0x0600020E RID: 526 RVA: 0x0000AD5B File Offset: 0x0000915B
		public bool bestFit
		{
			get
			{
				return this.m_BestFit;
			}
			set
			{
				this.m_BestFit = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0000AD68 File Offset: 0x00009168
		// (set) Token: 0x06000210 RID: 528 RVA: 0x0000AD83 File Offset: 0x00009183
		public int minSize
		{
			get
			{
				return this.m_MinSize;
			}
			set
			{
				this.m_MinSize = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0000AD90 File Offset: 0x00009190
		// (set) Token: 0x06000212 RID: 530 RVA: 0x0000ADAB File Offset: 0x000091AB
		public int maxSize
		{
			get
			{
				return this.m_MaxSize;
			}
			set
			{
				this.m_MaxSize = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0000ADB8 File Offset: 0x000091B8
		// (set) Token: 0x06000214 RID: 532 RVA: 0x0000ADD3 File Offset: 0x000091D3
		public TextAnchor alignment
		{
			get
			{
				return this.m_Alignment;
			}
			set
			{
				this.m_Alignment = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000215 RID: 533 RVA: 0x0000ADE0 File Offset: 0x000091E0
		// (set) Token: 0x06000216 RID: 534 RVA: 0x0000ADFB File Offset: 0x000091FB
		public bool alignByGeometry
		{
			get
			{
				return this.m_AlignByGeometry;
			}
			set
			{
				this.m_AlignByGeometry = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000217 RID: 535 RVA: 0x0000AE08 File Offset: 0x00009208
		// (set) Token: 0x06000218 RID: 536 RVA: 0x0000AE23 File Offset: 0x00009223
		public bool richText
		{
			get
			{
				return this.m_RichText;
			}
			set
			{
				this.m_RichText = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0000AE30 File Offset: 0x00009230
		// (set) Token: 0x0600021A RID: 538 RVA: 0x0000AE4B File Offset: 0x0000924B
		public HorizontalWrapMode horizontalOverflow
		{
			get
			{
				return this.m_HorizontalOverflow;
			}
			set
			{
				this.m_HorizontalOverflow = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0000AE58 File Offset: 0x00009258
		// (set) Token: 0x0600021C RID: 540 RVA: 0x0000AE73 File Offset: 0x00009273
		public VerticalWrapMode verticalOverflow
		{
			get
			{
				return this.m_VerticalOverflow;
			}
			set
			{
				this.m_VerticalOverflow = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000AE80 File Offset: 0x00009280
		// (set) Token: 0x0600021E RID: 542 RVA: 0x0000AE9B File Offset: 0x0000929B
		public float lineSpacing
		{
			get
			{
				return this.m_LineSpacing;
			}
			set
			{
				this.m_LineSpacing = value;
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000AEA5 File Offset: 0x000092A5
		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000AEA8 File Offset: 0x000092A8
		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
			this.m_FontSize = Mathf.Clamp(this.m_FontSize, 0, 300);
			this.m_MinSize = Mathf.Clamp(this.m_MinSize, 0, this.m_FontSize);
			this.m_MaxSize = Mathf.Clamp(this.m_MaxSize, this.m_FontSize, 300);
		}

		// Token: 0x040000F8 RID: 248
		[SerializeField]
		[FormerlySerializedAs("font")]
		private Font m_Font;

		// Token: 0x040000F9 RID: 249
		[SerializeField]
		[FormerlySerializedAs("fontSize")]
		private int m_FontSize;

		// Token: 0x040000FA RID: 250
		[SerializeField]
		[FormerlySerializedAs("fontStyle")]
		private FontStyle m_FontStyle;

		// Token: 0x040000FB RID: 251
		[SerializeField]
		private bool m_BestFit;

		// Token: 0x040000FC RID: 252
		[SerializeField]
		private int m_MinSize;

		// Token: 0x040000FD RID: 253
		[SerializeField]
		private int m_MaxSize;

		// Token: 0x040000FE RID: 254
		[SerializeField]
		[FormerlySerializedAs("alignment")]
		private TextAnchor m_Alignment;

		// Token: 0x040000FF RID: 255
		[SerializeField]
		private bool m_AlignByGeometry;

		// Token: 0x04000100 RID: 256
		[SerializeField]
		[FormerlySerializedAs("richText")]
		private bool m_RichText;

		// Token: 0x04000101 RID: 257
		[SerializeField]
		private HorizontalWrapMode m_HorizontalOverflow;

		// Token: 0x04000102 RID: 258
		[SerializeField]
		private VerticalWrapMode m_VerticalOverflow;

		// Token: 0x04000103 RID: 259
		[SerializeField]
		private float m_LineSpacing;
	}
}
