using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020003F6 RID: 1014
	[UsedByNativeCode]
	public struct Vector2
	{
		// Token: 0x06003399 RID: 13209 RVA: 0x00050CAC File Offset: 0x0004EEAC
		public Vector2(float x, float y)
		{
			this.x = x;
			this.y = y;
		}

		// Token: 0x17000BE2 RID: 3042
		public float this[int index]
		{
			get
			{
				float result;
				if (index != 0)
				{
					if (index != 1)
					{
						throw new IndexOutOfRangeException("Invalid Vector2 index!");
					}
					result = this.y;
				}
				else
				{
					result = this.x;
				}
				return result;
			}
			set
			{
				if (index != 0)
				{
					if (index != 1)
					{
						throw new IndexOutOfRangeException("Invalid Vector2 index!");
					}
					this.y = value;
				}
				else
				{
					this.x = value;
				}
			}
		}

		// Token: 0x0600339C RID: 13212 RVA: 0x00050D3C File Offset: 0x0004EF3C
		public void Set(float newX, float newY)
		{
			this.x = newX;
			this.y = newY;
		}

		// Token: 0x0600339D RID: 13213 RVA: 0x00050D50 File Offset: 0x0004EF50
		public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
		{
			t = Mathf.Clamp01(t);
			return new Vector2(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t);
		}

		// Token: 0x0600339E RID: 13214 RVA: 0x00050DA4 File Offset: 0x0004EFA4
		public static Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t)
		{
			return new Vector2(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t);
		}

		// Token: 0x0600339F RID: 13215 RVA: 0x00050DF0 File Offset: 0x0004EFF0
		public static Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta)
		{
			Vector2 a = target - current;
			float magnitude = a.magnitude;
			Vector2 result;
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

		// Token: 0x060033A0 RID: 13216 RVA: 0x00050E44 File Offset: 0x0004F044
		public static Vector2 Scale(Vector2 a, Vector2 b)
		{
			return new Vector2(a.x * b.x, a.y * b.y);
		}

		// Token: 0x060033A1 RID: 13217 RVA: 0x00050E7C File Offset: 0x0004F07C
		public void Scale(Vector2 scale)
		{
			this.x *= scale.x;
			this.y *= scale.y;
		}

		// Token: 0x060033A2 RID: 13218 RVA: 0x00050EA8 File Offset: 0x0004F0A8
		public void Normalize()
		{
			float magnitude = this.magnitude;
			if (magnitude > 1E-05f)
			{
				this /= magnitude;
			}
			else
			{
				this = Vector2.zero;
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x060033A3 RID: 13219 RVA: 0x00050EEC File Offset: 0x0004F0EC
		public Vector2 normalized
		{
			get
			{
				Vector2 result = new Vector2(this.x, this.y);
				result.Normalize();
				return result;
			}
		}

		// Token: 0x060033A4 RID: 13220 RVA: 0x00050F1C File Offset: 0x0004F11C
		public override string ToString()
		{
			return UnityString.Format("({0:F1}, {1:F1})", new object[]
			{
				this.x,
				this.y
			});
		}

		// Token: 0x060033A5 RID: 13221 RVA: 0x00050F60 File Offset: 0x0004F160
		public string ToString(string format)
		{
			return UnityString.Format("({0}, {1})", new object[]
			{
				this.x.ToString(format),
				this.y.ToString(format)
			});
		}

		// Token: 0x060033A6 RID: 13222 RVA: 0x00050FA4 File Offset: 0x0004F1A4
		public override int GetHashCode()
		{
			return this.x.GetHashCode() ^ this.y.GetHashCode() << 2;
		}

		// Token: 0x060033A7 RID: 13223 RVA: 0x00050FE0 File Offset: 0x0004F1E0
		public override bool Equals(object other)
		{
			bool result;
			if (!(other is Vector2))
			{
				result = false;
			}
			else
			{
				Vector2 vector = (Vector2)other;
				result = (this.x.Equals(vector.x) && this.y.Equals(vector.y));
			}
			return result;
		}

		// Token: 0x060033A8 RID: 13224 RVA: 0x0005103C File Offset: 0x0004F23C
		public static Vector2 Reflect(Vector2 inDirection, Vector2 inNormal)
		{
			return -2f * Vector2.Dot(inNormal, inDirection) * inNormal + inDirection;
		}

		// Token: 0x060033A9 RID: 13225 RVA: 0x0005106C File Offset: 0x0004F26C
		public static float Dot(Vector2 lhs, Vector2 rhs)
		{
			return lhs.x * rhs.x + lhs.y * rhs.y;
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x060033AA RID: 13226 RVA: 0x000510A0 File Offset: 0x0004F2A0
		public float magnitude
		{
			get
			{
				return Mathf.Sqrt(this.x * this.x + this.y * this.y);
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x060033AB RID: 13227 RVA: 0x000510D8 File Offset: 0x0004F2D8
		public float sqrMagnitude
		{
			get
			{
				return this.x * this.x + this.y * this.y;
			}
		}

		// Token: 0x060033AC RID: 13228 RVA: 0x00051108 File Offset: 0x0004F308
		public static float Angle(Vector2 from, Vector2 to)
		{
			return Mathf.Acos(Mathf.Clamp(Vector2.Dot(from.normalized, to.normalized), -1f, 1f)) * 57.29578f;
		}

		// Token: 0x060033AD RID: 13229 RVA: 0x0005114C File Offset: 0x0004F34C
		public static float Distance(Vector2 a, Vector2 b)
		{
			return (a - b).magnitude;
		}

		// Token: 0x060033AE RID: 13230 RVA: 0x00051170 File Offset: 0x0004F370
		public static Vector2 ClampMagnitude(Vector2 vector, float maxLength)
		{
			Vector2 result;
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

		// Token: 0x060033AF RID: 13231 RVA: 0x000511A8 File Offset: 0x0004F3A8
		public static float SqrMagnitude(Vector2 a)
		{
			return a.x * a.x + a.y * a.y;
		}

		// Token: 0x060033B0 RID: 13232 RVA: 0x000511DC File Offset: 0x0004F3DC
		public float SqrMagnitude()
		{
			return this.x * this.x + this.y * this.y;
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x0005120C File Offset: 0x0004F40C
		public static Vector2 Min(Vector2 lhs, Vector2 rhs)
		{
			return new Vector2(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y));
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x0005124C File Offset: 0x0004F44C
		public static Vector2 Max(Vector2 lhs, Vector2 rhs)
		{
			return new Vector2(Mathf.Max(lhs.x, rhs.x), Mathf.Max(lhs.y, rhs.y));
		}

		// Token: 0x060033B3 RID: 13235 RVA: 0x0005128C File Offset: 0x0004F48C
		public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
		{
			smoothTime = Mathf.Max(0.0001f, smoothTime);
			float num = 2f / smoothTime;
			float num2 = num * deltaTime;
			float d = 1f / (1f + num2 + 0.48f * num2 * num2 + 0.235f * num2 * num2 * num2);
			Vector2 vector = current - target;
			Vector2 vector2 = target;
			float maxLength = maxSpeed * smoothTime;
			vector = Vector2.ClampMagnitude(vector, maxLength);
			target = current - vector;
			Vector2 vector3 = (currentVelocity + num * vector) * deltaTime;
			currentVelocity = (currentVelocity - num * vector3) * d;
			Vector2 vector4 = target + (vector + vector3) * d;
			if (Vector2.Dot(vector2 - current, vector4 - vector2) > 0f)
			{
				vector4 = vector2;
				currentVelocity = (vector4 - vector2) / deltaTime;
			}
			return vector4;
		}

		// Token: 0x060033B4 RID: 13236 RVA: 0x00051394 File Offset: 0x0004F594
		public static Vector2 operator +(Vector2 a, Vector2 b)
		{
			return new Vector2(a.x + b.x, a.y + b.y);
		}

		// Token: 0x060033B5 RID: 13237 RVA: 0x000513CC File Offset: 0x0004F5CC
		public static Vector2 operator -(Vector2 a, Vector2 b)
		{
			return new Vector2(a.x - b.x, a.y - b.y);
		}

		// Token: 0x060033B6 RID: 13238 RVA: 0x00051404 File Offset: 0x0004F604
		public static Vector2 operator -(Vector2 a)
		{
			return new Vector2(-a.x, -a.y);
		}

		// Token: 0x060033B7 RID: 13239 RVA: 0x00051430 File Offset: 0x0004F630
		public static Vector2 operator *(Vector2 a, float d)
		{
			return new Vector2(a.x * d, a.y * d);
		}

		// Token: 0x060033B8 RID: 13240 RVA: 0x0005145C File Offset: 0x0004F65C
		public static Vector2 operator *(float d, Vector2 a)
		{
			return new Vector2(a.x * d, a.y * d);
		}

		// Token: 0x060033B9 RID: 13241 RVA: 0x00051488 File Offset: 0x0004F688
		public static Vector2 operator /(Vector2 a, float d)
		{
			return new Vector2(a.x / d, a.y / d);
		}

		// Token: 0x060033BA RID: 13242 RVA: 0x000514B4 File Offset: 0x0004F6B4
		public static bool operator ==(Vector2 lhs, Vector2 rhs)
		{
			return (lhs - rhs).sqrMagnitude < 9.9999994E-11f;
		}

		// Token: 0x060033BB RID: 13243 RVA: 0x000514E0 File Offset: 0x0004F6E0
		public static bool operator !=(Vector2 lhs, Vector2 rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060033BC RID: 13244 RVA: 0x00051500 File Offset: 0x0004F700
		public static implicit operator Vector2(Vector3 v)
		{
			return new Vector2(v.x, v.y);
		}

		// Token: 0x060033BD RID: 13245 RVA: 0x00051528 File Offset: 0x0004F728
		public static implicit operator Vector3(Vector2 v)
		{
			return new Vector3(v.x, v.y, 0f);
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x060033BE RID: 13246 RVA: 0x00051558 File Offset: 0x0004F758
		public static Vector2 zero
		{
			get
			{
				return new Vector2(0f, 0f);
			}
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x060033BF RID: 13247 RVA: 0x0005157C File Offset: 0x0004F77C
		public static Vector2 one
		{
			get
			{
				return new Vector2(1f, 1f);
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x060033C0 RID: 13248 RVA: 0x000515A0 File Offset: 0x0004F7A0
		public static Vector2 up
		{
			get
			{
				return new Vector2(0f, 1f);
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x060033C1 RID: 13249 RVA: 0x000515C4 File Offset: 0x0004F7C4
		public static Vector2 down
		{
			get
			{
				return new Vector2(0f, -1f);
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x060033C2 RID: 13250 RVA: 0x000515E8 File Offset: 0x0004F7E8
		public static Vector2 left
		{
			get
			{
				return new Vector2(-1f, 0f);
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x060033C3 RID: 13251 RVA: 0x0005160C File Offset: 0x0004F80C
		public static Vector2 right
		{
			get
			{
				return new Vector2(1f, 0f);
			}
		}

		// Token: 0x04000EE3 RID: 3811
		public float x;

		// Token: 0x04000EE4 RID: 3812
		public float y;

		// Token: 0x04000EE5 RID: 3813
		public const float kEpsilon = 1E-05f;
	}
}
