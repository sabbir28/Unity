using System;

namespace UnityEngine
{
	// Token: 0x020003D9 RID: 985
	internal class SystemClock
	{
		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x060032E4 RID: 13028 RVA: 0x0004F0E8 File Offset: 0x0004D2E8
		public static DateTime now
		{
			get
			{
				return DateTime.Now;
			}
		}

		// Token: 0x060032E5 RID: 13029 RVA: 0x0004F104 File Offset: 0x0004D304
		public static long ToUnixTimeMilliseconds(DateTime date)
		{
			return Convert.ToInt64((date.ToUniversalTime() - SystemClock.s_Epoch).TotalMilliseconds);
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x0004F138 File Offset: 0x0004D338
		public static long ToUnixTimeSeconds(DateTime date)
		{
			return Convert.ToInt64((date.ToUniversalTime() - SystemClock.s_Epoch).TotalSeconds);
		}

		// Token: 0x04000EAB RID: 3755
		private static readonly DateTime s_Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
	}
}
