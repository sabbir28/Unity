using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000315 RID: 789
	[UsedByNativeCode]
	[AttributeUsage(AttributeTargets.Class)]
	public class DefaultExecutionOrder : Attribute
	{
		// Token: 0x060030A3 RID: 12451 RVA: 0x00049360 File Offset: 0x00047560
		public DefaultExecutionOrder(int order)
		{
			this.order = order;
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x060030A4 RID: 12452 RVA: 0x00049370 File Offset: 0x00047570
		// (set) Token: 0x060030A5 RID: 12453 RVA: 0x0004938C File Offset: 0x0004758C
		public int order { get; private set; }
	}
}
