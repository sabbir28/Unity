using System;

namespace UnityEngine
{
	// Token: 0x02000215 RID: 533
	public struct HumanPose
	{
		// Token: 0x0600238E RID: 9102 RVA: 0x00028D6C File Offset: 0x00026F6C
		internal void Init()
		{
			if (this.muscles != null)
			{
				if (this.muscles.Length != HumanTrait.MuscleCount)
				{
					throw new ArgumentException("Bad array size for HumanPose.muscles. Size must equal HumanTrait.MuscleCount");
				}
			}
			if (this.muscles == null)
			{
				this.muscles = new float[HumanTrait.MuscleCount];
				if (this.bodyRotation.x == 0f && this.bodyRotation.y == 0f && this.bodyRotation.z == 0f && this.bodyRotation.w == 0f)
				{
					this.bodyRotation.w = 1f;
				}
			}
		}

		// Token: 0x0400062F RID: 1583
		public Vector3 bodyPosition;

		// Token: 0x04000630 RID: 1584
		public Quaternion bodyRotation;

		// Token: 0x04000631 RID: 1585
		public float[] muscles;
	}
}
