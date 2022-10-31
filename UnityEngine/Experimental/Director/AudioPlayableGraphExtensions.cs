using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Director
{
	// Token: 0x020001DF RID: 479
	public static class AudioPlayableGraphExtensions
	{
		// Token: 0x06002120 RID: 8480
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int internalAudioOutputCount(ref PlayableGraph graph);

		// Token: 0x06002121 RID: 8481
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool InternalGetAudioOutput(ref PlayableGraph graph, int index, out PlayableOutput output);
	}
}
