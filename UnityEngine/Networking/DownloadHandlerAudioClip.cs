using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine.Networking
{
	// Token: 0x02000287 RID: 647
	[StructLayout(LayoutKind.Sequential)]
	public sealed class DownloadHandlerAudioClip : DownloadHandler
	{
		// Token: 0x06002B52 RID: 11090 RVA: 0x0003D178 File Offset: 0x0003B378
		[RequiredByNativeCode]
		public DownloadHandlerAudioClip(string url, AudioType audioType)
		{
			this.InternalCreateAudioClip(url, audioType);
		}

		// Token: 0x06002B53 RID: 11091
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalCreateAudioClip(string url, AudioType audioType);

		// Token: 0x06002B54 RID: 11092 RVA: 0x0003D18C File Offset: 0x0003B38C
		protected override byte[] GetData()
		{
			return this.InternalGetData();
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x0003D1A8 File Offset: 0x0003B3A8
		protected override string GetText()
		{
			throw new NotSupportedException("String access is not supported for audio clips");
		}

		// Token: 0x06002B56 RID: 11094
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern byte[] InternalGetData();

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06002B57 RID: 11095
		public extern AudioClip audioClip { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002B58 RID: 11096 RVA: 0x0003D1B8 File Offset: 0x0003B3B8
		public static AudioClip GetContent(UnityWebRequest www)
		{
			return DownloadHandler.GetCheckedDownloader<DownloadHandlerAudioClip>(www).audioClip;
		}
	}
}
