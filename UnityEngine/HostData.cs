using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000099 RID: 153
	[RequiredByNativeCode(Optional = true)]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class HostData
	{
		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x0000FA6C File Offset: 0x0000DC6C
		// (set) Token: 0x06000B25 RID: 2853 RVA: 0x0000FA90 File Offset: 0x0000DC90
		public bool useNat
		{
			get
			{
				return this.m_Nat != 0;
			}
			set
			{
				this.m_Nat = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000B26 RID: 2854 RVA: 0x0000FAA8 File Offset: 0x0000DCA8
		// (set) Token: 0x06000B27 RID: 2855 RVA: 0x0000FAC4 File Offset: 0x0000DCC4
		public string gameType
		{
			get
			{
				return this.m_GameType;
			}
			set
			{
				this.m_GameType = value;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000B28 RID: 2856 RVA: 0x0000FAD0 File Offset: 0x0000DCD0
		// (set) Token: 0x06000B29 RID: 2857 RVA: 0x0000FAEC File Offset: 0x0000DCEC
		public string gameName
		{
			get
			{
				return this.m_GameName;
			}
			set
			{
				this.m_GameName = value;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000B2A RID: 2858 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
		// (set) Token: 0x06000B2B RID: 2859 RVA: 0x0000FB14 File Offset: 0x0000DD14
		public int connectedPlayers
		{
			get
			{
				return this.m_ConnectedPlayers;
			}
			set
			{
				this.m_ConnectedPlayers = value;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x0000FB20 File Offset: 0x0000DD20
		// (set) Token: 0x06000B2D RID: 2861 RVA: 0x0000FB3C File Offset: 0x0000DD3C
		public int playerLimit
		{
			get
			{
				return this.m_PlayerLimit;
			}
			set
			{
				this.m_PlayerLimit = value;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x0000FB48 File Offset: 0x0000DD48
		// (set) Token: 0x06000B2F RID: 2863 RVA: 0x0000FB64 File Offset: 0x0000DD64
		public string[] ip
		{
			get
			{
				return this.m_IP;
			}
			set
			{
				this.m_IP = value;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x0000FB70 File Offset: 0x0000DD70
		// (set) Token: 0x06000B31 RID: 2865 RVA: 0x0000FB8C File Offset: 0x0000DD8C
		public int port
		{
			get
			{
				return this.m_Port;
			}
			set
			{
				this.m_Port = value;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x0000FB98 File Offset: 0x0000DD98
		// (set) Token: 0x06000B33 RID: 2867 RVA: 0x0000FBBC File Offset: 0x0000DDBC
		public bool passwordProtected
		{
			get
			{
				return this.m_PasswordProtected != 0;
			}
			set
			{
				this.m_PasswordProtected = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x0000FBD4 File Offset: 0x0000DDD4
		// (set) Token: 0x06000B35 RID: 2869 RVA: 0x0000FBF0 File Offset: 0x0000DDF0
		public string comment
		{
			get
			{
				return this.m_Comment;
			}
			set
			{
				this.m_Comment = value;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x0000FBFC File Offset: 0x0000DDFC
		// (set) Token: 0x06000B37 RID: 2871 RVA: 0x0000FC18 File Offset: 0x0000DE18
		public string guid
		{
			get
			{
				return this.m_GUID;
			}
			set
			{
				this.m_GUID = value;
			}
		}

		// Token: 0x04000145 RID: 325
		private int m_Nat;

		// Token: 0x04000146 RID: 326
		private string m_GameType;

		// Token: 0x04000147 RID: 327
		private string m_GameName;

		// Token: 0x04000148 RID: 328
		private int m_ConnectedPlayers;

		// Token: 0x04000149 RID: 329
		private int m_PlayerLimit;

		// Token: 0x0400014A RID: 330
		private string[] m_IP;

		// Token: 0x0400014B RID: 331
		private int m_Port;

		// Token: 0x0400014C RID: 332
		private int m_PasswordProtected;

		// Token: 0x0400014D RID: 333
		private string m_Comment;

		// Token: 0x0400014E RID: 334
		private string m_GUID;
	}
}
