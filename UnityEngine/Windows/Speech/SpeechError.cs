using System;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x02000455 RID: 1109
	public enum SpeechError
	{
		// Token: 0x04000FA7 RID: 4007
		NoError,
		// Token: 0x04000FA8 RID: 4008
		TopicLanguageNotSupported,
		// Token: 0x04000FA9 RID: 4009
		GrammarLanguageMismatch,
		// Token: 0x04000FAA RID: 4010
		GrammarCompilationFailure,
		// Token: 0x04000FAB RID: 4011
		AudioQualityFailure,
		// Token: 0x04000FAC RID: 4012
		PauseLimitExceeded,
		// Token: 0x04000FAD RID: 4013
		TimeoutExceeded,
		// Token: 0x04000FAE RID: 4014
		NetworkFailure,
		// Token: 0x04000FAF RID: 4015
		MicrophoneUnavailable,
		// Token: 0x04000FB0 RID: 4016
		UnknownError
	}
}
