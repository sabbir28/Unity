using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001D8 RID: 472
	[RequireComponent(typeof(AudioBehaviour))]
	public sealed class AudioChorusFilter : Behaviour
	{
		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060020D7 RID: 8407
		// (set) Token: 0x060020D8 RID: 8408
		public extern float dryMix { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x060020D9 RID: 8409
		// (set) Token: 0x060020DA RID: 8410
		public extern float wetMix1 { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x060020DB RID: 8411
		// (set) Token: 0x060020DC RID: 8412
		public extern float wetMix2 { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x060020DD RID: 8413
		// (set) Token: 0x060020DE RID: 8414
		public extern float wetMix3 { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x060020DF RID: 8415
		// (set) Token: 0x060020E0 RID: 8416
		public extern float delay { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x060020E1 RID: 8417
		// (set) Token: 0x060020E2 RID: 8418
		public extern float rate { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x060020E3 RID: 8419
		// (set) Token: 0x060020E4 RID: 8420
		public extern float depth { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x060020E5 RID: 8421
		// (set) Token: 0x060020E6 RID: 8422
		[Obsolete("feedback is deprecated, this property does nothing.")]
		public extern float feedback { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
