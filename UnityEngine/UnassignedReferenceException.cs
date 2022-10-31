using System;
using System.Runtime.Serialization;

namespace UnityEngine
{
	// Token: 0x020003D7 RID: 983
	[Serializable]
	public class UnassignedReferenceException : SystemException
	{
		// Token: 0x060032DB RID: 13019 RVA: 0x0004F030 File Offset: 0x0004D230
		public UnassignedReferenceException() : base("A Unity Runtime error occurred!")
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060032DC RID: 13020 RVA: 0x0004F04C File Offset: 0x0004D24C
		public UnassignedReferenceException(string message) : base(message)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060032DD RID: 13021 RVA: 0x0004F064 File Offset: 0x0004D264
		public UnassignedReferenceException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060032DE RID: 13022 RVA: 0x0004F07C File Offset: 0x0004D27C
		protected UnassignedReferenceException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x04000EA7 RID: 3751
		private const int Result = -2147467261;

		// Token: 0x04000EA8 RID: 3752
		private string unityStackTrace;
	}
}
