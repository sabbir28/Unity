using System;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000016 RID: 22
	[AddComponentMenu("Event/Event Trigger")]
	public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler, IEventSystemHandler
	{
		// Token: 0x0600002F RID: 47 RVA: 0x0000292B File Offset: 0x00000D2B
		protected EventTrigger()
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002934 File Offset: 0x00000D34
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00002965 File Offset: 0x00000D65
		public List<EventTrigger.Entry> triggers
		{
			get
			{
				if (this.m_Delegates == null)
				{
					this.m_Delegates = new List<EventTrigger.Entry>();
				}
				return this.m_Delegates;
			}
			set
			{
				this.m_Delegates = value;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002970 File Offset: 0x00000D70
		private void Execute(EventTriggerType id, BaseEventData eventData)
		{
			int i = 0;
			int count = this.triggers.Count;
			while (i < count)
			{
				EventTrigger.Entry entry = this.triggers[i];
				if (entry.eventID == id && entry.callback != null)
				{
					entry.callback.Invoke(eventData);
				}
				i++;
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000029CE File Offset: 0x00000DCE
		public virtual void OnPointerEnter(PointerEventData eventData)
		{
			this.Execute(EventTriggerType.PointerEnter, eventData);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000029D9 File Offset: 0x00000DD9
		public virtual void OnPointerExit(PointerEventData eventData)
		{
			this.Execute(EventTriggerType.PointerExit, eventData);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000029E4 File Offset: 0x00000DE4
		public virtual void OnDrag(PointerEventData eventData)
		{
			this.Execute(EventTriggerType.Drag, eventData);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000029EF File Offset: 0x00000DEF
		public virtual void OnDrop(PointerEventData eventData)
		{
			this.Execute(EventTriggerType.Drop, eventData);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000029FA File Offset: 0x00000DFA
		public virtual void OnPointerDown(PointerEventData eventData)
		{
			this.Execute(EventTriggerType.PointerDown, eventData);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002A05 File Offset: 0x00000E05
		public virtual void OnPointerUp(PointerEventData eventData)
		{
			this.Execute(EventTriggerType.PointerUp, eventData);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002A10 File Offset: 0x00000E10
		public virtual void OnPointerClick(PointerEventData eventData)
		{
			this.Execute(EventTriggerType.PointerClick, eventData);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002A1B File Offset: 0x00000E1B
		public virtual void OnSelect(BaseEventData eventData)
		{
			this.Execute(EventTriggerType.Select, eventData);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002A27 File Offset: 0x00000E27
		public virtual void OnDeselect(BaseEventData eventData)
		{
			this.Execute(EventTriggerType.Deselect, eventData);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002A33 File Offset: 0x00000E33
		public virtual void OnScroll(PointerEventData eventData)
		{
			this.Execute(EventTriggerType.Scroll, eventData);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002A3E File Offset: 0x00000E3E
		public virtual void OnMove(AxisEventData eventData)
		{
			this.Execute(EventTriggerType.Move, eventData);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002A4A File Offset: 0x00000E4A
		public virtual void OnUpdateSelected(BaseEventData eventData)
		{
			this.Execute(EventTriggerType.UpdateSelected, eventData);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002A55 File Offset: 0x00000E55
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
			this.Execute(EventTriggerType.InitializePotentialDrag, eventData);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002A61 File Offset: 0x00000E61
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
			this.Execute(EventTriggerType.BeginDrag, eventData);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002A6D File Offset: 0x00000E6D
		public virtual void OnEndDrag(PointerEventData eventData)
		{
			this.Execute(EventTriggerType.EndDrag, eventData);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002A79 File Offset: 0x00000E79
		public virtual void OnSubmit(BaseEventData eventData)
		{
			this.Execute(EventTriggerType.Submit, eventData);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002A85 File Offset: 0x00000E85
		public virtual void OnCancel(BaseEventData eventData)
		{
			this.Execute(EventTriggerType.Cancel, eventData);
		}

		// Token: 0x04000010 RID: 16
		[FormerlySerializedAs("delegates")]
		[SerializeField]
		private List<EventTrigger.Entry> m_Delegates;

		// Token: 0x04000011 RID: 17
		[Obsolete("Please use triggers instead (UnityUpgradable) -> triggers", true)]
		public List<EventTrigger.Entry> delegates;

		// Token: 0x02000017 RID: 23
		[Serializable]
		public class TriggerEvent : UnityEvent<BaseEventData>
		{
		}

		// Token: 0x02000018 RID: 24
		[Serializable]
		public class Entry
		{
			// Token: 0x04000012 RID: 18
			public EventTriggerType eventID = EventTriggerType.PointerClick;

			// Token: 0x04000013 RID: 19
			public EventTrigger.TriggerEvent callback = new EventTrigger.TriggerEvent();
		}
	}
}
