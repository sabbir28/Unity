using System;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	// Token: 0x02000293 RID: 659
	internal class JoinMatchRequest : Request
	{
		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06002BC1 RID: 11201 RVA: 0x0003DDE0 File Offset: 0x0003BFE0
		// (set) Token: 0x06002BC2 RID: 11202 RVA: 0x0003DDFC File Offset: 0x0003BFFC
		public NetworkID networkId { get; set; }

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06002BC3 RID: 11203 RVA: 0x0003DE08 File Offset: 0x0003C008
		// (set) Token: 0x06002BC4 RID: 11204 RVA: 0x0003DE24 File Offset: 0x0003C024
		public string publicAddress { get; set; }

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06002BC5 RID: 11205 RVA: 0x0003DE30 File Offset: 0x0003C030
		// (set) Token: 0x06002BC6 RID: 11206 RVA: 0x0003DE4C File Offset: 0x0003C04C
		public string privateAddress { get; set; }

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06002BC7 RID: 11207 RVA: 0x0003DE58 File Offset: 0x0003C058
		// (set) Token: 0x06002BC8 RID: 11208 RVA: 0x0003DE74 File Offset: 0x0003C074
		public int eloScore { get; set; }

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06002BC9 RID: 11209 RVA: 0x0003DE80 File Offset: 0x0003C080
		// (set) Token: 0x06002BCA RID: 11210 RVA: 0x0003DE9C File Offset: 0x0003C09C
		public string password { get; set; }

		// Token: 0x06002BCB RID: 11211 RVA: 0x0003DEA8 File Offset: 0x0003C0A8
		public override string ToString()
		{
			return UnityString.Format("[{0}]-networkId:0x{1},publicAddress:{2},privateAddress:{3},eloScore:{4},HasPassword:{5}", new object[]
			{
				base.ToString(),
				this.networkId.ToString("X"),
				this.publicAddress,
				this.privateAddress,
				this.eloScore,
				(!string.IsNullOrEmpty(this.password)) ? "YES" : "NO"
			});
		}

		// Token: 0x06002BCC RID: 11212 RVA: 0x0003DF34 File Offset: 0x0003C134
		public override bool IsValid()
		{
			return base.IsValid() && this.networkId != NetworkID.Invalid;
		}
	}
}
