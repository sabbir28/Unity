using System;

namespace UnityEngine
{
	// Token: 0x02000341 RID: 833
	[Flags]
	public enum ComputeBufferType
	{
		// Token: 0x04000ACD RID: 2765
		Default = 0,
		// Token: 0x04000ACE RID: 2766
		Raw = 1,
		// Token: 0x04000ACF RID: 2767
		Append = 2,
		// Token: 0x04000AD0 RID: 2768
		Counter = 4,
		// Token: 0x04000AD1 RID: 2769
		[Obsolete("Enum member DrawIndirect has been deprecated. Use IndirectArguments instead (UnityUpgradable) -> IndirectArguments", false)]
		DrawIndirect = 256,
		// Token: 0x04000AD2 RID: 2770
		IndirectArguments = 256,
		// Token: 0x04000AD3 RID: 2771
		GPUMemory = 512
	}
}
