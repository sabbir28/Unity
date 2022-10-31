using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Director
{
	// Token: 0x0200021D RID: 541
	public static class AnimationPlayableGraphExtensions
	{
		// Token: 0x06002475 RID: 9333 RVA: 0x00029C6C File Offset: 0x00027E6C
		public static AnimationPlayableOutput CreateAnimationOutput(this PlayableGraph graph, string name, Animator target)
		{
			AnimationPlayableOutput animationPlayableOutput = default(AnimationPlayableOutput);
			AnimationPlayableOutput result;
			if (!AnimationPlayableGraphExtensions.InternalCreateAnimationOutput(ref graph, name, out animationPlayableOutput.m_Output))
			{
				result = AnimationPlayableOutput.Null;
			}
			else
			{
				animationPlayableOutput.target = target;
				result = animationPlayableOutput;
			}
			return result;
		}

		// Token: 0x06002476 RID: 9334
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool InternalCreateAnimationOutput(ref PlayableGraph graph, string name, out PlayableOutput output);

		// Token: 0x06002477 RID: 9335 RVA: 0x00029CB4 File Offset: 0x00027EB4
		internal static void SyncUpdateAndTimeMode(this PlayableGraph graph, Animator animator)
		{
			AnimationPlayableGraphExtensions.InternalSyncUpdateAndTimeMode(ref graph, animator);
		}

		// Token: 0x06002478 RID: 9336
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void InternalSyncUpdateAndTimeMode(ref PlayableGraph graph, Animator animator);

		// Token: 0x06002479 RID: 9337 RVA: 0x00029CC0 File Offset: 0x00027EC0
		public static PlayableHandle CreateAnimationClipPlayable(this PlayableGraph graph, AnimationClip clip)
		{
			PlayableHandle @null = PlayableHandle.Null;
			PlayableHandle result;
			if (!AnimationPlayableGraphExtensions.InternalCreateAnimationClipPlayable(ref graph, clip, ref @null))
			{
				result = PlayableHandle.Null;
			}
			else
			{
				result = @null;
			}
			return result;
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x00029CF8 File Offset: 0x00027EF8
		private static bool InternalCreateAnimationClipPlayable(ref PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle)
		{
			return AnimationPlayableGraphExtensions.INTERNAL_CALL_InternalCreateAnimationClipPlayable(ref graph, clip, ref handle);
		}

		// Token: 0x0600247B RID: 9339
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_InternalCreateAnimationClipPlayable(ref PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle);

		// Token: 0x0600247C RID: 9340 RVA: 0x00029D18 File Offset: 0x00027F18
		[ExcludeFromDocs]
		public static PlayableHandle CreateAnimationMixerPlayable(this PlayableGraph graph, int inputCount)
		{
			bool normalizeWeights = false;
			return graph.CreateAnimationMixerPlayable(inputCount, normalizeWeights);
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x00029D38 File Offset: 0x00027F38
		[ExcludeFromDocs]
		public static PlayableHandle CreateAnimationMixerPlayable(this PlayableGraph graph)
		{
			bool normalizeWeights = false;
			int inputCount = 0;
			return graph.CreateAnimationMixerPlayable(inputCount, normalizeWeights);
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x00029D5C File Offset: 0x00027F5C
		public static PlayableHandle CreateAnimationMixerPlayable(this PlayableGraph graph, [DefaultValue("0")] int inputCount, [DefaultValue("false")] bool normalizeWeights)
		{
			PlayableHandle @null = PlayableHandle.Null;
			PlayableHandle result;
			if (!AnimationPlayableGraphExtensions.InternalCreateAnimationMixerPlayable(ref graph, inputCount, normalizeWeights, ref @null))
			{
				result = PlayableHandle.Null;
			}
			else
			{
				@null.inputCount = inputCount;
				result = @null;
			}
			return result;
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x00029D9C File Offset: 0x00027F9C
		private static bool InternalCreateAnimationMixerPlayable(ref PlayableGraph graph, int inputCount, bool normalizeWeights, ref PlayableHandle handle)
		{
			return AnimationPlayableGraphExtensions.INTERNAL_CALL_InternalCreateAnimationMixerPlayable(ref graph, inputCount, normalizeWeights, ref handle);
		}

		// Token: 0x06002480 RID: 9344
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_InternalCreateAnimationMixerPlayable(ref PlayableGraph graph, int inputCount, bool normalizeWeights, ref PlayableHandle handle);

		// Token: 0x06002481 RID: 9345 RVA: 0x00029DBC File Offset: 0x00027FBC
		public static PlayableHandle CreateAnimatorControllerPlayable(this PlayableGraph graph, RuntimeAnimatorController controller)
		{
			PlayableHandle @null = PlayableHandle.Null;
			PlayableHandle result;
			if (!AnimationPlayableGraphExtensions.InternalCreateAnimatorControllerPlayable(ref graph, controller, ref @null))
			{
				result = PlayableHandle.Null;
			}
			else
			{
				result = @null;
			}
			return result;
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x00029DF4 File Offset: 0x00027FF4
		private static bool InternalCreateAnimatorControllerPlayable(ref PlayableGraph graph, RuntimeAnimatorController controller, ref PlayableHandle handle)
		{
			return AnimationPlayableGraphExtensions.INTERNAL_CALL_InternalCreateAnimatorControllerPlayable(ref graph, controller, ref handle);
		}

		// Token: 0x06002483 RID: 9347
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_InternalCreateAnimatorControllerPlayable(ref PlayableGraph graph, RuntimeAnimatorController controller, ref PlayableHandle handle);

		// Token: 0x06002484 RID: 9348 RVA: 0x00029E14 File Offset: 0x00028014
		internal static PlayableHandle CreateAnimationOffsetPlayable(this PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount)
		{
			PlayableHandle @null = PlayableHandle.Null;
			PlayableHandle result;
			if (!AnimationPlayableGraphExtensions.InternalCreateAnimationOffsetPlayable(ref graph, position, rotation, ref @null))
			{
				result = PlayableHandle.Null;
			}
			else
			{
				@null.inputCount = inputCount;
				result = @null;
			}
			return result;
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x00029E54 File Offset: 0x00028054
		private static bool InternalCreateAnimationOffsetPlayable(ref PlayableGraph graph, Vector3 position, Quaternion rotation, ref PlayableHandle handle)
		{
			return AnimationPlayableGraphExtensions.INTERNAL_CALL_InternalCreateAnimationOffsetPlayable(ref graph, ref position, ref rotation, ref handle);
		}

		// Token: 0x06002486 RID: 9350
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_InternalCreateAnimationOffsetPlayable(ref PlayableGraph graph, ref Vector3 position, ref Quaternion rotation, ref PlayableHandle handle);

		// Token: 0x06002487 RID: 9351 RVA: 0x00029E74 File Offset: 0x00028074
		internal static PlayableHandle CreateAnimationMotionXToDeltaPlayable(this PlayableGraph graph)
		{
			PlayableHandle @null = PlayableHandle.Null;
			PlayableHandle result;
			if (!AnimationPlayableGraphExtensions.InternalCreateAnimationMotionXToDeltaPlayable(ref graph, ref @null))
			{
				result = PlayableHandle.Null;
			}
			else
			{
				@null.inputCount = 1;
				result = @null;
			}
			return result;
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x00029EB4 File Offset: 0x000280B4
		private static bool InternalCreateAnimationMotionXToDeltaPlayable(ref PlayableGraph graph, ref PlayableHandle handle)
		{
			return AnimationPlayableGraphExtensions.INTERNAL_CALL_InternalCreateAnimationMotionXToDeltaPlayable(ref graph, ref handle);
		}

		// Token: 0x06002489 RID: 9353
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_InternalCreateAnimationMotionXToDeltaPlayable(ref PlayableGraph graph, ref PlayableHandle handle);

		// Token: 0x0600248A RID: 9354 RVA: 0x00029ED0 File Offset: 0x000280D0
		[ExcludeFromDocs]
		internal static PlayableHandle CreateAnimationLayerMixerPlayable(this PlayableGraph graph)
		{
			int inputCount = 0;
			return graph.CreateAnimationLayerMixerPlayable(inputCount);
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x00029EF0 File Offset: 0x000280F0
		internal static PlayableHandle CreateAnimationLayerMixerPlayable(this PlayableGraph graph, [DefaultValue("0")] int inputCount)
		{
			PlayableHandle @null = PlayableHandle.Null;
			PlayableHandle result;
			if (!AnimationPlayableGraphExtensions.InternalCreateAnimationLayerMixerPlayable(ref graph, ref @null))
			{
				result = PlayableHandle.Null;
			}
			else
			{
				@null.inputCount = inputCount;
				result = @null;
			}
			return result;
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x00029F30 File Offset: 0x00028130
		private static bool InternalCreateAnimationLayerMixerPlayable(ref PlayableGraph graph, ref PlayableHandle handle)
		{
			return AnimationPlayableGraphExtensions.INTERNAL_CALL_InternalCreateAnimationLayerMixerPlayable(ref graph, ref handle);
		}

		// Token: 0x0600248D RID: 9357
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_InternalCreateAnimationLayerMixerPlayable(ref PlayableGraph graph, ref PlayableHandle handle);

		// Token: 0x0600248E RID: 9358
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InternalDestroyOutput(ref PlayableGraph graph, ref PlayableOutput output);

		// Token: 0x0600248F RID: 9359 RVA: 0x00029F4C File Offset: 0x0002814C
		public static void DestroyOutput(this PlayableGraph graph, AnimationPlayableOutput output)
		{
			AnimationPlayableGraphExtensions.InternalDestroyOutput(ref graph, ref output.m_Output);
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x00029F60 File Offset: 0x00028160
		public static int GetAnimationOutputCount(this PlayableGraph graph)
		{
			return AnimationPlayableGraphExtensions.InternalAnimationOutputCount(ref graph);
		}

		// Token: 0x06002491 RID: 9361
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int InternalAnimationOutputCount(ref PlayableGraph graph);

		// Token: 0x06002492 RID: 9362 RVA: 0x00029F7C File Offset: 0x0002817C
		public static AnimationPlayableOutput GetAnimationOutput(this PlayableGraph graph, int index)
		{
			AnimationPlayableOutput animationPlayableOutput = default(AnimationPlayableOutput);
			AnimationPlayableOutput result;
			if (!AnimationPlayableGraphExtensions.InternalGetAnimationOutput(ref graph, index, out animationPlayableOutput.m_Output))
			{
				result = AnimationPlayableOutput.Null;
			}
			else
			{
				result = animationPlayableOutput;
			}
			return result;
		}

		// Token: 0x06002493 RID: 9363
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool InternalGetAnimationOutput(ref PlayableGraph graph, int index, out PlayableOutput output);
	}
}
