using System;
using System.Collections.Generic;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking
{
	// Token: 0x020002A5 RID: 677
	public class Utility
	{
		// Token: 0x06002C37 RID: 11319 RVA: 0x0003EED8 File Offset: 0x0003D0D8
		private Utility()
		{
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06002C38 RID: 11320 RVA: 0x0003EEE4 File Offset: 0x0003D0E4
		// (set) Token: 0x06002C39 RID: 11321 RVA: 0x0003EEFC File Offset: 0x0003D0FC
		[Obsolete("This property is unused and should not be referenced in code.", true)]
		public static bool useRandomSourceID
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x0003EF00 File Offset: 0x0003D100
		public static SourceID GetSourceID()
		{
			return (SourceID)((long)SystemInfo.deviceUniqueIdentifier.GetHashCode());
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x0003EF20 File Offset: 0x0003D120
		[Obsolete("This function is unused and should not be referenced in code. Please sign in and setup your project in the editor instead.", true)]
		public static void SetAppID(AppID newAppID)
		{
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x0003EF24 File Offset: 0x0003D124
		[Obsolete("This function is unused and should not be referenced in code. Please sign in and setup your project in the editor instead.", true)]
		public static AppID GetAppID()
		{
			return AppID.Invalid;
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x0003EF3C File Offset: 0x0003D13C
		public static void SetAccessTokenForNetwork(NetworkID netId, NetworkAccessToken accessToken)
		{
			if (Utility.s_dictTokens.ContainsKey(netId))
			{
				Utility.s_dictTokens.Remove(netId);
			}
			Utility.s_dictTokens.Add(netId, accessToken);
		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x0003EF68 File Offset: 0x0003D168
		public static NetworkAccessToken GetAccessTokenForNetwork(NetworkID netId)
		{
			NetworkAccessToken result;
			if (!Utility.s_dictTokens.TryGetValue(netId, out result))
			{
				result = new NetworkAccessToken();
			}
			return result;
		}

		// Token: 0x040008B9 RID: 2233
		private static Dictionary<NetworkID, NetworkAccessToken> s_dictTokens = new Dictionary<NetworkID, NetworkAccessToken>();
	}
}
