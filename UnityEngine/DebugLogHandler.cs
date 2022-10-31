using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000034 RID: 52
	internal sealed class DebugLogHandler : ILogHandler
	{
		// Token: 0x060003A8 RID: 936
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_Log(LogType level, string msg, [Writable] Object obj);

		// Token: 0x060003A9 RID: 937
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_LogException(Exception exception, [Writable] Object obj);

		// Token: 0x060003AA RID: 938 RVA: 0x0000653C File Offset: 0x0000473C
		public void LogFormat(LogType logType, Object context, string format, params object[] args)
		{
			DebugLogHandler.Internal_Log(logType, string.Format(format, args), context);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00006550 File Offset: 0x00004750
		public void LogException(Exception exception, Object context)
		{
			DebugLogHandler.Internal_LogException(exception, context);
		}
	}
}
