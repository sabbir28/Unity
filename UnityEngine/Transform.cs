using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000100 RID: 256
	public class Transform : Component, IEnumerable
	{
		// Token: 0x060011A3 RID: 4515 RVA: 0x000178E4 File Offset: 0x00015AE4
		protected Transform()
		{
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x000178F0 File Offset: 0x00015AF0
		// (set) Token: 0x060011A5 RID: 4517 RVA: 0x00017910 File Offset: 0x00015B10
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

		// Token: 0x060011A6 RID: 4518
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_position(out Vector3 value);

		// Token: 0x060011A7 RID: 4519
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_position(ref Vector3 value);

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x060011A8 RID: 4520 RVA: 0x0001791C File Offset: 0x00015B1C
		// (set) Token: 0x060011A9 RID: 4521 RVA: 0x0001793C File Offset: 0x00015B3C
		public Vector3 localPosition
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_localPosition(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_localPosition(ref value);
			}
		}

		// Token: 0x060011AA RID: 4522
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_localPosition(out Vector3 value);

		// Token: 0x060011AB RID: 4523
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_localPosition(ref Vector3 value);

		// Token: 0x060011AC RID: 4524 RVA: 0x00017948 File Offset: 0x00015B48
		internal Vector3 GetLocalEulerAngles(RotationOrder order)
		{
			Vector3 result;
			Transform.INTERNAL_CALL_GetLocalEulerAngles(this, order, out result);
			return result;
		}

		// Token: 0x060011AD RID: 4525
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetLocalEulerAngles(Transform self, RotationOrder order, out Vector3 value);

		// Token: 0x060011AE RID: 4526 RVA: 0x00017968 File Offset: 0x00015B68
		internal void SetLocalEulerAngles(Vector3 euler, RotationOrder order)
		{
			Transform.INTERNAL_CALL_SetLocalEulerAngles(this, ref euler, order);
		}

		// Token: 0x060011AF RID: 4527
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetLocalEulerAngles(Transform self, ref Vector3 euler, RotationOrder order);

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x060011B0 RID: 4528 RVA: 0x00017974 File Offset: 0x00015B74
		// (set) Token: 0x060011B1 RID: 4529 RVA: 0x00017998 File Offset: 0x00015B98
		public Vector3 eulerAngles
		{
			get
			{
				return this.rotation.eulerAngles;
			}
			set
			{
				this.rotation = Quaternion.Euler(value);
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x060011B2 RID: 4530 RVA: 0x000179A8 File Offset: 0x00015BA8
		// (set) Token: 0x060011B3 RID: 4531 RVA: 0x000179CC File Offset: 0x00015BCC
		public Vector3 localEulerAngles
		{
			get
			{
				return this.localRotation.eulerAngles;
			}
			set
			{
				this.localRotation = Quaternion.Euler(value);
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x000179DC File Offset: 0x00015BDC
		// (set) Token: 0x060011B5 RID: 4533 RVA: 0x00017A04 File Offset: 0x00015C04
		public Vector3 right
		{
			get
			{
				return this.rotation * Vector3.right;
			}
			set
			{
				this.rotation = Quaternion.FromToRotation(Vector3.right, value);
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x060011B6 RID: 4534 RVA: 0x00017A18 File Offset: 0x00015C18
		// (set) Token: 0x060011B7 RID: 4535 RVA: 0x00017A40 File Offset: 0x00015C40
		public Vector3 up
		{
			get
			{
				return this.rotation * Vector3.up;
			}
			set
			{
				this.rotation = Quaternion.FromToRotation(Vector3.up, value);
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x00017A54 File Offset: 0x00015C54
		// (set) Token: 0x060011B9 RID: 4537 RVA: 0x00017A7C File Offset: 0x00015C7C
		public Vector3 forward
		{
			get
			{
				return this.rotation * Vector3.forward;
			}
			set
			{
				this.rotation = Quaternion.LookRotation(value);
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x00017A8C File Offset: 0x00015C8C
		// (set) Token: 0x060011BB RID: 4539 RVA: 0x00017AAC File Offset: 0x00015CAC
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

		// Token: 0x060011BC RID: 4540
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_rotation(out Quaternion value);

		// Token: 0x060011BD RID: 4541
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_rotation(ref Quaternion value);

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x00017AB8 File Offset: 0x00015CB8
		// (set) Token: 0x060011BF RID: 4543 RVA: 0x00017AD8 File Offset: 0x00015CD8
		public Quaternion localRotation
		{
			get
			{
				Quaternion result;
				this.INTERNAL_get_localRotation(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_localRotation(ref value);
			}
		}

		// Token: 0x060011C0 RID: 4544
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_localRotation(out Quaternion value);

		// Token: 0x060011C1 RID: 4545
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_localRotation(ref Quaternion value);

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x00017AE4 File Offset: 0x00015CE4
		// (set) Token: 0x060011C3 RID: 4547 RVA: 0x00017B04 File Offset: 0x00015D04
		public Vector3 localScale
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_localScale(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_localScale(ref value);
			}
		}

		// Token: 0x060011C4 RID: 4548
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_localScale(out Vector3 value);

		// Token: 0x060011C5 RID: 4549
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_localScale(ref Vector3 value);

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x060011C6 RID: 4550 RVA: 0x00017B10 File Offset: 0x00015D10
		// (set) Token: 0x060011C7 RID: 4551 RVA: 0x00017B2C File Offset: 0x00015D2C
		public Transform parent
		{
			get
			{
				return this.parentInternal;
			}
			set
			{
				if (this is RectTransform)
				{
					Debug.LogWarning("Parent of RectTransform is being set with parent property. Consider using the SetParent method instead, with the worldPositionStays argument set to false. This will retain local orientation and scale rather than world orientation and scale, which can prevent common UI scaling issues.", this);
				}
				this.parentInternal = value;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x060011C8 RID: 4552
		// (set) Token: 0x060011C9 RID: 4553
		internal extern Transform parentInternal { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060011CA RID: 4554 RVA: 0x00017B4C File Offset: 0x00015D4C
		public void SetParent(Transform parent)
		{
			this.SetParent(parent, true);
		}

		// Token: 0x060011CB RID: 4555
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetParent(Transform parent, bool worldPositionStays);

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x060011CC RID: 4556 RVA: 0x00017B58 File Offset: 0x00015D58
		public Matrix4x4 worldToLocalMatrix
		{
			get
			{
				Matrix4x4 result;
				this.INTERNAL_get_worldToLocalMatrix(out result);
				return result;
			}
		}

		// Token: 0x060011CD RID: 4557
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_worldToLocalMatrix(out Matrix4x4 value);

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x00017B78 File Offset: 0x00015D78
		public Matrix4x4 localToWorldMatrix
		{
			get
			{
				Matrix4x4 result;
				this.INTERNAL_get_localToWorldMatrix(out result);
				return result;
			}
		}

		// Token: 0x060011CF RID: 4559
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_localToWorldMatrix(out Matrix4x4 value);

		// Token: 0x060011D0 RID: 4560 RVA: 0x00017B98 File Offset: 0x00015D98
		public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
		{
			Transform.INTERNAL_CALL_SetPositionAndRotation(this, ref position, ref rotation);
		}

		// Token: 0x060011D1 RID: 4561
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetPositionAndRotation(Transform self, ref Vector3 position, ref Quaternion rotation);

		// Token: 0x060011D2 RID: 4562 RVA: 0x00017BA8 File Offset: 0x00015DA8
		[ExcludeFromDocs]
		public void Translate(Vector3 translation)
		{
			Space relativeTo = Space.Self;
			this.Translate(translation, relativeTo);
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x00017BC0 File Offset: 0x00015DC0
		public void Translate(Vector3 translation, [DefaultValue("Space.Self")] Space relativeTo)
		{
			if (relativeTo == Space.World)
			{
				this.position += translation;
			}
			else
			{
				this.position += this.TransformDirection(translation);
			}
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x00017BF8 File Offset: 0x00015DF8
		[ExcludeFromDocs]
		public void Translate(float x, float y, float z)
		{
			Space relativeTo = Space.Self;
			this.Translate(x, y, z, relativeTo);
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x00017C14 File Offset: 0x00015E14
		public void Translate(float x, float y, float z, [DefaultValue("Space.Self")] Space relativeTo)
		{
			this.Translate(new Vector3(x, y, z), relativeTo);
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x00017C28 File Offset: 0x00015E28
		public void Translate(Vector3 translation, Transform relativeTo)
		{
			if (relativeTo)
			{
				this.position += relativeTo.TransformDirection(translation);
			}
			else
			{
				this.position += translation;
			}
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x00017C68 File Offset: 0x00015E68
		public void Translate(float x, float y, float z, Transform relativeTo)
		{
			this.Translate(new Vector3(x, y, z), relativeTo);
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x00017C7C File Offset: 0x00015E7C
		[ExcludeFromDocs]
		public void Rotate(Vector3 eulerAngles)
		{
			Space relativeTo = Space.Self;
			this.Rotate(eulerAngles, relativeTo);
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00017C94 File Offset: 0x00015E94
		public void Rotate(Vector3 eulerAngles, [DefaultValue("Space.Self")] Space relativeTo)
		{
			Quaternion rhs = Quaternion.Euler(eulerAngles.x, eulerAngles.y, eulerAngles.z);
			if (relativeTo == Space.Self)
			{
				this.localRotation *= rhs;
			}
			else
			{
				this.rotation *= Quaternion.Inverse(this.rotation) * rhs * this.rotation;
			}
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00017D0C File Offset: 0x00015F0C
		[ExcludeFromDocs]
		public void Rotate(float xAngle, float yAngle, float zAngle)
		{
			Space relativeTo = Space.Self;
			this.Rotate(xAngle, yAngle, zAngle, relativeTo);
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00017D28 File Offset: 0x00015F28
		public void Rotate(float xAngle, float yAngle, float zAngle, [DefaultValue("Space.Self")] Space relativeTo)
		{
			this.Rotate(new Vector3(xAngle, yAngle, zAngle), relativeTo);
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00017D3C File Offset: 0x00015F3C
		internal void RotateAroundInternal(Vector3 axis, float angle)
		{
			Transform.INTERNAL_CALL_RotateAroundInternal(this, ref axis, angle);
		}

		// Token: 0x060011DD RID: 4573
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_RotateAroundInternal(Transform self, ref Vector3 axis, float angle);

		// Token: 0x060011DE RID: 4574 RVA: 0x00017D48 File Offset: 0x00015F48
		[ExcludeFromDocs]
		public void Rotate(Vector3 axis, float angle)
		{
			Space relativeTo = Space.Self;
			this.Rotate(axis, angle, relativeTo);
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x00017D64 File Offset: 0x00015F64
		public void Rotate(Vector3 axis, float angle, [DefaultValue("Space.Self")] Space relativeTo)
		{
			if (relativeTo == Space.Self)
			{
				this.RotateAroundInternal(base.transform.TransformDirection(axis), angle * 0.017453292f);
			}
			else
			{
				this.RotateAroundInternal(axis, angle * 0.017453292f);
			}
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x00017D9C File Offset: 0x00015F9C
		public void RotateAround(Vector3 point, Vector3 axis, float angle)
		{
			Vector3 vector = this.position;
			Quaternion rotation = Quaternion.AngleAxis(angle, axis);
			Vector3 vector2 = vector - point;
			vector2 = rotation * vector2;
			vector = point + vector2;
			this.position = vector;
			this.RotateAroundInternal(axis, angle * 0.017453292f);
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x00017DE8 File Offset: 0x00015FE8
		[ExcludeFromDocs]
		public void LookAt(Transform target)
		{
			Vector3 up = Vector3.up;
			this.LookAt(target, up);
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x00017E04 File Offset: 0x00016004
		public void LookAt(Transform target, [DefaultValue("Vector3.up")] Vector3 worldUp)
		{
			if (target)
			{
				this.LookAt(target.position, worldUp);
			}
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x00017E20 File Offset: 0x00016020
		public void LookAt(Vector3 worldPosition, [DefaultValue("Vector3.up")] Vector3 worldUp)
		{
			Transform.INTERNAL_CALL_LookAt(this, ref worldPosition, ref worldUp);
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x00017E30 File Offset: 0x00016030
		[ExcludeFromDocs]
		public void LookAt(Vector3 worldPosition)
		{
			Vector3 up = Vector3.up;
			Transform.INTERNAL_CALL_LookAt(this, ref worldPosition, ref up);
		}

		// Token: 0x060011E5 RID: 4581
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_LookAt(Transform self, ref Vector3 worldPosition, ref Vector3 worldUp);

		// Token: 0x060011E6 RID: 4582 RVA: 0x00017E50 File Offset: 0x00016050
		public Vector3 TransformDirection(Vector3 direction)
		{
			Vector3 result;
			Transform.INTERNAL_CALL_TransformDirection(this, ref direction, out result);
			return result;
		}

		// Token: 0x060011E7 RID: 4583
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_TransformDirection(Transform self, ref Vector3 direction, out Vector3 value);

		// Token: 0x060011E8 RID: 4584 RVA: 0x00017E70 File Offset: 0x00016070
		public Vector3 TransformDirection(float x, float y, float z)
		{
			return this.TransformDirection(new Vector3(x, y, z));
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00017E94 File Offset: 0x00016094
		public Vector3 InverseTransformDirection(Vector3 direction)
		{
			Vector3 result;
			Transform.INTERNAL_CALL_InverseTransformDirection(this, ref direction, out result);
			return result;
		}

		// Token: 0x060011EA RID: 4586
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_InverseTransformDirection(Transform self, ref Vector3 direction, out Vector3 value);

		// Token: 0x060011EB RID: 4587 RVA: 0x00017EB4 File Offset: 0x000160B4
		public Vector3 InverseTransformDirection(float x, float y, float z)
		{
			return this.InverseTransformDirection(new Vector3(x, y, z));
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00017ED8 File Offset: 0x000160D8
		public Vector3 TransformVector(Vector3 vector)
		{
			Vector3 result;
			Transform.INTERNAL_CALL_TransformVector(this, ref vector, out result);
			return result;
		}

		// Token: 0x060011ED RID: 4589
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_TransformVector(Transform self, ref Vector3 vector, out Vector3 value);

		// Token: 0x060011EE RID: 4590 RVA: 0x00017EF8 File Offset: 0x000160F8
		public Vector3 TransformVector(float x, float y, float z)
		{
			return this.TransformVector(new Vector3(x, y, z));
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00017F1C File Offset: 0x0001611C
		public Vector3 InverseTransformVector(Vector3 vector)
		{
			Vector3 result;
			Transform.INTERNAL_CALL_InverseTransformVector(this, ref vector, out result);
			return result;
		}

		// Token: 0x060011F0 RID: 4592
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_InverseTransformVector(Transform self, ref Vector3 vector, out Vector3 value);

		// Token: 0x060011F1 RID: 4593 RVA: 0x00017F3C File Offset: 0x0001613C
		public Vector3 InverseTransformVector(float x, float y, float z)
		{
			return this.InverseTransformVector(new Vector3(x, y, z));
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00017F60 File Offset: 0x00016160
		public Vector3 TransformPoint(Vector3 position)
		{
			Vector3 result;
			Transform.INTERNAL_CALL_TransformPoint(this, ref position, out result);
			return result;
		}

		// Token: 0x060011F3 RID: 4595
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_TransformPoint(Transform self, ref Vector3 position, out Vector3 value);

		// Token: 0x060011F4 RID: 4596 RVA: 0x00017F80 File Offset: 0x00016180
		public Vector3 TransformPoint(float x, float y, float z)
		{
			return this.TransformPoint(new Vector3(x, y, z));
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x00017FA4 File Offset: 0x000161A4
		public Vector3 InverseTransformPoint(Vector3 position)
		{
			Vector3 result;
			Transform.INTERNAL_CALL_InverseTransformPoint(this, ref position, out result);
			return result;
		}

		// Token: 0x060011F6 RID: 4598
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_InverseTransformPoint(Transform self, ref Vector3 position, out Vector3 value);

		// Token: 0x060011F7 RID: 4599 RVA: 0x00017FC4 File Offset: 0x000161C4
		public Vector3 InverseTransformPoint(float x, float y, float z)
		{
			return this.InverseTransformPoint(new Vector3(x, y, z));
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x060011F8 RID: 4600
		public extern Transform root { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x060011F9 RID: 4601
		public extern int childCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060011FA RID: 4602
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void DetachChildren();

		// Token: 0x060011FB RID: 4603
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetAsFirstSibling();

		// Token: 0x060011FC RID: 4604
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetAsLastSibling();

		// Token: 0x060011FD RID: 4605
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetSiblingIndex(int index);

		// Token: 0x060011FE RID: 4606
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetSiblingIndex();

		// Token: 0x060011FF RID: 4607
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Transform Find(string name);

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06001200 RID: 4608 RVA: 0x00017FE8 File Offset: 0x000161E8
		public Vector3 lossyScale
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_lossyScale(out result);
				return result;
			}
		}

		// Token: 0x06001201 RID: 4609
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_lossyScale(out Vector3 value);

		// Token: 0x06001202 RID: 4610
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsChildOf(Transform parent);

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06001203 RID: 4611
		// (set) Token: 0x06001204 RID: 4612
		public extern bool hasChanged { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06001205 RID: 4613 RVA: 0x00018008 File Offset: 0x00016208
		[Obsolete("FindChild has been deprecated. Use Find instead (UnityUpgradable) -> Find([mscorlib] System.String)", false)]
		public Transform FindChild(string name)
		{
			return this.Find(name);
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00018024 File Offset: 0x00016224
		public IEnumerator GetEnumerator()
		{
			return new Transform.Enumerator(this);
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00018040 File Offset: 0x00016240
		[Obsolete("use Transform.Rotate instead.")]
		public void RotateAround(Vector3 axis, float angle)
		{
			Transform.INTERNAL_CALL_RotateAround(this, ref axis, angle);
		}

		// Token: 0x06001208 RID: 4616
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_RotateAround(Transform self, ref Vector3 axis, float angle);

		// Token: 0x06001209 RID: 4617 RVA: 0x0001804C File Offset: 0x0001624C
		[Obsolete("use Transform.Rotate instead.")]
		public void RotateAroundLocal(Vector3 axis, float angle)
		{
			Transform.INTERNAL_CALL_RotateAroundLocal(this, ref axis, angle);
		}

		// Token: 0x0600120A RID: 4618
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_RotateAroundLocal(Transform self, ref Vector3 axis, float angle);

		// Token: 0x0600120B RID: 4619
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Transform GetChild(int index);

		// Token: 0x0600120C RID: 4620
		[Obsolete("use Transform.childCount instead.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetChildCount();

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x0600120D RID: 4621
		// (set) Token: 0x0600120E RID: 4622
		public extern int hierarchyCapacity { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x0600120F RID: 4623
		public extern int hierarchyCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x02000101 RID: 257
		private sealed class Enumerator : IEnumerator
		{
			// Token: 0x06001210 RID: 4624 RVA: 0x00018058 File Offset: 0x00016258
			internal Enumerator(Transform outer)
			{
				this.outer = outer;
			}

			// Token: 0x170003AF RID: 943
			// (get) Token: 0x06001211 RID: 4625 RVA: 0x00018070 File Offset: 0x00016270
			public object Current
			{
				get
				{
					return this.outer.GetChild(this.currentIndex);
				}
			}

			// Token: 0x06001212 RID: 4626 RVA: 0x00018098 File Offset: 0x00016298
			public bool MoveNext()
			{
				int childCount = this.outer.childCount;
				return ++this.currentIndex < childCount;
			}

			// Token: 0x06001213 RID: 4627 RVA: 0x000180D0 File Offset: 0x000162D0
			public void Reset()
			{
				this.currentIndex = -1;
			}

			// Token: 0x0400025A RID: 602
			private Transform outer;

			// Token: 0x0400025B RID: 603
			private int currentIndex = -1;
		}
	}
}
