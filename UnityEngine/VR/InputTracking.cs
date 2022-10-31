using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.VR
{
	// Token: 0x020002DD RID: 733
	public static class InputTracking
	{
		// Token: 0x06002EBD RID: 11965 RVA: 0x000452FC File Offset: 0x000434FC
		public static Vector3 GetLocalPosition(VRNode node)
		{
			Vector3 result;
			InputTracking.INTERNAL_CALL_GetLocalPosition(node, out result);
			return result;
		}

		// Token: 0x06002EBE RID: 11966
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetLocalPosition(VRNode node, out Vector3 value);

		// Token: 0x06002EBF RID: 11967 RVA: 0x0004531C File Offset: 0x0004351C
		public static Quaternion GetLocalRotation(VRNode node)
		{
			Quaternion result;
			InputTracking.INTERNAL_CALL_GetLocalRotation(node, out result);
			return result;
		}

		// Token: 0x06002EC0 RID: 11968
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetLocalRotation(VRNode node, out Quaternion value);

		// Token: 0x06002EC1 RID: 11969
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Recenter();

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06002EC2 RID: 11970
		// (set) Token: 0x06002EC3 RID: 11971
		public static extern bool disablePositionalTracking { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
