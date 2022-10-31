using System;

namespace UnityEngine
{
	// Token: 0x02000302 RID: 770
	internal class AndroidJavaRunnableProxy : AndroidJavaProxy
	{
		// Token: 0x06002FEE RID: 12270 RVA: 0x00045D74 File Offset: 0x00043F74
		public AndroidJavaRunnableProxy(AndroidJavaRunnable runnable) : base("java/lang/Runnable")
		{
			this.mRunnable = runnable;
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x00045D8C File Offset: 0x00043F8C
		public void run()
		{
			this.mRunnable();
		}

		// Token: 0x040009DF RID: 2527
		private AndroidJavaRunnable mRunnable;
	}
}
