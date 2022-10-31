using System;
using System.Collections.Generic;

namespace UnityEngine.Networking.Match
{
	// Token: 0x0200028F RID: 655
	internal abstract class Response : ResponseBase, IResponse
	{
		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06002B93 RID: 11155 RVA: 0x0003D7D0 File Offset: 0x0003B9D0
		// (set) Token: 0x06002B94 RID: 11156 RVA: 0x0003D7EC File Offset: 0x0003B9EC
		public bool success { get; private set; }

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06002B95 RID: 11157 RVA: 0x0003D7F8 File Offset: 0x0003B9F8
		// (set) Token: 0x06002B96 RID: 11158 RVA: 0x0003D814 File Offset: 0x0003BA14
		public string extendedInfo { get; private set; }

		// Token: 0x06002B97 RID: 11159 RVA: 0x0003D820 File Offset: 0x0003BA20
		public void SetSuccess()
		{
			this.success = true;
			this.extendedInfo = "";
		}

		// Token: 0x06002B98 RID: 11160 RVA: 0x0003D838 File Offset: 0x0003BA38
		public void SetFailure(string info)
		{
			this.success = false;
			this.extendedInfo += info;
		}

		// Token: 0x06002B99 RID: 11161 RVA: 0x0003D854 File Offset: 0x0003BA54
		public override string ToString()
		{
			return UnityString.Format("[{0}]-success:{1}-extendedInfo:{2}", new object[]
			{
				base.ToString(),
				this.success,
				this.extendedInfo
			});
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x0003D89C File Offset: 0x0003BA9C
		public override void Parse(object obj)
		{
			IDictionary<string, object> dictionary = obj as IDictionary<string, object>;
			if (dictionary != null)
			{
				this.success = base.ParseJSONBool("success", obj, dictionary);
				this.extendedInfo = base.ParseJSONString("extendedInfo", obj, dictionary);
				if (!this.success)
				{
					throw new FormatException("FAILURE Returned from server: " + this.extendedInfo);
				}
			}
		}
	}
}
