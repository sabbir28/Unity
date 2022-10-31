using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.SceneManagement
{
	// Token: 0x020000E7 RID: 231
	[RequiredByNativeCode]
	public class SceneManager
	{
		// Token: 0x1700037C RID: 892
		// (get) Token: 0x060010A5 RID: 4261
		public static extern int sceneCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x060010A6 RID: 4262
		public static extern int sceneCountInBuildSettings { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060010A7 RID: 4263 RVA: 0x00016694 File Offset: 0x00014894
		public static Scene GetActiveScene()
		{
			Scene result;
			SceneManager.INTERNAL_CALL_GetActiveScene(out result);
			return result;
		}

		// Token: 0x060010A8 RID: 4264
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetActiveScene(out Scene value);

		// Token: 0x060010A9 RID: 4265 RVA: 0x000166B4 File Offset: 0x000148B4
		public static bool SetActiveScene(Scene scene)
		{
			return SceneManager.INTERNAL_CALL_SetActiveScene(ref scene);
		}

		// Token: 0x060010AA RID: 4266
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_SetActiveScene(ref Scene scene);

		// Token: 0x060010AB RID: 4267 RVA: 0x000166D0 File Offset: 0x000148D0
		public static Scene GetSceneByPath(string scenePath)
		{
			Scene result;
			SceneManager.INTERNAL_CALL_GetSceneByPath(scenePath, out result);
			return result;
		}

		// Token: 0x060010AC RID: 4268
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetSceneByPath(string scenePath, out Scene value);

		// Token: 0x060010AD RID: 4269 RVA: 0x000166F0 File Offset: 0x000148F0
		public static Scene GetSceneByName(string name)
		{
			Scene result;
			SceneManager.INTERNAL_CALL_GetSceneByName(name, out result);
			return result;
		}

		// Token: 0x060010AE RID: 4270
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetSceneByName(string name, out Scene value);

		// Token: 0x060010AF RID: 4271 RVA: 0x00016710 File Offset: 0x00014910
		public static Scene GetSceneByBuildIndex(int buildIndex)
		{
			Scene result;
			SceneManager.INTERNAL_CALL_GetSceneByBuildIndex(buildIndex, out result);
			return result;
		}

		// Token: 0x060010B0 RID: 4272
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetSceneByBuildIndex(int buildIndex, out Scene value);

		// Token: 0x060010B1 RID: 4273 RVA: 0x00016730 File Offset: 0x00014930
		public static Scene GetSceneAt(int index)
		{
			Scene result;
			SceneManager.INTERNAL_CALL_GetSceneAt(index, out result);
			return result;
		}

		// Token: 0x060010B2 RID: 4274
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetSceneAt(int index, out Scene value);

		// Token: 0x060010B3 RID: 4275 RVA: 0x00016750 File Offset: 0x00014950
		[Obsolete("Use SceneManager.sceneCount and SceneManager.GetSceneAt(int index) to loop the all scenes instead.")]
		public static Scene[] GetAllScenes()
		{
			Scene[] array = new Scene[SceneManager.sceneCount];
			for (int i = 0; i < SceneManager.sceneCount; i++)
			{
				array[i] = SceneManager.GetSceneAt(i);
			}
			return array;
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x0001679C File Offset: 0x0001499C
		[ExcludeFromDocs]
		public static void LoadScene(string sceneName)
		{
			LoadSceneMode mode = LoadSceneMode.Single;
			SceneManager.LoadScene(sceneName, mode);
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x000167B4 File Offset: 0x000149B4
		public static void LoadScene(string sceneName, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode)
		{
			SceneManager.LoadSceneAsyncNameIndexInternal(sceneName, -1, mode == LoadSceneMode.Additive, true);
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x000167D0 File Offset: 0x000149D0
		[ExcludeFromDocs]
		public static void LoadScene(int sceneBuildIndex)
		{
			LoadSceneMode mode = LoadSceneMode.Single;
			SceneManager.LoadScene(sceneBuildIndex, mode);
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x000167E8 File Offset: 0x000149E8
		public static void LoadScene(int sceneBuildIndex, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode)
		{
			SceneManager.LoadSceneAsyncNameIndexInternal(null, sceneBuildIndex, mode == LoadSceneMode.Additive, true);
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00016804 File Offset: 0x00014A04
		[ExcludeFromDocs]
		public static AsyncOperation LoadSceneAsync(string sceneName)
		{
			LoadSceneMode mode = LoadSceneMode.Single;
			return SceneManager.LoadSceneAsync(sceneName, mode);
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x00016824 File Offset: 0x00014A24
		public static AsyncOperation LoadSceneAsync(string sceneName, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode)
		{
			return SceneManager.LoadSceneAsyncNameIndexInternal(sceneName, -1, mode == LoadSceneMode.Additive, false);
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x00016850 File Offset: 0x00014A50
		[ExcludeFromDocs]
		public static AsyncOperation LoadSceneAsync(int sceneBuildIndex)
		{
			LoadSceneMode mode = LoadSceneMode.Single;
			return SceneManager.LoadSceneAsync(sceneBuildIndex, mode);
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x00016870 File Offset: 0x00014A70
		public static AsyncOperation LoadSceneAsync(int sceneBuildIndex, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode)
		{
			return SceneManager.LoadSceneAsyncNameIndexInternal(null, sceneBuildIndex, mode == LoadSceneMode.Additive, false);
		}

		// Token: 0x060010BC RID: 4284
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, bool isAdditive, bool mustCompleteNextFrame);

		// Token: 0x060010BD RID: 4285 RVA: 0x0001689C File Offset: 0x00014A9C
		public static Scene CreateScene(string sceneName)
		{
			Scene result;
			SceneManager.INTERNAL_CALL_CreateScene(sceneName, out result);
			return result;
		}

		// Token: 0x060010BE RID: 4286
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_CreateScene(string sceneName, out Scene value);

		// Token: 0x060010BF RID: 4287 RVA: 0x000168BC File Offset: 0x00014ABC
		[Obsolete("Use SceneManager.UnloadSceneAsync. This function is not safe to use during triggers and under other circumstances. See Scripting reference for more details.")]
		public static bool UnloadScene(Scene scene)
		{
			return SceneManager.UnloadSceneInternal(scene);
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x000168D8 File Offset: 0x00014AD8
		private static bool UnloadSceneInternal(Scene scene)
		{
			return SceneManager.INTERNAL_CALL_UnloadSceneInternal(ref scene);
		}

		// Token: 0x060010C1 RID: 4289
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_UnloadSceneInternal(ref Scene scene);

		// Token: 0x060010C2 RID: 4290 RVA: 0x000168F4 File Offset: 0x00014AF4
		[Obsolete("Use SceneManager.UnloadSceneAsync. This function is not safe to use during triggers and under other circumstances. See Scripting reference for more details.")]
		public static bool UnloadScene(int sceneBuildIndex)
		{
			bool result;
			SceneManager.UnloadSceneNameIndexInternal("", sceneBuildIndex, true, out result);
			return result;
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x0001691C File Offset: 0x00014B1C
		[Obsolete("Use SceneManager.UnloadSceneAsync. This function is not safe to use during triggers and under other circumstances. See Scripting reference for more details.")]
		public static bool UnloadScene(string sceneName)
		{
			bool result;
			SceneManager.UnloadSceneNameIndexInternal(sceneName, -1, true, out result);
			return result;
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x00016940 File Offset: 0x00014B40
		public static AsyncOperation UnloadSceneAsync(int sceneBuildIndex)
		{
			bool flag;
			return SceneManager.UnloadSceneNameIndexInternal("", sceneBuildIndex, false, out flag);
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x00016964 File Offset: 0x00014B64
		public static AsyncOperation UnloadSceneAsync(string sceneName)
		{
			bool flag;
			return SceneManager.UnloadSceneNameIndexInternal(sceneName, -1, false, out flag);
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x00016984 File Offset: 0x00014B84
		public static AsyncOperation UnloadSceneAsync(Scene scene)
		{
			return SceneManager.UnloadSceneAsyncInternal(scene);
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x000169A0 File Offset: 0x00014BA0
		private static AsyncOperation UnloadSceneAsyncInternal(Scene scene)
		{
			return SceneManager.INTERNAL_CALL_UnloadSceneAsyncInternal(ref scene);
		}

		// Token: 0x060010C8 RID: 4296
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AsyncOperation INTERNAL_CALL_UnloadSceneAsyncInternal(ref Scene scene);

		// Token: 0x060010C9 RID: 4297
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, out bool outSuccess);

		// Token: 0x060010CA RID: 4298 RVA: 0x000169BC File Offset: 0x00014BBC
		public static void MergeScenes(Scene sourceScene, Scene destinationScene)
		{
			SceneManager.INTERNAL_CALL_MergeScenes(ref sourceScene, ref destinationScene);
		}

		// Token: 0x060010CB RID: 4299
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_MergeScenes(ref Scene sourceScene, ref Scene destinationScene);

		// Token: 0x060010CC RID: 4300 RVA: 0x000169C8 File Offset: 0x00014BC8
		public static void MoveGameObjectToScene(GameObject go, Scene scene)
		{
			SceneManager.INTERNAL_CALL_MoveGameObjectToScene(go, ref scene);
		}

		// Token: 0x060010CD RID: 4301
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_MoveGameObjectToScene(GameObject go, ref Scene scene);

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060010CE RID: 4302 RVA: 0x000169D4 File Offset: 0x00014BD4
		// (remove) Token: 0x060010CF RID: 4303 RVA: 0x00016A08 File Offset: 0x00014C08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event UnityAction<Scene, LoadSceneMode> sceneLoaded;

		// Token: 0x060010D0 RID: 4304 RVA: 0x00016A3C File Offset: 0x00014C3C
		[RequiredByNativeCode]
		private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode)
		{
			if (SceneManager.sceneLoaded != null)
			{
				SceneManager.sceneLoaded(scene, mode);
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060010D1 RID: 4305 RVA: 0x00016A58 File Offset: 0x00014C58
		// (remove) Token: 0x060010D2 RID: 4306 RVA: 0x00016A8C File Offset: 0x00014C8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event UnityAction<Scene> sceneUnloaded;

		// Token: 0x060010D3 RID: 4307 RVA: 0x00016AC0 File Offset: 0x00014CC0
		[RequiredByNativeCode]
		private static void Internal_SceneUnloaded(Scene scene)
		{
			if (SceneManager.sceneUnloaded != null)
			{
				SceneManager.sceneUnloaded(scene);
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060010D4 RID: 4308 RVA: 0x00016ADC File Offset: 0x00014CDC
		// (remove) Token: 0x060010D5 RID: 4309 RVA: 0x00016B10 File Offset: 0x00014D10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event UnityAction<Scene, Scene> activeSceneChanged;

		// Token: 0x060010D6 RID: 4310 RVA: 0x00016B44 File Offset: 0x00014D44
		[RequiredByNativeCode]
		private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene)
		{
			if (SceneManager.activeSceneChanged != null)
			{
				SceneManager.activeSceneChanged(previousActiveScene, newActiveScene);
			}
		}
	}
}
