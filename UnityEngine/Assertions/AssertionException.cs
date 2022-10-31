using System;

namespace UnityEngine.Assertions
{
	// Token: 0x020003FA RID: 1018
	public class AssertionException : Exception
	{
		// Token: 0x0600340D RID: 13325 RVA: 0x00052530 File Offset: 0x00050730
		public AssertionException(string message, string userMessage) : base(message)
		{
			this.m_UserMessage = userMessage;
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x0600340E RID: 13326 RVA: 0x00052544 File Offset: 0x00050744
		public override string Message
		{
			get
			{
				string text = base.Message;
				if (this.m_UserMessage != null)
				{
					text = text + '\n' + this.m_UserMessage;
				}
				return text;
			}
		}

		// Token: 0x04000EEE RID: 3822
		private string m_UserMessage;
	}
}
