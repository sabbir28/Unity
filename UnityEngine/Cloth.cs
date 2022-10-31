using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001A6 RID: 422
	[RequireComponent(typeof(Transform), typeof(SkinnedMeshRenderer))]
	[NativeClass("Unity::Cloth")]
	public sealed class Cloth : Component
	{
		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06001E52 RID: 7762
		// (set) Token: 0x06001E53 RID: 7763
		public extern float sleepThreshold { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06001E54 RID: 7764
		// (set) Token: 0x06001E55 RID: 7765
		public extern float bendingStiffness { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06001E56 RID: 7766
		// (set) Token: 0x06001E57 RID: 7767
		public extern float stretchingStiffness { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06001E58 RID: 7768
		// (set) Token: 0x06001E59 RID: 7769
		public extern float damping { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x00024D2C File Offset: 0x00022F2C
		// (set) Token: 0x06001E5B RID: 7771 RVA: 0x00024D4C File Offset: 0x00022F4C
		public Vector3 externalAcceleration
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_externalAcceleration(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_externalAcceleration(ref value);
			}
		}

		// Token: 0x06001E5C RID: 7772
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_externalAcceleration(out Vector3 value);

		// Token: 0x06001E5D RID: 7773
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_externalAcceleration(ref Vector3 value);

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06001E5E RID: 7774 RVA: 0x00024D58 File Offset: 0x00022F58
		// (set) Token: 0x06001E5F RID: 7775 RVA: 0x00024D78 File Offset: 0x00022F78
		public Vector3 randomAcceleration
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_randomAcceleration(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_randomAcceleration(ref value);
			}
		}

		// Token: 0x06001E60 RID: 7776
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_randomAcceleration(out Vector3 value);

		// Token: 0x06001E61 RID: 7777
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_randomAcceleration(ref Vector3 value);

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06001E62 RID: 7778
		// (set) Token: 0x06001E63 RID: 7779
		public extern bool useGravity { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06001E64 RID: 7780
		// (set) Token: 0x06001E65 RID: 7781
		[Obsolete("Deprecated. Cloth.selfCollisions is no longer supported since Unity 5.0.", true)]
		public extern bool selfCollision { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06001E66 RID: 7782
		// (set) Token: 0x06001E67 RID: 7783
		public extern bool enabled { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06001E68 RID: 7784
		public extern Vector3[] vertices { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06001E69 RID: 7785
		public extern Vector3[] normals { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06001E6A RID: 7786
		// (set) Token: 0x06001E6B RID: 7787
		public extern float friction { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06001E6C RID: 7788
		// (set) Token: 0x06001E6D RID: 7789
		public extern float collisionMassScale { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06001E6E RID: 7790
		// (set) Token: 0x06001E6F RID: 7791
		public extern float useContinuousCollision { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06001E70 RID: 7792
		// (set) Token: 0x06001E71 RID: 7793
		public extern float useVirtualParticles { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06001E72 RID: 7794 RVA: 0x00024D84 File Offset: 0x00022F84
		public void ClearTransformMotion()
		{
			Cloth.INTERNAL_CALL_ClearTransformMotion(this);
		}

		// Token: 0x06001E73 RID: 7795
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ClearTransformMotion(Cloth self);

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06001E74 RID: 7796
		// (set) Token: 0x06001E75 RID: 7797
		public extern ClothSkinningCoefficient[] coefficients { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06001E76 RID: 7798
		// (set) Token: 0x06001E77 RID: 7799
		public extern float worldVelocityScale { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06001E78 RID: 7800
		// (set) Token: 0x06001E79 RID: 7801
		public extern float worldAccelerationScale { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06001E7A RID: 7802
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetEnabledFading(bool enabled, [DefaultValue("0.5f")] float interpolationTime);

		// Token: 0x06001E7B RID: 7803 RVA: 0x00024D90 File Offset: 0x00022F90
		[ExcludeFromDocs]
		public void SetEnabledFading(bool enabled)
		{
			float interpolationTime = 0.5f;
			this.SetEnabledFading(enabled, interpolationTime);
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06001E7C RID: 7804
		// (set) Token: 0x06001E7D RID: 7805
		public extern bool solverFrequency { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06001E7E RID: 7806
		// (set) Token: 0x06001E7F RID: 7807
		public extern CapsuleCollider[] capsuleColliders { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06001E80 RID: 7808
		// (set) Token: 0x06001E81 RID: 7809
		public extern ClothSphereColliderPair[] sphereColliders { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
