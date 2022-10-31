using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000314 RID: 788
	[UsedByNativeCode]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public sealed class HelpURLAttribute : Attribute
	{
		// Token: 0x060030A1 RID: 12449 RVA: 0x00049334 File Offset: 0x00047534
		public HelpURLAttribute(string url)
		{
			this.m_Url = url;
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x060030A2 RID: 12450 RVA: 0x00049344 File Offset: 0x00047544
		public string URL
		{
			get
			{
				return this.m_Url;
			}
		}

		// Token: 0x040009FF RID: 2559
		internal readonly string m_Url;
	}
}
