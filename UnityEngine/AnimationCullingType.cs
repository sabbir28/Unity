using System;

namespace UnityEngine
{
	// Token: 0x020001F0 RID: 496
	public enum AnimationCullingType
	{
		// Token: 0x0400053E RID: 1342
		AlwaysAnimate,
		// Token: 0x0400053F RID: 1343
		BasedOnRenderers,
		// Token: 0x04000540 RID: 1344
		[Obsolete("Enum member AnimatorCullingMode.BasedOnClipBounds has been deprecated. Use AnimationCullingType.AlwaysAnimate or AnimationCullingType.BasedOnRenderers instead")]
		BasedOnClipBounds,
		// Token: 0x04000541 RID: 1345
		[Obsolete("Enum member AnimatorCullingMode.BasedOnUserBounds has been deprecated. Use AnimationCullingType.AlwaysAnimate or AnimationCullingType.BasedOnRenderers instead")]
		BasedOnUserBounds
	}
}
