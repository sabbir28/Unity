using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200009C RID: 156
	public sealed class Ping
	{
		// Token: 0x06000B4B RID: 2891
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Ping(string address);

		// Token: 0x06000B4C RID: 2892
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void DestroyPing();

		// Token: 0x06000B4D RID: 2893 RVA: 0x0000FCCC File Offset: 0x0000DECC
		~Ping()
		{
			this.DestroyPing();
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000B4E RID: 2894
		public extern bool isDone { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000B4F RID: 2895
		public extern int time { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000B50 RID: 2896
		public extern string ip { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x04000152 RID: 338
		internal IntPtr m_Ptr;
	}
}
