using System;

namespace UnityEngine
{
	// Token: 0x02000447 RID: 1095
	public sealed class StaticBatchingUtility
	{
		// Token: 0x06003527 RID: 13607 RVA: 0x00054654 File Offset: 0x00052854
		public static void Combine(GameObject staticBatchRoot)
		{
			InternalStaticBatchingUtility.CombineRoot(staticBatchRoot);
		}

		// Token: 0x06003528 RID: 13608 RVA: 0x00054660 File Offset: 0x00052860
		public static void Combine(GameObject[] gos, GameObject staticBatchRoot)
		{
			InternalStaticBatchingUtility.CombineGameObjects(gos, staticBatchRoot, false);
		}
	}
}
