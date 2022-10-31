using System;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x02000459 RID: 1113
	public struct PhraseRecognizedEventArgs
	{
		// Token: 0x06003547 RID: 13639 RVA: 0x00054F00 File Offset: 0x00053100
		internal PhraseRecognizedEventArgs(string text, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, DateTime phraseStartTime, TimeSpan phraseDuration)
		{
			this.text = text;
			this.confidence = confidence;
			this.semanticMeanings = semanticMeanings;
			this.phraseStartTime = phraseStartTime;
			this.phraseDuration = phraseDuration;
		}

		// Token: 0x04000FC0 RID: 4032
		public readonly ConfidenceLevel confidence;

		// Token: 0x04000FC1 RID: 4033
		public readonly SemanticMeaning[] semanticMeanings;

		// Token: 0x04000FC2 RID: 4034
		public readonly string text;

		// Token: 0x04000FC3 RID: 4035
		public readonly DateTime phraseStartTime;

		// Token: 0x04000FC4 RID: 4036
		public readonly TimeSpan phraseDuration;
	}
}
