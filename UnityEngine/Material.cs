using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000AD RID: 173
	public class Material : Object
	{
		// Token: 0x06000CEF RID: 3311 RVA: 0x00011478 File Offset: 0x0000F678
		[Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.")]
		public Material(string contents)
		{
			Material.Internal_CreateWithString(this, contents);
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00011488 File Offset: 0x0000F688
		public Material(Shader shader)
		{
			Material.Internal_CreateWithShader(this, shader);
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00011498 File Offset: 0x0000F698
		public Material(Material source)
		{
			Material.Internal_CreateWithMaterial(this, source);
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000CF2 RID: 3314
		// (set) Token: 0x06000CF3 RID: 3315
		public extern Shader shader { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x000114A8 File Offset: 0x0000F6A8
		// (set) Token: 0x06000CF5 RID: 3317 RVA: 0x000114C8 File Offset: 0x0000F6C8
		public Color color
		{
			get
			{
				return this.GetColor("_Color");
			}
			set
			{
				this.SetColor("_Color", value);
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x000114D8 File Offset: 0x0000F6D8
		// (set) Token: 0x06000CF7 RID: 3319 RVA: 0x000114F8 File Offset: 0x0000F6F8
		public Texture mainTexture
		{
			get
			{
				return this.GetTexture("_MainTex");
			}
			set
			{
				this.SetTexture("_MainTex", value);
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x00011508 File Offset: 0x0000F708
		// (set) Token: 0x06000CF9 RID: 3321 RVA: 0x00011528 File Offset: 0x0000F728
		public Vector2 mainTextureOffset
		{
			get
			{
				return this.GetTextureOffset("_MainTex");
			}
			set
			{
				this.SetTextureOffset("_MainTex", value);
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000CFA RID: 3322 RVA: 0x00011538 File Offset: 0x0000F738
		// (set) Token: 0x06000CFB RID: 3323 RVA: 0x00011558 File Offset: 0x0000F758
		public Vector2 mainTextureScale
		{
			get
			{
				return this.GetTextureScale("_MainTex");
			}
			set
			{
				this.SetTextureScale("_MainTex", value);
			}
		}

		// Token: 0x06000CFC RID: 3324
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetFloatImpl(int nameID, float value);

		// Token: 0x06000CFD RID: 3325
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetIntImpl(int nameID, int value);

		// Token: 0x06000CFE RID: 3326 RVA: 0x00011568 File Offset: 0x0000F768
		private void SetColorImpl(int nameID, Color value)
		{
			Material.INTERNAL_CALL_SetColorImpl(this, nameID, ref value);
		}

		// Token: 0x06000CFF RID: 3327
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetColorImpl(Material self, int nameID, ref Color value);

		// Token: 0x06000D00 RID: 3328 RVA: 0x00011574 File Offset: 0x0000F774
		private void SetVectorImpl(int nameID, Vector4 value)
		{
			Material.INTERNAL_CALL_SetVectorImpl(this, nameID, ref value);
		}

		// Token: 0x06000D01 RID: 3329
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetVectorImpl(Material self, int nameID, ref Vector4 value);

		// Token: 0x06000D02 RID: 3330 RVA: 0x00011580 File Offset: 0x0000F780
		private void SetMatrixImpl(int nameID, Matrix4x4 value)
		{
			Material.INTERNAL_CALL_SetMatrixImpl(this, nameID, ref value);
		}

		// Token: 0x06000D03 RID: 3331
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetMatrixImpl(Material self, int nameID, ref Matrix4x4 value);

		// Token: 0x06000D04 RID: 3332
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetTextureImpl(int nameID, Texture value);

		// Token: 0x06000D05 RID: 3333
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetBufferImpl(int nameID, ComputeBuffer value);

		// Token: 0x06000D06 RID: 3334
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetFloatArrayImpl(int nameID, float[] values);

		// Token: 0x06000D07 RID: 3335
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetVectorArrayImpl(int nameID, Vector4[] values);

		// Token: 0x06000D08 RID: 3336
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetMatrixArrayImpl(int nameID, Matrix4x4[] values);

		// Token: 0x06000D09 RID: 3337
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Array ExtractArrayFromList(object list);

		// Token: 0x06000D0A RID: 3338
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern float GetFloatImpl(int nameID);

		// Token: 0x06000D0B RID: 3339
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int GetIntImpl(int nameID);

		// Token: 0x06000D0C RID: 3340 RVA: 0x0001158C File Offset: 0x0000F78C
		private Color GetColorImpl(int nameID)
		{
			Color result;
			Material.INTERNAL_CALL_GetColorImpl(this, nameID, out result);
			return result;
		}

		// Token: 0x06000D0D RID: 3341
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetColorImpl(Material self, int nameID, out Color value);

		// Token: 0x06000D0E RID: 3342 RVA: 0x000115AC File Offset: 0x0000F7AC
		private Vector4 GetVectorImpl(int nameID)
		{
			Vector4 result;
			Material.INTERNAL_CALL_GetVectorImpl(this, nameID, out result);
			return result;
		}

		// Token: 0x06000D0F RID: 3343
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetVectorImpl(Material self, int nameID, out Vector4 value);

		// Token: 0x06000D10 RID: 3344 RVA: 0x000115CC File Offset: 0x0000F7CC
		private Matrix4x4 GetMatrixImpl(int nameID)
		{
			Matrix4x4 result;
			Material.INTERNAL_CALL_GetMatrixImpl(this, nameID, out result);
			return result;
		}

		// Token: 0x06000D11 RID: 3345
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetMatrixImpl(Material self, int nameID, out Matrix4x4 value);

		// Token: 0x06000D12 RID: 3346
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Texture GetTextureImpl(int nameID);

		// Token: 0x06000D13 RID: 3347
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern float[] GetFloatArrayImpl(int nameID);

		// Token: 0x06000D14 RID: 3348
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Vector4[] GetVectorArrayImpl(int nameID);

		// Token: 0x06000D15 RID: 3349
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Matrix4x4[] GetMatrixArrayImpl(int nameID);

		// Token: 0x06000D16 RID: 3350
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetFloatArrayImplList(int nameID, object list);

		// Token: 0x06000D17 RID: 3351
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetVectorArrayImplList(int nameID, object list);

		// Token: 0x06000D18 RID: 3352
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetMatrixArrayImplList(int nameID, object list);

		// Token: 0x06000D19 RID: 3353
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetColorArrayImpl(int nameID, Color[] values);

		// Token: 0x06000D1A RID: 3354
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetColorArrayImplList(int nameID, object values);

		// Token: 0x06000D1B RID: 3355
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Color[] GetColorArrayImpl(int nameID);

		// Token: 0x06000D1C RID: 3356
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetColorArrayImplList(int nameID, object list);

		// Token: 0x06000D1D RID: 3357 RVA: 0x000115EC File Offset: 0x0000F7EC
		private Vector4 GetTextureScaleAndOffsetImpl(int nameID)
		{
			Vector4 result;
			Material.INTERNAL_CALL_GetTextureScaleAndOffsetImpl(this, nameID, out result);
			return result;
		}

		// Token: 0x06000D1E RID: 3358
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetTextureScaleAndOffsetImpl(Material self, int nameID, out Vector4 value);

		// Token: 0x06000D1F RID: 3359 RVA: 0x0001160C File Offset: 0x0000F80C
		private void SetTextureOffsetImpl(int nameID, Vector2 offset)
		{
			Material.INTERNAL_CALL_SetTextureOffsetImpl(this, nameID, ref offset);
		}

		// Token: 0x06000D20 RID: 3360
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetTextureOffsetImpl(Material self, int nameID, ref Vector2 offset);

		// Token: 0x06000D21 RID: 3361 RVA: 0x00011618 File Offset: 0x0000F818
		private void SetTextureScaleImpl(int nameID, Vector2 scale)
		{
			Material.INTERNAL_CALL_SetTextureScaleImpl(this, nameID, ref scale);
		}

		// Token: 0x06000D22 RID: 3362
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetTextureScaleImpl(Material self, int nameID, ref Vector2 scale);

		// Token: 0x06000D23 RID: 3363 RVA: 0x00011624 File Offset: 0x0000F824
		public bool HasProperty(string propertyName)
		{
			return this.HasProperty(Shader.PropertyToID(propertyName));
		}

		// Token: 0x06000D24 RID: 3364
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool HasProperty(int nameID);

		// Token: 0x06000D25 RID: 3365
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string GetTag(string tag, bool searchFallbacks, [DefaultValue("\"\"")] string defaultValue);

		// Token: 0x06000D26 RID: 3366 RVA: 0x00011648 File Offset: 0x0000F848
		[ExcludeFromDocs]
		public string GetTag(string tag, bool searchFallbacks)
		{
			string defaultValue = "";
			return this.GetTag(tag, searchFallbacks, defaultValue);
		}

		// Token: 0x06000D27 RID: 3367
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetOverrideTag(string tag, string val);

		// Token: 0x06000D28 RID: 3368
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetShaderPassEnabled(string passName, bool enabled);

		// Token: 0x06000D29 RID: 3369
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool GetShaderPassEnabled(string passName);

		// Token: 0x06000D2A RID: 3370
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Lerp(Material start, Material end, float t);

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000D2B RID: 3371
		public extern int passCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000D2C RID: 3372
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool SetPass(int pass);

		// Token: 0x06000D2D RID: 3373
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string GetPassName(int pass);

		// Token: 0x06000D2E RID: 3374
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int FindPass(string passName);

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000D2F RID: 3375
		// (set) Token: 0x06000D30 RID: 3376
		public extern int renderQueue { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000D31 RID: 3377 RVA: 0x0001166C File Offset: 0x0000F86C
		[Obsolete("Creating materials from shader source string will be removed in the future. Use Shader assets instead.")]
		public static Material Create(string scriptContents)
		{
			return new Material(scriptContents);
		}

		// Token: 0x06000D32 RID: 3378
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateWithString([Writable] Material mono, string contents);

		// Token: 0x06000D33 RID: 3379
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateWithShader([Writable] Material mono, Shader shader);

		// Token: 0x06000D34 RID: 3380
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateWithMaterial([Writable] Material mono, Material source);

		// Token: 0x06000D35 RID: 3381
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void CopyPropertiesFromMaterial(Material mat);

		// Token: 0x06000D36 RID: 3382
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void EnableKeyword(string keyword);

		// Token: 0x06000D37 RID: 3383
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void DisableKeyword(string keyword);

		// Token: 0x06000D38 RID: 3384
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsKeywordEnabled(string keyword);

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000D39 RID: 3385
		// (set) Token: 0x06000D3A RID: 3386
		public extern string[] shaderKeywords { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000D3B RID: 3387
		// (set) Token: 0x06000D3C RID: 3388
		public extern MaterialGlobalIlluminationFlags globalIlluminationFlags { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000D3D RID: 3389
		// (set) Token: 0x06000D3E RID: 3390
		public extern bool enableInstancing { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000D3F RID: 3391
		// (set) Token: 0x06000D40 RID: 3392
		public extern bool doubleSidedGI { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000D41 RID: 3393 RVA: 0x00011688 File Offset: 0x0000F888
		public void SetFloat(string name, float value)
		{
			this.SetFloat(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x00011698 File Offset: 0x0000F898
		public void SetFloat(int nameID, float value)
		{
			this.SetFloatImpl(nameID, value);
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x000116A4 File Offset: 0x0000F8A4
		public void SetInt(string name, int value)
		{
			this.SetInt(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x000116B4 File Offset: 0x0000F8B4
		public void SetInt(int nameID, int value)
		{
			this.SetIntImpl(nameID, value);
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x000116C0 File Offset: 0x0000F8C0
		public void SetColor(string name, Color value)
		{
			this.SetColor(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x000116D0 File Offset: 0x0000F8D0
		public void SetColor(int nameID, Color value)
		{
			this.SetColorImpl(nameID, value);
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x000116DC File Offset: 0x0000F8DC
		public void SetVector(string name, Vector4 value)
		{
			this.SetVector(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x000116EC File Offset: 0x0000F8EC
		public void SetVector(int nameID, Vector4 value)
		{
			this.SetVectorImpl(nameID, value);
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x000116F8 File Offset: 0x0000F8F8
		public void SetMatrix(string name, Matrix4x4 value)
		{
			this.SetMatrix(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00011708 File Offset: 0x0000F908
		public void SetMatrix(int nameID, Matrix4x4 value)
		{
			this.SetMatrixImpl(nameID, value);
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00011714 File Offset: 0x0000F914
		public void SetTexture(string name, Texture value)
		{
			this.SetTexture(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00011724 File Offset: 0x0000F924
		public void SetTexture(int nameID, Texture value)
		{
			this.SetTextureImpl(nameID, value);
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00011730 File Offset: 0x0000F930
		public void SetBuffer(string name, ComputeBuffer value)
		{
			this.SetBuffer(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00011740 File Offset: 0x0000F940
		public void SetBuffer(int nameID, ComputeBuffer value)
		{
			this.SetBufferImpl(nameID, value);
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x0001174C File Offset: 0x0000F94C
		public void SetTextureOffset(string name, Vector2 value)
		{
			this.SetTextureOffset(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x0001175C File Offset: 0x0000F95C
		public void SetTextureOffset(int nameID, Vector2 value)
		{
			this.SetTextureOffsetImpl(nameID, value);
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00011768 File Offset: 0x0000F968
		public void SetTextureScale(string name, Vector2 value)
		{
			this.SetTextureScale(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00011778 File Offset: 0x0000F978
		public void SetTextureScale(int nameID, Vector2 value)
		{
			this.SetTextureScaleImpl(nameID, value);
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x00011784 File Offset: 0x0000F984
		public void SetFloatArray(string name, List<float> values)
		{
			this.SetFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00011794 File Offset: 0x0000F994
		public void SetFloatArray(int nameID, List<float> values)
		{
			this.SetFloatArray(nameID, (float[])Material.ExtractArrayFromList(values));
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x000117AC File Offset: 0x0000F9AC
		public void SetFloatArray(string name, float[] values)
		{
			this.SetFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x000117BC File Offset: 0x0000F9BC
		public void SetFloatArray(int nameID, float[] values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			if (values.Length == 0)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			this.SetFloatArrayImpl(nameID, values);
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x000117EC File Offset: 0x0000F9EC
		public void SetColorArray(string name, List<Color> values)
		{
			this.SetColorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x000117FC File Offset: 0x0000F9FC
		public void SetColorArray(int nameID, List<Color> values)
		{
			this.SetColorArray(nameID, (Color[])Material.ExtractArrayFromList(values));
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00011814 File Offset: 0x0000FA14
		public void SetColorArray(string name, Color[] values)
		{
			this.SetColorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00011824 File Offset: 0x0000FA24
		public void SetColorArray(int nameID, Color[] values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			if (values.Length == 0)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			this.SetColorArrayImpl(nameID, values);
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x00011854 File Offset: 0x0000FA54
		public void SetVectorArray(string name, List<Vector4> values)
		{
			this.SetVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x00011864 File Offset: 0x0000FA64
		public void SetVectorArray(int nameID, List<Vector4> values)
		{
			this.SetVectorArray(nameID, (Vector4[])Material.ExtractArrayFromList(values));
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x0001187C File Offset: 0x0000FA7C
		public void SetVectorArray(string name, Vector4[] values)
		{
			this.SetVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x0001188C File Offset: 0x0000FA8C
		public void SetVectorArray(int nameID, Vector4[] values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			if (values.Length == 0)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			this.SetVectorArrayImpl(nameID, values);
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x000118BC File Offset: 0x0000FABC
		public void SetMatrixArray(string name, List<Matrix4x4> values)
		{
			this.SetMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x000118CC File Offset: 0x0000FACC
		public void SetMatrixArray(int nameID, List<Matrix4x4> values)
		{
			this.SetMatrixArray(nameID, (Matrix4x4[])Material.ExtractArrayFromList(values));
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x000118E4 File Offset: 0x0000FAE4
		public void SetMatrixArray(string name, Matrix4x4[] values)
		{
			this.SetMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x000118F4 File Offset: 0x0000FAF4
		public void SetMatrixArray(int nameID, Matrix4x4[] values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			if (values.Length == 0)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			this.SetMatrixArrayImpl(nameID, values);
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00011924 File Offset: 0x0000FB24
		public float GetFloat(string name)
		{
			return this.GetFloat(Shader.PropertyToID(name));
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00011948 File Offset: 0x0000FB48
		public float GetFloat(int nameID)
		{
			return this.GetFloatImpl(nameID);
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00011964 File Offset: 0x0000FB64
		public int GetInt(string name)
		{
			return this.GetInt(Shader.PropertyToID(name));
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00011988 File Offset: 0x0000FB88
		public int GetInt(int nameID)
		{
			return this.GetIntImpl(nameID);
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x000119A4 File Offset: 0x0000FBA4
		public Color GetColor(string name)
		{
			return this.GetColor(Shader.PropertyToID(name));
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x000119C8 File Offset: 0x0000FBC8
		public Color GetColor(int nameID)
		{
			return this.GetColorImpl(nameID);
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x000119E4 File Offset: 0x0000FBE4
		public Vector4 GetVector(string name)
		{
			return this.GetVector(Shader.PropertyToID(name));
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00011A08 File Offset: 0x0000FC08
		public Vector4 GetVector(int nameID)
		{
			return this.GetVectorImpl(nameID);
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00011A24 File Offset: 0x0000FC24
		public Matrix4x4 GetMatrix(string name)
		{
			return this.GetMatrix(Shader.PropertyToID(name));
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00011A48 File Offset: 0x0000FC48
		public Matrix4x4 GetMatrix(int nameID)
		{
			return this.GetMatrixImpl(nameID);
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x00011A64 File Offset: 0x0000FC64
		public void GetFloatArray(string name, List<float> values)
		{
			this.GetFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x00011A74 File Offset: 0x0000FC74
		public void GetFloatArray(int nameID, List<float> values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			this.GetFloatArrayImplList(nameID, values);
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x00011A90 File Offset: 0x0000FC90
		public float[] GetFloatArray(string name)
		{
			return this.GetFloatArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00011AB4 File Offset: 0x0000FCB4
		public float[] GetFloatArray(int nameID)
		{
			return this.GetFloatArrayImpl(nameID);
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x00011AD0 File Offset: 0x0000FCD0
		public void GetVectorArray(string name, List<Vector4> values)
		{
			this.GetVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x00011AE0 File Offset: 0x0000FCE0
		public void GetVectorArray(int nameID, List<Vector4> values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			this.GetVectorArrayImplList(nameID, values);
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x00011AFC File Offset: 0x0000FCFC
		public Color[] GetColorArray(string name)
		{
			return this.GetColorArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x00011B20 File Offset: 0x0000FD20
		public Color[] GetColorArray(int nameID)
		{
			return this.GetColorArrayImpl(nameID);
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x00011B3C File Offset: 0x0000FD3C
		public void GetColorArray(string name, List<Color> values)
		{
			this.GetColorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x00011B4C File Offset: 0x0000FD4C
		public void GetColorArray(int nameID, List<Color> values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			this.GetColorArrayImplList(nameID, values);
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00011B68 File Offset: 0x0000FD68
		public Vector4[] GetVectorArray(string name)
		{
			return this.GetVectorArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00011B8C File Offset: 0x0000FD8C
		public Vector4[] GetVectorArray(int nameID)
		{
			return this.GetVectorArrayImpl(nameID);
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x00011BA8 File Offset: 0x0000FDA8
		public void GetMatrixArray(string name, List<Matrix4x4> values)
		{
			this.GetMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x00011BB8 File Offset: 0x0000FDB8
		public void GetMatrixArray(int nameID, List<Matrix4x4> values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			this.GetMatrixArrayImplList(nameID, values);
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x00011BD4 File Offset: 0x0000FDD4
		public Matrix4x4[] GetMatrixArray(string name)
		{
			return this.GetMatrixArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00011BF8 File Offset: 0x0000FDF8
		public Matrix4x4[] GetMatrixArray(int nameID)
		{
			return this.GetMatrixArrayImpl(nameID);
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00011C14 File Offset: 0x0000FE14
		public Texture GetTexture(string name)
		{
			return this.GetTexture(Shader.PropertyToID(name));
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00011C38 File Offset: 0x0000FE38
		public Texture GetTexture(int nameID)
		{
			return this.GetTextureImpl(nameID);
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00011C54 File Offset: 0x0000FE54
		public Vector2 GetTextureOffset(string name)
		{
			return this.GetTextureOffset(Shader.PropertyToID(name));
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00011C78 File Offset: 0x0000FE78
		public Vector2 GetTextureOffset(int nameID)
		{
			Vector4 textureScaleAndOffsetImpl = this.GetTextureScaleAndOffsetImpl(nameID);
			return new Vector2(textureScaleAndOffsetImpl.z, textureScaleAndOffsetImpl.w);
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x00011CA8 File Offset: 0x0000FEA8
		public Vector2 GetTextureScale(string name)
		{
			return this.GetTextureScale(Shader.PropertyToID(name));
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x00011CCC File Offset: 0x0000FECC
		public Vector2 GetTextureScale(int nameID)
		{
			Vector4 textureScaleAndOffsetImpl = this.GetTextureScaleAndOffsetImpl(nameID);
			return new Vector2(textureScaleAndOffsetImpl.x, textureScaleAndOffsetImpl.y);
		}
	}
}
