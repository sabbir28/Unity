using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001E2 RID: 482
	[UsedByNativeCode]
	public struct WebCamDevice
	{
		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x0600212F RID: 8495 RVA: 0x00026BEC File Offset: 0x00024DEC
		public string name
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06002130 RID: 8496 RVA: 0x00026C08 File Offset: 0x00024E08
		public bool isFrontFacing
		{
			get
			{
				return (this.m_Flags & 1) == 1;
			}
		}

		// Token: 0x0400051D RID: 1309
		internal string m_Name;

		// Token: 0x0400051E RID: 1310
		internal int m_Flags;
	}
}
