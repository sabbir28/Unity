using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000289 RID: 649
	public sealed class ClusterInput
	{
		// Token: 0x06002B5A RID: 11098
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetAxis(string name);

		// Token: 0x06002B5B RID: 11099
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetButton(string name);

		// Token: 0x06002B5C RID: 11100 RVA: 0x0003D1E0 File Offset: 0x0003B3E0
		public static Vector3 GetTrackerPosition(string name)
		{
			Vector3 result;
			ClusterInput.INTERNAL_CALL_GetTrackerPosition(name, out result);
			return result;
		}

		// Token: 0x06002B5D RID: 11101
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetTrackerPosition(string name, out Vector3 value);

		// Token: 0x06002B5E RID: 11102 RVA: 0x0003D200 File Offset: 0x0003B400
		public static Quaternion GetTrackerRotation(string name)
		{
			Quaternion result;
			ClusterInput.INTERNAL_CALL_GetTrackerRotation(name, out result);
			return result;
		}

		// Token: 0x06002B5F RID: 11103
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetTrackerRotation(string name, out Quaternion value);

		// Token: 0x06002B60 RID: 11104
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetAxis(string name, float value);

		// Token: 0x06002B61 RID: 11105
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetButton(string name, bool value);

		// Token: 0x06002B62 RID: 11106 RVA: 0x0003D220 File Offset: 0x0003B420
		public static void SetTrackerPosition(string name, Vector3 value)
		{
			ClusterInput.INTERNAL_CALL_SetTrackerPosition(name, ref value);
		}

		// Token: 0x06002B63 RID: 11107
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetTrackerPosition(string name, ref Vector3 value);

		// Token: 0x06002B64 RID: 11108 RVA: 0x0003D22C File Offset: 0x0003B42C
		public static void SetTrackerRotation(string name, Quaternion value)
		{
			ClusterInput.INTERNAL_CALL_SetTrackerRotation(name, ref value);
		}

		// Token: 0x06002B65 RID: 11109
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetTrackerRotation(string name, ref Quaternion value);

		// Token: 0x06002B66 RID: 11110
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool AddInput(string name, string deviceName, string serverUrl, int index, ClusterInputType type);

		// Token: 0x06002B67 RID: 11111
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EditInput(string name, string deviceName, string serverUrl, int index, ClusterInputType type);

		// Token: 0x06002B68 RID: 11112
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool CheckConnectionToServer(string name);
	}
}
