using System;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	// Token: 0x02000296 RID: 662
	internal class DropConnectionRequest : Request
	{
		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06002BE4 RID: 11236 RVA: 0x0003E28C File Offset: 0x0003C48C
		// (set) Token: 0x06002BE5 RID: 11237 RVA: 0x0003E2A8 File Offset: 0x0003C4A8
		public NetworkID networkId { get; set; }

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06002BE6 RID: 11238 RVA: 0x0003E2B4 File Offset: 0x0003C4B4
		// (set) Token: 0x06002BE7 RID: 11239 RVA: 0x0003E2D0 File Offset: 0x0003C4D0
		public NodeID nodeId { get; set; }

		// Token: 0x06002BE8 RID: 11240 RVA: 0x0003E2DC File Offset: 0x0003C4DC
		public override string ToString()
		{
			return UnityString.Format("[{0}]-networkId:0x{1},nodeId:0x{2}", new object[]
			{
				base.ToString(),
				this.networkId.ToString("X"),
				this.nodeId.ToString("X")
			});
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x0003E344 File Offset: 0x0003C544
		public override bool IsValid()
		{
			return base.IsValid() && this.networkId != NetworkID.Invalid && this.nodeId != NodeID.Invalid;
		}
	}
}
