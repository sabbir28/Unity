using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000050 RID: 80
	public sealed class LineRenderer : Renderer
	{
		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060005BB RID: 1467
		// (set) Token: 0x060005BC RID: 1468
		public extern float startWidth { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060005BD RID: 1469
		// (set) Token: 0x060005BE RID: 1470
		public extern float endWidth { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060005BF RID: 1471
		// (set) Token: 0x060005C0 RID: 1472
		public extern AnimationCurve widthCurve { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060005C1 RID: 1473
		// (set) Token: 0x060005C2 RID: 1474
		public extern float widthMultiplier { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x000079A4 File Offset: 0x00005BA4
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x000079C4 File Offset: 0x00005BC4
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

		// Token: 0x060005C5 RID: 1477
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_startColor(out Color value);

		// Token: 0x060005C6 RID: 1478
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_startColor(ref Color value);

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x000079D0 File Offset: 0x00005BD0
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x000079F0 File Offset: 0x00005BF0
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

		// Token: 0x060005C9 RID: 1481
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_endColor(out Color value);

		// Token: 0x060005CA RID: 1482
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_endColor(ref Color value);

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060005CB RID: 1483
		// (set) Token: 0x060005CC RID: 1484
		public extern Gradient colorGradient { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060005CD RID: 1485
		// (set) Token: 0x060005CE RID: 1486
		public extern int positionCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060005CF RID: 1487
		// (set) Token: 0x060005D0 RID: 1488
		[Obsolete("Use positionCount property (UnityUpgradable) -> positionCount")]
		public extern int numPositions { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060005D1 RID: 1489 RVA: 0x000079FC File Offset: 0x00005BFC
		public void SetPosition(int index, Vector3 position)
		{
			LineRenderer.INTERNAL_CALL_SetPosition(this, index, ref position);
		}

		// Token: 0x060005D2 RID: 1490
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetPosition(LineRenderer self, int index, ref Vector3 position);

		// Token: 0x060005D3 RID: 1491 RVA: 0x00007A08 File Offset: 0x00005C08
		public Vector3 GetPosition(int index)
		{
			Vector3 result;
			LineRenderer.INTERNAL_CALL_GetPosition(this, index, out result);
			return result;
		}

		// Token: 0x060005D4 RID: 1492
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetPosition(LineRenderer self, int index, out Vector3 value);

		// Token: 0x060005D5 RID: 1493
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetPositions(Vector3[] positions);

		// Token: 0x060005D6 RID: 1494
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetPositions(Vector3[] positions);

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060005D7 RID: 1495
		// (set) Token: 0x060005D8 RID: 1496
		public extern bool useWorldSpace { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060005D9 RID: 1497
		// (set) Token: 0x060005DA RID: 1498
		public extern bool loop { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060005DB RID: 1499
		// (set) Token: 0x060005DC RID: 1500
		public extern int numCornerVertices { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060005DD RID: 1501
		// (set) Token: 0x060005DE RID: 1502
		public extern int numCapVertices { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060005DF RID: 1503
		// (set) Token: 0x060005E0 RID: 1504
		public extern LineTextureMode textureMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060005E1 RID: 1505
		// (set) Token: 0x060005E2 RID: 1506
		public extern LineAlignment alignment { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060005E3 RID: 1507 RVA: 0x00007A28 File Offset: 0x00005C28
		[Obsolete("Use startWidth, endWidth or widthCurve instead.", false)]
		public void SetWidth(float start, float end)
		{
			this.startWidth = start;
			this.endWidth = end;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00007A3C File Offset: 0x00005C3C
		[Obsolete("Use startColor, endColor or colorGradient instead.", false)]
		public void SetColors(Color start, Color end)
		{
			this.startColor = start;
			this.endColor = end;
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00007A50 File Offset: 0x00005C50
		[Obsolete("Use numPositions instead.", false)]
		public void SetVertexCount(int count)
		{
			this.numPositions = count;
		}
	}
}
