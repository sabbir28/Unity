using System;
using UnityEngine;

namespace UnityEngineInternal.Input
{
	// Token: 0x020002F0 RID: 752
	public struct NativeTrackingEvent
	{
		// Token: 0x040009BB RID: 2491
		public NativeInputEvent baseEvent;

		// Token: 0x040009BC RID: 2492
		public int nodeId;

		// Token: 0x040009BD RID: 2493
		public Vector3 localPosition;

		// Token: 0x040009BE RID: 2494
		public Quaternion localRotation;
	}
}
