using System;

namespace UnityEngine
{
	// Token: 0x0200002E RID: 46
	public struct CullingGroupEvent
	{
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600037A RID: 890 RVA: 0x000062A8 File Offset: 0x000044A8
		public int index
		{
			get
			{
				return this.m_Index;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600037B RID: 891 RVA: 0x000062C4 File Offset: 0x000044C4
		public bool isVisible
		{
			get
			{
				return (this.m_ThisState & 128) != 0;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600037C RID: 892 RVA: 0x000062EC File Offset: 0x000044EC
		public bool wasVisible
		{
			get
			{
				return (this.m_PrevState & 128) != 0;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600037D RID: 893 RVA: 0x00006314 File Offset: 0x00004514
		public bool hasBecomeVisible
		{
			get
			{
				return this.isVisible && !this.wasVisible;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00006340 File Offset: 0x00004540
		public bool hasBecomeInvisible
		{
			get
			{
				return !this.isVisible && this.wasVisible;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600037F RID: 895 RVA: 0x0000636C File Offset: 0x0000456C
		public int currentDistance
		{
			get
			{
				return (int)(this.m_ThisState & 127);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000380 RID: 896 RVA: 0x0000638C File Offset: 0x0000458C
		public int previousDistance
		{
			get
			{
				return (int)(this.m_PrevState & 127);
			}
		}

		// Token: 0x04000047 RID: 71
		private int m_Index;

		// Token: 0x04000048 RID: 72
		private byte m_PrevState;

		// Token: 0x04000049 RID: 73
		private byte m_ThisState;

		// Token: 0x0400004A RID: 74
		private const byte kIsVisibleMask = 128;

		// Token: 0x0400004B RID: 75
		private const byte kDistanceMask = 127;
	}
}
