using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x0200007E RID: 126
	[AddComponentMenu("UI/Toggle", 31)]
	[RequireComponent(typeof(RectTransform))]
	public class Toggle : Selectable, IPointerClickHandler, ISubmitHandler, ICanvasElement, IEventSystemHandler
	{
		// Token: 0x060004C6 RID: 1222 RVA: 0x00019D6A File Offset: 0x0001816A
		protected Toggle()
		{
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00019D88 File Offset: 0x00018188
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x00019DA3 File Offset: 0x000181A3
		public ToggleGroup group
		{
			get
			{
				return this.m_Group;
			}
			set
			{
				this.m_Group = value;
				this.SetToggleGroup(this.m_Group, true);
				this.PlayEffect(true);
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00019DC3 File Offset: 0x000181C3
		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00019DC6 File Offset: 0x000181C6
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00019DC9 File Offset: 0x000181C9
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00019DCC File Offset: 0x000181CC
		protected override void OnEnable()
		{
			base.OnEnable();
			this.SetToggleGroup(this.m_Group, false);
			this.PlayEffect(true);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00019DE9 File Offset: 0x000181E9
		protected override void OnDisable()
		{
			this.SetToggleGroup(null, false);
			base.OnDisable();
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00019DFC File Offset: 0x000181FC
		protected override void OnDidApplyAnimationProperties()
		{
			if (this.graphic != null)
			{
				bool flag = !Mathf.Approximately(this.graphic.canvasRenderer.GetColor().a, 0f);
				if (this.m_IsOn != flag)
				{
					this.m_IsOn = flag;
					this.Set(!flag);
				}
			}
			base.OnDidApplyAnimationProperties();
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00019E68 File Offset: 0x00018268
		private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue)
		{
			ToggleGroup group = this.m_Group;
			if (this.m_Group != null)
			{
				this.m_Group.UnregisterToggle(this);
			}
			if (setMemberValue)
			{
				this.m_Group = newGroup;
			}
			if (newGroup != null && this.IsActive())
			{
				newGroup.RegisterToggle(this);
			}
			if (newGroup != null && newGroup != group && this.isOn && this.IsActive())
			{
				newGroup.NotifyToggleOn(this);
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x00019EFC File Offset: 0x000182FC
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x00019F17 File Offset: 0x00018317
		public bool isOn
		{
			get
			{
				return this.m_IsOn;
			}
			set
			{
				this.Set(value);
			}
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00019F21 File Offset: 0x00018321
		private void Set(bool value)
		{
			this.Set(value, true);
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00019F2C File Offset: 0x0001832C
		private void Set(bool value, bool sendCallback)
		{
			if (this.m_IsOn != value)
			{
				this.m_IsOn = value;
				if (this.m_Group != null && this.IsActive())
				{
					if (this.m_IsOn || (!this.m_Group.AnyTogglesOn() && !this.m_Group.allowSwitchOff))
					{
						this.m_IsOn = true;
						this.m_Group.NotifyToggleOn(this);
					}
				}
				this.PlayEffect(this.toggleTransition == Toggle.ToggleTransition.None);
				if (sendCallback)
				{
					this.onValueChanged.Invoke(this.m_IsOn);
				}
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00019FD8 File Offset: 0x000183D8
		private void PlayEffect(bool instant)
		{
			if (!(this.graphic == null))
			{
				this.graphic.CrossFadeAlpha((!this.m_IsOn) ? 0f : 1f, (!instant) ? 0.1f : 0f, true);
			}
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0001A037 File Offset: 0x00018437
		protected override void Start()
		{
			this.PlayEffect(true);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0001A041 File Offset: 0x00018441
		private void InternalToggle()
		{
			if (this.IsActive() && this.IsInteractable())
			{
				this.isOn = !this.isOn;
			}
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0001A06E File Offset: 0x0001846E
		public virtual void OnPointerClick(PointerEventData eventData)
		{
			if (eventData.button == PointerEventData.InputButton.Left)
			{
				this.InternalToggle();
			}
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0001A087 File Offset: 0x00018487
		public virtual void OnSubmit(BaseEventData eventData)
		{
			this.InternalToggle();
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0001A090 File Offset: 0x00018490
		Transform ICanvasElement.get_transform()
		{
			return base.transform;
		}

		// Token: 0x04000249 RID: 585
		public Toggle.ToggleTransition toggleTransition = Toggle.ToggleTransition.Fade;

		// Token: 0x0400024A RID: 586
		public Graphic graphic;

		// Token: 0x0400024B RID: 587
		[SerializeField]
		private ToggleGroup m_Group;

		// Token: 0x0400024C RID: 588
		public Toggle.ToggleEvent onValueChanged = new Toggle.ToggleEvent();

		// Token: 0x0400024D RID: 589
		[FormerlySerializedAs("m_IsActive")]
		[Tooltip("Is the toggle currently on or off?")]
		[SerializeField]
		private bool m_IsOn;

		// Token: 0x0200007F RID: 127
		public enum ToggleTransition
		{
			// Token: 0x0400024F RID: 591
			None,
			// Token: 0x04000250 RID: 592
			Fade
		}

		// Token: 0x02000080 RID: 128
		[Serializable]
		public class ToggleEvent : UnityEvent<bool>
		{
		}
	}
}
