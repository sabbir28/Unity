using System;

namespace JetBrains.Annotations
{
	// Token: 0x0200038D RID: 909
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
	public sealed class ContractAnnotationAttribute : Attribute
	{
		// Token: 0x0600312D RID: 12589 RVA: 0x0004AE60 File Offset: 0x00049060
		public ContractAnnotationAttribute([NotNull] string contract) : this(contract, false)
		{
		}

		// Token: 0x0600312E RID: 12590 RVA: 0x0004AE6C File Offset: 0x0004906C
		public ContractAnnotationAttribute([NotNull] string contract, bool forceFullStates)
		{
			this.Contract = contract;
			this.ForceFullStates = forceFullStates;
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x0600312F RID: 12591 RVA: 0x0004AE84 File Offset: 0x00049084
		// (set) Token: 0x06003130 RID: 12592 RVA: 0x0004AEA0 File Offset: 0x000490A0
		public string Contract { get; private set; }

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06003131 RID: 12593 RVA: 0x0004AEAC File Offset: 0x000490AC
		// (set) Token: 0x06003132 RID: 12594 RVA: 0x0004AEC8 File Offset: 0x000490C8
		public bool ForceFullStates { get; private set; }
	}
}
