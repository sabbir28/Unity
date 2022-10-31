using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine.Networking
{
	// Token: 0x02000284 RID: 644
	[StructLayout(LayoutKind.Sequential)]
	public class DownloadHandlerScript : DownloadHandler
	{
		// Token: 0x06002B40 RID: 11072 RVA: 0x0003CF94 File Offset: 0x0003B194
		public DownloadHandlerScript()
		{
			base.InternalCreateScript();
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x0003CFA4 File Offset: 0x0003B1A4
		public DownloadHandlerScript(byte[] preallocatedBuffer)
		{
			if (preallocatedBuffer == null || preallocatedBuffer.Length < 1)
			{
				throw new ArgumentException("Cannot create a preallocated-buffer DownloadHandlerScript backed by a null or zero-length array");
			}
			base.InternalCreateScript();
			this.InternalSetPreallocatedBuffer(preallocatedBuffer);
		}

		// Token: 0x06002B42 RID: 11074
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InternalSetPreallocatedBuffer(byte[] buffer);
	}
}
