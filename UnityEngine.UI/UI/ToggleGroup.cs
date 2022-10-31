using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000081 RID: 129
	[AddComponentMenu("UI/Toggle Group", 32)]
	[DisallowMultipleComponent]
	public class ToggleGroup : UIBehaviour
	{
		// Token: 0x060004DB RID: 1243 RVA: 0x0001A0A0 File Offset: 0x000184A0
		protected ToggleGroup()
		{
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x0001A0BC File Offset: 0x000184BC
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x0001A0D7 File Offset: 0x000184D7
		public bool allowSwitchOff
		{
			get
			{
				return this.m_AllowSwitchOff;
			}
			set
			{
				this.m_AllowSwitchOff = value;
			}
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0001A0E1 File Offset: 0x000184E1
		private void ValidateToggleIsInGroup(Toggle toggle)
		{
			if (toggle == null || !this.m_Toggles.Contains(toggle))
			{
				throw new ArgumentException(string.Format("Toggle {0} is not part of ToggleGroup {1}", new object[]
				{
					toggle,
					this
				}));
			}
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0001A120 File Offset: 0x00018520
		public void NotifyToggleOn(Toggle toggle)
		{
			this.ValidateToggleIsInGroup(toggle);
			for (int i = 0; i < this.m_Toggles.Count; i++)
			{
				if (!(this.m_Toggles[i] == toggle))
				{
					this.m_Toggles[i].isOn = false;
				}
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0001A181 File Offset: 0x00018581
		public void UnregisterToggle(Toggle toggle)
		{
			if (this.m_Toggles.Contains(toggle))
			{
				this.m_Toggles.Remove(toggle);
			}
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0001A1A2 File Offset: 0x000185A2
		public void RegisterToggle(Toggle toggle)
		{
			if (!this.m_Toggles.Contains(toggle))
			{
				this.m_Toggles.Add(toggle);
			}
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0001A1C4 File Offset: 0x000185C4
		public bool AnyTogglesOn()
		{
			return this.m_Toggles.Find((Toggle x) => x.isOn) != null;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0001A208 File Offset: 0x00018608
		public IEnumerable<Toggle> ActiveToggles()
		{
			return from x in this.m_Toggles
			where x.isOn
			select x;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0001A248 File Offset: 0x00018648
		public void SetAllTogglesOff()
		{
			bool allowSwitchOff = this.m_AllowSwitchOff;
			this.m_AllowSwitchOff = true;
			for (int i = 0; i < this.m_Toggles.Count; i++)
			{
				this.m_Toggles[i].isOn = false;
			}
			this.m_AllowSwitchOff = allowSwitchOff;
		}

		// Token: 0x04000251 RID: 593
		[SerializeField]
		private bool m_AllowSwitchOff = false;

		// Token: 0x04000252 RID: 594
		private List<Toggle> m_Toggles = new List<Toggle>();
	}
}
