using System;
using System.Collections.Generic;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000333 RID: 819
	[UsedByNativeCode]
	internal struct DiagnosticSwitch
	{
		// Token: 0x060030ED RID: 12525 RVA: 0x0004A5B4 File Offset: 0x000487B4
		[UsedByNativeCode]
		private static void AppendDiagnosticSwitchToList(List<DiagnosticSwitch> list, string name, string description, DiagnosticSwitchFlags flags, object value, object minValue, object maxValue, object persistentValue, EnumInfo enumInfo)
		{
			list.Add(new DiagnosticSwitch
			{
				name = name,
				description = description,
				flags = flags,
				value = value,
				minValue = minValue,
				maxValue = maxValue,
				persistentValue = persistentValue,
				enumInfo = enumInfo
			});
		}

		// Token: 0x04000A86 RID: 2694
		public string name;

		// Token: 0x04000A87 RID: 2695
		public string description;

		// Token: 0x04000A88 RID: 2696
		public DiagnosticSwitchFlags flags;

		// Token: 0x04000A89 RID: 2697
		public object value;

		// Token: 0x04000A8A RID: 2698
		public object minValue;

		// Token: 0x04000A8B RID: 2699
		public object maxValue;

		// Token: 0x04000A8C RID: 2700
		public object persistentValue;

		// Token: 0x04000A8D RID: 2701
		public EnumInfo enumInfo;
	}
}
