using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000071 RID: 113
	public sealed class Input
	{
		// Token: 0x060007D5 RID: 2005
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int mainGyroIndex_Internal();

		// Token: 0x060007D6 RID: 2006
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetKeyInt(int key);

		// Token: 0x060007D7 RID: 2007
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetKeyString(string name);

		// Token: 0x060007D8 RID: 2008
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetKeyUpInt(int key);

		// Token: 0x060007D9 RID: 2009
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetKeyUpString(string name);

		// Token: 0x060007DA RID: 2010
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetKeyDownInt(int key);

		// Token: 0x060007DB RID: 2011
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetKeyDownString(string name);

		// Token: 0x060007DC RID: 2012
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetAxis(string axisName);

		// Token: 0x060007DD RID: 2013
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetAxisRaw(string axisName);

		// Token: 0x060007DE RID: 2014
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetButton(string buttonName);

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060007DF RID: 2015
		// (set) Token: 0x060007E0 RID: 2016
		public static extern bool compensateSensors { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060007E1 RID: 2017
		[Obsolete("isGyroAvailable property is deprecated. Please use SystemInfo.supportsGyroscope instead.")]
		public static extern bool isGyroAvailable { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x00009E14 File Offset: 0x00008014
		public static Gyroscope gyro
		{
			get
			{
				if (Input.m_MainGyro == null)
				{
					Input.m_MainGyro = new Gyroscope(Input.mainGyroIndex_Internal());
				}
				return Input.m_MainGyro;
			}
		}

		// Token: 0x060007E3 RID: 2019
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetButtonDown(string buttonName);

		// Token: 0x060007E4 RID: 2020
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetButtonUp(string buttonName);

		// Token: 0x060007E5 RID: 2021 RVA: 0x00009E48 File Offset: 0x00008048
		public static bool GetKey(string name)
		{
			return Input.GetKeyString(name);
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00009E64 File Offset: 0x00008064
		public static bool GetKey(KeyCode key)
		{
			return Input.GetKeyInt((int)key);
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00009E80 File Offset: 0x00008080
		public static bool GetKeyDown(string name)
		{
			return Input.GetKeyDownString(name);
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00009E9C File Offset: 0x0000809C
		public static bool GetKeyDown(KeyCode key)
		{
			return Input.GetKeyDownInt((int)key);
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00009EB8 File Offset: 0x000080B8
		public static bool GetKeyUp(string name)
		{
			return Input.GetKeyUpString(name);
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00009ED4 File Offset: 0x000080D4
		public static bool GetKeyUp(KeyCode key)
		{
			return Input.GetKeyUpInt((int)key);
		}

		// Token: 0x060007EB RID: 2027
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string[] GetJoystickNames();

		// Token: 0x060007EC RID: 2028
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetMouseButton(int button);

		// Token: 0x060007ED RID: 2029
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetMouseButtonDown(int button);

		// Token: 0x060007EE RID: 2030
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetMouseButtonUp(int button);

		// Token: 0x060007EF RID: 2031
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResetInputAxes();

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x00009EF0 File Offset: 0x000080F0
		public static Vector3 mousePosition
		{
			get
			{
				Vector3 result;
				Input.INTERNAL_get_mousePosition(out result);
				return result;
			}
		}

		// Token: 0x060007F1 RID: 2033
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_mousePosition(out Vector3 value);

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x00009F10 File Offset: 0x00008110
		public static Vector2 mouseScrollDelta
		{
			get
			{
				Vector2 result;
				Input.INTERNAL_get_mouseScrollDelta(out result);
				return result;
			}
		}

		// Token: 0x060007F3 RID: 2035
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_mouseScrollDelta(out Vector2 value);

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060007F4 RID: 2036
		public static extern bool mousePresent { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060007F5 RID: 2037
		// (set) Token: 0x060007F6 RID: 2038
		public static extern bool simulateMouseWithTouches { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060007F7 RID: 2039
		public static extern bool anyKey { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060007F8 RID: 2040
		public static extern bool anyKeyDown { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060007F9 RID: 2041
		public static extern string inputString { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x00009F30 File Offset: 0x00008130
		public static Vector3 acceleration
		{
			get
			{
				Vector3 result;
				Input.INTERNAL_get_acceleration(out result);
				return result;
			}
		}

		// Token: 0x060007FB RID: 2043
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_acceleration(out Vector3 value);

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x00009F50 File Offset: 0x00008150
		public static AccelerationEvent[] accelerationEvents
		{
			get
			{
				int accelerationEventCount = Input.accelerationEventCount;
				AccelerationEvent[] array = new AccelerationEvent[accelerationEventCount];
				for (int i = 0; i < accelerationEventCount; i++)
				{
					array[i] = Input.GetAccelerationEvent(i);
				}
				return array;
			}
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00009F98 File Offset: 0x00008198
		public static AccelerationEvent GetAccelerationEvent(int index)
		{
			AccelerationEvent result;
			Input.INTERNAL_CALL_GetAccelerationEvent(index, out result);
			return result;
		}

		// Token: 0x060007FE RID: 2046
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetAccelerationEvent(int index, out AccelerationEvent value);

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060007FF RID: 2047
		public static extern int accelerationEventCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x00009FB8 File Offset: 0x000081B8
		public static Touch[] touches
		{
			get
			{
				int touchCount = Input.touchCount;
				Touch[] array = new Touch[touchCount];
				for (int i = 0; i < touchCount; i++)
				{
					array[i] = Input.GetTouch(i);
				}
				return array;
			}
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x0000A000 File Offset: 0x00008200
		public static Touch GetTouch(int index)
		{
			Touch result;
			Input.INTERNAL_CALL_GetTouch(index, out result);
			return result;
		}

		// Token: 0x06000802 RID: 2050
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetTouch(int index, out Touch value);

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000803 RID: 2051
		public static extern int touchCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000804 RID: 2052
		// (set) Token: 0x06000805 RID: 2053
		[Obsolete("eatKeyPressOnTextFieldFocus property is deprecated, and only provided to support legacy behavior.")]
		public static extern bool eatKeyPressOnTextFieldFocus { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000806 RID: 2054
		public static extern bool touchPressureSupported { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000807 RID: 2055
		public static extern bool stylusTouchSupported { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000808 RID: 2056
		public static extern bool touchSupported { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000809 RID: 2057
		// (set) Token: 0x0600080A RID: 2058
		public static extern bool multiTouchEnabled { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x0000A020 File Offset: 0x00008220
		public static LocationService location
		{
			get
			{
				if (Input.locationServiceInstance == null)
				{
					Input.locationServiceInstance = new LocationService();
				}
				return Input.locationServiceInstance;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x0000A050 File Offset: 0x00008250
		public static Compass compass
		{
			get
			{
				if (Input.compassInstance == null)
				{
					Input.compassInstance = new Compass();
				}
				return Input.compassInstance;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600080D RID: 2061
		public static extern DeviceOrientation deviceOrientation { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600080E RID: 2062
		// (set) Token: 0x0600080F RID: 2063
		public static extern IMECompositionMode imeCompositionMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000810 RID: 2064
		public static extern string compositionString { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000811 RID: 2065
		public static extern bool imeIsSelected { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x0000A080 File Offset: 0x00008280
		// (set) Token: 0x06000813 RID: 2067 RVA: 0x0000A0A0 File Offset: 0x000082A0
		public static Vector2 compositionCursorPos
		{
			get
			{
				Vector2 result;
				Input.INTERNAL_get_compositionCursorPos(out result);
				return result;
			}
			set
			{
				Input.INTERNAL_set_compositionCursorPos(ref value);
			}
		}

		// Token: 0x06000814 RID: 2068
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_compositionCursorPos(out Vector2 value);

		// Token: 0x06000815 RID: 2069
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_compositionCursorPos(ref Vector2 value);

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000816 RID: 2070
		// (set) Token: 0x06000817 RID: 2071
		public static extern bool backButtonLeavesApp { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x040000B5 RID: 181
		private static Gyroscope m_MainGyro = null;

		// Token: 0x040000B6 RID: 182
		private static LocationService locationServiceInstance;

		// Token: 0x040000B7 RID: 183
		private static Compass compassInstance;
	}
}
