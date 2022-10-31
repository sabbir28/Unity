using System;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	// Token: 0x02000295 RID: 661
	internal class DestroyMatchRequest : Request
	{
		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06002BDF RID: 11231 RVA: 0x0003E1E0 File Offset: 0x0003C3E0
		// (set) Token: 0x06002BE0 RID: 11232 RVA: 0x0003E1FC File Offset: 0x0003C3FC
		public NetworkID networkId { get; set; }

		// Token: 0x06002BE1 RID: 11233 RVA: 0x0003E208 File Offset: 0x0003C408
		public override string ToString()
		{
			return UnityString.Format("[{0}]-networkId:0x{1}", new object[]
			{
				base.ToString(),
				this.networkId.ToString("X")
			});
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x0003E254 File Offset: 0x0003C454
		public override bool IsValid()
		{
			return base.IsValid() && this.networkId != NetworkID.Invalid;
		}
	}
}
