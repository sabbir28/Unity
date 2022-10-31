using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001E8 RID: 488
	public sealed class AnimatorOverrideController : RuntimeAnimatorController
	{
		// Token: 0x06002167 RID: 8551 RVA: 0x00026EDC File Offset: 0x000250DC
		public AnimatorOverrideController()
		{
			AnimatorOverrideController.Internal_CreateAnimatorOverrideController(this, null);
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x00026EEC File Offset: 0x000250EC
		public AnimatorOverrideController(RuntimeAnimatorController controller)
		{
			AnimatorOverrideController.Internal_CreateAnimatorOverrideController(this, controller);
		}

		// Token: 0x06002169 RID: 8553
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateAnimatorOverrideController([Writable] AnimatorOverrideController self, RuntimeAnimatorController controller);

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x0600216A RID: 8554
		// (set) Token: 0x0600216B RID: 8555
		public extern RuntimeAnimatorController runtimeAnimatorController { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000818 RID: 2072
		public AnimationClip this[string name]
		{
			get
			{
				return this.Internal_GetClipByName(name, true);
			}
			set
			{
				this.Internal_SetClipByName(name, value);
			}
		}

		// Token: 0x0600216E RID: 8558
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip);

		// Token: 0x0600216F RID: 8559
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_SetClipByName(string name, AnimationClip clip);

		// Token: 0x17000819 RID: 2073
		public AnimationClip this[AnimationClip clip]
		{
			get
			{
				return this.Internal_GetClip(clip, true);
			}
			set
			{
				this.Internal_SetClip(clip, value);
			}
		}

		// Token: 0x06002172 RID: 8562
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern AnimationClip Internal_GetClip(AnimationClip originalClip, bool returnEffectiveClip);

		// Token: 0x06002173 RID: 8563
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_SetClip(AnimationClip originalClip, AnimationClip overrideClip, [DefaultValue("true")] bool notify);

		// Token: 0x06002174 RID: 8564 RVA: 0x00026F54 File Offset: 0x00025154
		[ExcludeFromDocs]
		private void Internal_SetClip(AnimationClip originalClip, AnimationClip overrideClip)
		{
			bool notify = true;
			this.Internal_SetClip(originalClip, overrideClip, notify);
		}

		// Token: 0x06002175 RID: 8565
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SendNotification();

		// Token: 0x06002176 RID: 8566
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern AnimationClip Internal_GetOriginalClip(int index);

		// Token: 0x06002177 RID: 8567
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern AnimationClip Internal_GetOverrideClip(AnimationClip originalClip);

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06002178 RID: 8568
		public extern int overridesCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002179 RID: 8569 RVA: 0x00026F70 File Offset: 0x00025170
		public void GetOverrides(List<KeyValuePair<AnimationClip, AnimationClip>> overrides)
		{
			if (overrides == null)
			{
				throw new ArgumentNullException("overrides");
			}
			int overridesCount = this.overridesCount;
			if (overrides.Capacity < overridesCount)
			{
				overrides.Capacity = overridesCount;
			}
			overrides.Clear();
			for (int i = 0; i < overridesCount; i++)
			{
				AnimationClip animationClip = this.Internal_GetOriginalClip(i);
				overrides.Add(new KeyValuePair<AnimationClip, AnimationClip>(animationClip, this.Internal_GetOverrideClip(animationClip)));
			}
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x00026FE0 File Offset: 0x000251E0
		public void ApplyOverrides(IList<KeyValuePair<AnimationClip, AnimationClip>> overrides)
		{
			if (overrides == null)
			{
				throw new ArgumentNullException("overrides");
			}
			for (int i = 0; i < overrides.Count; i++)
			{
				this.Internal_SetClip(overrides[i].Key, overrides[i].Value, false);
			}
			this.SendNotification();
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x0600217B RID: 8571 RVA: 0x00027044 File Offset: 0x00025244
		// (set) Token: 0x0600217C RID: 8572 RVA: 0x000270AC File Offset: 0x000252AC
		[Obsolete("clips property is deprecated. Use AnimatorOverrideController.GetOverrides and AnimatorOverrideController.ApplyOverrides instead.")]
		public AnimationClipPair[] clips
		{
			get
			{
				int overridesCount = this.overridesCount;
				AnimationClipPair[] array = new AnimationClipPair[overridesCount];
				for (int i = 0; i < overridesCount; i++)
				{
					array[i] = new AnimationClipPair();
					array[i].originalClip = this.Internal_GetOriginalClip(i);
					array[i].overrideClip = this.Internal_GetOverrideClip(array[i].originalClip);
				}
				return array;
			}
			set
			{
				for (int i = 0; i < value.Length; i++)
				{
					this.Internal_SetClip(value[i].originalClip, value[i].overrideClip, false);
				}
				this.SendNotification();
			}
		}
	}
}
