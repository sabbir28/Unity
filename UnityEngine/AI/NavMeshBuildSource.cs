using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.AI
{
	// Token: 0x020001BD RID: 445
	[UsedByNativeCode]
	public struct NavMeshBuildSource
	{
		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06001FCF RID: 8143 RVA: 0x00025F70 File Offset: 0x00024170
		// (set) Token: 0x06001FD0 RID: 8144 RVA: 0x00025F8C File Offset: 0x0002418C
		public Matrix4x4 transform
		{
			get
			{
				return this.m_Transform;
			}
			set
			{
				this.m_Transform = value;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x00025F98 File Offset: 0x00024198
		// (set) Token: 0x06001FD2 RID: 8146 RVA: 0x00025FB4 File Offset: 0x000241B4
		public Vector3 size
		{
			get
			{
				return this.m_Size;
			}
			set
			{
				this.m_Size = value;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x00025FC0 File Offset: 0x000241C0
		// (set) Token: 0x06001FD4 RID: 8148 RVA: 0x00025FDC File Offset: 0x000241DC
		public NavMeshBuildSourceShape shape
		{
			get
			{
				return this.m_Shape;
			}
			set
			{
				this.m_Shape = value;
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x00025FE8 File Offset: 0x000241E8
		// (set) Token: 0x06001FD6 RID: 8150 RVA: 0x00026004 File Offset: 0x00024204
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

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x00026010 File Offset: 0x00024210
		// (set) Token: 0x06001FD8 RID: 8152 RVA: 0x00026034 File Offset: 0x00024234
		public Object sourceObject
		{
			get
			{
				return this.InternalGetObject(this.m_InstanceID);
			}
			set
			{
				this.m_InstanceID = ((!(value != null)) ? 0 : value.GetInstanceID());
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x00026058 File Offset: 0x00024258
		// (set) Token: 0x06001FDA RID: 8154 RVA: 0x0002607C File Offset: 0x0002427C
		public Component component
		{
			get
			{
				return this.InternalGetComponent(this.m_ComponentID);
			}
			set
			{
				this.m_ComponentID = ((!(value != null)) ? 0 : value.GetInstanceID());
			}
		}

		// Token: 0x06001FDB RID: 8155
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Component InternalGetComponent(int instanceID);

		// Token: 0x06001FDC RID: 8156
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Object InternalGetObject(int instanceID);

		// Token: 0x040004B8 RID: 1208
		private Matrix4x4 m_Transform;

		// Token: 0x040004B9 RID: 1209
		private Vector3 m_Size;

		// Token: 0x040004BA RID: 1210
		private NavMeshBuildSourceShape m_Shape;

		// Token: 0x040004BB RID: 1211
		private int m_Area;

		// Token: 0x040004BC RID: 1212
		private int m_InstanceID;

		// Token: 0x040004BD RID: 1213
		private int m_ComponentID;
	}
}
