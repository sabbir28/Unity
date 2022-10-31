using System;

namespace UnityEngine.AI
{
	// Token: 0x020001BA RID: 442
	internal struct NavMeshBuildDebugSettings
	{
		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001FBD RID: 8125 RVA: 0x00025D68 File Offset: 0x00023F68
		// (set) Token: 0x06001FBE RID: 8126 RVA: 0x00025D8C File Offset: 0x00023F8C
		public bool showInputGeom
		{
			get
			{
				return this.m_ShowInputGeom != 0;
			}
			set
			{
				this.m_ShowInputGeom = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06001FBF RID: 8127 RVA: 0x00025DA4 File Offset: 0x00023FA4
		// (set) Token: 0x06001FC0 RID: 8128 RVA: 0x00025DC8 File Offset: 0x00023FC8
		public bool showVoxels
		{
			get
			{
				return this.m_ShowVoxels != 0;
			}
			set
			{
				this.m_ShowVoxels = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x00025DE0 File Offset: 0x00023FE0
		// (set) Token: 0x06001FC2 RID: 8130 RVA: 0x00025E04 File Offset: 0x00024004
		public bool showRegions
		{
			get
			{
				return this.m_ShowRegions != 0;
			}
			set
			{
				this.m_ShowRegions = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x00025E1C File Offset: 0x0002401C
		// (set) Token: 0x06001FC4 RID: 8132 RVA: 0x00025E40 File Offset: 0x00024040
		public bool showRawContours
		{
			get
			{
				return this.m_ShowRawContours != 0;
			}
			set
			{
				this.m_ShowRawContours = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x00025E58 File Offset: 0x00024058
		// (set) Token: 0x06001FC6 RID: 8134 RVA: 0x00025E7C File Offset: 0x0002407C
		public bool showContours
		{
			get
			{
				return this.m_ShowContours != 0;
			}
			set
			{
				this.m_ShowContours = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x00025E94 File Offset: 0x00024094
		// (set) Token: 0x06001FC8 RID: 8136 RVA: 0x00025EB8 File Offset: 0x000240B8
		public bool showPolyMesh
		{
			get
			{
				return this.m_ShowPolyMesh != 0;
			}
			set
			{
				this.m_ShowPolyMesh = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x00025ED0 File Offset: 0x000240D0
		// (set) Token: 0x06001FCA RID: 8138 RVA: 0x00025EF4 File Offset: 0x000240F4
		public bool showPolyMeshDetail
		{
			get
			{
				return this.m_ShowPolyMeshDetail != 0;
			}
			set
			{
				this.m_ShowPolyMeshDetail = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06001FCB RID: 8139 RVA: 0x00025F0C File Offset: 0x0002410C
		// (set) Token: 0x06001FCC RID: 8140 RVA: 0x00025F30 File Offset: 0x00024130
		public bool useFocus
		{
			get
			{
				return this.m_UseFocus != 0;
			}
			set
			{
				this.m_UseFocus = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x00025F48 File Offset: 0x00024148
		// (set) Token: 0x06001FCE RID: 8142 RVA: 0x00025F64 File Offset: 0x00024164
		public Vector3 focusPoint
		{
			get
			{
				return this.m_FocusPoint;
			}
			set
			{
				this.m_FocusPoint = value;
			}
		}

		// Token: 0x040004A5 RID: 1189
		private int m_ShowInputGeom;

		// Token: 0x040004A6 RID: 1190
		private int m_ShowVoxels;

		// Token: 0x040004A7 RID: 1191
		private int m_ShowRegions;

		// Token: 0x040004A8 RID: 1192
		private int m_ShowRawContours;

		// Token: 0x040004A9 RID: 1193
		private int m_ShowContours;

		// Token: 0x040004AA RID: 1194
		private int m_ShowPolyMesh;

		// Token: 0x040004AB RID: 1195
		private int m_ShowPolyMeshDetail;

		// Token: 0x040004AC RID: 1196
		private int m_UseFocus;

		// Token: 0x040004AD RID: 1197
		private Vector3 m_FocusPoint;
	}
}
