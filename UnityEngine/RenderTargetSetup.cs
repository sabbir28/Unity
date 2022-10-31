using System;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000339 RID: 825
	public struct RenderTargetSetup
	{
		// Token: 0x06003103 RID: 12547 RVA: 0x0004A840 File Offset: 0x00048A40
		public RenderTargetSetup(RenderBuffer[] color, RenderBuffer depth, int mip, CubemapFace face, RenderBufferLoadAction[] colorLoad, RenderBufferStoreAction[] colorStore, RenderBufferLoadAction depthLoad, RenderBufferStoreAction depthStore)
		{
			this.color = color;
			this.depth = depth;
			this.mipLevel = mip;
			this.cubemapFace = face;
			this.depthSlice = 0;
			this.colorLoad = colorLoad;
			this.colorStore = colorStore;
			this.depthLoad = depthLoad;
			this.depthStore = depthStore;
		}

		// Token: 0x06003104 RID: 12548 RVA: 0x0004A894 File Offset: 0x00048A94
		public RenderTargetSetup(RenderBuffer color, RenderBuffer depth)
		{
			this = new RenderTargetSetup(new RenderBuffer[]
			{
				color
			}, depth);
		}

		// Token: 0x06003105 RID: 12549 RVA: 0x0004A8B4 File Offset: 0x00048AB4
		public RenderTargetSetup(RenderBuffer color, RenderBuffer depth, int mipLevel)
		{
			this = new RenderTargetSetup(new RenderBuffer[]
			{
				color
			}, depth, mipLevel);
		}

		// Token: 0x06003106 RID: 12550 RVA: 0x0004A8D4 File Offset: 0x00048AD4
		public RenderTargetSetup(RenderBuffer color, RenderBuffer depth, int mipLevel, CubemapFace face)
		{
			this = new RenderTargetSetup(new RenderBuffer[]
			{
				color
			}, depth, mipLevel, face);
		}

		// Token: 0x06003107 RID: 12551 RVA: 0x0004A8F4 File Offset: 0x00048AF4
		public RenderTargetSetup(RenderBuffer color, RenderBuffer depth, int mipLevel, CubemapFace face, int depthSlice)
		{
			this = new RenderTargetSetup(new RenderBuffer[]
			{
				color
			}, depth, mipLevel, face);
			this.depthSlice = depthSlice;
		}

		// Token: 0x06003108 RID: 12552 RVA: 0x0004A91C File Offset: 0x00048B1C
		public RenderTargetSetup(RenderBuffer[] color, RenderBuffer depth)
		{
			this = new RenderTargetSetup(color, depth, 0, CubemapFace.Unknown);
		}

		// Token: 0x06003109 RID: 12553 RVA: 0x0004A92C File Offset: 0x00048B2C
		public RenderTargetSetup(RenderBuffer[] color, RenderBuffer depth, int mipLevel)
		{
			this = new RenderTargetSetup(color, depth, mipLevel, CubemapFace.Unknown);
		}

		// Token: 0x0600310A RID: 12554 RVA: 0x0004A93C File Offset: 0x00048B3C
		public RenderTargetSetup(RenderBuffer[] color, RenderBuffer depth, int mip, CubemapFace face)
		{
			this = new RenderTargetSetup(color, depth, mip, face, RenderTargetSetup.LoadActions(color), RenderTargetSetup.StoreActions(color), depth.loadAction, depth.storeAction);
		}

		// Token: 0x0600310B RID: 12555 RVA: 0x0004A970 File Offset: 0x00048B70
		internal static RenderBufferLoadAction[] LoadActions(RenderBuffer[] buf)
		{
			RenderBufferLoadAction[] array = new RenderBufferLoadAction[buf.Length];
			for (int i = 0; i < buf.Length; i++)
			{
				array[i] = buf[i].loadAction;
				buf[i].loadAction = RenderBufferLoadAction.Load;
			}
			return array;
		}

		// Token: 0x0600310C RID: 12556 RVA: 0x0004A9C4 File Offset: 0x00048BC4
		internal static RenderBufferStoreAction[] StoreActions(RenderBuffer[] buf)
		{
			RenderBufferStoreAction[] array = new RenderBufferStoreAction[buf.Length];
			for (int i = 0; i < buf.Length; i++)
			{
				array[i] = buf[i].storeAction;
				buf[i].storeAction = RenderBufferStoreAction.Store;
			}
			return array;
		}

		// Token: 0x04000A99 RID: 2713
		public RenderBuffer[] color;

		// Token: 0x04000A9A RID: 2714
		public RenderBuffer depth;

		// Token: 0x04000A9B RID: 2715
		public int mipLevel;

		// Token: 0x04000A9C RID: 2716
		public CubemapFace cubemapFace;

		// Token: 0x04000A9D RID: 2717
		public int depthSlice;

		// Token: 0x04000A9E RID: 2718
		public RenderBufferLoadAction[] colorLoad;

		// Token: 0x04000A9F RID: 2719
		public RenderBufferStoreAction[] colorStore;

		// Token: 0x04000AA0 RID: 2720
		public RenderBufferLoadAction depthLoad;

		// Token: 0x04000AA1 RID: 2721
		public RenderBufferStoreAction depthStore;
	}
}
