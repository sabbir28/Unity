using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Networking
{
	// Token: 0x020002B8 RID: 696
	public sealed class ConnectionSimulatorConfig : IDisposable
	{
		// Token: 0x06002D5E RID: 11614
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern ConnectionSimulatorConfig(int outMinDelay, int outAvgDelay, int inMinDelay, int inAvgDelay, float packetLossPercentage);

		// Token: 0x06002D5F RID: 11615
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Dispose();

		// Token: 0x06002D60 RID: 11616 RVA: 0x00041944 File Offset: 0x0003FB44
		~ConnectionSimulatorConfig()
		{
			this.Dispose();
		}

		// Token: 0x0400092D RID: 2349
		internal IntPtr m_Ptr;
	}
}
