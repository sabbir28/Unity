using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001D5 RID: 469
	[RequireComponent(typeof(AudioBehaviour))]
	public sealed class AudioHighPassFilter : Behaviour
	{
		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x060020C6 RID: 8390
		// (set) Token: 0x060020C7 RID: 8391
		public extern float cutoffFrequency { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x060020C8 RID: 8392
		// (set) Token: 0x060020C9 RID: 8393
		public extern float highpassResonanceQ { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
