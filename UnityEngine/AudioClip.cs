using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001C8 RID: 456
	public sealed class AudioClip : Object
	{
		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06002014 RID: 8212
		public extern float length { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06002015 RID: 8213
		public extern int samples { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06002016 RID: 8214
		public extern int channels { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06002017 RID: 8215
		public extern int frequency { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06002018 RID: 8216
		[Obsolete("Use AudioClip.loadState instead to get more detailed information about the loading process.")]
		public extern bool isReadyToPlay { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06002019 RID: 8217
		public extern AudioClipLoadType loadType { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600201A RID: 8218
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool LoadAudioData();

		// Token: 0x0600201B RID: 8219
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool UnloadAudioData();

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x0600201C RID: 8220
		public extern bool preloadAudioData { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x0600201D RID: 8221
		public extern AudioDataLoadState loadState { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x0600201E RID: 8222
		public extern bool loadInBackground { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600201F RID: 8223
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool GetData(float[] data, int offsetSamples);

		// Token: 0x06002020 RID: 8224
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool SetData(float[] data, int offsetSamples);

		// Token: 0x06002021 RID: 8225 RVA: 0x0002666C File Offset: 0x0002486C
		[Obsolete("The _3D argument of AudioClip is deprecated. Use the spatialBlend property of AudioSource instead to morph between 2D and 3D playback.")]
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream)
		{
			return AudioClip.Create(name, lengthSamples, channels, frequency, stream);
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x0002668C File Offset: 0x0002488C
		[Obsolete("The _3D argument of AudioClip is deprecated. Use the spatialBlend property of AudioSource instead to morph between 2D and 3D playback.")]
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, AudioClip.PCMReaderCallback pcmreadercallback)
		{
			return AudioClip.Create(name, lengthSamples, channels, frequency, stream, pcmreadercallback, null);
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x000266B0 File Offset: 0x000248B0
		[Obsolete("The _3D argument of AudioClip is deprecated. Use the spatialBlend property of AudioSource instead to morph between 2D and 3D playback.")]
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, AudioClip.PCMReaderCallback pcmreadercallback, AudioClip.PCMSetPositionCallback pcmsetpositioncallback)
		{
			return AudioClip.Create(name, lengthSamples, channels, frequency, stream, pcmreadercallback, pcmsetpositioncallback);
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x000266D4 File Offset: 0x000248D4
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream)
		{
			return AudioClip.Create(name, lengthSamples, channels, frequency, stream, null, null);
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x000266F8 File Offset: 0x000248F8
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback)
		{
			return AudioClip.Create(name, lengthSamples, channels, frequency, stream, pcmreadercallback, null);
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x00026720 File Offset: 0x00024920
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback, AudioClip.PCMSetPositionCallback pcmsetpositioncallback)
		{
			if (name == null)
			{
				throw new NullReferenceException();
			}
			if (lengthSamples <= 0)
			{
				throw new ArgumentException("Length of created clip must be larger than 0");
			}
			if (channels <= 0)
			{
				throw new ArgumentException("Number of channels in created clip must be greater than 0");
			}
			if (frequency <= 0)
			{
				throw new ArgumentException("Frequency in created clip must be greater than 0");
			}
			AudioClip audioClip = AudioClip.Construct_Internal();
			if (pcmreadercallback != null)
			{
				audioClip.m_PCMReaderCallback += pcmreadercallback;
			}
			if (pcmsetpositioncallback != null)
			{
				audioClip.m_PCMSetPositionCallback += pcmsetpositioncallback;
			}
			audioClip.Init_Internal(name, lengthSamples, channels, frequency, stream);
			return audioClip;
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06002027 RID: 8231 RVA: 0x000267A8 File Offset: 0x000249A8
		// (remove) Token: 0x06002028 RID: 8232 RVA: 0x000267E0 File Offset: 0x000249E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private event AudioClip.PCMReaderCallback m_PCMReaderCallback = null;

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06002029 RID: 8233 RVA: 0x00026818 File Offset: 0x00024A18
		// (remove) Token: 0x0600202A RID: 8234 RVA: 0x00026850 File Offset: 0x00024A50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private event AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback = null;

		// Token: 0x0600202B RID: 8235 RVA: 0x00026888 File Offset: 0x00024A88
		[RequiredByNativeCode]
		private void InvokePCMReaderCallback_Internal(float[] data)
		{
			if (this.m_PCMReaderCallback != null)
			{
				this.m_PCMReaderCallback(data);
			}
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x000268A4 File Offset: 0x00024AA4
		[RequiredByNativeCode]
		private void InvokePCMSetPositionCallback_Internal(int position)
		{
			if (this.m_PCMSetPositionCallback != null)
			{
				this.m_PCMSetPositionCallback(position);
			}
		}

		// Token: 0x0600202D RID: 8237
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AudioClip Construct_Internal();

		// Token: 0x0600202E RID: 8238
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Init_Internal(string name, int lengthSamples, int channels, int frequency, bool stream);

		// Token: 0x020001C9 RID: 457
		// (Invoke) Token: 0x06002030 RID: 8240
		public delegate void PCMReaderCallback(float[] data);

		// Token: 0x020001CA RID: 458
		// (Invoke) Token: 0x06002034 RID: 8244
		public delegate void PCMSetPositionCallback(int position);
	}
}
