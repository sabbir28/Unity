using System;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Director
{
	// Token: 0x020000DF RID: 223
	[UsedByNativeCode]
	public struct ScriptPlayableOutput
	{
		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x000162D8 File Offset: 0x000144D8
		public static ScriptPlayableOutput Null
		{
			get
			{
				return new ScriptPlayableOutput
				{
					m_Output = new PlayableOutput
					{
						m_Version = 69
					}
				};
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06001069 RID: 4201 RVA: 0x00016310 File Offset: 0x00014510
		// (set) Token: 0x0600106A RID: 4202 RVA: 0x00016330 File Offset: 0x00014530
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

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x00016340 File Offset: 0x00014540
		// (set) Token: 0x0600106C RID: 4204 RVA: 0x00016360 File Offset: 0x00014560
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

		// Token: 0x0600106D RID: 4205 RVA: 0x00016370 File Offset: 0x00014570
		public bool IsValid()
		{
			return PlayableOutput.IsValidInternal(ref this.m_Output);
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x0600106E RID: 4206 RVA: 0x00016390 File Offset: 0x00014590
		// (set) Token: 0x0600106F RID: 4207 RVA: 0x000163B0 File Offset: 0x000145B0
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

		// Token: 0x04000208 RID: 520
		internal PlayableOutput m_Output;
	}
}
