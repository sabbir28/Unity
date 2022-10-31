using System;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000039 RID: 57
	[Serializable]
	public class AnimationTriggers
	{
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00006B6C File Offset: 0x00004F6C
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00006B87 File Offset: 0x00004F87
		public string normalTrigger
		{
			get
			{
				return this.m_NormalTrigger;
			}
			set
			{
				this.m_NormalTrigger = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00006B94 File Offset: 0x00004F94
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00006BAF File Offset: 0x00004FAF
		public string highlightedTrigger
		{
			get
			{
				return this.m_HighlightedTrigger;
			}
			set
			{
				this.m_HighlightedTrigger = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00006BBC File Offset: 0x00004FBC
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00006BD7 File Offset: 0x00004FD7
		public string pressedTrigger
		{
			get
			{
				return this.m_PressedTrigger;
			}
			set
			{
				this.m_PressedTrigger = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00006BE4 File Offset: 0x00004FE4
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00006BFF File Offset: 0x00004FFF
		public string disabledTrigger
		{
			get
			{
				return this.m_DisabledTrigger;
			}
			set
			{
				this.m_DisabledTrigger = value;
			}
		}

		// Token: 0x040000B6 RID: 182
		private const string kDefaultNormalAnimName = "Normal";

		// Token: 0x040000B7 RID: 183
		private const string kDefaultSelectedAnimName = "Highlighted";

		// Token: 0x040000B8 RID: 184
		private const string kDefaultPressedAnimName = "Pressed";

		// Token: 0x040000B9 RID: 185
		private const string kDefaultDisabledAnimName = "Disabled";

		// Token: 0x040000BA RID: 186
		[FormerlySerializedAs("normalTrigger")]
		[SerializeField]
		private string m_NormalTrigger = "Normal";

		// Token: 0x040000BB RID: 187
		[FormerlySerializedAs("highlightedTrigger")]
		[FormerlySerializedAs("m_SelectedTrigger")]
		[SerializeField]
		private string m_HighlightedTrigger = "Highlighted";

		// Token: 0x040000BC RID: 188
		[FormerlySerializedAs("pressedTrigger")]
		[SerializeField]
		private string m_PressedTrigger = "Pressed";

		// Token: 0x040000BD RID: 189
		[FormerlySerializedAs("disabledTrigger")]
		[SerializeField]
		private string m_DisabledTrigger = "Disabled";
	}
}
