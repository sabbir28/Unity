using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200042C RID: 1068
	[UsedByNativeCode]
	public struct CullingParameters
	{
		// Token: 0x060034EB RID: 13547 RVA: 0x00053CE4 File Offset: 0x00051EE4
		public unsafe float GetLayerCullDistance(int layerIndex)
		{
			if (layerIndex < 0 || layerIndex >= 32)
			{
				throw new IndexOutOfRangeException("Invalid layer index");
			}
			fixed (float* ptr = &this._layerFarCullDistances.FixedElementField)
			{
				return ptr[(IntPtr)layerIndex * 4];
			}
		}

		// Token: 0x060034EC RID: 13548 RVA: 0x00053D28 File Offset: 0x00051F28
		public unsafe void SetLayerCullDistance(int layerIndex, float distance)
		{
			if (layerIndex < 0 || layerIndex >= 32)
			{
				throw new IndexOutOfRangeException("Invalid layer index");
			}
			fixed (float* ptr = &this._layerFarCullDistances.FixedElementField)
			{
				ptr[(IntPtr)layerIndex * 4] = distance;
			}
		}

		// Token: 0x060034ED RID: 13549 RVA: 0x00053D6C File Offset: 0x00051F6C
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

		// Token: 0x060034EE RID: 13550 RVA: 0x00053DE8 File Offset: 0x00051FE8
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

		// Token: 0x04000F3D RID: 3901
		public int isOrthographic;

		// Token: 0x04000F3E RID: 3902
		public LODParameters lodParameters;

		// Token: 0x04000F3F RID: 3903
		private CullingParameters.<_cullingPlanes>__FixedBuffer0 _cullingPlanes;

		// Token: 0x04000F40 RID: 3904
		public int cullingPlaneCount;

		// Token: 0x04000F41 RID: 3905
		public int cullingMask;

		// Token: 0x04000F42 RID: 3906
		private CullingParameters.<_layerFarCullDistances>__FixedBuffer1 _layerFarCullDistances;

		// Token: 0x04000F43 RID: 3907
		private int layerCull;

		// Token: 0x04000F44 RID: 3908
		public Matrix4x4 cullingMatrix;

		// Token: 0x04000F45 RID: 3909
		public Vector3 position;

		// Token: 0x04000F46 RID: 3910
		public float shadowDistance;

		// Token: 0x04000F47 RID: 3911
		private int _cullingFlags;

		// Token: 0x04000F48 RID: 3912
		private int _cameraInstanceID;

		// Token: 0x04000F49 RID: 3913
		public ReflectionProbeSortOptions reflectionProbeSortOptions;

		// Token: 0x0200042D RID: 1069
		[UnsafeValueType]
		[CompilerGenerated]
		[StructLayout(LayoutKind.Sequential, Size = 160)]
		public struct <_cullingPlanes>__FixedBuffer0
		{
			// Token: 0x04000F4A RID: 3914
			public float FixedElementField;
		}

		// Token: 0x0200042E RID: 1070
		[UnsafeValueType]
		[CompilerGenerated]
		[StructLayout(LayoutKind.Sequential, Size = 128)]
		public struct <_layerFarCullDistances>__FixedBuffer1
		{
			// Token: 0x04000F4B RID: 3915
			public float FixedElementField;
		}
	}
}
