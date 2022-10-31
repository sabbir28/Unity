using System;
using System.Collections.Generic;

namespace UnityEngine.Networking.Match
{
	// Token: 0x02000291 RID: 657
	internal class CreateMatchRequest : Request
	{
		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06002B9D RID: 11165 RVA: 0x0003D914 File Offset: 0x0003BB14
		// (set) Token: 0x06002B9E RID: 11166 RVA: 0x0003D930 File Offset: 0x0003BB30
		public string name { get; set; }

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06002B9F RID: 11167 RVA: 0x0003D93C File Offset: 0x0003BB3C
		// (set) Token: 0x06002BA0 RID: 11168 RVA: 0x0003D958 File Offset: 0x0003BB58
		public uint size { get; set; }

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06002BA1 RID: 11169 RVA: 0x0003D964 File Offset: 0x0003BB64
		// (set) Token: 0x06002BA2 RID: 11170 RVA: 0x0003D980 File Offset: 0x0003BB80
		public string publicAddress { get; set; }

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06002BA3 RID: 11171 RVA: 0x0003D98C File Offset: 0x0003BB8C
		// (set) Token: 0x06002BA4 RID: 11172 RVA: 0x0003D9A8 File Offset: 0x0003BBA8
		public string privateAddress { get; set; }

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06002BA5 RID: 11173 RVA: 0x0003D9B4 File Offset: 0x0003BBB4
		// (set) Token: 0x06002BA6 RID: 11174 RVA: 0x0003D9D0 File Offset: 0x0003BBD0
		public int eloScore { get; set; }

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06002BA7 RID: 11175 RVA: 0x0003D9DC File Offset: 0x0003BBDC
		// (set) Token: 0x06002BA8 RID: 11176 RVA: 0x0003D9F8 File Offset: 0x0003BBF8
		public bool advertise { get; set; }

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06002BA9 RID: 11177 RVA: 0x0003DA04 File Offset: 0x0003BC04
		// (set) Token: 0x06002BAA RID: 11178 RVA: 0x0003DA20 File Offset: 0x0003BC20
		public string password { get; set; }

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06002BAB RID: 11179 RVA: 0x0003DA2C File Offset: 0x0003BC2C
		// (set) Token: 0x06002BAC RID: 11180 RVA: 0x0003DA48 File Offset: 0x0003BC48
		public Dictionary<string, long> matchAttributes { get; set; }

		// Token: 0x06002BAD RID: 11181 RVA: 0x0003DA54 File Offset: 0x0003BC54
		public override string ToString()
		{
			return UnityString.Format("[{0}]-name:{1},size:{2},publicAddress:{3},privateAddress:{4},eloScore:{5},advertise:{6},HasPassword:{7},matchAttributes.Count:{8}", new object[]
			{
				base.ToString(),
				this.name,
				this.size,
				this.publicAddress,
				this.privateAddress,
				this.eloScore,
				this.advertise,
				(!string.IsNullOrEmpty(this.password)) ? "YES" : "NO",
				(this.matchAttributes != null) ? this.matchAttributes.Count : 0
			});
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x0003DB10 File Offset: 0x0003BD10
		public override bool IsValid()
		{
			return base.IsValid() && this.size >= 2U && (this.matchAttributes == null || this.matchAttributes.Count <= 10);
		}
	}
}
