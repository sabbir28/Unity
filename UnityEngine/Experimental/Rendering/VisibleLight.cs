using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x020000FA RID: 250
	[UsedByNativeCode]
	public struct VisibleLight
	{
		// Token: 0x17000392 RID: 914
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x000176D4 File Offset: 0x000158D4
		public Light light
		{
			get
			{
				return VisibleLight.GetLightObject(this.instanceId);
			}
		}

		// Token: 0x0600117E RID: 4478
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Light GetLightObject(int instanceId);

		// Token: 0x0400023C RID: 572
		public LightType lightType;

		// Token: 0x0400023D RID: 573
		public Color finalColor;

		// Token: 0x0400023E RID: 574
		public Rect screenRect;

		// Token: 0x0400023F RID: 575
		public Matrix4x4 localToWorld;

		// Token: 0x04000240 RID: 576
		public float range;

		// Token: 0x04000241 RID: 577
		public float spotAngle;

		// Token: 0x04000242 RID: 578
		private int instanceId;

		// Token: 0x04000243 RID: 579
		public VisibleLightFlags flags;
	}
}
