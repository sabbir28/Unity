using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	public sealed class Application
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000FD RID: 253 RVA: 0x000041E4 File Offset: 0x000023E4
		// (remove) Token: 0x060000FE RID: 254 RVA: 0x00004218 File Offset: 0x00002418
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Application.LowMemoryCallback lowMemory;

		// Token: 0x060000FF RID: 255 RVA: 0x0000424C File Offset: 0x0000244C
		[RequiredByNativeCode]
		private static void CallLowMemory()
		{
			Application.LowMemoryCallback lowMemoryCallback = Application.lowMemory;
			if (lowMemoryCallback != null)
			{
				lowMemoryCallback();
			}
		}

		// Token: 0x06000100 RID: 256
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Quit();

		// Token: 0x06000101 RID: 257
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CancelQuit();

		// Token: 0x06000102 RID: 258
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Unload();

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000103 RID: 259
		[Obsolete("This property is deprecated, please use LoadLevelAsync to detect if a specific scene is currently loading.")]
		public static extern bool isLoadingLevel { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000104 RID: 260
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float GetStreamProgressForLevelByName(string levelName);

		// Token: 0x06000105 RID: 261
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetStreamProgressForLevel(int levelIndex);

		// Token: 0x06000106 RID: 262 RVA: 0x0000426C File Offset: 0x0000246C
		public static float GetStreamProgressForLevel(string levelName)
		{
			return Application.GetStreamProgressForLevelByName(levelName);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000107 RID: 263
		public static extern int streamedBytes { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000108 RID: 264
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool CanStreamedLevelBeLoadedByName(string levelName);

		// Token: 0x06000109 RID: 265
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool CanStreamedLevelBeLoaded(int levelIndex);

		// Token: 0x0600010A RID: 266 RVA: 0x00004288 File Offset: 0x00002488
		public static bool CanStreamedLevelBeLoaded(string levelName)
		{
			return Application.CanStreamedLevelBeLoadedByName(levelName);
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600010B RID: 267
		public static extern bool isPlaying { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600010C RID: 268
		public static extern bool isFocused { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600010D RID: 269
		public static extern bool isEditor { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600010E RID: 270
		public static extern bool isWebPlayer { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600010F RID: 271
		[ThreadAndSerializationSafe]
		public static extern RuntimePlatform platform { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000110 RID: 272
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string[] GetBuildTags();

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000111 RID: 273
		public static extern string buildGUID { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000112 RID: 274 RVA: 0x000042A4 File Offset: 0x000024A4
		public static bool isMobilePlatform
		{
			get
			{
				RuntimePlatform platform = Application.platform;
				switch (platform)
				{
				case RuntimePlatform.MetroPlayerX86:
				case RuntimePlatform.MetroPlayerX64:
				case RuntimePlatform.MetroPlayerARM:
				case RuntimePlatform.TizenPlayer:
					break;
				default:
					switch (platform)
					{
					case RuntimePlatform.IPhonePlayer:
					case RuntimePlatform.Android:
						goto IL_45;
					}
					return false;
				}
				IL_45:
				return true;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00004308 File Offset: 0x00002508
		public static bool isConsolePlatform
		{
			get
			{
				RuntimePlatform platform = Application.platform;
				return platform == RuntimePlatform.PS4 || platform == RuntimePlatform.XboxOne;
			}
		}

		// Token: 0x06000114 RID: 276
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CaptureScreenshot(string filename, [DefaultValue("0")] int superSize);

		// Token: 0x06000115 RID: 277 RVA: 0x00004334 File Offset: 0x00002534
		[ExcludeFromDocs]
		public static void CaptureScreenshot(string filename)
		{
			int superSize = 0;
			Application.CaptureScreenshot(filename, superSize);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000116 RID: 278
		// (set) Token: 0x06000117 RID: 279
		public static extern bool runInBackground { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0000434C File Offset: 0x0000254C
		[Obsolete("use Application.isEditor instead")]
		public static bool isPlayer
		{
			get
			{
				return !Application.isEditor;
			}
		}

		// Token: 0x06000119 RID: 281
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasProLicense();

		// Token: 0x0600011A RID: 282
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool HasAdvancedLicense();

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600011B RID: 283
		internal static extern bool isBatchmode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600011C RID: 284
		internal static extern bool isTestRun { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600011D RID: 285
		internal static extern bool isHumanControllingUs { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600011E RID: 286
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool HasARGV(string name);

		// Token: 0x0600011F RID: 287
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string GetValueForARGV(string name);

		// Token: 0x06000120 RID: 288
		[Obsolete("Use Object.DontDestroyOnLoad instead")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DontDestroyOnLoad(Object mono);

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000121 RID: 289
		public static extern string dataPath { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000122 RID: 290
		public static extern string streamingAssetsPath { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000123 RID: 291
		[SecurityCritical]
		public static extern string persistentDataPath { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000124 RID: 292
		public static extern string temporaryCachePath { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000125 RID: 293
		public static extern string srcValue { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000126 RID: 294
		public static extern string absoluteURL { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000127 RID: 295 RVA: 0x0000436C File Offset: 0x0000256C
		private static string ObjectToJSString(object o)
		{
			string result;
			if (o == null)
			{
				result = "null";
			}
			else if (o is string)
			{
				string text = o.ToString().Replace("\\", "\\\\");
				text = text.Replace("\"", "\\\"");
				text = text.Replace("\n", "\\n");
				text = text.Replace("\r", "\\r");
				text = text.Replace("\0", "");
				text = text.Replace("\u2028", "");
				text = text.Replace("\u2029", "");
				result = '"' + text + '"';
			}
			else if (o is int || o is short || o is uint || o is ushort || o is byte)
			{
				result = o.ToString();
			}
			else if (o is float)
			{
				NumberFormatInfo numberFormat = CultureInfo.InvariantCulture.NumberFormat;
				result = ((float)o).ToString(numberFormat);
			}
			else if (o is double)
			{
				NumberFormatInfo numberFormat2 = CultureInfo.InvariantCulture.NumberFormat;
				result = ((double)o).ToString(numberFormat2);
			}
			else if (o is char)
			{
				if ((char)o == '"')
				{
					result = "\"\\\"\"";
				}
				else
				{
					result = '"' + o.ToString() + '"';
				}
			}
			else if (o is IList)
			{
				IList list = (IList)o;
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("new Array(");
				int count = list.Count;
				for (int i = 0; i < count; i++)
				{
					if (i != 0)
					{
						stringBuilder.Append(", ");
					}
					stringBuilder.Append(Application.ObjectToJSString(list[i]));
				}
				stringBuilder.Append(")");
				result = stringBuilder.ToString();
			}
			else
			{
				result = Application.ObjectToJSString(o.ToString());
			}
			return result;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000045B4 File Offset: 0x000027B4
		public static void ExternalCall(string functionName, params object[] args)
		{
			Application.Internal_ExternalCall(Application.BuildInvocationForArguments(functionName, args));
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000045C4 File Offset: 0x000027C4
		private static string BuildInvocationForArguments(string functionName, params object[] args)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(functionName);
			stringBuilder.Append('(');
			int num = args.Length;
			for (int i = 0; i < num; i++)
			{
				if (i != 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(Application.ObjectToJSString(args[i]));
			}
			stringBuilder.Append(')');
			stringBuilder.Append(';');
			return stringBuilder.ToString();
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00004644 File Offset: 0x00002844
		public static void ExternalEval(string script)
		{
			if (script.Length > 0 && script[script.Length - 1] != ';')
			{
				script += ';';
			}
			Application.Internal_ExternalCall(script);
		}

		// Token: 0x0600012B RID: 299
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ExternalCall(string script);

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600012C RID: 300
		public static extern string unityVersion { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600012D RID: 301
		public static extern string version { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600012E RID: 302
		public static extern string installerName { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600012F RID: 303
		public static extern string identifier { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000130 RID: 304
		public static extern ApplicationInstallMode installMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000131 RID: 305
		public static extern ApplicationSandboxType sandboxType { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000132 RID: 306
		public static extern string productName { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000133 RID: 307
		public static extern string companyName { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000134 RID: 308
		public static extern string cloudProjectId { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000135 RID: 309 RVA: 0x00004680 File Offset: 0x00002880
		internal static void InvokeOnAdvertisingIdentifierCallback(string advertisingId, bool trackingEnabled)
		{
			if (Application.OnAdvertisingIdentifierCallback != null)
			{
				Application.OnAdvertisingIdentifierCallback(advertisingId, trackingEnabled, string.Empty);
			}
		}

		// Token: 0x06000136 RID: 310
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool RequestAdvertisingIdentifierAsync(Application.AdvertisingIdentifierCallback delegateMethod);

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000137 RID: 311
		[Obsolete("Application.webSecurityEnabled is no longer supported, since the Unity Web Player is no longer supported by Unity.")]
		[ThreadAndSerializationSafe]
		public static extern bool webSecurityEnabled { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000138 RID: 312
		[Obsolete("Application.webSecurityHostUrl is no longer supported, since the Unity Web Player is no longer supported by Unity.")]
		[ThreadAndSerializationSafe]
		public static extern string webSecurityHostUrl { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000139 RID: 313
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void OpenURL(string url);

		// Token: 0x0600013A RID: 314
		[Obsolete("For internal use only")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ForceCrash(int mode);

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600013B RID: 315
		// (set) Token: 0x0600013C RID: 316
		public static extern int targetFrameRate { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600013D RID: 317
		public static extern SystemLanguage systemLanguage { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600013E RID: 318 RVA: 0x000046A0 File Offset: 0x000028A0
		// (remove) Token: 0x0600013F RID: 319 RVA: 0x000046C0 File Offset: 0x000028C0
		public static event Application.LogCallback logMessageReceived
		{
			add
			{
				Application.s_LogCallbackHandler = (Application.LogCallback)Delegate.Combine(Application.s_LogCallbackHandler, value);
				Application.SetLogCallbackDefined(true);
			}
			remove
			{
				Application.s_LogCallbackHandler = (Application.LogCallback)Delegate.Remove(Application.s_LogCallbackHandler, value);
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000140 RID: 320 RVA: 0x000046D8 File Offset: 0x000028D8
		// (remove) Token: 0x06000141 RID: 321 RVA: 0x000046F8 File Offset: 0x000028F8
		public static event Application.LogCallback logMessageReceivedThreaded
		{
			add
			{
				Application.s_LogCallbackHandlerThreaded = (Application.LogCallback)Delegate.Combine(Application.s_LogCallbackHandlerThreaded, value);
				Application.SetLogCallbackDefined(true);
			}
			remove
			{
				Application.s_LogCallbackHandlerThreaded = (Application.LogCallback)Delegate.Remove(Application.s_LogCallbackHandlerThreaded, value);
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00004710 File Offset: 0x00002910
		[RequiredByNativeCode]
		private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread)
		{
			if (invokedOnMainThread)
			{
				Application.LogCallback logCallback = Application.s_LogCallbackHandler;
				if (logCallback != null)
				{
					logCallback(logString, stackTrace, type);
				}
			}
			Application.LogCallback logCallback2 = Application.s_LogCallbackHandlerThreaded;
			if (logCallback2 != null)
			{
				logCallback2(logString, stackTrace, type);
			}
		}

		// Token: 0x06000143 RID: 323
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetLogCallbackDefined(bool defined);

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000144 RID: 324
		// (set) Token: 0x06000145 RID: 325
		[Obsolete("Use SetStackTraceLogType/GetStackTraceLogType instead")]
		public static extern StackTraceLogType stackTraceLogType { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000146 RID: 326
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern StackTraceLogType GetStackTraceLogType(LogType logType);

		// Token: 0x06000147 RID: 327
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType);

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000148 RID: 328
		// (set) Token: 0x06000149 RID: 329
		public static extern ThreadPriority backgroundLoadingPriority { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600014A RID: 330
		public static extern NetworkReachability internetReachability { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600014B RID: 331
		public static extern bool genuine { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600014C RID: 332
		public static extern bool genuineCheckAvailable { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600014D RID: 333
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern AsyncOperation RequestUserAuthorization(UserAuthorization mode);

		// Token: 0x0600014E RID: 334
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasUserAuthorization(UserAuthorization mode);

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600014F RID: 335
		internal static extern bool submitAnalytics { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00004750 File Offset: 0x00002950
		[Obsolete("This property is deprecated, please use SplashScreen.isFinished instead")]
		public static bool isShowingSplashScreen
		{
			get
			{
				return !SplashScreen.isFinished;
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00004770 File Offset: 0x00002970
		[Obsolete("Application.RegisterLogCallback is deprecated. Use Application.logMessageReceived instead.")]
		public static void RegisterLogCallback(Application.LogCallback handler)
		{
			Application.RegisterLogCallback(handler, false);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000477C File Offset: 0x0000297C
		[Obsolete("Application.RegisterLogCallbackThreaded is deprecated. Use Application.logMessageReceivedThreaded instead.")]
		public static void RegisterLogCallbackThreaded(Application.LogCallback handler)
		{
			Application.RegisterLogCallback(handler, true);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00004788 File Offset: 0x00002988
		private static void RegisterLogCallback(Application.LogCallback handler, bool threaded)
		{
			if (Application.s_RegisterLogCallbackDeprecated != null)
			{
				Application.logMessageReceived -= Application.s_RegisterLogCallbackDeprecated;
				Application.logMessageReceivedThreaded -= Application.s_RegisterLogCallbackDeprecated;
			}
			Application.s_RegisterLogCallbackDeprecated = handler;
			if (handler != null)
			{
				if (threaded)
				{
					Application.logMessageReceivedThreaded += handler;
				}
				else
				{
					Application.logMessageReceived += handler;
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000154 RID: 340 RVA: 0x000047E4 File Offset: 0x000029E4
		[Obsolete("Use SceneManager.sceneCountInBuildSettings")]
		public static int levelCount
		{
			get
			{
				return SceneManager.sceneCountInBuildSettings;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00004800 File Offset: 0x00002A00
		[Obsolete("Use SceneManager to determine what scenes have been loaded")]
		public static int loadedLevel
		{
			get
			{
				return SceneManager.GetActiveScene().buildIndex;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00004824 File Offset: 0x00002A24
		[Obsolete("Use SceneManager to determine what scenes have been loaded")]
		public static string loadedLevelName
		{
			get
			{
				return SceneManager.GetActiveScene().name;
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00004848 File Offset: 0x00002A48
		[Obsolete("Use SceneManager.LoadScene")]
		public static void LoadLevel(int index)
		{
			SceneManager.LoadScene(index, LoadSceneMode.Single);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00004854 File Offset: 0x00002A54
		[Obsolete("Use SceneManager.LoadScene")]
		public static void LoadLevel(string name)
		{
			SceneManager.LoadScene(name, LoadSceneMode.Single);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00004860 File Offset: 0x00002A60
		[Obsolete("Use SceneManager.LoadScene")]
		public static void LoadLevelAdditive(int index)
		{
			SceneManager.LoadScene(index, LoadSceneMode.Additive);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000486C File Offset: 0x00002A6C
		[Obsolete("Use SceneManager.LoadScene")]
		public static void LoadLevelAdditive(string name)
		{
			SceneManager.LoadScene(name, LoadSceneMode.Additive);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00004878 File Offset: 0x00002A78
		[Obsolete("Use SceneManager.LoadSceneAsync")]
		public static AsyncOperation LoadLevelAsync(int index)
		{
			return SceneManager.LoadSceneAsync(index, LoadSceneMode.Single);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00004894 File Offset: 0x00002A94
		[Obsolete("Use SceneManager.LoadSceneAsync")]
		public static AsyncOperation LoadLevelAsync(string levelName)
		{
			return SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Single);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000048B0 File Offset: 0x00002AB0
		[Obsolete("Use SceneManager.LoadSceneAsync")]
		public static AsyncOperation LoadLevelAdditiveAsync(int index)
		{
			return SceneManager.LoadSceneAsync(index, LoadSceneMode.Additive);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000048CC File Offset: 0x00002ACC
		[Obsolete("Use SceneManager.LoadSceneAsync")]
		public static AsyncOperation LoadLevelAdditiveAsync(string levelName)
		{
			return SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000048E8 File Offset: 0x00002AE8
		[Obsolete("Use SceneManager.UnloadScene")]
		public static bool UnloadLevel(int index)
		{
			return SceneManager.UnloadScene(index);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00004904 File Offset: 0x00002B04
		[Obsolete("Use SceneManager.UnloadScene")]
		public static bool UnloadLevel(string scenePath)
		{
			return SceneManager.UnloadScene(scenePath);
		}

		// Token: 0x04000014 RID: 20
		internal static Application.AdvertisingIdentifierCallback OnAdvertisingIdentifierCallback;

		// Token: 0x04000015 RID: 21
		private static Application.LogCallback s_LogCallbackHandler;

		// Token: 0x04000016 RID: 22
		private static Application.LogCallback s_LogCallbackHandlerThreaded;

		// Token: 0x04000017 RID: 23
		private static volatile Application.LogCallback s_RegisterLogCallbackDeprecated;

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x06000162 RID: 354
		public delegate void AdvertisingIdentifierCallback(string advertisingId, bool trackingEnabled, string errorMsg);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000166 RID: 358
		public delegate void LowMemoryCallback();

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x0600016A RID: 362
		public delegate void LogCallback(string condition, string stackTrace, LogType type);
	}
}
