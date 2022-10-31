using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x0200007D RID: 125
	[AddComponentMenu("UI/Text", 10)]
	public class Text : MaskableGraphic, ILayoutElement
	{
		// Token: 0x06000495 RID: 1173 RVA: 0x00019095 File Offset: 0x00017495
		protected Text()
		{
			base.useLegacyMeshGeneration = false;
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x000190D0 File Offset: 0x000174D0
		public TextGenerator cachedTextGenerator
		{
			get
			{
				TextGenerator result;
				if ((result = this.m_TextCache) == null)
				{
					result = (this.m_TextCache = ((this.m_Text.Length == 0) ? new TextGenerator() : new TextGenerator(this.m_Text.Length)));
				}
				return result;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00019128 File Offset: 0x00017528
		public TextGenerator cachedTextGeneratorForLayout
		{
			get
			{
				TextGenerator result;
				if ((result = this.m_TextCacheForLayout) == null)
				{
					result = (this.m_TextCacheForLayout = new TextGenerator());
				}
				return result;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00019158 File Offset: 0x00017558
		public override Texture mainTexture
		{
			get
			{
				Texture mainTexture;
				if (this.font != null && this.font.material != null && this.font.material.mainTexture != null)
				{
					mainTexture = this.font.material.mainTexture;
				}
				else if (this.m_Material != null)
				{
					mainTexture = this.m_Material.mainTexture;
				}
				else
				{
					mainTexture = base.mainTexture;
				}
				return mainTexture;
			}
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x000191F0 File Offset: 0x000175F0
		public void FontTextureChanged()
		{
			if (this)
			{
				if (!this.m_DisableFontTextureRebuiltCallback)
				{
					this.cachedTextGenerator.Invalidate();
					if (this.IsActive())
					{
						if (CanvasUpdateRegistry.IsRebuildingGraphics() || CanvasUpdateRegistry.IsRebuildingLayout())
						{
							this.UpdateGeometry();
						}
						else
						{
							this.SetAllDirty();
						}
					}
				}
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x00019260 File Offset: 0x00017660
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x00019280 File Offset: 0x00017680
		public Font font
		{
			get
			{
				return this.m_FontData.font;
			}
			set
			{
				if (!(this.m_FontData.font == value))
				{
					FontUpdateTracker.UntrackText(this);
					this.m_FontData.font = value;
					FontUpdateTracker.TrackText(this);
					this.SetAllDirty();
				}
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x000192BC File Offset: 0x000176BC
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x000192D8 File Offset: 0x000176D8
		public virtual string text
		{
			get
			{
				return this.m_Text;
			}
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					if (!string.IsNullOrEmpty(this.m_Text))
					{
						this.m_Text = "";
						this.SetVerticesDirty();
					}
				}
				else if (this.m_Text != value)
				{
					this.m_Text = value;
					this.SetVerticesDirty();
					this.SetLayoutDirty();
				}
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x00019344 File Offset: 0x00017744
		// (set) Token: 0x0600049F RID: 1183 RVA: 0x00019364 File Offset: 0x00017764
		public bool supportRichText
		{
			get
			{
				return this.m_FontData.richText;
			}
			set
			{
				if (this.m_FontData.richText != value)
				{
					this.m_FontData.richText = value;
					this.SetVerticesDirty();
					this.SetLayoutDirty();
				}
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x00019398 File Offset: 0x00017798
		// (set) Token: 0x060004A1 RID: 1185 RVA: 0x000193B8 File Offset: 0x000177B8
		public bool resizeTextForBestFit
		{
			get
			{
				return this.m_FontData.bestFit;
			}
			set
			{
				if (this.m_FontData.bestFit != value)
				{
					this.m_FontData.bestFit = value;
					this.SetVerticesDirty();
					this.SetLayoutDirty();
				}
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x000193EC File Offset: 0x000177EC
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x0001940C File Offset: 0x0001780C
		public int resizeTextMinSize
		{
			get
			{
				return this.m_FontData.minSize;
			}
			set
			{
				if (this.m_FontData.minSize != value)
				{
					this.m_FontData.minSize = value;
					this.SetVerticesDirty();
					this.SetLayoutDirty();
				}
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x00019440 File Offset: 0x00017840
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x00019460 File Offset: 0x00017860
		public int resizeTextMaxSize
		{
			get
			{
				return this.m_FontData.maxSize;
			}
			set
			{
				if (this.m_FontData.maxSize != value)
				{
					this.m_FontData.maxSize = value;
					this.SetVerticesDirty();
					this.SetLayoutDirty();
				}
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00019494 File Offset: 0x00017894
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x000194B4 File Offset: 0x000178B4
		public TextAnchor alignment
		{
			get
			{
				return this.m_FontData.alignment;
			}
			set
			{
				if (this.m_FontData.alignment != value)
				{
					this.m_FontData.alignment = value;
					this.SetVerticesDirty();
					this.SetLayoutDirty();
				}
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x000194E8 File Offset: 0x000178E8
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x00019508 File Offset: 0x00017908
		public bool alignByGeometry
		{
			get
			{
				return this.m_FontData.alignByGeometry;
			}
			set
			{
				if (this.m_FontData.alignByGeometry != value)
				{
					this.m_FontData.alignByGeometry = value;
					this.SetVerticesDirty();
				}
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x00019534 File Offset: 0x00017934
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x00019554 File Offset: 0x00017954
		public int fontSize
		{
			get
			{
				return this.m_FontData.fontSize;
			}
			set
			{
				if (this.m_FontData.fontSize != value)
				{
					this.m_FontData.fontSize = value;
					this.SetVerticesDirty();
					this.SetLayoutDirty();
				}
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x00019588 File Offset: 0x00017988
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x000195A8 File Offset: 0x000179A8
		public HorizontalWrapMode horizontalOverflow
		{
			get
			{
				return this.m_FontData.horizontalOverflow;
			}
			set
			{
				if (this.m_FontData.horizontalOverflow != value)
				{
					this.m_FontData.horizontalOverflow = value;
					this.SetVerticesDirty();
					this.SetLayoutDirty();
				}
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x000195DC File Offset: 0x000179DC
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x000195FC File Offset: 0x000179FC
		public VerticalWrapMode verticalOverflow
		{
			get
			{
				return this.m_FontData.verticalOverflow;
			}
			set
			{
				if (this.m_FontData.verticalOverflow != value)
				{
					this.m_FontData.verticalOverflow = value;
					this.SetVerticesDirty();
					this.SetLayoutDirty();
				}
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00019630 File Offset: 0x00017A30
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00019650 File Offset: 0x00017A50
		public float lineSpacing
		{
			get
			{
				return this.m_FontData.lineSpacing;
			}
			set
			{
				if (this.m_FontData.lineSpacing != value)
				{
					this.m_FontData.lineSpacing = value;
					this.SetVerticesDirty();
					this.SetLayoutDirty();
				}
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00019684 File Offset: 0x00017A84
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x000196A4 File Offset: 0x00017AA4
		public FontStyle fontStyle
		{
			get
			{
				return this.m_FontData.fontStyle;
			}
			set
			{
				if (this.m_FontData.fontStyle != value)
				{
					this.m_FontData.fontStyle = value;
					this.SetVerticesDirty();
					this.SetLayoutDirty();
				}
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x000196D8 File Offset: 0x00017AD8
		public float pixelsPerUnit
		{
			get
			{
				Canvas canvas = base.canvas;
				float result;
				if (!canvas)
				{
					result = 1f;
				}
				else if (!this.font || this.font.dynamic)
				{
					result = canvas.scaleFactor;
				}
				else if (this.m_FontData.fontSize <= 0 || this.font.fontSize <= 0)
				{
					result = 1f;
				}
				else
				{
					result = (float)this.font.fontSize / (float)this.m_FontData.fontSize;
				}
				return result;
			}
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0001977C File Offset: 0x00017B7C
		protected override void OnEnable()
		{
			base.OnEnable();
			this.cachedTextGenerator.Invalidate();
			FontUpdateTracker.TrackText(this);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00019796 File Offset: 0x00017B96
		protected override void OnDisable()
		{
			FontUpdateTracker.UntrackText(this);
			base.OnDisable();
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x000197A5 File Offset: 0x00017BA5
		protected override void UpdateGeometry()
		{
			if (this.font != null)
			{
				base.UpdateGeometry();
			}
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x000197C1 File Offset: 0x00017BC1
		internal void AssignDefaultFont()
		{
			this.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x000197D4 File Offset: 0x00017BD4
		public TextGenerationSettings GetGenerationSettings(Vector2 extents)
		{
			TextGenerationSettings result = default(TextGenerationSettings);
			result.generationExtents = extents;
			if (this.font != null && this.font.dynamic)
			{
				result.fontSize = this.m_FontData.fontSize;
				result.resizeTextMinSize = this.m_FontData.minSize;
				result.resizeTextMaxSize = this.m_FontData.maxSize;
			}
			result.textAnchor = this.m_FontData.alignment;
			result.alignByGeometry = this.m_FontData.alignByGeometry;
			result.scaleFactor = this.pixelsPerUnit;
			result.color = this.color;
			result.font = this.font;
			result.pivot = base.rectTransform.pivot;
			result.richText = this.m_FontData.richText;
			result.lineSpacing = this.m_FontData.lineSpacing;
			result.fontStyle = this.m_FontData.fontStyle;
			result.resizeTextForBestFit = this.m_FontData.bestFit;
			result.updateBounds = false;
			result.horizontalOverflow = this.m_FontData.horizontalOverflow;
			result.verticalOverflow = this.m_FontData.verticalOverflow;
			return result;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00019924 File Offset: 0x00017D24
		public static Vector2 GetTextAnchorPivot(TextAnchor anchor)
		{
			Vector2 result;
			switch (anchor)
			{
			case TextAnchor.UpperLeft:
				result = new Vector2(0f, 1f);
				break;
			case TextAnchor.UpperCenter:
				result = new Vector2(0.5f, 1f);
				break;
			case TextAnchor.UpperRight:
				result = new Vector2(1f, 1f);
				break;
			case TextAnchor.MiddleLeft:
				result = new Vector2(0f, 0.5f);
				break;
			case TextAnchor.MiddleCenter:
				result = new Vector2(0.5f, 0.5f);
				break;
			case TextAnchor.MiddleRight:
				result = new Vector2(1f, 0.5f);
				break;
			case TextAnchor.LowerLeft:
				result = new Vector2(0f, 0f);
				break;
			case TextAnchor.LowerCenter:
				result = new Vector2(0.5f, 0f);
				break;
			case TextAnchor.LowerRight:
				result = new Vector2(1f, 0f);
				break;
			default:
				result = Vector2.zero;
				break;
			}
			return result;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00019A2C File Offset: 0x00017E2C
		protected override void OnPopulateMesh(VertexHelper toFill)
		{
			if (!(this.font == null))
			{
				this.m_DisableFontTextureRebuiltCallback = true;
				Vector2 size = base.rectTransform.rect.size;
				TextGenerationSettings generationSettings = this.GetGenerationSettings(size);
				this.cachedTextGenerator.PopulateWithErrors(this.text, generationSettings, base.gameObject);
				IList<UIVertex> verts = this.cachedTextGenerator.verts;
				float d = 1f / this.pixelsPerUnit;
				int num = verts.Count - 4;
				Vector2 vector = new Vector2(verts[0].position.x, verts[0].position.y) * d;
				vector = base.PixelAdjustPoint(vector) - vector;
				toFill.Clear();
				if (vector != Vector2.zero)
				{
					for (int i = 0; i < num; i++)
					{
						int num2 = i & 3;
						this.m_TempVerts[num2] = verts[i];
						UIVertex[] tempVerts = this.m_TempVerts;
						int num3 = num2;
						tempVerts[num3].position = tempVerts[num3].position * d;
						UIVertex[] tempVerts2 = this.m_TempVerts;
						int num4 = num2;
						tempVerts2[num4].position.x = tempVerts2[num4].position.x + vector.x;
						UIVertex[] tempVerts3 = this.m_TempVerts;
						int num5 = num2;
						tempVerts3[num5].position.y = tempVerts3[num5].position.y + vector.y;
						if (num2 == 3)
						{
							toFill.AddUIVertexQuad(this.m_TempVerts);
						}
					}
				}
				else
				{
					for (int j = 0; j < num; j++)
					{
						int num6 = j & 3;
						this.m_TempVerts[num6] = verts[j];
						UIVertex[] tempVerts4 = this.m_TempVerts;
						int num7 = num6;
						tempVerts4[num7].position = tempVerts4[num7].position * d;
						if (num6 == 3)
						{
							toFill.AddUIVertexQuad(this.m_TempVerts);
						}
					}
				}
				this.m_DisableFontTextureRebuiltCallback = false;
			}
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00019C42 File Offset: 0x00018042
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00019C45 File Offset: 0x00018045
		public virtual void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x00019C48 File Offset: 0x00018048
		public virtual float minWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00019C64 File Offset: 0x00018064
		public virtual float preferredWidth
		{
			get
			{
				TextGenerationSettings generationSettings = this.GetGenerationSettings(Vector2.zero);
				return this.cachedTextGeneratorForLayout.GetPreferredWidth(this.m_Text, generationSettings) / this.pixelsPerUnit;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00019CA0 File Offset: 0x000180A0
		public virtual float flexibleWidth
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00019CBC File Offset: 0x000180BC
		public virtual float minHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00019CD8 File Offset: 0x000180D8
		public virtual float preferredHeight
		{
			get
			{
				TextGenerationSettings generationSettings = this.GetGenerationSettings(new Vector2(base.GetPixelAdjustedRect().size.x, 0f));
				return this.cachedTextGeneratorForLayout.GetPreferredHeight(this.m_Text, generationSettings) / this.pixelsPerUnit;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00019D30 File Offset: 0x00018130
		public virtual float flexibleHeight
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x00019D4C File Offset: 0x0001814C
		public virtual int layoutPriority
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x04000242 RID: 578
		[SerializeField]
		private FontData m_FontData = FontData.defaultFontData;

		// Token: 0x04000243 RID: 579
		[TextArea(3, 10)]
		[SerializeField]
		protected string m_Text = string.Empty;

		// Token: 0x04000244 RID: 580
		private TextGenerator m_TextCache;

		// Token: 0x04000245 RID: 581
		private TextGenerator m_TextCacheForLayout;

		// Token: 0x04000246 RID: 582
		protected static Material s_DefaultText = null;

		// Token: 0x04000247 RID: 583
		[NonSerialized]
		protected bool m_DisableFontTextureRebuiltCallback = false;

		// Token: 0x04000248 RID: 584
		private readonly UIVertex[] m_TempVerts = new UIVertex[4];
	}
}
