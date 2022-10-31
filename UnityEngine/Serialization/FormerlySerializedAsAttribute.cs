using System;
using UnityEngine.Scripting;

namespace UnityEngine.Serialization
{
	// Token: 0x02000443 RID: 1091
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = false)]
	[RequiredByNativeCode]
	public class FormerlySerializedAsAttribute : Attribute
	{
		// Token: 0x06003518 RID: 13592 RVA: 0x00054384 File Offset: 0x00052584
		public FormerlySerializedAsAttribute(string oldName)
		{
			this.m_oldName = oldName;
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06003519 RID: 13593 RVA: 0x00054394 File Offset: 0x00052594
		public string oldName
		{
			get
			{
				return this.m_oldName;
			}
		}

		// Token: 0x04000F84 RID: 3972
		private string m_oldName;
	}
}
