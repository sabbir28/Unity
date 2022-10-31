using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000337 RID: 823
	[UsedByNativeCode]
	public struct Resolution
	{
		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x060030F5 RID: 12533 RVA: 0x0004A6F0 File Offset: 0x000488F0
		// (set) Token: 0x060030F6 RID: 12534 RVA: 0x0004A70C File Offset: 0x0004890C
		public int width
		{
			get
			{
				return this.m_Width;
			}
			set
			{
				this.m_Width = value;
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x060030F7 RID: 12535 RVA: 0x0004A718 File Offset: 0x00048918
		// (set) Token: 0x060030F8 RID: 12536 RVA: 0x0004A734 File Offset: 0x00048934
		public int height
		{
			get
			{
				return this.m_Height;
			}
			set
			{
				this.m_Height = value;
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x060030F9 RID: 12537 RVA: 0x0004A740 File Offset: 0x00048940
		// (set) Token: 0x060030FA RID: 12538 RVA: 0x0004A75C File Offset: 0x0004895C
		public int refreshRate
		{
			get
			{
				return this.m_RefreshRate;
			}
			set
			{
				this.m_RefreshRate = value;
			}
		}

		// Token: 0x060030FB RID: 12539 RVA: 0x0004A768 File Offset: 0x00048968
		public override string ToString()
		{
			return UnityString.Format("{0} x {1} @ {2}Hz", new object[]
			{
				this.m_Width,
				this.m_Height,
				this.m_RefreshRate
			});
		}

		// Token: 0x04000A94 RID: 2708
		private int m_Width;

		// Token: 0x04000A95 RID: 2709
		private int m_Height;

		// Token: 0x04000A96 RID: 2710
		private int m_RefreshRate;
	}
}
