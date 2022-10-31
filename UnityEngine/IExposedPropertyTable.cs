using System;

namespace UnityEngine
{
	// Token: 0x02000387 RID: 903
	internal interface IExposedPropertyTable
	{
		// Token: 0x06003120 RID: 12576
		void SetReferenceValue(PropertyName id, Object value);

		// Token: 0x06003121 RID: 12577
		Object GetReferenceValue(PropertyName id, out bool idValid);

		// Token: 0x06003122 RID: 12578
		void ClearReferenceValue(PropertyName id);
	}
}
