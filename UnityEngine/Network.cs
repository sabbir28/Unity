using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x02000096 RID: 150
	public sealed class Network
	{
		// Token: 0x06000AAC RID: 2732
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern NetworkConnectionError InitializeServer(int connections, int listenPort, bool useNat);

		// Token: 0x06000AAD RID: 2733
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern NetworkConnectionError Internal_InitializeServerDeprecated(int connections, int listenPort);

		// Token: 0x06000AAE RID: 2734 RVA: 0x0000F568 File Offset: 0x0000D768
		[Obsolete("Use the IntializeServer(connections, listenPort, useNat) function instead")]
		public static NetworkConnectionError InitializeServer(int connections, int listenPort)
		{
			return Network.Internal_InitializeServerDeprecated(connections, listenPort);
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000AAF RID: 2735
		// (set) Token: 0x06000AB0 RID: 2736
		public static extern string incomingPassword { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000AB1 RID: 2737
		// (set) Token: 0x06000AB2 RID: 2738
		public static extern NetworkLogLevel logLevel { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000AB3 RID: 2739
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void InitializeSecurity();

		// Token: 0x06000AB4 RID: 2740
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern NetworkConnectionError Internal_ConnectToSingleIP(string IP, int remotePort, int localPort, [DefaultValue("\"\"")] string password);

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0000F584 File Offset: 0x0000D784
		[ExcludeFromDocs]
		private static NetworkConnectionError Internal_ConnectToSingleIP(string IP, int remotePort, int localPort)
		{
			string password = "";
			return Network.Internal_ConnectToSingleIP(IP, remotePort, localPort, password);
		}

		// Token: 0x06000AB6 RID: 2742
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern NetworkConnectionError Internal_ConnectToGuid(string guid, string password);

		// Token: 0x06000AB7 RID: 2743
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern NetworkConnectionError Internal_ConnectToIPs(string[] IP, int remotePort, int localPort, [DefaultValue("\"\"")] string password);

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0000F5A8 File Offset: 0x0000D7A8
		[ExcludeFromDocs]
		private static NetworkConnectionError Internal_ConnectToIPs(string[] IP, int remotePort, int localPort)
		{
			string password = "";
			return Network.Internal_ConnectToIPs(IP, remotePort, localPort, password);
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0000F5CC File Offset: 0x0000D7CC
		[ExcludeFromDocs]
		public static NetworkConnectionError Connect(string IP, int remotePort)
		{
			string password = "";
			return Network.Connect(IP, remotePort, password);
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x0000F5F0 File Offset: 0x0000D7F0
		public static NetworkConnectionError Connect(string IP, int remotePort, [DefaultValue("\"\"")] string password)
		{
			return Network.Internal_ConnectToSingleIP(IP, remotePort, 0, password);
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x0000F610 File Offset: 0x0000D810
		[ExcludeFromDocs]
		public static NetworkConnectionError Connect(string[] IPs, int remotePort)
		{
			string password = "";
			return Network.Connect(IPs, remotePort, password);
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x0000F634 File Offset: 0x0000D834
		public static NetworkConnectionError Connect(string[] IPs, int remotePort, [DefaultValue("\"\"")] string password)
		{
			return Network.Internal_ConnectToIPs(IPs, remotePort, 0, password);
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0000F654 File Offset: 0x0000D854
		[ExcludeFromDocs]
		public static NetworkConnectionError Connect(string GUID)
		{
			string password = "";
			return Network.Connect(GUID, password);
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x0000F678 File Offset: 0x0000D878
		public static NetworkConnectionError Connect(string GUID, [DefaultValue("\"\"")] string password)
		{
			return Network.Internal_ConnectToGuid(GUID, password);
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x0000F694 File Offset: 0x0000D894
		[ExcludeFromDocs]
		public static NetworkConnectionError Connect(HostData hostData)
		{
			string password = "";
			return Network.Connect(hostData, password);
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0000F6B8 File Offset: 0x0000D8B8
		public static NetworkConnectionError Connect(HostData hostData, [DefaultValue("\"\"")] string password)
		{
			if (hostData == null)
			{
				throw new NullReferenceException();
			}
			NetworkConnectionError result;
			if (hostData.guid.Length > 0 && hostData.useNat)
			{
				result = Network.Connect(hostData.guid, password);
			}
			else
			{
				result = Network.Connect(hostData.ip, hostData.port, password);
			}
			return result;
		}

		// Token: 0x06000AC1 RID: 2753
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Disconnect([DefaultValue("200")] int timeout);

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0000F71C File Offset: 0x0000D91C
		[ExcludeFromDocs]
		public static void Disconnect()
		{
			int timeout = 200;
			Network.Disconnect(timeout);
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0000F738 File Offset: 0x0000D938
		public static void CloseConnection(NetworkPlayer target, bool sendDisconnectionNotification)
		{
			Network.INTERNAL_CALL_CloseConnection(ref target, sendDisconnectionNotification);
		}

		// Token: 0x06000AC4 RID: 2756
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_CloseConnection(ref NetworkPlayer target, bool sendDisconnectionNotification);

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000AC5 RID: 2757
		public static extern NetworkPlayer[] connections { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000AC6 RID: 2758
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetPlayer();

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x0000F744 File Offset: 0x0000D944
		public static NetworkPlayer player
		{
			get
			{
				NetworkPlayer result;
				result.index = Network.Internal_GetPlayer();
				return result;
			}
		}

		// Token: 0x06000AC8 RID: 2760
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_AllocateViewID(out NetworkViewID viewID);

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0000F768 File Offset: 0x0000D968
		public static NetworkViewID AllocateViewID()
		{
			NetworkViewID result;
			Network.Internal_AllocateViewID(out result);
			return result;
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0000F788 File Offset: 0x0000D988
		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object prefab, Vector3 position, Quaternion rotation, int group)
		{
			return Network.INTERNAL_CALL_Instantiate(prefab, ref position, ref rotation, group);
		}

		// Token: 0x06000ACB RID: 2763
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Object INTERNAL_CALL_Instantiate(Object prefab, ref Vector3 position, ref Quaternion rotation, int group);

		// Token: 0x06000ACC RID: 2764 RVA: 0x0000F7A8 File Offset: 0x0000D9A8
		public static void Destroy(NetworkViewID viewID)
		{
			Network.INTERNAL_CALL_Destroy(ref viewID);
		}

		// Token: 0x06000ACD RID: 2765
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Destroy(ref NetworkViewID viewID);

		// Token: 0x06000ACE RID: 2766 RVA: 0x0000F7B4 File Offset: 0x0000D9B4
		public static void Destroy(GameObject gameObject)
		{
			if (gameObject != null)
			{
				NetworkView component = gameObject.GetComponent<NetworkView>();
				if (component != null)
				{
					Network.Destroy(component.viewID);
				}
				else
				{
					Debug.LogError("Couldn't destroy game object because no network view is attached to it.", gameObject);
				}
			}
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x0000F800 File Offset: 0x0000DA00
		public static void DestroyPlayerObjects(NetworkPlayer playerID)
		{
			Network.INTERNAL_CALL_DestroyPlayerObjects(ref playerID);
		}

		// Token: 0x06000AD0 RID: 2768
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DestroyPlayerObjects(ref NetworkPlayer playerID);

		// Token: 0x06000AD1 RID: 2769 RVA: 0x0000F80C File Offset: 0x0000DA0C
		private static void Internal_RemoveRPCs(NetworkPlayer playerID, NetworkViewID viewID, uint channelMask)
		{
			Network.INTERNAL_CALL_Internal_RemoveRPCs(ref playerID, ref viewID, channelMask);
		}

		// Token: 0x06000AD2 RID: 2770
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_RemoveRPCs(ref NetworkPlayer playerID, ref NetworkViewID viewID, uint channelMask);

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0000F81C File Offset: 0x0000DA1C
		public static void RemoveRPCs(NetworkPlayer playerID)
		{
			Network.Internal_RemoveRPCs(playerID, NetworkViewID.unassigned, uint.MaxValue);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0000F82C File Offset: 0x0000DA2C
		public static void RemoveRPCs(NetworkPlayer playerID, int group)
		{
			Network.Internal_RemoveRPCs(playerID, NetworkViewID.unassigned, 1U << group);
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0000F840 File Offset: 0x0000DA40
		public static void RemoveRPCs(NetworkViewID viewID)
		{
			Network.Internal_RemoveRPCs(NetworkPlayer.unassigned, viewID, uint.MaxValue);
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0000F850 File Offset: 0x0000DA50
		public static void RemoveRPCsInGroup(int group)
		{
			Network.Internal_RemoveRPCs(NetworkPlayer.unassigned, NetworkViewID.unassigned, 1U << group);
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000AD7 RID: 2775
		public static extern bool isClient { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000AD8 RID: 2776
		public static extern bool isServer { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000AD9 RID: 2777
		public static extern NetworkPeerType peerType { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000ADA RID: 2778
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetLevelPrefix(int prefix);

		// Token: 0x06000ADB RID: 2779 RVA: 0x0000F868 File Offset: 0x0000DA68
		public static int GetLastPing(NetworkPlayer player)
		{
			return Network.INTERNAL_CALL_GetLastPing(ref player);
		}

		// Token: 0x06000ADC RID: 2780
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_GetLastPing(ref NetworkPlayer player);

		// Token: 0x06000ADD RID: 2781 RVA: 0x0000F884 File Offset: 0x0000DA84
		public static int GetAveragePing(NetworkPlayer player)
		{
			return Network.INTERNAL_CALL_GetAveragePing(ref player);
		}

		// Token: 0x06000ADE RID: 2782
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_GetAveragePing(ref NetworkPlayer player);

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000ADF RID: 2783
		// (set) Token: 0x06000AE0 RID: 2784
		public static extern float sendRate { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000AE1 RID: 2785
		// (set) Token: 0x06000AE2 RID: 2786
		public static extern bool isMessageQueueRunning { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0000F8A0 File Offset: 0x0000DAA0
		public static void SetReceivingEnabled(NetworkPlayer player, int group, bool enabled)
		{
			Network.INTERNAL_CALL_SetReceivingEnabled(ref player, group, enabled);
		}

		// Token: 0x06000AE4 RID: 2788
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetReceivingEnabled(ref NetworkPlayer player, int group, bool enabled);

		// Token: 0x06000AE5 RID: 2789
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetSendingGlobal(int group, bool enabled);

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0000F8AC File Offset: 0x0000DAAC
		private static void Internal_SetSendingSpecific(NetworkPlayer player, int group, bool enabled)
		{
			Network.INTERNAL_CALL_Internal_SetSendingSpecific(ref player, group, enabled);
		}

		// Token: 0x06000AE7 RID: 2791
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_SetSendingSpecific(ref NetworkPlayer player, int group, bool enabled);

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0000F8B8 File Offset: 0x0000DAB8
		public static void SetSendingEnabled(int group, bool enabled)
		{
			Network.Internal_SetSendingGlobal(group, enabled);
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0000F8C4 File Offset: 0x0000DAC4
		public static void SetSendingEnabled(NetworkPlayer player, int group, bool enabled)
		{
			Network.Internal_SetSendingSpecific(player, group, enabled);
		}

		// Token: 0x06000AEA RID: 2794
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_GetTime(out double t);

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x0000F8D0 File Offset: 0x0000DAD0
		public static double time
		{
			get
			{
				double result;
				Network.Internal_GetTime(out result);
				return result;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000AEC RID: 2796
		// (set) Token: 0x06000AED RID: 2797
		public static extern int minimumAllocatableViewIDs { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000AEE RID: 2798
		// (set) Token: 0x06000AEF RID: 2799
		[Obsolete("No longer needed. This is now explicitly set in the InitializeServer function call. It is implicitly set when calling Connect depending on if an IP/port combination is used (useNat=false) or a GUID is used(useNat=true).")]
		public static extern bool useNat { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000AF0 RID: 2800
		// (set) Token: 0x06000AF1 RID: 2801
		public static extern string natFacilitatorIP { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000AF2 RID: 2802
		// (set) Token: 0x06000AF3 RID: 2803
		public static extern int natFacilitatorPort { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000AF4 RID: 2804
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern ConnectionTesterStatus TestConnection([DefaultValue("false")] bool forceTest);

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0000F8F0 File Offset: 0x0000DAF0
		[ExcludeFromDocs]
		public static ConnectionTesterStatus TestConnection()
		{
			bool forceTest = false;
			return Network.TestConnection(forceTest);
		}

		// Token: 0x06000AF6 RID: 2806
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern ConnectionTesterStatus TestConnectionNAT([DefaultValue("false")] bool forceTest);

		// Token: 0x06000AF7 RID: 2807 RVA: 0x0000F910 File Offset: 0x0000DB10
		[ExcludeFromDocs]
		public static ConnectionTesterStatus TestConnectionNAT()
		{
			bool forceTest = false;
			return Network.TestConnectionNAT(forceTest);
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000AF8 RID: 2808
		// (set) Token: 0x06000AF9 RID: 2809
		public static extern string connectionTesterIP { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000AFA RID: 2810
		// (set) Token: 0x06000AFB RID: 2811
		public static extern int connectionTesterPort { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000AFC RID: 2812
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HavePublicAddress();

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000AFD RID: 2813
		// (set) Token: 0x06000AFE RID: 2814
		public static extern int maxConnections { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000AFF RID: 2815
		// (set) Token: 0x06000B00 RID: 2816
		public static extern string proxyIP { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000B01 RID: 2817
		// (set) Token: 0x06000B02 RID: 2818
		public static extern int proxyPort { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000B03 RID: 2819
		// (set) Token: 0x06000B04 RID: 2820
		public static extern bool useProxy { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000B05 RID: 2821
		// (set) Token: 0x06000B06 RID: 2822
		public static extern string proxyPassword { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
