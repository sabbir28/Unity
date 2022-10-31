using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000147 RID: 327
	internal sealed class ParticleSystemExtensionsImpl
	{
		// Token: 0x060017A3 RID: 6051
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetSafeCollisionEventSize(ParticleSystem ps);

		// Token: 0x060017A4 RID: 6052
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetCollisionEventsDeprecated(ParticleSystem ps, GameObject go, ParticleCollisionEvent[] collisionEvents);

		// Token: 0x060017A5 RID: 6053
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetSafeTriggerParticlesSize(ParticleSystem ps, int type);

		// Token: 0x060017A6 RID: 6054
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetCollisionEvents(ParticleSystem ps, GameObject go, object collisionEvents);

		// Token: 0x060017A7 RID: 6055
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetTriggerParticles(ParticleSystem ps, int type, object particles);

		// Token: 0x060017A8 RID: 6056
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void SetTriggerParticles(ParticleSystem ps, int type, object particles, int offset, int count);
	}
}
