using System;

namespace UnityEngine.UI
{
	// Token: 0x02000065 RID: 101
	internal static class Misc
	{
		// Token: 0x06000372 RID: 882 RVA: 0x000145B8 File Offset: 0x000129B8
		public static void Destroy(Object obj)
		{
			if (obj != null)
			{
				if (Application.isPlaying)
				{
					if (obj is GameObject)
					{
						GameObject gameObject = obj as GameObject;
						gameObject.transform.parent = null;
					}
					Object.Destroy(obj);
				}
				else
				{
					Object.DestroyImmediate(obj);
				}
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00014611 File Offset: 0x00012A11
		public static void DestroyImmediate(Object obj)
		{
			if (obj != null)
			{
				if (Application.isEditor)
				{
					Object.DestroyImmediate(obj);
				}
				else
				{
					Object.Destroy(obj);
				}
			}
		}
	}
}
