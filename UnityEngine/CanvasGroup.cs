using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000244 RID: 580
	public sealed class CanvasGroup : Component, ICanvasRaycastFilter
	{
		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06002691 RID: 9873
		// (set) Token: 0x06002692 RID: 9874
		public extern float alpha { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06002693 RID: 9875
		// (set) Token: 0x06002694 RID: 9876
		public extern bool interactable { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06002695 RID: 9877
		// (set) Token: 0x06002696 RID: 9878
		public extern bool blocksRaycasts { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06002697 RID: 9879
		// (set) Token: 0x06002698 RID: 9880
		public extern bool ignoreParentGroups { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002699 RID: 9881 RVA: 0x0002C6C4 File Offset: 0x0002A8C4
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return this.blocksRaycasts;
		}
	}
}
