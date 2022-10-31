using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000236 RID: 566
	public sealed class GUIText : GUIElement
	{
		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x060025CF RID: 9679
		// (set) Token: 0x060025D0 RID: 9680
		public extern string text { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x060025D1 RID: 9681
		// (set) Token: 0x060025D2 RID: 9682
		public extern Material material { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060025D3 RID: 9683
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_GetPixelOffset(out Vector2 output);

		// Token: 0x060025D4 RID: 9684 RVA: 0x0002B78C File Offset: 0x0002998C
		private void Internal_SetPixelOffset(Vector2 p)
		{
			GUIText.INTERNAL_CALL_Internal_SetPixelOffset(this, ref p);
		}

		// Token: 0x060025D5 RID: 9685
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_SetPixelOffset(GUIText self, ref Vector2 p);

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x060025D6 RID: 9686 RVA: 0x0002B798 File Offset: 0x00029998
		// (set) Token: 0x060025D7 RID: 9687 RVA: 0x0002B7B8 File Offset: 0x000299B8
		public Vector2 pixelOffset
		{
			get
			{
				Vector2 result;
				this.Internal_GetPixelOffset(out result);
				return result;
			}
			set
			{
				this.Internal_SetPixelOffset(value);
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x060025D8 RID: 9688
		// (set) Token: 0x060025D9 RID: 9689
		public extern Font font { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x060025DA RID: 9690
		// (set) Token: 0x060025DB RID: 9691
		public extern TextAlignment alignment { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x060025DC RID: 9692
		// (set) Token: 0x060025DD RID: 9693
		public extern TextAnchor anchor { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x060025DE RID: 9694
		// (set) Token: 0x060025DF RID: 9695
		public extern float lineSpacing { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x060025E0 RID: 9696
		// (set) Token: 0x060025E1 RID: 9697
		public extern float tabSize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x060025E2 RID: 9698
		// (set) Token: 0x060025E3 RID: 9699
		public extern int fontSize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x060025E4 RID: 9700
		// (set) Token: 0x060025E5 RID: 9701
		public extern FontStyle fontStyle { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x060025E6 RID: 9702
		// (set) Token: 0x060025E7 RID: 9703
		public extern bool richText { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x060025E8 RID: 9704 RVA: 0x0002B7C4 File Offset: 0x000299C4
		// (set) Token: 0x060025E9 RID: 9705 RVA: 0x0002B7E4 File Offset: 0x000299E4
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

		// Token: 0x060025EA RID: 9706
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_color(out Color value);

		// Token: 0x060025EB RID: 9707
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_color(ref Color value);
	}
}
