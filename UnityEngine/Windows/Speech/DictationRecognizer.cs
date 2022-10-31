using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x020000EE RID: 238
	public sealed class DictationRecognizer : IDisposable
	{
		// Token: 0x06001102 RID: 4354 RVA: 0x00016F54 File Offset: 0x00015154
		public DictationRecognizer() : this(ConfidenceLevel.Medium, DictationTopicConstraint.Dictation)
		{
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x00016F60 File Offset: 0x00015160
		public DictationRecognizer(ConfidenceLevel confidenceLevel) : this(confidenceLevel, DictationTopicConstraint.Dictation)
		{
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x00016F6C File Offset: 0x0001516C
		public DictationRecognizer(DictationTopicConstraint topic) : this(ConfidenceLevel.Medium, topic)
		{
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x00016F78 File Offset: 0x00015178
		public DictationRecognizer(ConfidenceLevel minimumConfidence, DictationTopicConstraint topic)
		{
			this.m_Recognizer = this.Create(minimumConfidence, topic);
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x00016F90 File Offset: 0x00015190
		private IntPtr Create(ConfidenceLevel minimumConfidence, DictationTopicConstraint topicConstraint)
		{
			IntPtr result;
			DictationRecognizer.INTERNAL_CALL_Create(this, minimumConfidence, topicConstraint, out result);
			return result;
		}

		// Token: 0x06001107 RID: 4359
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Create(DictationRecognizer self, ConfidenceLevel minimumConfidence, DictationTopicConstraint topicConstraint, out IntPtr value);

		// Token: 0x06001108 RID: 4360
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Start(IntPtr self);

		// Token: 0x06001109 RID: 4361
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Stop(IntPtr self);

		// Token: 0x0600110A RID: 4362
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Destroy(IntPtr self);

		// Token: 0x0600110B RID: 4363
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void DestroyThreaded(IntPtr self);

		// Token: 0x0600110C RID: 4364
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern SpeechSystemStatus GetStatus(IntPtr self);

		// Token: 0x0600110D RID: 4365
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float GetAutoSilenceTimeoutSeconds(IntPtr self);

		// Token: 0x0600110E RID: 4366
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetAutoSilenceTimeoutSeconds(IntPtr self, float value);

		// Token: 0x0600110F RID: 4367
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float GetInitialSilenceTimeoutSeconds(IntPtr self);

		// Token: 0x06001110 RID: 4368
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetInitialSilenceTimeoutSeconds(IntPtr self, float value);

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06001111 RID: 4369 RVA: 0x00016FB0 File Offset: 0x000151B0
		// (remove) Token: 0x06001112 RID: 4370 RVA: 0x00016FE8 File Offset: 0x000151E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event DictationRecognizer.DictationHypothesisDelegate DictationHypothesis;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06001113 RID: 4371 RVA: 0x00017020 File Offset: 0x00015220
		// (remove) Token: 0x06001114 RID: 4372 RVA: 0x00017058 File Offset: 0x00015258
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event DictationRecognizer.DictationResultDelegate DictationResult;

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06001115 RID: 4373 RVA: 0x00017090 File Offset: 0x00015290
		// (remove) Token: 0x06001116 RID: 4374 RVA: 0x000170C8 File Offset: 0x000152C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event DictationRecognizer.DictationCompletedDelegate DictationComplete;

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06001117 RID: 4375 RVA: 0x00017100 File Offset: 0x00015300
		// (remove) Token: 0x06001118 RID: 4376 RVA: 0x00017138 File Offset: 0x00015338
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event DictationRecognizer.DictationErrorHandler DictationError;

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001119 RID: 4377 RVA: 0x00017170 File Offset: 0x00015370
		public SpeechSystemStatus Status
		{
			get
			{
				return (!(this.m_Recognizer != IntPtr.Zero)) ? SpeechSystemStatus.Stopped : DictationRecognizer.GetStatus(this.m_Recognizer);
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x0600111A RID: 4378 RVA: 0x000171AC File Offset: 0x000153AC
		// (set) Token: 0x0600111B RID: 4379 RVA: 0x000171EC File Offset: 0x000153EC
		public float AutoSilenceTimeoutSeconds
		{
			get
			{
				float result;
				if (this.m_Recognizer == IntPtr.Zero)
				{
					result = 0f;
				}
				else
				{
					result = DictationRecognizer.GetAutoSilenceTimeoutSeconds(this.m_Recognizer);
				}
				return result;
			}
			set
			{
				if (!(this.m_Recognizer == IntPtr.Zero))
				{
					DictationRecognizer.SetAutoSilenceTimeoutSeconds(this.m_Recognizer, value);
				}
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x0600111C RID: 4380 RVA: 0x00017218 File Offset: 0x00015418
		// (set) Token: 0x0600111D RID: 4381 RVA: 0x00017258 File Offset: 0x00015458
		public float InitialSilenceTimeoutSeconds
		{
			get
			{
				float result;
				if (this.m_Recognizer == IntPtr.Zero)
				{
					result = 0f;
				}
				else
				{
					result = DictationRecognizer.GetInitialSilenceTimeoutSeconds(this.m_Recognizer);
				}
				return result;
			}
			set
			{
				if (!(this.m_Recognizer == IntPtr.Zero))
				{
					DictationRecognizer.SetInitialSilenceTimeoutSeconds(this.m_Recognizer, value);
				}
			}
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x00017284 File Offset: 0x00015484
		~DictationRecognizer()
		{
			if (this.m_Recognizer != IntPtr.Zero)
			{
				DictationRecognizer.DestroyThreaded(this.m_Recognizer);
				this.m_Recognizer = IntPtr.Zero;
				GC.SuppressFinalize(this);
			}
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x000172E4 File Offset: 0x000154E4
		public void Start()
		{
			if (!(this.m_Recognizer == IntPtr.Zero))
			{
				DictationRecognizer.Start(this.m_Recognizer);
			}
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x0001730C File Offset: 0x0001550C
		public void Stop()
		{
			if (!(this.m_Recognizer == IntPtr.Zero))
			{
				DictationRecognizer.Stop(this.m_Recognizer);
			}
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00017334 File Offset: 0x00015534
		public void Dispose()
		{
			if (this.m_Recognizer != IntPtr.Zero)
			{
				DictationRecognizer.Destroy(this.m_Recognizer);
				this.m_Recognizer = IntPtr.Zero;
			}
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0001736C File Offset: 0x0001556C
		[RequiredByNativeCode]
		private void DictationRecognizer_InvokeHypothesisGeneratedEvent(string keyword)
		{
			DictationRecognizer.DictationHypothesisDelegate dictationHypothesis = this.DictationHypothesis;
			if (dictationHypothesis != null)
			{
				dictationHypothesis(keyword);
			}
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x00017390 File Offset: 0x00015590
		[RequiredByNativeCode]
		private void DictationRecognizer_InvokeResultGeneratedEvent(string keyword, ConfidenceLevel minimumConfidence)
		{
			DictationRecognizer.DictationResultDelegate dictationResult = this.DictationResult;
			if (dictationResult != null)
			{
				dictationResult(keyword, minimumConfidence);
			}
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x000173B4 File Offset: 0x000155B4
		[RequiredByNativeCode]
		private void DictationRecognizer_InvokeCompletedEvent(DictationCompletionCause cause)
		{
			DictationRecognizer.DictationCompletedDelegate dictationComplete = this.DictationComplete;
			if (dictationComplete != null)
			{
				dictationComplete(cause);
			}
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x000173D8 File Offset: 0x000155D8
		[RequiredByNativeCode]
		private void DictationRecognizer_InvokeErrorEvent(string error, int hresult)
		{
			DictationRecognizer.DictationErrorHandler dictationError = this.DictationError;
			if (dictationError != null)
			{
				dictationError(error, hresult);
			}
		}

		// Token: 0x0400022A RID: 554
		private IntPtr m_Recognizer;

		// Token: 0x020000EF RID: 239
		// (Invoke) Token: 0x06001127 RID: 4391
		public delegate void DictationHypothesisDelegate(string text);

		// Token: 0x020000F0 RID: 240
		// (Invoke) Token: 0x0600112B RID: 4395
		public delegate void DictationResultDelegate(string text, ConfidenceLevel confidence);

		// Token: 0x020000F1 RID: 241
		// (Invoke) Token: 0x0600112F RID: 4399
		public delegate void DictationCompletedDelegate(DictationCompletionCause cause);

		// Token: 0x020000F2 RID: 242
		// (Invoke) Token: 0x06001133 RID: 4403
		public delegate void DictationErrorHandler(string error, int hresult);
	}
}
