using System;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000057 RID: 87
	public sealed class LightProbes : Object
	{
		// Token: 0x060006D1 RID: 1745 RVA: 0x00009120 File Offset: 0x00007320
		public static void GetInterpolatedProbe(Vector3 position, Renderer renderer, out SphericalHarmonicsL2 probe)
		{
			LightProbes.INTERNAL_CALL_GetInterpolatedProbe(ref position, renderer, out probe);
		}

		// Token: 0x060006D2 RID: 1746
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetInterpolatedProbe(ref Vector3 position, Renderer renderer, out SphericalHarmonicsL2 probe);

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060006D3 RID: 1747
		public extern Vector3[] positions { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060006D4 RID: 1748
		// (set) Token: 0x060006D5 RID: 1749
		public extern SphericalHarmonicsL2[] bakedProbes { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060006D6 RID: 1750
		public extern int count { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060006D7 RID: 1751
		public extern int cellCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060006D8 RID: 1752 RVA: 0x0000912C File Offset: 0x0000732C
		[Obsolete("Use GetInterpolatedProbe instead.", true)]
		public void GetInterpolatedLightProbe(Vector3 position, Renderer renderer, float[] coefficients)
		{
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x00009130 File Offset: 0x00007330
		// (set) Token: 0x060006DA RID: 1754 RVA: 0x0000914C File Offset: 0x0000734C
		[Obsolete("Use bakedProbes instead.", true)]
		public float[] coefficients
		{
			get
			{
				return new float[0];
			}
			set
			{
			}
		}
	}
}
