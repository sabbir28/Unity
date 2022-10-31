using System;
using System.Collections.Generic;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	// Token: 0x02000294 RID: 660
	internal class JoinMatchResponse : BasicResponse
	{
		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06002BCE RID: 11214 RVA: 0x0003DF6C File Offset: 0x0003C16C
		// (set) Token: 0x06002BCF RID: 11215 RVA: 0x0003DF88 File Offset: 0x0003C188
		public string address { get; set; }

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06002BD0 RID: 11216 RVA: 0x0003DF94 File Offset: 0x0003C194
		// (set) Token: 0x06002BD1 RID: 11217 RVA: 0x0003DFB0 File Offset: 0x0003C1B0
		public int port { get; set; }

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06002BD2 RID: 11218 RVA: 0x0003DFBC File Offset: 0x0003C1BC
		// (set) Token: 0x06002BD3 RID: 11219 RVA: 0x0003DFD8 File Offset: 0x0003C1D8
		public int domain { get; set; }

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06002BD4 RID: 11220 RVA: 0x0003DFE4 File Offset: 0x0003C1E4
		// (set) Token: 0x06002BD5 RID: 11221 RVA: 0x0003E000 File Offset: 0x0003C200
		public NetworkID networkId { get; set; }

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06002BD6 RID: 11222 RVA: 0x0003E00C File Offset: 0x0003C20C
		// (set) Token: 0x06002BD7 RID: 11223 RVA: 0x0003E028 File Offset: 0x0003C228
		public string accessTokenString { get; set; }

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06002BD8 RID: 11224 RVA: 0x0003E034 File Offset: 0x0003C234
		// (set) Token: 0x06002BD9 RID: 11225 RVA: 0x0003E050 File Offset: 0x0003C250
		public NodeID nodeId { get; set; }

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06002BDA RID: 11226 RVA: 0x0003E05C File Offset: 0x0003C25C
		// (set) Token: 0x06002BDB RID: 11227 RVA: 0x0003E078 File Offset: 0x0003C278
		public bool usingRelay { get; set; }

		// Token: 0x06002BDC RID: 11228 RVA: 0x0003E084 File Offset: 0x0003C284
		public override string ToString()
		{
			return UnityString.Format("[{0}]-address:{1},port:{2},networkId:0x{3},accessTokenString.IsEmpty:{4},nodeId:0x{5},usingRelay:{6}", new object[]
			{
				base.ToString(),
				this.address,
				this.port,
				this.networkId.ToString("X"),
				string.IsNullOrEmpty(this.accessTokenString),
				this.nodeId.ToString("X"),
				this.usingRelay
			});
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x0003E124 File Offset: 0x0003C324
		public override void Parse(object obj)
		{
			base.Parse(obj);
			IDictionary<string, object> dictionary = obj as IDictionary<string, object>;
			if (dictionary != null)
			{
				this.address = base.ParseJSONString("address", obj, dictionary);
				this.port = base.ParseJSONInt32("port", obj, dictionary);
				this.networkId = (NetworkID)base.ParseJSONUInt64("networkId", obj, dictionary);
				this.accessTokenString = base.ParseJSONString("accessTokenString", obj, dictionary);
				this.nodeId = (NodeID)base.ParseJSONUInt16("nodeId", obj, dictionary);
				this.usingRelay = base.ParseJSONBool("usingRelay", obj, dictionary);
				return;
			}
			throw new FormatException("While parsing JSON response, found obj is not of type IDictionary<string,object>:" + obj.ToString());
		}
	}
}
