using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Director
{
	// Token: 0x0200021E RID: 542
	public struct AnimationPlayableOutput
	{
		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06002494 RID: 9364 RVA: 0x00029FBC File Offset: 0x000281BC
		public static AnimationPlayableOutput Null
		{
			get
			{
				return new AnimationPlayableOutput
				{
					m_Output = new PlayableOutput
					{
						m_Version = 69
					}
				};
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06002495 RID: 9365 RVA: 0x00029FF4 File Offset: 0x000281F4
		// (set) Token: 0x06002496 RID: 9366 RVA: 0x0002A014 File Offset: 0x00028214
		internal Object referenceObject
		{
			get
			{
				return PlayableOutput.GetInternalReferenceObject(ref this.m_Output);
			}
			set
			{
				PlayableOutput.SetInternalReferenceObject(ref this.m_Output, value);
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06002497 RID: 9367 RVA: 0x0002A024 File Offset: 0x00028224
		// (set) Token: 0x06002498 RID: 9368 RVA: 0x0002A044 File Offset: 0x00028244
		public Object userData
		{
			get
			{
				return PlayableOutput.GetInternalUserData(ref this.m_Output);
			}
			set
			{
				PlayableOutput.SetInternalUserData(ref this.m_Output, value);
			}
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x0002A054 File Offset: 0x00028254
		public bool IsValid()
		{
			return PlayableOutput.IsValidInternal(ref this.m_Output);
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x0600249A RID: 9370 RVA: 0x0002A074 File Offset: 0x00028274
		// (set) Token: 0x0600249B RID: 9371 RVA: 0x0002A094 File Offset: 0x00028294
		public Animator target
		{
			get
			{
				return AnimationPlayableOutput.InternalGetTarget(ref this.m_Output);
			}
			set
			{
				AnimationPlayableOutput.InternalSetTarget(ref this.m_Output, value);
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x0600249C RID: 9372 RVA: 0x0002A0A4 File Offset: 0x000282A4
		// (set) Token: 0x0600249D RID: 9373 RVA: 0x0002A0C4 File Offset: 0x000282C4
		public float weight
		{
			get
			{
				return PlayableOutput.InternalGetWeight(ref this.m_Output);
			}
			set
			{
				PlayableOutput.InternalSetWeight(ref this.m_Output, value);
			}
		}

		// Token: 0x0600249E RID: 9374
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Animator InternalGetTarget(ref PlayableOutput output);

		// Token: 0x0600249F RID: 9375
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InternalSetTarget(ref PlayableOutput output, Animator target);

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x060024A0 RID: 9376 RVA: 0x0002A0D4 File Offset: 0x000282D4
		// (set) Token: 0x060024A1 RID: 9377 RVA: 0x0002A0F4 File Offset: 0x000282F4
		public PlayableHandle sourcePlayable
		{
			get
			{
				return PlayableOutput.InternalGetSourcePlayable(ref this.m_Output);
			}
			set
			{
				PlayableOutput.InternalSetSourcePlayable(ref this.m_Output, ref value);
			}
		}

		// Token: 0x04000633 RID: 1587
		internal PlayableOutput m_Output;
	}
}
