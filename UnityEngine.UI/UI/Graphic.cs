using System;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI.CoroutineTween;

namespace UnityEngine.UI
{
	// Token: 0x02000049 RID: 73
	[DisallowMultipleComponent]
	[RequireComponent(typeof(CanvasRenderer))]
	[RequireComponent(typeof(RectTransform))]
	[ExecuteInEditMode]
	public abstract class Graphic : UIBehaviour, ICanvasElement
	{
		// Token: 0x06000225 RID: 549 RVA: 0x0000B0BC File Offset: 0x000094BC
		protected Graphic()
		{
			if (this.m_ColorTweenRunner == null)
			{
				this.m_ColorTweenRunner = new TweenRunner<ColorTween>();
			}
			this.m_ColorTweenRunner.Init(this);
			this.useLegacyMeshGeneration = true;
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0000B10C File Offset: 0x0000950C
		public static Material defaultGraphicMaterial
		{
			get
			{
				if (Graphic.s_DefaultUI == null)
				{
					Graphic.s_DefaultUI = Canvas.GetDefaultCanvasMaterial();
				}
				return Graphic.s_DefaultUI;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0000B140 File Offset: 0x00009540
		// (set) Token: 0x06000228 RID: 552 RVA: 0x0000B15B File Offset: 0x0000955B
		public virtual Color color
		{
			get
			{
				return this.m_Color;
			}
			set
			{
				if (SetPropertyUtility.SetColor(ref this.m_Color, value))
				{
					this.SetVerticesDirty();
				}
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0000B178 File Offset: 0x00009578
		// (set) Token: 0x0600022A RID: 554 RVA: 0x0000B193 File Offset: 0x00009593
		public virtual bool raycastTarget
		{
			get
			{
				return this.m_RaycastTarget;
			}
			set
			{
				this.m_RaycastTarget = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0000B1A0 File Offset: 0x000095A0
		// (set) Token: 0x0600022C RID: 556 RVA: 0x0000B1BA File Offset: 0x000095BA
		protected bool useLegacyMeshGeneration { get; set; }

		// Token: 0x0600022D RID: 557 RVA: 0x0000B1C3 File Offset: 0x000095C3
		public virtual void SetAllDirty()
		{
			this.SetLayoutDirty();
			this.SetVerticesDirty();
			this.SetMaterialDirty();
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000B1D8 File Offset: 0x000095D8
		public virtual void SetLayoutDirty()
		{
			if (this.IsActive())
			{
				LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
				if (this.m_OnDirtyLayoutCallback != null)
				{
					this.m_OnDirtyLayoutCallback();
				}
			}
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000B20C File Offset: 0x0000960C
		public virtual void SetVerticesDirty()
		{
			if (this.IsActive())
			{
				this.m_VertsDirty = true;
				CanvasUpdateRegistry.RegisterCanvasElementForGraphicRebuild(this);
				if (this.m_OnDirtyVertsCallback != null)
				{
					this.m_OnDirtyVertsCallback();
				}
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000B242 File Offset: 0x00009642
		public virtual void SetMaterialDirty()
		{
			if (this.IsActive())
			{
				this.m_MaterialDirty = true;
				CanvasUpdateRegistry.RegisterCanvasElementForGraphicRebuild(this);
				if (this.m_OnDirtyMaterialCallback != null)
				{
					this.m_OnDirtyMaterialCallback();
				}
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000B278 File Offset: 0x00009678
		protected override void OnRectTransformDimensionsChange()
		{
			if (base.gameObject.activeInHierarchy)
			{
				if (CanvasUpdateRegistry.IsRebuildingLayout())
				{
					this.SetVerticesDirty();
				}
				else
				{
					this.SetVerticesDirty();
					this.SetLayoutDirty();
				}
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000B2B0 File Offset: 0x000096B0
		protected override void OnBeforeTransformParentChanged()
		{
			GraphicRegistry.UnregisterGraphicForCanvas(this.canvas, this);
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000B2CA File Offset: 0x000096CA
		protected override void OnTransformParentChanged()
		{
			base.OnTransformParentChanged();
			this.m_Canvas = null;
			if (this.IsActive())
			{
				this.CacheCanvas();
				GraphicRegistry.RegisterGraphicForCanvas(this.canvas, this);
				this.SetAllDirty();
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000234 RID: 564 RVA: 0x0000B304 File Offset: 0x00009704
		public int depth
		{
			get
			{
				return this.canvasRenderer.absoluteDepth;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000235 RID: 565 RVA: 0x0000B324 File Offset: 0x00009724
		public RectTransform rectTransform
		{
			get
			{
				RectTransform result;
				if ((result = this.m_RectTransform) == null)
				{
					result = (this.m_RectTransform = base.GetComponent<RectTransform>());
				}
				return result;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000236 RID: 566 RVA: 0x0000B358 File Offset: 0x00009758
		public Canvas canvas
		{
			get
			{
				if (this.m_Canvas == null)
				{
					this.CacheCanvas();
				}
				return this.m_Canvas;
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000B38C File Offset: 0x0000978C
		private void CacheCanvas()
		{
			List<Canvas> list = ListPool<Canvas>.Get();
			base.gameObject.GetComponentsInParent<Canvas>(false, list);
			if (list.Count > 0)
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].isActiveAndEnabled)
					{
						this.m_Canvas = list[i];
						break;
					}
				}
			}
			else
			{
				this.m_Canvas = null;
			}
			ListPool<Canvas>.Release(list);
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0000B40C File Offset: 0x0000980C
		public CanvasRenderer canvasRenderer
		{
			get
			{
				if (this.m_CanvasRender == null)
				{
					this.m_CanvasRender = base.GetComponent<CanvasRenderer>();
				}
				return this.m_CanvasRender;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0000B444 File Offset: 0x00009844
		public virtual Material defaultMaterial
		{
			get
			{
				return Graphic.defaultGraphicMaterial;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600023A RID: 570 RVA: 0x0000B460 File Offset: 0x00009860
		// (set) Token: 0x0600023B RID: 571 RVA: 0x0000B497 File Offset: 0x00009897
		public virtual Material material
		{
			get
			{
				return (!(this.m_Material != null)) ? this.defaultMaterial : this.m_Material;
			}
			set
			{
				if (!(this.m_Material == value))
				{
					this.m_Material = value;
					this.SetMaterialDirty();
				}
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0000B4C0 File Offset: 0x000098C0
		public virtual Material materialForRendering
		{
			get
			{
				List<Component> list = ListPool<Component>.Get();
				base.GetComponents(typeof(IMaterialModifier), list);
				Material material = this.material;
				for (int i = 0; i < list.Count; i++)
				{
					material = (list[i] as IMaterialModifier).GetModifiedMaterial(material);
				}
				ListPool<Component>.Release(list);
				return material;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600023D RID: 573 RVA: 0x0000B524 File Offset: 0x00009924
		public virtual Texture mainTexture
		{
			get
			{
				return Graphic.s_WhiteTexture;
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000B53E File Offset: 0x0000993E
		protected override void OnEnable()
		{
			base.OnEnable();
			this.CacheCanvas();
			GraphicRegistry.RegisterGraphicForCanvas(this.canvas, this);
			if (Graphic.s_WhiteTexture == null)
			{
				Graphic.s_WhiteTexture = Texture2D.whiteTexture;
			}
			this.SetAllDirty();
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000B57C File Offset: 0x0000997C
		protected override void OnDisable()
		{
			GraphicRegistry.UnregisterGraphicForCanvas(this.canvas, this);
			CanvasUpdateRegistry.UnRegisterCanvasElementForRebuild(this);
			if (this.canvasRenderer != null)
			{
				this.canvasRenderer.Clear();
			}
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
			base.OnDisable();
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000B5CC File Offset: 0x000099CC
		protected override void OnCanvasHierarchyChanged()
		{
			Canvas canvas = this.m_Canvas;
			this.m_Canvas = null;
			if (this.IsActive())
			{
				this.CacheCanvas();
				if (canvas != this.m_Canvas)
				{
					GraphicRegistry.UnregisterGraphicForCanvas(canvas, this);
					if (this.IsActive())
					{
						GraphicRegistry.RegisterGraphicForCanvas(this.canvas, this);
					}
				}
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000B630 File Offset: 0x00009A30
		public virtual void Rebuild(CanvasUpdate update)
		{
			if (!this.canvasRenderer.cull)
			{
				if (update == CanvasUpdate.PreRender)
				{
					if (this.m_VertsDirty)
					{
						this.UpdateGeometry();
						this.m_VertsDirty = false;
					}
					if (this.m_MaterialDirty)
					{
						this.UpdateMaterial();
						this.m_MaterialDirty = false;
					}
				}
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000B698 File Offset: 0x00009A98
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000B69B File Offset: 0x00009A9B
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000B6A0 File Offset: 0x00009AA0
		protected virtual void UpdateMaterial()
		{
			if (this.IsActive())
			{
				this.canvasRenderer.materialCount = 1;
				this.canvasRenderer.SetMaterial(this.materialForRendering, 0);
				this.canvasRenderer.SetTexture(this.mainTexture);
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000B6ED File Offset: 0x00009AED
		protected virtual void UpdateGeometry()
		{
			if (this.useLegacyMeshGeneration)
			{
				this.DoLegacyMeshGeneration();
			}
			else
			{
				this.DoMeshGeneration();
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000B70C File Offset: 0x00009B0C
		private void DoMeshGeneration()
		{
			if (this.rectTransform != null && this.rectTransform.rect.width >= 0f && this.rectTransform.rect.height >= 0f)
			{
				this.OnPopulateMesh(Graphic.s_VertexHelper);
			}
			else
			{
				Graphic.s_VertexHelper.Clear();
			}
			List<Component> list = ListPool<Component>.Get();
			base.GetComponents(typeof(IMeshModifier), list);
			for (int i = 0; i < list.Count; i++)
			{
				((IMeshModifier)list[i]).ModifyMesh(Graphic.s_VertexHelper);
			}
			ListPool<Component>.Release(list);
			Graphic.s_VertexHelper.FillMesh(Graphic.workerMesh);
			this.canvasRenderer.SetMesh(Graphic.workerMesh);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000B7E8 File Offset: 0x00009BE8
		private void DoLegacyMeshGeneration()
		{
			if (this.rectTransform != null && this.rectTransform.rect.width >= 0f && this.rectTransform.rect.height >= 0f)
			{
				this.OnPopulateMesh(Graphic.workerMesh);
			}
			else
			{
				Graphic.workerMesh.Clear();
			}
			List<Component> list = ListPool<Component>.Get();
			base.GetComponents(typeof(IMeshModifier), list);
			for (int i = 0; i < list.Count; i++)
			{
				((IMeshModifier)list[i]).ModifyMesh(Graphic.workerMesh);
			}
			ListPool<Component>.Release(list);
			this.canvasRenderer.SetMesh(Graphic.workerMesh);
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000248 RID: 584 RVA: 0x0000B8BC File Offset: 0x00009CBC
		protected static Mesh workerMesh
		{
			get
			{
				if (Graphic.s_Mesh == null)
				{
					Graphic.s_Mesh = new Mesh();
					Graphic.s_Mesh.name = "Shared UI Mesh";
					Graphic.s_Mesh.hideFlags = HideFlags.HideAndDontSave;
				}
				return Graphic.s_Mesh;
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000B90D File Offset: 0x00009D0D
		[Obsolete("Use OnPopulateMesh instead.", true)]
		protected virtual void OnFillVBO(List<UIVertex> vbo)
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000B910 File Offset: 0x00009D10
		[Obsolete("Use OnPopulateMesh(VertexHelper vh) instead.", false)]
		protected virtual void OnPopulateMesh(Mesh m)
		{
			this.OnPopulateMesh(Graphic.s_VertexHelper);
			Graphic.s_VertexHelper.FillMesh(m);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000B92C File Offset: 0x00009D2C
		protected virtual void OnPopulateMesh(VertexHelper vh)
		{
			Rect pixelAdjustedRect = this.GetPixelAdjustedRect();
			Vector4 vector = new Vector4(pixelAdjustedRect.x, pixelAdjustedRect.y, pixelAdjustedRect.x + pixelAdjustedRect.width, pixelAdjustedRect.y + pixelAdjustedRect.height);
			Color32 color = this.color;
			vh.Clear();
			vh.AddVert(new Vector3(vector.x, vector.y), color, new Vector2(0f, 0f));
			vh.AddVert(new Vector3(vector.x, vector.w), color, new Vector2(0f, 1f));
			vh.AddVert(new Vector3(vector.z, vector.w), color, new Vector2(1f, 1f));
			vh.AddVert(new Vector3(vector.z, vector.y), color, new Vector2(1f, 0f));
			vh.AddTriangle(0, 1, 2);
			vh.AddTriangle(2, 3, 0);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000BA3C File Offset: 0x00009E3C
		protected override void OnDidApplyAnimationProperties()
		{
			this.SetAllDirty();
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000BA45 File Offset: 0x00009E45
		public virtual void SetNativeSize()
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000BA48 File Offset: 0x00009E48
		public virtual bool Raycast(Vector2 sp, Camera eventCamera)
		{
			bool result;
			if (!base.isActiveAndEnabled)
			{
				result = false;
			}
			else
			{
				Transform transform = base.transform;
				List<Component> list = ListPool<Component>.Get();
				bool flag = false;
				bool flag2 = true;
				while (transform != null)
				{
					transform.GetComponents<Component>(list);
					for (int i = 0; i < list.Count; i++)
					{
						Canvas canvas = list[i] as Canvas;
						if (canvas != null && canvas.overrideSorting)
						{
							flag2 = false;
						}
						ICanvasRaycastFilter canvasRaycastFilter = list[i] as ICanvasRaycastFilter;
						if (canvasRaycastFilter != null)
						{
							bool flag3 = true;
							CanvasGroup canvasGroup = list[i] as CanvasGroup;
							if (canvasGroup != null)
							{
								if (!flag && canvasGroup.ignoreParentGroups)
								{
									flag = true;
									flag3 = canvasRaycastFilter.IsRaycastLocationValid(sp, eventCamera);
								}
								else if (!flag)
								{
									flag3 = canvasRaycastFilter.IsRaycastLocationValid(sp, eventCamera);
								}
							}
							else
							{
								flag3 = canvasRaycastFilter.IsRaycastLocationValid(sp, eventCamera);
							}
							if (!flag3)
							{
								ListPool<Component>.Release(list);
								return false;
							}
						}
					}
					transform = ((!flag2) ? null : transform.parent);
				}
				ListPool<Component>.Release(list);
				result = true;
			}
			return result;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000BB98 File Offset: 0x00009F98
		public Vector2 PixelAdjustPoint(Vector2 point)
		{
			Vector2 result;
			if (!this.canvas || this.canvas.renderMode == RenderMode.WorldSpace || this.canvas.scaleFactor == 0f || !this.canvas.pixelPerfect)
			{
				result = point;
			}
			else
			{
				result = RectTransformUtility.PixelAdjustPoint(point, base.transform, this.canvas);
			}
			return result;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000BC10 File Offset: 0x0000A010
		public Rect GetPixelAdjustedRect()
		{
			Rect result;
			if (!this.canvas || this.canvas.renderMode == RenderMode.WorldSpace || this.canvas.scaleFactor == 0f || !this.canvas.pixelPerfect)
			{
				result = this.rectTransform.rect;
			}
			else
			{
				result = RectTransformUtility.PixelAdjustRect(this.rectTransform, this.canvas);
			}
			return result;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000BC8D File Offset: 0x0000A08D
		public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
			this.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha, true);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000BC9C File Offset: 0x0000A09C
		public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB)
		{
			if (!(this.canvasRenderer == null) && (useRGB || useAlpha))
			{
				if (this.canvasRenderer.GetColor().Equals(targetColor))
				{
					this.m_ColorTweenRunner.StopTween();
				}
				else
				{
					ColorTween.ColorTweenMode tweenMode = (!useRGB || !useAlpha) ? ((!useRGB) ? ColorTween.ColorTweenMode.Alpha : ColorTween.ColorTweenMode.RGB) : ColorTween.ColorTweenMode.All;
					ColorTween info = new ColorTween
					{
						duration = duration,
						startColor = this.canvasRenderer.GetColor(),
						targetColor = targetColor
					};
					info.AddOnChangedCallback(new UnityAction<Color>(this.canvasRenderer.SetColor));
					info.ignoreTimeScale = ignoreTimeScale;
					info.tweenMode = tweenMode;
					this.m_ColorTweenRunner.StartTween(info);
				}
			}
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000BD88 File Offset: 0x0000A188
		private static Color CreateColorFromAlpha(float alpha)
		{
			Color black = Color.black;
			black.a = alpha;
			return black;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000BDAC File Offset: 0x0000A1AC
		public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
			this.CrossFadeColor(Graphic.CreateColorFromAlpha(alpha), duration, ignoreTimeScale, true, false);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000BDBF File Offset: 0x0000A1BF
		public void RegisterDirtyLayoutCallback(UnityAction action)
		{
			this.m_OnDirtyLayoutCallback = (UnityAction)Delegate.Combine(this.m_OnDirtyLayoutCallback, action);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000BDD9 File Offset: 0x0000A1D9
		public void UnregisterDirtyLayoutCallback(UnityAction action)
		{
			this.m_OnDirtyLayoutCallback = (UnityAction)Delegate.Remove(this.m_OnDirtyLayoutCallback, action);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000BDF3 File Offset: 0x0000A1F3
		public void RegisterDirtyVerticesCallback(UnityAction action)
		{
			this.m_OnDirtyVertsCallback = (UnityAction)Delegate.Combine(this.m_OnDirtyVertsCallback, action);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000BE0D File Offset: 0x0000A20D
		public void UnregisterDirtyVerticesCallback(UnityAction action)
		{
			this.m_OnDirtyVertsCallback = (UnityAction)Delegate.Remove(this.m_OnDirtyVertsCallback, action);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000BE27 File Offset: 0x0000A227
		public void RegisterDirtyMaterialCallback(UnityAction action)
		{
			this.m_OnDirtyMaterialCallback = (UnityAction)Delegate.Combine(this.m_OnDirtyMaterialCallback, action);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000BE41 File Offset: 0x0000A241
		public void UnregisterDirtyMaterialCallback(UnityAction action)
		{
			this.m_OnDirtyMaterialCallback = (UnityAction)Delegate.Remove(this.m_OnDirtyMaterialCallback, action);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000BE73 File Offset: 0x0000A273
		Transform ICanvasElement.get_transform()
		{
			return base.transform;
		}

		// Token: 0x04000107 RID: 263
		protected static Material s_DefaultUI = null;

		// Token: 0x04000108 RID: 264
		protected static Texture2D s_WhiteTexture = null;

		// Token: 0x04000109 RID: 265
		[FormerlySerializedAs("m_Mat")]
		[SerializeField]
		protected Material m_Material;

		// Token: 0x0400010A RID: 266
		[SerializeField]
		private Color m_Color = Color.white;

		// Token: 0x0400010B RID: 267
		[SerializeField]
		private bool m_RaycastTarget = true;

		// Token: 0x0400010C RID: 268
		[NonSerialized]
		private RectTransform m_RectTransform;

		// Token: 0x0400010D RID: 269
		[NonSerialized]
		private CanvasRenderer m_CanvasRender;

		// Token: 0x0400010E RID: 270
		[NonSerialized]
		private Canvas m_Canvas;

		// Token: 0x0400010F RID: 271
		[NonSerialized]
		private bool m_VertsDirty;

		// Token: 0x04000110 RID: 272
		[NonSerialized]
		private bool m_MaterialDirty;

		// Token: 0x04000111 RID: 273
		[NonSerialized]
		protected UnityAction m_OnDirtyLayoutCallback;

		// Token: 0x04000112 RID: 274
		[NonSerialized]
		protected UnityAction m_OnDirtyVertsCallback;

		// Token: 0x04000113 RID: 275
		[NonSerialized]
		protected UnityAction m_OnDirtyMaterialCallback;

		// Token: 0x04000114 RID: 276
		[NonSerialized]
		protected static Mesh s_Mesh;

		// Token: 0x04000115 RID: 277
		[NonSerialized]
		private static readonly VertexHelper s_VertexHelper = new VertexHelper();

		// Token: 0x04000116 RID: 278
		[NonSerialized]
		private readonly TweenRunner<ColorTween> m_ColorTweenRunner;
	}
}
