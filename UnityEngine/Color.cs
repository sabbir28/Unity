using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000325 RID: 805
	[UsedByNativeCode]
	public struct Color
	{
		// Token: 0x060030AC RID: 12460 RVA: 0x000493F0 File Offset: 0x000475F0
		public Color(float r, float g, float b, float a)
		{
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}

		// Token: 0x060030AD RID: 12461 RVA: 0x00049410 File Offset: 0x00047610
		public Color(float r, float g, float b)
		{
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = 1f;
		}

		// Token: 0x060030AE RID: 12462 RVA: 0x00049434 File Offset: 0x00047634
		public override string ToString()
		{
			return UnityString.Format("RGBA({0:F3}, {1:F3}, {2:F3}, {3:F3})", new object[]
			{
				this.r,
				this.g,
				this.b,
				this.a
			});
		}

		// Token: 0x060030AF RID: 12463 RVA: 0x00049494 File Offset: 0x00047694
		public string ToString(string format)
		{
			return UnityString.Format("RGBA({0}, {1}, {2}, {3})", new object[]
			{
				this.r.ToString(format),
				this.g.ToString(format),
				this.b.ToString(format),
				this.a.ToString(format)
			});
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x000494F8 File Offset: 0x000476F8
		public override int GetHashCode()
		{
			return this.GetHashCode();
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x00049528 File Offset: 0x00047728
		public override bool Equals(object other)
		{
			bool result;
			if (!(other is Color))
			{
				result = false;
			}
			else
			{
				Color color = (Color)other;
				result = (this.r.Equals(color.r) && this.g.Equals(color.g) && this.b.Equals(color.b) && this.a.Equals(color.a));
			}
			return result;
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x000495B0 File Offset: 0x000477B0
		public static Color operator +(Color a, Color b)
		{
			return new Color(a.r + b.r, a.g + b.g, a.b + b.b, a.a + b.a);
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x00049608 File Offset: 0x00047808
		public static Color operator -(Color a, Color b)
		{
			return new Color(a.r - b.r, a.g - b.g, a.b - b.b, a.a - b.a);
		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x00049660 File Offset: 0x00047860
		public static Color operator *(Color a, Color b)
		{
			return new Color(a.r * b.r, a.g * b.g, a.b * b.b, a.a * b.a);
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x000496B8 File Offset: 0x000478B8
		public static Color operator *(Color a, float b)
		{
			return new Color(a.r * b, a.g * b, a.b * b, a.a * b);
		}

		// Token: 0x060030B6 RID: 12470 RVA: 0x000496F8 File Offset: 0x000478F8
		public static Color operator *(float b, Color a)
		{
			return new Color(a.r * b, a.g * b, a.b * b, a.a * b);
		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x00049738 File Offset: 0x00047938
		public static Color operator /(Color a, float b)
		{
			return new Color(a.r / b, a.g / b, a.b / b, a.a / b);
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x00049778 File Offset: 0x00047978
		public static bool operator ==(Color lhs, Color rhs)
		{
			return lhs == rhs;
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x000497A0 File Offset: 0x000479A0
		public static bool operator !=(Color lhs, Color rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x000497C0 File Offset: 0x000479C0
		public static Color Lerp(Color a, Color b, float t)
		{
			t = Mathf.Clamp01(t);
			return new Color(a.r + (b.r - a.r) * t, a.g + (b.g - a.g) * t, a.b + (b.b - a.b) * t, a.a + (b.a - a.a) * t);
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x00049848 File Offset: 0x00047A48
		public static Color LerpUnclamped(Color a, Color b, float t)
		{
			return new Color(a.r + (b.r - a.r) * t, a.g + (b.g - a.g) * t, a.b + (b.b - a.b) * t, a.a + (b.a - a.a) * t);
		}

		// Token: 0x060030BC RID: 12476 RVA: 0x000498C8 File Offset: 0x00047AC8
		internal Color RGBMultiplied(float multiplier)
		{
			return new Color(this.r * multiplier, this.g * multiplier, this.b * multiplier, this.a);
		}

		// Token: 0x060030BD RID: 12477 RVA: 0x00049900 File Offset: 0x00047B00
		internal Color AlphaMultiplied(float multiplier)
		{
			return new Color(this.r, this.g, this.b, this.a * multiplier);
		}

		// Token: 0x060030BE RID: 12478 RVA: 0x00049934 File Offset: 0x00047B34
		internal Color RGBMultiplied(Color multiplier)
		{
			return new Color(this.r * multiplier.r, this.g * multiplier.g, this.b * multiplier.b, this.a);
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x060030BF RID: 12479 RVA: 0x00049980 File Offset: 0x00047B80
		public static Color red
		{
			get
			{
				return new Color(1f, 0f, 0f, 1f);
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x060030C0 RID: 12480 RVA: 0x000499B0 File Offset: 0x00047BB0
		public static Color green
		{
			get
			{
				return new Color(0f, 1f, 0f, 1f);
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x060030C1 RID: 12481 RVA: 0x000499E0 File Offset: 0x00047BE0
		public static Color blue
		{
			get
			{
				return new Color(0f, 0f, 1f, 1f);
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x060030C2 RID: 12482 RVA: 0x00049A10 File Offset: 0x00047C10
		public static Color white
		{
			get
			{
				return new Color(1f, 1f, 1f, 1f);
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x060030C3 RID: 12483 RVA: 0x00049A40 File Offset: 0x00047C40
		public static Color black
		{
			get
			{
				return new Color(0f, 0f, 0f, 1f);
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x060030C4 RID: 12484 RVA: 0x00049A70 File Offset: 0x00047C70
		public static Color yellow
		{
			get
			{
				return new Color(1f, 0.92156863f, 0.015686275f, 1f);
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x060030C5 RID: 12485 RVA: 0x00049AA0 File Offset: 0x00047CA0
		public static Color cyan
		{
			get
			{
				return new Color(0f, 1f, 1f, 1f);
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x060030C6 RID: 12486 RVA: 0x00049AD0 File Offset: 0x00047CD0
		public static Color magenta
		{
			get
			{
				return new Color(1f, 0f, 1f, 1f);
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x060030C7 RID: 12487 RVA: 0x00049B00 File Offset: 0x00047D00
		public static Color gray
		{
			get
			{
				return new Color(0.5f, 0.5f, 0.5f, 1f);
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x060030C8 RID: 12488 RVA: 0x00049B30 File Offset: 0x00047D30
		public static Color grey
		{
			get
			{
				return new Color(0.0f, 0.5f, 0.5f, 1f);
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x060030C9 RID: 12489 RVA: 0x00049B60 File Offset: 0x00047D60
		public static Color clear
		{
			get
			{
				return new Color(0f, 0f, 0f, 0f);
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x060030CA RID: 12490 RVA: 0x00049B90 File Offset: 0x00047D90
		public float grayscale
		{
			get
			{
				return 0.299f * this.r + 0.587f * this.g + 0.114f * this.b;
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x060030CB RID: 12491 RVA: 0x00049BCC File Offset: 0x00047DCC
		public Color linear
		{
			get
			{
				return new Color(Mathf.GammaToLinearSpace(this.r), Mathf.GammaToLinearSpace(this.g), Mathf.GammaToLinearSpace(this.b), this.a);
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x060030CC RID: 12492 RVA: 0x00049C10 File Offset: 0x00047E10
		public Color gamma
		{
			get
			{
				return new Color(Mathf.LinearToGammaSpace(this.r), Mathf.LinearToGammaSpace(this.g), Mathf.LinearToGammaSpace(this.b), this.a);
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x060030CD RID: 12493 RVA: 0x00049C54 File Offset: 0x00047E54
		public float maxColorComponent
		{
			get
			{
				return Mathf.Max(Mathf.Max(this.r, this.g), this.b);
			}
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x00049C88 File Offset: 0x00047E88
		public static implicit operator Vector4(Color c)
		{
			return new Vector4(c.r, c.g, c.b, c.a);
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x00049CC0 File Offset: 0x00047EC0
		public static implicit operator Color(Vector4 v)
		{
			return new Color(v.x, v.y, v.z, v.w);
		}

		// Token: 0x17000B4E RID: 2894
		public float this[int index]
		{
			get
			{
				float result;
				switch (index)
				{
				case 0:
					result = this.r;
					break;
				case 1:
					result = this.g;
					break;
				case 2:
					result = this.b;
					break;
				case 3:
					result = this.a;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid Vector3 index!");
				}
				return result;
			}
			set
			{
				switch (index)
				{
				case 0:
					this.r = value;
					break;
				case 1:
					this.g = value;
					break;
				case 2:
					this.b = value;
					break;
				case 3:
					this.a = value;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid Vector3 index!");
				}
			}
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x00049DC4 File Offset: 0x00047FC4
		public static void RGBToHSV(Color rgbColor, out float H, out float S, out float V)
		{
			if (rgbColor.b > rgbColor.g && rgbColor.b > rgbColor.r)
			{
				Color.RGBToHSVHelper(4f, rgbColor.b, rgbColor.r, rgbColor.g, out H, out S, out V);
			}
			else if (rgbColor.g > rgbColor.r)
			{
				Color.RGBToHSVHelper(2f, rgbColor.g, rgbColor.b, rgbColor.r, out H, out S, out V);
			}
			else
			{
				Color.RGBToHSVHelper(0f, rgbColor.r, rgbColor.g, rgbColor.b, out H, out S, out V);
			}
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x00049E7C File Offset: 0x0004807C
		private static void RGBToHSVHelper(float offset, float dominantcolor, float colorone, float colortwo, out float H, out float S, out float V)
		{
			V = dominantcolor;
			if (V != 0f)
			{
				float num;
				if (colorone > colortwo)
				{
					num = colortwo;
				}
				else
				{
					num = colorone;
				}
				float num2 = V - num;
				if (num2 != 0f)
				{
					S = num2 / V;
					H = offset + (colorone - colortwo) / num2;
				}
				else
				{
					S = 0f;
					H = offset + (colorone - colortwo);
				}
				H /= 6f;
				if (H < 0f)
				{
					H += 1f;
				}
			}
			else
			{
				S = 0f;
				H = 0f;
			}
		}

		// Token: 0x060030D4 RID: 12500 RVA: 0x00049F2C File Offset: 0x0004812C
		public static Color HSVToRGB(float H, float S, float V)
		{
			return Color.HSVToRGB(H, S, V, true);
		}

		// Token: 0x060030D5 RID: 12501 RVA: 0x00049F4C File Offset: 0x0004814C
		public static Color HSVToRGB(float H, float S, float V, bool hdr)
		{
			Color white = Color.white;
			if (S == 0f)
			{
				white.r = V;
				white.g = V;
				white.b = V;
			}
			else if (V == 0f)
			{
				white.r = 0f;
				white.g = 0f;
				white.b = 0f;
			}
			else
			{
				white.r = 0f;
				white.g = 0f;
				white.b = 0f;
				float num = H * 6f;
				int num2 = (int)Mathf.Floor(num);
				float num3 = num - (float)num2;
				float num4 = V * (1f - S);
				float num5 = V * (1f - S * num3);
				float num6 = V * (1f - S * (1f - num3));
				switch (num2 + 1)
				{
				case 0:
					white.r = V;
					white.g = num4;
					white.b = num5;
					break;
				case 1:
					white.r = V;
					white.g = num6;
					white.b = num4;
					break;
				case 2:
					white.r = num5;
					white.g = V;
					white.b = num4;
					break;
				case 3:
					white.r = num4;
					white.g = V;
					white.b = num6;
					break;
				case 4:
					white.r = num4;
					white.g = num5;
					white.b = V;
					break;
				case 5:
					white.r = num6;
					white.g = num4;
					white.b = V;
					break;
				case 6:
					white.r = V;
					white.g = num4;
					white.b = num5;
					break;
				case 7:
					white.r = V;
					white.g = num6;
					white.b = num4;
					break;
				}
				if (!hdr)
				{
					white.r = Mathf.Clamp(white.r, 0f, 1f);
					white.g = Mathf.Clamp(white.g, 0f, 1f);
					white.b = Mathf.Clamp(white.b, 0f, 1f);
				}
			}
			return white;
		}

		// Token: 0x04000A7B RID: 2683
		public float r;

		// Token: 0x04000A7C RID: 2684
		public float g;

		// Token: 0x04000A7D RID: 2685
		public float b;

		// Token: 0x04000A7E RID: 2686
		public float a;
	}
}
