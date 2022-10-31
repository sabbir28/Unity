using System;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	// Token: 0x02000082 RID: 130
	public class ClipperRegistry
	{
		// Token: 0x060004E7 RID: 1255 RVA: 0x0001A2D4 File Offset: 0x000186D4
		protected ClipperRegistry()
		{
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x0001A2F4 File Offset: 0x000186F4
		public static ClipperRegistry instance
		{
			get
			{
				if (ClipperRegistry.s_Instance == null)
				{
					ClipperRegistry.s_Instance = new ClipperRegistry();
				}
				return ClipperRegistry.s_Instance;
			}
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0001A324 File Offset: 0x00018724
		public void Cull()
		{
			for (int i = 0; i < this.m_Clippers.Count; i++)
			{
				this.m_Clippers[i].PerformClipping();
			}
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0001A361 File Offset: 0x00018761
		public static void Register(IClipper c)
		{
			if (c != null)
			{
				ClipperRegistry.instance.m_Clippers.AddUnique(c);
			}
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0001A380 File Offset: 0x00018780
		public static void Unregister(IClipper c)
		{
			ClipperRegistry.instance.m_Clippers.Remove(c);
		}

		// Token: 0x04000255 RID: 597
		private static ClipperRegistry s_Instance;

		// Token: 0x04000256 RID: 598
		private readonly IndexedSet<IClipper> m_Clippers = new IndexedSet<IClipper>();
	}
}
