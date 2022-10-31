using System;

namespace UnityEngine.UI
{
	// Token: 0x0200008F RID: 143
	[AddComponentMenu("Layout/Grid Layout Group", 152)]
	public class GridLayoutGroup : LayoutGroup
	{
		// Token: 0x06000531 RID: 1329 RVA: 0x0001B918 File Offset: 0x00019D18
		protected GridLayoutGroup()
		{
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x0001B968 File Offset: 0x00019D68
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x0001B983 File Offset: 0x00019D83
		public GridLayoutGroup.Corner startCorner
		{
			get
			{
				return this.m_StartCorner;
			}
			set
			{
				base.SetProperty<GridLayoutGroup.Corner>(ref this.m_StartCorner, value);
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x0001B994 File Offset: 0x00019D94
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x0001B9AF File Offset: 0x00019DAF
		public GridLayoutGroup.Axis startAxis
		{
			get
			{
				return this.m_StartAxis;
			}
			set
			{
				base.SetProperty<GridLayoutGroup.Axis>(ref this.m_StartAxis, value);
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x0001B9C0 File Offset: 0x00019DC0
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x0001B9DB File Offset: 0x00019DDB
		public Vector2 cellSize
		{
			get
			{
				return this.m_CellSize;
			}
			set
			{
				base.SetProperty<Vector2>(ref this.m_CellSize, value);
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x0001B9EC File Offset: 0x00019DEC
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x0001BA07 File Offset: 0x00019E07
		public Vector2 spacing
		{
			get
			{
				return this.m_Spacing;
			}
			set
			{
				base.SetProperty<Vector2>(ref this.m_Spacing, value);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x0001BA18 File Offset: 0x00019E18
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x0001BA33 File Offset: 0x00019E33
		public GridLayoutGroup.Constraint constraint
		{
			get
			{
				return this.m_Constraint;
			}
			set
			{
				base.SetProperty<GridLayoutGroup.Constraint>(ref this.m_Constraint, value);
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x0001BA44 File Offset: 0x00019E44
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x0001BA5F File Offset: 0x00019E5F
		public int constraintCount
		{
			get
			{
				return this.m_ConstraintCount;
			}
			set
			{
				base.SetProperty<int>(ref this.m_ConstraintCount, Mathf.Max(1, value));
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0001BA78 File Offset: 0x00019E78
		public override void CalculateLayoutInputHorizontal()
		{
			base.CalculateLayoutInputHorizontal();
			int num2;
			int num;
			if (this.m_Constraint == GridLayoutGroup.Constraint.FixedColumnCount)
			{
				num = (num2 = this.m_ConstraintCount);
			}
			else if (this.m_Constraint == GridLayoutGroup.Constraint.FixedRowCount)
			{
				num = (num2 = Mathf.CeilToInt((float)base.rectChildren.Count / (float)this.m_ConstraintCount - 0.001f));
			}
			else
			{
				num2 = 1;
				num = Mathf.CeilToInt(Mathf.Sqrt((float)base.rectChildren.Count));
			}
			base.SetLayoutInputForAxis((float)base.padding.horizontal + (this.cellSize.x + this.spacing.x) * (float)num2 - this.spacing.x, (float)base.padding.horizontal + (this.cellSize.x + this.spacing.x) * (float)num - this.spacing.x, -1f, 0);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0001BB84 File Offset: 0x00019F84
		public override void CalculateLayoutInputVertical()
		{
			int num;
			if (this.m_Constraint == GridLayoutGroup.Constraint.FixedColumnCount)
			{
				num = Mathf.CeilToInt((float)base.rectChildren.Count / (float)this.m_ConstraintCount - 0.001f);
			}
			else if (this.m_Constraint == GridLayoutGroup.Constraint.FixedRowCount)
			{
				num = this.m_ConstraintCount;
			}
			else
			{
				float x = base.rectTransform.rect.size.x;
				int num2 = Mathf.Max(1, Mathf.FloorToInt((x - (float)base.padding.horizontal + this.spacing.x + 0.001f) / (this.cellSize.x + this.spacing.x)));
				num = Mathf.CeilToInt((float)base.rectChildren.Count / (float)num2);
			}
			float num3 = (float)base.padding.vertical + (this.cellSize.y + this.spacing.y) * (float)num - this.spacing.y;
			base.SetLayoutInputForAxis(num3, num3, -1f, 1);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0001BCB7 File Offset: 0x0001A0B7
		public override void SetLayoutHorizontal()
		{
			this.SetCellsAlongAxis(0);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0001BCC1 File Offset: 0x0001A0C1
		public override void SetLayoutVertical()
		{
			this.SetCellsAlongAxis(1);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0001BCCC File Offset: 0x0001A0CC
		private void SetCellsAlongAxis(int axis)
		{
			if (axis == 0)
			{
				for (int i = 0; i < base.rectChildren.Count; i++)
				{
					RectTransform rectTransform = base.rectChildren[i];
					this.m_Tracker.Add(this, rectTransform, DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.AnchorMinX | DrivenTransformProperties.AnchorMinY | DrivenTransformProperties.AnchorMaxX | DrivenTransformProperties.AnchorMaxY | DrivenTransformProperties.SizeDeltaX | DrivenTransformProperties.SizeDeltaY);
					rectTransform.anchorMin = Vector2.up;
					rectTransform.anchorMax = Vector2.up;
					rectTransform.sizeDelta = this.cellSize;
				}
			}
			else
			{
				float x = base.rectTransform.rect.size.x;
				float y = base.rectTransform.rect.size.y;
				int num;
				int num2;
				if (this.m_Constraint == GridLayoutGroup.Constraint.FixedColumnCount)
				{
					num = this.m_ConstraintCount;
					num2 = Mathf.CeilToInt((float)base.rectChildren.Count / (float)num - 0.001f);
				}
				else if (this.m_Constraint == GridLayoutGroup.Constraint.FixedRowCount)
				{
					num2 = this.m_ConstraintCount;
					num = Mathf.CeilToInt((float)base.rectChildren.Count / (float)num2 - 0.001f);
				}
				else
				{
					if (this.cellSize.x + this.spacing.x <= 0f)
					{
						num = int.MaxValue;
					}
					else
					{
						num = Mathf.Max(1, Mathf.FloorToInt((x - (float)base.padding.horizontal + this.spacing.x + 0.001f) / (this.cellSize.x + this.spacing.x)));
					}
					if (this.cellSize.y + this.spacing.y <= 0f)
					{
						num2 = int.MaxValue;
					}
					else
					{
						num2 = Mathf.Max(1, Mathf.FloorToInt((y - (float)base.padding.vertical + this.spacing.y + 0.001f) / (this.cellSize.y + this.spacing.y)));
					}
				}
				int num3 = (int)(this.startCorner % GridLayoutGroup.Corner.LowerLeft);
				int num4 = (int)(this.startCorner / GridLayoutGroup.Corner.LowerLeft);
				int num5;
				int num6;
				int num7;
				if (this.startAxis == GridLayoutGroup.Axis.Horizontal)
				{
					num5 = num;
					num6 = Mathf.Clamp(num, 1, base.rectChildren.Count);
					num7 = Mathf.Clamp(num2, 1, Mathf.CeilToInt((float)base.rectChildren.Count / (float)num5));
				}
				else
				{
					num5 = num2;
					num7 = Mathf.Clamp(num2, 1, base.rectChildren.Count);
					num6 = Mathf.Clamp(num, 1, Mathf.CeilToInt((float)base.rectChildren.Count / (float)num5));
				}
				Vector2 vector = new Vector2((float)num6 * this.cellSize.x + (float)(num6 - 1) * this.spacing.x, (float)num7 * this.cellSize.y + (float)(num7 - 1) * this.spacing.y);
				Vector2 vector2 = new Vector2(base.GetStartOffset(0, vector.x), base.GetStartOffset(1, vector.y));
				for (int j = 0; j < base.rectChildren.Count; j++)
				{
					int num8;
					int num9;
					if (this.startAxis == GridLayoutGroup.Axis.Horizontal)
					{
						num8 = j % num5;
						num9 = j / num5;
					}
					else
					{
						num8 = j / num5;
						num9 = j % num5;
					}
					if (num3 == 1)
					{
						num8 = num6 - 1 - num8;
					}
					if (num4 == 1)
					{
						num9 = num7 - 1 - num9;
					}
					base.SetChildAlongAxis(base.rectChildren[j], 0, vector2.x + (this.cellSize[0] + this.spacing[0]) * (float)num8, this.cellSize[0]);
					base.SetChildAlongAxis(base.rectChildren[j], 1, vector2.y + (this.cellSize[1] + this.spacing[1]) * (float)num9, this.cellSize[1]);
				}
			}
		}

		// Token: 0x04000287 RID: 647
		[SerializeField]
		protected GridLayoutGroup.Corner m_StartCorner = GridLayoutGroup.Corner.UpperLeft;

		// Token: 0x04000288 RID: 648
		[SerializeField]
		protected GridLayoutGroup.Axis m_StartAxis = GridLayoutGroup.Axis.Horizontal;

		// Token: 0x04000289 RID: 649
		[SerializeField]
		protected Vector2 m_CellSize = new Vector2(100f, 100f);

		// Token: 0x0400028A RID: 650
		[SerializeField]
		protected Vector2 m_Spacing = Vector2.zero;

		// Token: 0x0400028B RID: 651
		[SerializeField]
		protected GridLayoutGroup.Constraint m_Constraint = GridLayoutGroup.Constraint.Flexible;

		// Token: 0x0400028C RID: 652
		[SerializeField]
		protected int m_ConstraintCount = 2;

		// Token: 0x02000090 RID: 144
		public enum Corner
		{
			// Token: 0x0400028E RID: 654
			UpperLeft,
			// Token: 0x0400028F RID: 655
			UpperRight,
			// Token: 0x04000290 RID: 656
			LowerLeft,
			// Token: 0x04000291 RID: 657
			LowerRight
		}

		// Token: 0x02000091 RID: 145
		public enum Axis
		{
			// Token: 0x04000293 RID: 659
			Horizontal,
			// Token: 0x04000294 RID: 660
			Vertical
		}

		// Token: 0x02000092 RID: 146
		public enum Constraint
		{
			// Token: 0x04000296 RID: 662
			Flexible,
			// Token: 0x04000297 RID: 663
			FixedColumnCount,
			// Token: 0x04000298 RID: 664
			FixedRowCount
		}
	}
}
