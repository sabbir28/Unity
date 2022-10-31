using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000C1 RID: 193
	[UsedByNativeCode]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class ProceduralPropertyDescription
	{
		// Token: 0x040001C1 RID: 449
		public string name;

		// Token: 0x040001C2 RID: 450
		public string label;

		// Token: 0x040001C3 RID: 451
		public string group;

		// Token: 0x040001C4 RID: 452
		public ProceduralPropertyType type;

		// Token: 0x040001C5 RID: 453
		public bool hasRange;

		// Token: 0x040001C6 RID: 454
		public float minimum;

		// Token: 0x040001C7 RID: 455
		public float maximum;

		// Token: 0x040001C8 RID: 456
		public float step;

		// Token: 0x040001C9 RID: 457
		public string[] enumOptions;

		// Token: 0x040001CA RID: 458
		public string[] componentLabels;
	}
}
