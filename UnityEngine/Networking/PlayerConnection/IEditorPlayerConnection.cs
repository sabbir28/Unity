using System;
using UnityEngine.Events;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x02000422 RID: 1058
	internal interface IEditorPlayerConnection
	{
		// Token: 0x060034C7 RID: 13511
		void Register(Guid messageId, UnityAction<MessageEventArgs> callback);

		// Token: 0x060034C8 RID: 13512
		void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback);

		// Token: 0x060034C9 RID: 13513
		void RegisterConnection(UnityAction<int> callback);

		// Token: 0x060034CA RID: 13514
		void RegisterDisconnection(UnityAction<int> callback);

		// Token: 0x060034CB RID: 13515
		void Send(Guid messageId, byte[] data);
	}
}
