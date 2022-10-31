using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.VR
{
	// Token: 0x020002DA RID: 730
	public static class VRSettings
	{
		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06002E9E RID: 11934
		// (set) Token: 0x06002E9F RID: 11935
		public static extern bool enabled { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06002EA0 RID: 11936
		public static extern bool isDeviceActive { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06002EA1 RID: 11937
		// (set) Token: 0x06002EA2 RID: 11938
		public static extern bool showDeviceView { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06002EA3 RID: 11939
		// (set) Token: 0x06002EA4 RID: 11940
		public static extern float renderScale { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06002EA5 RID: 11941
		public static extern int eyeTextureWidth { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06002EA6 RID: 11942
		public static extern int eyeTextureHeight { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06002EA7 RID: 11943 RVA: 0x000451E0 File Offset: 0x000433E0
		// (set) Token: 0x06002EA8 RID: 11944 RVA: 0x000451FC File Offset: 0x000433FC
		public static float renderViewportScale
		{
			get
			{
				return VRSettings.renderViewportScaleInternal;
			}
			set
			{
				if (value < 0f || value > 1f)
				{
					throw new ArgumentOutOfRangeException("value", "Render viewport scale should be between 0 and 1.");
				}
				VRSettings.renderViewportScaleInternal = value;
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06002EA9 RID: 11945
		// (set) Token: 0x06002EAA RID: 11946
		internal static extern float renderViewportScaleInternal { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06002EAB RID: 11947 RVA: 0x0004522C File Offset: 0x0004342C
		// (set) Token: 0x06002EAC RID: 11948 RVA: 0x00045280 File Offset: 0x00043480
		[Obsolete("loadedDevice is deprecated.  Use loadedDeviceName and LoadDeviceByName instead.")]
		public static VRDeviceType loadedDevice
		{
			get
			{
				VRDeviceType result = VRDeviceType.Unknown;
				try
				{
					result = (VRDeviceType)Enum.Parse(typeof(VRDeviceType), VRSettings.loadedDeviceName, true);
				}
				catch (Exception)
				{
				}
				return result;
			}
			set
			{
				VRSettings.LoadDeviceByName(value.ToString());
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06002EAD RID: 11949
		public static extern string loadedDeviceName { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002EAE RID: 11950 RVA: 0x00045298 File Offset: 0x00043498
		public static void LoadDeviceByName(string deviceName)
		{
			VRSettings.LoadDeviceByName(new string[]
			{
				deviceName
			});
		}

		// Token: 0x06002EAF RID: 11951
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LoadDeviceByName(string[] prioritizedDeviceNameList);

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06002EB0 RID: 11952
		public static extern string[] supportedDevices { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
