using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000311 RID: 785
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	[RequiredByNativeCode]
	public sealed class ContextMenu : Attribute
	{
		// Token: 0x0600309C RID: 12444 RVA: 0x000492E8 File Offset: 0x000474E8
		public ContextMenu(string itemName) : this(itemName, false)
		{
		}

		// Token: 0x0600309D RID: 12445 RVA: 0x000492F4 File Offset: 0x000474F4
		public ContextMenu(string itemName, bool isValidateFunction) : this(itemName, isValidateFunction, 1000000)
		{
		}

		// Token: 0x0600309E RID: 12446 RVA: 0x00049304 File Offset: 0x00047504
		public ContextMenu(string itemName, bool isValidateFunction, int priority)
		{
			this.menuItem = itemName;
			this.validate = isValidateFunction;
			this.priority = priority;
		}

		// Token: 0x040009FC RID: 2556
		public readonly string menuItem;

		// Token: 0x040009FD RID: 2557
		public readonly bool validate;

		// Token: 0x040009FE RID: 2558
		public readonly int priority;
	}
}
