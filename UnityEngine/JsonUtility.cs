using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200028B RID: 651
	public static class JsonUtility
	{
		// Token: 0x06002B6E RID: 11118 RVA: 0x0003D240 File Offset: 0x0003B440
		public static string ToJson(object obj)
		{
			return JsonUtility.ToJson(obj, false);
		}

		// Token: 0x06002B6F RID: 11119
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string ToJson(object obj, bool prettyPrint);

		// Token: 0x06002B70 RID: 11120 RVA: 0x0003D25C File Offset: 0x0003B45C
		public static T FromJson<T>(string json)
		{
			return (T)((object)JsonUtility.FromJson(json, typeof(T)));
		}

		// Token: 0x06002B71 RID: 11121
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FromJson(string json, Type type);

		// Token: 0x06002B72 RID: 11122
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FromJsonOverwrite(string json, object objectToOverwrite);
	}
}
