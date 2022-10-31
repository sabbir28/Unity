using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x020000EC RID: 236
	public abstract class PhraseRecognizer : IDisposable
	{
		// Token: 0x060010EB RID: 4331 RVA: 0x00016C78 File Offset: 0x00014E78
		internal PhraseRecognizer()
		{
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x00016C84 File Offset: 0x00014E84
		protected IntPtr CreateFromKeywords(string[] keywords, ConfidenceLevel minimumConfidence)
		{
			IntPtr result;
			PhraseRecognizer.INTERNAL_CALL_CreateFromKeywords(this, keywords, minimumConfidence, out result);
			return result;
		}

		// Token: 0x060010ED RID: 4333
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_CreateFromKeywords(PhraseRecognizer self, string[] keywords, ConfidenceLevel minimumConfidence, out IntPtr value);

		// Token: 0x060010EE RID: 4334 RVA: 0x00016CA4 File Offset: 0x00014EA4
		protected IntPtr CreateFromGrammarFile(string grammarFilePath, ConfidenceLevel minimumConfidence)
		{
			IntPtr result;
			PhraseRecognizer.INTERNAL_CALL_CreateFromGrammarFile(this, grammarFilePath, minimumConfidence, out result);
			return result;
		}

		// Token: 0x060010EF RID: 4335
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_CreateFromGrammarFile(PhraseRecognizer self, string grammarFilePath, ConfidenceLevel minimumConfidence, out IntPtr value);

		// Token: 0x060010F0 RID: 4336
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Start_Internal(IntPtr recognizer);

		// Token: 0x060010F1 RID: 4337
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Stop_Internal(IntPtr recognizer);

		// Token: 0x060010F2 RID: 4338
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsRunning_Internal(IntPtr recognizer);

		// Token: 0x060010F3 RID: 4339
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Destroy(IntPtr recognizer);

		// Token: 0x060010F4 RID: 4340
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void DestroyThreaded(IntPtr recognizer);

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060010F5 RID: 4341 RVA: 0x00016CC4 File Offset: 0x00014EC4
		// (remove) Token: 0x060010F6 RID: 4342 RVA: 0x00016CFC File Offset: 0x00014EFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event PhraseRecognizer.PhraseRecognizedDelegate OnPhraseRecognized;

		// Token: 0x060010F7 RID: 4343 RVA: 0x00016D34 File Offset: 0x00014F34
		~PhraseRecognizer()
		{
			if (this.m_Recognizer != IntPtr.Zero)
			{
				PhraseRecognizer.DestroyThreaded(this.m_Recognizer);
				this.m_Recognizer = IntPtr.Zero;
				GC.SuppressFinalize(this);
			}
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x00016D94 File Offset: 0x00014F94
		public void Start()
		{
			if (!(this.m_Recognizer == IntPtr.Zero))
			{
				PhraseRecognizer.Start_Internal(this.m_Recognizer);
			}
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x00016DBC File Offset: 0x00014FBC
		public void Stop()
		{
			if (!(this.m_Recognizer == IntPtr.Zero))
			{
				PhraseRecognizer.Stop_Internal(this.m_Recognizer);
			}
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x00016DE4 File Offset: 0x00014FE4
		public void Dispose()
		{
			if (this.m_Recognizer != IntPtr.Zero)
			{
				PhraseRecognizer.Destroy(this.m_Recognizer);
				this.m_Recognizer = IntPtr.Zero;
			}
			GC.SuppressFinalize(this);
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x00016E1C File Offset: 0x0001501C
		public bool IsRunning
		{
			get
			{
				return this.m_Recognizer != IntPtr.Zero && PhraseRecognizer.IsRunning_Internal(this.m_Recognizer);
			}
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x00016E54 File Offset: 0x00015054
		[RequiredByNativeCode]
		private void InvokePhraseRecognizedEvent(string text, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, long phraseStartFileTime, long phraseDurationTicks)
		{
			PhraseRecognizer.PhraseRecognizedDelegate onPhraseRecognized = this.OnPhraseRecognized;
			if (onPhraseRecognized != null)
			{
				onPhraseRecognized(new PhraseRecognizedEventArgs(text, confidence, semanticMeanings, DateTime.FromFileTime(phraseStartFileTime), TimeSpan.FromTicks(phraseDurationTicks)));
			}
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x00016E8C File Offset: 0x0001508C
		[RequiredByNativeCode]
		private unsafe static SemanticMeaning[] MarshalSemanticMeaning(IntPtr keys, IntPtr values, IntPtr valueSizes, int valueCount)
		{
			SemanticMeaning[] array = new SemanticMeaning[valueCount];
			int num = 0;
			for (int i = 0; i < valueCount; i++)
			{
				uint num2 = *(uint*)((byte*)((void*)valueSizes) + (IntPtr)i * 4);
				SemanticMeaning semanticMeaning = new SemanticMeaning
				{
					key = new string(*(IntPtr*)((byte*)((void*)keys) + (IntPtr)i * (IntPtr)sizeof(char*))),
					values = new string[num2]
				};
				int num3 = 0;
				while ((long)num3 < (long)((ulong)num2))
				{
					semanticMeaning.values[num3] = new string(*(IntPtr*)((byte*)((void*)values) + (IntPtr)(num + num3) * (IntPtr)sizeof(char*)));
					num3++;
				}
				array[i] = semanticMeaning;
				num += (int)num2;
			}
			return array;
		}

		// Token: 0x04000228 RID: 552
		protected IntPtr m_Recognizer;

		// Token: 0x020000ED RID: 237
		// (Invoke) Token: 0x060010FF RID: 4351
		public delegate void PhraseRecognizedDelegate(PhraseRecognizedEventArgs args);
	}
}
