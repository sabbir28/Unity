using System;
using System.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200001D RID: 29
	internal static class RaycasterManager
	{
		// Token: 0x06000076 RID: 118 RVA: 0x0000337E File Offset: 0x0000177E
		public static void AddRaycaster(BaseRaycaster baseRaycaster)
		{
			if (!RaycasterManager.s_Raycasters.Contains(baseRaycaster))
			{
				RaycasterManager.s_Raycasters.Add(baseRaycaster);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000033A4 File Offset: 0x000017A4
		public static List<BaseRaycaster> GetRaycasters()
		{
			return RaycasterManager.s_Raycasters;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000033BE File Offset: 0x000017BE
		public static void RemoveRaycasters(BaseRaycaster baseRaycaster)
		{
			if (RaycasterManager.s_Raycasters.Contains(baseRaycaster))
			{
				RaycasterManager.s_Raycasters.Remove(baseRaycaster);
			}
		}

		// Token: 0x04000050 RID: 80
		private static readonly List<BaseRaycaster> s_Raycasters = new List<BaseRaycaster>();
	}
}
