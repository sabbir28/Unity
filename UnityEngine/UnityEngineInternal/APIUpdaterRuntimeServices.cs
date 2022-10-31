using System;
using UnityEngine;

namespace UnityEngineInternal
{
	// Token: 0x0200044E RID: 1102
	public sealed class APIUpdaterRuntimeServices
	{
		// Token: 0x06003536 RID: 13622 RVA: 0x00054E38 File Offset: 0x00053038
		[Obsolete("Method is not meant to be used at runtime. Please, replace this call with GameObject.AddComponent<T>()/GameObject.AddComponent(Type).", true)]
		public static Component AddComponent(GameObject go, string sourceInfo, string name)
		{
			throw new Exception();
		}
	}
}
