using System;

namespace JetBrains.Annotations
{
	// Token: 0x02000393 RID: 915
	[Flags]
	public enum ImplicitUseKindFlags
	{
		// Token: 0x04000CD9 RID: 3289
		Default = 7,
		// Token: 0x04000CDA RID: 3290
		Access = 1,
		// Token: 0x04000CDB RID: 3291
		Assign = 2,
		// Token: 0x04000CDC RID: 3292
		InstantiatedWithFixedConstructorSignature = 4,
		// Token: 0x04000CDD RID: 3293
		InstantiatedNoFixedConstructorSignature = 8
	}
}
