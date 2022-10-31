using System;

namespace UnityEngine
{
	// Token: 0x0200041D RID: 1053
	public class Logger : ILogger, ILogHandler
	{
		// Token: 0x06003494 RID: 13460 RVA: 0x00052EF4 File Offset: 0x000510F4
		private Logger()
		{
		}

		// Token: 0x06003495 RID: 13461 RVA: 0x00052F00 File Offset: 0x00051100
		public Logger(ILogHandler logHandler)
		{
			this.logHandler = logHandler;
			this.logEnabled = true;
			this.filterLogType = LogType.Log;
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06003496 RID: 13462 RVA: 0x00052F20 File Offset: 0x00051120
		// (set) Token: 0x06003497 RID: 13463 RVA: 0x00052F3C File Offset: 0x0005113C
		public ILogHandler logHandler { get; set; }

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06003498 RID: 13464 RVA: 0x00052F48 File Offset: 0x00051148
		// (set) Token: 0x06003499 RID: 13465 RVA: 0x00052F64 File Offset: 0x00051164
		public bool logEnabled { get; set; }

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x0600349A RID: 13466 RVA: 0x00052F70 File Offset: 0x00051170
		// (set) Token: 0x0600349B RID: 13467 RVA: 0x00052F8C File Offset: 0x0005118C
		public LogType filterLogType { get; set; }

		// Token: 0x0600349C RID: 13468 RVA: 0x00052F98 File Offset: 0x00051198
		public bool IsLogTypeAllowed(LogType logType)
		{
			return this.logEnabled && (logType <= this.filterLogType || logType == LogType.Exception);
		}

		// Token: 0x0600349D RID: 13469 RVA: 0x00052FD4 File Offset: 0x000511D4
		private static string GetString(object message)
		{
			return (message == null) ? "Null" : message.ToString();
		}

		// Token: 0x0600349E RID: 13470 RVA: 0x00053000 File Offset: 0x00051200
		public void Log(LogType logType, object message)
		{
			if (this.IsLogTypeAllowed(logType))
			{
				this.logHandler.LogFormat(logType, null, "{0}", new object[]
				{
					Logger.GetString(message)
				});
			}
		}

		// Token: 0x0600349F RID: 13471 RVA: 0x00053030 File Offset: 0x00051230
		public void Log(LogType logType, object message, Object context)
		{
			if (this.IsLogTypeAllowed(logType))
			{
				this.logHandler.LogFormat(logType, context, "{0}", new object[]
				{
					Logger.GetString(message)
				});
			}
		}

		// Token: 0x060034A0 RID: 13472 RVA: 0x00053060 File Offset: 0x00051260
		public void Log(LogType logType, string tag, object message)
		{
			if (this.IsLogTypeAllowed(logType))
			{
				this.logHandler.LogFormat(logType, null, "{0}: {1}", new object[]
				{
					tag,
					Logger.GetString(message)
				});
			}
		}

		// Token: 0x060034A1 RID: 13473 RVA: 0x00053094 File Offset: 0x00051294
		public void Log(LogType logType, string tag, object message, Object context)
		{
			if (this.IsLogTypeAllowed(logType))
			{
				this.logHandler.LogFormat(logType, context, "{0}: {1}", new object[]
				{
					tag,
					Logger.GetString(message)
				});
			}
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x000530CC File Offset: 0x000512CC
		public void Log(object message)
		{
			if (this.IsLogTypeAllowed(LogType.Log))
			{
				this.logHandler.LogFormat(LogType.Log, null, "{0}", new object[]
				{
					Logger.GetString(message)
				});
			}
		}

		// Token: 0x060034A3 RID: 13475 RVA: 0x000530FC File Offset: 0x000512FC
		public void Log(string tag, object message)
		{
			if (this.IsLogTypeAllowed(LogType.Log))
			{
				this.logHandler.LogFormat(LogType.Log, null, "{0}: {1}", new object[]
				{
					tag,
					Logger.GetString(message)
				});
			}
		}

		// Token: 0x060034A4 RID: 13476 RVA: 0x00053130 File Offset: 0x00051330
		public void Log(string tag, object message, Object context)
		{
			if (this.IsLogTypeAllowed(LogType.Log))
			{
				this.logHandler.LogFormat(LogType.Log, context, "{0}: {1}", new object[]
				{
					tag,
					Logger.GetString(message)
				});
			}
		}

		// Token: 0x060034A5 RID: 13477 RVA: 0x00053164 File Offset: 0x00051364
		public void LogWarning(string tag, object message)
		{
			if (this.IsLogTypeAllowed(LogType.Warning))
			{
				this.logHandler.LogFormat(LogType.Warning, null, "{0}: {1}", new object[]
				{
					tag,
					Logger.GetString(message)
				});
			}
		}

		// Token: 0x060034A6 RID: 13478 RVA: 0x00053198 File Offset: 0x00051398
		public void LogWarning(string tag, object message, Object context)
		{
			if (this.IsLogTypeAllowed(LogType.Warning))
			{
				this.logHandler.LogFormat(LogType.Warning, context, "{0}: {1}", new object[]
				{
					tag,
					Logger.GetString(message)
				});
			}
		}

		// Token: 0x060034A7 RID: 13479 RVA: 0x000531CC File Offset: 0x000513CC
		public void LogError(string tag, object message)
		{
			if (this.IsLogTypeAllowed(LogType.Error))
			{
				this.logHandler.LogFormat(LogType.Error, null, "{0}: {1}", new object[]
				{
					tag,
					Logger.GetString(message)
				});
			}
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x00053200 File Offset: 0x00051400
		public void LogError(string tag, object message, Object context)
		{
			if (this.IsLogTypeAllowed(LogType.Error))
			{
				this.logHandler.LogFormat(LogType.Error, context, "{0}: {1}", new object[]
				{
					tag,
					Logger.GetString(message)
				});
			}
		}

		// Token: 0x060034A9 RID: 13481 RVA: 0x00053234 File Offset: 0x00051434
		public void LogFormat(LogType logType, string format, params object[] args)
		{
			if (this.IsLogTypeAllowed(logType))
			{
				this.logHandler.LogFormat(logType, null, format, args);
			}
		}

		// Token: 0x060034AA RID: 13482 RVA: 0x00053254 File Offset: 0x00051454
		public void LogException(Exception exception)
		{
			if (this.logEnabled)
			{
				this.logHandler.LogException(exception, null);
			}
		}

		// Token: 0x060034AB RID: 13483 RVA: 0x00053270 File Offset: 0x00051470
		public void LogFormat(LogType logType, Object context, string format, params object[] args)
		{
			if (this.IsLogTypeAllowed(logType))
			{
				this.logHandler.LogFormat(logType, context, format, args);
			}
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x00053290 File Offset: 0x00051490
		public void LogException(Exception exception, Object context)
		{
			if (this.logEnabled)
			{
				this.logHandler.LogException(exception, context);
			}
		}

		// Token: 0x04000F20 RID: 3872
		private const string kNoTagFormat = "{0}";

		// Token: 0x04000F21 RID: 3873
		private const string kTagFormat = "{0}: {1}";
	}
}
