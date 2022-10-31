using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Profiling
{
	// Token: 0x020000F6 RID: 246
	[UsedByNativeCode]
	public sealed class CustomSampler : Sampler
	{
		// Token: 0x06001169 RID: 4457 RVA: 0x0001761C File Offset: 0x0001581C
		internal CustomSampler()
		{
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x00017628 File Offset: 0x00015828
		public static CustomSampler Create(string name)
		{
			CustomSampler customSampler = CustomSampler.CreateInternal(name);
			return customSampler ?? CustomSampler.s_InvalidCustomSampler;
		}

		// Token: 0x0600116B RID: 4459
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern CustomSampler CreateInternal(string name);

		// Token: 0x0600116C RID: 4460
		[Conditional("ENABLE_PROFILER")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Begin();

		// Token: 0x0600116D RID: 4461 RVA: 0x00017654 File Offset: 0x00015854
		[Conditional("ENABLE_PROFILER")]
		public void Begin(Object targetObject)
		{
			this.BeginWithObject(targetObject);
		}

		// Token: 0x0600116E RID: 4462
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void BeginWithObject(Object targetObject);

		// Token: 0x0600116F RID: 4463
		[Conditional("ENABLE_PROFILER")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void End();

		// Token: 0x04000233 RID: 563
		internal static CustomSampler s_InvalidCustomSampler = new CustomSampler();
	}
}
