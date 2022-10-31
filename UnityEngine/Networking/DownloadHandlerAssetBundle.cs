using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine.Networking
{
	// Token: 0x02000286 RID: 646
	[StructLayout(LayoutKind.Sequential)]
	public sealed class DownloadHandlerAssetBundle : DownloadHandler
	{
		// Token: 0x06002B4B RID: 11083 RVA: 0x0003D0E8 File Offset: 0x0003B2E8
		public DownloadHandlerAssetBundle(string url, uint crc)
		{
			base.InternalCreateAssetBundle(url, crc);
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x0003D0FC File Offset: 0x0003B2FC
		public DownloadHandlerAssetBundle(string url, uint version, uint crc)
		{
			Hash128 hash = new Hash128(0U, 0U, 0U, version);
			base.InternalCreateAssetBundle(url, hash, crc);
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x0003D124 File Offset: 0x0003B324
		public DownloadHandlerAssetBundle(string url, Hash128 hash, uint crc)
		{
			base.InternalCreateAssetBundle(url, hash, crc);
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x0003D138 File Offset: 0x0003B338
		protected override byte[] GetData()
		{
			throw new NotSupportedException("Raw data access is not supported for asset bundles");
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x0003D148 File Offset: 0x0003B348
		protected override string GetText()
		{
			throw new NotSupportedException("String access is not supported for asset bundles");
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06002B50 RID: 11088
		public extern AssetBundle assetBundle { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002B51 RID: 11089 RVA: 0x0003D158 File Offset: 0x0003B358
		public static AssetBundle GetContent(UnityWebRequest www)
		{
			return DownloadHandler.GetCheckedDownloader<DownloadHandlerAssetBundle>(www).assetBundle;
		}
	}
}
