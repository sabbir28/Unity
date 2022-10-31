using System;
using System.Reflection;

namespace UnityEngineInternal
{
	// Token: 0x0200045C RID: 1116
	internal static class NetFxCoreExtensions
	{
		// Token: 0x06003550 RID: 13648 RVA: 0x00055068 File Offset: 0x00053268
		public static Delegate CreateDelegate(this MethodInfo self, Type delegateType, object target)
		{
			return Delegate.CreateDelegate(delegateType, target, self);
		}

		// Token: 0x06003551 RID: 13649 RVA: 0x00055088 File Offset: 0x00053288
		public static MethodInfo GetMethodInfo(this Delegate self)
		{
			return self.Method;
		}
	}
}
