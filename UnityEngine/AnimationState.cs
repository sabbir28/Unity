using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001F3 RID: 499
	[UsedByNativeCode]
	public sealed class AnimationState : TrackedReference
	{
		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x060021F6 RID: 8694
		// (set) Token: 0x060021F7 RID: 8695
		public extern bool enabled { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x060021F8 RID: 8696
		// (set) Token: 0x060021F9 RID: 8697
		public extern float weight { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x060021FA RID: 8698
		// (set) Token: 0x060021FB RID: 8699
		public extern WrapMode wrapMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x060021FC RID: 8700
		// (set) Token: 0x060021FD RID: 8701
		public extern float time { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x060021FE RID: 8702
		// (set) Token: 0x060021FF RID: 8703
		public extern float normalizedTime { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06002200 RID: 8704
		// (set) Token: 0x06002201 RID: 8705
		public extern float speed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06002202 RID: 8706
		// (set) Token: 0x06002203 RID: 8707
		public extern float normalizedSpeed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06002204 RID: 8708
		public extern float length { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06002205 RID: 8709
		// (set) Token: 0x06002206 RID: 8710
		public extern int layer { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06002207 RID: 8711
		public extern AnimationClip clip { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002208 RID: 8712
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void AddMixingTransform(Transform mix, [DefaultValue("true")] bool recursive);

		// Token: 0x06002209 RID: 8713 RVA: 0x000277C4 File Offset: 0x000259C4
		[ExcludeFromDocs]
		public void AddMixingTransform(Transform mix)
		{
			bool recursive = true;
			this.AddMixingTransform(mix, recursive);
		}

		// Token: 0x0600220A RID: 8714
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RemoveMixingTransform(Transform mix);

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x0600220B RID: 8715
		// (set) Token: 0x0600220C RID: 8716
		public extern string name { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x0600220D RID: 8717
		// (set) Token: 0x0600220E RID: 8718
		public extern AnimationBlendMode blendMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
