using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000220 RID: 544
	public class Motion : Object
	{
		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x060024B0 RID: 9392
		public extern float averageDuration { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x060024B1 RID: 9393
		public extern float averageAngularSpeed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x060024B2 RID: 9394 RVA: 0x0002A1CC File Offset: 0x000283CC
		public Vector3 averageSpeed
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_averageSpeed(out result);
				return result;
			}
		}

		// Token: 0x060024B3 RID: 9395
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_averageSpeed(out Vector3 value);

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x060024B4 RID: 9396
		public extern float apparentSpeed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x060024B5 RID: 9397
		public extern bool isLooping { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x060024B6 RID: 9398
		public extern bool legacy { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x060024B7 RID: 9399
		public extern bool isHumanMotion { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060024B8 RID: 9400
		[Obsolete("ValidateIfRetargetable is not supported anymore. Use isHumanMotion instead.", true)]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool ValidateIfRetargetable(bool val);

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x060024B9 RID: 9401
		[Obsolete("isAnimatorMotion is not supported anymore. Use !legacy instead.", true)]
		public extern bool isAnimatorMotion { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
