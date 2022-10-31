using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Internal.VR
{
	// Token: 0x020002DE RID: 734
	public static class VRTestMock
	{
		// Token: 0x06002EC4 RID: 11972
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Reset();

		// Token: 0x06002EC5 RID: 11973
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void AddTrackedDevice(string deviceName);

		// Token: 0x06002EC6 RID: 11974 RVA: 0x0004533C File Offset: 0x0004353C
		public static void UpdateTrackedDevice(string deviceName, Vector3 position, Quaternion rotation)
		{
			VRTestMock.INTERNAL_CALL_UpdateTrackedDevice(deviceName, ref position, ref rotation);
		}

		// Token: 0x06002EC7 RID: 11975
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_UpdateTrackedDevice(string deviceName, ref Vector3 position, ref Quaternion rotation);

		// Token: 0x06002EC8 RID: 11976 RVA: 0x0004534C File Offset: 0x0004354C
		public static void UpdateLeftEye(Vector3 position, Quaternion rotation)
		{
			VRTestMock.INTERNAL_CALL_UpdateLeftEye(ref position, ref rotation);
		}

		// Token: 0x06002EC9 RID: 11977
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_UpdateLeftEye(ref Vector3 position, ref Quaternion rotation);

		// Token: 0x06002ECA RID: 11978 RVA: 0x00045358 File Offset: 0x00043558
		public static void UpdateRightEye(Vector3 position, Quaternion rotation)
		{
			VRTestMock.INTERNAL_CALL_UpdateRightEye(ref position, ref rotation);
		}

		// Token: 0x06002ECB RID: 11979
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_UpdateRightEye(ref Vector3 position, ref Quaternion rotation);

		// Token: 0x06002ECC RID: 11980 RVA: 0x00045364 File Offset: 0x00043564
		public static void UpdateLeftHand(Vector3 position, Quaternion rotation)
		{
			VRTestMock.INTERNAL_CALL_UpdateLeftHand(ref position, ref rotation);
		}

		// Token: 0x06002ECD RID: 11981
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_UpdateLeftHand(ref Vector3 position, ref Quaternion rotation);

		// Token: 0x06002ECE RID: 11982 RVA: 0x00045370 File Offset: 0x00043570
		public static void UpdateRightHand(Vector3 position, Quaternion rotation)
		{
			VRTestMock.INTERNAL_CALL_UpdateRightHand(ref position, ref rotation);
		}

		// Token: 0x06002ECF RID: 11983
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_UpdateRightHand(ref Vector3 position, ref Quaternion rotation);

		// Token: 0x06002ED0 RID: 11984
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void AddController(string controllerName);

		// Token: 0x06002ED1 RID: 11985
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UpdateControllerAxis(string controllerName, int axis, float value);

		// Token: 0x06002ED2 RID: 11986
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UpdateControllerButton(string controllerName, int button, bool pressed);
	}
}
