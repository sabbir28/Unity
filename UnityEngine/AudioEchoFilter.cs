using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001D7 RID: 471
	[RequireComponent(typeof(AudioBehaviour))]
	public sealed class AudioEchoFilter : Behaviour
	{
		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x060020CE RID: 8398
		// (set) Token: 0x060020CF RID: 8399
		public extern float delay { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x060020D0 RID: 8400
		// (set) Token: 0x060020D1 RID: 8401
		public extern float decayRatio { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x060020D2 RID: 8402
		// (set) Token: 0x060020D3 RID: 8403
		public extern float dryMix { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x060020D4 RID: 8404
		// (set) Token: 0x060020D5 RID: 8405
		public extern float wetMix { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
