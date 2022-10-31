using System;
using System.Collections;

namespace UnityEngine
{
	// Token: 0x02000019 RID: 25
	public abstract class CustomYieldInstruction : IEnumerator
	{
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001EB RID: 491
		public abstract bool keepWaiting { get; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00004EF4 File Offset: 0x000030F4
		public object Current
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00004F0C File Offset: 0x0000310C
		public bool MoveNext()
		{
			return this.keepWaiting;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00004F28 File Offset: 0x00003128
		public void Reset()
		{
		}
	}
}
