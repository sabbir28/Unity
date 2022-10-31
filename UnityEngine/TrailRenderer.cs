using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200004F RID: 79
	public sealed class TrailRenderer : Renderer
	{
		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000594 RID: 1428
		// (set) Token: 0x06000595 RID: 1429
		public extern float time { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000596 RID: 1430
		// (set) Token: 0x06000597 RID: 1431
		public extern float startWidth { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000598 RID: 1432
		// (set) Token: 0x06000599 RID: 1433
		public extern float endWidth { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600059A RID: 1434
		// (set) Token: 0x0600059B RID: 1435
		public extern AnimationCurve widthCurve { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600059C RID: 1436
		// (set) Token: 0x0600059D RID: 1437
		public extern float widthMultiplier { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x00007924 File Offset: 0x00005B24
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x00007944 File Offset: 0x00005B44
		public Color startColor
		{
			get
			{
				Color result;
				this.INTERNAL_get_startColor(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_startColor(ref value);
			}
		}

		// Token: 0x060005A0 RID: 1440
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_startColor(out Color value);

		// Token: 0x060005A1 RID: 1441
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_startColor(ref Color value);

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x00007950 File Offset: 0x00005B50
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x00007970 File Offset: 0x00005B70
		public Color endColor
		{
			get
			{
				Color result;
				this.INTERNAL_get_endColor(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_endColor(ref value);
			}
		}

		// Token: 0x060005A4 RID: 1444
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_endColor(out Color value);

		// Token: 0x060005A5 RID: 1445
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_endColor(ref Color value);

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060005A6 RID: 1446
		// (set) Token: 0x060005A7 RID: 1447
		public extern Gradient colorGradient { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060005A8 RID: 1448
		// (set) Token: 0x060005A9 RID: 1449
		public extern bool autodestruct { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060005AA RID: 1450
		// (set) Token: 0x060005AB RID: 1451
		public extern int numCornerVertices { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060005AC RID: 1452
		// (set) Token: 0x060005AD RID: 1453
		public extern int numCapVertices { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060005AE RID: 1454
		// (set) Token: 0x060005AF RID: 1455
		public extern float minVertexDistance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060005B0 RID: 1456
		// (set) Token: 0x060005B1 RID: 1457
		public extern LineTextureMode textureMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060005B2 RID: 1458
		// (set) Token: 0x060005B3 RID: 1459
		public extern LineAlignment alignment { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060005B4 RID: 1460
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Clear();

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060005B5 RID: 1461
		public extern int positionCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060005B6 RID: 1462
		[Obsolete("Use positionCount property (UnityUpgradable) -> positionCount")]
		public extern int numPositions { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060005B7 RID: 1463 RVA: 0x0000797C File Offset: 0x00005B7C
		public Vector3 GetPosition(int index)
		{
			Vector3 result;
			TrailRenderer.INTERNAL_CALL_GetPosition(this, index, out result);
			return result;
		}

		// Token: 0x060005B8 RID: 1464
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetPosition(TrailRenderer self, int index, out Vector3 value);

		// Token: 0x060005B9 RID: 1465
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetPositions(Vector3[] positions);
	}
}
