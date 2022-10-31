using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Audio
{
	// Token: 0x020001DD RID: 477
	public class AudioMixerSnapshot : Object
	{
		// Token: 0x0600211B RID: 8475 RVA: 0x00026BA8 File Offset: 0x00024DA8
		internal AudioMixerSnapshot()
		{
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x0600211C RID: 8476
		public extern AudioMixer audioMixer { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600211D RID: 8477
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void TransitionTo(float timeToReach);
	}
}
