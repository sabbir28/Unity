using System;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x0200007A RID: 122
	[Serializable]
	public struct SpriteState : IEquatable<SpriteState>
	{
		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00018AB0 File Offset: 0x00016EB0
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x00018ACB File Offset: 0x00016ECB
		public Sprite highlightedSprite
		{
			get
			{
				return this.m_HighlightedSprite;
			}
			set
			{
				this.m_HighlightedSprite = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00018AD8 File Offset: 0x00016ED8
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x00018AF3 File Offset: 0x00016EF3
		public Sprite pressedSprite
		{
			get
			{
				return this.m_PressedSprite;
			}
			set
			{
				this.m_PressedSprite = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00018B00 File Offset: 0x00016F00
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x00018B1B File Offset: 0x00016F1B
		public Sprite disabledSprite
		{
			get
			{
				return this.m_DisabledSprite;
			}
			set
			{
				this.m_DisabledSprite = value;
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00018B28 File Offset: 0x00016F28
		public bool Equals(SpriteState other)
		{
			return this.highlightedSprite == other.highlightedSprite && this.pressedSprite == other.pressedSprite && this.disabledSprite == other.disabledSprite;
		}

		// Token: 0x04000234 RID: 564
		[FormerlySerializedAs("highlightedSprite")]
		[FormerlySerializedAs("m_SelectedSprite")]
		[SerializeField]
		private Sprite m_HighlightedSprite;

		// Token: 0x04000235 RID: 565
		[FormerlySerializedAs("pressedSprite")]
		[SerializeField]
		private Sprite m_PressedSprite;

		// Token: 0x04000236 RID: 566
		[FormerlySerializedAs("disabledSprite")]
		[SerializeField]
		private Sprite m_DisabledSprite;
	}
}
