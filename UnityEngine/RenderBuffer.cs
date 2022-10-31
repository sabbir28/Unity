using System;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000338 RID: 824
	public struct RenderBuffer
	{
		// Token: 0x060030FC RID: 12540 RVA: 0x0004A7B8 File Offset: 0x000489B8
		internal void SetLoadAction(RenderBufferLoadAction action)
		{
			RenderBufferHelper.SetLoadAction(out this, (int)action);
		}

		// Token: 0x060030FD RID: 12541 RVA: 0x0004A7C4 File Offset: 0x000489C4
		internal void SetStoreAction(RenderBufferStoreAction action)
		{
			RenderBufferHelper.SetStoreAction(out this, (int)action);
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x060030FE RID: 12542 RVA: 0x0004A7D0 File Offset: 0x000489D0
		// (set) Token: 0x060030FF RID: 12543 RVA: 0x0004A7EC File Offset: 0x000489EC
		internal RenderBufferLoadAction loadAction
		{
			get
			{
				return (RenderBufferLoadAction)RenderBufferHelper.GetLoadAction(out this);
			}
			set
			{
				this.SetLoadAction(value);
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06003100 RID: 12544 RVA: 0x0004A7F8 File Offset: 0x000489F8
		// (set) Token: 0x06003101 RID: 12545 RVA: 0x0004A814 File Offset: 0x00048A14
		internal RenderBufferStoreAction storeAction
		{
			get
			{
				return (RenderBufferStoreAction)RenderBufferHelper.GetStoreAction(out this);
			}
			set
			{
				this.SetStoreAction(value);
			}
		}

		// Token: 0x06003102 RID: 12546 RVA: 0x0004A820 File Offset: 0x00048A20
		public IntPtr GetNativeRenderBufferPtr()
		{
			return RenderBufferHelper.GetNativeRenderBufferPtr(this.m_BufferPtr);
		}

		// Token: 0x04000A97 RID: 2711
		internal int m_RenderTextureInstanceID;

		// Token: 0x04000A98 RID: 2712
		internal IntPtr m_BufferPtr;
	}
}
