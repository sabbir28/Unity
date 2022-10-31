using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001CD RID: 461
	[RequireComponent(typeof(Transform))]
	public sealed class AudioListener : Behaviour
	{
		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06002039 RID: 8249
		// (set) Token: 0x0600203A RID: 8250
		public static extern float volume { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x0600203B RID: 8251
		// (set) Token: 0x0600203C RID: 8252
		public static extern bool pause { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x0600203D RID: 8253
		// (set) Token: 0x0600203E RID: 8254
		public extern AudioVelocityUpdateMode velocityUpdateMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x0600203F RID: 8255
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetOutputDataHelper(float[] samples, int channel);

		// Token: 0x06002040 RID: 8256
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetSpectrumDataHelper(float[] samples, int channel, FFTWindow window);

		// Token: 0x06002041 RID: 8257 RVA: 0x000268D0 File Offset: 0x00024AD0
		[Obsolete("GetOutputData returning a float[] is deprecated, use GetOutputData and pass a pre allocated array instead.")]
		public static float[] GetOutputData(int numSamples, int channel)
		{
			float[] array = new float[numSamples];
			AudioListener.GetOutputDataHelper(array, channel);
			return array;
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x000268F4 File Offset: 0x00024AF4
		public static void GetOutputData(float[] samples, int channel)
		{
			AudioListener.GetOutputDataHelper(samples, channel);
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x00026900 File Offset: 0x00024B00
		[Obsolete("GetSpectrumData returning a float[] is deprecated, use GetOutputData and pass a pre allocated array instead.")]
		public static float[] GetSpectrumData(int numSamples, int channel, FFTWindow window)
		{
			float[] array = new float[numSamples];
			AudioListener.GetSpectrumDataHelper(array, channel, window);
			return array;
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x00026928 File Offset: 0x00024B28
		public static void GetSpectrumData(float[] samples, int channel, FFTWindow window)
		{
			AudioListener.GetSpectrumDataHelper(samples, channel, window);
		}
	}
}
