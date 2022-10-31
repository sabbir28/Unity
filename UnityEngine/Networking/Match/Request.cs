using System;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	// Token: 0x0200028C RID: 652
	internal abstract class Request
	{
		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06002B74 RID: 11124 RVA: 0x0003D290 File Offset: 0x0003B490
		// (set) Token: 0x06002B75 RID: 11125 RVA: 0x0003D2AC File Offset: 0x0003B4AC
		public int version { get; set; }

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06002B76 RID: 11126 RVA: 0x0003D2B8 File Offset: 0x0003B4B8
		// (set) Token: 0x06002B77 RID: 11127 RVA: 0x0003D2D4 File Offset: 0x0003B4D4
		public SourceID sourceId { get; set; }

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06002B78 RID: 11128 RVA: 0x0003D2E0 File Offset: 0x0003B4E0
		// (set) Token: 0x06002B79 RID: 11129 RVA: 0x0003D2FC File Offset: 0x0003B4FC
		public string projectId { get; set; }

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06002B7A RID: 11130 RVA: 0x0003D308 File Offset: 0x0003B508
		// (set) Token: 0x06002B7B RID: 11131 RVA: 0x0003D324 File Offset: 0x0003B524
		public AppID appId { get; set; }

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06002B7C RID: 11132 RVA: 0x0003D330 File Offset: 0x0003B530
		// (set) Token: 0x06002B7D RID: 11133 RVA: 0x0003D34C File Offset: 0x0003B54C
		public string accessTokenString { get; set; }

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06002B7E RID: 11134 RVA: 0x0003D358 File Offset: 0x0003B558
		// (set) Token: 0x06002B7F RID: 11135 RVA: 0x0003D374 File Offset: 0x0003B574
		public int domain { get; set; }

		// Token: 0x06002B80 RID: 11136 RVA: 0x0003D380 File Offset: 0x0003B580
		public virtual bool IsValid()
		{
			return this.sourceId != SourceID.Invalid;
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x0003D3A4 File Offset: 0x0003B5A4
		public override string ToString()
		{
			return UnityString.Format("[{0}]-SourceID:0x{1},projectId:{2},accessTokenString.IsEmpty:{3},domain:{4}", new object[]
			{
				base.ToString(),
				this.sourceId.ToString("X"),
				this.projectId,
				string.IsNullOrEmpty(this.accessTokenString),
				this.domain
			});
		}

		// Token: 0x04000866 RID: 2150
		public static readonly int currentVersion = 3;
	}
}
