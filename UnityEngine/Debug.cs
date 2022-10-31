using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000035 RID: 53
	public sealed class Debug
	{
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060003AD RID: 941 RVA: 0x00006564 File Offset: 0x00004764
		public static ILogger logger
		{
			get
			{
				return Debug.s_Logger;
			}
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00006580 File Offset: 0x00004780
		public static void DrawLine(Vector3 start, Vector3 end, [DefaultValue("Color.white")] Color color, [DefaultValue("0.0f")] float duration, [DefaultValue("true")] bool depthTest)
		{
			Debug.INTERNAL_CALL_DrawLine(ref start, ref end, ref color, duration, depthTest);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00006594 File Offset: 0x00004794
		[ExcludeFromDocs]
		public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
		{
			bool depthTest = true;
			Debug.INTERNAL_CALL_DrawLine(ref start, ref end, ref color, duration, depthTest);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x000065B4 File Offset: 0x000047B4
		[ExcludeFromDocs]
		public static void DrawLine(Vector3 start, Vector3 end, Color color)
		{
			bool depthTest = true;
			float duration = 0f;
			Debug.INTERNAL_CALL_DrawLine(ref start, ref end, ref color, duration, depthTest);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x000065D8 File Offset: 0x000047D8
		[ExcludeFromDocs]
		public static void DrawLine(Vector3 start, Vector3 end)
		{
			bool depthTest = true;
			float duration = 0f;
			Color white = Color.white;
			Debug.INTERNAL_CALL_DrawLine(ref start, ref end, ref white, duration, depthTest);
		}

		// Token: 0x060003B2 RID: 946
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DrawLine(ref Vector3 start, ref Vector3 end, ref Color color, float duration, bool depthTest);

		// Token: 0x060003B3 RID: 947 RVA: 0x00006604 File Offset: 0x00004804
		[ExcludeFromDocs]
		public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration)
		{
			bool depthTest = true;
			Debug.DrawRay(start, dir, color, duration, depthTest);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00006620 File Offset: 0x00004820
		[ExcludeFromDocs]
		public static void DrawRay(Vector3 start, Vector3 dir, Color color)
		{
			bool depthTest = true;
			float duration = 0f;
			Debug.DrawRay(start, dir, color, duration, depthTest);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00006640 File Offset: 0x00004840
		[ExcludeFromDocs]
		public static void DrawRay(Vector3 start, Vector3 dir)
		{
			bool depthTest = true;
			float duration = 0f;
			Color white = Color.white;
			Debug.DrawRay(start, dir, white, duration, depthTest);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00006668 File Offset: 0x00004868
		public static void DrawRay(Vector3 start, Vector3 dir, [DefaultValue("Color.white")] Color color, [DefaultValue("0.0f")] float duration, [DefaultValue("true")] bool depthTest)
		{
			Debug.DrawLine(start, start + dir, color, duration, depthTest);
		}

		// Token: 0x060003B7 RID: 951
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Break();

		// Token: 0x060003B8 RID: 952
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DebugBreak();

		// Token: 0x060003B9 RID: 953 RVA: 0x0000667C File Offset: 0x0000487C
		public static void Log(object message)
		{
			Debug.logger.Log(LogType.Log, message);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000668C File Offset: 0x0000488C
		public static void Log(object message, Object context)
		{
			Debug.logger.Log(LogType.Log, message, context);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000669C File Offset: 0x0000489C
		public static void LogFormat(string format, params object[] args)
		{
			Debug.logger.LogFormat(LogType.Log, format, args);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x000066AC File Offset: 0x000048AC
		public static void LogFormat(Object context, string format, params object[] args)
		{
			Debug.logger.LogFormat(LogType.Log, context, format, args);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x000066C0 File Offset: 0x000048C0
		public static void LogError(object message)
		{
			Debug.logger.Log(LogType.Error, message);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000066D0 File Offset: 0x000048D0
		public static void LogError(object message, Object context)
		{
			Debug.logger.Log(LogType.Error, message, context);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x000066E0 File Offset: 0x000048E0
		public static void LogErrorFormat(string format, params object[] args)
		{
			Debug.logger.LogFormat(LogType.Error, format, args);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x000066F0 File Offset: 0x000048F0
		public static void LogErrorFormat(Object context, string format, params object[] args)
		{
			Debug.logger.LogFormat(LogType.Error, context, format, args);
		}

		// Token: 0x060003C1 RID: 961
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearDeveloperConsole();

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060003C2 RID: 962
		// (set) Token: 0x060003C3 RID: 963
		public static extern bool developerConsoleVisible { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060003C4 RID: 964 RVA: 0x00006704 File Offset: 0x00004904
		public static void LogException(Exception exception)
		{
			Debug.logger.LogException(exception, null);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00006714 File Offset: 0x00004914
		public static void LogException(Exception exception, Object context)
		{
			Debug.logger.LogException(exception, context);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00006724 File Offset: 0x00004924
		public static void LogWarning(object message)
		{
			Debug.logger.Log(LogType.Warning, message);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00006734 File Offset: 0x00004934
		public static void LogWarning(object message, Object context)
		{
			Debug.logger.Log(LogType.Warning, message, context);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00006744 File Offset: 0x00004944
		public static void LogWarningFormat(string format, params object[] args)
		{
			Debug.logger.LogFormat(LogType.Warning, format, args);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00006754 File Offset: 0x00004954
		public static void LogWarningFormat(Object context, string format, params object[] args)
		{
			Debug.logger.LogFormat(LogType.Warning, context, format, args);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00006768 File Offset: 0x00004968
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition)
		{
			if (!condition)
			{
				Debug.logger.Log(LogType.Assert, "Assertion failed");
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00006784 File Offset: 0x00004984
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, Object context)
		{
			if (!condition)
			{
				Debug.logger.Log(LogType.Assert, "Assertion failed", context);
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x000067A0 File Offset: 0x000049A0
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, object message)
		{
			if (!condition)
			{
				Debug.logger.Log(LogType.Assert, message);
			}
		}

		// Token: 0x060003CD RID: 973 RVA: 0x000067B8 File Offset: 0x000049B8
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, string message)
		{
			if (!condition)
			{
				Debug.logger.Log(LogType.Assert, message);
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x000067D0 File Offset: 0x000049D0
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, object message, Object context)
		{
			if (!condition)
			{
				Debug.logger.Log(LogType.Assert, message, context);
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x000067E8 File Offset: 0x000049E8
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, string message, Object context)
		{
			if (!condition)
			{
				Debug.logger.Log(LogType.Assert, message, context);
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00006800 File Offset: 0x00004A00
		[Conditional("UNITY_ASSERTIONS")]
		public static void AssertFormat(bool condition, string format, params object[] args)
		{
			if (!condition)
			{
				Debug.logger.LogFormat(LogType.Assert, format, args);
			}
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00006818 File Offset: 0x00004A18
		[Conditional("UNITY_ASSERTIONS")]
		public static void AssertFormat(bool condition, Object context, string format, params object[] args)
		{
			if (!condition)
			{
				Debug.logger.LogFormat(LogType.Assert, context, format, args);
			}
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00006830 File Offset: 0x00004A30
		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertion(object message)
		{
			Debug.logger.Log(LogType.Assert, message);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00006840 File Offset: 0x00004A40
		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertion(object message, Object context)
		{
			Debug.logger.Log(LogType.Assert, message, context);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00006850 File Offset: 0x00004A50
		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertionFormat(string format, params object[] args)
		{
			Debug.logger.LogFormat(LogType.Assert, format, args);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00006860 File Offset: 0x00004A60
		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertionFormat(Object context, string format, params object[] args)
		{
			Debug.logger.LogFormat(LogType.Assert, context, format, args);
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060003D6 RID: 982
		public static extern bool isDebugBuild { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060003D7 RID: 983
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void OpenConsoleFile();

		// Token: 0x060003D8 RID: 984
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void GetDiagnosticSwitches(List<DiagnosticSwitch> results);

		// Token: 0x060003D9 RID: 985
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void SetDiagnosticSwitch(string name, object value, bool setPersistent);

		// Token: 0x060003DA RID: 986 RVA: 0x00006874 File Offset: 0x00004A74
		[Obsolete("Assert(bool, string, params object[]) is obsolete. Use AssertFormat(bool, string, params object[]) (UnityUpgradable) -> AssertFormat(*)", true)]
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, string format, params object[] args)
		{
			if (!condition)
			{
				Debug.logger.LogFormat(LogType.Assert, format, args);
			}
		}

		// Token: 0x04000055 RID: 85
		internal static ILogger s_Logger = new Logger(new DebugLogHandler());
	}
}
