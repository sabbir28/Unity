using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001C4 RID: 452
	public sealed class AudioSettings
	{
		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06001FFE RID: 8190
		public static extern AudioSpeakerMode driverCapabilities { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06001FFF RID: 8191
		// (set) Token: 0x06002000 RID: 8192
		public static extern AudioSpeakerMode speakerMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06002001 RID: 8193
		internal static extern int profilerCaptureFlags { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06002002 RID: 8194
		[ThreadAndSerializationSafe]
		public static extern double dspTime { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06002003 RID: 8195
		// (set) Token: 0x06002004 RID: 8196
		public static extern int outputSampleRate { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002005 RID: 8197
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetDSPBufferSize(out int bufferLength, out int numBuffers);

		// Token: 0x06002006 RID: 8198
		[Obsolete("AudioSettings.SetDSPBufferSize is deprecated and has been replaced by audio project settings and the AudioSettings.GetConfiguration/AudioSettings.Reset API.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetDSPBufferSize(int bufferLength, int numBuffers);

		// Token: 0x06002007 RID: 8199 RVA: 0x00026598 File Offset: 0x00024798
		public static AudioConfiguration GetConfiguration()
		{
			AudioConfiguration result;
			AudioSettings.INTERNAL_CALL_GetConfiguration(out result);
			return result;
		}

		// Token: 0x06002008 RID: 8200
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetConfiguration(out AudioConfiguration value);

		// Token: 0x06002009 RID: 8201 RVA: 0x000265B8 File Offset: 0x000247B8
		public static bool Reset(AudioConfiguration config)
		{
			return AudioSettings.INTERNAL_CALL_Reset(ref config);
		}

		// Token: 0x0600200A RID: 8202
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Reset(ref AudioConfiguration config);

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x0600200B RID: 8203 RVA: 0x000265D4 File Offset: 0x000247D4
		// (remove) Token: 0x0600200C RID: 8204 RVA: 0x00026608 File Offset: 0x00024808
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged;

		// Token: 0x0600200D RID: 8205 RVA: 0x0002663C File Offset: 0x0002483C
		[RequiredByNativeCode]
		internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged)
		{
			if (AudioSettings.OnAudioConfigurationChanged != null)
			{
				AudioSettings.OnAudioConfigurationChanged(deviceWasChanged);
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x0600200E RID: 8206
		internal static extern bool unityAudioDisabled { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x020001C5 RID: 453
		// (Invoke) Token: 0x06002010 RID: 8208
		public delegate void AudioConfigurationChangeHandler(bool deviceWasChanged);
	}
}
