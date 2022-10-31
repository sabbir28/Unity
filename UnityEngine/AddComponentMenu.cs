using System;

namespace UnityEngine
{
	// Token: 0x0200030F RID: 783
	public sealed class AddComponentMenu : Attribute
	{
		// Token: 0x06003091 RID: 12433 RVA: 0x00049200 File Offset: 0x00047400
		public AddComponentMenu(string menuName)
		{
			this.m_AddComponentMenu = menuName;
			this.m_Ordering = 0;
		}

		// Token: 0x06003092 RID: 12434 RVA: 0x00049218 File Offset: 0x00047418
		public AddComponentMenu(string menuName, int order)
		{
			this.m_AddComponentMenu = menuName;
			this.m_Ordering = order;
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06003093 RID: 12435 RVA: 0x00049230 File Offset: 0x00047430
		public string componentMenu
		{
			get
			{
				return this.m_AddComponentMenu;
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06003094 RID: 12436 RVA: 0x0004924C File Offset: 0x0004744C
		public int componentOrder
		{
			get
			{
				return this.m_Ordering;
			}
		}

		// Token: 0x040009F7 RID: 2551
		private string m_AddComponentMenu;

		// Token: 0x040009F8 RID: 2552
		private int m_Ordering;
	}
}
