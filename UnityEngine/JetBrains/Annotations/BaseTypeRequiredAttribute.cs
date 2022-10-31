using System;

namespace JetBrains.Annotations
{
	// Token: 0x02000390 RID: 912
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
	[BaseTypeRequired(typeof(Attribute))]
	public sealed class BaseTypeRequiredAttribute : Attribute
	{
		// Token: 0x06003138 RID: 12600 RVA: 0x0004AF20 File Offset: 0x00049120
		public BaseTypeRequiredAttribute([NotNull] Type baseType)
		{
			this.BaseType = baseType;
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06003139 RID: 12601 RVA: 0x0004AF30 File Offset: 0x00049130
		// (set) Token: 0x0600313A RID: 12602 RVA: 0x0004AF4C File Offset: 0x0004914C
		[NotNull]
		public Type BaseType { get; private set; }
	}
}
