using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200007E RID: 126
	[UsedByNativeCode]
	public struct Quaternion
	{
		// Token: 0x060008D9 RID: 2265 RVA: 0x0000B188 File Offset: 0x00009388
		public Quaternion(float x, float y, float z, float w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x0000B1A8 File Offset: 0x000093A8
		[ThreadAndSerializationSafe]
		public static Quaternion AngleAxis(float angle, Vector3 axis)
		{
			Quaternion result;
			Quaternion.INTERNAL_CALL_AngleAxis(angle, ref axis, out result);
			return result;
		}

		// Token: 0x060008DB RID: 2267
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AngleAxis(float angle, ref Vector3 axis, out Quaternion value);

		// Token: 0x060008DC RID: 2268 RVA: 0x0000B1C8 File Offset: 0x000093C8
		public void ToAngleAxis(out float angle, out Vector3 axis)
		{
			Quaternion.Internal_ToAxisAngleRad(this, out axis, out angle);
			angle *= 57.29578f;
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0000B1E4 File Offset: 0x000093E4
		public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection)
		{
			Quaternion result;
			Quaternion.INTERNAL_CALL_FromToRotation(ref fromDirection, ref toDirection, out result);
			return result;
		}

		// Token: 0x060008DE RID: 2270
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_FromToRotation(ref Vector3 fromDirection, ref Vector3 toDirection, out Quaternion value);

		// Token: 0x060008DF RID: 2271 RVA: 0x0000B208 File Offset: 0x00009408
		public void SetFromToRotation(Vector3 fromDirection, Vector3 toDirection)
		{
			this = Quaternion.FromToRotation(fromDirection, toDirection);
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0000B218 File Offset: 0x00009418
		public static Quaternion LookRotation(Vector3 forward, [DefaultValue("Vector3.up")] Vector3 upwards)
		{
			Quaternion result;
			Quaternion.INTERNAL_CALL_LookRotation(ref forward, ref upwards, out result);
			return result;
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0000B23C File Offset: 0x0000943C
		[ExcludeFromDocs]
		public static Quaternion LookRotation(Vector3 forward)
		{
			Vector3 up = Vector3.up;
			Quaternion result;
			Quaternion.INTERNAL_CALL_LookRotation(ref forward, ref up, out result);
			return result;
		}

		// Token: 0x060008E2 RID: 2274
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_LookRotation(ref Vector3 forward, ref Vector3 upwards, out Quaternion value);

		// Token: 0x060008E3 RID: 2275 RVA: 0x0000B264 File Offset: 0x00009464
		public static Quaternion Slerp(Quaternion a, Quaternion b, float t)
		{
			Quaternion result;
			Quaternion.INTERNAL_CALL_Slerp(ref a, ref b, t, out result);
			return result;
		}

		// Token: 0x060008E4 RID: 2276
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Slerp(ref Quaternion a, ref Quaternion b, float t, out Quaternion value);

		// Token: 0x060008E5 RID: 2277 RVA: 0x0000B288 File Offset: 0x00009488
		public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t)
		{
			Quaternion result;
			Quaternion.INTERNAL_CALL_SlerpUnclamped(ref a, ref b, t, out result);
			return result;
		}

		// Token: 0x060008E6 RID: 2278
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SlerpUnclamped(ref Quaternion a, ref Quaternion b, float t, out Quaternion value);

		// Token: 0x060008E7 RID: 2279 RVA: 0x0000B2AC File Offset: 0x000094AC
		public static Quaternion Lerp(Quaternion a, Quaternion b, float t)
		{
			Quaternion result;
			Quaternion.INTERNAL_CALL_Lerp(ref a, ref b, t, out result);
			return result;
		}

		// Token: 0x060008E8 RID: 2280
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Lerp(ref Quaternion a, ref Quaternion b, float t, out Quaternion value);

		// Token: 0x060008E9 RID: 2281 RVA: 0x0000B2D0 File Offset: 0x000094D0
		public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t)
		{
			Quaternion result;
			Quaternion.INTERNAL_CALL_LerpUnclamped(ref a, ref b, t, out result);
			return result;
		}

		// Token: 0x060008EA RID: 2282
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_LerpUnclamped(ref Quaternion a, ref Quaternion b, float t, out Quaternion value);

		// Token: 0x060008EB RID: 2283 RVA: 0x0000B2F4 File Offset: 0x000094F4
		public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta)
		{
			float num = Quaternion.Angle(from, to);
			Quaternion result;
			if (num == 0f)
			{
				result = to;
			}
			else
			{
				float t = Mathf.Min(1f, maxDegreesDelta / num);
				result = Quaternion.SlerpUnclamped(from, to, t);
			}
			return result;
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x0000B33C File Offset: 0x0000953C
		public static Quaternion Inverse(Quaternion rotation)
		{
			Quaternion result;
			Quaternion.INTERNAL_CALL_Inverse(ref rotation, out result);
			return result;
		}

		// Token: 0x060008ED RID: 2285
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Inverse(ref Quaternion rotation, out Quaternion value);

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x0000B35C File Offset: 0x0000955C
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x0000B38C File Offset: 0x0000958C
		public Vector3 eulerAngles
		{
			get
			{
				return Quaternion.Internal_MakePositive(Quaternion.Internal_ToEulerRad(this) * 57.29578f);
			}
			set
			{
				this = Quaternion.Internal_FromEulerRad(value * 0.017453292f);
			}
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x0000B3A8 File Offset: 0x000095A8
		public static Quaternion Euler(float x, float y, float z)
		{
			return Quaternion.Internal_FromEulerRad(new Vector3(x, y, z) * 0.017453292f);
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x0000B3D4 File Offset: 0x000095D4
		public static Quaternion Euler(Vector3 euler)
		{
			return Quaternion.Internal_FromEulerRad(euler * 0.017453292f);
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0000B3FC File Offset: 0x000095FC
		private static Vector3 Internal_ToEulerRad(Quaternion rotation)
		{
			Vector3 result;
			Quaternion.INTERNAL_CALL_Internal_ToEulerRad(ref rotation, out result);
			return result;
		}

		// Token: 0x060008F3 RID: 2291
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_ToEulerRad(ref Quaternion rotation, out Vector3 value);

		// Token: 0x060008F4 RID: 2292 RVA: 0x0000B41C File Offset: 0x0000961C
		private static Quaternion Internal_FromEulerRad(Vector3 euler)
		{
			Quaternion result;
			Quaternion.INTERNAL_CALL_Internal_FromEulerRad(ref euler, out result);
			return result;
		}

		// Token: 0x060008F5 RID: 2293
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_FromEulerRad(ref Vector3 euler, out Quaternion value);

		// Token: 0x060008F6 RID: 2294 RVA: 0x0000B43C File Offset: 0x0000963C
		private static void Internal_ToAxisAngleRad(Quaternion q, out Vector3 axis, out float angle)
		{
			Quaternion.INTERNAL_CALL_Internal_ToAxisAngleRad(ref q, out axis, out angle);
		}

		// Token: 0x060008F7 RID: 2295
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_ToAxisAngleRad(ref Quaternion q, out Vector3 axis, out float angle);

		// Token: 0x060008F8 RID: 2296 RVA: 0x0000B448 File Offset: 0x00009648
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
		public static Quaternion EulerRotation(float x, float y, float z)
		{
			return Quaternion.Internal_FromEulerRad(new Vector3(x, y, z));
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x0000B46C File Offset: 0x0000966C
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
		public static Quaternion EulerRotation(Vector3 euler)
		{
			return Quaternion.Internal_FromEulerRad(euler);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x0000B488 File Offset: 0x00009688
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
		public void SetEulerRotation(float x, float y, float z)
		{
			this = Quaternion.Internal_FromEulerRad(new Vector3(x, y, z));
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x0000B4A0 File Offset: 0x000096A0
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
		public void SetEulerRotation(Vector3 euler)
		{
			this = Quaternion.Internal_FromEulerRad(euler);
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x0000B4B0 File Offset: 0x000096B0
		[Obsolete("Use Quaternion.eulerAngles instead. This function was deprecated because it uses radians instead of degrees")]
		public Vector3 ToEuler()
		{
			return Quaternion.Internal_ToEulerRad(this);
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0000B4D0 File Offset: 0x000096D0
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
		public static Quaternion EulerAngles(float x, float y, float z)
		{
			return Quaternion.Internal_FromEulerRad(new Vector3(x, y, z));
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x0000B4F4 File Offset: 0x000096F4
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
		public static Quaternion EulerAngles(Vector3 euler)
		{
			return Quaternion.Internal_FromEulerRad(euler);
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0000B510 File Offset: 0x00009710
		[Obsolete("Use Quaternion.ToAngleAxis instead. This function was deprecated because it uses radians instead of degrees")]
		public void ToAxisAngle(out Vector3 axis, out float angle)
		{
			Quaternion.Internal_ToAxisAngleRad(this, out axis, out angle);
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x0000B520 File Offset: 0x00009720
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
		public void SetEulerAngles(float x, float y, float z)
		{
			this.SetEulerRotation(new Vector3(x, y, z));
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0000B534 File Offset: 0x00009734
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
		public void SetEulerAngles(Vector3 euler)
		{
			this = Quaternion.EulerRotation(euler);
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0000B544 File Offset: 0x00009744
		[Obsolete("Use Quaternion.eulerAngles instead. This function was deprecated because it uses radians instead of degrees")]
		public static Vector3 ToEulerAngles(Quaternion rotation)
		{
			return Quaternion.Internal_ToEulerRad(rotation);
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x0000B560 File Offset: 0x00009760
		[Obsolete("Use Quaternion.eulerAngles instead. This function was deprecated because it uses radians instead of degrees")]
		public Vector3 ToEulerAngles()
		{
			return Quaternion.Internal_ToEulerRad(this);
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0000B580 File Offset: 0x00009780
		[Obsolete("Use Quaternion.AngleAxis instead. This function was deprecated because it uses radians instead of degrees")]
		public static Quaternion AxisAngle(Vector3 axis, float angle)
		{
			Quaternion result;
			Quaternion.INTERNAL_CALL_AxisAngle(ref axis, angle, out result);
			return result;
		}

		// Token: 0x06000905 RID: 2309
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AxisAngle(ref Vector3 axis, float angle, out Quaternion value);

		// Token: 0x06000906 RID: 2310 RVA: 0x0000B5A0 File Offset: 0x000097A0
		[Obsolete("Use Quaternion.AngleAxis instead. This function was deprecated because it uses radians instead of degrees")]
		public void SetAxisAngle(Vector3 axis, float angle)
		{
			this = Quaternion.AxisAngle(axis, angle);
		}

		// Token: 0x1700022C RID: 556
		public float this[int index]
		{
			get
			{
				float result;
				switch (index)
				{
				case 0:
					result = this.x;
					break;
				case 1:
					result = this.y;
					break;
				case 2:
					result = this.z;
					break;
				case 3:
					result = this.w;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid Quaternion index!");
				}
				return result;
			}
			set
			{
				switch (index)
				{
				case 0:
					this.x = value;
					break;
				case 1:
					this.y = value;
					break;
				case 2:
					this.z = value;
					break;
				case 3:
					this.w = value;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid Quaternion index!");
				}
			}
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0000B67C File Offset: 0x0000987C
		public void Set(float new_x, float new_y, float new_z, float new_w)
		{
			this.x = new_x;
			this.y = new_y;
			this.z = new_z;
			this.w = new_w;
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x0000B69C File Offset: 0x0000989C
		public static Quaternion identity
		{
			get
			{
				return new Quaternion(0f, 0f, 0f, 1f);
			}
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x0000B6CC File Offset: 0x000098CC
		public static Quaternion operator *(Quaternion lhs, Quaternion rhs)
		{
			return new Quaternion(lhs.w * rhs.x + lhs.x * rhs.w + lhs.y * rhs.z - lhs.z * rhs.y, lhs.w * rhs.y + lhs.y * rhs.w + lhs.z * rhs.x - lhs.x * rhs.z, lhs.w * rhs.z + lhs.z * rhs.w + lhs.x * rhs.y - lhs.y * rhs.x, lhs.w * rhs.w - lhs.x * rhs.x - lhs.y * rhs.y - lhs.z * rhs.z);
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x0000B7E4 File Offset: 0x000099E4
		public static Vector3 operator *(Quaternion rotation, Vector3 point)
		{
			float num = rotation.x * 2f;
			float num2 = rotation.y * 2f;
			float num3 = rotation.z * 2f;
			float num4 = rotation.x * num;
			float num5 = rotation.y * num2;
			float num6 = rotation.z * num3;
			float num7 = rotation.x * num2;
			float num8 = rotation.x * num3;
			float num9 = rotation.y * num3;
			float num10 = rotation.w * num;
			float num11 = rotation.w * num2;
			float num12 = rotation.w * num3;
			Vector3 result;
			result.x = (1f - (num5 + num6)) * point.x + (num7 - num12) * point.y + (num8 + num11) * point.z;
			result.y = (num7 + num12) * point.x + (1f - (num4 + num6)) * point.y + (num9 - num10) * point.z;
			result.z = (num8 - num11) * point.x + (num9 + num10) * point.y + (1f - (num4 + num5)) * point.z;
			return result;
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x0000B92C File Offset: 0x00009B2C
		public static bool operator ==(Quaternion lhs, Quaternion rhs)
		{
			return Quaternion.Dot(lhs, rhs) > 0.999999f;
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0000B950 File Offset: 0x00009B50
		public static bool operator !=(Quaternion lhs, Quaternion rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0000B970 File Offset: 0x00009B70
		public static float Dot(Quaternion a, Quaternion b)
		{
			return a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w;
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0000B9C4 File Offset: 0x00009BC4
		[ExcludeFromDocs]
		public void SetLookRotation(Vector3 view)
		{
			Vector3 up = Vector3.up;
			this.SetLookRotation(view, up);
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0000B9E0 File Offset: 0x00009BE0
		public void SetLookRotation(Vector3 view, [DefaultValue("Vector3.up")] Vector3 up)
		{
			this = Quaternion.LookRotation(view, up);
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0000B9F0 File Offset: 0x00009BF0
		public static float Angle(Quaternion a, Quaternion b)
		{
			float f = Quaternion.Dot(a, b);
			return Mathf.Acos(Mathf.Min(Mathf.Abs(f), 1f)) * 2f * 57.29578f;
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0000BA30 File Offset: 0x00009C30
		private static Vector3 Internal_MakePositive(Vector3 euler)
		{
			float num = -0.005729578f;
			float num2 = 360f + num;
			if (euler.x < num)
			{
				euler.x += 360f;
			}
			else if (euler.x > num2)
			{
				euler.x -= 360f;
			}
			if (euler.y < num)
			{
				euler.y += 360f;
			}
			else if (euler.y > num2)
			{
				euler.y -= 360f;
			}
			if (euler.z < num)
			{
				euler.z += 360f;
			}
			else if (euler.z > num2)
			{
				euler.z -= 360f;
			}
			return euler;
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0000BB24 File Offset: 0x00009D24
		public override int GetHashCode()
		{
			return this.x.GetHashCode() ^ this.y.GetHashCode() << 2 ^ this.z.GetHashCode() >> 2 ^ this.w.GetHashCode() >> 1;
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0000BB88 File Offset: 0x00009D88
		public override bool Equals(object other)
		{
			bool result;
			if (!(other is Quaternion))
			{
				result = false;
			}
			else
			{
				Quaternion quaternion = (Quaternion)other;
				result = (this.x.Equals(quaternion.x) && this.y.Equals(quaternion.y) && this.z.Equals(quaternion.z) && this.w.Equals(quaternion.w));
			}
			return result;
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0000BC10 File Offset: 0x00009E10
		public override string ToString()
		{
			return UnityString.Format("({0:F1}, {1:F1}, {2:F1}, {3:F1})", new object[]
			{
				this.x,
				this.y,
				this.z,
				this.w
			});
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0000BC70 File Offset: 0x00009E70
		public string ToString(string format)
		{
			return UnityString.Format("({0}, {1}, {2}, {3})", new object[]
			{
				this.x.ToString(format),
				this.y.ToString(format),
				this.z.ToString(format),
				this.w.ToString(format)
			});
		}

		// Token: 0x040000D3 RID: 211
		public float x;

		// Token: 0x040000D4 RID: 212
		public float y;

		// Token: 0x040000D5 RID: 213
		public float z;

		// Token: 0x040000D6 RID: 214
		public float w;

		// Token: 0x040000D7 RID: 215
		public const float kEpsilon = 1E-06f;
	}
}
