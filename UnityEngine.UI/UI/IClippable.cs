using System;

namespace UnityEngine.UI
{
	// Token: 0x02000085 RID: 133
	public interface IClippable
	{
		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060004EF RID: 1263
		GameObject gameObject { get; }

		// Token: 0x060004F0 RID: 1264
		void RecalculateClipping();

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060004F1 RID: 1265
		RectTransform rectTransform { get; }

		// Token: 0x060004F2 RID: 1266
		void Cull(Rect clipRect, bool validRect);

		// Token: 0x060004F3 RID: 1267
		void SetClipRect(Rect value, bool validRect);
	}
}
