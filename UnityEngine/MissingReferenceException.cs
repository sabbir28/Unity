using System;
using System.Runtime.Serialization;

namespace UnityEngine
{
	// Token: 0x020003D8 RID: 984
	[Serializable]
	public class MissingReferenceException : SystemException
	{
		// Token: 0x060032DF RID: 13023 RVA: 0x0004F088 File Offset: 0x0004D288
		public MissingReferenceException() : base("A Unity Runtime error occurred!")
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060032E0 RID: 13024 RVA: 0x0004F0A4 File Offset: 0x0004D2A4
		public MissingReferenceException(string message) : base(message)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x0004F0BC File Offset: 0x0004D2BC
		public MissingReferenceException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060032E2 RID: 13026 RVA: 0x0004F0D4 File Offset: 0x0004D2D4
		protected MissingReferenceException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x04000EA9 RID: 3753
		private const int Result = -2147467261;

		// Token: 0x04000EAA RID: 3754
		private string unityStackTrace;
	}
}
