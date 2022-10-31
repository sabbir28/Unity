using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine.Networking
{
	// Token: 0x02000283 RID: 643
	[StructLayout(LayoutKind.Sequential)]
	public sealed class DownloadHandlerBuffer : DownloadHandler
	{
		// Token: 0x06002B3A RID: 11066 RVA: 0x0003CF2C File Offset: 0x0003B12C
		public DownloadHandlerBuffer()
		{
			base.InternalCreateBuffer();
		}

		// Token: 0x06002B3B RID: 11067 RVA: 0x0003CF3C File Offset: 0x0003B13C
		protected override byte[] GetData()
		{
			return this.InternalGetData();
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x0003CF58 File Offset: 0x0003B158
		protected override string GetText()
		{
			return this.InternalGetText();
		}

		// Token: 0x06002B3D RID: 11069
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern byte[] InternalGetData();

		// Token: 0x06002B3E RID: 11070
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern string InternalGetText();

		// Token: 0x06002B3F RID: 11071 RVA: 0x0003CF74 File Offset: 0x0003B174
		public static string GetContent(UnityWebRequest www)
		{
			return DownloadHandler.GetCheckedDownloader<DownloadHandlerBuffer>(www).text;
		}
	}
}
