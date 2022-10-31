using System;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200043D RID: 1085
	[Flags]
	public enum VisibleLightFlags
	{
		// Token: 0x04000F7D RID: 3965
		None = 0,
		// Token: 0x04000F7E RID: 3966
		IntersectsNearPlane = 1,
		// Token: 0x04000F7F RID: 3967
		IntersectsFarPlane = 2
	}
}
