using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngineInternal
{
	// Token: 0x020000E3 RID: 227
	public sealed class GIDebugVisualisation
	{
		// Token: 0x0600107E RID: 4222
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResetRuntimeInputTextures();

		// Token: 0x0600107F RID: 4223
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void PlayCycleMode();

		// Token: 0x06001080 RID: 4224
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void PauseCycleMode();

		// Token: 0x06001081 RID: 4225
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StopCycleMode();

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06001082 RID: 4226
		public static extern bool cycleMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001083 RID: 4227
		public static extern bool pauseCycleMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001084 RID: 4228
		// (set) Token: 0x06001085 RID: 4229
		public static extern GITextureType texType { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06001086 RID: 4230
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CycleSkipInstances(int skip);

		// Token: 0x06001087 RID: 4231
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CycleSkipSystems(int skip);
	}
}
