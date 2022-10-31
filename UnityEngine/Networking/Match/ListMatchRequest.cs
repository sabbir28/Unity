using System;
using System.Collections.Generic;

namespace UnityEngine.Networking.Match
{
	// Token: 0x02000298 RID: 664
	internal class ListMatchRequest : Request
	{
		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06002BF2 RID: 11250 RVA: 0x0003E494 File Offset: 0x0003C694
		// (set) Token: 0x06002BF3 RID: 11251 RVA: 0x0003E4B0 File Offset: 0x0003C6B0
		public int pageSize { get; set; }

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06002BF4 RID: 11252 RVA: 0x0003E4BC File Offset: 0x0003C6BC
		// (set) Token: 0x06002BF5 RID: 11253 RVA: 0x0003E4D8 File Offset: 0x0003C6D8
		public int pageNum { get; set; }

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06002BF6 RID: 11254 RVA: 0x0003E4E4 File Offset: 0x0003C6E4
		// (set) Token: 0x06002BF7 RID: 11255 RVA: 0x0003E500 File Offset: 0x0003C700
		public string nameFilter { get; set; }

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06002BF8 RID: 11256 RVA: 0x0003E50C File Offset: 0x0003C70C
		// (set) Token: 0x06002BF9 RID: 11257 RVA: 0x0003E528 File Offset: 0x0003C728
		public bool filterOutPrivateMatches { get; set; }

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06002BFA RID: 11258 RVA: 0x0003E534 File Offset: 0x0003C734
		// (set) Token: 0x06002BFB RID: 11259 RVA: 0x0003E550 File Offset: 0x0003C750
		public int eloScore { get; set; }

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06002BFC RID: 11260 RVA: 0x0003E55C File Offset: 0x0003C75C
		// (set) Token: 0x06002BFD RID: 11261 RVA: 0x0003E578 File Offset: 0x0003C778
		public Dictionary<string, long> matchAttributeFilterLessThan { get; set; }

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06002BFE RID: 11262 RVA: 0x0003E584 File Offset: 0x0003C784
		// (set) Token: 0x06002BFF RID: 11263 RVA: 0x0003E5A0 File Offset: 0x0003C7A0
		public Dictionary<string, long> matchAttributeFilterEqualTo { get; set; }

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06002C00 RID: 11264 RVA: 0x0003E5AC File Offset: 0x0003C7AC
		// (set) Token: 0x06002C01 RID: 11265 RVA: 0x0003E5C8 File Offset: 0x0003C7C8
		public Dictionary<string, long> matchAttributeFilterGreaterThan { get; set; }

		// Token: 0x06002C02 RID: 11266 RVA: 0x0003E5D4 File Offset: 0x0003C7D4
		public override string ToString()
		{
			return UnityString.Format("[{0}]-pageSize:{1},pageNum:{2},nameFilter:{3}, filterOutPrivateMatches:{4}, eloScore:{5}, matchAttributeFilterLessThan.Count:{6}, matchAttributeFilterEqualTo.Count:{7}, matchAttributeFilterGreaterThan.Count:{8}", new object[]
			{
				base.ToString(),
				this.pageSize,
				this.pageNum,
				this.nameFilter,
				this.filterOutPrivateMatches,
				this.eloScore,
				(this.matchAttributeFilterLessThan != null) ? this.matchAttributeFilterLessThan.Count : 0,
				(this.matchAttributeFilterEqualTo != null) ? this.matchAttributeFilterEqualTo.Count : 0,
				(this.matchAttributeFilterGreaterThan != null) ? this.matchAttributeFilterGreaterThan.Count : 0
			});
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x0003E6B0 File Offset: 0x0003C8B0
		public override bool IsValid()
		{
			int num = (this.matchAttributeFilterLessThan != null) ? this.matchAttributeFilterLessThan.Count : 0;
			num += ((this.matchAttributeFilterEqualTo != null) ? this.matchAttributeFilterEqualTo.Count : 0);
			num += ((this.matchAttributeFilterGreaterThan != null) ? this.matchAttributeFilterGreaterThan.Count : 0);
			return base.IsValid() && (this.pageSize >= 1 || this.pageSize <= 1000) && num <= 10;
		}

		// Token: 0x04000897 RID: 2199
		[Obsolete("This bool is deprecated in favor of filterOutPrivateMatches")]
		public bool includePasswordMatches;
	}
}
