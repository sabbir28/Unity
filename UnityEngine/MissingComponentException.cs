using System;
using System.Runtime.Serialization;

namespace UnityEngine
{
	// Token: 0x020003D6 RID: 982
	[Serializable]
	public class MissingComponentException : SystemException
	{
		// Token: 0x060032D7 RID: 13015 RVA: 0x0004EFD8 File Offset: 0x0004D1D8
		public MissingComponentException() : base("A Unity Runtime error occurred!")
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x0004EFF4 File Offset: 0x0004D1F4
		public MissingComponentException(string message) : base(message)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060032D9 RID: 13017 RVA: 0x0004F00C File Offset: 0x0004D20C
		public MissingComponentException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060032DA RID: 13018 RVA: 0x0004F024 File Offset: 0x0004D224
		protected MissingComponentException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x04000EA5 RID: 3749
		private const int Result = -2147467261;

		// Token: 0x04000EA6 RID: 3750
		private string unityStackTrace;
	}
}
