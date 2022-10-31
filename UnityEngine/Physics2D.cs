using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000170 RID: 368
	public class Physics2D
	{
		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001AB2 RID: 6834
		// (set) Token: 0x06001AB3 RID: 6835
		[ThreadAndSerializationSafe]
		public static extern int velocityIterations { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001AB4 RID: 6836
		// (set) Token: 0x06001AB5 RID: 6837
		public static extern int positionIterations { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x00020EC8 File Offset: 0x0001F0C8
		// (set) Token: 0x06001AB7 RID: 6839 RVA: 0x00020EE8 File Offset: 0x0001F0E8
		public static Vector2 gravity
		{
			get
			{
				Vector2 result;
				Physics2D.INTERNAL_get_gravity(out result);
				return result;
			}
			set
			{
				Physics2D.INTERNAL_set_gravity(ref value);
			}
		}

		// Token: 0x06001AB8 RID: 6840
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_gravity(out Vector2 value);

		// Token: 0x06001AB9 RID: 6841
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_gravity(ref Vector2 value);

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001ABA RID: 6842
		// (set) Token: 0x06001ABB RID: 6843
		public static extern bool queriesHitTriggers { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001ABC RID: 6844
		// (set) Token: 0x06001ABD RID: 6845
		public static extern bool queriesStartInColliders { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001ABE RID: 6846
		// (set) Token: 0x06001ABF RID: 6847
		public static extern bool changeStopsCallbacks { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001AC0 RID: 6848
		// (set) Token: 0x06001AC1 RID: 6849
		public static extern bool callbacksOnDisable { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001AC2 RID: 6850
		// (set) Token: 0x06001AC3 RID: 6851
		public static extern float velocityThreshold { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001AC4 RID: 6852
		// (set) Token: 0x06001AC5 RID: 6853
		public static extern float maxLinearCorrection { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001AC6 RID: 6854
		// (set) Token: 0x06001AC7 RID: 6855
		public static extern float maxAngularCorrection { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001AC8 RID: 6856
		// (set) Token: 0x06001AC9 RID: 6857
		public static extern float maxTranslationSpeed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001ACA RID: 6858
		// (set) Token: 0x06001ACB RID: 6859
		public static extern float maxRotationSpeed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001ACC RID: 6860
		// (set) Token: 0x06001ACD RID: 6861
		public static extern float defaultContactOffset { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001ACE RID: 6862
		// (set) Token: 0x06001ACF RID: 6863
		public static extern float baumgarteScale { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001AD0 RID: 6864
		// (set) Token: 0x06001AD1 RID: 6865
		public static extern float baumgarteTOIScale { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001AD2 RID: 6866
		// (set) Token: 0x06001AD3 RID: 6867
		public static extern float timeToSleep { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001AD4 RID: 6868
		// (set) Token: 0x06001AD5 RID: 6869
		public static extern float linearSleepTolerance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001AD6 RID: 6870
		// (set) Token: 0x06001AD7 RID: 6871
		public static extern float angularSleepTolerance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001AD8 RID: 6872
		// (set) Token: 0x06001AD9 RID: 6873
		public static extern bool alwaysShowColliders { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001ADA RID: 6874
		// (set) Token: 0x06001ADB RID: 6875
		public static extern bool showColliderSleep { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001ADC RID: 6876
		// (set) Token: 0x06001ADD RID: 6877
		public static extern bool showColliderContacts { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001ADE RID: 6878
		// (set) Token: 0x06001ADF RID: 6879
		public static extern bool showColliderAABB { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001AE0 RID: 6880
		// (set) Token: 0x06001AE1 RID: 6881
		public static extern float contactArrowScale { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001AE2 RID: 6882 RVA: 0x00020EF4 File Offset: 0x0001F0F4
		// (set) Token: 0x06001AE3 RID: 6883 RVA: 0x00020F14 File Offset: 0x0001F114
		public static Color colliderAwakeColor
		{
			get
			{
				Color result;
				Physics2D.INTERNAL_get_colliderAwakeColor(out result);
				return result;
			}
			set
			{
				Physics2D.INTERNAL_set_colliderAwakeColor(ref value);
			}
		}

		// Token: 0x06001AE4 RID: 6884
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_colliderAwakeColor(out Color value);

		// Token: 0x06001AE5 RID: 6885
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_colliderAwakeColor(ref Color value);

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001AE6 RID: 6886 RVA: 0x00020F20 File Offset: 0x0001F120
		// (set) Token: 0x06001AE7 RID: 6887 RVA: 0x00020F40 File Offset: 0x0001F140
		public static Color colliderAsleepColor
		{
			get
			{
				Color result;
				Physics2D.INTERNAL_get_colliderAsleepColor(out result);
				return result;
			}
			set
			{
				Physics2D.INTERNAL_set_colliderAsleepColor(ref value);
			}
		}

		// Token: 0x06001AE8 RID: 6888
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_colliderAsleepColor(out Color value);

		// Token: 0x06001AE9 RID: 6889
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_colliderAsleepColor(ref Color value);

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001AEA RID: 6890 RVA: 0x00020F4C File Offset: 0x0001F14C
		// (set) Token: 0x06001AEB RID: 6891 RVA: 0x00020F6C File Offset: 0x0001F16C
		public static Color colliderContactColor
		{
			get
			{
				Color result;
				Physics2D.INTERNAL_get_colliderContactColor(out result);
				return result;
			}
			set
			{
				Physics2D.INTERNAL_set_colliderContactColor(ref value);
			}
		}

		// Token: 0x06001AEC RID: 6892
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_colliderContactColor(out Color value);

		// Token: 0x06001AED RID: 6893
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_colliderContactColor(ref Color value);

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001AEE RID: 6894 RVA: 0x00020F78 File Offset: 0x0001F178
		// (set) Token: 0x06001AEF RID: 6895 RVA: 0x00020F98 File Offset: 0x0001F198
		public static Color colliderAABBColor
		{
			get
			{
				Color result;
				Physics2D.INTERNAL_get_colliderAABBColor(out result);
				return result;
			}
			set
			{
				Physics2D.INTERNAL_set_colliderAABBColor(ref value);
			}
		}

		// Token: 0x06001AF0 RID: 6896
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_colliderAABBColor(out Color value);

		// Token: 0x06001AF1 RID: 6897
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_colliderAABBColor(ref Color value);

		// Token: 0x06001AF2 RID: 6898
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void IgnoreCollision(Collider2D collider1, Collider2D collider2, [DefaultValue("true")] bool ignore);

		// Token: 0x06001AF3 RID: 6899 RVA: 0x00020FA4 File Offset: 0x0001F1A4
		[ExcludeFromDocs]
		public static void IgnoreCollision(Collider2D collider1, Collider2D collider2)
		{
			bool ignore = true;
			Physics2D.IgnoreCollision(collider1, collider2, ignore);
		}

		// Token: 0x06001AF4 RID: 6900
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetIgnoreCollision(Collider2D collider1, Collider2D collider2);

		// Token: 0x06001AF5 RID: 6901
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void IgnoreLayerCollision(int layer1, int layer2, [DefaultValue("true")] bool ignore);

		// Token: 0x06001AF6 RID: 6902 RVA: 0x00020FBC File Offset: 0x0001F1BC
		[ExcludeFromDocs]
		public static void IgnoreLayerCollision(int layer1, int layer2)
		{
			bool ignore = true;
			Physics2D.IgnoreLayerCollision(layer1, layer2, ignore);
		}

		// Token: 0x06001AF7 RID: 6903
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetIgnoreLayerCollision(int layer1, int layer2);

		// Token: 0x06001AF8 RID: 6904
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetLayerCollisionMask(int layer, int layerMask);

		// Token: 0x06001AF9 RID: 6905
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetLayerCollisionMask(int layer);

		// Token: 0x06001AFA RID: 6906
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsTouching(Collider2D collider1, Collider2D collider2);

		// Token: 0x06001AFB RID: 6907 RVA: 0x00020FD4 File Offset: 0x0001F1D4
		public static bool IsTouching(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter)
		{
			return Physics2D.Internal_IsTouching(collider1, collider2, contactFilter);
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00020FF4 File Offset: 0x0001F1F4
		private static bool Internal_IsTouching(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter)
		{
			return Physics2D.INTERNAL_CALL_Internal_IsTouching(collider1, collider2, ref contactFilter);
		}

		// Token: 0x06001AFD RID: 6909
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Internal_IsTouching(Collider2D collider1, Collider2D collider2, ref ContactFilter2D contactFilter);

		// Token: 0x06001AFE RID: 6910 RVA: 0x00021014 File Offset: 0x0001F214
		public static bool IsTouching(Collider2D collider, ContactFilter2D contactFilter)
		{
			return Physics2D.INTERNAL_CALL_IsTouching(collider, ref contactFilter);
		}

		// Token: 0x06001AFF RID: 6911
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_IsTouching(Collider2D collider, ref ContactFilter2D contactFilter);

		// Token: 0x06001B00 RID: 6912
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsTouchingLayers(Collider2D collider, [DefaultValue("AllLayers")] int layerMask);

		// Token: 0x06001B01 RID: 6913 RVA: 0x00021034 File Offset: 0x0001F234
		[ExcludeFromDocs]
		public static bool IsTouchingLayers(Collider2D collider)
		{
			int layerMask = -1;
			return Physics2D.IsTouchingLayers(collider, layerMask);
		}

		// Token: 0x06001B02 RID: 6914
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern ColliderDistance2D Distance(Collider2D colliderA, Collider2D colliderB);

		// Token: 0x06001B03 RID: 6915 RVA: 0x00021054 File Offset: 0x0001F254
		internal static void SetEditorDragMovement(bool dragging, GameObject[] objs)
		{
			foreach (Rigidbody2D rigidbody2D in Physics2D.m_LastDisabledRigidbody2D)
			{
				if (rigidbody2D != null)
				{
					rigidbody2D.SetDragBehaviour(false);
				}
			}
			Physics2D.m_LastDisabledRigidbody2D.Clear();
			if (dragging)
			{
				foreach (GameObject gameObject in objs)
				{
					Rigidbody2D[] componentsInChildren = gameObject.GetComponentsInChildren<Rigidbody2D>(false);
					foreach (Rigidbody2D rigidbody2D2 in componentsInChildren)
					{
						Physics2D.m_LastDisabledRigidbody2D.Add(rigidbody2D2);
						rigidbody2D2.SetDragBehaviour(true);
					}
				}
			}
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x0002113C File Offset: 0x0001F33C
		[ExcludeFromDocs]
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.Linecast(start, end, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x00021164 File Offset: 0x0001F364
		[ExcludeFromDocs]
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.Linecast(start, end, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x00021190 File Offset: 0x0001F390
		[ExcludeFromDocs]
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.Linecast(start, end, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x000211C0 File Offset: 0x0001F3C0
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			RaycastHit2D result;
			Physics2D.Internal_Linecast(start, end, contactFilter, out result);
			return result;
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x000211EC File Offset: 0x0001F3EC
		[ExcludeFromDocs]
		public static RaycastHit2D[] LinecastAll(Vector2 start, Vector2 end, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.LinecastAll(start, end, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x00021214 File Offset: 0x0001F414
		[ExcludeFromDocs]
		public static RaycastHit2D[] LinecastAll(Vector2 start, Vector2 end, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.LinecastAll(start, end, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x00021240 File Offset: 0x0001F440
		[ExcludeFromDocs]
		public static RaycastHit2D[] LinecastAll(Vector2 start, Vector2 end)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.LinecastAll(start, end, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x00021270 File Offset: 0x0001F470
		public static RaycastHit2D[] LinecastAll(Vector2 start, Vector2 end, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.Internal_LinecastAll(start, end, contactFilter);
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x00021298 File Offset: 0x0001F498
		[ExcludeFromDocs]
		public static int LinecastNonAlloc(Vector2 start, Vector2 end, RaycastHit2D[] results, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.LinecastNonAlloc(start, end, results, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x000212C0 File Offset: 0x0001F4C0
		[ExcludeFromDocs]
		public static int LinecastNonAlloc(Vector2 start, Vector2 end, RaycastHit2D[] results, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.LinecastNonAlloc(start, end, results, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x000212EC File Offset: 0x0001F4EC
		[ExcludeFromDocs]
		public static int LinecastNonAlloc(Vector2 start, Vector2 end, RaycastHit2D[] results)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.LinecastNonAlloc(start, end, results, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x0002131C File Offset: 0x0001F51C
		public static int LinecastNonAlloc(Vector2 start, Vector2 end, RaycastHit2D[] results, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.Internal_LinecastNonAlloc(start, end, contactFilter, results);
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x00021348 File Offset: 0x0001F548
		public static int Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter, RaycastHit2D[] results)
		{
			return Physics2D.Internal_LinecastNonAlloc(start, end, contactFilter, results);
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x00021368 File Offset: 0x0001F568
		private static void Internal_Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter, out RaycastHit2D raycastHit)
		{
			Physics2D.INTERNAL_CALL_Internal_Linecast(ref start, ref end, ref contactFilter, out raycastHit);
		}

		// Token: 0x06001B12 RID: 6930
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_Linecast(ref Vector2 start, ref Vector2 end, ref ContactFilter2D contactFilter, out RaycastHit2D raycastHit);

		// Token: 0x06001B13 RID: 6931 RVA: 0x00021378 File Offset: 0x0001F578
		private static RaycastHit2D[] Internal_LinecastAll(Vector2 start, Vector2 end, ContactFilter2D contactFilter)
		{
			return Physics2D.INTERNAL_CALL_Internal_LinecastAll(ref start, ref end, ref contactFilter);
		}

		// Token: 0x06001B14 RID: 6932
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RaycastHit2D[] INTERNAL_CALL_Internal_LinecastAll(ref Vector2 start, ref Vector2 end, ref ContactFilter2D contactFilter);

		// Token: 0x06001B15 RID: 6933 RVA: 0x00021398 File Offset: 0x0001F598
		private static int Internal_LinecastNonAlloc(Vector2 start, Vector2 end, ContactFilter2D contactFilter, RaycastHit2D[] results)
		{
			return Physics2D.INTERNAL_CALL_Internal_LinecastNonAlloc(ref start, ref end, ref contactFilter, results);
		}

		// Token: 0x06001B16 RID: 6934
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_Internal_LinecastNonAlloc(ref Vector2 start, ref Vector2 end, ref ContactFilter2D contactFilter, RaycastHit2D[] results);

		// Token: 0x06001B17 RID: 6935 RVA: 0x000213BC File Offset: 0x0001F5BC
		[RequiredByNativeCode]
		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.Raycast(origin, direction, distance, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x000213E4 File Offset: 0x0001F5E4
		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.Raycast(origin, direction, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x00021410 File Offset: 0x0001F610
		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.Raycast(origin, direction, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x00021440 File Offset: 0x0001F640
		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			float positiveInfinity2 = float.PositiveInfinity;
			return Physics2D.Raycast(origin, direction, positiveInfinity2, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x00021478 File Offset: 0x0001F678
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			RaycastHit2D result;
			Physics2D.Internal_Raycast(origin, direction, distance, contactFilter, out result);
			return result;
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x000214A4 File Offset: 0x0001F6A4
		[ExcludeFromDocs]
		public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.RaycastAll(origin, direction, distance, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x000214CC File Offset: 0x0001F6CC
		[ExcludeFromDocs]
		public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, float distance, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.RaycastAll(origin, direction, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x000214F8 File Offset: 0x0001F6F8
		[ExcludeFromDocs]
		public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, float distance)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.RaycastAll(origin, direction, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x00021528 File Offset: 0x0001F728
		[ExcludeFromDocs]
		public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			float positiveInfinity2 = float.PositiveInfinity;
			return Physics2D.RaycastAll(origin, direction, positiveInfinity2, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x00021560 File Offset: 0x0001F760
		public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.Internal_RaycastAll(origin, direction, distance, contactFilter);
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x0002158C File Offset: 0x0001F78C
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.RaycastNonAlloc(origin, direction, results, distance, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x000215B8 File Offset: 0x0001F7B8
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.RaycastNonAlloc(origin, direction, results, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x000215E8 File Offset: 0x0001F7E8
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results, float distance)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.RaycastNonAlloc(origin, direction, results, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x00021618 File Offset: 0x0001F818
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			float positiveInfinity2 = float.PositiveInfinity;
			return Physics2D.RaycastNonAlloc(origin, direction, results, positiveInfinity2, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x00021650 File Offset: 0x0001F850
		public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.Internal_RaycastNonAlloc(origin, direction, distance, contactFilter, results);
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x0002167C File Offset: 0x0001F87C
		[ExcludeFromDocs]
		public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.Raycast(origin, direction, contactFilter, results, positiveInfinity);
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x000216A4 File Offset: 0x0001F8A4
		public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance)
		{
			return Physics2D.Internal_RaycastNonAlloc(origin, direction, distance, contactFilter, results);
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x000216C4 File Offset: 0x0001F8C4
		private static void Internal_Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, out RaycastHit2D raycastHit)
		{
			Physics2D.INTERNAL_CALL_Internal_Raycast(ref origin, ref direction, distance, ref contactFilter, out raycastHit);
		}

		// Token: 0x06001B29 RID: 6953
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_Raycast(ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D raycastHit);

		// Token: 0x06001B2A RID: 6954 RVA: 0x000216D8 File Offset: 0x0001F8D8
		private static RaycastHit2D[] Internal_RaycastAll(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return Physics2D.INTERNAL_CALL_Internal_RaycastAll(ref origin, ref direction, distance, ref contactFilter);
		}

		// Token: 0x06001B2B RID: 6955
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RaycastHit2D[] INTERNAL_CALL_Internal_RaycastAll(ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter);

		// Token: 0x06001B2C RID: 6956 RVA: 0x000216FC File Offset: 0x0001F8FC
		private static int Internal_RaycastNonAlloc(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results)
		{
			return Physics2D.INTERNAL_CALL_Internal_RaycastNonAlloc(ref origin, ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x06001B2D RID: 6957
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_Internal_RaycastNonAlloc(ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results);

		// Token: 0x06001B2E RID: 6958 RVA: 0x00021720 File Offset: 0x0001F920
		[ExcludeFromDocs]
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.CircleCast(origin, radius, direction, distance, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x0002174C File Offset: 0x0001F94C
		[ExcludeFromDocs]
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.CircleCast(origin, radius, direction, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x0002177C File Offset: 0x0001F97C
		[ExcludeFromDocs]
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.CircleCast(origin, radius, direction, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x000217AC File Offset: 0x0001F9AC
		[ExcludeFromDocs]
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			float positiveInfinity2 = float.PositiveInfinity;
			return Physics2D.CircleCast(origin, radius, direction, positiveInfinity2, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x000217E4 File Offset: 0x0001F9E4
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			RaycastHit2D result;
			Physics2D.Internal_CircleCast(origin, radius, direction, distance, contactFilter, out result);
			return result;
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x00021814 File Offset: 0x0001FA14
		[ExcludeFromDocs]
		public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.CircleCastAll(origin, radius, direction, distance, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x00021840 File Offset: 0x0001FA40
		[ExcludeFromDocs]
		public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.CircleCastAll(origin, radius, direction, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x00021870 File Offset: 0x0001FA70
		[ExcludeFromDocs]
		public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.CircleCastAll(origin, radius, direction, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x000218A0 File Offset: 0x0001FAA0
		[ExcludeFromDocs]
		public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			float positiveInfinity2 = float.PositiveInfinity;
			return Physics2D.CircleCastAll(origin, radius, direction, positiveInfinity2, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x000218D8 File Offset: 0x0001FAD8
		public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.Internal_CircleCastAll(origin, radius, direction, distance, contactFilter);
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x00021904 File Offset: 0x0001FB04
		[ExcludeFromDocs]
		public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.CircleCastNonAlloc(origin, radius, direction, results, distance, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x00021930 File Offset: 0x0001FB30
		[ExcludeFromDocs]
		public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.CircleCastNonAlloc(origin, radius, direction, results, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x00021960 File Offset: 0x0001FB60
		[ExcludeFromDocs]
		public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] results, float distance)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.CircleCastNonAlloc(origin, radius, direction, results, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x00021994 File Offset: 0x0001FB94
		[ExcludeFromDocs]
		public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] results)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			float positiveInfinity2 = float.PositiveInfinity;
			return Physics2D.CircleCastNonAlloc(origin, radius, direction, results, positiveInfinity2, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x000219D0 File Offset: 0x0001FBD0
		public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.Internal_CircleCastNonAlloc(origin, radius, direction, distance, contactFilter, results);
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x00021A00 File Offset: 0x0001FC00
		[ExcludeFromDocs]
		public static int CircleCast(Vector2 origin, float radius, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.CircleCast(origin, radius, direction, contactFilter, results, positiveInfinity);
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x00021A28 File Offset: 0x0001FC28
		public static int CircleCast(Vector2 origin, float radius, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance)
		{
			return Physics2D.Internal_CircleCastNonAlloc(origin, radius, direction, distance, contactFilter, results);
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x00021A4C File Offset: 0x0001FC4C
		private static void Internal_CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter, out RaycastHit2D raycastHit)
		{
			Physics2D.INTERNAL_CALL_Internal_CircleCast(ref origin, radius, ref direction, distance, ref contactFilter, out raycastHit);
		}

		// Token: 0x06001B40 RID: 6976
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_CircleCast(ref Vector2 origin, float radius, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D raycastHit);

		// Token: 0x06001B41 RID: 6977 RVA: 0x00021A60 File Offset: 0x0001FC60
		private static RaycastHit2D[] Internal_CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return Physics2D.INTERNAL_CALL_Internal_CircleCastAll(ref origin, radius, ref direction, distance, ref contactFilter);
		}

		// Token: 0x06001B42 RID: 6978
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RaycastHit2D[] INTERNAL_CALL_Internal_CircleCastAll(ref Vector2 origin, float radius, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter);

		// Token: 0x06001B43 RID: 6979 RVA: 0x00021A84 File Offset: 0x0001FC84
		private static int Internal_CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results)
		{
			return Physics2D.INTERNAL_CALL_Internal_CircleCastNonAlloc(ref origin, radius, ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x06001B44 RID: 6980
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_Internal_CircleCastNonAlloc(ref Vector2 origin, float radius, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results);

		// Token: 0x06001B45 RID: 6981 RVA: 0x00021AA8 File Offset: 0x0001FCA8
		[ExcludeFromDocs]
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.BoxCast(origin, size, angle, direction, distance, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x00021AD4 File Offset: 0x0001FCD4
		[ExcludeFromDocs]
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.BoxCast(origin, size, angle, direction, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x00021B04 File Offset: 0x0001FD04
		[ExcludeFromDocs]
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.BoxCast(origin, size, angle, direction, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x00021B38 File Offset: 0x0001FD38
		[ExcludeFromDocs]
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			float positiveInfinity2 = float.PositiveInfinity;
			return Physics2D.BoxCast(origin, size, angle, direction, positiveInfinity2, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x00021B74 File Offset: 0x0001FD74
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			RaycastHit2D result;
			Physics2D.Internal_BoxCast(origin, size, angle, direction, distance, contactFilter, out result);
			return result;
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x00021BA4 File Offset: 0x0001FDA4
		[ExcludeFromDocs]
		public static RaycastHit2D[] BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.BoxCastAll(origin, size, angle, direction, distance, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x00021BD0 File Offset: 0x0001FDD0
		[ExcludeFromDocs]
		public static RaycastHit2D[] BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.BoxCastAll(origin, size, angle, direction, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x00021C00 File Offset: 0x0001FE00
		[ExcludeFromDocs]
		public static RaycastHit2D[] BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.BoxCastAll(origin, size, angle, direction, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x00021C34 File Offset: 0x0001FE34
		[ExcludeFromDocs]
		public static RaycastHit2D[] BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			float positiveInfinity2 = float.PositiveInfinity;
			return Physics2D.BoxCastAll(origin, size, angle, direction, positiveInfinity2, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x00021C70 File Offset: 0x0001FE70
		public static RaycastHit2D[] BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.Internal_BoxCastAll(origin, size, angle, direction, distance, contactFilter);
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x00021CA0 File Offset: 0x0001FEA0
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.BoxCastNonAlloc(origin, size, angle, direction, results, distance, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x00021CD0 File Offset: 0x0001FED0
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.BoxCastNonAlloc(origin, size, angle, direction, results, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x00021D04 File Offset: 0x0001FF04
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] results, float distance)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.BoxCastNonAlloc(origin, size, angle, direction, results, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x00021D38 File Offset: 0x0001FF38
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] results)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			float positiveInfinity2 = float.PositiveInfinity;
			return Physics2D.BoxCastNonAlloc(origin, size, angle, direction, results, positiveInfinity2, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x00021D74 File Offset: 0x0001FF74
		public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.Internal_BoxCastNonAlloc(origin, size, angle, direction, distance, contactFilter, results);
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x00021DA4 File Offset: 0x0001FFA4
		[ExcludeFromDocs]
		public static int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.BoxCast(origin, size, angle, direction, contactFilter, results, positiveInfinity);
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x00021DD0 File Offset: 0x0001FFD0
		public static int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance)
		{
			return Physics2D.Internal_BoxCastNonAlloc(origin, size, angle, direction, distance, contactFilter, results);
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x00021DF4 File Offset: 0x0001FFF4
		private static void Internal_BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, out RaycastHit2D raycastHit)
		{
			Physics2D.INTERNAL_CALL_Internal_BoxCast(ref origin, ref size, angle, ref direction, distance, ref contactFilter, out raycastHit);
		}

		// Token: 0x06001B57 RID: 6999
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_BoxCast(ref Vector2 origin, ref Vector2 size, float angle, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D raycastHit);

		// Token: 0x06001B58 RID: 7000 RVA: 0x00021E0C File Offset: 0x0002000C
		private static RaycastHit2D[] Internal_BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return Physics2D.INTERNAL_CALL_Internal_BoxCastAll(ref origin, ref size, angle, ref direction, distance, ref contactFilter);
		}

		// Token: 0x06001B59 RID: 7001
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RaycastHit2D[] INTERNAL_CALL_Internal_BoxCastAll(ref Vector2 origin, ref Vector2 size, float angle, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter);

		// Token: 0x06001B5A RID: 7002 RVA: 0x00021E34 File Offset: 0x00020034
		private static int Internal_BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results)
		{
			return Physics2D.INTERNAL_CALL_Internal_BoxCastNonAlloc(ref origin, ref size, angle, ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x06001B5B RID: 7003
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_Internal_BoxCastNonAlloc(ref Vector2 origin, ref Vector2 size, float angle, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results);

		// Token: 0x06001B5C RID: 7004 RVA: 0x00021E5C File Offset: 0x0002005C
		[ExcludeFromDocs]
		public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x00021E8C File Offset: 0x0002008C
		[ExcludeFromDocs]
		public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x00021EC0 File Offset: 0x000200C0
		[ExcludeFromDocs]
		public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x00021EF4 File Offset: 0x000200F4
		[ExcludeFromDocs]
		public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			float positiveInfinity2 = float.PositiveInfinity;
			return Physics2D.CapsuleCast(origin, size, capsuleDirection, angle, direction, positiveInfinity2, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x00021F30 File Offset: 0x00020130
		public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			RaycastHit2D result;
			Physics2D.Internal_CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter, out result);
			return result;
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x00021F64 File Offset: 0x00020164
		[ExcludeFromDocs]
		public static RaycastHit2D[] CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.CapsuleCastAll(origin, size, capsuleDirection, angle, direction, distance, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x00021F94 File Offset: 0x00020194
		[ExcludeFromDocs]
		public static RaycastHit2D[] CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.CapsuleCastAll(origin, size, capsuleDirection, angle, direction, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x00021FC8 File Offset: 0x000201C8
		[ExcludeFromDocs]
		public static RaycastHit2D[] CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.CapsuleCastAll(origin, size, capsuleDirection, angle, direction, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x00021FFC File Offset: 0x000201FC
		[ExcludeFromDocs]
		public static RaycastHit2D[] CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			float positiveInfinity2 = float.PositiveInfinity;
			return Physics2D.CapsuleCastAll(origin, size, capsuleDirection, angle, direction, positiveInfinity2, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x00022038 File Offset: 0x00020238
		public static RaycastHit2D[] CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.Internal_CapsuleCastAll(origin, size, capsuleDirection, angle, direction, distance, contactFilter);
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x00022068 File Offset: 0x00020268
		[ExcludeFromDocs]
		public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.CapsuleCastNonAlloc(origin, size, capsuleDirection, angle, direction, results, distance, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x00022098 File Offset: 0x00020298
		[ExcludeFromDocs]
		public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.CapsuleCastNonAlloc(origin, size, capsuleDirection, angle, direction, results, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x000220CC File Offset: 0x000202CC
		[ExcludeFromDocs]
		public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, RaycastHit2D[] results, float distance)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.CapsuleCastNonAlloc(origin, size, capsuleDirection, angle, direction, results, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x00022104 File Offset: 0x00020304
		[ExcludeFromDocs]
		public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, RaycastHit2D[] results)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			float positiveInfinity2 = float.PositiveInfinity;
			return Physics2D.CapsuleCastNonAlloc(origin, size, capsuleDirection, angle, direction, results, positiveInfinity2, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x00022144 File Offset: 0x00020344
		public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.Internal_CapsuleCastNonAlloc(origin, size, capsuleDirection, angle, direction, distance, contactFilter, results);
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x00022178 File Offset: 0x00020378
		[ExcludeFromDocs]
		public static int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.CapsuleCast(origin, size, capsuleDirection, angle, direction, contactFilter, results, positiveInfinity);
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x000221A4 File Offset: 0x000203A4
		public static int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance)
		{
			return Physics2D.Internal_CapsuleCastNonAlloc(origin, size, capsuleDirection, angle, direction, distance, contactFilter, results);
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x000221CC File Offset: 0x000203CC
		private static void Internal_CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, out RaycastHit2D raycastHit)
		{
			Physics2D.INTERNAL_CALL_Internal_CapsuleCast(ref origin, ref size, capsuleDirection, angle, ref direction, distance, ref contactFilter, out raycastHit);
		}

		// Token: 0x06001B6E RID: 7022
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_CapsuleCast(ref Vector2 origin, ref Vector2 size, CapsuleDirection2D capsuleDirection, float angle, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D raycastHit);

		// Token: 0x06001B6F RID: 7023 RVA: 0x000221E4 File Offset: 0x000203E4
		private static RaycastHit2D[] Internal_CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return Physics2D.INTERNAL_CALL_Internal_CapsuleCastAll(ref origin, ref size, capsuleDirection, angle, ref direction, distance, ref contactFilter);
		}

		// Token: 0x06001B70 RID: 7024
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RaycastHit2D[] INTERNAL_CALL_Internal_CapsuleCastAll(ref Vector2 origin, ref Vector2 size, CapsuleDirection2D capsuleDirection, float angle, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter);

		// Token: 0x06001B71 RID: 7025 RVA: 0x0002220C File Offset: 0x0002040C
		private static int Internal_CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results)
		{
			return Physics2D.INTERNAL_CALL_Internal_CapsuleCastNonAlloc(ref origin, ref size, capsuleDirection, angle, ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x06001B72 RID: 7026
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_Internal_CapsuleCastNonAlloc(ref Vector2 origin, ref Vector2 size, CapsuleDirection2D capsuleDirection, float angle, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results);

		// Token: 0x06001B73 RID: 7027 RVA: 0x00022234 File Offset: 0x00020434
		private static void Internal_GetRayIntersection(Ray ray, float distance, int layerMask, out RaycastHit2D raycastHit)
		{
			Physics2D.INTERNAL_CALL_Internal_GetRayIntersection(ref ray, distance, layerMask, out raycastHit);
		}

		// Token: 0x06001B74 RID: 7028
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_GetRayIntersection(ref Ray ray, float distance, int layerMask, out RaycastHit2D raycastHit);

		// Token: 0x06001B75 RID: 7029 RVA: 0x00022244 File Offset: 0x00020444
		[ExcludeFromDocs]
		public static RaycastHit2D GetRayIntersection(Ray ray, float distance)
		{
			int layerMask = -5;
			return Physics2D.GetRayIntersection(ray, distance, layerMask);
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x00022264 File Offset: 0x00020464
		[ExcludeFromDocs]
		public static RaycastHit2D GetRayIntersection(Ray ray)
		{
			int layerMask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.GetRayIntersection(ray, positiveInfinity, layerMask);
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x0002228C File Offset: 0x0002048C
		public static RaycastHit2D GetRayIntersection(Ray ray, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask)
		{
			RaycastHit2D result;
			Physics2D.Internal_GetRayIntersection(ray, distance, layerMask, out result);
			return result;
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x000222AC File Offset: 0x000204AC
		[RequiredByNativeCode]
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask)
		{
			return Physics2D.INTERNAL_CALL_GetRayIntersectionAll(ref ray, distance, layerMask);
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x000222CC File Offset: 0x000204CC
		[ExcludeFromDocs]
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance)
		{
			int layerMask = -5;
			return Physics2D.INTERNAL_CALL_GetRayIntersectionAll(ref ray, distance, layerMask);
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x000222F0 File Offset: 0x000204F0
		[ExcludeFromDocs]
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray)
		{
			int layerMask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_GetRayIntersectionAll(ref ray, positiveInfinity, layerMask);
		}

		// Token: 0x06001B7B RID: 7035
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RaycastHit2D[] INTERNAL_CALL_GetRayIntersectionAll(ref Ray ray, float distance, int layerMask);

		// Token: 0x06001B7C RID: 7036 RVA: 0x00022318 File Offset: 0x00020518
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask)
		{
			return Physics2D.INTERNAL_CALL_GetRayIntersectionNonAlloc(ref ray, results, distance, layerMask);
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x00022338 File Offset: 0x00020538
		[ExcludeFromDocs]
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance)
		{
			int layerMask = -5;
			return Physics2D.INTERNAL_CALL_GetRayIntersectionNonAlloc(ref ray, results, distance, layerMask);
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x0002235C File Offset: 0x0002055C
		[ExcludeFromDocs]
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results)
		{
			int layerMask = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_GetRayIntersectionNonAlloc(ref ray, results, positiveInfinity, layerMask);
		}

		// Token: 0x06001B7F RID: 7039
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_GetRayIntersectionNonAlloc(ref Ray ray, RaycastHit2D[] results, float distance, int layerMask);

		// Token: 0x06001B80 RID: 7040 RVA: 0x00022384 File Offset: 0x00020584
		[ExcludeFromDocs]
		public static Collider2D OverlapPoint(Vector2 point, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.OverlapPoint(point, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x000223A8 File Offset: 0x000205A8
		[ExcludeFromDocs]
		public static Collider2D OverlapPoint(Vector2 point, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.OverlapPoint(point, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x000223D4 File Offset: 0x000205D4
		[ExcludeFromDocs]
		public static Collider2D OverlapPoint(Vector2 point)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.OverlapPoint(point, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x00022404 File Offset: 0x00020604
		public static Collider2D OverlapPoint(Vector2 point, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.Internal_OverlapPoint(point, contactFilter);
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x0002242C File Offset: 0x0002062C
		[ExcludeFromDocs]
		public static Collider2D[] OverlapPointAll(Vector2 point, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.OverlapPointAll(point, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x00022450 File Offset: 0x00020650
		[ExcludeFromDocs]
		public static Collider2D[] OverlapPointAll(Vector2 point, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.OverlapPointAll(point, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x0002247C File Offset: 0x0002067C
		[ExcludeFromDocs]
		public static Collider2D[] OverlapPointAll(Vector2 point)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.OverlapPointAll(point, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x000224AC File Offset: 0x000206AC
		public static Collider2D[] OverlapPointAll(Vector2 point, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.Internal_OverlapPointAll(point, contactFilter);
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x000224D4 File Offset: 0x000206D4
		[ExcludeFromDocs]
		public static int OverlapPointNonAlloc(Vector2 point, Collider2D[] results, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.OverlapPointNonAlloc(point, results, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x000224FC File Offset: 0x000206FC
		[ExcludeFromDocs]
		public static int OverlapPointNonAlloc(Vector2 point, Collider2D[] results, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.OverlapPointNonAlloc(point, results, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x00022528 File Offset: 0x00020728
		[ExcludeFromDocs]
		public static int OverlapPointNonAlloc(Vector2 point, Collider2D[] results)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.OverlapPointNonAlloc(point, results, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x00022558 File Offset: 0x00020758
		public static int OverlapPointNonAlloc(Vector2 point, Collider2D[] results, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.Internal_OverlapPointNonAlloc(point, contactFilter, results);
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x00022580 File Offset: 0x00020780
		public static int OverlapPoint(Vector2 point, ContactFilter2D contactFilter, Collider2D[] results)
		{
			return Physics2D.Internal_OverlapPointNonAlloc(point, contactFilter, results);
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x000225A0 File Offset: 0x000207A0
		private static Collider2D Internal_OverlapPoint(Vector2 point, ContactFilter2D contactFilter)
		{
			return Physics2D.INTERNAL_CALL_Internal_OverlapPoint(ref point, ref contactFilter);
		}

		// Token: 0x06001B8E RID: 7054
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Collider2D INTERNAL_CALL_Internal_OverlapPoint(ref Vector2 point, ref ContactFilter2D contactFilter);

		// Token: 0x06001B8F RID: 7055 RVA: 0x000225C0 File Offset: 0x000207C0
		private static Collider2D[] Internal_OverlapPointAll(Vector2 point, ContactFilter2D contactFilter)
		{
			return Physics2D.INTERNAL_CALL_Internal_OverlapPointAll(ref point, ref contactFilter);
		}

		// Token: 0x06001B90 RID: 7056
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Collider2D[] INTERNAL_CALL_Internal_OverlapPointAll(ref Vector2 point, ref ContactFilter2D contactFilter);

		// Token: 0x06001B91 RID: 7057 RVA: 0x000225E0 File Offset: 0x000207E0
		private static int Internal_OverlapPointNonAlloc(Vector2 point, ContactFilter2D contactFilter, Collider2D[] results)
		{
			return Physics2D.INTERNAL_CALL_Internal_OverlapPointNonAlloc(ref point, ref contactFilter, results);
		}

		// Token: 0x06001B92 RID: 7058
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_Internal_OverlapPointNonAlloc(ref Vector2 point, ref ContactFilter2D contactFilter, Collider2D[] results);

		// Token: 0x06001B93 RID: 7059 RVA: 0x00022600 File Offset: 0x00020800
		[ExcludeFromDocs]
		public static Collider2D OverlapCircle(Vector2 point, float radius, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.OverlapCircle(point, radius, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x00022628 File Offset: 0x00020828
		[ExcludeFromDocs]
		public static Collider2D OverlapCircle(Vector2 point, float radius, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.OverlapCircle(point, radius, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x00022654 File Offset: 0x00020854
		[ExcludeFromDocs]
		public static Collider2D OverlapCircle(Vector2 point, float radius)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.OverlapCircle(point, radius, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x00022684 File Offset: 0x00020884
		public static Collider2D OverlapCircle(Vector2 point, float radius, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.Internal_OverlapCircle(point, radius, contactFilter);
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x000226AC File Offset: 0x000208AC
		[ExcludeFromDocs]
		public static Collider2D[] OverlapCircleAll(Vector2 point, float radius, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.OverlapCircleAll(point, radius, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x000226D4 File Offset: 0x000208D4
		[ExcludeFromDocs]
		public static Collider2D[] OverlapCircleAll(Vector2 point, float radius, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.OverlapCircleAll(point, radius, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x00022700 File Offset: 0x00020900
		[ExcludeFromDocs]
		public static Collider2D[] OverlapCircleAll(Vector2 point, float radius)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.OverlapCircleAll(point, radius, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x00022730 File Offset: 0x00020930
		public static Collider2D[] OverlapCircleAll(Vector2 point, float radius, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.Internal_OverlapCircleAll(point, radius, contactFilter);
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x00022758 File Offset: 0x00020958
		[ExcludeFromDocs]
		public static int OverlapCircleNonAlloc(Vector2 point, float radius, Collider2D[] results, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.OverlapCircleNonAlloc(point, radius, results, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x00022780 File Offset: 0x00020980
		[ExcludeFromDocs]
		public static int OverlapCircleNonAlloc(Vector2 point, float radius, Collider2D[] results, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.OverlapCircleNonAlloc(point, radius, results, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x000227AC File Offset: 0x000209AC
		[ExcludeFromDocs]
		public static int OverlapCircleNonAlloc(Vector2 point, float radius, Collider2D[] results)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.OverlapCircleNonAlloc(point, radius, results, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x000227DC File Offset: 0x000209DC
		public static int OverlapCircleNonAlloc(Vector2 point, float radius, Collider2D[] results, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.Internal_OverlapCircleNonAlloc(point, radius, contactFilter, results);
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x00022808 File Offset: 0x00020A08
		public static int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, Collider2D[] results)
		{
			return Physics2D.Internal_OverlapCircleNonAlloc(point, radius, contactFilter, results);
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x00022828 File Offset: 0x00020A28
		private static Collider2D Internal_OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter)
		{
			return Physics2D.INTERNAL_CALL_Internal_OverlapCircle(ref point, radius, ref contactFilter);
		}

		// Token: 0x06001BA1 RID: 7073
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Collider2D INTERNAL_CALL_Internal_OverlapCircle(ref Vector2 point, float radius, ref ContactFilter2D contactFilter);

		// Token: 0x06001BA2 RID: 7074 RVA: 0x00022848 File Offset: 0x00020A48
		private static Collider2D[] Internal_OverlapCircleAll(Vector2 point, float radius, ContactFilter2D contactFilter)
		{
			return Physics2D.INTERNAL_CALL_Internal_OverlapCircleAll(ref point, radius, ref contactFilter);
		}

		// Token: 0x06001BA3 RID: 7075
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Collider2D[] INTERNAL_CALL_Internal_OverlapCircleAll(ref Vector2 point, float radius, ref ContactFilter2D contactFilter);

		// Token: 0x06001BA4 RID: 7076 RVA: 0x00022868 File Offset: 0x00020A68
		private static int Internal_OverlapCircleNonAlloc(Vector2 point, float radius, ContactFilter2D contactFilter, Collider2D[] results)
		{
			return Physics2D.INTERNAL_CALL_Internal_OverlapCircleNonAlloc(ref point, radius, ref contactFilter, results);
		}

		// Token: 0x06001BA5 RID: 7077
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_Internal_OverlapCircleNonAlloc(ref Vector2 point, float radius, ref ContactFilter2D contactFilter, Collider2D[] results);

		// Token: 0x06001BA6 RID: 7078 RVA: 0x00022888 File Offset: 0x00020A88
		[ExcludeFromDocs]
		public static Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.OverlapBox(point, size, angle, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x000228B0 File Offset: 0x00020AB0
		[ExcludeFromDocs]
		public static Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.OverlapBox(point, size, angle, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x000228DC File Offset: 0x00020ADC
		[ExcludeFromDocs]
		public static Collider2D OverlapBox(Vector2 point, Vector2 size, float angle)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.OverlapBox(point, size, angle, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x0002290C File Offset: 0x00020B0C
		public static Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.Internal_OverlapBox(point, size, angle, contactFilter);
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x00022938 File Offset: 0x00020B38
		[ExcludeFromDocs]
		public static Collider2D[] OverlapBoxAll(Vector2 point, Vector2 size, float angle, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.OverlapBoxAll(point, size, angle, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x00022960 File Offset: 0x00020B60
		[ExcludeFromDocs]
		public static Collider2D[] OverlapBoxAll(Vector2 point, Vector2 size, float angle, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.OverlapBoxAll(point, size, angle, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x0002298C File Offset: 0x00020B8C
		[ExcludeFromDocs]
		public static Collider2D[] OverlapBoxAll(Vector2 point, Vector2 size, float angle)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.OverlapBoxAll(point, size, angle, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x000229BC File Offset: 0x00020BBC
		public static Collider2D[] OverlapBoxAll(Vector2 point, Vector2 size, float angle, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.Internal_OverlapBoxAll(point, size, angle, contactFilter);
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x000229E8 File Offset: 0x00020BE8
		[ExcludeFromDocs]
		public static int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Collider2D[] results, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.OverlapBoxNonAlloc(point, size, angle, results, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x00022A14 File Offset: 0x00020C14
		[ExcludeFromDocs]
		public static int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Collider2D[] results, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.OverlapBoxNonAlloc(point, size, angle, results, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x00022A44 File Offset: 0x00020C44
		[ExcludeFromDocs]
		public static int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Collider2D[] results)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.OverlapBoxNonAlloc(point, size, angle, results, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x00022A74 File Offset: 0x00020C74
		public static int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Collider2D[] results, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.Internal_OverlapBoxNonAlloc(point, size, angle, contactFilter, results);
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x00022AA0 File Offset: 0x00020CA0
		public static int OverlapBox(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, Collider2D[] results)
		{
			return Physics2D.Internal_OverlapBoxNonAlloc(point, size, angle, contactFilter, results);
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x00022AC0 File Offset: 0x00020CC0
		private static Collider2D Internal_OverlapBox(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter)
		{
			return Physics2D.INTERNAL_CALL_Internal_OverlapBox(ref point, ref size, angle, ref contactFilter);
		}

		// Token: 0x06001BB4 RID: 7092
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Collider2D INTERNAL_CALL_Internal_OverlapBox(ref Vector2 point, ref Vector2 size, float angle, ref ContactFilter2D contactFilter);

		// Token: 0x06001BB5 RID: 7093 RVA: 0x00022AE4 File Offset: 0x00020CE4
		private static Collider2D[] Internal_OverlapBoxAll(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter)
		{
			return Physics2D.INTERNAL_CALL_Internal_OverlapBoxAll(ref point, ref size, angle, ref contactFilter);
		}

		// Token: 0x06001BB6 RID: 7094
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Collider2D[] INTERNAL_CALL_Internal_OverlapBoxAll(ref Vector2 point, ref Vector2 size, float angle, ref ContactFilter2D contactFilter);

		// Token: 0x06001BB7 RID: 7095 RVA: 0x00022B08 File Offset: 0x00020D08
		private static int Internal_OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, Collider2D[] results)
		{
			return Physics2D.INTERNAL_CALL_Internal_OverlapBoxNonAlloc(ref point, ref size, angle, ref contactFilter, results);
		}

		// Token: 0x06001BB8 RID: 7096
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_Internal_OverlapBoxNonAlloc(ref Vector2 point, ref Vector2 size, float angle, ref ContactFilter2D contactFilter, Collider2D[] results);

		// Token: 0x06001BB9 RID: 7097 RVA: 0x00022B2C File Offset: 0x00020D2C
		[ExcludeFromDocs]
		public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.OverlapArea(pointA, pointB, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x00022B54 File Offset: 0x00020D54
		[ExcludeFromDocs]
		public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.OverlapArea(pointA, pointB, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x00022B80 File Offset: 0x00020D80
		[ExcludeFromDocs]
		public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.OverlapArea(pointA, pointB, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x00022BB0 File Offset: 0x00020DB0
		public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.Internal_OverlapArea(pointA, pointB, contactFilter);
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x00022BD8 File Offset: 0x00020DD8
		[ExcludeFromDocs]
		public static Collider2D[] OverlapAreaAll(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.OverlapAreaAll(pointA, pointB, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x00022C00 File Offset: 0x00020E00
		[ExcludeFromDocs]
		public static Collider2D[] OverlapAreaAll(Vector2 pointA, Vector2 pointB, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.OverlapAreaAll(pointA, pointB, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x00022C2C File Offset: 0x00020E2C
		[ExcludeFromDocs]
		public static Collider2D[] OverlapAreaAll(Vector2 pointA, Vector2 pointB)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.OverlapAreaAll(pointA, pointB, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x00022C5C File Offset: 0x00020E5C
		public static Collider2D[] OverlapAreaAll(Vector2 pointA, Vector2 pointB, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.Internal_OverlapAreaAll(pointA, pointB, contactFilter);
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x00022C84 File Offset: 0x00020E84
		[ExcludeFromDocs]
		public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Collider2D[] results, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.OverlapAreaNonAlloc(pointA, pointB, results, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x00022CAC File Offset: 0x00020EAC
		[ExcludeFromDocs]
		public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Collider2D[] results, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.OverlapAreaNonAlloc(pointA, pointB, results, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x00022CD8 File Offset: 0x00020ED8
		[ExcludeFromDocs]
		public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Collider2D[] results)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.OverlapAreaNonAlloc(pointA, pointB, results, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x00022D08 File Offset: 0x00020F08
		public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Collider2D[] results, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.Internal_OverlapAreaNonAlloc(pointA, pointB, contactFilter, results);
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x00022D34 File Offset: 0x00020F34
		public static int OverlapArea(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, Collider2D[] results)
		{
			return Physics2D.Internal_OverlapAreaNonAlloc(pointA, pointB, contactFilter, results);
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x00022D54 File Offset: 0x00020F54
		private static Collider2D Internal_OverlapArea(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter)
		{
			return Physics2D.INTERNAL_CALL_Internal_OverlapArea(ref pointA, ref pointB, ref contactFilter);
		}

		// Token: 0x06001BC7 RID: 7111
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Collider2D INTERNAL_CALL_Internal_OverlapArea(ref Vector2 pointA, ref Vector2 pointB, ref ContactFilter2D contactFilter);

		// Token: 0x06001BC8 RID: 7112 RVA: 0x00022D74 File Offset: 0x00020F74
		private static Collider2D[] Internal_OverlapAreaAll(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter)
		{
			return Physics2D.INTERNAL_CALL_Internal_OverlapAreaAll(ref pointA, ref pointB, ref contactFilter);
		}

		// Token: 0x06001BC9 RID: 7113
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Collider2D[] INTERNAL_CALL_Internal_OverlapAreaAll(ref Vector2 pointA, ref Vector2 pointB, ref ContactFilter2D contactFilter);

		// Token: 0x06001BCA RID: 7114 RVA: 0x00022D94 File Offset: 0x00020F94
		private static int Internal_OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, Collider2D[] results)
		{
			return Physics2D.INTERNAL_CALL_Internal_OverlapAreaNonAlloc(ref pointA, ref pointB, ref contactFilter, results);
		}

		// Token: 0x06001BCB RID: 7115
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_Internal_OverlapAreaNonAlloc(ref Vector2 pointA, ref Vector2 pointB, ref ContactFilter2D contactFilter, Collider2D[] results);

		// Token: 0x06001BCC RID: 7116 RVA: 0x00022DB8 File Offset: 0x00020FB8
		[ExcludeFromDocs]
		public static Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.OverlapCapsule(point, size, direction, angle, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x00022DE4 File Offset: 0x00020FE4
		[ExcludeFromDocs]
		public static Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.OverlapCapsule(point, size, direction, angle, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x00022E14 File Offset: 0x00021014
		[ExcludeFromDocs]
		public static Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.OverlapCapsule(point, size, direction, angle, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x00022E44 File Offset: 0x00021044
		public static Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.Internal_OverlapCapsule(point, size, direction, angle, contactFilter);
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x00022E70 File Offset: 0x00021070
		[ExcludeFromDocs]
		public static Collider2D[] OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.OverlapCapsuleAll(point, size, direction, angle, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x00022E9C File Offset: 0x0002109C
		[ExcludeFromDocs]
		public static Collider2D[] OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.OverlapCapsuleAll(point, size, direction, angle, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x00022ECC File Offset: 0x000210CC
		[ExcludeFromDocs]
		public static Collider2D[] OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.OverlapCapsuleAll(point, size, direction, angle, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x00022EFC File Offset: 0x000210FC
		public static Collider2D[] OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.Internal_OverlapCapsuleAll(point, size, direction, angle, contactFilter);
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x00022F28 File Offset: 0x00021128
		[ExcludeFromDocs]
		public static int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Collider2D[] results, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.OverlapCapsuleNonAlloc(point, size, direction, angle, results, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x00022F54 File Offset: 0x00021154
		[ExcludeFromDocs]
		public static int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Collider2D[] results, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.OverlapCapsuleNonAlloc(point, size, direction, angle, results, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x00022F84 File Offset: 0x00021184
		[ExcludeFromDocs]
		public static int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Collider2D[] results)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int layerMask = -5;
			return Physics2D.OverlapCapsuleNonAlloc(point, size, direction, angle, results, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x00022FB8 File Offset: 0x000211B8
		public static int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Collider2D[] results, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.Internal_OverlapCapsuleNonAlloc(point, size, direction, angle, contactFilter, results);
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x00022FE8 File Offset: 0x000211E8
		public static int OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, Collider2D[] results)
		{
			return Physics2D.Internal_OverlapCapsuleNonAlloc(point, size, direction, angle, contactFilter, results);
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x0002300C File Offset: 0x0002120C
		private static Collider2D Internal_OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter)
		{
			return Physics2D.INTERNAL_CALL_Internal_OverlapCapsule(ref point, ref size, direction, angle, ref contactFilter);
		}

		// Token: 0x06001BDA RID: 7130
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Collider2D INTERNAL_CALL_Internal_OverlapCapsule(ref Vector2 point, ref Vector2 size, CapsuleDirection2D direction, float angle, ref ContactFilter2D contactFilter);

		// Token: 0x06001BDB RID: 7131 RVA: 0x00023030 File Offset: 0x00021230
		private static Collider2D[] Internal_OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter)
		{
			return Physics2D.INTERNAL_CALL_Internal_OverlapCapsuleAll(ref point, ref size, direction, angle, ref contactFilter);
		}

		// Token: 0x06001BDC RID: 7132
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Collider2D[] INTERNAL_CALL_Internal_OverlapCapsuleAll(ref Vector2 point, ref Vector2 size, CapsuleDirection2D direction, float angle, ref ContactFilter2D contactFilter);

		// Token: 0x06001BDD RID: 7133 RVA: 0x00023054 File Offset: 0x00021254
		private static int Internal_OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, Collider2D[] results)
		{
			return Physics2D.INTERNAL_CALL_Internal_OverlapCapsuleNonAlloc(ref point, ref size, direction, angle, ref contactFilter, results);
		}

		// Token: 0x06001BDE RID: 7134
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_Internal_OverlapCapsuleNonAlloc(ref Vector2 point, ref Vector2 size, CapsuleDirection2D direction, float angle, ref ContactFilter2D contactFilter, Collider2D[] results);

		// Token: 0x06001BDF RID: 7135 RVA: 0x00023078 File Offset: 0x00021278
		public static int OverlapCollider(Collider2D collider, ContactFilter2D contactFilter, Collider2D[] results)
		{
			return Physics2D.INTERNAL_CALL_OverlapCollider(collider, ref contactFilter, results);
		}

		// Token: 0x06001BE0 RID: 7136
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_OverlapCollider(Collider2D collider, ref ContactFilter2D contactFilter, Collider2D[] results);

		// Token: 0x06001BE1 RID: 7137
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Rigidbody2D GetRigidbodyFromInstanceID(int instanceID);

		// Token: 0x06001BE2 RID: 7138
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Collider2D GetColliderFromInstanceID(int instanceID);

		// Token: 0x06001BE3 RID: 7139 RVA: 0x00023098 File Offset: 0x00021298
		private static int GetColliderContacts(Collider2D collider, ContactFilter2D contactFilter, ContactPoint2D[] results)
		{
			return Physics2D.INTERNAL_CALL_GetColliderContacts(collider, ref contactFilter, results);
		}

		// Token: 0x06001BE4 RID: 7140
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_GetColliderContacts(Collider2D collider, ref ContactFilter2D contactFilter, ContactPoint2D[] results);

		// Token: 0x06001BE5 RID: 7141 RVA: 0x000230B8 File Offset: 0x000212B8
		private static int GetRigidbodyContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, ContactPoint2D[] results)
		{
			return Physics2D.INTERNAL_CALL_GetRigidbodyContacts(rigidbody, ref contactFilter, results);
		}

		// Token: 0x06001BE6 RID: 7142
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_GetRigidbodyContacts(Rigidbody2D rigidbody, ref ContactFilter2D contactFilter, ContactPoint2D[] results);

		// Token: 0x06001BE7 RID: 7143 RVA: 0x000230D8 File Offset: 0x000212D8
		private static int GetColliderContactsCollidersOnly(Collider2D collider, ContactFilter2D contactFilter, Collider2D[] results)
		{
			return Physics2D.INTERNAL_CALL_GetColliderContactsCollidersOnly(collider, ref contactFilter, results);
		}

		// Token: 0x06001BE8 RID: 7144
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_GetColliderContactsCollidersOnly(Collider2D collider, ref ContactFilter2D contactFilter, Collider2D[] results);

		// Token: 0x06001BE9 RID: 7145 RVA: 0x000230F8 File Offset: 0x000212F8
		private static int GetRigidbodyContactsCollidersOnly(Rigidbody2D rigidbody, ContactFilter2D contactFilter, Collider2D[] results)
		{
			return Physics2D.INTERNAL_CALL_GetRigidbodyContactsCollidersOnly(rigidbody, ref contactFilter, results);
		}

		// Token: 0x06001BEA RID: 7146
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_GetRigidbodyContactsCollidersOnly(Rigidbody2D rigidbody, ref ContactFilter2D contactFilter, Collider2D[] results);

		// Token: 0x06001BEB RID: 7147 RVA: 0x00023118 File Offset: 0x00021318
		public static int GetContacts(Collider2D collider, ContactPoint2D[] contacts)
		{
			return Physics2D.GetColliderContacts(collider, default(ContactFilter2D).NoFilter(), contacts);
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x00023144 File Offset: 0x00021344
		public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, ContactPoint2D[] contacts)
		{
			return Physics2D.GetColliderContacts(collider, contactFilter, contacts);
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x00023164 File Offset: 0x00021364
		public static int GetContacts(Collider2D collider, Collider2D[] colliders)
		{
			return Physics2D.GetColliderContactsCollidersOnly(collider, default(ContactFilter2D).NoFilter(), colliders);
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x00023190 File Offset: 0x00021390
		public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, Collider2D[] colliders)
		{
			return Physics2D.GetColliderContactsCollidersOnly(collider, contactFilter, colliders);
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x000231B0 File Offset: 0x000213B0
		public static int GetContacts(Rigidbody2D rigidbody, ContactPoint2D[] contacts)
		{
			return Physics2D.GetRigidbodyContacts(rigidbody, default(ContactFilter2D).NoFilter(), contacts);
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x000231DC File Offset: 0x000213DC
		public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, ContactPoint2D[] contacts)
		{
			return Physics2D.GetRigidbodyContacts(rigidbody, contactFilter, contacts);
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x000231FC File Offset: 0x000213FC
		public static int GetContacts(Rigidbody2D rigidbody, Collider2D[] colliders)
		{
			return Physics2D.GetRigidbodyContactsCollidersOnly(rigidbody, default(ContactFilter2D).NoFilter(), colliders);
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x00023228 File Offset: 0x00021428
		public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, Collider2D[] colliders)
		{
			return Physics2D.GetRigidbodyContactsCollidersOnly(rigidbody, contactFilter, colliders);
		}

		// Token: 0x040003F9 RID: 1017
		public const int IgnoreRaycastLayer = 4;

		// Token: 0x040003FA RID: 1018
		public const int DefaultRaycastLayers = -5;

		// Token: 0x040003FB RID: 1019
		public const int AllLayers = -1;

		// Token: 0x040003FC RID: 1020
		private static List<Rigidbody2D> m_LastDisabledRigidbody2D = new List<Rigidbody2D>();
	}
}
