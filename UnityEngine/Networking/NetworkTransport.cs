using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Internal;
using UnityEngine.Networking.Types;
using UnityEngine.Scripting;

namespace UnityEngine.Networking
{
	// Token: 0x020002AE RID: 686
	public sealed class NetworkTransport
	{
		// Token: 0x06002C99 RID: 11417 RVA: 0x00040298 File Offset: 0x0003E498
		private NetworkTransport()
		{
		}

		// Token: 0x06002C9A RID: 11418 RVA: 0x000402A4 File Offset: 0x0003E4A4
		internal static bool DoesEndPointUsePlatformProtocols(EndPoint endPoint)
		{
			if (endPoint.GetType().FullName == "UnityEngine.PS4.SceEndPoint" || endPoint.GetType().FullName == "UnityEngine.PSVita.SceEndPoint")
			{
				SocketAddress socketAddress = endPoint.Serialize();
				if (socketAddress[8] != 0 || socketAddress[9] != 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002C9B RID: 11419 RVA: 0x00040318 File Offset: 0x0003E518
		public static int ConnectEndPoint(int hostId, EndPoint endPoint, int exceptionConnectionId, out byte error)
		{
			error = 0;
			byte[] array = new byte[]
			{
				95,
				36,
				19,
				246
			};
			if (endPoint == null)
			{
				throw new NullReferenceException("Null EndPoint provided");
			}
			if (endPoint.GetType().FullName != "UnityEngine.XboxOne.XboxOneEndPoint" && endPoint.GetType().FullName != "UnityEngine.PS4.SceEndPoint" && endPoint.GetType().FullName != "UnityEngine.PSVita.SceEndPoint")
			{
				throw new ArgumentException("Endpoint of type XboxOneEndPoint or SceEndPoint  required");
			}
			int result;
			if (endPoint.GetType().FullName == "UnityEngine.XboxOne.XboxOneEndPoint")
			{
				if (endPoint.AddressFamily != AddressFamily.InterNetworkV6)
				{
					throw new ArgumentException("XboxOneEndPoint has an invalid family");
				}
				SocketAddress socketAddress = endPoint.Serialize();
				if (socketAddress.Size != 14)
				{
					throw new ArgumentException("XboxOneEndPoint has an invalid size");
				}
				if (socketAddress[0] != 0 || socketAddress[1] != 0)
				{
					throw new ArgumentException("XboxOneEndPoint has an invalid family signature");
				}
				if (socketAddress[2] != array[0] || socketAddress[3] != array[1] || socketAddress[4] != array[2] || socketAddress[5] != array[3])
				{
					throw new ArgumentException("XboxOneEndPoint has an invalid signature");
				}
				byte[] array2 = new byte[8];
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i] = socketAddress[6 + i];
				}
				IntPtr intPtr = new IntPtr(BitConverter.ToInt64(array2, 0));
				if (intPtr == IntPtr.Zero)
				{
					throw new ArgumentException("XboxOneEndPoint has an invalid SOCKET_STORAGE pointer");
				}
				byte[] array3 = new byte[2];
				Marshal.Copy(intPtr, array3, 0, array3.Length);
				AddressFamily addressFamily = (AddressFamily)(((int)array3[1] << 8) + (int)array3[0]);
				if (addressFamily != AddressFamily.InterNetworkV6)
				{
					throw new ArgumentException("XboxOneEndPoint has corrupt or invalid SOCKET_STORAGE pointer");
				}
				result = NetworkTransport.Internal_ConnectEndPoint(hostId, intPtr, 128, exceptionConnectionId, out error);
			}
			else
			{
				SocketAddress socketAddress2 = endPoint.Serialize();
				if (socketAddress2.Size != 16)
				{
					throw new ArgumentException("EndPoint has an invalid size");
				}
				if ((int)socketAddress2[0] != socketAddress2.Size)
				{
					throw new ArgumentException("EndPoint has an invalid size value");
				}
				if (socketAddress2[1] != 2)
				{
					throw new ArgumentException("EndPoint has an invalid family value");
				}
				byte[] array4 = new byte[16];
				for (int j = 0; j < array4.Length; j++)
				{
					array4[j] = socketAddress2[j];
				}
				IntPtr intPtr2 = Marshal.AllocHGlobal(array4.Length);
				Marshal.Copy(array4, 0, intPtr2, array4.Length);
				int num = NetworkTransport.Internal_ConnectEndPoint(hostId, intPtr2, 16, exceptionConnectionId, out error);
				Marshal.FreeHGlobal(intPtr2);
				result = num;
			}
			return result;
		}

		// Token: 0x06002C9C RID: 11420 RVA: 0x000405D0 File Offset: 0x0003E7D0
		public static void Init()
		{
			NetworkTransport.InitWithNoParameters();
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x000405D8 File Offset: 0x0003E7D8
		public static void Init(GlobalConfig config)
		{
			NetworkTransport.InitWithParameters(new GlobalConfigInternal(config));
		}

		// Token: 0x06002C9E RID: 11422
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InitWithNoParameters();

		// Token: 0x06002C9F RID: 11423
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InitWithParameters(GlobalConfigInternal config);

		// Token: 0x06002CA0 RID: 11424
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Shutdown();

		// Token: 0x06002CA1 RID: 11425
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string GetAssetId(GameObject go);

		// Token: 0x06002CA2 RID: 11426
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void AddSceneId(int id);

		// Token: 0x06002CA3 RID: 11427
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetNextSceneId();

		// Token: 0x06002CA4 RID: 11428
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ConnectAsNetworkHost(int hostId, string address, int port, NetworkID network, SourceID source, NodeID node, out byte error);

		// Token: 0x06002CA5 RID: 11429
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DisconnectNetworkHost(int hostId, out byte error);

		// Token: 0x06002CA6 RID: 11430
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern NetworkEventType ReceiveRelayEventFromHost(int hostId, out byte error);

		// Token: 0x06002CA7 RID: 11431
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int ConnectToNetworkPeer(int hostId, string address, int port, int exceptionConnectionId, int relaySlotId, NetworkID network, SourceID source, NodeID node, int bytesPerSec, float bucketSizeFactor, out byte error);

		// Token: 0x06002CA8 RID: 11432 RVA: 0x000405E8 File Offset: 0x0003E7E8
		public static int ConnectToNetworkPeer(int hostId, string address, int port, int exceptionConnectionId, int relaySlotId, NetworkID network, SourceID source, NodeID node, out byte error)
		{
			return NetworkTransport.ConnectToNetworkPeer(hostId, address, port, exceptionConnectionId, relaySlotId, network, source, node, 0, 0f, out error);
		}

		// Token: 0x06002CA9 RID: 11433
		[Obsolete("GetCurrentIncomingMessageAmount has been deprecated.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCurrentIncomingMessageAmount();

		// Token: 0x06002CAA RID: 11434
		[Obsolete("GetCurrentOutgoingMessageAmount has been deprecated.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCurrentOutgoingMessageAmount();

		// Token: 0x06002CAB RID: 11435
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetIncomingMessageQueueSize(int hostId, out byte error);

		// Token: 0x06002CAC RID: 11436
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetOutgoingMessageQueueSize(int hostId, out byte error);

		// Token: 0x06002CAD RID: 11437
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCurrentRTT(int hostId, int connectionId, out byte error);

		// Token: 0x06002CAE RID: 11438
		[Obsolete("GetCurrentRtt() has been deprecated.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCurrentRtt(int hostId, int connectionId, out byte error);

		// Token: 0x06002CAF RID: 11439
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetIncomingPacketLossCount(int hostId, int connectionId, out byte error);

		// Token: 0x06002CB0 RID: 11440
		[Obsolete("GetNetworkLostPacketNum() has been deprecated.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetNetworkLostPacketNum(int hostId, int connectionId, out byte error);

		// Token: 0x06002CB1 RID: 11441
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetIncomingPacketCount(int hostId, int connectionId, out byte error);

		// Token: 0x06002CB2 RID: 11442
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetOutgoingPacketNetworkLossPercent(int hostId, int connectionId, out byte error);

		// Token: 0x06002CB3 RID: 11443
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetOutgoingPacketOverflowLossPercent(int hostId, int connectionId, out byte error);

		// Token: 0x06002CB4 RID: 11444
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetMaxAllowedBandwidth(int hostId, int connectionId, out byte error);

		// Token: 0x06002CB5 RID: 11445
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetAckBufferCount(int hostId, int connectionId, out byte error);

		// Token: 0x06002CB6 RID: 11446
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetIncomingPacketDropCountForAllHosts();

		// Token: 0x06002CB7 RID: 11447
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetIncomingPacketCountForAllHosts();

		// Token: 0x06002CB8 RID: 11448
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetOutgoingPacketCount();

		// Token: 0x06002CB9 RID: 11449
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetOutgoingPacketCountForHost(int hostId, out byte error);

		// Token: 0x06002CBA RID: 11450
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetOutgoingPacketCountForConnection(int hostId, int connectionId, out byte error);

		// Token: 0x06002CBB RID: 11451
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetOutgoingMessageCount();

		// Token: 0x06002CBC RID: 11452
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetOutgoingMessageCountForHost(int hostId, out byte error);

		// Token: 0x06002CBD RID: 11453
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetOutgoingMessageCountForConnection(int hostId, int connectionId, out byte error);

		// Token: 0x06002CBE RID: 11454
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetOutgoingUserBytesCount();

		// Token: 0x06002CBF RID: 11455
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetOutgoingUserBytesCountForHost(int hostId, out byte error);

		// Token: 0x06002CC0 RID: 11456
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetOutgoingUserBytesCountForConnection(int hostId, int connectionId, out byte error);

		// Token: 0x06002CC1 RID: 11457
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetOutgoingSystemBytesCount();

		// Token: 0x06002CC2 RID: 11458
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetOutgoingSystemBytesCountForHost(int hostId, out byte error);

		// Token: 0x06002CC3 RID: 11459
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetOutgoingSystemBytesCountForConnection(int hostId, int connectionId, out byte error);

		// Token: 0x06002CC4 RID: 11460
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetOutgoingFullBytesCount();

		// Token: 0x06002CC5 RID: 11461
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetOutgoingFullBytesCountForHost(int hostId, out byte error);

		// Token: 0x06002CC6 RID: 11462
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetOutgoingFullBytesCountForConnection(int hostId, int connectionId, out byte error);

		// Token: 0x06002CC7 RID: 11463
		[Obsolete("GetPacketSentRate has been deprecated.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetPacketSentRate(int hostId, int connectionId, out byte error);

		// Token: 0x06002CC8 RID: 11464
		[Obsolete("GetPacketReceivedRate has been deprecated.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetPacketReceivedRate(int hostId, int connectionId, out byte error);

		// Token: 0x06002CC9 RID: 11465
		[Obsolete("GetRemotePacketReceivedRate has been deprecated.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetRemotePacketReceivedRate(int hostId, int connectionId, out byte error);

		// Token: 0x06002CCA RID: 11466
		[Obsolete("GetNetIOTimeuS has been deprecated.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetNetIOTimeuS();

		// Token: 0x06002CCB RID: 11467 RVA: 0x00040618 File Offset: 0x0003E818
		public static void GetConnectionInfo(int hostId, int connectionId, out string address, out int port, out NetworkID network, out NodeID dstNode, out byte error)
		{
			ulong num;
			ushort num2;
			address = NetworkTransport.GetConnectionInfo(hostId, connectionId, out port, out num, out num2, out error);
			network = (NetworkID)num;
			dstNode = (NodeID)num2;
		}

		// Token: 0x06002CCC RID: 11468
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string GetConnectionInfo(int hostId, int connectionId, out int port, out ulong network, out ushort dstNode, out byte error);

		// Token: 0x06002CCD RID: 11469
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetNetworkTimestamp();

		// Token: 0x06002CCE RID: 11470
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetRemoteDelayTimeMS(int hostId, int connectionId, int remoteTime, out byte error);

		// Token: 0x06002CCF RID: 11471
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool StartSendMulticast(int hostId, int channelId, byte[] buffer, int size, out byte error);

		// Token: 0x06002CD0 RID: 11472
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SendMulticast(int hostId, int connectionId, out byte error);

		// Token: 0x06002CD1 RID: 11473
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool FinishSendMulticast(int hostId, out byte error);

		// Token: 0x06002CD2 RID: 11474
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetMaxPacketSize();

		// Token: 0x06002CD3 RID: 11475 RVA: 0x00040640 File Offset: 0x0003E840
		private static void CheckTopology(HostTopology topology)
		{
			int maxPacketSize = NetworkTransport.GetMaxPacketSize();
			if ((int)topology.DefaultConfig.PacketSize > maxPacketSize)
			{
				throw new ArgumentOutOfRangeException("Default config: packet size should be less than packet size defined in global config: " + maxPacketSize.ToString());
			}
			for (int i = 0; i < topology.SpecialConnectionConfigs.Count; i++)
			{
				if ((int)topology.SpecialConnectionConfigs[i].PacketSize > maxPacketSize)
				{
					throw new ArgumentOutOfRangeException("Special config " + i.ToString() + ": packet size should be less than packet size defined in global config: " + maxPacketSize.ToString());
				}
			}
		}

		// Token: 0x06002CD4 RID: 11476
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int AddWsHostWrapper(HostTopologyInternal topologyInt, string ip, int port);

		// Token: 0x06002CD5 RID: 11477
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int AddWsHostWrapperWithoutIp(HostTopologyInternal topologyInt, int port);

		// Token: 0x06002CD6 RID: 11478 RVA: 0x000406E8 File Offset: 0x0003E8E8
		[ExcludeFromDocs]
		public static int AddWebsocketHost(HostTopology topology, int port)
		{
			string ip = null;
			return NetworkTransport.AddWebsocketHost(topology, port, ip);
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x00040708 File Offset: 0x0003E908
		public static int AddWebsocketHost(HostTopology topology, int port, [DefaultValue("null")] string ip)
		{
			if (topology == null)
			{
				throw new NullReferenceException("topology is not defined");
			}
			NetworkTransport.CheckTopology(topology);
			int result;
			if (ip == null)
			{
				result = NetworkTransport.AddWsHostWrapperWithoutIp(new HostTopologyInternal(topology), port);
			}
			else
			{
				result = NetworkTransport.AddWsHostWrapper(new HostTopologyInternal(topology), ip, port);
			}
			return result;
		}

		// Token: 0x06002CD8 RID: 11480
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int AddHostWrapper(HostTopologyInternal topologyInt, string ip, int port, int minTimeout, int maxTimeout);

		// Token: 0x06002CD9 RID: 11481
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int AddHostWrapperWithoutIp(HostTopologyInternal topologyInt, int port, int minTimeout, int maxTimeout);

		// Token: 0x06002CDA RID: 11482 RVA: 0x0004075C File Offset: 0x0003E95C
		[ExcludeFromDocs]
		public static int AddHost(HostTopology topology, int port)
		{
			string ip = null;
			return NetworkTransport.AddHost(topology, port, ip);
		}

		// Token: 0x06002CDB RID: 11483 RVA: 0x0004077C File Offset: 0x0003E97C
		[ExcludeFromDocs]
		public static int AddHost(HostTopology topology)
		{
			string ip = null;
			int port = 0;
			return NetworkTransport.AddHost(topology, port, ip);
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x000407A0 File Offset: 0x0003E9A0
		public static int AddHost(HostTopology topology, [DefaultValue("0")] int port, [DefaultValue("null")] string ip)
		{
			if (topology == null)
			{
				throw new NullReferenceException("topology is not defined");
			}
			NetworkTransport.CheckTopology(topology);
			int result;
			if (ip == null)
			{
				result = NetworkTransport.AddHostWrapperWithoutIp(new HostTopologyInternal(topology), port, 0, 0);
			}
			else
			{
				result = NetworkTransport.AddHostWrapper(new HostTopologyInternal(topology), ip, port, 0, 0);
			}
			return result;
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x000407F8 File Offset: 0x0003E9F8
		[ExcludeFromDocs]
		public static int AddHostWithSimulator(HostTopology topology, int minTimeout, int maxTimeout, int port)
		{
			string ip = null;
			return NetworkTransport.AddHostWithSimulator(topology, minTimeout, maxTimeout, port, ip);
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x0004081C File Offset: 0x0003EA1C
		[ExcludeFromDocs]
		public static int AddHostWithSimulator(HostTopology topology, int minTimeout, int maxTimeout)
		{
			string ip = null;
			int port = 0;
			return NetworkTransport.AddHostWithSimulator(topology, minTimeout, maxTimeout, port, ip);
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x00040840 File Offset: 0x0003EA40
		public static int AddHostWithSimulator(HostTopology topology, int minTimeout, int maxTimeout, [DefaultValue("0")] int port, [DefaultValue("null")] string ip)
		{
			if (topology == null)
			{
				throw new NullReferenceException("topology is not defined");
			}
			int result;
			if (ip == null)
			{
				result = NetworkTransport.AddHostWrapperWithoutIp(new HostTopologyInternal(topology), port, minTimeout, maxTimeout);
			}
			else
			{
				result = NetworkTransport.AddHostWrapper(new HostTopologyInternal(topology), ip, port, minTimeout, maxTimeout);
			}
			return result;
		}

		// Token: 0x06002CE0 RID: 11488
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool RemoveHost(int hostId);

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06002CE1 RID: 11489
		public static extern bool IsStarted { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002CE2 RID: 11490
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Connect(int hostId, string address, int port, int exeptionConnectionId, out byte error);

		// Token: 0x06002CE3 RID: 11491
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_ConnectEndPoint(int hostId, IntPtr sockAddrStorage, int sockAddrStorageLen, int exceptionConnectionId, out byte error);

		// Token: 0x06002CE4 RID: 11492
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int ConnectWithSimulator(int hostId, string address, int port, int exeptionConnectionId, out byte error, ConnectionSimulatorConfig conf);

		// Token: 0x06002CE5 RID: 11493
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Disconnect(int hostId, int connectionId, out byte error);

		// Token: 0x06002CE6 RID: 11494 RVA: 0x00040894 File Offset: 0x0003EA94
		public static bool Send(int hostId, int connectionId, int channelId, byte[] buffer, int size, out byte error)
		{
			if (buffer == null)
			{
				throw new NullReferenceException("send buffer is not initialized");
			}
			return NetworkTransport.SendWrapper(hostId, connectionId, channelId, buffer, size, out error);
		}

		// Token: 0x06002CE7 RID: 11495 RVA: 0x000408C8 File Offset: 0x0003EAC8
		public static bool QueueMessageForSending(int hostId, int connectionId, int channelId, byte[] buffer, int size, out byte error)
		{
			if (buffer == null)
			{
				throw new NullReferenceException("send buffer is not initialized");
			}
			return NetworkTransport.QueueMessageForSendingWrapper(hostId, connectionId, channelId, buffer, size, out error);
		}

		// Token: 0x06002CE8 RID: 11496
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SendQueuedMessages(int hostId, int connectionId, out byte error);

		// Token: 0x06002CE9 RID: 11497
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool SendWrapper(int hostId, int connectionId, int channelId, byte[] buffer, int size, out byte error);

		// Token: 0x06002CEA RID: 11498
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool QueueMessageForSendingWrapper(int hostId, int connectionId, int channelId, byte[] buffer, int size, out byte error);

		// Token: 0x06002CEB RID: 11499
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool NotifyConnectionSendable(int hostId, int connectionId, out byte error);

		// Token: 0x06002CEC RID: 11500
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern NetworkEventType Receive(out int hostId, out int connectionId, out int channelId, byte[] buffer, int bufferSize, out int receivedSize, out byte error);

		// Token: 0x06002CED RID: 11501
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern NetworkEventType ReceiveFromHost(int hostId, out int connectionId, out int channelId, byte[] buffer, int bufferSize, out int receivedSize, out byte error);

		// Token: 0x06002CEE RID: 11502
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetPacketStat(int direction, int packetStatId, int numMsgs, int numBytes);

		// Token: 0x06002CEF RID: 11503 RVA: 0x000408FC File Offset: 0x0003EAFC
		public static bool StartBroadcastDiscovery(int hostId, int broadcastPort, int key, int version, int subversion, byte[] buffer, int size, int timeout, out byte error)
		{
			if (buffer != null)
			{
				if (buffer.Length < size)
				{
					throw new ArgumentOutOfRangeException(string.Concat(new object[]
					{
						"Size: ",
						size,
						" > buffer.Length ",
						buffer.Length
					}));
				}
				if (size == 0)
				{
					throw new ArgumentOutOfRangeException("Size is zero while buffer exists, please pass null and 0 as buffer and size parameters");
				}
			}
			bool result;
			if (buffer == null)
			{
				result = NetworkTransport.StartBroadcastDiscoveryWithoutData(hostId, broadcastPort, key, version, subversion, timeout, out error);
			}
			else
			{
				result = NetworkTransport.StartBroadcastDiscoveryWithData(hostId, broadcastPort, key, version, subversion, buffer, size, timeout, out error);
			}
			return result;
		}

		// Token: 0x06002CF0 RID: 11504
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool StartBroadcastDiscoveryWithoutData(int hostId, int broadcastPort, int key, int version, int subversion, int timeout, out byte error);

		// Token: 0x06002CF1 RID: 11505
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool StartBroadcastDiscoveryWithData(int hostId, int broadcastPort, int key, int version, int subversion, byte[] buffer, int size, int timeout, out byte error);

		// Token: 0x06002CF2 RID: 11506
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StopBroadcastDiscovery();

		// Token: 0x06002CF3 RID: 11507
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsBroadcastDiscoveryRunning();

		// Token: 0x06002CF4 RID: 11508
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetBroadcastCredentials(int hostId, int key, int version, int subversion, out byte error);

		// Token: 0x06002CF5 RID: 11509
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string GetBroadcastConnectionInfo(int hostId, out int port, out byte error);

		// Token: 0x06002CF6 RID: 11510 RVA: 0x000409A0 File Offset: 0x0003EBA0
		public static void GetBroadcastConnectionInfo(int hostId, out string address, out int port, out byte error)
		{
			address = NetworkTransport.GetBroadcastConnectionInfo(hostId, out port, out error);
		}

		// Token: 0x06002CF7 RID: 11511
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetBroadcastConnectionMessage(int hostId, byte[] buffer, int bufferSize, out int receivedSize, out byte error);
	}
}
