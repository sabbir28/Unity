using System;

namespace JetBrains.Annotations
{
	// Token: 0x02000392 RID: 914
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public sealed class MeansImplicitUseAttribute : Attribute
	{
		// Token: 0x06003143 RID: 12611 RVA: 0x0004AFE4 File Offset: 0x000491E4
		public MeansImplicitUseAttribute() : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
		{
		}

		// Token: 0x06003144 RID: 12612 RVA: 0x0004AFF0 File Offset: 0x000491F0
		public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags) : this(useKindFlags, ImplicitUseTargetFlags.Default)
		{
		}

		// Token: 0x06003145 RID: 12613 RVA: 0x0004AFFC File Offset: 0x000491FC
		public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags) : this(ImplicitUseKindFlags.Default, targetFlags)
		{
		}

		// Token: 0x06003146 RID: 12614 RVA: 0x0004B008 File Offset: 0x00049208
		public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
		{
			this.UseKindFlags = useKindFlags;
			this.TargetFlags = targetFlags;
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06003147 RID: 12615 RVA: 0x0004B020 File Offset: 0x00049220
		// (set) Token: 0x06003148 RID: 12616 RVA: 0x0004B03C File Offset: 0x0004923C
		[UsedImplicitly]
		public ImplicitUseKindFlags UseKindFlags { get; private set; }

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06003149 RID: 12617 RVA: 0x0004B048 File Offset: 0x00049248
		// (set) Token: 0x0600314A RID: 12618 RVA: 0x0004B064 File Offset: 0x00049264
		[UsedImplicitly]
		public ImplicitUseTargetFlags TargetFlags { get; private set; }
	}
}
