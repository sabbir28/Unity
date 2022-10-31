using System;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000020 RID: 32
	public class AxisEventData : BaseEventData
	{
		// Token: 0x0600008D RID: 141 RVA: 0x000036A0 File Offset: 0x00001AA0
		public AxisEventData(EventSystem eventSystem) : base(eventSystem)
		{
			this.moveVector = Vector2.zero;
			this.moveDir = MoveDirection.None;
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000036BC File Offset: 0x00001ABC
		// (set) Token: 0x0600008F RID: 143 RVA: 0x000036D6 File Offset: 0x00001AD6
		public Vector2 moveVector { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000036E0 File Offset: 0x00001AE0
		// (set) Token: 0x06000091 RID: 145 RVA: 0x000036FA File Offset: 0x00001AFA
		public MoveDirection moveDir { get; set; }
	}
}
