using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200007F RID: 127
	[UsedByNativeCode]
	public struct Matrix4x4
	{
		// Token: 0x06000918 RID: 2328 RVA: 0x0000BCD4 File Offset: 0x00009ED4
		[ThreadAndSerializationSafe]
		public static Matrix4x4 Inverse(Matrix4x4 m)
		{
			Matrix4x4 result;
			Matrix4x4.INTERNAL_CALL_Inverse(ref m, out result);
			return result;
		}

		// Token: 0x06000919 RID: 2329
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Inverse(ref Matrix4x4 m, out Matrix4x4 value);

		// Token: 0x0600091A RID: 2330 RVA: 0x0000BCF4 File Offset: 0x00009EF4
		public static Matrix4x4 Transpose(Matrix4x4 m)
		{
			Matrix4x4 result;
			Matrix4x4.INTERNAL_CALL_Transpose(ref m, out result);
			return result;
		}

		// Token: 0x0600091B RID: 2331
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Transpose(ref Matrix4x4 m, out Matrix4x4 value);

		// Token: 0x0600091C RID: 2332 RVA: 0x0000BD14 File Offset: 0x00009F14
		internal static bool Invert(Matrix4x4 inMatrix, out Matrix4x4 dest)
		{
			return Matrix4x4.INTERNAL_CALL_Invert(ref inMatrix, out dest);
		}

		// Token: 0x0600091D RID: 2333
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Invert(ref Matrix4x4 inMatrix, out Matrix4x4 dest);

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x0000BD34 File Offset: 0x00009F34
		public Matrix4x4 inverse
		{
			get
			{
				return Matrix4x4.Inverse(this);
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x0000BD54 File Offset: 0x00009F54
		public Matrix4x4 transpose
		{
			get
			{
				return Matrix4x4.Transpose(this);
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000920 RID: 2336
		public extern bool isIdentity { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000921 RID: 2337 RVA: 0x0000BD74 File Offset: 0x00009F74
		public static float Determinant(Matrix4x4 m)
		{
			return Matrix4x4.INTERNAL_CALL_Determinant(ref m);
		}

		// Token: 0x06000922 RID: 2338
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float INTERNAL_CALL_Determinant(ref Matrix4x4 m);

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x0000BD90 File Offset: 0x00009F90
		public float determinant
		{
			get
			{
				return Matrix4x4.Determinant(this);
			}
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x0000BDB0 File Offset: 0x00009FB0
		public void SetTRS(Vector3 pos, Quaternion q, Vector3 s)
		{
			this = Matrix4x4.TRS(pos, q, s);
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x0000BDC4 File Offset: 0x00009FC4
		public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s)
		{
			Matrix4x4 result;
			Matrix4x4.INTERNAL_CALL_TRS(ref pos, ref q, ref s, out result);
			return result;
		}

		// Token: 0x06000926 RID: 2342
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_TRS(ref Vector3 pos, ref Quaternion q, ref Vector3 s, out Matrix4x4 value);

		// Token: 0x06000927 RID: 2343 RVA: 0x0000BDE8 File Offset: 0x00009FE8
		public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar)
		{
			Matrix4x4 result;
			Matrix4x4.INTERNAL_CALL_Ortho(left, right, bottom, top, zNear, zFar, out result);
			return result;
		}

		// Token: 0x06000928 RID: 2344
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Ortho(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 value);

		// Token: 0x06000929 RID: 2345 RVA: 0x0000BE10 File Offset: 0x0000A010
		public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar)
		{
			Matrix4x4 result;
			Matrix4x4.INTERNAL_CALL_Perspective(fov, aspect, zNear, zFar, out result);
			return result;
		}

		// Token: 0x0600092A RID: 2346
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Perspective(float fov, float aspect, float zNear, float zFar, out Matrix4x4 value);

		// Token: 0x0600092B RID: 2347 RVA: 0x0000BE34 File Offset: 0x0000A034
		public static Matrix4x4 LookAt(Vector3 from, Vector3 to, Vector3 up)
		{
			Matrix4x4 result;
			Matrix4x4.INTERNAL_CALL_LookAt(ref from, ref to, ref up, out result);
			return result;
		}

		// Token: 0x0600092C RID: 2348
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_LookAt(ref Vector3 from, ref Vector3 to, ref Vector3 up, out Matrix4x4 value);

		// Token: 0x17000232 RID: 562
		public float this[int row, int column]
		{
			get
			{
				return this[row + column * 4];
			}
			set
			{
				this[row + column * 4] = value;
			}
		}

		// Token: 0x17000233 RID: 563
		public float this[int index]
		{
			get
			{
				float result;
				switch (index)
				{
				case 0:
					result = this.m00;
					break;
				case 1:
					result = this.m10;
					break;
				case 2:
					result = this.m20;
					break;
				case 3:
					result = this.m30;
					break;
				case 4:
					result = this.m01;
					break;
				case 5:
					result = this.m11;
					break;
				case 6:
					result = this.m21;
					break;
				case 7:
					result = this.m31;
					break;
				case 8:
					result = this.m02;
					break;
				case 9:
					result = this.m12;
					break;
				case 10:
					result = this.m22;
					break;
				case 11:
					result = this.m32;
					break;
				case 12:
					result = this.m03;
					break;
				case 13:
					result = this.m13;
					break;
				case 14:
					result = this.m23;
					break;
				case 15:
					result = this.m33;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid matrix index!");
				}
				return result;
			}
			set
			{
				switch (index)
				{
				case 0:
					this.m00 = value;
					break;
				case 1:
					this.m10 = value;
					break;
				case 2:
					this.m20 = value;
					break;
				case 3:
					this.m30 = value;
					break;
				case 4:
					this.m01 = value;
					break;
				case 5:
					this.m11 = value;
					break;
				case 6:
					this.m21 = value;
					break;
				case 7:
					this.m31 = value;
					break;
				case 8:
					this.m02 = value;
					break;
				case 9:
					this.m12 = value;
					break;
				case 10:
					this.m22 = value;
					break;
				case 11:
					this.m32 = value;
					break;
				case 12:
					this.m03 = value;
					break;
				case 13:
					this.m13 = value;
					break;
				case 14:
					this.m23 = value;
					break;
				case 15:
					this.m33 = value;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid matrix index!");
				}
			}
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x0000C0D4 File Offset: 0x0000A2D4
		public override int GetHashCode()
		{
			return this.GetColumn(0).GetHashCode() ^ this.GetColumn(1).GetHashCode() << 2 ^ this.GetColumn(2).GetHashCode() >> 2 ^ this.GetColumn(3).GetHashCode() >> 1;
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x0000C148 File Offset: 0x0000A348
		public override bool Equals(object other)
		{
			bool result;
			if (!(other is Matrix4x4))
			{
				result = false;
			}
			else
			{
				Matrix4x4 matrix4x = (Matrix4x4)other;
				result = (this.GetColumn(0).Equals(matrix4x.GetColumn(0)) && this.GetColumn(1).Equals(matrix4x.GetColumn(1)) && this.GetColumn(2).Equals(matrix4x.GetColumn(2)) && this.GetColumn(3).Equals(matrix4x.GetColumn(3)));
			}
			return result;
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0000C214 File Offset: 0x0000A414
		public static Matrix4x4 operator *(Matrix4x4 lhs, Matrix4x4 rhs)
		{
			return new Matrix4x4
			{
				m00 = lhs.m00 * rhs.m00 + lhs.m01 * rhs.m10 + lhs.m02 * rhs.m20 + lhs.m03 * rhs.m30,
				m01 = lhs.m00 * rhs.m01 + lhs.m01 * rhs.m11 + lhs.m02 * rhs.m21 + lhs.m03 * rhs.m31,
				m02 = lhs.m00 * rhs.m02 + lhs.m01 * rhs.m12 + lhs.m02 * rhs.m22 + lhs.m03 * rhs.m32,
				m03 = lhs.m00 * rhs.m03 + lhs.m01 * rhs.m13 + lhs.m02 * rhs.m23 + lhs.m03 * rhs.m33,
				m10 = lhs.m10 * rhs.m00 + lhs.m11 * rhs.m10 + lhs.m12 * rhs.m20 + lhs.m13 * rhs.m30,
				m11 = lhs.m10 * rhs.m01 + lhs.m11 * rhs.m11 + lhs.m12 * rhs.m21 + lhs.m13 * rhs.m31,
				m12 = lhs.m10 * rhs.m02 + lhs.m11 * rhs.m12 + lhs.m12 * rhs.m22 + lhs.m13 * rhs.m32,
				m13 = lhs.m10 * rhs.m03 + lhs.m11 * rhs.m13 + lhs.m12 * rhs.m23 + lhs.m13 * rhs.m33,
				m20 = lhs.m20 * rhs.m00 + lhs.m21 * rhs.m10 + lhs.m22 * rhs.m20 + lhs.m23 * rhs.m30,
				m21 = lhs.m20 * rhs.m01 + lhs.m21 * rhs.m11 + lhs.m22 * rhs.m21 + lhs.m23 * rhs.m31,
				m22 = lhs.m20 * rhs.m02 + lhs.m21 * rhs.m12 + lhs.m22 * rhs.m22 + lhs.m23 * rhs.m32,
				m23 = lhs.m20 * rhs.m03 + lhs.m21 * rhs.m13 + lhs.m22 * rhs.m23 + lhs.m23 * rhs.m33,
				m30 = lhs.m30 * rhs.m00 + lhs.m31 * rhs.m10 + lhs.m32 * rhs.m20 + lhs.m33 * rhs.m30,
				m31 = lhs.m30 * rhs.m01 + lhs.m31 * rhs.m11 + lhs.m32 * rhs.m21 + lhs.m33 * rhs.m31,
				m32 = lhs.m30 * rhs.m02 + lhs.m31 * rhs.m12 + lhs.m32 * rhs.m22 + lhs.m33 * rhs.m32,
				m33 = lhs.m30 * rhs.m03 + lhs.m31 * rhs.m13 + lhs.m32 * rhs.m23 + lhs.m33 * rhs.m33
			};
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0000C694 File Offset: 0x0000A894
		public static Vector4 operator *(Matrix4x4 lhs, Vector4 v)
		{
			Vector4 result;
			result.x = lhs.m00 * v.x + lhs.m01 * v.y + lhs.m02 * v.z + lhs.m03 * v.w;
			result.y = lhs.m10 * v.x + lhs.m11 * v.y + lhs.m12 * v.z + lhs.m13 * v.w;
			result.z = lhs.m20 * v.x + lhs.m21 * v.y + lhs.m22 * v.z + lhs.m23 * v.w;
			result.w = lhs.m30 * v.x + lhs.m31 * v.y + lhs.m32 * v.z + lhs.m33 * v.w;
			return result;
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x0000C7C4 File Offset: 0x0000A9C4
		public static bool operator ==(Matrix4x4 lhs, Matrix4x4 rhs)
		{
			return lhs.GetColumn(0) == rhs.GetColumn(0) && lhs.GetColumn(1) == rhs.GetColumn(1) && lhs.GetColumn(2) == rhs.GetColumn(2) && lhs.GetColumn(3) == rhs.GetColumn(3);
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0000C840 File Offset: 0x0000AA40
		public static bool operator !=(Matrix4x4 lhs, Matrix4x4 rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0000C860 File Offset: 0x0000AA60
		public Vector4 GetColumn(int i)
		{
			return new Vector4(this[0, i], this[1, i], this[2, i], this[3, i]);
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0000C89C File Offset: 0x0000AA9C
		public Vector4 GetRow(int i)
		{
			return new Vector4(this[i, 0], this[i, 1], this[i, 2], this[i, 3]);
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0000C8D8 File Offset: 0x0000AAD8
		public void SetColumn(int i, Vector4 v)
		{
			this[0, i] = v.x;
			this[1, i] = v.y;
			this[2, i] = v.z;
			this[3, i] = v.w;
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x0000C918 File Offset: 0x0000AB18
		public void SetRow(int i, Vector4 v)
		{
			this[i, 0] = v.x;
			this[i, 1] = v.y;
			this[i, 2] = v.z;
			this[i, 3] = v.w;
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x0000C958 File Offset: 0x0000AB58
		public Vector3 MultiplyPoint(Vector3 v)
		{
			Vector3 result;
			result.x = this.m00 * v.x + this.m01 * v.y + this.m02 * v.z + this.m03;
			result.y = this.m10 * v.x + this.m11 * v.y + this.m12 * v.z + this.m13;
			result.z = this.m20 * v.x + this.m21 * v.y + this.m22 * v.z + this.m23;
			float num = this.m30 * v.x + this.m31 * v.y + this.m32 * v.z + this.m33;
			num = 1f / num;
			result.x *= num;
			result.y *= num;
			result.z *= num;
			return result;
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0000CA88 File Offset: 0x0000AC88
		public Vector3 MultiplyPoint3x4(Vector3 v)
		{
			Vector3 result;
			result.x = this.m00 * v.x + this.m01 * v.y + this.m02 * v.z + this.m03;
			result.y = this.m10 * v.x + this.m11 * v.y + this.m12 * v.z + this.m13;
			result.z = this.m20 * v.x + this.m21 * v.y + this.m22 * v.z + this.m23;
			return result;
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x0000CB4C File Offset: 0x0000AD4C
		public Vector3 MultiplyVector(Vector3 v)
		{
			Vector3 result;
			result.x = this.m00 * v.x + this.m01 * v.y + this.m02 * v.z;
			result.y = this.m10 * v.x + this.m11 * v.y + this.m12 * v.z;
			result.z = this.m20 * v.x + this.m21 * v.y + this.m22 * v.z;
			return result;
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0000CBFC File Offset: 0x0000ADFC
		public static Matrix4x4 Scale(Vector3 v)
		{
			return new Matrix4x4
			{
				m00 = v.x,
				m01 = 0f,
				m02 = 0f,
				m03 = 0f,
				m10 = 0f,
				m11 = v.y,
				m12 = 0f,
				m13 = 0f,
				m20 = 0f,
				m21 = 0f,
				m22 = v.z,
				m23 = 0f,
				m30 = 0f,
				m31 = 0f,
				m32 = 0f,
				m33 = 1f
			};
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0000CCE0 File Offset: 0x0000AEE0
		public static Matrix4x4 Translate(Vector3 v)
		{
			return new Matrix4x4
			{
				m00 = 1f,
				m01 = 0f,
				m02 = 0f,
				m03 = v.x,
				m10 = 0f,
				m11 = 1f,
				m12 = 0f,
				m13 = v.y,
				m20 = 0f,
				m21 = 0f,
				m22 = 1f,
				m23 = v.z,
				m30 = 0f,
				m31 = 0f,
				m32 = 0f,
				m33 = 1f
			};
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x0000CDC4 File Offset: 0x0000AFC4
		public static Matrix4x4 zero
		{
			get
			{
				return new Matrix4x4
				{
					m00 = 0f,
					m01 = 0f,
					m02 = 0f,
					m03 = 0f,
					m10 = 0f,
					m11 = 0f,
					m12 = 0f,
					m13 = 0f,
					m20 = 0f,
					m21 = 0f,
					m22 = 0f,
					m23 = 0f,
					m30 = 0f,
					m31 = 0f,
					m32 = 0f,
					m33 = 0f
				};
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x0000CEA4 File Offset: 0x0000B0A4
		public static Matrix4x4 identity
		{
			get
			{
				return new Matrix4x4
				{
					m00 = 1f,
					m01 = 0f,
					m02 = 0f,
					m03 = 0f,
					m10 = 0f,
					m11 = 1f,
					m12 = 0f,
					m13 = 0f,
					m20 = 0f,
					m21 = 0f,
					m22 = 1f,
					m23 = 0f,
					m30 = 0f,
					m31 = 0f,
					m32 = 0f,
					m33 = 1f
				};
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0000CF84 File Offset: 0x0000B184
		public override string ToString()
		{
			return UnityString.Format("{0:F5}\t{1:F5}\t{2:F5}\t{3:F5}\n{4:F5}\t{5:F5}\t{6:F5}\t{7:F5}\n{8:F5}\t{9:F5}\t{10:F5}\t{11:F5}\n{12:F5}\t{13:F5}\t{14:F5}\t{15:F5}\n", new object[]
			{
				this.m00,
				this.m01,
				this.m02,
				this.m03,
				this.m10,
				this.m11,
				this.m12,
				this.m13,
				this.m20,
				this.m21,
				this.m22,
				this.m23,
				this.m30,
				this.m31,
				this.m32,
				this.m33
			});
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0000D094 File Offset: 0x0000B294
		public string ToString(string format)
		{
			return UnityString.Format("{0}\t{1}\t{2}\t{3}\n{4}\t{5}\t{6}\t{7}\n{8}\t{9}\t{10}\t{11}\n{12}\t{13}\t{14}\t{15}\n", new object[]
			{
				this.m00.ToString(format),
				this.m01.ToString(format),
				this.m02.ToString(format),
				this.m03.ToString(format),
				this.m10.ToString(format),
				this.m11.ToString(format),
				this.m12.ToString(format),
				this.m13.ToString(format),
				this.m20.ToString(format),
				this.m21.ToString(format),
				this.m22.ToString(format),
				this.m23.ToString(format),
				this.m30.ToString(format),
				this.m31.ToString(format),
				this.m32.ToString(format),
				this.m33.ToString(format)
			});
		}

		// Token: 0x040000D8 RID: 216
		public float m00;

		// Token: 0x040000D9 RID: 217
		public float m10;

		// Token: 0x040000DA RID: 218
		public float m20;

		// Token: 0x040000DB RID: 219
		public float m30;

		// Token: 0x040000DC RID: 220
		public float m01;

		// Token: 0x040000DD RID: 221
		public float m11;

		// Token: 0x040000DE RID: 222
		public float m21;

		// Token: 0x040000DF RID: 223
		public float m31;

		// Token: 0x040000E0 RID: 224
		public float m02;

		// Token: 0x040000E1 RID: 225
		public float m12;

		// Token: 0x040000E2 RID: 226
		public float m22;

		// Token: 0x040000E3 RID: 227
		public float m32;

		// Token: 0x040000E4 RID: 228
		public float m03;

		// Token: 0x040000E5 RID: 229
		public float m13;

		// Token: 0x040000E6 RID: 230
		public float m23;

		// Token: 0x040000E7 RID: 231
		public float m33;
	}
}
