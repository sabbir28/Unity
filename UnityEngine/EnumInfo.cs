using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000334 RID: 820
	internal class EnumInfo
	{
		// Token: 0x060030EF RID: 12527 RVA: 0x0004A620 File Offset: 0x00048820
		[UsedByNativeCode]
		internal static EnumInfo CreateEnumInfoFromNativeEnum(string[] names, int[] values, string[] annotations, bool isFlags)
		{
			return new EnumInfo
			{
				names = names,
				values = values,
				annotations = annotations,
				isFlags = isFlags
			};
		}

		// Token: 0x04000A8E RID: 2702
		public string[] names;

		// Token: 0x04000A8F RID: 2703
		public int[] values;

		// Token: 0x04000A90 RID: 2704
		public string[] annotations;

		// Token: 0x04000A91 RID: 2705
		public bool isFlags;
	}
}
