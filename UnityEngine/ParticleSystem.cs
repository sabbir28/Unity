using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000125 RID: 293
	[RequireComponent(typeof(Transform))]
	public sealed class ParticleSystem : Component
	{
		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001250 RID: 4688
		// (set) Token: 0x06001251 RID: 4689
		[Obsolete("startDelay property is deprecated. Use main.startDelay or main.startDelayMultiplier instead.")]
		public extern float startDelay { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001252 RID: 4690
		public extern bool isPlaying { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001253 RID: 4691
		public extern bool isEmitting { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06001254 RID: 4692
		public extern bool isStopped { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001255 RID: 4693
		public extern bool isPaused { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001256 RID: 4694
		// (set) Token: 0x06001257 RID: 4695
		[Obsolete("loop property is deprecated. Use main.loop instead.")]
		public extern bool loop { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001258 RID: 4696
		// (set) Token: 0x06001259 RID: 4697
		[Obsolete("playOnAwake property is deprecated. Use main.playOnAwake instead.")]
		public extern bool playOnAwake { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x0600125A RID: 4698
		// (set) Token: 0x0600125B RID: 4699
		public extern float time { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x0600125C RID: 4700
		[Obsolete("duration property is deprecated. Use main.duration instead.")]
		public extern float duration { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x0600125D RID: 4701
		// (set) Token: 0x0600125E RID: 4702
		[Obsolete("playbackSpeed property is deprecated. Use main.simulationSpeed instead.")]
		public extern float playbackSpeed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x0600125F RID: 4703
		public extern int particleCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001260 RID: 4704 RVA: 0x00018798 File Offset: 0x00016998
		// (set) Token: 0x06001261 RID: 4705 RVA: 0x000187BC File Offset: 0x000169BC
		[Obsolete("enableEmission property is deprecated. Use emission.enabled instead.")]
		public bool enableEmission
		{
			get
			{
				return this.emission.enabled;
			}
			set
			{
				this.emission.enabled = value;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001262 RID: 4706 RVA: 0x000187DC File Offset: 0x000169DC
		// (set) Token: 0x06001263 RID: 4707 RVA: 0x00018800 File Offset: 0x00016A00
		[Obsolete("emissionRate property is deprecated. Use emission.rateOverTime, emission.rateOverDistance, emission.rateOverTimeMultiplier or emission.rateOverDistanceMultiplier instead.")]
		public float emissionRate
		{
			get
			{
				return this.emission.rateOverTimeMultiplier;
			}
			set
			{
				this.emission.rateOverTime = value;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001264 RID: 4708
		// (set) Token: 0x06001265 RID: 4709
		[Obsolete("startSpeed property is deprecated. Use main.startSpeed or main.startSpeedMultiplier instead.")]
		public extern float startSpeed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001266 RID: 4710
		// (set) Token: 0x06001267 RID: 4711
		[Obsolete("startSize property is deprecated. Use main.startSize or main.startSizeMultiplier instead.")]
		public extern float startSize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x00018824 File Offset: 0x00016A24
		// (set) Token: 0x06001269 RID: 4713 RVA: 0x00018844 File Offset: 0x00016A44
		[Obsolete("startColor property is deprecated. Use main.startColor instead.")]
		public Color startColor
		{
			get
			{
				Color result;
				this.INTERNAL_get_startColor(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_startColor(ref value);
			}
		}

		// Token: 0x0600126A RID: 4714
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_startColor(out Color value);

		// Token: 0x0600126B RID: 4715
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_startColor(ref Color value);

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x0600126C RID: 4716
		// (set) Token: 0x0600126D RID: 4717
		[Obsolete("startRotation property is deprecated. Use main.startRotation or main.startRotationMultiplier instead.")]
		public extern float startRotation { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x00018850 File Offset: 0x00016A50
		// (set) Token: 0x0600126F RID: 4719 RVA: 0x00018870 File Offset: 0x00016A70
		[Obsolete("startRotation3D property is deprecated. Use main.startRotationX, main.startRotationY and main.startRotationZ instead. (Or main.startRotationXMultiplier, main.startRotationYMultiplier and main.startRotationZMultiplier).")]
		public Vector3 startRotation3D
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_startRotation3D(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_startRotation3D(ref value);
			}
		}

		// Token: 0x06001270 RID: 4720
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_startRotation3D(out Vector3 value);

		// Token: 0x06001271 RID: 4721
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_startRotation3D(ref Vector3 value);

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001272 RID: 4722
		// (set) Token: 0x06001273 RID: 4723
		[Obsolete("startLifetime property is deprecated. Use main.startLifetime or main.startLifetimeMultiplier instead.")]
		public extern float startLifetime { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06001274 RID: 4724
		// (set) Token: 0x06001275 RID: 4725
		[Obsolete("gravityModifier property is deprecated. Use main.gravityModifier or main.gravityModifierMultiplier instead.")]
		public extern float gravityModifier { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001276 RID: 4726
		// (set) Token: 0x06001277 RID: 4727
		[Obsolete("maxParticles property is deprecated. Use main.maxParticles instead.")]
		public extern int maxParticles { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001278 RID: 4728
		// (set) Token: 0x06001279 RID: 4729
		[Obsolete("simulationSpace property is deprecated. Use main.simulationSpace instead.")]
		public extern ParticleSystemSimulationSpace simulationSpace { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x0600127A RID: 4730
		// (set) Token: 0x0600127B RID: 4731
		[Obsolete("scalingMode property is deprecated. Use main.scalingMode instead.")]
		public extern ParticleSystemScalingMode scalingMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x0600127C RID: 4732
		// (set) Token: 0x0600127D RID: 4733
		public extern uint randomSeed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x0600127E RID: 4734
		// (set) Token: 0x0600127F RID: 4735
		public extern bool useAutoRandomSeed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001280 RID: 4736 RVA: 0x0001887C File Offset: 0x00016A7C
		public ParticleSystem.MainModule main
		{
			get
			{
				return new ParticleSystem.MainModule(this);
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x00018898 File Offset: 0x00016A98
		public ParticleSystem.EmissionModule emission
		{
			get
			{
				return new ParticleSystem.EmissionModule(this);
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001282 RID: 4738 RVA: 0x000188B4 File Offset: 0x00016AB4
		public ParticleSystem.ShapeModule shape
		{
			get
			{
				return new ParticleSystem.ShapeModule(this);
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001283 RID: 4739 RVA: 0x000188D0 File Offset: 0x00016AD0
		public ParticleSystem.VelocityOverLifetimeModule velocityOverLifetime
		{
			get
			{
				return new ParticleSystem.VelocityOverLifetimeModule(this);
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x000188EC File Offset: 0x00016AEC
		public ParticleSystem.LimitVelocityOverLifetimeModule limitVelocityOverLifetime
		{
			get
			{
				return new ParticleSystem.LimitVelocityOverLifetimeModule(this);
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x00018908 File Offset: 0x00016B08
		public ParticleSystem.InheritVelocityModule inheritVelocity
		{
			get
			{
				return new ParticleSystem.InheritVelocityModule(this);
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001286 RID: 4742 RVA: 0x00018924 File Offset: 0x00016B24
		public ParticleSystem.ForceOverLifetimeModule forceOverLifetime
		{
			get
			{
				return new ParticleSystem.ForceOverLifetimeModule(this);
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x00018940 File Offset: 0x00016B40
		public ParticleSystem.ColorOverLifetimeModule colorOverLifetime
		{
			get
			{
				return new ParticleSystem.ColorOverLifetimeModule(this);
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001288 RID: 4744 RVA: 0x0001895C File Offset: 0x00016B5C
		public ParticleSystem.ColorBySpeedModule colorBySpeed
		{
			get
			{
				return new ParticleSystem.ColorBySpeedModule(this);
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x00018978 File Offset: 0x00016B78
		public ParticleSystem.SizeOverLifetimeModule sizeOverLifetime
		{
			get
			{
				return new ParticleSystem.SizeOverLifetimeModule(this);
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x0600128A RID: 4746 RVA: 0x00018994 File Offset: 0x00016B94
		public ParticleSystem.SizeBySpeedModule sizeBySpeed
		{
			get
			{
				return new ParticleSystem.SizeBySpeedModule(this);
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x000189B0 File Offset: 0x00016BB0
		public ParticleSystem.RotationOverLifetimeModule rotationOverLifetime
		{
			get
			{
				return new ParticleSystem.RotationOverLifetimeModule(this);
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x0600128C RID: 4748 RVA: 0x000189CC File Offset: 0x00016BCC
		public ParticleSystem.RotationBySpeedModule rotationBySpeed
		{
			get
			{
				return new ParticleSystem.RotationBySpeedModule(this);
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x000189E8 File Offset: 0x00016BE8
		public ParticleSystem.ExternalForcesModule externalForces
		{
			get
			{
				return new ParticleSystem.ExternalForcesModule(this);
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x0600128E RID: 4750 RVA: 0x00018A04 File Offset: 0x00016C04
		public ParticleSystem.NoiseModule noise
		{
			get
			{
				return new ParticleSystem.NoiseModule(this);
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x00018A20 File Offset: 0x00016C20
		public ParticleSystem.CollisionModule collision
		{
			get
			{
				return new ParticleSystem.CollisionModule(this);
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001290 RID: 4752 RVA: 0x00018A3C File Offset: 0x00016C3C
		public ParticleSystem.TriggerModule trigger
		{
			get
			{
				return new ParticleSystem.TriggerModule(this);
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x00018A58 File Offset: 0x00016C58
		public ParticleSystem.SubEmittersModule subEmitters
		{
			get
			{
				return new ParticleSystem.SubEmittersModule(this);
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001292 RID: 4754 RVA: 0x00018A74 File Offset: 0x00016C74
		public ParticleSystem.TextureSheetAnimationModule textureSheetAnimation
		{
			get
			{
				return new ParticleSystem.TextureSheetAnimationModule(this);
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x00018A90 File Offset: 0x00016C90
		public ParticleSystem.LightsModule lights
		{
			get
			{
				return new ParticleSystem.LightsModule(this);
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001294 RID: 4756 RVA: 0x00018AAC File Offset: 0x00016CAC
		public ParticleSystem.TrailModule trails
		{
			get
			{
				return new ParticleSystem.TrailModule(this);
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x00018AC8 File Offset: 0x00016CC8
		public ParticleSystem.CustomDataModule customData
		{
			get
			{
				return new ParticleSystem.CustomDataModule(this);
			}
		}

		// Token: 0x06001296 RID: 4758
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetParticles(ParticleSystem.Particle[] particles, int size);

		// Token: 0x06001297 RID: 4759
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetParticles(ParticleSystem.Particle[] particles);

		// Token: 0x06001298 RID: 4760 RVA: 0x00018AE4 File Offset: 0x00016CE4
		public void SetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex)
		{
			this.SetCustomParticleDataInternal(customData, (int)streamIndex);
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00018AF0 File Offset: 0x00016CF0
		public int GetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex)
		{
			return this.GetCustomParticleDataInternal(customData, (int)streamIndex);
		}

		// Token: 0x0600129A RID: 4762
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetCustomParticleDataInternal(object customData, int streamIndex);

		// Token: 0x0600129B RID: 4763
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern int GetCustomParticleDataInternal(object customData, int streamIndex);

		// Token: 0x0600129C RID: 4764
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Simulate(ParticleSystem self, float t, bool restart, bool fixedTimeStep);

		// Token: 0x0600129D RID: 4765
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Play(ParticleSystem self);

		// Token: 0x0600129E RID: 4766
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Stop(ParticleSystem self, ParticleSystemStopBehavior stopBehavior);

		// Token: 0x0600129F RID: 4767
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Pause(ParticleSystem self);

		// Token: 0x060012A0 RID: 4768
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Clear(ParticleSystem self);

		// Token: 0x060012A1 RID: 4769
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsAlive(ParticleSystem self);

		// Token: 0x060012A2 RID: 4770 RVA: 0x00018B10 File Offset: 0x00016D10
		[ExcludeFromDocs]
		public void Simulate(float t, bool withChildren, bool restart)
		{
			bool fixedTimeStep = true;
			this.Simulate(t, withChildren, restart, fixedTimeStep);
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x00018B2C File Offset: 0x00016D2C
		[ExcludeFromDocs]
		public void Simulate(float t, bool withChildren)
		{
			bool fixedTimeStep = true;
			bool restart = true;
			this.Simulate(t, withChildren, restart, fixedTimeStep);
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x00018B48 File Offset: 0x00016D48
		[ExcludeFromDocs]
		public void Simulate(float t)
		{
			bool fixedTimeStep = true;
			bool restart = true;
			bool withChildren = true;
			this.Simulate(t, withChildren, restart, fixedTimeStep);
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x00018B68 File Offset: 0x00016D68
		public void Simulate(float t, [DefaultValue("true")] bool withChildren, [DefaultValue("true")] bool restart, [DefaultValue("true")] bool fixedTimeStep)
		{
			this.IterateParticleSystems(withChildren, (ParticleSystem ps) => ParticleSystem.Internal_Simulate(ps, t, restart, fixedTimeStep));
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x00018BA8 File Offset: 0x00016DA8
		[ExcludeFromDocs]
		public void Play()
		{
			bool withChildren = true;
			this.Play(withChildren);
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x00018BC0 File Offset: 0x00016DC0
		public void Play([DefaultValue("true")] bool withChildren)
		{
			this.IterateParticleSystems(withChildren, (ParticleSystem ps) => ParticleSystem.Internal_Play(ps));
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x00018BE8 File Offset: 0x00016DE8
		[ExcludeFromDocs]
		public void Stop(bool withChildren)
		{
			ParticleSystemStopBehavior stopBehavior = ParticleSystemStopBehavior.StopEmitting;
			this.Stop(withChildren, stopBehavior);
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x00018C00 File Offset: 0x00016E00
		[ExcludeFromDocs]
		public void Stop()
		{
			ParticleSystemStopBehavior stopBehavior = ParticleSystemStopBehavior.StopEmitting;
			bool withChildren = true;
			this.Stop(withChildren, stopBehavior);
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x00018C1C File Offset: 0x00016E1C
		public void Stop([DefaultValue("true")] bool withChildren, [DefaultValue("ParticleSystemStopBehavior.StopEmitting")] ParticleSystemStopBehavior stopBehavior)
		{
			this.IterateParticleSystems(withChildren, (ParticleSystem ps) => ParticleSystem.Internal_Stop(ps, stopBehavior));
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x00018C4C File Offset: 0x00016E4C
		[ExcludeFromDocs]
		public void Pause()
		{
			bool withChildren = true;
			this.Pause(withChildren);
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x00018C64 File Offset: 0x00016E64
		public void Pause([DefaultValue("true")] bool withChildren)
		{
			this.IterateParticleSystems(withChildren, (ParticleSystem ps) => ParticleSystem.Internal_Pause(ps));
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x00018C8C File Offset: 0x00016E8C
		[ExcludeFromDocs]
		public void Clear()
		{
			bool withChildren = true;
			this.Clear(withChildren);
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x00018CA4 File Offset: 0x00016EA4
		public void Clear([DefaultValue("true")] bool withChildren)
		{
			this.IterateParticleSystems(withChildren, (ParticleSystem ps) => ParticleSystem.Internal_Clear(ps));
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x00018CCC File Offset: 0x00016ECC
		[ExcludeFromDocs]
		public bool IsAlive()
		{
			bool withChildren = true;
			return this.IsAlive(withChildren);
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00018CEC File Offset: 0x00016EEC
		public bool IsAlive([DefaultValue("true")] bool withChildren)
		{
			return this.IterateParticleSystems(withChildren, (ParticleSystem ps) => ParticleSystem.Internal_IsAlive(ps));
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00018D28 File Offset: 0x00016F28
		public void Emit(int count)
		{
			ParticleSystem.INTERNAL_CALL_Emit(this, count);
		}

		// Token: 0x060012B2 RID: 4786
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Emit(ParticleSystem self, int count);

		// Token: 0x060012B3 RID: 4787 RVA: 0x00018D34 File Offset: 0x00016F34
		[Obsolete("Emit with specific parameters is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties")]
		public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color)
		{
			ParticleSystem.Particle particle = default(ParticleSystem.Particle);
			particle.position = position;
			particle.velocity = velocity;
			particle.lifetime = lifetime;
			particle.startLifetime = lifetime;
			particle.startSize = size;
			particle.rotation3D = Vector3.zero;
			particle.angularVelocity3D = Vector3.zero;
			particle.startColor = color;
			particle.randomSeed = 5U;
			this.Internal_EmitOld(ref particle);
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00018DA8 File Offset: 0x00016FA8
		[Obsolete("Emit with a single particle structure is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties")]
		public void Emit(ParticleSystem.Particle particle)
		{
			this.Internal_EmitOld(ref particle);
		}

		// Token: 0x060012B5 RID: 4789
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_EmitOld(ref ParticleSystem.Particle particle);

		// Token: 0x060012B6 RID: 4790 RVA: 0x00018DB4 File Offset: 0x00016FB4
		public void Emit(ParticleSystem.EmitParams emitParams, int count)
		{
			this.Internal_Emit(ref emitParams, count);
		}

		// Token: 0x060012B7 RID: 4791
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_Emit(ref ParticleSystem.EmitParams emitParams, int count);

		// Token: 0x060012B8 RID: 4792 RVA: 0x00018DC0 File Offset: 0x00016FC0
		internal bool IterateParticleSystems(bool recurse, ParticleSystem.IteratorDelegate func)
		{
			bool flag = func(this);
			if (recurse)
			{
				flag |= ParticleSystem.IterateParticleSystemsRecursive(base.transform, func);
			}
			return flag;
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x00018DF4 File Offset: 0x00016FF4
		private static bool IterateParticleSystemsRecursive(Transform transform, ParticleSystem.IteratorDelegate func)
		{
			bool flag = false;
			int childCount = transform.childCount;
			for (int i = 0; i < childCount; i++)
			{
				Transform child = transform.GetChild(i);
				ParticleSystem component = child.gameObject.GetComponent<ParticleSystem>();
				if (component != null)
				{
					flag = func(component);
					if (flag)
					{
						break;
					}
					ParticleSystem.IterateParticleSystemsRecursive(child, func);
				}
			}
			return flag;
		}

		// Token: 0x02000126 RID: 294
		public struct Burst
		{
			// Token: 0x060012BE RID: 4798 RVA: 0x00018EDC File Offset: 0x000170DC
			public Burst(float _time, short _count)
			{
				this.m_Time = _time;
				this.m_MinCount = _count;
				this.m_MaxCount = _count;
				this.m_RepeatCount = 0;
				this.m_RepeatInterval = 0f;
			}

			// Token: 0x060012BF RID: 4799 RVA: 0x00018F08 File Offset: 0x00017108
			public Burst(float _time, short _minCount, short _maxCount)
			{
				this.m_Time = _time;
				this.m_MinCount = _minCount;
				this.m_MaxCount = _maxCount;
				this.m_RepeatCount = 0;
				this.m_RepeatInterval = 0f;
			}

			// Token: 0x060012C0 RID: 4800 RVA: 0x00018F34 File Offset: 0x00017134
			public Burst(float _time, short _minCount, short _maxCount, int _cycleCount, float _repeatInterval)
			{
				this.m_Time = _time;
				this.m_MinCount = _minCount;
				this.m_MaxCount = _maxCount;
				this.m_RepeatCount = _cycleCount - 1;
				this.m_RepeatInterval = _repeatInterval;
			}

			// Token: 0x170003F0 RID: 1008
			// (get) Token: 0x060012C1 RID: 4801 RVA: 0x00018F60 File Offset: 0x00017160
			// (set) Token: 0x060012C2 RID: 4802 RVA: 0x00018F7C File Offset: 0x0001717C
			public float time
			{
				get
				{
					return this.m_Time;
				}
				set
				{
					this.m_Time = value;
				}
			}

			// Token: 0x170003F1 RID: 1009
			// (get) Token: 0x060012C3 RID: 4803 RVA: 0x00018F88 File Offset: 0x00017188
			// (set) Token: 0x060012C4 RID: 4804 RVA: 0x00018FA4 File Offset: 0x000171A4
			public short minCount
			{
				get
				{
					return this.m_MinCount;
				}
				set
				{
					this.m_MinCount = value;
				}
			}

			// Token: 0x170003F2 RID: 1010
			// (get) Token: 0x060012C5 RID: 4805 RVA: 0x00018FB0 File Offset: 0x000171B0
			// (set) Token: 0x060012C6 RID: 4806 RVA: 0x00018FCC File Offset: 0x000171CC
			public short maxCount
			{
				get
				{
					return this.m_MaxCount;
				}
				set
				{
					this.m_MaxCount = value;
				}
			}

			// Token: 0x170003F3 RID: 1011
			// (get) Token: 0x060012C7 RID: 4807 RVA: 0x00018FD8 File Offset: 0x000171D8
			// (set) Token: 0x060012C8 RID: 4808 RVA: 0x00018FF8 File Offset: 0x000171F8
			public int cycleCount
			{
				get
				{
					return this.m_RepeatCount + 1;
				}
				set
				{
					this.m_RepeatCount = value - 1;
				}
			}

			// Token: 0x170003F4 RID: 1012
			// (get) Token: 0x060012C9 RID: 4809 RVA: 0x00019004 File Offset: 0x00017204
			// (set) Token: 0x060012CA RID: 4810 RVA: 0x00019020 File Offset: 0x00017220
			public float repeatInterval
			{
				get
				{
					return this.m_RepeatInterval;
				}
				set
				{
					this.m_RepeatInterval = value;
				}
			}

			// Token: 0x04000339 RID: 825
			private float m_Time;

			// Token: 0x0400033A RID: 826
			private short m_MinCount;

			// Token: 0x0400033B RID: 827
			private short m_MaxCount;

			// Token: 0x0400033C RID: 828
			private int m_RepeatCount;

			// Token: 0x0400033D RID: 829
			private float m_RepeatInterval;
		}

		// Token: 0x02000127 RID: 295
		public struct MinMaxCurve
		{
			// Token: 0x060012CB RID: 4811 RVA: 0x0001902C File Offset: 0x0001722C
			public MinMaxCurve(float constant)
			{
				this.m_Mode = ParticleSystemCurveMode.Constant;
				this.m_CurveMultiplier = 0f;
				this.m_CurveMin = null;
				this.m_CurveMax = null;
				this.m_ConstantMin = 0f;
				this.m_ConstantMax = constant;
			}

			// Token: 0x060012CC RID: 4812 RVA: 0x00019064 File Offset: 0x00017264
			public MinMaxCurve(float multiplier, AnimationCurve curve)
			{
				this.m_Mode = ParticleSystemCurveMode.Curve;
				this.m_CurveMultiplier = multiplier;
				this.m_CurveMin = null;
				this.m_CurveMax = curve;
				this.m_ConstantMin = 0f;
				this.m_ConstantMax = 0f;
			}

			// Token: 0x060012CD RID: 4813 RVA: 0x0001909C File Offset: 0x0001729C
			public MinMaxCurve(float multiplier, AnimationCurve min, AnimationCurve max)
			{
				this.m_Mode = ParticleSystemCurveMode.TwoCurves;
				this.m_CurveMultiplier = multiplier;
				this.m_CurveMin = min;
				this.m_CurveMax = max;
				this.m_ConstantMin = 0f;
				this.m_ConstantMax = 0f;
			}

			// Token: 0x060012CE RID: 4814 RVA: 0x000190D4 File Offset: 0x000172D4
			public MinMaxCurve(float min, float max)
			{
				this.m_Mode = ParticleSystemCurveMode.TwoConstants;
				this.m_CurveMultiplier = 0f;
				this.m_CurveMin = null;
				this.m_CurveMax = null;
				this.m_ConstantMin = min;
				this.m_ConstantMax = max;
			}

			// Token: 0x170003F5 RID: 1013
			// (get) Token: 0x060012CF RID: 4815 RVA: 0x00019108 File Offset: 0x00017308
			// (set) Token: 0x060012D0 RID: 4816 RVA: 0x00019124 File Offset: 0x00017324
			public ParticleSystemCurveMode mode
			{
				get
				{
					return this.m_Mode;
				}
				set
				{
					this.m_Mode = value;
				}
			}

			// Token: 0x170003F6 RID: 1014
			// (get) Token: 0x060012D1 RID: 4817 RVA: 0x00019130 File Offset: 0x00017330
			// (set) Token: 0x060012D2 RID: 4818 RVA: 0x0001914C File Offset: 0x0001734C
			[Obsolete("Please use MinMaxCurve.curveMultiplier instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/MinMaxCurve.curveMultiplier")]
			public float curveScalar
			{
				get
				{
					return this.m_CurveMultiplier;
				}
				set
				{
					this.m_CurveMultiplier = value;
				}
			}

			// Token: 0x170003F7 RID: 1015
			// (get) Token: 0x060012D3 RID: 4819 RVA: 0x00019158 File Offset: 0x00017358
			// (set) Token: 0x060012D4 RID: 4820 RVA: 0x00019174 File Offset: 0x00017374
			public float curveMultiplier
			{
				get
				{
					return this.m_CurveMultiplier;
				}
				set
				{
					this.m_CurveMultiplier = value;
				}
			}

			// Token: 0x170003F8 RID: 1016
			// (get) Token: 0x060012D5 RID: 4821 RVA: 0x00019180 File Offset: 0x00017380
			// (set) Token: 0x060012D6 RID: 4822 RVA: 0x0001919C File Offset: 0x0001739C
			public AnimationCurve curveMax
			{
				get
				{
					return this.m_CurveMax;
				}
				set
				{
					this.m_CurveMax = value;
				}
			}

			// Token: 0x170003F9 RID: 1017
			// (get) Token: 0x060012D7 RID: 4823 RVA: 0x000191A8 File Offset: 0x000173A8
			// (set) Token: 0x060012D8 RID: 4824 RVA: 0x000191C4 File Offset: 0x000173C4
			public AnimationCurve curveMin
			{
				get
				{
					return this.m_CurveMin;
				}
				set
				{
					this.m_CurveMin = value;
				}
			}

			// Token: 0x170003FA RID: 1018
			// (get) Token: 0x060012D9 RID: 4825 RVA: 0x000191D0 File Offset: 0x000173D0
			// (set) Token: 0x060012DA RID: 4826 RVA: 0x000191EC File Offset: 0x000173EC
			public float constantMax
			{
				get
				{
					return this.m_ConstantMax;
				}
				set
				{
					this.m_ConstantMax = value;
				}
			}

			// Token: 0x170003FB RID: 1019
			// (get) Token: 0x060012DB RID: 4827 RVA: 0x000191F8 File Offset: 0x000173F8
			// (set) Token: 0x060012DC RID: 4828 RVA: 0x00019214 File Offset: 0x00017414
			public float constantMin
			{
				get
				{
					return this.m_ConstantMin;
				}
				set
				{
					this.m_ConstantMin = value;
				}
			}

			// Token: 0x170003FC RID: 1020
			// (get) Token: 0x060012DD RID: 4829 RVA: 0x00019220 File Offset: 0x00017420
			// (set) Token: 0x060012DE RID: 4830 RVA: 0x0001923C File Offset: 0x0001743C
			public float constant
			{
				get
				{
					return this.m_ConstantMax;
				}
				set
				{
					this.m_ConstantMax = value;
				}
			}

			// Token: 0x170003FD RID: 1021
			// (get) Token: 0x060012DF RID: 4831 RVA: 0x00019248 File Offset: 0x00017448
			// (set) Token: 0x060012E0 RID: 4832 RVA: 0x00019264 File Offset: 0x00017464
			public AnimationCurve curve
			{
				get
				{
					return this.m_CurveMax;
				}
				set
				{
					this.m_CurveMax = value;
				}
			}

			// Token: 0x060012E1 RID: 4833 RVA: 0x00019270 File Offset: 0x00017470
			public float Evaluate(float time)
			{
				return this.Evaluate(time, 1f);
			}

			// Token: 0x060012E2 RID: 4834 RVA: 0x00019294 File Offset: 0x00017494
			public float Evaluate(float time, float lerpFactor)
			{
				time = Mathf.Clamp(time, 0f, 1f);
				lerpFactor = Mathf.Clamp(lerpFactor, 0f, 1f);
				float result;
				if (this.m_Mode == ParticleSystemCurveMode.Constant)
				{
					result = this.m_ConstantMax;
				}
				else if (this.m_Mode == ParticleSystemCurveMode.TwoConstants)
				{
					result = Mathf.Lerp(this.m_ConstantMin, this.m_ConstantMax, lerpFactor);
				}
				else
				{
					float num = this.m_CurveMax.Evaluate(time) * this.m_CurveMultiplier;
					if (this.m_Mode == ParticleSystemCurveMode.TwoCurves)
					{
						result = Mathf.Lerp(this.m_CurveMin.Evaluate(time) * this.m_CurveMultiplier, num, lerpFactor);
					}
					else
					{
						result = num;
					}
				}
				return result;
			}

			// Token: 0x060012E3 RID: 4835 RVA: 0x0001934C File Offset: 0x0001754C
			public static implicit operator ParticleSystem.MinMaxCurve(float constant)
			{
				return new ParticleSystem.MinMaxCurve(constant);
			}

			// Token: 0x0400033E RID: 830
			private ParticleSystemCurveMode m_Mode;

			// Token: 0x0400033F RID: 831
			private float m_CurveMultiplier;

			// Token: 0x04000340 RID: 832
			private AnimationCurve m_CurveMin;

			// Token: 0x04000341 RID: 833
			private AnimationCurve m_CurveMax;

			// Token: 0x04000342 RID: 834
			private float m_ConstantMin;

			// Token: 0x04000343 RID: 835
			private float m_ConstantMax;
		}

		// Token: 0x02000128 RID: 296
		public struct MinMaxGradient
		{
			// Token: 0x060012E4 RID: 4836 RVA: 0x00019368 File Offset: 0x00017568
			public MinMaxGradient(Color color)
			{
				this.m_Mode = ParticleSystemGradientMode.Color;
				this.m_GradientMin = null;
				this.m_GradientMax = null;
				this.m_ColorMin = Color.black;
				this.m_ColorMax = color;
			}

			// Token: 0x060012E5 RID: 4837 RVA: 0x00019394 File Offset: 0x00017594
			public MinMaxGradient(Gradient gradient)
			{
				this.m_Mode = ParticleSystemGradientMode.Gradient;
				this.m_GradientMin = null;
				this.m_GradientMax = gradient;
				this.m_ColorMin = Color.black;
				this.m_ColorMax = Color.black;
			}

			// Token: 0x060012E6 RID: 4838 RVA: 0x000193C4 File Offset: 0x000175C4
			public MinMaxGradient(Color min, Color max)
			{
				this.m_Mode = ParticleSystemGradientMode.TwoColors;
				this.m_GradientMin = null;
				this.m_GradientMax = null;
				this.m_ColorMin = min;
				this.m_ColorMax = max;
			}

			// Token: 0x060012E7 RID: 4839 RVA: 0x000193EC File Offset: 0x000175EC
			public MinMaxGradient(Gradient min, Gradient max)
			{
				this.m_Mode = ParticleSystemGradientMode.TwoGradients;
				this.m_GradientMin = min;
				this.m_GradientMax = max;
				this.m_ColorMin = Color.black;
				this.m_ColorMax = Color.black;
			}

			// Token: 0x170003FE RID: 1022
			// (get) Token: 0x060012E8 RID: 4840 RVA: 0x0001941C File Offset: 0x0001761C
			// (set) Token: 0x060012E9 RID: 4841 RVA: 0x00019438 File Offset: 0x00017638
			public ParticleSystemGradientMode mode
			{
				get
				{
					return this.m_Mode;
				}
				set
				{
					this.m_Mode = value;
				}
			}

			// Token: 0x170003FF RID: 1023
			// (get) Token: 0x060012EA RID: 4842 RVA: 0x00019444 File Offset: 0x00017644
			// (set) Token: 0x060012EB RID: 4843 RVA: 0x00019460 File Offset: 0x00017660
			public Gradient gradientMax
			{
				get
				{
					return this.m_GradientMax;
				}
				set
				{
					this.m_GradientMax = value;
				}
			}

			// Token: 0x17000400 RID: 1024
			// (get) Token: 0x060012EC RID: 4844 RVA: 0x0001946C File Offset: 0x0001766C
			// (set) Token: 0x060012ED RID: 4845 RVA: 0x00019488 File Offset: 0x00017688
			public Gradient gradientMin
			{
				get
				{
					return this.m_GradientMin;
				}
				set
				{
					this.m_GradientMin = value;
				}
			}

			// Token: 0x17000401 RID: 1025
			// (get) Token: 0x060012EE RID: 4846 RVA: 0x00019494 File Offset: 0x00017694
			// (set) Token: 0x060012EF RID: 4847 RVA: 0x000194B0 File Offset: 0x000176B0
			public Color colorMax
			{
				get
				{
					return this.m_ColorMax;
				}
				set
				{
					this.m_ColorMax = value;
				}
			}

			// Token: 0x17000402 RID: 1026
			// (get) Token: 0x060012F0 RID: 4848 RVA: 0x000194BC File Offset: 0x000176BC
			// (set) Token: 0x060012F1 RID: 4849 RVA: 0x000194D8 File Offset: 0x000176D8
			public Color colorMin
			{
				get
				{
					return this.m_ColorMin;
				}
				set
				{
					this.m_ColorMin = value;
				}
			}

			// Token: 0x17000403 RID: 1027
			// (get) Token: 0x060012F2 RID: 4850 RVA: 0x000194E4 File Offset: 0x000176E4
			// (set) Token: 0x060012F3 RID: 4851 RVA: 0x00019500 File Offset: 0x00017700
			public Color color
			{
				get
				{
					return this.m_ColorMax;
				}
				set
				{
					this.m_ColorMax = value;
				}
			}

			// Token: 0x17000404 RID: 1028
			// (get) Token: 0x060012F4 RID: 4852 RVA: 0x0001950C File Offset: 0x0001770C
			// (set) Token: 0x060012F5 RID: 4853 RVA: 0x00019528 File Offset: 0x00017728
			public Gradient gradient
			{
				get
				{
					return this.m_GradientMax;
				}
				set
				{
					this.m_GradientMax = value;
				}
			}

			// Token: 0x060012F6 RID: 4854 RVA: 0x00019534 File Offset: 0x00017734
			public Color Evaluate(float time)
			{
				return this.Evaluate(time, 1f);
			}

			// Token: 0x060012F7 RID: 4855 RVA: 0x00019558 File Offset: 0x00017758
			public Color Evaluate(float time, float lerpFactor)
			{
				time = Mathf.Clamp(time, 0f, 1f);
				lerpFactor = Mathf.Clamp(lerpFactor, 0f, 1f);
				Color result;
				if (this.m_Mode == ParticleSystemGradientMode.Color)
				{
					result = this.m_ColorMax;
				}
				else if (this.m_Mode == ParticleSystemGradientMode.TwoColors)
				{
					result = Color.Lerp(this.m_ColorMin, this.m_ColorMax, lerpFactor);
				}
				else
				{
					Color color = this.m_GradientMax.Evaluate(time);
					if (this.m_Mode == ParticleSystemGradientMode.TwoGradients)
					{
						result = Color.Lerp(this.m_GradientMin.Evaluate(time), color, lerpFactor);
					}
					else
					{
						result = color;
					}
				}
				return result;
			}

			// Token: 0x060012F8 RID: 4856 RVA: 0x00019600 File Offset: 0x00017800
			public static implicit operator ParticleSystem.MinMaxGradient(Color color)
			{
				return new ParticleSystem.MinMaxGradient(color);
			}

			// Token: 0x060012F9 RID: 4857 RVA: 0x0001961C File Offset: 0x0001781C
			public static implicit operator ParticleSystem.MinMaxGradient(Gradient gradient)
			{
				return new ParticleSystem.MinMaxGradient(gradient);
			}

			// Token: 0x04000344 RID: 836
			private ParticleSystemGradientMode m_Mode;

			// Token: 0x04000345 RID: 837
			private Gradient m_GradientMin;

			// Token: 0x04000346 RID: 838
			private Gradient m_GradientMax;

			// Token: 0x04000347 RID: 839
			private Color m_ColorMin;

			// Token: 0x04000348 RID: 840
			private Color m_ColorMax;
		}

		// Token: 0x02000129 RID: 297
		public struct MainModule
		{
			// Token: 0x060012FA RID: 4858 RVA: 0x00019638 File Offset: 0x00017838
			internal MainModule(ParticleSystem particleSystem)
			{
				this.m_ParticleSystem = particleSystem;
			}

			// Token: 0x17000405 RID: 1029
			// (get) Token: 0x060012FB RID: 4859 RVA: 0x00019644 File Offset: 0x00017844
			// (set) Token: 0x060012FC RID: 4860 RVA: 0x00019664 File Offset: 0x00017864
			public float duration
			{
				get
				{
					return ParticleSystem.MainModule.GetDuration(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.MainModule.SetDuration(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000406 RID: 1030
			// (get) Token: 0x060012FD RID: 4861 RVA: 0x00019674 File Offset: 0x00017874
			// (set) Token: 0x060012FE RID: 4862 RVA: 0x00019694 File Offset: 0x00017894
			public bool loop
			{
				get
				{
					return ParticleSystem.MainModule.GetLoop(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.MainModule.SetLoop(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000407 RID: 1031
			// (get) Token: 0x060012FF RID: 4863 RVA: 0x000196A4 File Offset: 0x000178A4
			// (set) Token: 0x06001300 RID: 4864 RVA: 0x000196C4 File Offset: 0x000178C4
			public bool prewarm
			{
				get
				{
					return ParticleSystem.MainModule.GetPrewarm(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.MainModule.SetPrewarm(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000408 RID: 1032
			// (get) Token: 0x06001302 RID: 4866 RVA: 0x000196E4 File Offset: 0x000178E4
			// (set) Token: 0x06001301 RID: 4865 RVA: 0x000196D4 File Offset: 0x000178D4
			public ParticleSystem.MinMaxCurve startDelay
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.MainModule.GetStartDelay(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.MainModule.SetStartDelay(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000409 RID: 1033
			// (get) Token: 0x06001303 RID: 4867 RVA: 0x00019710 File Offset: 0x00017910
			// (set) Token: 0x06001304 RID: 4868 RVA: 0x00019730 File Offset: 0x00017930
			public float startDelayMultiplier
			{
				get
				{
					return ParticleSystem.MainModule.GetStartDelayMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.MainModule.SetStartDelayMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700040A RID: 1034
			// (get) Token: 0x06001306 RID: 4870 RVA: 0x00019750 File Offset: 0x00017950
			// (set) Token: 0x06001305 RID: 4869 RVA: 0x00019740 File Offset: 0x00017940
			public ParticleSystem.MinMaxCurve startLifetime
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.MainModule.GetStartLifetime(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.MainModule.SetStartLifetime(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x1700040B RID: 1035
			// (get) Token: 0x06001307 RID: 4871 RVA: 0x0001977C File Offset: 0x0001797C
			// (set) Token: 0x06001308 RID: 4872 RVA: 0x0001979C File Offset: 0x0001799C
			public float startLifetimeMultiplier
			{
				get
				{
					return ParticleSystem.MainModule.GetStartLifetimeMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.MainModule.SetStartLifetimeMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700040C RID: 1036
			// (get) Token: 0x0600130A RID: 4874 RVA: 0x000197BC File Offset: 0x000179BC
			// (set) Token: 0x06001309 RID: 4873 RVA: 0x000197AC File Offset: 0x000179AC
			public ParticleSystem.MinMaxCurve startSpeed
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.MainModule.GetStartSpeed(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.MainModule.SetStartSpeed(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x1700040D RID: 1037
			// (get) Token: 0x0600130B RID: 4875 RVA: 0x000197E8 File Offset: 0x000179E8
			// (set) Token: 0x0600130C RID: 4876 RVA: 0x00019808 File Offset: 0x00017A08
			public float startSpeedMultiplier
			{
				get
				{
					return ParticleSystem.MainModule.GetStartSpeedMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.MainModule.SetStartSpeedMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700040E RID: 1038
			// (get) Token: 0x0600130D RID: 4877 RVA: 0x00019818 File Offset: 0x00017A18
			// (set) Token: 0x0600130E RID: 4878 RVA: 0x00019838 File Offset: 0x00017A38
			public bool startSize3D
			{
				get
				{
					return ParticleSystem.MainModule.GetStartSize3D(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.MainModule.SetStartSize3D(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700040F RID: 1039
			// (get) Token: 0x06001310 RID: 4880 RVA: 0x00019858 File Offset: 0x00017A58
			// (set) Token: 0x0600130F RID: 4879 RVA: 0x00019848 File Offset: 0x00017A48
			public ParticleSystem.MinMaxCurve startSize
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.MainModule.GetStartSizeX(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.MainModule.SetStartSizeX(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000410 RID: 1040
			// (get) Token: 0x06001311 RID: 4881 RVA: 0x00019884 File Offset: 0x00017A84
			// (set) Token: 0x06001312 RID: 4882 RVA: 0x000198A4 File Offset: 0x00017AA4
			public float startSizeMultiplier
			{
				get
				{
					return ParticleSystem.MainModule.GetStartSizeXMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.MainModule.SetStartSizeXMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000411 RID: 1041
			// (get) Token: 0x06001314 RID: 4884 RVA: 0x000198C4 File Offset: 0x00017AC4
			// (set) Token: 0x06001313 RID: 4883 RVA: 0x000198B4 File Offset: 0x00017AB4
			public ParticleSystem.MinMaxCurve startSizeX
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.MainModule.GetStartSizeX(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.MainModule.SetStartSizeX(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000412 RID: 1042
			// (get) Token: 0x06001315 RID: 4885 RVA: 0x000198F0 File Offset: 0x00017AF0
			// (set) Token: 0x06001316 RID: 4886 RVA: 0x00019910 File Offset: 0x00017B10
			public float startSizeXMultiplier
			{
				get
				{
					return ParticleSystem.MainModule.GetStartSizeXMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.MainModule.SetStartSizeXMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000413 RID: 1043
			// (get) Token: 0x06001318 RID: 4888 RVA: 0x00019930 File Offset: 0x00017B30
			// (set) Token: 0x06001317 RID: 4887 RVA: 0x00019920 File Offset: 0x00017B20
			public ParticleSystem.MinMaxCurve startSizeY
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.MainModule.GetStartSizeY(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.MainModule.SetStartSizeY(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000414 RID: 1044
			// (get) Token: 0x06001319 RID: 4889 RVA: 0x0001995C File Offset: 0x00017B5C
			// (set) Token: 0x0600131A RID: 4890 RVA: 0x0001997C File Offset: 0x00017B7C
			public float startSizeYMultiplier
			{
				get
				{
					return ParticleSystem.MainModule.GetStartSizeYMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.MainModule.SetStartSizeYMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000415 RID: 1045
			// (get) Token: 0x0600131C RID: 4892 RVA: 0x0001999C File Offset: 0x00017B9C
			// (set) Token: 0x0600131B RID: 4891 RVA: 0x0001998C File Offset: 0x00017B8C
			public ParticleSystem.MinMaxCurve startSizeZ
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.MainModule.GetStartSizeZ(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.MainModule.SetStartSizeZ(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000416 RID: 1046
			// (get) Token: 0x0600131D RID: 4893 RVA: 0x000199C8 File Offset: 0x00017BC8
			// (set) Token: 0x0600131E RID: 4894 RVA: 0x000199E8 File Offset: 0x00017BE8
			public float startSizeZMultiplier
			{
				get
				{
					return ParticleSystem.MainModule.GetStartSizeZMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.MainModule.SetStartSizeZMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000417 RID: 1047
			// (get) Token: 0x0600131F RID: 4895 RVA: 0x000199F8 File Offset: 0x00017BF8
			// (set) Token: 0x06001320 RID: 4896 RVA: 0x00019A18 File Offset: 0x00017C18
			public bool startRotation3D
			{
				get
				{
					return ParticleSystem.MainModule.GetStartRotation3D(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.MainModule.SetStartRotation3D(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000418 RID: 1048
			// (get) Token: 0x06001322 RID: 4898 RVA: 0x00019A38 File Offset: 0x00017C38
			// (set) Token: 0x06001321 RID: 4897 RVA: 0x00019A28 File Offset: 0x00017C28
			public ParticleSystem.MinMaxCurve startRotation
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.MainModule.GetStartRotationZ(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.MainModule.SetStartRotationZ(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000419 RID: 1049
			// (get) Token: 0x06001323 RID: 4899 RVA: 0x00019A64 File Offset: 0x00017C64
			// (set) Token: 0x06001324 RID: 4900 RVA: 0x00019A84 File Offset: 0x00017C84
			public float startRotationMultiplier
			{
				get
				{
					return ParticleSystem.MainModule.GetStartRotationZMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.MainModule.SetStartRotationZMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700041A RID: 1050
			// (get) Token: 0x06001326 RID: 4902 RVA: 0x00019AA4 File Offset: 0x00017CA4
			// (set) Token: 0x06001325 RID: 4901 RVA: 0x00019A94 File Offset: 0x00017C94
			public ParticleSystem.MinMaxCurve startRotationX
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.MainModule.GetStartRotationX(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.MainModule.SetStartRotationX(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x1700041B RID: 1051
			// (get) Token: 0x06001327 RID: 4903 RVA: 0x00019AD0 File Offset: 0x00017CD0
			// (set) Token: 0x06001328 RID: 4904 RVA: 0x00019AF0 File Offset: 0x00017CF0
			public float startRotationXMultiplier
			{
				get
				{
					return ParticleSystem.MainModule.GetStartRotationXMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.MainModule.SetStartRotationXMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700041C RID: 1052
			// (get) Token: 0x0600132A RID: 4906 RVA: 0x00019B10 File Offset: 0x00017D10
			// (set) Token: 0x06001329 RID: 4905 RVA: 0x00019B00 File Offset: 0x00017D00
			public ParticleSystem.MinMaxCurve startRotationY
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.MainModule.GetStartRotationY(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.MainModule.SetStartRotationY(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x1700041D RID: 1053
			// (get) Token: 0x0600132B RID: 4907 RVA: 0x00019B3C File Offset: 0x00017D3C
			// (set) Token: 0x0600132C RID: 4908 RVA: 0x00019B5C File Offset: 0x00017D5C
			public float startRotationYMultiplier
			{
				get
				{
					return ParticleSystem.MainModule.GetStartRotationYMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.MainModule.SetStartRotationYMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700041E RID: 1054
			// (get) Token: 0x0600132E RID: 4910 RVA: 0x00019B7C File Offset: 0x00017D7C
			// (set) Token: 0x0600132D RID: 4909 RVA: 0x00019B6C File Offset: 0x00017D6C
			public ParticleSystem.MinMaxCurve startRotationZ
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.MainModule.GetStartRotationZ(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.MainModule.SetStartRotationZ(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x1700041F RID: 1055
			// (get) Token: 0x0600132F RID: 4911 RVA: 0x00019BA8 File Offset: 0x00017DA8
			// (set) Token: 0x06001330 RID: 4912 RVA: 0x00019BC8 File Offset: 0x00017DC8
			public float startRotationZMultiplier
			{
				get
				{
					return ParticleSystem.MainModule.GetStartRotationZMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.MainModule.SetStartRotationZMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000420 RID: 1056
			// (get) Token: 0x06001331 RID: 4913 RVA: 0x00019BD8 File Offset: 0x00017DD8
			// (set) Token: 0x06001332 RID: 4914 RVA: 0x00019BF8 File Offset: 0x00017DF8
			public float randomizeRotationDirection
			{
				get
				{
					return ParticleSystem.MainModule.GetRandomizeRotationDirection(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.MainModule.SetRandomizeRotationDirection(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000421 RID: 1057
			// (get) Token: 0x06001334 RID: 4916 RVA: 0x00019C18 File Offset: 0x00017E18
			// (set) Token: 0x06001333 RID: 4915 RVA: 0x00019C08 File Offset: 0x00017E08
			public ParticleSystem.MinMaxGradient startColor
			{
				get
				{
					ParticleSystem.MinMaxGradient result = default(ParticleSystem.MinMaxGradient);
					ParticleSystem.MainModule.GetStartColor(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.MainModule.SetStartColor(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000422 RID: 1058
			// (get) Token: 0x06001336 RID: 4918 RVA: 0x00019C54 File Offset: 0x00017E54
			// (set) Token: 0x06001335 RID: 4917 RVA: 0x00019C44 File Offset: 0x00017E44
			public ParticleSystem.MinMaxCurve gravityModifier
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.MainModule.GetGravityModifier(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.MainModule.SetGravityModifier(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000423 RID: 1059
			// (get) Token: 0x06001337 RID: 4919 RVA: 0x00019C80 File Offset: 0x00017E80
			// (set) Token: 0x06001338 RID: 4920 RVA: 0x00019CA0 File Offset: 0x00017EA0
			public float gravityModifierMultiplier
			{
				get
				{
					return ParticleSystem.MainModule.GetGravityModifierMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.MainModule.SetGravityModifierMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000424 RID: 1060
			// (get) Token: 0x06001339 RID: 4921 RVA: 0x00019CB0 File Offset: 0x00017EB0
			// (set) Token: 0x0600133A RID: 4922 RVA: 0x00019CD0 File Offset: 0x00017ED0
			public ParticleSystemSimulationSpace simulationSpace
			{
				get
				{
					return ParticleSystem.MainModule.GetSimulationSpace(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.MainModule.SetSimulationSpace(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000425 RID: 1061
			// (get) Token: 0x0600133B RID: 4923 RVA: 0x00019CE0 File Offset: 0x00017EE0
			// (set) Token: 0x0600133C RID: 4924 RVA: 0x00019D00 File Offset: 0x00017F00
			public Transform customSimulationSpace
			{
				get
				{
					return ParticleSystem.MainModule.GetCustomSimulationSpace(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.MainModule.SetCustomSimulationSpace(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000426 RID: 1062
			// (get) Token: 0x0600133D RID: 4925 RVA: 0x00019D10 File Offset: 0x00017F10
			// (set) Token: 0x0600133E RID: 4926 RVA: 0x00019D30 File Offset: 0x00017F30
			public float simulationSpeed
			{
				get
				{
					return ParticleSystem.MainModule.GetSimulationSpeed(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.MainModule.SetSimulationSpeed(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000427 RID: 1063
			// (get) Token: 0x0600133F RID: 4927 RVA: 0x00019D40 File Offset: 0x00017F40
			// (set) Token: 0x06001340 RID: 4928 RVA: 0x00019D60 File Offset: 0x00017F60
			public ParticleSystemScalingMode scalingMode
			{
				get
				{
					return ParticleSystem.MainModule.GetScalingMode(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.MainModule.SetScalingMode(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000428 RID: 1064
			// (get) Token: 0x06001341 RID: 4929 RVA: 0x00019D70 File Offset: 0x00017F70
			// (set) Token: 0x06001342 RID: 4930 RVA: 0x00019D90 File Offset: 0x00017F90
			public bool playOnAwake
			{
				get
				{
					return ParticleSystem.MainModule.GetPlayOnAwake(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.MainModule.SetPlayOnAwake(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000429 RID: 1065
			// (get) Token: 0x06001343 RID: 4931 RVA: 0x00019DA0 File Offset: 0x00017FA0
			// (set) Token: 0x06001344 RID: 4932 RVA: 0x00019DC0 File Offset: 0x00017FC0
			public int maxParticles
			{
				get
				{
					return ParticleSystem.MainModule.GetMaxParticles(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.MainModule.SetMaxParticles(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x06001345 RID: 4933
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetEnabled(ParticleSystem system, bool value);

			// Token: 0x06001346 RID: 4934
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetEnabled(ParticleSystem system);

			// Token: 0x06001347 RID: 4935
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetDuration(ParticleSystem system, float value);

			// Token: 0x06001348 RID: 4936
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetDuration(ParticleSystem system);

			// Token: 0x06001349 RID: 4937
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetLoop(ParticleSystem system, bool value);

			// Token: 0x0600134A RID: 4938
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetLoop(ParticleSystem system);

			// Token: 0x0600134B RID: 4939
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetPrewarm(ParticleSystem system, bool value);

			// Token: 0x0600134C RID: 4940
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetPrewarm(ParticleSystem system);

			// Token: 0x0600134D RID: 4941
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStartDelay(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x0600134E RID: 4942
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetStartDelay(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x0600134F RID: 4943
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStartDelayMultiplier(ParticleSystem system, float value);

			// Token: 0x06001350 RID: 4944
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetStartDelayMultiplier(ParticleSystem system);

			// Token: 0x06001351 RID: 4945
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStartLifetime(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001352 RID: 4946
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetStartLifetime(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001353 RID: 4947
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStartLifetimeMultiplier(ParticleSystem system, float value);

			// Token: 0x06001354 RID: 4948
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetStartLifetimeMultiplier(ParticleSystem system);

			// Token: 0x06001355 RID: 4949
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStartSpeed(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001356 RID: 4950
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetStartSpeed(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001357 RID: 4951
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStartSpeedMultiplier(ParticleSystem system, float value);

			// Token: 0x06001358 RID: 4952
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetStartSpeedMultiplier(ParticleSystem system);

			// Token: 0x06001359 RID: 4953
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStartSize3D(ParticleSystem system, bool value);

			// Token: 0x0600135A RID: 4954
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetStartSize3D(ParticleSystem system);

			// Token: 0x0600135B RID: 4955
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStartSizeX(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x0600135C RID: 4956
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetStartSizeX(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x0600135D RID: 4957
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStartSizeXMultiplier(ParticleSystem system, float value);

			// Token: 0x0600135E RID: 4958
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetStartSizeXMultiplier(ParticleSystem system);

			// Token: 0x0600135F RID: 4959
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStartSizeY(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001360 RID: 4960
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetStartSizeY(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001361 RID: 4961
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStartSizeYMultiplier(ParticleSystem system, float value);

			// Token: 0x06001362 RID: 4962
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetStartSizeYMultiplier(ParticleSystem system);

			// Token: 0x06001363 RID: 4963
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStartSizeZ(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001364 RID: 4964
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetStartSizeZ(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001365 RID: 4965
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStartSizeZMultiplier(ParticleSystem system, float value);

			// Token: 0x06001366 RID: 4966
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetStartSizeZMultiplier(ParticleSystem system);

			// Token: 0x06001367 RID: 4967
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStartRotation3D(ParticleSystem system, bool value);

			// Token: 0x06001368 RID: 4968
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetStartRotation3D(ParticleSystem system);

			// Token: 0x06001369 RID: 4969
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStartRotationX(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x0600136A RID: 4970
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetStartRotationX(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x0600136B RID: 4971
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStartRotationXMultiplier(ParticleSystem system, float value);

			// Token: 0x0600136C RID: 4972
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetStartRotationXMultiplier(ParticleSystem system);

			// Token: 0x0600136D RID: 4973
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStartRotationY(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x0600136E RID: 4974
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetStartRotationY(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x0600136F RID: 4975
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStartRotationYMultiplier(ParticleSystem system, float value);

			// Token: 0x06001370 RID: 4976
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetStartRotationYMultiplier(ParticleSystem system);

			// Token: 0x06001371 RID: 4977
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStartRotationZ(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001372 RID: 4978
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetStartRotationZ(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001373 RID: 4979
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStartRotationZMultiplier(ParticleSystem system, float value);

			// Token: 0x06001374 RID: 4980
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetStartRotationZMultiplier(ParticleSystem system);

			// Token: 0x06001375 RID: 4981
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRandomizeRotationDirection(ParticleSystem system, float value);

			// Token: 0x06001376 RID: 4982
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetRandomizeRotationDirection(ParticleSystem system);

			// Token: 0x06001377 RID: 4983
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStartColor(ParticleSystem system, ref ParticleSystem.MinMaxGradient gradient);

			// Token: 0x06001378 RID: 4984
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetStartColor(ParticleSystem system, ref ParticleSystem.MinMaxGradient gradient);

			// Token: 0x06001379 RID: 4985
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetGravityModifier(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x0600137A RID: 4986
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetGravityModifier(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x0600137B RID: 4987
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetGravityModifierMultiplier(ParticleSystem system, float value);

			// Token: 0x0600137C RID: 4988
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetGravityModifierMultiplier(ParticleSystem system);

			// Token: 0x0600137D RID: 4989
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetSimulationSpace(ParticleSystem system, ParticleSystemSimulationSpace value);

			// Token: 0x0600137E RID: 4990
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern ParticleSystemSimulationSpace GetSimulationSpace(ParticleSystem system);

			// Token: 0x0600137F RID: 4991
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetCustomSimulationSpace(ParticleSystem system, Transform value);

			// Token: 0x06001380 RID: 4992
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern Transform GetCustomSimulationSpace(ParticleSystem system);

			// Token: 0x06001381 RID: 4993
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetSimulationSpeed(ParticleSystem system, float value);

			// Token: 0x06001382 RID: 4994
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetSimulationSpeed(ParticleSystem system);

			// Token: 0x06001383 RID: 4995
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetScalingMode(ParticleSystem system, ParticleSystemScalingMode value);

			// Token: 0x06001384 RID: 4996
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern ParticleSystemScalingMode GetScalingMode(ParticleSystem system);

			// Token: 0x06001385 RID: 4997
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetPlayOnAwake(ParticleSystem system, bool value);

			// Token: 0x06001386 RID: 4998
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetPlayOnAwake(ParticleSystem system);

			// Token: 0x06001387 RID: 4999
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetMaxParticles(ParticleSystem system, int value);

			// Token: 0x06001388 RID: 5000
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetMaxParticles(ParticleSystem system);

			// Token: 0x04000349 RID: 841
			private ParticleSystem m_ParticleSystem;
		}

		// Token: 0x0200012A RID: 298
		public struct EmissionModule
		{
			// Token: 0x06001389 RID: 5001 RVA: 0x00019DD0 File Offset: 0x00017FD0
			internal EmissionModule(ParticleSystem particleSystem)
			{
				this.m_ParticleSystem = particleSystem;
			}

			// Token: 0x1700042A RID: 1066
			// (get) Token: 0x0600138B RID: 5003 RVA: 0x00019DEC File Offset: 0x00017FEC
			// (set) Token: 0x0600138A RID: 5002 RVA: 0x00019DDC File Offset: 0x00017FDC
			public bool enabled
			{
				get
				{
					return ParticleSystem.EmissionModule.GetEnabled(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.EmissionModule.SetEnabled(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700042B RID: 1067
			// (get) Token: 0x0600138D RID: 5005 RVA: 0x00019E1C File Offset: 0x0001801C
			// (set) Token: 0x0600138C RID: 5004 RVA: 0x00019E0C File Offset: 0x0001800C
			public ParticleSystem.MinMaxCurve rateOverTime
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.EmissionModule.GetRateOverTime(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.EmissionModule.SetRateOverTime(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x1700042C RID: 1068
			// (get) Token: 0x0600138E RID: 5006 RVA: 0x00019E48 File Offset: 0x00018048
			// (set) Token: 0x0600138F RID: 5007 RVA: 0x00019E68 File Offset: 0x00018068
			public float rateOverTimeMultiplier
			{
				get
				{
					return ParticleSystem.EmissionModule.GetRateOverTimeMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.EmissionModule.SetRateOverTimeMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700042D RID: 1069
			// (get) Token: 0x06001391 RID: 5009 RVA: 0x00019E88 File Offset: 0x00018088
			// (set) Token: 0x06001390 RID: 5008 RVA: 0x00019E78 File Offset: 0x00018078
			public ParticleSystem.MinMaxCurve rateOverDistance
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.EmissionModule.GetRateOverDistance(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.EmissionModule.SetRateOverDistance(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x1700042E RID: 1070
			// (get) Token: 0x06001392 RID: 5010 RVA: 0x00019EB4 File Offset: 0x000180B4
			// (set) Token: 0x06001393 RID: 5011 RVA: 0x00019ED4 File Offset: 0x000180D4
			public float rateOverDistanceMultiplier
			{
				get
				{
					return ParticleSystem.EmissionModule.GetRateOverDistanceMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.EmissionModule.SetRateOverDistanceMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x06001394 RID: 5012 RVA: 0x00019EE4 File Offset: 0x000180E4
			public void SetBursts(ParticleSystem.Burst[] bursts)
			{
				ParticleSystem.EmissionModule.SetBursts(this.m_ParticleSystem, bursts, bursts.Length);
			}

			// Token: 0x06001395 RID: 5013 RVA: 0x00019EF8 File Offset: 0x000180F8
			public void SetBursts(ParticleSystem.Burst[] bursts, int size)
			{
				ParticleSystem.EmissionModule.SetBursts(this.m_ParticleSystem, bursts, size);
			}

			// Token: 0x06001396 RID: 5014 RVA: 0x00019F08 File Offset: 0x00018108
			public int GetBursts(ParticleSystem.Burst[] bursts)
			{
				return ParticleSystem.EmissionModule.GetBursts(this.m_ParticleSystem, bursts);
			}

			// Token: 0x1700042F RID: 1071
			// (get) Token: 0x06001397 RID: 5015 RVA: 0x00019F2C File Offset: 0x0001812C
			public int burstCount
			{
				get
				{
					return ParticleSystem.EmissionModule.GetBurstCount(this.m_ParticleSystem);
				}
			}

			// Token: 0x17000430 RID: 1072
			// (get) Token: 0x06001398 RID: 5016 RVA: 0x00019F4C File Offset: 0x0001814C
			// (set) Token: 0x06001399 RID: 5017 RVA: 0x00019F64 File Offset: 0x00018164
			[Obsolete("ParticleSystemEmissionType no longer does anything. Time and Distance based emission are now both always active.")]
			public ParticleSystemEmissionType type
			{
				get
				{
					return ParticleSystemEmissionType.Time;
				}
				set
				{
				}
			}

			// Token: 0x17000431 RID: 1073
			// (get) Token: 0x0600139B RID: 5019 RVA: 0x00019F78 File Offset: 0x00018178
			// (set) Token: 0x0600139A RID: 5018 RVA: 0x00019F68 File Offset: 0x00018168
			[Obsolete("rate property is deprecated. Use rateOverTime or rateOverDistance instead.")]
			public ParticleSystem.MinMaxCurve rate
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.EmissionModule.GetRateOverTime(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.EmissionModule.SetRateOverTime(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000432 RID: 1074
			// (get) Token: 0x0600139C RID: 5020 RVA: 0x00019FA4 File Offset: 0x000181A4
			// (set) Token: 0x0600139D RID: 5021 RVA: 0x00019FC4 File Offset: 0x000181C4
			[Obsolete("rateMultiplier property is deprecated. Use rateOverTimeMultiplier or rateOverDistanceMultiplier instead.")]
			public float rateMultiplier
			{
				get
				{
					return ParticleSystem.EmissionModule.GetRateOverTimeMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.EmissionModule.SetRateOverTimeMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x0600139E RID: 5022
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetEnabled(ParticleSystem system, bool value);

			// Token: 0x0600139F RID: 5023
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetEnabled(ParticleSystem system);

			// Token: 0x060013A0 RID: 5024
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetBurstCount(ParticleSystem system);

			// Token: 0x060013A1 RID: 5025
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRateOverTime(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060013A2 RID: 5026
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetRateOverTime(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060013A3 RID: 5027
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRateOverTimeMultiplier(ParticleSystem system, float value);

			// Token: 0x060013A4 RID: 5028
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetRateOverTimeMultiplier(ParticleSystem system);

			// Token: 0x060013A5 RID: 5029
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRateOverDistance(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060013A6 RID: 5030
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetRateOverDistance(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060013A7 RID: 5031
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRateOverDistanceMultiplier(ParticleSystem system, float value);

			// Token: 0x060013A8 RID: 5032
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetRateOverDistanceMultiplier(ParticleSystem system);

			// Token: 0x060013A9 RID: 5033
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetBursts(ParticleSystem system, ParticleSystem.Burst[] bursts, int size);

			// Token: 0x060013AA RID: 5034
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetBursts(ParticleSystem system, ParticleSystem.Burst[] bursts);

			// Token: 0x0400034A RID: 842
			private ParticleSystem m_ParticleSystem;
		}

		// Token: 0x0200012B RID: 299
		public struct ShapeModule
		{
			// Token: 0x060013AB RID: 5035 RVA: 0x00019FD4 File Offset: 0x000181D4
			internal ShapeModule(ParticleSystem particleSystem)
			{
				this.m_ParticleSystem = particleSystem;
			}

			// Token: 0x17000433 RID: 1075
			// (get) Token: 0x060013AD RID: 5037 RVA: 0x00019FF0 File Offset: 0x000181F0
			// (set) Token: 0x060013AC RID: 5036 RVA: 0x00019FE0 File Offset: 0x000181E0
			public bool enabled
			{
				get
				{
					return ParticleSystem.ShapeModule.GetEnabled(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ShapeModule.SetEnabled(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000434 RID: 1076
			// (get) Token: 0x060013AE RID: 5038 RVA: 0x0001A010 File Offset: 0x00018210
			// (set) Token: 0x060013AF RID: 5039 RVA: 0x0001A030 File Offset: 0x00018230
			public ParticleSystemShapeType shapeType
			{
				get
				{
					return (ParticleSystemShapeType)ParticleSystem.ShapeModule.GetShapeType(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ShapeModule.SetShapeType(this.m_ParticleSystem, (int)value);
				}
			}

			// Token: 0x17000435 RID: 1077
			// (get) Token: 0x060013B0 RID: 5040 RVA: 0x0001A040 File Offset: 0x00018240
			// (set) Token: 0x060013B1 RID: 5041 RVA: 0x0001A060 File Offset: 0x00018260
			public float randomDirectionAmount
			{
				get
				{
					return ParticleSystem.ShapeModule.GetRandomDirectionAmount(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ShapeModule.SetRandomDirectionAmount(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000436 RID: 1078
			// (get) Token: 0x060013B2 RID: 5042 RVA: 0x0001A070 File Offset: 0x00018270
			// (set) Token: 0x060013B3 RID: 5043 RVA: 0x0001A090 File Offset: 0x00018290
			public float sphericalDirectionAmount
			{
				get
				{
					return ParticleSystem.ShapeModule.GetSphericalDirectionAmount(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ShapeModule.SetSphericalDirectionAmount(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000437 RID: 1079
			// (get) Token: 0x060013B4 RID: 5044 RVA: 0x0001A0A0 File Offset: 0x000182A0
			// (set) Token: 0x060013B5 RID: 5045 RVA: 0x0001A0C0 File Offset: 0x000182C0
			public bool alignToDirection
			{
				get
				{
					return ParticleSystem.ShapeModule.GetAlignToDirection(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ShapeModule.SetAlignToDirection(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000438 RID: 1080
			// (get) Token: 0x060013B6 RID: 5046 RVA: 0x0001A0D0 File Offset: 0x000182D0
			// (set) Token: 0x060013B7 RID: 5047 RVA: 0x0001A0F0 File Offset: 0x000182F0
			public float radius
			{
				get
				{
					return ParticleSystem.ShapeModule.GetRadius(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ShapeModule.SetRadius(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000439 RID: 1081
			// (get) Token: 0x060013B8 RID: 5048 RVA: 0x0001A100 File Offset: 0x00018300
			// (set) Token: 0x060013B9 RID: 5049 RVA: 0x0001A120 File Offset: 0x00018320
			public ParticleSystemShapeMultiModeValue radiusMode
			{
				get
				{
					return (ParticleSystemShapeMultiModeValue)ParticleSystem.ShapeModule.GetRadiusMode(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ShapeModule.SetRadiusMode(this.m_ParticleSystem, (int)value);
				}
			}

			// Token: 0x1700043A RID: 1082
			// (get) Token: 0x060013BA RID: 5050 RVA: 0x0001A130 File Offset: 0x00018330
			// (set) Token: 0x060013BB RID: 5051 RVA: 0x0001A150 File Offset: 0x00018350
			public float radiusSpread
			{
				get
				{
					return ParticleSystem.ShapeModule.GetRadiusSpread(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ShapeModule.SetRadiusSpread(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700043B RID: 1083
			// (get) Token: 0x060013BD RID: 5053 RVA: 0x0001A170 File Offset: 0x00018370
			// (set) Token: 0x060013BC RID: 5052 RVA: 0x0001A160 File Offset: 0x00018360
			public ParticleSystem.MinMaxCurve radiusSpeed
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.ShapeModule.GetRadiusSpeed(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.ShapeModule.SetRadiusSpeed(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x1700043C RID: 1084
			// (get) Token: 0x060013BE RID: 5054 RVA: 0x0001A19C File Offset: 0x0001839C
			// (set) Token: 0x060013BF RID: 5055 RVA: 0x0001A1BC File Offset: 0x000183BC
			public float radiusSpeedMultiplier
			{
				get
				{
					return ParticleSystem.ShapeModule.GetRadiusSpeedMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ShapeModule.SetRadiusSpeedMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700043D RID: 1085
			// (get) Token: 0x060013C0 RID: 5056 RVA: 0x0001A1CC File Offset: 0x000183CC
			// (set) Token: 0x060013C1 RID: 5057 RVA: 0x0001A1EC File Offset: 0x000183EC
			public float angle
			{
				get
				{
					return ParticleSystem.ShapeModule.GetAngle(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ShapeModule.SetAngle(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700043E RID: 1086
			// (get) Token: 0x060013C2 RID: 5058 RVA: 0x0001A1FC File Offset: 0x000183FC
			// (set) Token: 0x060013C3 RID: 5059 RVA: 0x0001A21C File Offset: 0x0001841C
			public float length
			{
				get
				{
					return ParticleSystem.ShapeModule.GetLength(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ShapeModule.SetLength(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700043F RID: 1087
			// (get) Token: 0x060013C4 RID: 5060 RVA: 0x0001A22C File Offset: 0x0001842C
			// (set) Token: 0x060013C5 RID: 5061 RVA: 0x0001A24C File Offset: 0x0001844C
			public Vector3 box
			{
				get
				{
					return ParticleSystem.ShapeModule.GetBox(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ShapeModule.SetBox(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000440 RID: 1088
			// (get) Token: 0x060013C6 RID: 5062 RVA: 0x0001A25C File Offset: 0x0001845C
			// (set) Token: 0x060013C7 RID: 5063 RVA: 0x0001A27C File Offset: 0x0001847C
			public ParticleSystemMeshShapeType meshShapeType
			{
				get
				{
					return (ParticleSystemMeshShapeType)ParticleSystem.ShapeModule.GetMeshShapeType(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ShapeModule.SetMeshShapeType(this.m_ParticleSystem, (int)value);
				}
			}

			// Token: 0x17000441 RID: 1089
			// (get) Token: 0x060013C8 RID: 5064 RVA: 0x0001A28C File Offset: 0x0001848C
			// (set) Token: 0x060013C9 RID: 5065 RVA: 0x0001A2AC File Offset: 0x000184AC
			public Mesh mesh
			{
				get
				{
					return ParticleSystem.ShapeModule.GetMesh(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ShapeModule.SetMesh(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000442 RID: 1090
			// (get) Token: 0x060013CA RID: 5066 RVA: 0x0001A2BC File Offset: 0x000184BC
			// (set) Token: 0x060013CB RID: 5067 RVA: 0x0001A2DC File Offset: 0x000184DC
			public MeshRenderer meshRenderer
			{
				get
				{
					return ParticleSystem.ShapeModule.GetMeshRenderer(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ShapeModule.SetMeshRenderer(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000443 RID: 1091
			// (get) Token: 0x060013CC RID: 5068 RVA: 0x0001A2EC File Offset: 0x000184EC
			// (set) Token: 0x060013CD RID: 5069 RVA: 0x0001A30C File Offset: 0x0001850C
			public SkinnedMeshRenderer skinnedMeshRenderer
			{
				get
				{
					return ParticleSystem.ShapeModule.GetSkinnedMeshRenderer(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ShapeModule.SetSkinnedMeshRenderer(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000444 RID: 1092
			// (get) Token: 0x060013CE RID: 5070 RVA: 0x0001A31C File Offset: 0x0001851C
			// (set) Token: 0x060013CF RID: 5071 RVA: 0x0001A33C File Offset: 0x0001853C
			public bool useMeshMaterialIndex
			{
				get
				{
					return ParticleSystem.ShapeModule.GetUseMeshMaterialIndex(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ShapeModule.SetUseMeshMaterialIndex(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000445 RID: 1093
			// (get) Token: 0x060013D0 RID: 5072 RVA: 0x0001A34C File Offset: 0x0001854C
			// (set) Token: 0x060013D1 RID: 5073 RVA: 0x0001A36C File Offset: 0x0001856C
			public int meshMaterialIndex
			{
				get
				{
					return ParticleSystem.ShapeModule.GetMeshMaterialIndex(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ShapeModule.SetMeshMaterialIndex(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000446 RID: 1094
			// (get) Token: 0x060013D2 RID: 5074 RVA: 0x0001A37C File Offset: 0x0001857C
			// (set) Token: 0x060013D3 RID: 5075 RVA: 0x0001A39C File Offset: 0x0001859C
			public bool useMeshColors
			{
				get
				{
					return ParticleSystem.ShapeModule.GetUseMeshColors(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ShapeModule.SetUseMeshColors(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000447 RID: 1095
			// (get) Token: 0x060013D4 RID: 5076 RVA: 0x0001A3AC File Offset: 0x000185AC
			// (set) Token: 0x060013D5 RID: 5077 RVA: 0x0001A3CC File Offset: 0x000185CC
			public float normalOffset
			{
				get
				{
					return ParticleSystem.ShapeModule.GetNormalOffset(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ShapeModule.SetNormalOffset(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000448 RID: 1096
			// (get) Token: 0x060013D6 RID: 5078 RVA: 0x0001A3DC File Offset: 0x000185DC
			// (set) Token: 0x060013D7 RID: 5079 RVA: 0x0001A3FC File Offset: 0x000185FC
			public float meshScale
			{
				get
				{
					return ParticleSystem.ShapeModule.GetMeshScale(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ShapeModule.SetMeshScale(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000449 RID: 1097
			// (get) Token: 0x060013D8 RID: 5080 RVA: 0x0001A40C File Offset: 0x0001860C
			// (set) Token: 0x060013D9 RID: 5081 RVA: 0x0001A42C File Offset: 0x0001862C
			public float arc
			{
				get
				{
					return ParticleSystem.ShapeModule.GetArc(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ShapeModule.SetArc(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700044A RID: 1098
			// (get) Token: 0x060013DA RID: 5082 RVA: 0x0001A43C File Offset: 0x0001863C
			// (set) Token: 0x060013DB RID: 5083 RVA: 0x0001A45C File Offset: 0x0001865C
			public ParticleSystemShapeMultiModeValue arcMode
			{
				get
				{
					return (ParticleSystemShapeMultiModeValue)ParticleSystem.ShapeModule.GetArcMode(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ShapeModule.SetArcMode(this.m_ParticleSystem, (int)value);
				}
			}

			// Token: 0x1700044B RID: 1099
			// (get) Token: 0x060013DC RID: 5084 RVA: 0x0001A46C File Offset: 0x0001866C
			// (set) Token: 0x060013DD RID: 5085 RVA: 0x0001A48C File Offset: 0x0001868C
			public float arcSpread
			{
				get
				{
					return ParticleSystem.ShapeModule.GetArcSpread(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ShapeModule.SetArcSpread(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700044C RID: 1100
			// (get) Token: 0x060013DF RID: 5087 RVA: 0x0001A4AC File Offset: 0x000186AC
			// (set) Token: 0x060013DE RID: 5086 RVA: 0x0001A49C File Offset: 0x0001869C
			public ParticleSystem.MinMaxCurve arcSpeed
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.ShapeModule.GetArcSpeed(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.ShapeModule.SetArcSpeed(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x1700044D RID: 1101
			// (get) Token: 0x060013E0 RID: 5088 RVA: 0x0001A4D8 File Offset: 0x000186D8
			// (set) Token: 0x060013E1 RID: 5089 RVA: 0x0001A4F8 File Offset: 0x000186F8
			public float arcSpeedMultiplier
			{
				get
				{
					return ParticleSystem.ShapeModule.GetArcSpeedMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ShapeModule.SetArcSpeedMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700044E RID: 1102
			// (get) Token: 0x060013E2 RID: 5090 RVA: 0x0001A508 File Offset: 0x00018708
			// (set) Token: 0x060013E3 RID: 5091 RVA: 0x0001A534 File Offset: 0x00018734
			[Obsolete("randomDirection property is deprecated. Use randomDirectionAmount instead.")]
			public bool randomDirection
			{
				get
				{
					return ParticleSystem.ShapeModule.GetRandomDirectionAmount(this.m_ParticleSystem) >= 0.5f;
				}
				set
				{
					ParticleSystem.ShapeModule.SetRandomDirectionAmount(this.m_ParticleSystem, 1f);
				}
			}

			// Token: 0x060013E4 RID: 5092
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetEnabled(ParticleSystem system, bool value);

			// Token: 0x060013E5 RID: 5093
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetEnabled(ParticleSystem system);

			// Token: 0x060013E6 RID: 5094
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetShapeType(ParticleSystem system, int value);

			// Token: 0x060013E7 RID: 5095
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetShapeType(ParticleSystem system);

			// Token: 0x060013E8 RID: 5096
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRandomDirectionAmount(ParticleSystem system, float value);

			// Token: 0x060013E9 RID: 5097
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetRandomDirectionAmount(ParticleSystem system);

			// Token: 0x060013EA RID: 5098
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetSphericalDirectionAmount(ParticleSystem system, float value);

			// Token: 0x060013EB RID: 5099
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetSphericalDirectionAmount(ParticleSystem system);

			// Token: 0x060013EC RID: 5100
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetAlignToDirection(ParticleSystem system, bool value);

			// Token: 0x060013ED RID: 5101
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetAlignToDirection(ParticleSystem system);

			// Token: 0x060013EE RID: 5102
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRadius(ParticleSystem system, float value);

			// Token: 0x060013EF RID: 5103
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetRadius(ParticleSystem system);

			// Token: 0x060013F0 RID: 5104
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRadiusMode(ParticleSystem system, int value);

			// Token: 0x060013F1 RID: 5105
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetRadiusMode(ParticleSystem system);

			// Token: 0x060013F2 RID: 5106
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRadiusSpread(ParticleSystem system, float value);

			// Token: 0x060013F3 RID: 5107
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetRadiusSpread(ParticleSystem system);

			// Token: 0x060013F4 RID: 5108
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRadiusSpeed(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060013F5 RID: 5109
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetRadiusSpeed(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060013F6 RID: 5110
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRadiusSpeedMultiplier(ParticleSystem system, float value);

			// Token: 0x060013F7 RID: 5111
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetRadiusSpeedMultiplier(ParticleSystem system);

			// Token: 0x060013F8 RID: 5112
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetAngle(ParticleSystem system, float value);

			// Token: 0x060013F9 RID: 5113
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetAngle(ParticleSystem system);

			// Token: 0x060013FA RID: 5114
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetLength(ParticleSystem system, float value);

			// Token: 0x060013FB RID: 5115
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetLength(ParticleSystem system);

			// Token: 0x060013FC RID: 5116 RVA: 0x0001A548 File Offset: 0x00018748
			private static void SetBox(ParticleSystem system, Vector3 value)
			{
				ParticleSystem.ShapeModule.INTERNAL_CALL_SetBox(system, ref value);
			}

			// Token: 0x060013FD RID: 5117
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void INTERNAL_CALL_SetBox(ParticleSystem system, ref Vector3 value);

			// Token: 0x060013FE RID: 5118 RVA: 0x0001A554 File Offset: 0x00018754
			private static Vector3 GetBox(ParticleSystem system)
			{
				Vector3 result;
				ParticleSystem.ShapeModule.INTERNAL_CALL_GetBox(system, out result);
				return result;
			}

			// Token: 0x060013FF RID: 5119
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void INTERNAL_CALL_GetBox(ParticleSystem system, out Vector3 value);

			// Token: 0x06001400 RID: 5120
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetMeshShapeType(ParticleSystem system, int value);

			// Token: 0x06001401 RID: 5121
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetMeshShapeType(ParticleSystem system);

			// Token: 0x06001402 RID: 5122
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetMesh(ParticleSystem system, Mesh value);

			// Token: 0x06001403 RID: 5123
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern Mesh GetMesh(ParticleSystem system);

			// Token: 0x06001404 RID: 5124
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetMeshRenderer(ParticleSystem system, MeshRenderer value);

			// Token: 0x06001405 RID: 5125
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern MeshRenderer GetMeshRenderer(ParticleSystem system);

			// Token: 0x06001406 RID: 5126
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetSkinnedMeshRenderer(ParticleSystem system, SkinnedMeshRenderer value);

			// Token: 0x06001407 RID: 5127
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern SkinnedMeshRenderer GetSkinnedMeshRenderer(ParticleSystem system);

			// Token: 0x06001408 RID: 5128
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetUseMeshMaterialIndex(ParticleSystem system, bool value);

			// Token: 0x06001409 RID: 5129
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetUseMeshMaterialIndex(ParticleSystem system);

			// Token: 0x0600140A RID: 5130
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetMeshMaterialIndex(ParticleSystem system, int value);

			// Token: 0x0600140B RID: 5131
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetMeshMaterialIndex(ParticleSystem system);

			// Token: 0x0600140C RID: 5132
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetUseMeshColors(ParticleSystem system, bool value);

			// Token: 0x0600140D RID: 5133
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetUseMeshColors(ParticleSystem system);

			// Token: 0x0600140E RID: 5134
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetNormalOffset(ParticleSystem system, float value);

			// Token: 0x0600140F RID: 5135
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetNormalOffset(ParticleSystem system);

			// Token: 0x06001410 RID: 5136
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetMeshScale(ParticleSystem system, float value);

			// Token: 0x06001411 RID: 5137
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetMeshScale(ParticleSystem system);

			// Token: 0x06001412 RID: 5138
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetArc(ParticleSystem system, float value);

			// Token: 0x06001413 RID: 5139
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetArc(ParticleSystem system);

			// Token: 0x06001414 RID: 5140
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetArcMode(ParticleSystem system, int value);

			// Token: 0x06001415 RID: 5141
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetArcMode(ParticleSystem system);

			// Token: 0x06001416 RID: 5142
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetArcSpread(ParticleSystem system, float value);

			// Token: 0x06001417 RID: 5143
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetArcSpread(ParticleSystem system);

			// Token: 0x06001418 RID: 5144
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetArcSpeed(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001419 RID: 5145
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetArcSpeed(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x0600141A RID: 5146
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetArcSpeedMultiplier(ParticleSystem system, float value);

			// Token: 0x0600141B RID: 5147
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetArcSpeedMultiplier(ParticleSystem system);

			// Token: 0x0400034B RID: 843
			private ParticleSystem m_ParticleSystem;
		}

		// Token: 0x0200012C RID: 300
		public struct VelocityOverLifetimeModule
		{
			// Token: 0x0600141C RID: 5148 RVA: 0x0001A574 File Offset: 0x00018774
			internal VelocityOverLifetimeModule(ParticleSystem particleSystem)
			{
				this.m_ParticleSystem = particleSystem;
			}

			// Token: 0x1700044F RID: 1103
			// (get) Token: 0x0600141E RID: 5150 RVA: 0x0001A590 File Offset: 0x00018790
			// (set) Token: 0x0600141D RID: 5149 RVA: 0x0001A580 File Offset: 0x00018780
			public bool enabled
			{
				get
				{
					return ParticleSystem.VelocityOverLifetimeModule.GetEnabled(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.VelocityOverLifetimeModule.SetEnabled(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000450 RID: 1104
			// (get) Token: 0x06001420 RID: 5152 RVA: 0x0001A5C0 File Offset: 0x000187C0
			// (set) Token: 0x0600141F RID: 5151 RVA: 0x0001A5B0 File Offset: 0x000187B0
			public ParticleSystem.MinMaxCurve x
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.VelocityOverLifetimeModule.GetX(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.VelocityOverLifetimeModule.SetX(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000451 RID: 1105
			// (get) Token: 0x06001422 RID: 5154 RVA: 0x0001A5FC File Offset: 0x000187FC
			// (set) Token: 0x06001421 RID: 5153 RVA: 0x0001A5EC File Offset: 0x000187EC
			public ParticleSystem.MinMaxCurve y
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.VelocityOverLifetimeModule.GetY(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.VelocityOverLifetimeModule.SetY(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000452 RID: 1106
			// (get) Token: 0x06001424 RID: 5156 RVA: 0x0001A638 File Offset: 0x00018838
			// (set) Token: 0x06001423 RID: 5155 RVA: 0x0001A628 File Offset: 0x00018828
			public ParticleSystem.MinMaxCurve z
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.VelocityOverLifetimeModule.GetZ(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.VelocityOverLifetimeModule.SetZ(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000453 RID: 1107
			// (get) Token: 0x06001425 RID: 5157 RVA: 0x0001A664 File Offset: 0x00018864
			// (set) Token: 0x06001426 RID: 5158 RVA: 0x0001A684 File Offset: 0x00018884
			public float xMultiplier
			{
				get
				{
					return ParticleSystem.VelocityOverLifetimeModule.GetXMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.VelocityOverLifetimeModule.SetXMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000454 RID: 1108
			// (get) Token: 0x06001427 RID: 5159 RVA: 0x0001A694 File Offset: 0x00018894
			// (set) Token: 0x06001428 RID: 5160 RVA: 0x0001A6B4 File Offset: 0x000188B4
			public float yMultiplier
			{
				get
				{
					return ParticleSystem.VelocityOverLifetimeModule.GetYMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.VelocityOverLifetimeModule.SetYMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000455 RID: 1109
			// (get) Token: 0x06001429 RID: 5161 RVA: 0x0001A6C4 File Offset: 0x000188C4
			// (set) Token: 0x0600142A RID: 5162 RVA: 0x0001A6E4 File Offset: 0x000188E4
			public float zMultiplier
			{
				get
				{
					return ParticleSystem.VelocityOverLifetimeModule.GetZMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.VelocityOverLifetimeModule.SetZMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000456 RID: 1110
			// (get) Token: 0x0600142B RID: 5163 RVA: 0x0001A6F4 File Offset: 0x000188F4
			// (set) Token: 0x0600142C RID: 5164 RVA: 0x0001A720 File Offset: 0x00018920
			public ParticleSystemSimulationSpace space
			{
				get
				{
					return (!ParticleSystem.VelocityOverLifetimeModule.GetWorldSpace(this.m_ParticleSystem)) ? ParticleSystemSimulationSpace.Local : ParticleSystemSimulationSpace.World;
				}
				set
				{
					ParticleSystem.VelocityOverLifetimeModule.SetWorldSpace(this.m_ParticleSystem, value == ParticleSystemSimulationSpace.World);
				}
			}

			// Token: 0x0600142D RID: 5165
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetEnabled(ParticleSystem system, bool value);

			// Token: 0x0600142E RID: 5166
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetEnabled(ParticleSystem system);

			// Token: 0x0600142F RID: 5167
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetX(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001430 RID: 5168
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetX(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001431 RID: 5169
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetY(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001432 RID: 5170
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetY(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001433 RID: 5171
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetZ(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001434 RID: 5172
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetZ(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001435 RID: 5173
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetXMultiplier(ParticleSystem system, float value);

			// Token: 0x06001436 RID: 5174
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetXMultiplier(ParticleSystem system);

			// Token: 0x06001437 RID: 5175
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetYMultiplier(ParticleSystem system, float value);

			// Token: 0x06001438 RID: 5176
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetYMultiplier(ParticleSystem system);

			// Token: 0x06001439 RID: 5177
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetZMultiplier(ParticleSystem system, float value);

			// Token: 0x0600143A RID: 5178
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetZMultiplier(ParticleSystem system);

			// Token: 0x0600143B RID: 5179
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetWorldSpace(ParticleSystem system, bool value);

			// Token: 0x0600143C RID: 5180
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetWorldSpace(ParticleSystem system);

			// Token: 0x0400034C RID: 844
			private ParticleSystem m_ParticleSystem;
		}

		// Token: 0x0200012D RID: 301
		public struct LimitVelocityOverLifetimeModule
		{
			// Token: 0x0600143D RID: 5181 RVA: 0x0001A734 File Offset: 0x00018934
			internal LimitVelocityOverLifetimeModule(ParticleSystem particleSystem)
			{
				this.m_ParticleSystem = particleSystem;
			}

			// Token: 0x17000457 RID: 1111
			// (get) Token: 0x0600143F RID: 5183 RVA: 0x0001A750 File Offset: 0x00018950
			// (set) Token: 0x0600143E RID: 5182 RVA: 0x0001A740 File Offset: 0x00018940
			public bool enabled
			{
				get
				{
					return ParticleSystem.LimitVelocityOverLifetimeModule.GetEnabled(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.LimitVelocityOverLifetimeModule.SetEnabled(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000458 RID: 1112
			// (get) Token: 0x06001441 RID: 5185 RVA: 0x0001A780 File Offset: 0x00018980
			// (set) Token: 0x06001440 RID: 5184 RVA: 0x0001A770 File Offset: 0x00018970
			public ParticleSystem.MinMaxCurve limitX
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.LimitVelocityOverLifetimeModule.GetX(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.LimitVelocityOverLifetimeModule.SetX(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000459 RID: 1113
			// (get) Token: 0x06001442 RID: 5186 RVA: 0x0001A7AC File Offset: 0x000189AC
			// (set) Token: 0x06001443 RID: 5187 RVA: 0x0001A7CC File Offset: 0x000189CC
			public float limitXMultiplier
			{
				get
				{
					return ParticleSystem.LimitVelocityOverLifetimeModule.GetXMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.LimitVelocityOverLifetimeModule.SetXMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700045A RID: 1114
			// (get) Token: 0x06001445 RID: 5189 RVA: 0x0001A7EC File Offset: 0x000189EC
			// (set) Token: 0x06001444 RID: 5188 RVA: 0x0001A7DC File Offset: 0x000189DC
			public ParticleSystem.MinMaxCurve limitY
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.LimitVelocityOverLifetimeModule.GetY(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.LimitVelocityOverLifetimeModule.SetY(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x1700045B RID: 1115
			// (get) Token: 0x06001446 RID: 5190 RVA: 0x0001A818 File Offset: 0x00018A18
			// (set) Token: 0x06001447 RID: 5191 RVA: 0x0001A838 File Offset: 0x00018A38
			public float limitYMultiplier
			{
				get
				{
					return ParticleSystem.LimitVelocityOverLifetimeModule.GetYMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.LimitVelocityOverLifetimeModule.SetYMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700045C RID: 1116
			// (get) Token: 0x06001449 RID: 5193 RVA: 0x0001A858 File Offset: 0x00018A58
			// (set) Token: 0x06001448 RID: 5192 RVA: 0x0001A848 File Offset: 0x00018A48
			public ParticleSystem.MinMaxCurve limitZ
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.LimitVelocityOverLifetimeModule.GetZ(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.LimitVelocityOverLifetimeModule.SetZ(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x1700045D RID: 1117
			// (get) Token: 0x0600144A RID: 5194 RVA: 0x0001A884 File Offset: 0x00018A84
			// (set) Token: 0x0600144B RID: 5195 RVA: 0x0001A8A4 File Offset: 0x00018AA4
			public float limitZMultiplier
			{
				get
				{
					return ParticleSystem.LimitVelocityOverLifetimeModule.GetZMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.LimitVelocityOverLifetimeModule.SetZMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700045E RID: 1118
			// (get) Token: 0x0600144D RID: 5197 RVA: 0x0001A8C4 File Offset: 0x00018AC4
			// (set) Token: 0x0600144C RID: 5196 RVA: 0x0001A8B4 File Offset: 0x00018AB4
			public ParticleSystem.MinMaxCurve limit
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.LimitVelocityOverLifetimeModule.GetMagnitude(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.LimitVelocityOverLifetimeModule.SetMagnitude(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x1700045F RID: 1119
			// (get) Token: 0x0600144E RID: 5198 RVA: 0x0001A8F0 File Offset: 0x00018AF0
			// (set) Token: 0x0600144F RID: 5199 RVA: 0x0001A910 File Offset: 0x00018B10
			public float limitMultiplier
			{
				get
				{
					return ParticleSystem.LimitVelocityOverLifetimeModule.GetMagnitudeMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.LimitVelocityOverLifetimeModule.SetMagnitudeMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000460 RID: 1120
			// (get) Token: 0x06001450 RID: 5200 RVA: 0x0001A920 File Offset: 0x00018B20
			// (set) Token: 0x06001451 RID: 5201 RVA: 0x0001A940 File Offset: 0x00018B40
			public float dampen
			{
				get
				{
					return ParticleSystem.LimitVelocityOverLifetimeModule.GetDampen(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.LimitVelocityOverLifetimeModule.SetDampen(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000461 RID: 1121
			// (get) Token: 0x06001452 RID: 5202 RVA: 0x0001A950 File Offset: 0x00018B50
			// (set) Token: 0x06001453 RID: 5203 RVA: 0x0001A970 File Offset: 0x00018B70
			public bool separateAxes
			{
				get
				{
					return ParticleSystem.LimitVelocityOverLifetimeModule.GetSeparateAxes(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.LimitVelocityOverLifetimeModule.SetSeparateAxes(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000462 RID: 1122
			// (get) Token: 0x06001454 RID: 5204 RVA: 0x0001A980 File Offset: 0x00018B80
			// (set) Token: 0x06001455 RID: 5205 RVA: 0x0001A9AC File Offset: 0x00018BAC
			public ParticleSystemSimulationSpace space
			{
				get
				{
					return (!ParticleSystem.LimitVelocityOverLifetimeModule.GetWorldSpace(this.m_ParticleSystem)) ? ParticleSystemSimulationSpace.Local : ParticleSystemSimulationSpace.World;
				}
				set
				{
					ParticleSystem.LimitVelocityOverLifetimeModule.SetWorldSpace(this.m_ParticleSystem, value == ParticleSystemSimulationSpace.World);
				}
			}

			// Token: 0x06001456 RID: 5206
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetEnabled(ParticleSystem system, bool value);

			// Token: 0x06001457 RID: 5207
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetEnabled(ParticleSystem system);

			// Token: 0x06001458 RID: 5208
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetX(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001459 RID: 5209
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetX(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x0600145A RID: 5210
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetXMultiplier(ParticleSystem system, float value);

			// Token: 0x0600145B RID: 5211
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetXMultiplier(ParticleSystem system);

			// Token: 0x0600145C RID: 5212
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetY(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x0600145D RID: 5213
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetY(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x0600145E RID: 5214
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetYMultiplier(ParticleSystem system, float value);

			// Token: 0x0600145F RID: 5215
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetYMultiplier(ParticleSystem system);

			// Token: 0x06001460 RID: 5216
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetZ(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001461 RID: 5217
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetZ(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001462 RID: 5218
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetZMultiplier(ParticleSystem system, float value);

			// Token: 0x06001463 RID: 5219
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetZMultiplier(ParticleSystem system);

			// Token: 0x06001464 RID: 5220
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetMagnitude(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001465 RID: 5221
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetMagnitude(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001466 RID: 5222
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetMagnitudeMultiplier(ParticleSystem system, float value);

			// Token: 0x06001467 RID: 5223
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetMagnitudeMultiplier(ParticleSystem system);

			// Token: 0x06001468 RID: 5224
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetDampen(ParticleSystem system, float value);

			// Token: 0x06001469 RID: 5225
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetDampen(ParticleSystem system);

			// Token: 0x0600146A RID: 5226
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetSeparateAxes(ParticleSystem system, bool value);

			// Token: 0x0600146B RID: 5227
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetSeparateAxes(ParticleSystem system);

			// Token: 0x0600146C RID: 5228
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetWorldSpace(ParticleSystem system, bool value);

			// Token: 0x0600146D RID: 5229
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetWorldSpace(ParticleSystem system);

			// Token: 0x0400034D RID: 845
			private ParticleSystem m_ParticleSystem;
		}

		// Token: 0x0200012E RID: 302
		public struct InheritVelocityModule
		{
			// Token: 0x0600146E RID: 5230 RVA: 0x0001A9C0 File Offset: 0x00018BC0
			internal InheritVelocityModule(ParticleSystem particleSystem)
			{
				this.m_ParticleSystem = particleSystem;
			}

			// Token: 0x17000463 RID: 1123
			// (get) Token: 0x06001470 RID: 5232 RVA: 0x0001A9DC File Offset: 0x00018BDC
			// (set) Token: 0x0600146F RID: 5231 RVA: 0x0001A9CC File Offset: 0x00018BCC
			public bool enabled
			{
				get
				{
					return ParticleSystem.InheritVelocityModule.GetEnabled(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.InheritVelocityModule.SetEnabled(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000464 RID: 1124
			// (get) Token: 0x06001471 RID: 5233 RVA: 0x0001A9FC File Offset: 0x00018BFC
			// (set) Token: 0x06001472 RID: 5234 RVA: 0x0001AA1C File Offset: 0x00018C1C
			public ParticleSystemInheritVelocityMode mode
			{
				get
				{
					return (ParticleSystemInheritVelocityMode)ParticleSystem.InheritVelocityModule.GetMode(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.InheritVelocityModule.SetMode(this.m_ParticleSystem, (int)value);
				}
			}

			// Token: 0x17000465 RID: 1125
			// (get) Token: 0x06001474 RID: 5236 RVA: 0x0001AA3C File Offset: 0x00018C3C
			// (set) Token: 0x06001473 RID: 5235 RVA: 0x0001AA2C File Offset: 0x00018C2C
			public ParticleSystem.MinMaxCurve curve
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.InheritVelocityModule.GetCurve(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.InheritVelocityModule.SetCurve(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000466 RID: 1126
			// (get) Token: 0x06001475 RID: 5237 RVA: 0x0001AA68 File Offset: 0x00018C68
			// (set) Token: 0x06001476 RID: 5238 RVA: 0x0001AA88 File Offset: 0x00018C88
			public float curveMultiplier
			{
				get
				{
					return ParticleSystem.InheritVelocityModule.GetCurveMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.InheritVelocityModule.SetCurveMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x06001477 RID: 5239
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetEnabled(ParticleSystem system, bool value);

			// Token: 0x06001478 RID: 5240
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetEnabled(ParticleSystem system);

			// Token: 0x06001479 RID: 5241
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetMode(ParticleSystem system, int value);

			// Token: 0x0600147A RID: 5242
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetMode(ParticleSystem system);

			// Token: 0x0600147B RID: 5243
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetCurve(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x0600147C RID: 5244
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetCurve(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x0600147D RID: 5245
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetCurveMultiplier(ParticleSystem system, float value);

			// Token: 0x0600147E RID: 5246
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetCurveMultiplier(ParticleSystem system);

			// Token: 0x0400034E RID: 846
			private ParticleSystem m_ParticleSystem;
		}

		// Token: 0x0200012F RID: 303
		public struct ForceOverLifetimeModule
		{
			// Token: 0x0600147F RID: 5247 RVA: 0x0001AA98 File Offset: 0x00018C98
			internal ForceOverLifetimeModule(ParticleSystem particleSystem)
			{
				this.m_ParticleSystem = particleSystem;
			}

			// Token: 0x17000467 RID: 1127
			// (get) Token: 0x06001481 RID: 5249 RVA: 0x0001AAB4 File Offset: 0x00018CB4
			// (set) Token: 0x06001480 RID: 5248 RVA: 0x0001AAA4 File Offset: 0x00018CA4
			public bool enabled
			{
				get
				{
					return ParticleSystem.ForceOverLifetimeModule.GetEnabled(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ForceOverLifetimeModule.SetEnabled(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000468 RID: 1128
			// (get) Token: 0x06001483 RID: 5251 RVA: 0x0001AAE4 File Offset: 0x00018CE4
			// (set) Token: 0x06001482 RID: 5250 RVA: 0x0001AAD4 File Offset: 0x00018CD4
			public ParticleSystem.MinMaxCurve x
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.ForceOverLifetimeModule.GetX(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.ForceOverLifetimeModule.SetX(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000469 RID: 1129
			// (get) Token: 0x06001485 RID: 5253 RVA: 0x0001AB20 File Offset: 0x00018D20
			// (set) Token: 0x06001484 RID: 5252 RVA: 0x0001AB10 File Offset: 0x00018D10
			public ParticleSystem.MinMaxCurve y
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.ForceOverLifetimeModule.GetY(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.ForceOverLifetimeModule.SetY(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x1700046A RID: 1130
			// (get) Token: 0x06001487 RID: 5255 RVA: 0x0001AB5C File Offset: 0x00018D5C
			// (set) Token: 0x06001486 RID: 5254 RVA: 0x0001AB4C File Offset: 0x00018D4C
			public ParticleSystem.MinMaxCurve z
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.ForceOverLifetimeModule.GetZ(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.ForceOverLifetimeModule.SetZ(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x1700046B RID: 1131
			// (get) Token: 0x06001488 RID: 5256 RVA: 0x0001AB88 File Offset: 0x00018D88
			// (set) Token: 0x06001489 RID: 5257 RVA: 0x0001ABA8 File Offset: 0x00018DA8
			public float xMultiplier
			{
				get
				{
					return ParticleSystem.ForceOverLifetimeModule.GetXMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ForceOverLifetimeModule.SetXMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700046C RID: 1132
			// (get) Token: 0x0600148A RID: 5258 RVA: 0x0001ABB8 File Offset: 0x00018DB8
			// (set) Token: 0x0600148B RID: 5259 RVA: 0x0001ABD8 File Offset: 0x00018DD8
			public float yMultiplier
			{
				get
				{
					return ParticleSystem.ForceOverLifetimeModule.GetYMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ForceOverLifetimeModule.SetYMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700046D RID: 1133
			// (get) Token: 0x0600148C RID: 5260 RVA: 0x0001ABE8 File Offset: 0x00018DE8
			// (set) Token: 0x0600148D RID: 5261 RVA: 0x0001AC08 File Offset: 0x00018E08
			public float zMultiplier
			{
				get
				{
					return ParticleSystem.ForceOverLifetimeModule.GetZMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ForceOverLifetimeModule.SetZMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700046E RID: 1134
			// (get) Token: 0x0600148E RID: 5262 RVA: 0x0001AC18 File Offset: 0x00018E18
			// (set) Token: 0x0600148F RID: 5263 RVA: 0x0001AC44 File Offset: 0x00018E44
			public ParticleSystemSimulationSpace space
			{
				get
				{
					return (!ParticleSystem.ForceOverLifetimeModule.GetWorldSpace(this.m_ParticleSystem)) ? ParticleSystemSimulationSpace.Local : ParticleSystemSimulationSpace.World;
				}
				set
				{
					ParticleSystem.ForceOverLifetimeModule.SetWorldSpace(this.m_ParticleSystem, value == ParticleSystemSimulationSpace.World);
				}
			}

			// Token: 0x1700046F RID: 1135
			// (get) Token: 0x06001491 RID: 5265 RVA: 0x0001AC68 File Offset: 0x00018E68
			// (set) Token: 0x06001490 RID: 5264 RVA: 0x0001AC58 File Offset: 0x00018E58
			public bool randomized
			{
				get
				{
					return ParticleSystem.ForceOverLifetimeModule.GetRandomized(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ForceOverLifetimeModule.SetRandomized(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x06001492 RID: 5266
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetEnabled(ParticleSystem system, bool value);

			// Token: 0x06001493 RID: 5267
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetEnabled(ParticleSystem system);

			// Token: 0x06001494 RID: 5268
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetX(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001495 RID: 5269
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetX(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001496 RID: 5270
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetY(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001497 RID: 5271
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetY(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001498 RID: 5272
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetZ(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001499 RID: 5273
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetZ(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x0600149A RID: 5274
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetXMultiplier(ParticleSystem system, float value);

			// Token: 0x0600149B RID: 5275
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetXMultiplier(ParticleSystem system);

			// Token: 0x0600149C RID: 5276
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetYMultiplier(ParticleSystem system, float value);

			// Token: 0x0600149D RID: 5277
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetYMultiplier(ParticleSystem system);

			// Token: 0x0600149E RID: 5278
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetZMultiplier(ParticleSystem system, float value);

			// Token: 0x0600149F RID: 5279
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetZMultiplier(ParticleSystem system);

			// Token: 0x060014A0 RID: 5280
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetWorldSpace(ParticleSystem system, bool value);

			// Token: 0x060014A1 RID: 5281
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetWorldSpace(ParticleSystem system);

			// Token: 0x060014A2 RID: 5282
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRandomized(ParticleSystem system, bool value);

			// Token: 0x060014A3 RID: 5283
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetRandomized(ParticleSystem system);

			// Token: 0x0400034F RID: 847
			private ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000130 RID: 304
		public struct ColorOverLifetimeModule
		{
			// Token: 0x060014A4 RID: 5284 RVA: 0x0001AC88 File Offset: 0x00018E88
			internal ColorOverLifetimeModule(ParticleSystem particleSystem)
			{
				this.m_ParticleSystem = particleSystem;
			}

			// Token: 0x17000470 RID: 1136
			// (get) Token: 0x060014A6 RID: 5286 RVA: 0x0001ACA4 File Offset: 0x00018EA4
			// (set) Token: 0x060014A5 RID: 5285 RVA: 0x0001AC94 File Offset: 0x00018E94
			public bool enabled
			{
				get
				{
					return ParticleSystem.ColorOverLifetimeModule.GetEnabled(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ColorOverLifetimeModule.SetEnabled(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000471 RID: 1137
			// (get) Token: 0x060014A8 RID: 5288 RVA: 0x0001ACD4 File Offset: 0x00018ED4
			// (set) Token: 0x060014A7 RID: 5287 RVA: 0x0001ACC4 File Offset: 0x00018EC4
			public ParticleSystem.MinMaxGradient color
			{
				get
				{
					ParticleSystem.MinMaxGradient result = default(ParticleSystem.MinMaxGradient);
					ParticleSystem.ColorOverLifetimeModule.GetColor(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.ColorOverLifetimeModule.SetColor(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x060014A9 RID: 5289
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetEnabled(ParticleSystem system, bool value);

			// Token: 0x060014AA RID: 5290
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetEnabled(ParticleSystem system);

			// Token: 0x060014AB RID: 5291
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetColor(ParticleSystem system, ref ParticleSystem.MinMaxGradient gradient);

			// Token: 0x060014AC RID: 5292
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetColor(ParticleSystem system, ref ParticleSystem.MinMaxGradient gradient);

			// Token: 0x04000350 RID: 848
			private ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000131 RID: 305
		public struct ColorBySpeedModule
		{
			// Token: 0x060014AD RID: 5293 RVA: 0x0001AD00 File Offset: 0x00018F00
			internal ColorBySpeedModule(ParticleSystem particleSystem)
			{
				this.m_ParticleSystem = particleSystem;
			}

			// Token: 0x17000472 RID: 1138
			// (get) Token: 0x060014AF RID: 5295 RVA: 0x0001AD1C File Offset: 0x00018F1C
			// (set) Token: 0x060014AE RID: 5294 RVA: 0x0001AD0C File Offset: 0x00018F0C
			public bool enabled
			{
				get
				{
					return ParticleSystem.ColorBySpeedModule.GetEnabled(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ColorBySpeedModule.SetEnabled(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000473 RID: 1139
			// (get) Token: 0x060014B1 RID: 5297 RVA: 0x0001AD4C File Offset: 0x00018F4C
			// (set) Token: 0x060014B0 RID: 5296 RVA: 0x0001AD3C File Offset: 0x00018F3C
			public ParticleSystem.MinMaxGradient color
			{
				get
				{
					ParticleSystem.MinMaxGradient result = default(ParticleSystem.MinMaxGradient);
					ParticleSystem.ColorBySpeedModule.GetColor(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.ColorBySpeedModule.SetColor(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000474 RID: 1140
			// (get) Token: 0x060014B3 RID: 5299 RVA: 0x0001AD88 File Offset: 0x00018F88
			// (set) Token: 0x060014B2 RID: 5298 RVA: 0x0001AD78 File Offset: 0x00018F78
			public Vector2 range
			{
				get
				{
					return ParticleSystem.ColorBySpeedModule.GetRange(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ColorBySpeedModule.SetRange(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x060014B4 RID: 5300
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetEnabled(ParticleSystem system, bool value);

			// Token: 0x060014B5 RID: 5301
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetEnabled(ParticleSystem system);

			// Token: 0x060014B6 RID: 5302
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetColor(ParticleSystem system, ref ParticleSystem.MinMaxGradient gradient);

			// Token: 0x060014B7 RID: 5303
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetColor(ParticleSystem system, ref ParticleSystem.MinMaxGradient gradient);

			// Token: 0x060014B8 RID: 5304 RVA: 0x0001ADA8 File Offset: 0x00018FA8
			private static void SetRange(ParticleSystem system, Vector2 value)
			{
				ParticleSystem.ColorBySpeedModule.INTERNAL_CALL_SetRange(system, ref value);
			}

			// Token: 0x060014B9 RID: 5305
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void INTERNAL_CALL_SetRange(ParticleSystem system, ref Vector2 value);

			// Token: 0x060014BA RID: 5306 RVA: 0x0001ADB4 File Offset: 0x00018FB4
			private static Vector2 GetRange(ParticleSystem system)
			{
				Vector2 result;
				ParticleSystem.ColorBySpeedModule.INTERNAL_CALL_GetRange(system, out result);
				return result;
			}

			// Token: 0x060014BB RID: 5307
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void INTERNAL_CALL_GetRange(ParticleSystem system, out Vector2 value);

			// Token: 0x04000351 RID: 849
			private ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000132 RID: 306
		public struct SizeOverLifetimeModule
		{
			// Token: 0x060014BC RID: 5308 RVA: 0x0001ADD4 File Offset: 0x00018FD4
			internal SizeOverLifetimeModule(ParticleSystem particleSystem)
			{
				this.m_ParticleSystem = particleSystem;
			}

			// Token: 0x17000475 RID: 1141
			// (get) Token: 0x060014BE RID: 5310 RVA: 0x0001ADF0 File Offset: 0x00018FF0
			// (set) Token: 0x060014BD RID: 5309 RVA: 0x0001ADE0 File Offset: 0x00018FE0
			public bool enabled
			{
				get
				{
					return ParticleSystem.SizeOverLifetimeModule.GetEnabled(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.SizeOverLifetimeModule.SetEnabled(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000476 RID: 1142
			// (get) Token: 0x060014C0 RID: 5312 RVA: 0x0001AE20 File Offset: 0x00019020
			// (set) Token: 0x060014BF RID: 5311 RVA: 0x0001AE10 File Offset: 0x00019010
			public ParticleSystem.MinMaxCurve size
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.SizeOverLifetimeModule.GetX(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.SizeOverLifetimeModule.SetX(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000477 RID: 1143
			// (get) Token: 0x060014C1 RID: 5313 RVA: 0x0001AE4C File Offset: 0x0001904C
			// (set) Token: 0x060014C2 RID: 5314 RVA: 0x0001AE6C File Offset: 0x0001906C
			public float sizeMultiplier
			{
				get
				{
					return ParticleSystem.SizeOverLifetimeModule.GetXMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.SizeOverLifetimeModule.SetXMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000478 RID: 1144
			// (get) Token: 0x060014C4 RID: 5316 RVA: 0x0001AE8C File Offset: 0x0001908C
			// (set) Token: 0x060014C3 RID: 5315 RVA: 0x0001AE7C File Offset: 0x0001907C
			public ParticleSystem.MinMaxCurve x
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.SizeOverLifetimeModule.GetX(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.SizeOverLifetimeModule.SetX(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000479 RID: 1145
			// (get) Token: 0x060014C5 RID: 5317 RVA: 0x0001AEB8 File Offset: 0x000190B8
			// (set) Token: 0x060014C6 RID: 5318 RVA: 0x0001AED8 File Offset: 0x000190D8
			public float xMultiplier
			{
				get
				{
					return ParticleSystem.SizeOverLifetimeModule.GetXMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.SizeOverLifetimeModule.SetXMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700047A RID: 1146
			// (get) Token: 0x060014C8 RID: 5320 RVA: 0x0001AEF8 File Offset: 0x000190F8
			// (set) Token: 0x060014C7 RID: 5319 RVA: 0x0001AEE8 File Offset: 0x000190E8
			public ParticleSystem.MinMaxCurve y
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.SizeOverLifetimeModule.GetY(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.SizeOverLifetimeModule.SetY(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x1700047B RID: 1147
			// (get) Token: 0x060014C9 RID: 5321 RVA: 0x0001AF24 File Offset: 0x00019124
			// (set) Token: 0x060014CA RID: 5322 RVA: 0x0001AF44 File Offset: 0x00019144
			public float yMultiplier
			{
				get
				{
					return ParticleSystem.SizeOverLifetimeModule.GetYMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.SizeOverLifetimeModule.SetYMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700047C RID: 1148
			// (get) Token: 0x060014CC RID: 5324 RVA: 0x0001AF64 File Offset: 0x00019164
			// (set) Token: 0x060014CB RID: 5323 RVA: 0x0001AF54 File Offset: 0x00019154
			public ParticleSystem.MinMaxCurve z
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.SizeOverLifetimeModule.GetZ(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.SizeOverLifetimeModule.SetZ(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x1700047D RID: 1149
			// (get) Token: 0x060014CD RID: 5325 RVA: 0x0001AF90 File Offset: 0x00019190
			// (set) Token: 0x060014CE RID: 5326 RVA: 0x0001AFB0 File Offset: 0x000191B0
			public float zMultiplier
			{
				get
				{
					return ParticleSystem.SizeOverLifetimeModule.GetZMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.SizeOverLifetimeModule.SetZMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700047E RID: 1150
			// (get) Token: 0x060014CF RID: 5327 RVA: 0x0001AFC0 File Offset: 0x000191C0
			// (set) Token: 0x060014D0 RID: 5328 RVA: 0x0001AFE0 File Offset: 0x000191E0
			public bool separateAxes
			{
				get
				{
					return ParticleSystem.SizeOverLifetimeModule.GetSeparateAxes(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.SizeOverLifetimeModule.SetSeparateAxes(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x060014D1 RID: 5329
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetEnabled(ParticleSystem system, bool value);

			// Token: 0x060014D2 RID: 5330
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetEnabled(ParticleSystem system);

			// Token: 0x060014D3 RID: 5331
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetX(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060014D4 RID: 5332
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetX(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060014D5 RID: 5333
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetY(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060014D6 RID: 5334
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetY(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060014D7 RID: 5335
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetZ(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060014D8 RID: 5336
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetZ(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060014D9 RID: 5337
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetXMultiplier(ParticleSystem system, float value);

			// Token: 0x060014DA RID: 5338
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetXMultiplier(ParticleSystem system);

			// Token: 0x060014DB RID: 5339
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetYMultiplier(ParticleSystem system, float value);

			// Token: 0x060014DC RID: 5340
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetYMultiplier(ParticleSystem system);

			// Token: 0x060014DD RID: 5341
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetZMultiplier(ParticleSystem system, float value);

			// Token: 0x060014DE RID: 5342
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetZMultiplier(ParticleSystem system);

			// Token: 0x060014DF RID: 5343
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetSeparateAxes(ParticleSystem system, bool value);

			// Token: 0x060014E0 RID: 5344
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetSeparateAxes(ParticleSystem system);

			// Token: 0x04000352 RID: 850
			private ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000133 RID: 307
		public struct SizeBySpeedModule
		{
			// Token: 0x060014E1 RID: 5345 RVA: 0x0001AFF0 File Offset: 0x000191F0
			internal SizeBySpeedModule(ParticleSystem particleSystem)
			{
				this.m_ParticleSystem = particleSystem;
			}

			// Token: 0x1700047F RID: 1151
			// (get) Token: 0x060014E3 RID: 5347 RVA: 0x0001B00C File Offset: 0x0001920C
			// (set) Token: 0x060014E2 RID: 5346 RVA: 0x0001AFFC File Offset: 0x000191FC
			public bool enabled
			{
				get
				{
					return ParticleSystem.SizeBySpeedModule.GetEnabled(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.SizeBySpeedModule.SetEnabled(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000480 RID: 1152
			// (get) Token: 0x060014E5 RID: 5349 RVA: 0x0001B03C File Offset: 0x0001923C
			// (set) Token: 0x060014E4 RID: 5348 RVA: 0x0001B02C File Offset: 0x0001922C
			public ParticleSystem.MinMaxCurve size
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.SizeBySpeedModule.GetX(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.SizeBySpeedModule.SetX(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000481 RID: 1153
			// (get) Token: 0x060014E6 RID: 5350 RVA: 0x0001B068 File Offset: 0x00019268
			// (set) Token: 0x060014E7 RID: 5351 RVA: 0x0001B088 File Offset: 0x00019288
			public float sizeMultiplier
			{
				get
				{
					return ParticleSystem.SizeBySpeedModule.GetXMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.SizeBySpeedModule.SetXMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000482 RID: 1154
			// (get) Token: 0x060014E9 RID: 5353 RVA: 0x0001B0A8 File Offset: 0x000192A8
			// (set) Token: 0x060014E8 RID: 5352 RVA: 0x0001B098 File Offset: 0x00019298
			public ParticleSystem.MinMaxCurve x
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.SizeBySpeedModule.GetX(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.SizeBySpeedModule.SetX(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000483 RID: 1155
			// (get) Token: 0x060014EA RID: 5354 RVA: 0x0001B0D4 File Offset: 0x000192D4
			// (set) Token: 0x060014EB RID: 5355 RVA: 0x0001B0F4 File Offset: 0x000192F4
			public float xMultiplier
			{
				get
				{
					return ParticleSystem.SizeBySpeedModule.GetXMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.SizeBySpeedModule.SetXMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000484 RID: 1156
			// (get) Token: 0x060014ED RID: 5357 RVA: 0x0001B114 File Offset: 0x00019314
			// (set) Token: 0x060014EC RID: 5356 RVA: 0x0001B104 File Offset: 0x00019304
			public ParticleSystem.MinMaxCurve y
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.SizeBySpeedModule.GetY(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.SizeBySpeedModule.SetY(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000485 RID: 1157
			// (get) Token: 0x060014EE RID: 5358 RVA: 0x0001B140 File Offset: 0x00019340
			// (set) Token: 0x060014EF RID: 5359 RVA: 0x0001B160 File Offset: 0x00019360
			public float yMultiplier
			{
				get
				{
					return ParticleSystem.SizeBySpeedModule.GetYMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.SizeBySpeedModule.SetYMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000486 RID: 1158
			// (get) Token: 0x060014F1 RID: 5361 RVA: 0x0001B180 File Offset: 0x00019380
			// (set) Token: 0x060014F0 RID: 5360 RVA: 0x0001B170 File Offset: 0x00019370
			public ParticleSystem.MinMaxCurve z
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.SizeBySpeedModule.GetZ(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.SizeBySpeedModule.SetZ(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000487 RID: 1159
			// (get) Token: 0x060014F2 RID: 5362 RVA: 0x0001B1AC File Offset: 0x000193AC
			// (set) Token: 0x060014F3 RID: 5363 RVA: 0x0001B1CC File Offset: 0x000193CC
			public float zMultiplier
			{
				get
				{
					return ParticleSystem.SizeBySpeedModule.GetZMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.SizeBySpeedModule.SetZMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000488 RID: 1160
			// (get) Token: 0x060014F4 RID: 5364 RVA: 0x0001B1DC File Offset: 0x000193DC
			// (set) Token: 0x060014F5 RID: 5365 RVA: 0x0001B1FC File Offset: 0x000193FC
			public bool separateAxes
			{
				get
				{
					return ParticleSystem.SizeBySpeedModule.GetSeparateAxes(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.SizeBySpeedModule.SetSeparateAxes(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000489 RID: 1161
			// (get) Token: 0x060014F7 RID: 5367 RVA: 0x0001B21C File Offset: 0x0001941C
			// (set) Token: 0x060014F6 RID: 5366 RVA: 0x0001B20C File Offset: 0x0001940C
			public Vector2 range
			{
				get
				{
					return ParticleSystem.SizeBySpeedModule.GetRange(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.SizeBySpeedModule.SetRange(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x060014F8 RID: 5368
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetEnabled(ParticleSystem system, bool value);

			// Token: 0x060014F9 RID: 5369
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetEnabled(ParticleSystem system);

			// Token: 0x060014FA RID: 5370
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetX(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060014FB RID: 5371
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetX(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060014FC RID: 5372
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetY(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060014FD RID: 5373
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetY(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060014FE RID: 5374
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetZ(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060014FF RID: 5375
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetZ(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001500 RID: 5376
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetXMultiplier(ParticleSystem system, float value);

			// Token: 0x06001501 RID: 5377
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetXMultiplier(ParticleSystem system);

			// Token: 0x06001502 RID: 5378
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetYMultiplier(ParticleSystem system, float value);

			// Token: 0x06001503 RID: 5379
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetYMultiplier(ParticleSystem system);

			// Token: 0x06001504 RID: 5380
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetZMultiplier(ParticleSystem system, float value);

			// Token: 0x06001505 RID: 5381
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetZMultiplier(ParticleSystem system);

			// Token: 0x06001506 RID: 5382
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetSeparateAxes(ParticleSystem system, bool value);

			// Token: 0x06001507 RID: 5383
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetSeparateAxes(ParticleSystem system);

			// Token: 0x06001508 RID: 5384 RVA: 0x0001B23C File Offset: 0x0001943C
			private static void SetRange(ParticleSystem system, Vector2 value)
			{
				ParticleSystem.SizeBySpeedModule.INTERNAL_CALL_SetRange(system, ref value);
			}

			// Token: 0x06001509 RID: 5385
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void INTERNAL_CALL_SetRange(ParticleSystem system, ref Vector2 value);

			// Token: 0x0600150A RID: 5386 RVA: 0x0001B248 File Offset: 0x00019448
			private static Vector2 GetRange(ParticleSystem system)
			{
				Vector2 result;
				ParticleSystem.SizeBySpeedModule.INTERNAL_CALL_GetRange(system, out result);
				return result;
			}

			// Token: 0x0600150B RID: 5387
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void INTERNAL_CALL_GetRange(ParticleSystem system, out Vector2 value);

			// Token: 0x04000353 RID: 851
			private ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000134 RID: 308
		public struct RotationOverLifetimeModule
		{
			// Token: 0x0600150C RID: 5388 RVA: 0x0001B268 File Offset: 0x00019468
			internal RotationOverLifetimeModule(ParticleSystem particleSystem)
			{
				this.m_ParticleSystem = particleSystem;
			}

			// Token: 0x1700048A RID: 1162
			// (get) Token: 0x0600150E RID: 5390 RVA: 0x0001B284 File Offset: 0x00019484
			// (set) Token: 0x0600150D RID: 5389 RVA: 0x0001B274 File Offset: 0x00019474
			public bool enabled
			{
				get
				{
					return ParticleSystem.RotationOverLifetimeModule.GetEnabled(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.RotationOverLifetimeModule.SetEnabled(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700048B RID: 1163
			// (get) Token: 0x06001510 RID: 5392 RVA: 0x0001B2B4 File Offset: 0x000194B4
			// (set) Token: 0x0600150F RID: 5391 RVA: 0x0001B2A4 File Offset: 0x000194A4
			public ParticleSystem.MinMaxCurve x
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.RotationOverLifetimeModule.GetX(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.RotationOverLifetimeModule.SetX(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x1700048C RID: 1164
			// (get) Token: 0x06001511 RID: 5393 RVA: 0x0001B2E0 File Offset: 0x000194E0
			// (set) Token: 0x06001512 RID: 5394 RVA: 0x0001B300 File Offset: 0x00019500
			public float xMultiplier
			{
				get
				{
					return ParticleSystem.RotationOverLifetimeModule.GetXMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.RotationOverLifetimeModule.SetXMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700048D RID: 1165
			// (get) Token: 0x06001514 RID: 5396 RVA: 0x0001B320 File Offset: 0x00019520
			// (set) Token: 0x06001513 RID: 5395 RVA: 0x0001B310 File Offset: 0x00019510
			public ParticleSystem.MinMaxCurve y
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.RotationOverLifetimeModule.GetY(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.RotationOverLifetimeModule.SetY(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x1700048E RID: 1166
			// (get) Token: 0x06001515 RID: 5397 RVA: 0x0001B34C File Offset: 0x0001954C
			// (set) Token: 0x06001516 RID: 5398 RVA: 0x0001B36C File Offset: 0x0001956C
			public float yMultiplier
			{
				get
				{
					return ParticleSystem.RotationOverLifetimeModule.GetYMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.RotationOverLifetimeModule.SetYMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700048F RID: 1167
			// (get) Token: 0x06001518 RID: 5400 RVA: 0x0001B38C File Offset: 0x0001958C
			// (set) Token: 0x06001517 RID: 5399 RVA: 0x0001B37C File Offset: 0x0001957C
			public ParticleSystem.MinMaxCurve z
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.RotationOverLifetimeModule.GetZ(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.RotationOverLifetimeModule.SetZ(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000490 RID: 1168
			// (get) Token: 0x06001519 RID: 5401 RVA: 0x0001B3B8 File Offset: 0x000195B8
			// (set) Token: 0x0600151A RID: 5402 RVA: 0x0001B3D8 File Offset: 0x000195D8
			public float zMultiplier
			{
				get
				{
					return ParticleSystem.RotationOverLifetimeModule.GetZMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.RotationOverLifetimeModule.SetZMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000491 RID: 1169
			// (get) Token: 0x0600151B RID: 5403 RVA: 0x0001B3E8 File Offset: 0x000195E8
			// (set) Token: 0x0600151C RID: 5404 RVA: 0x0001B408 File Offset: 0x00019608
			public bool separateAxes
			{
				get
				{
					return ParticleSystem.RotationOverLifetimeModule.GetSeparateAxes(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.RotationOverLifetimeModule.SetSeparateAxes(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x0600151D RID: 5405
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetEnabled(ParticleSystem system, bool value);

			// Token: 0x0600151E RID: 5406
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetEnabled(ParticleSystem system);

			// Token: 0x0600151F RID: 5407
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetX(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001520 RID: 5408
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetX(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001521 RID: 5409
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetY(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001522 RID: 5410
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetY(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001523 RID: 5411
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetZ(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001524 RID: 5412
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetZ(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001525 RID: 5413
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetXMultiplier(ParticleSystem system, float value);

			// Token: 0x06001526 RID: 5414
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetXMultiplier(ParticleSystem system);

			// Token: 0x06001527 RID: 5415
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetYMultiplier(ParticleSystem system, float value);

			// Token: 0x06001528 RID: 5416
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetYMultiplier(ParticleSystem system);

			// Token: 0x06001529 RID: 5417
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetZMultiplier(ParticleSystem system, float value);

			// Token: 0x0600152A RID: 5418
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetZMultiplier(ParticleSystem system);

			// Token: 0x0600152B RID: 5419
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetSeparateAxes(ParticleSystem system, bool value);

			// Token: 0x0600152C RID: 5420
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetSeparateAxes(ParticleSystem system);

			// Token: 0x04000354 RID: 852
			private ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000135 RID: 309
		public struct RotationBySpeedModule
		{
			// Token: 0x0600152D RID: 5421 RVA: 0x0001B418 File Offset: 0x00019618
			internal RotationBySpeedModule(ParticleSystem particleSystem)
			{
				this.m_ParticleSystem = particleSystem;
			}

			// Token: 0x17000492 RID: 1170
			// (get) Token: 0x0600152F RID: 5423 RVA: 0x0001B434 File Offset: 0x00019634
			// (set) Token: 0x0600152E RID: 5422 RVA: 0x0001B424 File Offset: 0x00019624
			public bool enabled
			{
				get
				{
					return ParticleSystem.RotationBySpeedModule.GetEnabled(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.RotationBySpeedModule.SetEnabled(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000493 RID: 1171
			// (get) Token: 0x06001531 RID: 5425 RVA: 0x0001B464 File Offset: 0x00019664
			// (set) Token: 0x06001530 RID: 5424 RVA: 0x0001B454 File Offset: 0x00019654
			public ParticleSystem.MinMaxCurve x
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.RotationBySpeedModule.GetX(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.RotationBySpeedModule.SetX(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000494 RID: 1172
			// (get) Token: 0x06001532 RID: 5426 RVA: 0x0001B490 File Offset: 0x00019690
			// (set) Token: 0x06001533 RID: 5427 RVA: 0x0001B4B0 File Offset: 0x000196B0
			public float xMultiplier
			{
				get
				{
					return ParticleSystem.RotationBySpeedModule.GetXMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.RotationBySpeedModule.SetXMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000495 RID: 1173
			// (get) Token: 0x06001535 RID: 5429 RVA: 0x0001B4D0 File Offset: 0x000196D0
			// (set) Token: 0x06001534 RID: 5428 RVA: 0x0001B4C0 File Offset: 0x000196C0
			public ParticleSystem.MinMaxCurve y
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.RotationBySpeedModule.GetY(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.RotationBySpeedModule.SetY(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000496 RID: 1174
			// (get) Token: 0x06001536 RID: 5430 RVA: 0x0001B4FC File Offset: 0x000196FC
			// (set) Token: 0x06001537 RID: 5431 RVA: 0x0001B51C File Offset: 0x0001971C
			public float yMultiplier
			{
				get
				{
					return ParticleSystem.RotationBySpeedModule.GetYMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.RotationBySpeedModule.SetYMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000497 RID: 1175
			// (get) Token: 0x06001539 RID: 5433 RVA: 0x0001B53C File Offset: 0x0001973C
			// (set) Token: 0x06001538 RID: 5432 RVA: 0x0001B52C File Offset: 0x0001972C
			public ParticleSystem.MinMaxCurve z
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.RotationBySpeedModule.GetZ(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.RotationBySpeedModule.SetZ(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000498 RID: 1176
			// (get) Token: 0x0600153A RID: 5434 RVA: 0x0001B568 File Offset: 0x00019768
			// (set) Token: 0x0600153B RID: 5435 RVA: 0x0001B588 File Offset: 0x00019788
			public float zMultiplier
			{
				get
				{
					return ParticleSystem.RotationBySpeedModule.GetZMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.RotationBySpeedModule.SetZMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000499 RID: 1177
			// (get) Token: 0x0600153C RID: 5436 RVA: 0x0001B598 File Offset: 0x00019798
			// (set) Token: 0x0600153D RID: 5437 RVA: 0x0001B5B8 File Offset: 0x000197B8
			public bool separateAxes
			{
				get
				{
					return ParticleSystem.RotationBySpeedModule.GetSeparateAxes(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.RotationBySpeedModule.SetSeparateAxes(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700049A RID: 1178
			// (get) Token: 0x0600153F RID: 5439 RVA: 0x0001B5D8 File Offset: 0x000197D8
			// (set) Token: 0x0600153E RID: 5438 RVA: 0x0001B5C8 File Offset: 0x000197C8
			public Vector2 range
			{
				get
				{
					return ParticleSystem.RotationBySpeedModule.GetRange(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.RotationBySpeedModule.SetRange(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x06001540 RID: 5440
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetEnabled(ParticleSystem system, bool value);

			// Token: 0x06001541 RID: 5441
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetEnabled(ParticleSystem system);

			// Token: 0x06001542 RID: 5442
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetX(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001543 RID: 5443
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetX(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001544 RID: 5444
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetY(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001545 RID: 5445
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetY(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001546 RID: 5446
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetZ(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001547 RID: 5447
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetZ(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001548 RID: 5448
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetXMultiplier(ParticleSystem system, float value);

			// Token: 0x06001549 RID: 5449
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetXMultiplier(ParticleSystem system);

			// Token: 0x0600154A RID: 5450
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetYMultiplier(ParticleSystem system, float value);

			// Token: 0x0600154B RID: 5451
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetYMultiplier(ParticleSystem system);

			// Token: 0x0600154C RID: 5452
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetZMultiplier(ParticleSystem system, float value);

			// Token: 0x0600154D RID: 5453
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetZMultiplier(ParticleSystem system);

			// Token: 0x0600154E RID: 5454
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetSeparateAxes(ParticleSystem system, bool value);

			// Token: 0x0600154F RID: 5455
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetSeparateAxes(ParticleSystem system);

			// Token: 0x06001550 RID: 5456 RVA: 0x0001B5F8 File Offset: 0x000197F8
			private static void SetRange(ParticleSystem system, Vector2 value)
			{
				ParticleSystem.RotationBySpeedModule.INTERNAL_CALL_SetRange(system, ref value);
			}

			// Token: 0x06001551 RID: 5457
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void INTERNAL_CALL_SetRange(ParticleSystem system, ref Vector2 value);

			// Token: 0x06001552 RID: 5458 RVA: 0x0001B604 File Offset: 0x00019804
			private static Vector2 GetRange(ParticleSystem system)
			{
				Vector2 result;
				ParticleSystem.RotationBySpeedModule.INTERNAL_CALL_GetRange(system, out result);
				return result;
			}

			// Token: 0x06001553 RID: 5459
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void INTERNAL_CALL_GetRange(ParticleSystem system, out Vector2 value);

			// Token: 0x04000355 RID: 853
			private ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000136 RID: 310
		public struct ExternalForcesModule
		{
			// Token: 0x06001554 RID: 5460 RVA: 0x0001B624 File Offset: 0x00019824
			internal ExternalForcesModule(ParticleSystem particleSystem)
			{
				this.m_ParticleSystem = particleSystem;
			}

			// Token: 0x1700049B RID: 1179
			// (get) Token: 0x06001556 RID: 5462 RVA: 0x0001B640 File Offset: 0x00019840
			// (set) Token: 0x06001555 RID: 5461 RVA: 0x0001B630 File Offset: 0x00019830
			public bool enabled
			{
				get
				{
					return ParticleSystem.ExternalForcesModule.GetEnabled(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ExternalForcesModule.SetEnabled(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700049C RID: 1180
			// (get) Token: 0x06001557 RID: 5463 RVA: 0x0001B660 File Offset: 0x00019860
			// (set) Token: 0x06001558 RID: 5464 RVA: 0x0001B680 File Offset: 0x00019880
			public float multiplier
			{
				get
				{
					return ParticleSystem.ExternalForcesModule.GetMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.ExternalForcesModule.SetMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x06001559 RID: 5465
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetEnabled(ParticleSystem system, bool value);

			// Token: 0x0600155A RID: 5466
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetEnabled(ParticleSystem system);

			// Token: 0x0600155B RID: 5467
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetMultiplier(ParticleSystem system, float value);

			// Token: 0x0600155C RID: 5468
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetMultiplier(ParticleSystem system);

			// Token: 0x04000356 RID: 854
			private ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000137 RID: 311
		public struct NoiseModule
		{
			// Token: 0x0600155D RID: 5469 RVA: 0x0001B690 File Offset: 0x00019890
			internal NoiseModule(ParticleSystem particleSystem)
			{
				this.m_ParticleSystem = particleSystem;
			}

			// Token: 0x1700049D RID: 1181
			// (get) Token: 0x0600155F RID: 5471 RVA: 0x0001B6AC File Offset: 0x000198AC
			// (set) Token: 0x0600155E RID: 5470 RVA: 0x0001B69C File Offset: 0x0001989C
			public bool enabled
			{
				get
				{
					return ParticleSystem.NoiseModule.GetEnabled(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.NoiseModule.SetEnabled(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700049E RID: 1182
			// (get) Token: 0x06001560 RID: 5472 RVA: 0x0001B6CC File Offset: 0x000198CC
			// (set) Token: 0x06001561 RID: 5473 RVA: 0x0001B6EC File Offset: 0x000198EC
			public bool separateAxes
			{
				get
				{
					return ParticleSystem.NoiseModule.GetSeparateAxes(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.NoiseModule.SetSeparateAxes(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x1700049F RID: 1183
			// (get) Token: 0x06001563 RID: 5475 RVA: 0x0001B70C File Offset: 0x0001990C
			// (set) Token: 0x06001562 RID: 5474 RVA: 0x0001B6FC File Offset: 0x000198FC
			public ParticleSystem.MinMaxCurve strength
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.NoiseModule.GetStrengthX(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.NoiseModule.SetStrengthX(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x170004A0 RID: 1184
			// (get) Token: 0x06001564 RID: 5476 RVA: 0x0001B738 File Offset: 0x00019938
			// (set) Token: 0x06001565 RID: 5477 RVA: 0x0001B758 File Offset: 0x00019958
			public float strengthMultiplier
			{
				get
				{
					return ParticleSystem.NoiseModule.GetStrengthXMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.NoiseModule.SetStrengthXMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004A1 RID: 1185
			// (get) Token: 0x06001567 RID: 5479 RVA: 0x0001B778 File Offset: 0x00019978
			// (set) Token: 0x06001566 RID: 5478 RVA: 0x0001B768 File Offset: 0x00019968
			public ParticleSystem.MinMaxCurve strengthX
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.NoiseModule.GetStrengthX(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.NoiseModule.SetStrengthX(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x170004A2 RID: 1186
			// (get) Token: 0x06001568 RID: 5480 RVA: 0x0001B7A4 File Offset: 0x000199A4
			// (set) Token: 0x06001569 RID: 5481 RVA: 0x0001B7C4 File Offset: 0x000199C4
			public float strengthXMultiplier
			{
				get
				{
					return ParticleSystem.NoiseModule.GetStrengthXMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.NoiseModule.SetStrengthXMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004A3 RID: 1187
			// (get) Token: 0x0600156B RID: 5483 RVA: 0x0001B7E4 File Offset: 0x000199E4
			// (set) Token: 0x0600156A RID: 5482 RVA: 0x0001B7D4 File Offset: 0x000199D4
			public ParticleSystem.MinMaxCurve strengthY
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.NoiseModule.GetStrengthY(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.NoiseModule.SetStrengthY(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x170004A4 RID: 1188
			// (get) Token: 0x0600156C RID: 5484 RVA: 0x0001B810 File Offset: 0x00019A10
			// (set) Token: 0x0600156D RID: 5485 RVA: 0x0001B830 File Offset: 0x00019A30
			public float strengthYMultiplier
			{
				get
				{
					return ParticleSystem.NoiseModule.GetStrengthYMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.NoiseModule.SetStrengthYMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004A5 RID: 1189
			// (get) Token: 0x0600156F RID: 5487 RVA: 0x0001B850 File Offset: 0x00019A50
			// (set) Token: 0x0600156E RID: 5486 RVA: 0x0001B840 File Offset: 0x00019A40
			public ParticleSystem.MinMaxCurve strengthZ
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.NoiseModule.GetStrengthZ(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.NoiseModule.SetStrengthZ(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x170004A6 RID: 1190
			// (get) Token: 0x06001570 RID: 5488 RVA: 0x0001B87C File Offset: 0x00019A7C
			// (set) Token: 0x06001571 RID: 5489 RVA: 0x0001B89C File Offset: 0x00019A9C
			public float strengthZMultiplier
			{
				get
				{
					return ParticleSystem.NoiseModule.GetStrengthZMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.NoiseModule.SetStrengthZMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004A7 RID: 1191
			// (get) Token: 0x06001572 RID: 5490 RVA: 0x0001B8AC File Offset: 0x00019AAC
			// (set) Token: 0x06001573 RID: 5491 RVA: 0x0001B8CC File Offset: 0x00019ACC
			public float frequency
			{
				get
				{
					return ParticleSystem.NoiseModule.GetFrequency(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.NoiseModule.SetFrequency(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004A8 RID: 1192
			// (get) Token: 0x06001574 RID: 5492 RVA: 0x0001B8DC File Offset: 0x00019ADC
			// (set) Token: 0x06001575 RID: 5493 RVA: 0x0001B8FC File Offset: 0x00019AFC
			public bool damping
			{
				get
				{
					return ParticleSystem.NoiseModule.GetDamping(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.NoiseModule.SetDamping(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004A9 RID: 1193
			// (get) Token: 0x06001576 RID: 5494 RVA: 0x0001B90C File Offset: 0x00019B0C
			// (set) Token: 0x06001577 RID: 5495 RVA: 0x0001B92C File Offset: 0x00019B2C
			public int octaveCount
			{
				get
				{
					return ParticleSystem.NoiseModule.GetOctaveCount(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.NoiseModule.SetOctaveCount(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004AA RID: 1194
			// (get) Token: 0x06001578 RID: 5496 RVA: 0x0001B93C File Offset: 0x00019B3C
			// (set) Token: 0x06001579 RID: 5497 RVA: 0x0001B95C File Offset: 0x00019B5C
			public float octaveMultiplier
			{
				get
				{
					return ParticleSystem.NoiseModule.GetOctaveMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.NoiseModule.SetOctaveMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004AB RID: 1195
			// (get) Token: 0x0600157A RID: 5498 RVA: 0x0001B96C File Offset: 0x00019B6C
			// (set) Token: 0x0600157B RID: 5499 RVA: 0x0001B98C File Offset: 0x00019B8C
			public float octaveScale
			{
				get
				{
					return ParticleSystem.NoiseModule.GetOctaveScale(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.NoiseModule.SetOctaveScale(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004AC RID: 1196
			// (get) Token: 0x0600157C RID: 5500 RVA: 0x0001B99C File Offset: 0x00019B9C
			// (set) Token: 0x0600157D RID: 5501 RVA: 0x0001B9BC File Offset: 0x00019BBC
			public ParticleSystemNoiseQuality quality
			{
				get
				{
					return (ParticleSystemNoiseQuality)ParticleSystem.NoiseModule.GetQuality(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.NoiseModule.SetQuality(this.m_ParticleSystem, (int)value);
				}
			}

			// Token: 0x170004AD RID: 1197
			// (get) Token: 0x0600157F RID: 5503 RVA: 0x0001B9DC File Offset: 0x00019BDC
			// (set) Token: 0x0600157E RID: 5502 RVA: 0x0001B9CC File Offset: 0x00019BCC
			public ParticleSystem.MinMaxCurve scrollSpeed
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.NoiseModule.GetScrollSpeed(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.NoiseModule.SetScrollSpeed(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x170004AE RID: 1198
			// (get) Token: 0x06001580 RID: 5504 RVA: 0x0001BA08 File Offset: 0x00019C08
			// (set) Token: 0x06001581 RID: 5505 RVA: 0x0001BA28 File Offset: 0x00019C28
			public float scrollSpeedMultiplier
			{
				get
				{
					return ParticleSystem.NoiseModule.GetScrollSpeedMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.NoiseModule.SetScrollSpeedMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004AF RID: 1199
			// (get) Token: 0x06001582 RID: 5506 RVA: 0x0001BA38 File Offset: 0x00019C38
			// (set) Token: 0x06001583 RID: 5507 RVA: 0x0001BA58 File Offset: 0x00019C58
			public bool remapEnabled
			{
				get
				{
					return ParticleSystem.NoiseModule.GetRemapEnabled(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.NoiseModule.SetRemapEnabled(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004B0 RID: 1200
			// (get) Token: 0x06001585 RID: 5509 RVA: 0x0001BA78 File Offset: 0x00019C78
			// (set) Token: 0x06001584 RID: 5508 RVA: 0x0001BA68 File Offset: 0x00019C68
			public ParticleSystem.MinMaxCurve remap
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.NoiseModule.GetRemapX(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.NoiseModule.SetRemapX(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x170004B1 RID: 1201
			// (get) Token: 0x06001586 RID: 5510 RVA: 0x0001BAA4 File Offset: 0x00019CA4
			// (set) Token: 0x06001587 RID: 5511 RVA: 0x0001BAC4 File Offset: 0x00019CC4
			public float remapMultiplier
			{
				get
				{
					return ParticleSystem.NoiseModule.GetRemapXMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.NoiseModule.SetRemapXMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004B2 RID: 1202
			// (get) Token: 0x06001589 RID: 5513 RVA: 0x0001BAE4 File Offset: 0x00019CE4
			// (set) Token: 0x06001588 RID: 5512 RVA: 0x0001BAD4 File Offset: 0x00019CD4
			public ParticleSystem.MinMaxCurve remapX
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.NoiseModule.GetRemapX(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.NoiseModule.SetRemapX(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x170004B3 RID: 1203
			// (get) Token: 0x0600158A RID: 5514 RVA: 0x0001BB10 File Offset: 0x00019D10
			// (set) Token: 0x0600158B RID: 5515 RVA: 0x0001BB30 File Offset: 0x00019D30
			public float remapXMultiplier
			{
				get
				{
					return ParticleSystem.NoiseModule.GetRemapXMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.NoiseModule.SetRemapXMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004B4 RID: 1204
			// (get) Token: 0x0600158D RID: 5517 RVA: 0x0001BB50 File Offset: 0x00019D50
			// (set) Token: 0x0600158C RID: 5516 RVA: 0x0001BB40 File Offset: 0x00019D40
			public ParticleSystem.MinMaxCurve remapY
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.NoiseModule.GetRemapY(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.NoiseModule.SetRemapY(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x170004B5 RID: 1205
			// (get) Token: 0x0600158E RID: 5518 RVA: 0x0001BB7C File Offset: 0x00019D7C
			// (set) Token: 0x0600158F RID: 5519 RVA: 0x0001BB9C File Offset: 0x00019D9C
			public float remapYMultiplier
			{
				get
				{
					return ParticleSystem.NoiseModule.GetRemapYMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.NoiseModule.SetRemapYMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004B6 RID: 1206
			// (get) Token: 0x06001591 RID: 5521 RVA: 0x0001BBBC File Offset: 0x00019DBC
			// (set) Token: 0x06001590 RID: 5520 RVA: 0x0001BBAC File Offset: 0x00019DAC
			public ParticleSystem.MinMaxCurve remapZ
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.NoiseModule.GetRemapZ(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.NoiseModule.SetRemapZ(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x170004B7 RID: 1207
			// (get) Token: 0x06001592 RID: 5522 RVA: 0x0001BBE8 File Offset: 0x00019DE8
			// (set) Token: 0x06001593 RID: 5523 RVA: 0x0001BC08 File Offset: 0x00019E08
			public float remapZMultiplier
			{
				get
				{
					return ParticleSystem.NoiseModule.GetRemapZMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.NoiseModule.SetRemapZMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x06001594 RID: 5524
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetEnabled(ParticleSystem system, bool value);

			// Token: 0x06001595 RID: 5525
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetEnabled(ParticleSystem system);

			// Token: 0x06001596 RID: 5526
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetSeparateAxes(ParticleSystem system, bool value);

			// Token: 0x06001597 RID: 5527
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetSeparateAxes(ParticleSystem system);

			// Token: 0x06001598 RID: 5528
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStrengthX(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001599 RID: 5529
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetStrengthX(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x0600159A RID: 5530
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStrengthY(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x0600159B RID: 5531
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetStrengthY(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x0600159C RID: 5532
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStrengthZ(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x0600159D RID: 5533
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetStrengthZ(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x0600159E RID: 5534
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStrengthXMultiplier(ParticleSystem system, float value);

			// Token: 0x0600159F RID: 5535
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetStrengthXMultiplier(ParticleSystem system);

			// Token: 0x060015A0 RID: 5536
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStrengthYMultiplier(ParticleSystem system, float value);

			// Token: 0x060015A1 RID: 5537
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetStrengthYMultiplier(ParticleSystem system);

			// Token: 0x060015A2 RID: 5538
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStrengthZMultiplier(ParticleSystem system, float value);

			// Token: 0x060015A3 RID: 5539
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetStrengthZMultiplier(ParticleSystem system);

			// Token: 0x060015A4 RID: 5540
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetFrequency(ParticleSystem system, float value);

			// Token: 0x060015A5 RID: 5541
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetFrequency(ParticleSystem system);

			// Token: 0x060015A6 RID: 5542
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetDamping(ParticleSystem system, bool value);

			// Token: 0x060015A7 RID: 5543
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetDamping(ParticleSystem system);

			// Token: 0x060015A8 RID: 5544
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetOctaveCount(ParticleSystem system, int value);

			// Token: 0x060015A9 RID: 5545
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetOctaveCount(ParticleSystem system);

			// Token: 0x060015AA RID: 5546
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetOctaveMultiplier(ParticleSystem system, float value);

			// Token: 0x060015AB RID: 5547
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetOctaveMultiplier(ParticleSystem system);

			// Token: 0x060015AC RID: 5548
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetOctaveScale(ParticleSystem system, float value);

			// Token: 0x060015AD RID: 5549
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetOctaveScale(ParticleSystem system);

			// Token: 0x060015AE RID: 5550
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetQuality(ParticleSystem system, int value);

			// Token: 0x060015AF RID: 5551
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetQuality(ParticleSystem system);

			// Token: 0x060015B0 RID: 5552
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetScrollSpeed(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060015B1 RID: 5553
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetScrollSpeed(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060015B2 RID: 5554
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetScrollSpeedMultiplier(ParticleSystem system, float value);

			// Token: 0x060015B3 RID: 5555
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetScrollSpeedMultiplier(ParticleSystem system);

			// Token: 0x060015B4 RID: 5556
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRemapEnabled(ParticleSystem system, bool value);

			// Token: 0x060015B5 RID: 5557
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetRemapEnabled(ParticleSystem system);

			// Token: 0x060015B6 RID: 5558
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRemapX(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060015B7 RID: 5559
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetRemapX(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060015B8 RID: 5560
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRemapY(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060015B9 RID: 5561
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetRemapY(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060015BA RID: 5562
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRemapZ(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060015BB RID: 5563
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetRemapZ(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060015BC RID: 5564
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRemapXMultiplier(ParticleSystem system, float value);

			// Token: 0x060015BD RID: 5565
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetRemapXMultiplier(ParticleSystem system);

			// Token: 0x060015BE RID: 5566
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRemapYMultiplier(ParticleSystem system, float value);

			// Token: 0x060015BF RID: 5567
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetRemapYMultiplier(ParticleSystem system);

			// Token: 0x060015C0 RID: 5568
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRemapZMultiplier(ParticleSystem system, float value);

			// Token: 0x060015C1 RID: 5569
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetRemapZMultiplier(ParticleSystem system);

			// Token: 0x04000357 RID: 855
			private ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000138 RID: 312
		public struct CollisionModule
		{
			// Token: 0x060015C2 RID: 5570 RVA: 0x0001BC18 File Offset: 0x00019E18
			internal CollisionModule(ParticleSystem particleSystem)
			{
				this.m_ParticleSystem = particleSystem;
			}

			// Token: 0x170004B8 RID: 1208
			// (get) Token: 0x060015C4 RID: 5572 RVA: 0x0001BC34 File Offset: 0x00019E34
			// (set) Token: 0x060015C3 RID: 5571 RVA: 0x0001BC24 File Offset: 0x00019E24
			public bool enabled
			{
				get
				{
					return ParticleSystem.CollisionModule.GetEnabled(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.CollisionModule.SetEnabled(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004B9 RID: 1209
			// (get) Token: 0x060015C6 RID: 5574 RVA: 0x0001BC64 File Offset: 0x00019E64
			// (set) Token: 0x060015C5 RID: 5573 RVA: 0x0001BC54 File Offset: 0x00019E54
			public ParticleSystemCollisionType type
			{
				get
				{
					return (ParticleSystemCollisionType)ParticleSystem.CollisionModule.GetType(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.CollisionModule.SetType(this.m_ParticleSystem, (int)value);
				}
			}

			// Token: 0x170004BA RID: 1210
			// (get) Token: 0x060015C8 RID: 5576 RVA: 0x0001BC94 File Offset: 0x00019E94
			// (set) Token: 0x060015C7 RID: 5575 RVA: 0x0001BC84 File Offset: 0x00019E84
			public ParticleSystemCollisionMode mode
			{
				get
				{
					return (ParticleSystemCollisionMode)ParticleSystem.CollisionModule.GetMode(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.CollisionModule.SetMode(this.m_ParticleSystem, (int)value);
				}
			}

			// Token: 0x170004BB RID: 1211
			// (get) Token: 0x060015CA RID: 5578 RVA: 0x0001BCC4 File Offset: 0x00019EC4
			// (set) Token: 0x060015C9 RID: 5577 RVA: 0x0001BCB4 File Offset: 0x00019EB4
			public ParticleSystem.MinMaxCurve dampen
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.CollisionModule.GetDampen(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.CollisionModule.SetDampen(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x170004BC RID: 1212
			// (get) Token: 0x060015CB RID: 5579 RVA: 0x0001BCF0 File Offset: 0x00019EF0
			// (set) Token: 0x060015CC RID: 5580 RVA: 0x0001BD10 File Offset: 0x00019F10
			public float dampenMultiplier
			{
				get
				{
					return ParticleSystem.CollisionModule.GetDampenMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.CollisionModule.SetDampenMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004BD RID: 1213
			// (get) Token: 0x060015CE RID: 5582 RVA: 0x0001BD30 File Offset: 0x00019F30
			// (set) Token: 0x060015CD RID: 5581 RVA: 0x0001BD20 File Offset: 0x00019F20
			public ParticleSystem.MinMaxCurve bounce
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.CollisionModule.GetBounce(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.CollisionModule.SetBounce(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x170004BE RID: 1214
			// (get) Token: 0x060015CF RID: 5583 RVA: 0x0001BD5C File Offset: 0x00019F5C
			// (set) Token: 0x060015D0 RID: 5584 RVA: 0x0001BD7C File Offset: 0x00019F7C
			public float bounceMultiplier
			{
				get
				{
					return ParticleSystem.CollisionModule.GetBounceMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.CollisionModule.SetBounceMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004BF RID: 1215
			// (get) Token: 0x060015D2 RID: 5586 RVA: 0x0001BD9C File Offset: 0x00019F9C
			// (set) Token: 0x060015D1 RID: 5585 RVA: 0x0001BD8C File Offset: 0x00019F8C
			public ParticleSystem.MinMaxCurve lifetimeLoss
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.CollisionModule.GetLifetimeLoss(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.CollisionModule.SetLifetimeLoss(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x170004C0 RID: 1216
			// (get) Token: 0x060015D3 RID: 5587 RVA: 0x0001BDC8 File Offset: 0x00019FC8
			// (set) Token: 0x060015D4 RID: 5588 RVA: 0x0001BDE8 File Offset: 0x00019FE8
			public float lifetimeLossMultiplier
			{
				get
				{
					return ParticleSystem.CollisionModule.GetLifetimeLossMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.CollisionModule.SetLifetimeLossMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004C1 RID: 1217
			// (get) Token: 0x060015D5 RID: 5589 RVA: 0x0001BDF8 File Offset: 0x00019FF8
			// (set) Token: 0x060015D6 RID: 5590 RVA: 0x0001BE18 File Offset: 0x0001A018
			public float minKillSpeed
			{
				get
				{
					return ParticleSystem.CollisionModule.GetMinKillSpeed(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.CollisionModule.SetMinKillSpeed(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004C2 RID: 1218
			// (get) Token: 0x060015D7 RID: 5591 RVA: 0x0001BE28 File Offset: 0x0001A028
			// (set) Token: 0x060015D8 RID: 5592 RVA: 0x0001BE48 File Offset: 0x0001A048
			public float maxKillSpeed
			{
				get
				{
					return ParticleSystem.CollisionModule.GetMaxKillSpeed(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.CollisionModule.SetMaxKillSpeed(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004C3 RID: 1219
			// (get) Token: 0x060015D9 RID: 5593 RVA: 0x0001BE58 File Offset: 0x0001A058
			// (set) Token: 0x060015DA RID: 5594 RVA: 0x0001BE80 File Offset: 0x0001A080
			public LayerMask collidesWith
			{
				get
				{
					return ParticleSystem.CollisionModule.GetCollidesWith(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.CollisionModule.SetCollidesWith(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004C4 RID: 1220
			// (get) Token: 0x060015DB RID: 5595 RVA: 0x0001BE94 File Offset: 0x0001A094
			// (set) Token: 0x060015DC RID: 5596 RVA: 0x0001BEB4 File Offset: 0x0001A0B4
			public bool enableDynamicColliders
			{
				get
				{
					return ParticleSystem.CollisionModule.GetEnableDynamicColliders(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.CollisionModule.SetEnableDynamicColliders(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004C5 RID: 1221
			// (get) Token: 0x060015DD RID: 5597 RVA: 0x0001BEC4 File Offset: 0x0001A0C4
			// (set) Token: 0x060015DE RID: 5598 RVA: 0x0001BEE4 File Offset: 0x0001A0E4
			public bool enableInteriorCollisions
			{
				get
				{
					return ParticleSystem.CollisionModule.GetEnableInteriorCollisions(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.CollisionModule.SetEnableInteriorCollisions(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004C6 RID: 1222
			// (get) Token: 0x060015DF RID: 5599 RVA: 0x0001BEF4 File Offset: 0x0001A0F4
			// (set) Token: 0x060015E0 RID: 5600 RVA: 0x0001BF14 File Offset: 0x0001A114
			public int maxCollisionShapes
			{
				get
				{
					return ParticleSystem.CollisionModule.GetMaxCollisionShapes(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.CollisionModule.SetMaxCollisionShapes(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004C7 RID: 1223
			// (get) Token: 0x060015E2 RID: 5602 RVA: 0x0001BF34 File Offset: 0x0001A134
			// (set) Token: 0x060015E1 RID: 5601 RVA: 0x0001BF24 File Offset: 0x0001A124
			public ParticleSystemCollisionQuality quality
			{
				get
				{
					return (ParticleSystemCollisionQuality)ParticleSystem.CollisionModule.GetQuality(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.CollisionModule.SetQuality(this.m_ParticleSystem, (int)value);
				}
			}

			// Token: 0x170004C8 RID: 1224
			// (get) Token: 0x060015E3 RID: 5603 RVA: 0x0001BF54 File Offset: 0x0001A154
			// (set) Token: 0x060015E4 RID: 5604 RVA: 0x0001BF74 File Offset: 0x0001A174
			public float voxelSize
			{
				get
				{
					return ParticleSystem.CollisionModule.GetVoxelSize(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.CollisionModule.SetVoxelSize(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004C9 RID: 1225
			// (get) Token: 0x060015E5 RID: 5605 RVA: 0x0001BF84 File Offset: 0x0001A184
			// (set) Token: 0x060015E6 RID: 5606 RVA: 0x0001BFA4 File Offset: 0x0001A1A4
			public float radiusScale
			{
				get
				{
					return ParticleSystem.CollisionModule.GetRadiusScale(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.CollisionModule.SetRadiusScale(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004CA RID: 1226
			// (get) Token: 0x060015E7 RID: 5607 RVA: 0x0001BFB4 File Offset: 0x0001A1B4
			// (set) Token: 0x060015E8 RID: 5608 RVA: 0x0001BFD4 File Offset: 0x0001A1D4
			public bool sendCollisionMessages
			{
				get
				{
					return ParticleSystem.CollisionModule.GetUsesCollisionMessages(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.CollisionModule.SetUsesCollisionMessages(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x060015E9 RID: 5609 RVA: 0x0001BFE4 File Offset: 0x0001A1E4
			public void SetPlane(int index, Transform transform)
			{
				ParticleSystem.CollisionModule.SetPlane(this.m_ParticleSystem, index, transform);
			}

			// Token: 0x060015EA RID: 5610 RVA: 0x0001BFF4 File Offset: 0x0001A1F4
			public Transform GetPlane(int index)
			{
				return ParticleSystem.CollisionModule.GetPlane(this.m_ParticleSystem, index);
			}

			// Token: 0x170004CB RID: 1227
			// (get) Token: 0x060015EB RID: 5611 RVA: 0x0001C018 File Offset: 0x0001A218
			public int maxPlaneCount
			{
				get
				{
					return ParticleSystem.CollisionModule.GetMaxPlaneCount(this.m_ParticleSystem);
				}
			}

			// Token: 0x060015EC RID: 5612
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetEnabled(ParticleSystem system, bool value);

			// Token: 0x060015ED RID: 5613
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetEnabled(ParticleSystem system);

			// Token: 0x060015EE RID: 5614
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetType(ParticleSystem system, int value);

			// Token: 0x060015EF RID: 5615
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetType(ParticleSystem system);

			// Token: 0x060015F0 RID: 5616
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetMode(ParticleSystem system, int value);

			// Token: 0x060015F1 RID: 5617
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetMode(ParticleSystem system);

			// Token: 0x060015F2 RID: 5618
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetDampen(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060015F3 RID: 5619
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetDampen(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060015F4 RID: 5620
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetDampenMultiplier(ParticleSystem system, float value);

			// Token: 0x060015F5 RID: 5621
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetDampenMultiplier(ParticleSystem system);

			// Token: 0x060015F6 RID: 5622
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetBounce(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060015F7 RID: 5623
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetBounce(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060015F8 RID: 5624
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetBounceMultiplier(ParticleSystem system, float value);

			// Token: 0x060015F9 RID: 5625
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetBounceMultiplier(ParticleSystem system);

			// Token: 0x060015FA RID: 5626
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetLifetimeLoss(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060015FB RID: 5627
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetLifetimeLoss(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060015FC RID: 5628
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetLifetimeLossMultiplier(ParticleSystem system, float value);

			// Token: 0x060015FD RID: 5629
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetLifetimeLossMultiplier(ParticleSystem system);

			// Token: 0x060015FE RID: 5630
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetMinKillSpeed(ParticleSystem system, float value);

			// Token: 0x060015FF RID: 5631
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetMinKillSpeed(ParticleSystem system);

			// Token: 0x06001600 RID: 5632
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetMaxKillSpeed(ParticleSystem system, float value);

			// Token: 0x06001601 RID: 5633
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetMaxKillSpeed(ParticleSystem system);

			// Token: 0x06001602 RID: 5634
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetCollidesWith(ParticleSystem system, int value);

			// Token: 0x06001603 RID: 5635
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetCollidesWith(ParticleSystem system);

			// Token: 0x06001604 RID: 5636
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetEnableDynamicColliders(ParticleSystem system, bool value);

			// Token: 0x06001605 RID: 5637
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetEnableDynamicColliders(ParticleSystem system);

			// Token: 0x06001606 RID: 5638
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetEnableInteriorCollisions(ParticleSystem system, bool value);

			// Token: 0x06001607 RID: 5639
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetEnableInteriorCollisions(ParticleSystem system);

			// Token: 0x06001608 RID: 5640
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetMaxCollisionShapes(ParticleSystem system, int value);

			// Token: 0x06001609 RID: 5641
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetMaxCollisionShapes(ParticleSystem system);

			// Token: 0x0600160A RID: 5642
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetQuality(ParticleSystem system, int value);

			// Token: 0x0600160B RID: 5643
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetQuality(ParticleSystem system);

			// Token: 0x0600160C RID: 5644
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetVoxelSize(ParticleSystem system, float value);

			// Token: 0x0600160D RID: 5645
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetVoxelSize(ParticleSystem system);

			// Token: 0x0600160E RID: 5646
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRadiusScale(ParticleSystem system, float value);

			// Token: 0x0600160F RID: 5647
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetRadiusScale(ParticleSystem system);

			// Token: 0x06001610 RID: 5648
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetUsesCollisionMessages(ParticleSystem system, bool value);

			// Token: 0x06001611 RID: 5649
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetUsesCollisionMessages(ParticleSystem system);

			// Token: 0x06001612 RID: 5650
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetPlane(ParticleSystem system, int index, Transform transform);

			// Token: 0x06001613 RID: 5651
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern Transform GetPlane(ParticleSystem system, int index);

			// Token: 0x06001614 RID: 5652
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetMaxPlaneCount(ParticleSystem system);

			// Token: 0x04000358 RID: 856
			private ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000139 RID: 313
		public struct TriggerModule
		{
			// Token: 0x06001615 RID: 5653 RVA: 0x0001C038 File Offset: 0x0001A238
			internal TriggerModule(ParticleSystem particleSystem)
			{
				this.m_ParticleSystem = particleSystem;
			}

			// Token: 0x170004CC RID: 1228
			// (get) Token: 0x06001617 RID: 5655 RVA: 0x0001C054 File Offset: 0x0001A254
			// (set) Token: 0x06001616 RID: 5654 RVA: 0x0001C044 File Offset: 0x0001A244
			public bool enabled
			{
				get
				{
					return ParticleSystem.TriggerModule.GetEnabled(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TriggerModule.SetEnabled(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004CD RID: 1229
			// (get) Token: 0x06001619 RID: 5657 RVA: 0x0001C084 File Offset: 0x0001A284
			// (set) Token: 0x06001618 RID: 5656 RVA: 0x0001C074 File Offset: 0x0001A274
			public ParticleSystemOverlapAction inside
			{
				get
				{
					return (ParticleSystemOverlapAction)ParticleSystem.TriggerModule.GetInside(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TriggerModule.SetInside(this.m_ParticleSystem, (int)value);
				}
			}

			// Token: 0x170004CE RID: 1230
			// (get) Token: 0x0600161B RID: 5659 RVA: 0x0001C0B4 File Offset: 0x0001A2B4
			// (set) Token: 0x0600161A RID: 5658 RVA: 0x0001C0A4 File Offset: 0x0001A2A4
			public ParticleSystemOverlapAction outside
			{
				get
				{
					return (ParticleSystemOverlapAction)ParticleSystem.TriggerModule.GetOutside(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TriggerModule.SetOutside(this.m_ParticleSystem, (int)value);
				}
			}

			// Token: 0x170004CF RID: 1231
			// (get) Token: 0x0600161D RID: 5661 RVA: 0x0001C0E4 File Offset: 0x0001A2E4
			// (set) Token: 0x0600161C RID: 5660 RVA: 0x0001C0D4 File Offset: 0x0001A2D4
			public ParticleSystemOverlapAction enter
			{
				get
				{
					return (ParticleSystemOverlapAction)ParticleSystem.TriggerModule.GetEnter(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TriggerModule.SetEnter(this.m_ParticleSystem, (int)value);
				}
			}

			// Token: 0x170004D0 RID: 1232
			// (get) Token: 0x0600161F RID: 5663 RVA: 0x0001C114 File Offset: 0x0001A314
			// (set) Token: 0x0600161E RID: 5662 RVA: 0x0001C104 File Offset: 0x0001A304
			public ParticleSystemOverlapAction exit
			{
				get
				{
					return (ParticleSystemOverlapAction)ParticleSystem.TriggerModule.GetExit(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TriggerModule.SetExit(this.m_ParticleSystem, (int)value);
				}
			}

			// Token: 0x170004D1 RID: 1233
			// (get) Token: 0x06001620 RID: 5664 RVA: 0x0001C134 File Offset: 0x0001A334
			// (set) Token: 0x06001621 RID: 5665 RVA: 0x0001C154 File Offset: 0x0001A354
			public float radiusScale
			{
				get
				{
					return ParticleSystem.TriggerModule.GetRadiusScale(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TriggerModule.SetRadiusScale(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x06001622 RID: 5666 RVA: 0x0001C164 File Offset: 0x0001A364
			public void SetCollider(int index, Component collider)
			{
				ParticleSystem.TriggerModule.SetCollider(this.m_ParticleSystem, index, collider);
			}

			// Token: 0x06001623 RID: 5667 RVA: 0x0001C174 File Offset: 0x0001A374
			public Component GetCollider(int index)
			{
				return ParticleSystem.TriggerModule.GetCollider(this.m_ParticleSystem, index);
			}

			// Token: 0x170004D2 RID: 1234
			// (get) Token: 0x06001624 RID: 5668 RVA: 0x0001C198 File Offset: 0x0001A398
			public int maxColliderCount
			{
				get
				{
					return ParticleSystem.TriggerModule.GetMaxColliderCount(this.m_ParticleSystem);
				}
			}

			// Token: 0x06001625 RID: 5669
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetEnabled(ParticleSystem system, bool value);

			// Token: 0x06001626 RID: 5670
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetEnabled(ParticleSystem system);

			// Token: 0x06001627 RID: 5671
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetInside(ParticleSystem system, int value);

			// Token: 0x06001628 RID: 5672
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetInside(ParticleSystem system);

			// Token: 0x06001629 RID: 5673
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetOutside(ParticleSystem system, int value);

			// Token: 0x0600162A RID: 5674
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetOutside(ParticleSystem system);

			// Token: 0x0600162B RID: 5675
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetEnter(ParticleSystem system, int value);

			// Token: 0x0600162C RID: 5676
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetEnter(ParticleSystem system);

			// Token: 0x0600162D RID: 5677
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetExit(ParticleSystem system, int value);

			// Token: 0x0600162E RID: 5678
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetExit(ParticleSystem system);

			// Token: 0x0600162F RID: 5679
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRadiusScale(ParticleSystem system, float value);

			// Token: 0x06001630 RID: 5680
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetRadiusScale(ParticleSystem system);

			// Token: 0x06001631 RID: 5681
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetCollider(ParticleSystem system, int index, Component collider);

			// Token: 0x06001632 RID: 5682
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern Component GetCollider(ParticleSystem system, int index);

			// Token: 0x06001633 RID: 5683
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetMaxColliderCount(ParticleSystem system);

			// Token: 0x04000359 RID: 857
			private ParticleSystem m_ParticleSystem;
		}

		// Token: 0x0200013A RID: 314
		public struct SubEmittersModule
		{
			// Token: 0x06001634 RID: 5684 RVA: 0x0001C1B8 File Offset: 0x0001A3B8
			internal SubEmittersModule(ParticleSystem particleSystem)
			{
				this.m_ParticleSystem = particleSystem;
			}

			// Token: 0x170004D3 RID: 1235
			// (get) Token: 0x06001636 RID: 5686 RVA: 0x0001C1D4 File Offset: 0x0001A3D4
			// (set) Token: 0x06001635 RID: 5685 RVA: 0x0001C1C4 File Offset: 0x0001A3C4
			public bool enabled
			{
				get
				{
					return ParticleSystem.SubEmittersModule.GetEnabled(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.SubEmittersModule.SetEnabled(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004D4 RID: 1236
			// (get) Token: 0x06001637 RID: 5687 RVA: 0x0001C1F4 File Offset: 0x0001A3F4
			public int subEmittersCount
			{
				get
				{
					return ParticleSystem.SubEmittersModule.GetSubEmittersCount(this.m_ParticleSystem);
				}
			}

			// Token: 0x06001638 RID: 5688 RVA: 0x0001C214 File Offset: 0x0001A414
			public void AddSubEmitter(ParticleSystem subEmitter, ParticleSystemSubEmitterType type, ParticleSystemSubEmitterProperties properties)
			{
				ParticleSystem.SubEmittersModule.AddSubEmitter(this.m_ParticleSystem, subEmitter, (int)type, (int)properties);
			}

			// Token: 0x06001639 RID: 5689 RVA: 0x0001C228 File Offset: 0x0001A428
			public void RemoveSubEmitter(int index)
			{
				ParticleSystem.SubEmittersModule.RemoveSubEmitter(this.m_ParticleSystem, index);
			}

			// Token: 0x0600163A RID: 5690 RVA: 0x0001C238 File Offset: 0x0001A438
			public void SetSubEmitterSystem(int index, ParticleSystem subEmitter)
			{
				ParticleSystem.SubEmittersModule.SetSubEmitterSystem(this.m_ParticleSystem, index, subEmitter);
			}

			// Token: 0x0600163B RID: 5691 RVA: 0x0001C248 File Offset: 0x0001A448
			public void SetSubEmitterType(int index, ParticleSystemSubEmitterType type)
			{
				ParticleSystem.SubEmittersModule.SetSubEmitterType(this.m_ParticleSystem, index, (int)type);
			}

			// Token: 0x0600163C RID: 5692 RVA: 0x0001C258 File Offset: 0x0001A458
			public void SetSubEmitterProperties(int index, ParticleSystemSubEmitterProperties properties)
			{
				ParticleSystem.SubEmittersModule.SetSubEmitterProperties(this.m_ParticleSystem, index, (int)properties);
			}

			// Token: 0x0600163D RID: 5693 RVA: 0x0001C268 File Offset: 0x0001A468
			public ParticleSystem GetSubEmitterSystem(int index)
			{
				return ParticleSystem.SubEmittersModule.GetSubEmitterSystem(this.m_ParticleSystem, index);
			}

			// Token: 0x0600163E RID: 5694 RVA: 0x0001C28C File Offset: 0x0001A48C
			public ParticleSystemSubEmitterType GetSubEmitterType(int index)
			{
				return (ParticleSystemSubEmitterType)ParticleSystem.SubEmittersModule.GetSubEmitterType(this.m_ParticleSystem, index);
			}

			// Token: 0x0600163F RID: 5695 RVA: 0x0001C2B0 File Offset: 0x0001A4B0
			public ParticleSystemSubEmitterProperties GetSubEmitterProperties(int index)
			{
				return (ParticleSystemSubEmitterProperties)ParticleSystem.SubEmittersModule.GetSubEmitterProperties(this.m_ParticleSystem, index);
			}

			// Token: 0x170004D5 RID: 1237
			// (get) Token: 0x06001640 RID: 5696 RVA: 0x0001C2D4 File Offset: 0x0001A4D4
			// (set) Token: 0x06001641 RID: 5697 RVA: 0x0001C2F8 File Offset: 0x0001A4F8
			[Obsolete("birth0 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.")]
			public ParticleSystem birth0
			{
				get
				{
					return ParticleSystem.SubEmittersModule.GetBirth(this.m_ParticleSystem, 0);
				}
				set
				{
					ParticleSystem.SubEmittersModule.SetBirth(this.m_ParticleSystem, 0, value);
				}
			}

			// Token: 0x170004D6 RID: 1238
			// (get) Token: 0x06001642 RID: 5698 RVA: 0x0001C308 File Offset: 0x0001A508
			// (set) Token: 0x06001643 RID: 5699 RVA: 0x0001C32C File Offset: 0x0001A52C
			[Obsolete("birth1 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.")]
			public ParticleSystem birth1
			{
				get
				{
					return ParticleSystem.SubEmittersModule.GetBirth(this.m_ParticleSystem, 1);
				}
				set
				{
					ParticleSystem.SubEmittersModule.SetBirth(this.m_ParticleSystem, 1, value);
				}
			}

			// Token: 0x170004D7 RID: 1239
			// (get) Token: 0x06001644 RID: 5700 RVA: 0x0001C33C File Offset: 0x0001A53C
			// (set) Token: 0x06001645 RID: 5701 RVA: 0x0001C360 File Offset: 0x0001A560
			[Obsolete("collision0 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.")]
			public ParticleSystem collision0
			{
				get
				{
					return ParticleSystem.SubEmittersModule.GetCollision(this.m_ParticleSystem, 0);
				}
				set
				{
					ParticleSystem.SubEmittersModule.SetCollision(this.m_ParticleSystem, 0, value);
				}
			}

			// Token: 0x170004D8 RID: 1240
			// (get) Token: 0x06001646 RID: 5702 RVA: 0x0001C370 File Offset: 0x0001A570
			// (set) Token: 0x06001647 RID: 5703 RVA: 0x0001C394 File Offset: 0x0001A594
			[Obsolete("collision1 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.")]
			public ParticleSystem collision1
			{
				get
				{
					return ParticleSystem.SubEmittersModule.GetCollision(this.m_ParticleSystem, 1);
				}
				set
				{
					ParticleSystem.SubEmittersModule.SetCollision(this.m_ParticleSystem, 1, value);
				}
			}

			// Token: 0x170004D9 RID: 1241
			// (get) Token: 0x06001648 RID: 5704 RVA: 0x0001C3A4 File Offset: 0x0001A5A4
			// (set) Token: 0x06001649 RID: 5705 RVA: 0x0001C3C8 File Offset: 0x0001A5C8
			[Obsolete("death0 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.")]
			public ParticleSystem death0
			{
				get
				{
					return ParticleSystem.SubEmittersModule.GetDeath(this.m_ParticleSystem, 0);
				}
				set
				{
					ParticleSystem.SubEmittersModule.SetDeath(this.m_ParticleSystem, 0, value);
				}
			}

			// Token: 0x170004DA RID: 1242
			// (get) Token: 0x0600164A RID: 5706 RVA: 0x0001C3D8 File Offset: 0x0001A5D8
			// (set) Token: 0x0600164B RID: 5707 RVA: 0x0001C3FC File Offset: 0x0001A5FC
			[Obsolete("death1 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.")]
			public ParticleSystem death1
			{
				get
				{
					return ParticleSystem.SubEmittersModule.GetDeath(this.m_ParticleSystem, 1);
				}
				set
				{
					ParticleSystem.SubEmittersModule.SetDeath(this.m_ParticleSystem, 1, value);
				}
			}

			// Token: 0x0600164C RID: 5708
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetEnabled(ParticleSystem system, bool value);

			// Token: 0x0600164D RID: 5709
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetEnabled(ParticleSystem system);

			// Token: 0x0600164E RID: 5710
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetSubEmittersCount(ParticleSystem system);

			// Token: 0x0600164F RID: 5711
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetBirth(ParticleSystem system, int index, ParticleSystem value);

			// Token: 0x06001650 RID: 5712
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern ParticleSystem GetBirth(ParticleSystem system, int index);

			// Token: 0x06001651 RID: 5713
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetCollision(ParticleSystem system, int index, ParticleSystem value);

			// Token: 0x06001652 RID: 5714
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern ParticleSystem GetCollision(ParticleSystem system, int index);

			// Token: 0x06001653 RID: 5715
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetDeath(ParticleSystem system, int index, ParticleSystem value);

			// Token: 0x06001654 RID: 5716
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern ParticleSystem GetDeath(ParticleSystem system, int index);

			// Token: 0x06001655 RID: 5717
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void AddSubEmitter(ParticleSystem system, ParticleSystem subEmitter, int type, int properties);

			// Token: 0x06001656 RID: 5718
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void RemoveSubEmitter(ParticleSystem system, int index);

			// Token: 0x06001657 RID: 5719
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetSubEmitterSystem(ParticleSystem system, int index, ParticleSystem subEmitter);

			// Token: 0x06001658 RID: 5720
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetSubEmitterType(ParticleSystem system, int index, int type);

			// Token: 0x06001659 RID: 5721
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetSubEmitterProperties(ParticleSystem system, int index, int properties);

			// Token: 0x0600165A RID: 5722
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern ParticleSystem GetSubEmitterSystem(ParticleSystem system, int index);

			// Token: 0x0600165B RID: 5723
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetSubEmitterType(ParticleSystem system, int index);

			// Token: 0x0600165C RID: 5724
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetSubEmitterProperties(ParticleSystem system, int index);

			// Token: 0x0400035A RID: 858
			private ParticleSystem m_ParticleSystem;
		}

		// Token: 0x0200013B RID: 315
		public struct TextureSheetAnimationModule
		{
			// Token: 0x0600165D RID: 5725 RVA: 0x0001C40C File Offset: 0x0001A60C
			internal TextureSheetAnimationModule(ParticleSystem particleSystem)
			{
				this.m_ParticleSystem = particleSystem;
			}

			// Token: 0x170004DB RID: 1243
			// (get) Token: 0x0600165F RID: 5727 RVA: 0x0001C428 File Offset: 0x0001A628
			// (set) Token: 0x0600165E RID: 5726 RVA: 0x0001C418 File Offset: 0x0001A618
			public bool enabled
			{
				get
				{
					return ParticleSystem.TextureSheetAnimationModule.GetEnabled(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TextureSheetAnimationModule.SetEnabled(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004DC RID: 1244
			// (get) Token: 0x06001661 RID: 5729 RVA: 0x0001C458 File Offset: 0x0001A658
			// (set) Token: 0x06001660 RID: 5728 RVA: 0x0001C448 File Offset: 0x0001A648
			public int numTilesX
			{
				get
				{
					return ParticleSystem.TextureSheetAnimationModule.GetNumTilesX(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TextureSheetAnimationModule.SetNumTilesX(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004DD RID: 1245
			// (get) Token: 0x06001663 RID: 5731 RVA: 0x0001C488 File Offset: 0x0001A688
			// (set) Token: 0x06001662 RID: 5730 RVA: 0x0001C478 File Offset: 0x0001A678
			public int numTilesY
			{
				get
				{
					return ParticleSystem.TextureSheetAnimationModule.GetNumTilesY(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TextureSheetAnimationModule.SetNumTilesY(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004DE RID: 1246
			// (get) Token: 0x06001665 RID: 5733 RVA: 0x0001C4B8 File Offset: 0x0001A6B8
			// (set) Token: 0x06001664 RID: 5732 RVA: 0x0001C4A8 File Offset: 0x0001A6A8
			public ParticleSystemAnimationType animation
			{
				get
				{
					return (ParticleSystemAnimationType)ParticleSystem.TextureSheetAnimationModule.GetAnimationType(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TextureSheetAnimationModule.SetAnimationType(this.m_ParticleSystem, (int)value);
				}
			}

			// Token: 0x170004DF RID: 1247
			// (get) Token: 0x06001667 RID: 5735 RVA: 0x0001C4E8 File Offset: 0x0001A6E8
			// (set) Token: 0x06001666 RID: 5734 RVA: 0x0001C4D8 File Offset: 0x0001A6D8
			public bool useRandomRow
			{
				get
				{
					return ParticleSystem.TextureSheetAnimationModule.GetUseRandomRow(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TextureSheetAnimationModule.SetUseRandomRow(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004E0 RID: 1248
			// (get) Token: 0x06001669 RID: 5737 RVA: 0x0001C518 File Offset: 0x0001A718
			// (set) Token: 0x06001668 RID: 5736 RVA: 0x0001C508 File Offset: 0x0001A708
			public ParticleSystem.MinMaxCurve frameOverTime
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.TextureSheetAnimationModule.GetFrameOverTime(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.TextureSheetAnimationModule.SetFrameOverTime(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x170004E1 RID: 1249
			// (get) Token: 0x0600166A RID: 5738 RVA: 0x0001C544 File Offset: 0x0001A744
			// (set) Token: 0x0600166B RID: 5739 RVA: 0x0001C564 File Offset: 0x0001A764
			public float frameOverTimeMultiplier
			{
				get
				{
					return ParticleSystem.TextureSheetAnimationModule.GetFrameOverTimeMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TextureSheetAnimationModule.SetFrameOverTimeMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004E2 RID: 1250
			// (get) Token: 0x0600166D RID: 5741 RVA: 0x0001C584 File Offset: 0x0001A784
			// (set) Token: 0x0600166C RID: 5740 RVA: 0x0001C574 File Offset: 0x0001A774
			public ParticleSystem.MinMaxCurve startFrame
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.TextureSheetAnimationModule.GetStartFrame(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.TextureSheetAnimationModule.SetStartFrame(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x170004E3 RID: 1251
			// (get) Token: 0x0600166E RID: 5742 RVA: 0x0001C5B0 File Offset: 0x0001A7B0
			// (set) Token: 0x0600166F RID: 5743 RVA: 0x0001C5D0 File Offset: 0x0001A7D0
			public float startFrameMultiplier
			{
				get
				{
					return ParticleSystem.TextureSheetAnimationModule.GetStartFrameMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TextureSheetAnimationModule.SetStartFrameMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004E4 RID: 1252
			// (get) Token: 0x06001671 RID: 5745 RVA: 0x0001C5F0 File Offset: 0x0001A7F0
			// (set) Token: 0x06001670 RID: 5744 RVA: 0x0001C5E0 File Offset: 0x0001A7E0
			public int cycleCount
			{
				get
				{
					return ParticleSystem.TextureSheetAnimationModule.GetCycleCount(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TextureSheetAnimationModule.SetCycleCount(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004E5 RID: 1253
			// (get) Token: 0x06001673 RID: 5747 RVA: 0x0001C620 File Offset: 0x0001A820
			// (set) Token: 0x06001672 RID: 5746 RVA: 0x0001C610 File Offset: 0x0001A810
			public int rowIndex
			{
				get
				{
					return ParticleSystem.TextureSheetAnimationModule.GetRowIndex(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TextureSheetAnimationModule.SetRowIndex(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004E6 RID: 1254
			// (get) Token: 0x06001675 RID: 5749 RVA: 0x0001C650 File Offset: 0x0001A850
			// (set) Token: 0x06001674 RID: 5748 RVA: 0x0001C640 File Offset: 0x0001A840
			public UVChannelFlags uvChannelMask
			{
				get
				{
					return (UVChannelFlags)ParticleSystem.TextureSheetAnimationModule.GetUVChannelMask(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TextureSheetAnimationModule.SetUVChannelMask(this.m_ParticleSystem, (int)value);
				}
			}

			// Token: 0x170004E7 RID: 1255
			// (get) Token: 0x06001676 RID: 5750 RVA: 0x0001C670 File Offset: 0x0001A870
			// (set) Token: 0x06001677 RID: 5751 RVA: 0x0001C690 File Offset: 0x0001A890
			public float flipU
			{
				get
				{
					return ParticleSystem.TextureSheetAnimationModule.GetFlipU(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TextureSheetAnimationModule.SetFlipU(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004E8 RID: 1256
			// (get) Token: 0x06001678 RID: 5752 RVA: 0x0001C6A0 File Offset: 0x0001A8A0
			// (set) Token: 0x06001679 RID: 5753 RVA: 0x0001C6C0 File Offset: 0x0001A8C0
			public float flipV
			{
				get
				{
					return ParticleSystem.TextureSheetAnimationModule.GetFlipV(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TextureSheetAnimationModule.SetFlipV(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x0600167A RID: 5754
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetEnabled(ParticleSystem system, bool value);

			// Token: 0x0600167B RID: 5755
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetEnabled(ParticleSystem system);

			// Token: 0x0600167C RID: 5756
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetNumTilesX(ParticleSystem system, int value);

			// Token: 0x0600167D RID: 5757
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetNumTilesX(ParticleSystem system);

			// Token: 0x0600167E RID: 5758
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetNumTilesY(ParticleSystem system, int value);

			// Token: 0x0600167F RID: 5759
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetNumTilesY(ParticleSystem system);

			// Token: 0x06001680 RID: 5760
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetAnimationType(ParticleSystem system, int value);

			// Token: 0x06001681 RID: 5761
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetAnimationType(ParticleSystem system);

			// Token: 0x06001682 RID: 5762
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetUseRandomRow(ParticleSystem system, bool value);

			// Token: 0x06001683 RID: 5763
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetUseRandomRow(ParticleSystem system);

			// Token: 0x06001684 RID: 5764
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetFrameOverTime(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001685 RID: 5765
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetFrameOverTime(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001686 RID: 5766
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetFrameOverTimeMultiplier(ParticleSystem system, float value);

			// Token: 0x06001687 RID: 5767
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetFrameOverTimeMultiplier(ParticleSystem system);

			// Token: 0x06001688 RID: 5768
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStartFrame(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001689 RID: 5769
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetStartFrame(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x0600168A RID: 5770
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetStartFrameMultiplier(ParticleSystem system, float value);

			// Token: 0x0600168B RID: 5771
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetStartFrameMultiplier(ParticleSystem system);

			// Token: 0x0600168C RID: 5772
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetCycleCount(ParticleSystem system, int value);

			// Token: 0x0600168D RID: 5773
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetCycleCount(ParticleSystem system);

			// Token: 0x0600168E RID: 5774
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRowIndex(ParticleSystem system, int value);

			// Token: 0x0600168F RID: 5775
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetRowIndex(ParticleSystem system);

			// Token: 0x06001690 RID: 5776
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetUVChannelMask(ParticleSystem system, int value);

			// Token: 0x06001691 RID: 5777
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetUVChannelMask(ParticleSystem system);

			// Token: 0x06001692 RID: 5778
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetFlipU(ParticleSystem system, float value);

			// Token: 0x06001693 RID: 5779
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetFlipU(ParticleSystem system);

			// Token: 0x06001694 RID: 5780
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetFlipV(ParticleSystem system, float value);

			// Token: 0x06001695 RID: 5781
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetFlipV(ParticleSystem system);

			// Token: 0x0400035B RID: 859
			private ParticleSystem m_ParticleSystem;
		}

		// Token: 0x0200013C RID: 316
		public struct LightsModule
		{
			// Token: 0x06001696 RID: 5782 RVA: 0x0001C6D0 File Offset: 0x0001A8D0
			internal LightsModule(ParticleSystem particleSystem)
			{
				this.m_ParticleSystem = particleSystem;
			}

			// Token: 0x170004E9 RID: 1257
			// (get) Token: 0x06001698 RID: 5784 RVA: 0x0001C6EC File Offset: 0x0001A8EC
			// (set) Token: 0x06001697 RID: 5783 RVA: 0x0001C6DC File Offset: 0x0001A8DC
			public bool enabled
			{
				get
				{
					return ParticleSystem.LightsModule.GetEnabled(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.LightsModule.SetEnabled(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004EA RID: 1258
			// (get) Token: 0x06001699 RID: 5785 RVA: 0x0001C70C File Offset: 0x0001A90C
			// (set) Token: 0x0600169A RID: 5786 RVA: 0x0001C72C File Offset: 0x0001A92C
			public float ratio
			{
				get
				{
					return ParticleSystem.LightsModule.GetRatio(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.LightsModule.SetRatio(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004EB RID: 1259
			// (get) Token: 0x0600169C RID: 5788 RVA: 0x0001C74C File Offset: 0x0001A94C
			// (set) Token: 0x0600169B RID: 5787 RVA: 0x0001C73C File Offset: 0x0001A93C
			public bool useRandomDistribution
			{
				get
				{
					return ParticleSystem.LightsModule.GetUseRandomDistribution(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.LightsModule.SetUseRandomDistribution(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004EC RID: 1260
			// (get) Token: 0x0600169E RID: 5790 RVA: 0x0001C77C File Offset: 0x0001A97C
			// (set) Token: 0x0600169D RID: 5789 RVA: 0x0001C76C File Offset: 0x0001A96C
			public Light light
			{
				get
				{
					return ParticleSystem.LightsModule.GetLightPrefab(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.LightsModule.SetLightPrefab(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004ED RID: 1261
			// (get) Token: 0x060016A0 RID: 5792 RVA: 0x0001C7AC File Offset: 0x0001A9AC
			// (set) Token: 0x0600169F RID: 5791 RVA: 0x0001C79C File Offset: 0x0001A99C
			public bool useParticleColor
			{
				get
				{
					return ParticleSystem.LightsModule.GetUseParticleColor(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.LightsModule.SetUseParticleColor(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004EE RID: 1262
			// (get) Token: 0x060016A2 RID: 5794 RVA: 0x0001C7DC File Offset: 0x0001A9DC
			// (set) Token: 0x060016A1 RID: 5793 RVA: 0x0001C7CC File Offset: 0x0001A9CC
			public bool sizeAffectsRange
			{
				get
				{
					return ParticleSystem.LightsModule.GetSizeAffectsRange(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.LightsModule.SetSizeAffectsRange(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004EF RID: 1263
			// (get) Token: 0x060016A4 RID: 5796 RVA: 0x0001C80C File Offset: 0x0001AA0C
			// (set) Token: 0x060016A3 RID: 5795 RVA: 0x0001C7FC File Offset: 0x0001A9FC
			public bool alphaAffectsIntensity
			{
				get
				{
					return ParticleSystem.LightsModule.GetAlphaAffectsIntensity(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.LightsModule.SetAlphaAffectsIntensity(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004F0 RID: 1264
			// (get) Token: 0x060016A6 RID: 5798 RVA: 0x0001C83C File Offset: 0x0001AA3C
			// (set) Token: 0x060016A5 RID: 5797 RVA: 0x0001C82C File Offset: 0x0001AA2C
			public ParticleSystem.MinMaxCurve range
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.LightsModule.GetRange(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.LightsModule.SetRange(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x170004F1 RID: 1265
			// (get) Token: 0x060016A7 RID: 5799 RVA: 0x0001C868 File Offset: 0x0001AA68
			// (set) Token: 0x060016A8 RID: 5800 RVA: 0x0001C888 File Offset: 0x0001AA88
			public float rangeMultiplier
			{
				get
				{
					return ParticleSystem.LightsModule.GetRangeMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.LightsModule.SetRangeMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004F2 RID: 1266
			// (get) Token: 0x060016AA RID: 5802 RVA: 0x0001C8A8 File Offset: 0x0001AAA8
			// (set) Token: 0x060016A9 RID: 5801 RVA: 0x0001C898 File Offset: 0x0001AA98
			public ParticleSystem.MinMaxCurve intensity
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.LightsModule.GetIntensity(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.LightsModule.SetIntensity(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x170004F3 RID: 1267
			// (get) Token: 0x060016AB RID: 5803 RVA: 0x0001C8D4 File Offset: 0x0001AAD4
			// (set) Token: 0x060016AC RID: 5804 RVA: 0x0001C8F4 File Offset: 0x0001AAF4
			public float intensityMultiplier
			{
				get
				{
					return ParticleSystem.LightsModule.GetIntensityMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.LightsModule.SetIntensityMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004F4 RID: 1268
			// (get) Token: 0x060016AE RID: 5806 RVA: 0x0001C914 File Offset: 0x0001AB14
			// (set) Token: 0x060016AD RID: 5805 RVA: 0x0001C904 File Offset: 0x0001AB04
			public int maxLights
			{
				get
				{
					return ParticleSystem.LightsModule.GetMaxLights(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.LightsModule.SetMaxLights(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x060016AF RID: 5807
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetEnabled(ParticleSystem system, bool value);

			// Token: 0x060016B0 RID: 5808
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetEnabled(ParticleSystem system);

			// Token: 0x060016B1 RID: 5809
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRatio(ParticleSystem system, float value);

			// Token: 0x060016B2 RID: 5810
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetRatio(ParticleSystem system);

			// Token: 0x060016B3 RID: 5811
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetUseRandomDistribution(ParticleSystem system, bool value);

			// Token: 0x060016B4 RID: 5812
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetUseRandomDistribution(ParticleSystem system);

			// Token: 0x060016B5 RID: 5813
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetLightPrefab(ParticleSystem system, Light value);

			// Token: 0x060016B6 RID: 5814
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern Light GetLightPrefab(ParticleSystem system);

			// Token: 0x060016B7 RID: 5815
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetUseParticleColor(ParticleSystem system, bool value);

			// Token: 0x060016B8 RID: 5816
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetUseParticleColor(ParticleSystem system);

			// Token: 0x060016B9 RID: 5817
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetSizeAffectsRange(ParticleSystem system, bool value);

			// Token: 0x060016BA RID: 5818
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetSizeAffectsRange(ParticleSystem system);

			// Token: 0x060016BB RID: 5819
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetAlphaAffectsIntensity(ParticleSystem system, bool value);

			// Token: 0x060016BC RID: 5820
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetAlphaAffectsIntensity(ParticleSystem system);

			// Token: 0x060016BD RID: 5821
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRange(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060016BE RID: 5822
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetRange(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060016BF RID: 5823
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRangeMultiplier(ParticleSystem system, float value);

			// Token: 0x060016C0 RID: 5824
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetRangeMultiplier(ParticleSystem system);

			// Token: 0x060016C1 RID: 5825
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetIntensity(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060016C2 RID: 5826
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetIntensity(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060016C3 RID: 5827
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetIntensityMultiplier(ParticleSystem system, float value);

			// Token: 0x060016C4 RID: 5828
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetIntensityMultiplier(ParticleSystem system);

			// Token: 0x060016C5 RID: 5829
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetMaxLights(ParticleSystem system, int value);

			// Token: 0x060016C6 RID: 5830
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetMaxLights(ParticleSystem system);

			// Token: 0x0400035C RID: 860
			private ParticleSystem m_ParticleSystem;
		}

		// Token: 0x0200013D RID: 317
		public struct TrailModule
		{
			// Token: 0x060016C7 RID: 5831 RVA: 0x0001C934 File Offset: 0x0001AB34
			internal TrailModule(ParticleSystem particleSystem)
			{
				this.m_ParticleSystem = particleSystem;
			}

			// Token: 0x170004F5 RID: 1269
			// (get) Token: 0x060016C9 RID: 5833 RVA: 0x0001C950 File Offset: 0x0001AB50
			// (set) Token: 0x060016C8 RID: 5832 RVA: 0x0001C940 File Offset: 0x0001AB40
			public bool enabled
			{
				get
				{
					return ParticleSystem.TrailModule.GetEnabled(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TrailModule.SetEnabled(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004F6 RID: 1270
			// (get) Token: 0x060016CA RID: 5834 RVA: 0x0001C970 File Offset: 0x0001AB70
			// (set) Token: 0x060016CB RID: 5835 RVA: 0x0001C990 File Offset: 0x0001AB90
			public float ratio
			{
				get
				{
					return ParticleSystem.TrailModule.GetRatio(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TrailModule.SetRatio(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004F7 RID: 1271
			// (get) Token: 0x060016CD RID: 5837 RVA: 0x0001C9B0 File Offset: 0x0001ABB0
			// (set) Token: 0x060016CC RID: 5836 RVA: 0x0001C9A0 File Offset: 0x0001ABA0
			public ParticleSystem.MinMaxCurve lifetime
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.TrailModule.GetLifetime(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.TrailModule.SetLifetime(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x170004F8 RID: 1272
			// (get) Token: 0x060016CE RID: 5838 RVA: 0x0001C9DC File Offset: 0x0001ABDC
			// (set) Token: 0x060016CF RID: 5839 RVA: 0x0001C9FC File Offset: 0x0001ABFC
			public float lifetimeMultiplier
			{
				get
				{
					return ParticleSystem.TrailModule.GetLifetimeMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TrailModule.SetLifetimeMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004F9 RID: 1273
			// (get) Token: 0x060016D1 RID: 5841 RVA: 0x0001CA1C File Offset: 0x0001AC1C
			// (set) Token: 0x060016D0 RID: 5840 RVA: 0x0001CA0C File Offset: 0x0001AC0C
			public float minVertexDistance
			{
				get
				{
					return ParticleSystem.TrailModule.GetMinVertexDistance(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TrailModule.SetMinVertexDistance(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004FA RID: 1274
			// (get) Token: 0x060016D2 RID: 5842 RVA: 0x0001CA3C File Offset: 0x0001AC3C
			// (set) Token: 0x060016D3 RID: 5843 RVA: 0x0001CA5C File Offset: 0x0001AC5C
			public ParticleSystemTrailTextureMode textureMode
			{
				get
				{
					return (ParticleSystemTrailTextureMode)ParticleSystem.TrailModule.GetTextureMode(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TrailModule.SetTextureMode(this.m_ParticleSystem, (float)value);
				}
			}

			// Token: 0x170004FB RID: 1275
			// (get) Token: 0x060016D5 RID: 5845 RVA: 0x0001CA7C File Offset: 0x0001AC7C
			// (set) Token: 0x060016D4 RID: 5844 RVA: 0x0001CA6C File Offset: 0x0001AC6C
			public bool worldSpace
			{
				get
				{
					return ParticleSystem.TrailModule.GetWorldSpace(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TrailModule.SetWorldSpace(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004FC RID: 1276
			// (get) Token: 0x060016D7 RID: 5847 RVA: 0x0001CAAC File Offset: 0x0001ACAC
			// (set) Token: 0x060016D6 RID: 5846 RVA: 0x0001CA9C File Offset: 0x0001AC9C
			public bool dieWithParticles
			{
				get
				{
					return ParticleSystem.TrailModule.GetDieWithParticles(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TrailModule.SetDieWithParticles(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004FD RID: 1277
			// (get) Token: 0x060016D9 RID: 5849 RVA: 0x0001CADC File Offset: 0x0001ACDC
			// (set) Token: 0x060016D8 RID: 5848 RVA: 0x0001CACC File Offset: 0x0001ACCC
			public bool sizeAffectsWidth
			{
				get
				{
					return ParticleSystem.TrailModule.GetSizeAffectsWidth(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TrailModule.SetSizeAffectsWidth(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004FE RID: 1278
			// (get) Token: 0x060016DB RID: 5851 RVA: 0x0001CB0C File Offset: 0x0001AD0C
			// (set) Token: 0x060016DA RID: 5850 RVA: 0x0001CAFC File Offset: 0x0001ACFC
			public bool sizeAffectsLifetime
			{
				get
				{
					return ParticleSystem.TrailModule.GetSizeAffectsLifetime(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TrailModule.SetSizeAffectsLifetime(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x170004FF RID: 1279
			// (get) Token: 0x060016DD RID: 5853 RVA: 0x0001CB3C File Offset: 0x0001AD3C
			// (set) Token: 0x060016DC RID: 5852 RVA: 0x0001CB2C File Offset: 0x0001AD2C
			public bool inheritParticleColor
			{
				get
				{
					return ParticleSystem.TrailModule.GetInheritParticleColor(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TrailModule.SetInheritParticleColor(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000500 RID: 1280
			// (get) Token: 0x060016DF RID: 5855 RVA: 0x0001CB6C File Offset: 0x0001AD6C
			// (set) Token: 0x060016DE RID: 5854 RVA: 0x0001CB5C File Offset: 0x0001AD5C
			public ParticleSystem.MinMaxGradient colorOverLifetime
			{
				get
				{
					ParticleSystem.MinMaxGradient result = default(ParticleSystem.MinMaxGradient);
					ParticleSystem.TrailModule.GetColorOverLifetime(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.TrailModule.SetColorOverLifetime(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000501 RID: 1281
			// (get) Token: 0x060016E1 RID: 5857 RVA: 0x0001CBA8 File Offset: 0x0001ADA8
			// (set) Token: 0x060016E0 RID: 5856 RVA: 0x0001CB98 File Offset: 0x0001AD98
			public ParticleSystem.MinMaxCurve widthOverTrail
			{
				get
				{
					ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
					ParticleSystem.TrailModule.GetWidthOverTrail(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.TrailModule.SetWidthOverTrail(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x17000502 RID: 1282
			// (get) Token: 0x060016E2 RID: 5858 RVA: 0x0001CBD4 File Offset: 0x0001ADD4
			// (set) Token: 0x060016E3 RID: 5859 RVA: 0x0001CBF4 File Offset: 0x0001ADF4
			public float widthOverTrailMultiplier
			{
				get
				{
					return ParticleSystem.TrailModule.GetWidthOverTrailMultiplier(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.TrailModule.SetWidthOverTrailMultiplier(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x17000503 RID: 1283
			// (get) Token: 0x060016E5 RID: 5861 RVA: 0x0001CC14 File Offset: 0x0001AE14
			// (set) Token: 0x060016E4 RID: 5860 RVA: 0x0001CC04 File Offset: 0x0001AE04
			public ParticleSystem.MinMaxGradient colorOverTrail
			{
				get
				{
					ParticleSystem.MinMaxGradient result = default(ParticleSystem.MinMaxGradient);
					ParticleSystem.TrailModule.GetColorOverTrail(this.m_ParticleSystem, ref result);
					return result;
				}
				set
				{
					ParticleSystem.TrailModule.SetColorOverTrail(this.m_ParticleSystem, ref value);
				}
			}

			// Token: 0x060016E6 RID: 5862
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetEnabled(ParticleSystem system, bool value);

			// Token: 0x060016E7 RID: 5863
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetEnabled(ParticleSystem system);

			// Token: 0x060016E8 RID: 5864
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetRatio(ParticleSystem system, float value);

			// Token: 0x060016E9 RID: 5865
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetRatio(ParticleSystem system);

			// Token: 0x060016EA RID: 5866
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetLifetime(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060016EB RID: 5867
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetLifetime(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060016EC RID: 5868
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetLifetimeMultiplier(ParticleSystem system, float value);

			// Token: 0x060016ED RID: 5869
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetLifetimeMultiplier(ParticleSystem system);

			// Token: 0x060016EE RID: 5870
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetMinVertexDistance(ParticleSystem system, float value);

			// Token: 0x060016EF RID: 5871
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetMinVertexDistance(ParticleSystem system);

			// Token: 0x060016F0 RID: 5872
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetTextureMode(ParticleSystem system, float value);

			// Token: 0x060016F1 RID: 5873
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetTextureMode(ParticleSystem system);

			// Token: 0x060016F2 RID: 5874
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetWorldSpace(ParticleSystem system, bool value);

			// Token: 0x060016F3 RID: 5875
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetWorldSpace(ParticleSystem system);

			// Token: 0x060016F4 RID: 5876
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetDieWithParticles(ParticleSystem system, bool value);

			// Token: 0x060016F5 RID: 5877
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetDieWithParticles(ParticleSystem system);

			// Token: 0x060016F6 RID: 5878
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetSizeAffectsWidth(ParticleSystem system, bool value);

			// Token: 0x060016F7 RID: 5879
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetSizeAffectsWidth(ParticleSystem system);

			// Token: 0x060016F8 RID: 5880
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetSizeAffectsLifetime(ParticleSystem system, bool value);

			// Token: 0x060016F9 RID: 5881
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetSizeAffectsLifetime(ParticleSystem system);

			// Token: 0x060016FA RID: 5882
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetInheritParticleColor(ParticleSystem system, bool value);

			// Token: 0x060016FB RID: 5883
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetInheritParticleColor(ParticleSystem system);

			// Token: 0x060016FC RID: 5884
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetColorOverLifetime(ParticleSystem system, ref ParticleSystem.MinMaxGradient gradient);

			// Token: 0x060016FD RID: 5885
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetColorOverLifetime(ParticleSystem system, ref ParticleSystem.MinMaxGradient gradient);

			// Token: 0x060016FE RID: 5886
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetWidthOverTrail(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x060016FF RID: 5887
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetWidthOverTrail(ParticleSystem system, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001700 RID: 5888
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetWidthOverTrailMultiplier(ParticleSystem system, float value);

			// Token: 0x06001701 RID: 5889
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetWidthOverTrailMultiplier(ParticleSystem system);

			// Token: 0x06001702 RID: 5890
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetColorOverTrail(ParticleSystem system, ref ParticleSystem.MinMaxGradient gradient);

			// Token: 0x06001703 RID: 5891
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetColorOverTrail(ParticleSystem system, ref ParticleSystem.MinMaxGradient gradient);

			// Token: 0x0400035D RID: 861
			private ParticleSystem m_ParticleSystem;
		}

		// Token: 0x0200013E RID: 318
		public struct CustomDataModule
		{
			// Token: 0x06001704 RID: 5892 RVA: 0x0001CC40 File Offset: 0x0001AE40
			internal CustomDataModule(ParticleSystem particleSystem)
			{
				this.m_ParticleSystem = particleSystem;
			}

			// Token: 0x17000504 RID: 1284
			// (get) Token: 0x06001706 RID: 5894 RVA: 0x0001CC5C File Offset: 0x0001AE5C
			// (set) Token: 0x06001705 RID: 5893 RVA: 0x0001CC4C File Offset: 0x0001AE4C
			public bool enabled
			{
				get
				{
					return ParticleSystem.CustomDataModule.GetEnabled(this.m_ParticleSystem);
				}
				set
				{
					ParticleSystem.CustomDataModule.SetEnabled(this.m_ParticleSystem, value);
				}
			}

			// Token: 0x06001707 RID: 5895 RVA: 0x0001CC7C File Offset: 0x0001AE7C
			public void SetMode(ParticleSystemCustomData stream, ParticleSystemCustomDataMode mode)
			{
				ParticleSystem.CustomDataModule.SetMode(this.m_ParticleSystem, (int)stream, (int)mode);
			}

			// Token: 0x06001708 RID: 5896 RVA: 0x0001CC8C File Offset: 0x0001AE8C
			public ParticleSystemCustomDataMode GetMode(ParticleSystemCustomData stream)
			{
				return (ParticleSystemCustomDataMode)ParticleSystem.CustomDataModule.GetMode(this.m_ParticleSystem, (int)stream);
			}

			// Token: 0x06001709 RID: 5897 RVA: 0x0001CCB0 File Offset: 0x0001AEB0
			public void SetVectorComponentCount(ParticleSystemCustomData stream, int count)
			{
				ParticleSystem.CustomDataModule.SetVectorComponentCount(this.m_ParticleSystem, (int)stream, count);
			}

			// Token: 0x0600170A RID: 5898 RVA: 0x0001CCC0 File Offset: 0x0001AEC0
			public int GetVectorComponentCount(ParticleSystemCustomData stream)
			{
				return ParticleSystem.CustomDataModule.GetVectorComponentCount(this.m_ParticleSystem, (int)stream);
			}

			// Token: 0x0600170B RID: 5899 RVA: 0x0001CCE4 File Offset: 0x0001AEE4
			public void SetVector(ParticleSystemCustomData stream, int component, ParticleSystem.MinMaxCurve curve)
			{
				ParticleSystem.CustomDataModule.SetVector(this.m_ParticleSystem, (int)stream, component, ref curve);
			}

			// Token: 0x0600170C RID: 5900 RVA: 0x0001CCF8 File Offset: 0x0001AEF8
			public ParticleSystem.MinMaxCurve GetVector(ParticleSystemCustomData stream, int component)
			{
				ParticleSystem.MinMaxCurve result = default(ParticleSystem.MinMaxCurve);
				ParticleSystem.CustomDataModule.GetVector(this.m_ParticleSystem, (int)stream, component, ref result);
				return result;
			}

			// Token: 0x0600170D RID: 5901 RVA: 0x0001CD28 File Offset: 0x0001AF28
			public void SetColor(ParticleSystemCustomData stream, ParticleSystem.MinMaxGradient gradient)
			{
				ParticleSystem.CustomDataModule.SetColor(this.m_ParticleSystem, (int)stream, ref gradient);
			}

			// Token: 0x0600170E RID: 5902 RVA: 0x0001CD3C File Offset: 0x0001AF3C
			public ParticleSystem.MinMaxGradient GetColor(ParticleSystemCustomData stream)
			{
				ParticleSystem.MinMaxGradient result = default(ParticleSystem.MinMaxGradient);
				ParticleSystem.CustomDataModule.GetColor(this.m_ParticleSystem, (int)stream, ref result);
				return result;
			}

			// Token: 0x0600170F RID: 5903
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetEnabled(ParticleSystem system, bool value);

			// Token: 0x06001710 RID: 5904
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool GetEnabled(ParticleSystem system);

			// Token: 0x06001711 RID: 5905
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetMode(ParticleSystem system, int stream, int mode);

			// Token: 0x06001712 RID: 5906
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetVectorComponentCount(ParticleSystem system, int stream, int count);

			// Token: 0x06001713 RID: 5907
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetVector(ParticleSystem system, int stream, int component, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001714 RID: 5908
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void SetColor(ParticleSystem system, int stream, ref ParticleSystem.MinMaxGradient gradient);

			// Token: 0x06001715 RID: 5909
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetMode(ParticleSystem system, int stream);

			// Token: 0x06001716 RID: 5910
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern int GetVectorComponentCount(ParticleSystem system, int stream);

			// Token: 0x06001717 RID: 5911
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetVector(ParticleSystem system, int stream, int component, ref ParticleSystem.MinMaxCurve curve);

			// Token: 0x06001718 RID: 5912
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void GetColor(ParticleSystem system, int stream, ref ParticleSystem.MinMaxGradient gradient);

			// Token: 0x0400035E RID: 862
			private ParticleSystem m_ParticleSystem;
		}

		// Token: 0x0200013F RID: 319
		[RequiredByNativeCode("particleSystemParticle", Optional = true)]
		public struct Particle
		{
			// Token: 0x17000505 RID: 1285
			// (get) Token: 0x06001719 RID: 5913 RVA: 0x0001CD68 File Offset: 0x0001AF68
			// (set) Token: 0x0600171A RID: 5914 RVA: 0x0001CD84 File Offset: 0x0001AF84
			public Vector3 position
			{
				get
				{
					return this.m_Position;
				}
				set
				{
					this.m_Position = value;
				}
			}

			// Token: 0x17000506 RID: 1286
			// (get) Token: 0x0600171B RID: 5915 RVA: 0x0001CD90 File Offset: 0x0001AF90
			// (set) Token: 0x0600171C RID: 5916 RVA: 0x0001CDAC File Offset: 0x0001AFAC
			public Vector3 velocity
			{
				get
				{
					return this.m_Velocity;
				}
				set
				{
					this.m_Velocity = value;
				}
			}

			// Token: 0x17000507 RID: 1287
			// (get) Token: 0x0600171D RID: 5917 RVA: 0x0001CDB8 File Offset: 0x0001AFB8
			// (set) Token: 0x0600171E RID: 5918 RVA: 0x0001CDD4 File Offset: 0x0001AFD4
			[Obsolete("Please use Particle.remainingLifetime instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/Particle.remainingLifetime")]
			public float lifetime
			{
				get
				{
					return this.m_Lifetime;
				}
				set
				{
					this.m_Lifetime = value;
				}
			}

			// Token: 0x17000508 RID: 1288
			// (get) Token: 0x0600171F RID: 5919 RVA: 0x0001CDE0 File Offset: 0x0001AFE0
			// (set) Token: 0x06001720 RID: 5920 RVA: 0x0001CDFC File Offset: 0x0001AFFC
			public float remainingLifetime
			{
				get
				{
					return this.m_Lifetime;
				}
				set
				{
					this.m_Lifetime = value;
				}
			}

			// Token: 0x17000509 RID: 1289
			// (get) Token: 0x06001721 RID: 5921 RVA: 0x0001CE08 File Offset: 0x0001B008
			// (set) Token: 0x06001722 RID: 5922 RVA: 0x0001CE24 File Offset: 0x0001B024
			public float startLifetime
			{
				get
				{
					return this.m_StartLifetime;
				}
				set
				{
					this.m_StartLifetime = value;
				}
			}

			// Token: 0x1700050A RID: 1290
			// (get) Token: 0x06001723 RID: 5923 RVA: 0x0001CE30 File Offset: 0x0001B030
			// (set) Token: 0x06001724 RID: 5924 RVA: 0x0001CE50 File Offset: 0x0001B050
			public float startSize
			{
				get
				{
					return this.m_StartSize.x;
				}
				set
				{
					this.m_StartSize = new Vector3(value, value, value);
				}
			}

			// Token: 0x1700050B RID: 1291
			// (get) Token: 0x06001725 RID: 5925 RVA: 0x0001CE64 File Offset: 0x0001B064
			// (set) Token: 0x06001726 RID: 5926 RVA: 0x0001CE80 File Offset: 0x0001B080
			public Vector3 startSize3D
			{
				get
				{
					return this.m_StartSize;
				}
				set
				{
					this.m_StartSize = value;
				}
			}

			// Token: 0x1700050C RID: 1292
			// (get) Token: 0x06001727 RID: 5927 RVA: 0x0001CE8C File Offset: 0x0001B08C
			// (set) Token: 0x06001728 RID: 5928 RVA: 0x0001CEA8 File Offset: 0x0001B0A8
			public Vector3 axisOfRotation
			{
				get
				{
					return this.m_AxisOfRotation;
				}
				set
				{
					this.m_AxisOfRotation = value;
				}
			}

			// Token: 0x1700050D RID: 1293
			// (get) Token: 0x06001729 RID: 5929 RVA: 0x0001CEB4 File Offset: 0x0001B0B4
			// (set) Token: 0x0600172A RID: 5930 RVA: 0x0001CEDC File Offset: 0x0001B0DC
			public float rotation
			{
				get
				{
					return this.m_Rotation.z * 57.29578f;
				}
				set
				{
					this.m_Rotation = new Vector3(0f, 0f, value * 0.017453292f);
				}
			}

			// Token: 0x1700050E RID: 1294
			// (get) Token: 0x0600172B RID: 5931 RVA: 0x0001CEFC File Offset: 0x0001B0FC
			// (set) Token: 0x0600172C RID: 5932 RVA: 0x0001CF24 File Offset: 0x0001B124
			public Vector3 rotation3D
			{
				get
				{
					return this.m_Rotation * 57.29578f;
				}
				set
				{
					this.m_Rotation = value * 0.017453292f;
				}
			}

			// Token: 0x1700050F RID: 1295
			// (get) Token: 0x0600172D RID: 5933 RVA: 0x0001CF38 File Offset: 0x0001B138
			// (set) Token: 0x0600172E RID: 5934 RVA: 0x0001CF60 File Offset: 0x0001B160
			public float angularVelocity
			{
				get
				{
					return this.m_AngularVelocity.z * 57.29578f;
				}
				set
				{
					this.m_AngularVelocity.z = value * 0.017453292f;
				}
			}

			// Token: 0x17000510 RID: 1296
			// (get) Token: 0x0600172F RID: 5935 RVA: 0x0001CF78 File Offset: 0x0001B178
			// (set) Token: 0x06001730 RID: 5936 RVA: 0x0001CFA0 File Offset: 0x0001B1A0
			public Vector3 angularVelocity3D
			{
				get
				{
					return this.m_AngularVelocity * 57.29578f;
				}
				set
				{
					this.m_AngularVelocity = value * 0.017453292f;
				}
			}

			// Token: 0x17000511 RID: 1297
			// (get) Token: 0x06001731 RID: 5937 RVA: 0x0001CFB4 File Offset: 0x0001B1B4
			// (set) Token: 0x06001732 RID: 5938 RVA: 0x0001CFD0 File Offset: 0x0001B1D0
			public Color32 startColor
			{
				get
				{
					return this.m_StartColor;
				}
				set
				{
					this.m_StartColor = value;
				}
			}

			// Token: 0x17000512 RID: 1298
			// (get) Token: 0x06001733 RID: 5939 RVA: 0x0001CFDC File Offset: 0x0001B1DC
			// (set) Token: 0x06001734 RID: 5940 RVA: 0x0001D004 File Offset: 0x0001B204
			[Obsolete("randomValue property is deprecated. Use randomSeed instead to control random behavior of particles.")]
			public float randomValue
			{
				get
				{
					return BitConverter.ToSingle(BitConverter.GetBytes(this.m_RandomSeed), 0);
				}
				set
				{
					this.m_RandomSeed = BitConverter.ToUInt32(BitConverter.GetBytes(value), 0);
				}
			}

			// Token: 0x17000513 RID: 1299
			// (get) Token: 0x06001735 RID: 5941 RVA: 0x0001D01C File Offset: 0x0001B21C
			// (set) Token: 0x06001736 RID: 5942 RVA: 0x0001D038 File Offset: 0x0001B238
			public uint randomSeed
			{
				get
				{
					return this.m_RandomSeed;
				}
				set
				{
					this.m_RandomSeed = value;
				}
			}

			// Token: 0x06001737 RID: 5943 RVA: 0x0001D044 File Offset: 0x0001B244
			public float GetCurrentSize(ParticleSystem system)
			{
				return ParticleSystem.Particle.GetCurrentSize(system, ref this);
			}

			// Token: 0x06001738 RID: 5944 RVA: 0x0001D060 File Offset: 0x0001B260
			public Vector3 GetCurrentSize3D(ParticleSystem system)
			{
				return ParticleSystem.Particle.GetCurrentSize3D(system, ref this);
			}

			// Token: 0x06001739 RID: 5945 RVA: 0x0001D07C File Offset: 0x0001B27C
			public Color32 GetCurrentColor(ParticleSystem system)
			{
				return ParticleSystem.Particle.GetCurrentColor(system, ref this);
			}

			// Token: 0x0600173A RID: 5946
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern float GetCurrentSize(ParticleSystem system, ref ParticleSystem.Particle particle);

			// Token: 0x0600173B RID: 5947 RVA: 0x0001D098 File Offset: 0x0001B298
			private static Vector3 GetCurrentSize3D(ParticleSystem system, ref ParticleSystem.Particle particle)
			{
				Vector3 result;
				ParticleSystem.Particle.INTERNAL_CALL_GetCurrentSize3D(system, ref particle, out result);
				return result;
			}

			// Token: 0x0600173C RID: 5948
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void INTERNAL_CALL_GetCurrentSize3D(ParticleSystem system, ref ParticleSystem.Particle particle, out Vector3 value);

			// Token: 0x0600173D RID: 5949 RVA: 0x0001D0B8 File Offset: 0x0001B2B8
			private static Color32 GetCurrentColor(ParticleSystem system, ref ParticleSystem.Particle particle)
			{
				Color32 result;
				ParticleSystem.Particle.INTERNAL_CALL_GetCurrentColor(system, ref particle, out result);
				return result;
			}

			// Token: 0x0600173E RID: 5950
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void INTERNAL_CALL_GetCurrentColor(ParticleSystem system, ref ParticleSystem.Particle particle, out Color32 value);

			// Token: 0x17000514 RID: 1300
			// (get) Token: 0x0600173F RID: 5951 RVA: 0x0001D0D8 File Offset: 0x0001B2D8
			// (set) Token: 0x06001740 RID: 5952 RVA: 0x0001D0F8 File Offset: 0x0001B2F8
			[Obsolete("size property is deprecated. Use startSize or GetCurrentSize() instead.")]
			public float size
			{
				get
				{
					return this.m_StartSize.x;
				}
				set
				{
					this.m_StartSize = new Vector3(value, value, value);
				}
			}

			// Token: 0x17000515 RID: 1301
			// (get) Token: 0x06001741 RID: 5953 RVA: 0x0001D10C File Offset: 0x0001B30C
			// (set) Token: 0x06001742 RID: 5954 RVA: 0x0001D128 File Offset: 0x0001B328
			[Obsolete("color property is deprecated. Use startColor or GetCurrentColor() instead.")]
			public Color32 color
			{
				get
				{
					return this.m_StartColor;
				}
				set
				{
					this.m_StartColor = value;
				}
			}

			// Token: 0x0400035F RID: 863
			private Vector3 m_Position;

			// Token: 0x04000360 RID: 864
			private Vector3 m_Velocity;

			// Token: 0x04000361 RID: 865
			private Vector3 m_AnimatedVelocity;

			// Token: 0x04000362 RID: 866
			private Vector3 m_InitialVelocity;

			// Token: 0x04000363 RID: 867
			private Vector3 m_AxisOfRotation;

			// Token: 0x04000364 RID: 868
			private Vector3 m_Rotation;

			// Token: 0x04000365 RID: 869
			private Vector3 m_AngularVelocity;

			// Token: 0x04000366 RID: 870
			private Vector3 m_StartSize;

			// Token: 0x04000367 RID: 871
			private Color32 m_StartColor;

			// Token: 0x04000368 RID: 872
			private uint m_RandomSeed;

			// Token: 0x04000369 RID: 873
			private float m_Lifetime;

			// Token: 0x0400036A RID: 874
			private float m_StartLifetime;

			// Token: 0x0400036B RID: 875
			private float m_EmitAccumulator0;

			// Token: 0x0400036C RID: 876
			private float m_EmitAccumulator1;
		}

		// Token: 0x02000140 RID: 320
		public struct EmitParams
		{
			// Token: 0x17000516 RID: 1302
			// (get) Token: 0x06001743 RID: 5955 RVA: 0x0001D134 File Offset: 0x0001B334
			// (set) Token: 0x06001744 RID: 5956 RVA: 0x0001D154 File Offset: 0x0001B354
			public Vector3 position
			{
				get
				{
					return this.m_Particle.position;
				}
				set
				{
					this.m_Particle.position = value;
					this.m_PositionSet = true;
				}
			}

			// Token: 0x17000517 RID: 1303
			// (get) Token: 0x06001745 RID: 5957 RVA: 0x0001D16C File Offset: 0x0001B36C
			// (set) Token: 0x06001746 RID: 5958 RVA: 0x0001D188 File Offset: 0x0001B388
			public bool applyShapeToPosition
			{
				get
				{
					return this.m_ApplyShapeToPosition;
				}
				set
				{
					this.m_ApplyShapeToPosition = value;
				}
			}

			// Token: 0x17000518 RID: 1304
			// (get) Token: 0x06001747 RID: 5959 RVA: 0x0001D194 File Offset: 0x0001B394
			// (set) Token: 0x06001748 RID: 5960 RVA: 0x0001D1B4 File Offset: 0x0001B3B4
			public Vector3 velocity
			{
				get
				{
					return this.m_Particle.velocity;
				}
				set
				{
					this.m_Particle.velocity = value;
					this.m_VelocitySet = true;
				}
			}

			// Token: 0x17000519 RID: 1305
			// (get) Token: 0x06001749 RID: 5961 RVA: 0x0001D1CC File Offset: 0x0001B3CC
			// (set) Token: 0x0600174A RID: 5962 RVA: 0x0001D1EC File Offset: 0x0001B3EC
			public float startLifetime
			{
				get
				{
					return this.m_Particle.startLifetime;
				}
				set
				{
					this.m_Particle.startLifetime = value;
					this.m_StartLifetimeSet = true;
				}
			}

			// Token: 0x1700051A RID: 1306
			// (get) Token: 0x0600174B RID: 5963 RVA: 0x0001D204 File Offset: 0x0001B404
			// (set) Token: 0x0600174C RID: 5964 RVA: 0x0001D224 File Offset: 0x0001B424
			public float startSize
			{
				get
				{
					return this.m_Particle.startSize;
				}
				set
				{
					this.m_Particle.startSize = value;
					this.m_StartSizeSet = true;
				}
			}

			// Token: 0x1700051B RID: 1307
			// (get) Token: 0x0600174D RID: 5965 RVA: 0x0001D23C File Offset: 0x0001B43C
			// (set) Token: 0x0600174E RID: 5966 RVA: 0x0001D25C File Offset: 0x0001B45C
			public Vector3 startSize3D
			{
				get
				{
					return this.m_Particle.startSize3D;
				}
				set
				{
					this.m_Particle.startSize3D = value;
					this.m_StartSizeSet = true;
				}
			}

			// Token: 0x1700051C RID: 1308
			// (get) Token: 0x0600174F RID: 5967 RVA: 0x0001D274 File Offset: 0x0001B474
			// (set) Token: 0x06001750 RID: 5968 RVA: 0x0001D294 File Offset: 0x0001B494
			public Vector3 axisOfRotation
			{
				get
				{
					return this.m_Particle.axisOfRotation;
				}
				set
				{
					this.m_Particle.axisOfRotation = value;
					this.m_AxisOfRotationSet = true;
				}
			}

			// Token: 0x1700051D RID: 1309
			// (get) Token: 0x06001751 RID: 5969 RVA: 0x0001D2AC File Offset: 0x0001B4AC
			// (set) Token: 0x06001752 RID: 5970 RVA: 0x0001D2CC File Offset: 0x0001B4CC
			public float rotation
			{
				get
				{
					return this.m_Particle.rotation;
				}
				set
				{
					this.m_Particle.rotation = value;
					this.m_RotationSet = true;
				}
			}

			// Token: 0x1700051E RID: 1310
			// (get) Token: 0x06001753 RID: 5971 RVA: 0x0001D2E4 File Offset: 0x0001B4E4
			// (set) Token: 0x06001754 RID: 5972 RVA: 0x0001D304 File Offset: 0x0001B504
			public Vector3 rotation3D
			{
				get
				{
					return this.m_Particle.rotation3D;
				}
				set
				{
					this.m_Particle.rotation3D = value;
					this.m_RotationSet = true;
				}
			}

			// Token: 0x1700051F RID: 1311
			// (get) Token: 0x06001755 RID: 5973 RVA: 0x0001D31C File Offset: 0x0001B51C
			// (set) Token: 0x06001756 RID: 5974 RVA: 0x0001D33C File Offset: 0x0001B53C
			public float angularVelocity
			{
				get
				{
					return this.m_Particle.angularVelocity;
				}
				set
				{
					this.m_Particle.angularVelocity = value;
					this.m_AngularVelocitySet = true;
				}
			}

			// Token: 0x17000520 RID: 1312
			// (get) Token: 0x06001757 RID: 5975 RVA: 0x0001D354 File Offset: 0x0001B554
			// (set) Token: 0x06001758 RID: 5976 RVA: 0x0001D374 File Offset: 0x0001B574
			public Vector3 angularVelocity3D
			{
				get
				{
					return this.m_Particle.angularVelocity3D;
				}
				set
				{
					this.m_Particle.angularVelocity3D = value;
					this.m_AngularVelocitySet = true;
				}
			}

			// Token: 0x17000521 RID: 1313
			// (get) Token: 0x06001759 RID: 5977 RVA: 0x0001D38C File Offset: 0x0001B58C
			// (set) Token: 0x0600175A RID: 5978 RVA: 0x0001D3AC File Offset: 0x0001B5AC
			public Color32 startColor
			{
				get
				{
					return this.m_Particle.startColor;
				}
				set
				{
					this.m_Particle.startColor = value;
					this.m_StartColorSet = true;
				}
			}

			// Token: 0x17000522 RID: 1314
			// (get) Token: 0x0600175B RID: 5979 RVA: 0x0001D3C4 File Offset: 0x0001B5C4
			// (set) Token: 0x0600175C RID: 5980 RVA: 0x0001D3E4 File Offset: 0x0001B5E4
			public uint randomSeed
			{
				get
				{
					return this.m_Particle.randomSeed;
				}
				set
				{
					this.m_Particle.randomSeed = value;
					this.m_RandomSeedSet = true;
				}
			}

			// Token: 0x0600175D RID: 5981 RVA: 0x0001D3FC File Offset: 0x0001B5FC
			public void ResetPosition()
			{
				this.m_PositionSet = false;
			}

			// Token: 0x0600175E RID: 5982 RVA: 0x0001D408 File Offset: 0x0001B608
			public void ResetVelocity()
			{
				this.m_VelocitySet = false;
			}

			// Token: 0x0600175F RID: 5983 RVA: 0x0001D414 File Offset: 0x0001B614
			public void ResetAxisOfRotation()
			{
				this.m_AxisOfRotationSet = false;
			}

			// Token: 0x06001760 RID: 5984 RVA: 0x0001D420 File Offset: 0x0001B620
			public void ResetRotation()
			{
				this.m_RotationSet = false;
			}

			// Token: 0x06001761 RID: 5985 RVA: 0x0001D42C File Offset: 0x0001B62C
			public void ResetAngularVelocity()
			{
				this.m_AngularVelocitySet = false;
			}

			// Token: 0x06001762 RID: 5986 RVA: 0x0001D438 File Offset: 0x0001B638
			public void ResetStartSize()
			{
				this.m_StartSizeSet = false;
			}

			// Token: 0x06001763 RID: 5987 RVA: 0x0001D444 File Offset: 0x0001B644
			public void ResetStartColor()
			{
				this.m_StartColorSet = false;
			}

			// Token: 0x06001764 RID: 5988 RVA: 0x0001D450 File Offset: 0x0001B650
			public void ResetRandomSeed()
			{
				this.m_RandomSeedSet = false;
			}

			// Token: 0x06001765 RID: 5989 RVA: 0x0001D45C File Offset: 0x0001B65C
			public void ResetStartLifetime()
			{
				this.m_StartLifetimeSet = false;
			}

			// Token: 0x0400036D RID: 877
			internal ParticleSystem.Particle m_Particle;

			// Token: 0x0400036E RID: 878
			internal bool m_PositionSet;

			// Token: 0x0400036F RID: 879
			internal bool m_VelocitySet;

			// Token: 0x04000370 RID: 880
			internal bool m_AxisOfRotationSet;

			// Token: 0x04000371 RID: 881
			internal bool m_RotationSet;

			// Token: 0x04000372 RID: 882
			internal bool m_AngularVelocitySet;

			// Token: 0x04000373 RID: 883
			internal bool m_StartSizeSet;

			// Token: 0x04000374 RID: 884
			internal bool m_StartColorSet;

			// Token: 0x04000375 RID: 885
			internal bool m_RandomSeedSet;

			// Token: 0x04000376 RID: 886
			internal bool m_StartLifetimeSet;

			// Token: 0x04000377 RID: 887
			internal bool m_ApplyShapeToPosition;
		}

		// Token: 0x02000141 RID: 321
		// (Invoke) Token: 0x06001767 RID: 5991
		internal delegate bool IteratorDelegate(ParticleSystem ps);
	}
}
