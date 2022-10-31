using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x020000B2 RID: 178
	public sealed class SplashScreen
	{
		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000DB0 RID: 3504
		public static extern bool isFinished { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000DB1 RID: 3505
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Begin();

		// Token: 0x06000DB2 RID: 3506
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Draw();
	}
}
