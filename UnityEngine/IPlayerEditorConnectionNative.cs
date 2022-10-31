using System;

namespace UnityEngine
{
	// Token: 0x0200009E RID: 158
	internal interface IPlayerEditorConnectionNative
	{
		// Token: 0x06000B53 RID: 2899
		void Initialize();

		// Token: 0x06000B54 RID: 2900
		void SendMessage(Guid messageId, byte[] data, int playerId);

		// Token: 0x06000B55 RID: 2901
		void RegisterInternal(Guid messageId);

		// Token: 0x06000B56 RID: 2902
		void UnregisterInternal(Guid messageId);

		// Token: 0x06000B57 RID: 2903
		bool IsConnected();
	}
}
