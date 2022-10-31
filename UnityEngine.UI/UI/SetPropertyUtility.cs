using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x02000075 RID: 117
	internal static class SetPropertyUtility
	{
		// Token: 0x06000455 RID: 1109 RVA: 0x00017C9C File Offset: 0x0001609C
		public static bool SetColor(ref Color currentValue, Color newValue)
		{
			bool result;
			if (currentValue.r == newValue.r && currentValue.g == newValue.g && currentValue.b == newValue.b && currentValue.a == newValue.a)
			{
				result = false;
			}
			else
			{
				currentValue = newValue;
				result = true;
			}
			return result;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00017D08 File Offset: 0x00016108
		public static bool SetStruct<T>(ref T currentValue, T newValue) where T : struct
		{
			bool result;
			if (EqualityComparer<T>.Default.Equals(currentValue, newValue))
			{
				result = false;
			}
			else
			{
				currentValue = newValue;
				result = true;
			}
			return result;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00017D44 File Offset: 0x00016144
		public static bool SetClass<T>(ref T currentValue, T newValue) where T : class
		{
			bool result;
			if ((currentValue == null && newValue == null) || (currentValue != null && currentValue.Equals(newValue)))
			{
				result = false;
			}
			else
			{
				currentValue = newValue;
				result = true;
			}
			return result;
		}
	}
}
