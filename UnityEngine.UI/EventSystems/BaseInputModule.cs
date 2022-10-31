using System;
using System.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000027 RID: 39
	[RequireComponent(typeof(EventSystem))]
	public abstract class BaseInputModule : UIBehaviour
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00003E58 File Offset: 0x00002258
		public BaseInput input
		{
			get
			{
				BaseInput result;
				if (this.m_InputOverride != null)
				{
					result = this.m_InputOverride;
				}
				else
				{
					if (this.m_DefaultInput == null)
					{
						BaseInput[] components = base.GetComponents<BaseInput>();
						foreach (BaseInput baseInput in components)
						{
							if (baseInput != null && baseInput.GetType() == typeof(BaseInput))
							{
								this.m_DefaultInput = baseInput;
								break;
							}
						}
						if (this.m_DefaultInput == null)
						{
							this.m_DefaultInput = base.gameObject.AddComponent<BaseInput>();
						}
					}
					result = this.m_DefaultInput;
				}
				return result;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00003F1C File Offset: 0x0000231C
		protected EventSystem eventSystem
		{
			get
			{
				return this.m_EventSystem;
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00003F37 File Offset: 0x00002337
		protected override void OnEnable()
		{
			base.OnEnable();
			this.m_EventSystem = base.GetComponent<EventSystem>();
			this.m_EventSystem.UpdateModules();
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00003F57 File Offset: 0x00002357
		protected override void OnDisable()
		{
			this.m_EventSystem.UpdateModules();
			base.OnDisable();
		}

		// Token: 0x060000DE RID: 222
		public abstract void Process();

		// Token: 0x060000DF RID: 223 RVA: 0x00003F6C File Offset: 0x0000236C
		protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates)
		{
			for (int i = 0; i < candidates.Count; i++)
			{
				if (!(candidates[i].gameObject == null))
				{
					return candidates[i];
				}
			}
			return default(RaycastResult);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00003FD0 File Offset: 0x000023D0
		protected static MoveDirection DetermineMoveDirection(float x, float y)
		{
			return BaseInputModule.DetermineMoveDirection(x, y, 0.6f);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00003FF4 File Offset: 0x000023F4
		protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone)
		{
			Vector2 vector = new Vector2(x, y);
			MoveDirection result;
			if (vector.sqrMagnitude < deadZone * deadZone)
			{
				result = MoveDirection.None;
			}
			else if (Mathf.Abs(x) > Mathf.Abs(y))
			{
				if (x > 0f)
				{
					result = MoveDirection.Right;
				}
				else
				{
					result = MoveDirection.Left;
				}
			}
			else if (y > 0f)
			{
				result = MoveDirection.Up;
			}
			else
			{
				result = MoveDirection.Down;
			}
			return result;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00004068 File Offset: 0x00002468
		protected static GameObject FindCommonRoot(GameObject g1, GameObject g2)
		{
			GameObject result;
			if (g1 == null || g2 == null)
			{
				result = null;
			}
			else
			{
				Transform transform = g1.transform;
				while (transform != null)
				{
					Transform transform2 = g2.transform;
					while (transform2 != null)
					{
						if (transform == transform2)
						{
							return transform.gameObject;
						}
						transform2 = transform2.parent;
					}
					transform = transform.parent;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000040F8 File Offset: 0x000024F8
		protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget)
		{
			if (newEnterTarget == null || currentPointerData.pointerEnter == null)
			{
				for (int i = 0; i < currentPointerData.hovered.Count; i++)
				{
					ExecuteEvents.Execute<IPointerExitHandler>(currentPointerData.hovered[i], currentPointerData, ExecuteEvents.pointerExitHandler);
				}
				currentPointerData.hovered.Clear();
				if (newEnterTarget == null)
				{
					currentPointerData.pointerEnter = newEnterTarget;
					return;
				}
			}
			if (!(currentPointerData.pointerEnter == newEnterTarget) || !newEnterTarget)
			{
				GameObject gameObject = BaseInputModule.FindCommonRoot(currentPointerData.pointerEnter, newEnterTarget);
				if (currentPointerData.pointerEnter != null)
				{
					Transform transform = currentPointerData.pointerEnter.transform;
					while (transform != null)
					{
						if (gameObject != null && gameObject.transform == transform)
						{
							break;
						}
						ExecuteEvents.Execute<IPointerExitHandler>(transform.gameObject, currentPointerData, ExecuteEvents.pointerExitHandler);
						currentPointerData.hovered.Remove(transform.gameObject);
						transform = transform.parent;
					}
				}
				currentPointerData.pointerEnter = newEnterTarget;
				if (newEnterTarget != null)
				{
					Transform transform2 = newEnterTarget.transform;
					while (transform2 != null && transform2.gameObject != gameObject)
					{
						ExecuteEvents.Execute<IPointerEnterHandler>(transform2.gameObject, currentPointerData, ExecuteEvents.pointerEnterHandler);
						currentPointerData.hovered.Add(transform2.gameObject);
						transform2 = transform2.parent;
					}
				}
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00004294 File Offset: 0x00002694
		protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone)
		{
			if (this.m_AxisEventData == null)
			{
				this.m_AxisEventData = new AxisEventData(this.eventSystem);
			}
			this.m_AxisEventData.Reset();
			this.m_AxisEventData.moveVector = new Vector2(x, y);
			this.m_AxisEventData.moveDir = BaseInputModule.DetermineMoveDirection(x, y, moveDeadZone);
			return this.m_AxisEventData;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000042FC File Offset: 0x000026FC
		protected virtual BaseEventData GetBaseEventData()
		{
			if (this.m_BaseEventData == null)
			{
				this.m_BaseEventData = new BaseEventData(this.eventSystem);
			}
			this.m_BaseEventData.Reset();
			return this.m_BaseEventData;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00004340 File Offset: 0x00002740
		public virtual bool IsPointerOverGameObject(int pointerId)
		{
			return false;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00004358 File Offset: 0x00002758
		public virtual bool ShouldActivateModule()
		{
			return base.enabled && base.gameObject.activeInHierarchy;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00004386 File Offset: 0x00002786
		public virtual void DeactivateModule()
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00004389 File Offset: 0x00002789
		public virtual void ActivateModule()
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000438C File Offset: 0x0000278C
		public virtual void UpdateModule()
		{
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00004390 File Offset: 0x00002790
		public virtual bool IsModuleSupported()
		{
			return true;
		}

		// Token: 0x0400007D RID: 125
		[NonSerialized]
		protected List<RaycastResult> m_RaycastResultCache = new List<RaycastResult>();

		// Token: 0x0400007E RID: 126
		private AxisEventData m_AxisEventData;

		// Token: 0x0400007F RID: 127
		private EventSystem m_EventSystem;

		// Token: 0x04000080 RID: 128
		private BaseEventData m_BaseEventData;

		// Token: 0x04000081 RID: 129
		protected BaseInput m_InputOverride;

		// Token: 0x04000082 RID: 130
		private BaseInput m_DefaultInput;
	}
}
