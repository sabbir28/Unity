using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020002C5 RID: 709
	public static class RemoteSettings
	{
		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06002DFF RID: 11775 RVA: 0x00042744 File Offset: 0x00040944
		// (remove) Token: 0x06002E00 RID: 11776 RVA: 0x00042778 File Offset: 0x00040978
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event RemoteSettings.UpdatedEventHandler Updated;

		// Token: 0x06002E01 RID: 11777 RVA: 0x000427AC File Offset: 0x000409AC
		[RequiredByNativeCode]
		public static void CallOnUpdate()
		{
			RemoteSettings.UpdatedEventHandler updated = RemoteSettings.Updated;
			if (updated != null)
			{
				updated();
			}
		}

		// Token: 0x06002E02 RID: 11778
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetInt(string key, [DefaultValue("0")] int defaultValue);

		// Token: 0x06002E03 RID: 11779 RVA: 0x000427CC File Offset: 0x000409CC
		[ExcludeFromDocs]
		public static int GetInt(string key)
		{
			int defaultValue = 0;
			return RemoteSettings.GetInt(key, defaultValue);
		}

		// Token: 0x06002E04 RID: 11780
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetFloat(string key, [DefaultValue("0.0F")] float defaultValue);

		// Token: 0x06002E05 RID: 11781 RVA: 0x000427EC File Offset: 0x000409EC
		[ExcludeFromDocs]
		public static float GetFloat(string key)
		{
			float defaultValue = 0f;
			return RemoteSettings.GetFloat(key, defaultValue);
		}

		// Token: 0x06002E06 RID: 11782
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string GetString(string key, [DefaultValue("\"\"")] string defaultValue);

		// Token: 0x06002E07 RID: 11783 RVA: 0x00042810 File Offset: 0x00040A10
		[ExcludeFromDocs]
		public static string GetString(string key)
		{
			string defaultValue = "";
			return RemoteSettings.GetString(key, defaultValue);
		}

		// Token: 0x06002E08 RID: 11784
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetBool(string key, [DefaultValue("false")] bool defaultValue);

		// Token: 0x06002E09 RID: 11785 RVA: 0x00042834 File Offset: 0x00040A34
		[ExcludeFromDocs]
		public static bool GetBool(string key)
		{
			bool defaultValue = false;
			return RemoteSettings.GetBool(key, defaultValue);
		}

		// Token: 0x06002E0A RID: 11786
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasKey(string key);

		// Token: 0x06002E0B RID: 11787
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCount();

		// Token: 0x06002E0C RID: 11788
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string[] GetKeys();

		// Token: 0x020002C6 RID: 710
		// (Invoke) Token: 0x06002E0E RID: 11790
		public delegate void UpdatedEventHandler();
	}
}
