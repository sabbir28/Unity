using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200007C RID: 124
	public sealed class LODGroup : Component
	{
		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x0000A2F0 File Offset: 0x000084F0
		// (set) Token: 0x06000885 RID: 2181 RVA: 0x0000A310 File Offset: 0x00008510
		public Vector3 localReferencePoint
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_localReferencePoint(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_localReferencePoint(ref value);
			}
		}

		// Token: 0x06000886 RID: 2182
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_localReferencePoint(out Vector3 value);

		// Token: 0x06000887 RID: 2183
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_localReferencePoint(ref Vector3 value);

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000888 RID: 2184
		// (set) Token: 0x06000889 RID: 2185
		public extern float size { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600088A RID: 2186
		public extern int lodCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600088B RID: 2187
		// (set) Token: 0x0600088C RID: 2188
		public extern LODFadeMode fadeMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600088D RID: 2189
		// (set) Token: 0x0600088E RID: 2190
		public extern bool animateCrossFading { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600088F RID: 2191
		// (set) Token: 0x06000890 RID: 2192
		public extern bool enabled { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000891 RID: 2193
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RecalculateBounds();

		// Token: 0x06000892 RID: 2194
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern LOD[] GetLODs();

		// Token: 0x06000893 RID: 2195 RVA: 0x0000A31C File Offset: 0x0000851C
		[Obsolete("Use SetLODs instead.")]
		public void SetLODS(LOD[] lods)
		{
			this.SetLODs(lods);
		}

		// Token: 0x06000894 RID: 2196
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetLODs(LOD[] lods);

		// Token: 0x06000895 RID: 2197
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ForceLOD(int index);

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000896 RID: 2198
		// (set) Token: 0x06000897 RID: 2199
		public static extern float crossFadeAnimationDuration { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
