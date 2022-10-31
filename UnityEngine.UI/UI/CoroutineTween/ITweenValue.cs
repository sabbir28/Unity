using System;

namespace UnityEngine.UI.CoroutineTween
{
	// Token: 0x02000032 RID: 50
	internal interface ITweenValue
	{
		// Token: 0x0600014F RID: 335
		void TweenValue(float floatPercentage);

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000150 RID: 336
		bool ignoreTimeScale { get; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000151 RID: 337
		float duration { get; }

		// Token: 0x06000152 RID: 338
		bool ValidTarget();
	}
}
