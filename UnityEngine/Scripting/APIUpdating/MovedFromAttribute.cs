using System;

namespace UnityEngine.Scripting.APIUpdating
{
	// Token: 0x02000442 RID: 1090
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public class MovedFromAttribute : Attribute
	{
		// Token: 0x06003515 RID: 13589 RVA: 0x0005434C File Offset: 0x0005254C
		public MovedFromAttribute(string sourceNamespace)
		{
			this.Namespace = sourceNamespace;
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06003516 RID: 13590 RVA: 0x0005435C File Offset: 0x0005255C
		// (set) Token: 0x06003517 RID: 13591 RVA: 0x00054378 File Offset: 0x00052578
		public string Namespace { get; private set; }
	}
}
