using System;
using System.Collections.Generic;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	// Token: 0x02000297 RID: 663
	internal class DropConnectionResponse : Response
	{
		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06002BEB RID: 11243 RVA: 0x0003E388 File Offset: 0x0003C588
		// (set) Token: 0x06002BEC RID: 11244 RVA: 0x0003E3A4 File Offset: 0x0003C5A4
		public NetworkID networkId { get; set; }

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06002BED RID: 11245 RVA: 0x0003E3B0 File Offset: 0x0003C5B0
		// (set) Token: 0x06002BEE RID: 11246 RVA: 0x0003E3CC File Offset: 0x0003C5CC
		public NodeID nodeId { get; set; }

		// Token: 0x06002BEF RID: 11247 RVA: 0x0003E3D8 File Offset: 0x0003C5D8
		public override string ToString()
		{
			return UnityString.Format("[{0}]-networkId:{1}", new object[]
			{
				base.ToString(),
				this.networkId.ToString("X")
			});
		}

		// Token: 0x06002BF0 RID: 11248 RVA: 0x0003E424 File Offset: 0x0003C624
		public override void Parse(object obj)
		{
			base.Parse(obj);
			IDictionary<string, object> dictionary = obj as IDictionary<string, object>;
			if (dictionary != null)
			{
				this.networkId = (NetworkID)base.ParseJSONUInt64("networkId", obj, dictionary);
				this.nodeId = (NodeID)base.ParseJSONUInt16("nodeId", obj, dictionary);
				return;
			}
			throw new FormatException("While parsing JSON response, found obj is not of type IDictionary<string,object>:" + obj.ToString());
		}
	}
}
