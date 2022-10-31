using System;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x0200003F RID: 63
	[Serializable]
	public struct ColorBlock : IEquatable<ColorBlock>
	{
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0000828C File Offset: 0x0000668C
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x000082A7 File Offset: 0x000066A7
		public Color normalColor
		{
			get
			{
				return this.m_NormalColor;
			}
			set
			{
				this.m_NormalColor = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x000082B4 File Offset: 0x000066B4
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x000082CF File Offset: 0x000066CF
		public Color highlightedColor
		{
			get
			{
				return this.m_HighlightedColor;
			}
			set
			{
				this.m_HighlightedColor = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x000082DC File Offset: 0x000066DC
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x000082F7 File Offset: 0x000066F7
		public Color pressedColor
		{
			get
			{
				return this.m_PressedColor;
			}
			set
			{
				this.m_PressedColor = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00008304 File Offset: 0x00006704
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x0000831F File Offset: 0x0000671F
		public Color disabledColor
		{
			get
			{
				return this.m_DisabledColor;
			}
			set
			{
				this.m_DisabledColor = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000832C File Offset: 0x0000672C
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00008347 File Offset: 0x00006747
		public float colorMultiplier
		{
			get
			{
				return this.m_ColorMultiplier;
			}
			set
			{
				this.m_ColorMultiplier = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00008354 File Offset: 0x00006754
		// (set) Token: 0x060001AA RID: 426 RVA: 0x0000836F File Offset: 0x0000676F
		public float fadeDuration
		{
			get
			{
				return this.m_FadeDuration;
			}
			set
			{
				this.m_FadeDuration = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000837C File Offset: 0x0000677C
		public static ColorBlock defaultColorBlock
		{
			get
			{
				return new ColorBlock
				{
					m_NormalColor = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue),
					m_HighlightedColor = new Color32(245, 245, 245, byte.MaxValue),
					m_PressedColor = new Color32(200, 200, 200, byte.MaxValue),
					m_DisabledColor = new Color32(200, 200, 200, 128),
					colorMultiplier = 1f,
					fadeDuration = 0.1f
				};
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00008448 File Offset: 0x00006848
		public override bool Equals(object obj)
		{
			return obj is ColorBlock && this.Equals((ColorBlock)obj);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000847C File Offset: 0x0000687C
		public bool Equals(ColorBlock other)
		{
			return this.normalColor == other.normalColor && this.highlightedColor == other.highlightedColor && this.pressedColor == other.pressedColor && this.disabledColor == other.disabledColor && this.colorMultiplier == other.colorMultiplier && this.fadeDuration == other.fadeDuration;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00008514 File Offset: 0x00006914
		public static bool operator ==(ColorBlock point1, ColorBlock point2)
		{
			return point1.Equals(point2);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00008534 File Offset: 0x00006934
		public static bool operator !=(ColorBlock point1, ColorBlock point2)
		{
			return !point1.Equals(point2);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00008554 File Offset: 0x00006954
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x040000CD RID: 205
		[FormerlySerializedAs("normalColor")]
		[SerializeField]
		private Color m_NormalColor;

		// Token: 0x040000CE RID: 206
		[FormerlySerializedAs("highlightedColor")]
		[FormerlySerializedAs("m_SelectedColor")]
		[SerializeField]
		private Color m_HighlightedColor;

		// Token: 0x040000CF RID: 207
		[FormerlySerializedAs("pressedColor")]
		[SerializeField]
		private Color m_PressedColor;

		// Token: 0x040000D0 RID: 208
		[FormerlySerializedAs("disabledColor")]
		[SerializeField]
		private Color m_DisabledColor;

		// Token: 0x040000D1 RID: 209
		[Range(1f, 5f)]
		[SerializeField]
		private float m_ColorMultiplier;

		// Token: 0x040000D2 RID: 210
		[FormerlySerializedAs("fadeDuration")]
		[SerializeField]
		private float m_FadeDuration;
	}
}
