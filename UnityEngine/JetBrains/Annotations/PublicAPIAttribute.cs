using System;

namespace JetBrains.Annotations
{
	// Token: 0x02000395 RID: 917
	[MeansImplicitUse]
	public sealed class PublicAPIAttribute : Attribute
	{
		// Token: 0x0600314B RID: 12619 RVA: 0x0004B070 File Offset: 0x00049270
		public PublicAPIAttribute()
		{
		}

		// Token: 0x0600314C RID: 12620 RVA: 0x0004B07C File Offset: 0x0004927C
		public PublicAPIAttribute([NotNull] string comment)
		{
			this.Comment = comment;
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x0600314D RID: 12621 RVA: 0x0004B08C File Offset: 0x0004928C
		// (set) Token: 0x0600314E RID: 12622 RVA: 0x0004B0A8 File Offset: 0x000492A8
		[NotNull]
		public string Comment { get; private set; }
	}
}
