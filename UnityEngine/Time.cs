using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000CE RID: 206
	public sealed class Time
	{
		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000F17 RID: 3863
		public static extern float time { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000F18 RID: 3864
		public static extern float timeSinceLevelLoad { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000F19 RID: 3865
		public static extern float deltaTime { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000F1A RID: 3866
		public static extern float fixedTime { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000F1B RID: 3867
		public static extern float unscaledTime { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000F1C RID: 3868
		public static extern float fixedUnscaledTime { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000F1D RID: 3869
		public static extern float unscaledDeltaTime { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000F1E RID: 3870
		public static extern float fixedUnscaledDeltaTime { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000F1F RID: 3871
		// (set) Token: 0x06000F20 RID: 3872
		public static extern float fixedDeltaTime { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000F21 RID: 3873
		// (set) Token: 0x06000F22 RID: 3874
		public static extern float maximumDeltaTime { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000F23 RID: 3875
		public static extern float smoothDeltaTime { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000F24 RID: 3876
		// (set) Token: 0x06000F25 RID: 3877
		public static extern float maximumParticleDeltaTime { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000F26 RID: 3878
		// (set) Token: 0x06000F27 RID: 3879
		public static extern float timeScale { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000F28 RID: 3880
		public static extern int frameCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000F29 RID: 3881
		public static extern int renderedFrameCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000F2A RID: 3882
		public static extern float realtimeSinceStartup { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000F2B RID: 3883
		// (set) Token: 0x06000F2C RID: 3884
		public static extern int captureFramerate { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000F2D RID: 3885
		public static extern bool inFixedTimeStep { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
