using System;

namespace UnityEngine
{
	// Token: 0x02000102 RID: 258
	[Flags]
	public enum DrivenTransformProperties
	{
		// Token: 0x0400025D RID: 605
		None = 0,
		// Token: 0x0400025E RID: 606
		All = -1,
		// Token: 0x0400025F RID: 607
		AnchoredPositionX = 2,
		// Token: 0x04000260 RID: 608
		AnchoredPositionY = 4,
		// Token: 0x04000261 RID: 609
		AnchoredPositionZ = 8,
		// Token: 0x04000262 RID: 610
		Rotation = 16,
		// Token: 0x04000263 RID: 611
		ScaleX = 32,
		// Token: 0x04000264 RID: 612
		ScaleY = 64,
		// Token: 0x04000265 RID: 613
		ScaleZ = 128,
		// Token: 0x04000266 RID: 614
		AnchorMinX = 256,
		// Token: 0x04000267 RID: 615
		AnchorMinY = 512,
		// Token: 0x04000268 RID: 616
		AnchorMaxX = 1024,
		// Token: 0x04000269 RID: 617
		AnchorMaxY = 2048,
		// Token: 0x0400026A RID: 618
		SizeDeltaX = 4096,
		// Token: 0x0400026B RID: 619
		SizeDeltaY = 8192,
		// Token: 0x0400026C RID: 620
		PivotX = 16384,
		// Token: 0x0400026D RID: 621
		PivotY = 32768,
		// Token: 0x0400026E RID: 622
		AnchoredPosition = 6,
		// Token: 0x0400026F RID: 623
		AnchoredPosition3D = 14,
		// Token: 0x04000270 RID: 624
		Scale = 224,
		// Token: 0x04000271 RID: 625
		AnchorMin = 768,
		// Token: 0x04000272 RID: 626
		AnchorMax = 3072,
		// Token: 0x04000273 RID: 627
		Anchors = 3840,
		// Token: 0x04000274 RID: 628
		SizeDelta = 12288,
		// Token: 0x04000275 RID: 629
		Pivot = 49152
	}
}
