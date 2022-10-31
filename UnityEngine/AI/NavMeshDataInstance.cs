using System;

namespace UnityEngine.AI
{
	// Token: 0x020001AC RID: 428
	public struct NavMeshDataInstance
	{
		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06001EE3 RID: 7907 RVA: 0x00025364 File Offset: 0x00023564
		public bool valid
		{
			get
			{
				return this.m_Handle != 0 && NavMesh.IsValidNavMeshDataHandle(this.m_Handle);
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06001EE4 RID: 7908 RVA: 0x00025394 File Offset: 0x00023594
		// (set) Token: 0x06001EE5 RID: 7909 RVA: 0x000253B0 File Offset: 0x000235B0
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

		// Token: 0x06001EE6 RID: 7910 RVA: 0x000253BC File Offset: 0x000235BC
		public void Remove()
		{
			NavMesh.RemoveNavMeshDataInternal(this.id);
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06001EE7 RID: 7911 RVA: 0x000253CC File Offset: 0x000235CC
		// (set) Token: 0x06001EE8 RID: 7912 RVA: 0x000253EC File Offset: 0x000235EC
		public Object owner
		{
			get
			{
				return NavMesh.InternalGetOwner(this.id);
			}
			set
			{
				int ownerID = (!(value != null)) ? 0 : value.GetInstanceID();
				if (!NavMesh.InternalSetOwner(this.id, ownerID))
				{
					Debug.LogError("Cannot set 'owner' on an invalid NavMeshDataInstance");
				}
			}
		}

		// Token: 0x04000472 RID: 1138
		private int m_Handle;
	}
}
