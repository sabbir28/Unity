using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200006F RID: 111
	public sealed class LocationService
	{
		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060007C4 RID: 1988
		public extern bool isEnabledByUser { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060007C5 RID: 1989
		public extern LocationServiceStatus status { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060007C6 RID: 1990
		public extern LocationInfo lastData { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060007C7 RID: 1991
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Start([DefaultValue("10f")] float desiredAccuracyInMeters, [DefaultValue("10f")] float updateDistanceInMeters);

		// Token: 0x060007C8 RID: 1992 RVA: 0x00009DA4 File Offset: 0x00007FA4
		[ExcludeFromDocs]
		public void Start(float desiredAccuracyInMeters)
		{
			float updateDistanceInMeters = 10f;
			this.Start(desiredAccuracyInMeters, updateDistanceInMeters);
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00009DC0 File Offset: 0x00007FC0
		[ExcludeFromDocs]
		public void Start()
		{
			float updateDistanceInMeters = 10f;
			float desiredAccuracyInMeters = 10f;
			this.Start(desiredAccuracyInMeters, updateDistanceInMeters);
		}

		// Token: 0x060007CA RID: 1994
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Stop();
	}
}
