using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000A7 RID: 167
	[RequiredByNativeCode]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class ResourceRequest : AsyncOperation
	{
		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x00010CF4 File Offset: 0x0000EEF4
		public Object asset
		{
			get
			{
				return Resources.Load(this.m_Path, this.m_Type);
			}
		}

		// Token: 0x04000158 RID: 344
		internal string m_Path;

		// Token: 0x04000159 RID: 345
		internal Type m_Type;
	}
}
