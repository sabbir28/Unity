using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Video
{
	// Token: 0x020002E9 RID: 745
	public sealed class VideoClip : Object
	{
		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06002F48 RID: 12104
		public extern string originalPath { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06002F49 RID: 12105
		public extern ulong frameCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06002F4A RID: 12106
		public extern double frameRate { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06002F4B RID: 12107
		public extern double length { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06002F4C RID: 12108
		public extern uint width { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06002F4D RID: 12109
		public extern uint height { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06002F4E RID: 12110
		public extern ushort audioTrackCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002F4F RID: 12111 RVA: 0x00045830 File Offset: 0x00043A30
		public ushort GetAudioChannelCount(ushort audioTrackIdx)
		{
			return VideoClip.INTERNAL_CALL_GetAudioChannelCount(this, audioTrackIdx);
		}

		// Token: 0x06002F50 RID: 12112
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ushort INTERNAL_CALL_GetAudioChannelCount(VideoClip self, ushort audioTrackIdx);

		// Token: 0x06002F51 RID: 12113 RVA: 0x0004584C File Offset: 0x00043A4C
		public uint GetAudioSampleRate(ushort audioTrackIdx)
		{
			return VideoClip.INTERNAL_CALL_GetAudioSampleRate(this, audioTrackIdx);
		}

		// Token: 0x06002F52 RID: 12114
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint INTERNAL_CALL_GetAudioSampleRate(VideoClip self, ushort audioTrackIdx);

		// Token: 0x06002F53 RID: 12115
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string GetAudioLanguage(ushort audioTrackIdx);
	}
}
