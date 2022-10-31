using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000212 RID: 530
	public sealed class HumanTrait
	{
		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x0600236F RID: 9071
		public static extern int MuscleCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06002370 RID: 9072
		public static extern string[] MuscleName { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06002371 RID: 9073
		public static extern int BoneCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06002372 RID: 9074
		public static extern string[] BoneName { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002373 RID: 9075
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int MuscleFromBone(int i, int dofIndex);

		// Token: 0x06002374 RID: 9076
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int BoneFromMuscle(int i);

		// Token: 0x06002375 RID: 9077
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool RequiredBone(int i);

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06002376 RID: 9078
		public static extern int RequiredBoneCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002377 RID: 9079
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool HasCollider(Avatar avatar, int i);

		// Token: 0x06002378 RID: 9080
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetMuscleDefaultMin(int i);

		// Token: 0x06002379 RID: 9081
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetMuscleDefaultMax(int i);

		// Token: 0x0600237A RID: 9082
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetParentBone(int i);
	}
}
