using System;

namespace UnityEngine
{
	// Token: 0x0200001B RID: 27
	public sealed class WaitUntil : CustomYieldInstruction
	{
		// Token: 0x060001F1 RID: 497 RVA: 0x00004F5C File Offset: 0x0000315C
		public WaitUntil(Func<bool> predicate)
		{
			this.m_Predicate = predicate;
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00004F6C File Offset: 0x0000316C
		public override bool keepWaiting
		{
			get
			{
				return !this.m_Predicate();
			}
		}

		// Token: 0x0400002B RID: 43
		private Func<bool> m_Predicate;
	}
}
