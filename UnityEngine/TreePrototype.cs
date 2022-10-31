using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000221 RID: 545
	[UsedByNativeCode]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class TreePrototype
	{
		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x060024BB RID: 9403 RVA: 0x0002A1F4 File Offset: 0x000283F4
		// (set) Token: 0x060024BC RID: 9404 RVA: 0x0002A210 File Offset: 0x00028410
		public GameObject prefab
		{
			get
			{
				return this.m_Prefab;
			}
			set
			{
				this.m_Prefab = value;
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x060024BD RID: 9405 RVA: 0x0002A21C File Offset: 0x0002841C
		// (set) Token: 0x060024BE RID: 9406 RVA: 0x0002A238 File Offset: 0x00028438
		public float bendFactor
		{
			get
			{
				return this.m_BendFactor;
			}
			set
			{
				this.m_BendFactor = value;
			}
		}

		// Token: 0x04000634 RID: 1588
		internal GameObject m_Prefab;

		// Token: 0x04000635 RID: 1589
		internal float m_BendFactor;
	}
}
