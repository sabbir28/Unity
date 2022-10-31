using System;

namespace UnityEngine.UI
{
	// Token: 0x02000094 RID: 148
	public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup
	{
		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x0001C160 File Offset: 0x0001A560
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x0001C17B File Offset: 0x0001A57B
		public float spacing
		{
			get
			{
				return this.m_Spacing;
			}
			set
			{
				base.SetProperty<float>(ref this.m_Spacing, value);
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x0001C18C File Offset: 0x0001A58C
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x0001C1A7 File Offset: 0x0001A5A7
		public bool childForceExpandWidth
		{
			get
			{
				return this.m_ChildForceExpandWidth;
			}
			set
			{
				base.SetProperty<bool>(ref this.m_ChildForceExpandWidth, value);
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0001C1B8 File Offset: 0x0001A5B8
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x0001C1D3 File Offset: 0x0001A5D3
		public bool childForceExpandHeight
		{
			get
			{
				return this.m_ChildForceExpandHeight;
			}
			set
			{
				base.SetProperty<bool>(ref this.m_ChildForceExpandHeight, value);
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x0001C1E4 File Offset: 0x0001A5E4
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x0001C1FF File Offset: 0x0001A5FF
		public bool childControlWidth
		{
			get
			{
				return this.m_ChildControlWidth;
			}
			set
			{
				base.SetProperty<bool>(ref this.m_ChildControlWidth, value);
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x0001C210 File Offset: 0x0001A610
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x0001C22B File Offset: 0x0001A62B
		public bool childControlHeight
		{
			get
			{
				return this.m_ChildControlHeight;
			}
			set
			{
				base.SetProperty<bool>(ref this.m_ChildControlHeight, value);
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0001C23C File Offset: 0x0001A63C
		protected void CalcAlongAxis(int axis, bool isVertical)
		{
			float num = (float)((axis != 0) ? base.padding.vertical : base.padding.horizontal);
			bool controlSize = (axis != 0) ? this.m_ChildControlHeight : this.m_ChildControlWidth;
			bool childForceExpand = (axis != 0) ? this.childForceExpandHeight : this.childForceExpandWidth;
			float num2 = num;
			float num3 = num;
			float num4 = 0f;
			bool flag = isVertical ^ axis == 1;
			for (int i = 0; i < base.rectChildren.Count; i++)
			{
				RectTransform child = base.rectChildren[i];
				float num5;
				float num6;
				float num7;
				this.GetChildSizes(child, axis, controlSize, childForceExpand, out num5, out num6, out num7);
				if (flag)
				{
					num2 = Mathf.Max(num5 + num, num2);
					num3 = Mathf.Max(num6 + num, num3);
					num4 = Mathf.Max(num7, num4);
				}
				else
				{
					num2 += num5 + this.spacing;
					num3 += num6 + this.spacing;
					num4 += num7;
				}
			}
			if (!flag && base.rectChildren.Count > 0)
			{
				num2 -= this.spacing;
				num3 -= this.spacing;
			}
			num3 = Mathf.Max(num2, num3);
			base.SetLayoutInputForAxis(num2, num3, num4, axis);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0001C38C File Offset: 0x0001A78C
		protected void SetChildrenAlongAxis(int axis, bool isVertical)
		{
			float num = base.rectTransform.rect.size[axis];
			bool flag = (axis != 0) ? this.m_ChildControlHeight : this.m_ChildControlWidth;
			bool childForceExpand = (axis != 0) ? this.childForceExpandHeight : this.childForceExpandWidth;
			float alignmentOnAxis = base.GetAlignmentOnAxis(axis);
			bool flag2 = isVertical ^ axis == 1;
			if (flag2)
			{
				float value = num - (float)((axis != 0) ? base.padding.vertical : base.padding.horizontal);
				for (int i = 0; i < base.rectChildren.Count; i++)
				{
					RectTransform rectTransform = base.rectChildren[i];
					float min;
					float num2;
					float num3;
					this.GetChildSizes(rectTransform, axis, flag, childForceExpand, out min, out num2, out num3);
					float num4 = Mathf.Clamp(value, min, (num3 <= 0f) ? num2 : num);
					float startOffset = base.GetStartOffset(axis, num4);
					if (flag)
					{
						base.SetChildAlongAxis(rectTransform, axis, startOffset, num4);
					}
					else
					{
						float num5 = (num4 - rectTransform.sizeDelta[axis]) * alignmentOnAxis;
						base.SetChildAlongAxis(rectTransform, axis, startOffset + num5);
					}
				}
			}
			else
			{
				float num6 = (float)((axis != 0) ? base.padding.top : base.padding.left);
				if (base.GetTotalFlexibleSize(axis) == 0f && base.GetTotalPreferredSize(axis) < num)
				{
					num6 = base.GetStartOffset(axis, base.GetTotalPreferredSize(axis) - (float)((axis != 0) ? base.padding.vertical : base.padding.horizontal));
				}
				float t = 0f;
				if (base.GetTotalMinSize(axis) != base.GetTotalPreferredSize(axis))
				{
					t = Mathf.Clamp01((num - base.GetTotalMinSize(axis)) / (base.GetTotalPreferredSize(axis) - base.GetTotalMinSize(axis)));
				}
				float num7 = 0f;
				if (num > base.GetTotalPreferredSize(axis))
				{
					if (base.GetTotalFlexibleSize(axis) > 0f)
					{
						num7 = (num - base.GetTotalPreferredSize(axis)) / base.GetTotalFlexibleSize(axis);
					}
				}
				for (int j = 0; j < base.rectChildren.Count; j++)
				{
					RectTransform rectTransform2 = base.rectChildren[j];
					float a;
					float b;
					float num8;
					this.GetChildSizes(rectTransform2, axis, flag, childForceExpand, out a, out b, out num8);
					float num9 = Mathf.Lerp(a, b, t);
					num9 += num8 * num7;
					if (flag)
					{
						base.SetChildAlongAxis(rectTransform2, axis, num6, num9);
					}
					else
					{
						float num10 = (num9 - rectTransform2.sizeDelta[axis]) * alignmentOnAxis;
						base.SetChildAlongAxis(rectTransform2, axis, num6 + num10);
					}
					num6 += num9 + this.spacing;
				}
			}
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0001C674 File Offset: 0x0001AA74
		private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible)
		{
			if (!controlSize)
			{
				min = child.sizeDelta[axis];
				preferred = min;
				flexible = 0f;
			}
			else
			{
				min = LayoutUtility.GetMinSize(child, axis);
				preferred = LayoutUtility.GetPreferredSize(child, axis);
				flexible = LayoutUtility.GetFlexibleSize(child, axis);
			}
			if (childForceExpand)
			{
				flexible = Mathf.Max(flexible, 1f);
			}
		}

		// Token: 0x04000299 RID: 665
		[SerializeField]
		protected float m_Spacing = 0f;

		// Token: 0x0400029A RID: 666
		[SerializeField]
		protected bool m_ChildForceExpandWidth = true;

		// Token: 0x0400029B RID: 667
		[SerializeField]
		protected bool m_ChildForceExpandHeight = true;

		// Token: 0x0400029C RID: 668
		[SerializeField]
		protected bool m_ChildControlWidth = true;

		// Token: 0x0400029D RID: 669
		[SerializeField]
		protected bool m_ChildControlHeight = true;
	}
}
