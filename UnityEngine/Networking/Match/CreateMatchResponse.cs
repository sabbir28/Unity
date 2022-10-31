using System;
using System.Collections.Generic;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	// Token: 0x02000292 RID: 658
	internal class CreateMatchResponse : BasicResponse
	{
		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06002BB0 RID: 11184 RVA: 0x0003DB6C File Offset: 0x0003BD6C
		// (set) Token: 0x06002BB1 RID: 11185 RVA: 0x0003DB88 File Offset: 0x0003BD88
		public string address { get; set; }

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06002BB2 RID: 11186 RVA: 0x0003DB94 File Offset: 0x0003BD94
		// (set) Token: 0x06002BB3 RID: 11187 RVA: 0x0003DBB0 File Offset: 0x0003BDB0
		public int port { get; set; }

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06002BB4 RID: 11188 RVA: 0x0003DBBC File Offset: 0x0003BDBC
		// (set) Token: 0x06002BB5 RID: 11189 RVA: 0x0003DBD8 File Offset: 0x0003BDD8
		public int domain { get; set; }

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06002BB6 RID: 11190 RVA: 0x0003DBE4 File Offset: 0x0003BDE4
		// (set) Token: 0x06002BB7 RID: 11191 RVA: 0x0003DC00 File Offset: 0x0003BE00
		public NetworkID networkId { get; set; }

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06002BB8 RID: 11192 RVA: 0x0003DC0C File Offset: 0x0003BE0C
		// (set) Token: 0x06002BB9 RID: 11193 RVA: 0x0003DC28 File Offset: 0x0003BE28
		public string accessTokenString { get; set; }

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06002BBA RID: 11194 RVA: 0x0003DC34 File Offset: 0x0003BE34
		// (set) Token: 0x06002BBB RID: 11195 RVA: 0x0003DC50 File Offset: 0x0003BE50
		public NodeID nodeId { get; set; }

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06002BBC RID: 11196 RVA: 0x0003DC5C File Offset: 0x0003BE5C
		// (set) Token: 0x06002BBD RID: 11197 RVA: 0x0003DC78 File Offset: 0x0003BE78
		public bool usingRelay { get; set; }

		// Token: 0x06002BBE RID: 11198 RVA: 0x0003DC84 File Offset: 0x0003BE84
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

		// Token: 0x06002BBF RID: 11199 RVA: 0x0003DD24 File Offset: 0x0003BF24
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
