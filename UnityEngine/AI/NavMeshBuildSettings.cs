using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.AI
{
	// Token: 0x020001B9 RID: 441
	public struct NavMeshBuildSettings
	{
		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001FA6 RID: 8102 RVA: 0x00025B6C File Offset: 0x00023D6C
		// (set) Token: 0x06001FA7 RID: 8103 RVA: 0x00025B88 File Offset: 0x00023D88
		public int agentTypeID
		{
			get
			{
				return this.m_AgentTypeID;
			}
			set
			{
				this.m_AgentTypeID = value;
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001FA8 RID: 8104 RVA: 0x00025B94 File Offset: 0x00023D94
		// (set) Token: 0x06001FA9 RID: 8105 RVA: 0x00025BB0 File Offset: 0x00023DB0
		public float agentRadius
		{
			get
			{
				return this.m_AgentRadius;
			}
			set
			{
				this.m_AgentRadius = value;
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001FAA RID: 8106 RVA: 0x00025BBC File Offset: 0x00023DBC
		// (set) Token: 0x06001FAB RID: 8107 RVA: 0x00025BD8 File Offset: 0x00023DD8
		public float agentHeight
		{
			get
			{
				return this.m_AgentHeight;
			}
			set
			{
				this.m_AgentHeight = value;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06001FAC RID: 8108 RVA: 0x00025BE4 File Offset: 0x00023DE4
		// (set) Token: 0x06001FAD RID: 8109 RVA: 0x00025C00 File Offset: 0x00023E00
		public float agentSlope
		{
			get
			{
				return this.m_AgentSlope;
			}
			set
			{
				this.m_AgentSlope = value;
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001FAE RID: 8110 RVA: 0x00025C0C File Offset: 0x00023E0C
		// (set) Token: 0x06001FAF RID: 8111 RVA: 0x00025C28 File Offset: 0x00023E28
		public float agentClimb
		{
			get
			{
				return this.m_AgentClimb;
			}
			set
			{
				this.m_AgentClimb = value;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06001FB0 RID: 8112 RVA: 0x00025C34 File Offset: 0x00023E34
		// (set) Token: 0x06001FB1 RID: 8113 RVA: 0x00025C50 File Offset: 0x00023E50
		public float minRegionArea
		{
			get
			{
				return this.m_MinRegionArea;
			}
			set
			{
				this.m_MinRegionArea = value;
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001FB2 RID: 8114 RVA: 0x00025C5C File Offset: 0x00023E5C
		// (set) Token: 0x06001FB3 RID: 8115 RVA: 0x00025C80 File Offset: 0x00023E80
		public bool overrideVoxelSize
		{
			get
			{
				return this.m_OverrideVoxelSize != 0;
			}
			set
			{
				this.m_OverrideVoxelSize = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001FB4 RID: 8116 RVA: 0x00025C98 File Offset: 0x00023E98
		// (set) Token: 0x06001FB5 RID: 8117 RVA: 0x00025CB4 File Offset: 0x00023EB4
		public float voxelSize
		{
			get
			{
				return this.m_VoxelSize;
			}
			set
			{
				this.m_VoxelSize = value;
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001FB6 RID: 8118 RVA: 0x00025CC0 File Offset: 0x00023EC0
		// (set) Token: 0x06001FB7 RID: 8119 RVA: 0x00025CE4 File Offset: 0x00023EE4
		public bool overrideTileSize
		{
			get
			{
				return this.m_OverrideTileSize != 0;
			}
			set
			{
				this.m_OverrideTileSize = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001FB8 RID: 8120 RVA: 0x00025CFC File Offset: 0x00023EFC
		// (set) Token: 0x06001FB9 RID: 8121 RVA: 0x00025D18 File Offset: 0x00023F18
		public int tileSize
		{
			get
			{
				return this.m_TileSize;
			}
			set
			{
				this.m_TileSize = value;
			}
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x00025D24 File Offset: 0x00023F24
		public string[] ValidationReport(Bounds buildBounds)
		{
			return NavMeshBuildSettings.InternalValidationReport(this, buildBounds);
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x00025D48 File Offset: 0x00023F48
		private static string[] InternalValidationReport(NavMeshBuildSettings buildSettings, Bounds buildBounds)
		{
			return NavMeshBuildSettings.INTERNAL_CALL_InternalValidationReport(ref buildSettings, ref buildBounds);
		}

		// Token: 0x06001FBC RID: 8124
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string[] INTERNAL_CALL_InternalValidationReport(ref NavMeshBuildSettings buildSettings, ref Bounds buildBounds);

		// Token: 0x04000498 RID: 1176
		private int m_AgentTypeID;

		// Token: 0x04000499 RID: 1177
		private float m_AgentRadius;

		// Token: 0x0400049A RID: 1178
		private float m_AgentHeight;

		// Token: 0x0400049B RID: 1179
		private float m_AgentSlope;

		// Token: 0x0400049C RID: 1180
		private float m_AgentClimb;

		// Token: 0x0400049D RID: 1181
		private float m_LedgeDropHeight;

		// Token: 0x0400049E RID: 1182
		private float m_MaxJumpAcrossDistance;

		// Token: 0x0400049F RID: 1183
		private float m_MinRegionArea;

		// Token: 0x040004A0 RID: 1184
		private int m_OverrideVoxelSize;

		// Token: 0x040004A1 RID: 1185
		private float m_VoxelSize;

		// Token: 0x040004A2 RID: 1186
		private int m_OverrideTileSize;

		// Token: 0x040004A3 RID: 1187
		private int m_TileSize;

		// Token: 0x040004A4 RID: 1188
		private int m_AccuratePlacement;
	}
}
