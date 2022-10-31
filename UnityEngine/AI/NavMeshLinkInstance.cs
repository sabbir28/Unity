using System;

namespace UnityEngine.AI
{
	// Token: 0x020001AE RID: 430
	public struct NavMeshLinkInstance
	{
		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x0002555C File Offset: 0x0002375C
		public bool valid
		{
			get
			{
				return this.m_Handle != 0 && NavMesh.IsValidLinkHandle(this.m_Handle);
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06001EF8 RID: 7928 RVA: 0x0002558C File Offset: 0x0002378C
		// (set) Token: 0x06001EF9 RID: 7929 RVA: 0x000255A8 File Offset: 0x000237A8
		internal int id
		{
			get
			{
				return this.m_Handle;
			}
			set
			{
				this.m_Handle = value;
			}
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x000255B4 File Offset: 0x000237B4
		public void Remove()
		{
			NavMesh.RemoveLinkInternal(this.id);
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06001EFB RID: 7931 RVA: 0x000255C4 File Offset: 0x000237C4
		// (set) Token: 0x06001EFC RID: 7932 RVA: 0x000255E4 File Offset: 0x000237E4
		public Object owner
		{
			get
			{
				return NavMesh.InternalGetLinkOwner(this.id);
			}
			set
			{
				int ownerID = (!(value != null)) ? 0 : value.GetInstanceID();
				if (!NavMesh.InternalSetLinkOwner(this.id, ownerID))
				{
					Debug.LogError("Cannot set 'owner' on an invalid NavMeshLinkInstance");
				}
			}
		}

		// Token: 0x0400047A RID: 1146
		private int m_Handle;
	}
}
