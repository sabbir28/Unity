using System;

namespace UnityEngine
{
	// Token: 0x0200002C RID: 44
	public struct BoundingSphere
	{
		// Token: 0x06000378 RID: 888 RVA: 0x00006264 File Offset: 0x00004464
		public BoundingSphere(Vector3 pos, float rad)
		{
			this.position = pos;
			this.radius = rad;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00006278 File Offset: 0x00004478
		public BoundingSphere(Vector4 packedSphere)
		{
			this.position = new Vector3(packedSphere.x, packedSphere.y, packedSphere.z);
			this.radius = packedSphere.w;
		}

		// Token: 0x04000041 RID: 65
		public Vector3 position;

		// Token: 0x04000042 RID: 66
		public float radius;
	}
}
