using System;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000066 RID: 102
	[Serializable]
	public struct Navigation : IEquatable<Navigation>
	{
		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00014640 File Offset: 0x00012A40
		// (set) Token: 0x06000375 RID: 885 RVA: 0x0001465B File Offset: 0x00012A5B
		public Navigation.Mode mode
		{
			get
			{
				return this.m_Mode;
			}
			set
			{
				this.m_Mode = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00014668 File Offset: 0x00012A68
		// (set) Token: 0x06000377 RID: 887 RVA: 0x00014683 File Offset: 0x00012A83
		public Selectable selectOnUp
		{
			get
			{
				return this.m_SelectOnUp;
			}
			set
			{
				this.m_SelectOnUp = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00014690 File Offset: 0x00012A90
		// (set) Token: 0x06000379 RID: 889 RVA: 0x000146AB File Offset: 0x00012AAB
		public Selectable selectOnDown
		{
			get
			{
				return this.m_SelectOnDown;
			}
			set
			{
				this.m_SelectOnDown = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600037A RID: 890 RVA: 0x000146B8 File Offset: 0x00012AB8
		// (set) Token: 0x0600037B RID: 891 RVA: 0x000146D3 File Offset: 0x00012AD3
		public Selectable selectOnLeft
		{
			get
			{
				return this.m_SelectOnLeft;
			}
			set
			{
				this.m_SelectOnLeft = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600037C RID: 892 RVA: 0x000146E0 File Offset: 0x00012AE0
		// (set) Token: 0x0600037D RID: 893 RVA: 0x000146FB File Offset: 0x00012AFB
		public Selectable selectOnRight
		{
			get
			{
				return this.m_SelectOnRight;
			}
			set
			{
				this.m_SelectOnRight = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00014708 File Offset: 0x00012B08
		public static Navigation defaultNavigation
		{
			get
			{
				return new Navigation
				{
					m_Mode = Navigation.Mode.Automatic
				};
			}
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00014730 File Offset: 0x00012B30
		public bool Equals(Navigation other)
		{
			return this.mode == other.mode && this.selectOnUp == other.selectOnUp && this.selectOnDown == other.selectOnDown && this.selectOnLeft == other.selectOnLeft && this.selectOnRight == other.selectOnRight;
		}

		// Token: 0x040001B1 RID: 433
		[FormerlySerializedAs("mode")]
		[SerializeField]
		private Navigation.Mode m_Mode;

		// Token: 0x040001B2 RID: 434
		[FormerlySerializedAs("selectOnUp")]
		[SerializeField]
		private Selectable m_SelectOnUp;

		// Token: 0x040001B3 RID: 435
		[FormerlySerializedAs("selectOnDown")]
		[SerializeField]
		private Selectable m_SelectOnDown;

		// Token: 0x040001B4 RID: 436
		[FormerlySerializedAs("selectOnLeft")]
		[SerializeField]
		private Selectable m_SelectOnLeft;

		// Token: 0x040001B5 RID: 437
		[FormerlySerializedAs("selectOnRight")]
		[SerializeField]
		private Selectable m_SelectOnRight;

		// Token: 0x02000067 RID: 103
		[Flags]
		public enum Mode
		{
			// Token: 0x040001B7 RID: 439
			None = 0,
			// Token: 0x040001B8 RID: 440
			Horizontal = 1,
			// Token: 0x040001B9 RID: 441
			Vertical = 2,
			// Token: 0x040001BA RID: 442
			Automatic = 3,
			// Token: 0x040001BB RID: 443
			Explicit = 4
		}
	}
}
