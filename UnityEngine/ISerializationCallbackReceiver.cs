using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020003D3 RID: 979
	[RequiredByNativeCode]
	public interface ISerializationCallbackReceiver
	{
		// Token: 0x060032C8 RID: 13000
		void OnBeforeSerialize();

		// Token: 0x060032C9 RID: 13001
		void OnAfterDeserialize();
	}
}
