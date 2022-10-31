using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000203 RID: 515
	[RequiredByNativeCode]
	public struct SkeletonBone
	{
		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06002337 RID: 9015 RVA: 0x000288B8 File Offset: 0x00026AB8
		// (set) Token: 0x06002338 RID: 9016 RVA: 0x000288D0 File Offset: 0x00026AD0
		[Obsolete("transformModified is no longer used and has been deprecated.", true)]
		public int transformModified
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x04000582 RID: 1410
		public string name;

		// Token: 0x04000583 RID: 1411
		internal string parentName;

		// Token: 0x04000584 RID: 1412
		public Vector3 position;

		// Token: 0x04000585 RID: 1413
		public Quaternion rotation;

		// Token: 0x04000586 RID: 1414
		public Vector3 scale;
	}
}
