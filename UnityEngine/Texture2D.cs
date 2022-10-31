using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000C6 RID: 198
	public sealed class Texture2D : Texture
	{
		// Token: 0x06000E49 RID: 3657 RVA: 0x000131DC File Offset: 0x000113DC
		public Texture2D(int width, int height)
		{
			Texture2D.Internal_Create(this, width, height, TextureFormat.RGBA32, true, false, IntPtr.Zero);
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x000131F8 File Offset: 0x000113F8
		public Texture2D(int width, int height, TextureFormat format, bool mipmap)
		{
			Texture2D.Internal_Create(this, width, height, format, mipmap, false, IntPtr.Zero);
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x00013214 File Offset: 0x00011414
		public Texture2D(int width, int height, TextureFormat format, bool mipmap, bool linear)
		{
			Texture2D.Internal_Create(this, width, height, format, mipmap, linear, IntPtr.Zero);
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00013230 File Offset: 0x00011430
		internal Texture2D(int width, int height, TextureFormat format, bool mipmap, bool linear, IntPtr nativeTex)
		{
			Texture2D.Internal_Create(this, width, height, format, mipmap, linear, nativeTex);
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000E4D RID: 3661
		public extern int mipmapCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000E4E RID: 3662
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Create([Writable] Texture2D mono, int width, int height, TextureFormat format, bool mipmap, bool linear, IntPtr nativeTex);

		// Token: 0x06000E4F RID: 3663 RVA: 0x00013248 File Offset: 0x00011448
		public static Texture2D CreateExternalTexture(int width, int height, TextureFormat format, bool mipmap, bool linear, IntPtr nativeTex)
		{
			return new Texture2D(width, height, format, mipmap, linear, nativeTex);
		}

		// Token: 0x06000E50 RID: 3664
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void UpdateExternalTexture(IntPtr nativeTex);

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000E51 RID: 3665
		public extern TextureFormat format { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000E52 RID: 3666
		public static extern Texture2D whiteTexture { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000E53 RID: 3667
		public static extern Texture2D blackTexture { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000E54 RID: 3668 RVA: 0x0001326C File Offset: 0x0001146C
		public void SetPixel(int x, int y, Color color)
		{
			Texture2D.INTERNAL_CALL_SetPixel(this, x, y, ref color);
		}

		// Token: 0x06000E55 RID: 3669
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetPixel(Texture2D self, int x, int y, ref Color color);

		// Token: 0x06000E56 RID: 3670 RVA: 0x0001327C File Offset: 0x0001147C
		public Color GetPixel(int x, int y)
		{
			Color result;
			Texture2D.INTERNAL_CALL_GetPixel(this, x, y, out result);
			return result;
		}

		// Token: 0x06000E57 RID: 3671
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetPixel(Texture2D self, int x, int y, out Color value);

		// Token: 0x06000E58 RID: 3672 RVA: 0x0001329C File Offset: 0x0001149C
		public Color GetPixelBilinear(float u, float v)
		{
			Color result;
			Texture2D.INTERNAL_CALL_GetPixelBilinear(this, u, v, out result);
			return result;
		}

		// Token: 0x06000E59 RID: 3673
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetPixelBilinear(Texture2D self, float u, float v, out Color value);

		// Token: 0x06000E5A RID: 3674 RVA: 0x000132BC File Offset: 0x000114BC
		[ExcludeFromDocs]
		public void SetPixels(Color[] colors)
		{
			int miplevel = 0;
			this.SetPixels(colors, miplevel);
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x000132D4 File Offset: 0x000114D4
		public void SetPixels(Color[] colors, [DefaultValue("0")] int miplevel)
		{
			int num = this.width >> miplevel;
			if (num < 1)
			{
				num = 1;
			}
			int num2 = this.height >> miplevel;
			if (num2 < 1)
			{
				num2 = 1;
			}
			this.SetPixels(0, 0, num, num2, colors, miplevel);
		}

		// Token: 0x06000E5C RID: 3676
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, [DefaultValue("0")] int miplevel);

		// Token: 0x06000E5D RID: 3677 RVA: 0x00013318 File Offset: 0x00011518
		[ExcludeFromDocs]
		public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors)
		{
			int miplevel = 0;
			this.SetPixels(x, y, blockWidth, blockHeight, colors, miplevel);
		}

		// Token: 0x06000E5E RID: 3678
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetAllPixels32(Color32[] colors, int miplevel);

		// Token: 0x06000E5F RID: 3679
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel);

		// Token: 0x06000E60 RID: 3680 RVA: 0x00013338 File Offset: 0x00011538
		[ExcludeFromDocs]
		public void SetPixels32(Color32[] colors)
		{
			int miplevel = 0;
			this.SetPixels32(colors, miplevel);
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x00013350 File Offset: 0x00011550
		public void SetPixels32(Color32[] colors, [DefaultValue("0")] int miplevel)
		{
			this.SetAllPixels32(colors, miplevel);
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x0001335C File Offset: 0x0001155C
		[ExcludeFromDocs]
		public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors)
		{
			int miplevel = 0;
			this.SetPixels32(x, y, blockWidth, blockHeight, colors, miplevel);
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x0001337C File Offset: 0x0001157C
		public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, [DefaultValue("0")] int miplevel)
		{
			this.SetBlockOfPixels32(x, y, blockWidth, blockHeight, colors, miplevel);
		}

		// Token: 0x06000E64 RID: 3684
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool LoadImage(byte[] data, [DefaultValue("false")] bool markNonReadable);

		// Token: 0x06000E65 RID: 3685 RVA: 0x00013390 File Offset: 0x00011590
		[ExcludeFromDocs]
		public bool LoadImage(byte[] data)
		{
			bool markNonReadable = false;
			return this.LoadImage(data, markNonReadable);
		}

		// Token: 0x06000E66 RID: 3686
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void LoadRawTextureData_ImplArray(byte[] data);

		// Token: 0x06000E67 RID: 3687
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void LoadRawTextureData_ImplPointer(IntPtr data, int size);

		// Token: 0x06000E68 RID: 3688 RVA: 0x000133B0 File Offset: 0x000115B0
		public void LoadRawTextureData(byte[] data)
		{
			this.LoadRawTextureData_ImplArray(data);
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x000133BC File Offset: 0x000115BC
		public void LoadRawTextureData(IntPtr data, int size)
		{
			this.LoadRawTextureData_ImplPointer(data, size);
		}

		// Token: 0x06000E6A RID: 3690
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern byte[] GetRawTextureData();

		// Token: 0x06000E6B RID: 3691 RVA: 0x000133C8 File Offset: 0x000115C8
		[ExcludeFromDocs]
		public Color[] GetPixels()
		{
			int miplevel = 0;
			return this.GetPixels(miplevel);
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x000133E8 File Offset: 0x000115E8
		public Color[] GetPixels([DefaultValue("0")] int miplevel)
		{
			int num = this.width >> miplevel;
			if (num < 1)
			{
				num = 1;
			}
			int num2 = this.height >> miplevel;
			if (num2 < 1)
			{
				num2 = 1;
			}
			return this.GetPixels(0, 0, num, num2, miplevel);
		}

		// Token: 0x06000E6D RID: 3693
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, [DefaultValue("0")] int miplevel);

		// Token: 0x06000E6E RID: 3694 RVA: 0x00013434 File Offset: 0x00011634
		[ExcludeFromDocs]
		public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight)
		{
			int miplevel = 0;
			return this.GetPixels(x, y, blockWidth, blockHeight, miplevel);
		}

		// Token: 0x06000E6F RID: 3695
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color32[] GetPixels32([DefaultValue("0")] int miplevel);

		// Token: 0x06000E70 RID: 3696 RVA: 0x00013458 File Offset: 0x00011658
		[ExcludeFromDocs]
		public Color32[] GetPixels32()
		{
			int miplevel = 0;
			return this.GetPixels32(miplevel);
		}

		// Token: 0x06000E71 RID: 3697
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Apply([DefaultValue("true")] bool updateMipmaps, [DefaultValue("false")] bool makeNoLongerReadable);

		// Token: 0x06000E72 RID: 3698 RVA: 0x00013478 File Offset: 0x00011678
		[ExcludeFromDocs]
		public void Apply(bool updateMipmaps)
		{
			bool makeNoLongerReadable = false;
			this.Apply(updateMipmaps, makeNoLongerReadable);
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00013490 File Offset: 0x00011690
		[ExcludeFromDocs]
		public void Apply()
		{
			bool makeNoLongerReadable = false;
			bool updateMipmaps = true;
			this.Apply(updateMipmaps, makeNoLongerReadable);
		}

		// Token: 0x06000E74 RID: 3700
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool Resize(int width, int height, TextureFormat format, bool hasMipMap);

		// Token: 0x06000E75 RID: 3701 RVA: 0x000134AC File Offset: 0x000116AC
		public bool Resize(int width, int height)
		{
			return this.Internal_ResizeWH(width, height);
		}

		// Token: 0x06000E76 RID: 3702
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool Internal_ResizeWH(int width, int height);

		// Token: 0x06000E77 RID: 3703 RVA: 0x000134CC File Offset: 0x000116CC
		public void Compress(bool highQuality)
		{
			Texture2D.INTERNAL_CALL_Compress(this, highQuality);
		}

		// Token: 0x06000E78 RID: 3704
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Compress(Texture2D self, bool highQuality);

		// Token: 0x06000E79 RID: 3705
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Rect[] PackTextures(Texture2D[] textures, int padding, [DefaultValue("2048")] int maximumAtlasSize, [DefaultValue("false")] bool makeNoLongerReadable);

		// Token: 0x06000E7A RID: 3706 RVA: 0x000134D8 File Offset: 0x000116D8
		[ExcludeFromDocs]
		public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize)
		{
			bool makeNoLongerReadable = false;
			return this.PackTextures(textures, padding, maximumAtlasSize, makeNoLongerReadable);
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x000134FC File Offset: 0x000116FC
		[ExcludeFromDocs]
		public Rect[] PackTextures(Texture2D[] textures, int padding)
		{
			bool makeNoLongerReadable = false;
			int maximumAtlasSize = 2048;
			return this.PackTextures(textures, padding, maximumAtlasSize, makeNoLongerReadable);
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00013524 File Offset: 0x00011724
		public static bool GenerateAtlas(Vector2[] sizes, int padding, int atlasSize, List<Rect> results)
		{
			if (sizes == null)
			{
				throw new ArgumentException("sizes array can not be null");
			}
			if (results == null)
			{
				throw new ArgumentException("results list cannot be null");
			}
			if (padding < 0)
			{
				throw new ArgumentException("padding can not be negative");
			}
			if (atlasSize <= 0)
			{
				throw new ArgumentException("atlas size must be positive");
			}
			results.Clear();
			bool result;
			if (sizes.Length == 0)
			{
				result = true;
			}
			else
			{
				Texture2D.GenerateAtlasInternal(sizes, padding, atlasSize, results);
				result = (results.Count != 0);
			}
			return result;
		}

		// Token: 0x06000E7D RID: 3709
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GenerateAtlasInternal(Vector2[] sizes, int padding, int atlasSize, object resultList);

		// Token: 0x06000E7E RID: 3710 RVA: 0x000135AC File Offset: 0x000117AC
		public void ReadPixels(Rect source, int destX, int destY, [DefaultValue("true")] bool recalculateMipMaps)
		{
			Texture2D.INTERNAL_CALL_ReadPixels(this, ref source, destX, destY, recalculateMipMaps);
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x000135BC File Offset: 0x000117BC
		[ExcludeFromDocs]
		public void ReadPixels(Rect source, int destX, int destY)
		{
			bool recalculateMipMaps = true;
			Texture2D.INTERNAL_CALL_ReadPixels(this, ref source, destX, destY, recalculateMipMaps);
		}

		// Token: 0x06000E80 RID: 3712
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ReadPixels(Texture2D self, ref Rect source, int destX, int destY, bool recalculateMipMaps);

		// Token: 0x06000E81 RID: 3713
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern byte[] EncodeToPNG();

		// Token: 0x06000E82 RID: 3714
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern byte[] EncodeToJPG(int quality);

		// Token: 0x06000E83 RID: 3715 RVA: 0x000135D8 File Offset: 0x000117D8
		public byte[] EncodeToJPG()
		{
			return this.EncodeToJPG(75);
		}

		// Token: 0x06000E84 RID: 3716
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern byte[] EncodeToEXR([DefaultValue("EXRFlags.None")] Texture2D.EXRFlags flags);

		// Token: 0x06000E85 RID: 3717 RVA: 0x000135F8 File Offset: 0x000117F8
		[ExcludeFromDocs]
		public byte[] EncodeToEXR()
		{
			Texture2D.EXRFlags flags = Texture2D.EXRFlags.None;
			return this.EncodeToEXR(flags);
		}

		// Token: 0x020000C7 RID: 199
		[Flags]
		public enum EXRFlags
		{
			// Token: 0x040001CC RID: 460
			None = 0,
			// Token: 0x040001CD RID: 461
			OutputAsFloat = 1,
			// Token: 0x040001CE RID: 462
			CompressZIP = 2,
			// Token: 0x040001CF RID: 463
			CompressRLE = 4,
			// Token: 0x040001D0 RID: 464
			CompressPIZ = 8
		}
	}
}
