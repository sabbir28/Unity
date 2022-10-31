using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.SceneManagement
{
	// Token: 0x020000E4 RID: 228
	public struct Scene
	{
		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001088 RID: 4232 RVA: 0x000163E8 File Offset: 0x000145E8
		internal int handle
		{
			get
			{
				return this.m_Handle;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001089 RID: 4233 RVA: 0x00016404 File Offset: 0x00014604
		internal Scene.LoadingState loadingState
		{
			get
			{
				return Scene.GetLoadingStateInternal(this.handle);
			}
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00016424 File Offset: 0x00014624
		public bool IsValid()
		{
			return Scene.IsValidInternal(this.handle);
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x0600108B RID: 4235 RVA: 0x00016444 File Offset: 0x00014644
		public string path
		{
			get
			{
				return Scene.GetPathInternal(this.handle);
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x00016464 File Offset: 0x00014664
		// (set) Token: 0x0600108D RID: 4237 RVA: 0x00016484 File Offset: 0x00014684
		public string name
		{
			get
			{
				return Scene.GetNameInternal(this.handle);
			}
			internal set
			{
				Scene.SetNameInternal(this.handle, value);
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x0600108E RID: 4238 RVA: 0x00016494 File Offset: 0x00014694
		internal string guid
		{
			get
			{
				return Scene.GetGUIDInternal(this.handle);
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x0600108F RID: 4239 RVA: 0x000164B4 File Offset: 0x000146B4
		public bool isLoaded
		{
			get
			{
				return Scene.GetIsLoadedInternal(this.handle);
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001090 RID: 4240 RVA: 0x000164D4 File Offset: 0x000146D4
		public int buildIndex
		{
			get
			{
				return Scene.GetBuildIndexInternal(this.handle);
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x000164F4 File Offset: 0x000146F4
		public bool isDirty
		{
			get
			{
				return Scene.GetIsDirtyInternal(this.handle);
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001092 RID: 4242 RVA: 0x00016514 File Offset: 0x00014714
		public int rootCount
		{
			get
			{
				return Scene.GetRootCountInternal(this.handle);
			}
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x00016534 File Offset: 0x00014734
		public GameObject[] GetRootGameObjects()
		{
			List<GameObject> list = new List<GameObject>(this.rootCount);
			this.GetRootGameObjects(list);
			return list.ToArray();
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x00016564 File Offset: 0x00014764
		public void GetRootGameObjects(List<GameObject> rootGameObjects)
		{
			if (rootGameObjects.Capacity < this.rootCount)
			{
				rootGameObjects.Capacity = this.rootCount;
			}
			rootGameObjects.Clear();
			if (!this.IsValid())
			{
				throw new ArgumentException("The scene is invalid.");
			}
			if (!this.isLoaded)
			{
				throw new ArgumentException("The scene is not loaded.");
			}
			if (this.rootCount != 0)
			{
				Scene.GetRootGameObjectsInternal(this.handle, rootGameObjects);
			}
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x000165E0 File Offset: 0x000147E0
		public static bool operator ==(Scene lhs, Scene rhs)
		{
			return lhs.handle == rhs.handle;
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x00016608 File Offset: 0x00014808
		public static bool operator !=(Scene lhs, Scene rhs)
		{
			return lhs.handle != rhs.handle;
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x00016630 File Offset: 0x00014830
		public override int GetHashCode()
		{
			return this.m_Handle;
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x0001664C File Offset: 0x0001484C
		public override bool Equals(object other)
		{
			bool result;
			if (!(other is Scene))
			{
				result = false;
			}
			else
			{
				Scene scene = (Scene)other;
				result = (this.handle == scene.handle);
			}
			return result;
		}

		// Token: 0x06001099 RID: 4249
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsValidInternal(int sceneHandle);

		// Token: 0x0600109A RID: 4250
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string GetPathInternal(int sceneHandle);

		// Token: 0x0600109B RID: 4251
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string GetNameInternal(int sceneHandle);

		// Token: 0x0600109C RID: 4252
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetNameInternal(int sceneHandle, string name);

		// Token: 0x0600109D RID: 4253
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string GetGUIDInternal(int sceneHandle);

		// Token: 0x0600109E RID: 4254
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetIsLoadedInternal(int sceneHandle);

		// Token: 0x0600109F RID: 4255
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Scene.LoadingState GetLoadingStateInternal(int sceneHandle);

		// Token: 0x060010A0 RID: 4256
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetIsDirtyInternal(int sceneHandle);

		// Token: 0x060010A1 RID: 4257
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetBuildIndexInternal(int sceneHandle);

		// Token: 0x060010A2 RID: 4258
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetRootCountInternal(int sceneHandle);

		// Token: 0x060010A3 RID: 4259
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetRootGameObjectsInternal(int sceneHandle, object resultRootList);

		// Token: 0x0400021B RID: 539
		private int m_Handle;

		// Token: 0x020000E5 RID: 229
		internal enum LoadingState
		{
			// Token: 0x0400021D RID: 541
			NotLoaded,
			// Token: 0x0400021E RID: 542
			Loading,
			// Token: 0x0400021F RID: 543
			Loaded
		}
	}
}
