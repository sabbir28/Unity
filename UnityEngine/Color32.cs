using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000326 RID: 806
	[UsedByNativeCode]
	[IL2CPPStructAlignment(Align = 4)]
	public struct Color32
	{
		// Token: 0x060030D6 RID: 12502 RVA: 0x0004A1C0 File Offset: 0x000483C0
		public Color32(byte r, byte g, byte b, byte a)
		{
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}

		// Token: 0x060030D7 RID: 12503 RVA: 0x0004A1E0 File Offset: 0x000483E0
		public static implicit operator Color32(Color c)
		{
			return new Color32((byte)(Mathf.Clamp01(c.r) * 255f), (byte)(Mathf.Clamp01(c.g) * 255f), (byte)(Mathf.Clamp01(c.b) * 255f), (byte)(Mathf.Clamp01(c.a) * 255f));
		}

		// Token: 0x060030D8 RID: 12504 RVA: 0x0004A248 File Offset: 0x00048448
		public static implicit operator Color(Color32 c)
		{
			return new Color((float)c.r / 255f, (float)c.g / 255f, (float)c.b / 255f, (float)c.a / 255f);
		}

		// Token: 0x060030D9 RID: 12505 RVA: 0x0004A29C File Offset: 0x0004849C
		public static Color32 Lerp(Color32 a, Color32 b, float t)
		{
			t = Mathf.Clamp01(t);
			return new Color32((byte)((float)a.r + (float)(b.r - a.r) * t), (byte)((float)a.g + (float)(b.g - a.g) * t), (byte)((float)a.b + (float)(b.b - a.b) * t), (byte)((float)a.a + (float)(b.a - a.a) * t));
		}

		// Token: 0x060030DA RID: 12506 RVA: 0x0004A330 File Offset: 0x00048530
		public static Color32 LerpUnclamped(Color32 a, Color32 b, float t)
		{
			return new Color32((byte)((float)a.r + (float)(b.r - a.r) * t), (byte)((float)a.g + (float)(b.g - a.g) * t), (byte)((float)a.b + (float)(b.b - a.b) * t), (byte)((float)a.a + (float)(b.a - a.a) * t));
		}

		// Token: 0x060030DB RID: 12507 RVA: 0x0004A3BC File Offset: 0x000485BC
		public override string ToString()
		{
			return UnityString.Format("RGBA({0}, {1}, {2}, {3})", new object[]
			{
				this.r,
				this.g,
				this.b,
				this.a
			});
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x0004A41C File Offset: 0x0004861C
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

		// Token: 0x04000A7F RID: 2687
		public byte r;

		// Token: 0x04000A80 RID: 2688
		public byte g;

		// Token: 0x04000A81 RID: 2689
		public byte b;

		// Token: 0x04000A82 RID: 2690
		public byte a;
	}
}
