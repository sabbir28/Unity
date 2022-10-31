using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000098 RID: 152
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	[RequiredByNativeCode(Optional = true)]
	[Obsolete("NetworkView RPC functions are deprecated. Refer to the new Multiplayer Networking system.")]
	public sealed class RPC : Attribute
	{
	}
}
