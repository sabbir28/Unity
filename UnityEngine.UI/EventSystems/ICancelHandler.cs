using System;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000014 RID: 20
	public interface ICancelHandler : IEventSystemHandler
	{
		// Token: 0x06000011 RID: 17
		void OnCancel(BaseEventData eventData);
	}
}
