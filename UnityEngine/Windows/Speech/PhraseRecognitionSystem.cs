using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x020000E9 RID: 233
	public static class PhraseRecognitionSystem
	{
		// Token: 0x1700037E RID: 894
		// (get) Token: 0x060010D9 RID: 4313
		[ThreadAndSerializationSafe]
		public static extern bool isSupported { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x060010DA RID: 4314
		public static extern SpeechSystemStatus Status { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060010DB RID: 4315
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Restart();

		// Token: 0x060010DC RID: 4316
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Shutdown();

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060010DD RID: 4317 RVA: 0x00016B60 File Offset: 0x00014D60
		// (remove) Token: 0x060010DE RID: 4318 RVA: 0x00016B94 File Offset: 0x00014D94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event PhraseRecognitionSystem.ErrorDelegate OnError;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060010DF RID: 4319 RVA: 0x00016BC8 File Offset: 0x00014DC8
		// (remove) Token: 0x060010E0 RID: 4320 RVA: 0x00016BFC File Offset: 0x00014DFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event PhraseRecognitionSystem.StatusDelegate OnStatusChanged;

		// Token: 0x060010E1 RID: 4321 RVA: 0x00016C30 File Offset: 0x00014E30
		[RequiredByNativeCode]
		private static void PhraseRecognitionSystem_InvokeErrorEvent(SpeechError errorCode)
		{
			PhraseRecognitionSystem.ErrorDelegate onError = PhraseRecognitionSystem.OnError;
			if (onError != null)
			{
				onError(errorCode);
			}
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x00016C54 File Offset: 0x00014E54
		[RequiredByNativeCode]
		private static void PhraseRecognitionSystem_InvokeStatusChangedEvent(SpeechSystemStatus status)
		{
			PhraseRecognitionSystem.StatusDelegate onStatusChanged = PhraseRecognitionSystem.OnStatusChanged;
			if (onStatusChanged != null)
			{
				onStatusChanged(status);
			}
		}

		// Token: 0x020000EA RID: 234
		// (Invoke) Token: 0x060010E4 RID: 4324
		public delegate void ErrorDelegate(SpeechError errorCode);

		// Token: 0x020000EB RID: 235
		// (Invoke) Token: 0x060010E8 RID: 4328
		public delegate void StatusDelegate(SpeechSystemStatus status);
	}
}
