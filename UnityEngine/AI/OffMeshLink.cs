using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI
{
	// Token: 0x020001B8 RID: 440
	[MovedFrom("UnityEngine")]
	public sealed class OffMeshLink : Behaviour
	{
		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001F94 RID: 8084
		// (set) Token: 0x06001F95 RID: 8085
		public extern bool activated { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001F96 RID: 8086
		public extern bool occupied { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001F97 RID: 8087
		// (set) Token: 0x06001F98 RID: 8088
		public extern float costOverride { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001F99 RID: 8089
		// (set) Token: 0x06001F9A RID: 8090
		public extern bool biDirectional { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06001F9B RID: 8091
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void UpdatePositions();

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001F9C RID: 8092
		// (set) Token: 0x06001F9D RID: 8093
		[Obsolete("Use area instead.")]
		public extern int navMeshLayer { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06001F9E RID: 8094
		// (set) Token: 0x06001F9F RID: 8095
		public extern int area { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06001FA0 RID: 8096
		// (set) Token: 0x06001FA1 RID: 8097
		public extern bool autoUpdatePositions { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06001FA2 RID: 8098
		// (set) Token: 0x06001FA3 RID: 8099
		public extern Transform startTransform { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06001FA4 RID: 8100
		// (set) Token: 0x06001FA5 RID: 8101
		public extern Transform endTransform { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
