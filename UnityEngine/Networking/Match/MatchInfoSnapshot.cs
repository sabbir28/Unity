using System;
using System.Collections.Generic;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	// Token: 0x020002A7 RID: 679
	public class MatchInfoSnapshot
	{
		// Token: 0x06002C52 RID: 11346 RVA: 0x0003F210 File Offset: 0x0003D410
		public MatchInfoSnapshot()
		{
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x0003F21C File Offset: 0x0003D41C
		internal MatchInfoSnapshot(MatchDesc matchDesc)
		{
			this.networkId = matchDesc.networkId;
			this.hostNodeId = matchDesc.hostNodeId;
			this.name = matchDesc.name;
			this.averageEloScore = matchDesc.averageEloScore;
			this.maxSize = matchDesc.maxSize;
			this.currentSize = matchDesc.currentSize;
			this.isPrivate = matchDesc.isPrivate;
			this.matchAttributes = matchDesc.matchAttributes;
			this.directConnectInfos = new List<MatchInfoSnapshot.MatchInfoDirectConnectSnapshot>();
			foreach (MatchDirectConnectInfo matchDirectConnectInfo in matchDesc.directConnectInfos)
			{
				this.directConnectInfos.Add(new MatchInfoSnapshot.MatchInfoDirectConnectSnapshot(matchDirectConnectInfo));
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06002C54 RID: 11348 RVA: 0x0003F2F8 File Offset: 0x0003D4F8
		// (set) Token: 0x06002C55 RID: 11349 RVA: 0x0003F314 File Offset: 0x0003D514
		public NetworkID networkId { get; private set; }

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06002C56 RID: 11350 RVA: 0x0003F320 File Offset: 0x0003D520
		// (set) Token: 0x06002C57 RID: 11351 RVA: 0x0003F33C File Offset: 0x0003D53C
		public NodeID hostNodeId { get; private set; }

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06002C58 RID: 11352 RVA: 0x0003F348 File Offset: 0x0003D548
		// (set) Token: 0x06002C59 RID: 11353 RVA: 0x0003F364 File Offset: 0x0003D564
		public string name { get; private set; }

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06002C5A RID: 11354 RVA: 0x0003F370 File Offset: 0x0003D570
		// (set) Token: 0x06002C5B RID: 11355 RVA: 0x0003F38C File Offset: 0x0003D58C
		public int averageEloScore { get; private set; }

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06002C5C RID: 11356 RVA: 0x0003F398 File Offset: 0x0003D598
		// (set) Token: 0x06002C5D RID: 11357 RVA: 0x0003F3B4 File Offset: 0x0003D5B4
		public int maxSize { get; private set; }

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06002C5E RID: 11358 RVA: 0x0003F3C0 File Offset: 0x0003D5C0
		// (set) Token: 0x06002C5F RID: 11359 RVA: 0x0003F3DC File Offset: 0x0003D5DC
		public int currentSize { get; private set; }

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06002C60 RID: 11360 RVA: 0x0003F3E8 File Offset: 0x0003D5E8
		// (set) Token: 0x06002C61 RID: 11361 RVA: 0x0003F404 File Offset: 0x0003D604
		public bool isPrivate { get; private set; }

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06002C62 RID: 11362 RVA: 0x0003F410 File Offset: 0x0003D610
		// (set) Token: 0x06002C63 RID: 11363 RVA: 0x0003F42C File Offset: 0x0003D62C
		public Dictionary<string, long> matchAttributes { get; private set; }

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06002C64 RID: 11364 RVA: 0x0003F438 File Offset: 0x0003D638
		// (set) Token: 0x06002C65 RID: 11365 RVA: 0x0003F454 File Offset: 0x0003D654
		public List<MatchInfoSnapshot.MatchInfoDirectConnectSnapshot> directConnectInfos { get; private set; }

		// Token: 0x020002A8 RID: 680
		public class MatchInfoDirectConnectSnapshot
		{
			// Token: 0x06002C66 RID: 11366 RVA: 0x0003F460 File Offset: 0x0003D660
			public MatchInfoDirectConnectSnapshot()
			{
			}

			// Token: 0x06002C67 RID: 11367 RVA: 0x0003F46C File Offset: 0x0003D66C
			internal MatchInfoDirectConnectSnapshot(MatchDirectConnectInfo matchDirectConnectInfo)
			{
				this.nodeId = matchDirectConnectInfo.nodeId;
				this.publicAddress = matchDirectConnectInfo.publicAddress;
				this.privateAddress = matchDirectConnectInfo.privateAddress;
				this.hostPriority = matchDirectConnectInfo.hostPriority;
			}

			// Token: 0x17000A73 RID: 2675
			// (get) Token: 0x06002C68 RID: 11368 RVA: 0x0003F4A8 File Offset: 0x0003D6A8
			// (set) Token: 0x06002C69 RID: 11369 RVA: 0x0003F4C4 File Offset: 0x0003D6C4
			public NodeID nodeId { get; private set; }

			// Token: 0x17000A74 RID: 2676
			// (get) Token: 0x06002C6A RID: 11370 RVA: 0x0003F4D0 File Offset: 0x0003D6D0
			// (set) Token: 0x06002C6B RID: 11371 RVA: 0x0003F4EC File Offset: 0x0003D6EC
			public string publicAddress { get; private set; }

			// Token: 0x17000A75 RID: 2677
			// (get) Token: 0x06002C6C RID: 11372 RVA: 0x0003F4F8 File Offset: 0x0003D6F8
			// (set) Token: 0x06002C6D RID: 11373 RVA: 0x0003F514 File Offset: 0x0003D714
			public string privateAddress { get; private set; }

			// Token: 0x17000A76 RID: 2678
			// (get) Token: 0x06002C6E RID: 11374 RVA: 0x0003F520 File Offset: 0x0003D720
			// (set) Token: 0x06002C6F RID: 11375 RVA: 0x0003F53C File Offset: 0x0003D73C
			public HostPriority hostPriority { get; private set; }
		}
	}
}
