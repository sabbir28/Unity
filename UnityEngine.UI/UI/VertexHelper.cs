using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x020000A8 RID: 168
	public class VertexHelper : IDisposable
	{
		// Token: 0x06000601 RID: 1537 RVA: 0x0001DAE8 File Offset: 0x0001BEE8
		public VertexHelper()
		{
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0001DB60 File Offset: 0x0001BF60
		public VertexHelper(Mesh m)
		{
			this.m_Positions.AddRange(m.vertices);
			this.m_Colors.AddRange(m.colors32);
			this.m_Uv0S.AddRange(m.uv);
			this.m_Uv1S.AddRange(m.uv2);
			this.m_Uv2S.AddRange(m.uv3);
			this.m_Uv3S.AddRange(m.uv4);
			this.m_Normals.AddRange(m.normals);
			this.m_Tangents.AddRange(m.tangents);
			this.m_Indices.AddRange(m.GetIndices(0));
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0001DC74 File Offset: 0x0001C074
		public void Clear()
		{
			this.m_Positions.Clear();
			this.m_Colors.Clear();
			this.m_Uv0S.Clear();
			this.m_Uv1S.Clear();
			this.m_Uv2S.Clear();
			this.m_Uv3S.Clear();
			this.m_Normals.Clear();
			this.m_Tangents.Clear();
			this.m_Indices.Clear();
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x0001DCE8 File Offset: 0x0001C0E8
		public int currentVertCount
		{
			get
			{
				return this.m_Positions.Count;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x0001DD08 File Offset: 0x0001C108
		public int currentIndexCount
		{
			get
			{
				return this.m_Indices.Count;
			}
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0001DD28 File Offset: 0x0001C128
		public void PopulateUIVertex(ref UIVertex vertex, int i)
		{
			vertex.position = this.m_Positions[i];
			vertex.color = this.m_Colors[i];
			vertex.uv0 = this.m_Uv0S[i];
			vertex.uv1 = this.m_Uv1S[i];
			vertex.uv2 = this.m_Uv2S[i];
			vertex.uv3 = this.m_Uv3S[i];
			vertex.normal = this.m_Normals[i];
			vertex.tangent = this.m_Tangents[i];
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x0001DDC8 File Offset: 0x0001C1C8
		public void SetUIVertex(UIVertex vertex, int i)
		{
			this.m_Positions[i] = vertex.position;
			this.m_Colors[i] = vertex.color;
			this.m_Uv0S[i] = vertex.uv0;
			this.m_Uv1S[i] = vertex.uv1;
			this.m_Uv2S[i] = vertex.uv2;
			this.m_Uv3S[i] = vertex.uv3;
			this.m_Normals[i] = vertex.normal;
			this.m_Tangents[i] = vertex.tangent;
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0001DE70 File Offset: 0x0001C270
		public void FillMesh(Mesh mesh)
		{
			mesh.Clear();
			if (this.m_Positions.Count >= 65000)
			{
				throw new ArgumentException("Mesh can not have more than 65000 vertices");
			}
			mesh.SetVertices(this.m_Positions);
			mesh.SetColors(this.m_Colors);
			mesh.SetUVs(0, this.m_Uv0S);
			mesh.SetUVs(1, this.m_Uv1S);
			mesh.SetUVs(2, this.m_Uv2S);
			mesh.SetUVs(3, this.m_Uv3S);
			mesh.SetNormals(this.m_Normals);
			mesh.SetTangents(this.m_Tangents);
			mesh.SetTriangles(this.m_Indices, 0);
			mesh.RecalculateBounds();
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0001DF1C File Offset: 0x0001C31C
		public void Dispose()
		{
			ListPool<Vector3>.Release(this.m_Positions);
			ListPool<Color32>.Release(this.m_Colors);
			ListPool<Vector2>.Release(this.m_Uv0S);
			ListPool<Vector2>.Release(this.m_Uv1S);
			ListPool<Vector2>.Release(this.m_Uv2S);
			ListPool<Vector2>.Release(this.m_Uv3S);
			ListPool<Vector3>.Release(this.m_Normals);
			ListPool<Vector4>.Release(this.m_Tangents);
			ListPool<int>.Release(this.m_Indices);
			this.m_Positions = null;
			this.m_Colors = null;
			this.m_Uv0S = null;
			this.m_Uv1S = null;
			this.m_Uv2S = null;
			this.m_Uv3S = null;
			this.m_Normals = null;
			this.m_Tangents = null;
			this.m_Indices = null;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0001DFCC File Offset: 0x0001C3CC
		public void AddVert(Vector3 position, Color32 color, Vector2 uv0, Vector2 uv1, Vector3 normal, Vector4 tangent)
		{
			this.m_Positions.Add(position);
			this.m_Colors.Add(color);
			this.m_Uv0S.Add(uv0);
			this.m_Uv1S.Add(uv1);
			this.m_Uv2S.Add(Vector2.zero);
			this.m_Uv3S.Add(Vector2.zero);
			this.m_Normals.Add(normal);
			this.m_Tangents.Add(tangent);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0001E045 File Offset: 0x0001C445
		public void AddVert(Vector3 position, Color32 color, Vector2 uv0)
		{
			this.AddVert(position, color, uv0, Vector2.zero, VertexHelper.s_DefaultNormal, VertexHelper.s_DefaultTangent);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0001E060 File Offset: 0x0001C460
		public void AddVert(UIVertex v)
		{
			this.AddVert(v.position, v.color, v.uv0, v.uv1, v.normal, v.tangent);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0001E093 File Offset: 0x0001C493
		public void AddTriangle(int idx0, int idx1, int idx2)
		{
			this.m_Indices.Add(idx0);
			this.m_Indices.Add(idx1);
			this.m_Indices.Add(idx2);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0001E0BC File Offset: 0x0001C4BC
		public void AddUIVertexQuad(UIVertex[] verts)
		{
			int currentVertCount = this.currentVertCount;
			for (int i = 0; i < 4; i++)
			{
				this.AddVert(verts[i].position, verts[i].color, verts[i].uv0, verts[i].uv1, verts[i].normal, verts[i].tangent);
			}
			this.AddTriangle(currentVertCount, currentVertCount + 1, currentVertCount + 2);
			this.AddTriangle(currentVertCount + 2, currentVertCount + 3, currentVertCount);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0001E14C File Offset: 0x0001C54C
		public void AddUIVertexStream(List<UIVertex> verts, List<int> indices)
		{
			if (verts != null)
			{
				CanvasRenderer.AddUIVertexStream(verts, this.m_Positions, this.m_Colors, this.m_Uv0S, this.m_Uv1S, this.m_Normals, this.m_Tangents);
			}
			if (indices != null)
			{
				this.m_Indices.AddRange(indices);
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0001E1A0 File Offset: 0x0001C5A0
		public void AddUIVertexTriangleStream(List<UIVertex> verts)
		{
			if (verts != null)
			{
				CanvasRenderer.SplitUIVertexStreams(verts, this.m_Positions, this.m_Colors, this.m_Uv0S, this.m_Uv1S, this.m_Normals, this.m_Tangents, this.m_Indices);
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0001E1DE File Offset: 0x0001C5DE
		public void GetUIVertexStream(List<UIVertex> stream)
		{
			if (stream != null)
			{
				CanvasRenderer.CreateUIVertexStream(stream, this.m_Positions, this.m_Colors, this.m_Uv0S, this.m_Uv1S, this.m_Normals, this.m_Tangents, this.m_Indices);
			}
		}

		// Token: 0x040002CA RID: 714
		private List<Vector3> m_Positions = ListPool<Vector3>.Get();

		// Token: 0x040002CB RID: 715
		private List<Color32> m_Colors = ListPool<Color32>.Get();

		// Token: 0x040002CC RID: 716
		private List<Vector2> m_Uv0S = ListPool<Vector2>.Get();

		// Token: 0x040002CD RID: 717
		private List<Vector2> m_Uv1S = ListPool<Vector2>.Get();

		// Token: 0x040002CE RID: 718
		private List<Vector2> m_Uv2S = ListPool<Vector2>.Get();

		// Token: 0x040002CF RID: 719
		private List<Vector2> m_Uv3S = ListPool<Vector2>.Get();

		// Token: 0x040002D0 RID: 720
		private List<Vector3> m_Normals = ListPool<Vector3>.Get();

		// Token: 0x040002D1 RID: 721
		private List<Vector4> m_Tangents = ListPool<Vector4>.Get();

		// Token: 0x040002D2 RID: 722
		private List<int> m_Indices = ListPool<int>.Get();

		// Token: 0x040002D3 RID: 723
		private static readonly Vector4 s_DefaultTangent = new Vector4(1f, 0f, 0f, -1f);

		// Token: 0x040002D4 RID: 724
		private static readonly Vector3 s_DefaultNormal = Vector3.back;
	}
}
