using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000038 RID: 56
	public struct ExposedPropertyResolver
	{
		// Token: 0x060003FD RID: 1021 RVA: 0x00006BB4 File Offset: 0x00004DB4
		internal static Object ResolveReferenceInternal(IntPtr ptr, PropertyName name, out bool isValid)
		{
			return ExposedPropertyResolver.INTERNAL_CALL_ResolveReferenceInternal(ptr, ref name, out isValid);
		}

		// Token: 0x060003FE RID: 1022
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Object INTERNAL_CALL_ResolveReferenceInternal(IntPtr ptr, ref PropertyName name, out bool isValid);

		// Token: 0x0400005A RID: 90
		internal IntPtr table;
	}
}
