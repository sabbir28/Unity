using System;

namespace UnityEngine
{
	// Token: 0x02000316 RID: 790
	[AttributeUsage(AttributeTargets.Struct)]
	internal class IL2CPPStructAlignmentAttribute : Attribute
	{
		// Token: 0x060030A6 RID: 12454 RVA: 0x00049398 File Offset: 0x00047598
		public IL2CPPStructAlignmentAttribute()
		{
			this.Align = 1;
		}

		// Token: 0x04000A01 RID: 2561
		public int Align;
	}
}
