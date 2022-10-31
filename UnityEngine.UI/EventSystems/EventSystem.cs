using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine.Serialization;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000015 RID: 21
	[AddComponentMenu("Event/Event System")]
	public class EventSystem : UIBehaviour
	{
		// Token: 0x06000012 RID: 18 RVA: 0x000020B4 File Offset: 0x000004B4
		protected EventSystem()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000020D8 File Offset: 0x000004D8
		// (set) Token: 0x06000014 RID: 20 RVA: 0x000020F1 File Offset: 0x000004F1
		public static EventSystem current { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000020FC File Offset: 0x000004FC
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002117 File Offset: 0x00000517
		public bool sendNavigationEvents
		{
			get
			{
				return this.m_sendNavigationEvents;
			}
			set
			{
				this.m_sendNavigationEvents = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002124 File Offset: 0x00000524
		// (set) Token: 0x06000018 RID: 24 RVA: 0x0000213F File Offset: 0x0000053F
		public int pixelDragThreshold
		{
			get
			{
				return this.m_DragThreshold;
			}
			set
			{
				this.m_DragThreshold = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000019 RID: 25 RVA: 0x0000214C File Offset: 0x0000054C
		public BaseInputModule currentInputModule
		{
			get
			{
				return this.m_CurrentInputModule;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002168 File Offset: 0x00000568
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002183 File Offset: 0x00000583
		public GameObject firstSelectedGameObject
		{
			get
			{
				return this.m_FirstSelected;
			}
			set
			{
				this.m_FirstSelected = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002190 File Offset: 0x00000590
		public GameObject currentSelectedGameObject
		{
			get
			{
				return this.m_CurrentSelected;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000021AC File Offset: 0x000005AC
		[Obsolete("lastSelectedGameObject is no longer supported")]
		public GameObject lastSelectedGameObject
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000021C4 File Offset: 0x000005C4
		public void UpdateModules()
		{
			base.GetComponents<BaseInputModule>(this.m_SystemInputModules);
			for (int i = this.m_SystemInputModules.Count - 1; i >= 0; i--)
			{
				if (!this.m_SystemInputModules[i] || !this.m_SystemInputModules[i].IsActive())
				{
					this.m_SystemInputModules.RemoveAt(i);
				}
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001F RID: 31 RVA: 0x0000223C File Offset: 0x0000063C
		public bool alreadySelecting
		{
			get
			{
				return this.m_SelectionGuard;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002258 File Offset: 0x00000658
		public void SetSelectedGameObject(GameObject selected, BaseEventData pointer)
		{
			if (this.m_SelectionGuard)
			{
				Debug.LogError("Attempting to select " + selected + "while already selecting an object.");
			}
			else
			{
				this.m_SelectionGuard = true;
				if (selected == this.m_CurrentSelected)
				{
					this.m_SelectionGuard = false;
				}
				else
				{
					ExecuteEvents.Execute<IDeselectHandler>(this.m_CurrentSelected, pointer, ExecuteEvents.deselectHandler);
					this.m_CurrentSelected = selected;
					ExecuteEvents.Execute<ISelectHandler>(this.m_CurrentSelected, pointer, ExecuteEvents.selectHandler);
					this.m_SelectionGuard = false;
				}
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000022E4 File Offset: 0x000006E4
		private BaseEventData baseEventDataCache
		{
			get
			{
				if (this.m_DummyData == null)
				{
					this.m_DummyData = new BaseEventData(this);
				}
				return this.m_DummyData;
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002316 File Offset: 0x00000716
		public void SetSelectedGameObject(GameObject selected)
		{
			this.SetSelectedGameObject(selected, this.baseEventDataCache);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002328 File Offset: 0x00000728
		private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs)
		{
			if (lhs.module != rhs.module)
			{
				if (lhs.module.eventCamera != null && rhs.module.eventCamera != null && lhs.module.eventCamera.depth != rhs.module.eventCamera.depth)
				{
					if (lhs.module.eventCamera.depth < rhs.module.eventCamera.depth)
					{
						return 1;
					}
					if (lhs.module.eventCamera.depth == rhs.module.eventCamera.depth)
					{
						return 0;
					}
					return -1;
				}
				else
				{
					if (lhs.module.sortOrderPriority != rhs.module.sortOrderPriority)
					{
						return rhs.module.sortOrderPriority.CompareTo(lhs.module.sortOrderPriority);
					}
					if (lhs.module.renderOrderPriority != rhs.module.renderOrderPriority)
					{
						return rhs.module.renderOrderPriority.CompareTo(lhs.module.renderOrderPriority);
					}
				}
			}
			int result;
			if (lhs.sortingLayer != rhs.sortingLayer)
			{
				int layerValueFromID = SortingLayer.GetLayerValueFromID(rhs.sortingLayer);
				int layerValueFromID2 = SortingLayer.GetLayerValueFromID(lhs.sortingLayer);
				result = layerValueFromID.CompareTo(layerValueFromID2);
			}
			else if (lhs.sortingOrder != rhs.sortingOrder)
			{
				result = rhs.sortingOrder.CompareTo(lhs.sortingOrder);
			}
			else if (lhs.depth != rhs.depth)
			{
				result = rhs.depth.CompareTo(lhs.depth);
			}
			else if (lhs.distance != rhs.distance)
			{
				result = lhs.distance.CompareTo(rhs.distance);
			}
			else
			{
				result = lhs.index.CompareTo(rhs.index);
			}
			return result;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000256C File Offset: 0x0000096C
		public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults)
		{
			raycastResults.Clear();
			List<BaseRaycaster> raycasters = RaycasterManager.GetRaycasters();
			for (int i = 0; i < raycasters.Count; i++)
			{
				BaseRaycaster baseRaycaster = raycasters[i];
				if (!(baseRaycaster == null) && baseRaycaster.IsActive())
				{
					baseRaycaster.Raycast(eventData, raycastResults);
				}
			}
			raycastResults.Sort(EventSystem.s_RaycastComparer);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000025D8 File Offset: 0x000009D8
		public bool IsPointerOverGameObject()
		{
			return this.IsPointerOverGameObject(-1);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000025F4 File Offset: 0x000009F4
		public bool IsPointerOverGameObject(int pointerId)
		{
			return !(this.m_CurrentInputModule == null) && this.m_CurrentInputModule.IsPointerOverGameObject(pointerId);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000262D File Offset: 0x00000A2D
		protected override void OnEnable()
		{
			base.OnEnable();
			if (EventSystem.current == null)
			{
				EventSystem.current = this;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000264C File Offset: 0x00000A4C
		protected override void OnDisable()
		{
			if (this.m_CurrentInputModule != null)
			{
				this.m_CurrentInputModule.DeactivateModule();
				this.m_CurrentInputModule = null;
			}
			if (EventSystem.current == this)
			{
				EventSystem.current = null;
			}
			base.OnDisable();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000269C File Offset: 0x00000A9C
		private void TickModules()
		{
			for (int i = 0; i < this.m_SystemInputModules.Count; i++)
			{
				if (this.m_SystemInputModules[i] != null)
				{
					this.m_SystemInputModules[i].UpdateModule();
				}
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000026F0 File Offset: 0x00000AF0
		protected virtual void OnApplicationFocus(bool hasFocus)
		{
			if (SystemInfo.operatingSystemFamily == OperatingSystemFamily.Windows || SystemInfo.operatingSystemFamily == OperatingSystemFamily.Linux || SystemInfo.operatingSystemFamily == OperatingSystemFamily.MacOSX)
			{
				this.m_Paused = !hasFocus;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002720 File Offset: 0x00000B20
		protected virtual void Update()
		{
			if (!(EventSystem.current != this) && !this.m_Paused)
			{
				this.TickModules();
				bool flag = false;
				for (int i = 0; i < this.m_SystemInputModules.Count; i++)
				{
					BaseInputModule baseInputModule = this.m_SystemInputModules[i];
					if (baseInputModule.IsModuleSupported() && baseInputModule.ShouldActivateModule())
					{
						if (this.m_CurrentInputModule != baseInputModule)
						{
							this.ChangeEventModule(baseInputModule);
							flag = true;
						}
						break;
					}
				}
				if (this.m_CurrentInputModule == null)
				{
					for (int j = 0; j < this.m_SystemInputModules.Count; j++)
					{
						BaseInputModule baseInputModule2 = this.m_SystemInputModules[j];
						if (baseInputModule2.IsModuleSupported())
						{
							this.ChangeEventModule(baseInputModule2);
							flag = true;
							break;
						}
					}
				}
				if (!flag && this.m_CurrentInputModule != null)
				{
					this.m_CurrentInputModule.Process();
				}
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002838 File Offset: 0x00000C38
		private void ChangeEventModule(BaseInputModule module)
		{
			if (!(this.m_CurrentInputModule == module))
			{
				if (this.m_CurrentInputModule != null)
				{
					this.m_CurrentInputModule.DeactivateModule();
				}
				if (module != null)
				{
					module.ActivateModule();
				}
				this.m_CurrentInputModule = module;
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002894 File Offset: 0x00000C94
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("<b>Selected:</b>" + this.currentSelectedGameObject);
			stringBuilder.AppendLine();
			stringBuilder.AppendLine();
			stringBuilder.AppendLine((!(this.m_CurrentInputModule != null)) ? "No module" : this.m_CurrentInputModule.ToString());
			return stringBuilder.ToString();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002907 File Offset: 0x00000D07
		// Note: this type is marked as 'beforefieldinit'.
		static EventSystem()
		{
			if (EventSystem.<>f__mg$cache0 == null)
			{
				EventSystem.<>f__mg$cache0 = new Comparison<RaycastResult>(EventSystem.RaycastComparer);
			}
			EventSystem.s_RaycastComparer = EventSystem.<>f__mg$cache0;
		}

		// Token: 0x04000004 RID: 4
		private List<BaseInputModule> m_SystemInputModules = new List<BaseInputModule>();

		// Token: 0x04000005 RID: 5
		private BaseInputModule m_CurrentInputModule;

		// Token: 0x04000007 RID: 7
		[SerializeField]
		[FormerlySerializedAs("m_Selected")]
		private GameObject m_FirstSelected;

		// Token: 0x04000008 RID: 8
		[SerializeField]
		private bool m_sendNavigationEvents = true;

		// Token: 0x04000009 RID: 9
		[SerializeField]
		private int m_DragThreshold = 5;

		// Token: 0x0400000A RID: 10
		private GameObject m_CurrentSelected;

		// Token: 0x0400000B RID: 11
		private bool m_Paused;

		// Token: 0x0400000C RID: 12
		private bool m_SelectionGuard;

		// Token: 0x0400000D RID: 13
		private BaseEventData m_DummyData;

		// Token: 0x0400000E RID: 14
		private static readonly Comparison<RaycastResult> s_RaycastComparer;

		// Token: 0x0400000F RID: 15
		[CompilerGenerated]
		private static Comparison<RaycastResult> <>f__mg$cache0;
	}
}
