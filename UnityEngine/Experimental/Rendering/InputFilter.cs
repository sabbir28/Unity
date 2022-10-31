using System;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000432 RID: 1074
	public struct InputFilter
	{
		// Token: 0x060034F3 RID: 13555 RVA: 0x00053F0C File Offset: 0x0005210C
		public static InputFilter Default()
		{
			return new InputFilter
			{
				renderQueueMin = 0,
				renderQueueMax = 5000,
				layerMask = -1
			};
		}

		// Token: 0x060034F4 RID: 13556 RVA: 0x00053F48 File Offset: 0x00052148
		public void SetQueuesOpaque()
		{
			this.renderQueueMin = 0;
			this.renderQueueMax = 2500;
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x00053F60 File Offset: 0x00052160
		public void SetQueuesTransparent()
		{
			this.renderQueueMin = 2501;
			this.renderQueueMax = 5000;
		}

		// Token: 0x04000F57 RID: 3927
		public int renderQueueMin;

		// Token: 0x04000F58 RID: 3928
		public int renderQueueMax;

		// Token: 0x04000F59 RID: 3929
		public int layerMask;
	}
}
