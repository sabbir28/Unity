using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020002FD RID: 765
	[Obsolete("This component is part of the legacy particle system, which is deprecated and will be removed in a future release. Use the ParticleSystem component instead.", false)]
	[RequireComponent(typeof(Transform))]
	public sealed class ParticleAnimator : Component
	{
		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06002FB1 RID: 12209
		// (set) Token: 0x06002FB2 RID: 12210
		public extern bool doesAnimateColor { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06002FB3 RID: 12211 RVA: 0x00045BDC File Offset: 0x00043DDC
		// (set) Token: 0x06002FB4 RID: 12212 RVA: 0x00045BFC File Offset: 0x00043DFC
		public Vector3 worldRotationAxis
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_worldRotationAxis(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_worldRotationAxis(ref value);
			}
		}

		// Token: 0x06002FB5 RID: 12213
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_worldRotationAxis(out Vector3 value);

		// Token: 0x06002FB6 RID: 12214
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_worldRotationAxis(ref Vector3 value);

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06002FB7 RID: 12215 RVA: 0x00045C08 File Offset: 0x00043E08
		// (set) Token: 0x06002FB8 RID: 12216 RVA: 0x00045C28 File Offset: 0x00043E28
		public Vector3 localRotationAxis
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_localRotationAxis(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_localRotationAxis(ref value);
			}
		}

		// Token: 0x06002FB9 RID: 12217
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_localRotationAxis(out Vector3 value);

		// Token: 0x06002FBA RID: 12218
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_localRotationAxis(ref Vector3 value);

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06002FBB RID: 12219
		// (set) Token: 0x06002FBC RID: 12220
		public extern float sizeGrow { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06002FBD RID: 12221 RVA: 0x00045C34 File Offset: 0x00043E34
		// (set) Token: 0x06002FBE RID: 12222 RVA: 0x00045C54 File Offset: 0x00043E54
		public Vector3 rndForce
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_rndForce(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_rndForce(ref value);
			}
		}

		// Token: 0x06002FBF RID: 12223
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_rndForce(out Vector3 value);

		// Token: 0x06002FC0 RID: 12224
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_rndForce(ref Vector3 value);

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06002FC1 RID: 12225 RVA: 0x00045C60 File Offset: 0x00043E60
		// (set) Token: 0x06002FC2 RID: 12226 RVA: 0x00045C80 File Offset: 0x00043E80
		public Vector3 force
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_force(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_force(ref value);
			}
		}

		// Token: 0x06002FC3 RID: 12227
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_force(out Vector3 value);

		// Token: 0x06002FC4 RID: 12228
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_force(ref Vector3 value);

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06002FC5 RID: 12229
		// (set) Token: 0x06002FC6 RID: 12230
		public extern float damping { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06002FC7 RID: 12231
		// (set) Token: 0x06002FC8 RID: 12232
		public extern bool autodestruct { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06002FC9 RID: 12233
		// (set) Token: 0x06002FCA RID: 12234
		public extern Color[] colorAnimation { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
