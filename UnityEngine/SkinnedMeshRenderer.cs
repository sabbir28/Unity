using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000046 RID: 70
	public class SkinnedMeshRenderer : Renderer
	{
		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600051B RID: 1307
		// (set) Token: 0x0600051C RID: 1308
		public extern Transform[] bones { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600051D RID: 1309
		// (set) Token: 0x0600051E RID: 1310
		public extern Transform rootBone { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600051F RID: 1311
		// (set) Token: 0x06000520 RID: 1312
		public extern SkinQuality quality { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000521 RID: 1313
		// (set) Token: 0x06000522 RID: 1314
		public extern Mesh sharedMesh { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000523 RID: 1315
		// (set) Token: 0x06000524 RID: 1316
		public extern bool updateWhenOffscreen { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000525 RID: 1317
		// (set) Token: 0x06000526 RID: 1318
		public extern bool skinnedMotionVectors { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x0000771C File Offset: 0x0000591C
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x0000773C File Offset: 0x0000593C
		public Bounds localBounds
		{
			get
			{
				Bounds result;
				this.INTERNAL_get_localBounds(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_localBounds(ref value);
			}
		}

		// Token: 0x06000529 RID: 1321
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_localBounds(out Bounds value);

		// Token: 0x0600052A RID: 1322
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_localBounds(ref Bounds value);

		// Token: 0x0600052B RID: 1323
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void BakeMesh(Mesh mesh);

		// Token: 0x0600052C RID: 1324
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float GetBlendShapeWeight(int index);

		// Token: 0x0600052D RID: 1325
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetBlendShapeWeight(int index, float value);
	}
}
