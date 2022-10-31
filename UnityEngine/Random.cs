using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000A2 RID: 162
	public sealed class Random
	{
		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000B76 RID: 2934
		// (set) Token: 0x06000B77 RID: 2935
		[Obsolete("Deprecated. Use InitState() function or Random.state property instead.")]
		public static extern int seed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000B78 RID: 2936
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void InitState(int seed);

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x0000FE5C File Offset: 0x0000E05C
		// (set) Token: 0x06000B7A RID: 2938 RVA: 0x0000FE7C File Offset: 0x0000E07C
		public static Random.State state
		{
			get
			{
				Random.State result;
				Random.INTERNAL_get_state(out result);
				return result;
			}
			set
			{
				Random.INTERNAL_set_state(ref value);
			}
		}

		// Token: 0x06000B7B RID: 2939
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_state(out Random.State value);

		// Token: 0x06000B7C RID: 2940
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_state(ref Random.State value);

		// Token: 0x06000B7D RID: 2941
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Range(float min, float max);

		// Token: 0x06000B7E RID: 2942 RVA: 0x0000FE88 File Offset: 0x0000E088
		public static int Range(int min, int max)
		{
			return Random.RandomRangeInt(min, max);
		}

		// Token: 0x06000B7F RID: 2943
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int RandomRangeInt(int min, int max);

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000B80 RID: 2944
		public static extern float value { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x0000FEA4 File Offset: 0x0000E0A4
		public static Vector3 insideUnitSphere
		{
			get
			{
				Vector3 result;
				Random.INTERNAL_get_insideUnitSphere(out result);
				return result;
			}
		}

		// Token: 0x06000B82 RID: 2946
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_insideUnitSphere(out Vector3 value);

		// Token: 0x06000B83 RID: 2947
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetRandomUnitCircle(out Vector2 output);

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000B84 RID: 2948 RVA: 0x0000FEC4 File Offset: 0x0000E0C4
		public static Vector2 insideUnitCircle
		{
			get
			{
				Vector2 result;
				Random.GetRandomUnitCircle(out result);
				return result;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x0000FEE4 File Offset: 0x0000E0E4
		public static Vector3 onUnitSphere
		{
			get
			{
				Vector3 result;
				Random.INTERNAL_get_onUnitSphere(out result);
				return result;
			}
		}

		// Token: 0x06000B86 RID: 2950
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_onUnitSphere(out Vector3 value);

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x0000FF04 File Offset: 0x0000E104
		public static Quaternion rotation
		{
			get
			{
				Quaternion result;
				Random.INTERNAL_get_rotation(out result);
				return result;
			}
		}

		// Token: 0x06000B88 RID: 2952
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_rotation(out Quaternion value);

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x0000FF24 File Offset: 0x0000E124
		public static Quaternion rotationUniform
		{
			get
			{
				Quaternion result;
				Random.INTERNAL_get_rotationUniform(out result);
				return result;
			}
		}

		// Token: 0x06000B8A RID: 2954
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_rotationUniform(out Quaternion value);

		// Token: 0x06000B8B RID: 2955 RVA: 0x0000FF44 File Offset: 0x0000E144
		[Obsolete("Use Random.Range instead")]
		public static float RandomRange(float min, float max)
		{
			return Random.Range(min, max);
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0000FF60 File Offset: 0x0000E160
		[Obsolete("Use Random.Range instead")]
		public static int RandomRange(int min, int max)
		{
			return Random.Range(min, max);
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0000FF7C File Offset: 0x0000E17C
		public static Color ColorHSV()
		{
			return Random.ColorHSV(0f, 1f, 0f, 1f, 0f, 1f, 1f, 1f);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0000FFC0 File Offset: 0x0000E1C0
		public static Color ColorHSV(float hueMin, float hueMax)
		{
			return Random.ColorHSV(hueMin, hueMax, 0f, 1f, 0f, 1f, 1f, 1f);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0000FFFC File Offset: 0x0000E1FC
		public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax)
		{
			return Random.ColorHSV(hueMin, hueMax, saturationMin, saturationMax, 0f, 1f, 1f, 1f);
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00010030 File Offset: 0x0000E230
		public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax)
		{
			return Random.ColorHSV(hueMin, hueMax, saturationMin, saturationMax, valueMin, valueMax, 1f, 1f);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0001005C File Offset: 0x0000E25C
		public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax)
		{
			float h = Mathf.Lerp(hueMin, hueMax, Random.value);
			float s = Mathf.Lerp(saturationMin, saturationMax, Random.value);
			float v = Mathf.Lerp(valueMin, valueMax, Random.value);
			Color result = Color.HSVToRGB(h, s, v, true);
			result.a = Mathf.Lerp(alphaMin, alphaMax, Random.value);
			return result;
		}

		// Token: 0x020000A3 RID: 163
		[Serializable]
		public struct State
		{
			// Token: 0x04000153 RID: 339
			[SerializeField]
			private int s0;

			// Token: 0x04000154 RID: 340
			[SerializeField]
			private int s1;

			// Token: 0x04000155 RID: 341
			[SerializeField]
			private int s2;

			// Token: 0x04000156 RID: 342
			[SerializeField]
			private int s3;
		}
	}
}
