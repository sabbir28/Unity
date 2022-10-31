using System;
using System.Collections.Generic;
using System.Security;

namespace UnityEngine
{
	// Token: 0x02000386 RID: 902
	internal class GUIStateObjects
	{
		// Token: 0x0600311C RID: 12572 RVA: 0x0004AD2C File Offset: 0x00048F2C
		[SecuritySafeCritical]
		internal static object GetStateObject(Type t, int controlID)
		{
			object obj;
			if (!GUIStateObjects.s_StateCache.TryGetValue(controlID, out obj) || obj.GetType() != t)
			{
				obj = Activator.CreateInstance(t);
				GUIStateObjects.s_StateCache[controlID] = obj;
			}
			return obj;
		}

		// Token: 0x0600311D RID: 12573 RVA: 0x0004AD78 File Offset: 0x00048F78
		internal static object QueryStateObject(Type t, int controlID)
		{
			object obj = GUIStateObjects.s_StateCache[controlID];
			object result;
			if (t.IsInstanceOfType(obj))
			{
				result = obj;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600311E RID: 12574 RVA: 0x0004ADB0 File Offset: 0x00048FB0
		internal static void Tests_ClearObjects()
		{
			GUIStateObjects.s_StateCache.Clear();
		}

		// Token: 0x04000CCD RID: 3277
		private static Dictionary<int, object> s_StateCache = new Dictionary<int, object>();
	}
}
