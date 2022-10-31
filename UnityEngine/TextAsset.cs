using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000C4 RID: 196
	public class TextAsset : Object
	{
		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000E2A RID: 3626
		public extern string text { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000E2B RID: 3627
		public extern byte[] bytes { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000E2C RID: 3628 RVA: 0x000130F4 File Offset: 0x000112F4
		public override string ToString()
		{
			return this.text;
		}
	}
}
