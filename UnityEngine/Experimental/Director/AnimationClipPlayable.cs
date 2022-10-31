using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Director
{
	// Token: 0x0200021B RID: 539
	[RequiredByNativeCode]
	public sealed class AnimationClipPlayable : AnimationPlayable
	{
		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x0600245F RID: 9311 RVA: 0x00029B20 File Offset: 0x00027D20
		public AnimationClip clip
		{
			get
			{
				return AnimationClipPlayable.GetAnimationClip(ref this.handle);
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06002460 RID: 9312 RVA: 0x00029B40 File Offset: 0x00027D40
		// (set) Token: 0x06002461 RID: 9313 RVA: 0x00029B60 File Offset: 0x00027D60
		public float speed
		{
			get
			{
				return AnimationClipPlayable.GetSpeed(ref this.handle);
			}
			set
			{
				AnimationClipPlayable.SetSpeed(ref this.handle, value);
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06002462 RID: 9314 RVA: 0x00029B70 File Offset: 0x00027D70
		// (set) Token: 0x06002463 RID: 9315 RVA: 0x00029B90 File Offset: 0x00027D90
		public bool applyFootIK
		{
			get
			{
				return AnimationClipPlayable.GetApplyFootIK(ref this.handle);
			}
			set
			{
				AnimationClipPlayable.SetApplyFootIK(ref this.handle, value);
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06002464 RID: 9316 RVA: 0x00029BA0 File Offset: 0x00027DA0
		// (set) Token: 0x06002465 RID: 9317 RVA: 0x00029BC0 File Offset: 0x00027DC0
		internal bool removeStartOffset
		{
			get
			{
				return AnimationClipPlayable.GetRemoveStartOffset(ref this.handle);
			}
			set
			{
				AnimationClipPlayable.SetRemoveStartOffset(ref this.handle, value);
			}
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x00029BD0 File Offset: 0x00027DD0
		private static AnimationClip GetAnimationClip(ref PlayableHandle handle)
		{
			return AnimationClipPlayable.INTERNAL_CALL_GetAnimationClip(ref handle);
		}

		// Token: 0x06002467 RID: 9319
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AnimationClip INTERNAL_CALL_GetAnimationClip(ref PlayableHandle handle);

		// Token: 0x06002468 RID: 9320 RVA: 0x00029BEC File Offset: 0x00027DEC
		private static float GetSpeed(ref PlayableHandle handle)
		{
			return AnimationClipPlayable.INTERNAL_CALL_GetSpeed(ref handle);
		}

		// Token: 0x06002469 RID: 9321
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float INTERNAL_CALL_GetSpeed(ref PlayableHandle handle);

		// Token: 0x0600246A RID: 9322 RVA: 0x00029C08 File Offset: 0x00027E08
		private static void SetSpeed(ref PlayableHandle handle, float value)
		{
			AnimationClipPlayable.INTERNAL_CALL_SetSpeed(ref handle, value);
		}

		// Token: 0x0600246B RID: 9323
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetSpeed(ref PlayableHandle handle, float value);

		// Token: 0x0600246C RID: 9324 RVA: 0x00029C14 File Offset: 0x00027E14
		private static bool GetApplyFootIK(ref PlayableHandle handle)
		{
			return AnimationClipPlayable.INTERNAL_CALL_GetApplyFootIK(ref handle);
		}

		// Token: 0x0600246D RID: 9325
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_GetApplyFootIK(ref PlayableHandle handle);

		// Token: 0x0600246E RID: 9326 RVA: 0x00029C30 File Offset: 0x00027E30
		private static void SetApplyFootIK(ref PlayableHandle handle, bool value)
		{
			AnimationClipPlayable.INTERNAL_CALL_SetApplyFootIK(ref handle, value);
		}

		// Token: 0x0600246F RID: 9327
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetApplyFootIK(ref PlayableHandle handle, bool value);

		// Token: 0x06002470 RID: 9328 RVA: 0x00029C3C File Offset: 0x00027E3C
		private static bool GetRemoveStartOffset(ref PlayableHandle handle)
		{
			return AnimationClipPlayable.INTERNAL_CALL_GetRemoveStartOffset(ref handle);
		}

		// Token: 0x06002471 RID: 9329
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_GetRemoveStartOffset(ref PlayableHandle handle);

		// Token: 0x06002472 RID: 9330 RVA: 0x00029C58 File Offset: 0x00027E58
		private static void SetRemoveStartOffset(ref PlayableHandle handle, bool value)
		{
			AnimationClipPlayable.INTERNAL_CALL_SetRemoveStartOffset(ref handle, value);
		}

		// Token: 0x06002473 RID: 9331
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetRemoveStartOffset(ref PlayableHandle handle, bool value);
	}
}
