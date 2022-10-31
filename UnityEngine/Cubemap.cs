using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000C8 RID: 200
	public sealed class Cubemap : Texture
	{
		// Token: 0x06000E86 RID: 3718 RVA: 0x00013618 File Offset: 0x00011818
		public Cubemap(int size, TextureFormat format, bool mipmap)
		{
			Cubemap.Internal_Create(this, size, format, mipmap);
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x0001362C File Offset: 0x0001182C
		public void SetPixel(CubemapFace face, int x, int y, Color color)
		{
			Cubemap.INTERNAL_CALL_SetPixel(this, face, x, y, ref color);
		}

		// Token: 0x06000E88 RID: 3720
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetPixel(Cubemap self, CubemapFace face, int x, int y, ref Color color);

		// Token: 0x06000E89 RID: 3721 RVA: 0x0001363C File Offset: 0x0001183C
		public Color GetPixel(CubemapFace face, int x, int y)
		{
			Color result;
			Cubemap.INTERNAL_CALL_GetPixel(this, face, x, y, out result);
			return result;
		}

		// Token: 0x06000E8A RID: 3722
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetPixel(Cubemap self, CubemapFace face, int x, int y, out Color value);

		// Token: 0x06000E8B RID: 3723
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color[] GetPixels(CubemapFace face, [DefaultValue("0")] int miplevel);

		// Token: 0x06000E8C RID: 3724 RVA: 0x00013660 File Offset: 0x00011860
		[ExcludeFromDocs]
		public Color[] GetPixels(CubemapFace face)
		{
			int miplevel = 0;
			return this.GetPixels(face, miplevel);
		}

		// Token: 0x06000E8D RID: 3725
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetPixels(Color[] colors, CubemapFace face, [DefaultValue("0")] int miplevel);

		// Token: 0x06000E8E RID: 3726 RVA: 0x00013680 File Offset: 0x00011880
		[ExcludeFromDocs]
		public void SetPixels(Color[] colors, CubemapFace face)
		{
			int miplevel = 0;
			this.SetPixels(colors, face, miplevel);
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000E8F RID: 3727
		public extern int mipmapCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000E90 RID: 3728
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Apply([DefaultValue("true")] bool updateMipmaps, [DefaultValue("false")] bool makeNoLongerReadable);

		// Token: 0x06000E91 RID: 3729 RVA: 0x0001369C File Offset: 0x0001189C
		[ExcludeFromDocs]
		public void Apply(bool updateMipmaps)
		{
			bool makeNoLongerReadable = false;
			this.Apply(updateMipmaps, makeNoLongerReadable);
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x000136B4 File Offset: 0x000118B4
		[ExcludeFromDocs]
		public void Apply()
		{
			bool makeNoLongerReadable = false;
			bool updateMipmaps = true;
			this.Apply(updateMipmaps, makeNoLongerReadable);
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000E93 RID: 3731
		public extern TextureFormat format { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000E94 RID: 3732
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Create([Writable] Cubemap mono, int size, TextureFormat format, bool mipmap);

		// Token: 0x06000E95 RID: 3733
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SmoothEdges([DefaultValue("1")] int smoothRegionWidthInPixels);

		// Token: 0x06000E96 RID: 3734 RVA: 0x000136D0 File Offset: 0x000118D0
		[ExcludeFromDocs]
		public void SmoothEdges()
		{
			int smoothRegionWidthInPixels = 1;
			this.SmoothEdges(smoothRegionWidthInPixels);
		}
	}
}
