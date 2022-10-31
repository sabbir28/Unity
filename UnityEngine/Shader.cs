using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000AC RID: 172
	public sealed class Shader : Object
	{
		// Token: 0x06000C8F RID: 3215
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Shader Find(string name);

		// Token: 0x06000C90 RID: 3216
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Shader FindBuiltin(string name);

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000C91 RID: 3217
		public extern bool isSupported { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000C92 RID: 3218
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnableKeyword(string keyword);

		// Token: 0x06000C93 RID: 3219
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DisableKeyword(string keyword);

		// Token: 0x06000C94 RID: 3220
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsKeywordEnabled(string keyword);

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000C95 RID: 3221
		// (set) Token: 0x06000C96 RID: 3222
		public extern int maximumLOD { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000C97 RID: 3223
		// (set) Token: 0x06000C98 RID: 3224
		public static extern int globalMaximumLOD { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000C99 RID: 3225
		// (set) Token: 0x06000C9A RID: 3226
		public static extern string globalRenderPipeline { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000C9B RID: 3227
		public extern int renderQueue { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000C9C RID: 3228
		internal extern DisableBatchingType disableBatching { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000C9D RID: 3229
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetGlobalFloatImpl(int nameID, float value);

		// Token: 0x06000C9E RID: 3230
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetGlobalIntImpl(int nameID, int value);

		// Token: 0x06000C9F RID: 3231 RVA: 0x00010F48 File Offset: 0x0000F148
		private static void SetGlobalVectorImpl(int nameID, Vector4 value)
		{
			Shader.INTERNAL_CALL_SetGlobalVectorImpl(nameID, ref value);
		}

		// Token: 0x06000CA0 RID: 3232
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetGlobalVectorImpl(int nameID, ref Vector4 value);

		// Token: 0x06000CA1 RID: 3233 RVA: 0x00010F54 File Offset: 0x0000F154
		private static void SetGlobalColorImpl(int nameID, Color value)
		{
			Shader.INTERNAL_CALL_SetGlobalColorImpl(nameID, ref value);
		}

		// Token: 0x06000CA2 RID: 3234
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetGlobalColorImpl(int nameID, ref Color value);

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00010F60 File Offset: 0x0000F160
		private static void SetGlobalMatrixImpl(int nameID, Matrix4x4 value)
		{
			Shader.INTERNAL_CALL_SetGlobalMatrixImpl(nameID, ref value);
		}

		// Token: 0x06000CA4 RID: 3236
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetGlobalMatrixImpl(int nameID, ref Matrix4x4 value);

		// Token: 0x06000CA5 RID: 3237
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetGlobalTextureImpl(int nameID, Texture value);

		// Token: 0x06000CA6 RID: 3238
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Array ExtractArrayFromList(object list);

		// Token: 0x06000CA7 RID: 3239
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetGlobalFloatArrayImpl(int nameID, float[] values);

		// Token: 0x06000CA8 RID: 3240
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetGlobalVectorArrayImpl(int nameID, Vector4[] values);

		// Token: 0x06000CA9 RID: 3241
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetGlobalMatrixArrayImpl(int nameID, Matrix4x4[] values);

		// Token: 0x06000CAA RID: 3242
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGlobalBuffer(int nameID, ComputeBuffer buffer);

		// Token: 0x06000CAB RID: 3243
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float GetGlobalFloatImpl(int nameID);

		// Token: 0x06000CAC RID: 3244
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetGlobalIntImpl(int nameID);

		// Token: 0x06000CAD RID: 3245 RVA: 0x00010F6C File Offset: 0x0000F16C
		private static Vector4 GetGlobalVectorImpl(int nameID)
		{
			Vector4 result;
			Shader.INTERNAL_CALL_GetGlobalVectorImpl(nameID, out result);
			return result;
		}

		// Token: 0x06000CAE RID: 3246
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetGlobalVectorImpl(int nameID, out Vector4 value);

		// Token: 0x06000CAF RID: 3247 RVA: 0x00010F8C File Offset: 0x0000F18C
		private static Color GetGlobalColorImpl(int nameID)
		{
			Color result;
			Shader.INTERNAL_CALL_GetGlobalColorImpl(nameID, out result);
			return result;
		}

		// Token: 0x06000CB0 RID: 3248
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetGlobalColorImpl(int nameID, out Color value);

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00010FAC File Offset: 0x0000F1AC
		private static Matrix4x4 GetGlobalMatrixImpl(int nameID)
		{
			Matrix4x4 result;
			Shader.INTERNAL_CALL_GetGlobalMatrixImpl(nameID, out result);
			return result;
		}

		// Token: 0x06000CB2 RID: 3250
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetGlobalMatrixImpl(int nameID, out Matrix4x4 value);

		// Token: 0x06000CB3 RID: 3251
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Texture GetGlobalTextureImpl(int nameID);

		// Token: 0x06000CB4 RID: 3252
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float[] GetGlobalFloatArrayImpl(int nameID);

		// Token: 0x06000CB5 RID: 3253
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector4[] GetGlobalVectorArrayImpl(int nameID);

		// Token: 0x06000CB6 RID: 3254
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Matrix4x4[] GetGlobalMatrixArrayImpl(int nameID);

		// Token: 0x06000CB7 RID: 3255
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetGlobalFloatArrayImplList(int nameID, object list);

		// Token: 0x06000CB8 RID: 3256
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetGlobalVectorArrayImplList(int nameID, object list);

		// Token: 0x06000CB9 RID: 3257
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetGlobalMatrixArrayImplList(int nameID, object list);

		// Token: 0x06000CBA RID: 3258
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int PropertyToID(string name);

		// Token: 0x06000CBB RID: 3259
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void WarmupAllShaders();

		// Token: 0x06000CBC RID: 3260 RVA: 0x00010FCC File Offset: 0x0000F1CC
		public static void SetGlobalFloat(string name, float value)
		{
			Shader.SetGlobalFloat(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00010FDC File Offset: 0x0000F1DC
		public static void SetGlobalFloat(int nameID, float value)
		{
			Shader.SetGlobalFloatImpl(nameID, value);
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x00010FE8 File Offset: 0x0000F1E8
		public static void SetGlobalInt(string name, int value)
		{
			Shader.SetGlobalInt(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x00010FF8 File Offset: 0x0000F1F8
		public static void SetGlobalInt(int nameID, int value)
		{
			Shader.SetGlobalIntImpl(nameID, value);
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x00011004 File Offset: 0x0000F204
		public static void SetGlobalVector(string name, Vector4 value)
		{
			Shader.SetGlobalVector(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x00011014 File Offset: 0x0000F214
		public static void SetGlobalVector(int nameID, Vector4 value)
		{
			Shader.SetGlobalVectorImpl(nameID, value);
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00011020 File Offset: 0x0000F220
		public static void SetGlobalColor(string name, Color value)
		{
			Shader.SetGlobalColor(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00011030 File Offset: 0x0000F230
		public static void SetGlobalColor(int nameID, Color value)
		{
			Shader.SetGlobalColorImpl(nameID, value);
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x0001103C File Offset: 0x0000F23C
		public static void SetGlobalMatrix(string name, Matrix4x4 value)
		{
			Shader.SetGlobalMatrix(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x0001104C File Offset: 0x0000F24C
		public static void SetGlobalMatrix(int nameID, Matrix4x4 value)
		{
			Shader.SetGlobalMatrixImpl(nameID, value);
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00011058 File Offset: 0x0000F258
		public static void SetGlobalTexture(string name, Texture value)
		{
			Shader.SetGlobalTexture(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00011068 File Offset: 0x0000F268
		public static void SetGlobalTexture(int nameID, Texture value)
		{
			Shader.SetGlobalTextureImpl(nameID, value);
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00011074 File Offset: 0x0000F274
		public static void SetGlobalBuffer(string name, ComputeBuffer buffer)
		{
			Shader.SetGlobalBuffer(Shader.PropertyToID(name), buffer);
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00011084 File Offset: 0x0000F284
		public static void SetGlobalFloatArray(string name, List<float> values)
		{
			Shader.SetGlobalFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x00011094 File Offset: 0x0000F294
		public static void SetGlobalFloatArray(int nameID, List<float> values)
		{
			Shader.SetGlobalFloatArray(nameID, (float[])Shader.ExtractArrayFromList(values));
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x000110A8 File Offset: 0x0000F2A8
		public static void SetGlobalFloatArray(string name, float[] values)
		{
			Shader.SetGlobalFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x000110B8 File Offset: 0x0000F2B8
		public static void SetGlobalFloatArray(int nameID, float[] values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			if (values.Length == 0)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			Shader.SetGlobalFloatArrayImpl(nameID, values);
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x000110E8 File Offset: 0x0000F2E8
		public static void SetGlobalVectorArray(string name, List<Vector4> values)
		{
			Shader.SetGlobalVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x000110F8 File Offset: 0x0000F2F8
		public static void SetGlobalVectorArray(int nameID, List<Vector4> values)
		{
			Shader.SetGlobalVectorArray(nameID, (Vector4[])Shader.ExtractArrayFromList(values));
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x0001110C File Offset: 0x0000F30C
		public static void SetGlobalVectorArray(string name, Vector4[] values)
		{
			Shader.SetGlobalVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x0001111C File Offset: 0x0000F31C
		public static void SetGlobalVectorArray(int nameID, Vector4[] values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			if (values.Length == 0)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			Shader.SetGlobalVectorArrayImpl(nameID, values);
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0001114C File Offset: 0x0000F34C
		public static void SetGlobalMatrixArray(string name, List<Matrix4x4> values)
		{
			Shader.SetGlobalMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x0001115C File Offset: 0x0000F35C
		public static void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values)
		{
			Shader.SetGlobalMatrixArray(nameID, (Matrix4x4[])Shader.ExtractArrayFromList(values));
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x00011170 File Offset: 0x0000F370
		public static void SetGlobalMatrixArray(string name, Matrix4x4[] values)
		{
			Shader.SetGlobalMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00011180 File Offset: 0x0000F380
		public static void SetGlobalMatrixArray(int nameID, Matrix4x4[] values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			if (values.Length == 0)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			Shader.SetGlobalMatrixArrayImpl(nameID, values);
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x000111B0 File Offset: 0x0000F3B0
		public static float GetGlobalFloat(string name)
		{
			return Shader.GetGlobalFloat(Shader.PropertyToID(name));
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x000111D0 File Offset: 0x0000F3D0
		public static float GetGlobalFloat(int nameID)
		{
			return Shader.GetGlobalFloatImpl(nameID);
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x000111EC File Offset: 0x0000F3EC
		public static int GetGlobalInt(string name)
		{
			return Shader.GetGlobalInt(Shader.PropertyToID(name));
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x0001120C File Offset: 0x0000F40C
		public static int GetGlobalInt(int nameID)
		{
			return Shader.GetGlobalIntImpl(nameID);
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00011228 File Offset: 0x0000F428
		public static Vector4 GetGlobalVector(string name)
		{
			return Shader.GetGlobalVector(Shader.PropertyToID(name));
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00011248 File Offset: 0x0000F448
		public static Vector4 GetGlobalVector(int nameID)
		{
			return Shader.GetGlobalVectorImpl(nameID);
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00011264 File Offset: 0x0000F464
		public static Color GetGlobalColor(string name)
		{
			return Shader.GetGlobalColor(Shader.PropertyToID(name));
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00011284 File Offset: 0x0000F484
		public static Color GetGlobalColor(int nameID)
		{
			return Shader.GetGlobalColorImpl(nameID);
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x000112A0 File Offset: 0x0000F4A0
		public static Matrix4x4 GetGlobalMatrix(string name)
		{
			return Shader.GetGlobalMatrix(Shader.PropertyToID(name));
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x000112C0 File Offset: 0x0000F4C0
		public static Matrix4x4 GetGlobalMatrix(int nameID)
		{
			return Shader.GetGlobalMatrixImpl(nameID);
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x000112DC File Offset: 0x0000F4DC
		public static Texture GetGlobalTexture(string name)
		{
			return Shader.GetGlobalTexture(Shader.PropertyToID(name));
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x000112FC File Offset: 0x0000F4FC
		public static Texture GetGlobalTexture(int nameID)
		{
			return Shader.GetGlobalTextureImpl(nameID);
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00011318 File Offset: 0x0000F518
		public static void GetGlobalFloatArray(string name, List<float> values)
		{
			Shader.GetGlobalFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00011328 File Offset: 0x0000F528
		public static void GetGlobalFloatArray(int nameID, List<float> values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			Shader.GetGlobalFloatArrayImplList(nameID, values);
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x00011344 File Offset: 0x0000F544
		public static float[] GetGlobalFloatArray(string name)
		{
			return Shader.GetGlobalFloatArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x00011364 File Offset: 0x0000F564
		public static float[] GetGlobalFloatArray(int nameID)
		{
			return Shader.GetGlobalFloatArrayImpl(nameID);
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x00011380 File Offset: 0x0000F580
		public static void GetGlobalVectorArray(string name, List<Vector4> values)
		{
			Shader.GetGlobalVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00011390 File Offset: 0x0000F590
		public static void GetGlobalVectorArray(int nameID, List<Vector4> values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			Shader.GetGlobalVectorArrayImplList(nameID, values);
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x000113AC File Offset: 0x0000F5AC
		public static Vector4[] GetGlobalVectorArray(string name)
		{
			return Shader.GetGlobalVectorArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x000113CC File Offset: 0x0000F5CC
		public static Vector4[] GetGlobalVectorArray(int nameID)
		{
			return Shader.GetGlobalVectorArrayImpl(nameID);
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x000113E8 File Offset: 0x0000F5E8
		public static void GetGlobalMatrixArray(string name, List<Matrix4x4> values)
		{
			Shader.GetGlobalMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x000113F8 File Offset: 0x0000F5F8
		public static void GetGlobalMatrixArray(int nameID, List<Matrix4x4> values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			Shader.GetGlobalMatrixArrayImplList(nameID, values);
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x00011414 File Offset: 0x0000F614
		public static Matrix4x4[] GetGlobalMatrixArray(string name)
		{
			return Shader.GetGlobalMatrixArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x00011434 File Offset: 0x0000F634
		public static Matrix4x4[] GetGlobalMatrixArray(int nameID)
		{
			return Shader.GetGlobalMatrixArrayImpl(nameID);
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x00011450 File Offset: 0x0000F650
		// (set) Token: 0x06000CEE RID: 3310 RVA: 0x0001146C File Offset: 0x0000F66C
		[Obsolete("Use Graphics.activeTier instead (UnityUpgradable) -> UnityEngine.Graphics.activeTier", false)]
		public static ShaderHardwareTier globalShaderHardwareTier
		{
			get
			{
				return (ShaderHardwareTier)Graphics.activeTier;
			}
			set
			{
				Graphics.activeTier = (GraphicsTier)value;
			}
		}
	}
}
