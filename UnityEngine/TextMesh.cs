using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000237 RID: 567
	[RequireComponent(typeof(Transform), typeof(MeshRenderer))]
	[NativeClass("TextRenderingPrivate::TextMesh")]
	public sealed class TextMesh : Component
	{
		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x060025ED RID: 9709
		// (set) Token: 0x060025EE RID: 9710
		public extern string text { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x060025EF RID: 9711
		// (set) Token: 0x060025F0 RID: 9712
		public extern Font font { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x060025F1 RID: 9713
		// (set) Token: 0x060025F2 RID: 9714
		public extern int fontSize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x060025F3 RID: 9715
		// (set) Token: 0x060025F4 RID: 9716
		public extern FontStyle fontStyle { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x060025F5 RID: 9717
		// (set) Token: 0x060025F6 RID: 9718
		public extern float offsetZ { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x060025F7 RID: 9719
		// (set) Token: 0x060025F8 RID: 9720
		public extern TextAlignment alignment { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x060025F9 RID: 9721
		// (set) Token: 0x060025FA RID: 9722
		public extern TextAnchor anchor { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x060025FB RID: 9723
		// (set) Token: 0x060025FC RID: 9724
		public extern float characterSize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x060025FD RID: 9725
		// (set) Token: 0x060025FE RID: 9726
		public extern float lineSpacing { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x060025FF RID: 9727
		// (set) Token: 0x06002600 RID: 9728
		public extern float tabSize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06002601 RID: 9729
		// (set) Token: 0x06002602 RID: 9730
		public extern bool richText { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06002603 RID: 9731 RVA: 0x0002B7F8 File Offset: 0x000299F8
		// (set) Token: 0x06002604 RID: 9732 RVA: 0x0002B818 File Offset: 0x00029A18
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

		// Token: 0x06002605 RID: 9733
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_color(out Color value);

		// Token: 0x06002606 RID: 9734
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_color(ref Color value);
	}
}
