using System;

namespace UnityEngine
{
	// Token: 0x0200041B RID: 1051
	public interface ILogger : ILogHandler
	{
		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x0600347E RID: 13438
		// (set) Token: 0x0600347F RID: 13439
		ILogHandler logHandler { get; set; }

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06003480 RID: 13440
		// (set) Token: 0x06003481 RID: 13441
		bool logEnabled { get; set; }

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06003482 RID: 13442
		// (set) Token: 0x06003483 RID: 13443
		LogType filterLogType { get; set; }

		// Token: 0x06003484 RID: 13444
		bool IsLogTypeAllowed(LogType logType);

		// Token: 0x06003485 RID: 13445
		void Log(LogType logType, object message);

		// Token: 0x06003486 RID: 13446
		void Log(LogType logType, object message, Object context);

		// Token: 0x06003487 RID: 13447
		void Log(LogType logType, string tag, object message);

		// Token: 0x06003488 RID: 13448
		void Log(LogType logType, string tag, object message, Object context);

		// Token: 0x06003489 RID: 13449
		void Log(object message);

		// Token: 0x0600348A RID: 13450
		void Log(string tag, object message);

		// Token: 0x0600348B RID: 13451
		void Log(string tag, object message, Object context);

		// Token: 0x0600348C RID: 13452
		void LogWarning(string tag, object message);

		// Token: 0x0600348D RID: 13453
		void LogWarning(string tag, object message, Object context);

		// Token: 0x0600348E RID: 13454
		void LogError(string tag, object message);

		// Token: 0x0600348F RID: 13455
		void LogError(string tag, object message, Object context);

		// Token: 0x06003490 RID: 13456
		void LogFormat(LogType logType, string format, params object[] args);

		// Token: 0x06003491 RID: 13457
		void LogException(Exception exception);
	}
}
