using System;
using System.Runtime.Serialization;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020003D5 RID: 981
	[RequiredByNativeCode]
	[Serializable]
	public class UnityException : SystemException
	{
		// Token: 0x060032D3 RID: 13011 RVA: 0x0004EF80 File Offset: 0x0004D180
		public UnityException() : base("A Unity Runtime error occurred!")
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x0004EF9C File Offset: 0x0004D19C
		public UnityException(string message) : base(message)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x0004EFB4 File Offset: 0x0004D1B4
		public UnityException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060032D6 RID: 13014 RVA: 0x0004EFCC File Offset: 0x0004D1CC
		protected UnityException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x04000EA3 RID: 3747
		private const int Result = -2147467261;

		// Token: 0x04000EA4 RID: 3748
		private string unityStackTrace;
	}
}
