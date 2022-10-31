using System;

namespace UnityEngine
{
	// Token: 0x0200001A RID: 26
	public sealed class WaitWhile : CustomYieldInstruction
	{
		// Token: 0x060001EF RID: 495 RVA: 0x00004F2C File Offset: 0x0000312C
		public WaitWhile(Func<bool> predicate)
		{
			this.m_Predicate = predicate;
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00004F3C File Offset: 0x0000313C
		public override bool keepWaiting
		{
			get
			{
				return this.m_Predicate();
			}
		}

		// Token: 0x0400002A RID: 42
		private Func<bool> m_Predicate;
	}
}
