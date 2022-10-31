using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200006E RID: 110
	[AddComponentMenu("UI/Scroll Rect", 37)]
	[SelectionBase]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(RectTransform))]
	public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, IEventSystemHandler, ILayoutController
	{
		// Token: 0x060003BD RID: 957 RVA: 0x00015A9C File Offset: 0x00013E9C
		protected ScrollRect()
		{
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00015B2C File Offset: 0x00013F2C
		// (set) Token: 0x060003BF RID: 959 RVA: 0x00015B47 File Offset: 0x00013F47
		public RectTransform content
		{
			get
			{
				return this.m_Content;
			}
			set
			{
				this.m_Content = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00015B54 File Offset: 0x00013F54
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00015B6F File Offset: 0x00013F6F
		public bool horizontal
		{
			get
			{
				return this.m_Horizontal;
			}
			set
			{
				this.m_Horizontal = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00015B7C File Offset: 0x00013F7C
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x00015B97 File Offset: 0x00013F97
		public bool vertical
		{
			get
			{
				return this.m_Vertical;
			}
			set
			{
				this.m_Vertical = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00015BA4 File Offset: 0x00013FA4
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x00015BBF File Offset: 0x00013FBF
		public ScrollRect.MovementType movementType
		{
			get
			{
				return this.m_MovementType;
			}
			set
			{
				this.m_MovementType = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00015BCC File Offset: 0x00013FCC
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x00015BE7 File Offset: 0x00013FE7
		public float elasticity
		{
			get
			{
				return this.m_Elasticity;
			}
			set
			{
				this.m_Elasticity = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00015BF4 File Offset: 0x00013FF4
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x00015C0F File Offset: 0x0001400F
		public bool inertia
		{
			get
			{
				return this.m_Inertia;
			}
			set
			{
				this.m_Inertia = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00015C1C File Offset: 0x0001401C
		// (set) Token: 0x060003CB RID: 971 RVA: 0x00015C37 File Offset: 0x00014037
		public float decelerationRate
		{
			get
			{
				return this.m_DecelerationRate;
			}
			set
			{
				this.m_DecelerationRate = value;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00015C44 File Offset: 0x00014044
		// (set) Token: 0x060003CD RID: 973 RVA: 0x00015C5F File Offset: 0x0001405F
		public float scrollSensitivity
		{
			get
			{
				return this.m_ScrollSensitivity;
			}
			set
			{
				this.m_ScrollSensitivity = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00015C6C File Offset: 0x0001406C
		// (set) Token: 0x060003CF RID: 975 RVA: 0x00015C87 File Offset: 0x00014087
		public RectTransform viewport
		{
			get
			{
				return this.m_Viewport;
			}
			set
			{
				this.m_Viewport = value;
				this.SetDirtyCaching();
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00015C98 File Offset: 0x00014098
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x00015CB4 File Offset: 0x000140B4
		public Scrollbar horizontalScrollbar
		{
			get
			{
				return this.m_HorizontalScrollbar;
			}
			set
			{
				if (this.m_HorizontalScrollbar)
				{
					this.m_HorizontalScrollbar.onValueChanged.RemoveListener(new UnityAction<float>(this.SetHorizontalNormalizedPosition));
				}
				this.m_HorizontalScrollbar = value;
				if (this.m_HorizontalScrollbar)
				{
					this.m_HorizontalScrollbar.onValueChanged.AddListener(new UnityAction<float>(this.SetHorizontalNormalizedPosition));
				}
				this.SetDirtyCaching();
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00015D28 File Offset: 0x00014128
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x00015D44 File Offset: 0x00014144
		public Scrollbar verticalScrollbar
		{
			get
			{
				return this.m_VerticalScrollbar;
			}
			set
			{
				if (this.m_VerticalScrollbar)
				{
					this.m_VerticalScrollbar.onValueChanged.RemoveListener(new UnityAction<float>(this.SetVerticalNormalizedPosition));
				}
				this.m_VerticalScrollbar = value;
				if (this.m_VerticalScrollbar)
				{
					this.m_VerticalScrollbar.onValueChanged.AddListener(new UnityAction<float>(this.SetVerticalNormalizedPosition));
				}
				this.SetDirtyCaching();
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00015DB8 File Offset: 0x000141B8
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x00015DD3 File Offset: 0x000141D3
		public ScrollRect.ScrollbarVisibility horizontalScrollbarVisibility
		{
			get
			{
				return this.m_HorizontalScrollbarVisibility;
			}
			set
			{
				this.m_HorizontalScrollbarVisibility = value;
				this.SetDirtyCaching();
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00015DE4 File Offset: 0x000141E4
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x00015DFF File Offset: 0x000141FF
		public ScrollRect.ScrollbarVisibility verticalScrollbarVisibility
		{
			get
			{
				return this.m_VerticalScrollbarVisibility;
			}
			set
			{
				this.m_VerticalScrollbarVisibility = value;
				this.SetDirtyCaching();
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00015E10 File Offset: 0x00014210
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x00015E2B File Offset: 0x0001422B
		public float horizontalScrollbarSpacing
		{
			get
			{
				return this.m_HorizontalScrollbarSpacing;
			}
			set
			{
				this.m_HorizontalScrollbarSpacing = value;
				this.SetDirty();
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00015E3C File Offset: 0x0001423C
		// (set) Token: 0x060003DB RID: 987 RVA: 0x00015E57 File Offset: 0x00014257
		public float verticalScrollbarSpacing
		{
			get
			{
				return this.m_VerticalScrollbarSpacing;
			}
			set
			{
				this.m_VerticalScrollbarSpacing = value;
				this.SetDirty();
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00015E68 File Offset: 0x00014268
		// (set) Token: 0x060003DD RID: 989 RVA: 0x00015E83 File Offset: 0x00014283
		public ScrollRect.ScrollRectEvent onValueChanged
		{
			get
			{
				return this.m_OnValueChanged;
			}
			set
			{
				this.m_OnValueChanged = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00015E90 File Offset: 0x00014290
		protected RectTransform viewRect
		{
			get
			{
				if (this.m_ViewRect == null)
				{
					this.m_ViewRect = this.m_Viewport;
				}
				if (this.m_ViewRect == null)
				{
					this.m_ViewRect = (RectTransform)base.transform;
				}
				return this.m_ViewRect;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003DF RID: 991 RVA: 0x00015EEC File Offset: 0x000142EC
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x00015F07 File Offset: 0x00014307
		public Vector2 velocity
		{
			get
			{
				return this.m_Velocity;
			}
			set
			{
				this.m_Velocity = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x00015F14 File Offset: 0x00014314
		private RectTransform rectTransform
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

		// Token: 0x060003E2 RID: 994 RVA: 0x00015F4C File Offset: 0x0001434C
		public virtual void Rebuild(CanvasUpdate executing)
		{
			if (executing == CanvasUpdate.Prelayout)
			{
				this.UpdateCachedData();
			}
			if (executing == CanvasUpdate.PostLayout)
			{
				this.UpdateBounds();
				this.UpdateScrollbars(Vector2.zero);
				this.UpdatePrevData();
				this.m_HasRebuiltLayout = true;
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00015F84 File Offset: 0x00014384
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00015F87 File Offset: 0x00014387
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00015F8C File Offset: 0x0001438C
		private void UpdateCachedData()
		{
			Transform transform = base.transform;
			this.m_HorizontalScrollbarRect = ((!(this.m_HorizontalScrollbar == null)) ? (this.m_HorizontalScrollbar.transform as RectTransform) : null);
			this.m_VerticalScrollbarRect = ((!(this.m_VerticalScrollbar == null)) ? (this.m_VerticalScrollbar.transform as RectTransform) : null);
			bool flag = this.viewRect.parent == transform;
			bool flag2 = !this.m_HorizontalScrollbarRect || this.m_HorizontalScrollbarRect.parent == transform;
			bool flag3 = !this.m_VerticalScrollbarRect || this.m_VerticalScrollbarRect.parent == transform;
			bool flag4 = flag && flag2 && flag3;
			this.m_HSliderExpand = (flag4 && this.m_HorizontalScrollbarRect && this.horizontalScrollbarVisibility == ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport);
			this.m_VSliderExpand = (flag4 && this.m_VerticalScrollbarRect && this.verticalScrollbarVisibility == ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport);
			this.m_HSliderHeight = ((!(this.m_HorizontalScrollbarRect == null)) ? this.m_HorizontalScrollbarRect.rect.height : 0f);
			this.m_VSliderWidth = ((!(this.m_VerticalScrollbarRect == null)) ? this.m_VerticalScrollbarRect.rect.width : 0f);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00016128 File Offset: 0x00014528
		protected override void OnEnable()
		{
			base.OnEnable();
			if (this.m_HorizontalScrollbar)
			{
				this.m_HorizontalScrollbar.onValueChanged.AddListener(new UnityAction<float>(this.SetHorizontalNormalizedPosition));
			}
			if (this.m_VerticalScrollbar)
			{
				this.m_VerticalScrollbar.onValueChanged.AddListener(new UnityAction<float>(this.SetVerticalNormalizedPosition));
			}
			CanvasUpdateRegistry.RegisterCanvasElementForLayoutRebuild(this);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0001619C File Offset: 0x0001459C
		protected override void OnDisable()
		{
			CanvasUpdateRegistry.UnRegisterCanvasElementForRebuild(this);
			if (this.m_HorizontalScrollbar)
			{
				this.m_HorizontalScrollbar.onValueChanged.RemoveListener(new UnityAction<float>(this.SetHorizontalNormalizedPosition));
			}
			if (this.m_VerticalScrollbar)
			{
				this.m_VerticalScrollbar.onValueChanged.RemoveListener(new UnityAction<float>(this.SetVerticalNormalizedPosition));
			}
			this.m_HasRebuiltLayout = false;
			this.m_Tracker.Clear();
			this.m_Velocity = Vector2.zero;
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
			base.OnDisable();
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00016238 File Offset: 0x00014638
		public override bool IsActive()
		{
			return base.IsActive() && this.m_Content != null;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00016267 File Offset: 0x00014667
		private void EnsureLayoutHasRebuilt()
		{
			if (!this.m_HasRebuiltLayout && !CanvasUpdateRegistry.IsRebuildingLayout())
			{
				Canvas.ForceUpdateCanvases();
			}
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00016284 File Offset: 0x00014684
		public virtual void StopMovement()
		{
			this.m_Velocity = Vector2.zero;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00016294 File Offset: 0x00014694
		public virtual void OnScroll(PointerEventData data)
		{
			if (this.IsActive())
			{
				this.EnsureLayoutHasRebuilt();
				this.UpdateBounds();
				Vector2 scrollDelta = data.scrollDelta;
				scrollDelta.y *= -1f;
				if (this.vertical && !this.horizontal)
				{
					if (Mathf.Abs(scrollDelta.x) > Mathf.Abs(scrollDelta.y))
					{
						scrollDelta.y = scrollDelta.x;
					}
					scrollDelta.x = 0f;
				}
				if (this.horizontal && !this.vertical)
				{
					if (Mathf.Abs(scrollDelta.y) > Mathf.Abs(scrollDelta.x))
					{
						scrollDelta.x = scrollDelta.y;
					}
					scrollDelta.y = 0f;
				}
				Vector2 vector = this.m_Content.anchoredPosition;
				vector += scrollDelta * this.m_ScrollSensitivity;
				if (this.m_MovementType == ScrollRect.MovementType.Clamped)
				{
					vector += this.CalculateOffset(vector - this.m_Content.anchoredPosition);
				}
				this.SetContentAnchoredPosition(vector);
				this.UpdateBounds();
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x000163CC File Offset: 0x000147CC
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
			if (eventData.button == PointerEventData.InputButton.Left)
			{
				this.m_Velocity = Vector2.zero;
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x000163EC File Offset: 0x000147EC
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
			if (eventData.button == PointerEventData.InputButton.Left)
			{
				if (this.IsActive())
				{
					this.UpdateBounds();
					this.m_PointerStartLocalCursor = Vector2.zero;
					RectTransformUtility.ScreenPointToLocalPointInRectangle(this.viewRect, eventData.position, eventData.pressEventCamera, out this.m_PointerStartLocalCursor);
					this.m_ContentStartPosition = this.m_Content.anchoredPosition;
					this.m_Dragging = true;
				}
			}
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00016461 File Offset: 0x00014861
		public virtual void OnEndDrag(PointerEventData eventData)
		{
			if (eventData.button == PointerEventData.InputButton.Left)
			{
				this.m_Dragging = false;
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0001647C File Offset: 0x0001487C
		public virtual void OnDrag(PointerEventData eventData)
		{
			if (eventData.button == PointerEventData.InputButton.Left)
			{
				if (this.IsActive())
				{
					Vector2 a;
					if (RectTransformUtility.ScreenPointToLocalPointInRectangle(this.viewRect, eventData.position, eventData.pressEventCamera, out a))
					{
						this.UpdateBounds();
						Vector2 b = a - this.m_PointerStartLocalCursor;
						Vector2 vector = this.m_ContentStartPosition + b;
						Vector2 b2 = this.CalculateOffset(vector - this.m_Content.anchoredPosition);
						vector += b2;
						if (this.m_MovementType == ScrollRect.MovementType.Elastic)
						{
							if (b2.x != 0f)
							{
								vector.x -= ScrollRect.RubberDelta(b2.x, this.m_ViewBounds.size.x);
							}
							if (b2.y != 0f)
							{
								vector.y -= ScrollRect.RubberDelta(b2.y, this.m_ViewBounds.size.y);
							}
						}
						this.SetContentAnchoredPosition(vector);
					}
				}
			}
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x000165A4 File Offset: 0x000149A4
		protected virtual void SetContentAnchoredPosition(Vector2 position)
		{
			if (!this.m_Horizontal)
			{
				position.x = this.m_Content.anchoredPosition.x;
			}
			if (!this.m_Vertical)
			{
				position.y = this.m_Content.anchoredPosition.y;
			}
			if (position != this.m_Content.anchoredPosition)
			{
				this.m_Content.anchoredPosition = position;
				this.UpdateBounds();
			}
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00016628 File Offset: 0x00014A28
		protected virtual void LateUpdate()
		{
			if (this.m_Content)
			{
				this.EnsureLayoutHasRebuilt();
				this.UpdateScrollbarVisibility();
				this.UpdateBounds();
				float unscaledDeltaTime = Time.unscaledDeltaTime;
				Vector2 vector = this.CalculateOffset(Vector2.zero);
				if (!this.m_Dragging && (vector != Vector2.zero || this.m_Velocity != Vector2.zero))
				{
					Vector2 vector2 = this.m_Content.anchoredPosition;
					for (int i = 0; i < 2; i++)
					{
						if (this.m_MovementType == ScrollRect.MovementType.Elastic && vector[i] != 0f)
						{
							float num = this.m_Velocity[i];
							vector2[i] = Mathf.SmoothDamp(this.m_Content.anchoredPosition[i], this.m_Content.anchoredPosition[i] + vector[i], ref num, this.m_Elasticity, float.PositiveInfinity, unscaledDeltaTime);
							if (Mathf.Abs(num) < 1f)
							{
								num = 0f;
							}
							this.m_Velocity[i] = num;
						}
						else if (this.m_Inertia)
						{
							ref Vector2 ptr = ref this.m_Velocity;
							int index;
							this.m_Velocity[index = i] = ptr[index] * Mathf.Pow(this.m_DecelerationRate, unscaledDeltaTime);
							if (Mathf.Abs(this.m_Velocity[i]) < 1f)
							{
								this.m_Velocity[i] = 0f;
							}
							ptr = ref vector2;
							int index2;
							vector2[index2 = i] = ptr[index2] + this.m_Velocity[i] * unscaledDeltaTime;
						}
						else
						{
							this.m_Velocity[i] = 0f;
						}
					}
					if (this.m_Velocity != Vector2.zero)
					{
						if (this.m_MovementType == ScrollRect.MovementType.Clamped)
						{
							vector = this.CalculateOffset(vector2 - this.m_Content.anchoredPosition);
							vector2 += vector;
						}
						this.SetContentAnchoredPosition(vector2);
					}
				}
				if (this.m_Dragging && this.m_Inertia)
				{
					Vector3 b = (this.m_Content.anchoredPosition - this.m_PrevPosition) / unscaledDeltaTime;
					this.m_Velocity = Vector3.Lerp(this.m_Velocity, b, unscaledDeltaTime * 10f);
				}
				if (this.m_ViewBounds != this.m_PrevViewBounds || this.m_ContentBounds != this.m_PrevContentBounds || this.m_Content.anchoredPosition != this.m_PrevPosition)
				{
					this.UpdateScrollbars(vector);
					this.m_OnValueChanged.Invoke(this.normalizedPosition);
					this.UpdatePrevData();
				}
			}
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0001691C File Offset: 0x00014D1C
		protected void UpdatePrevData()
		{
			if (this.m_Content == null)
			{
				this.m_PrevPosition = Vector2.zero;
			}
			else
			{
				this.m_PrevPosition = this.m_Content.anchoredPosition;
			}
			this.m_PrevViewBounds = this.m_ViewBounds;
			this.m_PrevContentBounds = this.m_ContentBounds;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00016974 File Offset: 0x00014D74
		private void UpdateScrollbars(Vector2 offset)
		{
			if (this.m_HorizontalScrollbar)
			{
				if (this.m_ContentBounds.size.x > 0f)
				{
					this.m_HorizontalScrollbar.size = Mathf.Clamp01((this.m_ViewBounds.size.x - Mathf.Abs(offset.x)) / this.m_ContentBounds.size.x);
				}
				else
				{
					this.m_HorizontalScrollbar.size = 1f;
				}
				this.m_HorizontalScrollbar.value = this.horizontalNormalizedPosition;
			}
			if (this.m_VerticalScrollbar)
			{
				if (this.m_ContentBounds.size.y > 0f)
				{
					this.m_VerticalScrollbar.size = Mathf.Clamp01((this.m_ViewBounds.size.y - Mathf.Abs(offset.y)) / this.m_ContentBounds.size.y);
				}
				else
				{
					this.m_VerticalScrollbar.size = 1f;
				}
				this.m_VerticalScrollbar.value = this.verticalNormalizedPosition;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00016AB8 File Offset: 0x00014EB8
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x00016ADE File Offset: 0x00014EDE
		public Vector2 normalizedPosition
		{
			get
			{
				return new Vector2(this.horizontalNormalizedPosition, this.verticalNormalizedPosition);
			}
			set
			{
				this.SetNormalizedPosition(value.x, 0);
				this.SetNormalizedPosition(value.y, 1);
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00016B00 File Offset: 0x00014F00
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x00016BD5 File Offset: 0x00014FD5
		public float horizontalNormalizedPosition
		{
			get
			{
				this.UpdateBounds();
				float result;
				if (this.m_ContentBounds.size.x <= this.m_ViewBounds.size.x)
				{
					result = (float)((this.m_ViewBounds.min.x <= this.m_ContentBounds.min.x) ? 0 : 1);
				}
				else
				{
					result = (this.m_ViewBounds.min.x - this.m_ContentBounds.min.x) / (this.m_ContentBounds.size.x - this.m_ViewBounds.size.x);
				}
				return result;
			}
			set
			{
				this.SetNormalizedPosition(value, 0);
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x00016BE0 File Offset: 0x00014FE0
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x00016CB5 File Offset: 0x000150B5
		public float verticalNormalizedPosition
		{
			get
			{
				this.UpdateBounds();
				float result;
				if (this.m_ContentBounds.size.y <= this.m_ViewBounds.size.y)
				{
					result = (float)((this.m_ViewBounds.min.y <= this.m_ContentBounds.min.y) ? 0 : 1);
				}
				else
				{
					result = (this.m_ViewBounds.min.y - this.m_ContentBounds.min.y) / (this.m_ContentBounds.size.y - this.m_ViewBounds.size.y);
				}
				return result;
			}
			set
			{
				this.SetNormalizedPosition(value, 1);
			}
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00016CC0 File Offset: 0x000150C0
		private void SetHorizontalNormalizedPosition(float value)
		{
			this.SetNormalizedPosition(value, 0);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00016CCB File Offset: 0x000150CB
		private void SetVerticalNormalizedPosition(float value)
		{
			this.SetNormalizedPosition(value, 1);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00016CD8 File Offset: 0x000150D8
		protected virtual void SetNormalizedPosition(float value, int axis)
		{
			this.EnsureLayoutHasRebuilt();
			this.UpdateBounds();
			float num = this.m_ContentBounds.size[axis] - this.m_ViewBounds.size[axis];
			float num2 = this.m_ViewBounds.min[axis] - value * num;
			float num3 = this.m_Content.localPosition[axis] + num2 - this.m_ContentBounds.min[axis];
			Vector3 localPosition = this.m_Content.localPosition;
			if (Mathf.Abs(localPosition[axis] - num3) > 0.01f)
			{
				localPosition[axis] = num3;
				this.m_Content.localPosition = localPosition;
				this.m_Velocity[axis] = 0f;
				this.UpdateBounds();
			}
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00016DBC File Offset: 0x000151BC
		private static float RubberDelta(float overStretching, float viewSize)
		{
			return (1f - 1f / (Mathf.Abs(overStretching) * 0.55f / viewSize + 1f)) * viewSize * Mathf.Sign(overStretching);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00016DFA File Offset: 0x000151FA
		protected override void OnRectTransformDimensionsChange()
		{
			this.SetDirty();
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x00016E04 File Offset: 0x00015204
		private bool hScrollingNeeded
		{
			get
			{
				return !Application.isPlaying || this.m_ContentBounds.size.x > this.m_ViewBounds.size.x + 0.01f;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00016E58 File Offset: 0x00015258
		private bool vScrollingNeeded
		{
			get
			{
				return !Application.isPlaying || this.m_ContentBounds.size.y > this.m_ViewBounds.size.y + 0.01f;
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00016EAC File Offset: 0x000152AC
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00016EAF File Offset: 0x000152AF
		public virtual void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x00016EB4 File Offset: 0x000152B4
		public virtual float minWidth
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00016ED0 File Offset: 0x000152D0
		public virtual float preferredWidth
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x00016EEC File Offset: 0x000152EC
		public virtual float flexibleWidth
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00016F08 File Offset: 0x00015308
		public virtual float minHeight
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x00016F24 File Offset: 0x00015324
		public virtual float preferredHeight
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00016F40 File Offset: 0x00015340
		public virtual float flexibleHeight
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x00016F5C File Offset: 0x0001535C
		public virtual int layoutPriority
		{
			get
			{
				return -1;
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00016F74 File Offset: 0x00015374
		public virtual void SetLayoutHorizontal()
		{
			this.m_Tracker.Clear();
			if (this.m_HSliderExpand || this.m_VSliderExpand)
			{
				this.m_Tracker.Add(this, this.viewRect, DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.AnchorMinX | DrivenTransformProperties.AnchorMinY | DrivenTransformProperties.AnchorMaxX | DrivenTransformProperties.AnchorMaxY | DrivenTransformProperties.SizeDeltaX | DrivenTransformProperties.SizeDeltaY);
				this.viewRect.anchorMin = Vector2.zero;
				this.viewRect.anchorMax = Vector2.one;
				this.viewRect.sizeDelta = Vector2.zero;
				this.viewRect.anchoredPosition = Vector2.zero;
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.content);
				this.m_ViewBounds = new Bounds(this.viewRect.rect.center, this.viewRect.rect.size);
				this.m_ContentBounds = this.GetBounds();
			}
			if (this.m_VSliderExpand && this.vScrollingNeeded)
			{
				this.viewRect.sizeDelta = new Vector2(-(this.m_VSliderWidth + this.m_VerticalScrollbarSpacing), this.viewRect.sizeDelta.y);
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.content);
				this.m_ViewBounds = new Bounds(this.viewRect.rect.center, this.viewRect.rect.size);
				this.m_ContentBounds = this.GetBounds();
			}
			if (this.m_HSliderExpand && this.hScrollingNeeded)
			{
				this.viewRect.sizeDelta = new Vector2(this.viewRect.sizeDelta.x, -(this.m_HSliderHeight + this.m_HorizontalScrollbarSpacing));
				this.m_ViewBounds = new Bounds(this.viewRect.rect.center, this.viewRect.rect.size);
				this.m_ContentBounds = this.GetBounds();
			}
			if (this.m_VSliderExpand && this.vScrollingNeeded && this.viewRect.sizeDelta.x == 0f && this.viewRect.sizeDelta.y < 0f)
			{
				this.viewRect.sizeDelta = new Vector2(-(this.m_VSliderWidth + this.m_VerticalScrollbarSpacing), this.viewRect.sizeDelta.y);
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00017204 File Offset: 0x00015604
		public virtual void SetLayoutVertical()
		{
			this.UpdateScrollbarLayout();
			this.m_ViewBounds = new Bounds(this.viewRect.rect.center, this.viewRect.rect.size);
			this.m_ContentBounds = this.GetBounds();
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0001725F File Offset: 0x0001565F
		private void UpdateScrollbarVisibility()
		{
			ScrollRect.UpdateOneScrollbarVisibility(this.vScrollingNeeded, this.m_Vertical, this.m_VerticalScrollbarVisibility, this.m_VerticalScrollbar);
			ScrollRect.UpdateOneScrollbarVisibility(this.hScrollingNeeded, this.m_Horizontal, this.m_HorizontalScrollbarVisibility, this.m_HorizontalScrollbar);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0001729C File Offset: 0x0001569C
		private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollRect.ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar)
		{
			if (scrollbar)
			{
				if (scrollbarVisibility == ScrollRect.ScrollbarVisibility.Permanent)
				{
					if (scrollbar.gameObject.activeSelf != xAxisEnabled)
					{
						scrollbar.gameObject.SetActive(xAxisEnabled);
					}
				}
				else if (scrollbar.gameObject.activeSelf != xScrollingNeeded)
				{
					scrollbar.gameObject.SetActive(xScrollingNeeded);
				}
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00017300 File Offset: 0x00015700
		private void UpdateScrollbarLayout()
		{
			if (this.m_VSliderExpand && this.m_HorizontalScrollbar)
			{
				this.m_Tracker.Add(this, this.m_HorizontalScrollbarRect, DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.AnchorMinX | DrivenTransformProperties.AnchorMaxX | DrivenTransformProperties.SizeDeltaX);
				this.m_HorizontalScrollbarRect.anchorMin = new Vector2(0f, this.m_HorizontalScrollbarRect.anchorMin.y);
				this.m_HorizontalScrollbarRect.anchorMax = new Vector2(1f, this.m_HorizontalScrollbarRect.anchorMax.y);
				this.m_HorizontalScrollbarRect.anchoredPosition = new Vector2(0f, this.m_HorizontalScrollbarRect.anchoredPosition.y);
				if (this.vScrollingNeeded)
				{
					this.m_HorizontalScrollbarRect.sizeDelta = new Vector2(-(this.m_VSliderWidth + this.m_VerticalScrollbarSpacing), this.m_HorizontalScrollbarRect.sizeDelta.y);
				}
				else
				{
					this.m_HorizontalScrollbarRect.sizeDelta = new Vector2(0f, this.m_HorizontalScrollbarRect.sizeDelta.y);
				}
			}
			if (this.m_HSliderExpand && this.m_VerticalScrollbar)
			{
				this.m_Tracker.Add(this, this.m_VerticalScrollbarRect, DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.AnchorMinY | DrivenTransformProperties.AnchorMaxY | DrivenTransformProperties.SizeDeltaY);
				this.m_VerticalScrollbarRect.anchorMin = new Vector2(this.m_VerticalScrollbarRect.anchorMin.x, 0f);
				this.m_VerticalScrollbarRect.anchorMax = new Vector2(this.m_VerticalScrollbarRect.anchorMax.x, 1f);
				this.m_VerticalScrollbarRect.anchoredPosition = new Vector2(this.m_VerticalScrollbarRect.anchoredPosition.x, 0f);
				if (this.hScrollingNeeded)
				{
					this.m_VerticalScrollbarRect.sizeDelta = new Vector2(this.m_VerticalScrollbarRect.sizeDelta.x, -(this.m_HSliderHeight + this.m_HorizontalScrollbarSpacing));
				}
				else
				{
					this.m_VerticalScrollbarRect.sizeDelta = new Vector2(this.m_VerticalScrollbarRect.sizeDelta.x, 0f);
				}
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00017540 File Offset: 0x00015940
		protected void UpdateBounds()
		{
			this.m_ViewBounds = new Bounds(this.viewRect.rect.center, this.viewRect.rect.size);
			this.m_ContentBounds = this.GetBounds();
			if (!(this.m_Content == null))
			{
				Vector3 size = this.m_ContentBounds.size;
				Vector3 center = this.m_ContentBounds.center;
				Vector2 pivot = this.m_Content.pivot;
				ScrollRect.AdjustBounds(ref this.m_ViewBounds, ref pivot, ref size, ref center);
				this.m_ContentBounds.size = size;
				this.m_ContentBounds.center = center;
				if (this.movementType == ScrollRect.MovementType.Clamped)
				{
					Vector2 zero = Vector2.zero;
					if (this.m_ViewBounds.max.x > this.m_ContentBounds.max.x)
					{
						zero.x = Math.Min(this.m_ViewBounds.min.x - this.m_ContentBounds.min.x, this.m_ViewBounds.max.x - this.m_ContentBounds.max.x);
					}
					else if (this.m_ViewBounds.min.x < this.m_ContentBounds.min.x)
					{
						zero.x = Math.Max(this.m_ViewBounds.min.x - this.m_ContentBounds.min.x, this.m_ViewBounds.max.x - this.m_ContentBounds.max.x);
					}
					if (this.m_ViewBounds.min.y < this.m_ContentBounds.min.y)
					{
						zero.y = Math.Max(this.m_ViewBounds.min.y - this.m_ContentBounds.min.y, this.m_ViewBounds.max.y - this.m_ContentBounds.max.y);
					}
					else if (this.m_ViewBounds.max.y > this.m_ContentBounds.max.y)
					{
						zero.y = Math.Min(this.m_ViewBounds.min.y - this.m_ContentBounds.min.y, this.m_ViewBounds.max.y - this.m_ContentBounds.max.y);
					}
					if (zero.sqrMagnitude > 1E-45f)
					{
						center = this.m_Content.anchoredPosition + zero;
						if (!this.m_Horizontal)
						{
							center.x = this.m_Content.anchoredPosition.x;
						}
						if (!this.m_Vertical)
						{
							center.y = this.m_Content.anchoredPosition.y;
						}
						ScrollRect.AdjustBounds(ref this.m_ViewBounds, ref pivot, ref size, ref center);
					}
				}
			}
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x000178D4 File Offset: 0x00015CD4
		internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos)
		{
			Vector3 vector = viewBounds.size - contentSize;
			if (vector.x > 0f)
			{
				contentPos.x -= vector.x * (contentPivot.x - 0.5f);
				contentSize.x = viewBounds.size.x;
			}
			if (vector.y > 0f)
			{
				contentPos.y -= vector.y * (contentPivot.y - 0.5f);
				contentSize.y = viewBounds.size.y;
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00017984 File Offset: 0x00015D84
		private Bounds GetBounds()
		{
			Bounds result;
			if (this.m_Content == null)
			{
				result = default(Bounds);
			}
			else
			{
				this.m_Content.GetWorldCorners(this.m_Corners);
				Matrix4x4 worldToLocalMatrix = this.viewRect.worldToLocalMatrix;
				result = ScrollRect.InternalGetBounds(this.m_Corners, ref worldToLocalMatrix);
			}
			return result;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x000179E4 File Offset: 0x00015DE4
		internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix)
		{
			Vector3 vector = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
			Vector3 vector2 = new Vector3(float.MinValue, float.MinValue, float.MinValue);
			for (int i = 0; i < 4; i++)
			{
				Vector3 lhs = viewWorldToLocalMatrix.MultiplyPoint3x4(corners[i]);
				vector = Vector3.Min(lhs, vector);
				vector2 = Vector3.Max(lhs, vector2);
			}
			Bounds result = new Bounds(vector, Vector3.zero);
			result.Encapsulate(vector2);
			return result;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00017A78 File Offset: 0x00015E78
		private Vector2 CalculateOffset(Vector2 delta)
		{
			return ScrollRect.InternalCalculateOffset(ref this.m_ViewBounds, ref this.m_ContentBounds, this.m_Horizontal, this.m_Vertical, this.m_MovementType, ref delta);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00017AB4 File Offset: 0x00015EB4
		internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, ScrollRect.MovementType movementType, ref Vector2 delta)
		{
			Vector2 zero = Vector2.zero;
			Vector2 result;
			if (movementType == ScrollRect.MovementType.Unrestricted)
			{
				result = zero;
			}
			else
			{
				Vector2 vector = contentBounds.min;
				Vector2 vector2 = contentBounds.max;
				if (horizontal)
				{
					vector.x += delta.x;
					vector2.x += delta.x;
					if (vector.x > viewBounds.min.x)
					{
						zero.x = viewBounds.min.x - vector.x;
					}
					else if (vector2.x < viewBounds.max.x)
					{
						zero.x = viewBounds.max.x - vector2.x;
					}
				}
				if (vertical)
				{
					vector.y += delta.y;
					vector2.y += delta.y;
					if (vector2.y < viewBounds.max.y)
					{
						zero.y = viewBounds.max.y - vector2.y;
					}
					else if (vector.y > viewBounds.min.y)
					{
						zero.y = viewBounds.min.y - vector.y;
					}
				}
				result = zero;
			}
			return result;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00017C48 File Offset: 0x00016048
		protected void SetDirty()
		{
			if (this.IsActive())
			{
				LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
			}
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00017C66 File Offset: 0x00016066
		protected void SetDirtyCaching()
		{
			if (this.IsActive())
			{
				CanvasUpdateRegistry.RegisterCanvasElementForLayoutRebuild(this);
				LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00017C8A File Offset: 0x0001608A
		Transform ICanvasElement.get_transform()
		{
			return base.transform;
		}

		// Token: 0x040001D9 RID: 473
		[SerializeField]
		private RectTransform m_Content;

		// Token: 0x040001DA RID: 474
		[SerializeField]
		private bool m_Horizontal = true;

		// Token: 0x040001DB RID: 475
		[SerializeField]
		private bool m_Vertical = true;

		// Token: 0x040001DC RID: 476
		[SerializeField]
		private ScrollRect.MovementType m_MovementType = ScrollRect.MovementType.Elastic;

		// Token: 0x040001DD RID: 477
		[SerializeField]
		private float m_Elasticity = 0.1f;

		// Token: 0x040001DE RID: 478
		[SerializeField]
		private bool m_Inertia = true;

		// Token: 0x040001DF RID: 479
		[SerializeField]
		private float m_DecelerationRate = 0.135f;

		// Token: 0x040001E0 RID: 480
		[SerializeField]
		private float m_ScrollSensitivity = 1f;

		// Token: 0x040001E1 RID: 481
		[SerializeField]
		private RectTransform m_Viewport;

		// Token: 0x040001E2 RID: 482
		[SerializeField]
		private Scrollbar m_HorizontalScrollbar;

		// Token: 0x040001E3 RID: 483
		[SerializeField]
		private Scrollbar m_VerticalScrollbar;

		// Token: 0x040001E4 RID: 484
		[SerializeField]
		private ScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility;

		// Token: 0x040001E5 RID: 485
		[SerializeField]
		private ScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility;

		// Token: 0x040001E6 RID: 486
		[SerializeField]
		private float m_HorizontalScrollbarSpacing;

		// Token: 0x040001E7 RID: 487
		[SerializeField]
		private float m_VerticalScrollbarSpacing;

		// Token: 0x040001E8 RID: 488
		[SerializeField]
		private ScrollRect.ScrollRectEvent m_OnValueChanged = new ScrollRect.ScrollRectEvent();

		// Token: 0x040001E9 RID: 489
		private Vector2 m_PointerStartLocalCursor = Vector2.zero;

		// Token: 0x040001EA RID: 490
		protected Vector2 m_ContentStartPosition = Vector2.zero;

		// Token: 0x040001EB RID: 491
		private RectTransform m_ViewRect;

		// Token: 0x040001EC RID: 492
		protected Bounds m_ContentBounds;

		// Token: 0x040001ED RID: 493
		private Bounds m_ViewBounds;

		// Token: 0x040001EE RID: 494
		private Vector2 m_Velocity;

		// Token: 0x040001EF RID: 495
		private bool m_Dragging;

		// Token: 0x040001F0 RID: 496
		private Vector2 m_PrevPosition = Vector2.zero;

		// Token: 0x040001F1 RID: 497
		private Bounds m_PrevContentBounds;

		// Token: 0x040001F2 RID: 498
		private Bounds m_PrevViewBounds;

		// Token: 0x040001F3 RID: 499
		[NonSerialized]
		private bool m_HasRebuiltLayout = false;

		// Token: 0x040001F4 RID: 500
		private bool m_HSliderExpand;

		// Token: 0x040001F5 RID: 501
		private bool m_VSliderExpand;

		// Token: 0x040001F6 RID: 502
		private float m_HSliderHeight;

		// Token: 0x040001F7 RID: 503
		private float m_VSliderWidth;

		// Token: 0x040001F8 RID: 504
		[NonSerialized]
		private RectTransform m_Rect;

		// Token: 0x040001F9 RID: 505
		private RectTransform m_HorizontalScrollbarRect;

		// Token: 0x040001FA RID: 506
		private RectTransform m_VerticalScrollbarRect;

		// Token: 0x040001FB RID: 507
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x040001FC RID: 508
		private readonly Vector3[] m_Corners = new Vector3[4];

		// Token: 0x0200006F RID: 111
		public enum MovementType
		{
			// Token: 0x040001FE RID: 510
			Unrestricted,
			// Token: 0x040001FF RID: 511
			Elastic,
			// Token: 0x04000200 RID: 512
			Clamped
		}

		// Token: 0x02000070 RID: 112
		public enum ScrollbarVisibility
		{
			// Token: 0x04000202 RID: 514
			Permanent,
			// Token: 0x04000203 RID: 515
			AutoHide,
			// Token: 0x04000204 RID: 516
			AutoHideAndExpandViewport
		}

		// Token: 0x02000071 RID: 113
		[Serializable]
		public class ScrollRectEvent : UnityEvent<Vector2>
		{
		}
	}
}
