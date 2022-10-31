using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000070 RID: 112
	public sealed class Compass
	{
		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060007CC RID: 1996
		public extern float magneticHeading { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060007CD RID: 1997
		public extern float trueHeading { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060007CE RID: 1998
		public extern float headingAccuracy { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x00009DEC File Offset: 0x00007FEC
		public Vector3 rawVector
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_rawVector(out result);
				return result;
			}
		}

		// Token: 0x060007D0 RID: 2000
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_rawVector(out Vector3 value);

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060007D1 RID: 2001
		public extern double timestamp { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060007D2 RID: 2002
		// (set) Token: 0x060007D3 RID: 2003
		public extern bool enabled { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
