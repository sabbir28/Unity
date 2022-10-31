using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200043A RID: 1082
	[UsedByNativeCode]
	public struct ShadowSplitData
	{
		// Token: 0x06003505 RID: 13573 RVA: 0x00054144 File Offset: 0x00052344
		public unsafe Plane GetCullingPlane(int index)
		{
			if (index < 0 || index >= this.cullingPlaneCount || index >= 10)
			{
				throw new IndexOutOfRangeException("Invalid plane index");
			}
			fixed (float* ptr = &this._cullingPlanes.FixedElementField)
			{
				return new Plane(new Vector3(ptr[(IntPtr)(index * 4) * 4], ptr[(IntPtr)(index * 4 + 1) * 4], ptr[(IntPtr)(index * 4 + 2) * 4]), ptr[(IntPtr)(index * 4 + 3) * 4]);
			}
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x000541C0 File Offset: 0x000523C0
		public unsafe void SetCullingPlane(int index, Plane plane)
		{
			if (index < 0 || index >= this.cullingPlaneCount || index >= 10)
			{
				throw new IndexOutOfRangeException("Invalid plane index");
			}
			fixed (float* ptr = &this._cullingPlanes.FixedElementField)
			{
				ptr[(IntPtr)(index * 4) * 4] = plane.normal.x;
				ptr[(IntPtr)(index * 4 + 1) * 4] = plane.normal.y;
				ptr[(IntPtr)(index * 4 + 2) * 4] = plane.normal.z;
				ptr[(IntPtr)(index * 4 + 3) * 4] = plane.distance;
			}
		}

		// Token: 0x04000F6E RID: 3950
		public int cullingPlaneCount;

		// Token: 0x04000F6F RID: 3951
		private ShadowSplitData.<_cullingPlanes>__FixedBuffer2 _cullingPlanes;

		// Token: 0x04000F70 RID: 3952
		public Vector4 cullingSphere;

		// Token: 0x0200043B RID: 1083
		[UnsafeValueType]
		[CompilerGenerated]
		[StructLayout(LayoutKind.Sequential, Size = 160)]
		public struct <_cullingPlanes>__FixedBuffer2
		{
			// Token: 0x04000F71 RID: 3953
			public float FixedElementField;
		}
	}
}
