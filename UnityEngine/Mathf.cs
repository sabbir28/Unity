using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x02000081 RID: 129
	public struct Mathf
	{
		// Token: 0x06000968 RID: 2408
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int ClosestPowerOfTwo(int value);

		// Token: 0x06000969 RID: 2409
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GammaToLinearSpace(float value);

		// Token: 0x0600096A RID: 2410
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float LinearToGammaSpace(float value);

		// Token: 0x0600096B RID: 2411 RVA: 0x0000D758 File Offset: 0x0000B958
		public static Color CorrelatedColorTemperatureToRGB(float kelvin)
		{
			Color result;
			Mathf.INTERNAL_CALL_CorrelatedColorTemperatureToRGB(kelvin, out result);
			return result;
		}

		// Token: 0x0600096C RID: 2412
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_CorrelatedColorTemperatureToRGB(float kelvin, out Color value);

		// Token: 0x0600096D RID: 2413
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsPowerOfTwo(int value);

		// Token: 0x0600096E RID: 2414
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int NextPowerOfTwo(int value);

		// Token: 0x0600096F RID: 2415
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float PerlinNoise(float x, float y);

		// Token: 0x06000970 RID: 2416
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern ushort FloatToHalf(float val);

		// Token: 0x06000971 RID: 2417
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float HalfToFloat(ushort val);

		// Token: 0x06000972 RID: 2418 RVA: 0x0000D778 File Offset: 0x0000B978
		public static float Sin(float f)
		{
			return (float)Math.Sin((double)f);
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x0000D798 File Offset: 0x0000B998
		public static float Cos(float f)
		{
			return (float)Math.Cos((double)f);
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x0000D7B8 File Offset: 0x0000B9B8
		public static float Tan(float f)
		{
			return (float)Math.Tan((double)f);
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0000D7D8 File Offset: 0x0000B9D8
		public static float Asin(float f)
		{
			return (float)Math.Asin((double)f);
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0000D7F8 File Offset: 0x0000B9F8
		public static float Acos(float f)
		{
			return (float)Math.Acos((double)f);
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0000D818 File Offset: 0x0000BA18
		public static float Atan(float f)
		{
			return (float)Math.Atan((double)f);
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x0000D838 File Offset: 0x0000BA38
		public static float Atan2(float y, float x)
		{
			return (float)Math.Atan2((double)y, (double)x);
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0000D858 File Offset: 0x0000BA58
		public static float Sqrt(float f)
		{
			return (float)Math.Sqrt((double)f);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0000D878 File Offset: 0x0000BA78
		public static float Abs(float f)
		{
			return Math.Abs(f);
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0000D894 File Offset: 0x0000BA94
		public static int Abs(int value)
		{
			return Math.Abs(value);
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0000D8B0 File Offset: 0x0000BAB0
		public static float Min(float a, float b)
		{
			return (a >= b) ? b : a;
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0000D8D4 File Offset: 0x0000BAD4
		public static float Min(params float[] values)
		{
			int num = values.Length;
			float result;
			if (num == 0)
			{
				result = 0f;
			}
			else
			{
				float num2 = values[0];
				for (int i = 1; i < num; i++)
				{
					if (values[i] < num2)
					{
						num2 = values[i];
					}
				}
				result = num2;
			}
			return result;
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0000D924 File Offset: 0x0000BB24
		public static int Min(int a, int b)
		{
			return (a >= b) ? b : a;
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0000D948 File Offset: 0x0000BB48
		public static int Min(params int[] values)
		{
			int num = values.Length;
			int result;
			if (num == 0)
			{
				result = 0;
			}
			else
			{
				int num2 = values[0];
				for (int i = 1; i < num; i++)
				{
					if (values[i] < num2)
					{
						num2 = values[i];
					}
				}
				result = num2;
			}
			return result;
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0000D994 File Offset: 0x0000BB94
		public static float Max(float a, float b)
		{
			return (a <= b) ? b : a;
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0000D9B8 File Offset: 0x0000BBB8
		public static float Max(params float[] values)
		{
			int num = values.Length;
			float result;
			if (num == 0)
			{
				result = 0f;
			}
			else
			{
				float num2 = values[0];
				for (int i = 1; i < num; i++)
				{
					if (values[i] > num2)
					{
						num2 = values[i];
					}
				}
				result = num2;
			}
			return result;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0000DA08 File Offset: 0x0000BC08
		public static int Max(int a, int b)
		{
			return (a <= b) ? b : a;
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0000DA2C File Offset: 0x0000BC2C
		public static int Max(params int[] values)
		{
			int num = values.Length;
			int result;
			if (num == 0)
			{
				result = 0;
			}
			else
			{
				int num2 = values[0];
				for (int i = 1; i < num; i++)
				{
					if (values[i] > num2)
					{
						num2 = values[i];
					}
				}
				result = num2;
			}
			return result;
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0000DA78 File Offset: 0x0000BC78
		public static float Pow(float f, float p)
		{
			return (float)Math.Pow((double)f, (double)p);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0000DA98 File Offset: 0x0000BC98
		public static float Exp(float power)
		{
			return (float)Math.Exp((double)power);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0000DAB8 File Offset: 0x0000BCB8
		public static float Log(float f, float p)
		{
			return (float)Math.Log((double)f, (double)p);
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0000DAD8 File Offset: 0x0000BCD8
		public static float Log(float f)
		{
			return (float)Math.Log((double)f);
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x0000DAF8 File Offset: 0x0000BCF8
		public static float Log10(float f)
		{
			return (float)Math.Log10((double)f);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x0000DB18 File Offset: 0x0000BD18
		public static float Ceil(float f)
		{
			return (float)Math.Ceiling((double)f);
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0000DB38 File Offset: 0x0000BD38
		public static float Floor(float f)
		{
			return (float)Math.Floor((double)f);
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0000DB58 File Offset: 0x0000BD58
		public static float Round(float f)
		{
			return (float)Math.Round((double)f);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x0000DB78 File Offset: 0x0000BD78
		public static int CeilToInt(float f)
		{
			return (int)Math.Ceiling((double)f);
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0000DB98 File Offset: 0x0000BD98
		public static int FloorToInt(float f)
		{
			return (int)Math.Floor((double)f);
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x0000DBB8 File Offset: 0x0000BDB8
		public static int RoundToInt(float f)
		{
			return (int)Math.Round((double)f);
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x0000DBD8 File Offset: 0x0000BDD8
		public static float Sign(float f)
		{
			return (f < 0f) ? -1f : 1f;
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0000DC08 File Offset: 0x0000BE08
		public static float Clamp(float value, float min, float max)
		{
			if (value < min)
			{
				value = min;
			}
			else if (value > max)
			{
				value = max;
			}
			return value;
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0000DC38 File Offset: 0x0000BE38
		public static int Clamp(int value, int min, int max)
		{
			if (value < min)
			{
				value = min;
			}
			else if (value > max)
			{
				value = max;
			}
			return value;
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0000DC68 File Offset: 0x0000BE68
		public static float Clamp01(float value)
		{
			float result;
			if (value < 0f)
			{
				result = 0f;
			}
			else if (value > 1f)
			{
				result = 1f;
			}
			else
			{
				result = value;
			}
			return result;
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x0000DCAC File Offset: 0x0000BEAC
		public static float Lerp(float a, float b, float t)
		{
			return a + (b - a) * Mathf.Clamp01(t);
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0000DCD0 File Offset: 0x0000BED0
		public static float LerpUnclamped(float a, float b, float t)
		{
			return a + (b - a) * t;
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0000DCEC File Offset: 0x0000BEEC
		public static float LerpAngle(float a, float b, float t)
		{
			float num = Mathf.Repeat(b - a, 360f);
			if (num > 180f)
			{
				num -= 360f;
			}
			return a + num * Mathf.Clamp01(t);
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0000DD2C File Offset: 0x0000BF2C
		public static float MoveTowards(float current, float target, float maxDelta)
		{
			float result;
			if (Mathf.Abs(target - current) <= maxDelta)
			{
				result = target;
			}
			else
			{
				result = current + Mathf.Sign(target - current) * maxDelta;
			}
			return result;
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x0000DD64 File Offset: 0x0000BF64
		public static float MoveTowardsAngle(float current, float target, float maxDelta)
		{
			float num = Mathf.DeltaAngle(current, target);
			float result;
			if (-maxDelta < num && num < maxDelta)
			{
				result = target;
			}
			else
			{
				target = current + num;
				result = Mathf.MoveTowards(current, target, maxDelta);
			}
			return result;
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0000DDA4 File Offset: 0x0000BFA4
		public static float SmoothStep(float from, float to, float t)
		{
			t = Mathf.Clamp01(t);
			t = -2f * t * t * t + 3f * t * t;
			return to * t + from * (1f - t);
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
		public static float Gamma(float value, float absmax, float gamma)
		{
			bool flag = false;
			if (value < 0f)
			{
				flag = true;
			}
			float num = Mathf.Abs(value);
			float result;
			if (num > absmax)
			{
				result = ((!flag) ? num : (-num));
			}
			else
			{
				float num2 = Mathf.Pow(num / absmax, gamma) * absmax;
				result = ((!flag) ? num2 : (-num2));
			}
			return result;
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0000DE48 File Offset: 0x0000C048
		public static bool Approximately(float a, float b)
		{
			return Mathf.Abs(b - a) < Mathf.Max(1E-06f * Mathf.Max(Mathf.Abs(a), Mathf.Abs(b)), Mathf.Epsilon * 8f);
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0000DE90 File Offset: 0x0000C090
		[ExcludeFromDocs]
		public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed)
		{
			float deltaTime = Time.deltaTime;
			return Mathf.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0000DEB8 File Offset: 0x0000C0B8
		[ExcludeFromDocs]
		public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime)
		{
			float deltaTime = Time.deltaTime;
			float positiveInfinity = float.PositiveInfinity;
			return Mathf.SmoothDamp(current, target, ref currentVelocity, smoothTime, positiveInfinity, deltaTime);
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0000DEE4 File Offset: 0x0000C0E4
		public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, [DefaultValue("Mathf.Infinity")] float maxSpeed, [DefaultValue("Time.deltaTime")] float deltaTime)
		{
			smoothTime = Mathf.Max(0.0001f, smoothTime);
			float num = 2f / smoothTime;
			float num2 = num * deltaTime;
			float num3 = 1f / (1f + num2 + 0.48f * num2 * num2 + 0.235f * num2 * num2 * num2);
			float num4 = current - target;
			float num5 = target;
			float num6 = maxSpeed * smoothTime;
			num4 = Mathf.Clamp(num4, -num6, num6);
			target = current - num4;
			float num7 = (currentVelocity + num * num4) * deltaTime;
			currentVelocity = (currentVelocity - num * num7) * num3;
			float num8 = target + (num4 + num7) * num3;
			if (num5 - current > 0f == num8 > num5)
			{
				num8 = num5;
				currentVelocity = (num8 - num5) / deltaTime;
			}
			return num8;
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0000DFA0 File Offset: 0x0000C1A0
		[ExcludeFromDocs]
		public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed)
		{
			float deltaTime = Time.deltaTime;
			return Mathf.SmoothDampAngle(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0000DFC8 File Offset: 0x0000C1C8
		[ExcludeFromDocs]
		public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime)
		{
			float deltaTime = Time.deltaTime;
			float positiveInfinity = float.PositiveInfinity;
			return Mathf.SmoothDampAngle(current, target, ref currentVelocity, smoothTime, positiveInfinity, deltaTime);
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0000DFF4 File Offset: 0x0000C1F4
		public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, [DefaultValue("Mathf.Infinity")] float maxSpeed, [DefaultValue("Time.deltaTime")] float deltaTime)
		{
			target = current + Mathf.DeltaAngle(current, target);
			return Mathf.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0000E024 File Offset: 0x0000C224
		public static float Repeat(float t, float length)
		{
			return t - Mathf.Floor(t / length) * length;
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x0000E048 File Offset: 0x0000C248
		public static float PingPong(float t, float length)
		{
			t = Mathf.Repeat(t, length * 2f);
			return length - Mathf.Abs(t - length);
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x0000E078 File Offset: 0x0000C278
		public static float InverseLerp(float a, float b, float value)
		{
			float result;
			if (a != b)
			{
				result = Mathf.Clamp01((value - a) / (b - a));
			}
			else
			{
				result = 0f;
			}
			return result;
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0000E0AC File Offset: 0x0000C2AC
		public static float DeltaAngle(float current, float target)
		{
			float num = Mathf.Repeat(target - current, 360f);
			if (num > 180f)
			{
				num -= 360f;
			}
			return num;
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0000E0E4 File Offset: 0x0000C2E4
		internal static bool LineIntersection(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, ref Vector2 result)
		{
			float num = p2.x - p1.x;
			float num2 = p2.y - p1.y;
			float num3 = p4.x - p3.x;
			float num4 = p4.y - p3.y;
			float num5 = num * num4 - num2 * num3;
			bool result2;
			if (num5 == 0f)
			{
				result2 = false;
			}
			else
			{
				float num6 = p3.x - p1.x;
				float num7 = p3.y - p1.y;
				float num8 = (num6 * num4 - num7 * num3) / num5;
				result = new Vector2(p1.x + num8 * num, p1.y + num8 * num2);
				result2 = true;
			}
			return result2;
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0000E1AC File Offset: 0x0000C3AC
		internal static bool LineSegmentIntersection(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, ref Vector2 result)
		{
			float num = p2.x - p1.x;
			float num2 = p2.y - p1.y;
			float num3 = p4.x - p3.x;
			float num4 = p4.y - p3.y;
			float num5 = num * num4 - num2 * num3;
			bool result2;
			if (num5 == 0f)
			{
				result2 = false;
			}
			else
			{
				float num6 = p3.x - p1.x;
				float num7 = p3.y - p1.y;
				float num8 = (num6 * num4 - num7 * num3) / num5;
				if (num8 < 0f || num8 > 1f)
				{
					result2 = false;
				}
				else
				{
					float num9 = (num6 * num2 - num7 * num) / num5;
					if (num9 < 0f || num9 > 1f)
					{
						result2 = false;
					}
					else
					{
						result = new Vector2(p1.x + num8 * num, p1.y + num8 * num2);
						result2 = true;
					}
				}
			}
			return result2;
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0000E2C4 File Offset: 0x0000C4C4
		internal static long RandomToLong(Random r)
		{
			byte[] array = new byte[8];
			r.NextBytes(array);
			return (long)(BitConverter.ToUInt64(array, 0) & 9223372036854775807UL);
		}

		// Token: 0x040000EA RID: 234
		public const float PI = 3.1415927f;

		// Token: 0x040000EB RID: 235
		public const float Infinity = float.PositiveInfinity;

		// Token: 0x040000EC RID: 236
		public const float NegativeInfinity = float.NegativeInfinity;

		// Token: 0x040000ED RID: 237
		public const float Deg2Rad = 0.017453292f;

		// Token: 0x040000EE RID: 238
		public const float Rad2Deg = 57.29578f;

		// Token: 0x040000EF RID: 239
		public static readonly float Epsilon = (!MathfInternal.IsFlushToZeroEnabled) ? MathfInternal.FloatMinDenormal : MathfInternal.FloatMinNormal;
	}
}
