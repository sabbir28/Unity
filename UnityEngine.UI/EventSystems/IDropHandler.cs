using System;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200000D RID: 13
	public interface IDropHandler : IEventSystemHandler
	{
		// Token: 0x0600000A RID: 10
		void OnDrop(PointerEventData eventData);
	}
}
