using System;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000022 RID: 34
	public class BaseEventData : AbstractEventData
	{
		// Token: 0x06000096 RID: 150 RVA: 0x0000363F File Offset: 0x00001A3F
		public BaseEventData(EventSystem eventSystem)
		{
			this.m_EventSystem = eventSystem;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00003650 File Offset: 0x00001A50
		public BaseInputModule currentInputModule
		{
			get
			{
				return this.m_EventSystem.currentInputModule;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00003670 File Offset: 0x00001A70
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00003690 File Offset: 0x00001A90
		public GameObject selectedObject
		{
			get
			{
				return this.m_EventSystem.currentSelectedGameObject;
			}
			set
			{
				this.m_EventSystem.SetSelectedGameObject(value, this);
			}
		}

		// Token: 0x0400005E RID: 94
		private readonly EventSystem m_EventSystem;
	}
}
