using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.VR
{
	// Token: 0x020002DB RID: 731
	public static class VRDevice
	{
		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06002EB1 RID: 11953
		public static extern bool isPresent { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06002EB2 RID: 11954
		[Obsolete("family is deprecated.  Use VRSettings.loadedDeviceName instead.")]
		public static extern string family { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06002EB3 RID: 11955
		public static extern string model { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06002EB4 RID: 11956
		public static extern float refreshRate { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002EB5 RID: 11957
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern TrackingSpaceType GetTrackingSpaceType();

		// Token: 0x06002EB6 RID: 11958
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SetTrackingSpaceType(TrackingSpaceType trackingSpaceType);

		// Token: 0x06002EB7 RID: 11959 RVA: 0x000452AC File Offset: 0x000434AC
		public static IntPtr GetNativePtr()
		{
			IntPtr result;
			VRDevice.INTERNAL_CALL_GetNativePtr(out result);
			return result;
		}

		// Token: 0x06002EB8 RID: 11960
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetNativePtr(out IntPtr value);
	}
}
