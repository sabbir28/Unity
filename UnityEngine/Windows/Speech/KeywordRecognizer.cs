using System;
using System.Collections.Generic;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x0200045A RID: 1114
	public sealed class KeywordRecognizer : PhraseRecognizer
	{
		// Token: 0x06003548 RID: 13640 RVA: 0x00054F28 File Offset: 0x00053128
		public KeywordRecognizer(string[] keywords) : this(keywords, ConfidenceLevel.Medium)
		{
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x00054F34 File Offset: 0x00053134
		public KeywordRecognizer(string[] keywords, ConfidenceLevel minimumConfidence)
		{
			if (keywords == null)
			{
				throw new ArgumentNullException("keywords");
			}
			if (keywords.Length == 0)
			{
				throw new ArgumentException("At least one keyword must be specified.", "keywords");
			}
			int num = keywords.Length;
			for (int i = 0; i < num; i++)
			{
				if (keywords[i] == null)
				{
					throw new ArgumentNullException(string.Format("Keyword at index {0} is null.", i));
				}
			}
			this.Keywords = keywords;
			this.m_Recognizer = base.CreateFromKeywords(keywords, minimumConfidence);
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x0600354A RID: 13642 RVA: 0x00054FBC File Offset: 0x000531BC
		// (set) Token: 0x0600354B RID: 13643 RVA: 0x00054FD8 File Offset: 0x000531D8
		public IEnumerable<string> Keywords { get; private set; }
	}
}
