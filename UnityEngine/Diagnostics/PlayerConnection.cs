using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Diagnostics
{
	// Token: 0x0200009D RID: 157
	public static class PlayerConnection
	{
		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000B51 RID: 2897
		public static extern bool connected { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000B52 RID: 2898
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SendFile(string remoteFilePath, byte[] data);
	}
}
