using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.CrashReportHandler
{
	// Token: 0x020002C2 RID: 706
	public static class CrashReportHandler
	{
		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06002DF0 RID: 11760
		// (set) Token: 0x06002DF1 RID: 11761
		[ThreadAndSerializationSafe]
		public static extern bool enableCaptureExceptions { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
