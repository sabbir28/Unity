using System;

namespace UnityEngine
{
	// Token: 0x020003C0 RID: 960
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class RangeAttribute : PropertyAttribute
	{
		// Token: 0x06003265 RID: 12901 RVA: 0x0004D748 File Offset: 0x0004B948
		public RangeAttribute(float min, float max)
		{
			this.min = min;
			this.max = max;
		}

		// Token: 0x04000E86 RID: 3718
		public readonly float min;

		// Token: 0x04000E87 RID: 3719
		public readonly float max;
	}
}
