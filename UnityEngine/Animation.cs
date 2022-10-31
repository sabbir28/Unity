using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001F1 RID: 497
	public sealed class Animation : Behaviour, IEnumerable
	{
		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x060021B2 RID: 8626
		// (set) Token: 0x060021B3 RID: 8627
		public extern AnimationClip clip { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x060021B4 RID: 8628
		// (set) Token: 0x060021B5 RID: 8629
		public extern bool playAutomatically { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x060021B6 RID: 8630
		// (set) Token: 0x060021B7 RID: 8631
		public extern WrapMode wrapMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060021B8 RID: 8632 RVA: 0x00027444 File Offset: 0x00025644
		public void Stop()
		{
			Animation.INTERNAL_CALL_Stop(this);
		}

		// Token: 0x060021B9 RID: 8633
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Stop(Animation self);

		// Token: 0x060021BA RID: 8634 RVA: 0x00027450 File Offset: 0x00025650
		public void Stop(string name)
		{
			this.Internal_StopByName(name);
		}

		// Token: 0x060021BB RID: 8635
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_StopByName(string name);

		// Token: 0x060021BC RID: 8636 RVA: 0x0002745C File Offset: 0x0002565C
		public void Rewind(string name)
		{
			this.Internal_RewindByName(name);
		}

		// Token: 0x060021BD RID: 8637
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_RewindByName(string name);

		// Token: 0x060021BE RID: 8638 RVA: 0x00027468 File Offset: 0x00025668
		public void Rewind()
		{
			Animation.INTERNAL_CALL_Rewind(this);
		}

		// Token: 0x060021BF RID: 8639
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Rewind(Animation self);

		// Token: 0x060021C0 RID: 8640 RVA: 0x00027474 File Offset: 0x00025674
		public void Sample()
		{
			Animation.INTERNAL_CALL_Sample(this);
		}

		// Token: 0x060021C1 RID: 8641
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Sample(Animation self);

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x060021C2 RID: 8642
		public extern bool isPlaying { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060021C3 RID: 8643
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsPlaying(string name);

		// Token: 0x17000837 RID: 2103
		public AnimationState this[string name]
		{
			get
			{
				return this.GetState(name);
			}
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x0002749C File Offset: 0x0002569C
		[ExcludeFromDocs]
		public bool Play()
		{
			PlayMode mode = PlayMode.StopSameLayer;
			return this.Play(mode);
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x000274BC File Offset: 0x000256BC
		public bool Play([DefaultValue("PlayMode.StopSameLayer")] PlayMode mode)
		{
			return this.PlayDefaultAnimation(mode);
		}

		// Token: 0x060021C7 RID: 8647
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool Play(string animation, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode);

		// Token: 0x060021C8 RID: 8648 RVA: 0x000274D8 File Offset: 0x000256D8
		[ExcludeFromDocs]
		public bool Play(string animation)
		{
			PlayMode mode = PlayMode.StopSameLayer;
			return this.Play(animation, mode);
		}

		// Token: 0x060021C9 RID: 8649
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void CrossFade(string animation, [DefaultValue("0.3F")] float fadeLength, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode);

		// Token: 0x060021CA RID: 8650 RVA: 0x000274F8 File Offset: 0x000256F8
		[ExcludeFromDocs]
		public void CrossFade(string animation, float fadeLength)
		{
			PlayMode mode = PlayMode.StopSameLayer;
			this.CrossFade(animation, fadeLength, mode);
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x00027514 File Offset: 0x00025714
		[ExcludeFromDocs]
		public void CrossFade(string animation)
		{
			PlayMode mode = PlayMode.StopSameLayer;
			float fadeLength = 0.3f;
			this.CrossFade(animation, fadeLength, mode);
		}

		// Token: 0x060021CC RID: 8652
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Blend(string animation, [DefaultValue("1.0F")] float targetWeight, [DefaultValue("0.3F")] float fadeLength);

		// Token: 0x060021CD RID: 8653 RVA: 0x00027534 File Offset: 0x00025734
		[ExcludeFromDocs]
		public void Blend(string animation, float targetWeight)
		{
			float fadeLength = 0.3f;
			this.Blend(animation, targetWeight, fadeLength);
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x00027554 File Offset: 0x00025754
		[ExcludeFromDocs]
		public void Blend(string animation)
		{
			float fadeLength = 0.3f;
			float targetWeight = 1f;
			this.Blend(animation, targetWeight, fadeLength);
		}

		// Token: 0x060021CF RID: 8655
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AnimationState CrossFadeQueued(string animation, [DefaultValue("0.3F")] float fadeLength, [DefaultValue("QueueMode.CompleteOthers")] QueueMode queue, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode);

		// Token: 0x060021D0 RID: 8656 RVA: 0x00027578 File Offset: 0x00025778
		[ExcludeFromDocs]
		public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue)
		{
			PlayMode mode = PlayMode.StopSameLayer;
			return this.CrossFadeQueued(animation, fadeLength, queue, mode);
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x0002759C File Offset: 0x0002579C
		[ExcludeFromDocs]
		public AnimationState CrossFadeQueued(string animation, float fadeLength)
		{
			PlayMode mode = PlayMode.StopSameLayer;
			QueueMode queue = QueueMode.CompleteOthers;
			return this.CrossFadeQueued(animation, fadeLength, queue, mode);
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x000275C0 File Offset: 0x000257C0
		[ExcludeFromDocs]
		public AnimationState CrossFadeQueued(string animation)
		{
			PlayMode mode = PlayMode.StopSameLayer;
			QueueMode queue = QueueMode.CompleteOthers;
			float fadeLength = 0.3f;
			return this.CrossFadeQueued(animation, fadeLength, queue, mode);
		}

		// Token: 0x060021D3 RID: 8659
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AnimationState PlayQueued(string animation, [DefaultValue("QueueMode.CompleteOthers")] QueueMode queue, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode);

		// Token: 0x060021D4 RID: 8660 RVA: 0x000275EC File Offset: 0x000257EC
		[ExcludeFromDocs]
		public AnimationState PlayQueued(string animation, QueueMode queue)
		{
			PlayMode mode = PlayMode.StopSameLayer;
			return this.PlayQueued(animation, queue, mode);
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x0002760C File Offset: 0x0002580C
		[ExcludeFromDocs]
		public AnimationState PlayQueued(string animation)
		{
			PlayMode mode = PlayMode.StopSameLayer;
			QueueMode queue = QueueMode.CompleteOthers;
			return this.PlayQueued(animation, queue, mode);
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x00027630 File Offset: 0x00025830
		public void AddClip(AnimationClip clip, string newName)
		{
			this.AddClip(clip, newName, int.MinValue, int.MaxValue);
		}

		// Token: 0x060021D7 RID: 8663
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame, [DefaultValue("false")] bool addLoopFrame);

		// Token: 0x060021D8 RID: 8664 RVA: 0x00027648 File Offset: 0x00025848
		[ExcludeFromDocs]
		public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame)
		{
			bool addLoopFrame = false;
			this.AddClip(clip, newName, firstFrame, lastFrame, addLoopFrame);
		}

		// Token: 0x060021D9 RID: 8665
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RemoveClip(AnimationClip clip);

		// Token: 0x060021DA RID: 8666 RVA: 0x00027664 File Offset: 0x00025864
		public void RemoveClip(string clipName)
		{
			this.RemoveClip2(clipName);
		}

		// Token: 0x060021DB RID: 8667
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetClipCount();

		// Token: 0x060021DC RID: 8668
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void RemoveClip2(string clipName);

		// Token: 0x060021DD RID: 8669
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool PlayDefaultAnimation(PlayMode mode);

		// Token: 0x060021DE RID: 8670 RVA: 0x00027670 File Offset: 0x00025870
		[Obsolete("use PlayMode instead of AnimationPlayMode.")]
		public bool Play(AnimationPlayMode mode)
		{
			return this.PlayDefaultAnimation((PlayMode)mode);
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x0002768C File Offset: 0x0002588C
		[Obsolete("use PlayMode instead of AnimationPlayMode.")]
		public bool Play(string animation, AnimationPlayMode mode)
		{
			return this.Play(animation, (PlayMode)mode);
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x000276AC File Offset: 0x000258AC
		public void SyncLayer(int layer)
		{
			Animation.INTERNAL_CALL_SyncLayer(this, layer);
		}

		// Token: 0x060021E1 RID: 8673
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SyncLayer(Animation self, int layer);

		// Token: 0x060021E2 RID: 8674 RVA: 0x000276B8 File Offset: 0x000258B8
		public IEnumerator GetEnumerator()
		{
			return new Animation.Enumerator(this);
		}

		// Token: 0x060021E3 RID: 8675
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern AnimationState GetState(string name);

		// Token: 0x060021E4 RID: 8676
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern AnimationState GetStateAtIndex(int index);

		// Token: 0x060021E5 RID: 8677
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern int GetStateCount();

		// Token: 0x060021E6 RID: 8678 RVA: 0x000276D4 File Offset: 0x000258D4
		public AnimationClip GetClip(string name)
		{
			AnimationState state = this.GetState(name);
			AnimationClip result;
			if (state)
			{
				result = state.clip;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x060021E7 RID: 8679
		// (set) Token: 0x060021E8 RID: 8680
		public extern bool animatePhysics { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x060021E9 RID: 8681
		// (set) Token: 0x060021EA RID: 8682
		[Obsolete("Use cullingType instead")]
		public extern bool animateOnlyIfVisible { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x060021EB RID: 8683
		// (set) Token: 0x060021EC RID: 8684
		public extern AnimationCullingType cullingType { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x060021ED RID: 8685 RVA: 0x0002770C File Offset: 0x0002590C
		// (set) Token: 0x060021EE RID: 8686 RVA: 0x0002772C File Offset: 0x0002592C
		public Bounds localBounds
		{
			get
			{
				Bounds result;
				this.INTERNAL_get_localBounds(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_localBounds(ref value);
			}
		}

		// Token: 0x060021EF RID: 8687
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_localBounds(out Bounds value);

		// Token: 0x060021F0 RID: 8688
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_localBounds(ref Bounds value);

		// Token: 0x020001F2 RID: 498
		private sealed class Enumerator : IEnumerator
		{
			// Token: 0x060021F1 RID: 8689 RVA: 0x00027738 File Offset: 0x00025938
			internal Enumerator(Animation outer)
			{
				this.m_Outer = outer;
			}

			// Token: 0x1700083C RID: 2108
			// (get) Token: 0x060021F2 RID: 8690 RVA: 0x00027750 File Offset: 0x00025950
			public object Current
			{
				get
				{
					return this.m_Outer.GetStateAtIndex(this.m_CurrentIndex);
				}
			}

			// Token: 0x060021F3 RID: 8691 RVA: 0x00027778 File Offset: 0x00025978
			public bool MoveNext()
			{
				int stateCount = this.m_Outer.GetStateCount();
				this.m_CurrentIndex++;
				return this.m_CurrentIndex < stateCount;
			}

			// Token: 0x060021F4 RID: 8692 RVA: 0x000277B0 File Offset: 0x000259B0
			public void Reset()
			{
				this.m_CurrentIndex = -1;
			}

			// Token: 0x04000542 RID: 1346
			private Animation m_Outer;

			// Token: 0x04000543 RID: 1347
			private int m_CurrentIndex = -1;
		}
	}
}
