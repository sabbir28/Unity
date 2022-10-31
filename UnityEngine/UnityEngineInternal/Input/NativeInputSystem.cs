using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Scripting;

namespace UnityEngineInternal.Input
{
	// Token: 0x020002F7 RID: 759
	public sealed class NativeInputSystem
	{
		// Token: 0x06002F61 RID: 12129 RVA: 0x00045870 File Offset: 0x00043A70
		[RequiredByNativeCode]
		internal static void NotifyUpdate(NativeInputUpdateType updateType)
		{
			NativeUpdateCallback nativeUpdateCallback = NativeInputSystem.onUpdate;
			if (nativeUpdateCallback != null)
			{
				nativeUpdateCallback(updateType);
			}
		}

		// Token: 0x06002F62 RID: 12130 RVA: 0x00045894 File Offset: 0x00043A94
		[RequiredByNativeCode]
		internal static void NotifyEvents(int eventCount, IntPtr eventData)
		{
			NativeEventCallback nativeEventCallback = NativeInputSystem.onEvents;
			if (nativeEventCallback != null)
			{
				nativeEventCallback(eventCount, eventData);
			}
		}

		// Token: 0x06002F63 RID: 12131 RVA: 0x000458B8 File Offset: 0x00043AB8
		[RequiredByNativeCode]
		internal static void NotifyDeviceDiscovered(NativeInputDeviceInfo deviceInfo)
		{
			NativeDeviceDiscoveredCallback nativeDeviceDiscoveredCallback = NativeInputSystem.onDeviceDiscovered;
			if (nativeDeviceDiscoveredCallback != null)
			{
				nativeDeviceDiscoveredCallback(deviceInfo);
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06002F64 RID: 12132
		internal static extern bool enabled { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06002F65 RID: 12133
		public static extern double zeroEventTime { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002F66 RID: 12134
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SendInput(ref NativeInputEvent inputEvent);

		// Token: 0x06002F67 RID: 12135
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string GetDeviceConfiguration(int deviceId);

		// Token: 0x06002F68 RID: 12136
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string GetControlConfiguration(int deviceId, int controlIndex);

		// Token: 0x06002F69 RID: 12137 RVA: 0x000458DC File Offset: 0x00043ADC
		public static void SetPollingFrequency(float hertz)
		{
			if (hertz < 1f)
			{
				throw new ArgumentException("Polling frequency cannot be less than 1Hz");
			}
			NativeInputSystem.SetPollingFrequencyInternal(hertz);
		}

		// Token: 0x06002F6A RID: 12138
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetPollingFrequencyInternal(float hertz);

		// Token: 0x040009C6 RID: 2502
		public static NativeUpdateCallback onUpdate;

		// Token: 0x040009C7 RID: 2503
		public static NativeEventCallback onEvents;

		// Token: 0x040009C8 RID: 2504
		public static NativeDeviceDiscoveredCallback onDeviceDiscovered;
	}
}
