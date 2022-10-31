using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020002FA RID: 762
	[Obsolete("This component is part of the legacy particle system, which is deprecated and will be removed in a future release. Use the ParticleSystem component instead.", false)]
	public class ParticleEmitter : Component
	{
		// Token: 0x06002F7B RID: 12155 RVA: 0x00045A3C File Offset: 0x00043C3C
		internal ParticleEmitter()
		{
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06002F7C RID: 12156
		// (set) Token: 0x06002F7D RID: 12157
		public extern bool emit { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06002F7E RID: 12158
		// (set) Token: 0x06002F7F RID: 12159
		public extern float minSize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06002F80 RID: 12160
		// (set) Token: 0x06002F81 RID: 12161
		public extern float maxSize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06002F82 RID: 12162
		// (set) Token: 0x06002F83 RID: 12163
		public extern float minEnergy { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06002F84 RID: 12164
		// (set) Token: 0x06002F85 RID: 12165
		public extern float maxEnergy { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06002F86 RID: 12166
		// (set) Token: 0x06002F87 RID: 12167
		public extern float minEmission { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06002F88 RID: 12168
		// (set) Token: 0x06002F89 RID: 12169
		public extern float maxEmission { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06002F8A RID: 12170
		// (set) Token: 0x06002F8B RID: 12171
		public extern float emitterVelocityScale { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06002F8C RID: 12172 RVA: 0x00045A48 File Offset: 0x00043C48
		// (set) Token: 0x06002F8D RID: 12173 RVA: 0x00045A68 File Offset: 0x00043C68
		public Vector3 worldVelocity
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_worldVelocity(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_worldVelocity(ref value);
			}
		}

		// Token: 0x06002F8E RID: 12174
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_worldVelocity(out Vector3 value);

		// Token: 0x06002F8F RID: 12175
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_worldVelocity(ref Vector3 value);

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06002F90 RID: 12176 RVA: 0x00045A74 File Offset: 0x00043C74
		// (set) Token: 0x06002F91 RID: 12177 RVA: 0x00045A94 File Offset: 0x00043C94
		public Vector3 localVelocity
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_localVelocity(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_localVelocity(ref value);
			}
		}

		// Token: 0x06002F92 RID: 12178
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_localVelocity(out Vector3 value);

		// Token: 0x06002F93 RID: 12179
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_localVelocity(ref Vector3 value);

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06002F94 RID: 12180 RVA: 0x00045AA0 File Offset: 0x00043CA0
		// (set) Token: 0x06002F95 RID: 12181 RVA: 0x00045AC0 File Offset: 0x00043CC0
		public Vector3 rndVelocity
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_rndVelocity(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_rndVelocity(ref value);
			}
		}

		// Token: 0x06002F96 RID: 12182
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_rndVelocity(out Vector3 value);

		// Token: 0x06002F97 RID: 12183
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_rndVelocity(ref Vector3 value);

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06002F98 RID: 12184
		// (set) Token: 0x06002F99 RID: 12185
		public extern bool useWorldSpace { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06002F9A RID: 12186
		// (set) Token: 0x06002F9B RID: 12187
		public extern bool rndRotation { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06002F9C RID: 12188
		// (set) Token: 0x06002F9D RID: 12189
		public extern float angularVelocity { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06002F9E RID: 12190
		// (set) Token: 0x06002F9F RID: 12191
		public extern float rndAngularVelocity { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06002FA0 RID: 12192
		// (set) Token: 0x06002FA1 RID: 12193
		public extern Particle[] particles { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06002FA2 RID: 12194
		public extern int particleCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002FA3 RID: 12195 RVA: 0x00045ACC File Offset: 0x00043CCC
		public void ClearParticles()
		{
			ParticleEmitter.INTERNAL_CALL_ClearParticles(this);
		}

		// Token: 0x06002FA4 RID: 12196
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ClearParticles(ParticleEmitter self);

		// Token: 0x06002FA5 RID: 12197 RVA: 0x00045AD8 File Offset: 0x00043CD8
		public void Emit()
		{
			this.Emit2((int)Random.Range(this.minEmission, this.maxEmission));
		}

		// Token: 0x06002FA6 RID: 12198 RVA: 0x00045AF4 File Offset: 0x00043CF4
		public void Emit(int count)
		{
			this.Emit2(count);
		}

		// Token: 0x06002FA7 RID: 12199 RVA: 0x00045B00 File Offset: 0x00043D00
		public void Emit(Vector3 pos, Vector3 velocity, float size, float energy, Color color)
		{
			InternalEmitParticleArguments internalEmitParticleArguments = default(InternalEmitParticleArguments);
			internalEmitParticleArguments.pos = pos;
			internalEmitParticleArguments.velocity = velocity;
			internalEmitParticleArguments.size = size;
			internalEmitParticleArguments.energy = energy;
			internalEmitParticleArguments.color = color;
			internalEmitParticleArguments.rotation = 0f;
			internalEmitParticleArguments.angularVelocity = 0f;
			this.Emit3(ref internalEmitParticleArguments);
		}

		// Token: 0x06002FA8 RID: 12200 RVA: 0x00045B60 File Offset: 0x00043D60
		public void Emit(Vector3 pos, Vector3 velocity, float size, float energy, Color color, float rotation, float angularVelocity)
		{
			InternalEmitParticleArguments internalEmitParticleArguments = default(InternalEmitParticleArguments);
			internalEmitParticleArguments.pos = pos;
			internalEmitParticleArguments.velocity = velocity;
			internalEmitParticleArguments.size = size;
			internalEmitParticleArguments.energy = energy;
			internalEmitParticleArguments.color = color;
			internalEmitParticleArguments.rotation = rotation;
			internalEmitParticleArguments.angularVelocity = angularVelocity;
			this.Emit3(ref internalEmitParticleArguments);
		}

		// Token: 0x06002FA9 RID: 12201
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Emit2(int count);

		// Token: 0x06002FAA RID: 12202
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Emit3(ref InternalEmitParticleArguments args);

		// Token: 0x06002FAB RID: 12203
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Simulate(float deltaTime);

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06002FAC RID: 12204
		// (set) Token: 0x06002FAD RID: 12205
		public extern bool enabled { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
