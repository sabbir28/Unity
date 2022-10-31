using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Profiling
{
	// Token: 0x020000F5 RID: 245
	[UsedByNativeCode]
	public class Sampler
	{
		// Token: 0x0600115F RID: 4447 RVA: 0x00017568 File Offset: 0x00015768
		internal Sampler()
		{
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x00017574 File Offset: 0x00015774
		public bool isValid
		{
			get
			{
				return this.m_Ptr != IntPtr.Zero;
			}
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x0001759C File Offset: 0x0001579C
		public Recorder GetRecorder()
		{
			Recorder recorderInternal = this.GetRecorderInternal();
			return recorderInternal ?? Recorder.s_InvalidRecorder;
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x000175C8 File Offset: 0x000157C8
		public static Sampler Get(string name)
		{
			Sampler samplerInternal = Sampler.GetSamplerInternal(name);
			return samplerInternal ?? Sampler.s_InvalidSampler;
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x000175F4 File Offset: 0x000157F4
		public static int GetNames(List<string> names)
		{
			return Sampler.GetSamplerNamesInternal(names);
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06001164 RID: 4452
		[ThreadAndSerializationSafe]
		public extern string name { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06001165 RID: 4453
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Recorder GetRecorderInternal();

		// Token: 0x06001166 RID: 4454
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Sampler GetSamplerInternal(string name);

		// Token: 0x06001167 RID: 4455
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetSamplerNamesInternal(object namesScriptingPtr);

		// Token: 0x04000231 RID: 561
		internal IntPtr m_Ptr;

		// Token: 0x04000232 RID: 562
		internal static Sampler s_InvalidSampler = new Sampler();
	}
}
