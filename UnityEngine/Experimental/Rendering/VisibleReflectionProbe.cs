using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x020000FB RID: 251
	[UsedByNativeCode]
	public struct VisibleReflectionProbe
	{
		// Token: 0x17000393 RID: 915
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x000176F4 File Offset: 0x000158F4
		public Texture texture
		{
			get
			{
				return VisibleReflectionProbe.GetTextureObject(this.textureId);
			}
		}

		// Token: 0x06001180 RID: 4480
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Texture GetTextureObject(int textureId);

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x00017714 File Offset: 0x00015914
		public ReflectionProbe probe
		{
			get
			{
				return VisibleReflectionProbe.GetReflectionProbeObject(this.instanceId);
			}
		}

		// Token: 0x06001182 RID: 4482
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ReflectionProbe GetReflectionProbeObject(int instanceId);

		// Token: 0x04000244 RID: 580
		public Bounds bounds;

		// Token: 0x04000245 RID: 581
		public Matrix4x4 localToWorld;

		// Token: 0x04000246 RID: 582
		public Vector4 hdr;

		// Token: 0x04000247 RID: 583
		public Vector3 center;

		// Token: 0x04000248 RID: 584
		public float blendDistance;

		// Token: 0x04000249 RID: 585
		public int importance;

		// Token: 0x0400024A RID: 586
		public int boxProjection;

		// Token: 0x0400024B RID: 587
		private int instanceId;

		// Token: 0x0400024C RID: 588
		private int textureId;
	}
}
