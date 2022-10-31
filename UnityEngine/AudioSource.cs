using System;
using System.Runtime.CompilerServices;
using UnityEngine.Audio;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001D1 RID: 465
	[RequireComponent(typeof(Transform))]
	public sealed class AudioSource : Behaviour
	{
		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06002046 RID: 8262
		// (set) Token: 0x06002047 RID: 8263
		public extern float volume { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06002048 RID: 8264
		// (set) Token: 0x06002049 RID: 8265
		public extern float pitch { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x0600204A RID: 8266
		// (set) Token: 0x0600204B RID: 8267
		public extern float time { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x0600204C RID: 8268
		// (set) Token: 0x0600204D RID: 8269
		[ThreadAndSerializationSafe]
		public extern int timeSamples { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x0600204E RID: 8270
		// (set) Token: 0x0600204F RID: 8271
		[ThreadAndSerializationSafe]
		public extern AudioClip clip { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06002050 RID: 8272
		// (set) Token: 0x06002051 RID: 8273
		public extern AudioMixerGroup outputAudioMixerGroup { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002052 RID: 8274
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Play([DefaultValue("0")] ulong delay);

		// Token: 0x06002053 RID: 8275 RVA: 0x0002693C File Offset: 0x00024B3C
		[ExcludeFromDocs]
		public void Play()
		{
			ulong delay = 0UL;
			this.Play(delay);
		}

		// Token: 0x06002054 RID: 8276
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void PlayDelayed(float delay);

		// Token: 0x06002055 RID: 8277
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void PlayScheduled(double time);

		// Token: 0x06002056 RID: 8278
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetScheduledStartTime(double time);

		// Token: 0x06002057 RID: 8279
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetScheduledEndTime(double time);

		// Token: 0x06002058 RID: 8280
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Stop();

		// Token: 0x06002059 RID: 8281 RVA: 0x00026954 File Offset: 0x00024B54
		public void Pause()
		{
			AudioSource.INTERNAL_CALL_Pause(this);
		}

		// Token: 0x0600205A RID: 8282
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Pause(AudioSource self);

		// Token: 0x0600205B RID: 8283 RVA: 0x00026960 File Offset: 0x00024B60
		public void UnPause()
		{
			AudioSource.INTERNAL_CALL_UnPause(this);
		}

		// Token: 0x0600205C RID: 8284
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_UnPause(AudioSource self);

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x0600205D RID: 8285
		public extern bool isPlaying { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x0600205E RID: 8286
		public extern bool isVirtual { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600205F RID: 8287
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void PlayOneShot(AudioClip clip, [DefaultValue("1.0F")] float volumeScale);

		// Token: 0x06002060 RID: 8288 RVA: 0x0002696C File Offset: 0x00024B6C
		[ExcludeFromDocs]
		public void PlayOneShot(AudioClip clip)
		{
			float volumeScale = 1f;
			this.PlayOneShot(clip, volumeScale);
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x00026988 File Offset: 0x00024B88
		[ExcludeFromDocs]
		public static void PlayClipAtPoint(AudioClip clip, Vector3 position)
		{
			float volume = 1f;
			AudioSource.PlayClipAtPoint(clip, position, volume);
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x000269A4 File Offset: 0x00024BA4
		public static void PlayClipAtPoint(AudioClip clip, Vector3 position, [DefaultValue("1.0F")] float volume)
		{
			GameObject gameObject = new GameObject("One shot audio");
			gameObject.transform.position = position;
			AudioSource audioSource = (AudioSource)gameObject.AddComponent(typeof(AudioSource));
			audioSource.clip = clip;
			audioSource.spatialBlend = 1f;
			audioSource.volume = volume;
			audioSource.Play();
			Object.Destroy(gameObject, clip.length * ((Time.timeScale >= 0.01f) ? Time.timeScale : 0.01f));
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06002063 RID: 8291
		// (set) Token: 0x06002064 RID: 8292
		public extern bool loop { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06002065 RID: 8293
		// (set) Token: 0x06002066 RID: 8294
		public extern bool ignoreListenerVolume { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06002067 RID: 8295
		// (set) Token: 0x06002068 RID: 8296
		public extern bool playOnAwake { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06002069 RID: 8297
		// (set) Token: 0x0600206A RID: 8298
		public extern bool ignoreListenerPause { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x0600206B RID: 8299
		// (set) Token: 0x0600206C RID: 8300
		public extern AudioVelocityUpdateMode velocityUpdateMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x0600206D RID: 8301
		// (set) Token: 0x0600206E RID: 8302
		public extern float panStereo { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x0600206F RID: 8303
		// (set) Token: 0x06002070 RID: 8304
		public extern float spatialBlend { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06002071 RID: 8305
		// (set) Token: 0x06002072 RID: 8306
		public extern bool spatialize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06002073 RID: 8307
		// (set) Token: 0x06002074 RID: 8308
		public extern bool spatializePostEffects { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002075 RID: 8309
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve);

		// Token: 0x06002076 RID: 8310
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AnimationCurve GetCustomCurve(AudioSourceCurveType type);

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06002077 RID: 8311
		// (set) Token: 0x06002078 RID: 8312
		public extern float reverbZoneMix { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06002079 RID: 8313
		// (set) Token: 0x0600207A RID: 8314
		public extern bool bypassEffects { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x0600207B RID: 8315
		// (set) Token: 0x0600207C RID: 8316
		public extern bool bypassListenerEffects { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x0600207D RID: 8317
		// (set) Token: 0x0600207E RID: 8318
		public extern bool bypassReverbZones { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x0600207F RID: 8319
		// (set) Token: 0x06002080 RID: 8320
		public extern float dopplerLevel { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06002081 RID: 8321
		// (set) Token: 0x06002082 RID: 8322
		public extern float spread { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06002083 RID: 8323
		// (set) Token: 0x06002084 RID: 8324
		public extern int priority { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06002085 RID: 8325
		// (set) Token: 0x06002086 RID: 8326
		public extern bool mute { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06002087 RID: 8327
		// (set) Token: 0x06002088 RID: 8328
		public extern float minDistance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06002089 RID: 8329
		// (set) Token: 0x0600208A RID: 8330
		public extern float maxDistance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x0600208B RID: 8331
		// (set) Token: 0x0600208C RID: 8332
		public extern AudioRolloffMode rolloffMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x0600208D RID: 8333
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetOutputDataHelper(float[] samples, int channel);

		// Token: 0x0600208E RID: 8334 RVA: 0x00026A2C File Offset: 0x00024C2C
		[Obsolete("GetOutputData return a float[] is deprecated, use GetOutputData passing a pre allocated array instead.")]
		public float[] GetOutputData(int numSamples, int channel)
		{
			float[] array = new float[numSamples];
			this.GetOutputDataHelper(array, channel);
			return array;
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x00026A54 File Offset: 0x00024C54
		public void GetOutputData(float[] samples, int channel)
		{
			this.GetOutputDataHelper(samples, channel);
		}

		// Token: 0x06002090 RID: 8336
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetSpectrumDataHelper(float[] samples, int channel, FFTWindow window);

		// Token: 0x06002091 RID: 8337 RVA: 0x00026A60 File Offset: 0x00024C60
		[Obsolete("GetSpectrumData returning a float[] is deprecated, use GetSpectrumData passing a pre allocated array instead.")]
		public float[] GetSpectrumData(int numSamples, int channel, FFTWindow window)
		{
			float[] array = new float[numSamples];
			this.GetSpectrumDataHelper(array, channel, window);
			return array;
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x00026A88 File Offset: 0x00024C88
		public void GetSpectrumData(float[] samples, int channel, FFTWindow window)
		{
			this.GetSpectrumDataHelper(samples, channel, window);
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06002093 RID: 8339
		// (set) Token: 0x06002094 RID: 8340
		[Obsolete("minVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.", true)]
		public extern float minVolume { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06002095 RID: 8341
		// (set) Token: 0x06002096 RID: 8342
		[Obsolete("maxVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.", true)]
		public extern float maxVolume { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06002097 RID: 8343
		// (set) Token: 0x06002098 RID: 8344
		[Obsolete("rolloffFactor is not supported anymore. Use min-, maxDistance and rolloffMode instead.", true)]
		public extern float rolloffFactor { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002099 RID: 8345
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool SetSpatializerFloat(int index, float value);

		// Token: 0x0600209A RID: 8346
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool GetSpatializerFloat(int index, out float value);
	}
}
