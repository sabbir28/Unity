using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200017A RID: 378
	[RequireComponent(typeof(Transform))]
	public class Collider2D : Behaviour
	{
		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001C79 RID: 7289
		// (set) Token: 0x06001C7A RID: 7290
		public extern float density { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001C7B RID: 7291
		// (set) Token: 0x06001C7C RID: 7292
		public extern bool isTrigger { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001C7D RID: 7293
		// (set) Token: 0x06001C7E RID: 7294
		public extern bool usedByEffector { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001C7F RID: 7295
		// (set) Token: 0x06001C80 RID: 7296
		public extern bool usedByComposite { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001C81 RID: 7297
		public extern CompositeCollider2D composite { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001C82 RID: 7298 RVA: 0x00023BA8 File Offset: 0x00021DA8
		// (set) Token: 0x06001C83 RID: 7299 RVA: 0x00023BC8 File Offset: 0x00021DC8
		public Vector2 offset
		{
			get
			{
				Vector2 result;
				this.INTERNAL_get_offset(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_offset(ref value);
			}
		}

		// Token: 0x06001C84 RID: 7300
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_offset(out Vector2 value);

		// Token: 0x06001C85 RID: 7301
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_offset(ref Vector2 value);

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001C86 RID: 7302
		public extern Rigidbody2D attachedRigidbody { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001C87 RID: 7303
		public extern int shapeCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001C88 RID: 7304 RVA: 0x00023BD4 File Offset: 0x00021DD4
		public Bounds bounds
		{
			get
			{
				Bounds result;
				this.INTERNAL_get_bounds(out result);
				return result;
			}
		}

		// Token: 0x06001C89 RID: 7305
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_bounds(out Bounds value);

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001C8A RID: 7306
		internal extern ColliderErrorState2D errorState { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001C8B RID: 7307
		internal extern bool compositeCapable { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001C8C RID: 7308
		// (set) Token: 0x06001C8D RID: 7309
		public extern PhysicsMaterial2D sharedMaterial { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001C8E RID: 7310
		public extern float friction { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001C8F RID: 7311
		public extern float bounciness { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06001C90 RID: 7312
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsTouching(Collider2D collider);

		// Token: 0x06001C91 RID: 7313 RVA: 0x00023BF4 File Offset: 0x00021DF4
		public bool IsTouching(Collider2D collider, ContactFilter2D contactFilter)
		{
			return this.Internal_IsTouching(collider, contactFilter);
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x00023C14 File Offset: 0x00021E14
		private bool Internal_IsTouching(Collider2D collider, ContactFilter2D contactFilter)
		{
			return Collider2D.INTERNAL_CALL_Internal_IsTouching(this, collider, ref contactFilter);
		}

		// Token: 0x06001C93 RID: 7315
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Internal_IsTouching(Collider2D self, Collider2D collider, ref ContactFilter2D contactFilter);

		// Token: 0x06001C94 RID: 7316 RVA: 0x00023C34 File Offset: 0x00021E34
		public bool IsTouching(ContactFilter2D contactFilter)
		{
			return Collider2D.INTERNAL_CALL_IsTouching(this, ref contactFilter);
		}

		// Token: 0x06001C95 RID: 7317
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_IsTouching(Collider2D self, ref ContactFilter2D contactFilter);

		// Token: 0x06001C96 RID: 7318
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsTouchingLayers([DefaultValue("Physics2D.AllLayers")] int layerMask);

		// Token: 0x06001C97 RID: 7319 RVA: 0x00023C54 File Offset: 0x00021E54
		[ExcludeFromDocs]
		public bool IsTouchingLayers()
		{
			int layerMask = -1;
			return this.IsTouchingLayers(layerMask);
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x00023C74 File Offset: 0x00021E74
		public bool OverlapPoint(Vector2 point)
		{
			return Collider2D.INTERNAL_CALL_OverlapPoint(this, ref point);
		}

		// Token: 0x06001C99 RID: 7321
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_OverlapPoint(Collider2D self, ref Vector2 point);

		// Token: 0x06001C9A RID: 7322 RVA: 0x00023C94 File Offset: 0x00021E94
		public int OverlapCollider(ContactFilter2D contactFilter, Collider2D[] results)
		{
			return Physics2D.OverlapCollider(this, contactFilter, results);
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x00023CB4 File Offset: 0x00021EB4
		[ExcludeFromDocs]
		public int Raycast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results)
		{
			float positiveInfinity = float.PositiveInfinity;
			return this.Raycast(direction, contactFilter, results, positiveInfinity);
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x00023CDC File Offset: 0x00021EDC
		public int Raycast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance)
		{
			return this.Internal_Raycast(direction, distance, contactFilter, results);
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x00023CFC File Offset: 0x00021EFC
		[ExcludeFromDocs]
		public int Raycast(Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return this.Raycast(direction, results, distance, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x00023D28 File Offset: 0x00021F28
		[ExcludeFromDocs]
		public int Raycast(Vector2 direction, RaycastHit2D[] results, float distance, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return this.Raycast(direction, results, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x00023D58 File Offset: 0x00021F58
		[ExcludeFromDocs]
		public int Raycast(Vector2 direction, RaycastHit2D[] results, float distance)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -1;
			return this.Raycast(direction, results, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x00023D88 File Offset: 0x00021F88
		[ExcludeFromDocs]
		public int Raycast(Vector2 direction, RaycastHit2D[] results)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -1;
			float positiveInfinity2 = float.PositiveInfinity;
			return this.Raycast(direction, results, positiveInfinity2, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x00023DC0 File Offset: 0x00021FC0
		public int Raycast(Vector2 direction, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("Physics2D.AllLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return this.Internal_Raycast(direction, distance, contactFilter, results);
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x00023DEC File Offset: 0x00021FEC
		private int Internal_Raycast(Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results)
		{
			return Collider2D.INTERNAL_CALL_Internal_Raycast(this, ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x06001CA3 RID: 7331
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_Internal_Raycast(Collider2D self, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results);

		// Token: 0x06001CA4 RID: 7332 RVA: 0x00023E10 File Offset: 0x00022010
		[ExcludeFromDocs]
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance)
		{
			bool ignoreSiblingColliders = true;
			return this.Cast(direction, contactFilter, results, distance, ignoreSiblingColliders);
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x00023E34 File Offset: 0x00022034
		[ExcludeFromDocs]
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results)
		{
			bool ignoreSiblingColliders = true;
			float positiveInfinity = float.PositiveInfinity;
			return this.Cast(direction, contactFilter, results, positiveInfinity, ignoreSiblingColliders);
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x00023E5C File Offset: 0x0002205C
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("true")] bool ignoreSiblingColliders)
		{
			return this.Internal_Cast(direction, contactFilter, distance, ignoreSiblingColliders, results);
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x00023E80 File Offset: 0x00022080
		[ExcludeFromDocs]
		public int Cast(Vector2 direction, RaycastHit2D[] results, float distance)
		{
			bool ignoreSiblingColliders = true;
			return this.Cast(direction, results, distance, ignoreSiblingColliders);
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x00023EA4 File Offset: 0x000220A4
		[ExcludeFromDocs]
		public int Cast(Vector2 direction, RaycastHit2D[] results)
		{
			bool ignoreSiblingColliders = true;
			float positiveInfinity = float.PositiveInfinity;
			return this.Cast(direction, results, positiveInfinity, ignoreSiblingColliders);
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x00023ECC File Offset: 0x000220CC
		public int Cast(Vector2 direction, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("true")] bool ignoreSiblingColliders)
		{
			ContactFilter2D contactFilter = default(ContactFilter2D);
			contactFilter.useTriggers = Physics2D.queriesHitTriggers;
			contactFilter.SetLayerMask(Physics2D.GetLayerCollisionMask(base.gameObject.layer));
			return this.Internal_Cast(direction, contactFilter, distance, ignoreSiblingColliders, results);
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x00023F20 File Offset: 0x00022120
		private int Internal_Cast(Vector2 direction, ContactFilter2D contactFilter, float distance, bool ignoreSiblingColliders, RaycastHit2D[] results)
		{
			return Collider2D.INTERNAL_CALL_Internal_Cast(this, ref direction, ref contactFilter, distance, ignoreSiblingColliders, results);
		}

		// Token: 0x06001CAB RID: 7339
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_Internal_Cast(Collider2D self, ref Vector2 direction, ref ContactFilter2D contactFilter, float distance, bool ignoreSiblingColliders, RaycastHit2D[] results);

		// Token: 0x06001CAC RID: 7340 RVA: 0x00023F44 File Offset: 0x00022144
		public int GetContacts(ContactPoint2D[] contacts)
		{
			return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), contacts);
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x00023F70 File Offset: 0x00022170
		public int GetContacts(ContactFilter2D contactFilter, ContactPoint2D[] contacts)
		{
			return Physics2D.GetContacts(this, contactFilter, contacts);
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x00023F90 File Offset: 0x00022190
		public int GetContacts(Collider2D[] colliders)
		{
			return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), colliders);
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x00023FBC File Offset: 0x000221BC
		public int GetContacts(ContactFilter2D contactFilter, Collider2D[] colliders)
		{
			return Physics2D.GetContacts(this, contactFilter, colliders);
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x00023FDC File Offset: 0x000221DC
		public ColliderDistance2D Distance(Collider2D collider)
		{
			return Physics2D.Distance(this, collider);
		}
	}
}
