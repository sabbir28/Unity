using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200015C RID: 348
	[RequireComponent(typeof(Transform))]
	public sealed class Rigidbody : Component
	{
		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x060018C8 RID: 6344 RVA: 0x0001FB00 File Offset: 0x0001DD00
		// (set) Token: 0x060018C9 RID: 6345 RVA: 0x0001FB20 File Offset: 0x0001DD20
		public Vector3 velocity
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_velocity(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_velocity(ref value);
			}
		}

		// Token: 0x060018CA RID: 6346
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_velocity(out Vector3 value);

		// Token: 0x060018CB RID: 6347
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_velocity(ref Vector3 value);

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x060018CC RID: 6348 RVA: 0x0001FB2C File Offset: 0x0001DD2C
		// (set) Token: 0x060018CD RID: 6349 RVA: 0x0001FB4C File Offset: 0x0001DD4C
		public Vector3 angularVelocity
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_angularVelocity(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_angularVelocity(ref value);
			}
		}

		// Token: 0x060018CE RID: 6350
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_angularVelocity(out Vector3 value);

		// Token: 0x060018CF RID: 6351
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_angularVelocity(ref Vector3 value);

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x060018D0 RID: 6352
		// (set) Token: 0x060018D1 RID: 6353
		public extern float drag { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x060018D2 RID: 6354
		// (set) Token: 0x060018D3 RID: 6355
		public extern float angularDrag { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x060018D4 RID: 6356
		// (set) Token: 0x060018D5 RID: 6357
		public extern float mass { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060018D6 RID: 6358 RVA: 0x0001FB58 File Offset: 0x0001DD58
		public void SetDensity(float density)
		{
			Rigidbody.INTERNAL_CALL_SetDensity(this, density);
		}

		// Token: 0x060018D7 RID: 6359
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetDensity(Rigidbody self, float density);

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x060018D8 RID: 6360
		// (set) Token: 0x060018D9 RID: 6361
		public extern bool useGravity { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x060018DA RID: 6362
		// (set) Token: 0x060018DB RID: 6363
		public extern float maxDepenetrationVelocity { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x060018DC RID: 6364
		// (set) Token: 0x060018DD RID: 6365
		public extern bool isKinematic { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060018DE RID: 6366
		// (set) Token: 0x060018DF RID: 6367
		public extern bool freezeRotation { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x060018E0 RID: 6368
		// (set) Token: 0x060018E1 RID: 6369
		public extern RigidbodyConstraints constraints { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x060018E2 RID: 6370
		// (set) Token: 0x060018E3 RID: 6371
		public extern CollisionDetectionMode collisionDetectionMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060018E4 RID: 6372 RVA: 0x0001FB64 File Offset: 0x0001DD64
		public void AddForce(Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
			Rigidbody.INTERNAL_CALL_AddForce(this, ref force, mode);
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x0001FB70 File Offset: 0x0001DD70
		[ExcludeFromDocs]
		public void AddForce(Vector3 force)
		{
			ForceMode mode = ForceMode.Force;
			Rigidbody.INTERNAL_CALL_AddForce(this, ref force, mode);
		}

		// Token: 0x060018E6 RID: 6374
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AddForce(Rigidbody self, ref Vector3 force, ForceMode mode);

		// Token: 0x060018E7 RID: 6375 RVA: 0x0001FB8C File Offset: 0x0001DD8C
		[ExcludeFromDocs]
		public void AddForce(float x, float y, float z)
		{
			ForceMode mode = ForceMode.Force;
			this.AddForce(x, y, z, mode);
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x0001FBA8 File Offset: 0x0001DDA8
		public void AddForce(float x, float y, float z, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
			this.AddForce(new Vector3(x, y, z), mode);
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x0001FBBC File Offset: 0x0001DDBC
		public void AddRelativeForce(Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
			Rigidbody.INTERNAL_CALL_AddRelativeForce(this, ref force, mode);
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x0001FBC8 File Offset: 0x0001DDC8
		[ExcludeFromDocs]
		public void AddRelativeForce(Vector3 force)
		{
			ForceMode mode = ForceMode.Force;
			Rigidbody.INTERNAL_CALL_AddRelativeForce(this, ref force, mode);
		}

		// Token: 0x060018EB RID: 6379
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AddRelativeForce(Rigidbody self, ref Vector3 force, ForceMode mode);

		// Token: 0x060018EC RID: 6380 RVA: 0x0001FBE4 File Offset: 0x0001DDE4
		[ExcludeFromDocs]
		public void AddRelativeForce(float x, float y, float z)
		{
			ForceMode mode = ForceMode.Force;
			this.AddRelativeForce(x, y, z, mode);
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x0001FC00 File Offset: 0x0001DE00
		public void AddRelativeForce(float x, float y, float z, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
			this.AddRelativeForce(new Vector3(x, y, z), mode);
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x0001FC14 File Offset: 0x0001DE14
		public void AddTorque(Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
			Rigidbody.INTERNAL_CALL_AddTorque(this, ref torque, mode);
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x0001FC20 File Offset: 0x0001DE20
		[ExcludeFromDocs]
		public void AddTorque(Vector3 torque)
		{
			ForceMode mode = ForceMode.Force;
			Rigidbody.INTERNAL_CALL_AddTorque(this, ref torque, mode);
		}

		// Token: 0x060018F0 RID: 6384
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AddTorque(Rigidbody self, ref Vector3 torque, ForceMode mode);

		// Token: 0x060018F1 RID: 6385 RVA: 0x0001FC3C File Offset: 0x0001DE3C
		[ExcludeFromDocs]
		public void AddTorque(float x, float y, float z)
		{
			ForceMode mode = ForceMode.Force;
			this.AddTorque(x, y, z, mode);
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x0001FC58 File Offset: 0x0001DE58
		public void AddTorque(float x, float y, float z, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
			this.AddTorque(new Vector3(x, y, z), mode);
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x0001FC6C File Offset: 0x0001DE6C
		public void AddRelativeTorque(Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
			Rigidbody.INTERNAL_CALL_AddRelativeTorque(this, ref torque, mode);
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x0001FC78 File Offset: 0x0001DE78
		[ExcludeFromDocs]
		public void AddRelativeTorque(Vector3 torque)
		{
			ForceMode mode = ForceMode.Force;
			Rigidbody.INTERNAL_CALL_AddRelativeTorque(this, ref torque, mode);
		}

		// Token: 0x060018F5 RID: 6389
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AddRelativeTorque(Rigidbody self, ref Vector3 torque, ForceMode mode);

		// Token: 0x060018F6 RID: 6390 RVA: 0x0001FC94 File Offset: 0x0001DE94
		[ExcludeFromDocs]
		public void AddRelativeTorque(float x, float y, float z)
		{
			ForceMode mode = ForceMode.Force;
			this.AddRelativeTorque(x, y, z, mode);
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x0001FCB0 File Offset: 0x0001DEB0
		public void AddRelativeTorque(float x, float y, float z, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
			this.AddRelativeTorque(new Vector3(x, y, z), mode);
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x0001FCC4 File Offset: 0x0001DEC4
		public void AddForceAtPosition(Vector3 force, Vector3 position, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
			Rigidbody.INTERNAL_CALL_AddForceAtPosition(this, ref force, ref position, mode);
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x0001FCD4 File Offset: 0x0001DED4
		[ExcludeFromDocs]
		public void AddForceAtPosition(Vector3 force, Vector3 position)
		{
			ForceMode mode = ForceMode.Force;
			Rigidbody.INTERNAL_CALL_AddForceAtPosition(this, ref force, ref position, mode);
		}

		// Token: 0x060018FA RID: 6394
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AddForceAtPosition(Rigidbody self, ref Vector3 force, ref Vector3 position, ForceMode mode);

		// Token: 0x060018FB RID: 6395 RVA: 0x0001FCF0 File Offset: 0x0001DEF0
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, [DefaultValue("0.0F")] float upwardsModifier, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
			Rigidbody.INTERNAL_CALL_AddExplosionForce(this, explosionForce, ref explosionPosition, explosionRadius, upwardsModifier, mode);
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x0001FD04 File Offset: 0x0001DF04
		[ExcludeFromDocs]
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier)
		{
			ForceMode mode = ForceMode.Force;
			Rigidbody.INTERNAL_CALL_AddExplosionForce(this, explosionForce, ref explosionPosition, explosionRadius, upwardsModifier, mode);
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x0001FD24 File Offset: 0x0001DF24
		[ExcludeFromDocs]
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius)
		{
			ForceMode mode = ForceMode.Force;
			float upwardsModifier = 0f;
			Rigidbody.INTERNAL_CALL_AddExplosionForce(this, explosionForce, ref explosionPosition, explosionRadius, upwardsModifier, mode);
		}

		// Token: 0x060018FE RID: 6398
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AddExplosionForce(Rigidbody self, float explosionForce, ref Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode);

		// Token: 0x060018FF RID: 6399 RVA: 0x0001FD48 File Offset: 0x0001DF48
		public Vector3 ClosestPointOnBounds(Vector3 position)
		{
			Vector3 result;
			Rigidbody.INTERNAL_CALL_ClosestPointOnBounds(this, ref position, out result);
			return result;
		}

		// Token: 0x06001900 RID: 6400
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ClosestPointOnBounds(Rigidbody self, ref Vector3 position, out Vector3 value);

		// Token: 0x06001901 RID: 6401 RVA: 0x0001FD68 File Offset: 0x0001DF68
		public Vector3 GetRelativePointVelocity(Vector3 relativePoint)
		{
			Vector3 result;
			Rigidbody.INTERNAL_CALL_GetRelativePointVelocity(this, ref relativePoint, out result);
			return result;
		}

		// Token: 0x06001902 RID: 6402
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetRelativePointVelocity(Rigidbody self, ref Vector3 relativePoint, out Vector3 value);

		// Token: 0x06001903 RID: 6403 RVA: 0x0001FD88 File Offset: 0x0001DF88
		public Vector3 GetPointVelocity(Vector3 worldPoint)
		{
			Vector3 result;
			Rigidbody.INTERNAL_CALL_GetPointVelocity(this, ref worldPoint, out result);
			return result;
		}

		// Token: 0x06001904 RID: 6404
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetPointVelocity(Rigidbody self, ref Vector3 worldPoint, out Vector3 value);

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001905 RID: 6405 RVA: 0x0001FDA8 File Offset: 0x0001DFA8
		// (set) Token: 0x06001906 RID: 6406 RVA: 0x0001FDC8 File Offset: 0x0001DFC8
		public Vector3 centerOfMass
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_centerOfMass(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_centerOfMass(ref value);
			}
		}

		// Token: 0x06001907 RID: 6407
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_centerOfMass(out Vector3 value);

		// Token: 0x06001908 RID: 6408
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_centerOfMass(ref Vector3 value);

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001909 RID: 6409 RVA: 0x0001FDD4 File Offset: 0x0001DFD4
		public Vector3 worldCenterOfMass
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_worldCenterOfMass(out result);
				return result;
			}
		}

		// Token: 0x0600190A RID: 6410
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_worldCenterOfMass(out Vector3 value);

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x0600190B RID: 6411 RVA: 0x0001FDF4 File Offset: 0x0001DFF4
		// (set) Token: 0x0600190C RID: 6412 RVA: 0x0001FE14 File Offset: 0x0001E014
		public Quaternion inertiaTensorRotation
		{
			get
			{
				Quaternion result;
				this.INTERNAL_get_inertiaTensorRotation(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_inertiaTensorRotation(ref value);
			}
		}

		// Token: 0x0600190D RID: 6413
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_inertiaTensorRotation(out Quaternion value);

		// Token: 0x0600190E RID: 6414
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_inertiaTensorRotation(ref Quaternion value);

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x0600190F RID: 6415 RVA: 0x0001FE20 File Offset: 0x0001E020
		// (set) Token: 0x06001910 RID: 6416 RVA: 0x0001FE40 File Offset: 0x0001E040
		public Vector3 inertiaTensor
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_inertiaTensor(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_inertiaTensor(ref value);
			}
		}

		// Token: 0x06001911 RID: 6417
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_inertiaTensor(out Vector3 value);

		// Token: 0x06001912 RID: 6418
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_inertiaTensor(ref Vector3 value);

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001913 RID: 6419
		// (set) Token: 0x06001914 RID: 6420
		public extern bool detectCollisions { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001915 RID: 6421
		// (set) Token: 0x06001916 RID: 6422
		[Obsolete("Cone friction is no longer supported.")]
		public extern bool useConeFriction { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001917 RID: 6423 RVA: 0x0001FE4C File Offset: 0x0001E04C
		// (set) Token: 0x06001918 RID: 6424 RVA: 0x0001FE6C File Offset: 0x0001E06C
		public Vector3 position
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_position(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_position(ref value);
			}
		}

		// Token: 0x06001919 RID: 6425
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_position(out Vector3 value);

		// Token: 0x0600191A RID: 6426
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_position(ref Vector3 value);

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x0600191B RID: 6427 RVA: 0x0001FE78 File Offset: 0x0001E078
		// (set) Token: 0x0600191C RID: 6428 RVA: 0x0001FE98 File Offset: 0x0001E098
		public Quaternion rotation
		{
			get
			{
				Quaternion result;
				this.INTERNAL_get_rotation(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_rotation(ref value);
			}
		}

		// Token: 0x0600191D RID: 6429
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_rotation(out Quaternion value);

		// Token: 0x0600191E RID: 6430
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_rotation(ref Quaternion value);

		// Token: 0x0600191F RID: 6431 RVA: 0x0001FEA4 File Offset: 0x0001E0A4
		public void MovePosition(Vector3 position)
		{
			Rigidbody.INTERNAL_CALL_MovePosition(this, ref position);
		}

		// Token: 0x06001920 RID: 6432
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_MovePosition(Rigidbody self, ref Vector3 position);

		// Token: 0x06001921 RID: 6433 RVA: 0x0001FEB0 File Offset: 0x0001E0B0
		public void MoveRotation(Quaternion rot)
		{
			Rigidbody.INTERNAL_CALL_MoveRotation(this, ref rot);
		}

		// Token: 0x06001922 RID: 6434
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_MoveRotation(Rigidbody self, ref Quaternion rot);

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001923 RID: 6435
		// (set) Token: 0x06001924 RID: 6436
		public extern RigidbodyInterpolation interpolation { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06001925 RID: 6437 RVA: 0x0001FEBC File Offset: 0x0001E0BC
		public void Sleep()
		{
			Rigidbody.INTERNAL_CALL_Sleep(this);
		}

		// Token: 0x06001926 RID: 6438
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Sleep(Rigidbody self);

		// Token: 0x06001927 RID: 6439 RVA: 0x0001FEC8 File Offset: 0x0001E0C8
		public bool IsSleeping()
		{
			return Rigidbody.INTERNAL_CALL_IsSleeping(this);
		}

		// Token: 0x06001928 RID: 6440
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_IsSleeping(Rigidbody self);

		// Token: 0x06001929 RID: 6441 RVA: 0x0001FEE4 File Offset: 0x0001E0E4
		public void WakeUp()
		{
			Rigidbody.INTERNAL_CALL_WakeUp(this);
		}

		// Token: 0x0600192A RID: 6442
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_WakeUp(Rigidbody self);

		// Token: 0x0600192B RID: 6443 RVA: 0x0001FEF0 File Offset: 0x0001E0F0
		public void ResetCenterOfMass()
		{
			Rigidbody.INTERNAL_CALL_ResetCenterOfMass(this);
		}

		// Token: 0x0600192C RID: 6444
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ResetCenterOfMass(Rigidbody self);

		// Token: 0x0600192D RID: 6445 RVA: 0x0001FEFC File Offset: 0x0001E0FC
		public void ResetInertiaTensor()
		{
			Rigidbody.INTERNAL_CALL_ResetInertiaTensor(this);
		}

		// Token: 0x0600192E RID: 6446
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ResetInertiaTensor(Rigidbody self);

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x0600192F RID: 6447
		// (set) Token: 0x06001930 RID: 6448
		public extern int solverIterations { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x0001FF08 File Offset: 0x0001E108
		// (set) Token: 0x06001932 RID: 6450 RVA: 0x0001FF24 File Offset: 0x0001E124
		[Obsolete("Please use Rigidbody.solverIterations instead. (UnityUpgradable) -> solverIterations")]
		public int solverIterationCount
		{
			get
			{
				return this.solverIterations;
			}
			set
			{
				this.solverIterations = value;
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001933 RID: 6451
		// (set) Token: 0x06001934 RID: 6452
		public extern int solverVelocityIterations { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001935 RID: 6453 RVA: 0x0001FF30 File Offset: 0x0001E130
		// (set) Token: 0x06001936 RID: 6454 RVA: 0x0001FF4C File Offset: 0x0001E14C
		[Obsolete("Please use Rigidbody.solverVelocityIterations instead. (UnityUpgradable) -> solverVelocityIterations")]
		public int solverVelocityIterationCount
		{
			get
			{
				return this.solverVelocityIterations;
			}
			set
			{
				this.solverVelocityIterations = value;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001937 RID: 6455
		// (set) Token: 0x06001938 RID: 6456
		[Obsolete("The sleepVelocity is no longer supported. Use sleepThreshold. Note that sleepThreshold is energy but not velocity.")]
		public extern float sleepVelocity { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001939 RID: 6457
		// (set) Token: 0x0600193A RID: 6458
		[Obsolete("The sleepAngularVelocity is no longer supported. Set Use sleepThreshold to specify energy.")]
		public extern float sleepAngularVelocity { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x0600193B RID: 6459
		// (set) Token: 0x0600193C RID: 6460
		public extern float sleepThreshold { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x0600193D RID: 6461
		// (set) Token: 0x0600193E RID: 6462
		public extern float maxAngularVelocity { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x0600193F RID: 6463 RVA: 0x0001FF58 File Offset: 0x0001E158
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Rigidbody.INTERNAL_CALL_SweepTest(this, ref direction, out hitInfo, maxDistance, queryTriggerInteraction);
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x0001FF7C File Offset: 0x0001E17C
		[ExcludeFromDocs]
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Rigidbody.INTERNAL_CALL_SweepTest(this, ref direction, out hitInfo, maxDistance, queryTriggerInteraction);
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x0001FFA0 File Offset: 0x0001E1A0
		[ExcludeFromDocs]
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			float positiveInfinity = float.PositiveInfinity;
			return Rigidbody.INTERNAL_CALL_SweepTest(this, ref direction, out hitInfo, positiveInfinity, queryTriggerInteraction);
		}

		// Token: 0x06001942 RID: 6466
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_SweepTest(Rigidbody self, ref Vector3 direction, out RaycastHit hitInfo, float maxDistance, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x06001943 RID: 6467 RVA: 0x0001FFC8 File Offset: 0x0001E1C8
		public RaycastHit[] SweepTestAll(Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Rigidbody.INTERNAL_CALL_SweepTestAll(this, ref direction, maxDistance, queryTriggerInteraction);
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x0001FFE8 File Offset: 0x0001E1E8
		[ExcludeFromDocs]
		public RaycastHit[] SweepTestAll(Vector3 direction, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Rigidbody.INTERNAL_CALL_SweepTestAll(this, ref direction, maxDistance, queryTriggerInteraction);
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x0002000C File Offset: 0x0001E20C
		[ExcludeFromDocs]
		public RaycastHit[] SweepTestAll(Vector3 direction)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			float positiveInfinity = float.PositiveInfinity;
			return Rigidbody.INTERNAL_CALL_SweepTestAll(this, ref direction, positiveInfinity, queryTriggerInteraction);
		}

		// Token: 0x06001946 RID: 6470
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RaycastHit[] INTERNAL_CALL_SweepTestAll(Rigidbody self, ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x06001947 RID: 6471 RVA: 0x00020034 File Offset: 0x0001E234
		[Obsolete("use Rigidbody.maxAngularVelocity instead.")]
		public void SetMaxAngularVelocity(float a)
		{
			this.maxAngularVelocity = a;
		}
	}
}
