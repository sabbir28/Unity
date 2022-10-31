using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.SceneManagement
{
	// Token: 0x020000E8 RID: 232
	public static class SceneUtility
	{
		// Token: 0x060010D7 RID: 4311
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string GetScenePathByBuildIndex(int buildIndex);

		// Token: 0x060010D8 RID: 4312
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetBuildIndexByScenePath(string scenePath);
	}
}
