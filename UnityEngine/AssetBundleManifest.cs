using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000013 RID: 19
	public sealed class AssetBundleManifest : Object
	{
		// Token: 0x060001A3 RID: 419
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string[] GetAllAssetBundles();

		// Token: 0x060001A4 RID: 420
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string[] GetAllAssetBundlesWithVariant();

		// Token: 0x060001A5 RID: 421 RVA: 0x00004E3C File Offset: 0x0000303C
		public Hash128 GetAssetBundleHash(string assetBundleName)
		{
			Hash128 result;
			AssetBundleManifest.INTERNAL_CALL_GetAssetBundleHash(this, assetBundleName, out result);
			return result;
		}

		// Token: 0x060001A6 RID: 422
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetAssetBundleHash(AssetBundleManifest self, string assetBundleName, out Hash128 value);

		// Token: 0x060001A7 RID: 423
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string[] GetDirectDependencies(string assetBundleName);

		// Token: 0x060001A8 RID: 424
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string[] GetAllDependencies(string assetBundleName);
	}
}
