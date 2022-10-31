using System;
using System.Reflection;

namespace UnityEngineInternal
{
	// Token: 0x020003AA RID: 938
	public class ScriptingUtils
	{
		// Token: 0x060031F3 RID: 12787 RVA: 0x0004CC6C File Offset: 0x0004AE6C
		public static Delegate CreateDelegate(Type type, MethodInfo methodInfo)
		{
			return Delegate.CreateDelegate(type, methodInfo);
		}
	}
}
