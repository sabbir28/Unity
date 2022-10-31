using System;

namespace UnityEngine.Experimental.Director
{
	// Token: 0x02000415 RID: 1045
	public struct FrameData
	{
		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06003471 RID: 13425 RVA: 0x00052D4C File Offset: 0x00050F4C
		public ulong frameId
		{
			get
			{
				return this.m_FrameID;
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06003472 RID: 13426 RVA: 0x00052D68 File Offset: 0x00050F68
		public float deltaTime
		{
			get
			{
				return (float)this.m_DeltaTime;
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06003473 RID: 13427 RVA: 0x00052D84 File Offset: 0x00050F84
		public float weight
		{
			get
			{
				return this.m_Weight;
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06003474 RID: 13428 RVA: 0x00052DA0 File Offset: 0x00050FA0
		public float effectiveWeight
		{
			get
			{
				return this.m_EffectiveWeight;
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06003475 RID: 13429 RVA: 0x00052DBC File Offset: 0x00050FBC
		public float effectiveSpeed
		{
			get
			{
				return this.m_EffectiveSpeed;
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06003476 RID: 13430 RVA: 0x00052DD8 File Offset: 0x00050FD8
		public FrameData.EvaluationType evaluationType
		{
			get
			{
				return ((this.m_Flags & FrameData.Flags.Evaluate) == (FrameData.Flags)0) ? FrameData.EvaluationType.Playback : FrameData.EvaluationType.Evaluate;
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06003477 RID: 13431 RVA: 0x00052E04 File Offset: 0x00051004
		public bool seekOccurred
		{
			get
			{
				return (this.m_Flags & FrameData.Flags.SeekOccured) != (FrameData.Flags)0;
			}
		}

		// Token: 0x04000F13 RID: 3859
		internal ulong m_FrameID;

		// Token: 0x04000F14 RID: 3860
		internal double m_DeltaTime;

		// Token: 0x04000F15 RID: 3861
		internal float m_Weight;

		// Token: 0x04000F16 RID: 3862
		internal float m_EffectiveWeight;

		// Token: 0x04000F17 RID: 3863
		internal float m_EffectiveSpeed;

		// Token: 0x04000F18 RID: 3864
		internal FrameData.Flags m_Flags;

		// Token: 0x02000416 RID: 1046
		[Flags]
		internal enum Flags
		{
			// Token: 0x04000F1A RID: 3866
			Evaluate = 1,
			// Token: 0x04000F1B RID: 3867
			SeekOccured = 2
		}

		// Token: 0x02000417 RID: 1047
		public enum EvaluationType
		{
			// Token: 0x04000F1D RID: 3869
			Evaluate,
			// Token: 0x04000F1E RID: 3870
			Playback
		}
	}
}
