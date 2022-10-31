using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000027 RID: 39
	public sealed class ColorUtility
	{
		// Token: 0x0600030D RID: 781
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool DoTryParseHtmlColor(string htmlString, out Color32 color);

		// Token: 0x0600030E RID: 782 RVA: 0x00005774 File Offset: 0x00003974
		public static bool TryParseHtmlString(string htmlString, out Color color)
		{
			Color32 c;
			bool result = ColorUtility.DoTryParseHtmlColor(htmlString, out c);
			color = c;
			return result;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x000057A0 File Offset: 0x000039A0
		public static string ToHtmlStringRGB(Color color)
		{
			Color32 color2 = new Color32((byte)Mathf.Clamp(Mathf.RoundToInt(color.r * 255f), 0, 255), (byte)Mathf.Clamp(Mathf.RoundToInt(color.g * 255f), 0, 255), (byte)Mathf.Clamp(Mathf.RoundToInt(color.b * 255f), 0, 255), 1);
			return string.Format("{0:X2}{1:X2}{2:X2}", color2.r, color2.g, color2.b);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00005848 File Offset: 0x00003A48
		public static string ToHtmlStringRGBA(Color color)
		{
			Color32 color2 = new Color32((byte)Mathf.Clamp(Mathf.RoundToInt(color.r * 255f), 0, 255), (byte)Mathf.Clamp(Mathf.RoundToInt(color.g * 255f), 0, 255), (byte)Mathf.Clamp(Mathf.RoundToInt(color.b * 255f), 0, 255), (byte)Mathf.Clamp(Mathf.RoundToInt(color.a * 255f), 0, 255));
			return string.Format("{0:X2}{1:X2}{2:X2}{3:X2}", new object[]
			{
				color2.r,
				color2.g,
				color2.b,
				color2.a
			});
		}
	}
}
