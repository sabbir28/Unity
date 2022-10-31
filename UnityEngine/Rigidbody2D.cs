using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000179 RID: 377
	[RequireComponent(typeof(Transform))]
	public sealed class Rigidbody2D : Component
	{
		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001C04 RID: 7172 RVA: 0x00023704 File Offset: 0x00021904
		// (set) Token: 0x06001C05 RID: 7173 RVA: 0x00023724 File Offset: 0x00021924
		public Vector2 position
		{
			get
			{
				Vector2 result;
				this.INTERNAL_get_position(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_position(ref value);
			}
		}

		// Token: 0x06001C06 RID: 7174
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_position(out Vector2 value);

		// Token: 0x06001C07 RID: 7175
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_position(ref Vector2 value);

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001C08 RID: 7176
		// (set) Token: 0x06001C09 RID: 7177
		public extern float rotation { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06001C0A RID: 7178 RVA: 0x00023730 File Offset: 0x00021930
		public void MovePosition(Vector2 position)
		{
			Rigidbody2D.INTERNAL_CALL_MovePosition(this, ref position);
		}

		// Token: 0x06001C0B RID: 7179
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_MovePosition(Rigidbody2D self, ref Vector2 position);

		// Token: 0x06001C0C RID: 7180 RVA: 0x0002373C File Offset: 0x0002193C
		public void MoveRotation(float angle)
		{
			Rigidbody2D.INTERNAL_CALL_MoveRotation(this, angle);
		}

		// Token: 0x06001C0D RID: 7181
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_MoveRotation(Rigidbody2D self, float angle);

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001C0E RID: 7182 RVA: 0x00023748 File Offset: 0x00021948
		// (set) Token: 0x06001C0F RID: 7183 RVA: 0x00023768 File Offset: 0x00021968
		public Vector2 velocity
		{
			get
			{
				Vector2 result;
				this.INTERNAL_get_velocity(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_velocity(ref value);
			}
		}

		// Token: 0x06001C10 RID: 7184
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_velocity(out Vector2 value);

		// Token: 0x06001C11 RID: 7185
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_velocity(ref Vector2 value);

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001C12 RID: 7186
		// (set) Token: 0x06001C13 RID: 7187
		public extern float angularVelocity { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001C14 RID: 7188
		// (set) Token: 0x06001C15 RID: 7189
		public extern bool useAutoMass { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001C16 RID: 7190
		// (set) Token: 0x06001C17 RID: 7191
		public extern float mass { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001C18 RID: 7192
		// (set) Token: 0x06001C19 RID: 7193
		public extern PhysicsMaterial2D sharedMaterial { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001C1A RID: 7194 RVA: 0x00023774 File Offset: 0x00021974
		// (set) Token: 0x06001C1B RID: 7195 RVA: 0x00023794 File Offset: 0x00021994
		public Vector2 centerOfMass
		{
			get
			{
				Vector2 result;
				this.INTERNAL_get_centerOfMass(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_centerOfMass(ref value);
			}
		}

		// Token: 0x06001C1C RID: 7196
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_centerOfMass(out Vector2 value);

		// Token: 0x06001C1D RID: 7197
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_centerOfMass(ref Vector2 value);

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001C1E RID: 7198 RVA: 0x000237A0 File Offset: 0x000219A0
		public Vector2 worldCenterOfMass
		{
			get
			{
				Vector2 result;
				this.INTERNAL_get_worldCenterOfMass(out result);
				return result;
			}
		}

		// Token: 0x06001C1F RID: 7199
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_worldCenterOfMass(out Vector2 value);

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001C20 RID: 7200
		// (set) Token: 0x06001C21 RID: 7201
		public extern float inertia { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001C22 RID: 7202
		// (set) Token: 0x06001C23 RID: 7203
		public extern float drag { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001C24 RID: 7204
		// (set) Token: 0x06001C25 RID: 7205
		public extern float angularDrag { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001C26 RID: 7206
		// (set) Token: 0x06001C27 RID: 7207
		public extern float gravityScale { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001C28 RID: 7208
		// (set) Token: 0x06001C29 RID: 7209
		public extern RigidbodyType2D bodyType { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06001C2A RID: 7210
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetDragBehaviour(bool dragged);

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001C2B RID: 7211
		// (set) Token: 0x06001C2C RID: 7212
		public extern bool useFullKinematicContacts { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001C2D RID: 7213 RVA: 0x000237C0 File Offset: 0x000219C0
		// (set) Token: 0x06001C2E RID: 7214 RVA: 0x000237E0 File Offset: 0x000219E0
		public bool isKinematic
		{
			get
			{
				return this.bodyType == RigidbodyType2D.Kinematic;
			}
			set
			{
				this.bodyType = ((!value) ? RigidbodyType2D.Dynamic : RigidbodyType2D.Kinematic);
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001C2F RID: 7215
		// (set) Token: 0x06001C30 RID: 7216
		[Obsolete("The fixedAngle is no longer supported. Use constraints instead.")]
		public extern bool fixedAngle { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001C31 RID: 7217
		// (set) Token: 0x06001C32 RID: 7218
		public extern bool freezeRotation { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001C33 RID: 7219
		// (set) Token: 0x06001C34 RID: 7220
		public extern RigidbodyConstraints2D constraints { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06001C35 RID: 7221
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsSleeping();

		// Token: 0x06001C36 RID: 7222
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsAwake();

		// Token: 0x06001C37 RID: 7223
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Sleep();

		// Token: 0x06001C38 RID: 7224
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void WakeUp();

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001C39 RID: 7225
		// (set) Token: 0x06001C3A RID: 7226
		public extern bool simulated { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001C3B RID: 7227
		// (set) Token: 0x06001C3C RID: 7228
		public extern RigidbodyInterpolation2D interpolation { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001C3D RID: 7229
		// (set) Token: 0x06001C3E RID: 7230
		public extern RigidbodySleepMode2D sleepMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001C3F RID: 7231
		// (set) Token: 0x06001C40 RID: 7232
		public extern CollisionDetectionMode2D collisionDetectionMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001C41 RID: 7233
		public extern int attachedColliderCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06001C42 RID: 7234
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetAttachedColliders(Collider2D[] results);

		// Token: 0x06001C43 RID: 7235
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsTouching(Collider2D collider);

		// Token: 0x06001C44 RID: 7236 RVA: 0x000237F8 File Offset: 0x000219F8
		public bool IsTouching(Collider2D collider, ContactFilter2D contactFilter)
		{
			return this.Internal_IsTouching(collider, contactFilter);
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x00023818 File Offset: 0x00021A18
		private bool Internal_IsTouching(Collider2D collider, ContactFilter2D contactFilter)
		{
			return Rigidbody2D.INTERNAL_CALL_Internal_IsTouching(this, collider, ref contactFilter);
		}

		// Token: 0x06001C46 RID: 7238
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Internal_IsTouching(Rigidbody2D self, Collider2D collider, ref ContactFilter2D contactFilter);

		// Token: 0x06001C47 RID: 7239 RVA: 0x00023838 File Offset: 0x00021A38
		public bool IsTouching(ContactFilter2D contactFilter)
		{
			return Rigidbody2D.INTERNAL_CALL_IsTouching(this, ref contactFilter);
		}

		// Token: 0x06001C48 RID: 7240
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_IsTouching(Rigidbody2D self, ref ContactFilter2D contactFilter);

		// Token: 0x06001C49 RID: 7241
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsTouchingLayers([DefaultValue("Physics2D.AllLayers")] int layerMask);

		// Token: 0x06001C4A RID: 7242 RVA: 0x00023858 File Offset: 0x00021A58
		[ExcludeFromDocs]
		public bool IsTouchingLayers()
		{
			int layerMask = -1;
			return this.IsTouchingLayers(layerMask);
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x00023878 File Offset: 0x00021A78
		public bool OverlapPoint(Vector2 point)
		{
			return Rigidbody2D.INTERNAL_CALL_OverlapPoint(this, ref point);
		}

		// Token: 0x06001C4C RID: 7244
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_OverlapPoint(Rigidbody2D self, ref Vector2 point);

		// Token: 0x06001C4D RID: 7245 RVA: 0x00023898 File Offset: 0x00021A98
		public int OverlapCollider(ContactFilter2D contactFilter, Collider2D[] results)
		{
			return Rigidbody2D.INTERNAL_CALL_OverlapCollider(this, ref contactFilter, results);
		}

		// Token: 0x06001C4E RID: 7246
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_OverlapCollider(Rigidbody2D self, ref ContactFilter2D contactFilter, Collider2D[] results);

		// Token: 0x06001C4F RID: 7247 RVA: 0x000238B8 File Offset: 0x00021AB8
		public int Cast(Vector2 direction, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance)
		{
			return Rigidbody2D.INTERNAL_CALL_Cast(this, ref direction, results, distance);
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x000238D8 File Offset: 0x00021AD8
		[ExcludeFromDocs]
		public int Cast(Vector2 direction, RaycastHit2D[] results)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Rigidbody2D.INTERNAL_CALL_Cast(this, ref direction, results, positiveInfinity);
		}

		// Token: 0x06001C51 RID: 7249
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_Cast(Rigidbody2D self, ref Vector2 direction, RaycastHit2D[] results, float distance);

		// Token: 0x06001C52 RID: 7250 RVA: 0x00023900 File Offset: 0x00021B00
		[ExcludeFromDocs]
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results)
		{
			float positiveInfinity = float.PositiveInfinity;
			return this.Cast(direction, contactFilter, results, positiveInfinity);
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x00023928 File Offset: 0x00021B28
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance)
		{
			return this.Internal_Cast(direction, distance, contactFilter, results);
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x00023948 File Offset: 0x00021B48
		private int Internal_Cast(Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results)
		{
			return Rigidbody2D.INTERNAL_CALL_Internal_Cast(this, ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x06001C55 RID: 7253
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_Internal_Cast(Rigidbody2D self, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results);

		// Token: 0x06001C56 RID: 7254
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern ColliderDistance2D Distance(Collider2D collider);

		// Token: 0x06001C57 RID: 7255 RVA: 0x0002396C File Offset: 0x00021B6C
		public void AddForce(Vector2 force, [DefaultValue("ForceMode2D.Force")] ForceMode2D mode)
		{
			Rigidbody2D.INTERNAL_CALL_AddForce(this, ref force, mode);
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x00023978 File Offset: 0x00021B78
		[ExcludeFromDocs]
		public void AddForce(Vector2 force)
		{
			ForceMode2D mode = ForceMode2D.Force;
			Rigidbody2D.INTERNAL_CALL_AddForce(this, ref force, mode);
		}

		// Token: 0x06001C59 RID: 7257
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AddForce(Rigidbody2D self, ref Vector2 force, ForceMode2D mode);

		// Token: 0x06001C5A RID: 7258 RVA: 0x00023994 File Offset: 0x00021B94
		public void AddRelativeForce(Vector2 relativeForce, [DefaultValue("ForceMode2D.Force")] ForceMode2D mode)
		{
			Rigidbody2D.INTERNAL_CALL_AddRelativeForce(this, ref relativeForce, mode);
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x000239A0 File Offset: 0x00021BA0
		[ExcludeFromDocs]
		public void AddRelativeForce(Vector2 relativeForce)
		{
			ForceMode2D mode = ForceMode2D.Force;
			Rigidbody2D.INTERNAL_CALL_AddRelativeForce(this, ref relativeForce, mode);
		}

		// Token: 0x06001C5C RID: 7260
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AddRelativeForce(Rigidbody2D self, ref Vector2 relativeForce, ForceMode2D mode);

		// Token: 0x06001C5D RID: 7261 RVA: 0x000239BC File Offset: 0x00021BBC
		public void AddForceAtPosition(Vector2 force, Vector2 position, [DefaultValue("ForceMode2D.Force")] ForceMode2D mode)
		{
			Rigidbody2D.INTERNAL_CALL_AddForceAtPosition(this, ref force, ref position, mode);
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x000239CC File Offset: 0x00021BCC
		[ExcludeFromDocs]
		public void AddForceAtPosition(Vector2 force, Vector2 position)
		{
			ForceMode2D mode = ForceMode2D.Force;
			Rigidbody2D.INTERNAL_CALL_AddForceAtPosition(this, ref force, ref position, mode);
		}

		// Token: 0x06001C5F RID: 7263
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AddForceAtPosition(Rigidbody2D self, ref Vector2 force, ref Vector2 position, ForceMode2D mode);

		// Token: 0x06001C60 RID: 7264
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void AddTorque(float torque, [DefaultValue("ForceMode2D.Force")] ForceMode2D mode);

		// Token: 0x06001C61 RID: 7265 RVA: 0x000239E8 File Offset: 0x00021BE8
		[ExcludeFromDocs]
		public void AddTorque(float torque)
		{
			ForceMode2D mode = ForceMode2D.Force;
			this.AddTorque(torque, mode);
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x00023A00 File Offset: 0x00021C00
		public Vector2 GetPoint(Vector2 point)
		{
			Vector2 result;
			Rigidbody2D.Internal_GetPoint(this, point, out result);
			return result;
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x00023A20 File Offset: 0x00021C20
		private static void Internal_GetPoint(Rigidbody2D rigidbody, Vector2 point, out Vector2 value)
		{
			Rigidbody2D.INTERNAL_CALL_Internal_GetPoint(rigidbody, ref point, out value);
		}

		// Token: 0x06001C64 RID: 7268
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_GetPoint(Rigidbody2D rigidbody, ref Vector2 point, out Vector2 value);

		// Token: 0x06001C65 RID: 7269 RVA: 0x00023A2C File Offset: 0x00021C2C
		public Vector2 GetRelativePoint(Vector2 relativePoint)
		{
			Vector2 result;
			Rigidbody2D.Internal_GetRelativePoint(this, relativePoint, out result);
			return result;
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x00023A4C File Offset: 0x00021C4C
		private static void Internal_GetRelativePoint(Rigidbody2D rigidbody, Vector2 relativePoint, out Vector2 value)
		{
			Rigidbody2D.INTERNAL_CALL_Internal_GetRelativePoint(rigidbody, ref relativePoint, out value);
		}

		// Token: 0x06001C67 RID: 7271
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_GetRelativePoint(Rigidbody2D rigidbody, ref Vector2 relativePoint, out Vector2 value);

		// Token: 0x06001C68 RID: 7272 RVA: 0x00023A58 File Offset: 0x00021C58
		public Vector2 GetVector(Vector2 vector)
		{
			Vector2 result;
			Rigidbody2D.Internal_GetVector(this, vector, out result);
			return result;
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x00023A78 File Offset: 0x00021C78
		private static void Internal_GetVector(Rigidbody2D rigidbody, Vector2 vector, out Vector2 value)
		{
			Rigidbody2D.INTERNAL_CALL_Internal_GetVector(rigidbody, ref vector, out value);
		}

		// Token: 0x06001C6A RID: 7274
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_GetVector(Rigidbody2D rigidbody, ref Vector2 vector, out Vector2 value);

		// Token: 0x06001C6B RID: 7275 RVA: 0x00023A84 File Offset: 0x00021C84
		public Vector2 GetRelativeVector(Vector2 relativeVector)
		{
			Vector2 result;
			Rigidbody2D.Internal_GetRelativeVector(this, relativeVector, out result);
			return result;
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x00023AA4 File Offset: 0x00021CA4
		private static void Internal_GetRelativeVector(Rigidbody2D rigidbody, Vector2 relativeVector, out Vector2 value)
		{
			Rigidbody2D.INTERNAL_CALL_Internal_GetRelativeVector(rigidbody, ref relativeVector, out value);
		}

		// Token: 0x06001C6D RID: 7277
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_GetRelativeVector(Rigidbody2D rigidbody, ref Vector2 relativeVector, out Vector2 value);

		// Token: 0x06001C6E RID: 7278 RVA: 0x00023AB0 File Offset: 0x00021CB0
		public Vector2 GetPointVelocity(Vector2 point)
		{
			Vector2 result;
			Rigidbody2D.Internal_GetPointVelocity(this, point, out result);
			return result;
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x00023AD0 File Offset: 0x00021CD0
		private static void Internal_GetPointVelocity(Rigidbody2D rigidbody, Vector2 point, out Vector2 value)
		{
			Rigidbody2D.INTERNAL_CALL_Internal_GetPointVelocity(rigidbody, ref point, out value);
		}

		// Token: 0x06001C70 RID: 7280
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_GetPointVelocity(Rigidbody2D rigidbody, ref Vector2 point, out Vector2 value);

		// Token: 0x06001C71 RID: 7281 RVA: 0x00023ADC File Offset: 0x00021CDC
		public Vector2 GetRelativePointVelocity(Vector2 relativePoint)
		{
			Vector2 result;
			Rigidbody2D.Internal_GetRelativePointVelocity(this, relativePoint, out result);
			return result;
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x00023AFC File Offset: 0x00021CFC
		private static void Internal_GetRelativePointVelocity(Rigidbody2D rigidbody, Vector2 relativePoint, out Vector2 value)
		{
			Rigidbody2D.INTERNAL_CALL_Internal_GetRelativePointVelocity(rigidbody, ref relativePoint, out value);
		}

		// Token: 0x06001C73 RID: 7283
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_GetRelativePointVelocity(Rigidbody2D rigidbody, ref Vector2 relativePoint, out Vector2 value);

		// Token: 0x06001C74 RID: 7284 RVA: 0x00023B08 File Offset: 0x00021D08
		public int GetContacts(ContactPoint2D[] contacts)
		{
			return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), contacts);
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x00023B34 File Offset: 0x00021D34
		public int GetContacts(ContactFilter2D contactFilter, ContactPoint2D[] contacts)
		{
			return Physics2D.GetContacts(this, contactFilter, contacts);
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x00023B54 File Offset: 0x00021D54
		public int GetContacts(Collider2D[] colliders)
		{
			return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), colliders);
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x00023B80 File Offset: 0x00021D80
		public int GetContacts(ContactFilter2D contactFilter, Collider2D[] colliders)
		{
			return Physics2D.GetContacts(this, contactFilter, colliders);
		}
	}
}
