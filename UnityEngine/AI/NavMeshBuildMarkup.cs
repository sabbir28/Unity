using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.AI
{
	// Token: 0x020001BE RID: 446
	public struct NavMeshBuildMarkup
	{
		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06001FDD RID: 8157 RVA: 0x000260A0 File Offset: 0x000242A0
		// (set) Token: 0x06001FDE RID: 8158 RVA: 0x000260C4 File Offset: 0x000242C4
		public bool overrideArea
		{
			get
			{
				return this.m_OverrideArea != 0;
			}
			set
			{
				this.m_OverrideArea = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06001FDF RID: 8159 RVA: 0x000260DC File Offset: 0x000242DC
		// (set) Token: 0x06001FE0 RID: 8160 RVA: 0x000260F8 File Offset: 0x000242F8
		public int area
		{
			get
			{
				return this.m_Area;
			}
			set
			{
				this.m_Area = value;
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x00026104 File Offset: 0x00024304
		// (set) Token: 0x06001FE2 RID: 8162 RVA: 0x00026128 File Offset: 0x00024328
		public bool ignoreFromBuild
		{
			get
			{
				return this.m_IgnoreFromBuild != 0;
			}
			set
			{
				this.m_IgnoreFromBuild = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x00026140 File Offset: 0x00024340
		// (set) Token: 0x06001FE4 RID: 8164 RVA: 0x00026164 File Offset: 0x00024364
		public Transform root
		{
			get
			{
				return this.InternalGetRootGO(this.m_InstanceID);
			}
			set
			{
				this.m_InstanceID = ((!(value != null)) ? 0 : value.GetInstanceID());
			}
		}

		// Token: 0x06001FE5 RID: 8165
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Transform InternalGetRootGO(int instanceID);

		// Token: 0x040004BE RID: 1214
		private int m_OverrideArea;

		// Token: 0x040004BF RID: 1215
		private int m_Area;

		// Token: 0x040004C0 RID: 1216
		private int m_IgnoreFromBuild;

		// Token: 0x040004C1 RID: 1217
		private int m_InstanceID;
	}
}
