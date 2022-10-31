using System;
using System.Collections.Generic;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	// Token: 0x02000299 RID: 665
	internal class MatchDirectConnectInfo : ResponseBase
	{
		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06002C05 RID: 11269 RVA: 0x0003E75C File Offset: 0x0003C95C
		// (set) Token: 0x06002C06 RID: 11270 RVA: 0x0003E778 File Offset: 0x0003C978
		public NodeID nodeId { get; set; }

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06002C07 RID: 11271 RVA: 0x0003E784 File Offset: 0x0003C984
		// (set) Token: 0x06002C08 RID: 11272 RVA: 0x0003E7A0 File Offset: 0x0003C9A0
		public string publicAddress { get; set; }

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06002C09 RID: 11273 RVA: 0x0003E7AC File Offset: 0x0003C9AC
		// (set) Token: 0x06002C0A RID: 11274 RVA: 0x0003E7C8 File Offset: 0x0003C9C8
		public string privateAddress { get; set; }

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06002C0B RID: 11275 RVA: 0x0003E7D4 File Offset: 0x0003C9D4
		// (set) Token: 0x06002C0C RID: 11276 RVA: 0x0003E7F0 File Offset: 0x0003C9F0
		public HostPriority hostPriority { get; set; }

		// Token: 0x06002C0D RID: 11277 RVA: 0x0003E7FC File Offset: 0x0003C9FC
		public override string ToString()
		{
			return UnityString.Format("[{0}]-nodeId:{1},publicAddress:{2},privateAddress:{3},hostPriority:{4}", new object[]
			{
				base.ToString(),
				this.nodeId,
				this.publicAddress,
				this.privateAddress,
				this.hostPriority
			});
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x0003E858 File Offset: 0x0003CA58
		public override void Parse(object obj)
		{
			IDictionary<string, object> dictionary = obj as IDictionary<string, object>;
			if (dictionary != null)
			{
				this.nodeId = (NodeID)base.ParseJSONUInt16("nodeId", obj, dictionary);
				this.publicAddress = base.ParseJSONString("publicAddress", obj, dictionary);
				this.privateAddress = base.ParseJSONString("privateAddress", obj, dictionary);
				this.hostPriority = (HostPriority)base.ParseJSONInt32("hostPriority", obj, dictionary);
				return;
			}
			throw new FormatException("While parsing JSON response, found obj is not of type IDictionary<string,object>:" + obj.ToString());
		}
	}
}
