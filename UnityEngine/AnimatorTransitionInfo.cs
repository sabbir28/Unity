using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001FE RID: 510
	[RequiredByNativeCode]
	public struct AnimatorTransitionInfo
	{
		// Token: 0x0600221D RID: 8733 RVA: 0x00027994 File Offset: 0x00025B94
		public bool IsName(string name)
		{
			return Animator.StringToHash(name) == this.m_Name || Animator.StringToHash(name) == this.m_FullPath;
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x000279CC File Offset: 0x00025BCC
		public bool IsUserName(string name)
		{
			return Animator.StringToHash(name) == this.m_UserName;
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x0600221F RID: 8735 RVA: 0x000279F0 File Offset: 0x00025BF0
		public int fullPathHash
		{
			get
			{
				return this.m_FullPath;
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06002220 RID: 8736 RVA: 0x00027A0C File Offset: 0x00025C0C
		public int nameHash
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06002221 RID: 8737 RVA: 0x00027A28 File Offset: 0x00025C28
		public int userNameHash
		{
			get
			{
				return this.m_UserName;
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06002222 RID: 8738 RVA: 0x00027A44 File Offset: 0x00025C44
		public float normalizedTime
		{
			get
			{
				return this.m_NormalizedTime;
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06002223 RID: 8739 RVA: 0x00027A60 File Offset: 0x00025C60
		public bool anyState
		{
			get
			{
				return this.m_AnyState;
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06002224 RID: 8740 RVA: 0x00027A7C File Offset: 0x00025C7C
		internal bool entry
		{
			get
			{
				return (this.m_TransitionType & 2) != 0;
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06002225 RID: 8741 RVA: 0x00027AA0 File Offset: 0x00025CA0
		internal bool exit
		{
			get
			{
				return (this.m_TransitionType & 4) != 0;
			}
		}

		// Token: 0x04000575 RID: 1397
		private int m_FullPath;

		// Token: 0x04000576 RID: 1398
		private int m_UserName;

		// Token: 0x04000577 RID: 1399
		private int m_Name;

		// Token: 0x04000578 RID: 1400
		private float m_NormalizedTime;

		// Token: 0x04000579 RID: 1401
		private bool m_AnyState;

		// Token: 0x0400057A RID: 1402
		private int m_TransitionType;
	}
}
