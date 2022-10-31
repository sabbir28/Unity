using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	internal sealed class WeakListenerBindings
	{
		// Token: 0x060000FB RID: 251
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void InvokeCallbacks(object inst, GCHandle gchandle, object[] parameters);
	}
}
