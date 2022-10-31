using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000264 RID: 612
	[Serializable]
	public sealed class GUISettings
	{
		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x060028F3 RID: 10483 RVA: 0x00036024 File Offset: 0x00034224
		// (set) Token: 0x060028F4 RID: 10484 RVA: 0x00036040 File Offset: 0x00034240
		public bool doubleClickSelectsWord
		{
			get
			{
				return this.m_DoubleClickSelectsWord;
			}
			set
			{
				this.m_DoubleClickSelectsWord = value;
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x060028F5 RID: 10485 RVA: 0x0003604C File Offset: 0x0003424C
		// (set) Token: 0x060028F6 RID: 10486 RVA: 0x00036068 File Offset: 0x00034268
		public bool tripleClickSelectsLine
		{
			get
			{
				return this.m_TripleClickSelectsLine;
			}
			set
			{
				this.m_TripleClickSelectsLine = value;
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x060028F7 RID: 10487 RVA: 0x00036074 File Offset: 0x00034274
		// (set) Token: 0x060028F8 RID: 10488 RVA: 0x00036090 File Offset: 0x00034290
		public Color cursorColor
		{
			get
			{
				return this.m_CursorColor;
			}
			set
			{
				this.m_CursorColor = value;
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x060028F9 RID: 10489 RVA: 0x0003609C File Offset: 0x0003429C
		// (set) Token: 0x060028FA RID: 10490 RVA: 0x000360D4 File Offset: 0x000342D4
		public float cursorFlashSpeed
		{
			get
			{
				float result;
				if (this.m_CursorFlashSpeed >= 0f)
				{
					result = this.m_CursorFlashSpeed;
				}
				else
				{
					result = GUISettings.Internal_GetCursorFlashSpeed();
				}
				return result;
			}
			set
			{
				this.m_CursorFlashSpeed = value;
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x060028FB RID: 10491 RVA: 0x000360E0 File Offset: 0x000342E0
		// (set) Token: 0x060028FC RID: 10492 RVA: 0x000360FC File Offset: 0x000342FC
		public Color selectionColor
		{
			get
			{
				return this.m_SelectionColor;
			}
			set
			{
				this.m_SelectionColor = value;
			}
		}

		// Token: 0x060028FD RID: 10493
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetCursorFlashSpeed();

		// Token: 0x04000772 RID: 1906
		[SerializeField]
		private bool m_DoubleClickSelectsWord = true;

		// Token: 0x04000773 RID: 1907
		[SerializeField]
		private bool m_TripleClickSelectsLine = true;

		// Token: 0x04000774 RID: 1908
		[SerializeField]
		private Color m_CursorColor = Color.white;

		// Token: 0x04000775 RID: 1909
		[SerializeField]
		private float m_CursorFlashSpeed = -1f;

		// Token: 0x04000776 RID: 1910
		[SerializeField]
		private Color m_SelectionColor = new Color(0.5f, 0.5f, 1f);
	}
}
