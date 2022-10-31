using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI
{
	// Token: 0x020001B7 RID: 439
	[MovedFrom("UnityEngine")]
	public struct OffMeshLinkData
	{
		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001F8C RID: 8076 RVA: 0x00025AA4 File Offset: 0x00023CA4
		public bool valid
		{
			get
			{
				return this.m_Valid != 0;
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06001F8D RID: 8077 RVA: 0x00025AC8 File Offset: 0x00023CC8
		public bool activated
		{
			get
			{
				return this.m_Activated != 0;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06001F8E RID: 8078 RVA: 0x00025AEC File Offset: 0x00023CEC
		public OffMeshLinkType linkType
		{
			get
			{
				return this.m_LinkType;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06001F8F RID: 8079 RVA: 0x00025B08 File Offset: 0x00023D08
		public Vector3 startPos
		{
			get
			{
				return this.m_StartPos;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06001F90 RID: 8080 RVA: 0x00025B24 File Offset: 0x00023D24
		public Vector3 endPos
		{
			get
			{
				return this.m_EndPos;
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06001F91 RID: 8081 RVA: 0x00025B40 File Offset: 0x00023D40
		public OffMeshLink offMeshLink
		{
			get
			{
				return this.GetOffMeshLinkInternal(this.m_InstanceID);
			}
		}

		// Token: 0x06001F92 RID: 8082
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern OffMeshLink GetOffMeshLinkInternal(int instanceID);

		// Token: 0x04000492 RID: 1170
		private int m_Valid;

		// Token: 0x04000493 RID: 1171
		private int m_Activated;

		// Token: 0x04000494 RID: 1172
		private int m_InstanceID;

		// Token: 0x04000495 RID: 1173
		private OffMeshLinkType m_LinkType;

		// Token: 0x04000496 RID: 1174
		private Vector3 m_StartPos;

		// Token: 0x04000497 RID: 1175
		private Vector3 m_EndPos;
	}
}
