using System;

namespace UnityEngine
{
	// Token: 0x0200041C RID: 1052
	public interface ILogHandler
	{
		// Token: 0x06003492 RID: 13458
		void LogFormat(LogType logType, Object context, string format, params object[] args);

		// Token: 0x06003493 RID: 13459
		void LogException(Exception exception, Object context);
	}
}
