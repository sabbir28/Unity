using System;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x0200003A RID: 58
	[AddComponentMenu("UI/Button", 30)]
	public class Button : Selectable, IPointerClickHandler, ISubmitHandler, IEventSystemHandler
	{
		// Token: 0x0600017F RID: 383 RVA: 0x00007AE3 File Offset: 0x00005EE3
		protected Button()
		{
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00007AF8 File Offset: 0x00005EF8
		// (set) Token: 0x06000181 RID: 385 RVA: 0x00007B13 File Offset: 0x00005F13
		public Button.ButtonClickedEvent onClick
		{
			get
			{
				return this.m_OnClick;
			}
			set
			{
				this.m_OnClick = value;
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00007B1D File Offset: 0x00005F1D
		private void Press()
		{
			if (this.IsActive() && this.IsInteractable())
			{
				this.m_OnClick.Invoke();
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00007B46 File Offset: 0x00005F46
		public virtual void OnPointerClick(PointerEventData eventData)
		{
			if (eventData.button == PointerEventData.InputButton.Left)
			{
				this.Press();
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00007B5F File Offset: 0x00005F5F
		public virtual void OnSubmit(BaseEventData eventData)
		{
			this.Press();
			if (this.IsActive() && this.IsInteractable())
			{
				this.DoStateTransition(Selectable.SelectionState.Pressed, false);
				base.StartCoroutine(this.OnFinishSubmit());
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00007B98 File Offset: 0x00005F98
		private IEnumerator OnFinishSubmit()
		{
			float fadeTime = base.colors.fadeDuration;
			float elapsedTime = 0f;
			while (elapsedTime < fadeTime)
			{
				elapsedTime += Time.unscaledDeltaTime;
				yield return null;
			}
			this.DoStateTransition(base.currentSelectionState, false);
			yield break;
		}

		// Token: 0x040000BE RID: 190
		[FormerlySerializedAs("onClick")]
		[SerializeField]
		private Button.ButtonClickedEvent m_OnClick = new Button.ButtonClickedEvent();

		// Token: 0x0200003B RID: 59
		[Serializable]
		public class ButtonClickedEvent : UnityEvent
		{
		}
	}
}
