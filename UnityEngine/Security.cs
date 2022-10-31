using System;
using System.Reflection;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x020000AA RID: 170
	public sealed class Security
	{
		// Token: 0x06000C8A RID: 3210 RVA: 0x00010ED4 File Offset: 0x0000F0D4
		[Obsolete("Security.PrefetchSocketPolicy is no longer supported, since the Unity Web Player is no longer supported by Unity.")]
		[ExcludeFromDocs]
		public static bool PrefetchSocketPolicy(string ip, int atPort)
		{
			int timeout = 3000;
			return Security.PrefetchSocketPolicy(ip, atPort, timeout);
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00010EF8 File Offset: 0x0000F0F8
		[Obsolete("Security.PrefetchSocketPolicy is no longer supported, since the Unity Web Player is no longer supported by Unity.")]
		public static bool PrefetchSocketPolicy(string ip, int atPort, [DefaultValue("3000")] int timeout)
		{
			return false;
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00010F10 File Offset: 0x0000F110
		[Obsolete("This was an internal method which is no longer used", true)]
		public static Assembly LoadAndVerifyAssembly(byte[] assemblyData, string authorizationKey)
		{
			return null;
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00010F28 File Offset: 0x0000F128
		[Obsolete("This was an internal method which is no longer used", true)]
		public static Assembly LoadAndVerifyAssembly(byte[] assemblyData)
		{
			return null;
		}
	}
}
