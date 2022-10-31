using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200009B RID: 155
	[RequiredByNativeCode(Optional = true)]
	public struct NetworkMessageInfo
	{
		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x0000FC48 File Offset: 0x0000DE48
		public double timestamp
		{
			get
			{
				return this.m_TimeStamp;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x0000FC64 File Offset: 0x0000DE64
		public NetworkPlayer sender
		{
			get
			{
				return this.m_Sender;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x0000FC80 File Offset: 0x0000DE80
		public NetworkView networkView
		{
			get
			{
				NetworkView result;
				if (this.m_ViewID == NetworkViewID.unassigned)
				{
					Debug.LogError("No NetworkView is assigned to this NetworkMessageInfo object. Note that this is expected in OnNetworkInstantiate().");
					result = this.NullNetworkView();
				}
				else
				{
					result = NetworkView.Find(this.m_ViewID);
				}
				return result;
			}
		}

		// Token: 0x06000B4A RID: 2890
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern NetworkView NullNetworkView();

		// Token: 0x0400014F RID: 335
		private double m_TimeStamp;

		// Token: 0x04000150 RID: 336
		private NetworkPlayer m_Sender;

		// Token: 0x04000151 RID: 337
		private NetworkViewID m_ViewID;
	}
}
