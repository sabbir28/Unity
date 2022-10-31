using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000063 RID: 99
	public sealed class GUITexture : GUIElement
	{
		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x00009600 File Offset: 0x00007800
		// (set) Token: 0x06000764 RID: 1892 RVA: 0x00009620 File Offset: 0x00007820
		public Color color
		{
			get
			{
				Color result;
				this.INTERNAL_get_color(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_color(ref value);
			}
		}

		// Token: 0x06000765 RID: 1893
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_color(out Color value);

		// Token: 0x06000766 RID: 1894
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_color(ref Color value);

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000767 RID: 1895
		// (set) Token: 0x06000768 RID: 1896
		public extern Texture texture { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x0000962C File Offset: 0x0000782C
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x0000964C File Offset: 0x0000784C
		public Rect pixelInset
		{
			get
			{
				Rect result;
				this.INTERNAL_get_pixelInset(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_pixelInset(ref value);
			}
		}

		// Token: 0x0600076B RID: 1899
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_pixelInset(out Rect value);

		// Token: 0x0600076C RID: 1900
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_pixelInset(ref Rect value);

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600076D RID: 1901
		// (set) Token: 0x0600076E RID: 1902
		public extern RectOffset border { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
