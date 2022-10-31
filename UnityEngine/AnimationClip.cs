using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001EB RID: 491
	public sealed class AnimationClip : Motion
	{
		// Token: 0x06002194 RID: 8596 RVA: 0x000273A0 File Offset: 0x000255A0
		public AnimationClip()
		{
			AnimationClip.Internal_CreateAnimationClip(this);
		}

		// Token: 0x06002195 RID: 8597
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SampleAnimation(GameObject go, float time);

		// Token: 0x06002196 RID: 8598
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateAnimationClip([Writable] AnimationClip self);

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06002197 RID: 8599
		public extern float length { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06002198 RID: 8600
		internal extern float startTime { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06002199 RID: 8601
		internal extern float stopTime { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x0600219A RID: 8602
		// (set) Token: 0x0600219B RID: 8603
		public extern float frameRate { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x0600219C RID: 8604
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetCurve(string relativePath, Type type, string propertyName, AnimationCurve curve);

		// Token: 0x0600219D RID: 8605 RVA: 0x000273B0 File Offset: 0x000255B0
		public void EnsureQuaternionContinuity()
		{
			AnimationClip.INTERNAL_CALL_EnsureQuaternionContinuity(this);
		}

		// Token: 0x0600219E RID: 8606
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_EnsureQuaternionContinuity(AnimationClip self);

		// Token: 0x0600219F RID: 8607 RVA: 0x000273BC File Offset: 0x000255BC
		public void ClearCurves()
		{
			AnimationClip.INTERNAL_CALL_ClearCurves(this);
		}

		// Token: 0x060021A0 RID: 8608
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ClearCurves(AnimationClip self);

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x060021A1 RID: 8609
		// (set) Token: 0x060021A2 RID: 8610
		public extern WrapMode wrapMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060021A3 RID: 8611 RVA: 0x000273C8 File Offset: 0x000255C8
		// (set) Token: 0x060021A4 RID: 8612 RVA: 0x000273E8 File Offset: 0x000255E8
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

		// Token: 0x060021A5 RID: 8613
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_localBounds(out Bounds value);

		// Token: 0x060021A6 RID: 8614
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_localBounds(ref Bounds value);

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x060021A7 RID: 8615
		// (set) Token: 0x060021A8 RID: 8616
		public new extern bool legacy { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x060021A9 RID: 8617
		public extern bool humanMotion { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x060021AA RID: 8618
		internal extern bool empty { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060021AB RID: 8619 RVA: 0x000273F4 File Offset: 0x000255F4
		public void AddEvent(AnimationEvent evt)
		{
			if (evt == null)
			{
				throw new ArgumentNullException("evt");
			}
			this.AddEventInternal(evt);
		}

		// Token: 0x060021AC RID: 8620
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void AddEventInternal(object evt);

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x060021AD RID: 8621 RVA: 0x00027410 File Offset: 0x00025610
		// (set) Token: 0x060021AE RID: 8622 RVA: 0x00027430 File Offset: 0x00025630
		public AnimationEvent[] events
		{
			get
			{
				return (AnimationEvent[])this.GetEventsInternal();
			}
			set
			{
				this.SetEventsInternal(value);
			}
		}

		// Token: 0x060021AF RID: 8623
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetEventsInternal(Array value);

		// Token: 0x060021B0 RID: 8624
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Array GetEventsInternal();
	}
}
