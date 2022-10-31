using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Video
{
	// Token: 0x020002E5 RID: 741
	[RequireComponent(typeof(Transform))]
	public sealed class VideoPlayer : Behaviour
	{
		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06002ED4 RID: 11988
		// (set) Token: 0x06002ED5 RID: 11989
		public extern VideoSource source { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06002ED6 RID: 11990
		// (set) Token: 0x06002ED7 RID: 11991
		public extern string url { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06002ED8 RID: 11992
		// (set) Token: 0x06002ED9 RID: 11993
		public extern VideoClip clip { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06002EDA RID: 11994
		// (set) Token: 0x06002EDB RID: 11995
		public extern VideoRenderMode renderMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06002EDC RID: 11996
		// (set) Token: 0x06002EDD RID: 11997
		public extern Camera targetCamera { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06002EDE RID: 11998
		// (set) Token: 0x06002EDF RID: 11999
		public extern RenderTexture targetTexture { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06002EE0 RID: 12000
		// (set) Token: 0x06002EE1 RID: 12001
		public extern Renderer targetMaterialRenderer { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06002EE2 RID: 12002
		// (set) Token: 0x06002EE3 RID: 12003
		public extern string targetMaterialProperty { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06002EE4 RID: 12004
		// (set) Token: 0x06002EE5 RID: 12005
		public extern VideoAspectRatio aspectRatio { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06002EE6 RID: 12006
		// (set) Token: 0x06002EE7 RID: 12007
		public extern float targetCameraAlpha { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06002EE8 RID: 12008
		public extern Texture texture { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002EE9 RID: 12009 RVA: 0x00045384 File Offset: 0x00043584
		public void Prepare()
		{
			VideoPlayer.INTERNAL_CALL_Prepare(this);
		}

		// Token: 0x06002EEA RID: 12010
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Prepare(VideoPlayer self);

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06002EEB RID: 12011
		public extern bool isPrepared { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06002EEC RID: 12012
		// (set) Token: 0x06002EED RID: 12013
		public extern bool waitForFirstFrame { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06002EEE RID: 12014
		// (set) Token: 0x06002EEF RID: 12015
		public extern bool playOnAwake { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002EF0 RID: 12016 RVA: 0x00045390 File Offset: 0x00043590
		public void Play()
		{
			VideoPlayer.INTERNAL_CALL_Play(this);
		}

		// Token: 0x06002EF1 RID: 12017
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Play(VideoPlayer self);

		// Token: 0x06002EF2 RID: 12018 RVA: 0x0004539C File Offset: 0x0004359C
		public void Pause()
		{
			VideoPlayer.INTERNAL_CALL_Pause(this);
		}

		// Token: 0x06002EF3 RID: 12019
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Pause(VideoPlayer self);

		// Token: 0x06002EF4 RID: 12020 RVA: 0x000453A8 File Offset: 0x000435A8
		public void Stop()
		{
			VideoPlayer.INTERNAL_CALL_Stop(this);
		}

		// Token: 0x06002EF5 RID: 12021
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Stop(VideoPlayer self);

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06002EF6 RID: 12022
		public extern bool isPlaying { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06002EF7 RID: 12023
		public extern bool canSetTime { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06002EF8 RID: 12024
		// (set) Token: 0x06002EF9 RID: 12025
		public extern double time { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06002EFA RID: 12026
		// (set) Token: 0x06002EFB RID: 12027
		public extern long frame { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06002EFC RID: 12028
		public extern bool canStep { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002EFD RID: 12029
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void StepForward();

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06002EFE RID: 12030
		public extern bool canSetPlaybackSpeed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06002EFF RID: 12031
		// (set) Token: 0x06002F00 RID: 12032
		public extern float playbackSpeed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06002F01 RID: 12033
		// (set) Token: 0x06002F02 RID: 12034
		public extern bool isLooping { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06002F03 RID: 12035
		public extern bool canSetTimeSource { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06002F04 RID: 12036
		// (set) Token: 0x06002F05 RID: 12037
		public extern VideoTimeSource timeSource { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06002F06 RID: 12038
		public extern bool canSetSkipOnDrop { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06002F07 RID: 12039
		// (set) Token: 0x06002F08 RID: 12040
		public extern bool skipOnDrop { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06002F09 RID: 12041
		public extern ulong frameCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06002F0A RID: 12042
		public extern float frameRate { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06002F0B RID: 12043
		public extern ushort audioTrackCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002F0C RID: 12044
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string GetAudioLanguageCode(ushort trackIndex);

		// Token: 0x06002F0D RID: 12045 RVA: 0x000453B4 File Offset: 0x000435B4
		public ushort GetAudioChannelCount(ushort trackIndex)
		{
			return VideoPlayer.INTERNAL_CALL_GetAudioChannelCount(this, trackIndex);
		}

		// Token: 0x06002F0E RID: 12046
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ushort INTERNAL_CALL_GetAudioChannelCount(VideoPlayer self, ushort trackIndex);

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06002F0F RID: 12047
		public static extern ushort controlledAudioTrackMaxCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06002F10 RID: 12048
		// (set) Token: 0x06002F11 RID: 12049
		public extern ushort controlledAudioTrackCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002F12 RID: 12050 RVA: 0x000453D0 File Offset: 0x000435D0
		public void EnableAudioTrack(ushort trackIndex, bool enabled)
		{
			VideoPlayer.INTERNAL_CALL_EnableAudioTrack(this, trackIndex, enabled);
		}

		// Token: 0x06002F13 RID: 12051
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_EnableAudioTrack(VideoPlayer self, ushort trackIndex, bool enabled);

		// Token: 0x06002F14 RID: 12052 RVA: 0x000453DC File Offset: 0x000435DC
		public bool IsAudioTrackEnabled(ushort trackIndex)
		{
			return VideoPlayer.INTERNAL_CALL_IsAudioTrackEnabled(this, trackIndex);
		}

		// Token: 0x06002F15 RID: 12053
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_IsAudioTrackEnabled(VideoPlayer self, ushort trackIndex);

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06002F16 RID: 12054
		// (set) Token: 0x06002F17 RID: 12055
		public extern VideoAudioOutputMode audioOutputMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06002F18 RID: 12056
		public extern bool canSetDirectAudioVolume { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002F19 RID: 12057 RVA: 0x000453F8 File Offset: 0x000435F8
		public float GetDirectAudioVolume(ushort trackIndex)
		{
			return VideoPlayer.INTERNAL_CALL_GetDirectAudioVolume(this, trackIndex);
		}

		// Token: 0x06002F1A RID: 12058
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float INTERNAL_CALL_GetDirectAudioVolume(VideoPlayer self, ushort trackIndex);

		// Token: 0x06002F1B RID: 12059 RVA: 0x00045414 File Offset: 0x00043614
		public void SetDirectAudioVolume(ushort trackIndex, float volume)
		{
			VideoPlayer.INTERNAL_CALL_SetDirectAudioVolume(this, trackIndex, volume);
		}

		// Token: 0x06002F1C RID: 12060
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetDirectAudioVolume(VideoPlayer self, ushort trackIndex, float volume);

		// Token: 0x06002F1D RID: 12061 RVA: 0x00045420 File Offset: 0x00043620
		public bool GetDirectAudioMute(ushort trackIndex)
		{
			return VideoPlayer.INTERNAL_CALL_GetDirectAudioMute(this, trackIndex);
		}

		// Token: 0x06002F1E RID: 12062
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_GetDirectAudioMute(VideoPlayer self, ushort trackIndex);

		// Token: 0x06002F1F RID: 12063 RVA: 0x0004543C File Offset: 0x0004363C
		public void SetDirectAudioMute(ushort trackIndex, bool mute)
		{
			VideoPlayer.INTERNAL_CALL_SetDirectAudioMute(this, trackIndex, mute);
		}

		// Token: 0x06002F20 RID: 12064
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetDirectAudioMute(VideoPlayer self, ushort trackIndex, bool mute);

		// Token: 0x06002F21 RID: 12065
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AudioSource GetTargetAudioSource(ushort trackIndex);

		// Token: 0x06002F22 RID: 12066 RVA: 0x00045448 File Offset: 0x00043648
		public void SetTargetAudioSource(ushort trackIndex, AudioSource source)
		{
			VideoPlayer.INTERNAL_CALL_SetTargetAudioSource(this, trackIndex, source);
		}

		// Token: 0x06002F23 RID: 12067
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetTargetAudioSource(VideoPlayer self, ushort trackIndex, AudioSource source);

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06002F24 RID: 12068 RVA: 0x00045454 File Offset: 0x00043654
		// (remove) Token: 0x06002F25 RID: 12069 RVA: 0x0004548C File Offset: 0x0004368C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event VideoPlayer.EventHandler prepareCompleted;

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06002F26 RID: 12070 RVA: 0x000454C4 File Offset: 0x000436C4
		// (remove) Token: 0x06002F27 RID: 12071 RVA: 0x000454FC File Offset: 0x000436FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event VideoPlayer.EventHandler loopPointReached;

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06002F28 RID: 12072 RVA: 0x00045534 File Offset: 0x00043734
		// (remove) Token: 0x06002F29 RID: 12073 RVA: 0x0004556C File Offset: 0x0004376C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event VideoPlayer.EventHandler started;

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06002F2A RID: 12074 RVA: 0x000455A4 File Offset: 0x000437A4
		// (remove) Token: 0x06002F2B RID: 12075 RVA: 0x000455DC File Offset: 0x000437DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event VideoPlayer.EventHandler frameDropped;

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06002F2C RID: 12076 RVA: 0x00045614 File Offset: 0x00043814
		// (remove) Token: 0x06002F2D RID: 12077 RVA: 0x0004564C File Offset: 0x0004384C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event VideoPlayer.ErrorEventHandler errorReceived;

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06002F2E RID: 12078 RVA: 0x00045684 File Offset: 0x00043884
		// (remove) Token: 0x06002F2F RID: 12079 RVA: 0x000456BC File Offset: 0x000438BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event VideoPlayer.EventHandler seekCompleted;

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06002F30 RID: 12080
		// (set) Token: 0x06002F31 RID: 12081
		public extern bool sendFrameReadyEvents { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06002F32 RID: 12082 RVA: 0x000456F4 File Offset: 0x000438F4
		// (remove) Token: 0x06002F33 RID: 12083 RVA: 0x0004572C File Offset: 0x0004392C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event VideoPlayer.FrameReadyEventHandler frameReady;

		// Token: 0x06002F34 RID: 12084 RVA: 0x00045764 File Offset: 0x00043964
		[RequiredByNativeCode]
		private static void InvokePrepareCompletedCallback_Internal(VideoPlayer source)
		{
			if (source.prepareCompleted != null)
			{
				source.prepareCompleted(source);
			}
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x00045780 File Offset: 0x00043980
		[RequiredByNativeCode]
		private static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx)
		{
			if (source.frameReady != null)
			{
				source.frameReady(source, frameIdx);
			}
		}

		// Token: 0x06002F36 RID: 12086 RVA: 0x0004579C File Offset: 0x0004399C
		[RequiredByNativeCode]
		private static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source)
		{
			if (source.loopPointReached != null)
			{
				source.loopPointReached(source);
			}
		}

		// Token: 0x06002F37 RID: 12087 RVA: 0x000457B8 File Offset: 0x000439B8
		[RequiredByNativeCode]
		private static void InvokeStartedCallback_Internal(VideoPlayer source)
		{
			if (source.started != null)
			{
				source.started(source);
			}
		}

		// Token: 0x06002F38 RID: 12088 RVA: 0x000457D4 File Offset: 0x000439D4
		[RequiredByNativeCode]
		private static void InvokeFrameDroppedCallback_Internal(VideoPlayer source)
		{
			if (source.frameDropped != null)
			{
				source.frameDropped(source);
			}
		}

		// Token: 0x06002F39 RID: 12089 RVA: 0x000457F0 File Offset: 0x000439F0
		[RequiredByNativeCode]
		private static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr)
		{
			if (source.errorReceived != null)
			{
				source.errorReceived(source, errorStr);
			}
		}

		// Token: 0x06002F3A RID: 12090 RVA: 0x0004580C File Offset: 0x00043A0C
		[RequiredByNativeCode]
		private static void InvokeSeekCompletedCallback_Internal(VideoPlayer source)
		{
			if (source.seekCompleted != null)
			{
				source.seekCompleted(source);
			}
		}

		// Token: 0x020002E6 RID: 742
		// (Invoke) Token: 0x06002F3C RID: 12092
		public delegate void EventHandler(VideoPlayer source);

		// Token: 0x020002E7 RID: 743
		// (Invoke) Token: 0x06002F40 RID: 12096
		public delegate void ErrorEventHandler(VideoPlayer source, string message);

		// Token: 0x020002E8 RID: 744
		// (Invoke) Token: 0x06002F44 RID: 12100
		public delegate void FrameReadyEventHandler(VideoPlayer source, long frameIdx);
	}
}
