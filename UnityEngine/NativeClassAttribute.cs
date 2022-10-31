using System;

namespace UnityEngine
{
	// Token: 0x02000317 RID: 791
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
	public sealed class NativeClassAttribute : Attribute
	{
		// Token: 0x060030A7 RID: 12455 RVA: 0x000493A8 File Offset: 0x000475A8
		public NativeClassAttribute(string qualifiedCppName)
		{
			this.QualifiedNativeName = qualifiedCppName;
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x060030A8 RID: 12456 RVA: 0x000493B8 File Offset: 0x000475B8
		// (set) Token: 0x060030A9 RID: 12457 RVA: 0x000493D4 File Offset: 0x000475D4
		public string QualifiedNativeName { get; private set; }
	}
}
