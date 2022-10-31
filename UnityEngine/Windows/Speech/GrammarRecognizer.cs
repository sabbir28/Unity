using System;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x0200045B RID: 1115
	public sealed class GrammarRecognizer : PhraseRecognizer
	{
		// Token: 0x0600354C RID: 13644 RVA: 0x00054FE4 File Offset: 0x000531E4
		public GrammarRecognizer(string grammarFilePath) : this(grammarFilePath, ConfidenceLevel.Medium)
		{
		}

		// Token: 0x0600354D RID: 13645 RVA: 0x00054FF0 File Offset: 0x000531F0
		public GrammarRecognizer(string grammarFilePath, ConfidenceLevel minimumConfidence)
		{
			if (grammarFilePath == null)
			{
				throw new ArgumentNullException("grammarFilePath");
			}
			if (grammarFilePath.Length == 0)
			{
				throw new ArgumentException("Grammar file path cannot be empty.");
			}
			this.GrammarFilePath = grammarFilePath;
			this.m_Recognizer = base.CreateFromGrammarFile(grammarFilePath, minimumConfidence);
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x0600354E RID: 13646 RVA: 0x00055040 File Offset: 0x00053240
		// (set) Token: 0x0600354F RID: 13647 RVA: 0x0005505C File Offset: 0x0005325C
		public string GrammarFilePath { get; private set; }
	}
}
