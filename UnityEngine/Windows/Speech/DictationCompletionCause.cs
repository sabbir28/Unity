using System;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x02000457 RID: 1111
	public enum DictationCompletionCause
	{
		// Token: 0x04000FB6 RID: 4022
		Complete,
		// Token: 0x04000FB7 RID: 4023
		AudioQualityFailure,
		// Token: 0x04000FB8 RID: 4024
		Canceled,
		// Token: 0x04000FB9 RID: 4025
		TimeoutExceeded,
		// Token: 0x04000FBA RID: 4026
		PauseLimitExceeded,
		// Token: 0x04000FBB RID: 4027
		NetworkFailure,
		// Token: 0x04000FBC RID: 4028
		MicrophoneUnavailable,
		// Token: 0x04000FBD RID: 4029
		UnknownError
	}
}
