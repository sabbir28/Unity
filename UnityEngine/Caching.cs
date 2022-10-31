using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000022 RID: 34
	public sealed class Caching
	{
		// Token: 0x06000226 RID: 550 RVA: 0x00005100 File Offset: 0x00003300
		public static bool Authorize(string name, string domain, long size, string signature)
		{
			return Caching.Authorize(name, domain, size, -1, signature);
		}

		// Token: 0x06000227 RID: 551
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Authorize(string name, string domain, long size, int expiration, string signature);

		// Token: 0x06000228 RID: 552 RVA: 0x00005120 File Offset: 0x00003320
		[Obsolete("Size is now specified as a long")]
		public static bool Authorize(string name, string domain, int size, int expiration, string signature)
		{
			return Caching.Authorize(name, domain, (long)size, expiration, signature);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00005144 File Offset: 0x00003344
		[Obsolete("Size is now specified as a long")]
		public static bool Authorize(string name, string domain, int size, string signature)
		{
			return Caching.Authorize(name, domain, (long)size, signature);
		}

		// Token: 0x0600022A RID: 554
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool CleanCache();

		// Token: 0x0600022B RID: 555
		[Obsolete("this API is not for public use.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool CleanNamedCache(string name);

		// Token: 0x0600022C RID: 556
		[Obsolete("This function is obsolete and has no effect.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool DeleteFromCache(string url);

		// Token: 0x0600022D RID: 557
		[Obsolete("This function is obsolete and will always return -1. Use IsVersionCached instead.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetVersionFromCache(string url);

		// Token: 0x0600022E RID: 558 RVA: 0x00005164 File Offset: 0x00003364
		public static bool IsVersionCached(string url, int version)
		{
			Hash128 hash = new Hash128(0U, 0U, 0U, (uint)version);
			return Caching.IsVersionCached(url, hash);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000518C File Offset: 0x0000338C
		public static bool IsVersionCached(string url, Hash128 hash)
		{
			return Caching.INTERNAL_CALL_IsVersionCached(url, ref hash);
		}

		// Token: 0x06000230 RID: 560
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_IsVersionCached(string url, ref Hash128 hash);

		// Token: 0x06000231 RID: 561 RVA: 0x000051AC File Offset: 0x000033AC
		public static bool MarkAsUsed(string url, int version)
		{
			Hash128 hash = new Hash128(0U, 0U, 0U, (uint)version);
			return Caching.MarkAsUsed(url, hash);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000051D4 File Offset: 0x000033D4
		public static bool MarkAsUsed(string url, Hash128 hash)
		{
			return Caching.INTERNAL_CALL_MarkAsUsed(url, ref hash);
		}

		// Token: 0x06000233 RID: 563
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_MarkAsUsed(string url, ref Hash128 hash);

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000234 RID: 564
		[Obsolete("this API is not for public use.")]
		public static extern CacheIndex[] index { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000235 RID: 565
		public static extern long spaceFree { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000236 RID: 566
		// (set) Token: 0x06000237 RID: 567
		public static extern long maximumAvailableDiskSpace { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000238 RID: 568
		public static extern long spaceOccupied { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000239 RID: 569
		[Obsolete("Please use Caching.spaceFree instead")]
		public static extern int spaceAvailable { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600023A RID: 570
		[Obsolete("Please use Caching.spaceOccupied instead")]
		public static extern int spaceUsed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600023B RID: 571
		// (set) Token: 0x0600023C RID: 572
		public static extern int expirationDelay { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600023D RID: 573
		// (set) Token: 0x0600023E RID: 574
		public static extern bool enabled { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600023F RID: 575
		// (set) Token: 0x06000240 RID: 576
		public static extern bool compressionEnabled { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000241 RID: 577
		public static extern bool ready { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
