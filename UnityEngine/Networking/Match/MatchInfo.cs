using System;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	// Token: 0x020002A6 RID: 678
	public class MatchInfo
	{
		// Token: 0x06002C40 RID: 11328 RVA: 0x0003EFA4 File Offset: 0x0003D1A4
		public MatchInfo()
		{
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x0003EFB0 File Offset: 0x0003D1B0
		internal MatchInfo(CreateMatchResponse matchResponse)
		{
			this.address = matchResponse.address;
			this.port = matchResponse.port;
			this.domain = matchResponse.domain;
			this.networkId = matchResponse.networkId;
			this.accessToken = new NetworkAccessToken(matchResponse.accessTokenString);
			this.nodeId = matchResponse.nodeId;
			this.usingRelay = matchResponse.usingRelay;
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x0003F020 File Offset: 0x0003D220
		internal MatchInfo(JoinMatchResponse matchResponse)
		{
			this.address = matchResponse.address;
			this.port = matchResponse.port;
			this.domain = matchResponse.domain;
			this.networkId = matchResponse.networkId;
			this.accessToken = new NetworkAccessToken(matchResponse.accessTokenString);
			this.nodeId = matchResponse.nodeId;
			this.usingRelay = matchResponse.usingRelay;
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06002C43 RID: 11331 RVA: 0x0003F090 File Offset: 0x0003D290
		// (set) Token: 0x06002C44 RID: 11332 RVA: 0x0003F0AC File Offset: 0x0003D2AC
		public string address { get; private set; }

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06002C45 RID: 11333 RVA: 0x0003F0B8 File Offset: 0x0003D2B8
		// (set) Token: 0x06002C46 RID: 11334 RVA: 0x0003F0D4 File Offset: 0x0003D2D4
		public int port { get; private set; }

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06002C47 RID: 11335 RVA: 0x0003F0E0 File Offset: 0x0003D2E0
		// (set) Token: 0x06002C48 RID: 11336 RVA: 0x0003F0FC File Offset: 0x0003D2FC
		public int domain { get; private set; }

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06002C49 RID: 11337 RVA: 0x0003F108 File Offset: 0x0003D308
		// (set) Token: 0x06002C4A RID: 11338 RVA: 0x0003F124 File Offset: 0x0003D324
		public NetworkID networkId { get; private set; }

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06002C4B RID: 11339 RVA: 0x0003F130 File Offset: 0x0003D330
		// (set) Token: 0x06002C4C RID: 11340 RVA: 0x0003F14C File Offset: 0x0003D34C
		public NetworkAccessToken accessToken { get; private set; }

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06002C4D RID: 11341 RVA: 0x0003F158 File Offset: 0x0003D358
		// (set) Token: 0x06002C4E RID: 11342 RVA: 0x0003F174 File Offset: 0x0003D374
		public NodeID nodeId { get; private set; }

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06002C4F RID: 11343 RVA: 0x0003F180 File Offset: 0x0003D380
		// (set) Token: 0x06002C50 RID: 11344 RVA: 0x0003F19C File Offset: 0x0003D39C
		public bool usingRelay { get; private set; }

		// Token: 0x06002C51 RID: 11345 RVA: 0x0003F1A8 File Offset: 0x0003D3A8
		public override string ToString()
		{
			return UnityString.Format("{0} @ {1}:{2} [{3},{4}]", new object[]
			{
				this.networkId,
				this.address,
				this.port,
				this.nodeId,
				this.usingRelay
			});
		}
	}
}
