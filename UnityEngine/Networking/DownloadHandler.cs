using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine.Scripting;

namespace UnityEngine.Networking
{
	// Token: 0x02000282 RID: 642
	[StructLayout(LayoutKind.Sequential)]
	public class DownloadHandler : IDisposable
	{
		// Token: 0x06002B26 RID: 11046 RVA: 0x0003CD9C File Offset: 0x0003AF9C
		internal DownloadHandler()
		{
		}

		// Token: 0x06002B27 RID: 11047
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalCreateBuffer();

		// Token: 0x06002B28 RID: 11048
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalCreateScript();

		// Token: 0x06002B29 RID: 11049
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalCreateTexture(bool readable);

		// Token: 0x06002B2A RID: 11050
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalCreateAssetBundle(string url, uint crc);

		// Token: 0x06002B2B RID: 11051 RVA: 0x0003CDA8 File Offset: 0x0003AFA8
		internal void InternalCreateAssetBundle(string url, Hash128 hash, uint crc)
		{
			DownloadHandler.INTERNAL_CALL_InternalCreateAssetBundle(this, url, ref hash, crc);
		}

		// Token: 0x06002B2C RID: 11052
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_InternalCreateAssetBundle(DownloadHandler self, string url, ref Hash128 hash, uint crc);

		// Token: 0x06002B2D RID: 11053
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InternalDestroy();

		// Token: 0x06002B2E RID: 11054 RVA: 0x0003CDB8 File Offset: 0x0003AFB8
		~DownloadHandler()
		{
			this.InternalDestroy();
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x0003CDE8 File Offset: 0x0003AFE8
		public void Dispose()
		{
			this.InternalDestroy();
			GC.SuppressFinalize(this);
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06002B30 RID: 11056
		public extern bool isDone { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06002B31 RID: 11057 RVA: 0x0003CDF8 File Offset: 0x0003AFF8
		public byte[] data
		{
			get
			{
				return this.GetData();
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06002B32 RID: 11058 RVA: 0x0003CE14 File Offset: 0x0003B014
		public string text
		{
			get
			{
				return this.GetText();
			}
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x0003CE30 File Offset: 0x0003B030
		protected virtual byte[] GetData()
		{
			return null;
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x0003CE48 File Offset: 0x0003B048
		protected virtual string GetText()
		{
			byte[] data = this.GetData();
			string result;
			if (data != null && data.Length > 0)
			{
				result = Encoding.UTF8.GetString(data, 0, data.Length);
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x0003CE90 File Offset: 0x0003B090
		[UsedByNativeCode]
		protected virtual bool ReceiveData(byte[] data, int dataLength)
		{
			return true;
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x0003CEA8 File Offset: 0x0003B0A8
		[UsedByNativeCode]
		protected virtual void ReceiveContentLength(int contentLength)
		{
		}

		// Token: 0x06002B37 RID: 11063 RVA: 0x0003CEAC File Offset: 0x0003B0AC
		[UsedByNativeCode]
		protected virtual void CompleteContent()
		{
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x0003CEB0 File Offset: 0x0003B0B0
		[UsedByNativeCode]
		protected virtual float GetProgress()
		{
			return 0f;
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x0003CECC File Offset: 0x0003B0CC
		protected static T GetCheckedDownloader<T>(UnityWebRequest www) where T : DownloadHandler
		{
			if (www == null)
			{
				throw new NullReferenceException("Cannot get content from a null UnityWebRequest object");
			}
			if (!www.isDone)
			{
				throw new InvalidOperationException("Cannot get content from an unfinished UnityWebRequest object");
			}
			if (www.isError)
			{
				throw new InvalidOperationException(www.error);
			}
			return (T)((object)www.downloadHandler);
		}

		// Token: 0x0400085D RID: 2141
		[NonSerialized]
		internal IntPtr m_Ptr;
	}
}
