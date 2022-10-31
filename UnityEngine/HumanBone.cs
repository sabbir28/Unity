using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000205 RID: 517
	[RequiredByNativeCode]
	public struct HumanBone
	{
		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06002343 RID: 9027 RVA: 0x000289B0 File Offset: 0x00026BB0
		// (set) Token: 0x06002344 RID: 9028 RVA: 0x000289CC File Offset: 0x00026BCC
		public string boneName
		{
			get
			{
				return this.m_BoneName;
			}
			set
			{
				this.m_BoneName = value;
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06002345 RID: 9029 RVA: 0x000289D8 File Offset: 0x00026BD8
		// (set) Token: 0x06002346 RID: 9030 RVA: 0x000289F4 File Offset: 0x00026BF4
		public string humanName
		{
			get
			{
				return this.m_HumanName;
			}
			set
			{
				this.m_HumanName = value;
			}
		}

		// Token: 0x0400058C RID: 1420
		private string m_BoneName;

		// Token: 0x0400058D RID: 1421
		private string m_HumanName;

		// Token: 0x0400058E RID: 1422
		public HumanLimit limit;
	}
}
