using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x02000108 RID: 264
	[RequireComponent(typeof(Transform))]
	public sealed class SortingGroup : Behaviour
	{
		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001246 RID: 4678
		// (set) Token: 0x06001247 RID: 4679
		public extern string sortingLayerName { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001248 RID: 4680
		// (set) Token: 0x06001249 RID: 4681
		public extern int sortingLayerID { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x0600124A RID: 4682
		// (set) Token: 0x0600124B RID: 4683
		public extern int sortingOrder { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x0600124C RID: 4684
		internal extern int sortingGroupID { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x0600124D RID: 4685
		internal extern int sortingGroupOrder { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x0600124E RID: 4686
		internal extern int index { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
