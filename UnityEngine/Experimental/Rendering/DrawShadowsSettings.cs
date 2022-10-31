using System;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000431 RID: 1073
	[UsedByNativeCode]
	public struct DrawShadowsSettings
	{
		// Token: 0x060034F1 RID: 13553 RVA: 0x00053EC8 File Offset: 0x000520C8
		public DrawShadowsSettings(CullResults cullResults, int lightIndex)
		{
			this._cullResults = cullResults.cullResults;
			this.lightIndex = lightIndex;
			this.splitData.cullingPlaneCount = 0;
			this.splitData.cullingSphere = Vector4.zero;
		}

		// Token: 0x17000C1F RID: 3103
		// (set) Token: 0x060034F2 RID: 13554 RVA: 0x00053EFC File Offset: 0x000520FC
		public CullResults cullResults
		{
			set
			{
				this._cullResults = value.cullResults;
			}
		}

		// Token: 0x04000F54 RID: 3924
		private IntPtr _cullResults;

		// Token: 0x04000F55 RID: 3925
		public int lightIndex;

		// Token: 0x04000F56 RID: 3926
		public ShadowSplitData splitData;
	}
}
