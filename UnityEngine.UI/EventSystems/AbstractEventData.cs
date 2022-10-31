using System;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000021 RID: 33
	public abstract class AbstractEventData
	{
		// Token: 0x06000093 RID: 147 RVA: 0x0000360E File Offset: 0x00001A0E
		public virtual void Reset()
		{
			this.m_Used = false;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003618 File Offset: 0x00001A18
		public virtual void Use()
		{
			this.m_Used = true;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00003624 File Offset: 0x00001A24
		public virtual bool used
		{
			get
			{
				return this.m_Used;
			}
		}

		// Token: 0x0400005D RID: 93
		protected bool m_Used;
	}
}
