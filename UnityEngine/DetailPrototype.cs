using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000223 RID: 547
	[UsedByNativeCode]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class DetailPrototype
	{
		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x060024C0 RID: 9408 RVA: 0x0002A2F4 File Offset: 0x000284F4
		// (set) Token: 0x060024C1 RID: 9409 RVA: 0x0002A310 File Offset: 0x00028510
		public GameObject prototype
		{
			get
			{
				return this.m_Prototype;
			}
			set
			{
				this.m_Prototype = value;
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x060024C2 RID: 9410 RVA: 0x0002A31C File Offset: 0x0002851C
		// (set) Token: 0x060024C3 RID: 9411 RVA: 0x0002A338 File Offset: 0x00028538
		public Texture2D prototypeTexture
		{
			get
			{
				return this.m_PrototypeTexture;
			}
			set
			{
				this.m_PrototypeTexture = value;
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x060024C4 RID: 9412 RVA: 0x0002A344 File Offset: 0x00028544
		// (set) Token: 0x060024C5 RID: 9413 RVA: 0x0002A360 File Offset: 0x00028560
		public float minWidth
		{
			get
			{
				return this.m_MinWidth;
			}
			set
			{
				this.m_MinWidth = value;
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x060024C6 RID: 9414 RVA: 0x0002A36C File Offset: 0x0002856C
		// (set) Token: 0x060024C7 RID: 9415 RVA: 0x0002A388 File Offset: 0x00028588
		public float maxWidth
		{
			get
			{
				return this.m_MaxWidth;
			}
			set
			{
				this.m_MaxWidth = value;
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x060024C8 RID: 9416 RVA: 0x0002A394 File Offset: 0x00028594
		// (set) Token: 0x060024C9 RID: 9417 RVA: 0x0002A3B0 File Offset: 0x000285B0
		public float minHeight
		{
			get
			{
				return this.m_MinHeight;
			}
			set
			{
				this.m_MinHeight = value;
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x060024CA RID: 9418 RVA: 0x0002A3BC File Offset: 0x000285BC
		// (set) Token: 0x060024CB RID: 9419 RVA: 0x0002A3D8 File Offset: 0x000285D8
		public float maxHeight
		{
			get
			{
				return this.m_MaxHeight;
			}
			set
			{
				this.m_MaxHeight = value;
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x060024CC RID: 9420 RVA: 0x0002A3E4 File Offset: 0x000285E4
		// (set) Token: 0x060024CD RID: 9421 RVA: 0x0002A400 File Offset: 0x00028600
		public float noiseSpread
		{
			get
			{
				return this.m_NoiseSpread;
			}
			set
			{
				this.m_NoiseSpread = value;
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x060024CE RID: 9422 RVA: 0x0002A40C File Offset: 0x0002860C
		// (set) Token: 0x060024CF RID: 9423 RVA: 0x0002A428 File Offset: 0x00028628
		public float bendFactor
		{
			get
			{
				return this.m_BendFactor;
			}
			set
			{
				this.m_BendFactor = value;
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x060024D0 RID: 9424 RVA: 0x0002A434 File Offset: 0x00028634
		// (set) Token: 0x060024D1 RID: 9425 RVA: 0x0002A450 File Offset: 0x00028650
		public Color healthyColor
		{
			get
			{
				return this.m_HealthyColor;
			}
			set
			{
				this.m_HealthyColor = value;
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x060024D2 RID: 9426 RVA: 0x0002A45C File Offset: 0x0002865C
		// (set) Token: 0x060024D3 RID: 9427 RVA: 0x0002A478 File Offset: 0x00028678
		public Color dryColor
		{
			get
			{
				return this.m_DryColor;
			}
			set
			{
				this.m_DryColor = value;
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x060024D4 RID: 9428 RVA: 0x0002A484 File Offset: 0x00028684
		// (set) Token: 0x060024D5 RID: 9429 RVA: 0x0002A4A0 File Offset: 0x000286A0
		public DetailRenderMode renderMode
		{
			get
			{
				return (DetailRenderMode)this.m_RenderMode;
			}
			set
			{
				this.m_RenderMode = (int)value;
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x060024D6 RID: 9430 RVA: 0x0002A4AC File Offset: 0x000286AC
		// (set) Token: 0x060024D7 RID: 9431 RVA: 0x0002A4D0 File Offset: 0x000286D0
		public bool usePrototypeMesh
		{
			get
			{
				return this.m_UsePrototypeMesh != 0;
			}
			set
			{
				this.m_UsePrototypeMesh = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x0400063A RID: 1594
		private GameObject m_Prototype = null;

		// Token: 0x0400063B RID: 1595
		private Texture2D m_PrototypeTexture = null;

		// Token: 0x0400063C RID: 1596
		private Color m_HealthyColor = new Color(0.2627451f, 0.9764706f, 0.16470589f, 1f);

		// Token: 0x0400063D RID: 1597
		private Color m_DryColor = new Color(0.8039216f, 0.7372549f, 0.101960786f, 1f);

		// Token: 0x0400063E RID: 1598
		private float m_MinWidth = 1f;

		// Token: 0x0400063F RID: 1599
		private float m_MaxWidth = 2f;

		// Token: 0x04000640 RID: 1600
		private float m_MinHeight = 1f;

		// Token: 0x04000641 RID: 1601
		private float m_MaxHeight = 2f;

		// Token: 0x04000642 RID: 1602
		private float m_NoiseSpread = 0.1f;

		// Token: 0x04000643 RID: 1603
		private float m_BendFactor = 0.1f;

		// Token: 0x04000644 RID: 1604
		private int m_RenderMode = 2;

		// Token: 0x04000645 RID: 1605
		private int m_UsePrototypeMesh = 0;
	}
}
