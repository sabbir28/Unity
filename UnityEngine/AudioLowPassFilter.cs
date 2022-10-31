using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001D4 RID: 468
	[RequireComponent(typeof(AudioBehaviour))]
	public sealed class AudioLowPassFilter : Behaviour
	{
		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x060020BF RID: 8383
		// (set) Token: 0x060020C0 RID: 8384
		public extern float cutoffFrequency { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x060020C1 RID: 8385
		// (set) Token: 0x060020C2 RID: 8386
		public extern AnimationCurve customCutoffCurve { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x060020C3 RID: 8387
		// (set) Token: 0x060020C4 RID: 8388
		public extern float lowpassResonanceQ { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
