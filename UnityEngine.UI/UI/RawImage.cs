using System;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000068 RID: 104
	[AddComponentMenu("UI/Raw Image", 12)]
	public class RawImage : MaskableGraphic
	{
		// Token: 0x06000380 RID: 896 RVA: 0x000147B1 File Offset: 0x00012BB1
		protected RawImage()
		{
			base.useLegacyMeshGeneration = false;
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000381 RID: 897 RVA: 0x000147E0 File Offset: 0x00012BE0
		public override Texture mainTexture
		{
			get
			{
				Texture result;
				if (this.m_Texture == null)
				{
					if (this.material != null && this.material.mainTexture != null)
					{
						result = this.material.mainTexture;
					}
					else
					{
						result = Graphic.s_WhiteTexture;
					}
				}
				else
				{
					result = this.m_Texture;
				}
				return result;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00014854 File Offset: 0x00012C54
		// (set) Token: 0x06000383 RID: 899 RVA: 0x0001486F File Offset: 0x00012C6F
		public Texture texture
		{
			get
			{
				return this.m_Texture;
			}
			set
			{
				if (!(this.m_Texture == value))
				{
					this.m_Texture = value;
					this.SetVerticesDirty();
					this.SetMaterialDirty();
				}
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0001489C File Offset: 0x00012C9C
		// (set) Token: 0x06000385 RID: 901 RVA: 0x000148B7 File Offset: 0x00012CB7
		public Rect uvRect
		{
			get
			{
				return this.m_UVRect;
			}
			set
			{
				if (!(this.m_UVRect == value))
				{
					this.m_UVRect = value;
					this.SetVerticesDirty();
				}
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x000148E0 File Offset: 0x00012CE0
		public override void SetNativeSize()
		{
			Texture mainTexture = this.mainTexture;
			if (mainTexture != null)
			{
				int num = Mathf.RoundToInt((float)mainTexture.width * this.uvRect.width);
				int num2 = Mathf.RoundToInt((float)mainTexture.height * this.uvRect.height);
				base.rectTransform.anchorMax = base.rectTransform.anchorMin;
				base.rectTransform.sizeDelta = new Vector2((float)num, (float)num2);
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00014968 File Offset: 0x00012D68
		protected override void OnPopulateMesh(VertexHelper vh)
		{
			Texture mainTexture = this.mainTexture;
			vh.Clear();
			if (mainTexture != null)
			{
				Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
				Vector4 vector = new Vector4(pixelAdjustedRect.x, pixelAdjustedRect.y, pixelAdjustedRect.x + pixelAdjustedRect.width, pixelAdjustedRect.y + pixelAdjustedRect.height);
				float num = (float)mainTexture.width * mainTexture.texelSize.x;
				float num2 = (float)mainTexture.height * mainTexture.texelSize.y;
				Color color = this.color;
				vh.AddVert(new Vector3(vector.x, vector.y), color, new Vector2(this.m_UVRect.xMin * num, this.m_UVRect.yMin * num2));
				vh.AddVert(new Vector3(vector.x, vector.w), color, new Vector2(this.m_UVRect.xMin * num, this.m_UVRect.yMax * num2));
				vh.AddVert(new Vector3(vector.z, vector.w), color, new Vector2(this.m_UVRect.xMax * num, this.m_UVRect.yMax * num2));
				vh.AddVert(new Vector3(vector.z, vector.y), color, new Vector2(this.m_UVRect.xMax * num, this.m_UVRect.yMin * num2));
				vh.AddTriangle(0, 1, 2);
				vh.AddTriangle(2, 3, 0);
			}
		}

		// Token: 0x040001BC RID: 444
		[FormerlySerializedAs("m_Tex")]
		[SerializeField]
		private Texture m_Texture;

		// Token: 0x040001BD RID: 445
		[SerializeField]
		private Rect m_UVRect = new Rect(0f, 0f, 1f, 1f);
	}
}
