using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.AI
{
	// Token: 0x020001AB RID: 427
	public sealed class NavMeshData : Object
	{
		// Token: 0x06001ED6 RID: 7894 RVA: 0x000252CC File Offset: 0x000234CC
		public NavMeshData()
		{
			NavMeshData.Internal_Create(this, 0);
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x000252DC File Offset: 0x000234DC
		public NavMeshData(int agentTypeID)
		{
			NavMeshData.Internal_Create(this, agentTypeID);
		}

		// Token: 0x06001ED8 RID: 7896
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Create([Writable] NavMeshData mono, int agentTypeID);

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06001ED9 RID: 7897 RVA: 0x000252EC File Offset: 0x000234EC
		public Bounds sourceBounds
		{
			get
			{
				Bounds result;
				this.INTERNAL_get_sourceBounds(out result);
				return result;
			}
		}

		// Token: 0x06001EDA RID: 7898
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_sourceBounds(out Bounds value);

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06001EDB RID: 7899 RVA: 0x0002530C File Offset: 0x0002350C
		// (set) Token: 0x06001EDC RID: 7900 RVA: 0x0002532C File Offset: 0x0002352C
		public Vector3 position
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_position(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_position(ref value);
			}
		}

		// Token: 0x06001EDD RID: 7901
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_position(out Vector3 value);

		// Token: 0x06001EDE RID: 7902
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_position(ref Vector3 value);

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06001EDF RID: 7903 RVA: 0x00025338 File Offset: 0x00023538
		// (set) Token: 0x06001EE0 RID: 7904 RVA: 0x00025358 File Offset: 0x00023558
		public Quaternion rotation
		{
			get
			{
				Quaternion result;
				this.INTERNAL_get_rotation(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_rotation(ref value);
			}
		}

		// Token: 0x06001EE1 RID: 7905
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_rotation(out Quaternion value);

		// Token: 0x06001EE2 RID: 7906
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_rotation(ref Quaternion value);
	}
}
