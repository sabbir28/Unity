using System;

namespace UnityEngine
{
	// Token: 0x020003BE RID: 958
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
	public class SpaceAttribute : PropertyAttribute
	{
		// Token: 0x06003262 RID: 12898 RVA: 0x0004D714 File Offset: 0x0004B914
		public SpaceAttribute()
		{
			this.height = 8f;
		}

		// Token: 0x06003263 RID: 12899 RVA: 0x0004D728 File Offset: 0x0004B928
		public SpaceAttribute(float height)
		{
			this.height = height;
		}

		// Token: 0x04000E84 RID: 3716
		public readonly float height;
	}
}
