using System;

namespace UnityEngine
{
	// Token: 0x020003DC RID: 988
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public class UnityAPICompatibilityVersionAttribute : Attribute
	{
		// Token: 0x060032EE RID: 13038 RVA: 0x0004F288 File Offset: 0x0004D488
		public UnityAPICompatibilityVersionAttribute(string version)
		{
			this._version = version;
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x060032EF RID: 13039 RVA: 0x0004F298 File Offset: 0x0004D498
		public string version
		{
			get
			{
				return this._version;
			}
		}

		// Token: 0x04000EB7 RID: 3767
		private string _version;
	}
}
