using System;

namespace UnityEngine
{
	// Token: 0x0200025E RID: 606
	internal sealed class GUIAspectSizer : GUILayoutEntry
	{
		// Token: 0x060028BA RID: 10426 RVA: 0x000349EC File Offset: 0x00032BEC
		public GUIAspectSizer(float aspect, GUILayoutOption[] options) : base(0f, 0f, 0f, 0f, GUIStyle.none)
		{
			this.aspect = aspect;
			this.ApplyOptions(options);
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x00034A1C File Offset: 0x00032C1C
		public override void CalcHeight()
		{
			this.minHeight = (this.maxHeight = this.rect.width / this.aspect);
		}

		// Token: 0x0400075C RID: 1884
		private float aspect;
	}
}
