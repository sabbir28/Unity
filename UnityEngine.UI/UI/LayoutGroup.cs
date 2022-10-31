using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x0200009B RID: 155
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup, ILayoutController
	{
		// Token: 0x0600057A RID: 1402 RVA: 0x0001B1F4 File Offset: 0x000195F4
		protected LayoutGroup()
		{
			if (this.m_Padding == null)
			{
				this.m_Padding = new RectOffset();
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x0001B25C File Offset: 0x0001965C
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x0001B277 File Offset: 0x00019677
		public RectOffset padding
		{
			get
			{
				return this.m_Padding;
			}
			set
			{
				this.SetProperty<RectOffset>(ref this.m_Padding, value);
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x0001B288 File Offset: 0x00019688
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x0001B2A3 File Offset: 0x000196A3
		public TextAnchor childAlignment
		{
			get
			{
				return this.m_ChildAlignment;
			}
			set
			{
				this.SetProperty<TextAnchor>(ref this.m_ChildAlignment, value);
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x0001B2B4 File Offset: 0x000196B4
		protected RectTransform rectTransform
		{
			get
			{
				if (this.m_Rect == null)
				{
					this.m_Rect = base.GetComponent<RectTransform>();
				}
				return this.m_Rect;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x0001B2EC File Offset: 0x000196EC
		protected List<RectTransform> rectChildren
		{
			get
			{
				return this.m_RectChildren;
			}
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0001B308 File Offset: 0x00019708
		public virtual void CalculateLayoutInputHorizontal()
		{
			this.m_RectChildren.Clear();
			List<Component> list = ListPool<Component>.Get();
			for (int i = 0; i < this.rectTransform.childCount; i++)
			{
				RectTransform rectTransform = this.rectTransform.GetChild(i) as RectTransform;
				if (!(rectTransform == null) && rectTransform.gameObject.activeInHierarchy)
				{
					rectTransform.GetComponents(typeof(ILayoutIgnorer), list);
					if (list.Count == 0)
					{
						this.m_RectChildren.Add(rectTransform);
					}
					else
					{
						for (int j = 0; j < list.Count; j++)
						{
							ILayoutIgnorer layoutIgnorer = (ILayoutIgnorer)list[j];
							if (!layoutIgnorer.ignoreLayout)
							{
								this.m_RectChildren.Add(rectTransform);
								break;
							}
						}
					}
				}
			}
			ListPool<Component>.Release(list);
			this.m_Tracker.Clear();
		}

		// Token: 0x06000582 RID: 1410
		public abstract void CalculateLayoutInputVertical();

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x0001B3FC File Offset: 0x000197FC
		public virtual float minWidth
		{
			get
			{
				return this.GetTotalMinSize(0);
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x0001B418 File Offset: 0x00019818
		public virtual float preferredWidth
		{
			get
			{
				return this.GetTotalPreferredSize(0);
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x0001B434 File Offset: 0x00019834
		public virtual float flexibleWidth
		{
			get
			{
				return this.GetTotalFlexibleSize(0);
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x0001B450 File Offset: 0x00019850
		public virtual float minHeight
		{
			get
			{
				return this.GetTotalMinSize(1);
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x0001B46C File Offset: 0x0001986C
		public virtual float preferredHeight
		{
			get
			{
				return this.GetTotalPreferredSize(1);
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x0001B488 File Offset: 0x00019888
		public virtual float flexibleHeight
		{
			get
			{
				return this.GetTotalFlexibleSize(1);
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x0001B4A4 File Offset: 0x000198A4
		public virtual int layoutPriority
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0600058A RID: 1418
		public abstract void SetLayoutHorizontal();

		// Token: 0x0600058B RID: 1419
		public abstract void SetLayoutVertical();

		// Token: 0x0600058C RID: 1420 RVA: 0x0001B4BA File Offset: 0x000198BA
		protected override void OnEnable()
		{
			base.OnEnable();
			this.SetDirty();
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0001B4C9 File Offset: 0x000198C9
		protected override void OnDisable()
		{
			this.m_Tracker.Clear();
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
			base.OnDisable();
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x0001B4E8 File Offset: 0x000198E8
		protected override void OnDidApplyAnimationProperties()
		{
			this.SetDirty();
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x0001B4F4 File Offset: 0x000198F4
		protected float GetTotalMinSize(int axis)
		{
			return this.m_TotalMinSize[axis];
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0001B518 File Offset: 0x00019918
		protected float GetTotalPreferredSize(int axis)
		{
			return this.m_TotalPreferredSize[axis];
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0001B53C File Offset: 0x0001993C
		protected float GetTotalFlexibleSize(int axis)
		{
			return this.m_TotalFlexibleSize[axis];
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0001B560 File Offset: 0x00019960
		protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding)
		{
			float num = requiredSpaceWithoutPadding + (float)((axis != 0) ? this.padding.vertical : this.padding.horizontal);
			float num2 = this.rectTransform.rect.size[axis];
			float num3 = num2 - num;
			float alignmentOnAxis = this.GetAlignmentOnAxis(axis);
			return (float)((axis != 0) ? this.padding.top : this.padding.left) + num3 * alignmentOnAxis;
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0001B5F0 File Offset: 0x000199F0
		protected float GetAlignmentOnAxis(int axis)
		{
			float result;
			if (axis == 0)
			{
				result = (float)(this.childAlignment % TextAnchor.MiddleLeft) * 0.5f;
			}
			else
			{
				result = (float)(this.childAlignment / TextAnchor.MiddleLeft) * 0.5f;
			}
			return result;
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0001B62F File Offset: 0x00019A2F
		protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis)
		{
			this.m_TotalMinSize[axis] = totalMin;
			this.m_TotalPreferredSize[axis] = totalPreferred;
			this.m_TotalFlexibleSize[axis] = totalFlexible;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0001B65C File Offset: 0x00019A5C
		protected void SetChildAlongAxis(RectTransform rect, int axis, float pos)
		{
			if (!(rect == null))
			{
				this.m_Tracker.Add(this, rect, DrivenTransformProperties.Anchors | ((axis != 0) ? DrivenTransformProperties.AnchoredPositionY : DrivenTransformProperties.AnchoredPositionX));
				rect.SetInsetAndSizeFromParentEdge((axis != 0) ? RectTransform.Edge.Top : RectTransform.Edge.Left, pos, rect.sizeDelta[axis]);
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0001B6C0 File Offset: 0x00019AC0
		protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size)
		{
			if (!(rect == null))
			{
				this.m_Tracker.Add(this, rect, DrivenTransformProperties.Anchors | ((axis != 0) ? (DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.SizeDeltaY) : (DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.SizeDeltaX)));
				rect.SetInsetAndSizeFromParentEdge((axis != 0) ? RectTransform.Edge.Top : RectTransform.Edge.Left, pos, size);
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x0001B720 File Offset: 0x00019B20
		private bool isRootLayoutGroup
		{
			get
			{
				Transform parent = base.transform.parent;
				return parent == null || base.transform.parent.GetComponent(typeof(ILayoutGroup)) == null;
			}
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0001B774 File Offset: 0x00019B74
		protected override void OnRectTransformDimensionsChange()
		{
			base.OnRectTransformDimensionsChange();
			if (this.isRootLayoutGroup)
			{
				this.SetDirty();
			}
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0001B78E File Offset: 0x00019B8E
		protected virtual void OnTransformChildrenChanged()
		{
			this.SetDirty();
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0001B798 File Offset: 0x00019B98
		protected void SetProperty<T>(ref T currentValue, T newValue)
		{
			if ((currentValue != null || newValue != null) && (currentValue == null || !currentValue.Equals(newValue)))
			{
				currentValue = newValue;
				this.SetDirty();
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0001B7FA File Offset: 0x00019BFA
		protected void SetDirty()
		{
			if (this.IsActive())
			{
				if (!CanvasUpdateRegistry.IsRebuildingLayout())
				{
					LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
				}
				else
				{
					base.StartCoroutine(this.DelayedSetDirty(this.rectTransform));
				}
			}
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0001B83C File Offset: 0x00019C3C
		private IEnumerator DelayedSetDirty(RectTransform rectTransform)
		{
			yield return null;
			LayoutRebuilder.MarkLayoutForRebuild(rectTransform);
			yield break;
		}

		// Token: 0x040002A5 RID: 677
		[SerializeField]
		protected RectOffset m_Padding = new RectOffset();

		// Token: 0x040002A6 RID: 678
		[FormerlySerializedAs("m_Alignment")]
		[SerializeField]
		protected TextAnchor m_ChildAlignment = TextAnchor.UpperLeft;

		// Token: 0x040002A7 RID: 679
		[NonSerialized]
		private RectTransform m_Rect;

		// Token: 0x040002A8 RID: 680
		protected DrivenRectTransformTracker m_Tracker;

		// Token: 0x040002A9 RID: 681
		private Vector2 m_TotalMinSize = Vector2.zero;

		// Token: 0x040002AA RID: 682
		private Vector2 m_TotalPreferredSize = Vector2.zero;

		// Token: 0x040002AB RID: 683
		private Vector2 m_TotalFlexibleSize = Vector2.zero;

		// Token: 0x040002AC RID: 684
		[NonSerialized]
		private List<RectTransform> m_RectChildren = new List<RectTransform>();
	}
}
