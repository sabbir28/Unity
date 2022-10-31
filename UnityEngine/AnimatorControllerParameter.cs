using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000201 RID: 513
	[UsedByNativeCode]
	public sealed class AnimatorControllerParameter
	{
		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06002328 RID: 9000 RVA: 0x00028738 File Offset: 0x00026938
		public string name
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06002329 RID: 9001 RVA: 0x00028754 File Offset: 0x00026954
		public int nameHash
		{
			get
			{
				return Animator.StringToHash(this.m_Name);
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x0600232A RID: 9002 RVA: 0x00028774 File Offset: 0x00026974
		// (set) Token: 0x0600232B RID: 9003 RVA: 0x00028790 File Offset: 0x00026990
		public AnimatorControllerParameterType type
		{
			get
			{
				return this.m_Type;
			}
			set
			{
				this.m_Type = value;
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x0600232C RID: 9004 RVA: 0x0002879C File Offset: 0x0002699C
		// (set) Token: 0x0600232D RID: 9005 RVA: 0x000287B8 File Offset: 0x000269B8
		public float defaultFloat
		{
			get
			{
				return this.m_DefaultFloat;
			}
			set
			{
				this.m_DefaultFloat = value;
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x0600232E RID: 9006 RVA: 0x000287C4 File Offset: 0x000269C4
		// (set) Token: 0x0600232F RID: 9007 RVA: 0x000287E0 File Offset: 0x000269E0
		public int defaultInt
		{
			get
			{
				return this.m_DefaultInt;
			}
			set
			{
				this.m_DefaultInt = value;
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06002330 RID: 9008 RVA: 0x000287EC File Offset: 0x000269EC
		// (set) Token: 0x06002331 RID: 9009 RVA: 0x00028808 File Offset: 0x00026A08
		public bool defaultBool
		{
			get
			{
				return this.m_DefaultBool;
			}
			set
			{
				this.m_DefaultBool = value;
			}
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x00028814 File Offset: 0x00026A14
		public override bool Equals(object o)
		{
			AnimatorControllerParameter animatorControllerParameter = o as AnimatorControllerParameter;
			return animatorControllerParameter != null && this.m_Name == animatorControllerParameter.m_Name && this.m_Type == animatorControllerParameter.m_Type && this.m_DefaultFloat == animatorControllerParameter.m_DefaultFloat && this.m_DefaultInt == animatorControllerParameter.m_DefaultInt && this.m_DefaultBool == animatorControllerParameter.m_DefaultBool;
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x00028890 File Offset: 0x00026A90
		public override int GetHashCode()
		{
			return this.name.GetHashCode();
		}

		// Token: 0x0400057D RID: 1405
		internal string m_Name = "";

		// Token: 0x0400057E RID: 1406
		internal AnimatorControllerParameterType m_Type;

		// Token: 0x0400057F RID: 1407
		internal float m_DefaultFloat;

		// Token: 0x04000580 RID: 1408
		internal int m_DefaultInt;

		// Token: 0x04000581 RID: 1409
		internal bool m_DefaultBool;
	}
}
