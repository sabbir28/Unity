using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200007D RID: 125
	[UsedByNativeCode]
	public struct Vector3
	{
		// Token: 0x06000898 RID: 2200 RVA: 0x0000A328 File Offset: 0x00008528
		public Vector3(float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x0000A340 File Offset: 0x00008540
		public Vector3(float x, float y)
		{
			this.x = x;
			this.y = y;
			this.z = 0f;
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0000A35C File Offset: 0x0000855C
		[ThreadAndSerializationSafe]
		public static Vector3 Slerp(Vector3 a, Vector3 b, float t)
		{
			Vector3 result;
			Vector3.INTERNAL_CALL_Slerp(ref a, ref b, t, out result);
			return result;
		}

		// Token: 0x0600089B RID: 2203
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Slerp(ref Vector3 a, ref Vector3 b, float t, out Vector3 value);

		// Token: 0x0600089C RID: 2204 RVA: 0x0000A380 File Offset: 0x00008580
		public static Vector3 SlerpUnclamped(Vector3 a, Vector3 b, float t)
		{
			Vector3 result;
			Vector3.INTERNAL_CALL_SlerpUnclamped(ref a, ref b, t, out result);
			return result;
		}

		// Token: 0x0600089D RID: 2205
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SlerpUnclamped(ref Vector3 a, ref Vector3 b, float t, out Vector3 value);

		// Token: 0x0600089E RID: 2206 RVA: 0x0000A3A4 File Offset: 0x000085A4
		private static void Internal_OrthoNormalize2(ref Vector3 a, ref Vector3 b)
		{
			Vector3.INTERNAL_CALL_Internal_OrthoNormalize2(ref a, ref b);
		}

		// Token: 0x0600089F RID: 2207
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_OrthoNormalize2(ref Vector3 a, ref Vector3 b);

		// Token: 0x060008A0 RID: 2208 RVA: 0x0000A3B0 File Offset: 0x000085B0
		private static void Internal_OrthoNormalize3(ref Vector3 a, ref Vector3 b, ref Vector3 c)
		{
			Vector3.INTERNAL_CALL_Internal_OrthoNormalize3(ref a, ref b, ref c);
		}

		// Token: 0x060008A1 RID: 2209
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_OrthoNormalize3(ref Vector3 a, ref Vector3 b, ref Vector3 c);

		// Token: 0x060008A2 RID: 2210 RVA: 0x0000A3BC File Offset: 0x000085BC
		public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent)
		{
			Vector3.Internal_OrthoNormalize2(ref normal, ref tangent);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x0000A3C8 File Offset: 0x000085C8
		public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent, ref Vector3 binormal)
		{
			Vector3.Internal_OrthoNormalize3(ref normal, ref tangent, ref binormal);
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x0000A3D4 File Offset: 0x000085D4
		public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta)
		{
			Vector3 result;
			Vector3.INTERNAL_CALL_RotateTowards(ref current, ref target, maxRadiansDelta, maxMagnitudeDelta, out result);
			return result;
		}

		// Token: 0x060008A5 RID: 2213
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_RotateTowards(ref Vector3 current, ref Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta, out Vector3 value);

		// Token: 0x060008A6 RID: 2214 RVA: 0x0000A3F8 File Offset: 0x000085F8
		[Obsolete("Use Vector3.ProjectOnPlane instead.")]
		public static Vector3 Exclude(Vector3 excludeThis, Vector3 fromThat)
		{
			return fromThat - Vector3.Project(fromThat, excludeThis);
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x0000A41C File Offset: 0x0000861C
		public static Vector3 Lerp(Vector3 a, Vector3 b, float t)
		{
			t = Mathf.Clamp01(t);
			return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x0000A48C File Offset: 0x0000868C
		public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t)
		{
			return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x0000A4F4 File Offset: 0x000086F4
		public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta)
		{
			Vector3 a = target - current;
			float magnitude = a.magnitude;
			Vector3 result;
			if (magnitude <= maxDistanceDelta || magnitude == 0f)
			{
				result = target;
			}
			else
			{
				result = current + a / magnitude * maxDistanceDelta;
			}
			return result;
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x0000A548 File Offset: 0x00008748
		[ExcludeFromDocs]
		public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed)
		{
			float deltaTime = Time.deltaTime;
			return Vector3.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x0000A570 File Offset: 0x00008770
		[ExcludeFromDocs]
		public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime)
		{
			float deltaTime = Time.deltaTime;
			float positiveInfinity = float.PositiveInfinity;
			return Vector3.SmoothDamp(current, target, ref currentVelocity, smoothTime, positiveInfinity, deltaTime);
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x0000A59C File Offset: 0x0000879C
		public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, [DefaultValue("Mathf.Infinity")] float maxSpeed, [DefaultValue("Time.deltaTime")] float deltaTime)
		{
			smoothTime = Mathf.Max(0.0001f, smoothTime);
			float num = 2f / smoothTime;
			float num2 = num * deltaTime;
			float d = 1f / (1f + num2 + 0.48f * num2 * num2 + 0.235f * num2 * num2 * num2);
			Vector3 vector = current - target;
			Vector3 vector2 = target;
			float maxLength = maxSpeed * smoothTime;
			vector = Vector3.ClampMagnitude(vector, maxLength);
			target = current - vector;
			Vector3 vector3 = (currentVelocity + num * vector) * deltaTime;
			currentVelocity = (currentVelocity - num * vector3) * d;
			Vector3 vector4 = target + (vector + vector3) * d;
			if (Vector3.Dot(vector2 - current, vector4 - vector2) > 0f)
			{
				vector4 = vector2;
				currentVelocity = (vector4 - vector2) / deltaTime;
			}
			return vector4;
		}

		// Token: 0x1700021E RID: 542
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
				default:
					throw new IndexOutOfRangeException("Invalid Vector3 index!");
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
				default:
					throw new IndexOutOfRangeException("Invalid Vector3 index!");
				}
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x0000A750 File Offset: 0x00008950
		public void Set(float new_x, float new_y, float new_z)
		{
			this.x = new_x;
			this.y = new_y;
			this.z = new_z;
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x0000A768 File Offset: 0x00008968
		public static Vector3 Scale(Vector3 a, Vector3 b)
		{
			return new Vector3(a.x * b.x, a.y * b.y, a.z * b.z);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x0000A7B0 File Offset: 0x000089B0
		public void Scale(Vector3 scale)
		{
			this.x *= scale.x;
			this.y *= scale.y;
			this.z *= scale.z;
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x0000A7F0 File Offset: 0x000089F0
		public static Vector3 Cross(Vector3 lhs, Vector3 rhs)
		{
			return new Vector3(lhs.y * rhs.z - lhs.z * rhs.y, lhs.z * rhs.x - lhs.x * rhs.z, lhs.x * rhs.y - lhs.y * rhs.x);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x0000A868 File Offset: 0x00008A68
		public override int GetHashCode()
		{
			return this.x.GetHashCode() ^ this.y.GetHashCode() << 2 ^ this.z.GetHashCode() >> 2;
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x0000A8B8 File Offset: 0x00008AB8
		public override bool Equals(object other)
		{
			bool result;
			if (!(other is Vector3))
			{
				result = false;
			}
			else
			{
				Vector3 vector = (Vector3)other;
				result = (this.x.Equals(vector.x) && this.y.Equals(vector.y) && this.z.Equals(vector.z));
			}
			return result;
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x0000A92C File Offset: 0x00008B2C
		public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal)
		{
			return -2f * Vector3.Dot(inNormal, inDirection) * inNormal + inDirection;
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0000A95C File Offset: 0x00008B5C
		public static Vector3 Normalize(Vector3 value)
		{
			float num = Vector3.Magnitude(value);
			Vector3 result;
			if (num > 1E-05f)
			{
				result = value / num;
			}
			else
			{
				result = Vector3.zero;
			}
			return result;
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x0000A998 File Offset: 0x00008B98
		public void Normalize()
		{
			float num = Vector3.Magnitude(this);
			if (num > 1E-05f)
			{
				this /= num;
			}
			else
			{
				this = Vector3.zero;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x0000A9E0 File Offset: 0x00008BE0
		public Vector3 normalized
		{
			get
			{
				return Vector3.Normalize(this);
			}
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x0000AA00 File Offset: 0x00008C00
		public static float Dot(Vector3 lhs, Vector3 rhs)
		{
			return lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x0000AA44 File Offset: 0x00008C44
		public static Vector3 Project(Vector3 vector, Vector3 onNormal)
		{
			float num = Vector3.Dot(onNormal, onNormal);
			Vector3 result;
			if (num < Mathf.Epsilon)
			{
				result = Vector3.zero;
			}
			else
			{
				result = onNormal * Vector3.Dot(vector, onNormal) / num;
			}
			return result;
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x0000AA8C File Offset: 0x00008C8C
		public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal)
		{
			return vector - Vector3.Project(vector, planeNormal);
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x0000AAB0 File Offset: 0x00008CB0
		public static float Angle(Vector3 from, Vector3 to)
		{
			return Mathf.Acos(Mathf.Clamp(Vector3.Dot(from.normalized, to.normalized), -1f, 1f)) * 57.29578f;
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x0000AAF4 File Offset: 0x00008CF4
		public static float Distance(Vector3 a, Vector3 b)
		{
			Vector3 vector = new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
			return Mathf.Sqrt(vector.x * vector.x + vector.y * vector.y + vector.z * vector.z);
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x0000AB74 File Offset: 0x00008D74
		public static Vector3 ClampMagnitude(Vector3 vector, float maxLength)
		{
			Vector3 result;
			if (vector.sqrMagnitude > maxLength * maxLength)
			{
				result = vector.normalized * maxLength;
			}
			else
			{
				result = vector;
			}
			return result;
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0000ABAC File Offset: 0x00008DAC
		public static float Magnitude(Vector3 a)
		{
			return Mathf.Sqrt(a.x * a.x + a.y * a.y + a.z * a.z);
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x0000ABF8 File Offset: 0x00008DF8
		public float magnitude
		{
			get
			{
				return Mathf.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
			}
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x0000AC3C File Offset: 0x00008E3C
		public static float SqrMagnitude(Vector3 a)
		{
			return a.x * a.x + a.y * a.y + a.z * a.z;
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x0000AC80 File Offset: 0x00008E80
		public float sqrMagnitude
		{
			get
			{
				return this.x * this.x + this.y * this.y + this.z * this.z;
			}
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x0000ACC0 File Offset: 0x00008EC0
		public static Vector3 Min(Vector3 lhs, Vector3 rhs)
		{
			return new Vector3(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y), Mathf.Min(lhs.z, rhs.z));
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x0000AD14 File Offset: 0x00008F14
		public static Vector3 Max(Vector3 lhs, Vector3 rhs)
		{
			return new Vector3(Mathf.Max(lhs.x, rhs.x), Mathf.Max(lhs.y, rhs.y), Mathf.Max(lhs.z, rhs.z));
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x0000AD68 File Offset: 0x00008F68
		public static Vector3 zero
		{
			get
			{
				return new Vector3(0f, 0f, 0f);
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x0000AD94 File Offset: 0x00008F94
		public static Vector3 one
		{
			get
			{
				return new Vector3(1f, 1f, 1f);
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x0000ADC0 File Offset: 0x00008FC0
		public static Vector3 forward
		{
			get
			{
				return new Vector3(0f, 0f, 1f);
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x0000ADEC File Offset: 0x00008FEC
		public static Vector3 back
		{
			get
			{
				return new Vector3(0f, 0f, -1f);
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060008C9 RID: 2249 RVA: 0x0000AE18 File Offset: 0x00009018
		public static Vector3 up
		{
			get
			{
				return new Vector3(0f, 1f, 0f);
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x0000AE44 File Offset: 0x00009044
		public static Vector3 down
		{
			get
			{
				return new Vector3(0f, -1f, 0f);
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x0000AE70 File Offset: 0x00009070
		public static Vector3 left
		{
			get
			{
				return new Vector3(-1f, 0f, 0f);
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x0000AE9C File Offset: 0x0000909C
		public static Vector3 right
		{
			get
			{
				return new Vector3(1f, 0f, 0f);
			}
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x0000AEC8 File Offset: 0x000090C8
		public static Vector3 operator +(Vector3 a, Vector3 b)
		{
			return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x0000AF10 File Offset: 0x00009110
		public static Vector3 operator -(Vector3 a, Vector3 b)
		{
			return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0000AF58 File Offset: 0x00009158
		public static Vector3 operator -(Vector3 a)
		{
			return new Vector3(-a.x, -a.y, -a.z);
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x0000AF8C File Offset: 0x0000918C
		public static Vector3 operator *(Vector3 a, float d)
		{
			return new Vector3(a.x * d, a.y * d, a.z * d);
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0000AFC4 File Offset: 0x000091C4
		public static Vector3 operator *(float d, Vector3 a)
		{
			return new Vector3(a.x * d, a.y * d, a.z * d);
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0000AFFC File Offset: 0x000091FC
		public static Vector3 operator /(Vector3 a, float d)
		{
			return new Vector3(a.x / d, a.y / d, a.z / d);
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x0000B034 File Offset: 0x00009234
		public static bool operator ==(Vector3 lhs, Vector3 rhs)
		{
			return Vector3.SqrMagnitude(lhs - rhs) < 9.9999994E-11f;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x0000B05C File Offset: 0x0000925C
		public static bool operator !=(Vector3 lhs, Vector3 rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x0000B07C File Offset: 0x0000927C
		public override string ToString()
		{
			return UnityString.Format("({0:F1}, {1:F1}, {2:F1})", new object[]
			{
				this.x,
				this.y,
				this.z
			});
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x0000B0CC File Offset: 0x000092CC
		public string ToString(string format)
		{
			return UnityString.Format("({0}, {1}, {2})", new object[]
			{
				this.x.ToString(format),
				this.y.ToString(format),
				this.z.ToString(format)
			});
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x0000B120 File Offset: 0x00009320
		[Obsolete("Use Vector3.forward instead.")]
		public static Vector3 fwd
		{
			get
			{
				return new Vector3(0f, 0f, 1f);
			}
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x0000B14C File Offset: 0x0000934C
		[Obsolete("Use Vector3.Angle instead. AngleBetween uses radians instead of degrees and was deprecated for this reason")]
		public static float AngleBetween(Vector3 from, Vector3 to)
		{
			return Mathf.Acos(Mathf.Clamp(Vector3.Dot(from.normalized, to.normalized), -1f, 1f));
		}

		// Token: 0x040000CF RID: 207
		public const float kEpsilon = 1E-05f;

		// Token: 0x040000D0 RID: 208
		public float x;

		// Token: 0x040000D1 RID: 209
		public float y;

		// Token: 0x040000D2 RID: 210
		public float z;
	}
}
