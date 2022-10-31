using System;
using Unity.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Collections
{
	// Token: 0x02000414 RID: 1044
	[NativeEnum(Name = "NativeCollection::Allocator")]
	[UsedByNativeCode]
	public enum Allocator
	{
		// Token: 0x04000F0E RID: 3854
		Invalid,
		// Token: 0x04000F0F RID: 3855
		None,
		// Token: 0x04000F10 RID: 3856
		Temp,
		// Token: 0x04000F11 RID: 3857
		TempJob,
		// Token: 0x04000F12 RID: 3858
		Persistent
	}
}
