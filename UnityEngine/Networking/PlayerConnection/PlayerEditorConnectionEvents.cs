using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Events;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x02000425 RID: 1061
	[Serializable]
	internal class PlayerEditorConnectionEvents
	{
		// Token: 0x060034DD RID: 13533 RVA: 0x00053A2C File Offset: 0x00051C2C
		public void InvokeMessageIdSubscribers(Guid messageId, byte[] data, int playerId)
		{
			IEnumerable<PlayerEditorConnectionEvents.MessageTypeSubscribers> enumerable = from x in this.messageTypeSubscribers
			where x.MessageTypeId == messageId
			select x;
			if (!enumerable.Any<PlayerEditorConnectionEvents.MessageTypeSubscribers>())
			{
				Debug.LogError("No actions found for messageId: " + messageId);
			}
			else
			{
				MessageEventArgs arg = new MessageEventArgs
				{
					playerId = playerId,
					data = data
				};
				foreach (PlayerEditorConnectionEvents.MessageTypeSubscribers messageTypeSubscribers in enumerable)
				{
					messageTypeSubscribers.messageCallback.Invoke(arg);
				}
			}
		}

		// Token: 0x060034DE RID: 13534 RVA: 0x00053AF8 File Offset: 0x00051CF8
		public UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId)
		{
			PlayerEditorConnectionEvents.MessageTypeSubscribers messageTypeSubscribers = this.messageTypeSubscribers.SingleOrDefault((PlayerEditorConnectionEvents.MessageTypeSubscribers x) => x.MessageTypeId == messageId);
			if (messageTypeSubscribers == null)
			{
				messageTypeSubscribers = new PlayerEditorConnectionEvents.MessageTypeSubscribers
				{
					MessageTypeId = messageId,
					messageCallback = new PlayerEditorConnectionEvents.MessageEvent()
				};
				this.messageTypeSubscribers.Add(messageTypeSubscribers);
			}
			messageTypeSubscribers.subscriberCount++;
			return messageTypeSubscribers.messageCallback;
		}

		// Token: 0x060034DF RID: 13535 RVA: 0x00053B7C File Offset: 0x00051D7C
		public void UnregisterManagedCallback(Guid messageId, UnityAction<MessageEventArgs> callback)
		{
			PlayerEditorConnectionEvents.MessageTypeSubscribers messageTypeSubscribers = this.messageTypeSubscribers.SingleOrDefault((PlayerEditorConnectionEvents.MessageTypeSubscribers x) => x.MessageTypeId == messageId);
			if (messageTypeSubscribers != null)
			{
				messageTypeSubscribers.subscriberCount--;
				messageTypeSubscribers.messageCallback.RemoveListener(callback);
				if (messageTypeSubscribers.subscriberCount <= 0)
				{
					this.messageTypeSubscribers.Remove(messageTypeSubscribers);
				}
			}
		}

		// Token: 0x04000F34 RID: 3892
		[SerializeField]
		public List<PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers = new List<PlayerEditorConnectionEvents.MessageTypeSubscribers>();

		// Token: 0x04000F35 RID: 3893
		[SerializeField]
		public PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent = new PlayerEditorConnectionEvents.ConnectionChangeEvent();

		// Token: 0x04000F36 RID: 3894
		[SerializeField]
		public PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent = new PlayerEditorConnectionEvents.ConnectionChangeEvent();

		// Token: 0x02000426 RID: 1062
		[Serializable]
		public class MessageEvent : UnityEvent<MessageEventArgs>
		{
		}

		// Token: 0x02000427 RID: 1063
		[Serializable]
		public class ConnectionChangeEvent : UnityEvent<int>
		{
		}

		// Token: 0x02000428 RID: 1064
		[Serializable]
		public class MessageTypeSubscribers
		{
			// Token: 0x17000C1D RID: 3101
			// (get) Token: 0x060034E3 RID: 13539 RVA: 0x00053C1C File Offset: 0x00051E1C
			// (set) Token: 0x060034E4 RID: 13540 RVA: 0x00053C3C File Offset: 0x00051E3C
			public Guid MessageTypeId
			{
				get
				{
					return new Guid(this.m_messageTypeId);
				}
				set
				{
					this.m_messageTypeId = value.ToString();
				}
			}

			// Token: 0x04000F37 RID: 3895
			[SerializeField]
			private string m_messageTypeId;

			// Token: 0x04000F38 RID: 3896
			public int subscriberCount = 0;

			// Token: 0x04000F39 RID: 3897
			public PlayerEditorConnectionEvents.MessageEvent messageCallback = new PlayerEditorConnectionEvents.MessageEvent();
		}
	}
}
