using System;

namespace UnityEngine
{
	// Token: 0x02000252 RID: 594
	public enum FocusType
	{
		// Token: 0x0400071B RID: 1819
		[Obsolete("FocusType.Native now behaves the same as FocusType.Passive in all OS cases. (UnityUpgradable) -> Passive", false)]
		Native,
		// Token: 0x0400071C RID: 1820
		Keyboard,
		// Token: 0x0400071D RID: 1821
		Passive
	}
}
