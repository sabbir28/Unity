using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000089 RID: 137
	[RequireComponent(typeof(Canvas))]
	[ExecuteInEditMode]
	[AddComponentMenu("Layout/Canvas Scaler", 101)]
	public class CanvasScaler : UIBehaviour
	{
		// Token: 0x06000505 RID: 1285 RVA: 0x0001A9D4 File Offset: 0x00018DD4
		protected CanvasScaler()
		{
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x0001AA6C File Offset: 0x00018E6C
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x0001AA87 File Offset: 0x00018E87
		public CanvasScaler.ScaleMode uiScaleMode
		{
			get
			{
				return this.m_UiScaleMode;
			}
			set
			{
				this.m_UiScaleMode = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x0001AA94 File Offset: 0x00018E94
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x0001AAAF File Offset: 0x00018EAF
		public float referencePixelsPerUnit
		{
			get
			{
				return this.m_ReferencePixelsPerUnit;
			}
			set
			{
				this.m_ReferencePixelsPerUnit = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x0001AABC File Offset: 0x00018EBC
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x0001AAD7 File Offset: 0x00018ED7
		public float scaleFactor
		{
			get
			{
				return this.m_ScaleFactor;
			}
			set
			{
				this.m_ScaleFactor = Mathf.Max(0.01f, value);
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x0001AAEC File Offset: 0x00018EEC
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x0001AB08 File Offset: 0x00018F08
		public Vector2 referenceResolution
		{
			get
			{
				return this.m_ReferenceResolution;
			}
			set
			{
				this.m_ReferenceResolution = value;
				if (this.m_ReferenceResolution.x > -1E-05f && this.m_ReferenceResolution.x < 1E-05f)
				{
					this.m_ReferenceResolution.x = 1E-05f * Mathf.Sign(this.m_ReferenceResolution.x);
				}
				if (this.m_ReferenceResolution.y > -1E-05f && this.m_ReferenceResolution.y < 1E-05f)
				{
					this.m_ReferenceResolution.y = 1E-05f * Mathf.Sign(this.m_ReferenceResolution.y);
				}
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x0001ABB4 File Offset: 0x00018FB4
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x0001ABCF File Offset: 0x00018FCF
		public CanvasScaler.ScreenMatchMode screenMatchMode
		{
			get
			{
				return this.m_ScreenMatchMode;
			}
			set
			{
				this.m_ScreenMatchMode = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x0001ABDC File Offset: 0x00018FDC
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x0001ABF7 File Offset: 0x00018FF7
		public float matchWidthOrHeight
		{
			get
			{
				return this.m_MatchWidthOrHeight;
			}
			set
			{
				this.m_MatchWidthOrHeight = value;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x0001AC04 File Offset: 0x00019004
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x0001AC1F File Offset: 0x0001901F
		public CanvasScaler.Unit physicalUnit
		{
			get
			{
				return this.m_PhysicalUnit;
			}
			set
			{
				this.m_PhysicalUnit = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x0001AC2C File Offset: 0x0001902C
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x0001AC47 File Offset: 0x00019047
		public float fallbackScreenDPI
		{
			get
			{
				return this.m_FallbackScreenDPI;
			}
			set
			{
				this.m_FallbackScreenDPI = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x0001AC54 File Offset: 0x00019054
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x0001AC6F File Offset: 0x0001906F
		public float defaultSpriteDPI
		{
			get
			{
				return this.m_DefaultSpriteDPI;
			}
			set
			{
				this.m_DefaultSpriteDPI = Mathf.Max(1f, value);
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x0001AC84 File Offset: 0x00019084
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x0001AC9F File Offset: 0x0001909F
		public float dynamicPixelsPerUnit
		{
			get
			{
				return this.m_DynamicPixelsPerUnit;
			}
			set
			{
				this.m_DynamicPixelsPerUnit = value;
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0001ACA9 File Offset: 0x000190A9
		protected override void OnEnable()
		{
			base.OnEnable();
			this.m_Canvas = base.GetComponent<Canvas>();
			this.Handle();
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0001ACC4 File Offset: 0x000190C4
		protected override void OnDisable()
		{
			this.SetScaleFactor(1f);
			this.SetReferencePixelsPerUnit(100f);
			base.OnDisable();
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0001ACE3 File Offset: 0x000190E3
		protected virtual void Update()
		{
			this.Handle();
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0001ACEC File Offset: 0x000190EC
		protected virtual void Handle()
		{
			if (!(this.m_Canvas == null) && this.m_Canvas.isRootCanvas)
			{
				if (this.m_Canvas.renderMode == RenderMode.WorldSpace)
				{
					this.HandleWorldCanvas();
				}
				else
				{
					CanvasScaler.ScaleMode uiScaleMode = this.m_UiScaleMode;
					if (uiScaleMode != CanvasScaler.ScaleMode.ConstantPixelSize)
					{
						if (uiScaleMode != CanvasScaler.ScaleMode.ScaleWithScreenSize)
						{
							if (uiScaleMode == CanvasScaler.ScaleMode.ConstantPhysicalSize)
							{
								this.HandleConstantPhysicalSize();
							}
						}
						else
						{
							this.HandleScaleWithScreenSize();
						}
					}
					else
					{
						this.HandleConstantPixelSize();
					}
				}
			}
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0001AD7E File Offset: 0x0001917E
		protected virtual void HandleWorldCanvas()
		{
			this.SetScaleFactor(this.m_DynamicPixelsPerUnit);
			this.SetReferencePixelsPerUnit(this.m_ReferencePixelsPerUnit);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0001AD99 File Offset: 0x00019199
		protected virtual void HandleConstantPixelSize()
		{
			this.SetScaleFactor(this.m_ScaleFactor);
			this.SetReferencePixelsPerUnit(this.m_ReferencePixelsPerUnit);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0001ADB4 File Offset: 0x000191B4
		protected virtual void HandleScaleWithScreenSize()
		{
			Vector2 vector = new Vector2((float)Screen.width, (float)Screen.height);
			int targetDisplay = this.m_Canvas.targetDisplay;
			if (targetDisplay > 0 && targetDisplay < Display.displays.Length)
			{
				Display display = Display.displays[targetDisplay];
				vector = new Vector2((float)display.renderingWidth, (float)display.renderingHeight);
			}
			float scaleFactor = 0f;
			CanvasScaler.ScreenMatchMode screenMatchMode = this.m_ScreenMatchMode;
			if (screenMatchMode != CanvasScaler.ScreenMatchMode.MatchWidthOrHeight)
			{
				if (screenMatchMode != CanvasScaler.ScreenMatchMode.Expand)
				{
					if (screenMatchMode == CanvasScaler.ScreenMatchMode.Shrink)
					{
						scaleFactor = Mathf.Max(vector.x / this.m_ReferenceResolution.x, vector.y / this.m_ReferenceResolution.y);
					}
				}
				else
				{
					scaleFactor = Mathf.Min(vector.x / this.m_ReferenceResolution.x, vector.y / this.m_ReferenceResolution.y);
				}
			}
			else
			{
				float a = Mathf.Log(vector.x / this.m_ReferenceResolution.x, 2f);
				float b = Mathf.Log(vector.y / this.m_ReferenceResolution.y, 2f);
				float p = Mathf.Lerp(a, b, this.m_MatchWidthOrHeight);
				scaleFactor = Mathf.Pow(2f, p);
			}
			this.SetScaleFactor(scaleFactor);
			this.SetReferencePixelsPerUnit(this.m_ReferencePixelsPerUnit);
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0001AF18 File Offset: 0x00019318
		protected virtual void HandleConstantPhysicalSize()
		{
			float dpi = Screen.dpi;
			float num = (dpi != 0f) ? dpi : this.m_FallbackScreenDPI;
			float num2 = 1f;
			switch (this.m_PhysicalUnit)
			{
			case CanvasScaler.Unit.Centimeters:
				num2 = 2.54f;
				break;
			case CanvasScaler.Unit.Millimeters:
				num2 = 25.4f;
				break;
			case CanvasScaler.Unit.Inches:
				num2 = 1f;
				break;
			case CanvasScaler.Unit.Points:
				num2 = 72f;
				break;
			case CanvasScaler.Unit.Picas:
				num2 = 6f;
				break;
			}
			this.SetScaleFactor(num / num2);
			this.SetReferencePixelsPerUnit(this.m_ReferencePixelsPerUnit * num2 / this.m_DefaultSpriteDPI);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0001AFC5 File Offset: 0x000193C5
		protected void SetScaleFactor(float scaleFactor)
		{
			if (scaleFactor != this.m_PrevScaleFactor)
			{
				this.m_Canvas.scaleFactor = scaleFactor;
				this.m_PrevScaleFactor = scaleFactor;
			}
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0001AFEC File Offset: 0x000193EC
		protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit)
		{
			if (referencePixelsPerUnit != this.m_PrevReferencePixelsPerUnit)
			{
				this.m_Canvas.referencePixelsPerUnit = referencePixelsPerUnit;
				this.m_PrevReferencePixelsPerUnit = referencePixelsPerUnit;
			}
		}

		// Token: 0x04000263 RID: 611
		[Tooltip("Determines how UI elements in the Canvas are scaled.")]
		[SerializeField]
		private CanvasScaler.ScaleMode m_UiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;

		// Token: 0x04000264 RID: 612
		[Tooltip("If a sprite has this 'Pixels Per Unit' setting, then one pixel in the sprite will cover one unit in the UI.")]
		[SerializeField]
		protected float m_ReferencePixelsPerUnit = 100f;

		// Token: 0x04000265 RID: 613
		[Tooltip("Scales all UI elements in the Canvas by this factor.")]
		[SerializeField]
		protected float m_ScaleFactor = 1f;

		// Token: 0x04000266 RID: 614
		[Tooltip("The resolution the UI layout is designed for. If the screen resolution is larger, the UI will be scaled up, and if it's smaller, the UI will be scaled down. This is done in accordance with the Screen Match Mode.")]
		[SerializeField]
		protected Vector2 m_ReferenceResolution = new Vector2(800f, 600f);

		// Token: 0x04000267 RID: 615
		[Tooltip("A mode used to scale the canvas area if the aspect ratio of the current resolution doesn't fit the reference resolution.")]
		[SerializeField]
		protected CanvasScaler.ScreenMatchMode m_ScreenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;

		// Token: 0x04000268 RID: 616
		[Tooltip("Determines if the scaling is using the width or height as reference, or a mix in between.")]
		[Range(0f, 1f)]
		[SerializeField]
		protected float m_MatchWidthOrHeight = 0f;

		// Token: 0x04000269 RID: 617
		private const float kLogBase = 2f;

		// Token: 0x0400026A RID: 618
		[Tooltip("The physical unit to specify positions and sizes in.")]
		[SerializeField]
		protected CanvasScaler.Unit m_PhysicalUnit = CanvasScaler.Unit.Points;

		// Token: 0x0400026B RID: 619
		[Tooltip("The DPI to assume if the screen DPI is not known.")]
		[SerializeField]
		protected float m_FallbackScreenDPI = 96f;

		// Token: 0x0400026C RID: 620
		[Tooltip("The pixels per inch to use for sprites that have a 'Pixels Per Unit' setting that matches the 'Reference Pixels Per Unit' setting.")]
		[SerializeField]
		protected float m_DefaultSpriteDPI = 96f;

		// Token: 0x0400026D RID: 621
		[Tooltip("The amount of pixels per unit to use for dynamically created bitmaps in the UI, such as Text.")]
		[SerializeField]
		protected float m_DynamicPixelsPerUnit = 1f;

		// Token: 0x0400026E RID: 622
		private Canvas m_Canvas;

		// Token: 0x0400026F RID: 623
		[NonSerialized]
		private float m_PrevScaleFactor = 1f;

		// Token: 0x04000270 RID: 624
		[NonSerialized]
		private float m_PrevReferencePixelsPerUnit = 100f;

		// Token: 0x0200008A RID: 138
		public enum ScaleMode
		{
			// Token: 0x04000272 RID: 626
			ConstantPixelSize,
			// Token: 0x04000273 RID: 627
			ScaleWithScreenSize,
			// Token: 0x04000274 RID: 628
			ConstantPhysicalSize
		}

		// Token: 0x0200008B RID: 139
		public enum ScreenMatchMode
		{
			// Token: 0x04000276 RID: 630
			MatchWidthOrHeight,
			// Token: 0x04000277 RID: 631
			Expand,
			// Token: 0x04000278 RID: 632
			Shrink
		}

		// Token: 0x0200008C RID: 140
		public enum Unit
		{
			// Token: 0x0400027A RID: 634
			Centimeters,
			// Token: 0x0400027B RID: 635
			Millimeters,
			// Token: 0x0400027C RID: 636
			Inches,
			// Token: 0x0400027D RID: 637
			Points,
			// Token: 0x0400027E RID: 638
			Picas
		}
	}
}
