using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000CA RID: 202
	public sealed class Texture2DArray : Texture
	{
		// Token: 0x06000EA6 RID: 3750 RVA: 0x000137A4 File Offset: 0x000119A4
		public Texture2DArray(int width, int height, int depth, TextureFormat format, bool mipmap)
		{
			Texture2DArray.Internal_Create(this, width, height, depth, format, mipmap, false);
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x000137BC File Offset: 0x000119BC
		public Texture2DArray(int width, int height, int depth, TextureFormat format, bool mipmap, bool linear)
		{
			Texture2DArray.Internal_Create(this, width, height, depth, format, mipmap, linear);
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000EA8 RID: 3752
		public extern int depth { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000EA9 RID: 3753
		public extern TextureFormat format { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000EAA RID: 3754
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Apply([DefaultValue("true")] bool updateMipmaps, [DefaultValue("false")] bool makeNoLongerReadable);

		// Token: 0x06000EAB RID: 3755 RVA: 0x000137D4 File Offset: 0x000119D4
		[ExcludeFromDocs]
		public void Apply(bool updateMipmaps)
		{
			bool makeNoLongerReadable = false;
			this.Apply(updateMipmaps, makeNoLongerReadable);
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x000137EC File Offset: 0x000119EC
		[ExcludeFromDocs]
		public void Apply()
		{
			bool makeNoLongerReadable = false;
			bool updateMipmaps = true;
			this.Apply(updateMipmaps, makeNoLongerReadable);
		}

		// Token: 0x06000EAD RID: 3757
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Create([Writable] Texture2DArray mono, int width, int height, int depth, TextureFormat format, bool mipmap, bool linear);

		// Token: 0x06000EAE RID: 3758
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetPixels(Color[] colors, int arrayElement, [DefaultValue("0")] int miplevel);

		// Token: 0x06000EAF RID: 3759 RVA: 0x00013808 File Offset: 0x00011A08
		[ExcludeFromDocs]
		public void SetPixels(Color[] colors, int arrayElement)
		{
			int miplevel = 0;
			this.SetPixels(colors, arrayElement, miplevel);
		}

		// Token: 0x06000EB0 RID: 3760
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetPixels32(Color32[] colors, int arrayElement, [DefaultValue("0")] int miplevel);

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00013824 File Offset: 0x00011A24
		[ExcludeFromDocs]
		public void SetPixels32(Color32[] colors, int arrayElement)
		{
			int miplevel = 0;
			this.SetPixels32(colors, arrayElement, miplevel);
		}

		// Token: 0x06000EB2 RID: 3762
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color[] GetPixels(int arrayElement, [DefaultValue("0")] int miplevel);

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00013840 File Offset: 0x00011A40
		[ExcludeFromDocs]
		public Color[] GetPixels(int arrayElement)
		{
			int miplevel = 0;
			return this.GetPixels(arrayElement, miplevel);
		}

		// Token: 0x06000EB4 RID: 3764
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color32[] GetPixels32(int arrayElement, [DefaultValue("0")] int miplevel);

		// Token: 0x06000EB5 RID: 3765 RVA: 0x00013860 File Offset: 0x00011A60
		[ExcludeFromDocs]
		public Color32[] GetPixels32(int arrayElement)
		{
			int miplevel = 0;
			return this.GetPixels32(arrayElement, miplevel);
		}
	}
}
