using System;

namespace UnityEngine.Experimental.Director
{
	// Token: 0x020001E4 RID: 484
	public class AnimationPlayableUtilities
	{
		// Token: 0x06002152 RID: 8530 RVA: 0x00026D44 File Offset: 0x00024F44
		public static void Play(Animator animator, PlayableHandle playable, PlayableGraph graph)
		{
			graph.CreateAnimationOutput("AnimationClip", animator).sourcePlayable = playable;
			graph.SyncUpdateAndTimeMode(animator);
			graph.Play();
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x00026D78 File Offset: 0x00024F78
		public static PlayableHandle PlayClip(Animator animator, AnimationClip clip, out PlayableGraph graph)
		{
			graph = PlayableGraph.CreateGraph();
			AnimationPlayableOutput animationPlayableOutput = graph.CreateAnimationOutput("AnimationClip", animator);
			PlayableHandle playableHandle = graph.CreateAnimationClipPlayable(clip);
			animationPlayableOutput.sourcePlayable = playableHandle;
			graph.SyncUpdateAndTimeMode(animator);
			graph.Play();
			return playableHandle;
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x00026DD4 File Offset: 0x00024FD4
		public static PlayableHandle PlayMixer(Animator animator, int inputCount, out PlayableGraph graph)
		{
			graph = PlayableGraph.CreateGraph();
			AnimationPlayableOutput animationPlayableOutput = graph.CreateAnimationOutput("Mixer", animator);
			PlayableHandle playableHandle = graph.CreateAnimationMixerPlayable(inputCount);
			animationPlayableOutput.sourcePlayable = playableHandle;
			graph.SyncUpdateAndTimeMode(animator);
			graph.Play();
			return playableHandle;
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x00026E30 File Offset: 0x00025030
		public static PlayableHandle PlayAnimatorController(Animator animator, RuntimeAnimatorController controller, out PlayableGraph graph)
		{
			graph = PlayableGraph.CreateGraph();
			AnimationPlayableOutput animationPlayableOutput = graph.CreateAnimationOutput("AnimatorControllerPlayable", animator);
			PlayableHandle playableHandle = graph.CreateAnimatorControllerPlayable(controller);
			animationPlayableOutput.sourcePlayable = playableHandle;
			graph.SyncUpdateAndTimeMode(animator);
			graph.Play();
			return playableHandle;
		}
	}
}
