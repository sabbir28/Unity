using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001A5 RID: 421
	[UsedByNativeCode]
	public struct ClothSphereColliderPair
	{
		// Token: 0x06001E4B RID: 7755 RVA: 0x00024C94 File Offset: 0x00022E94
		public ClothSphereColliderPair(SphereCollider a)
		{
			this.m_First = null;
			this.m_Second = null;
			this.first = a;
			this.second = null;
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x00024CB4 File Offset: 0x00022EB4
		public ClothSphereColliderPair(SphereCollider a, SphereCollider b)
		{
			this.m_First = null;
			this.m_Second = null;
			this.first = a;
			this.second = b;
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06001E4D RID: 7757 RVA: 0x00024CD4 File Offset: 0x00022ED4
		// (set) Token: 0x06001E4E RID: 7758 RVA: 0x00024CF0 File Offset: 0x00022EF0
		public SphereCollider first
		{
			get
			{
				return this.m_First;
			}
			set
			{
				this.m_First = value;
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06001E4F RID: 7759 RVA: 0x00024CFC File Offset: 0x00022EFC
		// (set) Token: 0x06001E50 RID: 7760 RVA: 0x00024D18 File Offset: 0x00022F18
		public SphereCollider second
		{
			get
			{
				return this.m_Second;
			}
			set
			{
				this.m_Second = value;
			}
		}

		// Token: 0x04000466 RID: 1126
		private SphereCollider m_First;

		// Token: 0x04000467 RID: 1127
		private SphereCollider m_Second;
	}
}
