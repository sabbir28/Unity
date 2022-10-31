using System;

namespace UnityEngine
{
	// Token: 0x0200006B RID: 107
	public struct AccelerationEvent
	{
		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x00009AFC File Offset: 0x00007CFC
		public Vector3 acceleration
		{
			get
			{
				return new Vector3(this.x, this.y, this.z);
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x00009B28 File Offset: 0x00007D28
		public float deltaTime
		{
			get
			{
				return this.m_TimeDelta;
			}
		}

		// Token: 0x040000A5 RID: 165
		private float x;

		// Token: 0x040000A6 RID: 166
		private float y;

		// Token: 0x040000A7 RID: 167
		private float z;

		// Token: 0x040000A8 RID: 168
		private float m_TimeDelta;
	}
}
