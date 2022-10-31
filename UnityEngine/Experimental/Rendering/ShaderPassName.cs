using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x020000F7 RID: 247
	public struct ShaderPassName
	{
		// Token: 0x06001171 RID: 4465 RVA: 0x0001766C File Offset: 0x0001586C
		public ShaderPassName(string name)
		{
			this.nameIndex = ShaderPassName.Init(name);
		}

		// Token: 0x06001172 RID: 4466
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Init(string name);

		// Token: 0x04000234 RID: 564
		private int nameIndex;
	}
}
