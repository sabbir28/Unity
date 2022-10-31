using System;
using System.Runtime.CompilerServices;
using Unity.Bindings;

namespace UnityEngine
{
	// Token: 0x020003C5 RID: 965
	internal class PropertyNameUtils
	{
		// Token: 0x0600326E RID: 12910 RVA: 0x0004D894 File Offset: 0x0004BA94
		public static PropertyName PropertyNameFromString([NativeParameter(Unmarshalled = true)] string name)
		{
			PropertyName result;
			PropertyNameUtils.PropertyNameFromString_Injected(name, out result);
			return result;
		}

		// Token: 0x0600326F RID: 12911
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void PropertyNameFromString_Injected(string name, out PropertyName ret);
	}
}
