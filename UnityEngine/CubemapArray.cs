using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000CB RID: 203
	public sealed class CubemapArray : Texture
	{
		// Token: 0x06000EB6 RID: 3766 RVA: 0x00013880 File Offset: 0x00011A80
		public CubemapArray(int faceSize, int cubemapCount, TextureFormat format, bool mipmap)
		{
			CubemapArray.Internal_Create(this, faceSize, cubemapCount, format, mipmap, false);
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x00013898 File Offset: 0x00011A98
		public CubemapArray(int faceSize, int cubemapCount, TextureFormat format, bool mipmap, bool linear)
		{
			CubemapArray.Internal_Create(this, faceSize, cubemapCount, format, mipmap, linear);
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000EB8 RID: 3768
		public extern int cubemapCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000EB9 RID: 3769
		public extern TextureFormat format { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000EBA RID: 3770
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Apply([DefaultValue("true")] bool updateMipmaps, [DefaultValue("false")] bool makeNoLongerReadable);

		// Token: 0x06000EBB RID: 3771 RVA: 0x000138B0 File Offset: 0x00011AB0
		[ExcludeFromDocs]
		public void Apply(bool updateMipmaps)
		{
			bool makeNoLongerReadable = false;
			this.Apply(updateMipmaps, makeNoLongerReadable);
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x000138C8 File Offset: 0x00011AC8
		[ExcludeFromDocs]
		public void Apply()
		{
			bool makeNoLongerReadable = false;
			bool updateMipmaps = true;
			this.Apply(updateMipmaps, makeNoLongerReadable);
		}

		// Token: 0x06000EBD RID: 3773
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Create([Writable] CubemapArray mono, int faceSize, int cubemapCount, TextureFormat format, bool mipmap, bool linear);

		// Token: 0x06000EBE RID: 3774
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetPixels(Color[] colors, CubemapFace face, int arrayElement, [DefaultValue("0")] int miplevel);

		// Token: 0x06000EBF RID: 3775 RVA: 0x000138E4 File Offset: 0x00011AE4
		[ExcludeFromDocs]
		public void SetPixels(Color[] colors, CubemapFace face, int arrayElement)
		{
			int miplevel = 0;
			this.SetPixels(colors, face, arrayElement, miplevel);
		}

		// Token: 0x06000EC0 RID: 3776
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetPixels32(Color32[] colors, CubemapFace face, int arrayElement, [DefaultValue("0")] int miplevel);

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00013900 File Offset: 0x00011B00
		[ExcludeFromDocs]
		public void SetPixels32(Color32[] colors, CubemapFace face, int arrayElement)
		{
			int miplevel = 0;
			this.SetPixels32(colors, face, arrayElement, miplevel);
		}

		// Token: 0x06000EC2 RID: 3778
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color[] GetPixels(CubemapFace face, int arrayElement, [DefaultValue("0")] int miplevel);

		// Token: 0x06000EC3 RID: 3779 RVA: 0x0001391C File Offset: 0x00011B1C
		[ExcludeFromDocs]
		public Color[] GetPixels(CubemapFace face, int arrayElement)
		{
			int miplevel = 0;
			return this.GetPixels(face, arrayElement, miplevel);
		}

		// Token: 0x06000EC4 RID: 3780
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color32[] GetPixels32(CubemapFace face, int arrayElement, [DefaultValue("0")] int miplevel);

		// Token: 0x06000EC5 RID: 3781 RVA: 0x0001393C File Offset: 0x00011B3C
		[ExcludeFromDocs]
		public Color32[] GetPixels32(CubemapFace face, int arrayElement)
		{
			int miplevel = 0;
			return this.GetPixels32(face, arrayElement, miplevel);
		}
	}
}
