using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine.Networking
{
	// Token: 0x02000285 RID: 645
	[StructLayout(LayoutKind.Sequential)]
	public sealed class DownloadHandlerTexture : DownloadHandler
	{
		// Token: 0x06002B43 RID: 11075 RVA: 0x0003CFD8 File Offset: 0x0003B1D8
		public DownloadHandlerTexture()
		{
			base.InternalCreateTexture(true);
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x0003CFE8 File Offset: 0x0003B1E8
		public DownloadHandlerTexture(bool readable)
		{
			base.InternalCreateTexture(readable);
			this.mNonReadable = !readable;
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x0003D004 File Offset: 0x0003B204
		protected override byte[] GetData()
		{
			return this.InternalGetData();
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06002B46 RID: 11078 RVA: 0x0003D020 File Offset: 0x0003B220
		public Texture2D texture
		{
			get
			{
				return this.InternalGetTexture();
			}
		}

		// Token: 0x06002B47 RID: 11079 RVA: 0x0003D03C File Offset: 0x0003B23C
		private Texture2D InternalGetTexture()
		{
			if (this.mHasTexture)
			{
				if (this.mTexture == null)
				{
					this.mTexture = new Texture2D(2, 2);
					this.mTexture.LoadImage(this.GetData(), this.mNonReadable);
				}
			}
			else if (this.mTexture == null)
			{
				this.mTexture = this.InternalGetTextureNative();
				this.mHasTexture = true;
			}
			return this.mTexture;
		}

		// Token: 0x06002B48 RID: 11080
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Texture2D InternalGetTextureNative();

		// Token: 0x06002B49 RID: 11081
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern byte[] InternalGetData();

		// Token: 0x06002B4A RID: 11082 RVA: 0x0003D0C8 File Offset: 0x0003B2C8
		public static Texture2D GetContent(UnityWebRequest www)
		{
			return DownloadHandler.GetCheckedDownloader<DownloadHandlerTexture>(www).texture;
		}

		// Token: 0x0400085E RID: 2142
		private Texture2D mTexture;

		// Token: 0x0400085F RID: 2143
		private bool mHasTexture;

		// Token: 0x04000860 RID: 2144
		private bool mNonReadable;
	}
}
