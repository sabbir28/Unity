using System;

namespace UnityEngine
{
	// Token: 0x020003F8 RID: 1016
	public class WaitForSecondsRealtime : CustomYieldInstruction
	{
		// Token: 0x060033EE RID: 13294 RVA: 0x00052138 File Offset: 0x00050338
		public WaitForSecondsRealtime(float time)
		{
			this.waitTime = Time.realtimeSinceStartup + time;
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x060033EF RID: 13295 RVA: 0x00052150 File Offset: 0x00050350
		public override bool keepWaiting
		{
			get
			{
				return Time.realtimeSinceStartup < this.waitTime;
			}
		}

		// Token: 0x04000EEB RID: 3819
		private float waitTime;
	}
}
