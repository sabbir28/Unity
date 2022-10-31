using System;

namespace UnityEngine
{
	// Token: 0x02000301 RID: 769
	public sealed class AndroidJavaException : Exception
	{
		// Token: 0x06002FEC RID: 12268 RVA: 0x00045D38 File Offset: 0x00043F38
		internal AndroidJavaException(string message, string javaStackTrace) : base(message)
		{
			this.mJavaStackTrace = javaStackTrace;
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06002FED RID: 12269 RVA: 0x00045D4C File Offset: 0x00043F4C
		public override string StackTrace
		{
			get
			{
				return this.mJavaStackTrace + base.StackTrace;
			}
		}

		// Token: 0x040009DE RID: 2526
		private string mJavaStackTrace;
	}
}
