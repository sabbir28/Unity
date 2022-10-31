using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020003F7 RID: 1015
	[UsedByNativeCode]
	public struct Vector4
	{
		// Token: 0x060033C4 RID: 13252 RVA: 0x00051630 File Offset: 0x0004F830
		public Vector4(float x, float y, float z, float w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		// Token: 0x060033C5 RID: 13253 RVA: 0x00051650 File Offset: 0x0004F850
		public Vector4(float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = 0f;
		}

		// Token: 0x060033C6 RID: 13254 RVA: 0x00051674 File Offset: 0x0004F874
		public Vector4(float x, float y)
		{
			this.x = x;
			this.y = y;
			this.z = 0f;
			this.w = 0f;
		}

		// Token: 0x17000BEC RID: 3052
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
					throw new IndexOutOfRangeException("Invalid Vector4 index!");
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
					throw new IndexOutOfRangeException("Invalid Vector4 index!");
				}
			}
		}

		// Token: 0x060033C9 RID: 13257 RVA: 0x00051768 File Offset: 0x0004F968
		public void Set(float new_x, float new_y, float new_z, float new_w)
		{
			this.x = new_x;
			this.y = new_y;
			this.z = new_z;
			this.w = new_w;
		}

		// Token: 0x060033CA RID: 13258 RVA: 0x00051788 File Offset: 0x0004F988
		public static Vector4 Lerp(Vector4 a, Vector4 b, float t)
		{
			t = Mathf.Clamp01(t);
			return new Vector4(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t, a.w + (b.w - a.w) * t);
		}

		// Token: 0x060033CB RID: 13259 RVA: 0x00051810 File Offset: 0x0004FA10
		public static Vector4 LerpUnclamped(Vector4 a, Vector4 b, float t)
		{
			return new Vector4(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t, a.w + (b.w - a.w) * t);
		}

		// Token: 0x060033CC RID: 13260 RVA: 0x00051890 File Offset: 0x0004FA90
		public static Vector4 MoveTowards(Vector4 current, Vector4 target, float maxDistanceDelta)
		{
			Vector4 a = target - current;
			float magnitude = a.magnitude;
			Vector4 result;
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

		// Token: 0x060033CD RID: 13261 RVA: 0x000518E4 File Offset: 0x0004FAE4
		public static Vector4 Scale(Vector4 a, Vector4 b)
		{
			return new Vector4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
		}

		// Token: 0x060033CE RID: 13262 RVA: 0x0005193C File Offset: 0x0004FB3C
		public void Scale(Vector4 scale)
		{
			this.x *= scale.x;
			this.y *= scale.y;
			this.z *= scale.z;
			this.w *= scale.w;
		}

		// Token: 0x060033CF RID: 13263 RVA: 0x0005199C File Offset: 0x0004FB9C
		public override int GetHashCode()
		{
			return this.x.GetHashCode() ^ this.y.GetHashCode() << 2 ^ this.z.GetHashCode() >> 2 ^ this.w.GetHashCode() >> 1;
		}

		// Token: 0x060033D0 RID: 13264 RVA: 0x00051A00 File Offset: 0x0004FC00
		public override bool Equals(object other)
		{
			bool result;
			if (!(other is Vector4))
			{
				result = false;
			}
			else
			{
				Vector4 vector = (Vector4)other;
				result = (this.x.Equals(vector.x) && this.y.Equals(vector.y) && this.z.Equals(vector.z) && this.w.Equals(vector.w));
			}
			return result;
		}

		// Token: 0x060033D1 RID: 13265 RVA: 0x00051A88 File Offset: 0x0004FC88
		public static Vector4 Normalize(Vector4 a)
		{
			float num = Vector4.Magnitude(a);
			Vector4 result;
			if (num > 1E-05f)
			{
				result = a / num;
			}
			else
			{
				result = Vector4.zero;
			}
			return result;
		}

		// Token: 0x060033D2 RID: 13266 RVA: 0x00051AC4 File Offset: 0x0004FCC4
		public void Normalize()
		{
			float num = Vector4.Magnitude(this);
			if (num > 1E-05f)
			{
				this /= num;
			}
			else
			{
				this = Vector4.zero;
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x060033D3 RID: 13267 RVA: 0x00051B0C File Offset: 0x0004FD0C
		public Vector4 normalized
		{
			get
			{
				return Vector4.Normalize(this);
			}
		}

		// Token: 0x060033D4 RID: 13268 RVA: 0x00051B2C File Offset: 0x0004FD2C
		public static float Dot(Vector4 a, Vector4 b)
		{
			return a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w;
		}

		// Token: 0x060033D5 RID: 13269 RVA: 0x00051B80 File Offset: 0x0004FD80
		public static Vector4 Project(Vector4 a, Vector4 b)
		{
			return b * Vector4.Dot(a, b) / Vector4.Dot(b, b);
		}

		// Token: 0x060033D6 RID: 13270 RVA: 0x00051BB0 File Offset: 0x0004FDB0
		public static float Distance(Vector4 a, Vector4 b)
		{
			return Vector4.Magnitude(a - b);
		}

		// Token: 0x060033D7 RID: 13271 RVA: 0x00051BD4 File Offset: 0x0004FDD4
		public static float Magnitude(Vector4 a)
		{
			return Mathf.Sqrt(Vector4.Dot(a, a));
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x060033D8 RID: 13272 RVA: 0x00051BF8 File Offset: 0x0004FDF8
		public float magnitude
		{
			get
			{
				return Mathf.Sqrt(Vector4.Dot(this, this));
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x060033D9 RID: 13273 RVA: 0x00051C24 File Offset: 0x0004FE24
		public float sqrMagnitude
		{
			get
			{
				return Vector4.Dot(this, this);
			}
		}

		// Token: 0x060033DA RID: 13274 RVA: 0x00051C4C File Offset: 0x0004FE4C
		public static Vector4 Min(Vector4 lhs, Vector4 rhs)
		{
			return new Vector4(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y), Mathf.Min(lhs.z, rhs.z), Mathf.Min(lhs.w, rhs.w));
		}

		// Token: 0x060033DB RID: 13275 RVA: 0x00051CB4 File Offset: 0x0004FEB4
		public static Vector4 Max(Vector4 lhs, Vector4 rhs)
		{
			return new Vector4(Mathf.Max(lhs.x, rhs.x), Mathf.Max(lhs.y, rhs.y), Mathf.Max(lhs.z, rhs.z), Mathf.Max(lhs.w, rhs.w));
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x060033DC RID: 13276 RVA: 0x00051D1C File Offset: 0x0004FF1C
		public static Vector4 zero
		{
			get
			{
				return new Vector4(0f, 0f, 0f, 0f);
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x060033DD RID: 13277 RVA: 0x00051D4C File Offset: 0x0004FF4C
		public static Vector4 one
		{
			get
			{
				return new Vector4(1f, 1f, 1f, 1f);
			}
		}

		// Token: 0x060033DE RID: 13278 RVA: 0x00051D7C File Offset: 0x0004FF7C
		public static Vector4 operator +(Vector4 a, Vector4 b)
		{
			return new Vector4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
		}

		// Token: 0x060033DF RID: 13279 RVA: 0x00051DD4 File Offset: 0x0004FFD4
		public static Vector4 operator -(Vector4 a, Vector4 b)
		{
			return new Vector4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
		}

		// Token: 0x060033E0 RID: 13280 RVA: 0x00051E2C File Offset: 0x0005002C
		public static Vector4 operator -(Vector4 a)
		{
			return new Vector4(-a.x, -a.y, -a.z, -a.w);
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x00051E68 File Offset: 0x00050068
		public static Vector4 operator *(Vector4 a, float d)
		{
			return new Vector4(a.x * d, a.y * d, a.z * d, a.w * d);
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x00051EA8 File Offset: 0x000500A8
		public static Vector4 operator *(float d, Vector4 a)
		{
			return new Vector4(a.x * d, a.y * d, a.z * d, a.w * d);
		}

		// Token: 0x060033E3 RID: 13283 RVA: 0x00051EE8 File Offset: 0x000500E8
		public static Vector4 operator /(Vector4 a, float d)
		{
			return new Vector4(a.x / d, a.y / d, a.z / d, a.w / d);
		}

		// Token: 0x060033E4 RID: 13284 RVA: 0x00051F28 File Offset: 0x00050128
		public static bool operator ==(Vector4 lhs, Vector4 rhs)
		{
			return Vector4.SqrMagnitude(lhs - rhs) < 9.9999994E-11f;
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x00051F50 File Offset: 0x00050150
		public static bool operator !=(Vector4 lhs, Vector4 rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060033E6 RID: 13286 RVA: 0x00051F70 File Offset: 0x00050170
		public static implicit operator Vector4(Vector3 v)
		{
			return new Vector4(v.x, v.y, v.z, 0f);
		}

		// Token: 0x060033E7 RID: 13287 RVA: 0x00051FA4 File Offset: 0x000501A4
		public static implicit operator Vector3(Vector4 v)
		{
			return new Vector3(v.x, v.y, v.z);
		}

		// Token: 0x060033E8 RID: 13288 RVA: 0x00051FD4 File Offset: 0x000501D4
		public static implicit operator Vector4(Vector2 v)
		{
			return new Vector4(v.x, v.y, 0f, 0f);
		}

		// Token: 0x060033E9 RID: 13289 RVA: 0x00052008 File Offset: 0x00050208
		public static implicit operator Vector2(Vector4 v)
		{
			return new Vector2(v.x, v.y);
		}

		// Token: 0x060033EA RID: 13290 RVA: 0x00052030 File Offset: 0x00050230
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

		// Token: 0x060033EB RID: 13291 RVA: 0x00052090 File Offset: 0x00050290
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

		// Token: 0x060033EC RID: 13292 RVA: 0x000520F4 File Offset: 0x000502F4
		public static float SqrMagnitude(Vector4 a)
		{
			return Vector4.Dot(a, a);
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x00052110 File Offset: 0x00050310
		public float SqrMagnitude()
		{
			return Vector4.Dot(this, this);
		}

		// Token: 0x04000EE6 RID: 3814
		public const float kEpsilon = 1E-05f;

		// Token: 0x04000EE7 RID: 3815
		public float x;

		// Token: 0x04000EE8 RID: 3816
		public float y;

		// Token: 0x04000EE9 RID: 3817
		public float z;

		// Token: 0x04000EEA RID: 3818
		public float w;
	}
}
