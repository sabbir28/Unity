using System;
using System.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000148 RID: 328
	public static class ParticlePhysicsExtensions
	{
		// Token: 0x060017A9 RID: 6057 RVA: 0x0001DB10 File Offset: 0x0001BD10
		public static int GetSafeCollisionEventSize(this ParticleSystem ps)
		{
			return ParticleSystemExtensionsImpl.GetSafeCollisionEventSize(ps);
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x0001DB2C File Offset: 0x0001BD2C
		public static int GetCollisionEvents(this ParticleSystem ps, GameObject go, List<ParticleCollisionEvent> collisionEvents)
		{
			if (go == null)
			{
				throw new ArgumentNullException("go");
			}
			if (collisionEvents == null)
			{
				throw new ArgumentNullException("collisionEvents");
			}
			return ParticleSystemExtensionsImpl.GetCollisionEvents(ps, go, collisionEvents);
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x0001DB74 File Offset: 0x0001BD74
		[Obsolete("GetCollisionEvents function using ParticleCollisionEvent[] is deprecated. Use List<ParticleCollisionEvent> instead.", false)]
		public static int GetCollisionEvents(this ParticleSystem ps, GameObject go, ParticleCollisionEvent[] collisionEvents)
		{
			if (go == null)
			{
				throw new ArgumentNullException("go");
			}
			if (collisionEvents == null)
			{
				throw new ArgumentNullException("collisionEvents");
			}
			return ParticleSystemExtensionsImpl.GetCollisionEventsDeprecated(ps, go, collisionEvents);
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x0001DBBC File Offset: 0x0001BDBC
		public static int GetSafeTriggerParticlesSize(this ParticleSystem ps, ParticleSystemTriggerEventType type)
		{
			return ParticleSystemExtensionsImpl.GetSafeTriggerParticlesSize(ps, (int)type);
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x0001DBD8 File Offset: 0x0001BDD8
		public static int GetTriggerParticles(this ParticleSystem ps, ParticleSystemTriggerEventType type, List<ParticleSystem.Particle> particles)
		{
			if (particles == null)
			{
				throw new ArgumentNullException("particles");
			}
			return ParticleSystemExtensionsImpl.GetTriggerParticles(ps, (int)type, particles);
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x0001DC08 File Offset: 0x0001BE08
		public static void SetTriggerParticles(this ParticleSystem ps, ParticleSystemTriggerEventType type, List<ParticleSystem.Particle> particles, int offset, int count)
		{
			if (particles == null)
			{
				throw new ArgumentNullException("particles");
			}
			if (offset >= particles.Count)
			{
				throw new ArgumentOutOfRangeException("offset", "offset should be smaller than the size of the particles list.");
			}
			if (offset + count >= particles.Count)
			{
				throw new ArgumentOutOfRangeException("count", "offset+count should be smaller than the size of the particles list.");
			}
			ParticleSystemExtensionsImpl.SetTriggerParticles(ps, (int)type, particles, offset, count);
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x0001DC70 File Offset: 0x0001BE70
		public static void SetTriggerParticles(this ParticleSystem ps, ParticleSystemTriggerEventType type, List<ParticleSystem.Particle> particles)
		{
			if (particles == null)
			{
				throw new ArgumentNullException("particles");
			}
			ParticleSystemExtensionsImpl.SetTriggerParticles(ps, (int)type, particles, 0, particles.Count);
		}
	}
}
