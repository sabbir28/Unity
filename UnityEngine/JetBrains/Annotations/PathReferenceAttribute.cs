using System;

namespace JetBrains.Annotations
{
	// Token: 0x02000398 RID: 920
	[AttributeUsage(AttributeTargets.Parameter)]
	public class PathReferenceAttribute : Attribute
	{
		// Token: 0x06003151 RID: 12625 RVA: 0x0004B0C4 File Offset: 0x000492C4
		public PathReferenceAttribute()
		{
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x0004B0D0 File Offset: 0x000492D0
		public PathReferenceAttribute([PathReference] string basePath)
		{
			this.BasePath = basePath;
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06003153 RID: 12627 RVA: 0x0004B0E0 File Offset: 0x000492E0
		// (set) Token: 0x06003154 RID: 12628 RVA: 0x0004B0FC File Offset: 0x000492FC
		[NotNull]
		public string BasePath { get; private set; }
	}
}
