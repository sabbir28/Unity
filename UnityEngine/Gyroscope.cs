using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200006C RID: 108
	public sealed class Gyroscope
	{
		// Token: 0x060007A5 RID: 1957 RVA: 0x00009B44 File Offset: 0x00007D44
		internal Gyroscope(int index)
		{
			this.m_GyroIndex = index;
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00009B54 File Offset: 0x00007D54
		private static Vector3 rotationRate_Internal(int idx)
		{
			Vector3 result;
			Gyroscope.INTERNAL_CALL_rotationRate_Internal(idx, out result);
			return result;
		}

		// Token: 0x060007A7 RID: 1959
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_rotationRate_Internal(int idx, out Vector3 value);

		// Token: 0x060007A8 RID: 1960 RVA: 0x00009B74 File Offset: 0x00007D74
		private static Vector3 rotationRateUnbiased_Internal(int idx)
		{
			Vector3 result;
			Gyroscope.INTERNAL_CALL_rotationRateUnbiased_Internal(idx, out result);
			return result;
		}

		// Token: 0x060007A9 RID: 1961
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_rotationRateUnbiased_Internal(int idx, out Vector3 value);

		// Token: 0x060007AA RID: 1962 RVA: 0x00009B94 File Offset: 0x00007D94
		private static Vector3 gravity_Internal(int idx)
		{
			Vector3 result;
			Gyroscope.INTERNAL_CALL_gravity_Internal(idx, out result);
			return result;
		}

		// Token: 0x060007AB RID: 1963
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_gravity_Internal(int idx, out Vector3 value);

		// Token: 0x060007AC RID: 1964 RVA: 0x00009BB4 File Offset: 0x00007DB4
		private static Vector3 userAcceleration_Internal(int idx)
		{
			Vector3 result;
			Gyroscope.INTERNAL_CALL_userAcceleration_Internal(idx, out result);
			return result;
		}

		// Token: 0x060007AD RID: 1965
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_userAcceleration_Internal(int idx, out Vector3 value);

		// Token: 0x060007AE RID: 1966 RVA: 0x00009BD4 File Offset: 0x00007DD4
		private static Quaternion attitude_Internal(int idx)
		{
			Quaternion result;
			Gyroscope.INTERNAL_CALL_attitude_Internal(idx, out result);
			return result;
		}

		// Token: 0x060007AF RID: 1967
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_attitude_Internal(int idx, out Quaternion value);

		// Token: 0x060007B0 RID: 1968
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool getEnabled_Internal(int idx);

		// Token: 0x060007B1 RID: 1969
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void setEnabled_Internal(int idx, bool enabled);

		// Token: 0x060007B2 RID: 1970
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float getUpdateInterval_Internal(int idx);

		// Token: 0x060007B3 RID: 1971
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void setUpdateInterval_Internal(int idx, float interval);

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x00009BF4 File Offset: 0x00007DF4
		public Vector3 rotationRate
		{
			get
			{
				return Gyroscope.rotationRate_Internal(this.m_GyroIndex);
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x00009C14 File Offset: 0x00007E14
		public Vector3 rotationRateUnbiased
		{
			get
			{
				return Gyroscope.rotationRateUnbiased_Internal(this.m_GyroIndex);
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x00009C34 File Offset: 0x00007E34
		public Vector3 gravity
		{
			get
			{
				return Gyroscope.gravity_Internal(this.m_GyroIndex);
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x00009C54 File Offset: 0x00007E54
		public Vector3 userAcceleration
		{
			get
			{
				return Gyroscope.userAcceleration_Internal(this.m_GyroIndex);
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x00009C74 File Offset: 0x00007E74
		public Quaternion attitude
		{
			get
			{
				return Gyroscope.attitude_Internal(this.m_GyroIndex);
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x00009C94 File Offset: 0x00007E94
		// (set) Token: 0x060007BA RID: 1978 RVA: 0x00009CB4 File Offset: 0x00007EB4
		public bool enabled
		{
			get
			{
				return Gyroscope.getEnabled_Internal(this.m_GyroIndex);
			}
			set
			{
				Gyroscope.setEnabled_Internal(this.m_GyroIndex, value);
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x00009CC4 File Offset: 0x00007EC4
		// (set) Token: 0x060007BC RID: 1980 RVA: 0x00009CE4 File Offset: 0x00007EE4
		public float updateInterval
		{
			get
			{
				return Gyroscope.getUpdateInterval_Internal(this.m_GyroIndex);
			}
			set
			{
				Gyroscope.setUpdateInterval_Internal(this.m_GyroIndex, value);
			}
		}

		// Token: 0x040000A9 RID: 169
		private int m_GyroIndex;
	}
}
