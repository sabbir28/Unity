using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200009F RID: 159
	internal sealed class PlayerConnectionInternal : IPlayerEditorConnectionNative
	{
		// Token: 0x06000B59 RID: 2905 RVA: 0x0000FD04 File Offset: 0x0000DF04
		void IPlayerEditorConnectionNative.SendMessage(Guid messageId, byte[] data, int playerId)
		{
			if (messageId == Guid.Empty)
			{
				throw new ArgumentException("messageId must not be empty");
			}
			PlayerConnectionInternal.SendMessage(messageId.ToString("N"), data, playerId);
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x0000FD38 File Offset: 0x0000DF38
		void IPlayerEditorConnectionNative.RegisterInternal(Guid messageId)
		{
			PlayerConnectionInternal.RegisterInternal(messageId.ToString("N"));
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0000FD4C File Offset: 0x0000DF4C
		void IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId)
		{
			PlayerConnectionInternal.UnregisterInternal(messageId.ToString("N"));
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0000FD60 File Offset: 0x0000DF60
		void IPlayerEditorConnectionNative.Initialize()
		{
			PlayerConnectionInternal.Initialize();
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x0000FD68 File Offset: 0x0000DF68
		bool IPlayerEditorConnectionNative.IsConnected()
		{
			return PlayerConnectionInternal.IsConnected();
		}

		// Token: 0x06000B5E RID: 2910
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsConnected();

		// Token: 0x06000B5F RID: 2911
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Initialize();

		// Token: 0x06000B60 RID: 2912
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RegisterInternal(string messageId);

		// Token: 0x06000B61 RID: 2913
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnregisterInternal(string messageId);

		// Token: 0x06000B62 RID: 2914
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SendMessage(string messageId, byte[] data, int playerId);
	}
}
