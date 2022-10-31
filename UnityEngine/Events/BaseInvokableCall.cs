using System;
using System.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x020003DF RID: 991
	internal abstract class BaseInvokableCall
	{
		// Token: 0x060032FF RID: 13055 RVA: 0x0004F48C File Offset: 0x0004D68C
		protected BaseInvokableCall()
		{
		}

		// Token: 0x06003300 RID: 13056 RVA: 0x0004F498 File Offset: 0x0004D698
		protected BaseInvokableCall(object target, MethodInfo function)
		{
			if (target == null)
			{
				throw new ArgumentNullException("target");
			}
			if (function == null)
			{
				throw new ArgumentNullException("function");
			}
		}

		// Token: 0x06003301 RID: 13057
		public abstract void Invoke(object[] args);

		// Token: 0x06003302 RID: 13058 RVA: 0x0004F4C4 File Offset: 0x0004D6C4
		protected static void ThrowOnInvalidArg<T>(object arg)
		{
			if (arg != null && !(arg is T))
			{
				throw new ArgumentException(UnityString.Format("Passed argument 'args[0]' is of the wrong type. Type:{0} Expected:{1}", new object[]
				{
					arg.GetType(),
					typeof(T)
				}));
			}
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x0004F504 File Offset: 0x0004D704
		protected static bool AllowInvoke(Delegate @delegate)
		{
			object target = @delegate.Target;
			bool result;
			if (target == null)
			{
				result = true;
			}
			else
			{
				Object @object = target as Object;
				result = (object.ReferenceEquals(@object, null) || @object != null);
			}
			return result;
		}

		// Token: 0x06003304 RID: 13060
		public abstract bool Find(object targetObj, MethodInfo method);
	}
}
