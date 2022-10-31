using System;

namespace JetBrains.Annotations
{
	// Token: 0x02000391 RID: 913
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class UsedImplicitlyAttribute : Attribute
	{
		// Token: 0x0600313B RID: 12603 RVA: 0x0004AF58 File Offset: 0x00049158
		public UsedImplicitlyAttribute() : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
		{
		}

		// Token: 0x0600313C RID: 12604 RVA: 0x0004AF64 File Offset: 0x00049164
		public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags) : this(useKindFlags, ImplicitUseTargetFlags.Default)
		{
		}

		// Token: 0x0600313D RID: 12605 RVA: 0x0004AF70 File Offset: 0x00049170
		public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags) : this(ImplicitUseKindFlags.Default, targetFlags)
		{
		}

		// Token: 0x0600313E RID: 12606 RVA: 0x0004AF7C File Offset: 0x0004917C
		public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
		{
			this.UseKindFlags = useKindFlags;
			this.TargetFlags = targetFlags;
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x0600313F RID: 12607 RVA: 0x0004AF94 File Offset: 0x00049194
		// (set) Token: 0x06003140 RID: 12608 RVA: 0x0004AFB0 File Offset: 0x000491B0
		public ImplicitUseKindFlags UseKindFlags { get; private set; }

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06003141 RID: 12609 RVA: 0x0004AFBC File Offset: 0x000491BC
		// (set) Token: 0x06003142 RID: 12610 RVA: 0x0004AFD8 File Offset: 0x000491D8
		public ImplicitUseTargetFlags TargetFlags { get; private set; }
	}
}
