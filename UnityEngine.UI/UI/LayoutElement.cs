using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200009A RID: 154
	[AddComponentMenu("Layout/Layout Element", 140)]
	[RequireComponent(typeof(RectTransform))]
	[ExecuteInEditMode]
	public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer
	{
		// Token: 0x06000562 RID: 1378 RVA: 0x0001C724 File Offset: 0x0001AB24
		protected LayoutElement()
		{
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x0001C784 File Offset: 0x0001AB84
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x0001C79F File Offset: 0x0001AB9F
		public virtual bool ignoreLayout
		{
			get
			{
				return this.m_IgnoreLayout;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<bool>(ref this.m_IgnoreLayout, value))
				{
					this.SetDirty();
				}
			}
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0001C7B9 File Offset: 0x0001ABB9
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0001C7BC File Offset: 0x0001ABBC
		public virtual void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x0001C7C0 File Offset: 0x0001ABC0
		// (set) Token: 0x06000568 RID: 1384 RVA: 0x0001C7DB File Offset: 0x0001ABDB
		public virtual float minWidth
		{
			get
			{
				return this.m_MinWidth;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<float>(ref this.m_MinWidth, value))
				{
					this.SetDirty();
				}
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x0001C7F8 File Offset: 0x0001ABF8
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x0001C813 File Offset: 0x0001AC13
		public virtual float minHeight
		{
			get
			{
				return this.m_MinHeight;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<float>(ref this.m_MinHeight, value))
				{
					this.SetDirty();
				}
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x0001C830 File Offset: 0x0001AC30
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x0001C84B File Offset: 0x0001AC4B
		public virtual float preferredWidth
		{
			get
			{
				return this.m_PreferredWidth;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<float>(ref this.m_PreferredWidth, value))
				{
					this.SetDirty();
				}
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x0001C868 File Offset: 0x0001AC68
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x0001C883 File Offset: 0x0001AC83
		public virtual float preferredHeight
		{
			get
			{
				return this.m_PreferredHeight;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<float>(ref this.m_PreferredHeight, value))
				{
					this.SetDirty();
				}
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x0001C8A0 File Offset: 0x0001ACA0
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x0001C8BB File Offset: 0x0001ACBB
		public virtual float flexibleWidth
		{
			get
			{
				return this.m_FlexibleWidth;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<float>(ref this.m_FlexibleWidth, value))
				{
					this.SetDirty();
				}
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x0001C8D8 File Offset: 0x0001ACD8
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x0001C8F3 File Offset: 0x0001ACF3
		public virtual float flexibleHeight
		{
			get
			{
				return this.m_FlexibleHeight;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<float>(ref this.m_FlexibleHeight, value))
				{
					this.SetDirty();
				}
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x0001C910 File Offset: 0x0001AD10
		public virtual int layoutPriority
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0001C926 File Offset: 0x0001AD26
		protected override void OnEnable()
		{
			base.OnEnable();
			this.SetDirty();
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0001C935 File Offset: 0x0001AD35
		protected override void OnTransformParentChanged()
		{
			this.SetDirty();
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0001C93E File Offset: 0x0001AD3E
		protected override void OnDisable()
		{
			this.SetDirty();
			base.OnDisable();
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0001C94D File Offset: 0x0001AD4D
		protected override void OnDidApplyAnimationProperties()
		{
			this.SetDirty();
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0001C956 File Offset: 0x0001AD56
		protected override void OnBeforeTransformParentChanged()
		{
			this.SetDirty();
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x0001C95F File Offset: 0x0001AD5F
		protected void SetDirty()
		{
			if (this.IsActive())
			{
				LayoutRebuilder.MarkLayoutForRebuild(base.transform as RectTransform);
			}
		}

		// Token: 0x0400029E RID: 670
		[SerializeField]
		private bool m_IgnoreLayout = false;

		// Token: 0x0400029F RID: 671
		[SerializeField]
		private float m_MinWidth = -1f;

		// Token: 0x040002A0 RID: 672
		[SerializeField]
		private float m_MinHeight = -1f;

		// Token: 0x040002A1 RID: 673
		[SerializeField]
		private float m_PreferredWidth = -1f;

		// Token: 0x040002A2 RID: 674
		[SerializeField]
		private float m_PreferredHeight = -1f;

		// Token: 0x040002A3 RID: 675
		[SerializeField]
		private float m_FlexibleWidth = -1f;

		// Token: 0x040002A4 RID: 676
		[SerializeField]
		private float m_FlexibleHeight = -1f;
	}
}
