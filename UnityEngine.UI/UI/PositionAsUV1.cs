using System;

namespace UnityEngine.UI
{
	// Token: 0x020000AE RID: 174
	[AddComponentMenu("UI/Effects/Position As UV1", 16)]
	public class PositionAsUV1 : BaseMeshEffect
	{
		// Token: 0x06000621 RID: 1569 RVA: 0x0001E7B2 File Offset: 0x0001CBB2
		protected PositionAsUV1()
		{
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0001E7BC File Offset: 0x0001CBBC
		public override void ModifyMesh(VertexHelper vh)
		{
			UIVertex vertex = default(UIVertex);
			for (int i = 0; i < vh.currentVertCount; i++)
			{
				vh.PopulateUIVertex(ref vertex, i);
				vertex.uv1 = new Vector2(vertex.position.x, vertex.position.y);
				vh.SetUIVertex(vertex, i);
			}
		}
	}
}
