using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x02000012 RID: 18
	public sealed class AssetBundle : Object
	{
		// Token: 0x06000174 RID: 372
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern AssetBundleCreateRequest LoadFromFileAsync(string path, [DefaultValue("0")] uint crc, [DefaultValue("0")] ulong offset);

		// Token: 0x06000175 RID: 373 RVA: 0x00004938 File Offset: 0x00002B38
		[ExcludeFromDocs]
		public static AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc)
		{
			ulong offset = 0UL;
			return AssetBundle.LoadFromFileAsync(path, crc, offset);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00004958 File Offset: 0x00002B58
		[ExcludeFromDocs]
		public static AssetBundleCreateRequest LoadFromFileAsync(string path)
		{
			ulong offset = 0UL;
			uint crc = 0U;
			return AssetBundle.LoadFromFileAsync(path, crc, offset);
		}

		// Token: 0x06000177 RID: 375
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern AssetBundle LoadFromFile(string path, [DefaultValue("0")] uint crc, [DefaultValue("0")] ulong offset);

		// Token: 0x06000178 RID: 376 RVA: 0x0000497C File Offset: 0x00002B7C
		[ExcludeFromDocs]
		public static AssetBundle LoadFromFile(string path, uint crc)
		{
			ulong offset = 0UL;
			return AssetBundle.LoadFromFile(path, crc, offset);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000499C File Offset: 0x00002B9C
		[ExcludeFromDocs]
		public static AssetBundle LoadFromFile(string path)
		{
			ulong offset = 0UL;
			uint crc = 0U;
			return AssetBundle.LoadFromFile(path, crc, offset);
		}

		// Token: 0x0600017A RID: 378
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern AssetBundleCreateRequest LoadFromMemoryAsync(byte[] binary, [DefaultValue("0")] uint crc);

		// Token: 0x0600017B RID: 379 RVA: 0x000049C0 File Offset: 0x00002BC0
		[ExcludeFromDocs]
		public static AssetBundleCreateRequest LoadFromMemoryAsync(byte[] binary)
		{
			uint crc = 0U;
			return AssetBundle.LoadFromMemoryAsync(binary, crc);
		}

		// Token: 0x0600017C RID: 380
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern AssetBundle LoadFromMemory(byte[] binary, [DefaultValue("0")] uint crc);

		// Token: 0x0600017D RID: 381 RVA: 0x000049E0 File Offset: 0x00002BE0
		[ExcludeFromDocs]
		public static AssetBundle LoadFromMemory(byte[] binary)
		{
			uint crc = 0U;
			return AssetBundle.LoadFromMemory(binary, crc);
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600017E RID: 382
		public extern Object mainAsset { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600017F RID: 383
		public extern bool isStreamedSceneAssetBundle { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000180 RID: 384
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool Contains(string name);

		// Token: 0x06000181 RID: 385 RVA: 0x00004A00 File Offset: 0x00002C00
		[Obsolete("Method Load has been deprecated. Script updater cannot update it as the loading behaviour has changed. Please use LoadAsset instead and check the documentation for details.", true)]
		public Object Load(string name)
		{
			return null;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00004A18 File Offset: 0x00002C18
		[Obsolete("Method Load has been deprecated. Script updater cannot update it as the loading behaviour has changed. Please use LoadAsset instead and check the documentation for details.", true)]
		public T Load<T>(string name) where T : Object
		{
			return (T)((object)null);
		}

		// Token: 0x06000183 RID: 387
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
		[Obsolete("Method Load has been deprecated. Script updater cannot update it as the loading behaviour has changed. Please use LoadAsset instead and check the documentation for details.", true)]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Object Load(string name, Type type);

		// Token: 0x06000184 RID: 388
		[Obsolete("Method LoadAsync has been deprecated. Script updater cannot update it as the loading behaviour has changed. Please use LoadAssetAsync instead and check the documentation for details.", true)]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AssetBundleRequest LoadAsync(string name, Type type);

		// Token: 0x06000185 RID: 389
		[Obsolete("Method LoadAll has been deprecated. Script updater cannot update it as the loading behaviour has changed. Please use LoadAllAssets instead and check the documentation for details.", true)]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Object[] LoadAll(Type type);

		// Token: 0x06000186 RID: 390 RVA: 0x00004A34 File Offset: 0x00002C34
		[Obsolete("Method LoadAll has been deprecated. Script updater cannot update it as the loading behaviour has changed. Please use LoadAllAssets instead and check the documentation for details.", true)]
		public Object[] LoadAll()
		{
			return null;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00004A4C File Offset: 0x00002C4C
		[Obsolete("Method LoadAll has been deprecated. Script updater cannot update it as the loading behaviour has changed. Please use LoadAllAssets instead and check the documentation for details.", true)]
		public T[] LoadAll<T>() where T : Object
		{
			return null;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00004A64 File Offset: 0x00002C64
		public Object LoadAsset(string name)
		{
			return this.LoadAsset(name, typeof(Object));
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00004A8C File Offset: 0x00002C8C
		public T LoadAsset<T>(string name) where T : Object
		{
			return (T)((object)this.LoadAsset(name, typeof(T)));
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00004AB8 File Offset: 0x00002CB8
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
		public Object LoadAsset(string name, Type type)
		{
			if (name == null)
			{
				throw new NullReferenceException("The input asset name cannot be null.");
			}
			if (name.Length == 0)
			{
				throw new ArgumentException("The input asset name cannot be empty.");
			}
			if (type == null)
			{
				throw new NullReferenceException("The input type cannot be null.");
			}
			return this.LoadAsset_Internal(name, type);
		}

		// Token: 0x0600018B RID: 395
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Object LoadAsset_Internal(string name, Type type);

		// Token: 0x0600018C RID: 396 RVA: 0x00004B10 File Offset: 0x00002D10
		public AssetBundleRequest LoadAssetAsync(string name)
		{
			return this.LoadAssetAsync(name, typeof(Object));
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00004B38 File Offset: 0x00002D38
		public AssetBundleRequest LoadAssetAsync<T>(string name)
		{
			return this.LoadAssetAsync(name, typeof(T));
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00004B60 File Offset: 0x00002D60
		public AssetBundleRequest LoadAssetAsync(string name, Type type)
		{
			if (name == null)
			{
				throw new NullReferenceException("The input asset name cannot be null.");
			}
			if (name.Length == 0)
			{
				throw new ArgumentException("The input asset name cannot be empty.");
			}
			if (type == null)
			{
				throw new NullReferenceException("The input type cannot be null.");
			}
			return this.LoadAssetAsync_Internal(name, type);
		}

		// Token: 0x0600018F RID: 399
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern AssetBundleRequest LoadAssetAsync_Internal(string name, Type type);

		// Token: 0x06000190 RID: 400 RVA: 0x00004BB8 File Offset: 0x00002DB8
		public Object[] LoadAssetWithSubAssets(string name)
		{
			return this.LoadAssetWithSubAssets(name, typeof(Object));
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00004BE0 File Offset: 0x00002DE0
		public T[] LoadAssetWithSubAssets<T>(string name) where T : Object
		{
			return Resources.ConvertObjects<T>(this.LoadAssetWithSubAssets(name, typeof(T)));
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00004C0C File Offset: 0x00002E0C
		public Object[] LoadAssetWithSubAssets(string name, Type type)
		{
			if (name == null)
			{
				throw new NullReferenceException("The input asset name cannot be null.");
			}
			if (name.Length == 0)
			{
				throw new ArgumentException("The input asset name cannot be empty.");
			}
			if (type == null)
			{
				throw new NullReferenceException("The input type cannot be null.");
			}
			return this.LoadAssetWithSubAssets_Internal(name, type);
		}

		// Token: 0x06000193 RID: 403
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Object[] LoadAssetWithSubAssets_Internal(string name, Type type);

		// Token: 0x06000194 RID: 404 RVA: 0x00004C64 File Offset: 0x00002E64
		public AssetBundleRequest LoadAssetWithSubAssetsAsync(string name)
		{
			return this.LoadAssetWithSubAssetsAsync(name, typeof(Object));
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00004C8C File Offset: 0x00002E8C
		public AssetBundleRequest LoadAssetWithSubAssetsAsync<T>(string name)
		{
			return this.LoadAssetWithSubAssetsAsync(name, typeof(T));
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00004CB4 File Offset: 0x00002EB4
		public AssetBundleRequest LoadAssetWithSubAssetsAsync(string name, Type type)
		{
			if (name == null)
			{
				throw new NullReferenceException("The input asset name cannot be null.");
			}
			if (name.Length == 0)
			{
				throw new ArgumentException("The input asset name cannot be empty.");
			}
			if (type == null)
			{
				throw new NullReferenceException("The input type cannot be null.");
			}
			return this.LoadAssetWithSubAssetsAsync_Internal(name, type);
		}

		// Token: 0x06000197 RID: 407
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(string name, Type type);

		// Token: 0x06000198 RID: 408 RVA: 0x00004D0C File Offset: 0x00002F0C
		public Object[] LoadAllAssets()
		{
			return this.LoadAllAssets(typeof(Object));
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00004D34 File Offset: 0x00002F34
		public T[] LoadAllAssets<T>() where T : Object
		{
			return Resources.ConvertObjects<T>(this.LoadAllAssets(typeof(T)));
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00004D60 File Offset: 0x00002F60
		public Object[] LoadAllAssets(Type type)
		{
			if (type == null)
			{
				throw new NullReferenceException("The input type cannot be null.");
			}
			return this.LoadAssetWithSubAssets_Internal("", type);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00004D94 File Offset: 0x00002F94
		public AssetBundleRequest LoadAllAssetsAsync()
		{
			return this.LoadAllAssetsAsync(typeof(Object));
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00004DBC File Offset: 0x00002FBC
		public AssetBundleRequest LoadAllAssetsAsync<T>()
		{
			return this.LoadAllAssetsAsync(typeof(T));
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00004DE4 File Offset: 0x00002FE4
		public AssetBundleRequest LoadAllAssetsAsync(Type type)
		{
			if (type == null)
			{
				throw new NullReferenceException("The input type cannot be null.");
			}
			return this.LoadAssetWithSubAssetsAsync_Internal("", type);
		}

		// Token: 0x0600019E RID: 414
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Unload(bool unloadAllLoadedObjects);

		// Token: 0x0600019F RID: 415 RVA: 0x00004E18 File Offset: 0x00003018
		[Obsolete("This method is deprecated. Use GetAllAssetNames() instead.")]
		public string[] AllAssetNames()
		{
			return this.GetAllAssetNames();
		}

		// Token: 0x060001A0 RID: 416
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string[] GetAllAssetNames();

		// Token: 0x060001A1 RID: 417
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string[] GetAllScenePaths();
	}
}
