using System;

namespace UnityEngine
{
	// Token: 0x0200030E RID: 782
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public sealed class RequireComponent : Attribute
	{
		// Token: 0x0600308E RID: 12430 RVA: 0x000491B8 File Offset: 0x000473B8
		public RequireComponent(Type requiredComponent)
		{
			this.m_Type0 = requiredComponent;
		}

		// Token: 0x0600308F RID: 12431 RVA: 0x000491C8 File Offset: 0x000473C8
		public RequireComponent(Type requiredComponent, Type requiredComponent2)
		{
			this.m_Type0 = requiredComponent;
			this.m_Type1 = requiredComponent2;
		}

		// Token: 0x06003090 RID: 12432 RVA: 0x000491E0 File Offset: 0x000473E0
		public RequireComponent(Type requiredComponent, Type requiredComponent2, Type requiredComponent3)
		{
			this.m_Type0 = requiredComponent;
			this.m_Type1 = requiredComponent2;
			this.m_Type2 = requiredComponent3;
		}

		// Token: 0x040009F4 RID: 2548
		public Type m_Type0;

		// Token: 0x040009F5 RID: 2549
		public Type m_Type1;

		// Token: 0x040009F6 RID: 2550
		public Type m_Type2;
	}
}
