using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEngine.Events;
using UnityEngine.Scripting;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x02000423 RID: 1059
	[Serializable]
	public class PlayerConnection : ScriptableObject, IEditorPlayerConnection
	{
		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x060034CD RID: 13517 RVA: 0x000536F0 File Offset: 0x000518F0
		public static PlayerConnection instance
		{
			get
			{
				PlayerConnection result;
				if (PlayerConnection.s_Instance == null)
				{
					result = PlayerConnection.CreateInstance();
				}
				else
				{
					result = PlayerConnection.s_Instance;
				}
				return result;
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x060034CE RID: 13518 RVA: 0x00053728 File Offset: 0x00051928
		public bool isConnected
		{
			get
			{
				return this.GetConnectionNativeApi().IsConnected();
			}
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x00053748 File Offset: 0x00051948
		private static PlayerConnection CreateInstance()
		{
			PlayerConnection.s_Instance = ScriptableObject.CreateInstance<PlayerConnection>();
			PlayerConnection.s_Instance.hideFlags = HideFlags.HideAndDontSave;
			return PlayerConnection.s_Instance;
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x00053778 File Offset: 0x00051978
		public void OnEnable()
		{
			if (!this.m_IsInitilized)
			{
				this.m_IsInitilized = true;
				this.GetConnectionNativeApi().Initialize();
			}
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x000537A0 File Offset: 0x000519A0
		private IPlayerEditorConnectionNative GetConnectionNativeApi()
		{
			return PlayerConnection.connectionNative ?? new PlayerConnectionInternal();
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x000537C8 File Offset: 0x000519C8
		public void Register(Guid messageId, UnityAction<MessageEventArgs> callback)
		{
			if (messageId == Guid.Empty)
			{
				throw new ArgumentException("Cant be Guid.Empty", "messageId");
			}
			if (!this.m_PlayerEditorConnectionEvents.messageTypeSubscribers.Any<PlayerEditorConnectionEvents.MessageTypeSubscribers>())
			{
				this.GetConnectionNativeApi().RegisterInternal(messageId);
			}
			this.m_PlayerEditorConnectionEvents.AddAndCreate(messageId).AddListener(callback);
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x0005382C File Offset: 0x00051A2C
		public void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback)
		{
			this.m_PlayerEditorConnectionEvents.UnregisterManagedCallback(messageId, callback);
			if (!this.m_PlayerEditorConnectionEvents.messageTypeSubscribers.Any((PlayerEditorConnectionEvents.MessageTypeSubscribers x) => x.MessageTypeId == messageId))
			{
				this.GetConnectionNativeApi().UnregisterInternal(messageId);
			}
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x00053890 File Offset: 0x00051A90
		public void RegisterConnection(UnityAction<int> callback)
		{
			foreach (int arg in this.m_connectedPlayers)
			{
				callback(arg);
			}
			this.m_PlayerEditorConnectionEvents.connectionEvent.AddListener(callback);
		}

		// Token: 0x060034D5 RID: 13525 RVA: 0x00053904 File Offset: 0x00051B04
		public void RegisterDisconnection(UnityAction<int> callback)
		{
			this.m_PlayerEditorConnectionEvents.disconnectionEvent.AddListener(callback);
		}

		// Token: 0x060034D6 RID: 13526 RVA: 0x00053918 File Offset: 0x00051B18
		public void Send(Guid messageId, byte[] data)
		{
			if (messageId == Guid.Empty)
			{
				throw new ArgumentException("Cant be Guid.Empty", "messageId");
			}
			this.GetConnectionNativeApi().SendMessage(messageId, data, 0);
		}

		// Token: 0x060034D7 RID: 13527 RVA: 0x0005394C File Offset: 0x00051B4C
		[RequiredByNativeCode]
		private static void MessageCallbackInternal(IntPtr data, ulong size, ulong guid, string messageId)
		{
			byte[] array = null;
			if (size > 0UL)
			{
				array = new byte[size];
				Marshal.Copy(data, array, 0, (int)size);
			}
			PlayerConnection.instance.m_PlayerEditorConnectionEvents.InvokeMessageIdSubscribers(new Guid(messageId), array, (int)guid);
		}

		// Token: 0x060034D8 RID: 13528 RVA: 0x00053990 File Offset: 0x00051B90
		[RequiredByNativeCode]
		private static void ConnectedCallbackInternal(int playerId)
		{
			PlayerConnection.instance.m_connectedPlayers.Add(playerId);
			PlayerConnection.instance.m_PlayerEditorConnectionEvents.connectionEvent.Invoke(playerId);
		}

		// Token: 0x060034D9 RID: 13529 RVA: 0x000539B8 File Offset: 0x00051BB8
		[RequiredByNativeCode]
		private static void DisconnectedCallback(int playerId)
		{
			PlayerConnection.instance.m_PlayerEditorConnectionEvents.disconnectionEvent.Invoke(playerId);
		}

		// Token: 0x04000F2E RID: 3886
		internal static IPlayerEditorConnectionNative connectionNative;

		// Token: 0x04000F2F RID: 3887
		[SerializeField]
		private PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents = new PlayerEditorConnectionEvents();

		// Token: 0x04000F30 RID: 3888
		[SerializeField]
		private List<int> m_connectedPlayers = new List<int>();

		// Token: 0x04000F31 RID: 3889
		private bool m_IsInitilized;

		// Token: 0x04000F32 RID: 3890
		private static PlayerConnection s_Instance;
	}
}
