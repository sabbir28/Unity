using System;
using System.Collections.Generic;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	// Token: 0x0200029A RID: 666
	internal class MatchDesc : ResponseBase
	{
		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06002C10 RID: 11280 RVA: 0x0003E8E8 File Offset: 0x0003CAE8
		// (set) Token: 0x06002C11 RID: 11281 RVA: 0x0003E904 File Offset: 0x0003CB04
		public NetworkID networkId { get; set; }

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06002C12 RID: 11282 RVA: 0x0003E910 File Offset: 0x0003CB10
		// (set) Token: 0x06002C13 RID: 11283 RVA: 0x0003E92C File Offset: 0x0003CB2C
		public string name { get; set; }

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06002C14 RID: 11284 RVA: 0x0003E938 File Offset: 0x0003CB38
		// (set) Token: 0x06002C15 RID: 11285 RVA: 0x0003E954 File Offset: 0x0003CB54
		public int averageEloScore { get; set; }

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06002C16 RID: 11286 RVA: 0x0003E960 File Offset: 0x0003CB60
		// (set) Token: 0x06002C17 RID: 11287 RVA: 0x0003E97C File Offset: 0x0003CB7C
		public int maxSize { get; set; }

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06002C18 RID: 11288 RVA: 0x0003E988 File Offset: 0x0003CB88
		// (set) Token: 0x06002C19 RID: 11289 RVA: 0x0003E9A4 File Offset: 0x0003CBA4
		public int currentSize { get; set; }

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06002C1A RID: 11290 RVA: 0x0003E9B0 File Offset: 0x0003CBB0
		// (set) Token: 0x06002C1B RID: 11291 RVA: 0x0003E9CC File Offset: 0x0003CBCC
		public bool isPrivate { get; set; }

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06002C1C RID: 11292 RVA: 0x0003E9D8 File Offset: 0x0003CBD8
		// (set) Token: 0x06002C1D RID: 11293 RVA: 0x0003E9F4 File Offset: 0x0003CBF4
		public Dictionary<string, long> matchAttributes { get; set; }

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06002C1E RID: 11294 RVA: 0x0003EA00 File Offset: 0x0003CC00
		// (set) Token: 0x06002C1F RID: 11295 RVA: 0x0003EA1C File Offset: 0x0003CC1C
		public NodeID hostNodeId { get; set; }

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06002C20 RID: 11296 RVA: 0x0003EA28 File Offset: 0x0003CC28
		// (set) Token: 0x06002C21 RID: 11297 RVA: 0x0003EA44 File Offset: 0x0003CC44
		public List<MatchDirectConnectInfo> directConnectInfos { get; set; }

		// Token: 0x06002C22 RID: 11298 RVA: 0x0003EA50 File Offset: 0x0003CC50
		public override string ToString()
		{
			return UnityString.Format("[{0}]-networkId:0x{1},name:{2},averageEloScore:{3},maxSize:{4},currentSize:{5},isPrivate:{6},matchAttributes.Count:{7},hostNodeId:{8},directConnectInfos.Count:{9}", new object[]
			{
				base.ToString(),
				this.networkId.ToString("X"),
				this.name,
				this.averageEloScore,
				this.maxSize,
				this.currentSize,
				this.isPrivate,
				(this.matchAttributes != null) ? this.matchAttributes.Count : 0,
				this.hostNodeId,
				this.directConnectInfos.Count
			});
		}

		// Token: 0x06002C23 RID: 11299 RVA: 0x0003EB24 File Offset: 0x0003CD24
		public override void Parse(object obj)
		{
			IDictionary<string, object> dictionary = obj as IDictionary<string, object>;
			if (dictionary != null)
			{
				this.networkId = (NetworkID)base.ParseJSONUInt64("networkId", obj, dictionary);
				this.name = base.ParseJSONString("name", obj, dictionary);
				this.averageEloScore = base.ParseJSONInt32("averageEloScore", obj, dictionary);
				this.maxSize = base.ParseJSONInt32("maxSize", obj, dictionary);
				this.currentSize = base.ParseJSONInt32("currentSize", obj, dictionary);
				this.isPrivate = base.ParseJSONBool("isPrivate", obj, dictionary);
				this.hostNodeId = (NodeID)base.ParseJSONUInt16("hostNodeId", obj, dictionary);
				this.directConnectInfos = base.ParseJSONList<MatchDirectConnectInfo>("directConnectInfos", obj, dictionary);
				return;
			}
			throw new FormatException("While parsing JSON response, found obj is not of type IDictionary<string,object>:" + obj.ToString());
		}
	}
}
