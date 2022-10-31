using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000335 RID: 821
	[UsedByNativeCode(Name = "ExposedReference")]
	[Serializable]
	public struct ExposedReference<T> where T : Object
	{
		// Token: 0x060030F0 RID: 12528 RVA: 0x0004A658 File Offset: 0x00048858
		public T Resolve(ExposedPropertyResolver resolver)
		{
			bool flag;
			Object @object = ExposedPropertyResolver.ResolveReferenceInternal(resolver.table, this.exposedName, out flag);
			T result;
			if (flag)
			{
				result = (@object as T);
			}
			else
			{
				result = (this.defaultValue as T);
			}
			return result;
		}

		// Token: 0x04000A92 RID: 2706
		[SerializeField]
		public PropertyName exposedName;

		// Token: 0x04000A93 RID: 2707
		[SerializeField]
		public Object defaultValue;
	}
}
