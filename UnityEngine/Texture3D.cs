using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000C9 RID: 201
	public sealed class Texture3D : Texture
	{
		// Token: 0x06000E97 RID: 3735 RVA: 0x000136E8 File Offset: 0x000118E8
		public Texture3D(int width, int height, int depth, TextureFormat format, bool mipmap)
		{
			Texture3D.Internal_Create(this, width, height, depth, format, mipmap);
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000E98 RID: 3736
		public extern int depth { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000E99 RID: 3737
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color[] GetPixels([DefaultValue("0")] int miplevel);

		// Token: 0x06000E9A RID: 3738 RVA: 0x00013700 File Offset: 0x00011900
		[ExcludeFromDocs]
		public Color[] GetPixels()
		{
			int miplevel = 0;
			return this.GetPixels(miplevel);
		}

		// Token: 0x06000E9B RID: 3739
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color32[] GetPixels32([DefaultValue("0")] int miplevel);

		// Token: 0x06000E9C RID: 3740 RVA: 0x00013720 File Offset: 0x00011920
		[ExcludeFromDocs]
		public Color32[] GetPixels32()
		{
			int miplevel = 0;
			return this.GetPixels32(miplevel);
		}

		// Token: 0x06000E9D RID: 3741
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetPixels(Color[] colors, [DefaultValue("0")] int miplevel);

		// Token: 0x06000E9E RID: 3742 RVA: 0x00013740 File Offset: 0x00011940
		[ExcludeFromDocs]
		public void SetPixels(Color[] colors)
		{
			int miplevel = 0;
			this.SetPixels(colors, miplevel);
		}

		// Token: 0x06000E9F RID: 3743
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetPixels32(Color32[] colors, [DefaultValue("0")] int miplevel);

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00013758 File Offset: 0x00011958
		[ExcludeFromDocs]
		public void SetPixels32(Color32[] colors)
		{
			int miplevel = 0;
			this.SetPixels32(colors, miplevel);
		}

		// Token: 0x06000EA1 RID: 3745
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Apply([DefaultValue("true")] bool updateMipmaps, [DefaultValue("false")] bool makeNoLongerReadable);

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00013770 File Offset: 0x00011970
		[ExcludeFromDocs]
		public void Apply(bool updateMipmaps)
		{
			bool makeNoLongerReadable = false;
			this.Apply(updateMipmaps, makeNoLongerReadable);
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00013788 File Offset: 0x00011988
		[ExcludeFromDocs]
		public void Apply()
		{
			bool makeNoLongerReadable = false;
			bool updateMipmaps = true;
			this.Apply(updateMipmaps, makeNoLongerReadable);
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000EA4 RID: 3748
		public extern TextureFormat format { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000EA5 RID: 3749
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Create([Writable] Texture3D mono, int width, int height, int depth, TextureFormat format, bool mipmap);
	}
}
