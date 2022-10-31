using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020003CC RID: 972
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute
	{
		// Token: 0x060032BF RID: 12991 RVA: 0x0004E710 File Offset: 0x0004C910
		public RuntimeInitializeOnLoadMethodAttribute()
		{
			this.loadType = RuntimeInitializeLoadType.AfterSceneLoad;
		}

		// Token: 0x060032C0 RID: 12992 RVA: 0x0004E720 File Offset: 0x0004C920
		public RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType)
		{
			this.loadType = loadType;
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x060032C1 RID: 12993 RVA: 0x0004E730 File Offset: 0x0004C930
		// (set) Token: 0x060032C2 RID: 12994 RVA: 0x0004E74C File Offset: 0x0004C94C
		public RuntimeInitializeLoadType loadType { get; private set; }
	}
}
