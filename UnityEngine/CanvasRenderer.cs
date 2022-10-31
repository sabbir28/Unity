using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000245 RID: 581
	public sealed class CanvasRenderer : Component
	{
		// Token: 0x0600269B RID: 9883 RVA: 0x0002C6E8 File Offset: 0x0002A8E8
		public void SetColor(Color color)
		{
			CanvasRenderer.INTERNAL_CALL_SetColor(this, ref color);
		}

		// Token: 0x0600269C RID: 9884
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetColor(CanvasRenderer self, ref Color color);

		// Token: 0x0600269D RID: 9885 RVA: 0x0002C6F4 File Offset: 0x0002A8F4
		public Color GetColor()
		{
			Color result;
			CanvasRenderer.INTERNAL_CALL_GetColor(this, out result);
			return result;
		}

		// Token: 0x0600269E RID: 9886
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetColor(CanvasRenderer self, out Color value);

		// Token: 0x0600269F RID: 9887
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float GetAlpha();

		// Token: 0x060026A0 RID: 9888
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetAlpha(float alpha);

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x060026A1 RID: 9889
		// (set) Token: 0x060026A2 RID: 9890
		[Obsolete("isMask is no longer supported. See EnableClipping for vertex clipping configuration")]
		public extern bool isMask { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060026A3 RID: 9891 RVA: 0x0002C714 File Offset: 0x0002A914
		[Obsolete("UI System now uses meshes. Generate a mesh and use 'SetMesh' instead")]
		public void SetVertices(List<UIVertex> vertices)
		{
			this.SetVertices(vertices.ToArray(), vertices.Count);
		}

		// Token: 0x060026A4 RID: 9892 RVA: 0x0002C72C File Offset: 0x0002A92C
		[Obsolete("UI System now uses meshes. Generate a mesh and use 'SetMesh' instead")]
		public void SetVertices(UIVertex[] vertices, int size)
		{
			Mesh mesh = new Mesh();
			List<Vector3> list = new List<Vector3>();
			List<Color32> list2 = new List<Color32>();
			List<Vector2> list3 = new List<Vector2>();
			List<Vector2> list4 = new List<Vector2>();
			List<Vector3> list5 = new List<Vector3>();
			List<Vector4> list6 = new List<Vector4>();
			List<int> list7 = new List<int>();
			for (int i = 0; i < size; i += 4)
			{
				for (int j = 0; j < 4; j++)
				{
					list.Add(vertices[i + j].position);
					list2.Add(vertices[i + j].color);
					list3.Add(vertices[i + j].uv0);
					list4.Add(vertices[i + j].uv1);
					list5.Add(vertices[i + j].normal);
					list6.Add(vertices[i + j].tangent);
				}
				list7.Add(i);
				list7.Add(i + 1);
				list7.Add(i + 2);
				list7.Add(i + 2);
				list7.Add(i + 3);
				list7.Add(i);
			}
			mesh.SetVertices(list);
			mesh.SetColors(list2);
			mesh.SetNormals(list5);
			mesh.SetTangents(list6);
			mesh.SetUVs(0, list3);
			mesh.SetUVs(1, list4);
			mesh.SetIndices(list7.ToArray(), MeshTopology.Triangles, 0);
			this.SetMesh(mesh);
			Object.DestroyImmediate(mesh);
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x0002C8B0 File Offset: 0x0002AAB0
		public void EnableRectClipping(Rect rect)
		{
			CanvasRenderer.INTERNAL_CALL_EnableRectClipping(this, ref rect);
		}

		// Token: 0x060026A6 RID: 9894
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_EnableRectClipping(CanvasRenderer self, ref Rect rect);

		// Token: 0x060026A7 RID: 9895
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void DisableRectClipping();

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x060026A8 RID: 9896
		public extern bool hasRectClipping { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x060026A9 RID: 9897
		// (set) Token: 0x060026AA RID: 9898
		public extern bool hasPopInstruction { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x060026AB RID: 9899
		// (set) Token: 0x060026AC RID: 9900
		public extern int materialCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060026AD RID: 9901
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetMaterial(Material material, int index);

		// Token: 0x060026AE RID: 9902 RVA: 0x0002C8BC File Offset: 0x0002AABC
		public void SetMaterial(Material material, Texture texture)
		{
			this.materialCount = Math.Max(1, this.materialCount);
			this.SetMaterial(material, 0);
			this.SetTexture(texture);
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x0002C8E0 File Offset: 0x0002AAE0
		public Material GetMaterial()
		{
			return this.GetMaterial(0);
		}

		// Token: 0x060026B0 RID: 9904
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Material GetMaterial(int index);

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x060026B1 RID: 9905
		// (set) Token: 0x060026B2 RID: 9906
		public extern int popMaterialCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060026B3 RID: 9907
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetPopMaterial(Material material, int index);

		// Token: 0x060026B4 RID: 9908
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Material GetPopMaterial(int index);

		// Token: 0x060026B5 RID: 9909
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetTexture(Texture texture);

		// Token: 0x060026B6 RID: 9910
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetAlphaTexture(Texture texture);

		// Token: 0x060026B7 RID: 9911
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetMesh(Mesh mesh);

		// Token: 0x060026B8 RID: 9912
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Clear();

		// Token: 0x060026B9 RID: 9913 RVA: 0x0002C8FC File Offset: 0x0002AAFC
		public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector3> normals, List<Vector4> tangents, List<int> indicies)
		{
			CanvasRenderer.SplitUIVertexStreamsInternal(verts, positions, colors, uv0S, uv1S, normals, tangents);
			CanvasRenderer.SplitIndiciesStreamsInternal(verts, indicies);
		}

		// Token: 0x060026BA RID: 9914
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object normals, object tangents);

		// Token: 0x060026BB RID: 9915
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SplitIndiciesStreamsInternal(object verts, object indicies);

		// Token: 0x060026BC RID: 9916 RVA: 0x0002C918 File Offset: 0x0002AB18
		public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector3> normals, List<Vector4> tangents, List<int> indicies)
		{
			CanvasRenderer.CreateUIVertexStreamInternal(verts, positions, colors, uv0S, uv1S, normals, tangents, indicies);
		}

		// Token: 0x060026BD RID: 9917
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object normals, object tangents, object indicies);

		// Token: 0x060026BE RID: 9918 RVA: 0x0002C92C File Offset: 0x0002AB2C
		public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector3> normals, List<Vector4> tangents)
		{
			CanvasRenderer.SplitUIVertexStreamsInternal(verts, positions, colors, uv0S, uv1S, normals, tangents);
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x060026BF RID: 9919
		public extern int relativeDepth { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x060026C0 RID: 9920
		// (set) Token: 0x060026C1 RID: 9921
		public extern bool cull { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x060026C2 RID: 9922
		public extern int absoluteDepth { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x060026C3 RID: 9923
		public extern bool hasMoved { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
