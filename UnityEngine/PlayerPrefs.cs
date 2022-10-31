using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000A1 RID: 161
	public sealed class PlayerPrefs
	{
		// Token: 0x06000B65 RID: 2917
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool TrySetInt(string key, int value);

		// Token: 0x06000B66 RID: 2918
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool TrySetFloat(string key, float value);

		// Token: 0x06000B67 RID: 2919
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool TrySetSetString(string key, string value);

		// Token: 0x06000B68 RID: 2920 RVA: 0x0000FD98 File Offset: 0x0000DF98
		public static void SetInt(string key, int value)
		{
			if (!PlayerPrefs.TrySetInt(key, value))
			{
				throw new PlayerPrefsException("Could not store preference value");
			}
		}

		// Token: 0x06000B69 RID: 2921
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetInt(string key, [DefaultValue("0")] int defaultValue);

		// Token: 0x06000B6A RID: 2922 RVA: 0x0000FDB4 File Offset: 0x0000DFB4
		[ExcludeFromDocs]
		public static int GetInt(string key)
		{
			int defaultValue = 0;
			return PlayerPrefs.GetInt(key, defaultValue);
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0000FDD4 File Offset: 0x0000DFD4
		public static void SetFloat(string key, float value)
		{
			if (!PlayerPrefs.TrySetFloat(key, value))
			{
				throw new PlayerPrefsException("Could not store preference value");
			}
		}

		// Token: 0x06000B6C RID: 2924
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetFloat(string key, [DefaultValue("0.0F")] float defaultValue);

		// Token: 0x06000B6D RID: 2925 RVA: 0x0000FDF0 File Offset: 0x0000DFF0
		[ExcludeFromDocs]
		public static float GetFloat(string key)
		{
			float defaultValue = 0f;
			return PlayerPrefs.GetFloat(key, defaultValue);
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0000FE14 File Offset: 0x0000E014
		public static void SetString(string key, string value)
		{
			if (!PlayerPrefs.TrySetSetString(key, value))
			{
				throw new PlayerPrefsException("Could not store preference value");
			}
		}

		// Token: 0x06000B6F RID: 2927
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string GetString(string key, [DefaultValue("\"\"")] string defaultValue);

		// Token: 0x06000B70 RID: 2928 RVA: 0x0000FE30 File Offset: 0x0000E030
		[ExcludeFromDocs]
		public static string GetString(string key)
		{
			string defaultValue = "";
			return PlayerPrefs.GetString(key, defaultValue);
		}

		// Token: 0x06000B71 RID: 2929
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasKey(string key);

		// Token: 0x06000B72 RID: 2930
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DeleteKey(string key);

		// Token: 0x06000B73 RID: 2931
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DeleteAll();

		// Token: 0x06000B74 RID: 2932
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Save();
	}
}
