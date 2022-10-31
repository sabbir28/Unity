using System;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Director
{
	// Token: 0x020000DB RID: 219
	[RequiredByNativeCode]
	public class Playable
	{
		// Token: 0x0600101E RID: 4126 RVA: 0x00015EA4 File Offset: 0x000140A4
		public static implicit operator PlayableHandle(Playable b)
		{
			return b.handle;
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x00015EC0 File Offset: 0x000140C0
		public bool IsValid()
		{
			return this.handle.IsValid();
		}

		// Token: 0x04000203 RID: 515
		public PlayableHandle handle;
	}
}
