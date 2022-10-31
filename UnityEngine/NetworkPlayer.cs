using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000093 RID: 147
	[RequiredByNativeCode(Optional = true)]
	public struct NetworkPlayer
	{
		// Token: 0x06000A6E RID: 2670 RVA: 0x0000F0E8 File Offset: 0x0000D2E8
		public NetworkPlayer(string ip, int port)
		{
			Debug.LogError("Not yet implemented");
			this.index = 0;
		}

		// Token: 0x06000A6F RID: 2671
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string Internal_GetIPAddress(int index);

		// Token: 0x06000A70 RID: 2672
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetPort(int index);

		// Token: 0x06000A71 RID: 2673
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string Internal_GetExternalIP();

		// Token: 0x06000A72 RID: 2674
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetExternalPort();

		// Token: 0x06000A73 RID: 2675
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string Internal_GetLocalIP();

		// Token: 0x06000A74 RID: 2676
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetLocalPort();

		// Token: 0x06000A75 RID: 2677
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetPlayerIndex();

		// Token: 0x06000A76 RID: 2678
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string Internal_GetGUID(int index);

		// Token: 0x06000A77 RID: 2679
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string Internal_GetLocalGUID();

		// Token: 0x06000A78 RID: 2680 RVA: 0x0000F0FC File Offset: 0x0000D2FC
		public static bool operator ==(NetworkPlayer lhs, NetworkPlayer rhs)
		{
			return lhs.index == rhs.index;
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0000F124 File Offset: 0x0000D324
		public static bool operator !=(NetworkPlayer lhs, NetworkPlayer rhs)
		{
			return lhs.index != rhs.index;
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0000F14C File Offset: 0x0000D34C
		public override int GetHashCode()
		{
			return this.index.GetHashCode();
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x0000F174 File Offset: 0x0000D374
		public override bool Equals(object other)
		{
			return other is NetworkPlayer && ((NetworkPlayer)other).index == this.index;
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x0000F1B4 File Offset: 0x0000D3B4
		public string ipAddress
		{
			get
			{
				string result;
				if (this.index == NetworkPlayer.Internal_GetPlayerIndex())
				{
					result = NetworkPlayer.Internal_GetLocalIP();
				}
				else
				{
					result = NetworkPlayer.Internal_GetIPAddress(this.index);
				}
				return result;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x0000F1F0 File Offset: 0x0000D3F0
		public int port
		{
			get
			{
				int result;
				if (this.index == NetworkPlayer.Internal_GetPlayerIndex())
				{
					result = NetworkPlayer.Internal_GetLocalPort();
				}
				else
				{
					result = NetworkPlayer.Internal_GetPort(this.index);
				}
				return result;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x0000F22C File Offset: 0x0000D42C
		public string guid
		{
			get
			{
				string result;
				if (this.index == NetworkPlayer.Internal_GetPlayerIndex())
				{
					result = NetworkPlayer.Internal_GetLocalGUID();
				}
				else
				{
					result = NetworkPlayer.Internal_GetGUID(this.index);
				}
				return result;
			}
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0000F268 File Offset: 0x0000D468
		public override string ToString()
		{
			return this.index.ToString();
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x0000F290 File Offset: 0x0000D490
		public string externalIP
		{
			get
			{
				return NetworkPlayer.Internal_GetExternalIP();
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x0000F2AC File Offset: 0x0000D4AC
		public int externalPort
		{
			get
			{
				return NetworkPlayer.Internal_GetExternalPort();
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x0000F2C8 File Offset: 0x0000D4C8
		internal static NetworkPlayer unassigned
		{
			get
			{
				NetworkPlayer result;
				result.index = -1;
				return result;
			}
		}

		// Token: 0x04000140 RID: 320
		internal int index;
	}
}
