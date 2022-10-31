using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine.Networking
{
	// Token: 0x02000281 RID: 641
	[StructLayout(LayoutKind.Sequential)]
	public sealed class UploadHandlerRaw : UploadHandler
	{
		// Token: 0x06002B1D RID: 11037 RVA: 0x0003CD2C File Offset: 0x0003AF2C
		public UploadHandlerRaw(byte[] data)
		{
			base.InternalCreateRaw(data);
		}

		// Token: 0x06002B1E RID: 11038
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern string InternalGetContentType();

		// Token: 0x06002B1F RID: 11039
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InternalSetContentType(string newContentType);

		// Token: 0x06002B20 RID: 11040
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern byte[] InternalGetData();

		// Token: 0x06002B21 RID: 11041
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern float InternalGetProgress();

		// Token: 0x06002B22 RID: 11042 RVA: 0x0003CD3C File Offset: 0x0003AF3C
		internal override string GetContentType()
		{
			return this.InternalGetContentType();
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x0003CD58 File Offset: 0x0003AF58
		internal override void SetContentType(string newContentType)
		{
			this.InternalSetContentType(newContentType);
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x0003CD64 File Offset: 0x0003AF64
		internal override byte[] GetData()
		{
			return this.InternalGetData();
		}

		// Token: 0x06002B25 RID: 11045 RVA: 0x0003CD80 File Offset: 0x0003AF80
		internal override float GetProgress()
		{
			return this.InternalGetProgress();
		}
	}
}
