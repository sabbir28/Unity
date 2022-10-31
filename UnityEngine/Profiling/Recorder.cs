using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Profiling
{
	// Token: 0x020000F4 RID: 244
	[UsedByNativeCode]
	public sealed class Recorder
	{
		// Token: 0x06001155 RID: 4437 RVA: 0x000174BC File Offset: 0x000156BC
		internal Recorder()
		{
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x000174C8 File Offset: 0x000156C8
		~Recorder()
		{
			if (this.m_Ptr != IntPtr.Zero)
			{
				this.DisposeNative();
			}
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x00017510 File Offset: 0x00015710
		public static Recorder Get(string samplerName)
		{
			Sampler sampler = Sampler.Get(samplerName);
			return sampler.GetRecorder();
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x00017534 File Offset: 0x00015734
		public bool isValid
		{
			get
			{
				return this.m_Ptr != IntPtr.Zero;
			}
		}

		// Token: 0x06001159 RID: 4441
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void DisposeNative();

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x0600115A RID: 4442
		// (set) Token: 0x0600115B RID: 4443
		[ThreadAndSerializationSafe]
		public extern bool enabled { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x0600115C RID: 4444
		[ThreadAndSerializationSafe]
		public extern long elapsedNanoseconds { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x0600115D RID: 4445
		[ThreadAndSerializationSafe]
		public extern int sampleBlockCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0400022F RID: 559
		internal IntPtr m_Ptr;

		// Token: 0x04000230 RID: 560
		internal static Recorder s_InvalidRecorder = new Recorder();
	}
}
