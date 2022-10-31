using System;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	// Token: 0x0200029D RID: 669
	internal class SetMatchAttributesRequest : Request
	{
		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06002C2C RID: 11308 RVA: 0x0003ECFC File Offset: 0x0003CEFC
		// (set) Token: 0x06002C2D RID: 11309 RVA: 0x0003ED18 File Offset: 0x0003CF18
		public NetworkID networkId { get; set; }

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06002C2E RID: 11310 RVA: 0x0003ED24 File Offset: 0x0003CF24
		// (set) Token: 0x06002C2F RID: 11311 RVA: 0x0003ED40 File Offset: 0x0003CF40
		public bool isListed { get; set; }

		// Token: 0x06002C30 RID: 11312 RVA: 0x0003ED4C File Offset: 0x0003CF4C
		public override string ToString()
		{
			return UnityString.Format("[{0}]-networkId:{1},isListed:{2}", new object[]
			{
				base.ToString(),
				this.networkId.ToString("X"),
				this.isListed
			});
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x0003EDA4 File Offset: 0x0003CFA4
		public override bool IsValid()
		{
			return base.IsValid() && this.networkId != NetworkID.Invalid;
		}
	}
}
