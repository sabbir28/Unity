using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000231 RID: 561
	[UsedByNativeCode]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class TextGenerator : IDisposable
	{
		// Token: 0x060025AA RID: 9642 RVA: 0x0002B1D4 File Offset: 0x000293D4
		public TextGenerator() : this(50)
		{
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x0002B1E0 File Offset: 0x000293E0
		public TextGenerator(int initialCapacity)
		{
			this.m_Verts = new List<UIVertex>((initialCapacity + 1) * 4);
			this.m_Characters = new List<UICharInfo>(initialCapacity + 1);
			this.m_Lines = new List<UILineInfo>(20);
			this.Init();
		}

		// Token: 0x060025AC RID: 9644 RVA: 0x0002B21C File Offset: 0x0002941C
		~TextGenerator()
		{
			((IDisposable)this).Dispose();
		}

		// Token: 0x060025AD RID: 9645 RVA: 0x0002B24C File Offset: 0x0002944C
		void IDisposable.Dispose()
		{
			this.Dispose_cpp();
		}

		// Token: 0x060025AE RID: 9646 RVA: 0x0002B258 File Offset: 0x00029458
		private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings)
		{
			TextGenerationSettings result;
			if (settings.font != null && settings.font.dynamic)
			{
				result = settings;
			}
			else
			{
				if (settings.fontSize != 0 || settings.fontStyle != FontStyle.Normal)
				{
					if (settings.font != null)
					{
						Debug.LogWarningFormat(settings.font, "Font size and style overrides are only supported for dynamic fonts. Font '{0}' is not dynamic.", new object[]
						{
							settings.font.name
						});
					}
					settings.fontSize = 0;
					settings.fontStyle = FontStyle.Normal;
				}
				if (settings.resizeTextForBestFit)
				{
					if (settings.font != null)
					{
						Debug.LogWarningFormat(settings.font, "BestFit is only supported for dynamic fonts. Font '{0}' is not dynamic.", new object[]
						{
							settings.font.name
						});
					}
					settings.resizeTextForBestFit = false;
				}
				result = settings;
			}
			return result;
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x0002B348 File Offset: 0x00029548
		public void Invalidate()
		{
			this.m_HasGenerated = false;
		}

		// Token: 0x060025B0 RID: 9648 RVA: 0x0002B354 File Offset: 0x00029554
		public void GetCharacters(List<UICharInfo> characters)
		{
			this.GetCharactersInternal(characters);
		}

		// Token: 0x060025B1 RID: 9649 RVA: 0x0002B360 File Offset: 0x00029560
		public void GetLines(List<UILineInfo> lines)
		{
			this.GetLinesInternal(lines);
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x0002B36C File Offset: 0x0002956C
		public void GetVertices(List<UIVertex> vertices)
		{
			this.GetVerticesInternal(vertices);
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x0002B378 File Offset: 0x00029578
		public float GetPreferredWidth(string str, TextGenerationSettings settings)
		{
			settings.horizontalOverflow = HorizontalWrapMode.Overflow;
			settings.verticalOverflow = VerticalWrapMode.Overflow;
			settings.updateBounds = true;
			this.Populate(str, settings);
			return this.rectExtents.width;
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x0002B3BC File Offset: 0x000295BC
		public float GetPreferredHeight(string str, TextGenerationSettings settings)
		{
			settings.verticalOverflow = VerticalWrapMode.Overflow;
			settings.updateBounds = true;
			this.Populate(str, settings);
			return this.rectExtents.height;
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x0002B3F8 File Offset: 0x000295F8
		public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context)
		{
			TextGenerationError textGenerationError = this.PopulateWithError(str, settings);
			bool result;
			if (textGenerationError == TextGenerationError.None)
			{
				result = true;
			}
			else
			{
				if ((textGenerationError & TextGenerationError.CustomSizeOnNonDynamicFont) != TextGenerationError.None)
				{
					Debug.LogErrorFormat(context, "Font '{0}' is not dynamic, which is required to override its size", new object[]
					{
						settings.font
					});
				}
				if ((textGenerationError & TextGenerationError.CustomStyleOnNonDynamicFont) != TextGenerationError.None)
				{
					Debug.LogErrorFormat(context, "Font '{0}' is not dynamic, which is required to override its style", new object[]
					{
						settings.font
					});
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060025B6 RID: 9654 RVA: 0x0002B46C File Offset: 0x0002966C
		public bool Populate(string str, TextGenerationSettings settings)
		{
			TextGenerationError textGenerationError = this.PopulateWithError(str, settings);
			return textGenerationError == TextGenerationError.None;
		}

		// Token: 0x060025B7 RID: 9655 RVA: 0x0002B490 File Offset: 0x00029690
		private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings)
		{
			TextGenerationError lastValid;
			if (this.m_HasGenerated && str == this.m_LastString && settings.Equals(this.m_LastSettings))
			{
				lastValid = this.m_LastValid;
			}
			else
			{
				this.m_LastValid = this.PopulateAlways(str, settings);
				lastValid = this.m_LastValid;
			}
			return lastValid;
		}

		// Token: 0x060025B8 RID: 9656 RVA: 0x0002B4F4 File Offset: 0x000296F4
		private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings)
		{
			this.m_LastString = str;
			this.m_HasGenerated = true;
			this.m_CachedVerts = false;
			this.m_CachedCharacters = false;
			this.m_CachedLines = false;
			this.m_LastSettings = settings;
			TextGenerationSettings textGenerationSettings = this.ValidatedSettings(settings);
			TextGenerationError textGenerationError;
			this.Populate_Internal(str, textGenerationSettings.font, textGenerationSettings.color, textGenerationSettings.fontSize, textGenerationSettings.scaleFactor, textGenerationSettings.lineSpacing, textGenerationSettings.fontStyle, textGenerationSettings.richText, textGenerationSettings.resizeTextForBestFit, textGenerationSettings.resizeTextMinSize, textGenerationSettings.resizeTextMaxSize, textGenerationSettings.verticalOverflow, textGenerationSettings.horizontalOverflow, textGenerationSettings.updateBounds, textGenerationSettings.textAnchor, textGenerationSettings.generationExtents, textGenerationSettings.pivot, textGenerationSettings.generateOutOfBounds, textGenerationSettings.alignByGeometry, out textGenerationError);
			this.m_LastValid = textGenerationError;
			return textGenerationError;
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x060025B9 RID: 9657 RVA: 0x0002B5CC File Offset: 0x000297CC
		public IList<UIVertex> verts
		{
			get
			{
				if (!this.m_CachedVerts)
				{
					this.GetVertices(this.m_Verts);
					this.m_CachedVerts = true;
				}
				return this.m_Verts;
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x060025BA RID: 9658 RVA: 0x0002B608 File Offset: 0x00029808
		public IList<UICharInfo> characters
		{
			get
			{
				if (!this.m_CachedCharacters)
				{
					this.GetCharacters(this.m_Characters);
					this.m_CachedCharacters = true;
				}
				return this.m_Characters;
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x060025BB RID: 9659 RVA: 0x0002B644 File Offset: 0x00029844
		public IList<UILineInfo> lines
		{
			get
			{
				if (!this.m_CachedLines)
				{
					this.GetLines(this.m_Lines);
					this.m_CachedLines = true;
				}
				return this.m_Lines;
			}
		}

		// Token: 0x060025BC RID: 9660
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Init();

		// Token: 0x060025BD RID: 9661
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Dispose_cpp();

		// Token: 0x060025BE RID: 9662 RVA: 0x0002B680 File Offset: 0x00029880
		internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error)
		{
			uint num = 0U;
			bool result;
			if (font == null)
			{
				error = TextGenerationError.NoFont;
				result = false;
			}
			else
			{
				bool flag = this.Populate_Internal_cpp(str, font, color, fontSize, scaleFactor, lineSpacing, style, richText, resizeTextForBestFit, resizeTextMinSize, resizeTextMaxSize, (int)verticalOverFlow, (int)horizontalOverflow, updateBounds, anchor, extents.x, extents.y, pivot.x, pivot.y, generateOutOfBounds, alignByGeometry, out num);
				error = (TextGenerationError)num;
				result = flag;
			}
			return result;
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x0002B6FC File Offset: 0x000298FC
		internal bool Populate_Internal_cpp(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error)
		{
			return TextGenerator.INTERNAL_CALL_Populate_Internal_cpp(this, str, font, ref color, fontSize, scaleFactor, lineSpacing, style, richText, resizeTextForBestFit, resizeTextMinSize, resizeTextMaxSize, verticalOverFlow, horizontalOverflow, updateBounds, anchor, extentsX, extentsY, pivotX, pivotY, generateOutOfBounds, alignByGeometry, out error);
		}

		// Token: 0x060025C0 RID: 9664
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Populate_Internal_cpp(TextGenerator self, string str, Font font, ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error);

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x060025C1 RID: 9665 RVA: 0x0002B744 File Offset: 0x00029944
		public Rect rectExtents
		{
			get
			{
				Rect result;
				this.INTERNAL_get_rectExtents(out result);
				return result;
			}
		}

		// Token: 0x060025C2 RID: 9666
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_rectExtents(out Rect value);

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x060025C3 RID: 9667
		public extern int vertexCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060025C4 RID: 9668
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetVerticesInternal(object vertices);

		// Token: 0x060025C5 RID: 9669
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern UIVertex[] GetVerticesArray();

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x060025C6 RID: 9670
		public extern int characterCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x060025C7 RID: 9671 RVA: 0x0002B764 File Offset: 0x00029964
		public int characterCountVisible
		{
			get
			{
				return this.characterCount - 1;
			}
		}

		// Token: 0x060025C8 RID: 9672
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetCharactersInternal(object characters);

		// Token: 0x060025C9 RID: 9673
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern UICharInfo[] GetCharactersArray();

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x060025CA RID: 9674
		public extern int lineCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060025CB RID: 9675
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetLinesInternal(object lines);

		// Token: 0x060025CC RID: 9676
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern UILineInfo[] GetLinesArray();

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x060025CD RID: 9677
		public extern int fontSizeUsedForBestFit { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x04000689 RID: 1673
		internal IntPtr m_Ptr;

		// Token: 0x0400068A RID: 1674
		private string m_LastString;

		// Token: 0x0400068B RID: 1675
		private TextGenerationSettings m_LastSettings;

		// Token: 0x0400068C RID: 1676
		private bool m_HasGenerated;

		// Token: 0x0400068D RID: 1677
		private TextGenerationError m_LastValid;

		// Token: 0x0400068E RID: 1678
		private readonly List<UIVertex> m_Verts;

		// Token: 0x0400068F RID: 1679
		private readonly List<UICharInfo> m_Characters;

		// Token: 0x04000690 RID: 1680
		private readonly List<UILineInfo> m_Lines;

		// Token: 0x04000691 RID: 1681
		private bool m_CachedVerts;

		// Token: 0x04000692 RID: 1682
		private bool m_CachedCharacters;

		// Token: 0x04000693 RID: 1683
		private bool m_CachedLines;
	}
}
