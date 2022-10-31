using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001EA RID: 490
	[RequiredByNativeCode]
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class AnimationEvent
	{
		// Token: 0x0600217D RID: 8573 RVA: 0x000270EC File Offset: 0x000252EC
		public AnimationEvent()
		{
			this.m_Time = 0f;
			this.m_FunctionName = "";
			this.m_StringParameter = "";
			this.m_ObjectReferenceParameter = null;
			this.m_FloatParameter = 0f;
			this.m_IntParameter = 0;
			this.m_MessageOptions = 0;
			this.m_Source = AnimationEventSource.NoSource;
			this.m_StateSender = null;
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x0600217E RID: 8574 RVA: 0x00027150 File Offset: 0x00025350
		// (set) Token: 0x0600217F RID: 8575 RVA: 0x0002716C File Offset: 0x0002536C
		[Obsolete("Use stringParameter instead")]
		public string data
		{
			get
			{
				return this.m_StringParameter;
			}
			set
			{
				this.m_StringParameter = value;
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06002180 RID: 8576 RVA: 0x00027178 File Offset: 0x00025378
		// (set) Token: 0x06002181 RID: 8577 RVA: 0x00027194 File Offset: 0x00025394
		public string stringParameter
		{
			get
			{
				return this.m_StringParameter;
			}
			set
			{
				this.m_StringParameter = value;
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06002182 RID: 8578 RVA: 0x000271A0 File Offset: 0x000253A0
		// (set) Token: 0x06002183 RID: 8579 RVA: 0x000271BC File Offset: 0x000253BC
		public float floatParameter
		{
			get
			{
				return this.m_FloatParameter;
			}
			set
			{
				this.m_FloatParameter = value;
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06002184 RID: 8580 RVA: 0x000271C8 File Offset: 0x000253C8
		// (set) Token: 0x06002185 RID: 8581 RVA: 0x000271E4 File Offset: 0x000253E4
		public int intParameter
		{
			get
			{
				return this.m_IntParameter;
			}
			set
			{
				this.m_IntParameter = value;
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06002186 RID: 8582 RVA: 0x000271F0 File Offset: 0x000253F0
		// (set) Token: 0x06002187 RID: 8583 RVA: 0x0002720C File Offset: 0x0002540C
		public Object objectReferenceParameter
		{
			get
			{
				return this.m_ObjectReferenceParameter;
			}
			set
			{
				this.m_ObjectReferenceParameter = value;
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06002188 RID: 8584 RVA: 0x00027218 File Offset: 0x00025418
		// (set) Token: 0x06002189 RID: 8585 RVA: 0x00027234 File Offset: 0x00025434
		public string functionName
		{
			get
			{
				return this.m_FunctionName;
			}
			set
			{
				this.m_FunctionName = value;
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x0600218A RID: 8586 RVA: 0x00027240 File Offset: 0x00025440
		// (set) Token: 0x0600218B RID: 8587 RVA: 0x0002725C File Offset: 0x0002545C
		public float time
		{
			get
			{
				return this.m_Time;
			}
			set
			{
				this.m_Time = value;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x0600218C RID: 8588 RVA: 0x00027268 File Offset: 0x00025468
		// (set) Token: 0x0600218D RID: 8589 RVA: 0x00027284 File Offset: 0x00025484
		public SendMessageOptions messageOptions
		{
			get
			{
				return (SendMessageOptions)this.m_MessageOptions;
			}
			set
			{
				this.m_MessageOptions = (int)value;
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x0600218E RID: 8590 RVA: 0x00027290 File Offset: 0x00025490
		public bool isFiredByLegacy
		{
			get
			{
				return this.m_Source == AnimationEventSource.Legacy;
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x0600218F RID: 8591 RVA: 0x000272B0 File Offset: 0x000254B0
		public bool isFiredByAnimator
		{
			get
			{
				return this.m_Source == AnimationEventSource.Animator;
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06002190 RID: 8592 RVA: 0x000272D0 File Offset: 0x000254D0
		public AnimationState animationState
		{
			get
			{
				if (!this.isFiredByLegacy)
				{
					Debug.LogError("AnimationEvent was not fired by Animation component, you shouldn't use AnimationEvent.animationState");
				}
				return this.m_StateSender;
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06002191 RID: 8593 RVA: 0x00027300 File Offset: 0x00025500
		public AnimatorStateInfo animatorStateInfo
		{
			get
			{
				if (!this.isFiredByAnimator)
				{
					Debug.LogError("AnimationEvent was not fired by Animator component, you shouldn't use AnimationEvent.animatorStateInfo");
				}
				return this.m_AnimatorStateInfo;
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06002192 RID: 8594 RVA: 0x00027330 File Offset: 0x00025530
		public AnimatorClipInfo animatorClipInfo
		{
			get
			{
				if (!this.isFiredByAnimator)
				{
					Debug.LogError("AnimationEvent was not fired by Animator component, you shouldn't use AnimationEvent.animatorClipInfo");
				}
				return this.m_AnimatorClipInfo;
			}
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x00027360 File Offset: 0x00025560
		internal int GetHash()
		{
			int hashCode = this.functionName.GetHashCode();
			return 33 * hashCode + this.time.GetHashCode();
		}

		// Token: 0x04000525 RID: 1317
		internal float m_Time;

		// Token: 0x04000526 RID: 1318
		internal string m_FunctionName;

		// Token: 0x04000527 RID: 1319
		internal string m_StringParameter;

		// Token: 0x04000528 RID: 1320
		internal Object m_ObjectReferenceParameter;

		// Token: 0x04000529 RID: 1321
		internal float m_FloatParameter;

		// Token: 0x0400052A RID: 1322
		internal int m_IntParameter;

		// Token: 0x0400052B RID: 1323
		internal int m_MessageOptions;

		// Token: 0x0400052C RID: 1324
		internal AnimationEventSource m_Source;

		// Token: 0x0400052D RID: 1325
		internal AnimationState m_StateSender;

		// Token: 0x0400052E RID: 1326
		internal AnimatorStateInfo m_AnimatorStateInfo;

		// Token: 0x0400052F RID: 1327
		internal AnimatorClipInfo m_AnimatorClipInfo;
	}
}
