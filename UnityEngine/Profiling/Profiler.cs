using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Profiling
{
	// Token: 0x020000F3 RID: 243
	[MovedFrom("UnityEngine")]
	public sealed class Profiler
	{
		// Token: 0x06001136 RID: 4406 RVA: 0x000173FC File Offset: 0x000155FC
		private Profiler()
		{
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06001137 RID: 4407
		public static extern bool supported { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06001138 RID: 4408
		// (set) Token: 0x06001139 RID: 4409
		public static extern string logFile { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x0600113A RID: 4410
		// (set) Token: 0x0600113B RID: 4411
		public static extern bool enableBinaryLog { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x0600113C RID: 4412
		// (set) Token: 0x0600113D RID: 4413
		public static extern bool enabled { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x0600113E RID: 4414
		[Conditional("UNITY_EDITOR")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void AddFramesFromFile(string file);

		// Token: 0x0600113F RID: 4415 RVA: 0x00017408 File Offset: 0x00015608
		[Conditional("ENABLE_PROFILER")]
		public static void BeginSample(string name)
		{
			Profiler.BeginSampleOnly(name);
		}

		// Token: 0x06001140 RID: 4416
		[Conditional("ENABLE_PROFILER")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BeginSample(string name, Object targetObject);

		// Token: 0x06001141 RID: 4417
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void BeginSampleOnly(string name);

		// Token: 0x06001142 RID: 4418
		[Conditional("ENABLE_PROFILER")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EndSample();

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06001143 RID: 4419
		// (set) Token: 0x06001144 RID: 4420
		[Obsolete("maxNumberOfSamplesPerFrame is no longer needed, as the profiler buffers auto expand as needed")]
		public static extern int maxNumberOfSamplesPerFrame { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001145 RID: 4421
		[Obsolete("usedHeapSize has been deprecated since it is limited to 4GB. Please use usedHeapSizeLong instead.")]
		public static extern uint usedHeapSize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001146 RID: 4422
		public static extern long usedHeapSizeLong { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06001147 RID: 4423 RVA: 0x00017414 File Offset: 0x00015614
		[Obsolete("GetRuntimeMemorySize has been deprecated since it is limited to 2GB. Please use GetRuntimeMemorySizeLong() instead.")]
		public static int GetRuntimeMemorySize(Object o)
		{
			return (int)Profiler.GetRuntimeMemorySizeLong(o);
		}

		// Token: 0x06001148 RID: 4424
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetRuntimeMemorySizeLong(Object o);

		// Token: 0x06001149 RID: 4425 RVA: 0x00017430 File Offset: 0x00015630
		[Obsolete("GetMonoHeapSize has been deprecated since it is limited to 4GB. Please use GetMonoHeapSizeLong() instead.")]
		public static uint GetMonoHeapSize()
		{
			return (uint)Profiler.GetMonoHeapSizeLong();
		}

		// Token: 0x0600114A RID: 4426
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetMonoHeapSizeLong();

		// Token: 0x0600114B RID: 4427 RVA: 0x0001744C File Offset: 0x0001564C
		[Obsolete("GetMonoUsedSize has been deprecated since it is limited to 4GB. Please use GetMonoUsedSizeLong() instead.")]
		public static uint GetMonoUsedSize()
		{
			return (uint)Profiler.GetMonoUsedSizeLong();
		}

		// Token: 0x0600114C RID: 4428
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetMonoUsedSizeLong();

		// Token: 0x0600114D RID: 4429
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SetTempAllocatorRequestedSize(uint size);

		// Token: 0x0600114E RID: 4430
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern uint GetTempAllocatorSize();

		// Token: 0x0600114F RID: 4431 RVA: 0x00017468 File Offset: 0x00015668
		[Obsolete("GetTotalAllocatedMemory has been deprecated since it is limited to 4GB. Please use GetTotalAllocatedMemoryLong() instead.")]
		public static uint GetTotalAllocatedMemory()
		{
			return (uint)Profiler.GetTotalAllocatedMemoryLong();
		}

		// Token: 0x06001150 RID: 4432
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetTotalAllocatedMemoryLong();

		// Token: 0x06001151 RID: 4433 RVA: 0x00017484 File Offset: 0x00015684
		[Obsolete("GetTotalUnusedReservedMemory has been deprecated since it is limited to 4GB. Please use GetTotalUnusedReservedMemoryLong() instead.")]
		public static uint GetTotalUnusedReservedMemory()
		{
			return (uint)Profiler.GetTotalUnusedReservedMemoryLong();
		}

		// Token: 0x06001152 RID: 4434
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetTotalUnusedReservedMemoryLong();

		// Token: 0x06001153 RID: 4435 RVA: 0x000174A0 File Offset: 0x000156A0
		[Obsolete("GetTotalReservedMemory has been deprecated since it is limited to 4GB. Please use GetTotalReservedMemoryLong() instead.")]
		public static uint GetTotalReservedMemory()
		{
			return (uint)Profiler.GetTotalReservedMemoryLong();
		}

		// Token: 0x06001154 RID: 4436
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetTotalReservedMemoryLong();
	}
}
