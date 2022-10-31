using System;

namespace UnityEngine
{
	// Token: 0x020003C3 RID: 963
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class ColorUsageAttribute : PropertyAttribute
	{
		// Token: 0x0600326A RID: 12906 RVA: 0x0004D7B0 File Offset: 0x0004B9B0
		public ColorUsageAttribute(bool showAlpha)
		{
			this.showAlpha = showAlpha;
		}

		// Token: 0x0600326B RID: 12907 RVA: 0x0004D808 File Offset: 0x0004BA08
		public ColorUsageAttribute(bool showAlpha, bool hdr, float minBrightness, float maxBrightness, float minExposureValue, float maxExposureValue)
		{
			this.showAlpha = showAlpha;
			this.hdr = hdr;
			this.minBrightness = minBrightness;
			this.maxBrightness = maxBrightness;
			this.minExposureValue = minExposureValue;
			this.maxExposureValue = maxExposureValue;
		}

		// Token: 0x04000E8B RID: 3723
		public readonly bool showAlpha = true;

		// Token: 0x04000E8C RID: 3724
		public readonly bool hdr = false;

		// Token: 0x04000E8D RID: 3725
		public readonly float minBrightness = 0f;

		// Token: 0x04000E8E RID: 3726
		public readonly float maxBrightness = 8f;

		// Token: 0x04000E8F RID: 3727
		public readonly float minExposureValue = 0.125f;

		// Token: 0x04000E90 RID: 3728
		public readonly float maxExposureValue = 3f;
	}
}
