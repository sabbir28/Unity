using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI
{
	// Token: 0x020001B3 RID: 435
	[MovedFrom("UnityEngine")]
	public sealed class NavMeshObstacle : Behaviour
	{
		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06001F67 RID: 8039
		// (set) Token: 0x06001F68 RID: 8040
		public extern float height { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06001F69 RID: 8041
		// (set) Token: 0x06001F6A RID: 8042
		public extern float radius { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06001F6B RID: 8043 RVA: 0x00025994 File Offset: 0x00023B94
		// (set) Token: 0x06001F6C RID: 8044 RVA: 0x000259B4 File Offset: 0x00023BB4
		public Vector3 velocity
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_velocity(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_velocity(ref value);
			}
		}

		// Token: 0x06001F6D RID: 8045
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_velocity(out Vector3 value);

		// Token: 0x06001F6E RID: 8046
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_velocity(ref Vector3 value);

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001F6F RID: 8047
		// (set) Token: 0x06001F70 RID: 8048
		public extern bool carving { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001F71 RID: 8049
		// (set) Token: 0x06001F72 RID: 8050
		public extern bool carveOnlyStationary { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001F73 RID: 8051
		// (set) Token: 0x06001F74 RID: 8052
		public extern float carvingMoveThreshold { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001F75 RID: 8053
		// (set) Token: 0x06001F76 RID: 8054
		public extern float carvingTimeToStationary { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001F77 RID: 8055
		// (set) Token: 0x06001F78 RID: 8056
		public extern NavMeshObstacleShape shape { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06001F79 RID: 8057 RVA: 0x000259C0 File Offset: 0x00023BC0
		// (set) Token: 0x06001F7A RID: 8058 RVA: 0x000259E0 File Offset: 0x00023BE0
		public Vector3 center
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_center(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_center(ref value);
			}
		}

		// Token: 0x06001F7B RID: 8059
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_center(out Vector3 value);

		// Token: 0x06001F7C RID: 8060
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_center(ref Vector3 value);

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06001F7D RID: 8061 RVA: 0x000259EC File Offset: 0x00023BEC
		// (set) Token: 0x06001F7E RID: 8062 RVA: 0x00025A0C File Offset: 0x00023C0C
		public Vector3 size
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_size(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_size(ref value);
			}
		}

		// Token: 0x06001F7F RID: 8063
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_size(out Vector3 value);

		// Token: 0x06001F80 RID: 8064
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_size(ref Vector3 value);

		// Token: 0x06001F81 RID: 8065
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void FitExtents();
	}
}
