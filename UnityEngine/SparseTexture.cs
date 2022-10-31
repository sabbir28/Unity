using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000CC RID: 204
	public sealed class SparseTexture : Texture
	{
		// Token: 0x06000EC6 RID: 3782 RVA: 0x0001395C File Offset: 0x00011B5C
		public SparseTexture(int width, int height, TextureFormat format, int mipCount)
		{
			SparseTexture.Internal_Create(this, width, height, format, mipCount, false);
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00013974 File Offset: 0x00011B74
		public SparseTexture(int width, int height, TextureFormat format, int mipCount, bool linear)
		{
			SparseTexture.Internal_Create(this, width, height, format, mipCount, linear);
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000EC8 RID: 3784
		public extern int tileWidth { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000EC9 RID: 3785
		public extern int tileHeight { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000ECA RID: 3786
		public extern bool isCreated { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000ECB RID: 3787
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Create([Writable] SparseTexture mono, int width, int height, TextureFormat format, int mipCount, bool linear);

		// Token: 0x06000ECC RID: 3788
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void UpdateTile(int tileX, int tileY, int miplevel, Color32[] data);

		// Token: 0x06000ECD RID: 3789
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void UpdateTileRaw(int tileX, int tileY, int miplevel, byte[] data);

		// Token: 0x06000ECE RID: 3790
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void UnloadTile(int tileX, int tileY, int miplevel);
	}
}
