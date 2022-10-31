using System;
using UnityEngine;

namespace UnityEngineInternal.Input
{
	// Token: 0x020002EE RID: 750
	public struct NativePointerEvent
	{
		// Token: 0x040009AF RID: 2479
		public NativeInputEvent baseEvent;

		// Token: 0x040009B0 RID: 2480
		public int pointerId;

		// Token: 0x040009B1 RID: 2481
		public Vector3 position;

		// Token: 0x040009B2 RID: 2482
		public Vector3 delta;

		// Token: 0x040009B3 RID: 2483
		public float pressure;

		// Token: 0x040009B4 RID: 2484
		public float rotation;

		// Token: 0x040009B5 RID: 2485
		public float tilt;

		// Token: 0x040009B6 RID: 2486
		public Vector3 radius;

		// Token: 0x040009B7 RID: 2487
		public float distance;

		// Token: 0x040009B8 RID: 2488
		public int displayIndex;
	}
}
