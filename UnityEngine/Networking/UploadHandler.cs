using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine.Networking
{
	// Token: 0x02000280 RID: 640
	[StructLayout(LayoutKind.Sequential)]
	public class UploadHandler : IDisposable
	{
		// Token: 0x06002B10 RID: 11024 RVA: 0x0003CC2C File Offset: 0x0003AE2C
		internal UploadHandler()
		{
		}

		// Token: 0x06002B11 RID: 11025
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalCreateRaw(byte[] data);

		// Token: 0x06002B12 RID: 11026
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InternalDestroy();

		// Token: 0x06002B13 RID: 11027 RVA: 0x0003CC38 File Offset: 0x0003AE38
		~UploadHandler()
		{
			this.InternalDestroy();
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x0003CC68 File Offset: 0x0003AE68
		public void Dispose()
		{
			this.InternalDestroy();
			GC.SuppressFinalize(this);
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06002B15 RID: 11029 RVA: 0x0003CC78 File Offset: 0x0003AE78
		public byte[] data
		{
			get
			{
				return this.GetData();
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06002B16 RID: 11030 RVA: 0x0003CC94 File Offset: 0x0003AE94
		// (set) Token: 0x06002B17 RID: 11031 RVA: 0x0003CCB0 File Offset: 0x0003AEB0
		public string contentType
		{
			get
			{
				return this.GetContentType();
			}
			set
			{
				this.SetContentType(value);
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06002B18 RID: 11032 RVA: 0x0003CCBC File Offset: 0x0003AEBC
		public float progress
		{
			get
			{
				return this.GetProgress();
			}
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x0003CCD8 File Offset: 0x0003AED8
		internal virtual byte[] GetData()
		{
			return null;
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x0003CCF0 File Offset: 0x0003AEF0
		internal virtual string GetContentType()
		{
			return "text/plain";
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x0003CD0C File Offset: 0x0003AF0C
		internal virtual void SetContentType(string newContentType)
		{
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x0003CD10 File Offset: 0x0003AF10
		internal virtual float GetProgress()
		{
			return 0.5f;
		}

		// Token: 0x0400085C RID: 2140
		[NonSerialized]
		internal IntPtr m_Ptr;
	}
}
